Imports System.Data.OleDb
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Base
Imports Microsoft.Office.Interop
Imports ExcelDataReader
Imports System.IO
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraReports.UI



Public Class FrmLiberaOrdenCompraConsolidacion



#Region "VARIABLES"
    Public pBuscaOC As String
    'Dim pOC As New ClsPedidoGuia

    Dim prmPrevFactura As String
    Dim prmPrevFechaRecibo As String
    Dim prmPrevPedimento As String
    Dim prmPrevClavePedimento As String
    Dim prmPrevFechaPedimento As String
    Dim prmPrevContenedor As String
    Dim prmPrevComentarios As String
#End Region


#Region "EVENTOS"
    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        Try
            If String.IsNullOrEmpty(LblNumHC.Text) Then

                If XtraMessageBox.Show("Generar una nueva orden de compra?", "Confirmación", MessageBoxButtons.YesNo) <> DialogResult.Yes Then
                    Return
                End If

                GenerarNuevoConsolidado()


            Else

                If XtraMessageBox.Show("Los datos de la orden de compra[" + LblNumHC.Text + "] se guardarán con los últimos cambios. Deseas generar una nueva orden de compra?", "Confirmación", MessageBoxButtons.YesNo) <> DialogResult.Yes Then
                    Return
                End If

                LimparCamposOCCons()
                LimpiarCamposOC()

            End If
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        Try
            If String.IsNullOrEmpty(TxtBusqueda.Text) Then
                XtraMessageBox.Show("Ingresar un documento", "Información", MessageBoxButtons.OK)
                LimpiarCamposOC()
                TxtBusqueda.Select()
            End If

            ActualizarDocumento(TxtBusqueda.Text)
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs)
        Try
            If String.IsNullOrEmpty(LblNumHC.Text) Then
                XtraMessageBox.Show("No se pueden agregar partidas sin antes haber generado una nueva orden de compra", "Información", MessageBoxButtons.OK)
                Return
            End If

            If GridView1.RowCount <= 0 Then
                XtraMessageBox.Show("No hay detalle de documento. Buscar un documento válido.", "Información", MessageBoxButtons.OK)
                TxtBusqueda.Select()
                Return
            End If

            'Dim datosExtra = CargarDatosExtraOrdenCompraBotonAgregar(TxtBusqueda.Text)
            'If datosExtra Then
            '    XtraMessageBox.Show("Es necesario capturar todos los datos de facturas y pedimentos", "AXC")
            '    Return
            'End If

            AgregarPartidas()
            'CargarOrdenDeCompra(LblPedidoVenta.Text, LblNumOC.Text)
            ListaPartidasHC(LblNumHC.Text)
            'ListatotalPedido(LblNumOC.Text)
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Try
            TabPane1.SelectedPageIndex = 0
            If String.IsNullOrEmpty(LblNumHC.Text) Then
                XtraMessageBox.Show("Es necesario generar una orden de compra antes de agregar buscar un documento de compra", "Información", MessageBoxButtons.OK)
                Return
            End If

            If String.IsNullOrEmpty(TxtBusqueda.Text) Then
                XtraMessageBox.Show("Ingresar un documento válido", "Información", MessageBoxButtons.OK)
                LimpiarCamposOC()
                TxtBusqueda.Select()
                Return
            End If

            Dim nuevo As New ClsOrdenCompra
            dgvResultados.DataSource = Nothing
            CargaOrdenCompra(nuevo.ConsultaOrdenCompraCons(TxtBusqueda.Text))
            'CargarOrdenDeCompra(TxtBusqueda.Text, LblNumOC.Text)
            'CargarDatosExtraOrdenCompra(TxtBusqueda.Text, LblNumOC.Text)
            CheckEdit1.Checked = False

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnElimina_Click(sender As Object, e As EventArgs)
        Try
            'If String.IsNullOrEmpty(LblNumOC.Text) Then
            '    XtraMessageBox.Show("No se pueden eliminar partidas sin antes haber generado una nueva hoja de conteo", "Información", MessageBoxButtons.OK)
            '    Return
            'End If

            'If DgvViewPreviaPartidas.RowCount <= 0 Then
            '    XtraMessageBox.Show("No hay partidas en esta hoja de conteo. Agregar partidas de órdenes de compra", "Información", MessageBoxButtons.OK)
            '    TxtBusqueda.Select()
            '    Return
            'End If

            'EliminarPartida(LblNumOC.Text)
            'CargarOrdenDeCompra(LblPedidoVenta.Text, LblNumOC.Text)
            'ListaPartidasHC(LblNumOC.Text)
            'ListatotalPedido(LblNumOC.Text)
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub

    Private Sub SimpleButton9_Click(sender As Object, e As EventArgs) Handles SimpleButton9.Click
        Try
            CargaDatosExtraPrevios()
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

    Private Sub GenerarNuevoConsolidado()
        Try
            Dim pResultado As New CResultado
            Dim Cls As New clsConsOC

            Cursor.Current = Cursors.WaitCursor
            pResultado = Cls.GenerarRecibo(My.Settings.Estacion, DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                Return
            End If

            LblNumHC.Text = pResultado.Texto

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub CargarOrdenDeCompra(prmOrden As String, prmPedido As String)
        Try
            dgvResultados.DataSource = Nothing

            Dim pResultado As New CResultado
            Dim Cls As New clsConsOC

            Cursor.Current = Cursors.WaitCursor
            pResultado = Cls.CargarDetalleOC(prmOrden, prmPedido, My.Settings.Estacion, DatosTemporales.Usuario)
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

            dgvResultados.DataSource = ds.Tables(1)

            LblOC2.Text = ds.Tables(1).Rows(0)(0).ToString


        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub AgregarPartidas()
        Try


            Dim view As ColumnView = CType(dgvResultados.MainView, ColumnView)
            view.SelectAll()
            Dim selectedRowHandles As Integer() = view.GetSelectedRows()



            For i As Integer = 0 To GridView1.DataRowCount - 1
                Dim cantidadARecibir = view.GetRowCellDisplayText(selectedRowHandles(i), view.Columns("CantidadARecibir")).ToString()
                If String.IsNullOrEmpty(cantidadARecibir) Or cantidadARecibir = "0" Then

                Else
                    Dim objCons = New clsConsOC
                    Dim resultado = objCons.AgregarPartidaConsolidado(LblOC2.Text, LblNumHC.Text, view.GetRowCellDisplayText(selectedRowHandles(i), view.Columns("Partida")).ToString(), cantidadARecibir, My.Settings.Estacion, DatosTemporales.Usuario)

                    If Not resultado.Estado Then
                        XtraMessageBox.Show(resultado.Texto, "AXC")
                        'Return
                    End If
                End If
                'MsgBox(view.GetRowCellDisplayText(selectedRowHandles(i), view.Columns("Partida")).ToString())




            Next

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    'Private Sub CargaOrdenCompra(ByVal ds As DataSet)
    '    Try
    '        If ds.Tables.Count = 1 Then
    '            DgvPreviaPartidas.DataSource = ""
    '            ' BorrarTextbox()
    '            XtraMessageBox.Show(ds.Tables(0).Rows(0)(1).ToString(), "AXC")
    '        Else
    '            DgvPreviaPartidas.DataSource = ds.Tables(1)
    '            GridView1.Columns("OrdenCompra").Caption = "Orden de compra"
    '            'Nombre de las columnas
    '            GridView1.Columns("OrdenCompra").Caption = "Orden de compra"
    '            GridView1.Columns("Partida").Caption = "Partidas"
    '            GridView1.Columns("NumParte").Caption = "Producto"
    '            GridView1.Columns("CantidadOrdenada").Caption = "Cantidad Ordenada"
    '            GridView1.Columns("CantidadARecibir").Caption = "Cantidad A Recibir"
    '            GridView1.Columns("DStatus").Caption = "Estatus"
    '            GridView1.Columns("CantidadRecibida").Caption = "Cantidad Recibida"
    '            GridView1.Columns("Descripcion").Caption = "Descripción"
    '            ''Tamaño minimo de columnas
    '            GridView1.Columns(2).MinWidth = 100
    '            ''Desactiva las columnas innesesarias

    '            GridView1.Columns("OrdenCompra").Visible = False
    '            GridView1.Columns("Partida").OptionsColumn.ReadOnly = True
    '            GridView1.Columns("NumParte").OptionsColumn.ReadOnly = True
    '            GridView1.Columns("Descripcion").OptionsColumn.ReadOnly = True
    '            GridView1.Columns("CantidadOrdenada").OptionsColumn.ReadOnly = True
    '            GridView1.Columns("CantidadRecibida").OptionsColumn.ReadOnly = True
    '            GridView1.Columns("CantidadARecibir").OptionsColumn.ReadOnly = False
    '            GridView1.Columns("CantidadCancelada").Visible = False
    '            GridView1.Columns("Revision").Visible = False
    '            GridView1.Columns("DStatus").OptionsColumn.ReadOnly = True
    '            GridView1.Columns("IdStatus").Visible = False
    '            GridView1.Columns("Tag1").Visible = False
    '            GridView1.Columns("Tag2").Visible = False
    '            GridView1.Columns("Tag3").Visible = False
    '            GridView1.Columns("FechaCrea").Visible = False
    '            GridView1.Columns("UnidadMedida").Visible = False
    '            GridView1.Columns("NomProveedor").Visible = False



    '            ' dgvResultado.Columns("IdProveedor").Visible = False
    '            GridView1.Columns("Lotes").Visible = False
    '            GridView1.Columns("CodigoExterno").Visible = False

    '            GridView1.Columns("Direccion1").Visible = False



    '        End If
    '    Catch ex As Exception
    '        XtraMessageBox.Show("Error: " + ex.Message, "AXC")
    '    End Try
    'End Sub
    Private Sub EliminarPartida(ByVal prmPedido As String)
        Try
            'Dim pResultado As New CResultado
            'Dim Cls As New clsConsEM

            'Dim pPartida As Integer
            'Dim pOrden As String = ""

            'Dim view As ColumnView = CType(DgvPreviaPartidas.MainView, ColumnView)
            'Dim selectedRowHandles As Integer() = view.GetSelectedRows()

            'pPartida = view.GetRowCellDisplayText(selectedRowHandles(0), view.Columns("Partida"))
            'pOrden = view.GetRowCellDisplayText(selectedRowHandles(0), view.Columns("OrdenEmbarque"))

            'Cursor.Current = Cursors.WaitCursor
            'pResultado = Cls.EliminarPartida(pOrden, pPartida, prmPedido, My.Settings.Estacion, DatosTemporales.Usuario)
            'Cursor.Current = Cursors.Default

            'If Not pResultado.Estado Then
            '    XtraMessageBox.Show(pResultado.Texto)
            '    Return
            'End If


        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub LimpiarCamposOC()
        dgvResultados.DataSource = Nothing
        LblOC2.ResetText()
        txtFactura.ResetText()
        dtFechaPedimento.ResetText()
        dtpFechaRecibe.ResetText()
        txtPedimento.ResetText()
        txtClavePedimento.ResetText()
        txtReferencia.ResetText()
        txtContenedor.ResetText()
    End Sub

    Public Sub LimparCamposOCCons()

        LblNumHC.Text = ""
        DgvViewTotalOC.Columns.Clear()
        DgvTotalOC.DataSource = Nothing
        GridControl1.DataSource = Nothing

    End Sub

    Private Sub ListaPartidasHC(prmBusqueda As String)
        Try
            GridControl1.DataSource = Nothing

            Dim pResultado As New CResultado
            Dim Cls As New clsConsOC

            Cursor.Current = Cursors.WaitCursor
            pResultado = Cls.OrdenesCompraAsociadasCons(prmBusqueda, My.Settings.Estacion, DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                GridControl1.DataSource = Nothing
                Return
            End If
            Dim dt As New DataTable
            Dim ds As New DataSet

            dt = pResultado.Tablas.Tables(0)
            ds.Tables.Add(dt)

            If dt.Rows.Count < 1 Then
                XtraMessageBox.Show("No hay partidas agregadas al recibo")
                GridControl1.DataSource = Nothing
                Return
            End If

            GridControl1.DataSource = dt

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ListatotalPedido(prmBusqueda As String)
        Try
            DgvViewTotalOC.Columns.Clear()
            DgvTotalOC.DataSource = Nothing

            Dim pResultado As New CResultado
            Dim Cls As New clsConsOC

            Cursor.Current = Cursors.WaitCursor
            pResultado = Cls.ListarTotalHC(prmBusqueda, My.Settings.Estacion, DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                DgvViewTotalOC.Columns.Clear()
                DgvTotalOC.DataSource = Nothing
                Return
            End If
            Dim dt As New DataTable
            Dim ds As New DataSet

            dt = pResultado.Tabla
            ds.Tables.Add(dt)

            If dt.Rows.Count < 1 Then
                XtraMessageBox.Show("No hay total te pedido")
                DgvViewTotalOC.Columns.Clear()
                DgvTotalOC.DataSource = Nothing
                Return
            End If
            DgvTotalOC.DataSource = Nothing
            DgvViewTotalOC.Columns.Clear()

            DgvTotalOC.DataSource = dt
            dsReporte = New DataSet
            dsReporte.Tables.Add(ds.Tables(0).Copy())
            DgvViewTotalOC.BestFitColumns()
            DgvViewTotalOC.Columns("OrdenCompra").Visible = False

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub CancelarCompra(ByVal prmHC As String)
        Try
            Dim pResultado As New CResultado
            Dim Cls As New clsConsOC

            Cursor.Current = Cursors.WaitCursor
            pResultado = Cls.CancelaCompra(prmHC, My.Settings.Estacion, DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                Return
            End If

            XtraMessageBox.Show("Hoja de conteo cancelada exitosamente")
            LimparCamposOCCons()
            Dim dt As New DataTable
            dgvResultados.DataSource = Nothing
            LimpiarCamposOC()
            GridControl1.DataSource = Nothing
            GridControl2.DataSource = Nothing
            DgvTotalOC.DataSource = Nothing
            LblNumHC.Text = ""
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub LiberarRecepcion(ByVal prmPedido As String)
        Try
            Dim pResultado As New CResultado
            Dim Cls As New clsConsEM


            Dim ds As New DataSet
            Dim dt As New DataTable

            Cursor.Current = Cursors.WaitCursor
            pResultado = Cls.LiberarPedido(dt.DataSet.GetXml(), My.Settings.Estacion, DatosTemporales.Usuario)
            ''pResultado = Cls.LiberarPedido(prmPedido, My.Settings.Estacion, DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                Return
            End If

            XtraMessageBox.Show("Pedido liberado exitosamente")


            ListaPartidasHC(LblNumHC.Text)
            ListatotalPedido(LblNumHC.Text)

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ConsultaDatosReferenciaOC(prmOrden As String)
        Try
            dgvResultados.DataSource = Nothing

            Dim pResultado As New CResultado
            Dim Cls As New clsConsOC

            Cursor.Current = Cursors.WaitCursor
            'pResultado = Cls.ConsultaDatosReferenciaOC(prmOrden, My.Settings.Estacion, DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                dgvResultados.DataSource = Nothing
                Return
            End If
            Dim dt As New DataTable
            Dim ds As New DataSet

            'dt = pResultado.Tabla
            'ds = pResultado.Resultado

            'If ds.Tables(1).Rows.Count < 1 Then
            '    XtraMessageBox.Show("No hay información del documento ingresado")
            '    dgvResultados.DataSource = Nothing
            '    Return
            'End If

            'dgvResultados.DataSource = ds.Tables(1).Copy

            'LblPedidoVenta.Text = ds.Tables(1).Rows(0)(0).ToString


        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Try
            If String.IsNullOrEmpty(LblNumHC.Text) Then
                XtraMessageBox.Show("Seleccionar una hoja de conteo", "Información", MessageBoxButtons.OK)
                Return
            End If

            If XtraMessageBox.Show("Cancelar la hoja de conteo [" + LblNumHC.Text + "] ?", "Confirmación", MessageBoxButtons.YesNo) <> DialogResult.Yes Then
                Return
            End If

            CancelarCompra(LblNumHC.Text)


        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub

    Private Sub BtnLiberar_Click(sender As Object, e As EventArgs) Handles BtnLiberar.Click
        Dim cOrdenCompra As ClsOrdenCompra = New ClsOrdenCompra
        Dim resultado As CResultado
        Try

            'Dim sFactura As String = ""
            'Dim sClaveRecepcion As String = ""
            'Dim iCantidadARecibir As Integer = 0
            'Dim iDiferencia As Integer = 0
            'Dim iCant As Integer = 0
            'Dim iError As Integer = 0
            'For i As Integer = 0 To DgvViewTotalOC.RowCount - 1
            '    Dim sCantidadOrdenada As Integer = DgvViewTotalOC.GetRowCellValue(i, "CantidadOrdenada") ' Convert.ToString(GridView1.GetRowCellValue(i, "CantidadOrdenada"))
            '    Dim sCantidadARecibir As Integer = DgvViewTotalOC.GetRowCellValue(i, "CantidadARecibir") 'Convert.ToString(GridView1.GetRowCellValue(i, "CantidadARecibir"))

            '    If sCantidadARecibir <> 0 Then
            '        iCantidadARecibir = iCantidadARecibir + 1
            '    End If
            '    If sCantidadARecibir > sCantidadOrdenada Then
            '        iDiferencia = iDiferencia + 1
            '    End If

            '    iCant = iCant + 1
            'Next


            'If iCantidadARecibir = 0 Then
            '    XtraMessageBox.Show("Debes ingresar la cantidad a recibir", "AXC")
            '    Return
            'End If
            'If iDiferencia > 0 Then
            '    XtraMessageBox.Show("La cantidad a recibir supera la cantidad ordenada", "AXC")
            '    Return
            'End If
            'If iCantidadARecibir = iCant Then
            If XtraMessageBox.Show("¿Generar la hoja de conteo del material?", "AXC", MessageBoxButtons.YesNo) <> DialogResult.Yes Then
                Return
            End If
            'Else

            '    If XtraMessageBox.Show("Dejo algunos registros en cero" + Chr(13) + "¿Generar la recepcion del material?", "AXC", MessageBoxButtons.YesNo) <> DialogResult.Yes Then
            '        Return
            '    End If
            'End If

            'Dim fecha As New Date
            'fecha = Date.Parse(dtpFechaRecibe.EditValue.ToString)
            'Dim FechaPedimento As New Date
            'FechaPedimento = Date.Parse(dtFechaPedimento.EditValue.ToString)

            Dim ds As DataSet = New DataSet
            ds.Merge(DgvTotalOC.DataSource)


            'ds.Tables(0).TableName = "Entrada"

            'ds.DataSetName = "TablaEntrada"

            resultado = cOrdenCompra.LiberaOrdenCompra(LblNumHC.Text, "", "", Now.Today, "", "", "", Now.Today, ds.GetXml(), "", "", "", "", txtContenedor.Text, My.Settings("Estacion"), DatosTemporales.Usuario, 0, 1)


            Dim cOrden As clsConsEM = New clsConsEM





            If resultado.Estado Then
                XtraMessageBox.Show("Orden de Compra Liberada", "AXC")
                'BorrarTextbox()
                Dim dt As DataTable = New DataTable
                DgvTotalOC.DataSource = Nothing
                DgvViewTotalOC.Columns.Clear()
                DgvTotalOC.DataSource = dt
                dgvResultados.DataSource = dt
                LimpiarCamposOC()
                GridControl1.DataSource = dt
                GridControl2.DataSource = dt
                LblNumHC.Text = ""
            Else
                XtraMessageBox.Show("" + resultado.Texto.ToString(), "AXC")
            End If
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub

    Private Sub BtnBuscarPedido_Click(sender As Object, e As EventArgs) Handles BtnBuscarOC.Click
        Try


            FrmConsultaConsOC.f = Me

            FrmConsultaConsOC.ShowDialog()


            If String.IsNullOrEmpty(pBuscaOC) Then
                Return
            End If


            ' BuscarPedido(pBuscaPedido)

            LblNumHC.Text = pBuscaOC
            'ListaPartidasHC(pBuscaOC)
            'ListaConsolidados(pBuscaOC)
            ListatotalPedido(pBuscaOC)
            CargaOrdenesDeCompraAsociadasAHojaConteo()
            listaNumSerie()
            pBuscaOC = ""
            TabPane1.SelectedPageIndex = 1

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub FrmConsEmbarque_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose(True)
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

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs)
        Try

            'If String.IsNullOrEmpty(LblNumOC.Text) Then
            '    XtraMessageBox.Show("No hay pedido consolidado cargado", "Información", MessageBoxButtons.OK)
            '    LblNumOC.Select()
            '    Return
            'End If

            'If String.IsNullOrEmpty(CmbEmbarque.Text) Then
            '    XtraMessageBox.Show("No hay ordenes de compra consolidadas al recibo de compra [" + LblNumOC.Text + "].", "Información", MessageBoxButtons.OK)
            '    CmbEmbarque.Select()
            '    Return
            'End If
            'If XtraMessageBox.Show("¿Cancelar la orden de compra [ " + CmbEmbarque.Text + " en el pedido [" + LblNumOC.Text + "]?", "Confirmación", MessageBoxButtons.YesNo) <> DialogResult.Yes Then
            '    Return
            'End If

            'CancelarOC(LblNumOC.Text, CmbEmbarque.Text)

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub CancelarOC(ByVal prmPedido As String, ByVal prmEmbarque As String)
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

            XtraMessageBox.Show("Orden de compra [" + +"] Cancelado exitosamente")

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub SimpleButton2_Click_1(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Try

            If String.IsNullOrEmpty(LblNumHC.Text) Then
                XtraMessageBox.Show("Seleccionar una orden de compra", "Información", MessageBoxButtons.OK)
                LblNumHC.Select()
                Return
            End If


        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub SimpleButton2_Click_2(sender As Object, e As EventArgs)
        Try
            If String.IsNullOrEmpty(LblNumHC.Text) Then
                XtraMessageBox.Show("Debe estar creado un documento para poder agregarle partidas", "AXC")
                Return
            End If

            If XtraMessageBox.Show("Deseas agregar las cantidades?", "Confirmación", MessageBoxButtons.YesNo) <> DialogResult.Yes Then
                Return
            End If


        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub SimpleButton2_Click_3(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Dim cOrdenCompra As ClsOrdenCompra = New ClsOrdenCompra
        Dim resultado As CResultado
        Try
            If LblOC2.Text.Trim = "" Then
                XtraMessageBox.Show("No ha seleccionado ninguna orden de compra")
                Return
            End If

            'Dim obj As New clsConsOC
            'resultado = obj.AgregarDatosExtra(LblPedidoVenta2.Text, txtFactura.Text, fecha, txtPedimento.Text, txtClavePedimento.Text, FechaPedimento, txtReferencia.Text, My.Settings.Estacion, DatosTemporales.Usuario)
            'If Not resultado.Estado Then
            '    XtraMessageBox.Show(resultado.Texto, "AXC")
            '    Return
            'End If

            If String.IsNullOrEmpty(LblNumHC.Text) Then
                XtraMessageBox.Show("No se pueden agregar partidas sin antes haber generado una nueva orden de compra", "Información", MessageBoxButtons.OK)
                Return
            End If

            If GridView1.RowCount <= 0 Then
                XtraMessageBox.Show("No hay detalle de documento. Buscar un documento válido.", "Información", MessageBoxButtons.OK)
                TxtBusqueda.Select()
                Return
            End If

            If txtFactura.Text.Trim = "" Then
                XtraMessageBox.Show("Ingrese la factura", "AXC")
                txtFactura.Select()
                Return
            End If
            If dtpFechaRecibe.Text.Trim = "" Then
                XtraMessageBox.Show("Ingrese una fecha de recibo", "Información", MessageBoxButtons.OK)
                dtpFechaRecibe.Select()
                Return
            End If


            If rbImportadas.Checked Then
                If txtPedimento.Text.Trim = "" Then
                    XtraMessageBox.Show("Ingrese el pedimento", "Información", MessageBoxButtons.OK)
                    dtpFechaRecibe.Select()
                    Return
                End If
                If txtClavePedimento.Text.Trim = "" Then
                    XtraMessageBox.Show("Ingrese una clave de pedimento", "Información", MessageBoxButtons.OK)
                    dtpFechaRecibe.Select()
                    Return
                End If
                If dtFechaPedimento.Text.Trim = "" Then
                    XtraMessageBox.Show("Ingrese una fecha de pedimento", "Información", MessageBoxButtons.OK)
                    dtpFechaRecibe.Select()
                    Return
                End If
            Else
                If txtCabecera.Text.Trim = "" Then
                    XtraMessageBox.Show("Ingrese el texto de cabecera", "AXC")
                    txtContenedor.Select()
                    Return
                End If

                If TxtNota.Text.Trim = "" Then
                    XtraMessageBox.Show("Ingrese la nota de entrega", "AXC")
                    txtReferencia.Select()
                    Return
                End If
            End If


            If txtContenedor.Text.Trim = "" Then
                XtraMessageBox.Show("Ingrese un contenedor", "AXC")
                txtContenedor.Select()
                Return
            End If

            If txtReferencia.Text.Trim = "" Then
                XtraMessageBox.Show("Ingrese un comentario", "AXC")
                txtReferencia.Select()
                Return
            End If

            'Dim datosExtra = CargarDatosExtraOrdenCompraBotonAgregar(LblPedidoVenta2.Text)
            'If Not datosExtra Then
            '    XtraMessageBox.Show("Es necesario capturar todos los datos de facturas y pedimentos", "AXC")
            '    Return
            'End If

            Dim sFactura As String = ""
            Dim sClaveRecepcion As String = ""
            Dim iCantidadARecibir As Integer = 0
            Dim iDiferencia As Integer = 0
            Dim iCant As Integer = 0
            Dim iError As Integer = 0
            For i As Integer = 0 To GridView1.RowCount - 1
                Dim sCantidadOrdenada As Integer = GridView1.GetRowCellValue(i, "CantidadOrdenada") ' Convert.ToString(GridView1.GetRowCellValue(i, "CantidadOrdenada"))
                Dim sCantidadARecibir As Integer = GridView1.GetRowCellValue(i, "CantidadARecibir") 'Convert.ToString(GridView1.GetRowCellValue(i, "CantidadARecibir"))

                If sCantidadARecibir <> 0 Then
                    iCantidadARecibir = iCantidadARecibir + 1
                End If
                If sCantidadARecibir > sCantidadOrdenada Then
                    iDiferencia = iDiferencia + 1
                End If

                iCant = iCant + 1
            Next


            If iCantidadARecibir = 0 Then
                XtraMessageBox.Show("Debes ingresar la cantidad a recibir", "AXC")
                Return
            End If
            If iDiferencia > 0 Then
                XtraMessageBox.Show("La cantidad a recibir supera la cantidad ordenada", "AXC")
                Return
            End If

            If String.IsNullOrEmpty(LblNumHC.Text) Then
                XtraMessageBox.Show("Favor de ingresar la orden de compra", "AXC")
                Exit Sub
            End If
            If txtFactura.Text.Trim = "" Then
                XtraMessageBox.Show("Ingrese la factura", "AXC")
                Return
            End If
            If txtReferencia.Text.Trim = "" Then
                XtraMessageBox.Show("Ingrese la referencia", "AXC")
                Return
            End If
            If iCantidadARecibir = iCant Then
                If XtraMessageBox.Show("¿Generar la hoja de conteo del material?", "AXC", MessageBoxButtons.YesNo) <> DialogResult.Yes Then
                    Return
                End If
            Else

                If XtraMessageBox.Show("Dejo algunos registros en cero" + Chr(13) + "¿Generar la hoja de conteo del material?", "AXC", MessageBoxButtons.YesNo) <> DialogResult.Yes Then
                    Return
                End If
            End If

            Dim fecha As New Date
            fecha = Date.Parse(dtpFechaRecibe.EditValue.ToString)


            Dim ds As DataSet = New DataSet
            ds.Merge(dgvResultados.DataSource)
            If rbImportadas.Checked Then
                Dim FechaPedimento As New Date
                FechaPedimento = Date.Parse(dtFechaPedimento.EditValue.ToString)
                resultado = cOrdenCompra.LiberaOrdenCompraPrev(LblOC2.Text, txtFactura.Text, txtReferencia.Text, fecha, txtClavePedimento.Text, "", txtPedimento.Text, FechaPedimento, ds.GetXml(), "", "", "", "", txtContenedor.Text, My.Settings("Estacion"), DatosTemporales.Usuario, 0, 1, LblNumHC.Text)
            Else
                'ds.Tables(0).Columns.Item("NumParte").ColumnName = "Producto"
                resultado = cOrdenCompra.LiberaOrdenCompraPrev(LblOC2.Text, txtFactura.Text, txtReferencia.Text, fecha, "", "", "", DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"), ds.GetXml(), "", txtCabecera.Text, TxtNota.Text, "", txtContenedor.Text, My.Settings("Estacion"), DatosTemporales.Usuario, 0, 1, LblNumHC.Text)
            End If

            If resultado.Estado Then
                XtraMessageBox.Show("Partidas agregadas a orden de conteo con éxito", "AXC")
                'BorrarTextbox()
                Dim dt As DataTable = New DataTable
                dgvResultados.DataSource = dt
            Else
                XtraMessageBox.Show("" + resultado.Texto.ToString(), "AXC")
            End If

            'If XtraMessageBox.Show("Deseas liberar el pedido [ " + LblNumOC.Text + " ]? ", "Confirmación", MessageBoxButtons.YesNo) <> DialogResult.Yes Then
            '    Return
            'End If

            'AgregarPartidas()
            prmPrevClavePedimento = txtClavePedimento.Text
            prmPrevComentarios = txtReferencia.Text
            prmPrevContenedor = txtContenedor.Text
            prmPrevFactura = txtFactura.Text
            prmPrevFechaPedimento = dtFechaPedimento.Text
            prmPrevFechaRecibo = dtpFechaRecibe.Text
            prmPrevPedimento = txtPedimento.Text

            ListatotalPedido(LblNumHC.Text)
            CargaOrdenesDeCompraAsociadasAHojaConteo()


        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub


    Public Sub CargaOrdenesDeCompraAsociadasAHojaConteo()
        Try
            Dim pResultado As New CResultado
            Dim Cls As New clsConsOC

            Cursor.Current = Cursors.WaitCursor
            pResultado = Cls.OrdenesCompraAsociadasCons(LblNumHC.Text, My.Settings.Estacion, DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                Return
            End If
            GridControl1.DataSource = pResultado.Tabla


        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub CargaOrdenCompra(ByVal ds As DataSet)
        Try
            If ds.Tables.Count = 1 Then
                'dgvResultados.DataSource = ""
                ' BorrarTextbox()
                XtraMessageBox.Show(ds.Tables(0).Rows(0)(1).ToString(), "AXC")
            Else
                If ds.Tables(1).Rows.Count <= 0 Then
                    XtraMessageBox.Show("No se encuentran las partidas de la orden de compra o ya fueron completadas")
                    Return
                End If

                dgvResultados.DataSource = ds.Tables(1)
                GridView1.Columns("OrdenCompra").Caption = "Orden de compra"
                'Nombre de las columnas
                GridView1.Columns("OrdenCompra").Caption = "Orden de compra"
                GridView1.Columns("Partida").Caption = "Partidas"
                GridView1.Columns("NumParte").Caption = "Producto"
                GridView1.Columns("CantidadOrdenada").Caption = "Cantidad Ordenada"
                GridView1.Columns("CantidadARecibir").Caption = "Cantidad A Recibir"
                GridView1.Columns("DStatus").Caption = "Estatus"
                GridView1.Columns("CantidadRecibida").Caption = "Cantidad Recibida"
                GridView1.Columns("Descripcion").Caption = "Descripción"
                ''Tamaño minimo de columnas
                GridView1.Columns(2).MinWidth = 100
                ''Desactiva las columnas innesesarias

                GridView1.Columns("OrdenCompra").Visible = False
                GridView1.Columns("Partida").OptionsColumn.ReadOnly = True
                GridView1.Columns("NumParte").OptionsColumn.ReadOnly = True
                GridView1.Columns("Descripcion").OptionsColumn.ReadOnly = True
                GridView1.Columns("CantidadOrdenada").OptionsColumn.ReadOnly = True
                GridView1.Columns("CantidadRecibida").OptionsColumn.ReadOnly = True
                GridView1.Columns("CantidadARecibir").OptionsColumn.ReadOnly = False
                GridView1.Columns("CantidadCancelada").Visible = False
                GridView1.Columns("Revision").Visible = False
                GridView1.Columns("DStatus").OptionsColumn.ReadOnly = True
                GridView1.Columns("IdStatus").Visible = False
                GridView1.Columns("Tag1").Visible = False
                GridView1.Columns("Tag2").Visible = False
                GridView1.Columns("Tag3").Visible = False
                GridView1.Columns("FechaCrea").Visible = False
                GridView1.Columns("UnidadMedida").Visible = False
                GridView1.Columns("NomProveedor").Visible = False



                ' dgvResultado.Columns("IdProveedor").Visible = False
                GridView1.Columns("Lotes").Visible = False
                GridView1.Columns("CodigoExterno").Visible = False

                GridView1.Columns("Direccion1").Visible = False

                'Centra el texto de las celdas
                'GridView1.sty .RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                'Rellena todo el grid con las columnas
                'GridView1 .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                'Quita permisos al usuario
                GridView1.BestFitColumns()
                LblOC2.Text = ds.Tables(1).Rows(0)("OrdenCompra").ToString()
                'CargaTextBox(ds)

            End If
        Catch ex As Exception
            XtraMessageBox.Show("Error: " + ex.Message, "AXC")
        End Try
    End Sub

    Private Sub CargaOrdenCompraModificar(ByVal ds As DataSet)
        Try
            If ds.Tables.Count = 1 Then
                'dgvResultados.DataSource = ""
                ' BorrarTextbox()
                XtraMessageBox.Show(ds.Tables(0).Rows(0)(1).ToString(), "AXC")
                Return
            Else
                'If ds.Tables.Item(1).Rows.Count <= 0 Then
                '    XtraMessageBox.Show("Las partidas de esta orden de compra ya han sido recibidas", "AXC")
                '    Return
                'End If
                DgvTotalOC.DataSource = Nothing
                DgvViewTotalOC.Columns.Clear()
                DgvTotalOC.DataSource = ds.Tables(1)
                DgvViewTotalOC.Columns("OrdenCompra").Caption = "Orden de compra"
                'Nombre de las columnas
                DgvViewTotalOC.Columns("OrdenCompra").Caption = "Orden de compra"
                DgvViewTotalOC.Columns("Partida").Caption = "Partidas"
                DgvViewTotalOC.Columns("NumParte").Caption = "Producto"
                DgvViewTotalOC.Columns("CantidadOrdenada").Caption = "Cantidad Ordenada"
                'DgvViewTotalOC.Columns("CantidadARecibir").Caption = "Cantidad A Recibir"
                DgvViewTotalOC.Columns("DStatus").Caption = "Estatus"
                DgvViewTotalOC.Columns("CantidadRecibida").Caption = "Cantidad Recibida"
                DgvViewTotalOC.Columns("Descripcion").Caption = "Descripción"
                ''Tamaño minimo de columnas
                DgvViewTotalOC.Columns(2).MinWidth = 100
                ''Desactiva las columnas innesesarias

                DgvViewTotalOC.Columns("OrdenCompra").Visible = False
                DgvViewTotalOC.Columns("Partida").OptionsColumn.ReadOnly = True
                DgvViewTotalOC.Columns("NumParte").OptionsColumn.ReadOnly = True
                DgvViewTotalOC.Columns("Descripcion").OptionsColumn.ReadOnly = True
                DgvViewTotalOC.Columns("CantidadOrdenada").OptionsColumn.ReadOnly = True
                DgvViewTotalOC.Columns("CantidadRecibida").OptionsColumn.ReadOnly = True
                'DgvViewTotalOC.Columns("CantidadARecibir").OptionsColumn.ReadOnly = False
                DgvViewTotalOC.Columns("CantidadCancelada").Visible = False
                DgvViewTotalOC.Columns("Revision").Visible = False
                DgvViewTotalOC.Columns("DStatus").OptionsColumn.ReadOnly = True
                DgvViewTotalOC.Columns("IdStatus").Visible = False
                DgvViewTotalOC.Columns("Tag1").Visible = False
                DgvViewTotalOC.Columns("Tag2").Visible = False
                DgvViewTotalOC.Columns("Tag3").Visible = False
                DgvViewTotalOC.Columns("FechaCrea").Visible = False
                DgvViewTotalOC.Columns("UnidadMedida").Visible = False
                DgvViewTotalOC.Columns("NomProveedor").Visible = False



                ' dgvResultado.Columns("IdProveedor").Visible = False
                DgvViewTotalOC.Columns("Lotes").Visible = False
                DgvViewTotalOC.Columns("CodigoExterno").Visible = False

                DgvViewTotalOC.Columns("Direccion1").Visible = False

                'Centra el texto de las celdas
                'GridView1.sty .RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                'Rellena todo el grid con las columnas
                'GridView1 .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                'Quita permisos al usuario
                DgvViewTotalOC.BestFitColumns()
                LblOC2.Text = ds.Tables(1).Rows(0)("OrdenCompra").ToString()
                'CargaTextBox(ds)
                SimpleButton7.Visible = True
                SimpleButton1.Visible = False
                BtnLiberar.Visible = False
                LabelControl3.Visible = True
                txtCantidadModificar.Visible = True
            End If
        Catch ex As Exception
            XtraMessageBox.Show("Error: " + ex.Message, "AXC")
        End Try
    End Sub


    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        'XtraMessageBox.Show("Opción deshabilitada", "AXC")
        Try
            If String.IsNullOrEmpty(LblNumHC.Text) Then
                XtraMessageBox.Show("No hay ninguna hoja de conteo creada/seleccionada", "AXC")
                Return
            End If
            Dim dt = TryCast(GridControl1.DataSource, DataTable)
            If dt.Rows.Count <= 0 Then
                XtraMessageBox.Show("No se encuentran ordenes de compra para buscar en la tabla de órdenes de compra asociadas", "AXC")
                Return
            End If

            DgvTotalOC.DataSource = Nothing
            If GridView2.SelectedRowsCount <= 0 Then
                XtraMessageBox.Show("Seleccione una orden de compra para modificar la hoja de conteo", "AXC")
                Return
            End If
            Dim nuevo As New ClsOrdenCompra
            dgvResultados.DataSource = Nothing
            Dim OCBuscar = GridView2.GetFocusedRowCellValue("OrdenCompra").ToString
            CargaOrdenCompraModificar(nuevo.ConsultaOrdenCompraGeneralPartidasAsociadasHC(OCBuscar, LblNumHC.Text))
            lblOCSeleccionada.Text = OCBuscar
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub

    Private Sub SimpleButton5_Click(sender As Object, e As EventArgs) Handles SimpleButton5.Click
        Cursor = Cursors.WaitCursor
        Try
            If String.IsNullOrEmpty(LblNumHC.Text) Then
                XtraMessageBox.Show("Debe seleccionar o crear una [hoja de conteo] para poder cargarle [números de serie]", "AXC")
                Cursor = Cursors.Default
                Return
            End If
            If XtraMessageBox.Show("Desea cargar un archivo para los números de serie?", "Confirmación", MessageBoxButtons.YesNo) <> DialogResult.Yes Then
                Cursor = Cursors.Default
                Return
            End If

            Using ofd As XtraOpenFileDialog = New XtraOpenFileDialog() With {.Filter = "Excel Woorkbook|*xlsx|EXCEL Files Workbook|*.xls"}
                If ofd.ShowDialog() = DialogResult.OK Then
                    If String.IsNullOrEmpty(ofd.FileName) Then
                        Exit Sub
                        Return
                    End If
                    Using stream = File.Open(ofd.FileName, FileMode.Open, FileAccess.Read)
                        Using reader As IExcelDataReader = ExcelReaderFactory.CreateReader(stream)
                            Dim result As DataSet = reader.AsDataSet(New ExcelDataSetConfiguration() With {
                                                                     .ConfigureDataTable = Function(__) New ExcelDataTableConfiguration() With {
                                                                     .UseHeaderRow = False}})
                            Dim tables = result.Tables
                            Dim dt As DataTable = tables.Item(0)
                            dt.Columns.Item(0).Caption = "Números de serie"
                            dt.Columns.Item(0).ColumnName = "NúmerosDeSerie"
                            GridControl2.DataSource = dt
                        End Using
                    End Using
                End If
                If String.IsNullOrEmpty(ofd.FileName) Then
                    Cursor = Cursors.Default
                    Exit Sub
                    Return
                End If
            End Using
            Dim ds As DataSet = New DataSet
            ds.Merge(GridControl2.DataSource)
            guardaNumSerie(ds.GetXml)

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
            Cursor = Cursors.Default
        End Try
        Cursor = Cursors.Default
    End Sub

    Private Sub guardaNumSerie(prmXML As String)
        Try
            Dim pResultado As New CResultado
            Dim Cls As New clsConsOC
            'Dim xmlformateado = prmXML.Replace("& vbCrLf &", "")
            Cursor.Current = Cursors.WaitCursor
            pResultado = Cls.GuardaNumerosSerie(LblNumHC.Text, prmXML, My.Settings.Estacion, DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                Return
            End If

            XtraMessageBox.Show("Números de serie guardados con éxito", "AXC")

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub eliminaNumSerie()
        Try
            Dim pResultado As New CResultado
            Dim Cls As New clsConsOC
            'Dim xmlformateado = prmXML.Replace("& vbCrLf &", "")
            Cursor.Current = Cursors.WaitCursor
            pResultado = Cls.EliminaNumerosSerie(LblNumHC.Text, My.Settings.Estacion, DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                Return
            End If

            XtraMessageBox.Show("Números de serie eliminados con éxito", "AXC")

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub listaNumSerie()
        Try
            Dim pResultado As New CResultado
            Dim Cls As New clsConsOC
            'Dim xmlformateado = prmXML.Replace("& vbCrLf &", "")
            Cursor.Current = Cursors.WaitCursor
            pResultado = Cls.ListarNumSerie(LblNumHC.Text, My.Settings.Estacion, DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                'XtraMessageBox.Show(pResultado.Texto)
                Return
            End If
            GridControl2.DataSource = pResultado.Tablas
            'XtraMessageBox.Show("Números de serie eliminados con éxito", "AXC")

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub SimpleButton6_Click(sender As Object, e As EventArgs) Handles SimpleButton6.Click
        Cursor = Cursors.WaitCursor
        Try
            If String.IsNullOrEmpty(LblNumHC.Text) Then
                XtraMessageBox.Show("Debe seleccionar o crear una [hoja de conteo] para poder cargarle [números de serie]", "AXC")
                Cursor = Cursors.Default
                Return
            End If
            If XtraMessageBox.Show("Desea eliminar los números de serie a la Hoja de conteo [" + LblNumHC.Text + "]?", "Confirmación", MessageBoxButtons.YesNo) <> DialogResult.Yes Then
                Cursor = Cursors.Default
                Return
            End If


            eliminaNumSerie()

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
            Cursor = Cursors.Default
        End Try
        Cursor = Cursors.Default
    End Sub

    Private Sub TxtBusqueda_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtBusqueda.KeyPress
        Try

            If e.KeyChar = Convert.ToChar(Keys.Enter) Then
                TabPane1.SelectedPageIndex = 0
                BtnBuscar.PerformClick()
            End If
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub

    Private Sub CheckEdit1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEdit1.CheckedChanged
        Try
            Dim dt As New DataTable
            dt = TryCast(dgvResultados.DataSource, DataTable)

            If dt Is Nothing Then
                XtraMessageBox.Show("No hay datos en la tabla de datos de orden de compra", "AXC")
                Return
            End If
            If dt.Rows.Count <= 0 Then
                XtraMessageBox.Show("No hay datos en la tabla de datos de orden de compra", "AXC")
                Return
            End If
            If CheckEdit1.Checked Then
                For Each Row As DataRow In dt.Rows
                    Row.Item("CantidadARecibir") = CInt(Row.Item("CantidadOrdenada").ToString) - CInt(Row.Item("CantidadRecibida").ToString)
                Next
            Else
                For Each Row As DataRow In dt.Rows
                    Row.Item("CantidadARecibir") = "0"
                Next
            End If
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try

    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        Try
            GridView2.FocusInvalidRow()
            DgvTotalOC.DataSource = Nothing
            DgvViewTotalOC.Columns.Clear()
            SimpleButton7.Visible = False
            BtnLiberar.Visible = True
            LabelControl3.Visible = False
            txtCantidadModificar.Visible = False
            SimpleButton1.Visible = True
            ListatotalPedido(LblNumHC.Text)
            lblOCSeleccionada.Text = "Ninguna"
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub

    Private Sub SimpleButton7_Click(sender As Object, e As EventArgs) Handles SimpleButton7.Click
        Try
            If DgvViewTotalOC.RowCount <= 0 Then
                XtraMessageBox.Show("No hay datos para eliminar", "AXC")
                Return
            End If

            If String.IsNullOrEmpty(txtCantidadModificar.Text) Then
                XtraMessageBox.Show("Ingrese una cantidad para modificar la partida", "AXC")
                Return
            End If
            Dim cantidad = DgvViewTotalOC.GetFocusedRowCellValue("CantidadEnEstaHojaConteo").ToString
            Dim HC = LblNumHC.Text
            Dim OC = GridView2.GetFocusedValue.ToString
            Dim partida = DgvViewTotalOC.GetFocusedRowCellValue("Partida").ToString

            If CInt(txtCantidadModificar.Text) < 0 Then
                XtraMessageBox.Show("Ingrese una cantidad válida ( >0 )", "AXC")
                Return
            ElseIf CInt(txtCantidadModificar.Text) = 0 Then 'si le pongo 0 es para eliminar toda la cantidad y la relacion
                If XtraMessageBox.Show("¿Seguro que desea eliminar la partida [" + partida + "], con cantidad de[" + cantidad + "] piezas de la hoja de conteo [" + HC + "]?", "Confirmación", MessageBoxButtons.YesNo) <> DialogResult.Yes Then
                    Return
                End If
            Else 'si le pongo + de 0 voy a modificar la cantidad 
                If XtraMessageBox.Show("¿Seguro que desea modificar la partida [" + partida + "], con cantidades de [" + cantidad + "] a [" + txtCantidadModificar.Text + "] piezas, de la hoja de conteo [" + HC + "]?", "Confirmación", MessageBoxButtons.YesNo) <> DialogResult.Yes Then
                    Return
                End If
            End If
            Dim obj = New ClsOrdenCompra
            Dim resultado = obj.ModificaPartidaHC(OC, HC, partida, txtCantidadModificar.Text, My.Settings.Estacion, DatosTemporales.Usuario)

            If Not resultado.Estado Then
                XtraMessageBox.Show(resultado.Texto, "AXC")
                Return
            End If

            XtraMessageBox.Show("Partida actualizada con éxito", "AXC")
            SimpleButton3.PerformClick()
            CargaOrdenesDeCompraAsociadasAHojaConteo()
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub

    Private Sub SimpleButton8_Click(sender As Object, e As EventArgs) Handles SimpleButton8.Click
        Cursor = Cursors.WaitCursor
        Try
            If String.IsNullOrEmpty(LblNumHC.Text) Then
                XtraMessageBox.Show("Debe crear o seleccionar una hoja de conteo", "AXC")
                Return
            End If
            If String.IsNullOrEmpty(LblOC2.Text) Then
                XtraMessageBox.Show("Debe cargar una orden de compra para cargar sus cantidades", "AXC")
                Return
            End If
            If GridView1.RowCount <= 0 Then
                XtraMessageBox.Show("No hay partidas de orden de compra para cargar sus cantidades", "AXC")
                Return
            End If

            If XtraMessageBox.Show("¿Deseas cargar las cantidades a recibir?, Se modificarán las cantidades acorde al excel", "Confirmación", MessageBoxButtons.YesNo) <> DialogResult.Yes Then
                Cursor = Cursors.Default
                Return
            End If



            Using ofd As XtraOpenFileDialog = New XtraOpenFileDialog() With {.Filter = "Excel Woorkbook|*xlsx|EXCEL Files Workbook|*.xls"}
                If ofd.ShowDialog() = DialogResult.OK Then
                    If String.IsNullOrEmpty(ofd.FileName) Then
                        Exit Sub
                        Return
                    End If
                    Using stream = File.Open(ofd.FileName, FileMode.Open, FileAccess.Read)
                        Using reader As IExcelDataReader = ExcelReaderFactory.CreateReader(stream)
                            Dim result As DataSet = reader.AsDataSet(New ExcelDataSetConfiguration() With {
                                                                         .ConfigureDataTable = Function(__) New ExcelDataTableConfiguration() With {
                                                                         .UseHeaderRow = False}})
                            Dim tables = result.Tables
                            Dim dt As DataTable = tables.Item(0)
                            dt.Columns.Item(0).Caption = "NumParte"
                            dt.Columns.Item(0).ColumnName = "NumParte"
                            dt.Columns.Item(1).Caption = "CantidadARecibir"
                            dt.Columns.Item(1).ColumnName = "CantidadARecibir"

                            Dim dtDGV As New DataTable()
                            dtDGV = TryCast(dgvResultados.DataSource, DataTable)

                            'LIMPIAR LAS CANTIDADES A RECIBIR PRIMERO
                            For Each row2 As DataRow In dtDGV.Rows
                                row2("CantidadARecibir") = 0
                            Next

                            For Each row As DataRow In dt.Rows

                                For Each row2 As DataRow In dtDGV.Rows
                                    If (row2("NumParte").ToString = row("NumParte").ToString Or row2("CódigoProveedor").ToString = row("NumParte").ToString) And CInt(row("CantidadARecibir").ToString) <> 0 Then
                                        If CInt(row2("CantidadPendiente").ToString) = CInt(row("CantidadARecibir").ToString) Then
                                            row2("CantidadARecibir") = CInt(row("CantidadARecibir").ToString)
                                            row("CantidadARecibir") = 0
                                        ElseIf CInt(row2("CantidadPendiente").ToString) > CInt(row("CantidadARecibir").ToString) Then
                                            row2("CantidadARecibir") = CInt(row("CantidadARecibir").ToString)
                                            row("CantidadARecibir") = 0
                                        Else
                                            row2("CantidadARecibir") = CInt(row2("CantidadPendiente").ToString)
                                            row("CantidadARecibir") = CInt(row("CantidadARecibir").ToString) - CInt(row2("CantidadARecibir").ToString)
                                        End If

                                        'Exit For
                                    End If
                                Next
                                'End If
                            Next

                        End Using
                    End Using
                End If
                If String.IsNullOrEmpty(ofd.FileName) Then
                    Cursor = Cursors.Default
                    Exit Sub
                    Return
                End If
            End Using

            XtraMessageBox.Show("Cantidades actualizadas desde excel con éxito", "AXC")

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
            Cursor = Cursors.Default
        End Try
        Cursor = Cursors.Default
    End Sub

    Private Sub CargaDatosExtraPrevios()
        Try
            If String.IsNullOrEmpty(prmPrevFactura) And
                    String.IsNullOrEmpty(prmPrevFechaRecibo) And
                    String.IsNullOrEmpty(prmPrevPedimento) And
                    String.IsNullOrEmpty(prmPrevClavePedimento) And
                    String.IsNullOrEmpty(prmPrevFechaPedimento) And
                    String.IsNullOrEmpty(prmPrevContenedor) And
                    String.IsNullOrEmpty(prmPrevComentarios) Then
                XtraMessageBox.Show("No se pudieron cargar datos ingresados previamente", "AXC")
                Return
            End If

            txtFactura.Text = prmPrevFactura
            dtpFechaRecibe.Text = prmPrevFechaRecibo
            txtPedimento.Text = prmPrevPedimento
            txtClavePedimento.Text = prmPrevClavePedimento
            dtFechaPedimento.Text = prmPrevFechaPedimento
            txtContenedor.Text = prmPrevContenedor
            txtReferencia.Text = prmPrevComentarios

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub

    Private Sub txtCantidadModificar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantidadModificar.KeyPress
        Try
            If e.KeyChar = Convert.ToChar(Keys.Enter) Then
                SimpleButton7.PerformClick()
            End If
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles rbImportadas.CheckedChanged
        Try
            MostrarImportadas()
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles rbNacionales.CheckedChanged
        Try
            MostrarNacionales()
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub

    Private Sub MostrarImportadas()
        Try
            LabelControl8.Visible = True
            LabelControl9.Visible = True
            LabelControl10.Visible = True
            txtPedimento.Visible = True
            txtClavePedimento.Visible = True
            dtFechaPedimento.Visible = True
            LabelControl14.Visible = False
            LabelControl13.Visible = False
            txtCabecera.Visible = False
            TxtNota.Visible = False
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub

    Private Sub MostrarNacionales()
        Try
            LabelControl14.Visible = True
            LabelControl13.Visible = True
            txtCabecera.Visible = True
            TxtNota.Visible = True
            LabelControl8.Visible = False
            LabelControl9.Visible = False
            LabelControl10.Visible = False
            txtPedimento.Visible = False
            txtClavePedimento.Visible = False
            dtFechaPedimento.Visible = False
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub

    Private Sub GroupControl3_Paint(sender As Object, e As PaintEventArgs) Handles GroupControl3.Paint

    End Sub

#Region "VARIABLES"
    Public dsReporte As New DataSet
#End Region
    Private Sub SimpleButton10_Click(sender As Object, e As EventArgs) Handles SimpleButton10.Click
        Try
            If XtraMessageBox.Show("¿Generar reporte?", "Confirmación", MessageBoxButtons.YesNo) <> DialogResult.Yes Then
                Return
            End If

            If DgvTotalOC.DataSource Is Nothing Then
                XtraMessageBox.Show("No hay información para generar el reporte", "AXC")
                Return
            End If


            If dsReporte.Tables Is Nothing Then

            End If


            Dim RepExistencias As New DevRepEntradaMercancia
            RepExistencias.CargaReporte(dsReporte, 1)
            Dim designTool As New ReportPrintTool(RepExistencias)
            designTool.ShowPreview()
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub

    Private Sub FrmLiberaOrdenCompraConsolidacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'SimpleButton10.Location = New Point(377, 15)
    End Sub


#End Region

End Class