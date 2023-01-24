Imports DevExpress.XtraCharts
Imports DevExpress.XtraEditors

Public Class FrmPrecision
    Public fechainicio As String
    Public fechafin As String
    Dim tablaGlobalOrdenesEmbarcadas As DataTable
    Dim tablaGlobalOrdenesEmbarcadasPromedio As DataTable
    Dim tablaGlobalOrdenesEmbarcadasGeneral As DataTable

    Private Sub FrmPrecision_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TabPane2.Pages.Item(1).Hide()
        TabPane2.Pages.Item(2).Hide()

        Timer1.Stop()
        Timer1.Interval = 5000
        TabNavigationPage3.PageVisible = False
        TabNavigationPage4.PageVisible = False
    End Sub


    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click

        Try

            llenarPantallaDashboard()


        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try

    End Sub

    Private Sub llenarPantallaDashboard()

        llenarGraficaAlmacenamientoDashbord()
        llenarGraficaOrdenesCompletasEmbarcadas()
        llenarGraficaOrdenesPrecisionInv()
        llenarGraficaDockToStock()
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

            GridControl3.DataSource = tablaGeneral

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try

    End Sub

    Private Sub llenarGraficasAlmacenamientoPestañaDashboard(ByVal tablaPromedio As DataTable, ByVal tablaGeneral As DataTable)
        Try
            If tablaPromedio.Rows.Count > 0 Then
                For Each row As DataRow In tablaPromedio.Rows
                    If row.Item("Almacen") = "CEDIS" Then
                        ArcScaleComponent3.Value = row.Item("Ocupado")
                        LabelComponent3.Text = row.Item("Ocupado").ToString
                        LabelComponent7.Text = row.Item("Almacen").ToString
                    ElseIf row.Item("Almacen") = "LABOR" Then
                        ArcScaleComponent5.Value = row.Item("Ocupado")
                        LabelComponent5.Text = row.Item("Ocupado").ToString
                        LabelComponent6.Text = row.Item("Almacen").ToString
                    ElseIf row.Item("Almacen") = "RECEPCION" Then
                        ArcScaleComponent6.Value = row.Item("Ocupado")
                        LabelComponent8.Text = row.Item("Ocupado").ToString
                        LabelComponent9.Text = row.Item("Almacen").ToString
                    End If
                Next

                If tablaPromedio.Rows.Count = 1 Then
                    TabNavigationPage3.PageVisible = False
                    TabNavigationPage4.PageVisible = False
                    Timer1.Stop()
                Else
                    TabNavigationPage3.PageVisible = True
                    TabNavigationPage4.PageVisible = True
                    Timer1.Start()
                End If
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub llenarGraficasAlmacenamientoPestañaAlmacenamiento(ByVal tablaPromedio As DataTable, ByVal tablaGeneral As DataTable, ByVal tablaDistintosAlmacenes As DataTable)
        Try
            If tablaPromedio.Rows.Count > 0 Then

                'LLENAR TABLAS PESTAÑA ALMACENAMIENTO
                GridControl4.DataSource = tablaPromedio

                'LLENAR GRAFICAS PESTAÑA ALMACENAMIENTO
                For Each row As DataRow In tablaPromedio.Rows
                    If row.Item("Almacen") = "CEDIS" Then
                        ArcScaleComponent2.Value = row.Item("Ocupado")
                        LabelComponent2.Text = row.Item("Ocupado").ToString
                        LabelComponent12.Text = row.Item("Almacen").ToString
                    ElseIf row.Item("Almacen") = "LABOR" Then
                        ArcScaleComponent7.Value = row.Item("Ocupado")
                        LabelComponent13.Text = row.Item("Ocupado").ToString
                        LabelComponent14.Text = row.Item("Almacen").ToString
                    ElseIf row.Item("Almacen") = "RECEPCION" Then
                        ArcScaleComponent6.Value = row.Item("Ocupado")
                        LabelComponent15.Text = row.Item("Ocupado").ToString
                        LabelComponent16.Text = row.Item("Almacen").ToString
                    End If
                Next

                If tablaPromedio.Rows.Count = 1 Then
                    TabNavigationPage9.PageVisible = False
                    TabNavigationPage10.PageVisible = False
                    Timer1.Stop()
                Else
                    TabNavigationPage9.PageVisible = True
                    TabNavigationPage10.PageVisible = True
                    Timer1.Start()
                End If
            End If

            ChartControl1.Titles.Clear()
            ChartControl1.Series.Clear()
            ChartControl1.Series.Clear()

            ChartControl1.DataSource = tablaGeneral

            Dim series() As Series
            ReDim series(tablaDistintosAlmacenes.Rows.Count - 1)
            Dim contador = 0
            For Each rowAlm As DataRow In tablaDistintosAlmacenes.Rows
                series(contador) = New Series(rowAlm.Item("Almacen"), ViewType.Line)

                Dim almacen = rowAlm.Item("Almacen")
                For Each rowOcupados As DataRow In tablaGeneral.Rows
                    If rowOcupados.Item("Almacen") = almacen Then
                        series(contador).Points.Add(New SeriesPoint(rowOcupados.Item("Fecha"), rowOcupados.Item("Ocupado")))
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

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub
    Private Sub llenarGraficaOrdenesCompletasEmbarcadas()

        Try
            Dim objKPI As New clsKPI

            Dim resultado = objKPI.KPIOrdenesCompletasEmbarcadas(IIf(String.IsNullOrEmpty(dtpFechaInicio.Text), "@", dtpFechaInicio.Text), IIf(String.IsNullOrEmpty(dtpFechaFin.Text), "@", dtpFechaFin.Text), My.Settings.Estacion, DatosTemporales.Usuario)
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
                ArcScaleComponent4.Value = row.Item("PorcentajeEmbarcadas")
                LabelComponent4.Text = row.Item("PorcentajeEmbarcadas").ToString
            End If

            'CARGA GAUGE PAGINA EMBARCADAS
            If tablaPromedio.Rows.Count > 0 Then
                Dim row As DataRow = tablaPromedio.Rows(0)
                ArcScaleComponent9.Value = row.Item("PorcentajeEmbarcadas")
                LabelComponent17.Text = row.Item("PorcentajeEmbarcadas").ToString
            End If
            llenarGraficasPestañaEmbarques(tablaPromedio, tablaGeneral)

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try

    End Sub

    Private Sub llenarGraficasPestañaEmbarques(ByVal tablaPromedio As DataTable, ByVal tablaGeneral As DataTable)
        Try

            GridControl5.DataSource = tablaPromedio
            GridView5.BestFitColumns()
            GridControl6.DataSource = tablaGeneral
            GridView6.BestFitColumns()
            tablaGlobalOrdenesEmbarcadas = tablaGeneral
            Dim series1 As New Series("Órdenes completas embarcadas", ViewType.Pie)

            ' Populate the series with points.
            ChartControl3.Series.Clear()
            ChartControl3.Titles.Clear()

            series1.Points.Add(New SeriesPoint("Embarcadas", tablaPromedio.Rows(0).Item("PorcentajeEmbarcadas")))
            series1.Points.Add(New SeriesPoint("Incompletas", tablaPromedio.Rows(0).Item("PorcentajeIncompletas")))
            'series1.Points.Add(New SeriesPoint("Liberadas Totales", tablaPromedio.Rows(0).Item("PorcentajeLiberadasTotales")))
            'series1.Points.Add(New SeriesPoint("Liberadas Parciales", tablaPromedio.Rows(0).Item("PorcentajeLiberadasParciales")))
            'series1.Points.Add(New SeriesPoint("Surtidas", tablaPromedio.Rows(0).Item("PorcentajeSurtidas")))
            'series1.Points.Add(New SeriesPoint("Validadas", tablaPromedio.Rows(0).Item("PorcentajeValidadas")))
            'series1.Points.Add(New SeriesPoint("Embarcadas", tablaPromedio.Rows(0).Item("PorcentajeEmbarcadas")))
            'series1.Points.Add(New SeriesPoint("Rechazadas", tablaPromedio.Rows(0).Item("PorcentajeRechazadas")))
            ' Add the series to the chart.
            ChartControl3.Series.Add(series1)

            ' Adjust the value numeric options of the series.
            series1.PointOptions.ValueNumericOptions.Format = NumericFormat.Percent
            series1.PointOptions.ValueNumericOptions.Precision = 2

            ' Adjust the view-type-specific options of the series.
            CType(series1.View, PieSeriesView).ExplodedPoints.Add(series1.Points(0))


            ' Add a title to the chart and hide the legend.
            Dim chartTitle1 As New ChartTitle()
            chartTitle1.Text = "Órdenes completas embarcadas"
            ChartControl3.Titles.Add(chartTitle1)
            ChartControl3.Legend.Visible = False

            ' Add the chart to the form.
            ChartControl3.Dock = DockStyle.None

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub

    Private Sub llenarGraficaOrdenesPrecisionInv()

        Try
            Dim objKPI As New clsKPI

            Dim resultado = objKPI.KPIPresicionInv(IIf(String.IsNullOrEmpty(dtpFechaInicio.Text), "@", dtpFechaInicio.Text), IIf(String.IsNullOrEmpty(dtpFechaFin.Text), "@", dtpFechaFin.Text), My.Settings.Estacion, DatosTemporales.Usuario)
            If Not resultado.Estado Then
                XtraMessageBox.Show(resultado.Texto, "AXC")
                Return
            End If

            Dim tablaPromedio = resultado.Tablas.Tables(1)
            Dim tablaGeneral = resultado.Tablas.Tables(2)

            If tablaPromedio.Rows.Count > 0 Then
                ArcScaleComponent1.Value = tablaPromedio.Rows(0).Item("Precision")
                LabelComponent11.Text = tablaPromedio.Rows(0).Item("Precision")
            End If

            llenarGraficasPestañaPrecisionInv(tablaGeneral, tablaPromedio)

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try

    End Sub

    Private Sub llenarGraficasPestañaPrecisionInv(ByVal tablaGeneral As DataTable, ByVal tablaPromedio As DataTable)
        Try

            GridControl8.DataSource = tablaPromedio
            GridView8.BestFitColumns()
            GridControl7.DataSource = tablaGeneral
            GridView7.BestFitColumns()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub
    Private Sub llenarGraficaDockToStock()

        Try
            Dim objKPI As New clsKPI

            Dim resultado = objKPI.KPITiempoCicloRecepcion(IIf(String.IsNullOrEmpty(dtpFechaInicio.Text), "@", dtpFechaInicio.Text), IIf(String.IsNullOrEmpty(dtpFechaFin.Text), "@", dtpFechaFin.Text), My.Settings.Estacion, DatosTemporales.Usuario)
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
                DigitalGauge5.Text = tablaPromedio.Rows(0).Item("Dias")
                DigitalGauge3.Text = tablaPromedio.Rows(0).Item("Horas")
                DigitalGauge4.Text = tablaPromedio.Rows(0).Item("Minutos")

                GridControl1.DataSource = tablaPromedio
                GridControl2.DataSource = tablaGeneral
            End If




        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'TabPane2.TransitionAnimationProperties.FrameInterval = 2000
        TabPane2.SelectNextPage()
        TabPane3.SelectNextPage()

    End Sub

    Private Sub TabPane2_SelectedPageChanged(sender As Object, e As DevExpress.XtraBars.Navigation.SelectedPageChangedEventArgs)
        Timer1.Stop()
        Timer1.Start()
    End Sub

    Private Sub GridView6_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GridView6.RowClick
        Try

            ' Populate the series with points.
            ChartControl3.Series.Clear()
            ChartControl3.Titles.Clear()

            If GridView6.SelectedRowsCount <= 0 Then
                Return
            End If
            Dim rowIndex = GridView6.GetSelectedRows


            Dim series1 As New Series("Detalle diario órdenes embarcadas", ViewType.Pie)
            series1.Points.Add(New SeriesPoint("Liberadas Totales", tablaGlobalOrdenesEmbarcadas.Rows(rowIndex(0)).Item("PorcentajeLiberadasTotales")))
            series1.Points.Add(New SeriesPoint("Liberadas Parciales", tablaGlobalOrdenesEmbarcadas.Rows(rowIndex(0)).Item("PorcentajeLiberadasParciales")))
            series1.Points.Add(New SeriesPoint("Surtidas", tablaGlobalOrdenesEmbarcadas.Rows(rowIndex(0)).Item("PorcentajeSurtidas")))
            series1.Points.Add(New SeriesPoint("Validadas", tablaGlobalOrdenesEmbarcadas.Rows(rowIndex(0)).Item("PorcentajeValidadas")))
            series1.Points.Add(New SeriesPoint("Embarcadas", tablaGlobalOrdenesEmbarcadas.Rows(rowIndex(0)).Item("PorcentajeEmbarcadas")))
            series1.Points.Add(New SeriesPoint("Rechazadas", tablaGlobalOrdenesEmbarcadas.Rows(rowIndex(0)).Item("PorcentajeRechazadas")))
            ' Add the series to the chart.
            ChartControl3.Series.Add(series1)

            ' Adjust the value numeric options of the series.
            series1.PointOptions.ValueNumericOptions.Format = NumericFormat.Percent
            series1.PointOptions.ValueNumericOptions.Precision = 2

            ' Adjust the view-type-specific options of the series.
            CType(series1.View, PieSeriesView).ExplodedPoints.Add(series1.Points(0))


            ' Add a title to the chart and hide the legend.
            Dim chartTitle1 As New ChartTitle()
            chartTitle1.Text = "Órdenes completas embarcadas"
            ChartControl3.Titles.Add(chartTitle1)
            ChartControl3.Legend.Visible = False

            ' Add the chart to the form.
            ChartControl3.Dock = DockStyle.None

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        llenarGraficasPestañaEmbarques(tablaGlobalOrdenesEmbarcadasPromedio, tablaGlobalOrdenesEmbarcadasGeneral)
    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        FrmOrdenesTotales.fechainicio = dtpFechaInicio.Text
        FrmOrdenesTotales.fechafin = dtpFechaFin.Text

        FrmOrdenesTotales.Show()

    End Sub



    Private Sub SimpleButton5_Click_1(sender As Object, e As EventArgs) Handles SimpleButton5.Click
        FrmOrdenesRec.fechainicio = dtpFechaInicio.Text
        FrmOrdenesRec.fechafin = dtpFechaFin.Text

        FrmOrdenesRec.Show()
    End Sub
End Class