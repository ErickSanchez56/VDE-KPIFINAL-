Imports DevExpress.XtraCharts
Imports DevExpress.XtraEditors
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Globalization
Imports DevExpress.Utils
Imports DevExpress.XtraEditors.Repository

Public Class FrmKpiEmbarqueRes
    Public activaInfo As Boolean = True
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
        dtpFechaInicio.EditValue = Date.Parse(DateAdd(DateInterval.Day, -7, Today))
        dtpFechaFin.EditValue = Date.Parse(Today)
        llenarGraficaOrdenesCompletasEmbarcadas(Date.Parse(Today), Date.Parse(Today), dias)
        ResultadoLista6("", Date.Parse(Today), Date.Parse(Today), dias)
        ResultadoLista(Date.Parse(Today), Date.Parse(Today), dias)
        llenarGraficaAlmacenamientoDashbord(Date.Parse(Today), Date.Parse(Today), dias)
        cargaOrdenesEmbarque(Date.Parse(Today), Date.Parse(Today), dias)

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
    Private Sub llenarTotalEmbarquesUsuario(ByVal tablaPromedio As DataTable, ByVal tablaGeneral As DataTable, ByVal tablaGeneral1 As DataTable, ByVal usuario As String)
        Try


            '//*SE LLENA LOS CUADROS PRINCIPALES

            Dim Totalemb As String = tablaGeneral.Rows(0).Item("TotalOrdenes")
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

            LblTotaldeordenes.Text = Totalemb

            Lblordenesliberadas.Text = tablaGeneral.Rows(0).Item("LIBERADA TOTAL")
            LblTotaldeOrdenessurtidas.Text = tablaGeneral.Rows(0).Item("SURTIDA")
            LblOrdenesvalidadas.Text = tablaGeneral.Rows(0).Item("VALIDADA")

            'Lblordencompletas.Text = tablaGeneral.Rows(0).Item("EMBARCADA")

            Lblordenesembarcadas.Text = tablaGeneral.Rows(0).Item("EMBARCADA")

            'Lblporcentajecompletas.Text = "100%"

            LblCantidadC2.Text = tablaGeneral.Rows(0).Item("EMBARCADA")
            LblPorcentajecantidadc2.Text = "100%"

            Lblordenesporcentajedeliberadas.Text = tablaGeneral.Rows(0).Item("PorcentajeLiberadasTotales")
            Lblordenesporcentajedeliberadas.Text = Lblordenesporcentajedeliberadas.Text + "%"
            Lblordenesporcentajedevalidacion.Text = tablaGeneral.Rows(0).Item("PorcentajeSurtidas")
            Lblordenesporcentajedevalidacion.Text = Lblordenesporcentajedevalidacion.Text + "%"
            Lblporcentajedevalidacion.Text = tablaGeneral.Rows(0).Item("PorcentajeValidadas")
            Lblporcentajedevalidacion.Text = Lblporcentajedevalidacion.Text + "%"
            LblPorcentajedeordenesembarcadas.Text = tablaGeneral.Rows(0).Item("PorcentajeEmbarcadas")
            LblPorcentajedeordenesembarcadas.Text = LblPorcentajedeordenesembarcadas.Text + "%"

            LblTotalOrdenespendientes.Text = "0" 'incompletoN
            Lblporcentajedeordenespendientes.Text = "0" ' incompleto
            Lblporcentajedeordenespendientes.Text = Lblporcentajedeordenespendientes.Text + "%"



            '/**pantalla detalle



            Lbltotal2.Text = Totalemb

            lblEmbarcadas2.Text = tablaGeneral.Rows(0).Item("EMBARCADA")
            LblPorcentajeembarcadas.Text = tablaGeneral.Rows(0).Item("PorcentajeEmbarcadas")
            LblPorcentajeembarcadas.Text = LblPorcentajeembarcadas.Text + "%"


            LblPendientes.Text = "0" 'incompletoN
            Lblporcentajependientes2.Text = "0" 'incompleto
            Lblporcentajependientes2.Text = Lblporcentajependientes2.Text + "%"
            LblLiberadas.Text = tablaGeneral.Rows(0).Item("LIBERADA TOTAL")
            LblPorcentajeLiberadas.Text = tablaGeneral.Rows(0).Item("PorcentajeLiberadasTotales")
            LblPorcentajeLiberadas.Text = LblPorcentajeLiberadas.Text + "%"
            LblValidadas2.Text = tablaGeneral.Rows(0).Item("SURTIDA")
            LblPorcentajevalidacion2.Text = tablaGeneral.Rows(0).Item("PorcentajeSurtidas")
            LblPorcentajevalidacion2.Text = LblPorcentajevalidacion2.Text + "%"

            Lblvalidacion3.Text = tablaGeneral.Rows(0).Item("VALIDADA")

            Lblporcentajevalidacion3.Text = tablaGeneral.Rows(0).Item("PorcentajeValidadas")
            Lblporcentajevalidacion3.Text = Lblporcentajevalidacion3.Text + "%"














            '//*COMENZAMOS CON LA GRAFICA RESUMEN
            Dim series1 As New Series("Órdenes de embarcadas", ViewType.Pie)

            ' Populate the series with points.
            ChartOrdenesemb.Series.Clear()
            ChartOrdenesemb.Titles.Clear()

            series1.Points.Add(New SeriesPoint("Embarcadas", tablaGeneral.Rows(0).Item("PorcentajeEmbarcadas")))
            series1.Points.Add(New SeriesPoint("Liberadas", tablaGeneral.Rows(0).Item("PorcentajeLiberadasTotales")))
            series1.Points.Add(New SeriesPoint("Surtidas", tablaGeneral.Rows(0).Item("PorcentajeSurtidas")))
            series1.Points.Add(New SeriesPoint("Validadas", tablaGeneral.Rows(0).Item("PorcentajeValidadas")))




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

            '//*COMENZAMOS CON LA GRAFICA 

            Dim series2 As New Series("Órdenes de embarcadas", ViewType.Pie)

            ' Populate the series with points.
            ChartOrdenesemb2.Series.Clear()
            ChartOrdenesemb2.Titles.Clear()

            series2.Points.Add(New SeriesPoint("Embarcadas", tablaGeneral.Rows(0).Item("PorcentajeEmbarcadas")))
            series2.Points.Add(New SeriesPoint("Liberadas", tablaGeneral.Rows(0).Item("PorcentajeLiberadasTotales")))
            series2.Points.Add(New SeriesPoint("Surtidas", tablaGeneral.Rows(0).Item("PorcentajeSurtidas")))
            series2.Points.Add(New SeriesPoint("Validadas", tablaGeneral.Rows(0).Item("PorcentajeValidadas")))

            'series2.Points.Add(New SeriesPoint("Incompletas", tablaPromedio.Rows(0).Item("PorcentajeIncompletas")))

            ' Add the series to the chart.
            ChartOrdenesemb2.Series.Add(series2)

            ' Adjust the value numeric options of the series.
            series2.PointOptions.ValueNumericOptions.Format = NumericFormat.Percent
            series2.PointOptions.ValueNumericOptions.Precision = 2

            ' Adjust the view-type-specific options of the series.
            CType(series2.View, PieSeriesView).ExplodedPoints.Add(series2.Points(0))


            ' Add a title to the chart and hide the legend.
            Dim chartTitle2 As New ChartTitle()
            chartTitle2.Text = "Órdenes embarcadas "
            ChartOrdenesemb2.Titles.Add(chartTitle2)
            ChartOrdenesemb2.Legend.Visible = False

            ' Add the chart to the form.
            ChartOrdenesemb2.Dock = DockStyle.None

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub
    Private Sub GridView1_CustomRowCellEdit(sender As Object, e As DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs) Handles dgvViewEncabezado.CustomRowCellEdit
        If e.Column.FieldName = "Surtido" Then
            Dim rp As RepositoryItemProgressBar = New RepositoryItemProgressBar()

            rp.ProgressViewStyle = DevExpress.XtraEditors.Controls.ProgressViewStyle.Solid
            rp.ShowTitle = True
            rp.PercentView = False
            rp.DisplayFormat.FormatType = FormatType.Numeric
            rp.DisplayFormat.FormatString = "{0:n2}%"
            rp.Minimum = 0
            rp.Maximum = 100
            rp.LookAndFeel.UseDefaultLookAndFeel = False
            rp.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
            If e.CellValue < 50 Then
                rp.StartColor = Color.DarkOrange
                rp.EndColor = Color.Orange
            ElseIf e.CellValue > 50 And e.CellValue < 100 Then
                rp.StartColor = Color.YellowGreen
                rp.EndColor = Color.DarkGreen
            Else
                rp.StartColor = Color.Green
                rp.EndColor = Color.DarkGreen
            End If
            e.RepositoryItem = rp
        End If

        dgvViewEncabezado.Columns(5).Width = 200

        'dgvViewEncabezado.Appearance.HeaderPanel.FontSizeDelta = 5
        'dgvViewEncabezado.Appearance.Row.FontSizeDelta = 5
    End Sub
    Private Sub dgvViewEncabezado_RowCellStyle(sender As Object, e As RowCellStyleEventArgs) Handles dgvViewEncabezado.RowCellStyle
        Try
            Dim Estatus As String = dgvViewEncabezado.GetRowCellValue(e.RowHandle, "Surtido")
            If e.Column.Name = "Surtido" Then
                Select Case Estatus
                    Case "COMPLETO"
                        e.Appearance.BackColor = Color.Green
                    Case "INCOMPLETO"
                        e.Appearance.BackColor = Color.Orange
                    Case "SIN EXISTENCIA"
                        e.Appearance.BackColor = Color.Red
                    Case Else
                End Select
            End If
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
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
                Return
            End If
            Dim ds As New DataSet
            dt = pResultado.Tabla
            ds.Tables.Add(dt)
            Dim tablaPromedioTodo As DataTable
            Dim tablaPromedioDetalle As DataTable
            Dim tablaCantidadOrdenes As DataTable
            Dim tablaDetallePallet As DataTable

            tablaPromedioTodo = pResultado.Tablas.Tables(1)
            tablaDetallePallet = pResultado.Tablas.Tables(2)
            tablaPromedioDetalle = pResultado.Tablas.Tables(3)
            tablaCantidadOrdenes = pResultado.Tablas.Tables(4)

            If dt.Rows.Count < 1 Then
                XtraMessageBox.Show("Sin información en el sistema", "AXC", MessageBoxButtons.OK)
                Return
            End If
            Gdiasmixto.Text = IIf(IsDBNull(tablaPromedioTodo.Rows(0).Item("Dias")), 0, tablaPromedioTodo.Rows(0).Item("Dias"))
            Gdiasmixto2.Text = IIf(IsDBNull(tablaPromedioTodo.Rows(0).Item("Dias")), 0, tablaPromedioTodo.Rows(0).Item("Dias"))

            Ghorasmixto.Text = IIf(IsDBNull(tablaPromedioTodo.Rows(0).Item("Horas")), 0, tablaPromedioTodo.Rows(0).Item("Horas"))
            Ghorasmixto2.Text = IIf(IsDBNull(tablaPromedioTodo.Rows(0).Item("Horas")), 0, tablaPromedioTodo.Rows(0).Item("Horas"))

            Gminutosmixto.Text = IIf(IsDBNull(tablaPromedioTodo.Rows(0).Item("Minutos")), 0, tablaPromedioTodo.Rows(0).Item("Minutos"))
            Gminutosmixto2.Text = IIf(IsDBNull(tablaPromedioTodo.Rows(0).Item("Minutos")), 0, tablaPromedioTodo.Rows(0).Item("Minutos"))




            Gdiaspallet.Text = IIf(IsDBNull(tablaDetallePallet.Rows(0).Item("Dias")), 0, tablaDetallePallet.Rows(0).Item("Dias"))
            Ghoraspallet.Text = IIf(IsDBNull(tablaDetallePallet.Rows(0).Item("Horas")), 0, tablaDetallePallet.Rows(0).Item("Horas"))
            Gminutospallets.Text = IIf(IsDBNull(tablaDetallePallet.Rows(0).Item("Minutos")), 0, tablaDetallePallet.Rows(0).Item("Minutos"))

            Gdiaspicking.Text = IIf(IsDBNull(tablaPromedioDetalle.Rows(0).Item("Dias")), 0, tablaPromedioDetalle.Rows(0).Item("Dias"))
            Ghoraspicking.Text = IIf(IsDBNull(tablaPromedioDetalle.Rows(0).Item("Horas")), 0, tablaPromedioDetalle.Rows(0).Item("Horas"))
            Gminutospicking.Text = IIf(IsDBNull(tablaPromedioDetalle.Rows(0).Item("Minutos")), 0, tablaPromedioDetalle.Rows(0).Item("Minutos"))






            Gdiasmixtoxpartida.Text = IIf(IsDBNull(tablaCantidadOrdenes.Rows(0).Item("Dias")), 0, tablaCantidadOrdenes.Rows(0).Item("Dias"))
            Ghorasmixtoxpartida.Text = IIf(IsDBNull(tablaCantidadOrdenes.Rows(0).Item("Horas")), 0, tablaCantidadOrdenes.Rows(0).Item("Horas"))
            Gminutosmixtoxpartida.Text = IIf(IsDBNull(tablaCantidadOrdenes.Rows(0).Item("Minutos")), 0, tablaCantidadOrdenes.Rows(0).Item("Minutos"))


            Gdiasmixtoxpartida2.Text = IIf(IsDBNull(tablaCantidadOrdenes.Rows(0).Item("Dias")), 0, tablaCantidadOrdenes.Rows(0).Item("Dias"))
            Ghorasmixtoxpartida2.Text = IIf(IsDBNull(tablaCantidadOrdenes.Rows(0).Item("Horas")), 0, tablaCantidadOrdenes.Rows(0).Item("Horas"))
            Gminutosmixtoxpartida2.Text = IIf(IsDBNull(tablaCantidadOrdenes.Rows(0).Item("Minutos")), 0, tablaCantidadOrdenes.Rows(0).Item("Minutos"))






            dgvDetalleTiemposurtido.DataSource = pResultado.Tablas.Tables(5)
            DgvVistaSurtido.BestFitColumns()

            DgvVistaSurtido.Columns("Total minutos").Visible = False

            Chartcontrolsurtido.Titles.Clear()
            Chartcontrolsurtido.Series.Clear()

            '/***aqui la grafica mas tardadas en 
            Chartcontrolsurtido.DataSource = pResultado.Tablas.Tables(6)
            Chartcontrolsurtido.Titles.Add(New ChartTitle() With {.Text = "Órdenes con mayor tiempo de surtido"})
            Chartcontrolsurtido.Legend.Title.Text = "Órdenes de embarque"
            Chartcontrolsurtido.Legend.Title.Font = New Font("Calibri", 12, FontStyle.Bold)
            Chartcontrolsurtido.Legend.Title.TextColor = Color.AliceBlue


            Chartcontrolsurtido.SeriesDataMember = "Orden embarque"


            'Chartcontrolsurtido.Legend.TextVisible = False

            'Chartcontrolsurtido.Legend.ItemVisibilityMode = False
            'Chartcontrolsurtido.Legend.Visibility = False
            Chartcontrolsurtido.SeriesTemplate.ValueDataMembers.AddRange(New String() {"Total minutos"})



            Chartcontrolsurtido.SeriesTemplate.ArgumentDataMember = "Orden embarque"
            Chartcontrolsurtido.RuntimeHitTesting = True



            Chartcontrolsurtido.Legend.Title.Visible = True
            'Chartcontrolsurtido.SeriesNameTemplate.BeginText = "Horas: "

            Dim diagram As XYDiagram = CType(Chartcontrolsurtido.Diagram, XYDiagram)
            Dim axisX As AxisX = diagram.AxisX
            axisX.Label.Angle = 315

            diagram.EnableAxisXScrolling = True
            diagram.EnableAxisXZooming = True

            diagram.EnableAxisYScrolling = True
            diagram.EnableAxisYZooming = True

            Dim view As SideBySideBarSeriesView = TryCast(Chartcontrolsurtido.SeriesTemplate.View, SideBySideBarSeriesView)
            'Dim diagram As XYDiagram = CType(Chartcontrolsurtido.Diagram, XYDiagram)

            'Dim axisX As AxisX = diagram.AxisX
            'axisX.Label.Angle = 315
            'axisX.QualitativeScaleOptions.AutoGrid = False


            diagram.AxisX.Title.Visible = True
            diagram.AxisX.Title.Alignment = StringAlignment.Center
            diagram.AxisX.Title.Text = "Órdenes de embarque"
            diagram.AxisX.Title.TextColor = Color.White
            diagram.AxisX.Title.Antialiasing = True

            diagram.AxisY.Title.Visible = True
            diagram.AxisY.Title.Alignment = StringAlignment.Center
            diagram.AxisY.Title.Text = "Horas"
            diagram.AxisY.Title.TextColor = Color.White
            diagram.AxisY.Title.Antialiasing = True

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
            dt = ds.Tables(0)
            dt2 = ds.Tables(1)
            dt3 = ds.Tables(2)
            If dt3.Rows.Count < 1 Then
                XtraMessageBox.Show("Sin detalle de las ordenes", "AXC", MessageBoxButtons.OK)
            End If


            'Lblordenesatiempo.Text = dt.Rows(0).Item("TotalembarquesaTiempo")

            LblOatiempo2.Text = dt.Rows(0).Item("TotalembarquesaTiempo")

            'Lblordenesretrazadas.Text = dt.Rows(0).Item("OrdenesRetrazadas")

            '  Nordenestotal.Text = dt.Rows(0).Item("Totalembarques")
            'Lblporcentajeordenesatiempo.Text = dt2.Rows(0).Item("PorcentajeOrdenesEmb")

            '            Lblporcentajeordenesatiempo.Text = Lblporcentajeordenesatiempo.Text + "%"

            LblPorcentajeatiempo2.Text = dt2.Rows(0).Item("PorcentajeOrdenesEmb")
            LblPorcentajeatiempo2.Text = LblPorcentajeatiempo2.Text + "%"


            dgvDetalleordenescompl.DataSource = dt3
            dgvviewcompl.BestFitColumns()
            'Lbloporcentajedeordenesretrazadas.Text = dt2.Rows(0).Item("PorcentajeOrdenesRetrazadas")

            'Lbloporcentajedeordenesretrazadas.Text = Lbloporcentajedeordenesretrazadas.Text + "%"

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message.ToString, "Error", MessageBoxButtons.OK)
        End Try
    End Sub
    Private Sub llenarGraficasAlmacenamientoPestañaAlmacenamiento(ByVal tablaDistintosAlmacenes As DataTable)
        Try


            ChartOrdenesembXDIA.Titles.Clear()
            ChartOrdenesembXDIA.Series.Clear()

            Chartcontrolembarquespordia.Titles.Clear()
            Chartcontrolembarquespordia.Series.Clear()



            ChartOrdenesembXDIA.DataSource = tablaDistintosAlmacenes
            Chartcontrolembarquespordia.DataSource = tablaDistintosAlmacenes

            If tablaDistintosAlmacenes.Rows.Count > 0 Then
                Dim series() As Series
                ReDim series(0)
                Dim contador = 0
                For Each rowAlm As DataRow In tablaDistintosAlmacenes.Rows
                    series(contador) = New Series(rowAlm.Item("Almacen"), ViewType.Line)

                    Dim almacen = rowAlm.Item("Almacen")
                    For Each rowOcupados As DataRow In tablaDistintosAlmacenes.Rows
                        If rowOcupados.Item("Almacen") = almacen Then
                            series(contador).Points.Add(New SeriesPoint(rowOcupados.Item("Fecha"), rowOcupados.Item("Órdenes Embarcadas")))
                        End If

                    Next
                    ChartOrdenesembXDIA.Series.Add(series(contador))


                    CType(series(contador).View, LineSeriesView).MarkerVisibility = DevExpress.Utils.DefaultBoolean.True
                    CType(series(contador).View, LineSeriesView).LineMarkerOptions.Size = 10
                    CType(series(contador).View, LineSeriesView).LineMarkerOptions.Kind = MarkerKind.Circle
                    CType(series(contador).View, LineSeriesView).LineStyle.DashStyle = DashStyle.Dash
                    Exit For
                Next

                ' Add a title to the chart and hide the legend.
                Dim chartTitle1 As New ChartTitle()
                chartTitle1.Text = "Total de órdenes embarcadas por día"
                ChartOrdenesembXDIA.Titles.Add(chartTitle1)
                ChartOrdenesembXDIA.Legend.Visible = False


                'Cast the chart's diagram to the XYDiagram type, to access its axes.
                Dim diagram As XYDiagram = CType(ChartOrdenesembXDIA.Diagram, XYDiagram)
                Dim axisX As AxisX = diagram.AxisX
                axisX.Label.Angle = 315

                diagram.EnableAxisXScrolling = True
                diagram.EnableAxisXZooming = True

                diagram.EnableAxisYScrolling = True
                diagram.EnableAxisYZooming = True










            End If


            If tablaDistintosAlmacenes.Rows.Count > 0 Then
                Dim series() As Series
                ReDim series(0)
                Dim contador = 0
                For Each rowAlm As DataRow In tablaDistintosAlmacenes.Rows
                    series(contador) = New Series(rowAlm.Item("Almacen"), ViewType.Line)

                    Dim almacen = rowAlm.Item("Almacen")
                    For Each rowOcupados As DataRow In tablaDistintosAlmacenes.Rows
                        If rowOcupados.Item("Almacen") = almacen Then
                            series(contador).Points.Add(New SeriesPoint(rowOcupados.Item("Fecha"), rowOcupados.Item("Órdenes Embarcadas")))
                        End If

                    Next
                    Chartcontrolembarquespordia.Series.Add(series(contador))


                    CType(series(contador).View, LineSeriesView).MarkerVisibility = DevExpress.Utils.DefaultBoolean.True
                    CType(series(contador).View, LineSeriesView).LineMarkerOptions.Size = 10
                    CType(series(contador).View, LineSeriesView).LineMarkerOptions.Kind = MarkerKind.Circle
                    CType(series(contador).View, LineSeriesView).LineStyle.DashStyle = DashStyle.Dash
                    Exit For
                Next

                ' Add a title to the chart and hide the legend.
                Dim chartTitle1 As New ChartTitle()
                chartTitle1.Text = "Total de órdenes embarcadas por día"
                Chartcontrolembarquespordia.Titles.Add(chartTitle1)
                Chartcontrolembarquespordia.Legend.Visible = False


                'Cast the chart's diagram to the XYDiagram type, to access its axes.
                Dim diagram As XYDiagram = CType(Chartcontrolembarquespordia.Diagram, XYDiagram)
                Dim axisX As AxisX = diagram.AxisX
                axisX.Label.Angle = 315

                diagram.EnableAxisXScrolling = True
                diagram.EnableAxisXZooming = True

                diagram.EnableAxisYScrolling = True
                diagram.EnableAxisYZooming = True
            End If



        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
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
        llenarGraficaAlmacenamientoDashbord(fecha, fecha2, 0)
        cargaOrdenesEmbarque(fecha, fecha2, 0)
    End Sub

    'Private Sub ChartOrdenesembXDIA_MouseHover(sender As Object, e As EventArgs) Handles ChartOrdenesembXDIA.MouseHover
    '    ChartOrdenesembXDIA.Anchor = AnchorStyles.Right
    '    ChartOrdenesembXDIA.Location = New Point(400, 291)
    '    ChartOrdenesembXDIA.Width = (678)
    '    ChartOrdenesembXDIA.Height = (318)
    '    'ChartOrdenesembXDIA.Anchor = AnchorStyles.Top
    '    ''ChartOrdenesembXDIA.Anchor = AnchorStyles.Bottom
    '    'ChartOrdenesembXDIA.Anchor = AnchorStyles.Left


    'End Sub

    'Private Sub ChartOrdenesembXDIA_MouseLeave(sender As Object, e As EventArgs) Handles ChartOrdenesembXDIA.MouseLeave
    '    'ChartOrdenesembXDIA.Anchor = AnchorStyles.Top
    '    ''ChartOrdenesembXDIA.Anchor = AnchorStyles.Bottom
    '    'ChartOrdenesembXDIA.Anchor = AnchorStyles.Left
    '    ChartOrdenesembXDIA.Anchor = AnchorStyles.Right
    '    ChartOrdenesembXDIA.Location = New Point(690, 439)
    '    ChartOrdenesembXDIA.Width = (390)
    '    ChartOrdenesembXDIA.Height = (157)




    'End Sub
    Public Sub cargaOrdenesEmbarque(prmBusqueda2 As Date, prmBusqueda3 As Date, dias As String)
        Try
            'If primera Then
            '    Return
            'End If
            dgvOrdenes.DataSource = Nothing
            Dim pResultado As New CResultado
            Dim Cls As New ClsKPIEMB
            Cursor.Current = Cursors.WaitCursor
            pResultado = Cls.Estatus(prmBusqueda2, prmBusqueda3, dias)
            Cursor.Current = Cursors.Default
            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                dgvOrdenes.DataSource = Nothing
                Return
            End If
            Dim dtEncabezado As New DataTable
            Dim ds As New DataSet
            ds = pResultado.Tablas
            dtEncabezado = ds.Tables(1)
            dtEncabezado.TableName = "Encabezado"
            If dtEncabezado.Rows.Count < 1 Then
                XtraMessageBox.Show("No hay información de pedidos con los filtros seleccionados")
                dgvOrdenes.DataSource = Nothing
                Return
            End If
            dgvOrdenes.DataSource = ds.Tables("Encabezado")
            dgvViewEncabezado.BestFitColumns()
            dgvViewEncabezado.Columns(5).Width = 200
            'dgvViewEncabezado.Appearance.HeaderPanel.FontSizeDelta = 10
            'dgvViewEncabezado.Appearance.Row.FontSizeDelta = 107


        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub CambiarLabel()
        If NavigationFrame1.SelectedPageIndex = 0 Then
            LabelPrincipal.Text = "Resumen"
        End If
        If NavigationFrame1.SelectedPageIndex = 1 Then
            LabelPrincipal.Text = "Tiempo promedio de surtido"
        End If
        If NavigationFrame1.SelectedPageIndex = 2 Then
            LabelPrincipal.Text = "Órdenes en proceso"
        End If
        If NavigationFrame1.SelectedPageIndex = 3 Then
            LabelPrincipal.Text = "Órdenes embarcadas"
        End If
    End Sub
    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        NavigationFrame1.SelectNextPage()
        CambiarLabel()
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        NavigationFrame1.SelectPrevPage()
        CambiarLabel()

    End Sub

    Private Sub Panel17_Click(sender As Object, e As EventArgs) Handles Panel17.Click
        If activaInfo Then
            XtraMessageBox.Show("Muestra el total de órdenes de embarque de las fechas seleccionadas / Desde " + dtpFechaInicio.Text + " hasta " + dtpFechaFin.Text + "", "AXC")
        End If
    End Sub

    Private Sub Panel18_Click(sender As Object, e As EventArgs) Handles Panel18.Click
        If activaInfo Then
            XtraMessageBox.Show("Muestra el total de órdenes de embarque que se han liberado y no se han comenzado a surtir o iniciaron el surtido y aun no finaliza el surtido, / Desde " + dtpFechaInicio.Text + " hasta " + dtpFechaFin.Text + "", "AXC")
        End If
    End Sub
    Private Sub LabelControl43_Click(sender As Object, e As EventArgs) Handles LabelControl43.Click
        If activaInfo Then
            XtraMessageBox.Show("Muestra el total de órdenes de embarque que se han liberado y no se han comenzado a surtir o iniciaron el surtido y aun no finaliza el surtido, / Desde " + dtpFechaInicio.Text + " hasta " + dtpFechaFin.Text + "", "AXC")
        End If
    End Sub

    Private Sub Panel21_Click(sender As Object, e As EventArgs) Handles Panel21.Click
        If activaInfo Then
            XtraMessageBox.Show("Muestra el total de órdenes de embarque que se han liberado, con el surtido finalizado, pendiente de finalizar la validación, / Desde " + dtpFechaInicio.Text + " hasta " + dtpFechaFin.Text + "", "AXC")
        End If
    End Sub
    Private Sub LabelControl51_Click(sender As Object, e As EventArgs) Handles LabelControl51.Click
        If activaInfo Then
            XtraMessageBox.Show("Muestra el total de órdenes de embarque que se han liberado, con el surtido finalizado, pendiente de finalizar la validación, / Desde " + dtpFechaInicio.Text + " hasta " + dtpFechaFin.Text + "", "AXC")
        End If
    End Sub

    Private Sub Panel22_Click(sender As Object, e As EventArgs) Handles Panel22.Click
        If activaInfo Then
            XtraMessageBox.Show("Muestra el total de órdenes de embarque que se han liberado, con el surtido finalizado, validadas, pendientes de reempacar,/ Desde " + dtpFechaInicio.Text + " hasta " + dtpFechaFin.Text + "", "AXC")
        End If
    End Sub
    Private Sub LabelControl53_Click(sender As Object, e As EventArgs) Handles LabelControl53.Click
        If activaInfo Then
            XtraMessageBox.Show("Muestra el total de órdenes de embarque que se han liberado, con el surtido finalizado, validadas, pendientes de reempacar,/ Desde " + dtpFechaInicio.Text + " hasta " + dtpFechaFin.Text + "", "AXC")
        End If
    End Sub

    Private Sub Panel19_Click(sender As Object, e As EventArgs) Handles Panel19.Click
        If activaInfo Then
            XtraMessageBox.Show("Muestra el total de órdenes de embarque que se han finalizado completamente, / Desde " + dtpFechaInicio.Text + " hasta " + dtpFechaFin.Text + "", "AXC")
        End If
    End Sub
    Private Sub Panel20_Click(sender As Object, e As EventArgs) Handles Panel20.Click
        If activaInfo Then
            XtraMessageBox.Show("Muestra el total de órdenes de embarque que se han finalizado parcialmente, / Desde " + dtpFechaInicio.Text + " hasta " + dtpFechaFin.Text + "", "AXC")
        End If
    End Sub



    Private Sub ChartOrdenesemb_Click(sender As Object, e As EventArgs) Handles ChartOrdenesemb.Click
        If activaInfo Then
            XtraMessageBox.Show("En esta grafica se muestra el porcentaje de órdenes que estan en un proceso en especifico , / Desde " + dtpFechaInicio.Text + " hasta " + dtpFechaFin.Text + "", "AXC")
        End If

    End Sub


    Private Sub ChartOrdenesembXDIA_Click(sender As Object, e As EventArgs) Handles ChartOrdenesembXDIA.Click
        If activaInfo Then
            XtraMessageBox.Show("En esta grafica se muestran los picos, más bien cuantos embarques que se completan por día., / Desde " + dtpFechaInicio.Text + " hasta " + dtpFechaFin.Text + "", "AXC")
        End If
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click


        If activaInfo = False Then
            If XtraMessageBox.Show("Cada control cuenta con un mensaje de ayuda al momento de dar click sobre ellos, ¿Deseas activarlos?", "AXC", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                activaInfo = True
                GroupControl3.CustomHeaderButtons.Item(0).Properties.Visible = True
                GroupControl15.CustomHeaderButtons.Item(0).Properties.Visible = True
                GroupControl5.CustomHeaderButtons.Item(0).Properties.Visible = True
                GroupControl10.CustomHeaderButtons.Item(0).Properties.Visible = True

            Else
                activaInfo = False
                GroupControl3.CustomHeaderButtons.Item(0).Properties.Visible = False
                GroupControl15.CustomHeaderButtons.Item(0).Properties.Visible = False
                GroupControl5.CustomHeaderButtons.Item(0).Properties.Visible = False
                GroupControl10.CustomHeaderButtons.Item(0).Properties.Visible = False
            End If
        Else
            If XtraMessageBox.Show("Cada control cuenta con un mensaje de ayuda al momento de dar click sobre ellos, ¿Deseas descartivarlos?", "AXC", MessageBoxButtons.YesNo) <> DialogResult.Yes Then
                activaInfo = True
                GroupControl3.CustomHeaderButtons.Item(0).Properties.Visible = True
                GroupControl15.CustomHeaderButtons.Item(0).Properties.Visible = True
                GroupControl5.CustomHeaderButtons.Item(0).Properties.Visible = True
                GroupControl10.CustomHeaderButtons.Item(0).Properties.Visible = True
            Else
                activaInfo = False
                GroupControl3.CustomHeaderButtons.Item(0).Properties.Visible = False
                GroupControl15.CustomHeaderButtons.Item(0).Properties.Visible = False
                GroupControl5.CustomHeaderButtons.Item(0).Properties.Visible = False
                GroupControl10.CustomHeaderButtons.Item(0).Properties.Visible = False
            End If

        End If

    End Sub

End Class
