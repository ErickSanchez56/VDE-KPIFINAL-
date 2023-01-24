Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Base

Public Class FrmEliminarDocRecepcion


#Region "VARIABLES"
    Dim nuevo As New ClsOrdenCompra
    Dim DocRecepcion As String
    Dim Pallet As String
#End Region

#Region "EVENTOS"
    Private Sub FrmEliminarDocRecepcion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            txtOrdenCompra.Properties.CharacterCasing = CharacterCasing.Upper
            txtOrdenCompra.Select()

        Catch ex As Exception
            XtraMessageBox.Show("Error: " + ex.Message, "AXC")
        End Try
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Try
            If String.IsNullOrEmpty(txtOrdenCompra.Text) Then
                XtraMessageBox.Show("Ingresar una Orden de Compra", "AXC")
                Return
            End If

            CargaGridOrdenCompra(nuevo.ListaDocRecepcion(txtOrdenCompra.Text, My.Settings("Estacion"), DatosTemporales.Usuario))

        Catch ex As Exception
            XtraMessageBox.Show("Error: " + ex.Message, "AXC")
        End Try
    End Sub

    Private Sub btnBorrarDoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim resultado As String
        Try
            If XtraMessageBox.Show("¿Eliminar documento de recepción?", "AXC", MessageBoxButtons.YesNo) <> DialogResult.Yes Then
                Return
            End If
            Dim view As ColumnView = CType(dgvListaOrdenRecibido.MainView, ColumnView)
            Dim selectedRowHandles As Integer() = view.GetSelectedRows()


            If selectedRowHandles.Count < 1 Then
                XtraMessageBox.Show("Seleccionar el documento de recepción a eliminar", "AXC")
                Return
            End If

            DocRecepcion = view.GetRowCellDisplayText(selectedRowHandles(0), view.Columns("IdReciboCompra"))

            'Dim i = dgvListaOrdenRecibido.CurrentCellAddress.Y
            'DocRecepcion = dgvListaOrdenRecibido.Item(0, i).Value.ToString()
            If String.IsNullOrEmpty(DocRecepcion) Then
                XtraMessageBox.Show("Seleccionar una Orden de Recepción", "AXC")
                Return
            End If

            resultado = nuevo.EliminaDocRecepcion(DocRecepcion, My.Settings("Estacion"), DatosTemporales.Usuario)

            If resultado = "" Then
                XtraMessageBox.Show("Documento de recepción eliminado con éxito", "AXC")
                CargaGridOrdenCompra(nuevo.ListaDocRecepcion(txtOrdenCompra.Text, My.Settings("Estacion"), DatosTemporales.Usuario))
                dgvListaOrdenRecibido.DataSource = Nothing
            Else
                XtraMessageBox.Show(resultado, "AXC")
                Return
            End If

        Catch ex As Exception
            XtraMessageBox.Show("Error: " + ex.Message, "AXC")
        End Try
    End Sub

    Private Sub btnEliminarPallet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarPallet.Click
        Dim cOrdenCompra As New ClsOrdenCompra
        Dim resultado As String
        Try


            If GridView2.RowCount < 1 Then
                XtraMessageBox.Show("No hay empaques en la lista", "AXC")
                Return
            End If

            Dim view As ColumnView = CType(dgvpalletsOrdenRecibo.MainView, ColumnView)
            Dim selectedRowHandles As Integer() = view.GetSelectedRows()



            If selectedRowHandles.Count < 1 Then
                XtraMessageBox.Show("Seleccionar un registro a eliminar", "AXC")
                Return
            End If

            'Dim i = dgvListaOrdenRecibido.CurrentCellAddress.Y
            'DocRecepcion = dgvListaOrdenRecibido.Item(0, i).Value.ToString()
            DocRecepcion = view.GetRowCellDisplayText(selectedRowHandles(0), view.Columns("IdRecibo"))

            If String.IsNullOrEmpty(DocRecepcion) Then
                XtraMessageBox.Show("Seleccionar una Orden de Recepción", "AXC")
                Return
            End If

            ' Dim ii = dgvpalletsOrdenRecibo.CurrentCellAddress.Y
            Pallet = view.GetRowCellDisplayText(selectedRowHandles(0), view.Columns("CodigoPallet"))

            If XtraMessageBox.Show("¿Eliminar el registro[" + Pallet + "] de la recepción?", "AXC", MessageBoxButtons.YesNo) <> DialogResult.Yes Then
                Return
            End If
            If String.IsNullOrEmpty(Pallet) Then
                XtraMessageBox.Show("Seleccionar una registro", "AXC")
                Return
            End If

            resultado = nuevo.EliminaPalletDocRecepcion(DocRecepcion, Pallet, My.Settings("Estacion"), DatosTemporales.Usuario)

            If resultado = "" Then
                XtraMessageBox.Show("registro eliminado con éxito", "AXC")
                CargaGridDetalle(nuevo.ListaPalletsRecepcion(DocRecepcion, -1, My.Settings("Estacion"), DatosTemporales.Usuario))
            Else
                XtraMessageBox.Show(resultado, "AXC")
                Return
            End If
        Catch ex As Exception
            XtraMessageBox.Show("Error: " + ex.Message, "AXC")
        End Try
    End Sub

    Private Sub dgvListaOrdenRecibido_Click(sender As Object, e As EventArgs) Handles dgvListaOrdenRecibido.Click
        Try
            Dim view As ColumnView = CType(dgvListaOrdenRecibido.MainView, ColumnView)
            Dim selectedRowHandles As Integer() = view.GetSelectedRows()
            Dim pSeleccion As String
            pSeleccion = view.GetRowCellDisplayText(selectedRowHandles(0), view.Columns("IdReciboCompra"))
            CargaGridDetalle(nuevo.ListaPalletsRecepcion(pSeleccion, -1, My.Settings("Estacion"), DatosTemporales.Usuario))
            GridView1.BestFitColumns()
        Catch ex As Exception
            XtraMessageBox.Show("Error: " + ex.Message, "AXC")
        End Try
    End Sub

    Private Sub btnCancelarRecepcion_Click(sender As Object, e As EventArgs) Handles btnCancelarRecepcion.Click

        Try
            Dim resultado As String

            If XtraMessageBox.Show("¿Deseas eliminar el documento de recepción de la orden de compra " + txtOrdenCompra.Text + "?", "AXC", MessageBoxButtons.YesNo) <> DialogResult.Yes Then
                Return
            End If
            If GridView1.RowCount < 1 Then
                XtraMessageBox.Show("No hay documentos de recepción", "AXC")
                Return
            End If

            Dim view As ColumnView = CType(dgvListaOrdenRecibido.MainView, ColumnView)
            Dim selectedRowHandles As Integer() = view.GetSelectedRows()

            If selectedRowHandles.Count < 1 Then
                XtraMessageBox.Show("Seleccionar el documento de recepción a eliminar", "AXC")
                Return
            End If

            DocRecepcion = view.GetRowCellDisplayText(selectedRowHandles(0), view.Columns("IdReciboCompra"))

            If String.IsNullOrEmpty(DocRecepcion) Then
                XtraMessageBox.Show("Seleccionar una Orden de Recepción", "AXC")
                Return
            End If

            resultado = nuevo.EliminaDocRecepcion(DocRecepcion, My.Settings("Estacion"), DatosTemporales.Usuario)

            If resultado = "" Then
                XtraMessageBox.Show("Documento de recepción eliminado con éxito", "AXC")
                CargaGridOrdenCompra(nuevo.ListaDocRecepcion(DocRecepcion, My.Settings("Estacion"), DatosTemporales.Usuario))
                dgvListaOrdenRecibido.DataSource = Nothing
            Else
                XtraMessageBox.Show(resultado, "AXC")
                Return
            End If

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub

#End Region

#Region "METODOS"
    Sub CargaGridOrdenCompra(ByVal ds As DataSet)
        Try
            If ds.Tables.Count = 1 Then
                XtraMessageBox.Show(ds.Tables(0).Rows(0)(1).ToString, "AXC")
                dgvpalletsOrdenRecibo.DataSource = Nothing
                Return
            End If
            dgvListaOrdenRecibido.DataSource = ds.Tables(1)
            GridView1.Columns("IdReciboCompra").Visible = True
            GridView1.Columns("Almacen").Visible = False
            GridView1.Columns("Usuario").Visible = False
            GridView1.Columns("OrdenCompra").Caption = "Orden de Compra"
            GridView1.Columns("FechaRecibe").Caption = "Fecha de Recepción"
            GridView1.Columns("Factura").Caption = "Factura"
            GridView1.Columns("Proveedor").Caption = "Proveedor"
            GridView1.Columns("NumParte").Caption = "Producto"
            GridView1.Columns("CantidadPendiente").Caption = "Cantidad Pendiente"
            GridView1.Columns("CantidadRecibida").Caption = "Cantidad Recibida"
            GridView1.Columns("Estatus").Caption = "Estatus"
            GridView1.BestFitColumns()
            'GridView1.Columns("FechaRecibe").OptionsColumn.MinimumWidth = 170
            'GridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            'GridView1..AllowUserToAddRows = False
            'GridView1.AllowUserToDeleteRows = False
            'GridView1.AllowUserToOrderColumns = False
            'GridView1.AllowUserToResizeColumns = False
            'GridView1.AllowUserToResizeRows = False
            'GridView1.RowHeadersVisible = False
            'GridView1.DefaultCellStyle.ForeColor = Color.Black
            'GridView1.DefaultCellStyle.Alignment = ContentAlignment.MiddleCenter
            'GridView1.p.SelectionMode = SelectionMode.One
            'GridView1.ReadOnly = True
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub

    Sub CargaGridDetalle(ByVal ds As DataSet)
        Try
            'Dim dg As DataGridView = dgvpalletsOrdenRecibo
            If ds.Tables.Count = 1 Then
                XtraMessageBox.Show(ds.Tables(0).Rows(0)(1).ToString, "AXC")
                dgvpalletsOrdenRecibo.DataSource = Nothing
                Return
            End If
            dgvpalletsOrdenRecibo.DataSource = ds.Tables(1)
            GridView2.Columns("IdRecibo").Visible = False
            'GridView2.Columns("Producto").Caption = "Producto"
            GridView2.Columns("LoteProveedor").Caption = "Lote Proveedor"
            GridView2.Columns("LoteAXC").Caption = "Lote AXC"
            GridView2.Columns("CantidadOriginal").Caption = "Cantidad Original"
            GridView2.Columns("CantidadActual").Caption = "Cantidad Actual"
            GridView2.Columns("DStatus").Caption = "Estatus"
            GridView2.Columns("FechaCrea").Caption = "Fecha de Creación"
            GridView2.BestFitColumns()

            'dg.Columns("FechaCrea").MinimumWidth = 170
            'dg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
            'dg.AllowUserToAddRows = False
            'dg.AllowUserToDeleteRows = False
            'dg.AllowUserToOrderColumns = False
            'dg.AllowUserToResizeColumns = False
            'dg.AllowUserToResizeRows = False
            'dg.RowHeadersVisible = False
            'dg.DefaultCellStyle.ForeColor = Color.Black
            'dg.DefaultCellStyle.Alignment = ContentAlignment.MiddleCenter
            'dg.SelectionMode = SelectionMode.One
            'dg.ReadOnly = True
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub

    Private Sub txtOrdenCompra_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtOrdenCompra.KeyPress
        Try
            If e.KeyChar = Convert.ToChar(Keys.Enter) Then
                btnBuscar.PerformClick()
            End If
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub



#End Region

End Class