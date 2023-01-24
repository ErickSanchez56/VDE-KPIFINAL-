Imports DevExpress.Utils
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraPrinting

Public Class FrmMonitorOrdenesEmbarque


#Region "Variables"
    Public BanderaLib As String = ""
    Public Presultado2 As CResultado
    Public Pagina As String
    Public Dia As New DXMenuItem()
#End Region
#Region "EVENTOS"
    Private Sub FrmMonitorOrdenesEmbarque_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Pagina = 1
            LabelControl1.Text = "Pagina" + "" + Pagina
            cargarTextoGroup("7")
            cargaOrdenesEmbarque("@", "7", TextEdit1.Text)
            Dia.Tag = 7
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub


    'Private Sub dgvViewEncabezado_MasterRowEmpty(sender As Object, e As DevExpress.XtraGrid.Views.Grid.MasterRowEmptyEventArgs) Handles dgvViewEncabezado.MasterRowEmpty

    '    Dim view As GridView = sender
    '    Dim pSeleccion = view.GetRowCellDisplayText(e.RowHandle, "OrdenEmbarque")

    '    If (pSeleccion IsNot Nothing) Then
    '        e.IsEmpty = IsNothing(cargaOrdenesEmbarqueDet(pSeleccion))
    '    End If

    'End Sub

    'Private Sub dgvViewEncabezado_MasterRowGetChildList(sender As Object, e As DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventArgs) Handles dgvViewEncabezado.MasterRowGetChildList

    '    Dim view As GridView = sender
    '    Dim pSeleccion = view.GetRowCellDisplayText(e.RowHandle, "OrdenEmbarque")

    '    If (pSeleccion IsNot Nothing) Then

    '        e.ChildList = cargaOrdenesEmbarqueDet(pSeleccion)
    '    End If
    'End Sub

    'Private Sub dgvViewEncabezado_MasterRowGetRelationCount(sender As Object, e As DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationCountEventArgs) Handles dgvViewEncabezado.MasterRowGetRelationCount

    '    e.RelationCount = 1
    'End Sub

    'Private Sub dgvViewEncabezado_MasterRowGetRelationName(sender As Object, e As DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationNameEventArgs) Handles dgvViewEncabezado.MasterRowGetRelationName
    '    e.RelationName = "DetalleOrdenes"
    'End Sub


    Private Sub dgvViewEncabezado_PopupMenuShowing(sender As Object, e As PopupMenuShowingEventArgs) Handles dgvViewEncabezado.PopupMenuShowing
        Dim view As GridView = TryCast(sender, GridView)

        If e.MenuType = GridMenuType.Row Then


            Dim rowHandle As Integer = e.HitInfo.RowHandle
            e.Menu.Items.Clear()

            Select Case e.HitInfo.Column.FieldName

                Case "TotalSurtidos"
                    e.Menu.Items.Add(CreateMenuRows(view, rowHandle, "Ver surtidos"))
                    e.Menu.Items.Add(CreateMenuRows(view, rowHandle, "Liberar"))
                Case Else
                    e.Menu.Items.Add(CreateMenuRows(view, rowHandle, "Liberar"))
            End Select



        End If
    End Sub

    Private Function CreateSubMenuRows(ByVal view As GridView, ByVal rowHandle As Integer, ByVal NombreSubMenu As String) As DXMenuItem
        Dim subMenu As DXSubMenuItem = New DXSubMenuItem()
        Dim menuItemRow As DXMenuItem = Nothing

        Select Case NombreSubMenu
            Case "Existencias"
                subMenu.Caption = "Existencias"
                Dim pSeleccion = view.GetRowCellDisplayText(rowHandle, "Articulo")
                Dim existencias = cargaExistencias(pSeleccion)

                For Each row As DataRow In existencias.Rows
                    menuItemRow = New DXMenuItem("Existencia AXC:" & row("ExistenciaAXC"))
                    menuItemRow.Tag = New RowInfo(view, rowHandle)
                    subMenu.Items.Add(menuItemRow)
                    menuItemRow = New DXMenuItem("Existencia SAP:" & row("ExistenciaSAP"))
                    subMenu.Items.Add(menuItemRow)
                    menuItemRow = New DXMenuItem("Ir a existencias", New EventHandler(AddressOf OnIrSurtidosRowClick))
                    menuItemRow.Tag = pSeleccion
                    subMenu.Items.Add(menuItemRow)
                Next
            Case Else
        End Select
        Return subMenu
    End Function

    Private Function CreateMenuRows(ByVal view As GridView, ByVal rowHandle As Integer, ByVal NombreMenu As String) As DXMenuItem
        Dim Item As DXMenuItem
        Select Case NombreMenu
            Case "Ver surtidos"
                Item = New DXMenuItem(NombreMenu, New EventHandler(AddressOf OnIrSurtidosRowClick))
            Case "Liberar"
                Item = New DXMenuItem(NombreMenu, New EventHandler(AddressOf OnIrLiberarRowClick))
            Case Else

        End Select
        Item.Tag = New RowInfo(view, rowHandle)

        Return Item
    End Function
    Class RowInfo
        Public Sub New(ByVal view As GridView, ByVal rowHandle As Integer)
            Me.RowHandle = rowHandle
            Me.View = view
        End Sub

        Public View As GridView
        Public RowHandle As Integer
    End Class
    Public Sub OnIrSurtidosRowClick(ByVal sender As Object, ByVal e As EventArgs)
        Try
            Dim menuItem As DXMenuItem = TryCast(sender, DXMenuItem)
            Dim ri As RowInfo = TryCast(menuItem.Tag, RowInfo)
            Dim FrmSurtidosDetalle As New FrmSurtidosDetalle
            FrmSurtidosDetalle.pOrdenProd = ri.View.GetRowCellDisplayText(ri.RowHandle, "OrdenProd")
            FrmSurtidosDetalle.ShowDialog()
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub
    Public Sub OnIrLiberarRowClick(ByVal sender As Object, ByVal e As EventArgs)

        Try

            Dim menuItem As DXMenuItem = TryCast(sender, DXMenuItem)
            Dim ri = TryCast(menuItem.Tag, RowInfo)
            Dim FrmLiberar As New FrmLiberaOrdenEmbarque
            FrmLiberar.MdiParent = FrmMenuPrincipal.XtraTabbedMdiManager1.MdiParent
            FrmLiberar.pOrdenEmbarque = ri.View.GetRowCellDisplayText(ri.RowHandle, "OrdenEmbarque")
            FrmLiberar.Show()
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try




    End Sub
    Private Sub dgvViewDetalle_PopupMenuShowing(sender As Object, e As PopupMenuShowingEventArgs) Handles dgvViewDetalle.PopupMenuShowing
        Dim view As GridView = TryCast(sender, GridView)

        If e.MenuType = GridMenuType.Row Then
            Dim rowHandle As Integer = e.HitInfo.RowHandle

            e.Menu.Items.Clear()
            Select Case e.HitInfo.Column.FieldName
                Case "Existencia"
                    e.Menu.Items.Add(CreateSubMenuRows(view, rowHandle, "Existencias"))
                Case "Surtidos"
                    e.Menu.Items.Add(CreateMenuRows(view, rowHandle, "Ver surtidos"))
                Case Else
            End Select
        End If
    End Sub
#End Region

#Region "METODOS"
    Public Function cargaExistencias(ByVal prmBusqueda As String) As DataTable
        Try
            Dim pResultado As New CResultado
            Dim Cls As New clsOrdenProd

            Cursor.Current = Cursors.WaitCursor
            pResultado = Cls.ConsultaExistencias(prmBusqueda, My.Settings.Estacion, DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                Return Nothing
            End If

            Dim dt As New DataTable
            Dim ds As New DataSet

            dt = pResultado.Tabla
            ds.Tables.Add(dt)

            If dt.Rows.Count < 1 Then
                Return Nothing
            End If

            Return dt

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Function

    Public Sub cargaOrdenesEmbarque(ByVal prmBusqueda As String, ByVal prmDias As String, ByVal prmOrden As String)
        Try
            dgvOrdenes.DataSource = Nothing
            Dim pBusqueda As String = "@"


            If String.IsNullOrEmpty(prmOrden.Trim()) Then
                pBusqueda = "@"
            Else
                pBusqueda = prmOrden
            End If


            Dim pResultado As New CResultado
            Dim Cls As New clsEmbarque



            Cursor.Current = Cursors.WaitCursor
            pResultado = Cls.ListaOrdenesEmbarqueMontitor(prmDias, My.Settings.Estacion, DatosTemporales.Usuario, Pagina, pBusqueda)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                dgvOrdenes.DataSource = Nothing
                Return
            End If
            'Dim dt As New DataTable
            'Dim ds As New DataSet

            'dt = pResultado.Tabla
            'ds.Tables.Add(dt)

            'If dt.Rows.Count < 1 Then
            '    XtraMessageBox.Show("No hay información de pedidos con los filtros seleccionados")
            '    dgvOrdenes.DataSource = Nothing
            '    Return
            'End If

            Dim dtEncabezado As New DataTable
            Dim ds As New DataSet

            ds = pResultado.Tablas
            dtEncabezado = ds.Tables(2)

            dtEncabezado.TableName = "Encabezado"
            'ds.Tables.Add(dtEncabezado)
            If dtEncabezado.Rows.Count < 1 Then
                XtraMessageBox.Show("No hay información de pedidos con los filtros seleccionados")
                dgvOrdenes.DataSource = Nothing
                Return
            End If

            'ds.Tables.Add(dtEncabezado)

            'pResultado = New CResultado
            'Cls = New clsEmbarque

            'Cursor.Current = Cursors.WaitCursor
            'pResultado = Cls.ListaOrdenesEmbarqueMontitorDetalle(prmDias, My.Settings.Estacion, DatosTemporales.Usuario)
            'Cursor.Current = Cursors.Default

            'If Not pResultado.Estado Then
            '    XtraMessageBox.Show(pResultado.Texto)
            '    dgvOrdenes.DataSource = Nothing
            '    Return
            'End If
            Dim dtDetalle As New DataTable

            ds = pResultado.Tablas
            dtDetalle = ds.Tables(0)
            dtDetalle.TableName = "Detalle"
            'ds.Tables.Add(dtDetalle)

            Dim keyColumn As DataColumn = ds.Tables("Encabezado").Columns("OrdenEmbarque")
            Dim foreignKeyColumn As DataColumn = ds.Tables("Detalle").Columns("OrdenEmbarque")
            ds.Relations.Add("DetalleOrdenes", keyColumn, foreignKeyColumn)

            ds.Tables.Remove("Table1")
            ds.Tables.Remove("Table3")
            dgvOrdenes.DataSource = ds.Tables("Encabezado")


            dgvViewEncabezado.BestFitColumns()




        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub dgvViewEncabezado_RowCellStyle(sender As Object, e As RowCellStyleEventArgs) Handles dgvViewEncabezado.RowCellStyle
        Try
            Dim Estatus As String = dgvViewEncabezado.GetRowCellValue(e.RowHandle, "EstatusExistencia")

            If e.Column.Name = "colEstatusExistencia" Then
                Select Case Estatus
                    Case "COMPLETO"
                        e.Appearance.BackColor = Color.Green
                    Case "INCOMPLETO"
                        e.Appearance.BackColor = Color.Orange
                    Case "SIN EXISTENCIA"
                        e.Appearance.BackColor = Color.Red
                    Case Else
                End Select
            End If

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub GroupControl2_CustomButtonClick(sender As Object, e As DevExpress.XtraBars.Docking2010.BaseButtonEventArgs) Handles GroupControl2.CustomButtonClick

        If (e.Button.Properties.Tag = "Filtro") Then
            Dim dxPopupMenu As New DXPopupMenu
            Dim p7Dias As DXMenuItem = New DXMenuItem("7 días", AddressOf OnEditValueChanged)
            p7Dias.Tag = 7
            Dim p15Dias As DXMenuItem = New DXMenuItem("15 días", AddressOf OnEditValueChanged)
            p15Dias.Tag = 15
            Dim p21Dias As DXMenuItem = New DXMenuItem("21 días", AddressOf OnEditValueChanged)
            p21Dias.Tag = 21
            Dim p31Dias As DXMenuItem = New DXMenuItem("31 días", AddressOf OnEditValueChanged)
            p31Dias.Tag = 31

            dxPopupMenu.Items.Add(p7Dias)
            dxPopupMenu.Items.Add(p15Dias)
            dxPopupMenu.Items.Add(p21Dias)
            dxPopupMenu.Items.Add(p31Dias)

            dxPopupMenu.MenuViewType = MenuViewType.Menu

            StandardExMenuManager.Default.ShowPopupMenu(dxPopupMenu, Me, GroupControl2.PointToClient(System.Windows.Forms.Control.MousePosition))

        ElseIf e.Button.Properties.Tag = "Excel" Then
            If dgvOrdenes.DataSource Is Nothing Then
                XtraMessageBox.Show("No hay información para exportar", "Información", MessageBoxButtons.OK)
                Return
            End If
            Dim path As String = ""

            Dim sv As New SaveFileDialog
            sv.Filter = "Excel Workbook|*.xlsx"
            If sv.ShowDialog() = DialogResult.OK And sv.FileName <> Nothing Then
                If sv.FileName.EndsWith(".xlsx") Then
                    path = sv.FileName.ToString()
                    ' Customize export options
                    CType(dgvOrdenes.MainView, GridView).OptionsPrint.PrintHorzLines = False
                    CType(dgvOrdenes.MainView, GridView).OptionsPrint.PrintVertLines = False
                    CType(dgvOrdenes.MainView, GridView).OptionsPrint.PrintHeader = True
                    Dim advOptions As XlsxExportOptionsEx = New XlsxExportOptionsEx()
                    'advOptions.AllowGrouping = DevExpress.Utils.DefaultBoolean.False
                    'advOptions.ShowTotalSummaries = DevExpress.Utils.DefaultBoolean.False
                    advOptions.SheetName = "Partidas de embarque"
                    advOptions.ShowColumnHeaders = DevExpress.Utils.DefaultBoolean.True

                    dgvOrdenes.ExportToXlsx(path, advOptions)
                    ' Open the created XLSX file with the default application.
                    Process.Start(path)

                End If
            End If
        End If

    End Sub

    Private Sub OnEditValueChanged(ByVal sender As System.Object, ByVal e As EventArgs)
        Dim item As New DXMenuItem()
        item = sender
        Dia = sender
        cargarTextoGroup(item.Tag)
        cargaOrdenesEmbarque("@", item.Tag, TextEdit1.Text)
    End Sub

    Private Sub dgvViewDetalle_RowCellStyle(sender As Object, e As RowCellStyleEventArgs) Handles dgvViewDetalle.RowCellStyle
        Try
            If e.Column.Name = "colEstatusExistencia" Then
                BanderaLib = e.CellValue.ToString
            End If

            If e.Column.Name = "colExistencia" Then

                Select Case BanderaLib
                    Case "COMPLETO"
                        e.Appearance.BackColor = Color.Green
                    Case "INCOMPLETO"
                        e.Appearance.BackColor = Color.Orange
                    Case "SIN EXISTENCIA"
                        e.Appearance.BackColor = Color.Red
                    Case Else
                End Select
            End If

            If e.Column.Name = "colEstatusExistencia" Then
                Select Case BanderaLib
                    Case "COMPLETO"
                        e.Appearance.BackColor = Color.Green
                    Case "INCOMPLETO"
                        e.Appearance.BackColor = Color.Orange
                    Case "SIN EXISTENCIA"
                        e.Appearance.BackColor = Color.Red
                    Case Else
                End Select

                BanderaLib = ""
            End If
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub dgvOrdenes_ViewRegistered(sender As Object, e As DevExpress.XtraGrid.ViewOperationEventArgs) Handles dgvOrdenes.ViewRegistered
        Dim View As GridView = e.View
        View.BestFitColumns()
    End Sub

    Private Sub dgvViewDetalle_CustomRowCellEdit(sender As Object, e As CustomRowCellEditEventArgs) Handles dgvViewDetalle.CustomRowCellEdit



        If e.Column.FieldName = "PorcentajeAvance" Then
            Dim rp As RepositoryItemProgressBar = New RepositoryItemProgressBar()

            rp.ProgressViewStyle = DevExpress.XtraEditors.Controls.ProgressViewStyle.Broken
            rp.ShowTitle = True
            rp.PercentView = False
            rp.DisplayFormat.FormatType = FormatType.Numeric
            rp.DisplayFormat.FormatString = "{0:n2}%"
            rp.Minimum = 0
            rp.Maximum = 100
            rp.LookAndFeel.UseDefaultLookAndFeel = False
            rp.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
            rp.StartColor = Color.Green
            rp.EndColor = Color.DarkGreen
            e.RepositoryItem = rp
        End If
    End Sub

    Private Sub cargarTextoGroup(ByVal dias As String)
        Try
            Me.GroupControl2.Text = "Resultado" + " - " + dias + " Días"
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Pagina = Pagina + 1
        cargaOrdenesEmbarque("@", Dia.Tag, TextEdit1.Text)
        LabelControl1.Text = "Pagina" + "" + Pagina
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        If Pagina > 1 Then
            Pagina = Pagina - 1
        End If
        cargaOrdenesEmbarque("@", Dia.Tag, TextEdit1.Text)
        LabelControl1.Text = "Pagina" + "" + Pagina
    End Sub

    Private Sub TextEdit1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextEdit1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                'CmbTipoLib.ItemIndex = 0


                If String.IsNullOrEmpty(TextEdit1.Text) Then
                    XtraMessageBox.Show("Favor de ingresar la orden de embarque", "Información", MessageBoxButtons.OK)
                    TextEdit1.Select()
                    'CmbTipoLib.EditValue = ""
                    Return
                End If

                cargaOrdenesEmbarque("@", Dia.Tag, TextEdit1.Text)



            Catch ex As Exception
                XtraMessageBox.Show(ex.Message)
            End Try

        End If
    End Sub




#End Region

End Class