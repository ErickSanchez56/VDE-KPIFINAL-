Imports DevExpress.XtraCharts
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Base
Public Class FrmAlmacenHistorico3

    Public pClienteSeleccionada As String = ""
    Public pCliente As String
    Public pIdCliente As Int64
    Public pAccion As Integer
    Public Property RuntimeRotation As Boolean

    Private Sub ResultadoLista(prmBusqueda As String, prmBusqueda2 As Date, prmBusqueda3 As Date)
        Try
            Dim pResultado As New CResultado
            Dim Cls As New clsKPI
            Dim dt As New DataTable

            'pResultado = Cls.ResultadoListaEmpaques
            dt = pResultado.Tabla


            GridControl1.DataSource = Nothing


            Cursor.Current = Cursors.WaitCursor
            pResultado = Cls.ResultadoListaEmpaques(prmBusqueda, prmBusqueda2, prmBusqueda3, My.Settings.Estacion, DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                GridControl1.DataSource = Nothing
                Return
            End If

            Dim ds As New DataSet

            dt = pResultado.Tabla
            ds.Tables.Add(dt)

            If dt.Rows.Count < 1 Then
                XtraMessageBox.Show("Sin información en el sistema", "AXC", MessageBoxButtons.OK)
                GridControl1.DataSource = Nothing
                Return
            End If

            GridControl1.DataSource = dt
            dgvViewResultado.BestFitColumns()

            ChartControl1.DataSource = dt

            '''GRAFICA LINEAS (ESTA EN TEST)

            'ChartControl1.Series.Clear()
            'ChartControl1.Titles.Clear()
            'ChartControl1.Titles.Add(New ChartTitle() With {.Text = ""})
            'ChartControl1.Legend.Title.Text = ""
            'ChartControl1.SeriesTemplate.View = New DateTimeScale
            'Dim diagram As XYDiagram = TryCast(ChartControl1.Diagram, XYDiagram)
            ''diagram.AxisX.WholeRange.SetMinMaxValues(New DateTime(2021, 11, 1), New DateTime(2022, 1, 1))
            'diagram.AxisX.WholeRange.SideMarginsValue = 1

            ''diagram.AxisX.VisualRange.SetMinMaxValues(New DateTime(2021, 11, 1), New DateTime(2022, 1, 1))

            'Dim dateTimeScaleOptions As DateTimeScaleOptions = CType(ChartControl1.Diagram, XYDiagram).AxisX.DateTimeScaleOptions
            'dateTimeScaleOptions.MeasureUnit = DateTimeMeasureUnit.Month
            'ChartControl1.SeriesTemplate.View = New SplineSeriesView
            'CType(ChartControl1.SeriesTemplate.View, SplineSeriesView).LineStyle.DashStyle = DashStyle.Solid
            'CType(ChartControl1.SeriesTemplate.View, SplineSeriesView).LineStyle.Thickness = 2
            'CType(ChartControl1.SeriesTemplate.View, SplineSeriesView).LineMarkerOptions.Kind = MarkerKind.Diamond
            'CType(ChartControl1.SeriesTemplate.View, SplineSeriesView).MarkerVisibility = DevExpress.Utils.DefaultBoolean.True
            'CType(ChartControl1.SeriesTemplate.View, SplineSeriesView).LineMarkerOptions.Size = 8




            ''GRAFICA DE BARRAS
            'Dim series2 As New Series("Series2", ViewType.Bar)

            'ChartControl1.Series.Clear()
            'ChartControl1.Titles.Clear()
            'ChartControl1.Titles.Add(New ChartTitle() With {.Text = ""})
            'ChartControl1.Legend.Title.Text = ""
            'ChartControl1.SeriesTemplate.View = New SideBySideBarSeriesView
            'ChartControl1.SeriesDataMember = "Fecha"
            'ChartControl1.SeriesTemplate.ValueDataMembers.AddRange(New String() {"ocupado"})
            'ChartControl1.SeriesTemplate.ArgumentDataMember = "Fecha"

            'ChartControl1.RuntimeHitTesting = True


            'Dim view As SideBySideBarSeriesView = TryCast(ChartControl1.SeriesTemplate.View, SideBySideBarSeriesView)
            'view.BarDistance = 1
            'view.BarDistanceFixed = 1
            'view.BarWidth = 4
            'view.EqualBarWidth = True
            'ChartControl1.DataSource = dt


            '''GRAFICA MANHATTAN


            '' Add a bar series to it.
            'ChartControl1.Series.Clear()
            'ChartControl1.Titles.Clear()
            'Dim seriesM1 As New Series("Series M1", ViewType.ManhattanBar)
            'Dim seriesM2 As New Series("Series M2", ViewType.ManhattanBar)

            '' Add points to the series.
            'seriesM1.Points.Add(New SeriesPoint("Ocupado", dt.Rows(0).Item("Ocupado")))
            ''seriesM1.Points.Add(New SeriesPoint("Lunes", dt.Rows(1).Item("Ocupado")))
            ''seriesM1.Points.Add(New SeriesPoint("Martes", dt.Rows(2).Item("Ocupado")))
            ''seriesM1.Points.Add(New SeriesPoint("Miercoles", dt.Rows(3).Item("Ocupado")))
            'seriesM2.Points.Add(New SeriesPoint("Vacio", dt.Rows(0).Item("Vacio")))
            ''seriesM2.Points.Add(New SeriesPoint("Lunes", dt.Rows(1).Item("Vacio")))
            ''seriesM2.Points.Add(New SeriesPoint("Martes", dt.Rows(2).Item("Vacio")))
            ''seriesM2.Points.Add(New SeriesPoint("Miercoles", dt.Rows(3).Item("Vacio")))

            '' Add both series to the chart.
            'ChartControl1.Series.AddRange(New Series() {seriesM1, seriesM2})

            '' Access labels of the first series.
            'CType(seriesM1.Label, BarSeriesLabel).Visible = True
            ''CType(seriesM1.Label, BarSeriesLabel).ResolveOverlappingMode = ResolveOverlappingMode.Default
            'CType(seriesM2.Label, BarSeriesLabel).Visible = True

            '' Access the series options.
            'seriesM1.PointOptions.PointView = PointView.ArgumentAndValues

            '' Customize the view-type-specific properties of the series.
            'Dim myView As Bar3DSeriesView = CType(seriesM2.View, Bar3DSeriesView)
            'myView.BarDepthAuto = False
            'myView.BarDepth = 1
            'myView.Transparency = 80
            'myView.ShowFacet = False

            'myView.Model = Bar3DModel.Box

            '' Access the diagram's options.
            'CType(ChartControl1.Diagram, XYDiagram3D).ZoomPercent = 100

            '' Add a title to the chart and hide the legend.
            'Dim chartTitle2 As New ChartTitle()
            'chartTitle2.Text = "Almacenamiento Histórico"
            'ChartControl1.Titles.Add(chartTitle2)
            'ChartControl1.Legend.Visible = False

            '' Add the chart to the form.
            'ChartControl1.Dock = DockStyle.None
            '' Add Rotacion to chart 
            'ChartControl1.RuntimeRotation = True




            '''GRAFICA DE DONA

            Dim series1 As New Series("Doughnut Series 1", ViewType.Doughnut3D)

            ' Populate the series with points.
            ChartControl1.Series.Clear()
            ChartControl1.Titles.Clear()
            series1.Points.Add(New SeriesPoint("Ocupado", dt.Rows(0).Item("Ocupado")))
            series1.Points.Add(New SeriesPoint("Vacio", dt.Rows(0).Item("Vacio")))

            ' Add the series to the chart.
            ChartControl1.Series.Add(series1)

            ' Adjust the value numeric options of the series.
            series1.PointOptions.ValueNumericOptions.Format = NumericFormat.Percent
            series1.PointOptions.ValueNumericOptions.Precision = 2

            ' Adjust the view-type-specific options of the series.
            CType(series1.View, Doughnut3DSeriesView).HoleRadiusPercent = 30
            CType(series1.View, Doughnut3DSeriesView).ExplodedPoints.Add(series1.Points(0))

            ' Access the diagram's options.
            CType(ChartControl1.Diagram, SimpleDiagram3D).RotationType = RotationType.UseAngles
            CType(ChartControl1.Diagram, SimpleDiagram3D).RotationAngleX = -35

            ' Add a title to the chart and hide the legend.
            Dim chartTitle1 As New ChartTitle()
            chartTitle1.Text = "Porcentaje ocupacion"
            ChartControl1.Titles.Add(chartTitle1)
            ChartControl1.Legend.Visible = False

            ' Add the chart to the form.
            ChartControl1.Dock = DockStyle.None
            'Rotacion de Char3d
            ChartControl1.RuntimeRotation = True



            '''------------------------------------------------------

            ''GAUGES
            'LinearScaleComponent1.Value = dt.Rows(0).Item("Ocupado")
            ''ArcScaleComponent1.Value = dt.Rows(0).Item("Ocupado")
            ''ArcSca1leComponent2.Value = dt.Rows(1).Item("Ocupado")

            ''ArcScaleComponent3.Value = dt.Rows(3).Item("Ocupado")

            ''DIGITAL GAUGE
            'dGauge1.Text = "12:50"





        Catch ex As Exception
            XtraMessageBox.Show(ex.Message.ToString, "Error", MessageBoxButtons.OK)
        End Try
    End Sub
    Private Sub ResultadoLista2(prmBusqueda2 As Date, prmBusqueda3 As Date)
        Try
            Dim pResultado As New CResultado
            Dim Cls As New clsKPI
            Dim dt As New DataTable

            'pResultado = Cls.ResultadoListaEmpaques
            dt = pResultado.Tabla


            GridControl4.DataSource = Nothing


            Cursor.Current = Cursors.WaitCursor
            pResultado = Cls.ResultadoListaOrdenesCompletasEmb(prmBusqueda2, prmBusqueda3, My.Settings.Estacion, DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                GridControl4.DataSource = Nothing
                Return
            End If

            Dim ds As New DataSet

            dt = pResultado.Tabla
            ds.Tables.Add(dt)

            If dt.Rows.Count < 1 Then
                XtraMessageBox.Show("Sin información en el sistema", "AXC", MessageBoxButtons.OK)
                GridControl4.DataSource = Nothing
                Return
            End If

            GridControl4.DataSource = dt
            GridView5.BestFitColumns()

            '''GRAFICA DE DONA

            Dim series1 As New Series("Doughnut Series 1", ViewType.Doughnut3D)

            ' Populate the series with points.
            ChartControl4.Series.Clear()
            ChartControl4.Titles.Clear()
            series1.Points.Add(New SeriesPoint("Liberadas Totales", dt.Rows(0).Item("PorcentajeLiberadasTotales")))
            series1.Points.Add(New SeriesPoint("Liberadas Parciales", dt.Rows(0).Item("PorcentajeLiberadasParciales")))
            series1.Points.Add(New SeriesPoint("Surtidas", dt.Rows(0).Item("PorcentajeSurtidas")))
            series1.Points.Add(New SeriesPoint("Validadas", dt.Rows(0).Item("PorcentajeValidadas")))
            series1.Points.Add(New SeriesPoint("Embarcadas", dt.Rows(0).Item("PorcentajeEmbarcadas")))
            series1.Points.Add(New SeriesPoint("Rechazadas", dt.Rows(0).Item("PorcentajeRechazadas")))
            ' Add the series to the chart.
            ChartControl4.Series.Add(series1)

            ' Adjust the value numeric options of the series.
            series1.PointOptions.ValueNumericOptions.Format = NumericFormat.Percent
            series1.PointOptions.ValueNumericOptions.Precision = 2

            ' Adjust the view-type-specific options of the series.
            CType(series1.View, Doughnut3DSeriesView).HoleRadiusPercent = 30
            CType(series1.View, Doughnut3DSeriesView).ExplodedPoints.Add(series1.Points(0))

            ' Access the diagram's options.
            CType(ChartControl4.Diagram, SimpleDiagram3D).RotationType = RotationType.UseAngles
            CType(ChartControl4.Diagram, SimpleDiagram3D).RotationAngleX = -35

            ' Add a title to the chart and hide the legend.
            Dim chartTitle1 As New ChartTitle()
            chartTitle1.Text = "Porcentaje Ordenes Embarque"
            ChartControl4.Titles.Add(chartTitle1)
            ChartControl4.Legend.Visible = False

            ' Add the chart to the form.
            ChartControl4.Dock = DockStyle.None
            'Rotacion de Char3d
            ChartControl4.RuntimeRotation = True








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
    Private Sub TabNavigationPage1_Paint(sender As Object, e As PaintEventArgs) Handles TabNavigationPage1.Paint

    End Sub

    Private Sub dtpFechaInicio_EditValueChanged(sender As Object, e As EventArgs) Handles dtpFechaInicio.EditValueChanged

    End Sub

    Private Sub cmbAlmacen_EditValueChanged(sender As Object, e As EventArgs) Handles cmbAlmacen.EditValueChanged

    End Sub

    Private Sub dtpFechaFin_EditValueChanged(sender As Object, e As EventArgs) Handles dtpFechaFin.EditValueChanged

    End Sub

    Private Sub DateEdit1_EditValueChanged(sender As Object, e As EventArgs) Handles DateEdit1.EditValueChanged

    End Sub

    Private Sub DateEdit2_EditValueChanged(sender As Object, e As EventArgs) Handles DateEdit2.EditValueChanged

    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
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

    Private Sub dgvResultado_Click(sender As Object, e As EventArgs) Handles GridControl1.Click
        Try
            If IsNothing(GridControl1.DataSource) Then
                Return
            End If

            Dim ds As New DataSet


            Dim view As ColumnView = CType(GridControl1.MainView, ColumnView)
            Dim selectedRowHandles As Integer() = view.GetSelectedRows()

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message.ToString, "Error", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub FrmAlmacenHistorico2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListaAlmacenes()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click

    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        Try

            Dim prmBusqueda2 As String
            Dim prmBusqueda3 As String



            If String.IsNullOrEmpty(DateEdit5.Text) Then
                prmBusqueda2 = "@"
            Else
                prmBusqueda2 = DateEdit5.Text
            End If
            Dim fecha As New Date
            fecha = Date.Parse(DateEdit5.EditValue.ToString)
            'ResultadoLista(prmBusqueda2, fecha)



            If String.IsNullOrEmpty(DateEdit6.Text) Then
                prmBusqueda3 = "@"
            Else
                prmBusqueda3 = DateEdit6.Text
            End If
            Dim fecha2 As New Date
            fecha2 = Date.Parse(DateEdit6.EditValue.ToString)
            ResultadoLista2(fecha, fecha2)



        Catch ex As Exception
            XtraMessageBox.Show(ex.Message.ToString, "Error", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub GridView5_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GridView5.RowClick
        Try



        Catch ex As Exception
            XtraMessageBox.Show(ex.Message.ToString, "Error", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub SimpleButton2_Click_1(sender As Object, e As EventArgs) Handles SimpleButton2.Click

    End Sub
End Class