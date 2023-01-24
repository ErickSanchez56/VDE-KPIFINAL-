Imports DevExpress.XtraCharts
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.Utils
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraPrinting
Imports System.Deployment.Application
Imports System.Reflection

Public Class FrmOrdenEmbarqueKpi
    Public Dia As New DXMenuItem()
    Public ds As New DataSet
    Public ds2 As New DataSet
    Public forma As FrmMenuPrincipal
    Public fechainicio As String
    Public fechafin As String
    Dim tablaGlobalOrdenesEmbarcadas As DataTable
    Dim tablaGlobalOrdenesEmbarcadasPromedio As DataTable
    Dim tablaGlobalOrdenesEmbarcadasGeneral As DataTable
    Private formCount As Integer = 0
    Private Sub FrmOrdenEmbarqueKpi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dias = 7
        'LabelControl16.Visible = False
        'LabelControl4.Visible = False
        'LabelControl10.Visible = False
        'LabelControl12.Visible = False
        'LabelControl14.Visible = False
        'LblPorcentajeOrdenesTotal.Visible = False
        'LblPorcentajeIncompletoTotal.Visible = False
        'LblPorcentajeLiberadasTotal.Visible = False
        'LblPorcentajeSurtidasTotal.Visible = False
        'LblPorcentajeValidadasTotal.Visible = False
        dtpFechaInicio.EditValue = Date.Parse(DateAdd(DateInterval.Day, -7, Today))
        dtpFechaFin.EditValue = Date.Parse(Today)
        llenarGraficaOrdenesCompletasEmbarcadas(Date.Parse(Today), Date.Parse(Today), dias)
        ResultadoLista6("", Date.Parse(Today), Date.Parse(Today), dias)

        ResultadoLista(Date.Parse(Today), Date.Parse(Today), dias)
        ResultadoListaOrdSurtidasEmbarcadas(Date.Parse(Today), Date.Parse(Today), dias)






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
        llenarGraficaOrdenesCompletasEmbarcadas(fecha, fecha2, 0)
        ResultadoLista6("", fecha, fecha2, 0)
        ResultadoLista(fecha, fecha2, 0)
        ResultadoListaOrdSurtidasEmbarcadas(fecha, fecha2, 0)
    End Sub

    Private Sub llenar(ByVal dias As String)


        llenarGraficaOrdenesCompletasEmbarcadas(Date.Parse(Today), Date.Parse(Today), dias)
        ResultadoLista6("", Date.Parse(Today), Date.Parse(Today), dias)
        ResultadoLista(Date.Parse(Today), Date.Parse(Today), dias)
        ResultadoListaOrdSurtidasEmbarcadas(Date.Parse(Today), Date.Parse(Today), dias)
    End Sub

    Private Sub OnEditValueChanged(ByVal sender As System.Object, ByVal e As EventArgs)
        Dim item As New DXMenuItem()
        item = sender
        Dia = sender
        llenar(item.Tag)
    End Sub
    Private Sub ResultadoListaOrdSurtidasEmbarcadas(prmBusqueda2 As Date, prmBusqueda3 As Date, dias As String)
        Try
            Dim pResultado As New CResultado
            Dim Cls As New ClsKPIEMB
            Dim dt As New DataTable

            Cursor.Current = Cursors.WaitCursor
            pResultado = Cls.ResultadoListaOrdSurtidasEmbarcadas(prmBusqueda2, prmBusqueda3, dias, My.Settings.Estacion, DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                Return
            End If

            dt = pResultado.Tabla
            Dim tablaDetalleSurtidas As DataTable
            Dim tablaDettalleEmbarcadas As DataTable
            Dim tablaGeneral As DataTable
            tablaDetalleSurtidas = pResultado.Tablas.Tables(2)
            tablaDettalleEmbarcadas = pResultado.Tablas.Tables(3)
            tablaGeneral = pResultado.Tablas.Tables(1)
            If dt.Rows.Count < 1 Then
                XtraMessageBox.Show("Sin información en el sistema", "AXC", MessageBoxButtons.OK)
                Return
            End If


            ''GridView2.BestFitColumns()
            ChartControl3.DataSource = dt
            '''GRAFICA PIES ChartControl3 
            Dim series1 As New Series("Órdenes Embarque", ViewType.Pie)
            ' Populate the series with points.
            ChartControl3.Series.Clear()
            ChartControl3.Titles.Clear()
            series1.Points.Add(New SeriesPoint("PorcentajeÓrdenesEmbarcadasCompletas", dt.Rows(0).Item("PorcentajeÓrdenesEmbarcadasCompletas")))
            series1.Points.Add(New SeriesPoint("PorcentajeÓrdenesIncompletas", dt.Rows(0).Item("PorcentajeÓrdenesIncompletas")))


            Dim totalporcentajeordenescompletas As String = dt.Rows(0).Item("ÓrdenesEmbarcadas")
            Dim totalporcentajeordenesincompletas As String = dt.Rows(0).Item("ÓrdenesEmbarcadasInc")
            Dim porcentajeordenescompletas As String = dt.Rows(0).Item("PorcentajeÓrdenesEmbarcadasCompletas")
            Dim porcentajeordenesincompletas As String = dt.Rows(0).Item("PorcentajeÓrdenesIncompletas")


            Lblporcentajeembcom.Text = "#" + totalporcentajeordenescompletas

            totalporcentajeordenesincompletas = dt.Rows(0).Item("ÓrdenesEmbarcadasInc") - dt.Rows(0).Item("ÓrdenesEmbarcadas")
            Lblporcentajesurtidascom.Text = "# 0" 'totalporcentajeordenesincompletas

            ' Add the series to the chart.
            ChartControl3.Series.Add(series1)
            ' Adjust the value numeric options of the series.
            series1.PointOptions.ValueNumericOptions.Format = NumericFormat.Percent
            series1.PointOptions.ValueNumericOptions.Precision = 2
            ' Adjust the view-type-specific options of the series.
            CType(series1.View, PieSeriesView).ExplodedPoints.Add(series1.Points(0))
            'Dim chartTitle1 As New ChartTitle()
            'chartTitle1.Text = "Porcentaje de órdenes"
            'ChartControl3.Titles.Add(chartTitle1)
            ChartControl3.Legend.Visible = True
            ' Add the chart to the form.
            ChartControl3.Dock = DockStyle.None
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message.ToString, "Error", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub llenarGraficaOrdenesCompletasEmbarcadas(prmBusqueda2 As Date, prmBusqueda3 As Date, dias As String)
        Try
            Dim objKPI As New ClsKPIEMB
            Dim resultado = objKPI.KPIOrdenesCompletasEmbarcadas(prmBusqueda2, prmBusqueda3, dias, My.Settings.Estacion, DatosTemporales.Usuario)
            If Not resultado.Estado Then
                XtraMessageBox.Show(resultado.Texto, "AXC")
                Return
            End If
            If resultado.Tablas.Tables(1).Rows.Count > 0 And resultado.Tablas.Tables(2).Rows.Count > 0 Then
                llenarGraficasPestañaEmbarques(resultado.Tablas.Tables(1), resultado.Tablas.Tables(2))
                ds = resultado.Tablas
            Else
            End If
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
            'tablaDetallePallet = pResultado.Tablas.Tables(2)
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






        Catch ex As Exception
            XtraMessageBox.Show(ex.Message.ToString, "Error", MessageBoxButtons.OK)
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
            ds2 = pResultado.Tablas
            'ds.Tables.Add(dt)
            dt = ds.Tables(0)
            dt2 = ds.Tables(1)
            dt3 = ds.Tables(2)
            'If dt.Rows.Count < 1 Then
            '    XtraMessageBox.Show("Sin información en el sistema", "AXC", MessageBoxButtons.OK)
            '    GridControl4.DataSource = Nothing
            '    Return
            'End If
            If dt3.Rows.Count < 1 Then
                XtraMessageBox.Show("Sin detalle de las ordenes", "AXC", MessageBoxButtons.OK)
            End If

            'GridView23.BestFitColumns()
            'dgvDetalle13.DataSource = dt3
            'GridView15.BestFitColumns()
            Nordenesatiempo.Text = dt.Rows(0).Item("TotalembarquesaTiempo")
            Nordenesadespiempo.Text = dt.Rows(0).Item("OrdenesRetrazadas")
            '  Nordenestotal.Text = dt.Rows(0).Item("Totalembarques")
            Lblporcentajejeat.Text = dt2.Rows(0).Item("PorcentajeOrdenesEmb")
            Lblporcentajejeat.Text = Lblporcentajejeat.Text + "%"
            Lblporcentajejeadest.Text = dt2.Rows(0).Item("PorcentajeOrdenesRetrazadas")
            Lblporcentajejeadest.Text = Lblporcentajejeadest.Text + "%"

            ''LblPorcentajeIncompletoTotal.Text




            'Nordenesvalidar.text
            'NordenesSurtiendo.text
            'NordenesSinregistro.text
            'Nordenesliberadas.text


            'GridControl4.DataSource = dt
            'GridView5.BestFitColumns()
            ''''GRAFICA DE DONA
            'Dim series1 As New Series("Doughnut Series 1", ViewType.Pie)
            '' Populate the series with points.
            'ChartControl2.Series.Clear()
            'ChartControl2.Titles.Clear()
            'series1.Points.Add(New SeriesPoint("ENVIADAS A TIEMPO", dt.Rows(0).Item("TotalembarquesaTiempo")))
            'series1.Points.Add(New SeriesPoint("ORDENES RETRAZADAS", dt.Rows(0).Item("OrdenesRetrazadas")))
            ''' series1.Points.Add(New SeriesPoint("TOTAL ENVIADAS", dt.Rows(0).Item("Totalembarques")))
            '' Add the series to the chart.
            'ChartControl2.Series.Add(series1)
            'ChartControl2.Legend.Title.Text = "ORDENES"
            'ChartControl2.Legend.MarkerMode = LegendMarkerMode.Marker
            ''ChartControl3.Legend
            '' Adjust the value numeric options of the series.
            'series1.PointOptions.ValueNumericOptions.Format = NumericFormat.Percent
            'series1.PointOptions.ValueNumericOptions.Precision = 2
            '' Add a title to the chart and hide the legend.
            'Dim chartTitle1 As New ChartTitle()
            'chartTitle1.Text = "ORDENES ENVIADAS A TIEMPO"
            'ChartControl2.Titles.Add(chartTitle1)
            'ChartControl2.Legend.Visible = False
            '' Add the chart to the form.
            'ChartControl2.Dock = DockStyle.None
            ''Rotacion de Char3d
            'ChartControl2.RuntimeRotation = True
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message.ToString, "Error", MessageBoxButtons.OK)
        End Try
    End Sub
    Private Sub llenarGraficasPestañaEmbarques(ByVal tablaPromedio As DataTable, ByVal tablaGeneral As DataTable)
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



            Nordenestotal.Text = Totalemb ''Nordenestotal.Text '+ "/" + 


            LblPorcentajeIncompletoTotal.Text = "#" + incompletoN

            LblPorcentajeLiberadasTotal.Text = "#" + totalesn
            LblPorcentajeSurtidasTotal.Text = "#" + surtidasN
            LblPorcentajeValidadasTotal.Text = "#" + validadaN
            LblPorcentajeOrdenesTotal.Text = "#" + embarcadaN








            Dim series1 As New Series("Órdenes de embarcadas", ViewType.Pie)

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
            chartTitle1.Text = "Órdenes embarcadas "
            ChartOrdenesemb.Titles.Add(chartTitle1)
            ChartOrdenesemb.Legend.Visible = False

            ' Add the chart to the form.
            ChartOrdenesemb.Dock = DockStyle.None

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub
    Public Sub AddNewForm(ByVal frm As Form)
        Try
            FrmMenuPrincipal.XtraTabbedMdiManager1.MdiParent = FrmMenuPrincipal
            frm.MdiParent = FrmMenuPrincipal
            frm.Show()
            Me.Close()
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub
    Private Sub GroupControl2_CustomButtonClick(sender As Object, e As DevExpress.XtraBars.Docking2010.BaseButtonEventArgs) Handles GroupControl15.CustomButtonClick
        Try
            If e.Button.Properties.Tag = "adelante" Then
                FrmDetalleOrdenC.ds = ds
                FrmDetalleOrdenC.ds2 = ds2
                FrmMenuPrincipal.XtraTabbedMdiManager1.MdiParent = FrmMenuPrincipal
                FrmDetalleOrdenC.MdiParent = FrmMenuPrincipal
                FrmDetalleOrdenC.Show()
                Me.Close()
                '                AddNewForm(New FrmDetalleOrdenC)
            ElseIf e.Button.Properties.Tag = "atras" Then
                XtraMessageBox.Show("Esta es la pantalla de inicio", "AXC")
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
        ''pantalla de robert
        'FrmDetalleOrdenC.ds = ds
        'FrmDetalleOrdenC.ds2 = ds2
        'FrmMenuPrincipal.XtraTabbedMdiManager1.MdiParent = FrmMenuPrincipal
        'FrmDetalleOrdenC.MdiParent = FrmMenuPrincipal
        'FrmDetalleOrdenC.Show()
        ''Me.Close()
    End Sub

    Async Sub SimpleButton8_Click(sender As Object, e As EventArgs) Handles SimpleButton8.Click
        FrmDetalleOrdenC.ds = ds
        FrmDetalleOrdenC.ds2 = ds2
        FrmMenuPrincipal.XtraTabbedMdiManager1.MdiParent = FrmMenuPrincipal
        FrmDetalleOrdenC.MdiParent = FrmMenuPrincipal
        FrmDetalleOrdenC.Show()
        'AddHandler FrmDetalleOrdenC.Load, AddressOf cierra
        If dtpFechaFin.EditValue <> dtpFechaInicio.EditValue Then
            cierra()
        Else
            cierra()
        End If





    End Sub
    Public Sub cierra()
        Me.Close()
    End Sub
End Class