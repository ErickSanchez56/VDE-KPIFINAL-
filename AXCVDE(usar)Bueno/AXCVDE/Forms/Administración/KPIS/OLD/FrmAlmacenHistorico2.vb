Imports DevExpress.XtraCharts
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Base
Public Class FrmAlmacenHistorico2

    Public pClienteSeleccionada As String = ""
    Public pCliente As String
    Public pIdCliente As Int64
    Public pAccion As Integer
    Public Property RuntimeRotation As Boolean

    Private Sub ResultadoLista4(prmBusqueda As String, prmBusqueda2 As Date, prmBusqueda3 As Date)
        Try
            Dim pResultado As New CResultado
            Dim Cls As New clsKPI
            Dim dt As New DataTable

            'pResultado = Cls.ResultadoListaEmpaques
            dt = pResultado.Tabla


            GridControl1.DataSource = Nothing


            Cursor.Current = Cursors.WaitCursor
            pResultado = Cls.DatosCicloRecibo(prmBusqueda, prmBusqueda2, prmBusqueda3, My.Settings.Estacion, DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                GridControl1.DataSource = Nothing
                Return
            End If

            Dim ds As New DataSet

            dt = pResultado.Tabla
            ds.Tables.Add(dt)


            Dim tablaPromedioGeneral As DataTable
            Dim tablaDetallePallet As DataTable
            ' Dim tablaMym As DataTable

            tablaPromedioGeneral = pResultado.Tablas.Tables(1)
            tablaDetallePallet = pResultado.Tablas.Tables(2)
            ' tablaMym = pResultado.Tablas.Tables(2)

            If dt.Rows.Count < 1 Then
                XtraMessageBox.Show("Sin información en el sistema", "AXC", MessageBoxButtons.OK)
                GridControl1.DataSource = Nothing
                Return
            End If

            digitalGauge3.Text = tablaPromedioGeneral.Rows(0).Item("Dias")
            DigitalGauge1.Text = tablaPromedioGeneral.Rows(0).Item("Horas")
            DigitalGauge2.Text = tablaPromedioGeneral.Rows(0).Item("Minutos")

            GridControl1.DataSource = tablaDetallePallet
            dgvViewResultado.BestFitColumns()


            ChartControl1.Titles.Clear()
            ChartControl1.Series.Clear()
            ChartControl1.DataSource = tablaDetallePallet
            ChartControl1.Titles.Add(New ChartTitle() With {.Text = "Tiempo Promedio Recepción"})
            ChartControl1.Legend.Title.Text = ""
            ChartControl1.SeriesDataMember = "Orden"
            ChartControl1.SeriesTemplate.ValueDataMembers.AddRange(New String() {"TotalMinutos"})
            ChartControl1.SeriesTemplate.ArgumentDataMember = "Orden"
            ChartControl1.RuntimeHitTesting = True
            Dim view As SideBySideBarSeriesView = TryCast(ChartControl1.SeriesTemplate.View, SideBySideBarSeriesView)
            Dim diagram As XYDiagram = CType(ChartControl1.Diagram, XYDiagram)

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
    Private Sub ResultadoLista5(prmBusqueda As String, prmBusqueda2 As Date, prmBusqueda3 As Date)
        Try
            Dim pResultado As New CResultado
            Dim Cls As New clsKPI
            Dim dt As New DataTable

            'pResultado = Cls.ResultadoListaEmpaques
            dt = pResultado.Tabla


            GridControl2.DataSource = Nothing


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
            tablaDetallePallet = pResultado.Tablas.Tables(2)
            'tablaMym = pResultado.Tablas.Tables(2)

            If dt.Rows.Count < 1 Then
                XtraMessageBox.Show("Sin información en el sistema", "AXC", MessageBoxButtons.OK)
                GridControl2.DataSource = Nothing
                Return
            End If

            DigitalGauge6.Text = tablaPromedioGeneral.Rows(0).Item("Dias")
            DigitalGauge5.Text = tablaPromedioGeneral.Rows(0).Item("Horas")
            DigitalGauge4.Text = tablaPromedioGeneral.Rows(0).Item("Minutos")

            GridControl2.DataSource = tablaDetallePallet
            dgvViewResultado.BestFitColumns()


            ChartControl2.Titles.Clear()
            ChartControl2.Series.Clear()
            ChartControl2.DataSource = tablaDetallePallet
            ChartControl2.Titles.Add(New ChartTitle() With {.Text = "Tiempo Promedio Recepción"})
            ChartControl2.Legend.Title.Text = ""
            ChartControl2.SeriesDataMember = "CodigoPallet"
            ChartControl2.SeriesTemplate.ValueDataMembers.AddRange(New String() {"TotalMinutos"})
            ChartControl2.SeriesTemplate.ArgumentDataMember = "CodigoPallet"
            ChartControl2.RuntimeHitTesting = True
            Dim view As SideBySideBarSeriesView = TryCast(ChartControl2.SeriesTemplate.View, SideBySideBarSeriesView)
            Dim diagram As XYDiagram = CType(ChartControl2.Diagram, XYDiagram)

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

    Private Sub ResultadoLista6(prmBusqueda As String, prmBusqueda2 As Date, prmBusqueda3 As Date)

        Try
            Dim pResultado As New CResultado
            Dim Cls As New clsKPI
            Dim dt As New DataTable


            dt = pResultado.Tabla


            'GridControl3.DataSource = Nothing


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
            Dim tablaPromedioMixto As DataTable
            Dim tablaPromedioDetalle As DataTable
            Dim tablaCantidadOrdenes As DataTable
            Dim tablaDetallePallet As DataTable
            ' Dim tablaMym As DataTable

            tablaPromedioTodo = pResultado.Tablas.Tables(1)
            tablaPromedioMixto = pResultado.Tablas.Tables(2)
            tablaPromedioDetalle = pResultado.Tablas.Tables(3)
            tablaCantidadOrdenes = pResultado.Tablas.Tables(4)
            'tablaDetallePallet = pResultado.Tablas.Tables(2)
            'tablaMym = pResultado.Tablas.Tables(2)

            If dt.Rows.Count < 1 Then
                XtraMessageBox.Show("Sin información en el sistema", "AXC", MessageBoxButtons.OK)
                'GridControl3.DataSource = Nothing
                Return
            End If

            DigitalGauge9.Text = tablaPromedioTodo.Rows(0).Item("Dias")
            DigitalGauge8.Text = tablaPromedioTodo.Rows(0).Item("Horas")
            DigitalGauge7.Text = tablaPromedioTodo.Rows(0).Item("Minutos")

            DigitalGauge12.Text = tablaPromedioMixto.Rows(0).Item("Dias")
            DigitalGauge11.Text = tablaPromedioMixto.Rows(0).Item("Horas")
            DigitalGauge10.Text = tablaPromedioMixto.Rows(0).Item("Minutos")

            DigitalGauge15.Text = tablaPromedioDetalle.Rows(0).Item("Dias")
            DigitalGauge14.Text = tablaPromedioDetalle.Rows(0).Item("Horas")
            DigitalGauge13.Text = tablaPromedioDetalle.Rows(0).Item("Minutos")

            ' GridControl3.DataSource = tablaDetallePallet
            dgvViewResultado.BestFitColumns()


            ChartControl3.Titles.Clear()
            ChartControl3.Series.Clear()
            ChartControl3.DataSource = tablaCantidadOrdenes
            ChartControl3.Titles.Add(New ChartTitle() With {.Text = "Tiempo Promedio Surtido"})
            ChartControl3.Legend.Title.Text = ""
            ChartControl3.SeriesDataMember = "Tipo"
            ChartControl3.SeriesTemplate.ValueDataMembers.AddRange(New String() {"Cantidad"})
            ChartControl3.SeriesTemplate.ArgumentDataMember = "Tipo"
            ChartControl3.RuntimeHitTesting = True
            Dim view As SideBySideBarSeriesView = TryCast(ChartControl3.SeriesTemplate.View, SideBySideBarSeriesView)
            Dim diagram As XYDiagram = CType(ChartControl3.Diagram, XYDiagram)

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

    Private Sub DateEdit1_EditValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub DateEdit2_EditValueChanged(sender As Object, e As EventArgs)

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
            ResultadoLista4(prmBusqueda, fecha, fecha2)
            ResultadoLista5(prmBusqueda, fecha, fecha2)
            ResultadoLista6(prmBusqueda, fecha, fecha2)

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



    Private Sub GridView5_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs)
        Try



        Catch ex As Exception
            XtraMessageBox.Show(ex.Message.ToString, "Error", MessageBoxButtons.OK)
        End Try
    End Sub


End Class