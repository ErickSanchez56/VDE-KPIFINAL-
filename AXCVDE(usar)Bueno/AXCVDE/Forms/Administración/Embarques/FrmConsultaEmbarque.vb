Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Base

Public Class FrmConsultaEmbarque


    Public f As FrmConsEmbarque
    Private Sub FrmConsultaEmbarque_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            cmbTipo.EditValue = 0
            dtpFechaFin.EditValue = Date.Now
            dtpFechaInicio.EditValue = Date.Now

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub LlenarTipoBusqueda()
        Try
            Dim TipoBus = New List(Of String)()
            TipoBus.Add("PRODUCTO")
            TipoBus.Add("ORDEN DE EMBARQUE")

            cmbTipo.Properties.DataSource = TipoBus

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Try
            Dim pBusqueda As String = "@"


            If String.IsNullOrEmpty(TxtBusqueda.Text.Trim()) Then
                pBusqueda = "@"
            Else
                pBusqueda = TxtBusqueda.Text
            End If

            CargarPedidos(pBusqueda)

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message.ToString, "Error", MessageBoxButtons.OK)
        End Try
    End Sub

#Region "METODOS"
    Private Sub CargarPedidos(prmBusqueda As String)
        Try
            DgvResultado.DataSource = Nothing

            Dim pResultado As New CResultado
            Dim Cls As New clsConsEM

            Dim dInicio As New Date
            Dim dFin As New Date

            dInicio = Date.Parse(dtpFechaInicio.EditValue.ToString)
            dFin = Date.Parse(dtpFechaFin.EditValue.ToString)


            Cursor.Current = Cursors.WaitCursor
            pResultado = Cls.CargarPedidos(0, prmBusqueda, dInicio.ToString("yyyyMMdd"), dFin.ToString("yyyyMMdd"), My.Settings.Estacion, DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                DgvResultado.DataSource = Nothing
                TxtBusqueda.Select()
                Return
            End If
            Dim dt As New DataTable
            Dim ds As New DataSet

            dt = pResultado.Tabla
            ds.Tables.Add(dt)

            If dt.Rows.Count < 1 Then
                XtraMessageBox.Show("No hay información de pedidos con los filtros seleccionados")
                DgvResultado.DataSource = Nothing
                Return
            End If

            DgvResultado.DataSource = dt

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub FrmConsultaEmbarque_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose(True)
    End Sub

    Private Sub DgvViewResultado_DoubleClick(sender As Object, e As EventArgs) Handles DgvViewResultado.DoubleClick
        Try

            Dim view As ColumnView = CType(DgvResultado.MainView, ColumnView)
            Dim selectedRowHandles As Integer() = view.GetSelectedRows()

            'FrmConsEmbarque.pPedido = view.GetRowCellDisplayText(selectedRowHandles(0), view.Columns("Embarque"))

            f.pBuscaPedido = view.GetRowCellDisplayText(selectedRowHandles(0), view.Columns("Embarque"))
            Me.Close()

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub



#End Region
End Class