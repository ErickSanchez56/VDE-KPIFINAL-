Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraReports.UI

Public Class FrmMonitorSurtido

#Region "VARIABLES"
    Dim dsReporte As New DataSet
#End Region

    Private Sub FrmMonitorSurtido_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            BuscarEmbarque("@")
            TxtBusqueda.Select()
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub TxtBusqueda_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtBusqueda.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            Dim pBusqueda As String = "@"


            If String.IsNullOrEmpty(TxtBusqueda.Text.Trim()) Then
                pBusqueda = "@"
            Else
                pBusqueda = TxtBusqueda.Text
            End If

            BuscarEmbarque(pBusqueda)
        End If
    End Sub

#Region "METODOS"

    Private Sub BuscarEmbarque(prmEmbarque As String)
        Try
            DgvResultado.DataSource = Nothing


            Dim pResultado As New CResultado
            Dim pCons As New clsEmbarque

            Cursor.Current = Cursors.WaitCursor
            pResultado = pCons.ListaOrdenEmbarqueMonitorTodas(prmEmbarque, My.Settings.Estacion, DatosTemporales.Usuario)
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
                XtraMessageBox.Show("No existen embarques", "AXC")
                DgvResultado.DataSource = Nothing
                Return
            End If

            DgvResultado.DataSource = dt
            DgvViewResultado.BestFitColumns()


        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub

    Private Sub DgvViewResultado_DoubleClick(sender As Object, e As EventArgs) Handles DgvViewResultado.DoubleClick
        Try
            If DgvViewResultado.RowCount <= 0 Then
                Return
            End If

            Dim view As ColumnView = CType(DgvResultado.MainView, ColumnView)

            Dim selectedRowHandles As Integer() = view.GetSelectedRows

            dsReporte = New DataSet
            CargarPartidas(view.GetRowCellValue(selectedRowHandles(0), "Embarque"))
            PalletsSinCerrar(view.GetRowCellValue(selectedRowHandles(0), "Embarque"))
            PalletsPendientesValidacion(view.GetRowCellValue(selectedRowHandles(0), "Embarque"))
            PalletsPendientesEntrega(view.GetRowCellValue(selectedRowHandles(0), "Embarque"))
            PalletsTransito(view.GetRowCellValue(selectedRowHandles(0), "Embarque"))

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub CargarPartidas(prmBusqueda As String)
        Try
            DgvPartidas.DataSource = Nothing

            Dim pResultado As New CResultado
            Dim Cls As New clsEmbarque

            Cursor.Current = Cursors.WaitCursor
            pResultado = Cls.ListarPartidas(prmBusqueda, My.Settings.Estacion, DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                DgvPartidas.DataSource = Nothing
                Return
            End If
            Dim dt As New DataTable
            Dim ds As New DataSet

            dt = pResultado.Tabla
            ds.Tables.Add(dt)
            dt.TableName = "Detalle"
            dsReporte.Tables.Add(dt.Copy)


            DgvPartidas.DataSource = dt
            DgvViewPartidas.BestFitColumns()
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub PalletsSinCerrar(prmBusqueda As String)
        Try
            DgvPalletsSinCerrar.DataSource = Nothing

            Dim pResultado As New CResultado
            Dim Cls As New clsEmbarque

            Cursor.Current = Cursors.WaitCursor
            pResultado = Cls.ListaPalletsSinCerrar(prmBusqueda, My.Settings.Estacion, DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                DgvPalletsSinCerrar.DataSource = Nothing
                Return
            End If
            Dim dt As New DataTable
            Dim ds As New DataSet

            dt = pResultado.Tabla
            ds.Tables.Add(dt)

            DgvPalletsSinCerrar.DataSource = dt
            DgvVierPalletsSinCerrar.BestFitColumns()
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub PalletsPendientesValidacion(prmBusqueda As String)
        Try
            DgvPalletsPendientesVal.DataSource = Nothing

            Dim pResultado As New CResultado
            Dim Cls As New clsEmbarque

            Cursor.Current = Cursors.WaitCursor
            pResultado = Cls.ListaPalletsPteValida(prmBusqueda, My.Settings.Estacion, DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                DgvPalletsPendientesVal.DataSource = Nothing
                Return
            End If
            Dim dt As New DataTable
            Dim ds As New DataSet

            dt = pResultado.Tabla
            ds.Tables.Add(dt)

            DgvPalletsPendientesVal.DataSource = dt
            DgvViewPalletsPendientesVal.BestFitColumns()
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub PalletsPendientesEntrega(prmBusqueda As String)
        Try
            DgvPalletsPendientesEntregaD.DataSource = Nothing

            Dim pResultado As New CResultado
            Dim Cls As New clsEmbarque

            Cursor.Current = Cursors.WaitCursor
            pResultado = Cls.ListaPalletsPteEntrega(prmBusqueda, My.Settings.Estacion, DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                DgvPalletsPendientesEntregaD.DataSource = Nothing
                Return
            End If
            Dim dt As New DataTable
            Dim ds As New DataSet

            dt = pResultado.Tabla
            ds.Tables.Add(dt)

            DgvPalletsPendientesEntregaD.DataSource = dt
            DgvViewPalletsPendientesEntrega.BestFitColumns()
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub PalletsTransito(prmBusqueda As String)
        Try
            DgvPalletsEmbarcados.DataSource = Nothing

            Dim pResultado As New CResultado
            Dim Cls As New clsEmbarque

            Cursor.Current = Cursors.WaitCursor
            pResultado = Cls.ListaPalletsPteTransito(prmBusqueda, My.Settings.Estacion, DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                DgvPalletsEmbarcados.DataSource = Nothing
                Return
            End If
            Dim dt As New DataTable
            Dim ds As New DataSet

            dt = pResultado.Tabla
            ds.Tables.Add(dt)
            dt.TableName = "Pallets"
            dsReporte.Tables.Add(dt.Copy)

            DgvPalletsEmbarcados.DataSource = dt
            DgvViewEmbarcados.BestFitColumns()
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Try
            Dim pBusqueda As String = "@"


            If String.IsNullOrEmpty(TxtBusqueda.Text.Trim()) Then
                pBusqueda = "@"
            Else
                pBusqueda = TxtBusqueda.Text
            End If

            BuscarEmbarque(pBusqueda)
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub btnReporte_Click(sender As Object, e As EventArgs) Handles btnReporte.Click
        Try
            If XtraMessageBox.Show("¿Generar reporte?", "Confirmación", MessageBoxButtons.YesNo) <> DialogResult.Yes Then
                Return
            End If

            If DgvPartidas.DataSource Is Nothing Then
                XtraMessageBox.Show("No hay orden de embarque seleccionada para generar el reporte", "AXC")
                Return
            End If



            Dim RepExistencias As New DevRepPKListEmb
            RepExistencias.DetailReport.DataSource = dsReporte.Tables(0)
            RepExistencias.DetailReport1.DataSource = dsReporte.Tables(1)
            Dim designTool As New ReportPrintTool(RepExistencias)
            designTool.ShowPreview()


        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub FrmMonitorSurtido_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose(True)
    End Sub

    Private Sub GroupControl4_CustomButtonClick(sender As Object, e As DevExpress.XtraBars.Docking2010.BaseButtonEventArgs) Handles GroupControl4.CustomButtonClick
        Try

            If DgvPartidas.DataSource Is Nothing Then
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
                    CType(DgvPartidas.MainView, GridView).OptionsPrint.PrintHorzLines = False
                    CType(DgvPartidas.MainView, GridView).OptionsPrint.PrintVertLines = False
                    CType(DgvPartidas.MainView, GridView).OptionsPrint.PrintHeader = True
                    Dim advOptions As XlsxExportOptionsEx = New XlsxExportOptionsEx()
                    'advOptions.AllowGrouping = DevExpress.Utils.DefaultBoolean.False
                    'advOptions.ShowTotalSummaries = DevExpress.Utils.DefaultBoolean.False
                    advOptions.SheetName = "Partidas de embarque"
                    advOptions.ShowColumnHeaders = DevExpress.Utils.DefaultBoolean.True

                    DgvPartidas.ExportToXlsx(path, advOptions)
                    ' Open the created XLSX file with the default application.
                    Process.Start(path)

                End If
            End If

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub GroupControl1_CustomButtonClick(sender As Object, e As DevExpress.XtraBars.Docking2010.BaseButtonEventArgs) Handles GroupControl1.CustomButtonClick
        Try
            If DgvPalletsSinCerrar.DataSource Is Nothing Then
                XtraMessageBox.Show("No hay información para exportar", "Información", MessageBoxButtons.OK)
                Return
            End If
            Dim path As String = ""

            Dim sv As New SaveFileDialog
            sv.Filter = "Excel Workbook|*.xlsx"
            If sv.ShowDialog() = DialogResult.OK And sv.FileName <> Nothing Then
                If sv.FileName.EndsWith(".xlsx") Then
                    path = sv.FileName.ToString()
                    CType(DgvPalletsSinCerrar.MainView, GridView).OptionsPrint.PrintHorzLines = False
                    CType(DgvPalletsSinCerrar.MainView, GridView).OptionsPrint.PrintVertLines = False
                    CType(DgvPalletsSinCerrar.MainView, GridView).OptionsPrint.PrintHeader = True
                    Dim advOptions As XlsxExportOptionsEx = New XlsxExportOptionsEx()
                    advOptions.SheetName = "Pallets sin cerrar"
                    advOptions.ShowColumnHeaders = DevExpress.Utils.DefaultBoolean.True

                    DgvPalletsSinCerrar.ExportToXlsx(path, advOptions)
                    Process.Start(path)

                End If
            End If

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub GroupControl2_CustomButtonClick(sender As Object, e As DevExpress.XtraBars.Docking2010.BaseButtonEventArgs) Handles GroupControl2.CustomButtonClick
        Try

            If DgvPalletsPendientesVal.DataSource Is Nothing Then
                XtraMessageBox.Show("No hay información para exportar", "Información", MessageBoxButtons.OK)
                Return
            End If
            Dim path As String = ""

            Dim sv As New SaveFileDialog
            sv.Filter = "Excel Workbook|*.xlsx"
            If sv.ShowDialog() = DialogResult.OK And sv.FileName <> Nothing Then
                If sv.FileName.EndsWith(".xlsx") Then
                    path = sv.FileName.ToString()
                    CType(DgvPalletsPendientesVal.MainView, GridView).OptionsPrint.PrintHorzLines = False
                    CType(DgvPalletsPendientesVal.MainView, GridView).OptionsPrint.PrintVertLines = False
                    CType(DgvPalletsPendientesVal.MainView, GridView).OptionsPrint.PrintHeader = True
                    Dim advOptions As XlsxExportOptionsEx = New XlsxExportOptionsEx()
                    advOptions.SheetName = "Pallets pendientes de validación"
                    advOptions.ShowColumnHeaders = DevExpress.Utils.DefaultBoolean.True

                    DgvPalletsPendientesVal.ExportToXlsx(path, advOptions)
                    Process.Start(path)

                End If
            End If

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub GroupControl3_CustomButtonClick(sender As Object, e As DevExpress.XtraBars.Docking2010.BaseButtonEventArgs) Handles GroupControl3.CustomButtonClick
        Try

            If DgvPalletsPendientesEntregaD.DataSource Is Nothing Then
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
                    CType(DgvPalletsPendientesEntregaD.MainView, GridView).OptionsPrint.PrintHorzLines = False
                    CType(DgvPalletsPendientesEntregaD.MainView, GridView).OptionsPrint.PrintVertLines = False
                    CType(DgvPalletsPendientesEntregaD.MainView, GridView).OptionsPrint.PrintHeader = True
                    Dim advOptions As XlsxExportOptionsEx = New XlsxExportOptionsEx()
                    advOptions.SheetName = "Pallets pendientes de entrega"
                    advOptions.ShowColumnHeaders = DevExpress.Utils.DefaultBoolean.True

                    DgvPalletsPendientesEntregaD.ExportToXlsx(path, advOptions)
                    Process.Start(path)

                End If
            End If

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub GroupControl5_CustomButtonClick(sender As Object, e As DevExpress.XtraBars.Docking2010.BaseButtonEventArgs) Handles GroupControl5.CustomButtonClick
        Try

            If DgvPalletsEmbarcados.DataSource Is Nothing Then
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
                    CType(DgvPalletsEmbarcados.MainView, GridView).OptionsPrint.PrintHorzLines = False
                    CType(DgvPalletsEmbarcados.MainView, GridView).OptionsPrint.PrintVertLines = False
                    CType(DgvPalletsEmbarcados.MainView, GridView).OptionsPrint.PrintHeader = True
                    Dim advOptions As XlsxExportOptionsEx = New XlsxExportOptionsEx()
                    advOptions.SheetName = "Pallets embarcados"
                    advOptions.ShowColumnHeaders = DevExpress.Utils.DefaultBoolean.True

                    DgvPalletsPendientesEntregaD.ExportToXlsx(path, advOptions)
                    Process.Start(path)

                End If
            End If

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click

    End Sub

#End Region
End Class