Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Base

Public Class frmReimpresionEtiquetaEmpaque
    Private Sub frmReimpresionEtiquetaEmpaque_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim Tipobusq = New List(Of String)()
            Tipobusq.Add("TODOS")
            Tipobusq.Add("CÓDIGO DE EMPAQUE")
            Tipobusq.Add("CÓDIGO DE CONTENEDOR")
            Tipobusq.Add("CÓDIGO DE CARRITO")

            cmbTipo.Properties.DataSource = Tipobusq
            cmbTipo.ItemIndex = 0
            ListarImpresora()

        Catch ex As Exception
            XtraMessageBox.Show("Error: " & ex.Message, "AXC")
        End Try
    End Sub

    Private Sub ListarImpresora()

        Try

            Dim pResultado As New CResultado
            Dim pCons As New clsImpresora

            Cursor.Current = Cursors.WaitCursor
            pResultado = pCons.CargarImpresora(My.Settings.Estacion, DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                MsgBox(pResultado.Texto)
                Return
            End If
            Dim dt As New DataTable
            Dim ds As New DataSet

            dt = pResultado.Tabla
            ds.Tables.Add(dt)

            CmbImpresora.Properties.ValueMember = "Impresora"
            CmbImpresora.Properties.DisplayMember = "Impresora"
            CmbImpresora.Properties.DataSource = dt

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
            GridView1.Columns.Clear()
            dgvResultado.DataSource = Nothing


            Dim pResultado As New CResultado
            Dim Cls As New clsImpresiones

            Cursor.Current = Cursors.WaitCursor
            pResultado = Cls.ListaEmpaqueReimpresion(cmbTipo.ItemIndex, prmBusqueda, My.Settings.Estacion, DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto, "AXC")
                dgvResultado.DataSource = Nothing
                Return
            End If
            Dim dt As New DataTable
            Dim ds As New DataSet

            dt = pResultado.Tabla
            ds.Tables.Add(dt)

            If dt.Rows.Count < 1 Then
                XtraMessageBox.Show("No hay información con los filtros selccionados", "AXC")
                dgvResultado.DataSource = Nothing
                Return
            End If

            dgvResultado.DataSource = dt
            GridView1.BestFitColumns()

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnReporte_Click(sender As Object, e As EventArgs) Handles BtnReporte.Click
        Try
            If XtraMessageBox.Show("¿Desea reimprimir la etiqueta seleccionada?", "AXC", MessageBoxButtons.YesNo) <> DialogResult.Yes Then
                Return
            End If

            Dim view As ColumnView = CType(dgvResultado.MainView, ColumnView)
            Dim selectedRowHandles As Integer() = view.GetSelectedRows()

            If Not selectedRowHandles.Count > 0 Then
                XtraMessageBox.Show("Seleccionar el código a imprimir", "AXC")
                Return
            End If

            If String.IsNullOrEmpty(CmbImpresora.Text) Then
                XtraMessageBox.Show("Seleccionar una impresora", "AXC")
                Return
            End If

            Dim CodigoEmpaque As String = ""
            CodigoEmpaque = view.GetRowCellDisplayText(selectedRowHandles(0), view.Columns("Código"))
            ImprimeEtiquetas(CodigoEmpaque, CmbImpresora.Text)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ImprimeEtiquetas(ByVal prmEmpaque As String, ByVal prmImpresora As String)
        Try
            Dim CRespuesta As New CResultado

            Dim pResultado As New wsAXC.CResultado
            Dim ws As New wsAXC.wsAXCMP

            Dim pUrl As String = My.Settings("AXCVDE_wsAXC_wsAXCMP")

            If pUrl = "" Then
                pUrl = "http://192.168.1.181:1000/wsAXCVDE/wsAXCMP.asmx"
            End If

            ws.Url = pUrl
            Cursor.Current = Cursors.WaitCursor
            pResultado = ws.WM_ReimprimeEmpaquePT(prmEmpaque, prmImpresora)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then


                XtraMessageBox.Show("ER" + pResultado.Texto, "AXC")
                Return
            Else
                XtraMessageBox.Show("Impresión enviada con éxito", "AXC")
            End If

        Catch ex As Exception
            XtraMessageBox.Show("Error: " + ex.Message, "AXC")
        End Try
    End Sub

End Class