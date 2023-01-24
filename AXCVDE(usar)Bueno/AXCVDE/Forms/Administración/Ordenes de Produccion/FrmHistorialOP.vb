Imports DevExpress.Charts.Native
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Menu
Imports DevExpress.XtraGrid.Views.Grid

Public Class FrmHistorialOP

#Region "EVENTOS"
    Private Sub FrmMonitorOrdenesPro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim TipoBus = New List(Of String)()
        TipoBus.Add("ORDEN DE PRODUCCIÓN")
        TipoBus.Add("ARTÍCULO")
        TipoBus.Add("LOTE")
        cmbTipo.Properties.DataSource = TipoBus
        cmbTipo.ItemIndex = 0

        dtpFechaFin.EditValue = Date.Now
        dtpFechaInicio.EditValue = Date.Now
    End Sub

    Private Sub dgvViewEncabezado_MasterRowEmpty(sender As Object, e As DevExpress.XtraGrid.Views.Grid.MasterRowEmptyEventArgs) Handles dgvViewEncabezado.MasterRowEmpty

        Dim view As GridView = sender
        Dim pSeleccion = view.GetRowCellDisplayText(e.RowHandle, "OrdenProd")

        If (pSeleccion IsNot Nothing) Then
            e.IsEmpty = IsNothing(cargaOrdenesProdDet(pSeleccion))
        End If

    End Sub

    Private Sub dgvViewEncabezado_MasterRowGetChildList(sender As Object, e As DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventArgs) Handles dgvViewEncabezado.MasterRowGetChildList

        Dim view As GridView = sender
        Dim pSeleccion = view.GetRowCellDisplayText(e.RowHandle, "OrdenProd")

        If (pSeleccion IsNot Nothing) Then

            e.ChildList = cargaOrdenesProdDet(pSeleccion)
        End If
    End Sub

    Private Sub dgvViewEncabezado_MasterRowGetRelationCount(sender As Object, e As DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationCountEventArgs) Handles dgvViewEncabezado.MasterRowGetRelationCount

        e.RelationCount = 1
    End Sub

    Private Sub dgvViewEncabezado_MasterRowGetRelationName(sender As Object, e As DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationNameEventArgs) Handles dgvViewEncabezado.MasterRowGetRelationName
        e.RelationName = "DetalleOrdenesProduccion"
    End Sub

    Private Sub dgvOrdenesProduccion_Click(sender As Object, e As EventArgs) Handles dgvOrdenesProduccion.Click

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            Dim pBusqueda As String = "@"

            If String.IsNullOrEmpty(txtBusqueda.Text.Trim()) Then
                pBusqueda = "@"
            Else
                pBusqueda = txtBusqueda.Text
            End If
            cargaOrdenesProd(pBusqueda)
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
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
                Case Else

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
                    menuItemRow = New DXMenuItem("Ir a existencias", New EventHandler(AddressOf OnirExistenciasRowClick))
                    subMenu.Items.Add(menuItemRow)

                Next


            Case Else

        End Select





        Return subMenu
    End Function

    Private Function CreateMenuRows(ByVal view As GridView, ByVal rowHandle As Integer, ByVal NombreMenu As String) As DXMenuItem
        Dim Item As DXMenuItem = New DXMenuItem(NombreMenu, New EventHandler(AddressOf OnIrSurtidosRowClick))
        Item.Tag = New RowInfo(view, rowHandle)
        Return Item
    End Function


    Public Sub OnirExistenciasRowClick(ByVal sender As Object, ByVal e As EventArgs)

        Try
            Dim menuItem As DXMenuItem = TryCast(sender, DXMenuItem)
            Dim ri As RowInfo = TryCast(menuItem.Tag, RowInfo)
            Dim FrmExistencia As New FrmExistenciasGeneralVisor
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

    Public Sub cargaOrdenesProd(ByVal prmBusqueda As String)
        Try
            dgvOrdenesProduccion.DataSource = Nothing

            Dim pResultado As New CResultado
            Dim Cls As New clsOrdenProd

            Dim dInicio As New Date
            Dim dFin As New Date

            dInicio = Date.Parse(dtpFechaInicio.EditValue.ToString)
            dFin = Date.Parse(dtpFechaFin.EditValue.ToString)


            Cursor.Current = Cursors.WaitCursor
            pResultado = Cls.ListaOrdenesProduccionHistorial(cmbTipo.ItemIndex, prmBusqueda, dInicio.ToString("yyyyMMdd"), dFin.ToString("yyyyMMdd"), My.Settings.Estacion, DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                dgvOrdenesProduccion.DataSource = Nothing
                Return
            End If
            Dim dt As New DataTable
            Dim ds As New DataSet

            dt = pResultado.Tabla
            ds.Tables.Add(dt)

            If dt.Rows.Count < 1 Then
                XtraMessageBox.Show("No hay información de pedidos con los filtros seleccionados")
                dgvOrdenesProduccion.DataSource = Nothing
                Return
            End If

            dgvOrdenesProduccion.DataSource = dt

            dgvViewEncabezado.BestFitColumns()
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Function cargaOrdenesProdDet(ByVal prmBusqueda As String) As IList
        Try
            Dim pResultado As New CResultado
            Dim Cls As New clsOrdenProd


            Cursor.Current = Cursors.WaitCursor
            pResultado = Cls.ListaOrdenesProduccionMontitorDetalle(prmBusqueda, My.Settings.Estacion, DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                dgvOrdenesProduccion.DataSource = Nothing
                Return Nothing
            End If
            Dim dt As New DataTable
            Dim ds As New DataSet

            dt = pResultado.Tabla
            ds.Tables.Add(dt)

            If dt.Rows.Count < 1 Then
                Return Nothing
            End If

            Dim ListaDetalle As List(Of clsDetalleOrdenesProduccion)
            ListaDetalle = (
                        From m In dt.Rows.Cast(Of DataRow)()
                        Select New clsDetalleOrdenesProduccion With {
                            .OrdenProd = m.Field(Of String)("OrdenProd"),
                            .Articulo = m.Field(Of String)("NumParte"),
                                 .Descripcion = m.Field(Of String)("DNumParte1"),
                                 .CantidadPedida = m.Field(Of Double)("CantidadPedida"),
                                 .CantidadSurtida = m.Field(Of Double)("CantidadSurtida"),
                                 .CantidadPendiente = m.Field(Of Double)("CantidadPendiente"),
                                 .Existencia = m.Field(Of Double)("Existencia"),
                                 .Estatus = m.Field(Of String)("Estatus"),
                                 .FechaCrea = m.Field(Of DateTime)("Fecha")
                    }).ToList()


            Return ListaDetalle

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Function

    Private Sub dgvViewEncabezado_RowCellStyle(sender As Object, e As RowCellStyleEventArgs) Handles dgvViewEncabezado.RowCellStyle
        Try
            Dim Estatus As String = dgvViewEncabezado.GetRowCellValue(e.RowHandle, "Estatus")

            If e.Column.Name = "colEstatus" Then
                If Estatus = "CREADA" Then

                    e.Appearance.BackColor = Color.Green
                Else
                    ' e.Appearance.BackColor = Color.Red7
                    e.Appearance.BackColor = Color.Red
                End If
            End If

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region


End Class