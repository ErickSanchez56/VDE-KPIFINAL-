Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraPrinting

Public Class FrmReferencia
    Private Sub FrmReferencia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            TxtBusqueda.Select()

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Try
            ConsultaReferencia()
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ConsultaReferencia()
        Try
            DgvResultado.DataSource = Nothing

            Dim pResultado As New CResultado
            Dim Cls As New ClsHerramientas

            Cursor.Current = Cursors.WaitCursor
            pResultado = Cls.ListaReferencias(IIf(String.IsNullOrEmpty(TxtBusqueda.Text), "@", TxtBusqueda.Text), My.Settings.Estacion, DatosTemporales.Usuario)
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
                XtraMessageBox.Show("No hay información con este filtro")
                DgvResultado.DataSource = Nothing
                Return
            End If

            DgvResultado.DataSource = dt

            DgvViewResultado.Columns("Fecha").DisplayFormat.FormatString = "g"
            DgvViewResultado.BestFitColumns()

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub FrmReferencia_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose(True)
    End Sub

    Private Sub btnExportar_Click(sender As Object, e As EventArgs) Handles btnExportar.Click
        Try

            If DgvResultado.DataSource Is Nothing Then
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
                    CType(DgvResultado.MainView, GridView).OptionsPrint.PrintHorzLines = False
                    CType(DgvResultado.MainView, GridView).OptionsPrint.PrintVertLines = False
                    CType(DgvResultado.MainView, GridView).OptionsPrint.PrintHeader = True
                    Dim advOptions As XlsxExportOptionsEx = New XlsxExportOptionsEx()
                    'advOptions.AllowGrouping = DevExpress.Utils.DefaultBoolean.False
                    'advOptions.ShowTotalSummaries = DevExpress.Utils.DefaultBoolean.False
                    advOptions.SheetName = "Transacciones"
                    advOptions.ShowColumnHeaders = DevExpress.Utils.DefaultBoolean.True

                    DgvResultado.ExportToXlsx(path, advOptions)
                    ' Open the created XLSX file with the default application.
                    Process.Start(path)

                End If
            End If

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub TxtBusqueda_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtBusqueda.KeyPress
        Try
            If e.KeyChar = Convert.ToChar(Keys.Enter) Then
                ConsultaReferencia()
            End If
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub
End Class