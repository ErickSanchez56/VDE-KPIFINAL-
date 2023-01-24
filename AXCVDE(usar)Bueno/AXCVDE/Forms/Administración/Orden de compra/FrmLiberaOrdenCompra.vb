Imports System.IO
Imports DevExpress.XtraEditors

Public Class FrmLiberaOrdenCompra
#Region "VARIABLES"
    Public dsLotes As DataSet = New DataSet
    Public tblLotes As DataTable = New DataTable

    Public pPartida As String = ""
    Public pNumParte As String = ""
    Public pCantidad As String = ""
    Public pLotes As String = ""
    Public pOrdenCompra As String = ""
#End Region

#Region "EVENTOS"
    Private Sub FrmLiberaOrdenCompra_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            ' BorrarTextbox()
            Dim dt As DataTable = New DataTable
            'dgvResultado.DataSource = dt
            txtOrdenCompra.Properties.CharacterCasing = CharacterCasing.Upper

            If Not String.IsNullOrEmpty(pOrdenCompra) Then
                Dim nuevo As New ClsOrdenCompra
                txtOrdenCompra.Text = pOrdenCompra
                CargaOrdenCompra(nuevo.ConsultaOrdenCompraGeneral(pOrdenCompra))
            End If
        Catch ex As Exception
            XtraMessageBox.Show("Error: " + ex.Message, "AXC")
        End Try
    End Sub



    'Private Sub btnCostos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCostos.Click
    '    Try
    '        FrmCostosCarga.ShowDialog()
    '    Catch ex As Exception
    '        MsgBox("Error: " + ex.Message, MsgBoxStyle.Critical, "AXC")
    '    End Try
    'End Sub

    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click
        Dim resp As String
        Try
            Dim nuevo As New ClsOrdenCompra
            'nuevo.ActualizaOrdenCompra(txtOrdenCompra.Text, My.Settings("Estacion"), DatosTemporales.Usuario)
            If String.IsNullOrEmpty(txtOrdenCompra.Text) Then
                XtraMessageBox.Show("Ingresar una orden de compra", "AXC")
                Return
            End If
            resp = nuevo.ActualizaOrdenCompra(txtOrdenCompra.Text, My.Settings("Estacion"), DatosTemporales.Usuario)
            If resp = "OK" Then
                XtraMessageBox.Show("Orden actualizada con éxito", "AXC")
                CargaOrdenCompra(nuevo.ConsultaOrdenCompraGeneral(txtOrdenCompra.Text))
            Else
                XtraMessageBox.Show(resp, "AXC")
                Return
            End If
        Catch ex As Exception
            XtraMessageBox.Show("Error: " + ex.Message, "AXC")
        End Try
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Try
            Dim nuevo As New ClsOrdenCompra
            dgvResultado.DataSource = Nothing
            ''dgvResultado.Columns.Clear()
            'dgvResultado.Rows.Clear()

            If String.IsNullOrEmpty(txtOrdenCompra.Text) Then
                XtraMessageBox.Show("Favor de ingresar la orden de compra", "AXC")
                txtOrdenCompra.Select()
            Else
                CargaOrdenCompra(nuevo.ConsultaOrdenCompraGeneral(txtOrdenCompra.Text))
            End If
        Catch ex As Exception
            XtraMessageBox.Show("Error: " + ex.Message, "AXC")
        End Try
    End Sub

    Private Sub btnLiberar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLiberar.Click
        Dim cOrdenCompra As ClsOrdenCompra = New ClsOrdenCompra
        Dim resultado As CResultado
        Try

            'If String.IsNullOrEmpty(txtCabecera.Text) Then
            '    XtraMessageBox.Show("Debes ingresar el dato de Texto de cabecera", "Información", MessageBoxButtons.OK)
            '    txtCabecera.Select()
            '    Return
            'End If

            'If String.IsNullOrEmpty(TxtNota.Text) Then
            '    XtraMessageBox.Show("Debes de ingresar el dato de Nota de entrega", "Información", MessageBoxButtons.OK)
            '    TxtNota.Select()
            '    Return
            'End If

            'If String.IsNullOrEmpty(txtCarta.Text) Then
            '    XtraMessageBox.Show("Debes ingresar el dato de Carta porte", "Información", MessageBoxButtons.OK)
            '    txtCarta.Select()
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

            If String.IsNullOrEmpty(txtOrdenCompra.Text) Then
                XtraMessageBox.Show("Favor de ingresar la orden de compra", "AXC")
                Exit Sub
            End If
            If txtFactura.Text.Trim = "" Then
                XtraMessageBox.Show("Ingrese la factura", "AXC")
                Return
            End If
            If txtContenedor.Text.Trim = "" Then
                XtraMessageBox.Show("Ingrese el contenedor", "AXC")
                Return
            End If
            If txtReferencia.Text.Trim = "" Then
                XtraMessageBox.Show("Ingrese la referencia", "AXC")
                Return
            End If
            If iCantidadARecibir = iCant Then
                If XtraMessageBox.Show("¿Generar la recepcion del material?", "AXC", MessageBoxButtons.YesNo) <> DialogResult.Yes Then
                    Return
                End If
            Else

                If XtraMessageBox.Show("Dejo algunos registros en cero" + Chr(13) + "¿Generar la recepcion del material?", "AXC", MessageBoxButtons.YesNo) <> DialogResult.Yes Then
                    Return
                End If
            End If

            Dim fecha As New Date
            fecha = Date.Parse(dtpFechaRecibe.EditValue.ToString)
            'Dim FechaPedimento As New Date
            'FechaPedimento = Date.Parse(dtFechaPedimento.EditValue.ToString)

            Dim ds As DataSet = New DataSet
            ds.Merge(dgvResultado.DataSource)
            ds.Tables(0).Columns.Item("NumParte").ColumnName = "Producto"
            resultado = cOrdenCompra.LiberaOrdenCompra(txtOrdenCompra.Text, txtFactura.Text, txtReferencia.Text, fecha, "", "", "", Date.Now, ds.GetXml(), "", txtCabecera.Text, TxtNota.Text, "", txtContenedor.Text, My.Settings("Estacion"), DatosTemporales.Usuario, 0, 1)
            If resultado.Estado Then
                XtraMessageBox.Show("Orden de Compra Liberada", "AXC")
                BorrarTextbox()
                Dim dt As DataTable = New DataTable
                dgvResultado.DataSource = dt
            Else
                XtraMessageBox.Show("" + resultado.Texto.ToString(), "AXC")
            End If
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try

    End Sub
#End Region

#Region "METODOS"


    Private Sub CargaOrdenCompra(ByVal ds As DataSet)
        Try
            If ds.Tables.Count = 1 Then
                dgvResultado.DataSource = Nothing
                ' BorrarTextbox()
                XtraMessageBox.Show(ds.Tables(0).Rows(0)(1).ToString(), "AXC")
            Else
                If ds.Tables(1).Rows.Count <= 0 Then
                    XtraMessageBox.Show("No se encontraron las partidas, ya fueron completadas o se encuentran en una hoja de conteo")
                    Return
                End If
                dgvResultado.DataSource = ds.Tables(1)
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


                CargaTextBox(ds)
                GridView1.BestFitColumns()
            End If
        Catch ex As Exception
            dgvResultado.DataSource = Nothing
            XtraMessageBox.Show("Error: " + ex.Message, "AXC")
        End Try
    End Sub

    Private Sub CargaTextBox(ByVal dsg As DataSet)
        Try
            txtIdProveedor.Text = dsg.Tables(1).Rows(0)(16)
            txtFechaCrea.Text = dsg.Tables(1).Rows(0)(15)

            txtDireccionProv.Text = dsg.Tables(1).Rows(0)("Direccion1")

        Catch ex As Exception
            XtraMessageBox.Show("Error: " + ex.Message, "AXC")
        End Try
    End Sub

    Private Sub BorrarTextbox()
        Try
            txtOrdenCompra.Text = ""
            txtIdProveedor.Text = ""
            txtFechaCrea.Text = ""
            txtFactura.Text = ""
            txtReferencia.Text = ""
            txtClavePedimento.Text = ""
            txtPedimento.Text = ""
            txtFactura.Text = ""
            dtpFechaRecibe.Text = ""
            txtCabecera.Text = ""
            TxtNota.Text = ""
            txtContenedor.Text = ""

            dsLotes = New DataSet
        Catch ex As Exception
            XtraMessageBox.Show("Error: " + ex.Message, "AXC")
        End Try
    End Sub

    Private Sub FrmLiberaOrdenCompra_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            Me.Dispose(True)
        Catch ex As Exception

        End Try
    End Sub



    Private Sub txtOrdenCompra_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtOrdenCompra.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then


            Try
                Dim nuevo As New ClsOrdenCompra
                dgvResultado.DataSource = Nothing
                GridView1.Columns.Clear()
                ' dgvResultado.Rows.Clear()

                If String.IsNullOrEmpty(txtOrdenCompra.Text) Then
                    XtraMessageBox.Show("Favor de ingresar la orden de compra", "AXC")
                    txtOrdenCompra.Select()
                Else
                    CargaOrdenCompra(nuevo.ConsultaOrdenCompraGeneral(txtOrdenCompra.Text))
                End If

            Catch ex As Exception
                XtraMessageBox.Show(ex.Message, "AXC")
            End Try


        End If
    End Sub

    Private Sub LabelControl7_Click(sender As Object, e As EventArgs) Handles LabelControl7.Click

    End Sub

    Private Sub dtpFechaRecibe_EditValueChanged(sender As Object, e As EventArgs) Handles dtpFechaRecibe.EditValueChanged

    End Sub

    Private Sub GridView1_DoubleClick(sender As Object, e As EventArgs) Handles GridView1.DoubleClick
        'Try

        '    If GridView1.RowCount <= 0 Then
        '        Return
        '    End If

        '    Dim view As ColumnView = CType(dgvResultado.MainView, ColumnView)

        '    Dim selectedRowHandles As Integer() = view.GetSelectedRows

        '    pPartida = (view.GetRowCellValue(selectedRowHandles(0), "Partida"))
        '    pNumParte = (view.GetRowCellValue(selectedRowHandles(0), "NumParte"))
        '    pLotes = (view.GetRowCellValue(selectedRowHandles(0), "Lotes"))
        '    pCantidad = (view.GetRowCellValue(selectedRowHandles(0), "CantidadARecibir"))

        '    If Decimal.Parse(pCantidad) <= 0 Then
        '        XtraMessageBox.Show("el campo de Cantidad a recibir tiene que ser mayor a 0", "AXC")
        '        Return
        '    End If

        '    FrmLotesOrdenCompra.ShowDialog()
        '    view.SetRowCellValue(selectedRowHandles(0), "Lotes", pLotes)
        '    view.SetRowCellValue(selectedRowHandles(0), "tblLotes", tblLotes)
        '    GridView1.RefreshData()
        '    dgvResultado.Refresh()

        'Catch ex As Exception
        '    XtraMessageBox.Show("Error: " + ex.Message, "AXC")
        'End Try
    End Sub

    Private Sub dgvResultado_Click(sender As Object, e As EventArgs) Handles dgvResultado.Click

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Dim cOrdenCompra As ClsOrdenCompra = New ClsOrdenCompra
        Dim resultado As CResultado
        Try
            Dim sFactura As String = ""
            Dim sClaveRecepcion As String = ""
            Dim iCantidadARecibir As Integer = 0
            Dim iDiferencia As Integer = 0
            Dim iCant As Integer = 0
            Dim iError As Integer = 0

            For i As Integer = 0 To GridView1.RowCount - 1
                Dim sCantidadOrdenada As Integer = GridView1.GetRowCellValue(i, "CantidadOrdenada") ' Convert.ToString(GridView1.GetRowCellValue(i, "CantidadOrdenada"))
                Dim sCantidadARecibir As Integer = GridView1.GetRowCellValue(i, "CantidadARecibir") 'Convert.ToString(GridView1.GetRowCellValue(i, "CantidadARecibir"))
                Dim sLotes = GridView1.GetRowCellValue(i, "Lotes")
                If sCantidadARecibir <> 0 Then
                    iCantidadARecibir = iCantidadARecibir + 1
                End If
                If sCantidadARecibir > sCantidadOrdenada Then
                    iDiferencia = iDiferencia + 1
                End If
                If sLotes.Trim = "" And sCantidadARecibir <> 0 Then
                    XtraMessageBox.Show("Debes ingresar los lotes del material recibido", "AXC")
                    iError = 1
                    Exit For
                End If

                iCant = iCant + 1
            Next

            If iError = 1 Then
                Return
            End If
            If iCantidadARecibir = 0 Then
                XtraMessageBox.Show("Debes ingresar la cantidad a recibir", "AXC")
                Return
            End If
            If iDiferencia > 0 Then
                XtraMessageBox.Show("La cantidad a recibir supera la cantidad ordenada", "AXC")
                Return
            End If

            If String.IsNullOrEmpty(txtOrdenCompra.Text) Then
                XtraMessageBox.Show("Favor de ingresar la orden de compra", "AXC")
                Exit Sub
            End If
            If txtFactura.Text.Trim = "" Then
                XtraMessageBox.Show("Ingrese la factura", "AXC")
                Return
            End If
            If txtContenedor.Text.Trim = "" Then
                XtraMessageBox.Show("Ingrese el contenedor", "AXC")
                Return
            End If
            If txtReferencia.Text.Trim = "" Then
                XtraMessageBox.Show("Ingrese la referencia", "AXC")
                Return
            End If
            If iCantidadARecibir = iCant Then
                If XtraMessageBox.Show("¿Generar la recepcion del material?", "AXC", MessageBoxButtons.YesNo) <> DialogResult.Yes Then
                    Return
                End If
            Else

                If XtraMessageBox.Show("Dejo algunos registros en cero" + Chr(13) + "¿Generar la recepcion del material?", "AXC", MessageBoxButtons.YesNo) <> DialogResult.Yes Then
                    Return
                End If
            End If
            Dim fecha As New Date
            fecha = Date.Parse(dtpFechaRecibe.EditValue.ToString)


            Dim ds As DataSet = New DataSet
            ds.Merge(dgvResultado.DataSource)
            dsLotes = New DataSet

            For i As Integer = 0 To GridView1.RowCount - 1
                Dim sCantidadOrdenada As Integer = GridView1.GetRowCellValue(i, "CantidadOrdenada") ' Convert.ToString(GridView1.GetRowCellValue(i, "CantidadOrdenada"))
                Dim sCantidadARecibir As Integer = GridView1.GetRowCellValue(i, "CantidadARecibir") 'Convert.ToString(GridView1.GetRowCellValue(i, "CantidadARecibir"))
                Dim sLotes = GridView1.GetRowCellValue(i, "Lotes")
                If sCantidadARecibir <> 0 Then
                    iCantidadARecibir = iCantidadARecibir + 1
                End If
                If sCantidadARecibir > sCantidadOrdenada Then
                    iDiferencia = iDiferencia + 1
                End If
                If sLotes.Trim = "" And sCantidadARecibir <> 0 Then
                    XtraMessageBox.Show("Debes ingresar los lotes del material recibido", "AXC")
                    iError = 1
                    Exit For
                End If

                iCant = iCant + 1
            Next

            For i As Integer = 0 To GridView1.RowCount - 1
                If GridView1.GetRowCellValue(i, "Lotes") Is Nothing Then

                Else
                    Dim a As Object
                    a = GridView1.GetRowCellDisplayText(i, "Lotes")
                    dsLotes.Merge(XMLToDataSet(GridView1.GetRowCellDisplayText(i, "Lotes"), ""))
                End If
            Next

            'PRIMERO VALIDAMOS SI CUMPLE CON AXC
            resultado = cOrdenCompra.LiberaOrdenCompra(txtOrdenCompra.Text, txtFactura.Text, txtReferencia.Text, fecha, "", "", "", fecha, ds.GetXml(), "", "", "", "", txtContenedor.Text, My.Settings("Estacion"), DatosTemporales.Usuario, 1, 0)

            If Not resultado.Estado Then
                XtraMessageBox.Show("" + resultado.Texto.ToString(), "AXC")
            Else
                'PASO LAS VALIDACIONES DE AXC, PROCEDEMOS A REGISTRAR EN SAP

                'APLICAMOS EN AXC
                resultado = cOrdenCompra.LiberaOrdenCompra(txtOrdenCompra.Text, txtFactura.Text, txtReferencia.Text, fecha, "", "", "", fecha, ds.GetXml(), "", "", "", "", txtContenedor.Text, My.Settings("Estacion"), DatosTemporales.Usuario, 0, 1)
                If Not resultado.Estado Then
                    XtraMessageBox.Show("" + resultado.Texto.ToString(), "AXC")
                Else
                    XtraMessageBox.Show("Orden de Compra Liberada", "AXC")
                    BorrarTextbox()
                    Dim dt As DataTable = New DataTable
                    dgvResultado.DataSource = dt
                End If
            End If
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub

    Public Shared Function XMLToDataSet(ByVal xmlStr As String, ByVal schemaFile As String) As DataSet
        'Convert the XML to a dataset
        Dim sr As New StringReader(xmlStr)

        'Convert xmlData to a Dataset
        Dim ds As New DataSet

        If schemaFile = String.Empty Then
            ds.ReadXml(sr, XmlReadMode.InferSchema)
        Else
            ds.ReadXmlSchema(schemaFile)
            ds.ReadXml(sr, XmlReadMode.ReadSchema)
        End If

        For Each relation As DataRelation In ds.Relations
            For Each c As DataColumn In relation.ParentColumns
                If Not relation.ChildTable.Columns.Contains(c.ColumnName) Then
                    relation.ChildTable.Columns.Add(c)
                End If
                For Each dr As DataRow In relation.ChildTable.Rows
                    dr(c.ColumnName) = dr.GetParentRow(relation)(c.ColumnName)
                Next
            Next
        Next

        Return ds
    End Function

#End Region

End Class