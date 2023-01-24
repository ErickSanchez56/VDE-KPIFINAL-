Imports System.Data.OleDb
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Base

Public Class FrmConsEmbarque


#Region "VARIABLES"
    Public pBuscaPedido As String
    Dim pPedido As New ClsPedidoGuia

#End Region


#Region "EVENTOS"
    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        Try
            If String.IsNullOrEmpty(LblNumPedido.Text) Then

                If XtraMessageBox.Show("Generar un nuevo pedido?", "Confirmación", MessageBoxButtons.YesNo) <> DialogResult.Yes Then
                    Return
                End If

                GenerarNuevoPedido()


            Else

                If XtraMessageBox.Show("Los datos del pedido[" + LblNumPedido.Text + "] se guardarán con los últimos cambios. Deseas generar un nuevo pedido?", "Confirmación", MessageBoxButtons.YesNo) <> DialogResult.Yes Then
                    Return
                End If

                LimparCamposPedidoCons()
                LimpiarCamposOP()

            End If
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        Try
            If String.IsNullOrEmpty(TxtBusqueda.Text) Then
                XtraMessageBox.Show("Ingresar un documento", "Información", MessageBoxButtons.OK)
                LimpiarCamposOP()
                TxtBusqueda.Select()
            End If

            ActualizarDocumento(TxtBusqueda.Text)
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        Try
            If String.IsNullOrEmpty(LblNumPedido.Text) Then
                XtraMessageBox.Show("No se pueden agregar partidas sin antes haber generado un nuevo pedido", "Información", MessageBoxButtons.OK)
                Return
            End If

            If GridView1.RowCount <= 0 Then
                XtraMessageBox.Show("No hay detalle de documento. Buscar un documento válido.", "Información", MessageBoxButtons.OK)
                TxtBusqueda.Select()
                Return
            End If

            AgregarPartida()
            CargarOrdenDeVenta(LblPedidoVenta.Text, LblNumPedido.Text)
            ListaPartidasPedido(LblNumPedido.Text)
            ListatotalPedido(LblNumPedido.Text)
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Try
            If String.IsNullOrEmpty(LblNumPedido.Text) Then
                XtraMessageBox.Show("Es necesario generar un pedido antes de agregar buscar un documento de embarque", "Información", MessageBoxButtons.OK)
                Return
            End If

            If String.IsNullOrEmpty(TxtBusqueda.Text) Then
                XtraMessageBox.Show("Ingresar un documento válido", "Información", MessageBoxButtons.OK)
                LimpiarCamposOP()
                TxtBusqueda.Select()
                Return
            End If

            CargarOrdenDeVenta(TxtBusqueda.Text, LblNumPedido.Text)

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnElimina_Click(sender As Object, e As EventArgs) Handles BtnElimina.Click
        Try
            If String.IsNullOrEmpty(LblNumPedido.Text) Then
                XtraMessageBox.Show("No se pueden eliminar partidas sin antes haber generado un nuevo pedido", "Información", MessageBoxButtons.OK)
                Return
            End If

            If DgvViewPreviaPedidos.RowCount <= 0 Then
                XtraMessageBox.Show("No hay partidas en este pedido. Agregar partidas de órdenes de embarque ", "Información", MessageBoxButtons.OK)
                TxtBusqueda.Select()
                Return
            End If

            EliminarPartida(LblNumPedido.Text)
            CargarOrdenDeVenta(LblPedidoVenta.Text, LblNumPedido.Text)
            ListaPartidasPedido(LblNumPedido.Text)
            ListatotalPedido(LblNumPedido.Text)
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub
#End Region

#Region "METODOS"

    Private Sub ActualizarDocumento(prmDocumento As String)
        Try
            Dim pResultado As New CResultado
            Dim Cls As New clsConsEM

            Cursor.Current = Cursors.WaitCursor
            pResultado = Cls.ActualizaOrden(prmDocumento, My.Settings.Estacion, DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                Return
            End If

            XtraMessageBox.Show("Documento actualizado exitosamente")

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub GenerarNuevoPedido()
        Try
            Dim pResultado As New CResultado
            Dim Cls As New clsConsEM

            Cursor.Current = Cursors.WaitCursor
            pResultado = Cls.GeneraPedido(My.Settings.Estacion, DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                Return
            End If

            LblNumPedido.Text = pResultado.Texto

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub CargarOrdenDeVenta(prmOrden As String, prmPedido As String)
        Try
            dgvResultados.DataSource = Nothing

            Dim pResultado As New CResultado
            Dim Cls As New clsConsEM

            Cursor.Current = Cursors.WaitCursor
            pResultado = Cls.CargarDetalleOP(prmOrden, prmPedido, My.Settings.Estacion, DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                dgvResultados.DataSource = Nothing
                Return
            End If
            Dim dt As New DataTable
            Dim ds As New DataSet

            dt = pResultado.Tabla
            ds = pResultado.Resultado

            If ds.Tables(1).Rows.Count < 1 Then
                XtraMessageBox.Show("No hay información del documento ingresado")
                dgvResultados.DataSource = Nothing
                Return
            End If

            dgvResultados.DataSource = ds.Tables(1).Copy

            LblPedidoVenta.Text = ds.Tables(1).Rows(0)(0).ToString


        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub AgregarPartida()
        Try
            Dim pResultado As New CResultado
            Dim Cls As New clsConsEM

            Dim pPartida As Integer

            Dim view As ColumnView = CType(dgvResultados.MainView, ColumnView)
            Dim selectedRowHandles As Integer() = view.GetSelectedRows()

            pPartida = view.GetRowCellDisplayText(selectedRowHandles(0), view.Columns("Partida"))

            Cursor.Current = Cursors.WaitCursor
            pResultado = Cls.AgregarPartida(LblPedidoVenta.Text, pPartida, LblNumPedido.Text, My.Settings.Estacion, DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                Return
            End If


        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub EliminarPartida(ByVal prmPedido As String)
        Try
            Dim pResultado As New CResultado
            Dim Cls As New clsConsEM

            Dim pPartida As Integer
            Dim pOrden As String = ""

            Dim view As ColumnView = CType(DgvPreviaPartidas.MainView, ColumnView)
            Dim selectedRowHandles As Integer() = view.GetSelectedRows()

            pPartida = view.GetRowCellDisplayText(selectedRowHandles(0), view.Columns("Partida"))
            pOrden = view.GetRowCellDisplayText(selectedRowHandles(0), view.Columns("OrdenEmbarque"))

            Cursor.Current = Cursors.WaitCursor
            pResultado = Cls.EliminarPartida(pOrden, pPartida, prmPedido, My.Settings.Estacion, DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                Return
            End If


        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub LimpiarCamposOP()
        LblPedidoVenta.Text = ""
        dgvResultados.DataSource = Nothing
    End Sub

    Public Sub LimparCamposPedidoCons()
        DgvPreviaPartidas.DataSource = Nothing
        LblNumPedido.Text = ""
        DgvTotalPedido.DataSource = Nothing

    End Sub

    Private Sub ListaPartidasPedido(prmBusqueda As String)
        Try
            DgvPreviaPartidas.DataSource = Nothing

            Dim pResultado As New CResultado
            Dim Cls As New clsConsEM

            Cursor.Current = Cursors.WaitCursor
            pResultado = Cls.ListarPrevioPedido(prmBusqueda, My.Settings.Estacion, DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                DgvPreviaPartidas.DataSource = Nothing
                Return
            End If
            Dim dt As New DataTable
            Dim ds As New DataSet

            dt = pResultado.Tabla
            ds.Tables.Add(dt)

            If dt.Rows.Count < 1 Then
                XtraMessageBox.Show("No hay partidas agregadas al pedido")
                DgvPreviaPartidas.DataSource = Nothing
                Return
            End If

            DgvPreviaPartidas.DataSource = dt

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ListatotalPedido(prmBusqueda As String)
        Try
            DgvTotalPedido.DataSource = Nothing

            Dim pResultado As New CResultado
            Dim Cls As New clsConsEM

            Cursor.Current = Cursors.WaitCursor
            pResultado = Cls.ListarTotalPedido(prmBusqueda, My.Settings.Estacion, DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                DgvTotalPedido.DataSource = Nothing
                Return
            End If
            Dim dt As New DataTable
            Dim ds As New DataSet

            dt = pResultado.Tabla
            ds.Tables.Add(dt)

            If dt.Rows.Count < 1 Then
                XtraMessageBox.Show("No hay total te pedido")
                DgvTotalPedido.DataSource = Nothing
                Return
            End If

            DgvTotalPedido.DataSource = dt

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub CancelarPedido(ByVal prmPedido As String)
        Try
            Dim pResultado As New CResultado
            Dim Cls As New clsConsEM

            Cursor.Current = Cursors.WaitCursor
            pResultado = Cls.CancelaPedido(prmPedido, My.Settings.Estacion, DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                Return
            End If

            XtraMessageBox.Show("Pedido cancelado exitosamente")
            LimparCamposPedidoCons()


        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub LiberarPedido(ByVal prmPedido As String)
        Try
            Dim pResultado As New CResultado
            Dim Cls As New clsConsEM

            Cursor.Current = Cursors.WaitCursor
            pResultado = Cls.LiberarPedido(prmPedido, My.Settings.Estacion, DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                Return
            End If

            XtraMessageBox.Show("Pedido liberado exitosamente")


            ListaPartidasPedido(LblNumPedido.Text)
            ListatotalPedido(LblNumPedido.Text)

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Try
            If String.IsNullOrEmpty(LblNumPedido.Text) Then
                XtraMessageBox.Show("Seleccionar un pedido", "Información", MessageBoxButtons.OK)
                Return
            End If

            If XtraMessageBox.Show("Cnacelar el pedido [" + LblNumPedido.Text + "] ?", "Confirmación", MessageBoxButtons.YesNo) <> DialogResult.Yes Then
                Return
            End If

            CancelarPedido(LblNumPedido.Text)


        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub

    Private Sub BtnLiberar_Click(sender As Object, e As EventArgs) Handles BtnLiberar.Click
        Try
            If String.IsNullOrEmpty(LblNumPedido.Text) Then
                XtraMessageBox.Show("No hya pedido seleccionado para liberar", "Información", MessageBoxButtons.OK)
                Return
            End If

            If XtraMessageBox.Show("Deseas liberar el pedido [ " + LblNumPedido.Text + " ]? ", "Confirmación", MessageBoxButtons.YesNo) <> DialogResult.Yes Then
                Return
            End If



            LiberarPedido(LblNumPedido.Text)

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub

    Private Sub BtnBuscarPedido_Click(sender As Object, e As EventArgs) Handles BtnBuscarPedido.Click
        Try


            FrmConsultaEmbarque.f = Me

            FrmConsultaEmbarque.ShowDialog()


            If String.IsNullOrEmpty(pBuscaPedido) Then
                Return
            End If


            ' BuscarPedido(pBuscaPedido)

            LblNumPedido.Text = pBuscaPedido
            ListaPartidasPedido(pBuscaPedido)
            ListaConsolidados(pBuscaPedido)
            ListatotalPedido(pBuscaPedido)

            pBuscaPedido = ""


        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub FrmConsEmbarque_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose(True)
    End Sub

    Private Sub FrmConsEmbarque_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub






    Private Sub ListaConsolidados(prmBusqueda As String)
        Try


            Dim pResultado As New CResultado
            Dim Cls As New clsConsEM

            Cursor.Current = Cursors.WaitCursor
            pResultado = Cls.ListaConsolidados(prmBusqueda, My.Settings.Estacion, DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                Return
            End If
            Dim dt As New DataTable
            Dim ds As New DataSet

            dt = pResultado.Tabla
            ds.Tables.Add(dt)



        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles BtnCancelaEmbarque.Click
        Try

            If String.IsNullOrEmpty(LblNumPedido.Text) Then
                XtraMessageBox.Show("No hay pedido consolidado cargado", "Información", MessageBoxButtons.OK)
                LblNumPedido.Select()
                Return
            End If

            If String.IsNullOrEmpty(CmbEmbarque.Text) Then
                XtraMessageBox.Show("No hay embarques consolidados al pedido [" + LblNumPedido.Text + "].", "Información", MessageBoxButtons.OK)
                CmbEmbarque.Select()
                Return
            End If
            If XtraMessageBox.Show("¿Cancelar el embarque [ " + CmbEmbarque.Text + " en el pedido [" + LblNumPedido.Text + "]?", "Confirmación", MessageBoxButtons.YesNo) <> DialogResult.Yes Then
                Return
            End If

            CancelarEmbarque(LblNumPedido.Text, CmbEmbarque.Text)

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub CancelarEmbarque(ByVal prmPedido As String, ByVal prmEmbarque As String)
        Try
            Dim pResultado As New CResultado
            Dim Cls As New clsConsEM

            Cursor.Current = Cursors.WaitCursor
            pResultado = Cls.CancelarEmbarque(prmPedido, prmEmbarque, My.Settings.Estacion, DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                Return
            End If

            XtraMessageBox.Show("embarque [" + +"] Cancelado exitosamente")

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub SimpleButton2_Click_1(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Try

            If String.IsNullOrEmpty(LblNumPedido.Text) Then
                XtraMessageBox.Show("Seleccionar un pedido", "Información", MessageBoxButtons.OK)
                LblNumPedido.Select()
                Return
            End If

            AsignarGuias(LblNumPedido.Text)

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub AsignarGuias(prmBusqueda As String)
        Try

            Dim pResultado As New CResultado
            Dim Cls As New clsConsEM

            Cursor.Current = Cursors.WaitCursor
            pResultado = Cls.ValidarPedido(prmBusqueda, My.Settings.Estacion, DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                Return
            End If

            FrmAsignaGuiaPedido.pPedido = prmBusqueda

            FrmAsignaGuiaPedido.ShowDialog()




        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region
End Class