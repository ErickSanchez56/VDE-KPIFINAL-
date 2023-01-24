Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Base

Public Class FrmTraspasoSalidaPT


#Region "VARIABLES"
    Dim dtGridPartidas As DataTable
    Public Traspaso As String
    Public pBuscar As Boolean
    Public pClaveTraspaso As String
    Public pOrdenTras As String
    Public pOrdenT As String
    Public pEstacion As String
    Public pNumParteDet As String
    Private TipoLib As New List(Of Tipo)()
    Private ESTOTAL As Integer
    Private CantidadASurtir As Double
    Private CantidadPedida As Double
    Private TipoDeSurtido As Integer
    Public Class Tipo
        Public Property TipoLiberacion() As String
        Public Property TipoLibID() As Integer
    End Class
#End Region

#Region "EVENTOS"
    Private Sub FrmTraspasoSalidaPT_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ListaEstaciones("")

        Dim nuevo As New clsTransfer
        If pOrdenT = "" Then

        Else
            CargaTransf(nuevo.ConsultaTransf(pOrdenT))
        End If

        Try
            crearDatatable()
            'ListarPlantas()
            'ListaNumParte()
            'txtTraspasoSalida.Text = ""
            'cancelar()

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub



    Private Sub btnGuardar_Click(sender As System.Object, e As System.EventArgs) Handles btnGuardar.Click
        Try
            If XtraMessageBox.Show("¿Liberar Traspaso?", "AXC", MessageBoxButtons.YesNo) <> DialogResult.Yes Then
                Return
            End If


            For Fila As Integer = 0 To GridView1.RowCount - 1
                If GridView1.GetRowCellValue(Fila, "CantidadSolicitada") <> 0 Then
                    LiberarTras()
                    Exit For
                Else
                    XtraMessageBox.Show("La orden NO se puede Liberar en 0")
                    Return
                End If
            Next





            grdPartidasTraspaso.DataSource = Nothing
            grdPartidasTraspaso.Refresh()
            'txtGuia.Text = ""
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnBuscar_Click(sender As System.Object, e As System.EventArgs)
        FrmBuscaTransferPT.ShowDialog()
        If pBuscar Then
            'buscar()
        End If

    End Sub

    'Private Sub btnEditar_Click(sender As System.Object, e As System.EventArgs)
    '    Try
    '        GridView1.Columns("Producto").OptionsColumn.ReadOnly = True
    '        GridView1.Columns("Cantidad").OptionsColumn.ReadOnly = True
    '        GridView1.Columns("Surtida").OptionsColumn.ReadOnly = True
    '        btnEliminarLinea.Enabled = True
    '        Activar()
    '    Catch ex As Exception
    '        XtraMessageBox.Show(ex.Message, "AXC", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try

    'End Sub

    'Private Sub txtCantidad_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs)
    '    If Char.IsDigit(e.KeyChar) Then
    '        e.Handled = False
    '    ElseIf Char.IsControl(e.KeyChar) Then
    '        e.Handled = False
    '    Else
    '        e.Handled = True
    '    End If
    'End Sub

    Private Sub FrmTraspasoSalidaPT_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose(True)
    End Sub

    Private Sub cbNumParte_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.KeyChar = UCase(e.KeyChar)
    End Sub

    'Private Sub cmbNumParte_SelectedIndexChanged(sender As Object, e As EventArgs)
    '    Try
    '        Dim text As String = cmbNumParte.Text
    '        If text.Equals("System.Data.DataRowView") Then
    '            Return
    '        End If
    '        ConsultaNumParte()
    '        txtCantidad.Text = ""
    '    Catch ex As Exception
    '        XtraMessageBox.Show(ex.Message, "AXC", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub

#End Region

#Region "METODOS"


    'Private Sub cargarLotes(ByVal prmNumParte As String)
    '    Try

    '        Dim pResultado As New CResultado
    '        Dim pArticulo As New clsNumParte

    '        Cursor.Current = Cursors.WaitCursor
    '        pResultado = pArticulo.ListaLoteXNumParte(prmNumParte, My.Settings.Estacion, DatosTemporales.Usuario)
    '        Cursor.Current = Cursors.Default

    '        If Not pResultado.Estado Then
    '            XtraMessageBox.Show(pResultado.Texto, "AXC")
    '            Return
    '        End If

    '        Dim dt As DataTable = New DataTable
    '        dt = pResultado.Tabla



    '        CmbLote.Properties.DataSource = dt
    '        CmbLote.Properties.ValueMember = "LoteAXC"
    '        CmbLote.Properties.DisplayMember = "LoteAXC"


    '    Catch ex As Exception
    '        Cursor.Current = Cursors.Default
    '        XtraMessageBox.Show(ex.Message, "AXC", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub

    Public Sub LlenaVariables(ByVal prmTransfer As String, ByVal prmBanderaBusca As Boolean)
        Traspaso = prmTransfer
        txtTraspasoSalida.Text = Traspaso
        pBuscar = prmBanderaBusca
    End Sub

    'Private Sub ListarPlantas()
    '    Try
    '        Dim pResultado As New CResultado
    '        Dim pAlmacen As New ClsPlanta

    '        Cursor.Current = Cursors.WaitCursor
    '        pResultado = pAlmacen.ListaPlantas("@", My.Settings.Estacion)
    '        Cursor.Current = Cursors.Default

    '        If Not pResultado.Estado Then
    '            XtraMessageBox.Show(pResultado.Texto, "AXC")
    '            Return
    '        End If

    '        Dim dtOrigen As DataTable = New DataTable
    '        dtOrigen = pResultado.Tabla.Copy

    '        Dim dtDestino As DataTable = New DataTable
    '        dtDestino = pResultado.Tabla.Copy



    '        cmbAlmacenOrigen.Properties.DataSource = dtOrigen
    '        cmbAlmacenOrigen.Properties.ValueMember = "ERPPlanta"
    '        cmbAlmacenOrigen.Properties.DisplayMember = "ERPPlanta"

    '        cmbAlmacenDestino.Properties.DataSource = dtDestino
    '        cmbAlmacenDestino.Properties.ValueMember = "ERPPlanta"
    '        cmbAlmacenDestino.Properties.DisplayMember = "ERPPlanta"

    '        Cursor.Current = Cursors.Default

    '    Catch ex As Exception
    '        Cursor.Current = Cursors.Default
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub

    'Private Sub ListaNumParte()
    '    Try
    '        Dim pResultado As New CResultado
    '        Dim pOC As New COrdenCompraR

    '        Cursor.Current = Cursors.WaitCursor
    '        pResultado = pOC.ListaNumParte()
    '        Cursor.Current = Cursors.Default

    '        If Not pResultado.Estado Then
    '            XtraMessageBox.Show(pResultado.Texto)
    '            Return
    '        End If

    '        Dim dt As DataTable = New DataTable
    '        dt = pResultado.Tabla

    '        cmbNumParte.Properties.ValueMember = "IdNumParte"
    '        cmbNumParte.Properties.DisplayMember = "NumParte"
    '        cmbNumParte.Properties.DataSource = dt
    '    Catch ex As Exception
    '        XtraMessageBox.Show(ex.Message, "AXC")
    '    End Try

    'End Sub

    'Private Sub ConsultaNumParte()
    '    Try
    '        Dim pResultado As New CResultado
    '        Dim pOP As New COrdenProd

    '        Cursor.Current = Cursors.WaitCursor
    '        pResultado = pOP.ConsultaNumParte(cmbNumParte.Text)
    '        Cursor.Current = Cursors.Default

    '        If Not pResultado.Estado Then
    '            XtraMessageBox.Show(pResultado.Texto, "AXC")

    '            Return
    '        End If

    '        Dim dt As DataTable = New DataTable
    '        dt = pResultado.Tabla

    '        txtDescripcion.Text = dt.Rows(0).Item("DNumParte1")
    '        ' lblExistencia.Text = dt.Rows(0).Item("Existencia")
    '    Catch ex As Exception
    '        XtraMessageBox.Show(ex.Message, "AXC")
    '    End Try
    'End Sub

    Private Sub crearDatatable()
        Try
            dtGridPartidas = New DataTable
            dtGridPartidas.Columns.Add("Producto")
            dtGridPartidas.Columns.Add("Descripcion")
            dtGridPartidas.Columns.Add("Cantidad")
            dtGridPartidas.Columns.Add("Lote")


            dtGridPartidas.Columns("Producto").ReadOnly = True
            dtGridPartidas.Columns("Descripcion").ReadOnly = True
            dtGridPartidas.Columns("Lote").ReadOnly = True
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub

    Private Sub crearEncabezado()

        Try
            Dim pCantidad As Integer = 0

            If GridView1.RowCount = 0 Then
                XtraMessageBox.Show("Debes agregar por lo menos una línea", "AXC")
                Return
            End If

            For i As Integer = 0 To GridView1.RowCount - 1
                If Not IsNumeric(GridView1.GetRowCellValue(i, "Cantidad")) Then
                    XtraMessageBox.Show("Una de las cantidades no es válida", "AXC")
                    Return
                End If

                If Integer.Parse(GridView1.GetRowCellValue(i, "Cantidad").ToString) <= 0 Then
                    XtraMessageBox.Show("La cantidad registrada debe ser mayor a 0", "AXC")
                    Return
                End If

                pCantidad = pCantidad + Integer.Parse(GridView1.GetRowCellValue(i, "Cantidad").ToString)

            Next


            If pCantidad <= 0 Then
                XtraMessageBox.Show("El total de la cantidad de las partidas no puede ser 0", "AXC")
                Return
            End If

            Dim pResultado As New CResultado
            Dim pTraspaso As New clsTransfer

            'Cursor.Current = Cursors.WaitCursor
            'pResultado = pTraspaso.CrearInterorgSalidaPT(txtTransfer.Text, txtReferencia.Text, dtpFechaComp.Value.ToString("yyyyMMdd"), dtpFechaRetorno.Value.ToString("yyyyMMdd"), cmbTurno.Text, My.Settings.Estacion, DatosTemporales.Usuario)
            'Cursor.Current = Cursors.Default

            Cursor.Current = Cursors.WaitCursor
            pResultado = pTraspaso.CrearInterorgSalidaPT(txtTraspasoSalida.Text, CmbTipoLib.Text, My.Settings.Estacion, DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                txtTraspasoSalida.Text = ""
                Return
            End If
            txtTraspasoSalida.Text = pResultado.Texto
            'crearDetalle(pResultado.Texto)

        Catch ex As Exception
            Cursor.Current = Cursors.Default
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try

    End Sub

    'Private Sub crearDetalle(prmIdTraspaso As String)
    '    Try
    '        Dim strArticulos As String = ""
    '        Dim strComa As String = ""
    '        For i As Integer = 0 To GridView1.RowCount - 1
    '            strArticulos = strArticulos + strComa + GridView1.GetRowCellValue(i, "Producto").ToString()
    '            strComa = ","
    '        Next

    '        strArticulos = strArticulos + strComa
    '        For i As Integer = 0 To GridView1.RowCount - 1
    '            If Not IsNumeric(GridView1.GetRowCellValue(i, "Cantidad").ToString) Then
    '                XtraMessageBox.Show("Una de las cantidades no es válida", "AXC")
    '                Return
    '            End If

    '            If Integer.Parse(GridView1.GetRowCellValue(i, "Cantidad").ToString) <= 0 Then
    '                XtraMessageBox.Show("La cantidad registrada debe ser mayor a 0", "AXC")
    '                Return
    '            End If

    '            If GridView1.GetRowCellValue(i, "Producto").ToString = "" Then
    '                XtraMessageBox.Show("Falta artículo en una de las Líneas", "AXC")
    '                Return
    '            End If

    '            Dim pResultado As New CResultado
    '            Dim pTraspaso As New clsTransfer

    '            Cursor.Current = Cursors.WaitCursor
    '            pResultado = pTraspaso.AgregarLineaInterorgSalidaPT(prmIdTraspaso, cmbAlmacenOrigen.Text, cmbAlmacenDestino.Text, strArticulos,
    '                                                                 GridView1.GetRowCellValue(i, "Producto").ToString, GridView1.GetRowCellValue(i, "Lote").ToString, "1", Decimal.Parse(GridView1.GetRowCellValue(i, "Cantidad").ToString),
    '                                                                My.Settings.Estacion, DatosTemporales.Usuario)
    '            Cursor.Current = Cursors.Default

    '            strArticulos = strArticulos
    '            If Not pResultado.Estado Then
    '                XtraMessageBox.Show(pResultado.Texto, "AXC")
    '                Return
    '            End If

    '        Next


    '        XtraMessageBox.Show("Transferencia [" + prmIdTraspaso + "] liberada correctamente", "AXC")

    '    Catch ex As Exception
    '        Cursor.Current = Cursors.Default
    '        XtraMessageBox.Show(ex.Message, "AXC")
    '    End Try
    'End Sub

    Private Sub LimpiarCampos()
        Try
            grdPartidasTraspaso.DataSource = Nothing
            'txtCantidad.Text = ""
            'txtTransfer.Text = ""
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub

    Private Sub nuevo()
        Try
            btnGuardar.Visible = True
            'cmbAlmacenOrigen.Enabled = True
            'cmbAlmacenDestino.Enabled = True
            'HABILITAR GRUPO DE TEXTS PARA AGREGAR ARTICULOS
            'cmbNumParte.Enabled = True
            'txtCantidad.Enabled = True
            'btnAgregarLinea.Enabled = True
            '-------------------------
            'HABILITAR GRUPO DE TEXTS PARA CREAR DOCS
            txtTraspasoSalida.Enabled = True


            'gpoLineas.Enabled = True
            'GroupBox1.Enabled = True
            'btnNuevo.Visible = False
            'btnCancelar.Visible = True
            'btnBuscar.Visible = False
            'grdPartidasTraspaso.DataSource = Nothing
            'txtReferencia.Enabled = True



        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub

    'Private Sub cancelar()
    '    Try
    '        btnGuardar.Visible = False
    '        cmbAlmacenOrigen.Enabled = False
    '        cmbAlmacenDestino.Enabled = False

    '        'DESHABILITAR GRUPO DE TEXTS PARA AGREGAR ARTICULOS
    '        cmbNumParte.Enabled = False
    '        txtCantidad.Enabled = False
    '        btnAgregarLinea.Enabled = False
    '        '-------------------------
    '        'DESHABILITAR GRUPO DE TEXTS PARA CREAR DOCS
    '        txtTraspasoSalida.Enabled = True
    '        cmbAlmacenOrigen.Enabled = False
    '        cmbAlmacenDestino.Enabled = False
    '        txtReferencia.Enabled = False

    '        ' gpoLineas.Enabled = False
    '        btnNuevo.Visible = True
    '        btnCancelar.Visible = False
    '        btnBuscar.Visible = True
    '        btnEliminarLinea.Enabled = False
    '        txtCantidad.Text = ""
    '        txtTraspasoSalida.Text = ""


    '        txtReferencia.Enabled = False
    '        txtReferencia.Text = ""

    '        grdPartidasTraspaso.DataSource = Nothing
    '        dtGridPartidas = New DataTable
    '        crearDatatable()
    '    Catch ex As Exception
    '        XtraMessageBox.Show(ex.Message, "AXC")
    '    End Try
    'End Sub

    'Sub buscar()
    '    Try
    '        If IsNothing(txtTransfer.Text) Then
    '            Return
    '        End If

    '        If txtTransfer.Text = "" Then
    '            Return
    '        End If

    '        '---
    '        Dim pResultado1 As New CResultado
    '        Dim pTransfer1 As New clsTransfer

    '        Cursor.Current = Cursors.WaitCursor
    '        pResultado1 = pTransfer1.BuscarTransferPT(txtTransfer.Text)
    '        Cursor.Current = Cursors.Default

    '        If Not pResultado1.Estado Then
    '            XtraMessageBox.Show(pResultado1.Texto, "AXC")
    '            Return
    '        End If

    '        Dim dt1 As DataTable = New DataTable

    '        dt1 = pResultado1.Tabla

    '        Dim row As DataRow = dt1.Rows(0)

    '        cmbAlmacenOrigen.ItemIndex = cmbAlmacenOrigen.Properties.GetDataSourceRowIndex("ERPPlanta", row("Origen").ToString)
    '        cmbAlmacenDestino.ItemIndex = cmbAlmacenDestino.Properties.GetDataSourceRowIndex("ERPPlanta", row("Destino").ToString)

    '        txtTraspasoSalida.Text = row("Documento")
    '        txtReferencia.Text = row("Referencia")


    '        '---
    '        Dim pResultado As New CResultado
    '        Dim pTransfer As New clsTransfer

    '        Cursor.Current = Cursors.WaitCursor
    '        pResultado = pTransfer.BuscarTransferDetPT(txtTransfer.Text)
    '        Cursor.Current = Cursors.Default

    '        If Not pResultado.Estado Then
    '            XtraMessageBox.Show(pResultado.Texto, "AXC")
    '            grdPartidasTraspaso.DataSource = Nothing
    '            Return
    '        End If

    '        Dim dt As DataTable = New DataTable

    '        dt = pResultado.Tabla

    '        grdPartidasTraspaso.DataSource = dt

    '        GridView1.Columns("Producto").OptionsColumn.ReadOnly = True
    '        GridView1.Columns("Cantidad").OptionsColumn.ReadOnly = True
    '        GridView1.Columns("Surtida").OptionsColumn.ReadOnly = True
    '        btnEditar.Visible = True

    '        'HABILITAR GRUPO DE TEXTS PARA CREAR DOCS
    '        txtTraspasoSalida.Enabled = True
    '        cmbAlmacenOrigen.Enabled = True
    '        cmbAlmacenDestino.Enabled = True
    '        txtReferencia.Enabled = True
    '        Activar()


    '    Catch ex As Exception
    '        XtraMessageBox.Show(ex.Message, "AXC")
    '    End Try

    'End Sub

    'Private Sub Activar()
    '    Try
    '        btnGuardar.Visible = True
    '        cmbAlmacenOrigen.Enabled = True
    '        cmbAlmacenDestino.Enabled = True
    '        cmbNumParte.Enabled = True
    '        txtCantidad.Enabled = True
    '        btnAgregarLinea.Enabled = True

    '        'gpoLineas.Enabled = True
    '        btnNuevo.Visible = False
    '        btnEditar.Visible = False
    '        btnCancelar.Visible = True
    '        btnBuscar.Visible = False
    '        btnEliminarLinea.Enabled = True

    '    Catch ex As Exception
    '        XtraMessageBox.Show(ex.Message, "AXC")
    '    End Try
    'End Sub

    Private Sub btnBuscaFolio_Click(sender As Object, e As EventArgs) Handles btnBuscaFolio.Click
        If String.IsNullOrEmpty(txtTraspasoSalida.Text) Then
            XtraMessageBox.Show("Ingresar un documento válido", "Información", MessageBoxButtons.OK)
            LimpiarCamposOC()
            txtTraspasoSalida.Select()
            Return
        End If

        Dim nuevo As New clsTransfer
        grdPartidasTraspaso.DataSource = Nothing
        CargaTransf(nuevo.ConsultaTransf(txtTraspasoSalida.Text))
        EstableceEstacion()
    End Sub
#End Region

#Region "METODOS"

    Private Sub ListaEstaciones(prmBusqueda As String)
        Try


            Dim pResultado As New CResultado
            Dim Cls As New clsOrdenProd

            Cursor.Current = Cursors.WaitCursor

            pResultado = Cls.ListaEstaciones()
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                grdPartidasTraspaso.DataSource = Nothing
                Return
            End If
            Dim dt As New DataTable
            Dim ds As New DataSet

            dt = pResultado.Tabla
            ds.Tables.Add(dt)
            Dim row As DataRow = ds.Tables(0).NewRow

            row.Item(0) = "TODOS"
            ds.Tables(0).Rows.InsertAt(row, 0)

            CmbEstacion.Properties.ValueMember = "Estacion"
            CmbEstacion.Properties.DisplayMember = "Estacion"
            CmbEstacion.Properties.DataSource = dt

            'Dim TipoLiberacion() As String = {"PALLET", "EMPAQUE", "PACKING"}
            TipoLib.Add(New Tipo() With {.TipoLiberacion = "TODO", .TipoLibID = 1})
            '  TipoLib.Add(New Tipo() With {.TipoLiberacion = "EMPAQUE", .TipoLibID = 2})
            ' TipoLib.Add(New Tipo() With {.TipoLiberacion = "PICKING", .TipoLibID = 3})
            'CmbTipoLib.Properties.NullText = "Tipo De Liberacion"
            CmbTipoLib.Properties.ValueMember = "TipoLiberacion"
            CmbTipoLib.Properties.DisplayMember = "TipoLiberacion"
            CmbTipoLib.Properties.DataSource = TipoLib




        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub Conteo()
        For Fila As Integer = 0 To GridView1.RowCount - 1
            'Dim Fila As Integer = DgvViewResultado.RowCount
            CantidadASurtir = GridView1.GetRowCellValue(Fila, "CantidadSolicitada")
            CantidadPedida = GridView1.GetRowCellValue(Fila, "CantidadSolicitada")
            'If CantidadPedida - CantidadASurtir = 0 Then
            '    ESTOTAL = 2
            '    'CantidadPedida = CantidadASurtir - CantidadPedida
            'Else
            '    'CantidadPedida = CantidadASurtir - CantidadPedida
            '    ESTOTAL = 3
            '    Exit Sub
            'End If
            ESTOTAL = 2
        Next
    End Sub
    Public Sub LiberarTras()
        Try

            Dim iLote As Integer = 0
            Dim iCant As Integer = 0
            Dim pValidacionLote As Integer

            If GridView1.RowCount <= 0 Then
                XtraMessageBox.Show("No hay detalle en el Traspaso", "Error", MessageBoxButtons.OK)
                Return
            End If

            If String.IsNullOrEmpty(CmbEstacion.Text) Then
                XtraMessageBox.Show("Seleccionar una opción en el listado de Estaciones", "Información", MessageBoxButtons.OK)
                Return
            End If
            'If String.IsNullOrEmpty(CmbTipoLib.Text) Then
            '    XtraMessageBox.Show("Seleccionar un tipo de liberado", "Información", MessageBoxButtons.OK)
            '    Return
            'End If

            'For Fila As Integer = 0 To DgvViewResultado.RowCount - 1
            '    'Dim Fila As Integer = DgvViewResultado.RowCount
            '    If DgvViewResultado.GetRowCellValue(Fila, "CantidadASurtir") = 0 Then
            '        XtraMessageBox.Show("Ingresa una cantidad a Suritir", "Información", MessageBoxButtons.OK)
            '    End If
            'Next
            'If ChkLote.Checked Then
            '    Dim view As ColumnView = CType(DgvResultado.MainView, ColumnView)
            '    For i As Integer = 0 To view.RowCount - 1
            '        Dim sLote As String
            '        sLote = view.GetRowCellValue(i, "Lote")
            '        If sLote <> "" Then
            '            iLote = iLote + 1
            '        End If
            '        iCant = iCant + 1
            '    Next
            '    If iCant = 0 Then
            '        XtraMessageBox.Show("No hay detalle", "Error", MessageBoxButtons.OK)
            '        Return
            '    End If
            '    If iLote <> iCant Then
            '        XtraMessageBox.Show("Hay partidas sin revisión de existencias", "Error", MessageBoxButtons.OK)
            '        Return
            '    End If

            '    pValidacionLote = 1
            'Else
            '    pValidacionLote = 0
            'End If
            EstableceEstacion()

            Dim ds As New DataSet
            Dim dt As New DataTable
            dt = TryCast(grdPartidasTraspaso.DataSource, DataTable)
            ds.Tables.Add(dt.Copy)


            Dim pResultado As New CResultado
            Dim Cls As New clsTransfer

            Conteo()



            Cursor.Current = Cursors.WaitCursor
            pResultado = Cls.LiberaTras(pValidacionLote, txtTraspasoSalida.Text, dt.DataSet.GetXml, My.Settings("Estacion"), DatosTemporales.Usuario, CmbTipoLib.Text, ESTOTAL, CantidadPedida, CantidadASurtir)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                Return
            End If

            XtraMessageBox.Show("Orden de Traspaso liberada", "Información", MessageBoxButtons.OK)



        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub
    Sub EstableceEstacion()

        Dim view As ColumnView = CType(grdPartidasTraspaso.MainView, ColumnView)
        If ChkEstacion.Checked Then
            pEstacion = CmbEstacion.Text
            Dim ArrCadena As String() = pEstacion.Split("/")
            For i As Integer = 0 To view.RowCount - 1

                view.SetRowCellValue(i, "Estacion", ArrCadena(0))
            Next
            GridView1.RefreshData()
            grdPartidasTraspaso.Refresh()
        Else
            pEstacion = "TODOS"
            For i As Integer = 0 To view.RowCount - 1

                view.SetRowCellValue(i, "Estacion", "")
            Next
            GridView1.RefreshData()
            grdPartidasTraspaso.Refresh()
        End If
    End Sub
    Private Sub CargaTransf(ByVal ds As DataSet)
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

                grdPartidasTraspaso.DataSource = ds.Tables(1)
                GridView1.Columns("Documento").Caption = "Orden de Transpaso"
                'Nombre de las columnas
                GridView1.Columns("Documento").Caption = "Orden de Transpaso"
                GridView1.Columns("Partida").Caption = "Partidas"
                GridView1.Columns("NumParte").Caption = "Producto"
                GridView1.Columns("CantidadSolicitada").Caption = "Cantidad Solicitada"
                GridView1.Columns("CantidadSurtida").Caption = "Cantidad Surtida"
                GridView1.Columns("DStatus").Caption = "Estatus"
                'GridView1.Columns("CantidadRecibida").Caption = "Cantidad Recibida"
                GridView1.Columns("Descripcion").Caption = "Descripción"
                GridView1.Columns("Estacion").Caption = "Estacion"
                ''Tamaño minimo de columnas
                GridView1.Columns(2).MinWidth = 100
                ''Desactiva las columnas innesesarias

                GridView1.Columns("Documento").Visible = False
                GridView1.Columns("Partida").OptionsColumn.ReadOnly = True
                GridView1.Columns("NumParte").OptionsColumn.ReadOnly = True
                GridView1.Columns("Descripcion").OptionsColumn.ReadOnly = True
                GridView1.Columns("CantidadSolicitada").OptionsColumn.ReadOnly = True
                GridView1.Columns("CantidadSurtida").OptionsColumn.ReadOnly = True
                'GridView1.Columns("CantidadARecibir").OptionsColumn.ReadOnly = False
                GridView1.Columns("CantidadPendiente").Visible = False
                'GridView1.Columns("Revision").Visible = False
                GridView1.Columns("DStatus").OptionsColumn.ReadOnly = True
                GridView1.Columns("Estatus").Visible = False
                GridView1.Columns("Tag1").Visible = False
                GridView1.Columns("Tag2").Visible = False
                GridView1.Columns("Tag3").Visible = False
                GridView1.Columns("FechaCreacion").Visible = False
                'GridView1.Columns("UnidadMedida").Visible = False
                'GridView1.Columns("NomProveedor").Visible = False



                ' dgvResultado.Columns("IdProveedor").Visible = False
                GridView1.Columns("Lotes").Visible = False
                GridView1.Columns("CodigoExterno").Visible = False

                'GridView1.Columns("Direccion1").Visible = False

                'Centra el texto de las celdas
                'GridView1.sty .RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                'Rellena todo el grid con las columnas
                'GridView1 .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                'Quita permisos al usuario
                GridView1.BestFitColumns()
                txtTraspasoSalida.Text = ds.Tables(1).Rows(0)("Documento").ToString()
                'CargaTextBox(ds)
                Dim view As ColumnView = CType(grdPartidasTraspaso.MainView, ColumnView)

                Dim selectedRowHandles As Integer() = view.GetSelectedRows



                Dim Si As String = view.GetRowCellValue(selectedRowHandles(0), "EstacionAsignada").ToString

                If Si = "" Then
                    GridView1.Columns("Estacion").Visible = True
                    GridView1.Columns("EstacionAsignada").Visible = False
                Else
                    GridView1.Columns("Estacion").Visible = False
                    GridView1.Columns("EstacionAsignada").Visible = True

                End If
                For Fila As Integer = 0 To GridView1.RowCount - 1

                    CantidadPedida = GridView1.GetRowCellValue(Fila, "CantidadSolicitada")
                    GridView1.SetRowCellValue(Fila, "CantidadARecibir", CantidadPedida)
                Next

            End If
        Catch ex As Exception
            XtraMessageBox.Show("Error: " + ex.Message, "AXC")
        End Try
    End Sub
    Public Sub LimpiarCamposOC()
        grdPartidasTraspaso.DataSource = Nothing

        'txtFactura.ResetText()
        'dtFechaPedimento.ResetText()
        'dtpFechaRecibe.ResetText()
        'txtPedimento.ResetText()
        'txtClavePedimento.ResetText()
        'txtReferencia.ResetText()
        'txtContenedor.ResetText()
    End Sub

    Private Sub CmbEstacion_EditValueChanged(sender As Object, e As EventArgs) Handles CmbEstacion.EditValueChanged
        EstableceEstacion()
    End Sub
#End Region

End Class