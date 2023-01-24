Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Base

Public Class FrmConfiguracionImpresora
    Private Sub FrmConfiguracionImpresora_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ListaImpresoras("@")
            ListaImpresorasDisponibles("@")
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ListaImpresoras(prmBusqueda As String)
        Try
            dgvImpresora.DataSource = Nothing

            Dim pResultado As New CResultado
            Dim cls As New clsImpresora

            Cursor.Current = Cursors.WaitCursor
            pResultado = cls.ListaProcesosImpresoras(My.Settings.Estacion, DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                dgvImpresora.DataSource = Nothing
                Return
            End If
            Dim dt As New DataTable
            Dim ds As New DataSet

            dt = pResultado.Tabla
            ds.Tables.Add(dt)

            If dt.Rows.Count < 1 Then
                XtraMessageBox.Show("No hay procesos en el sistema")
                dgvImpresora.DataSource = Nothing
                Return
            End If

            dgvImpresora.DataSource = dt



        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ListaImpresorasDisponibles(prmBusqueda As String)
        Try


            Dim pResultado As New CResultado
            Dim ws As New wsAXC.wsAXCMP

            Cursor.Current = Cursors.WaitCursor
            pResultado.Tabla = ws.WM_ListaImpresoras.Tabla
            Cursor.Current = Cursors.Default


            Dim dt As New DataTable
            Dim ds As New DataSet

            dt = pResultado.Tabla
            ds.Tables.Add(dt)


            CmbImpresora.Properties.ValueMember = "Impresora"
            CmbImpresora.Properties.DisplayMember = "Impresora"
            CmbImpresora.Properties.DataSource = dt

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub GridView1_Click(sender As Object, e As EventArgs) Handles GridView1.Click
        Try

            If GridView1.SelectedRowsCount < 1 Then
                Exit Sub
            End If

            Dim view As ColumnView = CType(dgvImpresora.MainView, ColumnView)
            Dim selectedRowHandles As Integer() = view.GetSelectedRows()
            CmbImpresora.EditValue = view.GetRowCellDisplayText(selectedRowHandles(0), view.Columns("Impresora"))


        Catch ex As Exception
            XtraMessageBox.Show(ex.Message.ToString, "Error", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Try
            If GridView1.SelectedRowsCount < 1 Then
                Exit Sub
            End If

            Dim view As ColumnView = CType(dgvImpresora.MainView, ColumnView)
            Dim selectedRowHandles As Integer() = view.GetSelectedRows()


            If XtraMessageBox.Show("Cambiar impresora al proceso [" + view.GetRowCellDisplayText(selectedRowHandles(0), view.Columns("Tag1")) + "]?", "Confirmación", MessageBoxButtons.YesNo) <> DialogResult.Yes Then
                Return
            End If

            Dim pResultado As New CResultado
            Dim Cls As New clsImpresora

            Cursor.Current = Cursors.WaitCursor
            pResultado = Cls.AsociaProcesoImpresora(view.GetRowCellDisplayText(selectedRowHandles(0), view.Columns("Tag1")), CmbImpresora.Text, My.Settings.Estacion, DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                Return
            End If

            XtraMessageBox.Show("Cambio de impresora a proceso exitosamente")
            ListaImpresoras("@")
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FrmConfiguracionImpresora_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose(True)
    End Sub
End Class