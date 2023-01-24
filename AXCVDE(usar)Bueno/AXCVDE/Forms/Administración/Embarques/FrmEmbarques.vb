Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraReports.UI

Public Class FrmEmbarques
    Private Sub FrmEmbarques_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim TipoBus = New List(Of String)()
            TipoBus.Add("ORDEN DE EMBARQUE")
            TipoBus.Add("CLIENTE")
            cmbTipo.Properties.DataSource = TipoBus
            cmbTipo.ItemIndex = 0
            dtpFechaFin.EditValue = Date.Now
            dtpFechaInicio.EditValue = Date.Now

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
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

    Private Sub cargarResultados(prmBusqueda As String)
        Try
            dgvResultado.DataSource = Nothing

            Dim pResultado As New CResultado
            Dim Cls As New clsEmbarque

            Dim dInicio As New Date
            Dim dFin As New Date
            dInicio = Date.Parse(dtpFechaInicio.EditValue.ToString)
            dFin = Date.Parse(dtpFechaFin.EditValue.ToString)

            Cursor.Current = Cursors.WaitCursor
            pResultado = Cls.ConsultaEmbarque(cmbTipo.ItemIndex, prmBusqueda, dInicio.ToString("yyyyMMdd"), dFin.ToString("yyyyMMdd"), My.Settings("Estacion"), DatosTemporales.Usuario)
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

    Private Sub GridView1_DoubleClick(sender As Object, e As EventArgs) Handles GridView1.DoubleClick
        Try
            If GridView1.RowCount <= 0 Then
                Return
            End If

            Dim view As ColumnView = CType(dgvResultado.MainView, ColumnView)

            Dim selectedRowHandles As Integer() = view.GetSelectedRows

            Dim OrdenEmbarque As String = ""
            OrdenEmbarque = (view.GetRowCellValue(selectedRowHandles(0), "OrdenEmbarque"))
            FrmEmbarquesDetalle.pOrdenEmbarque = OrdenEmbarque
            FrmEmbarquesDetalle.ShowDialog()

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

            Dim OrdenEmbarqueD As String = ""
            OrdenEmbarqueD = (view.GetRowCellValue(selectedrowHandles(0), "OrdenEmbarque"))
            CargaDetalle(OrdenEmbarqueD)
            SbLiberacion.Enabled = True

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub

    Private Sub CargaDetalle(prmOrdenEmbarque As String)
        Try
            dgvDetalle.DataSource = Nothing

            Dim pResultado As New CResultado
            Dim cls As New clsEmbarque

            Cursor.Current = Cursors.WaitCursor
            pResultado = cls.ConsultaOEDet(prmOrdenEmbarque)
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

    Private Sub SbLiberacion_Click(sender As Object, e As EventArgs) Handles SbLiberacion.Click
        Try
            Dim FrmLiberaOrdenEmb As New FrmLiberaOrdenEmbarque
            Dim view As ColumnView = CType(dgvResultado.MainView, ColumnView)
            Dim selectedRowHandles As Integer() = view.GetSelectedRows

            Dim OrdenEmbarque As String = ""
            OrdenEmbarque = (view.GetRowCellValue(selectedRowHandles(0), "OrdenEmbarque"))
            FrmLiberaOrdenEmb.pOrdenEmbarque = OrdenEmbarque
            FrmLiberaOrdenEmb.MdiParent = FrmMenuPrincipal.XtraTabbedMdiManager1.MdiParent
            FrmLiberaOrdenEmb.Show()
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnReporte_Click(sender As Object, e As EventArgs) Handles BtnReporte.Click
        Try
            FrmRepEmbFechas.ShowDialog()
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
                    advOptions.SheetName = "Encabezado de orden de embarque"
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
                    advOptions.SheetName = "Detalle de orden de embarque"
                    advOptions.ShowColumnHeaders = DevExpress.Utils.DefaultBoolean.True

                    dgvDetalle.ExportToXlsx(path, advOptions)
                    Process.Start(path)

                End If
            End If
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub
End Class