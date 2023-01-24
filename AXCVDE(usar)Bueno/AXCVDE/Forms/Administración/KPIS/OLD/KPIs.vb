Imports DevExpress.XtraCharts
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Base
Public Class KPIs
    Public pClienteSeleccionada As String = ""
    Public pCliente As String
    Public pIdCliente As Int64
    Public pAccion As Integer
    Private Sub ResultadoListaOrdSurtidasEmbarcadas(prmBusqueda2 As Date, prmBusqueda3 As Date)
        Try
            Dim pResultado As New CResultado
            Dim Cls As New clsKPI
            Dim dt As New DataTable

            'pResultado = Cls.ResultadoListaEmpaques
            dt = pResultado.Tabla


            GridControl1.DataSource = Nothing



            Cursor.Current = Cursors.WaitCursor
            pResultado = Cls.ResultadoListaOrdSurtidasEmbarcadas(prmBusqueda2, prmBusqueda3, My.Settings.Estacion, DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                GridControl1.DataSource = Nothing
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
                GridControl1.DataSource = Nothing
                Return
            End If

            GridControl1.DataSource = dt
            GridView1.BestFitColumns()
            GridControl3.DataSource = tablaDetalleSurtidas
            GridView3.BestFitColumns()
            GridControl2.DataSource = tablaDettalleEmbarcadas
            GridView2.BestFitColumns()
            ChartControl1.DataSource = dt
            ChartControl2.DataSource = dt

            '''GRAFICA PIES ChartControl3 
            Dim series1 As New Series("Ordenes Embarque", ViewType.Pie)
            ' Populate the series with points.
            ChartControl1.Series.Clear()
            ChartControl1.Titles.Clear()
            series1.Points.Add(New SeriesPoint("PorcentajeOrdenesEmbarcadas", dt.Rows(0).Item("PorcentajeOrdenesEmbarcadas")))
            series1.Points.Add(New SeriesPoint("PorcentajeOrdenesNoEmbarcadas", dt.Rows(0).Item("PorcentajeOrdenesNoEmbarcadas")))
            ' Add the series to the chart.
            ChartControl1.Series.Add(series1)
            ' Adjust the value numeric options of the series.
            series1.PointOptions.ValueNumericOptions.Format = NumericFormat.Percent
            series1.PointOptions.ValueNumericOptions.Precision = 2
            ' Adjust the view-type-specific options of the series.
            CType(series1.View, PieSeriesView).ExplodedPoints.Add(series1.Points(0))
            Dim chartTitle1 As New ChartTitle()
            chartTitle1.Text = "Porcentaje Ordenes Embarcadas"
            ChartControl1.Titles.Add(chartTitle1)
            ChartControl1.Legend.Visible = True
            ' Add the chart to the form.
            ChartControl1.Dock = DockStyle.None



            '''GRAFICA PIES CHARTCONTROL 2
            Dim series2 As New Series("Partidas Embarque", ViewType.Doughnut)
            ' Populate the series with points.
            ChartControl2.Series.Clear()
            ChartControl2.Titles.Clear()
            series2.Points.Add(New SeriesPoint("PorcentajePartidasEmbarcadas", dt.Rows(0).Item("PorcentajePartidasEmbarcadas")))
            series2.Points.Add(New SeriesPoint("PorcentajePartidasNoEmbarcadas", dt.Rows(0).Item("PorcentajePartidasNoEmbarcadas")))
            ' Add the series to the chart.
            ChartControl2.Series.Add(series2)
            ' Adjust the value numeric options of the series.
            series2.PointOptions.ValueNumericOptions.Format = NumericFormat.Percent
            series2.PointOptions.ValueNumericOptions.Precision = 2

            ' Adjust the view-type-specific options of the series.
            CType(series2.View, DoughnutSeriesView).ExplodedPoints.Add(series2.Points(0))
            ' Add a title to the chart and hide the legend.
            Dim chartTitle2 As New ChartTitle()
            chartTitle2.Text = "Porcentaje Partidas Embarcadas"
            ChartControl2.Titles.Add(chartTitle2)
            ChartControl2.Legend.Visible = True

            ' Add the chart to the form.
            ChartControl2.Dock = DockStyle.None







        Catch ex As Exception
            XtraMessageBox.Show(ex.Message.ToString, "Error", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub ResultadoListaCantidadSurtidoTipos(prmBusqueda2 As Date, prmBusqueda3 As Date)
        Try
            Dim pResultado As New CResultado
            Dim Cls As New clsKPI
            Dim dt As New DataTable

            'pResultado = Cls.ResultadoListaEmpaques
            dt = pResultado.Tabla


            GridControl5.DataSource = Nothing



            Cursor.Current = Cursors.WaitCursor
            pResultado = Cls.ResultadoListaCantSurtidoTipos(prmBusqueda2, prmBusqueda3, My.Settings.Estacion, DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                GridControl5.DataSource = Nothing
                Return
            End If

            dt = pResultado.Tabla
            Dim tablaDetalletipoSurtido As DataTable


            tablaDetalletipoSurtido = pResultado.Tablas.Tables(2)


            If dt.Rows.Count < 1 Then
                XtraMessageBox.Show("Sin información en el sistema", "AXC", MessageBoxButtons.OK)
                GridControl5.DataSource = Nothing
                Return
            End If

            GridControl5.DataSource = dt
            GridView5.BestFitColumns()
            GridControl4.DataSource = tablaDetalletipoSurtido
            GridView4.BestFitColumns()

            ChartControl3.Titles.Clear()
            ChartControl3.Series.Clear()
            ChartControl3.Series.Clear()

            ChartControl3.DataSource = dt

            '''GRAFICA BARRAS

            Dim seriesL1 As Series = New Series("Ordenes Surtidas", ViewType.Bar)
            ' Add points to it.
            seriesL1.Points.Add(New SeriesPoint("Pallet", dt.Rows(0).Item("PALLET")))
            seriesL1.Points.Add(New SeriesPoint("Todo", dt.Rows(0).Item("TODO")))
            seriesL1.Points.Add(New SeriesPoint("Picking", dt.Rows(0).Item("PICKING")))
            seriesL1.Points.Add(New SeriesPoint("Producción", dt.Rows(0).Item("PRODUCCION")))



            ' Add the series to the chart.
            ChartControl3.Series.Add(seriesL1)


            'Cast the chart's diagram to the XYDiagram type, to access its axes.
            Dim diagram As XYDiagram = CType(ChartControl3.Diagram, XYDiagram)
            ' Enable the diagram's scrolling.
            'diagram.EnableAxisXScrolling = True
            'diagram.EnableAxisYScrolling = True

            'Lineas Constantes
            'Dim MargenLine As ConstantLine = New ConstantLine("Capacidad Optima: 90%", 90)
            'diagram.AxisY.ConstantLines.Add(MargenLine)
            'MargenLine.Visible = True

            ' Define the whole range for the X-axis. 
            diagram.AxisX.WholeRange.Auto = False
            diagram.AxisX.WholeRange.SetMinMaxValues("A", "D")

            ' Disable the side margins 
            ' (this has an effect only for certain view types).
            diagram.AxisX.VisualRange.AutoSideMargins = False

            ' Limit the visible range for the X-axis.
            diagram.AxisX.VisualRange.Auto = False
            diagram.AxisX.VisualRange.SetMinMaxValues("B", "C")

            ' Define the whole range for the Y-axis. 
            diagram.AxisY.WholeRange.Auto = False
            diagram.AxisY.WholeRange.SetMinMaxValues(0, 5000)




            ' Access the view-type-specific options of the series.
            CType(ChartControl3.Diagram, XYDiagram).AxisY.Interlaced = True
            CType(ChartControl3.Diagram, XYDiagram).AxisY.InterlacedColor = Color.FromArgb(20, 60, 60, 60)
            CType(ChartControl3.Diagram, XYDiagram).AxisX.NumericScaleOptions.AutoGrid = False
            CType(ChartControl3.Diagram, XYDiagram).AxisX.NumericScaleOptions.GridSpacing = 1
            ' Hide the legend (if necessary).
            'ChartControl3.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False
            ' Add a title to the chart (if necessary).
            ChartControl3.Titles.Add(New ChartTitle())
            ChartControl3.Titles(0).Text = "Ordenes surtidas por tipo"
            ' Add the chart to the form.
            ChartControl3.Dock = DockStyle.None







        Catch ex As Exception
            XtraMessageBox.Show(ex.Message.ToString, "Error", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub ResultadoListaTiempoPromedioRecepcioOrdCompra(prmBusqueda2 As Date, prmBusqueda3 As Date)
        Try
            Dim pResultado As New CResultado
            Dim Cls As New clsKPI
            Dim dt As New DataTable

            'pResultado = Cls.ResultadoListaEmpaques
            dt = pResultado.Tabla


            'GridControl1.DataSource = Nothing



            Cursor.Current = Cursors.WaitCursor
            pResultado = Cls.ResultadoListaTiempoRecepcioOrdCompra(prmBusqueda2, prmBusqueda3, My.Settings.Estacion, DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                GridControl6.DataSource = Nothing
                Return
            End If

            dt = pResultado.Tabla
            Dim tablaDetalleTiempoRec As DataTable
            Dim tablaDetalleMinutos As DataTable



            tablaDetalleTiempoRec = pResultado.Tablas.Tables(2)
            tablaDetalleMinutos = pResultado.Tablas.Tables(3)




            If dt.Rows.Count < 1 Then
                XtraMessageBox.Show("Sin información en el sistema", "AXC", MessageBoxButtons.OK)

                Return
            End If


            GridControl6.DataSource = tablaDetalleTiempoRec
            GridView6.BestFitColumns()
            GridControl8.DataSource = tablaDetalleMinutos
            GridView8.BestFitColumns()


            ChartControl4.Titles.Clear()
            ChartControl4.Series.Clear()
            ChartControl4.DataSource = tablaDetalleMinutos
            ChartControl4.Titles.Add(New ChartTitle() With {.Text = "Tiempo Promedio Recepción en Minutos"})
            ChartControl4.Legend.Title.Text = ""
            ChartControl4.SeriesDataMember = "OrdenCompra"
            ChartControl4.SeriesTemplate.ValueDataMembers.AddRange(New String() {"Minutos"})
            ChartControl4.SeriesTemplate.ArgumentDataMember = "OrdenCompra"
            ChartControl4.RuntimeHitTesting = True
            Dim view As SideBySideBarSeriesView = TryCast(ChartControl4.SeriesTemplate.View, SideBySideBarSeriesView)
            Dim diagram As XYDiagram = CType(ChartControl4.Diagram, XYDiagram)

            diagram.EnableAxisXScrolling = True
            diagram.EnableAxisXZooming = True
            diagram.EnableAxisYScrolling = True
            diagram.EnableAxisYZooming = True
            view.BarDistance = 0.5
            view.BarDistanceFixed = 0.5
            view.BarWidth = 3

            'GAUGES

            DigitalGauge1.Text = dt.Rows(0).Item("Horas")
            DigitalGauge2.Text = dt.Rows(0).Item("Minutos")








        Catch ex As Exception
            XtraMessageBox.Show(ex.Message.ToString, "Error", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub ResultadoListaUsuarioxRecepcion(prmBusqueda2 As Date, prmBusqueda3 As Date)
        Try
            Dim pResultado As New CResultado
            Dim Cls As New clsKPI
            Dim dt As New DataTable

            'pResultado = Cls.ResultadoListaEmpaques
            dt = pResultado.Tabla


            GridControl9.DataSource = Nothing



            Cursor.Current = Cursors.WaitCursor
            pResultado = Cls.ResultadoListaUsuarioXRecepcion(prmBusqueda2, prmBusqueda3, My.Settings.Estacion, DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                GridControl9.DataSource = Nothing
                Return
            End If

            dt = pResultado.Tabla






            If dt.Rows.Count < 1 Then
                XtraMessageBox.Show("Sin información en el sistema", "AXC", MessageBoxButtons.OK)
                GridControl9.DataSource = Nothing
                Return
            End If

            GridControl9.DataSource = dt
            GridView9.BestFitColumns()


            ChartControl5.Titles.Clear()
            ChartControl5.Series.Clear()
            ChartControl5.DataSource = dt

            ChartControl5.Series.Clear()
            ChartControl5.Titles.Clear()
            ChartControl5.Titles.Add(New ChartTitle() With {.Text = "Promedio Usuarios por Orden Recepción"})
            ChartControl5.Legend.Title.Text = ""
            ChartControl5.SeriesDataMember = "OrdenCompra"
            ChartControl5.SeriesTemplate.ValueDataMembers.AddRange(New String() {"CantidadUsuarios"})
            ChartControl5.SeriesTemplate.ArgumentDataMember = "OrdenCompra"
            ChartControl5.RuntimeHitTesting = True
            Dim view As SideBySideBarSeriesView = TryCast(ChartControl5.SeriesTemplate.View, SideBySideBarSeriesView)
            Dim diagram As XYDiagram = CType(ChartControl5.Diagram, XYDiagram)
            diagram.EnableAxisXScrolling = True
            diagram.EnableAxisXZooming = True
            diagram.EnableAxisYScrolling = True
            diagram.EnableAxisYZooming = True
            view.BarDistance = 0.5
            view.BarDistanceFixed = 0.5
            view.BarWidth = 0.5











        Catch ex As Exception
            XtraMessageBox.Show(ex.Message.ToString, "Error", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub ResultadoListaProductosPorOrdenProd(prmBusqueda2 As Date, prmBusqueda3 As Date)
        Try
            Dim pResultado As New CResultado
            Dim Cls As New clsKPI
            Dim dt As New DataTable

            'pResultado = Cls.ResultadoListaEmpaques
            dt = pResultado.Tabla



            Cursor.Current = Cursors.WaitCursor
            pResultado = Cls.ResultadoListaProductosPorOrdenProduccion(prmBusqueda2, prmBusqueda3, My.Settings.Estacion, DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                GridControl7.DataSource = Nothing
                Return
            End If

            dt = pResultado.Tabla
            Dim TablaCantidadRegOrden As DataTable
            TablaCantidadRegOrden = pResultado.Tablas.Tables(2)
            Dim TablaPromedioYTotal As DataTable
            TablaPromedioYTotal = pResultado.Tablas.Tables(1)
            Dim TablaNumParteAgrupa As DataTable
            TablaNumParteAgrupa = pResultado.Tablas.Tables(3)

            If dt.Rows.Count < 1 Then
                XtraMessageBox.Show("Sin información en el sistema", "AXC", MessageBoxButtons.OK)
                GridControl7.DataSource = Nothing
                Return
            End If

            GridControl7.DataSource = TablaCantidadRegOrden
            GridView7.BestFitColumns()

            GridControl10.DataSource = TablaNumParteAgrupa
            GridView10.BestFitColumns()

            ChartControl6.Titles.Clear()
            ChartControl6.Series.Clear()
            ChartControl6.DataSource = TablaCantidadRegOrden

            ChartControl6.Series.Clear()
            ChartControl6.Titles.Clear()
            ChartControl6.Titles.Add(New ChartTitle() With {.Text = "Cantidad Registrada por Orden"})
            ChartControl6.Legend.Title.Text = ""
            ChartControl6.SeriesDataMember = "OrdenProd"
            ChartControl6.SeriesTemplate.ValueDataMembers.AddRange(New String() {"CantRegistradaPorOrden"})
            ChartControl6.SeriesTemplate.ArgumentDataMember = "OrdenProd"
            ChartControl6.RuntimeHitTesting = True
            Dim view As SideBySideBarSeriesView = TryCast(ChartControl6.SeriesTemplate.View, SideBySideBarSeriesView)
            Dim diagram As XYDiagram = CType(ChartControl6.Diagram, XYDiagram)
            diagram.EnableAxisXScrolling = True
            diagram.EnableAxisXZooming = True
            diagram.EnableAxisYScrolling = True
            diagram.EnableAxisYZooming = True
            view.BarDistance = 0.5
            view.BarDistanceFixed = 0.5
            view.BarWidth = 0.5

            'Gauges
            DigitalGauge4.Text = TablaPromedioYTotal.Rows(0).Item("CantidadPromProductosXOrden")
            DigitalGauge3.Text = TablaPromedioYTotal.Rows(0).Item("CantidadDeProductoTotal")

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message.ToString, "Error", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub ResultadoListaTiempoRegistroPT(prmBusqueda2 As Date, prmBusqueda3 As Date)
        Try
            Dim pResultado As New CResultado
            Dim Cls As New clsKPI
            Dim dt As New DataTable

            'pResultado = Cls.ResultadoListaEmpaques
            dt = pResultado.Tabla



            Cursor.Current = Cursors.WaitCursor
            pResultado = Cls.ResultadoListaTiempoRegistroproductoTerminado(prmBusqueda2, prmBusqueda3, My.Settings.Estacion, DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                GridControl11.DataSource = Nothing
                Return
            End If

            dt = pResultado.Tabla
            Dim TablaTiempoRegistroPromedio As DataTable
            TablaTiempoRegistroPromedio = pResultado.Tablas.Tables(1)
            Dim TablaDetalleTiemposurtidoxorden As DataTable
            TablaDetalleTiemposurtidoxorden = pResultado.Tablas.Tables(2)

            If dt.Rows.Count < 1 Then
                XtraMessageBox.Show("Sin información en el sistema", "AXC", MessageBoxButtons.OK)
                GridControl11.DataSource = Nothing
                Return
            End If

            GridControl11.DataSource = TablaDetalleTiemposurtidoxorden
            GridView11.BestFitColumns()


            'Gauges
            DigitalGauge5.Text = TablaTiempoRegistroPromedio.Rows(0).Item("Horas")
            DigitalGauge6.Text = TablaTiempoRegistroPromedio.Rows(0).Item("Minutos")

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message.ToString, "Error", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub KPIs_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Try

            Dim prmBusqueda2 As String
            Dim prmBusqueda3 As String



            If String.IsNullOrEmpty(DateEdit1.Text) Then
                prmBusqueda2 = "@"
            Else
                prmBusqueda2 = DateEdit1.Text
            End If
            Dim fecha As New Date
            fecha = Date.Parse(DateEdit1.EditValue.ToString)
            'ResultadoLista(prmBusqueda2, fecha)



            If String.IsNullOrEmpty(DateEdit2.Text) Then
                prmBusqueda3 = "@"
            Else
                prmBusqueda3 = DateEdit2.Text
            End If
            Dim fecha2 As New Date
            fecha2 = Date.Parse(DateEdit2.EditValue.ToString)
            ResultadoListaOrdSurtidasEmbarcadas(fecha, fecha2)
            ResultadoListaCantidadSurtidoTipos(fecha, fecha2)
            ResultadoListaTiempoPromedioRecepcioOrdCompra(fecha, fecha2)
            ResultadoListaUsuarioxRecepcion(fecha, fecha2)
            ResultadoListaProductosPorOrdenProd(fecha, fecha2)
            ResultadoListaTiempoRegistroPT(fecha, fecha2)


        Catch ex As Exception
            XtraMessageBox.Show(ex.Message.ToString, "Error", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub ChartControl4_Click(sender As Object, e As EventArgs) Handles ChartControl4.Click

    End Sub

    Private Sub LabelControl7_Click(sender As Object, e As EventArgs) Handles LabelControl7.Click

    End Sub
End Class