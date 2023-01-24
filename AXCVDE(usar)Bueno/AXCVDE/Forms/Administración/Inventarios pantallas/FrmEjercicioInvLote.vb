Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Base

Public Class FrmEjercicioInvLote
    Private Sub FrmEjercicioInvLote_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            txtTipoEjercicio.Text = "CÍCLICO POR LOTE"
            txtComentarios.Select()
            ListaNumParte()
            ListaAlmacenes()
            cmbAlmacen.EditValue = 0
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub

    Private Sub ListaNumParte()
        Try
            Dim pResultado As New CResultado
            Dim pOC As New COrdenCompraR

            Cursor.Current = Cursors.WaitCursor
            pResultado = pOC.ListaNumParte()
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto, "AXC")
                Return
            End If

            Dim dt As DataTable = New DataTable
            dt = pResultado.Tabla

            cmbNumParte.Properties.ValueMember = "IdNumParte"
            cmbNumParte.Properties.DisplayMember = "NumParte"
            cmbNumParte.Properties.DataSource = dt
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try

    End Sub

    Private Sub ConsultaNumParte()
        Try
            Dim pResultado As New CResultado
            Dim pOP As New COrdenProd

            Cursor.Current = Cursors.WaitCursor
            pResultado = pOP.ConsultaNumParte(cmbNumParte.Text)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto, "AXC")

                Return
            End If

            Dim dt As DataTable = New DataTable
            dt = pResultado.Tabla

            txtDescripcion.Text = dt.Rows(0).Item("DNumParte1")
            ' lblExistencia.Text = dt.Rows(0).Item("Existencia")
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub

    Private Sub CargarLotes(prmBusqueda As String)
        Try
            dgvPosSelect.DataSource = Nothing

            Dim pResultado As New CResultado
            Dim Cls As New clsNumParte

            Cursor.Current = Cursors.WaitCursor
            pResultado = Cls.ListaLoteXNumParte(prmBusqueda, My.Settings.Estacion, DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto, "AXC")
                dgvPosSelect.DataSource = Nothing
                Return
            End If
            Dim dt As New DataTable
            Dim ds As New DataSet

            dt = pResultado.Tabla
            ds.Tables.Add(dt)

            If dt.Rows.Count < 1 Then
                XtraMessageBox.Show("No hay lotes dosponibles para mostrar", "AXC")
                dgvPosSelect.DataSource = Nothing
                Return
            End If

            dgvPosSelect.DataSource = dt

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub cmbNumParte_EditValueChanged(sender As Object, e As EventArgs) Handles cmbNumParte.EditValueChanged
        Try

            If Not String.IsNullOrEmpty(cmbNumParte.Text) Then
                ConsultaNumParte()
                CargarLotes(cmbNumParte.Text)
            End If


        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try

            If String.IsNullOrEmpty(txtComentarios.Text) Then
                XtraMessageBox.Show("Ingresar comentarios", "AXC", MessageBoxButtons.OK)
                Return
            End If


            Dim iSeleccion As Integer = 0
            Dim iCant As Integer = 0

            Dim view As ColumnView = CType(dgvPosSelect.MainView, ColumnView)
            Dim selectedRowHandles As Integer() = view.GetSelectedRows()



            If selectedRowHandles.Count = 0 Then
                XtraMessageBox.Show("No hay ningún lote seleccionado. Favor de seleccionar alguno de ellos.", "AXC")
                dgvPosSelect.DataSource = Nothing
                Return
            End If

            If String.IsNullOrEmpty(cmbAlmacen.Text) Then
                XtraMessageBox.Show("Seleccionar almacén", "AXC", MessageBoxButtons.OK)
                cmbAlmacen.Select()
                Return
            End If

            If XtraMessageBox.Show("Crear ejercicio de inventario?", "AXC", MessageBoxButtons.YesNo) <> DialogResult.Yes Then
                Return
            End If


            Dim pResultado As New CResultado
            Dim Cls As New ClsAlmacen

            Cursor.Current = Cursors.WaitCursor
            pResultado = Cls.CreaEjercicioInventario(txtTipoEjercicio.Text, txtComentarios.Text, cmbAlmacen.Text, My.Settings.Estacion, DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto, "AXC")
                dgvPosSelect.DataSource = Nothing
                Return
            End If
            Dim dt As New DataTable
            Dim ds As New DataSet


            Dim IdEjercicio As Long
            IdEjercicio = Convert.ToInt16(pResultado.Texto.ToString())

            pResultado = New CResultado
            Cls = New ClsAlmacen



            For i As Integer = 0 To selectedRowHandles.Count - 1

                Cursor.Current = Cursors.WaitCursor
                pResultado = Cls.CreaEjercicioInventarioPorLote(IdEjercicio, cmbNumParte.Text, view.GetRowCellValue(selectedRowHandles(i), view.Columns("LoteAXC")), My.Settings.Estacion, DatosTemporales.Usuario)
                Cursor.Current = Cursors.Default
            Next

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto, "AXC")
                dgvPosSelect.DataSource = Nothing
                Return
            End If

            XtraMessageBox.Show("Ejercicio de inventario creado con éxito", "AXC", MessageBoxButtons.OK)
            ReiniciarTodo()

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub

    Public Sub ReiniciarTodo()
        txtComentarios.Text = ""
        cmbNumParte.Refresh()
        txtDescripcion.Text = ""
        dgvPosSelect.DataSource = Nothing


    End Sub

    Private Sub FrmEjercicioInvLote_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose(True)
    End Sub

    Private Sub ListaAlmacenes()
        Try
            Dim pResultado As New CResultado
            Dim pAlmacen As New ClsAlmacen

            Cursor.Current = Cursors.WaitCursor
            pResultado = pAlmacen.ListaAlmacen("@", "@", My.Settings.Estacion)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto, "AXC")
                Return
            End If

            Dim dtOrigen As DataTable = New DataTable
            dtOrigen = pResultado.Tabla.Copy


            cmbAlmacen.Properties.DataSource = dtOrigen
            cmbAlmacen.Properties.ValueMember = "ERPAlmacen"
            cmbAlmacen.Properties.DisplayMember = "ERPAlmacen"

            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Cursor.Current = Cursors.Default
            XtraMessageBox.Show(ex.Message, "AXC", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class