Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraReports.UI

Public Class FrmMonitorTraspaso
#Region "VARIABLES"
    Dim nuevo As New ClsMaterialRecibido
    Public pTraspaso As String
    Dim dsReporte As New DataSet
#End Region

#Region "EVENTOS"
    Private Sub txtDocTraspaso_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDocTraspaso.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            Dim pDocTras As String
            Dim pStatus As String

            If String.IsNullOrEmpty(txtDocTraspaso.Text) Then
                pDocTras = "@"
                pStatus = "@"
            Else
                pDocTras = txtDocTraspaso.Text
                pStatus = "@"
            End If

            Dim dInicio As New Date
            Dim dFin As New Date
            dInicio = Date.Parse(dtpDesde.EditValue.ToString)
            dFin = Date.Parse(dtpHasta.EditValue.ToString)



            LimpiarGrids()
            CargaGridDetalle(nuevo.ConsultaDocumentoTraspaso(pDocTras, pStatus, dInicio.ToString("yyyyMMdd"), dFin.ToString("yyyyMMdd"), My.Settings("Estacion"), DatosTemporales.Usuario))

            pTraspaso = ""
        End If
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            Dim pDocTras As String
            Dim pStatus As String



            If String.IsNullOrEmpty(txtDocTraspaso.Text) Then
                pDocTras = "@"
                pStatus = "@"
            Else
                pDocTras = txtDocTraspaso.Text
                pStatus = "@"
            End If
            Dim dInicio As New Date
            Dim dFin As New Date
            dInicio = Date.Parse(dtpDesde.EditValue.ToString)
            dFin = Date.Parse(dtpHasta.EditValue.ToString)


            LimpiarGrids()

            CargaGridDetalle(nuevo.ConsultaDocumentoTraspaso(pDocTras, pStatus, dInicio.ToString("yyyyMMdd"), dFin.ToString("yyyyMMdd"), My.Settings("Estacion"), DatosTemporales.Usuario))

            pTraspaso = ""

        Catch ex As Exception
            XtraMessageBox.Show("Error: " + ex.Message, "AXC")
        End Try
    End Sub

    Private Sub FrmMonitorTraspaso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            dtpDesde.EditValue = Date.Now.ToShortDateString
            dtpHasta.EditValue = Date.Now.ToShortDateString
            txtDocTraspaso.Select()

        Catch ex As Exception
            XtraMessageBox.Show("Error: " + ex.Message, "AXC")
        End Try
    End Sub

    Private Sub FrmMonitorTraspaso_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose(True)
    End Sub
#End Region


#Region "METODOS"
    Sub CargaGridDetalle(ByVal ds As DataSet)

        Try
            dsReporte = New DataSet
            ds.Tables(1).TableName = "Det"
            dsReporte.Tables.Add(ds.Tables(1).Copy)
            grdDetalle.DataSource = ds.Tables(1)
            GridView1.BestFitColumns()

        Catch ex As Exception
            XtraMessageBox.Show("Error: " + ex.Message, "AXC")
        End Try
    End Sub

    Private Sub CargarGridPallets(prmBusqueda As String)
        Try
            DgvPallets.DataSource = Nothing

            Dim pResultado As New CResultado
            Dim Cls As New ClsMaterialRecibido

            Cursor.Current = Cursors.WaitCursor
            pResultado = Cls.ConsultaPalletsTraspaso(prmBusqueda, My.Settings.Estacion, DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                DgvPallets.DataSource = Nothing
                Return
            End If
            Dim dt As New DataTable
            Dim ds As New DataSet

            dt = pResultado.Tabla
            ds.Tables.Add(dt)

            ds.Tables(0).TableName = "Pallets"
            dsReporte.Tables.Add(ds.Tables(0).Copy)

            DgvPallets.DataSource = dt
            GridView2.BestFitColumns()

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub LimpiarGrids()

        grdDetalle.DataSource = Nothing
        DgvPallets.DataSource = Nothing
        ' GridView1.Rows.Clear()




    End Sub

    'Private Sub CancelarTraspaso(ByVal prmCodigoPallet As String)
    '    Try

    '        Dim pResultado As New CResultado
    '        Dim pCons As New clsTransfer

    '        Cursor.Current = Cursors.WaitCursor
    '        pResultado = pCons.CancerlarTraspaso(pTraspaso, prmCodigoPallet, My.Settings.Estacion, DatosTemporales.Usuario)
    '        Cursor.Current = Cursors.Default

    '        If Not pResultado.Estado Then
    '            MsgBox(pResultado.Texto)
    '            Return
    '        End If

    '        MsgBox("Pallet cancelado correctamente", MsgBoxStyle.OkOnly, "AXC")

    '        pTraspaso = ""



    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Critical, "AXC")
    '    End Try
    'End Sub

    Private Sub btnReporte_Click(sender As Object, e As EventArgs) Handles btnReporte.Click
        Try
            If XtraMessageBox.Show("Generar reporte?", "Confirmación", MessageBoxButtons.YesNo) <> DialogResult.Yes Then
                Return
            End If

            If grdDetalle.DataSource Is Nothing Then
                XtraMessageBox.Show("No hay información para generar el reporte", "AXC")
                Return
            End If

            If dsReporte.Tables Is Nothing Then

            End If

            If dsReporte.Tables.Count = 1 Then
                Dim dt As New DataTable
                dsReporte.Tables.Add(dt)
            End If

            '   Dim RepExistencias As New DevRepMonitorTransferencias
            'RepExistencias.DetailReport.DataSource = dsReporte.Tables(0)
            'RepExistencias.DetailReport2.DataSource = dsReporte.Tables(1)
            'Dim designTool As New ReportPrintTool(RepExistencias)
            'designTool.ShowPreviewDialog()

        Catch ex As Exception
            MsgBox("Error: " + ex.Message, MsgBoxStyle.Critical, "AXC")
        End Try
    End Sub

    Private Sub GridView2_DoubleClick(sender As Object, e As EventArgs) Handles  GridView1.DoubleClick
        Try
            If GridView1.RowCount <= 0 Then
                Return
            End If

            Dim pDocTras As String
            Dim pStatus As String = "@"

            Dim dInicio As New Date
            Dim dFin As New Date
            dInicio = Date.Parse(dtpDesde.EditValue.ToString)
            dFin = Date.Parse(dtpHasta.EditValue.ToString)

            Dim view As ColumnView = CType(grdDetalle.MainView, ColumnView)

            Dim selectedRowHandles As Integer() = view.GetSelectedRows
            txtDocTraspaso.Text = view.GetRowCellValue(selectedRowHandles(0), "Traspaso")
            pTraspaso = view.GetRowCellValue(selectedRowHandles(0), "Traspaso")
            CargaGridDetalle(nuevo.ConsultaDocumentoTraspaso(txtDocTraspaso.Text, pStatus, dInicio.ToString("yyyyMMdd"), dFin.ToString("yyyyMMdd"), My.Settings("Estacion"), DatosTemporales.Usuario))
            CargarGridPallets(txtDocTraspaso.Text)

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Try

            If String.IsNullOrEmpty(txtDocTraspaso.Text) Then
                XtraMessageBox.Show("El campo [Traspaso]  no debe estar vacío.Seleccione una traspaso", "AXC", MessageBoxButtons.OK)
                txtDocTraspaso.Select()
                Return
            End If
            If XtraMessageBox.Show("¿Deseas cerrar el documento [" + txtDocTraspaso.Text + "] parcial?", "Confirmación", MessageBoxButtons.YesNo) <> DialogResult.Yes Then
                Return
            End If

            CierreParcial(txtDocTraspaso.Text)

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub CierreParcial(ByVal prmDocumento As String)
        Try

            Dim pResultado1 As New CResultado
            Dim Cls1 As New clsTransfer

            Cursor.Current = Cursors.WaitCursor
            pResultado1 = Cls1.CierreParcialdocumento(prmDocumento, My.Settings.Estacion, DatosTemporales.Usuario, 1)
            Cursor.Current = Cursors.Default

            If Not pResultado1.Estado Then
                XtraMessageBox.Show(pResultado1.Texto)
                Return
            End If


            XtraMessageBox.Show("Traspaso cerrado exitosamente")

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnCancelaPallet_Click(sender As Object, e As EventArgs) Handles btnCancelaPallet.Click
        Try

            Dim pCodigoPallet As String
            Dim pDocTras As String
            Dim pStatus As String

            If String.IsNullOrEmpty(txtDocTraspaso.Text) Then
                pDocTras = "@"
                pStatus = "@"
            Else
                pDocTras = txtDocTraspaso.Text
                pStatus = "@"
            End If
            Dim dInicio As New Date
            Dim dFin As New Date
            dInicio = Date.Parse(dtpDesde.EditValue.ToString)
            dFin = Date.Parse(dtpHasta.EditValue.ToString)


            Dim view As ColumnView = CType(DgvPallets.MainView, ColumnView)
            Dim selectedRowHandles As Integer() = view.GetSelectedRows()

            pCodigoPallet = view.GetRowCellDisplayText(selectedRowHandles(0), view.Columns("CodigoPallet"))

            If String.IsNullOrEmpty(pCodigoPallet) Then
                XtraMessageBox.Show("Seleccionar un Código de pallet en la lista", "Información", MessageBoxButtons.OK)

                Return
            End If

            If XtraMessageBox.Show("¿Cancelar pallet [" + pCodigoPallet + "]?", "Confirmación", MessageBoxButtons.YesNo) <> DialogResult.Yes Then
                Return
            End If

            CancelaPallet(pDocTras, pCodigoPallet)
            CargaGridDetalle(nuevo.ConsultaDocumentoTraspaso(pDocTras, pStatus, dInicio.ToString("yyyyMMdd"), dFin.ToString("yyyyMMdd"), My.Settings("Estacion"), DatosTemporales.Usuario))
            CargarGridPallets(txtDocTraspaso.Text)


        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub CancelaPallet(ByVal prmDocumento As String, ByVal prmCodigoPallet As String)
        Try
            Dim pResultado As New CResultado
            Dim Cls As New clsTransfer

            Cursor.Current = Cursors.WaitCursor
            pResultado = Cls.CancelaPallet(prmDocumento, prmCodigoPallet, My.Settings.Estacion, DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                Return
            End If

            XtraMessageBox.Show("Pallet cancelado exitosamente")

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub


#End Region

End Class