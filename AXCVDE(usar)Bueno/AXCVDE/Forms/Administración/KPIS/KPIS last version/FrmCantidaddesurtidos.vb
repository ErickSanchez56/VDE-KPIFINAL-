Imports DevExpress.XtraCharts
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.Utils
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraPrinting

Public Class FrmCantidaddesurtidos
    Public Dia As New DXMenuItem()
    Public ds As DataSet
    Public ds2 As DataSet
    Public fechainicio As String
    Public fechafin As String
    Dim tablaGlobalOrdenesEmbarcadas As DataTable
    Dim tablaGlobalOrdenesEmbarcadasPromedio As DataTable
    Dim tablaGlobalOrdenesEmbarcadasGeneral As DataTable
    Private Sub FrmOrdenEmbarqueKpi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dias = 7
        dtpFechaInicio.EditValue = Date.Parse(DateAdd(DateInterval.Day, -7, Today))
        dtpFechaFin.EditValue = Date.Parse(Today)
        'llenarGraficaOrdenesCompletasEmbarcadas(Date.Parse(Today), Date.Parse(Today), dias)
        ResultadoLista6("", Date.Parse(Today), Date.Parse(Today), dias)

    End Sub
    Private Sub OnEditValueChanged(ByVal sender As System.Object, ByVal e As EventArgs)
        Dim item As New DXMenuItem()
        item = sender
        Dia = sender
        llenar(item.Tag)
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Dim prmBusqueda2 As String
        Dim prmBusqueda3 As String



        If String.IsNullOrEmpty(dtpFechaInicio.Text) Then
            prmBusqueda2 = "@"
        Else
            prmBusqueda2 = dtpFechaInicio.Text
        End If
        Dim fecha As New Date
        fecha = Date.Parse(dtpFechaInicio.EditValue.ToString)
        'ResultadoLista(prmBusqueda2, fecha)



        If String.IsNullOrEmpty(dtpFechaFin.Text) Then
            prmBusqueda3 = "@"
        Else
            prmBusqueda3 = dtpFechaFin.Text
        End If
        Dim fecha2 As New Date
        fecha2 = Date.Parse(dtpFechaFin.EditValue.ToString)

        'llenarGraficaOrdenesCompletasEmbarcadas(fecha, fecha2, 0)
        ResultadoLista6("", fecha, fecha2, 0)



    End Sub
    Private Sub llenar(ByVal dias As String)

        'llenarGraficaOrdenesCompletasEmbarcadas(Date.Parse(Today), Date.Parse(Today), dias)
        ResultadoLista6("", Date.Parse(Today), Date.Parse(Today), dias)


    End Sub
    Private Sub llenarGraficaOrdenesCompletasEmbarcadas(prmBusqueda2 As Date, prmBusqueda3 As Date, dias As String)
        Try
            Dim objKPI As New ClsKPIEMB
            Dim resultado = objKPI.KPIOrdenesCompletasEmbarcadas(IIf(String.IsNullOrEmpty(prmBusqueda2), dias, prmBusqueda2), IIf(String.IsNullOrEmpty(prmBusqueda3), Date.Parse(Today), prmBusqueda3), dias, My.Settings.Estacion, DatosTemporales.Usuario)
            If Not resultado.Estado Then
                XtraMessageBox.Show(resultado.Texto, "AXC")
                Return
            End If
            Dim tablaPromedio = resultado.Tablas.Tables(1)
            Dim tablaGeneral = resultado.Tablas.Tables(2)
            tablaGlobalOrdenesEmbarcadasPromedio = tablaPromedio
            tablaGlobalOrdenesEmbarcadasGeneral = tablaPromedio
            If tablaPromedio.Rows.Count > 0 Then
                Dim row As DataRow = tablaPromedio.Rows(0)
                If IsDBNull(row.Item("PorcentajeEmbarcadas")) Then
                Else
                    ' ArcScaleComponent4.Value = row.Item("PorcentajeEmbarcadas")
                    '  LabelComponent4.Text = row.Item("PorcentajeEmbarcadas").ToString
                End If
            End If
            'CARGA GAUGE PAGINA EMBARCADAS
            If tablaPromedio.Rows.Count > 0 Then
                Dim row As DataRow = tablaPromedio.Rows(0)
                If IsDBNull(row.Item("PorcentajeEmbarcadas")) Then
                Else
                    '    ArcScaleComponent9.Value = row.Item("PorcentajeEmbarcadas")
                    ' LabelComponent17.Text = row.Item("PorcentajeEmbarcadas").ToString
                End If
            End If
            'If tablaPromedio.Rows.Count > 0 And tablaGeneral.Rows.Count > 0 Then
            '    llenarGraficasPestañaEmbarques(tablaPromedio, tablaGeneral)
            'Else
            'End If
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub
    Private Sub ResultadoLista6(prmBusqueda As String, prmBusqueda2 As Date, prmBusqueda3 As Date, dias As String)
        Try
            Dim pResultado As New CResultado
            Dim Cls As New ClsKPIEMB
            Dim dt As New DataTable
            Cursor.Current = Cursors.WaitCursor
            pResultado = Cls.TiempoSurtido(prmBusqueda, prmBusqueda2, prmBusqueda3, dias, My.Settings.Estacion, DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default
            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                'GridControl3.DataSource = Nothing
                Return
            End If
            Dim ds As New DataSet
            dt = pResultado.Tabla
            ds.Tables.Add(dt)
            Dim tablaPromedioTodo As DataTable
            Dim tablaPromedioDetalle As DataTable
            Dim tablaCantidadOrdenes As DataTable
            Dim tablaDetallePallet As DataTable
            ' Dim tablaMym As DataTable
            tablaPromedioTodo = pResultado.Tablas.Tables(1)
            tablaDetallePallet = pResultado.Tablas.Tables(2)
            tablaPromedioDetalle = pResultado.Tablas.Tables(3)
            tablaCantidadOrdenes = pResultado.Tablas.Tables(4)
            ''tablaDetallePallet = pResultado.Tablas.Tables(5)
            'tablaMym = pResultado.Tablas.Tables(2)
            If dt.Rows.Count < 1 Then
                XtraMessageBox.Show("Sin información en el sistema", "AXC", MessageBoxButtons.OK)
                'GridControl3.DataSource = Nothing
                Return
            End If
            Gdiasmixto.Text = IIf(IsDBNull(tablaPromedioTodo.Rows(0).Item("Dias")), 0, tablaPromedioTodo.Rows(0).Item("Dias"))
            Ghorasmixto.Text = IIf(IsDBNull(tablaPromedioTodo.Rows(0).Item("Horas")), 0, tablaPromedioTodo.Rows(0).Item("Horas"))
            Gminutosmixto.Text = IIf(IsDBNull(tablaPromedioTodo.Rows(0).Item("Minutos")), 0, tablaPromedioTodo.Rows(0).Item("Minutos"))
            Gdiaspallet.Text = IIf(IsDBNull(tablaDetallePallet.Rows(0).Item("Dias")), 0, tablaDetallePallet.Rows(0).Item("Dias"))
            Ghoraspallet.Text = IIf(IsDBNull(tablaDetallePallet.Rows(0).Item("Horas")), 0, tablaDetallePallet.Rows(0).Item("Horas"))
            Gminutospallets.Text = IIf(IsDBNull(tablaDetallePallet.Rows(0).Item("Minutos")), 0, tablaDetallePallet.Rows(0).Item("Minutos"))
            Gdiaspicking.Text = IIf(IsDBNull(tablaPromedioDetalle.Rows(0).Item("Dias")), 0, tablaPromedioDetalle.Rows(0).Item("Dias"))
            Ghoraspicking.Text = IIf(IsDBNull(tablaPromedioDetalle.Rows(0).Item("Horas")), 0, tablaPromedioDetalle.Rows(0).Item("Horas"))
            Gminutospicking.Text = IIf(IsDBNull(tablaPromedioDetalle.Rows(0).Item("Minutos")), 0, tablaPromedioDetalle.Rows(0).Item("Minutos"))




            DgvDetalleOrdenesCP.DataSource = pResultado.Tablas.Tables(5)
            GridView3.BestFitColumns()


            ChartControl2.Titles.Clear()
            ChartControl2.Series.Clear()
            ChartControl2.DataSource = tablaCantidadOrdenes
            ChartControl2.Titles.Add(New ChartTitle() With {.Text = "Cantidad de órdenes"})
            ChartControl2.Legend.Title.Text = ""
            ChartControl2.SeriesDataMember = "Tipo"
            ChartControl2.SeriesTemplate.ValueDataMembers.AddRange(New String() {"Cantidad"})
            ChartControl2.SeriesTemplate.ArgumentDataMember = "Tipo"
            ChartControl2.RuntimeHitTesting = True
            Dim view2 As SideBySideBarSeriesView = TryCast(ChartControl2.SeriesTemplate.View, SideBySideBarSeriesView)
            Dim diagram2 As XYDiagram = CType(ChartControl2.Diagram, XYDiagram)
            diagram2.EnableAxisXScrolling = True
            diagram2.EnableAxisXZooming = True
            diagram2.EnableAxisYScrolling = True
            diagram2.EnableAxisYZooming = True
            view2.BarDistance = 0.5
            view2.BarDistanceFixed = 0.5
            view2.BarWidth = 3


        Catch ex As Exception
            XtraMessageBox.Show(ex.Message.ToString, "Error", MessageBoxButtons.OK)
        End Try
    End Sub






    Private Sub SimpleButton8_Click(sender As Object, e As EventArgs)
        Try
            FrmDetalleOrdenC.Show()
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub AddNewForm(ByVal frm As Form)
        Try
            FrmMenuPrincipal.XtraTabbedMdiManager1.MdiParent = FrmMenuPrincipal
            frm.MdiParent = FrmMenuPrincipal
            frm.Show()
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub
    Private Sub GroupControl2_CustomButtonClick(sender As Object, e As DevExpress.XtraBars.Docking2010.BaseButtonEventArgs) Handles GroupControl1.CustomButtonClick
        Try
            If (e.Button.Properties.Tag = "Calendario") Then
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

                StandardExMenuManager.Default.ShowPopupMenu(dxPopupMenu, Me, GroupControl1.PointToClient(System.Windows.Forms.Control.MousePosition))

            ElseIf e.Button.Properties.Tag = "atras" Then
                FrmDetalleOrdenC.ds = ds
                FrmDetalleOrdenC.ds2 = ds2
                FrmMenuPrincipal.XtraTabbedMdiManager1.MdiParent = FrmMenuPrincipal
                FrmDetalleOrdenC.MdiParent = FrmMenuPrincipal
                FrmDetalleOrdenC.Show()
                Me.Close()
                'FrmDetalleOrdenC.Show()
            ElseIf e.Button.Properties.Tag = "adelante" Then
                XtraMessageBox.Show("Esta es la ultima pantalla")
            End If





        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub SimpleButton9_Click(sender As Object, e As EventArgs) Handles SimpleButton9.Click
        FrmDetalleRequerimientoClienteEmb.ds = ds
        FrmDetalleRequerimientoClienteEmb.ds2 = ds2
        FrmMenuPrincipal.XtraTabbedMdiManager1.MdiParent = FrmMenuPrincipal
        FrmDetalleRequerimientoClienteEmb.MdiParent = FrmMenuPrincipal
        FrmDetalleRequerimientoClienteEmb.Show()
        Me.Close()
    End Sub

    Private Sub SimpleButton8_Click_1(sender As Object, e As EventArgs) Handles SimpleButton8.Click
        ''pantalla de robert

        FrmBalanceCargas.ds = ds
        FrmBalanceCargas.ds2 = ds2
        FrmMenuPrincipal.XtraTabbedMdiManager1.MdiParent = FrmMenuPrincipal
        FrmBalanceCargas.MdiParent = FrmMenuPrincipal
        FrmBalanceCargas.Show()
        Me.Close()
    End Sub
End Class