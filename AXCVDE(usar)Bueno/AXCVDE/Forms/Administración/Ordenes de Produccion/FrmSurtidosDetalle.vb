Imports DevExpress.Data
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Columns

Public Class FrmSurtidosDetalle

    Public pOrdenProd As String
    Private Sub FrmSurtidosDetalle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If pOrdenProd <> Nothing Then
                ConsultaSurtidos(pOrdenProd)
            End If
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub

    Public Sub ConsultaSurtidos(ByVal prmBusqueda As String)
        Try
            dgvResultado.DataSource = Nothing

            Dim pResultado As New CResultado
            Dim Cls As New clsOrdenProd


            Cursor.Current = Cursors.WaitCursor
            pResultado = Cls.ConsultaSurtidos(prmBusqueda, My.Settings.Estacion, DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                Me.Close()
                dgvResultado.DataSource = Nothing
                Return
            End If
            Dim dt As New DataTable
            Dim ds As New DataSet

            dt = pResultado.Tabla
            ds.Tables.Add(dt)

            If dt.Rows.Count < 1 Then
                XtraMessageBox.Show("No hay información de pedidos con los filtros seleccionados")
                dgvResultado.DataSource = Nothing
                Return
            End If

            dgvResultado.DataSource = dt
            Dim sortInfo As GridColumnSortInfo() = {New GridColumnSortInfo(GridView1.Columns("IdOrdenSurtido"), ColumnSortOrder.Ascending)}
            GridView1.SortInfo.ClearAndAddRange(sortInfo, 1)
            GridView1.BestFitColumns()

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

End Class