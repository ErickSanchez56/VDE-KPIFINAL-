Imports DevExpress.XtraCharts
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGauges.Win
Imports DevExpress.XtraGauges.Core.Model
Imports DevExpress.XtraGauges.Core.Base
Imports DevExpress.XtraGauges.Win.Gauges.Digital




Public Class FrmAlmacenHistorico


    Public pClienteSeleccionada As String = ""
    Public pCliente As String
    Public pIdCliente As Int64
    Public pAccion As Integer

    Private Sub dgvResultado_Click(sender As Object, e As EventArgs)
        Try
            If IsNothing(dgvResultado.DataSource) Then
                Return
            End If

            Dim ds As New DataSet


            Dim view As ColumnView = CType(dgvResultado.MainView, ColumnView)
            Dim selectedRowHandles As Integer() = view.GetSelectedRows()

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message.ToString, "Error", MessageBoxButtons.OK)
        End Try
    End Sub
    Public Property RuntimeRotation As Boolean


    Private Sub ResultadoLista(prmBusqueda As String, prmBusqueda2 As Date, prmBusqueda3 As Date)
        Try
            Dim pResultado As New CResultado
            Dim Cls As New clsKPI
            Dim dt As New DataTable

            'pResultado = Cls.ResultadoListaEmpaques
            dt = pResultado.Tabla


            dgvResultado.DataSource = Nothing


            Cursor.Current = Cursors.WaitCursor
            pResultado = Cls.ResultadoListaEmpaques(prmBusqueda, prmBusqueda2, prmBusqueda3, My.Settings.Estacion, DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                dgvResultado.DataSource = Nothing
                Return
            End If

            Dim ds As New DataSet

            dt = pResultado.Tabla
            ds.Tables.Add(dt)

            If dt.Rows.Count < 1 Then
                XtraMessageBox.Show("Sin información en el sistema", "AXC", MessageBoxButtons.OK)
                dgvResultado.DataSource = Nothing
                Return
            End If

            dgvResultado.DataSource = dt
            dgvViewResultado.BestFitColumns()



            ''GRAFICA DE BARRAS
            ChartControl4.Series.Clear()
            ChartControl4.Titles.Clear()
            ChartControl4.Titles.Add(New ChartTitle() With {.Text = ""})
            ChartControl4.Legend.Title.Text = ""
            ChartControl4.SeriesTemplate.View = New SideBySideBarSeriesView
            ChartControl4.SeriesDataMember = "Fecha"
            ChartControl4.SeriesTemplate.ValueDataMembers.AddRange(New String() {"ocupado"})
            ChartControl4.SeriesTemplate.ArgumentDataMember = "Fecha"
            ChartControl4.RuntimeHitTesting = True


            Dim view As SideBySideBarSeriesView = TryCast(ChartControl4.SeriesTemplate.View, SideBySideBarSeriesView)
            view.BarDistance = 1
            view.BarDistanceFixed = 1
            view.BarWidth = 4
            view.EqualBarWidth = True
            ChartControl4.DataSource = dt

            ''GRAFICA MANHATTAN


            ' Add a bar series to it.
            Dim seriesM1 As New Series("Series M1", ViewType.ManhattanBar)
            Dim seriesM2 As New Series("Series M2", ViewType.ManhattanBar)

            ' Add points to the series.
            seriesM1.Points.Add(New SeriesPoint("Domingo", dt.Rows(0).Item("Ocupado")))
            seriesM1.Points.Add(New SeriesPoint("Lunes", dt.Rows(1).Item("Ocupado")))
            seriesM1.Points.Add(New SeriesPoint("Martes", dt.Rows(2).Item("Ocupado")))
            seriesM1.Points.Add(New SeriesPoint("Miercoles", dt.Rows(3).Item("Ocupado")))
            seriesM2.Points.Add(New SeriesPoint("Domingo", dt.Rows(0).Item("Vacio")))
            seriesM2.Points.Add(New SeriesPoint("Lunes", dt.Rows(1).Item("Vacio")))
            seriesM2.Points.Add(New SeriesPoint("Martes", dt.Rows(2).Item("Vacio")))
            seriesM2.Points.Add(New SeriesPoint("Miercoles", dt.Rows(3).Item("Vacio")))

            ' Add both series to the chart.
            ChartControl3.Series.AddRange(New Series() {seriesM1, seriesM2})

            ' Access labels of the first series.
            CType(seriesM1.Label, BarSeriesLabel).Visible = True
            'CType(seriesM1.Label, BarSeriesLabel).ResolveOverlappingMode = ResolveOverlappingMode.Default
            CType(seriesM2.Label, BarSeriesLabel).Visible = True

            ' Access the series options.
            seriesM1.PointOptions.PointView = PointView.ArgumentAndValues

            ' Customize the view-type-specific properties of the series.
            Dim myView As Bar3DSeriesView = CType(seriesM2.View, Bar3DSeriesView)
            myView.BarDepthAuto = False
            myView.BarDepth = 1
            myView.Transparency = 80
            myView.ShowFacet = False

            myView.Model = Bar3DModel.Box

            ' Access the diagram's options.
            CType(ChartControl3.Diagram, XYDiagram3D).ZoomPercent = 100

            ' Add a title to the chart and hide the legend.
            Dim chartTitle2 As New ChartTitle()
            chartTitle2.Text = "Almacenamiento Histórico"
            ChartControl3.Titles.Add(chartTitle2)
            ChartControl3.Legend.Visible = False

            ' Add the chart to the form.
            ChartControl3.Dock = DockStyle.None
            ' Add Rotacion to chart 
            ChartControl3.RuntimeRotation = True




            'GRAFICA DE DONA

            Dim series1 As New Series("Doughnut Series 1", ViewType.Doughnut3D)

            ' Populate the series with points.
            series1.Points.Add(New SeriesPoint("Ocupado", dt.Rows(0).Item("Ocupado")))
            series1.Points.Add(New SeriesPoint("Vacio", dt.Rows(0).Item("Vacio")))


            ' Add the series to the chart.
            Grafica.Series.Add(series1)

            ' Adjust the value numeric options of the series.
            series1.PointOptions.ValueNumericOptions.Format = NumericFormat.Percent
            series1.PointOptions.ValueNumericOptions.Precision = 2

            ' Adjust the view-type-specific options of the series.
            CType(series1.View, Doughnut3DSeriesView).HoleRadiusPercent = 30
            CType(series1.View, Doughnut3DSeriesView).ExplodedPoints.Add(series1.Points(0))

            ' Access the diagram's options.
            CType(Grafica.Diagram, SimpleDiagram3D).RotationType = RotationType.UseAngles
            CType(Grafica.Diagram, SimpleDiagram3D).RotationAngleX = -35

            ' Add a title to the chart and hide the legend.
            Dim chartTitle1 As New ChartTitle()
            chartTitle1.Text = "Almacen Historico"
            Grafica.Titles.Add(chartTitle1)
            Grafica.Legend.Visible = False

            ' Add the chart to the form.
            Grafica.Dock = DockStyle.None
            'Rotacion de Char3d
            Grafica.RuntimeRotation = True




            ''GAUGES
            LinearScaleComponent1.Value = dt.Rows(0).Item("Ocupado")
            'ArcScaleComponent1.Value = dt.Rows(0).Item("Ocupado")
            'ArcSca1leComponent2.Value = dt.Rows(1).Item("Ocupado")

            'ArcScaleComponent3.Value = dt.Rows(3).Item("Ocupado")

            'DIGITAL GAUGE
            dGauge1.Text = "12:50"




        Catch ex As Exception
            XtraMessageBox.Show(ex.Message.ToString, "Error", MessageBoxButtons.OK)
        End Try
    End Sub


    Private Sub ListaAlmacenes()
        Try
            Dim pResultado As New CResultado
            Dim pAlmacen As New clsKPI

            Cursor.Current = Cursors.WaitCursor
            pResultado = pAlmacen.ListaAlmacenHistorico("@", "@", My.Settings.Estacion)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto, "AXC")
                Return
            End If

            Dim dtOrigen As DataTable = New DataTable
            dtOrigen = pResultado.Tabla.Copy


            cmbAlmacen.Properties.DataSource = dtOrigen
            cmbAlmacen.Properties.ValueMember = "Almacen"
            cmbAlmacen.Properties.DisplayMember = "Almacen"

            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Cursor.Current = Cursors.Default
            XtraMessageBox.Show(ex.Message, "AXC", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub




    Private Sub consultaAlmacenHistorico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListaAlmacenes()

    End Sub


    Private Sub BtnBuscar_Click_1(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Try
            Dim prmBusqueda As String
            Dim prmBusqueda2 As String
            Dim prmBusqueda3 As String
            If String.IsNullOrEmpty(cmbAlmacen.Text) Then
                prmBusqueda = "@"
            Else
                prmBusqueda = cmbAlmacen.Text
            End If


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
            ResultadoLista(prmBusqueda, fecha, fecha2)

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message.ToString, "Error", MessageBoxButtons.OK)
        End Try



    End Sub

    Private Sub SeparatorControl1_Click(sender As Object, e As EventArgs) Handles SeparatorControl1.Click

    End Sub
End Class