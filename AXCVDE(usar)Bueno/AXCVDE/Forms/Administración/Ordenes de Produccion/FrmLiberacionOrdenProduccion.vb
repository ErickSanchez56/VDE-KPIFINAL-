Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid.Views.Grid
Public Class FrmLiberacionOrdenProduccion

#Region "VARIABLES"
    Public pLote As String
    Public pEstacion As String
    Public pNumParteDet As String
    Public pOrdenProd As String
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

    Private Sub FrmLiberaOrdenProduccion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ListaEstaciones("")


            Dim Fila As Integer = DgvViewResultado.RowCount
            If DgvViewResultado.GetRowCellValue(Fila, "EstacionAsignada") = 0 Then
                DgvViewResultado.Columns("Estacion").Visible = True
                DgvViewResultado.Columns("EstacionAsignada").Visible = False
            Else
                DgvViewResultado.Columns("Estacion").Visible = False
                DgvViewResultado.Columns("EstacionAsignada").Visible = True
            End If
            If ChkEstacion.Checked Then
                DgvViewResultado.Columns("Estacion").Visible = False
                'DgvViewResultado.Columns("CantidadASurtir").Visible = False
                CmbEstacion.Enabled = True
                EstableceEstacion()
            Else
                DgvViewResultado.Columns("Estacion").Visible = True
                'DgvViewResultado.Columns("CantidadASurtir").Visible = False
                CmbEstacion.Enabled = False
                EstableceEstacion()
            End If


            Dim TipoBus = New List(Of String)()
            TipoBus.Add("EXPRESS")
            TipoBus.Add("ESTAFETA")
            'cmbPaqueteria.Properties.DataSource = TipoBus
            'cmbPaqueteria.ItemIndex = 0

            If Not String.IsNullOrEmpty(pOrdenProd) Then
                TxtBusqueda.Text = pOrdenProd
                ConsultaOrdenProd(pOrdenProd)
            End If
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub BtnLiberar_Click(sender As Object, e As EventArgs) Handles BtnLiberar.Click
        Try
            If XtraMessageBox.Show("¿Liberar Orden de Produccion?", "AXC", MessageBoxButtons.YesNo) <> DialogResult.Yes Then
                Return
            End If


            For Fila As Integer = 0 To DgvViewResultado.RowCount - 1
                If DgvViewResultado.GetRowCellValue(Fila, "CantidadASurtir") <> 0 Then
                    LiberarOrdenProd()
                    Exit For
                Else
                    XtraMessageBox.Show("La orden NO se puede Liberar en 0")
                    Return
                End If
            Next





            DgvResultado.DataSource = Nothing
            DgvResultado.Refresh()
            'txtGuia.Text = ""
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try


    End Sub

    Public Sub LiberarOrdenProd()
        Try

            Dim iLote As Integer = 0
            Dim iCant As Integer = 0
            Dim pValidacionLote As Integer

            If DgvViewResultado.RowCount <= 0 Then
                XtraMessageBox.Show("No hay detalle de orden de produccion", "Error", MessageBoxButtons.OK)
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
            dt = TryCast(DgvResultado.DataSource, DataTable)
            ds.Tables.Add(dt.Copy)


            Dim pResultado As New CResultado
            Dim Cls As New clsOrdenProd

            Conteo()



            Cursor.Current = Cursors.WaitCursor
            pResultado = Cls.LiberaOrdenProd(pValidacionLote, TxtBusqueda.Text, dt.DataSet.GetXml, My.Settings("Estacion"), DatosTemporales.Usuario, CmbTipoLib.Text, ESTOTAL, CantidadPedida, CantidadASurtir)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                Return
            End If

            XtraMessageBox.Show("Orden de produccion liberada", "Información", MessageBoxButtons.OK)



        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Try
        If String.IsNullOrEmpty(TxtBusqueda.Text) Then
            XtraMessageBox.Show("Favor de ingresar la orden de produccion", "Información", MessageBoxButtons.OK)
            TxtBusqueda.Select()
            Return
        End If
            ConsultaOrdenProd(TxtBusqueda.Text)
            EstableceEstacion()


        Catch ex As Exception
        XtraMessageBox.Show(ex.Message)
        End Try
        Dim nuevo As New clsEmbarque
    End Sub

    Private Sub Conteo()
        For Fila As Integer = 0 To DgvViewResultado.RowCount - 1
            'Dim Fila As Integer = DgvViewResultado.RowCount
            CantidadASurtir = DgvViewResultado.GetRowCellValue(Fila, "CantidadASurtir")
            CantidadPedida = DgvViewResultado.GetRowCellValue(Fila, "CantidadPedida")
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
    Private Sub ConsultaOrdenProd(prmBusqueda As String)
        Try
            DgvResultado.DataSource = Nothing

            Dim pResultado As New CResultado
            Dim Cls As New clsOrdenProd

            Cursor.Current = Cursors.WaitCursor
            pResultado = Cls.ConsultaOrdenProdDet(prmBusqueda)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                DgvResultado.DataSource = Nothing
                Return
            End If
            Dim dt As New DataTable
            Dim ds As New DataSet

            dt = pResultado.Tabla
            ds.Tables.Add(dt)

            If dt.Rows.Count < 1 Then
                XtraMessageBox.Show("No hay partidas en la orden de produccion")
                DgvResultado.DataSource = Nothing
                Return
            End If
            DgvResultado.DataSource = dt
            'Dim _riEditor As New RepositoryItemComboBox()
            '_riEditor.Items.AddRange(New String() {"PALLET", "EMPAQUE", "PICKING"})
            'DgvResultado.RepositoryItems.Add(_riEditor)
            'DgvViewResultado.Columns(7).ColumnEdit = _riEditor
            'If Not String.IsNullOrEmpty(ds.Tables(0).Rows(0)("Guia").ToString) Then
            '    If ds.Tables(0).Rows(0)("Guia").ToString = "NA" Then
            '        ChkCustomer.Checked = True
            '        txtGuia.Text = ""
            '    Else
            '        ChkCustomer.Checked = False 
            '        txtGuia.Text = ds.Tables(0).Rows(0)("Guia").ToString
            '        cmbPaqueteria.Text = ds.Tables(0).Rows(0)("Paqueteria").ToString
            '    End If
            'Else
            '    ChkCustomer.Checked = False
            '    cmbPaqueteria.Text = ds.Tables(0).Rows(0)("Paqueteria").ToString
            'End If
            Dim view As ColumnView = CType(DgvResultado.MainView, ColumnView)

            Dim selectedRowHandles As Integer() = view.GetSelectedRows



            Dim Si As String = view.GetRowCellValue(selectedRowHandles(0), "EstacionAsignada").ToString

            If Si = "" Then
                DgvViewResultado.Columns("Estacion").Visible = True
                DgvViewResultado.Columns("EstacionAsignada").Visible = False
            Else
                DgvViewResultado.Columns("Estacion").Visible = False
                DgvViewResultado.Columns("EstacionAsignada").Visible = True

            End If
            For Fila As Integer = 0 To DgvViewResultado.RowCount - 1

                CantidadPedida = DgvViewResultado.GetRowCellValue(Fila, "CantidadPedida")
                DgvViewResultado.SetRowCellValue(Fila, "CantidadASurtir", CantidadPedida)
            Next
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ListaEstaciones(prmBusqueda As String)
        Try


            Dim pResultado As New CResultado
            Dim Cls As New clsOrdenProd

            Cursor.Current = Cursors.WaitCursor

            pResultado = Cls.ListaEstaciones()
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                DgvResultado.DataSource = Nothing
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

    Private Sub ChkEstacion_CheckedChanged(sender As Object, e As EventArgs) Handles ChkEstacion.CheckedChanged
        Try
            If ChkEstacion.Checked Then
                DgvViewResultado.Columns("Estacion").Visible = False
                CmbEstacion.Enabled = True
                EstableceEstacion()
            Else
                DgvViewResultado.Columns("Estacion").Visible = True
                CmbEstacion.Enabled = False
                EstableceEstacion()
            End If
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub EstableceEstacion()

        Dim view As ColumnView = CType(DgvResultado.MainView, ColumnView)
        If ChkEstacion.Checked Then
            pEstacion = CmbEstacion.Text
            Dim ArrCadena As String() = pEstacion.Split("/")
            For i As Integer = 0 To view.RowCount - 1

                view.SetRowCellValue(i, "Estacion", ArrCadena(0))
            Next
            DgvViewResultado.RefreshData()
            DgvResultado.Refresh()
        Else
            pEstacion = "TODOS"
            For i As Integer = 0 To view.RowCount - 1

                view.SetRowCellValue(i, "Estacion", "")
            Next
            DgvViewResultado.RefreshData()
            DgvResultado.Refresh()
        End If
    End Sub



    Private Sub DgvViewResultado_DoubleClick(sender As Object, e As EventArgs) Handles DgvViewResultado.DoubleClick
        Try


            Dim view As ColumnView = CType(DgvResultado.MainView, ColumnView)

            Dim selectedRowHandles As Integer() = view.GetSelectedRows


            pNumParteDet = view.GetRowCellValue(selectedRowHandles(0), "NumParte").ToString
            'pLote = view.GetRowCellValue(selectedRowHandles(0), "Lote").ToString
            pOrdenProd = TxtBusqueda.Text
            FrmModificarEstacion.pOrdenProd = pOrdenProd

            FrmModificarEstacion.pNumParte = pNumParteDet
            FrmModificarEstacion.pLote = pLote
            FrmModificarEstacion.pEstacion = pEstacion
            'FrmModificaPartida.chkLote = ChkLote.CheckState
            FrmModificarEstacion.ShowDialog()

            'view.SetRowCellValue(selectedRowHandles(0), "Lote", pLote)
            view.SetRowCellValue(selectedRowHandles(0), "Estacion", pEstacion)
            DgvViewResultado.RefreshData()
            DgvResultado.Refresh()
            ConsultaOrdenProd(pOrdenProd)


        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub cargaOrdenesProd(ByVal prmOrdenProduccion)
        Try

            DgvResultado.DataSource = Nothing
            Dim pResultado As New CResultado
            Dim Cls As New clsOrdenProd



            Cursor.Current = Cursors.WaitCursor
            pResultado = Cls.OrdenesProduccion(prmOrdenProduccion, My.Settings.Estacion, DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                DgvResultado.DataSource = Nothing
                Return
            End If
            Dim dt As New DataTable
            Dim ds As New DataSet

            dt = pResultado.Tabla
            ds.Tables.Add(dt)

            If dt.Rows.Count < 1 Then
                XtraMessageBox.Show("No hay información de pedidos con los filtros seleccionados")
                DgvResultado.DataSource = Nothing
                Return
            End If

            DgvResultado.DataSource = dt

            DgvViewResultado.BestFitColumns()
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub CmbEstacion_EditValueChanged(sender As Object, e As EventArgs) Handles CmbEstacion.EditValueChanged
        Try
            EstableceEstacion()
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub FrmLiberaOrdenProduccion_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose(True)
    End Sub



    Private Sub ActualizarDocumento(prmDocumento As String)
        Try
            Dim pResultado As New CResultado
            Dim Cls As New COrdenProd

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




    Private Sub DgvViewResultado_CustomRowCellEdit(sender As Object, e As DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs) Handles DgvViewResultado.CustomRowCellEdit
        Dim View As GridView = sender
        If e.Column.CustomizationSearchCaption = "TipoDeLiberacion" Then
            Verificacion()
        End If
    End Sub

    'Private Sub DgvViewResultado_CustomDrawCell(sender As Object, e As RowCellCustomDrawEventArgs) Handles DgvViewResultado.CustomDrawCell
    '    Try
    '        Dim View As GridView = sender
    '        If DgvViewResultado.RowCount > 0 Then
    '            Dim Texto As String = ""
    '            Texto = View.GetRowCellDisplayText(e.RowHandle, View.Columns("CantidadASurtir"))
    '            If Texto = "" Then
    '                Texto = 0
    '            End If
    '            If Texto = 0 Then
    '                If e.Column.CustomizationSearchCaption = "Cantidad A Surtir" Then
    '                    e.Appearance.BackColor = Color.LightSeaGreen
    '                End If
    '                If e.Column.CustomizationSearchCaption = "Tipo De Liberacion" Then
    '                    e.Appearance.BackColor = Color.LightSeaGreen
    '                End If
    '            End If
    '            DgvViewResultado.FocusInvalidRow()
    '        End If
    '    Catch ex As Exception
    '        XtraMessageBox.Show("Error: " + ex.Message, "AXC")
    '    End Try
    'End Sub

    Private Sub Verificacion()
        For Fila As Integer = 0 To DgvViewResultado.RowCount - 1
            'Dim Fila As Integer = DgvViewResultado.RowCount
            TipoDeSurtido = DgvViewResultado.GetRowCellValue(Fila, "TipoDeLiberacion")
            If TipoDeSurtido <> "" Then


            Else



            End If

        Next
    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        Try
            If String.IsNullOrEmpty(TxtBusqueda.Text) Then
                XtraMessageBox.Show("Ingresar un documento", "Información", MessageBoxButtons.OK)
                'LimpiarCamposOP()
                TxtBusqueda.Select()
            End If

            ActualizarDocumento(TxtBusqueda.Text)
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub CmbTipoLib_EditValueChanged(sender As Object, e As EventArgs) Handles CmbTipoLib.EditValueChanged

        'Try

        '    If String.IsNullOrEmpty(TxtBusqueda.Text) Then
        '        XtraMessageBox.Show("Favor de ingresar la orden de Prod", "Información", MessageBoxButtons.OK)
        '        TxtBusqueda.Select()
        '        Return
        '    End If

        Try
            DgvResultado.DataSource = Nothing
            'If String.IsNullOrEmpty(TxtBusqueda.Text) Then
            '    XtraMessageBox.Show("Favor de ingresar la orden de embarque", "Información", MessageBoxButtons.OK)
            '    TxtBusqueda.Select()
            '    Return
            'End If
            ''ConsultaEmbarque(TxtBusqueda.Text)
            If CmbTipoLib.Text = "TODO" Then
                ConsultaOrdenProd(TxtBusqueda.Text)
                EstableceEstacion()
                For Fila As Integer = 0 To DgvViewResultado.RowCount - 1
                    'Dim Fila As Integer = DgvViewResultado.RowCount

                    CantidadPedida = DgvViewResultado.GetRowCellValue(Fila, "CantidadPedida")
                    'DgvViewResultado.GetRowCellValue(Fila, "CantidadASurtir")
                    DgvViewResultado.SetRowCellValue(Fila, "CantidadASurtir", CantidadPedida)
                    'If CantidadPedida - CantidadASurtir = 0 Then
                    '    ESTOTAL = 2
                    '    'CantidadPedida = CantidadASurtir - CantidadPedida
                    'Else
                    '    'CantidadPedida = CantidadASurtir - CantidadPedida
                    '    ESTOTAL = 3
                    '    Exit Sub
                    'End If

                Next
            End If


        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
        Dim nuevo As New clsEmbarque

    End Sub

End Class