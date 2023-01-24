Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraReports.UI

Public Class FrmExistenciasGeneralVisor
#Region "VARIABLES"
    Dim nuevo As New clsExistencias
    Dim nuevoNumParte As New clsNumParte
    Dim dsTotales As New DataSet
#End Region

#Region "EVENTOS"

    Public Property pNumParte As String
    Public Property pLote As String
    Public Property pAlmacen As String
    Public Property pPosicion As String
    Public Property pCliente As String
    Private Sub FrmExistenciasGeneral_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            pLote = "@"
            pAlmacen = "@"
            pPosicion = "@"
            pCliente = "@"
            CargarTotalExistencias(pNumParte, pLote, pAlmacen, pPosicion, pCliente)
        Catch ex As Exception
            XtraMessageBox.Show("Error: " + ex.Message, "AXC")
        End Try
    End Sub

    Private Sub CargarTotalExistencias(prmNUmParte As String, ByVal prmLote As String, ByVal prmAlmacen As String, ByVal prmPosicion As String, ByVal prmCliente As String)
        Try
            DgvExistenciaTotal.DataSource = Nothing
            DgvExistenciaTotal.Refresh()

            Dim pResultado As New CResultado
            Dim pCons As New clsExistencias

            Cursor.Current = Cursors.WaitCursor
            pResultado = pCons.CargarTotalExistencias(prmNUmParte, prmLote, prmAlmacen, prmPosicion, prmCliente, My.Settings.Estacion, DatosTemporales.Usuario)
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


#End Region

#Region "METODOS"
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
            pResultado = pCons.ConsultaPallet(prmAlmacen, pPosicion, prmNumParte, prmLote, prmEstatus, My.Settings.Estacion, DatosTemporales.Usuario)
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
#End Region
End Class