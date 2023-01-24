Imports DevExpress.XtraEditors

Public Class FrmModifcaPartidaEvento
#Region "VARIABLES"


#End Region

#Region "EVENTOS"
    Private Sub FrmModificaTransferPT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            ListaNumParte()

            Dim sNum As String = FrmTraspasoSalidaPT.txtArticuloPartida.Text
            cmbNumParte.EditValue = FrmTraspasoSalidaPT.txtArticuloPartida.Text 'cmbNumParte.Properties.GetIndexByKeyValue(FrmTraspasoSalidaPT.txtArticuloPartida.Text) '.GetDataSourceRowIndex("ERPAlmacen", row("Origen").ToString)

            txtCantidad.Text = FrmTraspasoSalidaPT.txtCantidadPartida.Text
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnAceptar_Click(sender As System.Object, e As System.EventArgs) Handles btnAceptar.Click

        FrmTraspasoSalidaPT.txtArticuloPartida.Text = cmbNumParte.Text
        FrmTraspasoSalidaPT.txtCantidadPartida.Text = txtCantidad.Text
        FrmTraspasoSalidaPT.txtDescPartida.Text = txtDescripcion.Text

        Me.Close()

    End Sub

    Private Sub cmbNumParte_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbNumParte.EditValueChanged
        Try
            Dim text As String = cmbNumParte.Text
            If text.Equals("System.Data.DataRowView") Then
                Return
            End If
            ConsultaNumParte()

            txtCantidad.Text = ""
            'cargarLotes(cmbNumParte.Text)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

#End Region

#Region "METODOS"
    Private Sub ListaNumParte()
        Try
            Dim pResultado As New CResultado
            Dim pOC As New COrdenCompraR

            Cursor.Current = Cursors.WaitCursor
            pResultado = pOC.ListaNumParte()
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                Return
            End If

            Dim dt As DataTable = New DataTable
            dt = pResultado.Tabla

            cmbNumParte.Properties.ValueMember = "IdNumParte"
            cmbNumParte.Properties.DisplayMember = "NumParte"
            cmbNumParte.Properties.DataSource = dt
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
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
                MsgBox(pResultado.Texto)

                Return
            End If

            Dim dt As DataTable = New DataTable
            dt = pResultado.Tabla

            txtDescripcion.Text = dt.Rows(0).Item("DNumParte1")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

#End Region
End Class