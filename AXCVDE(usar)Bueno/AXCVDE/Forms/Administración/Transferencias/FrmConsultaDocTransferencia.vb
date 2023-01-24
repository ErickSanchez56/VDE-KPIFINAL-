Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraPrinting
Imports DevExpress.Utils

Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraReports.UI
Public Class FrmConsultaDocTransferencia
    Private Sub FrmConsultaDocTransferencia_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose(True)
    End Sub

    Private Sub FrmConsultaDocTransferencias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim TipoBus = New List(Of String)()
            TipoBus.Add("ORDEN TRAS")
            ' TipoBus.Add("CLIENTE")
            cmbTipo.Properties.DataSource = TipoBus
            cmbTipo.ItemIndex = 0
            dtpFechaFin.EditValue = Date.Now
            dtpFechaInicio.EditValue = Date.Now

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub



#Region "EVENTOS"
    Private Sub SbLiberacion_Click(sender As Object, e As EventArgs) Handles SbLiberacion.Click
        Try
            Dim FrmTraspasoSalidaPT As New FrmTraspasoSalidaPT
            Dim view As ColumnView = CType(dgvResultado.MainView, ColumnView)
            Dim selectedRowHandles As Integer() = view.GetSelectedRows

            Dim Documento As String = ""
            Documento = (view.GetRowCellValue(selectedRowHandles(0), "Documento"))
            FrmTraspasoSalidaPT.pOrdenT = Documento
            FrmTraspasoSalidaPT.MdiParent = FrmMenuPrincipal.XtraTabbedMdiManager1.MdiParent
            FrmTraspasoSalidaPT.Show()
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub GridView1_DoubleClick(sender As Object, e As EventArgs) Handles GridView1.DoubleClick
        Try
            If GridView1.RowCount <= 0 Then
                Return
            End If

            Dim view As ColumnView = CType(dgvResultado.MainView, ColumnView)

            Dim selectedRowHandles As Integer() = view.GetSelectedRows

            Dim OrdenTras As String = ""
            OrdenTras = (view.GetRowCellValue(selectedRowHandles(0), "Documento"))
            Dim FrmOrdenesSurtidoTras As New FrmOrdenesSurtidoTras
            FrmOrdenesSurtidoTras.pOrdenTras = OrdenTras
            FrmOrdenesSurtidoTras.ShowDialog()

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub

    Private Sub dgvResultado_Click(sender As Object, e As EventArgs) Handles dgvResultado.Click
        Try
            If GridView1.RowCount <= 0 Then
                Return
            End If
            Dim cls As New clsEmbarque

            Dim view As ColumnView = CType(dgvResultado.MainView, ColumnView)

            Dim selectedrowHandles As Integer() = view.GetSelectedRows

            Dim OrdenProd As String = ""
            OrdenProd = (view.GetRowCellValue(selectedrowHandles(0), "Documento"))
            CargaDetalle(OrdenProd)
            SbLiberacion.Enabled = True

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub

    Private Sub GroupControl2_CustomButtonClick(sender As Object, e As DevExpress.XtraBars.Docking2010.BaseButtonEventArgs) Handles GroupControl2.CustomButtonClick
        Try
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
                    advOptions.SheetName = "Encabezado de orden de Tras"
                    advOptions.ShowColumnHeaders = DevExpress.Utils.DefaultBoolean.True

                    dgvResultado.ExportToXlsx(path, advOptions)
                    Process.Start(path)

                End If
            End If
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub GroupControl3_CustomButtonClick(sender As Object, e As DevExpress.XtraBars.Docking2010.BaseButtonEventArgs) Handles GroupControl3.CustomButtonClick
        Try
            If dgvDetalle.DataSource Is Nothing Then
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
                    CType(dgvDetalle.MainView, GridView).OptionsPrint.PrintHorzLines = False
                    CType(dgvDetalle.MainView, GridView).OptionsPrint.PrintVertLines = False
                    CType(dgvDetalle.MainView, GridView).OptionsPrint.PrintHeader = True
                    Dim advOptions As XlsxExportOptionsEx = New XlsxExportOptionsEx()
                    advOptions.SheetName = "Detalle de orden de Tras"
                    advOptions.ShowColumnHeaders = DevExpress.Utils.DefaultBoolean.True

                    dgvDetalle.ExportToXlsx(path, advOptions)
                    Process.Start(path)

                End If
            End If
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

#End Region


    Private Sub btnBuscar_Click_1(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            Dim pBusqueda As String = "@"

            If String.IsNullOrEmpty(txtBusqueda.Text.Trim()) Then
                pBusqueda = "@"
            Else
                pBusqueda = txtBusqueda.Text
            End If
            cargarResultados(pBusqueda)

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub


#Region "METODOS"
    Private Sub cargarResultados(prmBusqueda As String)
        Try
            dgvResultado.DataSource = Nothing

            Dim pResultado As New CResultado
            Dim Cls As New clsTransfer

            Dim dInicio As New Date
            Dim dFin As New Date
            dInicio = Date.Parse(dtpFechaInicio.EditValue.ToString)
            dFin = Date.Parse(dtpFechaFin.EditValue.ToString)

            Cursor.Current = Cursors.WaitCursor

            pResultado = Cls.ConsultaListaOrdenTRAS(1, prmBusqueda, dInicio.ToString("yyyyMMdd"), dFin.ToString("yyyyMMdd"), My.Settings.Estacion, DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                dgvResultado.DataSource = Nothing
                Return
            End If
            Dim dt As New DataTable
            Dim ds As New DataSet

            dt = pResultado.Tabla
            ds.Tables.Add(dt)

            If dt.Rows.Count < 1 Then
                XtraMessageBox.Show("Sin información con los filtros seleccionados")
                dgvResultado.DataSource = Nothing
                Return
            End If

            dgvResultado.DataSource = dt
            GridView1.BestFitColumns()

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub CargaDetalle(prmBusqueda As String)
        Try
            dgvDetalle.DataSource = Nothing

            Dim pResultado As New CResultado
            Dim cls As New clsTransfer

            Cursor.Current = Cursors.WaitCursor
            pResultado = cls.ConsultaOrdenTrasDet(prmBusqueda)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                dgvDetalle.DataSource = Nothing
                Return
            End If

            Dim dt As New DataTable
            Dim ds As New DataSet

            dt = pResultado.Tabla
            ds.Tables.Add(dt)

            If dt.Rows.Count < 1 Then
                XtraMessageBox.Show("Sin información")
                dgvDetalle.DataSource = Nothing
                Return
            End If

            dgvDetalle.DataSource = dt
            GridView2.BestFitColumns()

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region
End Class