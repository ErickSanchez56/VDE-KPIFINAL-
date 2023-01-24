Imports DevExpress.XtraEditors

Public Class FrmVisorImagen
#Region "VARIABLES "
    Public pImagen As New System.IO.MemoryStream
#End Region

    Private Sub FrmVisroImagen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            CargarImagen()
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

#Region "METODOS"
    Sub CargarImagen()
        Try
            If pImagen Is Nothing Then
                PbImagen.Image = My.Resources.s_img
            Else
                PbImagen.Image = Image.FromStream(pImagen)
            End If
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region
End Class