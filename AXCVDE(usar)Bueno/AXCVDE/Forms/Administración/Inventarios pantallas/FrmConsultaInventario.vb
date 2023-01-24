Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraReports.UI
Public Class FrmConsultaInventario
#Region "VARIABLES"
    Dim dsReporte As New DataSet
#End Region

#Region "EVENTOS"


    Private Sub FrmConsultarOrdenesCompra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'Dim TipoBus = New List(Of String)()
            'TipoBus.Add("PRODUCTO")
            'TipoBus.Add("POSICION")
            'cmbTipo.Properties.DataSource = TipoBus
            'cmbTipo.ItemIndex = 0
            dtpFechaFin.EditValue = Date.Now
            dtpFechaInicio.EditValue = Date.Now

            'Dim TipoBus = New List(Of String)()

            ListPlantas()
            ListEstatus()
            ListEstatusTiposInventario()
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub


    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Try
            If String.IsNullOrEmpty(CmbTipoInventario.Text) Then
                XtraMessageBox.Show("Seleccione un tipo de inventario para poder buscar", "AXC")
                Return
            End If

            Dim pBusqueda As String = "@"

            If String.IsNullOrEmpty(txtBusqueda.Text.Trim()) Then
                pBusqueda = "@"
            Else
                pBusqueda = txtBusqueda.Text
            End If
            cargarResultados(pBusqueda)
            'btnLiberacion.Enabled = True
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub

    Private Sub txtOrdenCompra_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBusqueda.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
        End Select
    End Sub
#End Region

#Region "METODOS"

    Private Sub ListEstatus()
        Try

            Dim pResultado As New CResultado
            Dim pCons As New ClsAlmacen

            Cursor.Current = Cursors.WaitCursor
            pResultado = pCons.ListaEstatusInventario("@", "@")
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                Return
            End If

            Dim dt As DataTable = New DataTable
            Dim ds As New DataSet

            dt = pResultado.Tabla.Copy
            ds.Tables.Add(dt)
            Dim row As DataRow = ds.Tables(0).NewRow
            row.Item(0) = "TODOS"
            row.Item(0) = "TODOS"
            'row.Item(1) = "TODOS"

            ds.Tables(0).Rows.InsertAt(row, 0)

            cmbEstatus.Properties.ValueMember = "DStatus"
            cmbEstatus.Properties.DisplayMember = "DStatus"
            cmbEstatus.Properties.DataSource = dt

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub

    Private Sub ListEstatusTiposInventario()
        Try

            Dim pResultado As New CResultado
            Dim pCons As New ClsAlmacen

            Cursor.Current = Cursors.WaitCursor
            pResultado = pCons.ListaTiposInventariosCResult("@", "@")
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                Return
            End If

            Dim dt As DataTable = New DataTable
            Dim ds As New DataSet

            dt = pResultado.Tabla.Copy
            ds.Tables.Add(dt)
            'Dim row As DataRow = ds.Tables(0).NewRow
            'row.Item(0) = 0
            'row.Item(0) = 0
            'row.Item(1) = "TODOS"

            'ds.Tables(0).Rows.InsertAt(row, 0)

            CmbTipoInventario.Properties.ValueMember = "Tipo"
            CmbTipoInventario.Properties.DisplayMember = "Tipo"
            CmbTipoInventario.Properties.DataSource = dt

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub

    Private Sub ListPlantas()
        Try


            Dim pResultado As New CResultado
            Dim pCons As New ClsPlanta

            Cursor.Current = Cursors.WaitCursor
            pResultado = pCons.ListaPlantas("@", "@")
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                Return
            End If

            Dim dt As DataTable = New DataTable
            Dim ds As New DataSet

            dt = pResultado.Tabla.Copy
            ds.Tables.Add(dt)
            Dim row As DataRow = ds.Tables(0).NewRow
            row.Item(0) = 0
            row.Item(0) = 0
            row.Item(1) = "TODAS"
            row.Item(2) = "TODAS"
            row.Item(3) = "TODAS"
            ds.Tables(0).Rows.InsertAt(row, 0)

            cmbPlanta.Properties.ValueMember = "Planta"
            cmbPlanta.Properties.DisplayMember = "Planta"
            cmbPlanta.Properties.DataSource = dt

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub
    Public Sub cargarResultados(ByVal prmBusqueda As String)
        Try
            dsReporte = New DataSet
            dgvResultado.DataSource = Nothing
            dgvDetalle.DataSource = Nothing
            Dim pConsulta As New ClsAlmacen
            Dim ds As New CResultado

            Dim dInicio As New Date
            Dim dFin As New Date
            dInicio = Date.Parse(dtpFechaInicio.EditValue.ToString)
            dFin = Date.Parse(dtpFechaFin.EditValue.ToString)

            ds = (pConsulta.ListaConsultaEjerciciosInventario(IIf(String.IsNullOrEmpty(prmBusqueda), "@", prmBusqueda), IIf(CmbTipoInventario.Text = "TODOS", "@", CmbTipoInventario.Text), IIf(cmbPlanta.Text = "TODAS", "@", cmbPlanta.Text), IIf(cmbEstatus.Text = "TODOS", "@", cmbEstatus.Text), dInicio.ToString("yyyyMMdd"), dFin.ToString("yyyyMMdd"), My.Settings("Estacion"), DatosTemporales.Usuario))
            dgvDetalle.DataSource = Nothing
            If Not ds.Estado Then

                XtraMessageBox.Show("No hay información a reportar", "AXC")
                Return
            End If
            dgvResultado.DataSource = ds.Tabla
            'dsReporte.Tables.Add(ds.Tables(1).Copy())
        Catch ex As Exception
            XtraMessageBox.Show("Error: " + ex.Message, "AXC")
        End Try
    End Sub

    Public Sub CargarDetalle(ByVal prmOrdenCompra As String)
        Try
            dgvDetalle.DataSource = Nothing

            Dim pResultado As New CResultado
            Dim cls As New ClsAlmacen

            Cursor.Current = Cursors.WaitCursor
            pResultado = cls.ListaConsultaEjerciciosInventarioDetalles(prmOrdenCompra, My.Settings("Estacion"), DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                dgvDetalle.DataSource = Nothing
                Return
            End If

            Dim dt As New DataTable
            Dim ds As New DataSet

            dt = pResultado.Tabla
            ds.Tables.Add(dt)

            If dt.Rows.Count < 1 Then
                XtraMessageBox.Show("Sin información")
                dgvDetalle.DataSource = Nothing
                Return
            End If

            dgvDetalle.DataSource = dt
            GridView2.BestFitColumns()

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnReporte_Click(sender As Object, e As EventArgs)
        Try
            FrmRepRecFechas.ShowDialog()
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub

    Private Sub FrmConsultarOrdenesCompra_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose(True)
    End Sub

    Private Sub dgvResultado_Click(sender As Object, e As EventArgs) Handles dgvResultado.Click
        Try
            If GridView1.RowCount <= 0 Then
                Return
            End If

            Dim cls As New ClsOrdenCompra

            Dim view As ColumnView = CType(dgvResultado.MainView, ColumnView)

            Dim selectedrowHandles As Integer() = view.GetSelectedRows

            Dim OrdenCompraD As String = ""
            OrdenCompraD = (view.GetRowCellValue(selectedrowHandles(0), "IdEjercicio"))
            CargarDetalle(OrdenCompraD)
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub

    Private Sub btnLiberacion_Click(sender As Object, e As EventArgs)
        Try
            Dim frmLiberaOrdenCompra As New FrmLiberaOrdenCompra
            Dim view As ColumnView = CType(dgvResultado.MainView, ColumnView)
            Dim selectedRowHandles As Integer() = view.GetSelectedRows

            Dim OrdenCompraD As String = ""
            OrdenCompraD = (view.GetRowCellValue(selectedRowHandles(0), "OrdenCompra"))
            frmLiberaOrdenCompra.pOrdenCompra = OrdenCompraD
            frmLiberaOrdenCompra.MdiParent = FrmMenuPrincipal.XtraTabbedMdiManager1.MdiParent
            frmLiberaOrdenCompra.Show()
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try

    End Sub



#End Region
End Class