Imports DevExpress.XtraEditors

Public Class FrmImpresionContenedores
    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        Try
            If XtraMessageBox.Show("¿Desea imprimir las etiquetas?", "AXC", MessageBoxButtons.YesNo) <> DialogResult.Yes Then
                Return
            End If


            If numEtiquetas.Value = 0 Then
                XtraMessageBox.Show("Valor introducido no válido", "AXC")
                Return
            End If

            ImprimeEtiquetas()
        Catch ex As Exception
                   XtraMessageBox.Show(ex.Message, "AXC", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub numEtiquetas_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles numEtiquetas.Leave
        If ((numEtiquetas.Value Mod 2) <> 0) Then
            numEtiquetas.Value = numEtiquetas.Value + 1
        End If
    End Sub

    Private Sub ListarImpresora()

        Try

            Dim pResultado As New CResultado
            Dim pCons As New clsImpresora

            Cursor.Current = Cursors.WaitCursor
            pResultado = pCons.CargarImpresora(My.Settings.Estacion, DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                     XtraMessageBox.Show(pResultado.Texto, "AXC")
                Return
            End If
            Dim dt As New DataTable
            Dim ds As New DataSet

            dt = pResultado.Tabla
            ds.Tables.Add(dt)

            cmbImpresora.Properties.ValueMember = "Impresora"
            cmbImpresora.Properties.DisplayMember = "Impresora"
            cmbImpresora.Properties.DataSource = dt

        Catch ex As Exception
              XtraMessageBox.Show(ex.Message, "AXC", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ImprimeEtiquetas()
        Try
            Dim CRespuesta As New CResultado

            Dim pResultado As New wsAXC.CResultado
            Dim ws As New wsAXC.wsAXCMP

            Dim pUrl As String = My.Settings("AXCVDE_wsAXC_wsAXCMP")

            If pUrl = "" Then
                pUrl = "http://192.168.1.181/wsAXCMP/wsAXCMP.asmx"
            End If

            ws.Url = pUrl
            Cursor.Current = Cursors.WaitCursor
            '   pResultado = ws.WM_ImpContenedor(numEtiquetas.Value, cmbImpresora.Text, "1", DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then

                XtraMessageBox.Show("ER" + pResultado.Texto, "AXC")
                Return
            Else
                XtraMessageBox.Show("Impresión enviada con exito", "AXC")
            End If

        Catch ex As Exception
                   XtraMessageBox.Show(ex.Message, "AXC", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub FrmImpresionContenedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ListarImpresora()
        Catch ex As Exception
           XtraMessageBox.Show(ex.Message, "AXC", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class