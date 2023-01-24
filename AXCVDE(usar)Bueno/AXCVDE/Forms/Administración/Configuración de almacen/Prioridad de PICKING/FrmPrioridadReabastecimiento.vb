Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Base

Public Class FrmPrioridadReabastecimiento
    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Try
            CargarOrdenes("@")
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub CargarOrdenes(prmProducto As String)
        Try
            DgvEncabezado.DataSource = Nothing

            Dim pResultado As New CResultado
            Dim Cls As New CPicking

            Cursor.Current = Cursors.WaitCursor
            pResultado = Cls.ObtenerOrdenesReabastecimiento(IIf(String.IsNullOrEmpty(prmProducto), "@", prmProducto), My.Settings.Estacion, DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                DgvEncabezado.DataSource = Nothing
                Return
            End If
            Dim dt As New DataTable
            Dim ds As New DataSet

            dt = pResultado.Tabla
            ds.Tables.Add(dt)

            If dt.Rows.Count < 1 Then
                XtraMessageBox.Show("No hay información", "AXC")
                DgvEncabezado.DataSource = Nothing
                Return
            End If

            DgvEncabezado.DataSource = dt
            DgvViewEncabezado.BestFitColumns()

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub

    Private Sub FrmPrioridadReabastecimiento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            CargarOrdenes("@")
            TxtBusqueda.Select()
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Try
            If IsNothing(DgvEncabezado.DataSource) Then
                Return
            End If

            If XtraMessageBox.Show("¿Eliminar orden de reabastecimiento?", "AXC", MessageBoxButtons.YesNo) <> DialogResult.Yes Then
                Return
            End If

            Dim view As ColumnView = CType(DgvEncabezado.MainView, ColumnView)
            Dim selectedRowHandles As Integer() = view.GetSelectedRows()

            Eliminar(view.GetRowCellDisplayText(selectedRowHandles(0), view.Columns("Orden")))

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub

    Private Sub Eliminar(prmOrden As String)
        Try
            Dim pResultado As New CResultado
            Dim Cls As New CPicking

            If String.IsNullOrEmpty(prmOrden) Then
                XtraMessageBox.Show("Seleccionar una orden de reabastecimiento", "AXC")
                Return
            End If
            Cursor.Current = Cursors.WaitCursor
            pResultado = Cls.Eliminar(prmOrden, My.Settings.Estacion, DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto, "AXC")
                Return
            End If

            XtraMessageBox.Show("orden de reabastecimiento eliminada con éxito")
            CargarOrdenes(IIf(String.IsNullOrEmpty(TxtBusqueda.Text), "@", TxtBusqueda.Text))
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub

    Private Sub Suspender(prmOrden As String)
        Try
            Dim pResultado As New CResultado
            Dim Cls As New CPicking

            If String.IsNullOrEmpty(prmOrden) Then
                XtraMessageBox.Show("Seleccionar una orden de reabastecimiento", "AXC")
                Return
            End If
            Cursor.Current = Cursors.WaitCursor
            pResultado = Cls.DeshabilitaOrden(prmOrden, My.Settings.Estacion, DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto, "AXC")
                Return
            End If

            XtraMessageBox.Show("orden de reabastecimiento suspendida éxito")
            CargarOrdenes(IIf(String.IsNullOrEmpty(TxtBusqueda.Text), "@", TxtBusqueda.Text))
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub
    Private Sub BtnSuspender_Click(sender As Object, e As EventArgs) Handles BtnSuspender.Click
        Try
            If IsNothing(DgvEncabezado.DataSource) Then
                Return
            End If

            If XtraMessageBox.Show("¿Suspender orden de reabastecimiento?", "AXC", MessageBoxButtons.YesNo) <> DialogResult.Yes Then
                Return
            End If

            Dim view As ColumnView = CType(DgvEncabezado.MainView, ColumnView)
            Dim selectedRowHandles As Integer() = view.GetSelectedRows()

            Suspender(view.GetRowCellDisplayText(selectedRowHandles(0), view.Columns("Orden")))

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub
End Class