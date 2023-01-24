Imports DevExpress.XtraCharts
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.Utils
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraPrinting
Imports System.Deployment.Application
Imports System.Reflection
Public Class FrmKpiEmbarques
    Public Dia As New DXMenuItem()
    Public ds As New DataSet
    Public ds2 As New DataSet
    Public forma As FrmMenuPrincipal
    Public fechainicio As String
    Public fechafin As String
    Dim tablaGlobalOrdenesEmbarcadas As DataTable
    Dim tablaGlobalOrdenesEmbarcadasPromedio As DataTable
    Dim tablaGlobalOrdenesEmbarcadasGeneral As DataTable
    Private formCount As Integer = 0

    Private Sub FrmKpiEmbarques_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dias = 7
        'LabelControl16.Visible = False
        'LabelControl4.Visible = False
        'LabelControl10.Visible = False
        'LabelControl12.Visible = False
        'LabelControl14.Visible = False
        'LblPorcentajeOrdenesTotal.Visible = False
        'LblPorcentajeIncompletoTotal.Visible = False
        'LblPorcentajeLiberadasTotal.Visible = False
        'LblPorcentajeSurtidasTotal.Visible = False
        'LblPorcentajeValidadasTotal.Visible = False
        dtpFechaInicio.EditValue = Date.Parse(DateAdd(DateInterval.Day, -7, Today))
        dtpFechaFin.EditValue = Date.Parse(Today)
        llenarGraficaOrdenesCompletasEmbarcadas(Date.Parse(Today), Date.Parse(Today), dias)
        ResultadoLista6("", Date.Parse(Today), Date.Parse(Today), dias)

        ResultadoLista(Date.Parse(Today), Date.Parse(Today), dias)
        ResultadoListaOrdSurtidasEmbarcadas(Date.Parse(Today), Date.Parse(Today), dias)

        llenarGraficaAlmacenamientoDashbord(Date.Parse(Today), Date.Parse(Today), dias)
        CrearGrafica(1, 1)
    End Sub
    Private Sub llenarGraficaAlmacenamientoDashbord(prmBusqueda2 As Date, prmBusqueda3 As Date, dias As String)

        Try
            Dim objKPI As New ClsKPIEMB

            Dim resultado = objKPI.KPIOrdenesXusuario(prmBusqueda2, prmBusqueda3, dias, My.Settings.Estacion, DatosTemporales.Usuario)
            If Not resultado.Estado Then
                XtraMessageBox.Show(resultado.Texto, "AXC")
                Return
            End If

            Dim tablaDistintosAlmacenes = resultado.Tablas.Tables(0)

            llenarGraficasAlmacenamientoPestañaAlmacenamiento(tablaDistintosAlmacenes)


        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try

    End Sub
    Private Sub llenarGraficasAlmacenamientoPestañaAlmacenamiento(ByVal tablaDistintosAlmacenes As DataTable)
        Try


            ChartControl5.Titles.Clear()
            ChartControl5.Series.Clear()

            ChartControl5.DataSource = tablaDistintosAlmacenes
            If tablaDistintosAlmacenes.Rows.Count > 0 Then
                Dim series() As Series
                ReDim series(tablaDistintosAlmacenes.Rows.Count - 1)
                Dim contador = 0
                For Each rowAlm As DataRow In tablaDistintosAlmacenes.Rows
                    series(contador) = New Series(rowAlm.Item("Fecha"), ViewType.Line)

                    Dim almacen = rowAlm.Item("Fecha")
                    For Each rowOcupados As DataRow In tablaDistintosAlmacenes.Rows
                        If rowOcupados.Item("Fecha") = almacen Then
                            series(contador).Points.Add(New SeriesPoint(rowOcupados.Item("Fecha"), rowOcupados.Item("Órdenes embarcadas")))
                        End If

                    Next
                    ChartControl5.Series.Add(series(contador))


                    CType(series(contador).View, LineSeriesView).MarkerVisibility = DevExpress.Utils.DefaultBoolean.True
                    CType(series(contador).View, LineSeriesView).LineMarkerOptions.Size = 10
                    CType(series(contador).View, LineSeriesView).LineMarkerOptions.Kind = MarkerKind.Circle
                    CType(series(contador).View, LineSeriesView).LineStyle.DashStyle = DashStyle.Dash
                    contador += 1
                Next

                ' Add a title to the chart and hide the legend.
                Dim chartTitle1 As New ChartTitle()
                chartTitle1.Text = "Total de órdenes embarcadas por día"
                ChartControl5.Titles.Add(chartTitle1)
                ChartControl5.Legend.Visible = False


                'Cast the chart's diagram to the XYDiagram type, to access its axes.
                Dim diagram As XYDiagram = CType(ChartControl5.Diagram, XYDiagram)


                diagram.EnableAxisXScrolling = True
                diagram.EnableAxisXZooming = True

                diagram.EnableAxisYScrolling = True
                diagram.EnableAxisYZooming = True


            End If



        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub
    Private Sub llenar(ByVal dias As String)


        llenarGraficaOrdenesCompletasEmbarcadas(Date.Parse(Today), Date.Parse(Today), dias)
        ResultadoLista6("", Date.Parse(Today), Date.Parse(Today), dias)
        ResultadoLista(Date.Parse(Today), Date.Parse(Today), dias)
        ResultadoListaOrdSurtidasEmbarcadas(Date.Parse(Today), Date.Parse(Today), dias)
    End Sub

    Private Sub OnEditValueChanged(ByVal sender As System.Object, ByVal e As EventArgs)
        Dim item As New DXMenuItem()
        item = sender
        Dia = sender
        llenar(item.Tag)
    End Sub
    Private Sub ResultadoListaOrdSurtidasEmbarcadas(prmBusqueda2 As Date, prmBusqueda3 As Date, dias As String)
        Try
            Dim pResultado As New CResultado
            Dim Cls As New ClsKPIEMB
            Dim dt As New DataTable

            Cursor.Current = Cursors.WaitCursor
            pResultado = Cls.ResultadoListaOrdSurtidasEmbarcadas(prmBusqueda2, prmBusqueda3, dias, My.Settings.Estacion, DatosTemporales.Usuario)
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

            ChartControl2.DataSource = dt
            '''GRAFICA PIES ChartControl3 
            Dim series1 As New Series("Órdenes Embarque", ViewType.Pie)
            ' Populate the series with points.
            ChartControl2.Series.Clear()
            ChartControl2.Titles.Clear()
            series1.Points.Add(New SeriesPoint("PorcentajeÓrdenesEmbarcadasCompletas", dt.Rows(0).Item("PorcentajeÓrdenesEmbarcadasCompletas")))
            series1.Points.Add(New SeriesPoint("PorcentajeÓrdenesIncompletas", dt.Rows(0).Item("PorcentajeÓrdenesIncompletas")))


            Dim totalporcentajeordenescompletas As String = dt.Rows(0).Item("ÓrdenesEmbarcadas") - 1
            Dim totalporcentajeordenesincompletas As String = dt.Rows(0).Item("ÓrdenesEmbarcadasInc")
            Dim porcentajeordenescompletas As String = dt.Rows(0).Item("PorcentajeÓrdenesEmbarcadasCompletas")
            Dim porcentajeordenesincompletas As String = dt.Rows(0).Item("PorcentajeÓrdenesIncompletas")


            Lblporcentajeembcom.Text = "#" + totalporcentajeordenescompletas


            totalporcentajeordenesincompletas = dt.Rows(0).Item("ÓrdenesEmbarcadasInc") - dt.Rows(0).Item("ÓrdenesEmbarcadas")
            Lblporcentajesurtidascom.Text = "# 0" 'totalporcentajeordenesincompletas
            Dim chartTitle1 As New ChartTitle()
            chartTitle1.Text = "Órdenes embarcardas con la cantidad solicitada"
            ChartControl2.Titles.Add(chartTitle1)
            ' Add the series to the chart.
            ChartControl2.Series.Add(series1)
            ' Adjust the value numeric options of the series.
            series1.PointOptions.ValueNumericOptions.Format = NumericFormat.Percent
            series1.PointOptions.ValueNumericOptions.Precision = 2
            ' Adjust the view-type-specific options of the series.
            CType(series1.View, PieSeriesView).ExplodedPoints.Add(series1.Points(0))
            'Dim chartTitle1 As New ChartTitle()
            'chartTitle1.Text = "Porcentaje de órdenes"
            'ChartControl3.Titles.Add(chartTitle1)
            ChartControl2.Legend.Visible = True
            ' Add the chart to the form.
            ChartControl2.Dock = DockStyle.None
            GridControl1.DataSource = tablaDettalleEmbarcadas
            GridView1.BestFitColumns()



            ChartControl3.DataSource = dt
            '''GRAFICA PIES ChartControl3 
            Dim series2 As New Series("Órdenes Embarque", ViewType.Pie)
            ' Populate the series with points.
            ChartControl3.Series.Clear()
            ChartControl3.Titles.Clear()
            series2.Points.Add(New SeriesPoint("PorcentajeÓrdenesEmbarcadasCompletas", dt.Rows(0).Item("PorcentajeÓrdenesEmbarcadasCompletas")))
            series2.Points.Add(New SeriesPoint("PorcentajeÓrdenesIncompletas", dt.Rows(0).Item("PorcentajeÓrdenesIncompletas")))

            LabelControl66.Text = "#" + totalporcentajeordenescompletas
            LabelControl67.Text = "# 0"



            Lblporcentajeembcom.Text = "#" + totalporcentajeordenescompletas
            LblPorcentajeOrdenesTotal.Text = "#" + totalporcentajeordenescompletas
            LblPorcentajeOrdenesTotal2.Text = "#" + totalporcentajeordenescompletas
            LabelControl66.Text = "#" + totalporcentajeordenescompletas

            totalporcentajeordenesincompletas = dt.Rows(0).Item("ÓrdenesEmbarcadasInc") - dt.Rows(0).Item("ÓrdenesEmbarcadas")
            Lblporcentajesurtidascom.Text = "# 0" 'totalporcentajeordenesincompletas

            ' Add the series to the chart.
            ChartControl3.Series.Add(series2)
            ' Adjust the value numeric options of the series.
            series2.PointOptions.ValueNumericOptions.Format = NumericFormat.Percent
            series2.PointOptions.ValueNumericOptions.Precision = 2
            ' Adjust the view-type-specific options of the series.
            CType(series2.View, PieSeriesView).ExplodedPoints.Add(series2.Points(0))
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

    Private Sub llenarGraficaOrdenesCompletasEmbarcadas(prmBusqueda2 As Date, prmBusqueda3 As Date, dias As String)
        Try
            Dim objKPI As New ClsKPIEMB
            Dim resultado = objKPI.KPIOrdenesCompletasEmbarcadas(prmBusqueda2, prmBusqueda3, dias, My.Settings.Estacion, DatosTemporales.Usuario)
            If Not resultado.Estado Then
                XtraMessageBox.Show(resultado.Texto, "AXC")
                Return
            End If
            Dim tablaPromedio = resultado.Tablas.Tables(1)
            Dim tablaGeneral = resultado.Tablas.Tables(2)
            Dim tablaGeneral1 = resultado.Tablas.Tables(3)
            If tablaPromedio.Rows.Count > 0 And tablaGeneral.Rows.Count > 0 Then
                llenarTotalEmbarquesUsuario(tablaPromedio, tablaGeneral, tablaGeneral1, "")
            Else
            End If
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub
    Private Sub ResultadoLista6(prmBusqueda As String, prmBusqueda2 As Date, prmBusqueda3 As Date, dias As String)
        Try
            Dim pResultado As New CResultado
            Dim Cls As New ClsKPIEMB
            Dim dt As New DataTable
            Cursor.Current = Cursors.WaitCursor
            pResultado = Cls.TiempoSurtido(prmBusqueda, prmBusqueda2, prmBusqueda3, dias, My.Settings.Estacion, DatosTemporales.Usuario)
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
            DigitalGauge1.Text = IIf(IsDBNull(tablaPromedioTodo.Rows(0).Item("Dias")), 0, tablaPromedioTodo.Rows(0).Item("Dias"))
            DigitalGauge3.Text = IIf(IsDBNull(tablaPromedioTodo.Rows(0).Item("Horas")), 0, tablaPromedioTodo.Rows(0).Item("Horas"))
            DigitalGauge2.Text = IIf(IsDBNull(tablaPromedioTodo.Rows(0).Item("Minutos")), 0, tablaPromedioTodo.Rows(0).Item("Minutos"))


            Gdiaspallet.Text = IIf(IsDBNull(tablaDetallePallet.Rows(0).Item("Dias")), 0, tablaDetallePallet.Rows(0).Item("Dias"))
            Ghoraspallet.Text = IIf(IsDBNull(tablaDetallePallet.Rows(0).Item("Horas")), 0, tablaDetallePallet.Rows(0).Item("Horas"))
            Gminutospallets.Text = IIf(IsDBNull(tablaDetallePallet.Rows(0).Item("Minutos")), 0, tablaDetallePallet.Rows(0).Item("Minutos"))
            Gdiaspicking.Text = IIf(IsDBNull(tablaPromedioDetalle.Rows(0).Item("Dias")), 0, tablaPromedioDetalle.Rows(0).Item("Dias"))
            Ghoraspicking.Text = IIf(IsDBNull(tablaPromedioDetalle.Rows(0).Item("Horas")), 0, tablaPromedioDetalle.Rows(0).Item("Horas"))
            Gminutospicking.Text = IIf(IsDBNull(tablaPromedioDetalle.Rows(0).Item("Minutos")), 0, tablaPromedioDetalle.Rows(0).Item("Minutos"))

            GridControl2.DataSource = pResultado.Tablas.Tables(5)
            GridView5.BestFitColumns()


            ChartControl50.Titles.Clear()
            ChartControl50.Series.Clear()
            ChartControl50.DataSource = tablaCantidadOrdenes
            ChartControl50.Titles.Add(New ChartTitle() With {.Text = "Cantidad de órdenes surtidas "})
            ChartControl50.Legend.Title.Text = ""
            ChartControl50.SeriesDataMember = "Tipo"
            ChartControl50.SeriesTemplate.ValueDataMembers.AddRange(New String() {"Cantidad"})
            ChartControl50.SeriesTemplate.ArgumentDataMember = "Tipo"
            ChartControl50.RuntimeHitTesting = True
            Dim view2 As SideBySideBarSeriesView = TryCast(ChartControl50.SeriesTemplate.View, SideBySideBarSeriesView)
            Dim diagram2 As XYDiagram = CType(ChartControl50.Diagram, XYDiagram)
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
    Private Sub ResultadoLista(prmBusqueda2 As Date, prmBusqueda3 As Date, dias As String)
        Try
            Dim pResultado As New CResultado
            Dim Cls As New ClsKPIEMB
            Dim dt As New DataTable
            Dim dt2 As New DataTable
            Dim dt3 As New DataTable
            Cursor.Current = Cursors.WaitCursor
            pResultado = Cls.ResultadoListaOrdenesCompletasEmbES(prmBusqueda2, prmBusqueda3, dias, My.Settings.Estacion, DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default
            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                Return
            End If
            Dim ds As New DataSet
            ds = pResultado.Tablas
            ds2 = pResultado.Tablas
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




            Nordenesatiempo2.Text = dt.Rows(0).Item("TotalembarquesaTiempo")




            Nordenesadespiempo.Text = dt.Rows(0).Item("OrdenesRetrazadas")
            Nordenesadespiempo2.Text = dt.Rows(0).Item("OrdenesRetrazadas")
            '  Nordenestotal.Text = dt.Rows(0).Item("Totalembarques")
            Lblporcentajejeat.Text = dt2.Rows(0).Item("PorcentajeOrdenesEmb")
            Lblporcentajejeat2.Text = dt2.Rows(0).Item("PorcentajeOrdenesEmb")
            Lblporcentajejeat.Text = Lblporcentajejeat.Text + "%"
            Lblporcentajejeat2.Text = Lblporcentajejeat.Text + "%"
            Lblporcentajejeadest.Text = dt2.Rows(0).Item("PorcentajeOrdenesRetrazadas")
            Lblporcentajejeadest2.Text = dt2.Rows(0).Item("PorcentajeOrdenesRetrazadas")
            Lblporcentajejeadest.Text = Lblporcentajejeadest.Text + "%"
            Lblporcentajejeadest2.Text = Lblporcentajejeadest.Text + "%"

            ''LblPorcentajeIncompletoTotal.Text




            'Nordenesvalidar.text
            'NordenesSurtiendo.text
            'NordenesSinregistro.text
            'Nordenesliberadas.text


            'GridControl4.DataSource = dt
            'GridView5.BestFitColumns()
            '''GRAFICA DE DONA

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message.ToString, "Error", MessageBoxButtons.OK)
        End Try
    End Sub
    Private Sub llenarTotalEmbarquesUsuario(ByVal tablaPromedio As DataTable, ByVal tablaGeneral As DataTable, ByVal tablaGeneral1 As DataTable, ByVal usuario As String)
        Try
            Dim Totalemb As String = tablaGeneral.Rows(0).Item("TotalOrdenes")
            Nordenesliberadas.Text = tablaGeneral.Rows(0).Item("LIBERADA TOTAL")
            NordenesSurtiendo.Text = tablaGeneral.Rows(0).Item("SURTIDA")
            Nordenesvalidar.Text = tablaGeneral.Rows(0).Item("VALIDADA")
            Nordenestotal.Text = tablaGeneral.Rows(0).Item("EMBARCADA")


            Nordenesliberadas2.Text = tablaGeneral.Rows(0).Item("LIBERADA TOTAL")
            NordenesSurtiendo2.Text = tablaGeneral.Rows(0).Item("SURTIDA")
            Nordenesvalidar2.Text = tablaGeneral.Rows(0).Item("VALIDADA")
            Nordenestotal2.Text = tablaGeneral.Rows(0).Item("EMBARCADA")

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



            LblPorcentajeLiberadas2.Text = tablaGeneral.Rows(0).Item("PorcentajeLiberadasTotales")
            LblPorcentajeLiberadas2.Text = LblPorcentajeLiberadas.Text + "%"
            LblPorcentajesurtidas2.Text = tablaGeneral.Rows(0).Item("PorcentajeSurtidas")
            LblPorcentajesurtidas2.Text = LblPorcentajesurtidas.Text + "%"
            LblPorcentajevalidadas2.Text = tablaGeneral.Rows(0).Item("PorcentajeValidadas")
            LblPorcentajevalidadas2.Text = LblPorcentajevalidadas.Text + "%"
            LblPorcentajeEmb2.Text = tablaGeneral.Rows(0).Item("PorcentajeEmbarcadas")
            LblPorcentajeEmb2.Text = LblPorcentajeEmb.Text + "%"

            LabelControl166.Visible = True
            LabelControl40.Visible = True
            LabelControl10.Visible = True
            LabelControl12.Visible = True
            LabelControl14.Visible = True

            LblPorcentajeOrdenesTotal2.Visible = True
            LblPorcentajeIncompletoTotal2.Visible = True
            LblPorcentajeLiberadasTotal2.Visible = True
            LblPorcentajeSurtidasTotal2.Visible = True
            LblPorcentajeValidadasTotal2.Visible = True


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



            Nordenestotal.Text = Totalemb ''Nordenestotal.Text '+ "/" + 


            LblPorcentajeIncompletoTotal.Text = "#" + incompletoN

            LblPorcentajeLiberadasTotal.Text = "#" + totalesn
            LblPorcentajeSurtidasTotal.Text = "#" + surtidasN
            LblPorcentajeValidadasTotal.Text = "#" + validadaN




            Nordenestotal2.Text = Totalemb ''Nordenestotal.Text '+ "/" + 


            LblPorcentajeIncompletoTotal2.Text = "#" + incompletoN

            LblPorcentajeLiberadasTotal2.Text = "#" + totalesn
            LblPorcentajeSurtidasTotal2.Text = "#" + surtidasN
            LblPorcentajeValidadasTotal2.Text = "#" + validadaN
            LblPorcentajeOrdenesTotal2.Text = "#" + embarcadaN








            Dim series1 As New Series("Órdenes de embarcadas", ViewType.Pie)

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
            chartTitle1.Text = "Órdenes embarcadas "
            ChartOrdenesemb.Titles.Add(chartTitle1)
            ChartOrdenesemb.Legend.Visible = False

            ' Add the chart to the form.
            ChartOrdenesemb.Dock = DockStyle.None


            Dim series2 As New Series("Órdenes de embarcadas", ViewType.Pie)

            ' Populate the series with points.
            ChartControl1.Series.Clear()
            ChartControl1.Titles.Clear()

            series2.Points.Add(New SeriesPoint("Embarcadas", tablaPromedio.Rows(0).Item("PorcentajeEmbarcadas")))
            series2.Points.Add(New SeriesPoint("Incompletas", tablaPromedio.Rows(0).Item("PorcentajeIncompletas")))

            ' Add the series to the chart.
            ChartControl1.Series.Add(series2)

            ' Adjust the value numeric options of the series.
            series2.PointOptions.ValueNumericOptions.Format = NumericFormat.Percent
            series2.PointOptions.ValueNumericOptions.Precision = 2

            ' Adjust the view-type-specific options of the series.
            CType(series2.View, PieSeriesView).ExplodedPoints.Add(series2.Points(0))


            ' Add a title to the chart and hide the legend.
            Dim chartTitle2 As New ChartTitle()
            chartTitle2.Text = "Órdenes embarcadas "
            ChartControl1.Titles.Add(chartTitle2)
            ChartControl1.Legend.Visible = False

            ' Add the chart to the form.
            ChartControl1.Dock = DockStyle.None

            DgvDetalleOrdenesCP.DataSource = tablaGeneral1
            GridView3.BestFitColumns()


        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub
    Public Sub AddNewForm(ByVal frm As Form)
        Try
            FrmMenuPrincipal.XtraTabbedMdiManager1.MdiParent = FrmMenuPrincipal
            frm.MdiParent = FrmMenuPrincipal
            frm.Show()
            Me.Close()
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub
    'Private Sub GroupControl2_CustomButtonClick(sender As Object, e As DevExpress.XtraBars.Docking2010.BaseButtonEventArgs) Handles GroupControl15.CustomButtonClick
    '    Try
    '        If e.Button.Properties.Tag = "adelante" Then
    '            FrmDetalleOrdenC.ds = ds
    '            FrmDetalleOrdenC.ds2 = ds2
    '            FrmMenuPrincipal.XtraTabbedMdiManager1.MdiParent = FrmMenuPrincipal
    '            FrmDetalleOrdenC.MdiParent = FrmMenuPrincipal
    '            FrmDetalleOrdenC.Show()
    '            Me.Close()
    '            AddNewForm(New FrmDetalleOrdenC)
    '        ElseIf e.Button.Properties.Tag = "atras" Then
    '            XtraMessageBox.Show("Esta es la pantalla de inicio", "AXC")
    '        ElseIf (e.Button.Properties.Tag = "Calendario") Then
    '            Dim dxPopupMenu As New DXPopupMenu
    '            Dim p7Dias As DXMenuItem = New DXMenuItem("7 días", AddressOf OnEditValueChanged)
    '            p7Dias.Tag = 7
    '            Dim p15Dias As DXMenuItem = New DXMenuItem("15 días", AddressOf OnEditValueChanged)
    '            p15Dias.Tag = 15
    '            Dim p21Dias As DXMenuItem = New DXMenuItem("21 días", AddressOf OnEditValueChanged)
    '            p21Dias.Tag = 21
    '            Dim p31Dias As DXMenuItem = New DXMenuItem("31 días", AddressOf OnEditValueChanged)
    '            p31Dias.Tag = 31
    '            dxPopupMenu.Items.Add(p7Dias)
    '            dxPopupMenu.Items.Add(p15Dias)
    '            dxPopupMenu.Items.Add(p21Dias)
    '            dxPopupMenu.Items.Add(p31Dias)
    '            dxPopupMenu.MenuViewType = MenuViewType.Menu
    '            StandardExMenuManager.Default.ShowPopupMenu(dxPopupMenu, Me, GroupControl15.PointToClient(System.Windows.Forms.Control.MousePosition))
    '        End If
    '    Catch ex As Exception
    '        XtraMessageBox.Show(ex.Message)
    '    End Try

    'End Sub
    Private Sub CambiarLabel()
        If NavigationFrame1.SelectedPageIndex = 0 Then
            LabelPrincipal.Text = "Resumen"

        ElseIf NavigationFrame1.SelectedPageIndex = 1 Then
            LabelPrincipal.Text = "Detalle de órdenes "

        ElseIf NavigationFrame1.SelectedPageIndex = 2 Then
            LabelPrincipal.Text = "Tiempo promedio de surtido"
        ElseIf NavigationFrame1.SelectedPageIndex = 3 Then

            LabelPrincipal.Text = "Órdenes surtidas con la cantidad completa"
        ElseIf NavigationFrame1.SelectedPageIndex = 4 Then
            LabelPrincipal.Text = "Balance de carga"
        End If
    End Sub
    Private Sub SimpleButton9_Click(sender As Object, e As EventArgs) Handles SimpleButton9.Click

        NavigationFrame1.SelectPrevPage()
        CambiarLabel()

    End Sub

    Public Sub SimpleButton8_Click(sender As Object, e As EventArgs) Handles SimpleButton8.Click
        'FrmDetalleOrdenC.ds = ds
        'FrmDetalleOrdenC.ds2 = ds2
        'FrmMenuPrincipal.XtraTabbedMdiManager1.MdiParent = FrmMenuPrincipal
        'FrmDetalleOrdenC.MdiParent = FrmMenuPrincipal
        'FrmDetalleOrdenC.Show()
        ''AddHandler FrmDetalleOrdenC.Load, AddressOf cierra
        'If dtpFechaFin.EditValue <> dtpFechaInicio.EditValue Then
        '    cierra()
        'Else
        '    cierra()
        'End If

        NavigationFrame1.SelectNextPage()
        CambiarLabel()



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
        llenarGraficaOrdenesCompletasEmbarcadas(fecha, fecha2, 0)
        ResultadoLista6("", fecha, fecha2, 0)
        ResultadoLista(fecha, fecha2, 0)
        ResultadoListaOrdSurtidasEmbarcadas(fecha, fecha2, 0)
        llenarGraficaAlmacenamientoDashbord(fecha, Date.Parse(Today), 0)
        CrearGrafica(1)

    End Sub
    Public Sub cierra()
        Me.Close()
    End Sub

#Region "BALANCE DE CARGAS"
    Private Function CrearGrafica(prmtipo As Integer, Optional prmFecha As Integer = 0)
        Try
            Dim dt As New DataTable

            If prmFecha = 1 Then
                dtpFechaInicio.DateTime = DateTime.Now.AddDays(-7)
                '' dtpFechaFin.DateTime = DateTime.Now.AddDays(-7)
            End If
            dt = ConsultaTablaBalance(prmtipo)
            ChartBalance.Series.Clear()
            Dim Series1 As Series

            Dim miView As DataView = New DataView(dt)
            For x = 0 To miView.Count - 1
                Dim nSer As Series = ChartBalance.Series(miView(x)("Posicion"))

                If nSer Is Nothing Then
                    Series1 = New Series(miView(x)("Posicion"), ViewType.StackedBar)
                    ChartBalance.Series.Add(Series1)
                    nSer = ChartBalance.Series(miView(x)("Posicion"))
                End If

                Dim sp As New SeriesPoint(miView(x)("Rack"), miView(x)("No"))
                If prmtipo = 1 Then
                    If miView(x)("Estatus") >= 10 Then
                        sp.Color = Color.Red
                    ElseIf miView(x)("Estatus") < 10 And miView(x)("Estatus") > 5 Then
                        sp.Color = Color.DarkOrange
                    ElseIf miView(x)("Estatus") <= 5 And miView(x)("Estatus") > 3 Then
                        sp.Color = Color.Gold
                    ElseIf miView(x)("Estatus") < 0 Then
                        sp.Color = Color.Black
                    Else
                        sp.Color = Color.Blue
                    End If

                Else
                    If miView(x)("Estatus") >= 100 Then
                        sp.Color = Color.Red
                    ElseIf miView(x)("Estatus") < 100 And miView(x)("Estatus") > 50 Then
                        sp.Color = Color.DarkOrange
                    ElseIf miView(x)("Estatus") <= 50 And miView(x)("Estatus") > 30 Then
                        sp.Color = Color.Gold
                    ElseIf miView(x)("Estatus") < 0 Then
                        sp.Color = Color.Black
                    Else
                        sp.Color = Color.Blue
                    End If
                End If

                nSer.LabelsVisibility = DevExpress.Utils.DefaultBoolean.False
                nSer.Points.Add(sp)

            Next

            If prmtipo = 1 Then
                lblinfo1.Text = "Mayor a 10 partidas surtidas"
                lblinfo2.Text = "Entre 6 y 10 partidas surtidas"
                lblinfo3.Text = "Entre 3 y 5 partidas surtidas"
                lblinfo4.Text = "Posicion deshabilitada"

            Else
                lblinfo1.Text = "Mayor a 100 artículos (Unidades) surtidas"
                lblinfo2.Text = "Entre 51 y 100 artículos (Unidades) surtidas"
                lblinfo3.Text = "Entre 30 y 50 artículos (Unidades) surtidas"
                lblinfo4.Text = "Posicion deshabilitada"
            End If
            For Each s As Series In ChartBalance.Series
                Dim viewS As StackedBarSeriesView = CType(s.View, StackedBarSeriesView)
                viewS.BarWidth = 0.6
            Next

            Dim diagram As XYDiagram = CType(ChartBalance.Diagram, XYDiagram)
            diagram.AxisX.Tickmarks.MinorVisible = False
            diagram.EnableAxisXScrolling = True
            diagram.EnableAxisYScrolling = True
            diagram.EnableAxisXZooming = True
            diagram.EnableAxisYZooming = True

            ChartBalance.Legend.MarkerMode = LegendMarkerMode.CheckBoxAndMarker
            ChartBalance.Legend.AlignmentHorizontal = LegendAlignmentHorizontal.Center
            ChartBalance.Legend.AlignmentVertical = LegendAlignmentVertical.TopOutside

        Catch ex As Exception
            XtraMessageBox.Show("Error: " + ex.Message, "AXC")
        End Try
    End Function

    Public Function ConsultaTablaBalance(prmDato As Integer) As DataTable
        Try
            Dim pResultado As New CResultado
            Dim pOC As New COrdenCompraR
            Dim dt As DataTable = New DataTable

            Cursor.Current = Cursors.WaitCursor
            pResultado = ConsultaBalance(prmDato)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                MsgBox(pResultado.Texto)
                Return Nothing
            End If

            dt = pResultado.Tabla

            Return dt
        Catch ex As Exception
            Cursor.Current = Cursors.Default
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function ConsultaBalance(prmTipo As Integer) As CResultado
        Dim pRespuesta As New CResultado
        Dim dt As DataTable
        Dim ds As DataSet
        Try
            Dim db As New CAccesoDatos
            Dim pResultado As CResultado

            Dim dRec As New Date
            Dim dRet As New Date

            dRec = Date.Parse(dtpFechaInicio.EditValue.ToString)
            dRet = Date.Parse(dtpFechaFin.EditValue.ToString)


            If prmTipo = 1 Then 'partidas por Estacion
                pResultado = db.SPToDataSet("spQryBalancePorPartidas", dRec.ToString("yyyyMMdd"), dRet.ToString("yyyyMMdd"))
            ElseIf prmTipo = 2 Then 'partidas por pasillos
                pResultado = db.SPToDataSet("spQryBalancePorArticulos", dRec.ToString("yyyyMMdd"), dRet.ToString("yyyyMMdd"))
            ElseIf prmTipo = 3 Then 'Artículos por pasillo
                pResultado = db.SPToDataSet("spQryBalancePorPasillos", dRec.ToString("yyyyMMdd"), dRet.ToString("yyyyMMdd"))
            Else
                pResultado = db.SPToDataSet("spQryBalancePorPartidas", dRec.ToString("yyyyMMdd"), dRet.ToString("yyyyMMdd"))
            End If

            If pResultado.Estado Then
                ds = pResultado.Resultado

                For Each dr As DataRow In ds.Tables(0).Rows

                    Select Case dr("Estado").ToString
                        Case "OK"
                            dt = ds.Tables(1).Copy

                            pRespuesta.Estado = True
                            pRespuesta.Texto = ""
                            pRespuesta.Tabla = dt
                            dgvDetalleBalance.DataSource = Nothing
                            dgvDetalleBalance.DataSource = ds.Tables(2).Copy

                            GridViewBalance.BestFitColumns()
                        Case "ER"
                            dgvDetalleBalance.DataSource = Nothing
                            pRespuesta.Estado = False
                            pRespuesta.Texto = dr("Texto").ToString

                        Case Else
                            pRespuesta.Estado = True
                            pRespuesta.Texto = "No se pudo procesar la orden"
                            pRespuesta.Resultado = Nothing
                    End Select
                Next
            Else
                pRespuesta.Estado = False
                pRespuesta.Texto = pResultado.Texto
            End If

            Return pRespuesta
        Catch ex As Exception

            pRespuesta.Estado = False
            pRespuesta.Texto = "Error al obtener OC [SP1]" + ex.Message

            Return pRespuesta
        End Try
    End Function

    Private Sub ChartBalance_Zoom(sender As Object, e As ChartZoomEventArgs) Handles ChartBalance.Zoom
        Try
            Dim chart As ChartControl = CType(sender, ChartControl)
            Dim diagram As XYDiagram = CType(chart.Diagram, XYDiagram)

            If (Convert.ToDouble(e.NewXRange.MaxValue) - Convert.ToDouble(e.NewXRange.MinValue)) < 6 Then
                For Each s As Series In ChartBalance.Series
                    s.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[True]
                    s.Label.TextPattern = "{S}"
                    CType(s.Label, BarSeriesLabel).Position = BarSeriesLabelPosition.Center
                Next
            Else
                For Each s As Series In ChartBalance.Series
                    s.LabelsVisibility = DevExpress.Utils.DefaultBoolean.False
                Next
            End If
        Catch ex As Exception
            XtraMessageBox.Show("Error: " + ex.Message, "AXC")
        End Try


    End Sub
    Private Sub rdpartidas_Click(sender As Object, e As EventArgs) Handles rdpartidas.Click
        Try
            If rdpartidas.Checked Then

                rdarticulos.Checked = False
                CrearGrafica(1)
            Else
                rdpartidas.Checked = True
                CrearGrafica(2)
            End If
        Catch ex As Exception
            XtraMessageBox.Show("Error: " + ex.Message, "AXC")

        End Try
    End Sub

    Private Sub rdarticulos_Click(sender As Object, e As EventArgs) Handles rdarticulos.Click
        Try
            If rdarticulos.Checked Then

                rdpartidas.Checked = False
                CrearGrafica(2)
            Else
                rdpartidas.Checked = True
                CrearGrafica(1)
            End If
        Catch ex As Exception
            XtraMessageBox.Show("Error: " + ex.Message, "AXC")

        End Try
    End Sub
#End Region

End Class