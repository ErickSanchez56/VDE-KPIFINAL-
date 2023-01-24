Imports DevExpress.XtraCharts
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Base

Public Class frmKPIsProduccion
    Private Sub KPIsProduccion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim fecha As Date
            Dim fecha2 As Date
            '------------carga con 7 días de rango con fecha final fija---------------
            'fecha2 = New Date(2022, 12, 14)
            'fecha = fecha2.AddDays(-7)
            '-------------------------------------------------------------------------
            '------------carga con 7 días de rango tomando el día actual como fecha final---------------
            fecha2 = Date.Today
            fecha = fecha2.AddDays(-7)
            '--------------------------------------------------------------------------------------------
            dtpFechaInicio.Text = fecha.ToString
            dtpFechaFin.Text = fecha2.ToString
            metodosProdKPIs(fecha, fecha2, 1)
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "Error al cargar.")
        End Try
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Try
            metodosProdKPIs("1900/01/01", "1900/01/01", 0)
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "Error al buscar.")
        End Try
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        NavigationFrame1.SelectPrevPage()
        CambiarLabel()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        NavigationFrame1.SelectNextPage()
        CambiarLabel()
    End Sub

    Private Sub CambiarLabel()
        If NavigationFrame1.SelectedPageIndex = 0 Then
            LabelProduccion.Text = "Resumen"
        End If
        If NavigationFrame1.SelectedPageIndex = 1 Then
            LabelProduccion.Text = "Órdenes de producción"
        End If
        If NavigationFrame1.SelectedPageIndex = 2 Then
            LabelProduccion.Text = "Productos por orden de producción"
        End If
        If NavigationFrame1.SelectedPageIndex = 3 Then
            LabelProduccion.Text = "Tiempos promedio"
        End If
        'If NavigationFrame1.SelectedPageIndex = 4 Then
        '    LabelProduccion.Text = "Surtidos por tipo"
        'End If
    End Sub

    Private Sub metodosProdKPIs(prmFecha As Date, prmFecha2 As Date, prmIndicaLoad As Integer)
        Try
            Dim fecha As New Date
            Dim fecha2 As New Date

            limpiarTodo()

            If prmIndicaLoad = 1 Then
                fecha = prmFecha
                fecha2 = prmFecha2

                ResultadoListaProductosPorOrdenProd(fecha, fecha2)
                ResultadoListaTiempoRegistroPT(fecha, fecha2)
                ResultadoListaCantidadSurtidoTipos(fecha, fecha2)
                ResultadoLista3(fecha, fecha2)
                ResultadoOrdAutSurtVal(fecha, fecha2)
                Return
            End If

            If String.IsNullOrEmpty(dtpFechaInicio.Text) And String.IsNullOrEmpty(dtpFechaFin.Text) Then
                XtraMessageBox.Show("Ingrese parámetros de búsqueda.")
                Return
            End If
            If String.IsNullOrEmpty(dtpFechaInicio.Text) Then
                XtraMessageBox.Show("Ingrese Fecha Inicial de búsqueda.")
                Return
            End If
            If String.IsNullOrEmpty(dtpFechaFin.Text) Then
                XtraMessageBox.Show("Ingrese Fecha Final de búsqueda.")
                Return
            End If

            fecha = Date.Parse(dtpFechaInicio.EditValue.ToString)
            fecha2 = Date.Parse(dtpFechaFin.EditValue.ToString)

            ResultadoListaProductosPorOrdenProd(fecha, fecha2)
            ResultadoListaTiempoRegistroPT(fecha, fecha2)
            ResultadoListaCantidadSurtidoTipos(fecha, fecha2)
            ResultadoLista3(fecha, fecha2)
            ResultadoOrdAutSurtVal(fecha, fecha2)
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "Error al ingresar a los métodos producción.")
        End Try
    End Sub

    Private Sub limpiarTodo()
        Try
            ChartControl1Prod.Titles.Clear()
            ChartControl1Prod.Series.Clear()
            ChartControl1Prod.DataSource = Nothing
            ChartControl2Prod.Titles.Clear()
            ChartControl2Prod.Series.Clear()
            ChartControl2Prod.DataSource = Nothing
            ChartControl3Prod.Titles.Clear()
            ChartControl3Prod.Series.Clear()
            ChartControl3Prod.DataSource = Nothing
            'ChartControl4Prod.Titles.Clear()
            'ChartControl4Prod.Series.Clear()
            'ChartControl4Prod.DataSource = Nothing
            ChartControl5Prod.Titles.Clear()
            ChartControl5Prod.Series.Clear()
            ChartControl5Prod.DataSource = Nothing
            ChartControl6Prod.Titles.Clear()
            ChartControl6Prod.Series.Clear()
            ChartControl6Prod.DataSource = Nothing
            ChartControl7Prod.Titles.Clear()
            ChartControl7Prod.Series.Clear()
            ChartControl7Prod.DataSource = Nothing
            ChartControl8Prod.Titles.Clear()
            ChartControl8Prod.Series.Clear()
            ChartControl8Prod.DataSource = Nothing
            ChartControl9Prod.Titles.Clear()
            ChartControl9Prod.Series.Clear()
            ChartControl9Prod.DataSource = Nothing

            'dgvDetalle1Prod.DataSource = Nothing
            'dgvDetalle2Prod.DataSource = Nothing
            'dgvDetalle3Prod.DataSource = Nothing
            dgvDetalle4Prod.DataSource = Nothing
            dgvDetalle5Prod.DataSource = Nothing

            DigitalGauge2Prod.Text = "00"
            DigitalGauge3Prod.Text = "00"
            DigitalGauge4Prod.Text = "00"
            DigitalGauge5Prod.Text = "00"
            DigitalGauge6Prod.Text = "00"
            DigitalGauge7Prod.Text = "00"
            'DigitalGauge8Prod.Text = "000000"
            DigitalGauge9Prod.Text = "00"
            DigitalGauge10Prod.Text = "00"
            DigitalGauge11Prod.Text = "00"
            DigitalGauge12Prod.Text = "00"
            DigitalGauge13Prod.Text = "00"
            DigitalGauge14Prod.Text = "00"
            DigitalGauge15Prod.Text = "00"
            DigitalGauge16Prod.Text = "00"
            DigitalGauge17Prod.Text = "00"
            DigitalGauge18Prod.Text = "00"
            DigitalGauge19Prod.Text = "00"
            DigitalGauge20Prod.Text = "00"
            DigitalGauge21Prod.Text = "00"
            DigitalGauge22Prod.Text = "00"
            DigitalGauge23Prod.Text = "00"
            DigitalGauge24Prod.Text = "00"
            DigitalGauge25Prod.Text = "00"
            DigitalGauge26Prod.Text = "00"
            DigitalGauge27Prod.Text = "00"
            DigitalGauge28Prod.Text = "00"
            DigitalGauge29Prod.Text = "00"
            DigitalGauge30Prod.Text = "00"
            DigitalGauge31Prod.Text = "00"
            DigitalGauge32Prod.Text = "00"
            'DigitalGauge33Prod.Text = "000000"

            NoOrdenesAutProd.Text = "----"
            NoOrdPendientes.Text = "----"
            NoOrdenesLibProd.Text = "----"
            NoOrdenesSurtProd.Text = "----"
            NoOrdValProd.Text = "----"
            NoOrdTerm.Text = "----"

            NoOrdAut1Prod.Text = "----"
            NoOrdPend1Prod.Text = "----"
            NoOrdLib1Prod.Text = "----"
            NoOrdSurt1Prod.Text = "----"
            NoOrdVal1Prod.Text = "----"
            NoOrdTerm1Prod.Text = "----"

            LblOrdPendPorcentajeProd.Text = "%"
            LblOrdLibPorcentajeProd.Text = "%"
            LblOrdSurtPorcentajeProd.Text = "%"
            LblOrdValPorcentajeProd.Text = "%"
            LblOrdTermPorcentajeProd.Text = "%"

            LblOrdPendPorcentajeProd1.Text = "%"
            LblOrdLibPorcentajeProd1.Text = "%"
            LblOrdSurtPorcentajeProd1.Text = "%"
            LblOrdValPorcentajeProd1.Text = "%"
            LblOrdTermPorcentajeProd1.Text = "%"

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "Error al limpiar las herramientas.")
        End Try
    End Sub

    Private Sub ResultadoListaProductosPorOrdenProd(prmBusqueda2 As Date, prmBusqueda3 As Date)
        Try
            Dim pResultado As New CResultado
            Dim Cls As New clsKPIProd
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
            Dim TablaTotalPorAreas As DataTable
            TablaTotalPorAreas = pResultado.Tablas.Tables(5)

            If dt.Rows.Count < 1 Then
                XtraMessageBox.Show("Sin información en el sistema para Productos por orden de producción.", "AXC", MessageBoxButtons.OK)
                'dgvDetalle1Prod.DataSource = Nothing
                Return
            End If

            '--------------------PantallaResumen Productos----------------------------------------------------
            ChartControl2Prod.DataSource = TablaTotalPorAreas

            Dim seriesOP As Series = New Series("Área 003", ViewType.Bar)
            Dim seriesOP1 As Series = New Series("Área 004", ViewType.Bar)
            Dim seriesOP2 As Series = New Series("Área 005", ViewType.Bar)
            Dim seriesOP3 As Series = New Series("Área 006", ViewType.Bar)
            Dim seriesOP4 As Series = New Series("Área 007", ViewType.Bar)
            Dim seriesOP5 As Series = New Series("Área 009", ViewType.Bar)
            ' Add points to it.
            seriesOP.Points.Add(New SeriesPoint("ÁREA 003", TablaTotalPorAreas.Rows(0).Item("Área 003")))
            seriesOP1.Points.Add(New SeriesPoint("ÁREA 004", TablaTotalPorAreas.Rows(0).Item("Área 004")))
            seriesOP2.Points.Add(New SeriesPoint("ÁREA 005", TablaTotalPorAreas.Rows(0).Item("Área 005")))
            seriesOP3.Points.Add(New SeriesPoint("ÁREA 006", TablaTotalPorAreas.Rows(0).Item("Área 006")))
            seriesOP4.Points.Add(New SeriesPoint("ÁREA 007", TablaTotalPorAreas.Rows(0).Item("Área 007")))
            seriesOP5.Points.Add(New SeriesPoint("ÁREA 009", TablaTotalPorAreas.Rows(0).Item("Área 009")))
            'seriesL2.Points.Add(New SeriesPoint("ÁREA 002", TablaTotalPorAreas.Rows(0).Item("Área 002")))
            'seriesL2.Points.Add(New SeriesPoint("ÁREA 008", TablaTotalPorAreas.Rows(0).Item("Área 008")))

            ' Add the series to the chart.
            ChartControl2Prod.Series.Add(seriesOP)
            ChartControl2Prod.Series.Add(seriesOP1)
            ChartControl2Prod.Series.Add(seriesOP2)
            ChartControl2Prod.Series.Add(seriesOP3)
            ChartControl2Prod.Series.Add(seriesOP4)
            ChartControl2Prod.Series.Add(seriesOP5)
            'Cast the chart's diagram1 to the XYDiagram type, to access its axes.
            Dim diagram1 As XYDiagram = CType(ChartControl2Prod.Diagram, XYDiagram)
            Dim view0 As SideBySideBarSeriesView = TryCast(ChartControl2Prod.SeriesTemplate.View, SideBySideBarSeriesView)
            view0.BarDistance = 0.5
            view0.BarDistanceFixed = 0.5
            view0.BarWidth = 3
            ' Define the whole range for the X-axis. 
            diagram1.AxisX.WholeRange.Auto = False
            diagram1.AxisX.WholeRange.SetMinMaxValues("A", "D")
            ' Disable the side margins 
            ' (this has an effect only for certain view types).
            diagram1.AxisX.VisualRange.AutoSideMargins = False
            ' Limit the visible range for the X-axis.
            diagram1.AxisX.VisualRange.Auto = False
            diagram1.AxisX.VisualRange.SetMinMaxValues("B", "C")
            ' Define the whole range for the Y-axis. 
            diagram1.AxisY.WholeRange.Auto = True
            'diagram1.AxisY.WholeRange.SetMinMaxValues(0, 200)
            ' Access the view-type-specific options of the series.
            CType(ChartControl2Prod.Diagram, XYDiagram).AxisY.Interlaced = True
            CType(ChartControl2Prod.Diagram, XYDiagram).AxisY.InterlacedColor = Color.FromArgb(20, 60, 60, 60)
            CType(ChartControl2Prod.Diagram, XYDiagram).AxisX.NumericScaleOptions.AutoGrid = False
            CType(ChartControl2Prod.Diagram, XYDiagram).AxisX.NumericScaleOptions.GridSpacing = 1
            ' Hide the legend (if necessary).
            'ChartControl2Prod.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False
            ' Add a title to the chart (if necessary).
            ChartControl2Prod.Titles.Add(New ChartTitle())
            ChartControl2Prod.Titles(0).Text = "Órdenes terminadas por áreas"
            ' Add the chart to the form.
            ChartControl2Prod.Dock = DockStyle.None
            diagram1.AxisY.Title.Visible = True
            diagram1.AxisY.Title.Alignment = StringAlignment.Center
            diagram1.AxisY.Title.Text = "Cantidad de órdenes"
            diagram1.AxisY.Title.TextColor = Color.White
            diagram1.AxisY.Title.Antialiasing = True

            '--
            'ChartControl2Prod.DataSource = TablaTotalPorAreas
            'ChartControl2Prod.Titles.Add(New ChartTitle() With {.Text = "Órdenes terminadas por áreas"})
            'ChartControl2Prod.Legend.Title.Text = "aaa"
            'ChartControl2Prod.Legend.Title.Font = New Font("Calibri", 12, FontStyle.Bold)
            'ChartControl2Prod.Legend.Title.TextColor = Color.AliceBlue
            'ChartControl2Prod.Legend.Title.Visible = True
            'ChartControl2Prod.SeriesDataMember = "Área"
            'ChartControl2Prod.SeriesTemplate.ValueDataMembers.AddRange(New String() {"Cantidad"})
            ''ChartControl2Prod.SeriesTemplate.ArgumentDataMember = "Área"
            'ChartControl2Prod.RuntimeHitTesting = True
            'Dim view As SideBySideBarSeriesView = TryCast(ChartControl2Prod.SeriesTemplate.View, SideBySideBarSeriesView)
            'Dim diagram As XYDiagram = CType(ChartControl2Prod.Diagram, XYDiagram)

            'Dim axisX As AxisX = diagram.AxisX
            ''axisX.Label.Angle = -90
            'axisX.QualitativeScaleOptions.AutoGrid = False


            'diagram.AxisX.Title.Visible = True
            'diagram.AxisX.Title.Alignment = StringAlignment.Center
            'diagram.AxisX.Title.Text = "Órdenes"
            'diagram.AxisX.Title.TextColor = Color.White
            'diagram.AxisX.Title.Antialiasing = True

            'diagram.AxisY.Title.Visible = True
            'diagram.AxisY.Title.Alignment = StringAlignment.Center
            'diagram.AxisY.Title.Text = "Tiempo en minutos"
            'diagram.AxisY.Title.TextColor = Color.White
            'diagram.AxisY.Title.Antialiasing = True

            'diagram.EnableAxisXScrolling = True
            'diagram.EnableAxisXZooming = True
            'diagram.EnableAxisYScrolling = True
            'diagram.EnableAxisYZooming = True
            'view.BarDistance = 0.5
            'view.BarDistanceFixed = 0.5
            'view.BarWidth = 3
            '--

            '--------------------Fin de PantallaResumen Productos----------------------------------------------------

            '--------------------Pestaña detalle Productos-----------------------------------------------------------
            'dgvDetalle1Prod.DataSource = TablaCantidadRegOrden
            'GridView1Prod.BestFitColumns()

            'dgvDetalle2Prod.DataSource = TablaNumParteAgrupa
            'GridView2Prod.BestFitColumns()

            'DigitalGauge8Prod.Text = TablaPromedioYTotal.Rows(0).Item("TotalProductoTerminadoProducido")

            ChartControl3Prod.DataSource = TablaTotalPorAreas
            Dim seriesOP6 As Series = New Series("Área 003", ViewType.Bar)
            Dim seriesOP7 As Series = New Series("Área 004", ViewType.Bar)
            Dim seriesOP8 As Series = New Series("Área 005", ViewType.Bar)
            Dim seriesOP9 As Series = New Series("Área 006", ViewType.Bar)
            Dim seriesOP10 As Series = New Series("Área 007", ViewType.Bar)
            Dim seriesOP11 As Series = New Series("Área 009", ViewType.Bar)
            ' Add points to it.
            seriesOP6.Points.Add(New SeriesPoint("ÁREA 003", TablaTotalPorAreas.Rows(0).Item("Área 003")))
            seriesOP7.Points.Add(New SeriesPoint("ÁREA 004", TablaTotalPorAreas.Rows(0).Item("Área 004")))
            seriesOP8.Points.Add(New SeriesPoint("ÁREA 005", TablaTotalPorAreas.Rows(0).Item("Área 005")))
            seriesOP9.Points.Add(New SeriesPoint("ÁREA 006", TablaTotalPorAreas.Rows(0).Item("Área 006")))
            seriesOP10.Points.Add(New SeriesPoint("ÁREA 007", TablaTotalPorAreas.Rows(0).Item("Área 007")))
            seriesOP11.Points.Add(New SeriesPoint("ÁREA 009", TablaTotalPorAreas.Rows(0).Item("Área 009")))
            'seriesL3.Points.Add(New SeriesPoint("ÁREA 002", TablaTotalPorAreas.Rows(0).Item("Área 002")))
            'seriesL3.Points.Add(New SeriesPoint("ÁREA 008", TablaTotalPorAreas.Rows(0).Item("Área 008")))

            ' Add the series to the chart.
            ChartControl3Prod.Series.Add(seriesOP6)
            ChartControl3Prod.Series.Add(seriesOP7)
            ChartControl3Prod.Series.Add(seriesOP8)
            ChartControl3Prod.Series.Add(seriesOP9)
            ChartControl3Prod.Series.Add(seriesOP10)
            ChartControl3Prod.Series.Add(seriesOP11)
            'Cast the chart's diagram2 to the XYDiagram type, to access its axes.
            Dim diagram2 As XYDiagram = CType(ChartControl3Prod.Diagram, XYDiagram)
            Dim view As SideBySideBarSeriesView = TryCast(ChartControl3Prod.SeriesTemplate.View, SideBySideBarSeriesView)
            view.BarDistance = 0.5
            view.BarDistanceFixed = 0.5
            view.BarWidth = 3
            ' Define the whole range for the X-axis. 
            diagram2.AxisX.WholeRange.Auto = False
            diagram2.AxisX.WholeRange.SetMinMaxValues("A", "D")
            ' Disable the side margins 
            ' (this has an effect only for certain view types).
            diagram2.AxisX.VisualRange.AutoSideMargins = False
            ' Limit the visible range for the X-axis.
            diagram2.AxisX.VisualRange.Auto = False
            diagram2.AxisX.VisualRange.SetMinMaxValues("B", "C")
            ' Define the whole range for the Y-axis. 
            diagram2.AxisY.WholeRange.Auto = True
            'diagram2.AxisY.WholeRange.SetMinMaxValues(0, 200)
            ' Access the view-type-specific options of the series.
            CType(ChartControl3Prod.Diagram, XYDiagram).AxisY.Interlaced = True
            CType(ChartControl3Prod.Diagram, XYDiagram).AxisY.InterlacedColor = Color.FromArgb(20, 60, 60, 60)
            CType(ChartControl3Prod.Diagram, XYDiagram).AxisX.NumericScaleOptions.AutoGrid = False
            CType(ChartControl3Prod.Diagram, XYDiagram).AxisX.NumericScaleOptions.GridSpacing = 1
            ' Hide the legend (if necessary).
            'ChartControl3Prod.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False
            ' Add a title to the chart (if necessary).
            ChartControl3Prod.Titles.Add(New ChartTitle())
            ChartControl3Prod.Titles(0).Text = "Órdenes terminadas por áreas"
            ' Add the chart to the form.
            ChartControl3Prod.Dock = DockStyle.None
            diagram2.AxisY.Title.Visible = True
            diagram2.AxisY.Title.Alignment = StringAlignment.Center
            diagram2.AxisY.Title.Text = "Cantidad de órdenes"
            diagram2.AxisY.Title.TextColor = Color.White
            diagram2.AxisY.Title.Antialiasing = True

            ChartControl8Prod.DataSource = TablaNumParteAgrupa

            ChartControl8Prod.DataSource = TablaNumParteAgrupa
            ChartControl8Prod.Titles.Add(New ChartTitle() With {.Text = "Números de parte más registrados"})
            ChartControl8Prod.Legend.Title.Text = ""
            ChartControl8Prod.SeriesDataMember = "NúmeroDeParte"
            ChartControl8Prod.SeriesTemplate.ValueDataMembers.AddRange(New String() {"CantidadRegistrada"})
            ChartControl8Prod.SeriesTemplate.ArgumentDataMember = "NúmeroDeParte"
            ChartControl8Prod.RuntimeHitTesting = True
            Dim viewn As SideBySideBarSeriesView = TryCast(ChartControl8Prod.SeriesTemplate.View, SideBySideBarSeriesView)
            Dim diagram As XYDiagram = CType(ChartControl8Prod.Diagram, XYDiagram)
            diagram.EnableAxisXScrolling = True
            diagram.EnableAxisXZooming = True
            diagram.EnableAxisYScrolling = True
            diagram.EnableAxisYZooming = True
            viewn.BarDistance = 0.5
            viewn.BarDistanceFixed = 0.5
            viewn.BarWidth = 2

            Dim axisX As AxisX = diagram.AxisX
            axisX.Label.Angle = 315
            diagram.AxisX.Title.Visible = True
            diagram.AxisX.Title.Alignment = StringAlignment.Center
            diagram.AxisX.Title.Text = "Número de Parte" '_
            diagram.AxisX.Title.TextColor = Color.White
            diagram.AxisX.Title.Antialiasing = True
            diagram.AxisX.QualitativeScaleOptions.AutoGrid = False

            diagram.AxisY.Title.Visible = True
            diagram.AxisY.Title.Alignment = StringAlignment.Center
            diagram.AxisY.Title.Text = "Cantidad" ' |
            diagram.AxisY.Title.TextColor = Color.White
            diagram.AxisY.Title.Antialiasing = True

            axisX.Label.Angle = 315
            axisX.Label.Visible = True

            '--------------------Fin de Pestaña detalle Productos----------------------------------------------------
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message.ToString, "Error Productos por orden de producción", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub ResultadoListaTiempoRegistroPT(prmBusqueda2 As Date, prmBusqueda3 As Date)
        Try
            Dim pResultado As New CResultado
            Dim Cls As New clsKPIProd
            Dim dt As New DataTable

            'pResultado = Cls.ResultadoListaEmpaques
            dt = pResultado.Tabla

            Cursor.Current = Cursors.WaitCursor
            pResultado = Cls.ResultadoListaTiempoRegistroproductoTerminado(prmBusqueda2, prmBusqueda3, My.Settings.Estacion, DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                'dgvDetalle2Prod.DataSource = Nothing
                Return
            End If

            dt = pResultado.Tabla
            Dim TablaTiempoRegistroPromedio As DataTable
            TablaTiempoRegistroPromedio = pResultado.Tablas.Tables(1)
            Dim TablaDetalleTiemposurtidoxorden As DataTable
            TablaDetalleTiemposurtidoxorden = pResultado.Tablas.Tables(2)
            Dim TablaTop10OrdMasTardadasProd As DataTable
            TablaTop10OrdMasTardadasProd = pResultado.Tablas.Tables(5)
            Dim TiempoPromArea003 As DataTable
            TiempoPromArea003 = pResultado.Tablas.Tables(6)
            Dim TiempoPromArea004 As DataTable
            TiempoPromArea004 = pResultado.Tablas.Tables(7)
            Dim TiempoPromArea005 As DataTable
            TiempoPromArea005 = pResultado.Tablas.Tables(8)
            Dim TiempoPromArea006 As DataTable
            TiempoPromArea006 = pResultado.Tablas.Tables(9)
            Dim TiempoPromArea007 As DataTable
            TiempoPromArea007 = pResultado.Tablas.Tables(10)
            Dim TiempoPromArea009 As DataTable
            TiempoPromArea009 = pResultado.Tablas.Tables(11)
            Dim TablaTop10NumParteMasTardadosProd As DataTable
            TablaTop10NumParteMasTardadosProd = pResultado.Tablas.Tables(12)

            'If dt.Rows.Count < 1 Then
            '    XtraMessageBox.Show("Sin información en el sistema para Tiempo promedio de producción.", "AXC", MessageBoxButtons.OK)
            '    'dgvDetalle2Prod.DataSource = Nothing
            '    Return
            'End If

            '--------------------PantallaResumen TiempoPromedioProducción-----------------------------------------------------------
            'Gauges
            DigitalGauge2Prod.Text = TablaTiempoRegistroPromedio.Rows(0).Item("Días")
            DigitalGauge3Prod.Text = TablaTiempoRegistroPromedio.Rows(0).Item("Horas")
            DigitalGauge4Prod.Text = TablaTiempoRegistroPromedio.Rows(0).Item("Minutos")



            '--------------------Fin de PantallaResumen TiempoPromedioProducción---------------------------------------------------

            '--------------------Pestaña detalle Tiempos promedio------------------------------------------------------------------
            'Gauges
            DigitalGauge9Prod.Text = TablaTiempoRegistroPromedio.Rows(0).Item("Días")
            DigitalGauge10Prod.Text = TablaTiempoRegistroPromedio.Rows(0).Item("Horas")
            DigitalGauge11Prod.Text = TablaTiempoRegistroPromedio.Rows(0).Item("Minutos")

            DigitalGauge15Prod.Text = TiempoPromArea003.Rows(0).Item("Días")
            DigitalGauge16Prod.Text = TiempoPromArea003.Rows(0).Item("Horas")
            DigitalGauge17Prod.Text = TiempoPromArea003.Rows(0).Item("Minutos")

            DigitalGauge18Prod.Text = TiempoPromArea004.Rows(0).Item("Días")
            DigitalGauge19Prod.Text = TiempoPromArea004.Rows(0).Item("Horas")
            DigitalGauge20Prod.Text = TiempoPromArea004.Rows(0).Item("Minutos")

            DigitalGauge21Prod.Text = TiempoPromArea005.Rows(0).Item("Días")
            DigitalGauge22Prod.Text = TiempoPromArea005.Rows(0).Item("Horas")
            DigitalGauge23Prod.Text = TiempoPromArea005.Rows(0).Item("Minutos")

            DigitalGauge24Prod.Text = TiempoPromArea006.Rows(0).Item("Días")
            DigitalGauge25Prod.Text = TiempoPromArea006.Rows(0).Item("Horas")
            DigitalGauge26Prod.Text = TiempoPromArea006.Rows(0).Item("Minutos")

            DigitalGauge27Prod.Text = TiempoPromArea007.Rows(0).Item("Días")
            DigitalGauge28Prod.Text = TiempoPromArea007.Rows(0).Item("Horas")
            DigitalGauge29Prod.Text = TiempoPromArea007.Rows(0).Item("Minutos")

            DigitalGauge30Prod.Text = TiempoPromArea009.Rows(0).Item("Días")
            DigitalGauge31Prod.Text = TiempoPromArea009.Rows(0).Item("Horas")
            DigitalGauge32Prod.Text = TiempoPromArea009.Rows(0).Item("Minutos")

            '--------------------Fin de Pestaña detalle Tiempos promedio-----------------------------------------------------------

            '--------------------Pestaña Productos por orden----------------------------------------------------
            dgvDetalle4Prod.DataSource = TablaTop10NumParteMasTardadosProd
            GridView4Prod.BestFitColumns()

            ChartControl9Prod.DataSource = TablaTop10NumParteMasTardadosProd
            ChartControl9Prod.Titles.Add(New ChartTitle() With {.Text = "Números de parte con tiempos más largos"})
            ChartControl9Prod.Legend.Title.Text = ""
            ChartControl9Prod.SeriesDataMember = "NúmeroDeParte"
            ChartControl9Prod.SeriesTemplate.ValueDataMembers.AddRange(New String() {"TotalHoras"})
            ChartControl9Prod.SeriesTemplate.ArgumentDataMember = "NúmeroDeParte"
            ChartControl9Prod.RuntimeHitTesting = True
            Dim view As SideBySideBarSeriesView = TryCast(ChartControl9Prod.SeriesTemplate.View, SideBySideBarSeriesView)
            Dim diagram As XYDiagram = CType(ChartControl9Prod.Diagram, XYDiagram)
            diagram.EnableAxisXScrolling = True
            diagram.EnableAxisXZooming = True
            diagram.EnableAxisYScrolling = True
            diagram.EnableAxisYZooming = True
            view.BarDistance = 0.5
            view.BarDistanceFixed = 0.5
            view.BarWidth = 2

            Dim axisX As AxisX = diagram.AxisX
            axisX.Label.Angle = 315
            diagram.AxisX.Title.Visible = True
            diagram.AxisX.Title.Alignment = StringAlignment.Center
            diagram.AxisX.Title.Text = "Número de Parte" '_
            diagram.AxisX.Title.TextColor = Color.White
            diagram.AxisX.Title.Antialiasing = True
            diagram.AxisX.QualitativeScaleOptions.AutoGrid = False

            diagram.AxisY.Title.Visible = True
            diagram.AxisY.Title.Alignment = StringAlignment.Center
            diagram.AxisY.Title.Text = "Horas" ' |
            diagram.AxisY.Title.TextColor = Color.White
            diagram.AxisY.Title.Antialiasing = True

            axisX.Label.Angle = 315
            axisX.Label.Visible = True
            '----------Fin de Pestaña Productos por orden----------------------------------------------------



        Catch ex As Exception
            XtraMessageBox.Show(ex.Message.ToString, "Error Tiempo promedio de producción", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub ResultadoLista3(prmBusqueda2 As Date, prmBusqueda3 As Date)
        Try
            Dim pResultado As New CResultado
            Dim Cls As New clsKPIProd
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

            '--------------------PantallaResumen TiempoPromedioProducciónSurtidos------------------------------------------------
            DigitalGauge5Prod.Text = tablaTiempoPromedioSurtidoProd.Rows(0).Item("Días")
            DigitalGauge6Prod.Text = tablaTiempoPromedioSurtidoProd.Rows(0).Item("Horas")
            DigitalGauge7Prod.Text = tablaTiempoPromedioSurtidoProd.Rows(0).Item("Minutos")
            '--------------Fin de PantallaResumen TiempoPromedioProducciónSurtidos-----------------------------------------------

            '--------------------Pestaña detalle Tiempos promedio------------------------------------------------------------------
            DigitalGauge12Prod.Text = tablaTiempoPromedioSurtidoProd.Rows(0).Item("Días")
            DigitalGauge13Prod.Text = tablaTiempoPromedioSurtidoProd.Rows(0).Item("Horas")
            DigitalGauge14Prod.Text = tablaTiempoPromedioSurtidoProd.Rows(0).Item("Minutos")

            '-------------Fin de Pestaña detalle Tiempos promedio------------------------------------------------------------------


        Catch ex As Exception
            XtraMessageBox.Show(ex.Message.ToString, "Error Tiempo promedio de surtido en producción", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub ResultadoListaCantidadSurtidoTipos(prmBusqueda2 As Date, prmBusqueda3 As Date)
        Try
            Dim pResultado As New CResultado
            Dim Cls As New clsKPIProd
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
            Dim tablaDetalletipoSurtido As DataTable
            tablaDetalletipoSurtido = pResultado.Tablas.Tables(2)

            'Gauge
            'DigitalGauge33Prod.Text = tablaCantidadSurtidosTipo.Rows(0).Item("PRODUCCIÓN")

            'LblCantSurtProd.Text = tablaCantidadSurtidosTipo.Rows(0).Item("PRODUCCIÓN")

            'dgvDetalle1Prod.DataSource = dt
            'GridView3.BestFitColumns()
            'dgvDetalle3Prod.DataSource = tablaDetalletipoSurtido
            'GridView3Prod.BestFitColumns()

            'ChartControl4Prod.DataSource = dt


            If dt.Rows.Count < 1 Then
                XtraMessageBox.Show("Sin información en el sistema para la Cantidad de surtidos tipo Producción.", "AXC", MessageBoxButtons.OK)
                Return
            End If

            '--------------------Pestaña detalle Surtidos por Tipo------------------------------------------------------------------
            'GRAFICA BARRAS
            'Dim seriesL1 As Series = New Series("Órdenes Surtidas", ViewType.Bar)
            '' Add points to it.
            'seriesL1.Points.Add(New SeriesPoint("PALLET", dt.Rows(0).Item("PALLET")))
            'seriesL1.Points.Add(New SeriesPoint("MIXTO", dt.Rows(0).Item("MIXTO")))
            'seriesL1.Points.Add(New SeriesPoint("PICKING", dt.Rows(0).Item("PICKING")))
            ''seriesL1.Points.Add(New SeriesPoint("Producción", dt.Rows(0).Item("PRODUCCIÓN")))

            '' Add the series to the chart.
            'ChartControl4Prod.Series.Add(seriesL1)
            ''Cast the chart's diagram to the XYDiagram type, to access its axes.
            'Dim diagram As XYDiagram = CType(ChartControl4Prod.Diagram, XYDiagram)
            '' Define the whole range for the X-axis. 
            'diagram.AxisX.WholeRange.Auto = False
            'diagram.AxisX.WholeRange.SetMinMaxValues("A", "D")
            '' Disable the side margins 
            '' (this has an effect only for certain view types).
            'diagram.AxisX.VisualRange.AutoSideMargins = False
            '' Limit the visible range for the X-axis.
            'diagram.AxisX.VisualRange.Auto = False
            'diagram.AxisX.VisualRange.SetMinMaxValues("B", "C")
            '' Define the whole range for the Y-axis. 
            'diagram.AxisY.WholeRange.Auto = True
            ''diagram.AxisY.WholeRange.SetMinMaxValues(0, 3000)
            '' Access the view-type-specific options of the series.
            'CType(ChartControl4Prod.Diagram, XYDiagram).AxisY.Interlaced = True
            'CType(ChartControl4Prod.Diagram, XYDiagram).AxisY.InterlacedColor = Color.FromArgb(20, 60, 60, 60)
            'CType(ChartControl4Prod.Diagram, XYDiagram).AxisX.NumericScaleOptions.AutoGrid = False
            'CType(ChartControl4Prod.Diagram, XYDiagram).AxisX.NumericScaleOptions.GridSpacing = 1
            '' Hide the legend (if necessary).
            ''ChartControl4Prod.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False
            '' Add a title to the chart (if necessary).
            'ChartControl4Prod.Titles.Add(New ChartTitle())
            'ChartControl4Prod.Titles(0).Text = "Comparación de surtidos por tipo"
            '' Add the chart to the form.
            'ChartControl4Prod.Dock = DockStyle.None
            'diagram.AxisY.Title.Visible = True
            'diagram.AxisY.Title.Alignment = StringAlignment.Center
            'diagram.AxisY.Title.Text = "Cantidad"
            'diagram.AxisY.Title.TextColor = Color.White
            'diagram.AxisY.Title.Antialiasing = True

            '--------------------Fin de Pestaña detalle Surtidos por Tipo-----------------------------------------------------------
            '-------------------Pantalla Resumen------------------------------------------------------------------------------------

            'ChartControl1Prod.DataSource = dt

            'Dim seriesL2 As Series = New Series("Órdenes Surtidas", ViewType.Bar)
            '' Add points to it.
            'seriesL2.Points.Add(New SeriesPoint("PALLET", dt.Rows(0).Item("PALLET")))
            'seriesL2.Points.Add(New SeriesPoint("MIXTO", dt.Rows(0).Item("MIXTO")))
            'seriesL2.Points.Add(New SeriesPoint("PICKING", dt.Rows(0).Item("PICKING")))
            ''seriesL2.Points.Add(New SeriesPoint("Producción", dt.Rows(0).Item("PRODUCCIÓN")))

            '' Add the series to the chart.
            'ChartControl1Prod.Series.Add(seriesL2)
            ''Cast the chart's diagram1 to the XYDiagram type, to access its axes.
            'Dim diagram1 As XYDiagram = CType(ChartControl1Prod.Diagram, XYDiagram)
            '' Define the whole range for the X-axis. 
            'diagram1.AxisX.WholeRange.Auto = False
            'diagram1.AxisX.WholeRange.SetMinMaxValues("A", "D")
            '' Disable the side margins 
            '' (this has an effect only for certain view types).
            'diagram1.AxisX.VisualRange.AutoSideMargins = False
            '' Limit the visible range for the X-axis.
            'diagram1.AxisX.VisualRange.Auto = False
            'diagram1.AxisX.VisualRange.SetMinMaxValues("B", "C")
            '' Define the whole range for the Y-axis. 
            'diagram1.AxisY.WholeRange.Auto = True
            ''diagram1.AxisY.WholeRange.SetMinMaxValues(,)
            '' Access the view-type-specific options of the series.
            'CType(ChartControl1Prod.Diagram, XYDiagram).AxisY.Interlaced = True
            'CType(ChartControl1Prod.Diagram, XYDiagram).AxisY.InterlacedColor = Color.FromArgb(20, 60, 60, 60)
            'CType(ChartControl1Prod.Diagram, XYDiagram).AxisX.NumericScaleOptions.AutoGrid = False
            'CType(ChartControl1Prod.Diagram, XYDiagram).AxisX.NumericScaleOptions.GridSpacing = 1
            '' Hide the legend (if necessary).
            ''ChartControl1Prod.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False
            '' Add a title to the chart (if necessary).
            'ChartControl1Prod.Titles.Add(New ChartTitle())
            'ChartControl1Prod.Titles(0).Text = "Surtidos por tipo"
            '' Add the chart to the form.
            'ChartControl1Prod.Dock = DockStyle.None
            'diagram1.AxisY.Title.Visible = True
            'diagram1.AxisY.Title.Alignment = StringAlignment.Center
            'diagram1.AxisY.Title.Text = "Cantidad"
            'diagram1.AxisY.Title.TextColor = Color.White
            'diagram1.AxisY.Title.Antialiasing = True
            '-----------------------------------------------------------------------------------------------------------------------


        Catch ex As Exception
            XtraMessageBox.Show(ex.Message.ToString, "Error Cantidad de surtidos tipo Producción", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub ResultadoOrdAutSurtVal(prmBusqueda2 As Date, prmBusqueda3 As Date)
        Try
            Dim pResultado As New CResultado
            Dim Cls As New clsKPIProd
            Dim dt As New DataTable

            'pResultado = Cls.ResultadoListaEmpaques
            ''dt = pResultado.Tabla
            Cursor.Current = Cursors.WaitCursor
            pResultado = Cls.ResultadoOrdenesAutSurtVal(prmBusqueda2, prmBusqueda3, My.Settings.Estacion, DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                'dgvDetalle1Prod.DataSource = Nothing
                Return
            End If

            dt = pResultado.Tabla
            Dim TablaOrdProdAut As DataTable
            TablaOrdProdAut = pResultado.Tablas.Tables(1)
            Dim TablaOrdProdAutPorcentaje As DataTable
            TablaOrdProdAutPorcentaje = pResultado.Tablas.Tables(2)
            Dim TablaDetalleOrdenesAut As DataTable
            TablaDetalleOrdenesAut = pResultado.Tablas.Tables(3)
            Dim TablaOrdenesAutPorFecha As DataTable
            TablaOrdenesAutPorFecha = pResultado.Tablas.Tables(4)

            'If dt.Rows.Count < 1 Then
            '    XtraMessageBox.Show("Sin información en el sistema para Productos por orden de producción.", "AXC", MessageBoxButtons.OK)
            '    'dgvDetalle1Prod.DataSource = Nothing
            '    Return
            'End If

            '------------Pantalla Resumen--------------------------------------------------------------------------
            NoOrdenesAutProd.Text = TablaOrdProdAut.Rows(0).Item("OrdenesAutorizadas")
            NoOrdenesLibProd.Text = TablaOrdProdAut.Rows(0).Item("OrdenesLiberadas")
            NoOrdenesSurtProd.Text = TablaOrdProdAut.Rows(0).Item("OrdenesSurtidas")
            NoOrdValProd.Text = TablaOrdProdAut.Rows(0).Item("OrdenesValidadas")
            NoOrdPendientes.Text = TablaOrdProdAut.Rows(0).Item("OrdenesPendientes")
            NoOrdTerm.Text = TablaOrdProdAut.Rows(0).Item("OrdenesTerminadas")

            LblOrdPendPorcentajeProd.Text = TablaOrdProdAutPorcentaje.Rows(0).Item("PorcentajePendientes")
            LblOrdPendPorcentajeProd.Text = LblOrdPendPorcentajeProd.Text + " %"
            LblOrdLibPorcentajeProd.Text = TablaOrdProdAutPorcentaje.Rows(0).Item("PorcentajeLiberadas")
            LblOrdLibPorcentajeProd.Text = LblOrdLibPorcentajeProd.Text + " %"
            LblOrdSurtPorcentajeProd.Text = TablaOrdProdAutPorcentaje.Rows(0).Item("PorcentajeSurtidas")
            LblOrdSurtPorcentajeProd.Text = LblOrdSurtPorcentajeProd.Text + " %"
            LblOrdValPorcentajeProd.Text = TablaOrdProdAutPorcentaje.Rows(0).Item("PorcentajeValidadas")
            LblOrdValPorcentajeProd.Text = LblOrdValPorcentajeProd.Text + " %"
            LblOrdTermPorcentajeProd.Text = TablaOrdProdAutPorcentaje.Rows(0).Item("PorcentajeTerminadas")
            LblOrdTermPorcentajeProd.Text = LblOrdTermPorcentajeProd.Text + " %"

            '---gráfica pie
            Dim series1 As New Series("Doughnut Series 1", ViewType.Pie)

            ' Populate the series with points.
            ChartControl5Prod.DataSource = TablaOrdProdAutPorcentaje
            series1.Points.Add(New SeriesPoint("Pendientes", TablaOrdProdAutPorcentaje.Rows(0).Item("PorcentajePendientes")))
            series1.Points.Add(New SeriesPoint("Liberadas", TablaOrdProdAutPorcentaje.Rows(0).Item("PorcentajeLiberadas")))
            series1.Points.Add(New SeriesPoint("Surtidas", TablaOrdProdAutPorcentaje.Rows(0).Item("PorcentajeSurtidas")))
            series1.Points.Add(New SeriesPoint("Validadas", TablaOrdProdAutPorcentaje.Rows(0).Item("PorcentajeValidadas")))
            series1.Points.Add(New SeriesPoint("Terminadas", TablaOrdProdAutPorcentaje.Rows(0).Item("PorcentajeTerminadas")))

            ' Add the series to the chart.
            ChartControl5Prod.Series.Add(series1)
            ChartControl5Prod.Legend.Title.Text = "Porcentajes"
            ChartControl5Prod.Legend.Title.Font = New Font("Calibri", 12, FontStyle.Bold)
            ChartControl5Prod.Legend.Title.TextColor = Color.AliceBlue
            ChartControl5Prod.Legend.Title.Visible = True
            'ChartControl5Prod.Legend.MarkerMode = LegendMarkerMode.Marker

            ' Adjust the value numeric options of the series.
            series1.PointOptions.ValueNumericOptions.Format = NumericFormat.Percent
            series1.PointOptions.ValueNumericOptions.Precision = 2
            'series1.PointOptions.value

            ' Add a title to the chart and hide the legend.
            Dim chartTitle1 As New ChartTitle()
            chartTitle1.Text = "Órdenes de producción"
            ChartControl5Prod.Titles.Add(chartTitle1)
            ChartControl5Prod.Legend.Visible = False

            ' Add the chart to the form.
            ChartControl5Prod.Dock = DockStyle.None
            'Rotacion de Char3d
            ChartControl5Prod.RuntimeRotation = True
            '---gráfica pie end

            '---gráfica de puntos
            ChartControl1Prod.DataSource = TablaOrdenesAutPorFecha
            'ChartControl1Prod.Titles(0).Text = "Órdenes autorizadas por fechas"

            If TablaOrdenesAutPorFecha.Rows.Count > 0 Then
                Dim series() As Series
                ReDim series(0)
                Dim contador = 0
                For Each rowAlm As DataRow In TablaOrdenesAutPorFecha.Rows
                    series(contador) = New Series(rowAlm.Item("Aut"), ViewType.Line)

                    Dim almacen = rowAlm.Item("Aut")
                    For Each rowOcupados As DataRow In TablaOrdenesAutPorFecha.Rows
                        If rowOcupados.Item("Aut") = almacen Then
                            series(contador).Points.Add(New SeriesPoint(rowOcupados.Item("FechaDeAutorización"), rowOcupados.Item("ÓrdenesAutorizadas")))
                        End If
                    Next
                    ChartControl1Prod.Series.Add(series(contador))

                    CType(series(contador).View, LineSeriesView).MarkerVisibility = DevExpress.Utils.DefaultBoolean.True
                    CType(series(contador).View, LineSeriesView).LineMarkerOptions.Size = 10
                    CType(series(contador).View, LineSeriesView).LineMarkerOptions.Kind = MarkerKind.Circle
                    CType(series(contador).View, LineSeriesView).LineStyle.DashStyle = DashStyle.Dash
                    Exit For
                Next
            End If
            Dim chartTitle4 As New ChartTitle()
            chartTitle4.Text = "Órdenes autorizadas por día"
            ChartControl1Prod.Titles.Add(chartTitle4)
            ChartControl1Prod.Legend.Visible = False

            Dim diagram4 As XYDiagram = CType(ChartControl1Prod.Diagram, XYDiagram)
            diagram4.EnableAxisXScrolling = True
            diagram4.EnableAxisXZooming = True
            diagram4.EnableAxisYScrolling = True
            diagram4.EnableAxisYZooming = True

            Dim axisX4 As AxisX = diagram4.AxisX
            axisX4.Label.Angle = 315
            diagram4.AxisX.Title.Visible = False
            diagram4.AxisX.Title.Alignment = StringAlignment.Center
            'diagram.AxisX.Title.Text = "Número de Parte" '_
            diagram4.AxisX.Title.TextColor = Color.White
            diagram4.AxisX.Title.Antialiasing = True
            diagram4.AxisX.QualitativeScaleOptions.AutoGrid = False
            '--- gráfica de puntos end


            '----------Fin de Pantalla Resumen------------------------------------------------------------

            '---------Inicia pestaña detalle-------------------------------------------------------------
            NoOrdAut1Prod.Text = TablaOrdProdAut.Rows(0).Item("OrdenesAutorizadas")
            NoOrdLib1Prod.Text = TablaOrdProdAut.Rows(0).Item("OrdenesLiberadas")
            NoOrdSurt1Prod.Text = TablaOrdProdAut.Rows(0).Item("OrdenesSurtidas")
            NoOrdVal1Prod.Text = TablaOrdProdAut.Rows(0).Item("OrdenesValidadas")
            NoOrdPend1Prod.Text = TablaOrdProdAut.Rows(0).Item("OrdenesPendientes")
            NoOrdTerm1Prod.Text = TablaOrdProdAut.Rows(0).Item("OrdenesTerminadas")

            LblOrdPendPorcentajeProd1.Text = TablaOrdProdAutPorcentaje.Rows(0).Item("PorcentajePendientes")
            LblOrdPendPorcentajeProd1.Text = LblOrdPendPorcentajeProd1.Text + " %"
            LblOrdLibPorcentajeProd1.Text = TablaOrdProdAutPorcentaje.Rows(0).Item("PorcentajeLiberadas")
            LblOrdLibPorcentajeProd1.Text = LblOrdLibPorcentajeProd1.Text + " %"
            LblOrdSurtPorcentajeProd1.Text = TablaOrdProdAutPorcentaje.Rows(0).Item("PorcentajeSurtidas")
            LblOrdSurtPorcentajeProd1.Text = LblOrdSurtPorcentajeProd1.Text + " %"
            LblOrdValPorcentajeProd1.Text = TablaOrdProdAutPorcentaje.Rows(0).Item("PorcentajeValidadas")
            LblOrdValPorcentajeProd1.Text = LblOrdValPorcentajeProd1.Text + " %"
            LblOrdTermPorcentajeProd1.Text = TablaOrdProdAutPorcentaje.Rows(0).Item("PorcentajeTerminadas")
            LblOrdTermPorcentajeProd1.Text = LblOrdTermPorcentajeProd1.Text + " %"

            dgvDetalle5Prod.DataSource = TablaDetalleOrdenesAut
            GridView5Prod.BestFitColumns()

            '---gráfica pie
            Dim series2 As New Series("Doughnut Series 1", ViewType.Pie)

            ' Populate the series with points.
            ChartControl7Prod.DataSource = TablaOrdProdAutPorcentaje
            series2.Points.Add(New SeriesPoint("Pendientes", TablaOrdProdAutPorcentaje.Rows(0).Item("PorcentajePendientes")))
            series2.Points.Add(New SeriesPoint("Liberadas", TablaOrdProdAutPorcentaje.Rows(0).Item("PorcentajeLiberadas")))
            series2.Points.Add(New SeriesPoint("Surtidas", TablaOrdProdAutPorcentaje.Rows(0).Item("PorcentajeSurtidas")))
            series2.Points.Add(New SeriesPoint("Validadas", TablaOrdProdAutPorcentaje.Rows(0).Item("PorcentajeValidadas")))
            series2.Points.Add(New SeriesPoint("Terminadas", TablaOrdProdAutPorcentaje.Rows(0).Item("PorcentajeTerminadas")))

            ' Add the series to the chart.
            ChartControl7Prod.Series.Add(series2)
            ChartControl7Prod.Legend.Title.Text = "Porcentajes"
            ChartControl7Prod.Legend.Title.Font = New Font("Calibri", 12, FontStyle.Bold)
            ChartControl7Prod.Legend.Title.TextColor = Color.AliceBlue
            ChartControl7Prod.Legend.Title.Visible = True
            'ChartControl7Prod.Legend.MarkerMode = LegendMarkerMode.Marker

            ' Adjust the value numeric options of the series.
            series2.PointOptions.ValueNumericOptions.Format = NumericFormat.Percent
            series2.PointOptions.ValueNumericOptions.Precision = 2
            'series2.PointOptions.value

            ' Add a title to the chart and hide the legend.
            Dim chartTitle2 As New ChartTitle()
            chartTitle2.Text = "Órdenes de producción"
            ChartControl7Prod.Titles.Add(chartTitle1)
            ChartControl7Prod.Legend.Visible = False

            ' Add the chart to the form.
            ChartControl7Prod.Dock = DockStyle.None
            'Rotacion de Char3d
            ChartControl7Prod.RuntimeRotation = True
            '---grafica pie end

            '---gráfica de puntos
            ChartControl6Prod.DataSource = TablaOrdenesAutPorFecha
            'ChartControl6Prod.Titles(0).Text = "Órdenes autorizadas por fechas"

            If TablaOrdenesAutPorFecha.Rows.Count > 0 Then
                Dim series() As Series
                ReDim series(0)
                Dim contador = 0
                For Each rowAlm As DataRow In TablaOrdenesAutPorFecha.Rows
                    series(contador) = New Series(rowAlm.Item("Aut"), ViewType.Line)

                    Dim almacen = rowAlm.Item("Aut")
                    For Each rowOcupados As DataRow In TablaOrdenesAutPorFecha.Rows
                        If rowOcupados.Item("Aut") = almacen Then
                            series(contador).Points.Add(New SeriesPoint(rowOcupados.Item("FechaDeAutorización"), rowOcupados.Item("ÓrdenesAutorizadas")))
                        End If
                    Next
                    ChartControl6Prod.Series.Add(series(contador))

                    CType(series(contador).View, LineSeriesView).MarkerVisibility = DevExpress.Utils.DefaultBoolean.True
                    CType(series(contador).View, LineSeriesView).LineMarkerOptions.Size = 10
                    CType(series(contador).View, LineSeriesView).LineMarkerOptions.Kind = MarkerKind.Circle
                    CType(series(contador).View, LineSeriesView).LineStyle.DashStyle = DashStyle.Dash
                    Exit For
                Next
            End If
            Dim chartTitle3 As New ChartTitle()
            chartTitle3.Text = "Órdenes autorizadas por día"
            ChartControl6Prod.Titles.Add(chartTitle3)
            ChartControl6Prod.Legend.Visible = False

            Dim diagram As XYDiagram = CType(ChartControl6Prod.Diagram, XYDiagram)
            diagram.EnableAxisXScrolling = True
            diagram.EnableAxisXZooming = True
            diagram.EnableAxisYScrolling = True
            diagram.EnableAxisYZooming = True

            Dim axisX As AxisX = diagram.AxisX
            axisX.Label.Angle = 315
            diagram.AxisX.Title.Visible = False
            diagram.AxisX.Title.Alignment = StringAlignment.Center
            'diagram.AxisX.Title.Text = "Número de Parte" '_
            diagram.AxisX.Title.TextColor = Color.White
            diagram.AxisX.Title.Antialiasing = True
            diagram.AxisX.QualitativeScaleOptions.AutoGrid = False

            '---------Fin de pestaña detalle--------------------------------------------------------------

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message.ToString, "Error Productos por orden de producción", MessageBoxButtons.OK)
        End Try
    End Sub
End Class