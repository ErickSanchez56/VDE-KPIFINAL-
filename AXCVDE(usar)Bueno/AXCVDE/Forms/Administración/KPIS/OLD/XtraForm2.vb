Imports DevExpress.XtraCharts
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Base

Public Class XtraForm2


    Public pClienteSeleccionada As String = ""
    Public pCliente As String
    Public pIdCliente As Int64
    Public pAccion As Integer
    Public fechainicio As String
    Public fechafin As String
    Dim tablaGlobalOrdenesEmbarcadas As DataTable
    Dim tablaGlobalOrdenesEmbarcadasPromedio As DataTable
    Dim tablaGlobalOrdenesEmbarcadasGeneral As DataTable



#Region "RECEPCION"
    Private Sub GroupControl4_DoubleClick(sender As Object, e As EventArgs) Handles GroupControl4.DoubleClick
        Dim prmBusqueda2 As String
        Dim prmBusqueda3 As String
        If String.IsNullOrEmpty(dtpFechaInicio.Text) Then
            prmBusqueda2 = "@"
        Else
            prmBusqueda2 = dtpFechaInicio.Text
        End If
        Dim fecha As New Date
        fecha = Date.Parse(dtpFechaInicio.EditValue.ToString)
        If String.IsNullOrEmpty(dtpFechaFin.Text) Then
            prmBusqueda3 = "@"
        Else
            prmBusqueda3 = dtpFechaFin.Text
        End If
        Dim fecha2 As New Date
        fecha2 = Date.Parse(dtpFechaFin.EditValue.ToString)
        ''RECEPCION
        llenarGraficaDockToStock()
        ResultadoListaUsuarioxRecepcion(fecha, fecha2)
        ResultadoLista2(fecha, fecha2)
        ' ResultadoListaTiempoPromedioRecepcioOrdCompra(fecha, fecha2)
        TabPane1.SelectedPageIndex = 1
        TabNavigationPage15.PageVisible = True
    End Sub
    Private Sub llenarGraficaDockToStock()
        Try
            Dim objKPI As New clsKPI
            Dim resultado = objKPI.KPITiempoCicloRecepcion(IIf(String.IsNullOrEmpty(dtpFechaInicio.Text), Date.Parse(Today), dtpFechaInicio.Text), IIf(String.IsNullOrEmpty(dtpFechaFin.Text), Date.Parse(Today), dtpFechaFin.Text), My.Settings.Estacion, DatosTemporales.Usuario)
            If Not resultado.Estado Then
                XtraMessageBox.Show(resultado.Texto, "AXC")
                Return
            End If
            Dim tablaPromedio = resultado.Tablas.Tables(1)
            Dim tablaGeneral = resultado.Tablas.Tables(2)
            If tablaPromedio.Rows.Count > 0 Then
                'Gauges dashboard
                digitalGauge10.Text = tablaPromedio.Rows(0).Item("Dias")
                DigitalGauge1.Text = tablaPromedio.Rows(0).Item("Horas")
                DigitalGauge2.Text = tablaPromedio.Rows(0).Item("Minutos")
                'Gauges tiempo colocación
                DigitalGauge8.Text = tablaPromedio.Rows(0).Item("Dias")
                DigitalGauge7.Text = tablaPromedio.Rows(0).Item("Horas")
                DigitalGauge6.Text = tablaPromedio.Rows(0).Item("Minutos")
                'dgvDetalle1.DataSource = tablaPromedio
                dgvDetalle2.DataSource = tablaGeneral
            End If
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub
    Private Sub ResultadoListaUsuarioxRecepcion(prmBusqueda2 As Date, prmBusqueda3 As Date)
        Try
            Dim pResultado As New CResultado
            Dim Cls As New clsKPI
            Dim dt As New DataTable
            Cursor.Current = Cursors.WaitCursor
            pResultado = Cls.ResultadoListaUsuarioXRecepcion(prmBusqueda2, prmBusqueda3, My.Settings.Estacion, DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default
            dt = pResultado.Tabla
            Dim promediousuarioxrecepcion As DataTable
            promediousuarioxrecepcion = pResultado.Tablas.Tables(2)
            DigitalGauge20.Text = promediousuarioxrecepcion.Rows(0).Item("PromedioUsuariosPorOrdenRecepción")
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message.ToString, "Error", MessageBoxButtons.OK)
        End Try
    End Sub
    Private Sub ResultadoLista2(prmBusqueda2 As Date, prmBusqueda3 As Date)
        Try
            Dim pResultado As New CResultado
            Dim Cls As New clsKPI
            Dim dt As New DataTable
            Dim dt2 As New DataTable
            Dim dt3 As New DataTable
            Cursor.Current = Cursors.WaitCursor
            pResultado = Cls.ResultadoListaPartidasRec(prmBusqueda2, prmBusqueda3, My.Settings.Estacion, DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default
            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                dgvDetalle3.DataSource = Nothing
                Return
            End If
            Dim ds As New DataSet
            ds = pResultado.Tablas
            'ds.Tables.Add(dt)
            dt = ds.Tables(0)
            dt2 = ds.Tables(1)
            dt3 = ds.Tables(2)
            If dt2.Rows.Count < 1 Then
                XtraMessageBox.Show("Sin detalle de las ordenes", "AXC", MessageBoxButtons.OK)
                dgvDetalle3.DataSource = Nothing
                Return
            End If
            dgvDetalle3.DataSource = dt2
            GridView33.BestFitColumns()
            'dgvDetalle4.DataSource = dt3
            'GridView35.BestFitColumns()
            llenarGraficasRec(dt)
            llenarGraficaDockToStock(ds)
            llenarGraficas(dt3)
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message.ToString, "Error", MessageBoxButtons.OK)
        End Try
    End Sub
    Private Sub llenarGraficasRec(ByVal tablaPromedio As DataTable)
        Try
            If tablaPromedio.Rows.Count > 0 Then
                For Each row As DataRow In tablaPromedio.Rows
                    If row.Item("Recibos").ToString = row.Item("Recibos").ToString Then
                        LabelComponent23.Text = row.Item("Recibos").ToString
                        LabelComponent24.Text = "Recibos"
                    End If
                    If row.Item("Partidas Recibidas").ToString = row.Item("Partidas Recibidas").ToString Then
                        LabelComponent25.Text = row.Item("Partidas Recibidas").ToString
                        LabelComponent26.Text = "Partidas"
                    End If
                Next
            End If
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub
    Private Sub llenarGraficaDockToStock(ByRef ds As DataSet)
        Try
            If ds.Tables(0).Rows.Count > 0 Then
                'Gauges dashboard
                DigitalGauge9.Text = ds.Tables(0).Rows(0).Item("Dias")
                DigitalGauge11.Text = ds.Tables(0).Rows(0).Item("Horas")
                DigitalGauge12.Text = ds.Tables(0).Rows(0).Item("Minutos")
            End If
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub
    Private Sub llenarGraficas(ByVal dt As DataTable)
        Try
            If dt.Rows.Count > 0 Then
                ChartControl7.Titles.Clear()
                ChartControl7.Series.Clear()
                ChartControl7.DataSource = dt
                Dim series() As Series
                ReDim series(dt.Rows.Count - 1)
                Dim contador = 0
                For Each rowAlm As DataRow In dt.Rows
                    series(contador) = New Series(rowAlm.Item("FechaLiberacion"), ViewType.Bar)
                    Dim almacen = rowAlm.Item("FechaFinRec")
                    For Each rowOcupados As DataRow In dt.Rows
                        If rowOcupados.Item("FechaFinRec") = almacen Then
                            series(contador).Points.Add(New SeriesPoint(rowOcupados.Item("FechaFinRec"), rowOcupados.Item("Recibos")))
                        End If
                    Next
                    ChartControl7.Series.Add(series(contador))
                    contador += 1
                Next
                'Cast the chart's diagram to the XYDiagram type, to access its axes.
                Dim diagram As XYDiagram = CType(ChartControl7.Diagram, XYDiagram)
                diagram.EnableAxisXScrolling = True
                diagram.EnableAxisXZooming = False
                diagram.EnableAxisYScrolling = True
                diagram.EnableAxisYZooming = False
                diagram.AxisX.WholeRange.SetMinMaxValues(fechainicio, fechafin)
            End If
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub
#End Region

#Region "Almacen"
    Private Sub LabelControl4_Click(sender As Object, e As EventArgs)
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
        ''ALMACEN
        llenarGraficaAlmacenamientoDashbord()
        llenarGraficaOrdenesPrecisionInv()
        ResultadoLista5("", fecha, fecha2)
        TabPane1.SelectedPageIndex = 2
        TabNavigationPage5.PageVisible = True
    End Sub
    Private Sub llenarGraficaAlmacenamientoDashbord()
        Try
            Dim objKPI As New clsKPI
            Dim resultado = objKPI.KPIAlmacenamientoUtilizado("@", IIf(String.IsNullOrEmpty(dtpFechaInicio.Text), "@", dtpFechaInicio.Text), IIf(String.IsNullOrEmpty(dtpFechaFin.Text), "@", dtpFechaFin.Text), My.Settings.Estacion, DatosTemporales.Usuario)
            If Not resultado.Estado Then
                XtraMessageBox.Show(resultado.Texto, "AXC")
                Return
            End If
            Dim tablaPromedio = resultado.Tablas.Tables(2)
            Dim tablaGeneral = resultado.Tablas.Tables(3)
            Dim tablaDistintosAlmacenes = resultado.Tablas.Tables(1)
            llenarGraficasAlmacenamientoPestañaDashboard(tablaPromedio, tablaGeneral)
            llenarGraficasAlmacenamientoPestañaAlmacenamiento(tablaPromedio, tablaGeneral, tablaDistintosAlmacenes)
            dgvDetalle6.DataSource = tablaGeneral
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try

    End Sub
    Private Sub llenarGraficasAlmacenamientoPestañaDashboard(ByVal tablaPromedio As DataTable, ByVal tablaGeneral As DataTable)
        Try
            If tablaPromedio.Rows.Count > 0 Then
                For Each row As DataRow In tablaPromedio.Rows
                    If row.Item("Almacén") = "CEDIS" Then
                        'ArcScaleComponent3.Value = row.Item("Ocupación")

                        'LabelComponent3.Text = row.Item("Ocupación").ToString
                        ''  LabelComponent7.Text = row.Item("Almacén").ToString
                    End If
                Next
            End If
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub
    Private Sub llenarGraficasAlmacenamientoPestañaAlmacenamiento(ByVal tablaPromedio As DataTable, ByVal tablaGeneral As DataTable, ByVal tablaDistintosAlmacenes As DataTable)
        Try
            If tablaPromedio.Rows.Count > 0 Then
                'LLENAR TABLAS PESTAÑA ALMACENAMIENTO
                'dgvDetalle5.DataSource = tablaPromedio
                'LLENAR GRAFICAS PESTAÑA ALMACENAMIENTO
                For Each row As DataRow In tablaPromedio.Rows
                    If row.Item("Almacén") = "CEDIS" Then
                        ArcScaleComponent2.Value = row.Item("Ocupación")
                        LabelComponent2.Text = row.Item("Ocupación").ToString
                        'LabelComponent6.Text = row.Item("Almacén").ToString
                    End If
                Next
            End If
            ChartControl1.Titles.Clear()
            ChartControl1.Series.Clear()
            ChartControl1.Series.Clear()
            ChartControl1.DataSource = tablaGeneral
            If tablaGeneral.Rows.Count > 0 Then
                Dim series() As Series
                ReDim series(tablaDistintosAlmacenes.Rows.Count - 1)
                Dim contador = 0
                For Each rowAlm As DataRow In tablaDistintosAlmacenes.Rows
                    series(contador) = New Series(rowAlm.Item("Almacén"), ViewType.Line)
                    Dim almacen = rowAlm.Item("Almacén")
                    For Each rowOcupados As DataRow In tablaGeneral.Rows
                        If rowOcupados.Item("Almacén") = almacen Then
                            series(contador).Points.Add(New SeriesPoint(rowOcupados.Item("Fecha"), rowOcupados.Item("Ocupación")))
                        End If
                    Next
                    ChartControl1.Series.Add(series(contador))
                    CType(series(contador).View, LineSeriesView).MarkerVisibility = DevExpress.Utils.DefaultBoolean.True
                    CType(series(contador).View, LineSeriesView).LineMarkerOptions.Size = 10
                    CType(series(contador).View, LineSeriesView).LineMarkerOptions.Kind = MarkerKind.Circle
                    CType(series(contador).View, LineSeriesView).LineStyle.DashStyle = DashStyle.Dash
                    contador += 1
                Next
                'Cast the chart's diagram to the XYDiagram type, to access its axes.
                Dim diagram As XYDiagram = CType(ChartControl1.Diagram, XYDiagram)
                diagram.EnableAxisXScrolling = True
                diagram.EnableAxisXZooming = True
                diagram.EnableAxisYScrolling = True
                diagram.EnableAxisYZooming = True
                diagram.AxisX.WholeRange.SetMinMaxValues(dtpFechaInicio, dtpFechaFin)
            End If
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub

    Private Sub llenarGraficaOrdenesPrecisionInv()
        Try
            Dim objKPI As New clsKPI
            Dim resultado = objKPI.KPIPresicionInv(IIf(String.IsNullOrEmpty(dtpFechaInicio.Text), "@", dtpFechaInicio.Text), IIf(String.IsNullOrEmpty(dtpFechaFin.Text), "@", dtpFechaFin.Text), My.Settings.Estacion, DatosTemporales.Usuario)
            If Not resultado.Estado Then
                XtraMessageBox.Show("No hay información con los filtros solicitados", "AXC")
                Return
            End If
            Dim tablaPromedio = resultado.Tablas.Tables(1)
            Dim tablaGeneral = resultado.Tablas.Tables(2)
            If tablaPromedio.Rows.Count > 0 Then
                ArcScaleComponent10.Value = tablaPromedio.Rows(0).Item("Precisión")
                LabelComponent19.Text = tablaPromedio.Rows(0).Item("Precisión")
            End If
            llenarGraficasPestañaPrecisionInv(tablaGeneral, tablaPromedio)
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub
    Private Sub llenarGraficasPestañaPrecisionInv(ByVal tablaGeneral As DataTable, ByVal tablaPromedio As DataTable)
        Try

            dgvDetalle16.DataSource = tablaPromedio
            GridView14.BestFitColumns()
            dgvDetalle17.DataSource = tablaGeneral
            GridView13.BestFitColumns()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub
    Private Sub ResultadoLista5(prmBusqueda As String, prmBusqueda2 As Date, prmBusqueda3 As Date)
        Try
            Dim pResultado As New CResultado
            Dim Cls As New clsKPI
            Dim dt As New DataTable
            Cursor.Current = Cursors.WaitCursor
            pResultado = Cls.TiempoUbicaciónPallet(prmBusqueda, prmBusqueda2, prmBusqueda3, My.Settings.Estacion, DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default
            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                GridControl2.DataSource = Nothing
                Return
            End If
            Dim ds As New DataSet
            dt = pResultado.Tabla
            ds.Tables.Add(dt)
            Dim tablaPromedioGeneral As DataTable
            Dim tablaDetallePallet As DataTable
            'Dim tablaMym As DataTable
            tablaPromedioGeneral = pResultado.Tablas.Tables(1)
            tablaDetallePallet = pResultado.Tablas.Tables(3)
            'tablaMym = pResultado.Tablas.Tables(2)
            If dt.Rows.Count < 1 Then
                XtraMessageBox.Show("Sin información en el sistema", "AXC", MessageBoxButtons.OK)
                GridControl2.DataSource = Nothing
                Return
            End If
            DigitalGauge16.Text = tablaPromedioGeneral.Rows(0).Item("Dias")
            DigitalGauge15.Text = tablaPromedioGeneral.Rows(0).Item("Horas")
            DigitalGauge14.Text = tablaPromedioGeneral.Rows(0).Item("Minutos")
            GridControl2.DataSource = tablaDetallePallet
            ''dgvViewResultado.BestFitColumns()
            ChartControl10.Titles.Clear()
            ChartControl10.Series.Clear()
            ChartControl10.DataSource = tablaDetallePallet
            ChartControl10.Titles.Add(New ChartTitle() With {.Text = "Tiempo Promedio Recepción"})
            ChartControl10.Legend.Title.Text = ""
            ChartControl10.SeriesDataMember = "CodigoPallet"
            ChartControl10.SeriesTemplate.ValueDataMembers.AddRange(New String() {"TotalMinutos"})
            ChartControl10.SeriesTemplate.ArgumentDataMember = "CodigoPallet"
            ChartControl10.RuntimeHitTesting = True
            Dim view As SideBySideBarSeriesView = TryCast(ChartControl10.SeriesTemplate.View, SideBySideBarSeriesView)
            Dim diagram As XYDiagram = CType(ChartControl10.Diagram, XYDiagram)
            diagram.EnableAxisXScrolling = True
            diagram.EnableAxisXZooming = True
            diagram.EnableAxisYScrolling = True
            diagram.EnableAxisYZooming = True
            view.BarDistance = 0.5
            view.BarDistanceFixed = 0.5
            view.BarWidth = 3
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message.ToString, "Error", MessageBoxButtons.OK)
        End Try
    End Sub
#End Region

#Region "Produccion"
    Private Sub GroupControl17_DoubleClick(sender As Object, e As EventArgs) Handles GroupControl17.DoubleClick
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

        ''PRODUCCION
        ResultadoListaProductosPorOrdenProd(fecha, fecha2)
        ResultadoListaTiempoRegistroPT(fecha, fecha2)
        ResultadoLista3(fecha, fecha2)
        TabPane1.SelectedPageIndex = 3
        TabNavigationPage1.PageVisible = True

    End Sub
    Private Sub ResultadoListaProductosPorOrdenProd(prmBusqueda2 As Date, prmBusqueda3 As Date)
        Try
            Dim pResultado As New CResultado
            Dim Cls As New clsKPI
            Dim dt As New DataTable
            Cursor.Current = Cursors.WaitCursor
            pResultado = Cls.ResultadoListaProductosPorOrdenProduccion(prmBusqueda2, prmBusqueda3, My.Settings.Estacion, DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default
            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                dgvDetalle18.DataSource = Nothing
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
                dgvDetalle18.DataSource = Nothing
                Return
            End If
            dgvDetalle18.DataSource = TablaCantidadRegOrden
            GridView12.BestFitColumns()
            dgvDetalle19.DataSource = TablaNumParteAgrupa
            GridView11.BestFitColumns()
            ChartControl9.Titles.Clear()
            ChartControl9.Series.Clear()
            ChartControl9.DataSource = Nothing
            ChartControl9.DataSource = TablaCantidadRegOrden
            ChartControl9.Series.Clear()
            ChartControl9.Titles.Clear()
            ChartControl9.Titles.Add(New ChartTitle() With {.Text = "Top 10 Órdenes con más cantidades registradas"})
            ChartControl9.Legend.Title.Text = ""
            ChartControl9.SeriesDataMember = "Ordenproducción"
            ChartControl9.SeriesTemplate.ValueDataMembers.AddRange(New String() {"CantidadRegistradaPorOrden"})
            ChartControl9.SeriesTemplate.ArgumentDataMember = "Ordenproducción"
            ChartControl9.RuntimeHitTesting = True
            Dim view As SideBySideBarSeriesView = TryCast(ChartControl9.SeriesTemplate.View, SideBySideBarSeriesView)
            Dim diagram As XYDiagram = CType(ChartControl9.Diagram, XYDiagram)
            diagram.EnableAxisXScrolling = True
            diagram.EnableAxisXZooming = True
            diagram.EnableAxisYScrolling = True
            diagram.EnableAxisYZooming = True
            view.BarDistance = 0.5
            view.BarDistanceFixed = 0.5
            view.BarWidth = 0.5
            'Gauges
            DigitalGauge4.Text = TablaPromedioYTotal.Rows(0).Item("CantidadPromProductosXOrden")
            DigitalGauge21.Text = TablaPromedioYTotal.Rows(0).Item("CantidadPromProductosXOrden")
            ArcScaleComponent4.Value = TablaPromedioYTotal.Rows(0).Item("CantidadPromProductosXOrden")
            DigitalGauge3.Text = TablaPromedioYTotal.Rows(0).Item("CantidadDeProductoTotal")
            'ArcScaleComponent3.Value = TablaPromedioYTotal.Rows(0).Item("CantidadDeProductoTotal")
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message.ToString, "Error", MessageBoxButtons.OK)
        End Try
    End Sub
    Private Sub ResultadoListaTiempoRegistroPT(prmBusqueda2 As Date, prmBusqueda3 As Date)
        Try
            Dim pResultado As New CResultado
            Dim Cls As New clsKPI
            Dim dt As New DataTable
            Cursor.Current = Cursors.WaitCursor
            pResultado = Cls.ResultadoListaTiempoRegistroproductoTerminado(prmBusqueda2, prmBusqueda3, My.Settings.Estacion, DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default
            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                dgvDetalle22.DataSource = Nothing
                Return
            End If
            dt = pResultado.Tabla
            Dim TablaTiempoRegistroPromedio As DataTable
            TablaTiempoRegistroPromedio = pResultado.Tablas.Tables(1)
            Dim TablaDetalleTiemposurtidoxorden As DataTable
            TablaDetalleTiemposurtidoxorden = pResultado.Tablas.Tables(2)
            If dt.Rows.Count < 1 Then
                XtraMessageBox.Show("Sin información en el sistema", "AXC", MessageBoxButtons.OK)
                dgvDetalle22.DataSource = Nothing
                Return
            End If
            dgvDetalle22.DataSource = TablaDetalleTiemposurtidoxorden
            GridView37.BestFitColumns()
            'Gauges
            DigitalGauge5.Text = TablaTiempoRegistroPromedio.Rows(0).Item("Horas")
            DigitalGauge13.Text = TablaTiempoRegistroPromedio.Rows(0).Item("Minutos")
            DigitalGauge22.Text = TablaTiempoRegistroPromedio.Rows(0).Item("Horas")
            DigitalGauge23.Text = TablaTiempoRegistroPromedio.Rows(0).Item("Minutos")
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message.ToString, "Error", MessageBoxButtons.OK)
        End Try
    End Sub
    Private Sub ResultadoLista3(prmBusqueda2 As Date, prmBusqueda3 As Date)
        Try
            Dim pResultado As New CResultado
            Dim Cls As New clsKPI
            Dim dt As New DataTable
            Dim dt2 As New DataTable
            Dim dt3 As New DataTable
            Cursor.Current = Cursors.WaitCursor
            pResultado = Cls.ResultadoListaOrdenesProd(prmBusqueda2, prmBusqueda3)
            Cursor.Current = Cursors.Default
            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                dgvDetalle12.DataSource = Nothing
                Return
            End If
            Dim ds As New DataSet
            ds = pResultado.Tablas
            'ds.Tables.Add(dt)
            dt2 = ds.Tables(0)
            dt3 = ds.Tables(1)
            If dt2.Rows.Count < 1 Then
                XtraMessageBox.Show("Sin detalle de las ordenes", "AXC", MessageBoxButtons.OK)
                dgvDetalle23.DataSource = Nothing
                Return
            End If
            dgvDetalle23.DataSource = dt2
            '' GridView1.BestFitColumns()
            dgvDetalle24.DataSource = dt3
            ''GridView2.BestFitColumns()

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message.ToString, "Error", MessageBoxButtons.OK)
        End Try
    End Sub
#End Region


#Region "Embarques"
    Private Sub LabelControl6_Click(sender As Object, e As EventArgs)
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
        ''EMBARQUE
        llenarGraficaOrdenesCompletasEmbarcadas()
        ResultadoListaOrdSurtidasEmbarcadas(fecha, fecha2)
        ResultadoListaCantidadSurtidoTipos(fecha, fecha2)
        ResultadoLista6("", fecha, fecha2)
        ResultadoLista(fecha, fecha2)
        TabPane1.SelectedPageIndex = 4
        TabNavigationPage6.PageVisible = True
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
                    ArcScaleComponent4.Value = row.Item("PorcentajeEmbarcadas")
                    LabelComponent4.Text = row.Item("PorcentajeEmbarcadas").ToString
                End If
            End If
            'CARGA GAUGE PAGINA EMBARCADAS
            If tablaPromedio.Rows.Count > 0 Then
                Dim row As DataRow = tablaPromedio.Rows(0)
                If IsDBNull(row.Item("PorcentajeEmbarcadas")) Then
                Else
                    ArcScaleComponent9.Value = row.Item("PorcentajeEmbarcadas")
                    LabelComponent17.Text = row.Item("PorcentajeEmbarcadas").ToString
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
    Private Sub ResultadoListaOrdSurtidasEmbarcadas(prmBusqueda2 As Date, prmBusqueda3 As Date)
        Try
            Dim pResultado As New CResultado
            Dim Cls As New clsKPI
            Dim dt As New DataTable

            'pResultado = Cls.ResultadoListaEmpaques
            dt = pResultado.Tabla

            dgvDetalle9.DataSource = Nothing

            Cursor.Current = Cursors.WaitCursor
            pResultado = Cls.ResultadoListaOrdSurtidasEmbarcadas(prmBusqueda2, prmBusqueda3, My.Settings.Estacion, DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                dgvDetalle9.DataSource = Nothing
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
                dgvDetalle9.DataSource = Nothing
                Return
            End If

            dgvDetalle9.DataSource = dt
            ''GridView1.BestFitColumns()
            dgvDetalle11.DataSource = tablaDetalleSurtidas
            ''GridView3.BestFitColumns()
            dgvDetalle10.DataSource = tablaDettalleEmbarcadas
            ''GridView2.BestFitColumns()
            ChartControl3.DataSource = dt
            ChartControl5.DataSource = dt

            '''GRAFICA PIES ChartControl3 
            Dim series1 As New Series("Órdenes Embarque", ViewType.Pie)
            ' Populate the series with points.
            ChartControl3.Series.Clear()
            ChartControl3.Titles.Clear()
            series1.Points.Add(New SeriesPoint("PorcentajeÓrdenesEmbarcadas", dt.Rows(0).Item("PorcentajeÓrdenesEmbarcadas")))
            series1.Points.Add(New SeriesPoint("PorcentajeÓrdenesNoEmbarcadas", dt.Rows(0).Item("PorcentajeÓrdenesNoEmbarcadas")))
            ' Add the series to the chart.
            ChartControl3.Series.Add(series1)
            ' Adjust the value numeric options of the series.
            series1.PointOptions.ValueNumericOptions.Format = NumericFormat.Percent
            series1.PointOptions.ValueNumericOptions.Precision = 2
            ' Adjust the view-type-specific options of the series.
            CType(series1.View, PieSeriesView).ExplodedPoints.Add(series1.Points(0))
            Dim chartTitle1 As New ChartTitle()
            chartTitle1.Text = "Porcentaje de órdenes de embarque completas"
            ChartControl3.Titles.Add(chartTitle1)
            ChartControl3.Legend.Visible = True
            ' Add the chart to the form.
            ChartControl3.Dock = DockStyle.None
            '''GRAFICA PIES CHARTCONTROL 2
            Dim series2 As New Series("Partidas Embarque", ViewType.Pie)
            ' Populate the series with points.
            ChartControl5.Series.Clear()
            ChartControl5.Titles.Clear()
            series2.Points.Add(New SeriesPoint("PorcentajePartidasEmbarcadas", dt.Rows(0).Item("PorcentajePartidasEmbarcadas")))
            series2.Points.Add(New SeriesPoint("PorcentajePartidasNoEmbarcadas", dt.Rows(0).Item("PorcentajePartidasNoEmbarcadas")))
            ' Add the series to the chart.
            ChartControl5.Series.Add(series2)
            ' Adjust the value numeric options of the series.
            series2.PointOptions.ValueNumericOptions.Format = NumericFormat.Percent
            series2.PointOptions.ValueNumericOptions.Precision = 2

            ' Adjust the view-type-specific options of the series.
            CType(series2.View, PieSeriesView).ExplodedPoints.Add(series2.Points(0))
            ' Add a title to the chart and hide the legend.
            Dim chartTitle2 As New ChartTitle()
            chartTitle2.Text = "Porcentaje de partidas completas"
            ChartControl5.Titles.Add(chartTitle2)
            ChartControl5.Legend.Visible = True
            ' Add the chart to the form.
            ChartControl5.Dock = DockStyle.None
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


            dgvDetalle20.DataSource = Nothing



            Cursor.Current = Cursors.WaitCursor
            pResultado = Cls.ResultadoListaCantSurtidoTipos(prmBusqueda2, prmBusqueda3, My.Settings.Estacion, DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                dgvDetalle20.DataSource = Nothing
                Return
            End If

            dt = pResultado.Tabla
            Dim tablaDetalletipoSurtido As DataTable


            tablaDetalletipoSurtido = pResultado.Tablas.Tables(2)


            If dt.Rows.Count < 1 Then
                XtraMessageBox.Show("Sin información en el sistema", "AXC", MessageBoxButtons.OK)
                dgvDetalle20.DataSource = Nothing
                Return
            End If

            dgvDetalle20.DataSource = dt
            GridView3.BestFitColumns()
            dgvDetalle21.DataSource = tablaDetalletipoSurtido
            GridView4.BestFitColumns()

            ChartControl8.Titles.Clear()
            ChartControl8.Series.Clear()
            ChartControl8.Series.Clear()

            ChartControl8.DataSource = dt

            '''GRAFICA BARRAS

            Dim seriesL1 As Series = New Series("Ordenes Surtidas", ViewType.Bar)
            ' Add points to it.
            seriesL1.Points.Add(New SeriesPoint("Pallet", dt.Rows(0).Item("PALLET")))
            seriesL1.Points.Add(New SeriesPoint("Todo", dt.Rows(0).Item("MIXTO")))
            seriesL1.Points.Add(New SeriesPoint("Picking", dt.Rows(0).Item("PICKING")))
            seriesL1.Points.Add(New SeriesPoint("Producción", dt.Rows(0).Item("PRODUCCIÓN")))



            ' Add the series to the chart.
            ChartControl8.Series.Add(seriesL1)


            'Cast the chart's diagram to the XYDiagram type, to access its axes.
            Dim diagram As XYDiagram = CType(ChartControl8.Diagram, XYDiagram)
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
            CType(ChartControl8.Diagram, XYDiagram).AxisY.Interlaced = True
            CType(ChartControl8.Diagram, XYDiagram).AxisY.InterlacedColor = Color.FromArgb(20, 60, 60, 60)
            CType(ChartControl8.Diagram, XYDiagram).AxisX.NumericScaleOptions.AutoGrid = False
            CType(ChartControl8.Diagram, XYDiagram).AxisX.NumericScaleOptions.GridSpacing = 1
            ' Hide the legend (if necessary).
            'ChartControl8.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False
            ' Add a title to the chart (if necessary).
            ChartControl8.Titles.Add(New ChartTitle())
            ChartControl8.Titles(0).Text = "Ordenes surtidas por tipo"
            ' Add the chart to the form.
            ChartControl8.Dock = DockStyle.None

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message.ToString, "Error", MessageBoxButtons.OK)
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
            DigitalGauge34.Text = tablaPromedioTodo.Rows(0).Item("Dias")
            DigitalGauge33.Text = tablaPromedioTodo.Rows(0).Item("Horas")
            DigitalGauge32.Text = tablaPromedioTodo.Rows(0).Item("Minutos")
            DigitalGauge37.Text = tablaDetallePallet.Rows(0).Item("Dias")
            DigitalGauge36.Text = tablaDetallePallet.Rows(0).Item("Horas")
            DigitalGauge35.Text = tablaDetallePallet.Rows(0).Item("Minutos")
            DigitalGauge31.Text = tablaPromedioDetalle.Rows(0).Item("Dias")
            DigitalGauge30.Text = tablaPromedioDetalle.Rows(0).Item("Horas")
            DigitalGauge29.Text = tablaPromedioDetalle.Rows(0).Item("Minutos")
            ' GridControl3.DataSource = tablaDetallePallet
            'dgvViewResultado.BestFitColumns()
            ChartControl11.Titles.Clear()
            ChartControl11.Series.Clear()
            ChartControl11.DataSource = tablaCantidadOrdenes
            ChartControl11.Titles.Add(New ChartTitle() With {.Text = "Cantidad de pallets realizados"})
            ChartControl11.Legend.Title.Text = ""
            ChartControl11.SeriesDataMember = "Tipo"
            ChartControl11.SeriesTemplate.ValueDataMembers.AddRange(New String() {"Cantidad"})
            ChartControl11.SeriesTemplate.ArgumentDataMember = "Tipo"
            ChartControl11.RuntimeHitTesting = True
            Dim view As SideBySideBarSeriesView = TryCast(ChartControl11.SeriesTemplate.View, SideBySideBarSeriesView)
            Dim diagram As XYDiagram = CType(ChartControl11.Diagram, XYDiagram)
            diagram.EnableAxisXScrolling = True
            diagram.EnableAxisXZooming = True
            diagram.EnableAxisYScrolling = True
            diagram.EnableAxisYZooming = True
            view.BarDistance = 0.5
            view.BarDistanceFixed = 0.5
            view.BarWidth = 3
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
                dgvDetalle12.DataSource = Nothing
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
                dgvDetalle12.DataSource = Nothing
                Return
            End If
            dgvDetalle12.DataSource = dt2
            'GridView23.BestFitColumns()
            'dgvDetalle13.DataSource = dt3
            'GridView15.BestFitColumns()
            DigitalGauge19.Text = dt.Rows(0).Item("TotalembarquesaTiempo")
            DigitalGauge18.Text = dt.Rows(0).Item("OrdenesRetrazadas")
            DigitalGauge17.Text = dt.Rows(0).Item("Totalembarques")
            'GridControl4.DataSource = dt
            'GridView5.BestFitColumns()
            ''''GRAFICA DE DONA
            Dim series1 As New Series("Doughnut Series 1", ViewType.Pie)
            ' Populate the series with points.
            ChartControl2.Series.Clear()
            ChartControl2.Titles.Clear()
            series1.Points.Add(New SeriesPoint("ENVIADAS A TIEMPO", dt.Rows(0).Item("TotalembarquesaTiempo")))
            series1.Points.Add(New SeriesPoint("ORDENES RETRAZADAS", dt.Rows(0).Item("OrdenesRetrazadas")))
            '' series1.Points.Add(New SeriesPoint("TOTAL ENVIADAS", dt.Rows(0).Item("Totalembarques")))
            ' Add the series to the chart.
            ChartControl2.Series.Add(series1)
            ChartControl2.Legend.Title.Text = "ORDENES"
            ChartControl2.Legend.MarkerMode = LegendMarkerMode.Marker
            'ChartControl3.Legend
            ' Adjust the value numeric options of the series.
            series1.PointOptions.ValueNumericOptions.Format = NumericFormat.Percent
            series1.PointOptions.ValueNumericOptions.Precision = 2
            ' Add a title to the chart and hide the legend.
            Dim chartTitle1 As New ChartTitle()
            chartTitle1.Text = "ORDENES ENVIADAS A TIEMPO"
            ChartControl2.Titles.Add(chartTitle1)
            ChartControl2.Legend.Visible = False
            ' Add the chart to the form.
            ChartControl2.Dock = DockStyle.None
            'Rotacion de Char3d
            ChartControl2.RuntimeRotation = True
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message.ToString, "Error", MessageBoxButtons.OK)
        End Try
    End Sub
    Private Sub llenarGraficasPestañaEmbarques(ByVal tablaPromedio As DataTable, ByVal tablaGeneral As DataTable)
        Try

            'dgvDetalle7.DataSource = tablaPromedio
            'GridView8.BestFitColumns()
            dgvDetalle8.DataSource = tablaGeneral
            GridView7.BestFitColumns()
            tablaGlobalOrdenesEmbarcadas = tablaGeneral
            Dim series1 As New Series("Órdenes completas embarcadas", ViewType.Pie)

            ' Populate the series with points.
            ChartControl4.Series.Clear()
            ChartControl4.Titles.Clear()

            series1.Points.Add(New SeriesPoint("Embarcadas", tablaPromedio.Rows(0).Item("PorcentajeEmbarcadas")))
            series1.Points.Add(New SeriesPoint("Incompletas", tablaPromedio.Rows(0).Item("PorcentajeIncompletas")))

            ' Add the series to the chart.
            ChartControl4.Series.Add(series1)

            ' Adjust the value numeric options of the series.
            series1.PointOptions.ValueNumericOptions.Format = NumericFormat.Percent
            series1.PointOptions.ValueNumericOptions.Precision = 2

            ' Adjust the view-type-specific options of the series.
            CType(series1.View, PieSeriesView).ExplodedPoints.Add(series1.Points(0))


            ' Add a title to the chart and hide the legend.
            Dim chartTitle1 As New ChartTitle()
            chartTitle1.Text = "Órdenes completas embarcadas"
            ChartControl4.Titles.Add(chartTitle1)
            ChartControl4.Legend.Visible = False

            ' Add the chart to the form.
            ChartControl4.Dock = DockStyle.None

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub
    Private Sub dgvDetalle12_DoubleClick(sender As Object, e As EventArgs) Handles dgvDetalle12.DoubleClick
        Try
            ' Dim FrmPromedioSurtidoPorOrden As New FrmPromedioSurtidoPorOrden
            Dim view As ColumnView = CType(dgvDetalle12.MainView, ColumnView)
            Dim selectedRowHandles As Integer() = view.GetSelectedRows
            Dim OrdenEmbarque As String = ""
            OrdenEmbarque = (view.GetRowCellValue(selectedRowHandles(0), "OrdenEmbarque"))
            CARGARDETALLE(OrdenEmbarque)
            TabPane7.SelectedPageIndex = 5
            TabNavigationPage14.PageVisible = True

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub CARGARDETALLE(ByVal prmOrdenEmbarque)
        Dim pResultado As New CResultado
        Dim Cls As New clsKPI
        Dim dt As New DataTable
        Dim dt2 As New DataTable
        dgvDetalle14.DataSource = Nothing
        dgvDetalle15.DataSource = Nothing
        Cursor.Current = Cursors.WaitCursor
        pResultado = Cls.ResultadoOrdenEmb(prmOrdenEmbarque)
        Cursor.Current = Cursors.Default
        If Not pResultado.Estado Then
            XtraMessageBox.Show(pResultado.Texto)
            dgvDetalle14.DataSource = Nothing
            Return
        End If

        Dim ds As New DataSet

        ds = pResultado.Tablas
        'ds.Tables.Add(dt)
        dt = ds.Tables(0)
        dt2 = ds.Tables(1)
        If dt2.Rows.Count < 1 Then
            XtraMessageBox.Show("Sin detalle de las ordenes", "AXC", MessageBoxButtons.OK)
            dgvDetalle14.DataSource = Nothing
            Return
        End If
        dgvDetalle14.DataSource = dt
        'GridView1.BestFitColumns()
        dgvDetalle15.DataSource = dt2
        'GridView3.BestFitColumns()
        'GridView3.Columns("SEGUNDOS").Visible = False

        ''''GRAFICA MANHATTAN
        ' Add a bar series to it.
        ChartControl6.Series.Clear()
        ChartControl6.Titles.Clear()
        Dim seriesM1 As New Series("Tiempo De Surtido", ViewType.Bar)
        'Dim seriesM2 As New Series("Total Enviadas", ViewType.Bar)
        Dim int As Integer = 0
        ' Add points to the series.
        For Each Dr As DataRow In ds.Tables(1).Rows
            seriesM1.Points.Add(New SeriesPoint("Tiempo De Surtido Partida:" + dt2.Rows(int).Item("Partida"), dt2.Rows(int).Item("SEGUNDOS")))
            int = int + 1
        Next

        ' Add both series to the chart.
        ChartControl6.Series.AddRange(New Series() {seriesM1})

        ' Access labels of the first series.
        CType(seriesM1.Label, BarSeriesLabel).Visible = False
        ' CType(seriesM1.Label, BarSeriesLabel).ResolveOverlappingMode = ResolveOverlappingMode.Default
        'CType(seriesM2.Label, BarSeriesLabel).Visible = True

        ' Access the series options.
        seriesM1.PointOptions.PointView = PointView.ArgumentAndValues
        'seriesM2.PointOptions.PointView = PointView.ArgumentAndValues        ' Customize the view-type-specific properties of the series.

        ' Add a title to the chart and hide the legend.
        Dim chartTitle2 As New ChartTitle()
        chartTitle2.Text = "Tiempo De Surtido"
        ChartControl6.Titles.Add(chartTitle2)
        ChartControl6.Legend.Visible = True

        ' Add the chart to the form.
        ChartControl6.Dock = DockStyle.None
        ' Add Rotacion to chart 
    End Sub
#End Region




    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Try
            llenarPantallaDashboard()
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try

    End Sub





    Private Sub llenarPantallaDashboard()
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


        ''RECEPCION
        llenarGraficaDockToStock()
        ResultadoListaUsuarioxRecepcion(fecha, fecha2)
        ResultadoLista2(fecha, fecha2)
        'ResultadoListaTiempoPromedioRecepcioOrdCompra(fecha, fecha2)

        ''EMBARQUE
        llenarGraficaOrdenesCompletasEmbarcadas()
        ResultadoListaOrdSurtidasEmbarcadas(fecha, fecha2)
        ResultadoListaCantidadSurtidoTipos(fecha, fecha2)
        ResultadoLista6("", fecha, fecha2)
        ResultadoLista(fecha, fecha2)

        ''PRODUCCION
        ResultadoListaProductosPorOrdenProd(fecha, fecha2)
        ResultadoListaTiempoRegistroPT(fecha, fecha2)
        ResultadoLista3(fecha, fecha2)


        ''almacen
        llenarGraficaAlmacenamientoDashbord()
        llenarGraficaOrdenesPrecisionInv()
        ResultadoLista5("", fecha, fecha2)

    End Sub















    'Private Sub llenarGraficaOrdenesCompletasEmbarcadas()

    '    Try
    '        Dim objKPI As New clsKPI

    '        Dim resultado = objKPI.KPIOrdenesCompletasEmbarcadas(IIf(String.IsNullOrEmpty(dtpFechaInicio.Text), "@", dtpFechaInicio.Text), IIf(String.IsNullOrEmpty(dtpFechaFin.Text), "@", dtpFechaFin.Text), My.Settings.Estacion, DatosTemporales.Usuario)
    '        If Not resultado.Estado Then
    '            XtraMessageBox.Show(resultado.Texto, "AXC")
    '            Return
    '        End If

    '        Dim tablaPromedio = resultado.Tablas.Tables(1)
    '        Dim tablaGeneral = resultado.Tablas.Tables(2)
    '        tablaGlobalOrdenesEmbarcadasPromedio = tablaPromedio
    '        tablaGlobalOrdenesEmbarcadasGeneral = tablaPromedio

    '        If tablaPromedio.Rows.Count > 0 Then
    '            Dim row As DataRow = tablaPromedio.Rows(0)
    '            ArcScaleComponent4.Value = row.Item("PorcentajeEmbarcadas")
    '            LabelComponent4.Text = row.Item("PorcentajeEmbarcadas").ToString
    '        End If

    '        'CARGA GAUGE PAGINA EMBARCADAS
    '        If tablaPromedio.Rows.Count > 0 Then
    '            Dim row As DataRow = tablaPromedio.Rows(0)
    '            ArcScaleComponent9.Value = row.Item("PorcentajeEmbarcadas")
    '            LabelComponent17.Text = row.Item("PorcentajeEmbarcadas").ToString
    '        End If
    '        llenarGraficasPestañaEmbarques(tablaPromedio, tablaGeneral)

    '    Catch ex As Exception
    '        XtraMessageBox.Show(ex.Message, "AXC")
    '    End Try

    'End Sub







    Private Sub GridView7_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GridView7.RowClick
        Try

            ' Populate the series with points.
            ChartControl4.Series.Clear()
            ChartControl4.Titles.Clear()

            If GridView7.SelectedRowsCount <= 0 Then
                Return
            End If
            Dim rowIndex = GridView7.GetSelectedRows


            Dim series1 As New Series("Detalle diario órdenes embarcadas", ViewType.Pie)
            series1.Points.Add(New SeriesPoint("Liberadas Totales", tablaGlobalOrdenesEmbarcadas.Rows(rowIndex(0)).Item("PorcentajeLiberadasTotales")))
            series1.Points.Add(New SeriesPoint("Liberadas Parciales", tablaGlobalOrdenesEmbarcadas.Rows(rowIndex(0)).Item("PorcentajeLiberadasParciales")))
            series1.Points.Add(New SeriesPoint("Surtidas", tablaGlobalOrdenesEmbarcadas.Rows(rowIndex(0)).Item("PorcentajeSurtidas")))
            series1.Points.Add(New SeriesPoint("Validadas", tablaGlobalOrdenesEmbarcadas.Rows(rowIndex(0)).Item("PorcentajeValidadas")))
            series1.Points.Add(New SeriesPoint("Embarcadas", tablaGlobalOrdenesEmbarcadas.Rows(rowIndex(0)).Item("PorcentajeEmbarcadas")))
            series1.Points.Add(New SeriesPoint("Rechazadas", tablaGlobalOrdenesEmbarcadas.Rows(rowIndex(0)).Item("PorcentajeRechazadas")))
            ' Add the series to the chart.
            ChartControl4.Series.Add(series1)

            ' Adjust the value numeric options of the series.
            series1.PointOptions.ValueNumericOptions.Format = NumericFormat.Percent
            series1.PointOptions.ValueNumericOptions.Precision = 2

            ' Adjust the view-type-specific options of the series.
            CType(series1.View, PieSeriesView).ExplodedPoints.Add(series1.Points(0))


            ' Add a title to the chart and hide the legend.
            Dim chartTitle1 As New ChartTitle()
            chartTitle1.Text = "Órdenes completas embarcadas"
            ChartControl4.Titles.Add(chartTitle1)
            ChartControl4.Legend.Visible = False

            ' Add the chart to the form.
            ChartControl4.Dock = DockStyle.None

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub

    Private Sub TabNavigationPage23_Paint(sender As Object, e As PaintEventArgs) Handles TabNavigationPage23.Paint

    End Sub

    Private Sub XtraForm2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TabNavigationPage14.PageVisible = False
    End Sub

    'Private Sub XtraForm2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    llenarGraficaDockToStock()
    '    ''llenarGraficasAlmacenamientoPestañaDashboard(tablaPromedio, tablaGeneral)
    '    llenarGraficaOrdenesCompletasEmbarcadas()
    '    ResultadoListaTiempoRegistroPT(Date.Parse(Today), Date.Parse(Today))

    'End Sub







    'Private Sub ResultadoListaTiempoPromedioRecepcioOrdCompra(prmBusqueda2 As Date, prmBusqueda3 As Date)
    '    Try
    '        Dim pResultado As New CResultado
    '        Dim Cls As New clsKPI
    '        Dim dt As New DataTable

    '        'pResultado = Cls.ResultadoListaEmpaques
    '        dt = pResultado.Tabla

    '        'GridControl1.DataSource = Nothing

    '        Cursor.Current = Cursors.WaitCursor
    '        pResultado = Cls.ResultadoListaTiempoRecepcioOrdCompra(prmBusqueda2, prmBusqueda3, My.Settings.Estacion, DatosTemporales.Usuario)
    '        Cursor.Current = Cursors.Default

    '        If Not pResultado.Estado Then
    '            XtraMessageBox.Show(pResultado.Texto)
    '            'GridControl6.DataSource = Nothing ' Checar estos
    '            Return
    '        End If

    '        dt = pResultado.Tabla
    '        Dim tablaDetalleTiempoRec As DataTable
    '        Dim tablaDetalleMinutos As DataTable



    '        tablaDetalleTiempoRec = pResultado.Tablas.Tables(2)
    '        tablaDetalleMinutos = pResultado.Tablas.Tables(3)




    '        If dt.Rows.Count < 1 Then
    '            XtraMessageBox.Show("Sin información en el sistema", "AXC", MessageBoxButtons.OK)

    '            Return
    '        End If


    '        'GridControl6.DataSource = tablaDetalleTiempoRec 'Checar estos
    '        'GridView7.BestFitColumns()
    '        'dgvDetalle2.DataSource = tablaDetalleMinutos
    '        'GridView8.BestFitColumns()


    '        ChartControl4.Titles.Clear()
    '        ChartControl4.Series.Clear()
    '        ChartControl4.DataSource = tablaDetalleMinutos
    '        ChartControl4.Titles.Add(New ChartTitle() With {.Text = "Tiempo Promedio Recepción en Minutos"})
    '        ChartControl4.Legend.Title.Text = ""
    '        ChartControl4.SeriesDataMember = "OrdenCompra"
    '        ChartControl4.SeriesTemplate.ValueDataMembers.AddRange(New String() {"Minutos"})
    '        ChartControl4.SeriesTemplate.ArgumentDataMember = "OrdenCompra"
    '        ChartControl4.RuntimeHitTesting = True
    '        Dim view As SideBySideBarSeriesView = TryCast(ChartControl4.SeriesTemplate.View, SideBySideBarSeriesView)
    '        Dim diagram As XYDiagram = CType(ChartControl4.Diagram, XYDiagram)

    '        diagram.EnableAxisXScrolling = True
    '        diagram.EnableAxisXZooming = True
    '        diagram.EnableAxisYScrolling = True
    '        diagram.EnableAxisYZooming = True
    '        view.BarDistance = 0.5
    '        view.BarDistanceFixed = 0.5
    '        view.BarWidth = 3

    '        'GAUGES
    '        'DigitalGauge8.Text = dt.Rows(0).Item("Dias")-- el sp de Raúl no regresa días
    '        'DigitalGauge7.Text = dt.Rows(0).Item("Horas")
    '        'DigitalGauge6.Text = dt.Rows(0).Item("Minutos")

    '    Catch ex As Exception
    '        XtraMessageBox.Show(ex.Message.ToString, "Error", MessageBoxButtons.OK)
    '    End Try
    'End Sub










End Class