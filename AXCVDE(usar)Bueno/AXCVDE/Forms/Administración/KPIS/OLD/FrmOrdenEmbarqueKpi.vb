Imports DevExpress.XtraCharts
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Base
Public Class FrmOrdenEmbarqueKpi

    Public fechainicio As String
    Public fechafin As String
    Dim tablaGlobalOrdenesEmbarcadas As DataTable
    Dim tablaGlobalOrdenesEmbarcadasPromedio As DataTable
    Dim tablaGlobalOrdenesEmbarcadasGeneral As DataTable
    Private Sub FrmOrdenEmbarqueKpi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LabelControl16.Visible = False
        LabelControl4.Visible = False
        LabelControl10.Visible = False
        LabelControl12.Visible = False
        LabelControl14.Visible = False
        LblPorcentajeOrdenesTotal.Visible = False
        LblPorcentajeIncompletoTotal.Visible = False
        LblPorcentajeLiberadasTotal.Visible = False
        LblPorcentajeSurtidasTotal.Visible = False
        LblPorcentajeValidadasTotal.Visible = False
        dtpFechaInicio.EditValue = Today
        dtpFechaFin.EditValue = Today
        Dim prmBusqueda2 As String
        Dim prmBusqueda3 As String
        If String.IsNullOrEmpty(dtpFechaInicio.Text) Then
            prmBusqueda2 = "@"
        Else
            prmBusqueda2 = dtpFechaInicio.Text
        End If
        Dim fecha As New Date
        fecha = Date.Parse(dtpFechaInicio.EditValue.ToString)
        'ResultadoLista(prmBusqueda2, fecha)
        If String.IsNullOrEmpty(dtpFechaFin.Text) Then
            prmBusqueda3 = "@"
        Else
            prmBusqueda3 = dtpFechaFin.Text
        End If
        Dim fecha2 As New Date
        fecha2 = Date.Parse(dtpFechaFin.EditValue.ToString)
        llenarGraficaOrdenesCompletasEmbarcadas()
        ResultadoListaOrdSurtidasEmbarcadas(fecha, fecha2)
        ResultadoLista6("", fecha, fecha2)
        ResultadoLista(fecha, fecha2)
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Dim prmBusqueda2 As String
        Dim prmBusqueda3 As String
        If String.IsNullOrEmpty(dtpFechaInicio.Text) Then
            prmBusqueda2 = "@"
        Else
            prmBusqueda2 = dtpFechaInicio.Text
        End If
        Dim fecha As New Date
        fecha = Date.Parse(dtpFechaInicio.EditValue.ToString)
        'ResultadoLista(prmBusqueda2, fecha)
        If String.IsNullOrEmpty(dtpFechaFin.Text) Then
            prmBusqueda3 = "@"
        Else
            prmBusqueda3 = dtpFechaFin.Text
        End If
        Dim fecha2 As New Date
        fecha2 = Date.Parse(dtpFechaFin.EditValue.ToString)
        llenarGraficaOrdenesCompletasEmbarcadas()
        ResultadoListaOrdSurtidasEmbarcadas(fecha, fecha2)
        ResultadoLista6("", fecha, fecha2)
        ResultadoLista(fecha, fecha2)
    End Sub

    Private Sub llenarGraficaOrdenesCompletasEmbarcadas()
        Try
            Dim objKPI As New clsKPI
            Dim resultado = objKPI.KPIOrdenesCompletasEmbarcadas(IIf(String.IsNullOrEmpty(dtpFechaInicio.Text), Date.Parse(Today), dtpFechaInicio.Text), IIf(String.IsNullOrEmpty(dtpFechaFin.Text), Date.Parse(Today), dtpFechaFin.Text), My.Settings.Estacion, DatosTemporales.Usuario)
            If Not resultado.Estado Then
                XtraMessageBox.Show(resultado.Texto, "AXC")
                Return
            End If
            Dim tablaPromedio = resultado.Tablas.Tables(1)
            Dim tablaGeneral = resultado.Tablas.Tables(2)
            tablaGlobalOrdenesEmbarcadasPromedio = tablaPromedio
            tablaGlobalOrdenesEmbarcadasGeneral = tablaPromedio
            If tablaPromedio.Rows.Count > 0 Then
                Dim row As DataRow = tablaPromedio.Rows(0)
                If IsDBNull(row.Item("PorcentajeEmbarcadas")) Then
                Else
                    ' ArcScaleComponent4.Value = row.Item("PorcentajeEmbarcadas")
                    '  LabelComponent4.Text = row.Item("PorcentajeEmbarcadas").ToString
                End If
            End If
            'CARGA GAUGE PAGINA EMBARCADAS
            If tablaPromedio.Rows.Count > 0 Then
                Dim row As DataRow = tablaPromedio.Rows(0)
                If IsDBNull(row.Item("PorcentajeEmbarcadas")) Then
                Else
                    '    ArcScaleComponent9.Value = row.Item("PorcentajeEmbarcadas")
                    ' LabelComponent17.Text = row.Item("PorcentajeEmbarcadas").ToString
                End If
            End If
            If tablaPromedio.Rows.Count > 0 And tablaGeneral.Rows.Count > 0 Then
                llenarGraficasPestañaEmbarques(tablaPromedio, tablaGeneral)
            Else
            End If
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub
    Private Sub ResultadoLista6(prmBusqueda As String, prmBusqueda2 As Date, prmBusqueda3 As Date)
        Try
            Dim pResultado As New CResultado
            Dim Cls As New clsKPI
            Dim dt As New DataTable
            Cursor.Current = Cursors.WaitCursor
            pResultado = Cls.TiempoSurtido(prmBusqueda, prmBusqueda2, prmBusqueda3, My.Settings.Estacion, DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default
            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                'GridControl3.DataSource = Nothing
                Return
            End If
            Dim ds As New DataSet
            dt = pResultado.Tabla
            ds.Tables.Add(dt)
            Dim tablaPromedioTodo As DataTable
            Dim tablaPromedioDetalle As DataTable
            Dim tablaCantidadOrdenes As DataTable
            Dim tablaDetallePallet As DataTable
            ' Dim tablaMym As DataTable
            tablaPromedioTodo = pResultado.Tablas.Tables(1)
            tablaDetallePallet = pResultado.Tablas.Tables(2)
            tablaPromedioDetalle = pResultado.Tablas.Tables(3)
            tablaCantidadOrdenes = pResultado.Tablas.Tables(4)
            'tablaDetallePallet = pResultado.Tablas.Tables(2)
            'tablaMym = pResultado.Tablas.Tables(2)
            If dt.Rows.Count < 1 Then
                XtraMessageBox.Show("Sin información en el sistema", "AXC", MessageBoxButtons.OK)
                'GridControl3.DataSource = Nothing
                Return
            End If
            Gdiasmixto.Text = IIf(IsDBNull(tablaPromedioTodo.Rows(0).Item("Dias")), 0, tablaPromedioTodo.Rows(0).Item("Dias"))
            Ghorasmixto.Text = IIf(IsDBNull(tablaPromedioTodo.Rows(0).Item("Horas")), 0, tablaPromedioTodo.Rows(0).Item("Horas"))
            Gminutosmixto.Text = IIf(IsDBNull(tablaPromedioTodo.Rows(0).Item("Minutos")), 0, tablaPromedioTodo.Rows(0).Item("Minutos"))
            Gdiaspallet.Text = IIf(IsDBNull(tablaDetallePallet.Rows(0).Item("Dias")), 0, tablaDetallePallet.Rows(0).Item("Dias"))
            Ghoraspallet.Text = IIf(IsDBNull(tablaDetallePallet.Rows(0).Item("Horas")), 0, tablaDetallePallet.Rows(0).Item("Horas"))
            Gminutospallets.Text = IIf(IsDBNull(tablaDetallePallet.Rows(0).Item("Minutos")), 0, tablaDetallePallet.Rows(0).Item("Minutos"))
            Gdiaspicking.Text = IIf(IsDBNull(tablaPromedioDetalle.Rows(0).Item("Dias")), 0, tablaPromedioDetalle.Rows(0).Item("Dias"))
            Ghoraspicking.Text = IIf(IsDBNull(tablaPromedioDetalle.Rows(0).Item("Horas")), 0, tablaPromedioDetalle.Rows(0).Item("Horas"))
            Gminutospicking.Text = IIf(IsDBNull(tablaPromedioDetalle.Rows(0).Item("Minutos")), 0, tablaPromedioDetalle.Rows(0).Item("Minutos"))




            ' GridControl3.DataSource = tablaDetallePallet
            'dgvViewResultado.BestFitColumns()


            ChartControl2.Titles.Clear()
            ChartControl2.Series.Clear()
            ChartControl2.DataSource = tablaCantidadOrdenes
            ChartControl2.Titles.Add(New ChartTitle() With {.Text = "Cantidad pallets"})
            ChartControl2.Legend.Title.Text = ""
            ChartControl2.SeriesDataMember = "Tipo"
            ChartControl2.SeriesTemplate.ValueDataMembers.AddRange(New String() {"Cantidad"})
            ChartControl2.SeriesTemplate.ArgumentDataMember = "Tipo"
            ChartControl2.RuntimeHitTesting = True
            Dim view2 As SideBySideBarSeriesView = TryCast(ChartControl2.SeriesTemplate.View, SideBySideBarSeriesView)
            Dim diagram2 As XYDiagram = CType(ChartControl2.Diagram, XYDiagram)
            diagram2.EnableAxisXScrolling = True
            diagram2.EnableAxisXZooming = True
            diagram2.EnableAxisYScrolling = True
            diagram2.EnableAxisYZooming = True
            view2.BarDistance = 0.5
            view2.BarDistanceFixed = 0.5
            view2.BarWidth = 3


        Catch ex As Exception
            XtraMessageBox.Show(ex.Message.ToString, "Error", MessageBoxButtons.OK)
        End Try
    End Sub
    Private Sub ResultadoLista(prmBusqueda2 As Date, prmBusqueda3 As Date)
        Try
            Dim pResultado As New CResultado
            Dim Cls As New clsKPI
            Dim dt As New DataTable
            Dim dt2 As New DataTable
            Dim dt3 As New DataTable
            Cursor.Current = Cursors.WaitCursor
            pResultado = Cls.ResultadoListaOrdenesCompletasEmbES(prmBusqueda2, prmBusqueda3, My.Settings.Estacion, DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default
            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                Return
            End If
            Dim ds As New DataSet
            ds = pResultado.Tablas
            'ds.Tables.Add(dt)
            dt = ds.Tables(0)
            dt2 = ds.Tables(1)
            dt3 = ds.Tables(2)
            'If dt.Rows.Count < 1 Then
            '    XtraMessageBox.Show("Sin información en el sistema", "AXC", MessageBoxButtons.OK)
            '    GridControl4.DataSource = Nothing
            '    Return
            'End If
            If dt3.Rows.Count < 1 Then
                XtraMessageBox.Show("Sin detalle de las ordenes", "AXC", MessageBoxButtons.OK)
            End If

            'GridView23.BestFitColumns()
            'dgvDetalle13.DataSource = dt3
            'GridView15.BestFitColumns()
            Nordenesatiempo.Text = dt.Rows(0).Item("TotalembarquesaTiempo")
            Nordenesadespiempo.Text = dt.Rows(0).Item("OrdenesRetrazadas")
            '  Nordenestotal.Text = dt.Rows(0).Item("Totalembarques")
            Lblporcentajejeat.Text = dt2.Rows(0).Item("PorcentajeOrdenesEmb")
            Lblporcentajejeat.Text = Lblporcentajejeat.Text + "%"
            Lblporcentajejeadest.Text = dt2.Rows(0).Item("PorcentajeOrdenesRetrazadas")
            Lblporcentajejeadest.Text = Lblporcentajejeadest.Text + "%"

            ''LblPorcentajeIncompletoTotal.Text




            'Nordenesvalidar.text
            'NordenesSurtiendo.text
            'NordenesSinregistro.text
            'Nordenesliberadas.text


            'GridControl4.DataSource = dt
            'GridView5.BestFitColumns()
            ''''GRAFICA DE DONA
            'Dim series1 As New Series("Doughnut Series 1", ViewType.Pie)
            '' Populate the series with points.
            'ChartControl2.Series.Clear()
            'ChartControl2.Titles.Clear()
            'series1.Points.Add(New SeriesPoint("ENVIADAS A TIEMPO", dt.Rows(0).Item("TotalembarquesaTiempo")))
            'series1.Points.Add(New SeriesPoint("ORDENES RETRAZADAS", dt.Rows(0).Item("OrdenesRetrazadas")))
            ''' series1.Points.Add(New SeriesPoint("TOTAL ENVIADAS", dt.Rows(0).Item("Totalembarques")))
            '' Add the series to the chart.
            'ChartControl2.Series.Add(series1)
            'ChartControl2.Legend.Title.Text = "ORDENES"
            'ChartControl2.Legend.MarkerMode = LegendMarkerMode.Marker
            ''ChartControl3.Legend
            '' Adjust the value numeric options of the series.
            'series1.PointOptions.ValueNumericOptions.Format = NumericFormat.Percent
            'series1.PointOptions.ValueNumericOptions.Precision = 2
            '' Add a title to the chart and hide the legend.
            'Dim chartTitle1 As New ChartTitle()
            'chartTitle1.Text = "ORDENES ENVIADAS A TIEMPO"
            'ChartControl2.Titles.Add(chartTitle1)
            'ChartControl2.Legend.Visible = False
            '' Add the chart to the form.
            'ChartControl2.Dock = DockStyle.None
            ''Rotacion de Char3d
            'ChartControl2.RuntimeRotation = True
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message.ToString, "Error", MessageBoxButtons.OK)
        End Try
    End Sub
    Private Sub llenarGraficasPestañaEmbarques(ByVal tablaPromedio As DataTable, ByVal tablaGeneral As DataTable)
        Try

            'dgvDetalle7.DataSource = tablaPromedio
            'GridView8.BestFitColumns()
            'dgvDetalle8.DataSource = tablaGeneral
            'GridView7.BestFitColumns()
            tablaGlobalOrdenesEmbarcadas = tablaGeneral

            Dim Totalemb As String = tablaGeneral.Rows(0).Item("TotalOrdenes")
            Nordenesliberadas.Text = tablaGeneral.Rows(0).Item("LIBERADA TOTAL")
            NordenesSurtiendo.Text = tablaGeneral.Rows(0).Item("SURTIDA")
            Nordenesvalidar.Text = tablaGeneral.Rows(0).Item("VALIDADA")
            Nordenestotal.Text = tablaGeneral.Rows(0).Item("EMBARCADA")

            LblPorcentajeLiberadas.Text = tablaGeneral.Rows(0).Item("PorcentajeLiberadasTotales")
            LblPorcentajeLiberadas.Text = LblPorcentajeLiberadas.Text + "%"
            LblPorcentajesurtidas.Text = tablaGeneral.Rows(0).Item("PorcentajeSurtidas")
            LblPorcentajesurtidas.Text = LblPorcentajesurtidas.Text + "%"
            LblPorcentajevalidadas.Text = tablaGeneral.Rows(0).Item("PorcentajeValidadas")
            LblPorcentajevalidadas.Text = LblPorcentajevalidadas.Text + "%"
            LblPorcentajeEmb.Text = tablaGeneral.Rows(0).Item("PorcentajeEmbarcadas")
            LblPorcentajeEmb.Text = LblPorcentajeEmb.Text + "%"

            LabelControl16.Visible = True
            LabelControl4.Visible = True
            LabelControl10.Visible = True
            LabelControl12.Visible = True
            LabelControl14.Visible = True

            LblPorcentajeOrdenesTotal.Visible = True
            LblPorcentajeIncompletoTotal.Visible = True
            LblPorcentajeLiberadasTotal.Visible = True
            LblPorcentajeSurtidasTotal.Visible = True
            LblPorcentajeValidadasTotal.Visible = True


            Dim totales As String = tablaGeneral.Rows(0).Item("PorcentajeLiberadasTotales")
            Dim totalesn As String = tablaGeneral.Rows(0).Item("LIBERADA TOTAL")

            Dim surtidas As String = tablaGeneral.Rows(0).Item("PorcentajeSurtidas")
            Dim surtidasN As String = tablaGeneral.Rows(0).Item("SURTIDA")

            Dim validada As String = tablaGeneral.Rows(0).Item("PorcentajeValidadas")
            Dim validadaN As String = tablaGeneral.Rows(0).Item("VALIDADA")

            Dim embarcada As String = tablaGeneral.Rows(0).Item("PorcentajeEmbarcadas")
            Dim embarcadaN As String = tablaGeneral.Rows(0).Item("EMBARCADA")

            Dim incompleto As String = tablaPromedio.Rows(0).Item("PorcentajeIncompletas")
            Dim incompletoN As String = tablaGeneral.Rows(0).Item("LIBERADA TOTAL") + tablaGeneral.Rows(0).Item("SURTIDA") + tablaGeneral.Rows(0).Item("VALIDADA")



            Nordenestotal.Text = Nordenestotal.Text + "/" + Totalemb


            LblPorcentajeIncompletoTotal.Text = incompleto + " %" + " /Nº" + incompletoN + "/Nº" + Totalemb

            LblPorcentajeLiberadasTotal.Text = totales + " %" + " /Nº" + totalesn + "/Nº" + Totalemb
            LblPorcentajeSurtidasTotal.Text = surtidas + " %" + " /Nº" + surtidasN
            LblPorcentajeValidadasTotal.Text = validada + " %" + " /Nº" + validadaN
            LblPorcentajeOrdenesTotal.Text = embarcada + " %" + " /Nº" + embarcadaN








            Dim series1 As New Series("Órdenes completas embarcadas", ViewType.Pie)

            ' Populate the series with points.
            ChartOrdenesemb.Series.Clear()
            ChartOrdenesemb.Titles.Clear()

            series1.Points.Add(New SeriesPoint("Embarcadas", tablaPromedio.Rows(0).Item("PorcentajeEmbarcadas")))
            series1.Points.Add(New SeriesPoint("Incompletas", tablaPromedio.Rows(0).Item("PorcentajeIncompletas")))

            ' Add the series to the chart.
            ChartOrdenesemb.Series.Add(series1)

            ' Adjust the value numeric options of the series.
            series1.PointOptions.ValueNumericOptions.Format = NumericFormat.Percent
            series1.PointOptions.ValueNumericOptions.Precision = 2

            ' Adjust the view-type-specific options of the series.
            CType(series1.View, PieSeriesView).ExplodedPoints.Add(series1.Points(0))


            ' Add a title to the chart and hide the legend.
            Dim chartTitle1 As New ChartTitle()
            chartTitle1.Text = "Órdenes completas embarcadas / incompletas"
            ChartOrdenesemb.Titles.Add(chartTitle1)
            ChartOrdenesemb.Legend.Visible = False

            ' Add the chart to the form.
            ChartOrdenesemb.Dock = DockStyle.None

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub

    Private Sub ResultadoListaOrdSurtidasEmbarcadas(prmBusqueda2 As Date, prmBusqueda3 As Date)
        Try
            Dim pResultado As New CResultado
            Dim Cls As New clsKPI
            Dim dt As New DataTable

            Cursor.Current = Cursors.WaitCursor
            pResultado = Cls.ResultadoListaOrdSurtidasEmbarcadas(prmBusqueda2, prmBusqueda3, My.Settings.Estacion, DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                Return
            End If

            dt = pResultado.Tabla
            Dim tablaDetalleSurtidas As DataTable
            Dim tablaDettalleEmbarcadas As DataTable
            Dim tablaGeneral As DataTable
            tablaDetalleSurtidas = pResultado.Tablas.Tables(2)
            tablaDettalleEmbarcadas = pResultado.Tablas.Tables(3)
            tablaGeneral = pResultado.Tablas.Tables(1)
            If dt.Rows.Count < 1 Then
                XtraMessageBox.Show("Sin información en el sistema", "AXC", MessageBoxButtons.OK)
                Return
            End If


            ''GridView2.BestFitColumns()
            ChartControl3.DataSource = dt
            '''GRAFICA PIES ChartControl3 
            Dim series1 As New Series("Órdenes Embarque", ViewType.Pie)
            ' Populate the series with points.
            ChartControl3.Series.Clear()
            ChartControl3.Titles.Clear()
            series1.Points.Add(New SeriesPoint("PorcentajeÓrdenesEmbarcadas", dt.Rows(0).Item("PorcentajeÓrdenesEmbarcadas")))
            series1.Points.Add(New SeriesPoint("PorcentajeÓrdenesNoEmbarcadas", dt.Rows(0).Item("PorcentajeÓrdenesNoEmbarcadas")))


            Dim totalporcentajeordenescompletas As String = dt.Rows(0).Item("ÓrdenesEmbarcadas")
            Dim totalporcentajeordenesincompletas As String = dt.Rows(0).Item("ÓrdenesSurtidas")
            Dim porcentajeordenescompletas As String = dt.Rows(0).Item("PorcentajeÓrdenesEmbarcadas")
            Dim porcentajeordenesincompletas As String = dt.Rows(0).Item("PorcentajeÓrdenesNoEmbarcadas")


            Lblporcentajeembcom.Text = porcentajeordenescompletas + "%" + totalporcentajeordenescompletas

            totalporcentajeordenesincompletas = dt.Rows(0).Item("ÓrdenesSurtidas") - dt.Rows(0).Item("ÓrdenesEmbarcadas")
            Lblporcentajesurtidascom.Text = porcentajeordenesincompletas + "%" + totalporcentajeordenesincompletas

            ' Add the series to the chart.
            ChartControl3.Series.Add(series1)
            ' Adjust the value numeric options of the series.
            series1.PointOptions.ValueNumericOptions.Format = NumericFormat.Percent
            series1.PointOptions.ValueNumericOptions.Precision = 2
            ' Adjust the view-type-specific options of the series.
            CType(series1.View, PieSeriesView).ExplodedPoints.Add(series1.Points(0))
            'Dim chartTitle1 As New ChartTitle()
            'chartTitle1.Text = "Porcentaje de órdenes"
            'ChartControl3.Titles.Add(chartTitle1)
            ChartControl3.Legend.Visible = True
            ' Add the chart to the form.
            ChartControl3.Dock = DockStyle.None
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message.ToString, "Error", MessageBoxButtons.OK)
        End Try
    End Sub

End Class