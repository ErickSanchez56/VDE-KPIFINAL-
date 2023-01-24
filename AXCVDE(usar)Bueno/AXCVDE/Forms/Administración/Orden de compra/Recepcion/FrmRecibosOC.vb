Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraReports.UI

Public Class FrmRecibosOC

#Region "VARIABLES"
    Public pOrdenCompra As String
#End Region



#Region "EVENTOS"
    Private Sub FrmRecibosOC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ListaRecibosOC(pOrdenCompra)
            lblOrdenCompra.Text = pOrdenCompra
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dgvConsulta_DoubleClick(sender As Object, e As EventArgs) Handles dgvConsulta.DoubleClick
        Try
            Dim view As ColumnView = CType(dgvConsulta.MainView, ColumnView)
            Dim selectedRowHandles As Integer() = view.GetSelectedRows()


            If selectedRowHandles.Count < 1 Then
                XtraMessageBox.Show("Seleccionar el documento de recepción a eliminar", "AXC", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            Dim pRecepcion As String
            pRecepcion = view.GetRowCellDisplayText(selectedRowHandles(0), view.Columns("ReciboAXC"))
            lblDocumentoRecepcionS.Text = pRecepcion.ToString
            ListaPartidasPorRecepcion(pRecepcion)
            ListaPalletsPorRecepcion(pRecepcion)
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

#End Region

#Region "METODOS"
    Private Sub ListaRecibosOC(prmOrdenCompra As String)
        Try
            dgvConsulta.DataSource = Nothing
            GridView1.Columns.Clear()

            Dim pResultado As New CResultado
            Dim pCons As New ClsOrdenCompra

            Cursor.Current = Cursors.WaitCursor
            pResultado = pCons.ListaRecepcionesOC(prmOrdenCompra, My.Settings.Estacion, DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto, "AXC", MessageBoxButtons.OK, MessageBoxIcon.Error)
                dgvConsulta.DataSource = Nothing
                GridView1.Columns.Clear()
                Return
            End If
            Dim dt As New DataTable
            Dim ds As New DataSet

            dt = pResultado.Tabla
            ds.Tables.Add(dt)

            If dt.Rows.Count < 1 Then

                XtraMessageBox.Show("No existen docuementos de recepción con esta orden de compra", "AXC", MessageBoxButtons.OK, MessageBoxIcon.Information)
                dgvConsulta.DataSource = Nothing
                GridView1.Columns.Clear()
                Return
            End If

            dgvConsulta.DataSource = dt
            GridView1.BestFitColumns()
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ListaPartidasPorRecepcion(prmRecepcion As String)
        Try
            dgvPartidasDocRecepcion.DataSource = Nothing
            GridView2.Columns.Clear()

            Dim pResultado As New CResultado
            Dim pCons As New ClsOrdenCompra

            Cursor.Current = Cursors.WaitCursor
            pResultado = pCons.ListaPartidasRecepcion(prmRecepcion, My.Settings.Estacion, DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto, "AXC", MessageBoxButtons.OK, MessageBoxIcon.Error)
                dgvPartidasDocRecepcion.DataSource = Nothing
                GridView2.Columns.Clear()
                Return
            End If
            Dim dt As New DataTable
            Dim ds As New DataSet


            ds = pResultado.Resultado

            If ds.Tables.Count = 1 Then
                XtraMessageBox.Show("No existen partidas de este documento de recepción", "AXC", MessageBoxButtons.OK, MessageBoxIcon.Information)

                dgvPartidasDocRecepcion.DataSource = Nothing
                GridView2.Columns.Clear()
                Return
            End If

            dgvPartidasDocRecepcion.DataSource = ds.Tables(1)
            dgvLotesRecibidos.DataSource = ds.Tables(2)

            GridView2.BestFitColumns()
            GridView3.BestFitColumns()
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ListaPalletsPorRecepcion(prmRecepcion As Integer)
        Try
            dgvPalletsPorRecepcion.DataSource = Nothing
            GridView3.Columns.Clear()

            Dim pResultado As New CResultado
            Dim pCons As New ClsOrdenCompra

            Cursor.Current = Cursors.WaitCursor
            pResultado = pCons.ListaPalletsPorRecepcion(prmRecepcion, My.Settings.Estacion, DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto, "AXC", MessageBoxButtons.OK, MessageBoxIcon.Error)
                dgvPalletsPorRecepcion.DataSource = Nothing
                GridView3.Columns.Clear()
                Return
            End If
            Dim dt As New DataTable
            Dim ds As New DataSet

            dt = pResultado.Tabla
            ds.Tables.Add(dt)

            If dt.Rows.Count < 1 Then
                XtraMessageBox.Show("No hay pallets con este documento de recepción", "AXC", MessageBoxButtons.OK, MessageBoxIcon.Information)
                dgvPalletsPorRecepcion.DataSource = Nothing
                GridView3.Columns.Clear()
                Return
            End If

            dgvPalletsPorRecepcion.DataSource = dt
            GridView3.BestFitColumns()

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub FrmRecibosOC_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose(True)
    End Sub

    Private Sub btnGenera_Click(sender As Object, e As EventArgs) Handles btnGenera.Click
        Try
            If vbNo = MsgBox("¿Generar reporte?", MsgBoxStyle.YesNo, "AXC") Then
                Return
            End If

            If dgvConsulta.DataSource Is Nothing Then
                XtraMessageBox.Show("No hay información para generar el reporte", "Información", MessageBoxButtons.OK)
                Return
            End If


            Dim pResultado As New CResultado
            Dim pCons As New ClsOrdenCompra

            Cursor.Current = Cursors.WaitCursor
            pResultado = pCons.RptRecibosOC(lblOrdenCompra.Text, My.Settings.Estacion, DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto, "AXC")
                dgvPartidasDocRecepcion.DataSource = Nothing
                Return
            End If
            Dim dt As New DataTable
            Dim ds As New DataSet


            ds = pResultado.Tablas.Copy
            If ds.Tables Is Nothing Then

            End If

            Dim RepExistencias As New DevRepRecibosOC
            RepExistencias.DetailReporteOC.DataSource = ds.Tables(1)
            RepExistencias.DetailReport.DataSource = ds.Tables(2)

            Dim designTool As New ReportPrintTool(RepExistencias)
            designTool.ShowPreviewDialog()



        Catch ex As Exception
            XtraMessageBox.Show(ex.Message.ToString, "AXC", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub btnCierreParcial_Click(sender As Object, e As EventArgs) Handles btnCierreParcial.Click
        Try
            If String.IsNullOrEmpty(lblOrdenCompra.Text) Then
                XtraMessageBox.Show("Seleccionar una orden de compra", "Información", MessageBoxButtons.OK)
                Return
            End If

            If XtraMessageBox.Show("¿Deseas cerrar la orden de compra?", "Confirmación", MessageBoxButtons.YesNo) <> DialogResult.Yes Then
                Return
            End If

            CierreParcial(lblOrdenCompra.Text)
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub CierreParcial(ByVal prmOrdenCompra As String)
        Try
            Dim pResultado As New CResultado
            Dim Cls As New ClsOrdenCompra

            Cursor.Current = Cursors.WaitCursor
            pResultado = Cls.CierreParcial(prmOrdenCompra, My.Settings.Estacion, DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                Return
            End If

            XtraMessageBox.Show("Orden de compra cerrada con éxito")
            ListaRecibosOC(pOrdenCompra)
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Try
            If String.IsNullOrEmpty(lblOrdenCompra.Text) Then
                XtraMessageBox.Show("Seleccionar una orden de compra", "Información", MessageBoxButtons.OK)
                Return
            End If

            If XtraMessageBox.Show("¿Deseas aplicar la orden de compra en interfaz?", "Confirmación", MessageBoxButtons.YesNo) <> DialogResult.Yes Then
                Return
            End If

            AplicaOrdenCompra(lblOrdenCompra.Text)
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub AplicaOrdenCompra(ByVal prmOrdenCompra As String)
        Try
            Dim pResultado As New CResultado
            Dim Cls As New ClsOrdenCompra

            Cursor.Current = Cursors.WaitCursor
            pResultado = Cls.AplicaOrdenCompra(prmOrdenCompra, My.Settings.Estacion, DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                Return
            End If

            XtraMessageBox.Show("Orden de compra aplicada con éxito")
            ListaRecibosOC(pOrdenCompra)
            dgvPalletsPorRecepcion.DataSource = Nothing
            dgvPartidasDocRecepcion.DataSource = Nothing
            GridView2.Columns.Clear()
            GridView4.Columns.Clear()
            GridView3.Columns.Clear()
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

#End Region

End Class