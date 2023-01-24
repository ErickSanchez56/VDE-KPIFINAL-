Imports DevExpress.XtraGrid.Views.Base

Public Class FrmBuscaTransferPT
    Dim pCierre As Boolean = False



    Private Sub FrmBuscaTransferPT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            Dim pResultado As New CResultado
            Dim pTransfer As New clsTransfer

            Cursor.Current = Cursors.WaitCursor
            pResultado = pTransfer.ConsultaTransfersPT()
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                MsgBox(pResultado.Texto)
                grdTransfer.DataSource = Nothing
                Return
            End If

            Dim dt As DataTable = New DataTable

            dt = pResultado.Tabla

            grdTransfer.DataSource = dt


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub btnAceptar_Click(sender As System.Object, e As System.EventArgs) Handles btnAceptar.Click

        If GridView1.RowCount = 0 Then
            Return
        End If
        If String.IsNullOrEmpty(grdTransfer.DataSource.ToString) Then
            Return
        End If

        Dim pTransfer As String '= grdDetalle.Item(1, grdTransfer.CurrentRow.Index).Value().ToString()

        Dim view As ColumnView = CType(grdTransfer.MainView, ColumnView)
        Dim selectedRowHandles As Integer() = view.GetSelectedRows()

        pTransfer = view.GetRowCellDisplayText(selectedRowHandles(0), view.Columns(0))

        FrmTraspasoSalidaPT.LlenaVariables(pTransfer, True)
        pCierre = True
        'FrmMostrarTransferPT.txtTransfer.Text = grdTransfer.Item(0, grdTransfer.CurrentRow.Index).Value()

        Me.Close()

    End Sub

    Private Sub FrmBuscaTransferPT_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Not pCierre Then
            FrmTraspasoSalidaPT.LlenaVariables("", False)
        End If
        Me.Dispose(True)
    End Sub
End Class