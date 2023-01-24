Imports DevExpress.XtraCharts
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Base
Imports Syncfusion.Windows.Forms.Chart
Public Class FrmOrdenesTotalesProd

    Private Sub SimpleButton3_Click_1(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        Try

            Dim prmBusqueda2 As String
            Dim prmBusqueda3 As String



            'If String.IsNullOrEmpty(DateEdit5.Text) Then
            '    prmBusqueda2 = "@"
            'Else
            '    prmBusqueda2 = DateEdit5.Text
            'End If
            'Dim fecha As New Date
            'fecha = Date.Parse(DateEdit5.EditValue.ToString)
            '''ResultadoLista(prmBusqueda2, fecha)



            'If String.IsNullOrEmpty(DateEdit6.Text) Then
            '    prmBusqueda3 = "@"
            'Else
            '    prmBusqueda3 = DateEdit6.Text
            'End If
            'Dim fecha2 As New Date
            'fecha2 = Date.Parse(DateEdit6.EditValue.ToString)


            ''ResultadoLista2(fecha, fecha2)



        Catch ex As Exception
            XtraMessageBox.Show(ex.Message.ToString, "Error", MessageBoxButtons.OK)
        End Try
    End Sub

    'Private Sub dgvResultado_Click(sender As Object, e As EventArgs) Handles GridControl1.Click
    '    Try
    '        If IsNothing(GridControl1.DataSource) Then
    '            Return
    '        End If

    '        Dim ds As New DataSet


    '        Dim view As ColumnView = CType(GridControl1.MainView, ColumnView)
    '        Dim selectedRowHandles As Integer() = view.GetSelectedRows()

    '    Catch ex As Exception
    '        XtraMessageBox.Show(ex.Message.ToString, "Error", MessageBoxButtons.OK)
    '    End Try
    'End Sub
    Private Sub ResultadoLista2(prmBusqueda2 As Date, prmBusqueda3 As Date)
        Try
            Dim pResultado As New CResultado
            Dim Cls As New clsKPI
            Dim dt As New DataTable
            Dim dt2 As New DataTable
            Dim dt3 As New DataTable

            'pResultado = Cls.ResultadoListaEmpaques
            dt = pResultado.Tabla


            GridControl1.DataSource = Nothing


            Cursor.Current = Cursors.WaitCursor
            pResultado = Cls.ResultadoListaOrdenesProd(prmBusqueda2, prmBusqueda3, My.Settings.Estacion, DatosTemporales.Usuario)
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

            'SimpleButton2.Text = dt.Rows(0).Item("TotalembarquesaTiempo").ToString
            'SimpleButton4.Text = dt.Rows(0).Item("OrdenesRetrazadas").ToString
            'SimpleButton1.Text = dt.Rows(0).Item("Totalembarques").ToString
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

            Dim series1 As New Series("Doughnut Series 1", ViewType.Doughnut3D)

            ' Populate the series with points.
            ChartControl3.Series.Clear()
            ChartControl3.Titles.Clear()
            series1.Points.Add(New SeriesPoint("ENVIADAS A TIEMPO", dt.Rows(0).Item("TotalembarquesaTiempo")))
            series1.Points.Add(New SeriesPoint("ORDENES RETRAZADAS", dt.Rows(0).Item("OrdenesRetrazadas")))





            '' series1.Points.Add(New SeriesPoint("TOTAL ENVIADAS", dt.Rows(0).Item("Totalembarques")))
            ' Add the series to the chart.
            ChartControl3.Series.Add(series1)
            ChartControl3.Legend.Title.Text = "ORDENES"
            ChartControl3.Legend.MarkerMode = LegendMarkerMode.Marker
            'ChartControl3.Legend


            ' Adjust the value numeric options of the series.
            series1.PointOptions.ValueNumericOptions.Format = NumericFormat.Percent
            series1.PointOptions.ValueNumericOptions.Precision = 2

            ' Adjust the view-type-specific options of the series.
            CType(series1.View, Doughnut3DSeriesView).HoleRadiusPercent = 30
            CType(series1.View, Doughnut3DSeriesView).ExplodedPoints.Add(series1.Points(0))


            ' Access the diagram's options.
            CType(ChartControl3.Diagram, SimpleDiagram3D).RotationType = RotationType.UseAngles
            CType(ChartControl3.Diagram, SimpleDiagram3D).RotationAngleX = -40

            ' Add a title to the chart and hide the legend.
            Dim chartTitle1 As New ChartTitle()
            chartTitle1.Text = "ORDENES ENVIADAS A TIEMPO"
            ChartControl3.Titles.Add(chartTitle1)


            ChartControl3.Legend.Visible = True



            ' Add the chart to the form.
            ChartControl3.Dock = DockStyle.None
            'Rotacion de Char3d
            ChartControl3.RuntimeRotation = True










        Catch ex As Exception
            XtraMessageBox.Show(ex.Message.ToString, "Error", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub GridControl1_DoubleClick(sender As Object, e As EventArgs) Handles GridControl1.DoubleClick
        Try
            ' Dim FrmPromedioSurtidoPorOrden As New FrmPromedioSurtidoPorOrden
            Dim view As ColumnView = CType(GridControl1.MainView, ColumnView)
            Dim selectedRowHandles As Integer() = view.GetSelectedRows

            Dim OrdenEmbarque As String = ""
            OrdenEmbarque = (view.GetRowCellValue(selectedRowHandles(0), "OrdenEmbarque"))
            FrmPromedioSurtidoPorOrden.pOrdenEmbarque = OrdenEmbarque
            '' FrmPromedioSurtidoPorOrden.MdiParent = FrmMenuPrincipal.XtraTabbedMdiManager1.MdiParent
            FrmPromedioSurtidoPorOrden.Show()
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

End Class