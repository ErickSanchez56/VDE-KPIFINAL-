Imports DevExpress.XtraEditors

Public Class FrmHojaConteoAfectación
#Region "VARIABLES"

#End Region

#Region "MÉTODOS"
    Private Sub ListaHojasConteo()
        Try
            Dim objCompraCons As New clsConsOC
            Dim resultado = objCompraCons.ListaConsolidados(IIf(String.IsNullOrEmpty(TxtBusqueda.Text), "@", TxtBusqueda.Text).ToString, My.Settings("Estacion"), DatosTemporales.Usuario)
            If Not resultado.Estado Then
                DgvResultado.DataSource = Nothing
                XtraMessageBox.Show(resultado.Texto, "AXC")
                Return
            End If

            DgvResultado.DataSource = resultado.Tabla
            DgvViewResultado.BestFitColumns()
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub

    Private Sub ListaHojasConteoDetalles()
        Try
            Dim objCompraCons As New clsConsOC
            Dim resultado = objCompraCons.ListarTotalHC(DgvViewResultado.GetFocusedRowCellValue("OrdenCompra").ToString, My.Settings("Estacion"), DatosTemporales.Usuario)
            If Not resultado.Estado Then
                GridControl1.DataSource = Nothing
                XtraMessageBox.Show(resultado.Texto, "AXC")
                Return
            End If
            If resultado.Tabla.Rows.Count <= 0 Then
                XtraMessageBox.Show("No se encontraron detalles de la hoja de conteo", "AXC")
                Return
            End If
            GridControl1.DataSource = resultado.Tabla
            GridView1.BestFitColumns()
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub

    Public Sub CargaOrdenesDeCompraAsociadasAHojaConteo()
        Try
            Dim pResultado As New CResultado
            Dim Cls As New clsConsOC

            Cursor.Current = Cursors.WaitCursor
            pResultado = Cls.OrdenesCompraAsociadasCons(DgvViewResultado.GetFocusedRowCellValue("OrdenCompra").ToString, My.Settings.Estacion, DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                GridControl2.DataSource = Nothing
                XtraMessageBox.Show(pResultado.Texto)
                Return
            End If
            GridControl2.DataSource = pResultado.Tabla
            GridView2.BestFitColumns()
            GridView2.FocusInvalidRow()
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

#End Region

#Region "EVENTOS"
    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Try
            ListaHojasConteo()
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub

    Private Sub TxtBusqueda_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtBusqueda.KeyPress
        Try
            If e.KeyChar = Convert.ToChar(Keys.Enter) Then
                ListaHojasConteo()
            End If
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub

    Private Sub DgvViewResultado_Click(sender As Object, e As EventArgs) Handles DgvViewResultado.Click
        Try
            If DgvViewResultado.SelectedRowsCount < 0 Then
                ''XtraMessageBox.Show("No se selecc", "AXC")
                Return
            End If
            ListaHojasConteoDetalles()
            CargaOrdenesDeCompraAsociadasAHojaConteo()
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub
#End Region
End Class