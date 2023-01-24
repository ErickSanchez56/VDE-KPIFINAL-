Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraReports.UI

Public Class FrmExistenciasGeneral
#Region "VARIABLES"
    Dim nuevo As New clsExistencias
    Dim nuevoNumParte As New clsNumParte
    Dim dsTotales As New DataSet
#End Region

#Region "EVENTOS"
    Private Sub FrmExistenciasGeneral_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            '  ListaNumParte()
            ListaAlmacenes()
            ListaClientes("@")


            cmbNumParte.EditValue = 0
            cmbAlmacen.EditValue = "TODOS"
        Catch ex As Exception
            XtraMessageBox.Show("Error: " + ex.Message, "AXC")
        End Try
    End Sub

    Private Sub cbNumParte_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.KeyChar = UCase(e.KeyChar)
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Try
            DgvResultados.DataSource = Nothing
            DgvResultados.Refresh()


            CargarTotalExistencias(IIf(cmbNumParte.Text = "TODOS", "@", cmbNumParte.Text),
                                   IIf(String.IsNullOrEmpty(TxtLote.Text), "@", TxtLote.Text),
                                   IIf(cmbAlmacen.Text = "TODOS", "@", cmbAlmacen.Text),
                                   IIf(String.IsNullOrEmpty(TxtPosicion.Text), "@", TxtPosicion.Text), cmbCliente.Text)
        Catch ex As Exception
            XtraMessageBox.Show("Error: " & ex.Message, " AXC")
        End Try
    End Sub

    Private Sub CargarTotalExistencias(prmNUmParte As String, ByVal prmLote As String, ByVal prmAlmacen As String, ByVal prmPosicion As String, ByVal prmCliente As String)
        Try
            DgvExistenciaTotal.DataSource = Nothing
            DgvExistenciaTotal.Refresh()

            Dim pResultado As New CResultado
            Dim pCons As New clsExistencias

            Cursor.Current = Cursors.WaitCursor
            pResultado = pCons.CargarTotalExistencias(prmNUmParte, prmLote, prmAlmacen, prmPosicion, IIf(prmCliente = "TODOS", "@", prmCliente), My.Settings.Estacion, DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto, "AXC")
                DgvExistenciaTotal.DataSource = Nothing
                DgvExistenciaTotal.Refresh()
                Return
            End If
            Dim dt As New DataTable
            Dim ds As New DataSet

            dt = pResultado.Tabla

            ds.Tables.Add(dt)

            If dt.Rows.Count < 1 Then
                XtraMessageBox.Show("No hay información en totales", "AXC")
                DgvExistenciaTotal.DataSource = Nothing
                DgvExistenciaTotal.Refresh()
                Return
            End If
            Dim TotalDisponible As Decimal = 0
            Dim TotalnpseccionColocado As Decimal = 0
            Dim TotalBloqueadoColocado As Decimal = 0
            Dim TotalArmadoPedido As Decimal = 0
            Dim TotalArmadoTraspaso As Decimal = 0
            Dim TotalReciboArmado As Decimal = 0
            Dim TotalTransito As Decimal = 0
            Dim TotalSurtido As Decimal = 0
            Dim TotalValidado As Decimal = 0
            Dim TotalEmbarque As Decimal = 0
            Dim TotalPAletizando As Decimal = 0
            Dim TotalSinColocar As Decimal = 0
            Dim TotalEnIpseccionSC As Decimal = 0
            Dim TotalBloqueado As Decimal = 0

            'If Not prmNUmParte = "@" Then
            '    For Each rows As DataRow In ds.Tables(0).Rows
            '        TotalDisponible += rows.Item("COLOCADO DISPONIBLE")
            '        TotalnpseccionColocado += rows.Item("EN INSPECCIÓN COLOCADO")
            '        TotalBloqueadoColocado += rows.Item("BLOQUEADO COLOCADO")
            '        TotalArmadoPedido += rows.Item("ARMADO PEDIDO")
            '        TotalArmadoTraspaso += rows.Item("ARMADO TRASPASO")
            '        TotalReciboArmado += rows.Item("ARMADO RECIBO TRAS")
            '        TotalTransito += rows.Item("EN TRANSITO")
            '        TotalSurtido += rows.Item("SURTIDO")
            '        TotalValidado += rows.Item("VALIDADO")
            '        TotalEmbarque += rows.Item("EMBARQUE")
            '        TotalPAletizando += rows.Item("PALETIZANDO")
            '        TotalSinColocar += rows.Item("SIN COLOCAR")
            '        TotalEnIpseccionSC += rows.Item("EN INSPECCIÓN SC")
            '        TotalBloqueado += rows.Item("BLOQUEADO SC")
            '    Next
            '    Dim row1 As DataRow = ds.Tables(0).NewRow
            '    row1.Item(0) = ""
            '    Dim row As DataRow = ds.Tables(0).NewRow
            '    row.Item(0) = ""
            '    row.Item(1) = ""
            '    row.Item(2) = ""
            '    row.Item(3) = "TOTALES"
            '    row.Item(4) = TotalDisponible
            '    row.Item(5) = TotalnpseccionColocado
            '    row.Item(6) = TotalBloqueadoColocado
            '    row.Item(7) = TotalArmadoPedido
            '    row.Item(8) = TotalArmadoTraspaso
            '    row.Item(9) = TotalReciboArmado
            '    row.Item(10) = TotalTransito
            '    row.Item(11) = TotalSurtido
            '    row.Item(12) = TotalValidado
            '    row.Item(13) = TotalEmbarque
            '    row.Item(14) = TotalPAletizando
            '    row.Item(15) = TotalSinColocar
            '    row.Item(16) = TotalEnIpseccionSC
            '    row.Item(17) = TotalBloqueado

            '    ds.Tables(0).Rows.InsertAt(row, 0)
            '    ds.Tables(0).Rows.InsertAt(row1, 1)
            '    DgvExistenciaTotal.DataSource = ds.Tables(0)


            'End If

            DgvExistenciaTotal.DataSource = dt
            GridView1.BestFitColumns()
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub


    Private Sub btnReporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReporte.Click
        Dim dsG As New DataSet
        Try
            If GridView1.RowCount = 0 Then
                XtraMessageBox.Show("Buscar información con los filtros", "AXC")
                Return
            End If

            If XtraMessageBox.Show("¿Generar reporte?", "AXC", MessageBoxButtons.YesNo) <> DialogResult.Yes Then
                Return
            End If

            Dim ds As DataSet = nuevo.ListaExistenciasGeneralRPT(cmbNumParte.Text, IIf(cmbAlmacen.Text = "TODOS", "@", cmbAlmacen.Text), TxtLote.Text, My.Settings("Estacion"), DatosTemporales.Usuario)

            Dim RepExistencias As New DevRepExistenciasDiponiblesXPosicion
            RepExistencias.CargaReporte(ds, 1)
            Dim designTool As New ReportPrintTool(RepExistencias)
            designTool.ShowPreview()
            dsG = New DataSet
        Catch ex As Exception
            XtraMessageBox.Show("Error: " + ex.Message, "AXC")
        End Try
    End Sub



    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim dsRep As New DataSet
        Try

            If XtraMessageBox.Show("¿Generar reporte?", "AXC", MessageBoxButtons.YesNo) <> DialogResult.Yes Then
                Return
            End If
            Cursor.Current = Cursors.WaitCursor
            Dim ds As DataSet = nuevo.ListaExistenciasTotalRPT(cmbNumParte.Text, IIf(cmbAlmacen.Text = "TODOS", "@", cmbAlmacen.Text), TxtPosicion.Text, TxtLote.Text, My.Settings("Estacion"), DatosTemporales.Usuario)
            dsRep.Tables.Add(ds.Tables(1).Copy)
            If Not dsTotales.Tables.Count < 1 Then
                dsRep.Tables.Add(dsTotales.Tables(0).Copy)
            End If

            Cursor.Current = Cursors.Default


            Dim RepExistencias As New DevRepExixtenciaTotal
            RepExistencias.CargaReporte(dsRep, 1)
            Dim designTool As New ReportPrintTool(RepExistencias)
            designTool.ShowPreview()

            'FrmVisorReportes.CargaReporte(dsRep, 12)
            'FrmVisorReportes.Show()
            dsRep = New DataSet
        Catch ex As Exception
            XtraMessageBox.Show("Error: " + ex.Message, "AXC")
        End Try
    End Sub

#End Region

#Region "METODOS"

    Private Sub ListaNumParte(ByVal prmCliente As String)
        Try
            Dim pResultado As New CResultado
            Dim pOC As New clsNumParte

            Cursor.Current = Cursors.WaitCursor
            pResultado = pOC.ListaNumPartePorCliente(prmCliente, "@", My.Settings.Estacion, DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto, "AXC")
                Return
            End If

            Dim dt As DataTable = New DataTable
            Dim ds As New DataSet
            dt = pResultado.Tabla
            ds.Tables.Add(dt)
            Dim row As DataRow = ds.Tables(0).NewRow
            row.Item(0) = 0
            row.Item(1) = "TODOS"
            row.Item(2) = ""
            row.Item(3) = ""
            row.Item(4) = ""
            row.Item(5) = ""
            row.Item(6) = ""
            ds.Tables(0).Rows.InsertAt(row, 0)

            cmbNumParte.Properties.ValueMember = "IdNumParte"
            cmbNumParte.Properties.DisplayMember = "Artículo"
            cmbNumParte.Properties.DataSource = dt
            cmbNumParte.Properties.BestFitMode = BestFitMode.BestFitResizePopup
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Private Sub ListaClientes(prmBusqueda As String)
        Try
            Dim pResultado As New CResultado
            Dim Cls As New clsCliente

            Cursor.Current = Cursors.WaitCursor
            pResultado = Cls.ResultadoListaClientes(prmBusqueda, My.Settings.Estacion, DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                Return
            End If
            Dim dt As New DataTable
            Dim ds As New DataSet

            dt = pResultado.Tabla
            ds.Tables.Add(dt)
            Dim row As DataRow = ds.Tables(0).NewRow
            row.Item(0) = 0
            row.Item(1) = "TODOS"
            row.Item(2) = ""
            row.Item(3) = ""
            row.Item(4) = ""
            row.Item(5) = ""
            row.Item(6) = ""
            row.Item(7) = ""
            row.Item(8) = Date.Now
            ds.Tables(0).Rows.InsertAt(row, 0)


            cmbCliente.Properties.DataSource = dt
            cmbCliente.Properties.DisplayMember = "Cliente"
            cmbCliente.Properties.ValueMember = "IdCliente"
            cmbCliente.Properties.BestFitMode = BestFitMode.BestFitResizePopup
            cmbCliente.EditValue = 0

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message.ToString, "Error", MessageBoxButtons.OK)
        End Try
    End Sub
    Private Sub ListaNumParte()
        Try
            Dim pResultado As New CResultado
            Dim pOC As New clsNumParte

            Cursor.Current = Cursors.WaitCursor
            pResultado = pOC.ListaNumParteConsultas()
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                Return
            End If

            Dim dt As DataTable = New DataTable
            dt = pResultado.Tabla

            cmbNumParte.Properties.ValueMember = "IdNumParte"
            cmbNumParte.Properties.DisplayMember = "NumParte"
            cmbNumParte.Properties.DataSource = dt
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub ListaAlmacenes()
        Try


            Dim pResultado As New CResultado
            Dim pCons As New ClsAlmacen

            Cursor.Current = Cursors.WaitCursor
            pResultado = pCons.ListaAlmacen("@", "@", My.Settings.Estacion)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                Return
            End If

            Dim dt As DataTable = New DataTable
            Dim ds As New DataSet

            dt = pResultado.Tabla.Copy
            ds.Tables.Add(dt)
            Dim row As DataRow = ds.Tables(0).NewRow
            row.Item(0) = 0
            row.Item(1) = "0"
            row.Item(2) = "TODOS"
            row.Item(3) = "TODOS"
            ds.Tables(0).Rows.InsertAt(row, 0)

            cmbAlmacen.Properties.ValueMember = "ERPAlmacen"
            cmbAlmacen.Properties.DisplayMember = "ERPAlmacen"
            cmbAlmacen.Properties.DataSource = dt

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub

    Private Sub ConsultaNumParte()
        Try
            Dim pResultado As New CResultado
            Dim pOP As New COrdenProd

            Cursor.Current = Cursors.WaitCursor
            pResultado = pOP.ConsultaNumParte(cmbNumParte.Text)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                MsgBox(pResultado.Texto)

                Return
            End If

            Dim dt As DataTable = New DataTable
            dt = pResultado.Tabla

            txtDescripcion.Text = dt.Rows(0).Item("DNumParte1")
            'lblExistencia.Text = dt.Rows(0).Item("Existencia")
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub CargaGridResultados(ByVal ds As DataSet)
        Try
            DgvExistenciaTotal.DataSource = Nothing
            'If ds.Tables(1).Rows.Count = 0 Or ds.Tables.Count = 1 Then
            '    MsgBox("No se encontraron resultados", MsgBoxStyle.Critical, " AXC")
            '    dg.DataSource = Nothing
            '    Return
            'End If
            DgvExistenciaTotal.DataSource = ds.Tables(1)
            GridView1.BestFitColumns()



        Catch ex As Exception
            XtraMessageBox.Show("Error: " & ex.Message, " AXC")
        End Try
    End Sub

    Private Sub FrmExistenciasGeneral_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose(True)
    End Sub

    Private Sub GridView1_DoubleClick(sender As Object, e As EventArgs) Handles GridView1.DoubleClick
        Try
            Dim pStatus As String = ""
            Dim pLote As String = ""
            Dim pNumParte As String = ""
            Dim pAlmacen As String = ""
            Cursor.Current = Cursors.WaitCursor

            Dim ea As DXMouseEventArgs = TryCast(e, DXMouseEventArgs)
            Dim view As GridView = TryCast(sender, GridView)
            Dim info As GridHitInfo = view.CalcHitInfo(ea.Location)

            Dim pSeleccion As ColumnView = CType(DgvExistenciaTotal.MainView, ColumnView)
            Dim selectedRowHandles As Integer() = view.GetSelectedRows

            If info.InRow OrElse info.InRowCell Then
                Dim colCaption As String = If(info.Column Is Nothing, "N/A", info.Column.GetCaption())
                '  MessageBox.Show(String.Format("DoubleClick on row: {0}, column: {1}.", info.RowHandle, colCaption))

                'If pSeleccion.GetRowCellValue(selectedRowHandles(0)) = 0 Or info.RowHandle = 1 Or info.RowHandle = 2 Or info.RowHandle = 3 Then
                '    Return
                'End If
                'If Not cmbNumParte.Text = "TODOS" Then
                '    If info.RowHandle = 0 Or info.RowHandle = 1 Then
                '        Return
                '    End If
                'End If

                pStatus = colCaption

                pAlmacen = (view.GetRowCellValue(selectedRowHandles(0), "Almacen"))
                pNumParte = (view.GetRowCellValue(selectedRowHandles(0), "Producto"))
                pLote = (view.GetRowCellValue(selectedRowHandles(0), "Lote"))
                ConsultaPallet(pAlmacen, pNumParte, pLote, pStatus)
            End If



            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Cursor.Current = Cursors.Default
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub

    Private Sub ConsultaPallet(prmAlmacen As String, prmNumParte As String, prmLote As String, prmEstatus As String)
        Try
            DgvResultados.DataSource = Nothing
            DgvResultados.Refresh()

            Dim pResultado As New CResultado
            Dim pCons As New clsExistencias
            dsTotales = New DataSet
            Cursor.Current = Cursors.WaitCursor
            pResultado = pCons.ConsultaPallet(prmAlmacen, IIf(String.IsNullOrEmpty(TxtPosicion.Text), "@", TxtPosicion.Text), prmNumParte, prmLote, prmEstatus, My.Settings.Estacion, DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto, "AXC")
                DgvResultados.DataSource = Nothing
                DgvResultados.Refresh()
                Return
            End If
            Dim dt As New DataTable
            Dim ds As New DataSet

            dt = pResultado.Tabla
            dt.TableName = "PALLETS"
            ds.Tables.Add(dt)

            If dt.Rows.Count < 1 Then
                XtraMessageBox.Show("No se encontraron pallets con esta caracteristicas", "AXC")
                DgvResultados.DataSource = Nothing
                DgvResultados.Refresh()
                Return
            End If
            dsTotales.Tables.Add(ds.Tables(0).Copy)
            DgvResultados.DataSource = dt
            GridView3.BestFitColumns()

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub



#Region "VARIABLES"
    Public dsReporte As New DataSet
#End Region

    Private Sub BtnReporteTotales_Click(sender As Object, e As EventArgs) Handles BtnReporteTotales.Click
        Try
            Dim ChkLst As New List(Of DevExpress.XtraEditors.CheckEdit) 'Todos los checkbox serán considerados como un item de ChkLst
            ChkLst.AddRange(GroupControl4.Controls.OfType(Of DevExpress.XtraEditors.CheckEdit)) 'Añadimos todos los checkboxes al ChkLst
            Dim pTipoReporte As String = ""
            dgvExistencias.DataSource = Nothing
            dgvViewExistencias.Columns.Clear()

            For I As Integer = 0 To ChkLst.Count - 1

                'Hacemos el Deschecked a todos los checkbox:
                'ChkLst(I).Checked = False

                If ChkLst(I).Checked Then


                    Select Case ChkLst(I).Name
                        Case "ChkDisponibles"
                            pTipoReporte = "1"

                            Exit For
                        Case "ChkTotales"
                            pTipoReporte = "2"
                            Exit For
                        Case "ChkDisponiblesPorPos"
                            pTipoReporte = "3"

                            Exit For
                        Case "ChkTotalesPorPos"
                            pTipoReporte = "4"
                            Exit For
                        Case "ChkNoDisponibles"
                            pTipoReporte = "5"
                            Exit For
                        Case "ChkNoDisponiblesPorPos"
                            pTipoReporte = "6"
                            Exit For
                    End Select

                End If

            Next (I)

            If String.IsNullOrEmpty(pTipoReporte) Then
                XtraMessageBox.Show("No se ha seleccionado un tipo de reporte", "Información", MessageBoxButtons.OK)
                Return
            End If

            Dim pResultado As New CResultado
            Dim pOC As New clsExistencias

            Cursor.Current = Cursors.WaitCursor
            pResultado = pOC.ConsultaReporte(pTipoReporte, IIf(cmbAlmacen.Text = "TODOS", "@", cmbAlmacen.Text),
                                            IIf(cmbCliente.Text = "TODOS", "@", cmbCliente.Text),
                                        IIf(cmbNumParte.Text = "TODOS", "@", cmbNumParte.Text),
                                   IIf(String.IsNullOrEmpty(TxtPosicion.Text), "@", TxtPosicion.Text), My.Settings.Estacion, DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                Return
            End If

            Dim dt As DataTable = New DataTable
            Dim ds As New DataSet
            dt = pResultado.Tabla
            dgvExistencias.DataSource = dt
            ds.Tables.Add(dt)



            'ASIGNAR DATOS AL REPORTE
            dsReporte = New DataSet
            dsReporte.Tables.Add(ds.Tables(0).Copy())

            'GENERA REPORTE

            If XtraMessageBox.Show("¿Generar reporte?", "Confirmación", MessageBoxButtons.YesNo) <> DialogResult.Yes Then
                Return
            End If
            If dgvExistencias.DataSource Is Nothing Then
                XtraMessageBox.Show("No hay información para exportar", "Información", MessageBoxButtons.OK)
                Return
            End If
            'Dim path As String = ""

            'Dim sv As New SaveFileDialog
            'sv.Filter = "Excel Workbook|*.xlsx"
            'If sv.ShowDialog() = DialogResult.OK And sv.FileName <> Nothing Then
            '    If sv.FileName.EndsWith(".xlsx") Then
            '        path = sv.FileName.ToString()
            '        ' Customize export options
            '        CType(dgvExistencias.MainView, GridView).OptionsPrint.PrintHorzLines = False
            '        CType(dgvExistencias.MainView, GridView).OptionsPrint.PrintVertLines = False
            '        CType(dgvExistencias.MainView, GridView).OptionsPrint.PrintHeader = True
            '        Dim advOptions As XlsxExportOptionsEx = New XlsxExportOptionsEx()
            '        advOptions.SheetName = "Reporte de existencias"
            '        advOptions.ShowColumnHeaders = DevExpress.Utils.DefaultBoolean.True

            '        dgvExistencias.ExportToXlsx(path, advOptions)
            '        Process.Start(path)

            '    End If
            'End If



            If pTipoReporte = "1" Then
                Dim RepExistencias As New DevRepExistenciasDiponibles
                RepExistencias.CargaReporte(dsReporte, 1)
                Dim designTool As New ReportPrintTool(RepExistencias)
                designTool.ShowPreview()
            ElseIf pTipoReporte = "3" Then
                Dim RepExistencias As New DevRepExistenciasDiponiblesXPosicion
                RepExistencias.CargaReporte(dsReporte, 1)
                Dim designTool As New ReportPrintTool(RepExistencias)
                designTool.ShowPreview()
            ElseIf pTipoReporte = "5" Then
                Dim RepExistencias As New DevRepExistenciasNoDiponibles
                RepExistencias.CargaReporte(dsReporte, 1)
                Dim designTool As New ReportPrintTool(RepExistencias)
                designTool.ShowPreview()
            ElseIf pTipoReporte = "6" Then
                Dim RepExistencias As New DevRepExistenciasNoDiponiblesXPosicion
                RepExistencias.CargaReporte(dsReporte, 1)
                Dim designTool As New ReportPrintTool(RepExistencias)
                designTool.ShowPreview()
            ElseIf pTipoReporte = "2" Then
                Dim RepExistencias As New DevRepExistenciasTotales
                RepExistencias.CargaReporte(dsReporte, 1)
                Dim designTool As New ReportPrintTool(RepExistencias)
                designTool.ShowPreview()
            ElseIf pTipoReporte = "4" Then
                Dim RepExistencias As New DevRepExistenciasTotalesXPosicion
                RepExistencias.CargaReporte(dsReporte, 1)
                Dim designTool As New ReportPrintTool(RepExistencias)
                designTool.ShowPreview()
            End If


        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub GroupControl2_CustomButtonClick(sender As Object, e As DevExpress.XtraBars.Docking2010.BaseButtonEventArgs) Handles GroupControl2.CustomButtonClick
        Try
            If DgvExistenciaTotal.DataSource Is Nothing Then
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
                    CType(DgvExistenciaTotal.MainView, GridView).OptionsPrint.PrintHorzLines = False
                    CType(DgvExistenciaTotal.MainView, GridView).OptionsPrint.PrintVertLines = False
                    CType(DgvExistenciaTotal.MainView, GridView).OptionsPrint.PrintHeader = True
                    Dim advOptions As XlsxExportOptionsEx = New XlsxExportOptionsEx()
                    advOptions.SheetName = "Existencias totales por estatus"
                    advOptions.ShowColumnHeaders = DevExpress.Utils.DefaultBoolean.True

                    DgvExistenciaTotal.ExportToXlsx(path, advOptions)
                    Process.Start(path)

                End If
            End If
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub GroupControl3_CustomButtonClick(sender As Object, e As DevExpress.XtraBars.Docking2010.BaseButtonEventArgs) Handles GroupControl3.CustomButtonClick
        Try
            If DgvResultados.DataSource Is Nothing Then
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
                    CType(DgvResultados.MainView, GridView).OptionsPrint.PrintHorzLines = False
                    CType(DgvResultados.MainView, GridView).OptionsPrint.PrintVertLines = False
                    CType(DgvResultados.MainView, GridView).OptionsPrint.PrintHeader = True
                    Dim advOptions As XlsxExportOptionsEx = New XlsxExportOptionsEx()
                    advOptions.SheetName = "Pallets"
                    advOptions.ShowColumnHeaders = DevExpress.Utils.DefaultBoolean.True

                    DgvResultados.ExportToXlsx(path, advOptions)
                    Process.Start(path)

                End If
            End If
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub cmbCliente_EditValueChanged(sender As Object, e As EventArgs) Handles cmbCliente.EditValueChanged
        Try
            Dim text As String = cmbCliente.Text
            If text.Equals("System.Data.DataRowView") Then
                Return
            End If
            ListaNumParte(IIf(cmbCliente.Text = "TODOS", "@", cmbCliente.Text))
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message.ToString, "AXC", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub ChkDisponibles_CheckedChanged(sender As Object, e As EventArgs) Handles ChkDisponibles.CheckedChanged
        If ChkDisponibles.Checked Then
            ChkTotales.Checked = False
            ChkTotalesPorPos.Checked = False
            ChkDisponiblesPorPos.Checked = False
            ChkNoDisponibles.Checked = False
            ChkNoDisponiblesPorPos.Checked = False
        End If
    End Sub

    Private Sub ChkTotales_CheckedChanged(sender As Object, e As EventArgs) Handles ChkTotales.CheckedChanged
        If ChkTotales.Checked Then
            ChkDisponibles.Checked = False
            ChkTotalesPorPos.Checked = False
            ChkDisponiblesPorPos.Checked = False
            ChkNoDisponibles.Checked = False
            ChkNoDisponiblesPorPos.Checked = False
        End If
    End Sub

    Private Sub ChkDisponiblesPorPos_CheckedChanged(sender As Object, e As EventArgs) Handles ChkDisponiblesPorPos.CheckedChanged
        If ChkDisponiblesPorPos.Checked Then
            ChkDisponibles.Checked = False
            ChkTotalesPorPos.Checked = False
            ChkTotales.Checked = False
            ChkNoDisponibles.Checked = False
            ChkNoDisponiblesPorPos.Checked = False
        End If
    End Sub

    Private Sub ChkTotalesPorPos_CheckedChanged(sender As Object, e As EventArgs) Handles ChkTotalesPorPos.CheckedChanged
        If ChkTotalesPorPos.Checked Then
            ChkDisponibles.Checked = False
            ChkDisponiblesPorPos.Checked = False
            ChkTotales.Checked = False
            ChkNoDisponibles.Checked = False
            ChkNoDisponiblesPorPos.Checked = False
        End If
    End Sub

    Private Sub ChkNoDisponibles_CheckedChanged(sender As Object, e As EventArgs) Handles ChkNoDisponibles.CheckedChanged
        If ChkNoDisponibles.Checked Then
            ChkDisponibles.Checked = False
            ChkDisponiblesPorPos.Checked = False
            ChkTotales.Checked = False
            ChkTotalesPorPos.Checked = False
            ChkNoDisponiblesPorPos.Checked = False
        End If
    End Sub

    Private Sub ChkNoDisponiblesPorPos_CheckedChanged(sender As Object, e As EventArgs) Handles ChkNoDisponiblesPorPos.CheckedChanged
        If ChkNoDisponiblesPorPos.Checked Then
            ChkDisponibles.Checked = False
            ChkDisponiblesPorPos.Checked = False
            ChkTotales.Checked = False
            ChkTotalesPorPos.Checked = False
            ChkNoDisponibles.Checked = False
        End If
    End Sub

#End Region
End Class