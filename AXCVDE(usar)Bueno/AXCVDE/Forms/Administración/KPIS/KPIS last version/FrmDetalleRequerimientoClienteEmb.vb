Imports DevExpress.XtraCharts
Imports DevExpress.XtraEditors
Imports DevExpress.Utils.Menu
Public Class FrmDetalleRequerimientoClienteEmb
    Public Dia As New DXMenuItem()
    Public ds As DataSet
    Public ds2 As DataSet
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


            ChartControl1.Titles.Clear()
            ChartControl1.Series.Clear()

            ChartControl1.DataSource = tablaDistintosAlmacenes
            If tablaDistintosAlmacenes.Rows.Count > 0 Then
                Dim series() As Series
                ReDim series(tablaDistintosAlmacenes.Rows.Count - 1)
                Dim contador = 0
                For Each rowAlm As DataRow In tablaDistintosAlmacenes.Rows
                    series(contador) = New Series(rowAlm.Item("Fecha"), ViewType.Line)

                    Dim almacen = rowAlm.Item("Fecha")
                    For Each rowOcupados As DataRow In tablaDistintosAlmacenes.Rows
                        If rowOcupados.Item("Fecha") = almacen Then
                            series(contador).Points.Add(New SeriesPoint(rowOcupados.Item("Fecha"), rowOcupados.Item("Órdenes liberadas")))
                        End If

                    Next
                    ChartControl1.Series.Add(series(contador))


                    CType(series(contador).View, LineSeriesView).MarkerVisibility = DevExpress.Utils.DefaultBoolean.True
                    CType(series(contador).View, LineSeriesView).LineMarkerOptions.Size = 10
                    CType(series(contador).View, LineSeriesView).LineMarkerOptions.Kind = MarkerKind.Circle
                    CType(series(contador).View, LineSeriesView).LineStyle.DashStyle = DashStyle.Dash
                    contador += 1
                Next

                ' Add a title to the chart and hide the legend.
                Dim chartTitle1 As New ChartTitle()
                chartTitle1.Text = "Total de órdenes liberadas por día"
                ChartControl1.Titles.Add(chartTitle1)
                ChartControl1.Legend.Visible = False


                'Cast the chart's diagram to the XYDiagram type, to access its axes.
                Dim diagram As XYDiagram = CType(ChartControl1.Diagram, XYDiagram)


                diagram.EnableAxisXScrolling = True
                diagram.EnableAxisXZooming = True

                diagram.EnableAxisYScrolling = True
                diagram.EnableAxisYZooming = True


            End If



        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub


    Private Sub FrmDetalleRequerimientoClienteEmb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim prmBusqueda2 As String
        Dim prmBusqueda3 As String
        Dim dias = 7
        dtpFechaInicio.EditValue = Date.Parse(DateAdd(DateInterval.Day, -7, Today))
        dtpFechaFin.EditValue = Date.Parse(Today)


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
        ResultadoListaOrdSurtidasEmbarcadas(fecha, fecha2, 0)
        llenarGraficaAlmacenamientoDashbord(fecha, fecha2, 0)
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
        ResultadoListaOrdSurtidasEmbarcadas(fecha, fecha2, 0)
        llenarGraficaAlmacenamientoDashbord(fecha, fecha2, 0)
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


            ''GridView2.BestFitColumns()
            ChartControl3.DataSource = dt
            '''GRAFICA PIES ChartControl3 
            Dim series1 As New Series("Órdenes Embarque", ViewType.Pie)
            ' Populate the series with points.
            ChartControl3.Series.Clear()
            ChartControl3.Titles.Clear()
            series1.Points.Add(New SeriesPoint("PorcentajeÓrdenesEmbarcadasCompletas", dt.Rows(0).Item("PorcentajeÓrdenesEmbarcadasCompletas")))
            series1.Points.Add(New SeriesPoint("PorcentajeÓrdenesIncompletas", dt.Rows(0).Item("PorcentajeÓrdenesIncompletas")))


            Dim totalporcentajeordenescompletas As String = dt.Rows(0).Item("ÓrdenesEmbarcadas")
            Dim totalporcentajeordenesincompletas As String = dt.Rows(0).Item("ÓrdenesEmbarcadasInc")
            Dim porcentajeordenescompletas As String = dt.Rows(0).Item("PorcentajeÓrdenesEmbarcadasCompletas")
            Dim porcentajeordenesincompletas As String = dt.Rows(0).Item("PorcentajeÓrdenesIncompletas")


            Lblporcentajeembcom.Text = "#" + totalporcentajeordenescompletas

            totalporcentajeordenesincompletas = dt.Rows(0).Item("ÓrdenesEmbarcadasInc") - dt.Rows(0).Item("ÓrdenesEmbarcadas")
            Lblporcentajesurtidascom.Text = "# 0" 'totalporcentajeordenesincompletas

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
            DgvDetalleOrdenesCP.DataSource = tablaDettalleEmbarcadas
            GridView3.BestFitColumns()
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message.ToString, "Error", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub SimpleButton8_Click(sender As Object, e As EventArgs) Handles SimpleButton8.Click
        FrmCantidaddesurtidos.ds = ds
        FrmCantidaddesurtidos.ds2 = ds2
        FrmMenuPrincipal.XtraTabbedMdiManager1.MdiParent = FrmMenuPrincipal
        FrmCantidaddesurtidos.MdiParent = FrmMenuPrincipal
        FrmCantidaddesurtidos.Show()
        Me.Close()
    End Sub

    Private Sub SimpleButton9_Click(sender As Object, e As EventArgs) Handles SimpleButton9.Click
        FrmDetalleOrdenC.ds = ds
        FrmDetalleOrdenC.ds2 = ds2
        FrmMenuPrincipal.XtraTabbedMdiManager1.MdiParent = FrmMenuPrincipal
        FrmDetalleOrdenC.MdiParent = FrmMenuPrincipal
        FrmDetalleOrdenC.Show()
        Me.Close()
    End Sub


End Class