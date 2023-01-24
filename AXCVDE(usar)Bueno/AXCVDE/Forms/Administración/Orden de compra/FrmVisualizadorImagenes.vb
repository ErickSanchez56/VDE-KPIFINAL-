Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Base
Imports System.IO
Imports System.Drawing.Imaging

Public Class FrmVisualizadorImagenes

    Private Sub cargarImagen(ByVal input As String)
        Try

            'Evidencia1.Image = Image.FromStream(client.OpenRead(url))
            '    Evidencia2.Image = Image.FromStream(client.OpenRead(url))
            '    Evidencia3.Image = Image.FromStream(client.OpenRead(url))

        Catch ex As Exception
            MsgBox("Error en el formato de la etiqueta")
        End Try
    End Sub
    Private Sub FrmVisualizadorImagenes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim pOrdenCompra As String
            Dim pStatus As String
            'If String.IsNullOrEmpty(TxtBusqueda.Text) Then
            '    pOrdenCompra = "@"
            '    pStatus = "@"
            'Else
            '    pOrdenCompra = TxtBusqueda.Text
            '    pStatus = "@"
            'End If
            Consultaimagen("@")
        Catch ex As Exception
            XtraMessageBox.Show("Error: " + ex.Message, "AXC")
        End Try
    End Sub

    Private Sub Consultaimagen(prmBusqueda As String)
        Try
            Evidencia1.Image = Nothing
            Evidencia2.Image = Nothing
            Evidencia3.Image = Nothing

            Dim pResultado As New CResultado
            Dim Cls As New clsConsOC

            Cursor.Current = Cursors.WaitCursor
            pResultado = Cls.Cargarevidencia("7000011830")
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                Evidencia1.Image = Nothing
                Evidencia2.Image = Nothing
                Evidencia3.Image = Nothing
                Return
            End If
            'Dim dt As New DataTable
            Dim ds As New DataSet

            ds = pResultado.Resultado
            'ds.Tables.Add(dt)

            If ds.Tables(0).Rows.Count < 1 Then
                XtraMessageBox.Show("No hay evidencias")
                Evidencia1.Image = Nothing
                Evidencia2.Image = Nothing
                Evidencia3.Image = Nothing
                Return
            End If

            '//AQUI EMPEZAREMOS A LLENAR LAS IMAGENES
            txtIdProveedor.Text = ds.Tables(0).Rows(0)("Proveedor").ToString
            txtContenedor.Text = ds.Tables(0).Rows(0)("Contenedor").ToString
            TXTPLACAS.Text = ds.Tables(0).Rows(0)("Placa").ToString
            txtnombre.Text = ds.Tables(0).Rows(0)("Nombre").ToString
            txtestacón.Text = ds.Tables(0).Rows(0)("Estación").ToString

            If ds.Tables(0).Rows(0)("Foto1").ToString = "" Then
                XtraMessageBox.Show("No hay evidencia")
            Else
                Evidencia1.Image = Base64ToImage(ds.Tables(0).Rows(0)("Foto1").ToString)
                TileItem1.Image = Base64ToImage(ds.Tables(0).Rows(0)("Foto1").ToString)
            End If
            If ds.Tables(0).Rows(0)("Foto2").ToString = "" Then
                XtraMessageBox.Show("No hay evidencia 2")
            Else
                Evidencia2.Image = Base64ToImage(ds.Tables(0).Rows(0)("Foto2").ToString)
                TileItem2.Image = Base64ToImage(ds.Tables(0).Rows(0)("Foto2").ToString)
            End If
            If ds.Tables(0).Rows(0)("Foto3").ToString = "" Then
                XtraMessageBox.Show("No hay evidencia 3")
            Else
                Evidencia3.Image = Base64ToImage(ds.Tables(0).Rows(0)("Foto3").ToString)
                TileItem3.Image = Base64ToImage(ds.Tables(0).Rows(0)("Foto3").ToString)
            End If
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try

    End Sub
    Public Function Base64ToImage(ByVal base64String As String) As Image
        Dim imageBytes As Byte() = Convert.FromBase64String(base64String)
        Using ms = New MemoryStream(imageBytes, 0, imageBytes.Length)
            Dim image As Image = Image.FromStream(ms, True)
            Return image
        End Using
    End Function
End Class