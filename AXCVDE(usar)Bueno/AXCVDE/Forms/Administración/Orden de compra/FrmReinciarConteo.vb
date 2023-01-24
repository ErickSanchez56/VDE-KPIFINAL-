Imports DevExpress.XtraEditors

Public Class FrmReinciarConteo
#Region "Variables"
    Dim nuevo As New clsConsOC
    'Public pOrdenCompra As String = ""
#End Region

#Region "Eventos"
    Private Sub TxtBusqueda_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtBusqueda.KeyPress
        Try
            If e.KeyChar = Convert.ToChar(Keys.Enter) Then
                buscarHC()
            End If
        Catch ex As Exception
            XtraMessageBox.Show("Error: " + ex.Message, "AXC")
        End Try
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Try
            buscarHC()
        Catch ex As Exception
            XtraMessageBox.Show("Error: " + ex.Message, "AXC")
        End Try
    End Sub

    Private Sub btnCierreParcial_Click(sender As Object, e As EventArgs) Handles btnReinicioConteo.Click
        Try
            If DgvViewResultado.SelectedRowsCount <= 0 Then
                XtraMessageBox.Show("Debe seleccionar una partida para poder reiniciar su conteo", "AXC")
                Return
            End If
            Dim partida = DgvViewResultado.GetRowCellValue(DgvViewResultado.FocusedRowHandle, "Partida")
            Dim recibo = DgvViewResultado.GetRowCellValue(DgvViewResultado.FocusedRowHandle, "IdReciboCompra")
            Dim OC = DgvViewResultado.GetRowCellValue(DgvViewResultado.FocusedRowHandle, "OrdenCompra")
            'MsgBox(partida.ToString)

            If XtraMessageBox.Show("¿Está seguro que desea reiniciar el conteo de la hoja de conteo [" + TxtBusqueda.Text + "], Partida [" + partida + "]?", "AXC", MessageBoxButtons.YesNo) <> DialogResult.Yes Then
                Return
            End If

            ReiniciarConteo(partida, recibo, OC)

        Catch ex As Exception
            XtraMessageBox.Show("Error: " + ex.Message, "AXC")
        End Try
    End Sub
#End Region

#Region "Métodos"
    'Sub CargaGridOrdenes(ByVal ds As DataSet)
    '    Try
    '        DgvResultado.DataSource = ds.Tables(1)
    '    Catch ex As Exception
    '        XtraMessageBox.Show("Error: " + ex.Message, "AXC")
    '    End Try
    'End Sub
    Public Sub buscarHC()
        Try
            LimpiarGrids()
            Dim resultado = nuevo.ListarDetallesConsConteo(TxtBusqueda.Text, My.Settings("Estacion"), DatosTemporales.Usuario)
            If Not resultado.Estado Then
                XtraMessageBox.Show(resultado.Texto, "AXC")
                Return
            End If
            DgvResultado.DataSource = resultado.Tabla
            DgvViewResultado.BestFitColumns()
        Catch ex As Exception
            XtraMessageBox.Show("Error: " + ex.Message, "AXC")
        End Try

    End Sub


    Public Sub LimpiarGrids()
        Try
            DgvResultado.DataSource = Nothing
        Catch ex As Exception
            XtraMessageBox.Show("Error: " + ex.Message, "AXC")
        End Try
    End Sub

    Public Sub ReiniciarConteo(prmPartida$, prmRecibo$, prmOC$)
        Try
            Dim obj As New clsConsOC
            Dim resultado = obj.ReiniciaConteo(prmRecibo, prmOC, prmPartida, My.Settings("Estacion"), DatosTemporales.Usuario)
            If Not resultado.Estado Then
                XtraMessageBox.Show(resultado.Texto, "AXC")
                Return
            End If

            XtraMessageBox.Show("Conteo reiniciado con éxito", "AXC")
            buscarHC()
        Catch ex As Exception
            XtraMessageBox.Show("Error: " + ex.Message, "AXC")
        End Try
    End Sub
#End Region

End Class