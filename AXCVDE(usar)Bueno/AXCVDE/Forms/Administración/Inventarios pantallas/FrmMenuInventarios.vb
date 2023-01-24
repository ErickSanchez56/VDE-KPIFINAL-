Public Class FrmMenuInventarios

#Region "VARIABLES"
    Dim nuevo As New ClsAlmacen
#End Region

#Region "METODOS"
    Sub CargaEjercicios()
        Try
            CargaGridEjercicios(nuevo.ListaEjerciciosInventario("@", My.Settings("Estacion"), DatosTemporales.Usuario))
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, " AXC")
        End Try
    End Sub

    Sub CargaGridEjercicios(ByVal ds As DataSet)
        Try
            If ds.Tables.Count = 1 Then
                Return
            End If
            dgvEjercicios.DataSource = ds.Tables(1)

        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, " AXC")
        End Try
    End Sub
#End Region

#Region "EVENTOS"
    Private Sub btnTotal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTotal.Click
        Try
            Dim EjercicioTotal As New FrmEjercicioInvTotal
            EjercicioTotal.ShowDialog()
            CargaEjercicios()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, " AXC")
        End Try
    End Sub

    Private Sub btnArticulo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnArticulo.Click
        'Try
        '    Dim EjercicioArticulo As New FrmEjercicioInvLote
        '    EjercicioArticulo.ShowDialog()
        '    CargaEjercicios()
        'Catch ex As Exceptions
        '    MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, " AXC")
        'End Try
    End Sub

    Private Sub btnPosicion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPosicion.Click
        Try
            Dim EjercicioPosicion As New FrmEjercicioInvPosicion
            EjercicioPosicion.ShowDialog()
            CargaEjercicios()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, " AXC")
        End Try
    End Sub

    Private Sub FrmMenuInventarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            CargaEjercicios()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, " AXC")
        End Try
    End Sub

    Private Sub btnProducto_Click(sender As Object, e As EventArgs) Handles btnProducto.Click
        FrmEjercicioInvArticulo.ShowDialog()
    End Sub
#End Region

End Class