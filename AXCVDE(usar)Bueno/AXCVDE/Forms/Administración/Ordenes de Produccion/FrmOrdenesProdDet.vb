
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraReports.UI
Public Class FrmOrdenesProdDet
#Region "VARIABLES"
    Public pOrdenProd As String
#End Region
#Region "EVENTOS"
    Private Sub FrmOrdenesProdDet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ListaSurtidos(pOrdenProd)
            lblOrdenCompra.Text = pOrdenProd
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub dgvConsulta_DoubleClick(sender As Object, e As EventArgs) Handles dgvConsulta.DoubleClick
        Try
            Dim view As ColumnView = CType(dgvConsulta.MainView, ColumnView)
            Dim selectedRowHandles As Integer() = view.GetSelectedRows()


            If selectedRowHandles.Count < 1 Then
                XtraMessageBox.Show("Seleccionar un documento de surtido", "AXC", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Dim pSurtido As String
            pSurtido = view.GetRowCellDisplayText(selectedRowHandles(0), view.Columns("IdSurtido"))
            lblDocumentoRecepcionS.Text = pSurtido.ToString
            ListaPartidasPorSurtido(pSurtido)
            ListaPalletsPorSurtido(pSurtido)
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


#End Region




#Region "METODOS"
    Private Sub ListaSurtidos(pOrdenProd As String)
        Try
            dgvConsulta.DataSource = Nothing
            GridView1.Columns.Clear()

            Dim pResultado As New CResultado
            Dim pCons As New clsOrdenProd
            Cursor.Current = Cursors.WaitCursor
            pResultado = pCons.ListaSurtidos(pOrdenProd, My.Settings.Estacion, DatosTemporales.Usuario)
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

                XtraMessageBox.Show("No existen docuementos de surtido con esta orden de Produccion", "AXC", MessageBoxButtons.OK, MessageBoxIcon.Information)
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

    Private Sub ListaPartidasPorSurtido(prmRecepcion As String)
        Try
            dgvPartidasDocRecepcion.DataSource = Nothing
            GridView2.Columns.Clear()

            Dim pResultado As New CResultado
            Dim pCons As New clsOrdenProd

            Cursor.Current = Cursors.WaitCursor
            pResultado = pCons.ListaPartidasSurtido(prmRecepcion, My.Settings.Estacion, DatosTemporales.Usuario)
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
                XtraMessageBox.Show("No existen partidas de este documento de surtido", "AXC", MessageBoxButtons.OK, MessageBoxIcon.Information)

                dgvPartidasDocRecepcion.DataSource = Nothing
                GridView2.Columns.Clear()
                Return
            End If

            dgvPartidasDocRecepcion.DataSource = ds.Tables(1)

            GridView2.BestFitColumns()
            GridView3.BestFitColumns()
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ListaPalletsPorSurtido(prmRecepcion As Integer)
        Try
            dgvPalletsPorRecepcion.DataSource = Nothing
            GridView3.Columns.Clear()

            Dim pResultado As New CResultado
            Dim pCons As New clsOrdenProd

            Cursor.Current = Cursors.WaitCursor
            pResultado = pCons.ListaPalletsPorSurtido(prmRecepcion, My.Settings.Estacion, DatosTemporales.Usuario)
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
                XtraMessageBox.Show("No hay pallets con este documento de surtido", "AXC", MessageBoxButtons.OK, MessageBoxIcon.Information)
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

    'Private Sub btnGenera_Click(sender As Object, e As EventArgs) Handles btnGenera.Click
    '    Try

    '        If XtraMessageBox.Show("¿Generar reporte?", "Confirmación", MessageBoxButtons.YesNo) <> DialogResult.Yes Then
    '            Return
    '        End If



    '        If dgvConsulta.DataSource Is Nothing Then
    '            XtraMessageBox.Show("No hay información para generar el reporte", "Información", MessageBoxButtons.OK)
    '            Return
    '        End If

    '        Dim pResultado As New CResultado
    '        Dim pCons As New clsEmbarque


    '        Cursor.Current = Cursors.WaitCursor
    '        pResultado = pCons.RptOrdenEmbarque(lblOrdenCompra.Text, My.Settings.Estacion, DatosTemporales.Usuario)
    '        Cursor.Current = Cursors.Default

    '        If Not pResultado.Estado Then
    '            XtraMessageBox.Show(pResultado.Texto, "AXC")
    '            dgvPartidasDocRecepcion.DataSource = Nothing
    '            Return
    '        End If
    '        Dim dt As New DataTable
    '        Dim ds As New DataSet


    '        ds = pResultado.Tablas.Copy

    '        Dim RepOrdenEmb As New DevRepEmbarqueDetvb
    '        RepOrdenEmb.DetailReporteEmb.DataSource = ds.Tables(1)
    '        RepOrdenEmb.DetailReport.DataSource = ds.Tables(2)

    '        Dim designTool As New ReportPrintTool(RepOrdenEmb)
    '        designTool.ShowPreviewDialog()



    '    Catch ex As Exception
    '        XtraMessageBox.Show(ex.Message.ToString, "AXC", MessageBoxButtons.OK)
    '    End Try
    'End Sub

#End Region

End Class