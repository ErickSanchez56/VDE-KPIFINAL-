Imports DevExpress.XtraReports.UI

Public Class FrmReportePorFechasInv
    Public prmAgrupa As Integer
    Private Sub FrmReportePorFechasInv_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpFechaFin.EditValue = Date.Now
        dtpFechaInicio.EditValue = Date.Now
    End Sub

    Private Sub btnReporte_Click(sender As Object, e As EventArgs) Handles btnReporte.Click
        Try
            Dim nuevo As New ClsAlmacen

            Dim dInicio As New Date
            Dim dFin As New Date

            dInicio = Date.Parse(dtpFechaInicio.EditValue.ToString)
            dFin = Date.Parse(dtpFechaFin.EditValue.ToString)

            Dim dsReporte As DataSet = New DataSet

            Dim ds As DataSet = nuevo.ListaResultadoInvPorFechas(dInicio.ToString("yyyyMMdd"), dFin.ToString("yyyyMMdd"), My.Settings("Estacion"), DatosTemporales.Usuario, prmAgrupa)

            If ds.Tables(1).Rows.Count <= 0 Then
                MsgBox("No se registraron cambios", MsgBoxStyle.Critical, "AXC")
                Exit Sub
            End If

            If prmAgrupa = 1 Then
                dsReporte.Tables.Add(ds.Tables(1).Copy)
                Dim RepExistencias As New DevRepResultadoInventario
                RepExistencias.CargaReporte(dsReporte, 1)
                Dim designTool As New ReportPrintTool(RepExistencias)
                designTool.ShowPreviewDialog()
            Else
                dsReporte.Tables.Add(ds.Tables(1).Copy)
                Dim RepExistencias As New DevRepResultadoInventario2
                RepExistencias.CargaReporte(dsReporte, 1)
                Dim designTool As New ReportPrintTool(RepExistencias)
                designTool.ShowPreviewDialog()
            End If

        Catch ex As Exception
            MsgBox("Error: " + ex.Message, MsgBoxStyle.Critical, "AXC")
        End Try

    End Sub

    Private Sub FrmReportePorFechasInv_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose(True)
    End Sub
End Class