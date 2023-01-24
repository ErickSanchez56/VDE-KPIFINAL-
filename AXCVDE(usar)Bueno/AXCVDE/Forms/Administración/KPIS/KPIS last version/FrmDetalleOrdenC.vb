Imports DevExpress.XtraCharts
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.Utils
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraPrinting

Public Class FrmDetalleOrdenC
    Public Dia As New DXMenuItem()
    Public ds As DataSet
    Public ds2 As DataSet
    Private Sub FrmOrdenEmbarqueKpi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpFechaInicio.EditValue = Date.Parse(DateAdd(DateInterval.Day, -7, Today))
        dtpFechaFin.EditValue = Date.Parse(Today)
        Totaldeordenesload()
        ResultadoListaload()
        ' FrmOrdenEmbarqueKpi.Close()
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
        If String.IsNullOrEmpty(dtpFechaFin.Text) Then
            prmBusqueda3 = "@"
        Else
            prmBusqueda3 = dtpFechaFin.Text
        End If
        Dim fecha2 As New Date
        fecha2 = Date.Parse(dtpFechaFin.EditValue.ToString)
        Totaldeordenes(fecha, fecha2, 0)
        ResultadoLista(fecha, fecha2, 0)
    End Sub
    Private Sub OnEditValueChanged(ByVal sender As System.Object, ByVal e As EventArgs)
        Dim item As New DXMenuItem()
        item = sender
        Dia = sender
        Totaldeordenes(Date.Parse(Today), Date.Parse(Today), item.Tag)
        ResultadoLista(Date.Parse(Today), Date.Parse(Today), item.Tag)
    End Sub
    Private Sub Totaldeordenes(prmBusqueda2 As Date, prmBusqueda3 As Date, dias As String)
        Try
            Dim objKPI As New ClsKPIEMB
            Dim resultado = objKPI.KPIOrdenesCompletasEmbarcadas(prmBusqueda2, prmBusqueda3, dias, My.Settings.Estacion, DatosTemporales.Usuario)
            If Not resultado.Estado Then
                XtraMessageBox.Show(resultado.Texto, "AXC")
                Return
            End If
            Dim tablaPromedio = resultado.Tablas.Tables(1)
            Dim tablaGeneral = resultado.Tablas.Tables(2)
            Dim tablaGeneral1 = resultado.Tablas.Tables(3)
            If tablaPromedio.Rows.Count > 0 And tablaGeneral.Rows.Count > 0 Then
                llenarTotalEmbarquesUsuario(tablaPromedio, tablaGeneral, tablaGeneral1, "")
            Else
            End If
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub

    Private Sub Totaldeordenesload()
        Try

            Dim tablaPromedio = ds.Tables(1)
            Dim tablaGeneral = ds.Tables(2)
            Dim tablaGeneral1 = ds.Tables(3)
            If tablaPromedio.Rows.Count > 0 And tablaGeneral.Rows.Count > 0 Then
                llenarTotalEmbarquesUsuario(tablaPromedio, tablaGeneral, tablaGeneral1, "")
            Else
            End If
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub
    Private Sub ResultadoLista(prmBusqueda2 As Date, prmBusqueda3 As Date, dias As String)
        Try
            Dim pResultado As New CResultado
            Dim Cls As New ClsKPIEMB
            Dim dt As New DataTable
            Dim dt2 As New DataTable
            Dim dt3 As New DataTable
            Cursor.Current = Cursors.WaitCursor
            pResultado = Cls.ResultadoListaOrdenesCompletasEmbES(prmBusqueda2, prmBusqueda3, dias, My.Settings.Estacion, DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default
            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                Return
            End If
            Dim ds As New DataSet
            ds = pResultado.Tablas
            dt = ds.Tables(0)
            dt2 = ds.Tables(1)
            'dt3 = ds.Tables(2)
            If dt.Rows.Count < 1 Then
                XtraMessageBox.Show("Sin detalle de las ordenes", "AXC", MessageBoxButtons.OK)
            End If
            Nordenesatiempo.Text = dt.Rows(0).Item("TotalembarquesaTiempo")
            Nordenesadespiempo.Text = dt.Rows(0).Item("OrdenesRetrazadas")
            Lblporcentajejeat.Text = dt2.Rows(0).Item("PorcentajeOrdenesEmb")
            Lblporcentajejeat.Text = Lblporcentajejeat.Text + "%"
            Lblporcentajejeadest.Text = dt2.Rows(0).Item("PorcentajeOrdenesRetrazadas")
            Lblporcentajejeadest.Text = Lblporcentajejeadest.Text + "%"
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message.ToString, "Error", MessageBoxButtons.OK)
        End Try
    End Sub
    Private Sub ResultadoListaload()
        Try
            Dim dt As New DataTable
            Dim dt2 As New DataTable
            dt = ds2.Tables(0)
            dt2 = ds2.Tables(1)
            If dt.Rows.Count < 1 Then
                XtraMessageBox.Show("Sin detalle de las ordenes", "AXC", MessageBoxButtons.OK)
            End If
            Nordenesatiempo.Text = dt.Rows(0).Item("TotalembarquesaTiempo")
            Nordenesadespiempo.Text = dt.Rows(0).Item("OrdenesRetrazadas")
            Lblporcentajejeat.Text = dt2.Rows(0).Item("PorcentajeOrdenesEmb")
            Lblporcentajejeat.Text = Lblporcentajejeat.Text + "%"
            Lblporcentajejeadest.Text = dt2.Rows(0).Item("PorcentajeOrdenesRetrazadas")
            Lblporcentajejeadest.Text = Lblporcentajejeadest.Text + "%"
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message.ToString, "Error", MessageBoxButtons.OK)
        End Try
    End Sub
    Private Sub llenarTotalEmbarquesUsuario(ByVal tablaPromedio As DataTable, ByVal tablaGeneral As DataTable, ByVal tablaGeneral1 As DataTable, ByVal usuario As String)
        Try
            Dim Totalemb As String = tablaGeneral.Rows(0).Item("TotalOrdenes")
            Nordenesliberadas.Text = tablaGeneral.Rows(0).Item("LIBERADA TOTAL")
            NordenesSurtiendo.Text = tablaGeneral.Rows(0).Item("SURTIDA")
            Nordenesvalidar.Text = tablaGeneral.Rows(0).Item("VALIDADA")
            Nordenestotal.Text = tablaGeneral.Rows(0).Item("EMBARCADA")

            LblPorcentajeLiberadas.Text = tablaGeneral.Rows(0).Item("PorcentajeLiberadasTotales")
            LblPorcentajeLiberadas.Text = LblPorcentajeLiberadas.Text + "%"
            LblPorcentajesurtidas.Text = tablaGeneral.Rows(0).Item("PorcentajeSurtidas")
            LblPorcentajesurtidas.Text = LblPorcentajesurtidas.Text + "%"
            LblPorcentajevalidadas.Text = tablaGeneral.Rows(0).Item("PorcentajeValidadas")
            LblPorcentajevalidadas.Text = LblPorcentajevalidadas.Text + "%"
            LblPorcentajeEmb.Text = tablaGeneral.Rows(0).Item("PorcentajeEmbarcadas")
            LblPorcentajeEmb.Text = LblPorcentajeEmb.Text + "%"

            LabelControl16.Visible = True
            LabelControl4.Visible = True
            LabelControl10.Visible = True
            LabelControl12.Visible = True
            LabelControl14.Visible = True

            LblPorcentajeOrdenesTotal.Visible = True
            LblPorcentajeIncompletoTotal.Visible = True
            LblPorcentajeLiberadasTotal.Visible = True
            LblPorcentajeSurtidasTotal.Visible = True
            LblPorcentajeValidadasTotal.Visible = True


            Dim totales As String = tablaGeneral.Rows(0).Item("PorcentajeLiberadasTotales")
            Dim totalesn As String = tablaGeneral.Rows(0).Item("LIBERADA TOTAL")

            Dim surtidas As String = tablaGeneral.Rows(0).Item("PorcentajeSurtidas")
            Dim surtidasN As String = tablaGeneral.Rows(0).Item("SURTIDA")

            Dim validada As String = tablaGeneral.Rows(0).Item("PorcentajeValidadas")
            Dim validadaN As String = tablaGeneral.Rows(0).Item("VALIDADA")

            Dim embarcada As String = tablaGeneral.Rows(0).Item("PorcentajeEmbarcadas")
            Dim embarcadaN As String = tablaGeneral.Rows(0).Item("EMBARCADA")

            Dim incompleto As String = tablaPromedio.Rows(0).Item("PorcentajeIncompletas")
            Dim incompletoN As String = tablaGeneral.Rows(0).Item("LIBERADA TOTAL") + tablaGeneral.Rows(0).Item("SURTIDA") + tablaGeneral.Rows(0).Item("VALIDADA")



            Nordenestotal.Text = Totalemb


            LblPorcentajeIncompletoTotal.Text = "#" + incompletoN

            LblPorcentajeLiberadasTotal.Text = "#" + totalesn
            LblPorcentajeSurtidasTotal.Text = "#" + surtidasN
            LblPorcentajeValidadasTotal.Text = "#" + validadaN
            LblPorcentajeOrdenesTotal.Text = "#" + embarcadaN








            Dim series1 As New Series("Órdenes completas embarcadas", ViewType.Pie)

            ' Populate the series with points.
            ChartOrdenesemb.Series.Clear()
            ChartOrdenesemb.Titles.Clear()

            series1.Points.Add(New SeriesPoint("Embarcadas", tablaPromedio.Rows(0).Item("PorcentajeEmbarcadas")))
            series1.Points.Add(New SeriesPoint("Incompletas", tablaPromedio.Rows(0).Item("PorcentajeIncompletas")))

            ' Add the series to the chart.
            ChartOrdenesemb.Series.Add(series1)

            ' Adjust the value numeric options of the series.
            series1.PointOptions.ValueNumericOptions.Format = NumericFormat.Percent
            series1.PointOptions.ValueNumericOptions.Precision = 2

            ' Adjust the view-type-specific options of the series.
            CType(series1.View, PieSeriesView).ExplodedPoints.Add(series1.Points(0))


            ' Add a title to the chart and hide the legend.
            Dim chartTitle1 As New ChartTitle()
            chartTitle1.Text = "Órdenes embarcadas"
            ChartOrdenesemb.Titles.Add(chartTitle1)
            ChartOrdenesemb.Legend.Visible = False

            ' Add the chart to the form.
            ChartOrdenesemb.Dock = DockStyle.None



            DgvDetalleOrdenesCP.DataSource = tablaGeneral1
            GridView3.BestFitColumns()

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub
    Public Sub AddNewForm(ByVal frm As Form)
        Try


        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub
    Private Sub GroupControl2_CustomButtonClick(sender As Object, e As DevExpress.XtraBars.Docking2010.BaseButtonEventArgs)
        Try
            If e.Button.Properties.Tag = "atras" Then

                'AddNewForm(New FrmOrdenEmbarqueKpi)

            ElseIf e.Button.Properties.Tag = "adelante" Then
                Me.Close()
                FrmCantidaddesurtidos.ds = ds
                FrmCantidaddesurtidos.ds2 = ds2
                FrmMenuPrincipal.XtraTabbedMdiManager1.MdiParent = FrmMenuPrincipal
                FrmCantidaddesurtidos.MdiParent = FrmMenuPrincipal
                FrmCantidaddesurtidos.Show()

                'AddNewForm(New )
            ElseIf (e.Button.Properties.Tag = "Calendario") Then
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
                StandardExMenuManager.Default.ShowPopupMenu(dxPopupMenu, Me, GroupControl15.PointToClient(System.Windows.Forms.Control.MousePosition))
            End If
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub SimpleButton9_Click(sender As Object, e As EventArgs) Handles SimpleButton9.Click
        FrmOrdenEmbarqueKpi.ds = ds
        FrmOrdenEmbarqueKpi.ds2 = ds2
        FrmMenuPrincipal.XtraTabbedMdiManager1.MdiParent = FrmMenuPrincipal
        FrmOrdenEmbarqueKpi.MdiParent = FrmMenuPrincipal
        FrmOrdenEmbarqueKpi.Show()
        Me.Close()
    End Sub

    Private Sub SimpleButton8_Click(sender As Object, e As EventArgs) Handles SimpleButton8.Click

        FrmDetalleRequerimientoClienteEmb.ds = ds
        FrmDetalleRequerimientoClienteEmb.ds2 = ds2
        FrmMenuPrincipal.XtraTabbedMdiManager1.MdiParent = FrmMenuPrincipal
        FrmDetalleRequerimientoClienteEmb.MdiParent = FrmMenuPrincipal
        FrmDetalleRequerimientoClienteEmb.Show()
        Me.Close()
    End Sub
End Class