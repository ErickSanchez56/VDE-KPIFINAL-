Imports DevExpress.XtraEditors

Public Class FrmEtiquetasEmpaque
    Private Sub FrmEtiquetasEmpaque_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            TxtLote.Text = ""
            TxtLote.Select()
            ListarImpresora()


        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

#Region "METODOS"

    Private Sub ListarImpresora()

        Try

            Dim pResultado As New CResultado
            Dim pCons As New clsImpresora

            Cursor.Current = Cursors.WaitCursor
            pResultado = pCons.CargarImpresora(My.Settings.Estacion, DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                MsgBox(pResultado.Texto)
                Return
            End If
            Dim dt As New DataTable
            Dim ds As New DataSet

            dt = pResultado.Tabla
            ds.Tables.Add(dt)

            CmbImpresora.Properties.ValueMember = "Impresora"
            CmbImpresora.Properties.DisplayMember = "Impresora"
            CmbImpresora.Properties.DataSource = dt

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "AXC")
        End Try
    End Sub

    Private Sub ImprimeEtiquetas()
        Try
            Dim CRespuesta As New CResultado

            Dim pResultado As New wsAXC.CResultado
            Dim ws As New wsAXC.wsAXCMP

            Dim pUrl As String = My.Settings("AXCVDE_wsAXC_wsAXCMP")

            If pUrl = "" Then
                pUrl = "http://192.168.1.181/axcVDEpt/wsAXCMP.asmx"
            End If


            ws.Url = pUrl
            Cursor.Current = Cursors.WaitCursor
            pResultado = ws.WM_ImprimeEtiquetaEmpaque(CmbImpresora.Text, numEtiquetas.Value, My.Settings.Estacion, DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default


            If Not pResultado.Estado Then

                XtraMessageBox.Show("ER" + pResultado.Texto, "AXC")
                Return
            Else
                XtraMessageBox.Show("Impresión enviada con éxito", "AXC")
            End If

            TxtLote.Text = ""
            TxtLote.Select()


        Catch ex As Exception
            XtraMessageBox.Show("Error: " + ex.Message, "AXC")
        End Try
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        Try
            If String.IsNullOrEmpty(CmbImpresora.Text) Then
                XtraMessageBox.Show("Seleccionar impresora", "Información", MessageBoxButtons.OK)
                CmbImpresora.Select()
                Return
            End If
            ImprimeEtiquetas()

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub
#End Region
End Class