Imports DevExpress.XtraCharts
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Base
Imports Syncfusion.Windows.Forms.Chart

Public Class FrmOrdenesRec


    Public fechainicio As String
    Public fechafin As String

    Private Sub FrmOrdenesRec_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LabelControl6.Text = fechainicio
        LabelControl7.Text = fechafin
        ResultadoLista2(fechainicio, fechafin)
    End Sub
    Private Sub SimpleButton3_Click_1(sender As Object, e As EventArgs)
        Try


            ResultadoLista2(fechainicio, fechafin)



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

            GridControl1.DataSource = Nothing


            Cursor.Current = Cursors.WaitCursor
            pResultado = Cls.ResultadoListaPartidasRec(prmBusqueda2, prmBusqueda3, My.Settings.Estacion, DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                GridControl1.DataSource = Nothing
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
            If dt2.Rows.Count < 1 Then
                XtraMessageBox.Show("Sin detalle de las ordenes", "AXC", MessageBoxButtons.OK)
                GridControl1.DataSource = Nothing
                Return
            End If

            GridControl1.DataSource = dt2
            GridView1.BestFitColumns()
            GridControl2.DataSource = dt3
            GridView2.BestFitColumns()

            llenarGraficasAlmacenamientoPestañaDashboard(dt)
            llenarGraficaDockToStock(ds)
            llenarGraficasAlmacenamientoPestañaAlmacenamiento(dt3)

            'GridControl4.DataSource = dt
            'GridView5.BestFitColumns()



            '''GRAFICA LINEAS (ESTA EN TEST)

            'Dim seriesL1 As Series = New Series("EnviadasATiempo", ViewType.Line)
            'Dim seriesL2 As Series = New Series("TotalEnviadas", ViewType.Line)
            'Add points to it.
            'seriesL1.Points.Add(New SeriesPoint("EnviadasATiempo", dt.Rows(0).Item("EnviadasATiempo")))
            'seriesL1.Points.Add(New SeriesPoint("Vacio", dt.Rows(0).Item("Vacio")))
            'seriesL1.Points.Add(New SeriesPoint(3, 14))
            'seriesL1.Points.Add(New SeriesPoint(4, 17))
            'seriesL2.Points.Add(New SeriesPoint("TotalEnviadas", dt.Rows(0).Item("TotalEnviadas")))
            'seriesL2.Points.Add(New SeriesPoint("Vacio", dt.Rows(0).Item("Vacio")))
            'seriesL2.Points.Add(New SeriesPoint(3, 14))
            'seriesL2.Points.Add(New SeriesPoint(4, 17))
            'Add the series to the chart.
            'ChartControl4.Series.Add(seriesL1)
            'ChartControl4.Series.Add(seriesL2)

            'Cast the chart's diagram to the XYDiagram type, to access its axes.
            'Dim diagram As XYDiagram = CType(ChartControl4.Diagram, XYDiagram)
            'Enable the diagram's scrolling.
            'diagram.EnableAxisXScrolling = True
            'diagram.EnableAxisYScrolling = True

            'Define the whole range for the X-axis. 
            'diagram.AxisX.WholeRange.Auto = False
            'diagram.AxisX.WholeRange.SetMinMaxValues("A", "D")

            'Disable the side margins 
            ' (this has an effect only for certain view types).
            'diagram.AxisX.VisualRange.AutoSideMargins = False

            'Limit the visible range for the X-axis.
            'diagram.AxisX.VisualRange.Auto = False
            'diagram.AxisX.VisualRange.SetMinMaxValues("B", "C")

            'Define the whole range for the Y-axis. 
            'diagram.AxisY.WholeRange.Auto = False
            'diagram.AxisY.WholeRange.SetMinMaxValues(0, 100)
            ' Set the numerical argument scale types for the series,
            '' as it is qualitative, by default.
            'seriesL1.ArgumentScaleType = ScaleType.Numerical
            'Access the view-type-specific options of the series.
            'CType(seriesL1.View, LineSeriesView).MarkerVisibility = DevExpress.Utils.DefaultBoolean.True
            'CType(seriesL1.View, LineSeriesView).LineMarkerOptions.Size = 20
            'CType(seriesL1.View, LineSeriesView).LineMarkerOptions.Kind = MarkerKind.Triangle
            'CType(seriesL1.View, LineSeriesView).LineStyle.DashStyle = DashStyle.Dash
            'CType(seriesL2.View, LineSeriesView).MarkerVisibility = DevExpress.Utils.DefaultBoolean.True
            'CType(seriesL2.View, LineSeriesView).LineMarkerOptions.Size = 20
            'CType(seriesL2.View, LineSeriesView).LineMarkerOptions.Kind = MarkerKind.Triangle
            'CType(seriesL2.View, LineSeriesView).LineStyle.DashStyle = DashStyle.Dash
            'Access the view-type-specific options of the series.
            'CType(ChartControl4.Diagram, XYDiagram).AxisY.Interlaced = True
            'CType(ChartControl4.Diagram, XYDiagram).AxisY.InterlacedColor = Color.FromArgb(20, 60, 60, 60)
            'CType(ChartControl4.Diagram, XYDiagram).AxisX.NumericScaleOptions.AutoGrid = False
            'CType(ChartControl4.Diagram, XYDiagram).AxisX.NumericScaleOptions.GridSpacing = 1
            'Hide the legend (if necessary).
            'ChartControl1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False
            'Add a title to the chart (if necessary).
            'ChartControl4.Titles.Add(New ChartTitle())
            'ChartControl4.Titles(0).Text = "Enviados A Tiempo"
            'Add the chart to the form.
            'ChartControl4.Dock = DockStyle.None





            ''GRAFICA DE BARRAS
            'Dim series2 As New Series("Series2", ViewType.Bar)
            'Dim series3 As New Series("Series3", ViewType.Bar)

            'ChartControl4.Series.Clear()
            'ChartControl4.Titles.Clear()
            'ChartControl4.Titles.Add(New ChartTitle() With {.Text = "Enviadas A Tiempo"})
            'ChartControl4.Legend.Title.Text = "Enviadas A Tiempo"
            'ChartControl4.SeriesTemplate.View = New SideBySideBarSeriesView

            ''ChartControl4.SeriesDataMember =
            ''

            'ChartControl4.SeriesDataMember = "EnviadasATiempo"

            ''ChartControl4.Text = "EnviadasATiempo"

            ''ChartControl4.SeriesTemplate.ValueDataMembers.AddRange(New String() {"EnviadasATiempo", "TotalEnviadas"})
            ''ChartControl4.SeriesTemplate.ValueDataMembers.AddRange()
            'ChartControl4.SeriesTemplate.ValueDataMembers.AddRange(New Series()series2)
            'ChartControl4.SeriesTemplate.ArgumentDataMember = "FechaConsulta"

            'ChartControl4.RuntimeHitTesting = True


            'Dim view As SideBySideBarSeriesView = TryCast(ChartControl4.SeriesTemplate.View, SideBySideBarSeriesView)
            'view.BarDistance = 0.5
            'view.BarDistanceFixed = 0.5
            'view.BarWidth = 0.5
            '''view.EqualBarWidth = True
            'ChartControl4.DataSource = dt


            ''''GRAFICA MANHATTAN


            ' Add a bar series to it.
            'ChartControl3.Series.Clear()
            'ChartControl3.Titles.Clear()
            'Dim seriesM1 As New Series("Enviadas A Tiempo", ViewType.Bar)
            'Dim seriesM2 As New Series("Total Enviadas", ViewType.Bar)

            '' Add points to the series.
            'seriesM1.Points.Add(New SeriesPoint("Enviadas A Tiempo", dt.Rows(0).Item("EnviadasATiempo")))
            ''seriesM1.Points.Add(New SeriesPoint("Lunes", dt.Rows(1).Item("Ocupado")))
            ''seriesM1.Points.Add(New SeriesPoint("Martes", dt.Rows(2).Item("Ocupado")))
            ''seriesM1.Points.Add(New SeriesPoint("Miercoles", dt.Rows(3).Item("Ocupado")))
            'seriesM2.Points.Add(New SeriesPoint("Total Enviadas", dt.Rows(0).Item("TotalEnviadas")))
            ''seriesM2.Points.Add(New SeriesPoint("Lunes", dt.Rows(1).Item("Vacio")))
            ''seriesM2.Points.Add(New SeriesPoint("Martes", dt.Rows(2).Item("Vacio")))
            ''seriesM2.Points.Add(New SeriesPoint("Miercoles", dt.Rows(3).Item("Vacio")))

            '' Add both series to the chart.
            'ChartControl3.Series.AddRange(New Series() {seriesM1, seriesM2})

            '' Access labels of the first series.
            'CType(seriesM1.Label, BarSeriesLabel).Visible = True
            '' CType(seriesM1.Label, BarSeriesLabel).ResolveOverlappingMode = ResolveOverlappingMode.Default
            'CType(seriesM2.Label, BarSeriesLabel).Visible = True

            '' Access the series options.
            'seriesM1.PointOptions.PointView = PointView.ArgumentAndValues
            'seriesM2.PointOptions.PointView = PointView.ArgumentAndValues
            '' Customize the view-type-specific properties of the series.
            ''Dim myView As Bar3DSeriesView = CType(seriesM2.View, Bar3DSeriesView)
            ''myView.BarDepthAuto = False
            ''myView.BarDepth = 1
            ''myView.Transparency = 80
            ''myView.ShowFacet = False

            ''myView.Model = Bar3DModel.Box

            ''' Access the diagram's options.
            ''CType(ChartControl3.Diagram, XYDiagram3D).ZoomPercent = 100

            '' Add a title to the chart and hide the legend.
            'Dim chartTitle2 As New ChartTitle()
            'chartTitle2.Text = "ENVIADAS A TIEMPO"
            'ChartControl3.Titles.Add(chartTitle2)
            'ChartControl3.Legend.Visible = True

            '' Add the chart to the form.
            'ChartControl3.Dock = DockStyle.None
            ' Add Rotacion to chart 
            ''ChartControl3.RuntimeRotation = True

            ''''GRAFICA DE DONA

            'Dim series1 As New Series("Doughnut Series 1", ViewType.Doughnut3D)

            '' Populate the series with points.
            'ChartControl3.Series.Clear()
            'ChartControl3.Titles.Clear()
            'series1.Points.Add(New SeriesPoint("ENVIADAS A TIEMPO", dt.Rows(0).Item("TotalembarquesaTiempo")))
            'series1.Points.Add(New SeriesPoint("ORDENES RETRAZADAS", dt.Rows(0).Item("OrdenesRetrazadas")))





            ''' series1.Points.Add(New SeriesPoint("TOTAL ENVIADAS", dt.Rows(0).Item("Totalembarques")))
            '' Add the series to the chart.
            'ChartControl3.Series.Add(series1)
            'ChartControl3.Legend.Title.Text = "ORDENES"
            'ChartControl3.Legend.MarkerMode = LegendMarkerMode.Marker
            ''ChartControl3.Legend


            '' Adjust the value numeric options of the series.
            'series1.PointOptions.ValueNumericOptions.Format = NumericFormat.Percent
            'series1.PointOptions.ValueNumericOptions.Precision = 2

            '' Adjust the view-type-specific options of the series.
            'CType(series1.View, Doughnut3DSeriesView).HoleRadiusPercent = 30
            'CType(series1.View, Doughnut3DSeriesView).ExplodedPoints.Add(series1.Points(0))


            '' Access the diagram's options.
            'CType(ChartControl3.Diagram, SimpleDiagram3D).RotationType = RotationType.UseAngles
            'CType(ChartControl3.Diagram, SimpleDiagram3D).RotationAngleX = -40

            '' Add a title to the chart and hide the legend.
            'Dim chartTitle1 As New ChartTitle()
            'chartTitle1.Text = "ORDENES ENVIADAS A TIEMPO"
            'ChartControl3.Titles.Add(chartTitle1)


            'ChartControl3.Legend.Visible = True



            '' Add the chart to the form.
            'ChartControl3.Dock = DockStyle.None
            ''Rotacion de Char3d
            'ChartControl3.RuntimeRotation = True










        Catch ex As Exception
            XtraMessageBox.Show(ex.Message.ToString, "Error", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub llenarGraficasAlmacenamientoPestañaDashboard(ByVal tablaPromedio As DataTable)
        Try
            If tablaPromedio.Rows.Count > 0 Then
                For Each row As DataRow In tablaPromedio.Rows
                    If row.Item("Recibos").ToString = row.Item("Recibos").ToString Then
                        ArcScaleComponent1.Value = row.Item("Recibos")
                        LabelComponent1.Text = row.Item("Recibos").ToString
                        LabelComponent2.Text = "Recibos"
                    End If
                    If row.Item("Ordenes").ToString = row.Item("Ordenes").ToString Then
                        ArcScaleComponent2.Value = row.Item("Ordenes")
                        LabelComponent4.Text = row.Item("Ordenes").ToString
                        LabelComponent5.Text = "Ordenes"
                    End If
                    If row.Item("Partidas Recibidas").ToString = row.Item("Partidas Recibidas").ToString Then
                        ArcScaleComponent3.Value = row.Item("Partidas Recibidas")
                        LabelComponent3.Text = row.Item("Partidas Recibidas").ToString
                        LabelComponent7.Text = "Partidas"
                    End If
                Next


            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub llenarGraficaDockToStock(ByRef ds As DataSet)

        Try

            If ds.Tables(0).Rows.Count > 0 Then
                'Gauges dashboard
                DigitalGauge3.Text = ds.Tables(0).Rows(0).Item("Dias")
                DigitalGauge1.Text = ds.Tables(0).Rows(0).Item("Horas")
                DigitalGauge2.Text = ds.Tables(0).Rows(0).Item("Minutos")

            End If




        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try

    End Sub

    Private Sub llenarGraficasAlmacenamientoPestañaAlmacenamiento(ByVal dt As DataTable)
        Try
            If dt.Rows.Count > 0 Then


                ChartControl1.Titles.Clear()
                ChartControl1.Series.Clear()

                ChartControl1.DataSource = dt

                Dim series() As Series
                ReDim series(dt.Rows.Count - 1)
                Dim contador = 0
                For Each rowAlm As DataRow In dt.Rows
                    series(contador) = New Series(rowAlm.Item("FechaLiberacion"), ViewType.Line)

                    Dim almacen = rowAlm.Item("FechaFinRec")
                    For Each rowOcupados As DataRow In dt.Rows
                        If rowOcupados.Item("FechaFinRec") = almacen Then
                            series(contador).Points.Add(New SeriesPoint(rowOcupados.Item("FechaFinRec"), rowOcupados.Item("Recibos")))
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
                diagram.EnableAxisXZooming = False

                diagram.EnableAxisYScrolling = True
                diagram.EnableAxisYZooming = False
                diagram.AxisX.WholeRange.SetMinMaxValues(fechainicio, fechafin)




            End If
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub
    Private Sub GridControl1_DoubleClick(sender As Object, e As EventArgs) Handles GridControl1.DoubleClick
        Try
            ' Dim FrmPromedioSurtidoPorOrden As New FrmPromedioSurtidoPorOrden
            'Dim view As ColumnView = CType(GridControl1.MainView, ColumnView)
            'Dim selectedRowHandles As Integer() = view.GetSelectedRows

            'Dim OrdenEmbarque As String = ""
            'OrdenEmbarque = (view.GetRowCellValue(selectedRowHandles(0), "OrdenEmbarque"))
            'FrmPromedioSurtidoPorOrden.pOrdenEmbarque = OrdenEmbarque
            ''' FrmPromedioSurtidoPorOrden.MdiParent = FrmMenuPrincipal.XtraTabbedMdiManager1.MdiParent
            'FrmPromedioSurtidoPorOrden.Show()
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub


End Class