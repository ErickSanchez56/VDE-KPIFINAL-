Imports DevExpress.XtraCharts
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Base

Public Class KPIsProduccion
    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Try
            metodosProdKPIs()
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "Error al buscar")
        End Try
    End Sub

    Private Sub metodosProdKPIs()
        Try
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

            ResultadoListaProductosPorOrdenProd(fecha, fecha2)
            ResultadoListaTiempoRegistroPT(fecha, fecha2)
            ResultadoListaCantidadSurtidoTipos(fecha, fecha2)
            ResultadoLista3(fecha, fecha2)

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "Error al ingresar a los métodos producción.")
        End Try
    End Sub

    Private Sub ResultadoListaProductosPorOrdenProd(prmBusqueda2 As Date, prmBusqueda3 As Date)
        Try
            Dim pResultado As New CResultado
            Dim Cls As New clsKPI
            Dim dt As New DataTable

            'pResultado = Cls.ResultadoListaEmpaques
            ''dt = pResultado.Tabla
            Cursor.Current = Cursors.WaitCursor
            pResultado = Cls.ResultadoListaProductosPorOrdenProduccion(prmBusqueda2, prmBusqueda3, My.Settings.Estacion, DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                'dgvDetalle1Prod.DataSource = Nothing
                Return
            End If

            dt = pResultado.Tabla
            Dim TablaCantidadRegOrden As DataTable
            TablaCantidadRegOrden = pResultado.Tablas.Tables(2)
            Dim TablaTop10 As DataTable
            TablaTop10 = pResultado.Tablas.Tables(3)
            Dim TablaPromedioYTotal As DataTable
            TablaPromedioYTotal = pResultado.Tablas.Tables(1)
            Dim TablaNumParteAgrupa As DataTable
            TablaNumParteAgrupa = pResultado.Tablas.Tables(4)

            If dt.Rows.Count < 1 Then
                XtraMessageBox.Show("Sin información en el sistema para Productos por orden de producción.", "AXC", MessageBoxButtons.OK)
                'dgvDetalle1Prod.DataSource = Nothing
                Return
            End If

            'dgvDetalle1Prod.DataSource = TablaCantidadRegOrden
            'GridView1Prod.BestFitColumns()

            'dgvDetalle2Prod.DataSource = TablaNumParteAgrupa
            'GridView2Prod.BestFitColumns()

            ChartControl1Prod.Titles.Clear()
            ChartControl1Prod.Series.Clear()
            ChartControl1Prod.DataSource = Nothing

            ChartControl1Prod.DataSource = TablaTop10

            ChartControl1Prod.Series.Clear()
            ChartControl1Prod.Titles.Clear()
            ChartControl1Prod.Titles.Add(New ChartTitle() With {.Text = "Top 10 Órdenes con más cantidades registradas"})
            ChartControl1Prod.Legend.Title.Text = ""
            ChartControl1Prod.SeriesDataMember = "Ordenproducción"
            ChartControl1Prod.SeriesTemplate.ValueDataMembers.AddRange(New String() {"CantidadRegistradaPorOrden"})
            ChartControl1Prod.SeriesTemplate.ArgumentDataMember = "Ordenproducción"
            ChartControl1Prod.RuntimeHitTesting = True
            Dim view As SideBySideBarSeriesView = TryCast(ChartControl1Prod.SeriesTemplate.View, SideBySideBarSeriesView)
            Dim diagram As XYDiagram = CType(ChartControl1Prod.Diagram, XYDiagram)
            diagram.EnableAxisXScrolling = True
            diagram.EnableAxisXZooming = True
            diagram.EnableAxisYScrolling = True
            diagram.EnableAxisYZooming = True
            view.BarDistance = 0.5
            view.BarDistanceFixed = 0.5
            view.BarWidth = 0.5

            'Gauges
            DigitalGauge6Prod.Text = TablaPromedioYTotal.Rows(0).Item("CantidadDeProductoTotal")

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message.ToString, "Error Productos por orden de producción", MessageBoxButtons.OK)
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
                'dgvDetalle22.DataSource = Nothing
                Return
            End If

            dt = pResultado.Tabla
            Dim TablaTiempoRegistroPromedio As DataTable
            TablaTiempoRegistroPromedio = pResultado.Tablas.Tables(1)
            Dim TablaDetalleTiemposurtidoxorden As DataTable
            TablaDetalleTiemposurtidoxorden = pResultado.Tablas.Tables(2)

            If dt.Rows.Count < 1 Then
                XtraMessageBox.Show("Sin información en el sistema para Tiempo promedio de producción.", "AXC", MessageBoxButtons.OK)
                'dgvDetalle22.DataSource = Nothing
                Return
            End If

            'dgvDetalle22.DataSource = TablaDetalleTiemposurtidoxorden
            'GridView37.BestFitColumns()

            'Gauges
            DigitalGauge1Prod.Text = TablaTiempoRegistroPromedio.Rows(0).Item("Horas")
            DigitalGauge2Prod.Text = TablaTiempoRegistroPromedio.Rows(0).Item("Minutos")
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message.ToString, "Error Tiempo promedio de producción", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub ResultadoLista3(prmBusqueda2 As Date, prmBusqueda3 As Date)
        Try
            Dim pResultado As New CResultado
            Dim Cls As New ClsKPIF
            Dim dt As New DataTable
            dt = pResultado.Tabla

            Cursor.Current = Cursors.WaitCursor
            pResultado = Cls.ResultadoListaOrdenesProd(prmBusqueda2, prmBusqueda3)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                Return
            End If

            dt = pResultado.Tabla

            Dim tablaTiempoPromedioSurtidoProd As DataTable
            tablaTiempoPromedioSurtidoProd = pResultado.Tablas.Tables(1)

            'If dt.Rows.Count < 1 Then
            '    XtraMessageBox.Show("Sin información en el sistema para Tiempo promedio de surtido en producción.", "AXC", MessageBoxButtons.OK)
            '    'GridControl4.DataSource = Nothing
            '    Return
            'End If

            DigitalGauge4Prod.Text = tablaTiempoPromedioSurtidoProd.Rows(0).Item("Horas")
            DigitalGauge5Prod.Text = tablaTiempoPromedioSurtidoProd.Rows(0).Item("Minutos")

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message.ToString, "Error Tiempo promedio de surtido en producción", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub ResultadoListaCantidadSurtidoTipos(prmBusqueda2 As Date, prmBusqueda3 As Date)
        Try
            Dim pResultado As New CResultado
            Dim Cls As New clsKPI
            Dim dt As New DataTable

            'pResultado = Cls.ResultadoListaEmpaques

            Cursor.Current = Cursors.WaitCursor
            pResultado = Cls.ResultadoListaCantSurtidoTipos(prmBusqueda2, prmBusqueda3, My.Settings.Estacion, DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                Return
            End If

            dt = pResultado.Tabla
            Dim tablaCantidadSurtidosTipo As DataTable

            tablaCantidadSurtidosTipo = pResultado.Tablas.Tables(1)

            If dt.Rows.Count < 1 Then
                XtraMessageBox.Show("Sin información en el sistema para la Cantidad de surtidos tipo Producción.", "AXC", MessageBoxButtons.OK)
                Return
            End If

            'Gauge
            DigitalGauge3Prod.Text = tablaCantidadSurtidosTipo.Rows(0).Item("PRODUCCIÓN")

            ChartControl2Prod.Titles.Clear()
            ChartControl2Prod.Series.Clear()
            ChartControl2Prod.Series.Clear()

            ChartControl2Prod.DataSource = dt

            ''GRAFICA BARRAS

            Dim seriesL1 As Series = New Series("Órdenes Surtidas", ViewType.Bar)
            ' Add points to it.
            seriesL1.Points.Add(New SeriesPoint("Pallet", dt.Rows(0).Item("PALLET")))
            seriesL1.Points.Add(New SeriesPoint("Todo", dt.Rows(0).Item("MIXTO")))
            seriesL1.Points.Add(New SeriesPoint("Picking", dt.Rows(0).Item("PICKING")))
            'seriesL1.Points.Add(New SeriesPoint("Producción", dt.Rows(0).Item("PRODUCCIÓN")))



            ' Add the series to the chart.
            ChartControl2Prod.Series.Add(seriesL1)


            'Cast the chart's diagram to the XYDiagram type, to access its axes.
            Dim diagram As XYDiagram = CType(ChartControl2Prod.Diagram, XYDiagram)
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
            diagram.AxisY.WholeRange.SetMinMaxValues(0, 10000)

            ' Access the view-type-specific options of the series.
            CType(ChartControl2Prod.Diagram, XYDiagram).AxisY.Interlaced = True
            CType(ChartControl2Prod.Diagram, XYDiagram).AxisY.InterlacedColor = Color.FromArgb(20, 60, 60, 60)
            CType(ChartControl2Prod.Diagram, XYDiagram).AxisX.NumericScaleOptions.AutoGrid = False
            CType(ChartControl2Prod.Diagram, XYDiagram).AxisX.NumericScaleOptions.GridSpacing = 1
            ' Hide the legend (if necessary).
            'ChartControl2Prod.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False
            ' Add a title to the chart (if necessary).
            ChartControl2Prod.Titles.Add(New ChartTitle())
            ChartControl2Prod.Titles(0).Text = "Comparación de órdenes de producción surtidas por tipo"
            ' Add the chart to the form.
            ChartControl2Prod.Dock = DockStyle.None

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message.ToString, "Error Cantidad de surtidos tipo Producción", MessageBoxButtons.OK)
        End Try
    End Sub
End Class