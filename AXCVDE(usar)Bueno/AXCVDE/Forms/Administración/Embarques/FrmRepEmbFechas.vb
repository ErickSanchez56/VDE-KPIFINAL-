Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraPrinting

Public Class FrmRepEmbFechas

#Region "VARIABLES"
    Dim dsReporte As New DataSet
#End Region

    Private Sub btnGenera_Click(sender As Object, e As EventArgs) Handles btnGenera.Click
        Try
            BuscarEmbarques()
        Catch ex As Exception
            MsgBox("Error: " + ex.Message, MsgBoxStyle.Critical, "AXC")
        End Try
    End Sub

    Private Sub BuscarEmbarques()
        Try
            Dim pResultado As New CResultado
            Dim pEmb As New clsEmbarque
            dsReporte = New DataSet

            Dim dInicio As New Date
            Dim dFin As New Date
            dInicio = Date.Parse(dtpFechaInicio.EditValue.ToString)
            dFin = Date.Parse(dtpFechaFin.EditValue.ToString)

            Cursor.Current = Cursors.WaitCursor
            pResultado = pEmb.BuscarEmbarquesPorFecha(dInicio.ToString("yyyyMMdd"), dFin.ToString("yyyyMMdd"), My.Settings.Estacion, DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                MsgBox(pResultado.Texto)
                Return
            End If
            Dim dt As New DataTable
            Dim ds As New DataSet

            dt = pResultado.Tabla
            ds.Tables.Add(dt)

            If dt.Rows.Count < 1 Then
                XtraMessageBox.Show("No hay información con el filtro seleccionado", "AXC")
                Return
            End If

            DgvDatos.DataSource = dt
            If DgvDatos.DataSource Is Nothing Then
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
                    CType(DgvDatos.MainView, GridView).OptionsPrint.PrintHorzLines = False
                    CType(DgvDatos.MainView, GridView).OptionsPrint.PrintVertLines = False
                    CType(DgvDatos.MainView, GridView).OptionsPrint.PrintHeader = True
                    Dim advOptions As XlsxExportOptionsEx = New XlsxExportOptionsEx()
                    advOptions.SheetName = "Recibos de orden de compra por fecha"
                    advOptions.ShowColumnHeaders = DevExpress.Utils.DefaultBoolean.True

                    DgvDatos.ExportToXlsx(path, advOptions)
                    Process.Start(path)

                End If
            End If

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub
End Class