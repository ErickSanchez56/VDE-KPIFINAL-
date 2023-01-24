Imports DevExpress.XtraCharts
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Base
Public Class FrmPromedioSurtidoPorOrden
    Public pOrdenEmbarque As String

    Private Sub FrmPromedioSurtidoPorOrden_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CARGARDETALLE(pOrdenEmbarque)
    End Sub

    Private Sub CARGARDETALLE(ByVal prmOrdenEmbarque)
        Dim pResultado As New CResultado
        Dim Cls As New clsKPI
        Dim dt As New DataTable
        Dim dt2 As New DataTable


        GridControl1.DataSource = Nothing
        GridControl2.DataSource = Nothing


        Cursor.Current = Cursors.WaitCursor
        pResultado = Cls.ResultadoOrdenEmb(prmOrdenEmbarque)
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


        GridControl1.DataSource = dt
        GridView1.BestFitColumns()
        GridControl2.DataSource = dt2
        GridView3.BestFitColumns()
        GridView3.Columns("SEGUNDOS").Visible = False




        ''''GRAFICA MANHATTAN


        ' Add a bar series to it.
        ChartControl3.Series.Clear()
        ChartControl3.Titles.Clear()
        Dim seriesM1 As New Series("Tiempo De Surtido", ViewType.Bar)
        'Dim seriesM2 As New Series("Total Enviadas", ViewType.Bar)
        Dim int As Integer = 0
        ' Add points to the series.
        For Each Dr As DataRow In ds.Tables(1).Rows
            seriesM1.Points.Add(New SeriesPoint("Tiempo De Surtido Partida:" + dt2.Rows(int).Item("Partida"), dt2.Rows(int).Item("SEGUNDOS")))
            int = int + 1
        Next





        'seriesM1.Points.Add(New SeriesPoint("Martes", dt.Rows(2).Item("Ocupado")))
        'seriesM1.Points.Add(New SeriesPoint("Miercoles", dt.Rows(3).Item("Ocupado")))
        'seriesM2.Points.Add(New SeriesPoint("Total Enviadas", dt.Rows(0).Item("TotalEnviadas")))
        'seriesM2.Points.Add(New SeriesPoint("Lunes", dt.Rows(1).Item("Vacio")))
        'seriesM2.Points.Add(New SeriesPoint("Martes", dt.Rows(2).Item("Vacio")))
        'seriesM2.Points.Add(New SeriesPoint("Miercoles", dt.Rows(3).Item("Vacio")))

        ' Add both series to the chart.
        ChartControl3.Series.AddRange(New Series() {seriesM1})

        ' Access labels of the first series.
        CType(seriesM1.Label, BarSeriesLabel).Visible = False
        ' CType(seriesM1.Label, BarSeriesLabel).ResolveOverlappingMode = ResolveOverlappingMode.Default
        'CType(seriesM2.Label, BarSeriesLabel).Visible = True

        ' Access the series options.
        seriesM1.PointOptions.PointView = PointView.ArgumentAndValues
        'seriesM2.PointOptions.PointView = PointView.ArgumentAndValues        ' Customize the view-type-specific properties of the series.
        'Dim myView As Bar3DSeriesView = CType(seriesM2.View, Bar3DSeriesView)
        'myView.BarDepthAuto = False
        'myView.BarDepth = 1
        'myView.Transparency = 80
        'myView.ShowFacet = False

        'myView.Model = Bar3DModel.Box

        '' Access the diagram's options.
        'CType(ChartControl3.Diagram, XYDiagram3D).ZoomPercent = 100

        ' Add a title to the chart and hide the legend.
        Dim chartTitle2 As New ChartTitle()
        chartTitle2.Text = "Tiempo De Surtido"
        ChartControl3.Titles.Add(chartTitle2)
        ChartControl3.Legend.Visible = True

        ' Add the chart to the form.
        ChartControl3.Dock = DockStyle.None
        ' Add Rotacion to chart 




    End Sub
End Class