Imports DevExpress.Data
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraPrinting

Public Class FrmSurtidosPedidosDetalle

    Public pOrdenEmbarque As String

    Private Sub FrmSurtidosPedidosDetalle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If pOrdenEmbarque <> Nothing Then
                ConsultaSurtidos(pOrdenEmbarque)
            End If
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub

    Public Sub ConsultaSurtidos(ByVal prmBusqueda As String)
        Try
            dgvResultado.DataSource = Nothing

            Dim pResultado As New CResultado
            Dim Cls As New clsEmbarque


            Cursor.Current = Cursors.WaitCursor
            pResultado = Cls.ConsultaSurtidos(prmBusqueda, My.Settings.Estacion, DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                Me.Close()
                dgvResultado.DataSource = Nothing
                Return
            End If
            Dim dt As New DataTable
            Dim ds As New DataSet

            dt = pResultado.Tabla
            ds.Tables.Add(dt)

            If dt.Rows.Count < 1 Then
                XtraMessageBox.Show("No hay información de pedidos con los filtros seleccionados")
                dgvResultado.DataSource = Nothing
                Return
            End If

            dgvResultado.DataSource = dt
            Dim sortInfo As GridColumnSortInfo() = {New GridColumnSortInfo(GridView1.Columns("IdOrdenSurtido"), ColumnSortOrder.Ascending)}
            GridView1.SortInfo.ClearAndAddRange(sortInfo, 1)
            GridView1.BestFitColumns()

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub GroupControl2_CustomButtonClick(sender As Object, e As DevExpress.XtraBars.Docking2010.BaseButtonEventArgs) Handles GroupControl2.CustomButtonClick
        If dgvResultado.DataSource Is Nothing Then
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
                CType(dgvResultado.MainView, GridView).OptionsPrint.PrintHorzLines = False
                CType(dgvResultado.MainView, GridView).OptionsPrint.PrintVertLines = False
                CType(dgvResultado.MainView, GridView).OptionsPrint.PrintHeader = True
                Dim advOptions As XlsxExportOptionsEx = New XlsxExportOptionsEx()
                'advOptions.AllowGrouping = DevExpress.Utils.DefaultBoolean.False
                'advOptions.ShowTotalSummaries = DevExpress.Utils.DefaultBoolean.False
                advOptions.SheetName = "Detalle surtido"
                advOptions.ShowColumnHeaders = DevExpress.Utils.DefaultBoolean.True

                dgvResultado.ExportToXlsx(path, advOptions)
                ' Open the created XLSX file with the default application.
                Process.Start(path)

            End If
        End If
    End Sub
End Class