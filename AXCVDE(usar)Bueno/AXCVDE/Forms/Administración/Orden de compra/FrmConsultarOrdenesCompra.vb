Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraReports.UI

Public Class FrmConsultarOrdenesCompra


#Region "VARIABLES"
    Dim dsReporte As New DataSet
#End Region

#Region "EVENTOS"


    Private Sub FrmConsultarOrdenesCompra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim TipoBus = New List(Of String)()
            TipoBus.Add("ORDEN DE COMPRA")
            TipoBus.Add("PRODUCTO")
            TipoBus.Add("PROVEEDOR")
            TipoBus.Add("FACTURA")
            cmbTipo.Properties.DataSource = TipoBus
            cmbTipo.ItemIndex = 0
            dtpFechaFin.EditValue = Date.Now
            dtpFechaInicio.EditValue = Date.Now

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub


    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Try
            Dim pBusqueda As String = "@"

            If String.IsNullOrEmpty(txtBusqueda.Text.Trim()) Then
                pBusqueda = "@"
            Else
                pBusqueda = txtBusqueda.Text
            End If
            cargarResultados(pBusqueda)
            btnLiberacion.Enabled = True
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub


#End Region

#Region "METODOS"
    Public Sub cargarResultados(ByVal prmBusqueda As String)
        Try
            dsReporte = New DataSet
            dgvResultado.DataSource = Nothing
            dgvDetalle.DataSource = Nothing
            Dim pConsulta As New ClsOrdenCompra
            Dim ds As New DataSet

            Dim dInicio As New Date
            Dim dFin As New Date
            dInicio = Date.Parse(dtpFechaInicio.EditValue.ToString)
            dFin = Date.Parse(dtpFechaFin.EditValue.ToString)

            ds = (pConsulta.ConsultaOrdenCompra(cmbTipo.ItemIndex, prmBusqueda, dInicio.ToString("yyyyMMdd"), dFin.ToString("yyyyMMdd"), My.Settings("Estacion"), DatosTemporales.Usuario))
            If ds.Tables.Count = 1 Then
                XtraMessageBox.Show("No hay información a reportar", "AXC")
                Return
            End If
            dgvResultado.DataSource = ds.Tables(1)
            GridView1.BestFitColumns()
            dsReporte.Tables.Add(ds.Tables(1).Copy())
        Catch ex As Exception
            XtraMessageBox.Show("Error: " + ex.Message, "AXC")
        End Try
    End Sub

    Public Sub CargarDetalle(ByVal prmRecibo As Integer, ByVal prmOrdenCompra As String)
        Try
            dgvDetalle.DataSource = Nothing

            Dim pResultado As New CResultado
            Dim cls As New ClsOrdenCompra

            Cursor.Current = Cursors.WaitCursor
            pResultado = cls.ConsultaOrdenCompraDet(prmRecibo, prmOrdenCompra)
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
                XtraMessageBox.Show("No se encontraron recibos para esta orden de compra")
                dgvDetalle.DataSource = Nothing
                Return
            End If

            dgvDetalle.DataSource = dt
            GridView2.BestFitColumns()

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnReporte_Click(sender As Object, e As EventArgs) Handles BtnReporte.Click
        Try
            FrmRepRecFechas.ShowDialog()
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub

    Private Sub FrmConsultarOrdenesCompra_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose(True)
    End Sub

    Private Sub GridView1_DoubleClick(sender As Object, e As EventArgs) Handles GridView1.DoubleClick
        Try
            If GridView1.RowCount <= 0 Then
                Return
            End If

            Dim view As ColumnView = CType(dgvResultado.MainView, ColumnView)

            Dim selectedRowHandles As Integer() = view.GetSelectedRows

            Dim OrdenCompra As String = ""
            OrdenCompra = (view.GetRowCellValue(selectedRowHandles(0), "OrdenCompra"))
            FrmRecibosOC.pOrdenCompra = OrdenCompra
            FrmRecibosOC.ShowDialog()


        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub

    Private Sub dgvResultado_Click(sender As Object, e As EventArgs) Handles dgvResultado.Click
        Try
            If GridView1.RowCount <= 0 Then
                Return
            End If

            Dim cls As New ClsOrdenCompra

            Dim view As ColumnView = CType(dgvResultado.MainView, ColumnView)

            Dim selectedrowHandles As Integer() = view.GetSelectedRows

            Dim OrdenCompraD As String = ""
            Dim idRecibo = view.GetRowCellValue(selectedrowHandles(0), "IdRecibo").ToString
            OrdenCompraD = (view.GetRowCellValue(selectedrowHandles(0), "OrdenCompra"))
            CargarDetalle(IIf(idRecibo = "", 0, idRecibo), OrdenCompraD)
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub

    Private Sub btnLiberacion_Click(sender As Object, e As EventArgs) Handles btnLiberacion.Click
        Try
            Dim frmLiberaOrdenCompra As New FrmLiberaOrdenCompra
            Dim view As ColumnView = CType(dgvResultado.MainView, ColumnView)
            Dim selectedRowHandles As Integer() = view.GetSelectedRows

            Dim OrdenCompraD As String = ""
            OrdenCompraD = (view.GetRowCellValue(selectedRowHandles(0), "OrdenCompra"))
            frmLiberaOrdenCompra.pOrdenCompra = OrdenCompraD
            frmLiberaOrdenCompra.MdiParent = FrmMenuPrincipal.XtraTabbedMdiManager1.MdiParent
            frmLiberaOrdenCompra.Show()
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
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
                    advOptions.SheetName = "Encabezado de orden de compra"
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
                    advOptions.SheetName = "Detalle de orden de compra"
                    advOptions.ShowColumnHeaders = DevExpress.Utils.DefaultBoolean.True

                    dgvDetalle.ExportToXlsx(path, advOptions)
                    Process.Start(path)

                End If
            End If
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub txtBusqueda_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBusqueda.KeyPress
        Try
            If e.KeyChar = Convert.ToChar(Keys.Enter) Then
                Dim pBusqueda As String = "@"

                If String.IsNullOrEmpty(txtBusqueda.Text.Trim()) Then
                    pBusqueda = "@"
                Else
                    pBusqueda = txtBusqueda.Text
                End If
                cargarResultados(pBusqueda)
                btnLiberacion.Enabled = True
            End If
        Catch ex As Exception
            XtraMessageBox.Show("Error: " + ex.Message, "AXC")
        End Try
    End Sub

#End Region
End Class