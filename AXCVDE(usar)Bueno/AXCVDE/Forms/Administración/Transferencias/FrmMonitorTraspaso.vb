Imports DevExpress.Charts.Native
Imports DevExpress.LookAndFeel.Design
Imports DevExpress.Utils
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraBars
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Menu
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraPrinting.Control

Public Class FrmMonitorTraspaso
#Region "VARIABLES"
    Public BanderaLib As String = ""
    Public Property dataSetDetalle As DataSet
#End Region

#Region "EVENTOS"
    Private Sub FrmMonitorOrdenesTras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            cargarTextoGroup("7")
            cargaOrdenesTras("@", "7")
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub cargarTextoGroup(ByVal dias As String)
        Try
            Me.GroupControl2.Text = "Resultado" + " - " + dias + " Días"
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try

    End Sub

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
                    '  e.Menu.Items.Add(CreateMenuRows(view, rowHandle, "Autorizar"))
            End Select
        End If
    End Sub

    Private Function CreateSubMenuRows(ByVal view As GridView, ByVal rowHandle As Integer, ByVal NombreSubMenu As String) As DXMenuItem
        Dim subMenu As DXSubMenuItem = New DXSubMenuItem()
        Dim menuItemRow As DXMenuItem = Nothing

        Select Case NombreSubMenu
            Case "Existencias"
                subMenu.Caption = "Existencias"
                Dim pSeleccion = view.GetRowCellDisplayText(rowHandle, "Artículo")
                Dim existencias = cargaExistencias(pSeleccion)

                For Each row As DataRow In existencias.Rows
                    menuItemRow = New DXMenuItem("Existencia AXC:" & row("ExistenciaAXC"))
                    menuItemRow.Tag = New RowInfo(view, rowHandle)
                    subMenu.Items.Add(menuItemRow)
                    menuItemRow = New DXMenuItem("Existencia SAP:" & row("ExistenciaSAP"))
                    subMenu.Items.Add(menuItemRow)
                    menuItemRow = New DXMenuItem("Ir a existencias", New EventHandler(AddressOf OnirExistenciasRowClick))
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
                ' Case "Autorizar"
                '     Item = New DXMenuItem(NombreMenu, New EventHandler(AddressOf OnIrAutorizaRowClick))
        End Select
        Item.Tag = New RowInfo(view, rowHandle)

        Return Item
    End Function

    Public Sub OnirExistenciasRowClick(ByVal sender As Object, ByVal e As EventArgs)
        Try
            Dim menuItem As DXMenuItem = TryCast(sender, DXMenuItem)
            Dim ri As RowInfo = TryCast(menuItem.Tag, RowInfo)
            Dim FrmExistencia As New FrmExistenciasGeneralVisor
            FrmExistencia.pNumParte = menuItem.Tag.ToString
            FrmExistencia.MdiParent = FrmMenuPrincipal.XtraTabbedMdiManager1.MdiParent
            FrmExistencia.Show()
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub

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
            Dim ri As RowInfo = TryCast(menuItem.Tag, RowInfo)
            Dim FrmTRAS As New FrmTraspasoSalidaPT
            FrmTRAS.MdiParent = FrmMenuPrincipal.XtraTabbedMdiManager1.MdiParent
            FrmTRAS.pOrdenT = ri.View.GetRowCellDisplayText(ri.RowHandle, "Documento")
            'FrmLiberar.pNumParte = menuItem.Tag.ToString
            FrmTRAS.Show()

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub
    Public Sub OnIrAutorizaRowClick(ByVal sender As Object, ByVal e As EventArgs)
        Try
            Dim pResultado As New CResultado
            Dim Cls As New clsOrdenProd
            Dim menuItem As DXMenuItem = TryCast(sender, DXMenuItem)
            Dim ri As RowInfo = TryCast(menuItem.Tag, RowInfo)

            Cursor.Current = Cursors.WaitCursor
            pResultado = Cls.Autoriza(ri.View.GetRowCellDisplayText(ri.RowHandle, "OrdenProd"), My.settings.Estacion, DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                Return
            End If
            cargaOrdenesTras("@", "7")
            XtraMessageBox.Show("Orden de produccion Autorizada", "Información", MessageBoxButtons.OK)
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try

    End Sub

    Class RowInfo
        Public Sub New(ByVal view As GridView, ByVal rowHandle As Integer)
            Me.RowHandle = rowHandle
            Me.View = view
        End Sub

        Public View As GridView
        Public RowHandle As Integer
    End Class

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
    Private Sub FrmMonitorTraspaso_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose(True)
    End Sub
#End Region


#Region "METODOS"


    Public Function cargaExistencias(ByVal prmBusqueda As String) As DataTable
        Try
            Dim pResultado As New CResultado
            Dim Cls As New clsOrdenProd

            Cursor.Current = Cursors.WaitCursor
            pResultado = Cls.ConsultaExistencias(prmBusqueda, My.settings.Estacion, DatosTemporales.Usuario)
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

    Public Sub cargaOrdenesTras(ByVal prmBusqueda As String, ByVal prmDias As String)
        Try
            dgvOrdenesProduccion.DataSource = Nothing

            Dim pResultado As New CResultado
            Dim Cls As New clsTransfer

            Cursor.Current = Cursors.WaitCursor
            pResultado = Cls.ListaOrdenesTrasMontitor(prmDias, My.settings.Estacion, DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                dgvOrdenesProduccion.DataSource = Nothing
                Return
            End If

            Dim dtEncabezado As New DataTable
            Dim ds As New DataSet

            dtEncabezado = pResultado.Tabla
            dtEncabezado.TableName = "Encabezado"

            If dtEncabezado.Rows.Count < 1 Then
                XtraMessageBox.Show("No hay información de pedidos con los filtros seleccionados")
                dgvOrdenesProduccion.DataSource = Nothing
                Return
            End If

            ds.Tables.Add(dtEncabezado)

            pResultado = New CResultado
            Cls = New clsTransfer

            Cursor.Current = Cursors.WaitCursor
            pResultado = Cls.ListaOrdenesTrasMontitorDetalle(prmDias, My.settings.Estacion, DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                dgvOrdenesProduccion.DataSource = Nothing
                Return
            End If
            Dim dtDetalle As New DataTable

            dtDetalle = pResultado.Tabla
            dtDetalle.TableName = "Detalle"
            ds.Tables.Add(dtDetalle)

            Dim keyColumn As DataColumn = ds.Tables("Encabezado").Columns("Documento")
            Dim foreignKeyColumn As DataColumn = ds.Tables("Detalle").Columns("Documento")
            ds.Relations.Add("DetalleOrdenesTraspaso", keyColumn, foreignKeyColumn)

            dgvOrdenesProduccion.DataSource = ds.Tables("Encabezado")
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
            If dgvOrdenesProduccion.DataSource Is Nothing Then
                XtraMessageBox.Show("No hay información para exportar", "Información", MessageBoxButtons.OK)
                Return
            End If
            Dim path As String = ""
            Dim sv As New SaveFileDialog
            sv.Filter = "Excel Workbook|*.xlsx"
            If sv.ShowDialog() = DialogResult.OK And sv.FileName <> Nothing Then
                If sv.FileName.EndsWith(".xlsx") Then
                    path = sv.FileName.ToString()
                    CType(dgvOrdenesProduccion.MainView, GridView).OptionsPrint.PrintHorzLines = False
                    CType(dgvOrdenesProduccion.MainView, GridView).OptionsPrint.PrintVertLines = False
                    CType(dgvOrdenesProduccion.MainView, GridView).OptionsPrint.PrintHeader = True
                    Dim advOptions As XlsxExportOptionsEx = New XlsxExportOptionsEx()
                    advOptions.SheetName = "Partidas de orden Traspaso"
                    advOptions.ShowColumnHeaders = DevExpress.Utils.DefaultBoolean.True

                    dgvOrdenesProduccion.ExportToXlsx(path, advOptions)
                    Process.Start(path)

                End If
            End If
        End If
    End Sub

    Private Sub OnEditValueChanged(ByVal sender As System.Object, ByVal e As EventArgs)
        Dim item As New DXMenuItem()
        item = sender
        cargarTextoGroup(item.Tag)
        cargaOrdenesTras("@", item.Tag)
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

    Private Sub dgvOrdenesProduccion_ViewRegistered(sender As Object, e As DevExpress.XtraGrid.ViewOperationEventArgs) Handles dgvOrdenesProduccion.ViewRegistered
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
#End Region

End Class