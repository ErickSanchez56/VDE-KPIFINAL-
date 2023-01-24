Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid.Views.Grid


Public Class FrmLiberaOrdenEmbarque

#Region "VARIABLES"
    Public pLote As String
    Public pEstacion As String
    Public pNumParteDet As String
    Public pOrdenEmbarque As String
    Private TipoLib As New List(Of Tipo)()
    Private TipoLib1 As New List(Of Tipo)()
    Private TipoLib2 As New List(Of Tipo)()
    Private ESTOTAL As Integer
    Private CantidadASurtir As Double
    Private CantidadPedida As Double
    Private TipoDeSurtido As Integer
    Public Class Tipo
        Public Property TipoLiberacion() As String
        Public Property TipoLibID() As Integer
    End Class
#End Region

    Private Sub AgregarPartida()
        Try
            Dim pResultado As New CResultado
            Dim Cls As New clsEmbarque

            Dim pPartida As Integer
            Dim pCantidad As Double
            Dim pCantidadPendiente As Double
            Dim view As ColumnView = CType(DgvResultado.MainView, ColumnView)
            Dim selectedRowHandles As Integer() = view.GetSelectedRows()

            pPartida = view.GetRowCellDisplayText(selectedRowHandles(0), view.Columns("Partida"))
            pCantidad = view.GetRowCellDisplayText(selectedRowHandles(0), view.Columns("CantidadASurtir"))
            pCantidadPendiente = view.GetRowCellDisplayText(selectedRowHandles(0), view.Columns("CantidadPendiente"))
            Cursor.Current = Cursors.WaitCursor
            CmbEsta.Text.Split("-")
            If CmbTipoLib.Text = "PICKING" Then
                pResultado = Cls.AgregarPartida(TxtBusqueda.Text, pPartida, pCantidad, pCantidadPendiente, CmbEsta.Text, My.Settings.Estacion, CmbT.Text, DatosTemporales.Usuario)
            ElseIf CmbTipoLib.Text = "PALLET" Then
                pResultado = Cls.AgregarPartida(TxtBusqueda.Text, pPartida, pCantidad, pCantidadPendiente, CmbEst2.Text, My.Settings.Estacion, CmbT2.Text, DatosTemporales.Usuario)
            End If


            Cursor.Current = Cursors.Default


            Dim dt As New DataTable
            Dim ds As New DataSet

            dt = pResultado.Tabla
            ds.Tables.Add(dt)

            If dt.Rows.Count < 1 Then
                XtraMessageBox.Show("No hay partidas en la orden de embarque")
                DgvResultado.DataSource = Nothing
                Return
            End If
            GridControl1.DataSource = dt

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                Return
            End If


        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub ListaPartidasPedido(prmBusqueda As String)
        Try
            GridControl1.DataSource = Nothing

            Dim pResultado As New CResultado
            Dim Cls As New clsEmbarque

            Cursor.Current = Cursors.WaitCursor
            pResultado = Cls.ListarPrevioPedido(prmBusqueda, My.Settings.Estacion, DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                GridControl1.DataSource = Nothing
                Return
            End If
            Dim dt As New DataTable
            Dim ds As New DataSet

            dt = pResultado.Tabla
            ds.Tables.Add(dt)

            If dt.Rows.Count < 1 Then
                XtraMessageBox.Show("No hay partidas agregadas al pedido")
                GridControl1.DataSource = Nothing
                Return
            End If

            GridControl1.DataSource = dt

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub FrmLiberaOrdenEmbarque_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
                DgvViewResultado.Columns("Estacion").Visible = True
                GridView1.Columns("Estacion").Visible = True
                GridView1.Columns("TipoSurtido").Visible = False
                GridView1.Columns("EstacionPicking").Visible = False
                GridView1.Columns("EstacionPallet").Visible = False
                GridView1.Columns("TipoSurtido1").Visible = False
                CmbEstacion.Enabled = True
                EstableceEstacion()
            Else
                DgvViewResultado.Columns("Estacion").Visible = True
                GridView1.Columns("Estacion").Visible = True
                CmbEstacion.Enabled = False
                EstableceEstacion()
            End If




            If Not String.IsNullOrEmpty(pOrdenEmbarque) Then
                TxtBusqueda.Text = pOrdenEmbarque
                ConsultaEmbarque(pOrdenEmbarque)
            End If
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub BtnLiberar_Click(sender As Object, e As EventArgs) Handles BtnLiberar.Click
        Try
            If XtraMessageBox.Show("¿Liberar Embarque?", "AXC", MessageBoxButtons.YesNo) <> DialogResult.Yes Then
                Return
            End If

            For Fila As Integer = 0 To DgvViewResultado.RowCount - 1
                If DgvViewResultado.GetRowCellValue(Fila, "CantidadASurtir") <> 0 Then
                    LiberarEmbarque()
                    Exit For
                Else
                    XtraMessageBox.Show("La orden NO se puede Liberar en 0")
                    Return
                End If
            Next


            ''ConsultaEmbarqueFiltro(TxtBusqueda.Text, CmbTipoLib.Text)
            DgvResultado.DataSource = Nothing
            DgvResultado.Refresh()

            Limpiar()
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try


    End Sub

    Public Sub LiberarEmbarque()
        Try

            Dim iLote As Integer = 0
            Dim iCant As Integer = 0
            Dim pValidacionLote As Integer



            If CmbTipoLib.Text = "TODO" Then
                If DgvViewResultado.RowCount <= 0 Then
                    XtraMessageBox.Show("No hay detalle de orden de embarque", "Error", MessageBoxButtons.OK)
                    CmbTipoLib.ResetText()
                    Return
                End If




                If String.IsNullOrEmpty(CmbEstacion.Text) Then
                    XtraMessageBox.Show("Seleccionar una opción en el listado de Estaciones", "Información", MessageBoxButtons.OK)
                    CmbTipoLib.ResetText()
                    Return
                End If
            End If

            'If String.IsNullOrEmpty(CmbTipoLib.Text) Then
            '    XtraMessageBox.Show("Seleccionar un tipo de liberado", "Información", MessageBoxButtons.OK)
            '    CmbTipoLib.ResetText()
            '    Return
            'End If


            'If CmbTipoLib.Text <> "TODO" Then
            '    '' XtraMessageBox.Show("Seleccionar un tipo de liberado", "Información", MessageBoxButtons.OK)
            '    ''CmbTipoLib.ResetText()
            '    DgvResultado.DataSource = Nothing
            '    Return
            'End If

            For Fila As Integer = 0 To DgvViewResultado.RowCount - 1
                'Dim Fila As Integer = DgvViewResultado.RowCount
                If DgvViewResultado.GetRowCellValue(Fila, "CantidadASurtir") = 0 Then
                    XtraMessageBox.Show("Ingresa una cantidad a Suritir", "Información", MessageBoxButtons.OK)
                    CmbTipoLib.ResetText()
                    Return
                End If
            Next




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
            '        CmbTipoLib.ResetText()
            '        Return
            '    End If
            '    If iLote <> iCant Then
            '        XtraMessageBox.Show("Hay partidas sin revisión de existencias", "Error", MessageBoxButtons.OK)
            '        CmbTipoLib.ResetText()
            '        Return
            '    End If

            '    pValidacionLote = 1
            'Else
            '    pValidacionLote = 0
            'End If
            EstableceEstacion()

            Dim ds As New DataSet
            Dim dt As New DataTable

            If CmbTipoLib.Text = "TODO" Then
                dt = TryCast(DgvResultado.DataSource, DataTable)
                ds.Tables.Add(dt.Copy)

            Else
                dt = TryCast(GridControl1.DataSource, DataTable)
                ds.Tables.Add(dt.Copy)


            End If


            Dim pResultado As New CResultado
            Dim Cls As New clsEmbarque

            Conteo()

            If CmbTipoLib.Text <> "TODO" Then
                pResultado = Cls.LiberaxPartidaOrdenEmbarque(pValidacionLote, TxtBusqueda.Text, dt.DataSet.GetXml, "", My.Settings("Estacion"), DatosTemporales.Usuario, "TODO", ESTOTAL, CantidadPedida, CantidadASurtir, CmbEsta.Text, CmbT.Text, CmbEst2.Text, CmbT2.Text)

            Else
                pResultado = Cls.LiberaOrdenEmbarque(pValidacionLote, TxtBusqueda.Text, dt.DataSet.GetXml, "", My.Settings("Estacion"), DatosTemporales.Usuario, "TODO", ESTOTAL, CantidadPedida, CantidadASurtir)
            End If

            'For Fila As Integer = 0 To DgvViewResultado.RowCount + 1
            '    If DgvViewResultado.GetRowCellValue(Fila, "Estatus") = "LIBERADA TOTAL" Then
            '        Cursor.Current = Cursors.WaitCursor
            '        pResultado = Cls.LiberaOrdenEmbarque(pValidacionLote, TxtBusqueda.Text, dt.DataSet.GetXml, txtGuia.Text, My.Settings("Estacion"), DatosTemporales.Usuario, CmbTipoLib.Text, ESTOTAL, CantidadPedida, CantidadASurtir)
            '        Cursor.Current = Cursors.Default
            '        Exit For
            '    Else
            '        XtraMessageBox.Show("Orden de embarque ya ha sido liberada", "Información", MessageBoxButtons.OK)
            '        Return
            '        Exit For
            '    End If
            'Next
            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                Return
            End If

            XtraMessageBox.Show("Orden de embarque liberada", "Información", MessageBoxButtons.OK)



        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub EliminarPartida(ByVal prmPedido As String)
        Try
            Dim pResultado As New CResultado
            Dim Cls As New clsEmbarque

            Dim pPartida As Integer
            Dim pCantidad As Double
            Dim pCantidadPendiente As Double
            Dim pOrden As String = ""
            Dim pTsurtido As String = ""
            Dim pTsurtido1 As String = ""
            Dim EstacionPick As String
            Dim EstacionPall As String
            Dim view As ColumnView = CType(GridControl1.MainView, ColumnView)
            Dim view2 As ColumnView = CType(DgvResultado.MainView, ColumnView)
            Dim selectedRowHandles As Integer() = view.GetSelectedRows()

            pPartida = view.GetRowCellDisplayText(selectedRowHandles(0), view.Columns("Partida"))
            pCantidad = view.GetRowCellDisplayText(selectedRowHandles(0), view.Columns("CantidadASurtir"))



            pTsurtido = view.GetRowCellDisplayText(selectedRowHandles(0), view.Columns("TipoSurtido"))
            EstacionPick = view.GetRowCellDisplayText(selectedRowHandles(0), view.Columns("EstacionPicking"))

            pTsurtido1 = view.GetRowCellDisplayText(selectedRowHandles(0), view.Columns("TipoSurtido1"))
            EstacionPall = view.GetRowCellDisplayText(selectedRowHandles(0), view.Columns("EstacionPallet"))
            pCantidadPendiente = view.GetRowCellDisplayText(selectedRowHandles(0), view2.Columns("CantidadPendiente"))
            pOrden = TxtBusqueda.Text ''view.GetRowCellDisplayText(selectedRowHandles(0), view.Columns("OrdenEmbarque"))

            Cursor.Current = Cursors.WaitCursor
            pResultado = Cls.EliminarPartida(pOrden, pPartida, prmPedido, pCantidad, pCantidadPendiente, pTsurtido, EstacionPick, pTsurtido1, EstacionPall, My.Settings.Estacion, DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                Return
            End If


        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Try
            'CmbTipoLib.ItemIndex = 0


            If String.IsNullOrEmpty(TxtBusqueda.Text) Then
                XtraMessageBox.Show("Favor de ingresar la orden de embarque", "Información", MessageBoxButtons.OK)
                TxtBusqueda.Select()
                CmbTipoLib.EditValue = ""
                Return
            End If

            ConsultaEmbarque(TxtBusqueda.Text)
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
            If CantidadPedida - CantidadASurtir = 0 Then
                ESTOTAL = 2
                'CantidadPedida = CantidadASurtir - CantidadPedida
            Else
                'CantidadPedida = CantidadASurtir - CantidadPedida
                ESTOTAL = 3
                Exit Sub
            End If

        Next
    End Sub
    Private Sub ConsultaEmbarque(prmBusqueda As String)
        Try
            DgvResultado.DataSource = Nothing

            Dim pResultado As New CResultado
            Dim Cls As New clsEmbarque

            Cursor.Current = Cursors.WaitCursor
            pResultado = Cls.ConsultaOrdenEmbarque(prmBusqueda)
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
                XtraMessageBox.Show("No hay partidas en la orden de embarque")
                DgvResultado.DataSource = Nothing
                Return
            End If
            DgvResultado.DataSource = dt
            Dim _riEditor As New RepositoryItemComboBox()
            _riEditor.Items.AddRange(New String() {"TODO", "PALLET", "PICKING"})
            DgvResultado.RepositoryItems.Add(_riEditor)
            DgvViewResultado.Columns(7).ColumnEdit = _riEditor

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
    Private Sub ConsultaEmbarqueFiltro(prmBusqueda As String, prmTipo As String)
        Try
            DgvResultado.DataSource = Nothing

            Dim pResultado As New CResultado
            Dim Cls As New clsEmbarque

            Cursor.Current = Cursors.WaitCursor
            pResultado = Cls.ConsultaOrdenEmbarqueFiltro(prmBusqueda, prmTipo)
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
                XtraMessageBox.Show("No hay partidas en la orden de embarque")
                DgvResultado.DataSource = Nothing
                Return
            End If
            DgvResultado.DataSource = dt
            Dim _riEditor As New RepositoryItemComboBox()
            _riEditor.Items.AddRange(New String() {"TODO", "PALLET", "PICKING"})
            DgvResultado.RepositoryItems.Add(_riEditor)
            DgvViewResultado.Columns(7).ColumnEdit = _riEditor

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

            CmbEst2.Properties.ValueMember = "Estacion"
            CmbEst2.Properties.DisplayMember = "Estacion"
            CmbEst2.Properties.DataSource = dt

            CmbEsta.Properties.ValueMember = "Estacion"
            CmbEsta.Properties.DisplayMember = "Estacion"
            CmbEsta.Properties.DataSource = dt

            'Dim TipoLiberacion() As String = {"PALLET", "EMPAQUE", "PACKING"}
            TipoLib.Add(New Tipo() With {.TipoLiberacion = "TODO", .TipoLibID = 1})
            'TipoLib.Add(New Tipo() With {.TipoLiberacion = "PALLET", .TipoLibID = 2})
            'TipoLib.Add(New Tipo() With {.TipoLiberacion = "PICKING", .TipoLibID = 3})
            'CmbTipoLib.Properties.NullText = "Tipo De Liberacion"
            CmbTipoLib.Properties.ValueMember = "TipoLiberacion"
            CmbTipoLib.Properties.DisplayMember = "TipoLiberacion"
            CmbTipoLib.Properties.DataSource = TipoLib



            TipoLib1.Add(New Tipo() With {.TipoLiberacion = "PICKING", .TipoLibID = 1})

            'CmbT.Properties.NullText = "Tipo De Liberacion"
            CmbT.Properties.ValueMember = "TipoLiberacion"
            CmbT.Properties.DisplayMember = "TipoLiberacion"
            CmbT.Properties.DataSource = TipoLib1



            TipoLib2.Add(New Tipo() With {.TipoLiberacion = "PALLET", .TipoLibID = 1})


            'CmbT2.Properties.NullText = "Tipo De Liberacion"
            CmbT2.Properties.ValueMember = "TipoLiberacion"
            CmbT2.Properties.DisplayMember = "TipoLiberacion"
            CmbT2.Properties.DataSource = TipoLib2



        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ChkEstacion_CheckedChanged(sender As Object, e As EventArgs) Handles ChkEstacion.CheckedChanged
        Try
            If ChkEstacion.Checked Then
                'DgvViewResultado.Columns("Estacion").Visible = False
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
        Dim view2 As ColumnView = CType(GridControl1.MainView, ColumnView)
        If ChkEstacion.Checked Then
            pEstacion = CmbEstacion.Text
            Dim ArrCadena As String() = pEstacion.Split("/")
            For i As Integer = 0 To view.RowCount - 1

                view2.SetRowCellValue(i, "Estacion", ArrCadena(0))

            Next
            GridView1.RefreshData()
            GridControl1.Refresh()
        Else
            pEstacion = "TODOS"
            For i As Integer = 0 To view2.RowCount - 1

                view2.SetRowCellValue(i, "Estacion", "")
            Next
            GridView1.RefreshData()
            GridControl1.Refresh()
        End If



    End Sub



    Private Sub DgvViewResultado_DoubleClick(sender As Object, e As EventArgs) Handles DgvViewResultado.DoubleClick
        Try


            Dim view As ColumnView = CType(DgvResultado.MainView, ColumnView)

            Dim selectedRowHandles As Integer() = view.GetSelectedRows


            pNumParteDet = view.GetRowCellValue(selectedRowHandles(0), "NumParte").ToString
            pLote = view.GetRowCellValue(selectedRowHandles(0), "Lote").ToString
            pOrdenEmbarque = TxtBusqueda.Text
            FrmModificaPartida.pOrdenEmbarque = pOrdenEmbarque
            FrmModificaPartida.pNumParte = pNumParteDet
            FrmModificaPartida.pLote = pLote
            FrmModificaPartida.pEstacion = pEstacion
            'FrmModificaPartida.chkLote = ChkLote.CheckState
            FrmModificaPartida.ShowDialog()

            view.SetRowCellValue(selectedRowHandles(0), "Lote", pLote)
            view.SetRowCellValue(selectedRowHandles(0), "Estacion", pEstacion)
            DgvViewResultado.RefreshData()
            DgvResultado.Refresh()
            ConsultaEmbarque(TxtBusqueda.Text)
            Dim pResultado As New CResultado
            Dim Cls As New clsEmbarque

            'If XtraMessageBox.Show("¿Desea Actualizar la estacion??", "AXC", MessageBoxButtons.YesNo) <> DialogResult.Yes Then
            '    Return
            'End If
            'If CmbTipoLib.Text = "TODO" Then
            '    Cursor.Current = Cursors.WaitCursor
            '    Dim Estacion As String() = pEstacion.Split("/")
            '    pResultado = Cls.ActualizaEstacion(Estacion(0), TxtBusqueda.Text)
            '    Cursor.Current = Cursors.Default
            'End If

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

    Private Sub FrmLiberaOrdenEmbarque_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose(True)
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

    Private Sub CmbTipoLib_EditValueChanged(sender As Object, e As EventArgs) Handles CmbTipoLib.EditValueChanged

        Try
            DgvResultado.DataSource = Nothing

            'If String.IsNullOrEmpty(TxtBusqueda.Text) Then
            '    XtraMessageBox.Show("Favor de ingresar la orden de embarque", "Información", MessageBoxButtons.OK)
            '    TxtBusqueda.Select()
            '    Return
            'End If
            ''ConsultaEmbarque(TxtBusqueda.Text)
            If CmbTipoLib.Text = "TODO" Then
                ConsultaEmbarque(TxtBusqueda.Text)
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
            If CmbTipoLib.Text = "TODO" Then
                BtnElimina.Visible = False
                BtnAgregar.Visible = False
                GridControl1.Visible = False
                CmbEstacion.Enabled = True
                lblTipolib.Visible = False
                lblTipolib2.Visible = False
                lblEstacion.Visible = False
                lblEstacion2.Visible = False
                CmbT.Visible = False
                CmbT2.Visible = False
                CmbEsta.Visible = False
                CmbEst2.Visible = False




            ElseIf CmbTipoLib.Text = "PICKING" Or CmbTipoLib.Text = "PALLET" Then
                GridControl1.Visible = True
                ConsultaEmbarqueFiltro(TxtBusqueda.Text, CmbTipoLib.Text)
                ListaPartidasPedido(TxtBusqueda.Text)
                lblTipolib.Visible = True
                lblTipolib2.Visible = True
                lblEstacion.Visible = True
                lblEstacion2.Visible = True
                'CmbEstacion.Text = "TODO"
                CmbEstacion.Enabled = False
                BtnElimina.Visible = True
                BtnAgregar.Visible = True
                CmbT.Visible = True
                CmbT2.Visible = True
                CmbEsta.Visible = True
                CmbEst2.Visible = True
            End If


            If CmbTipoLib.Text = "PICKING" Then
                CmbT2.EditValue = ""
                CmbT2.Enabled = False
                CmbEst2.EditValue = ""
                CmbEst2.Enabled = False

            Else
                CmbT2.EditValue = ""
                CmbT2.Enabled = True
                CmbEst2.EditValue = ""
                CmbEst2.Enabled = True
            End If

            If CmbTipoLib.Text = "PALLET" Then
                CmbT.EditValue = ""
                CmbT.Enabled = False
                CmbEsta.EditValue = ""
                CmbEsta.Enabled = False
            Else
                CmbT.EditValue = ""
                CmbT.Enabled = True
                CmbEsta.EditValue = ""
                CmbEsta.Enabled = True
            End If
            Dim ds As New DataSet
            Dim dt As New DataTable
            dt = TryCast(DgvResultado.DataSource, DataTable)
            ds.Tables.Add(dt.Copy)


            Dim pResultado As New CResultado
            Dim Cls As New clsEmbarque



            Cursor.Current = Cursors.WaitCursor
            pResultado = Cls.Filtro(TxtBusqueda.Text, My.Settings("Estacion"), DatosTemporales.Usuario, CmbTipoLib.Text, CantidadPedida, CantidadASurtir)
            Cursor.Current = Cursors.Default



        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
        Dim nuevo As New clsEmbarque

    End Sub
    Private Sub Limpiar()
        CmbEsta.EditValue = ""
        CmbEst2.EditValue = ""
        CmbT.EditValue = ""
        CmbT2.EditValue = ""
        'CmbTipoLib.EditValue = ""
        CmbEstacion.EditValue = ""
    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        Try
            'If String.IsNullOrEmpty() Then
            '    XtraMessageBox.Show("No se pueden agregar partidas sin antes haber generado un nuevo pedido", "Información", MessageBoxButtons.OK)
            '    Return
            'End If

            If DgvViewResultado.RowCount <= 0 Then
                XtraMessageBox.Show("No hay detalle de documento. Buscar un documento válido.", "Información", MessageBoxButtons.OK)
                TxtBusqueda.Select()
                Return
            End If


            If CmbTipoLib.Text = "PICKING" Then
                If CmbT.Text = "" Then
                    XtraMessageBox.Show("Porfavor seleccione un Tipo de Liberacion para la partida", "Información", MessageBoxButtons.OK)
                    CmbT.Select()
                    Return
                End If
                If CmbEsta.Text = "" Then
                    XtraMessageBox.Show("Porfavor seleccione la estacion a asignar  ", "Información", MessageBoxButtons.OK)
                    CmbEsta.Select()
                    Return
                End If
            End If

            If CmbTipoLib.Text = "PALLET" Then
                If CmbT2.Text = "" Then
                    XtraMessageBox.Show("Porfavor seleccione un Tipo de Liberacion para la partida", "Información", MessageBoxButtons.OK)
                    CmbT2.Select()
                    Return
                End If
                If CmbEst2.Text = "" Then
                    XtraMessageBox.Show("Porfavor seleccione la estacion a asignar  ", "Información", MessageBoxButtons.OK)
                    CmbEst2.Select()
                    Return
                End If
            End If

            AgregarPartida()
            'CargarOrdenDeVenta(LblPedidoVenta.Text, LblNumPedido.Text)
            ListaPartidasPedido(TxtBusqueda.Text)
            'ListatotalPedido(LblNumPedido.Text)
            Limpiar()
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
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

    Private Sub ActualizarDocumento(prmDocumento As String)
        Try
            Dim pResultado As New CResultado
            Dim Cls As New clsEmbarque

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
    Private Sub BtnElimina_Click(sender As Object, e As EventArgs) Handles BtnElimina.Click
        Try
            If String.IsNullOrEmpty(TxtBusqueda.Text) Then
                XtraMessageBox.Show("No se pueden eliminar partidas sin antes haber generado un nuevo pedido", "Información", MessageBoxButtons.OK)
                Return
            End If

            If GridView1.RowCount <= 0 Then
                XtraMessageBox.Show("No hay partidas en este pedido. Agregar partidas de órdenes de embarque ", "Información", MessageBoxButtons.OK)
                TxtBusqueda.Select()
                Return
            End If

            EliminarPartida(TxtBusqueda.Text)
            ListaPartidasPedido(TxtBusqueda.Text)
            Limpiar()
            'CargarOrdenDeVenta(LblPedidoVenta.Text, LblNumPedido.Text)
            'ListaPartidasPedido(LblNumPedido.Text)
            'ListatotalPedido(LblNumPedido.Text)
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub

    Private Sub TxtBusqueda_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtBusqueda.KeyDown

        If e.KeyCode = Keys.Enter Then
            Try
                'CmbTipoLib.ItemIndex = 0


                If String.IsNullOrEmpty(TxtBusqueda.Text) Then
                    XtraMessageBox.Show("Favor de ingresar la orden de embarque", "Información", MessageBoxButtons.OK)
                    TxtBusqueda.Select()
                    'CmbTipoLib.EditValue = ""
                    Return
                End If

                ConsultaEmbarque(TxtBusqueda.Text)
                EstableceEstacion()


            Catch ex As Exception
                XtraMessageBox.Show(ex.Message)
            End Try

        End If
    End Sub

    Private Sub TxtBusqueda_EditValueChanged(sender As Object, e As EventArgs) Handles TxtBusqueda.EditValueChanged

    End Sub

    Private Sub txtEstacion(sender As Object, e As KeyPressEventArgs) Handles CmbEstacion.KeyPress
        Try
            If e.KeyChar = Convert.ToChar(Keys.Return) Then
                CmbTipoLib.Select()
            End If
        Catch ex As Exception
            XtraMessageBox.Show("Error: " + ex.Message, "AXC")
        End Try
    End Sub

    Private Sub txtEmbarque(sender As Object, e As KeyPressEventArgs) Handles TxtBusqueda.KeyPress
        Try
            If e.KeyChar = Convert.ToChar(Keys.Return) Then
                CmbEstacion.Select()
            End If
        Catch ex As Exception
            XtraMessageBox.Show("Error: " + ex.Message, "AXC")
        End Try
    End Sub

    Private Sub txtLiberacion1(sender As Object, e As KeyPressEventArgs) Handles CmbTipoLib.KeyPress
        Try
            If e.KeyChar = Convert.ToChar(Keys.Return) Then
                BtnLiberar.Select()
            End If
        Catch ex As Exception
            XtraMessageBox.Show("Error: " + ex.Message, "AXC")
        End Try
    End Sub

    Private Sub txtLiberacion2(sender As Object, e As KeyPressEventArgs) Handles CmbT.KeyPress

    End Sub

    Private Sub txtLiberacion3(sender As Object, e As KeyPressEventArgs) Handles CmbT2.KeyPress

    End Sub

End Class