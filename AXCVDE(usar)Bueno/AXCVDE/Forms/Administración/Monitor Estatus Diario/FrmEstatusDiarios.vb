Imports DevExpress.Utils.Menu
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Globalization
Imports DevExpress.Utils
Imports DevExpress.XtraEditors.Repository


Public Class FrmEstatusDiarios
    Private primera As Boolean = True
    Private Sub FrmEstatusDiarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            primera = False
            Dim dInicio As New Date
            dInicio = Date.Parse(dtpFechaInicio.EditValue.ToString)
            cargaTotales(dInicio.ToString("yyyyMMdd"))

            cargaOrdenesEmbarque(dInicio.ToString("yyyyMMdd"))
            cargaEstaciones(dInicio.ToString("yyyyMMdd"))
            btnActualizar.Select()
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub
#Region "METODOS"
    Private Sub GridView1_CustomRowCellEdit(sender As Object, e As DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs) Handles dgvViewEncabezado.CustomRowCellEdit
        If e.Column.FieldName = "Surtido" Then
            Dim rp As RepositoryItemProgressBar = New RepositoryItemProgressBar()

            rp.ProgressViewStyle = DevExpress.XtraEditors.Controls.ProgressViewStyle.Solid
            rp.ShowTitle = True
            rp.PercentView = False
            rp.DisplayFormat.FormatType = FormatType.Numeric
            rp.DisplayFormat.FormatString = "{0:n2}%"
            rp.Minimum = 0
            rp.Maximum = 100
            rp.LookAndFeel.UseDefaultLookAndFeel = False
            rp.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
            If e.CellValue < 50 Then
                rp.StartColor = Color.DarkOrange
                rp.EndColor = Color.Orange
            ElseIf e.CellValue > 50 And e.CellValue < 100 Then
                rp.StartColor = Color.YellowGreen
                rp.EndColor = Color.DarkGreen
            Else
                rp.StartColor = Color.Green
                rp.EndColor = Color.DarkGreen
            End If
            e.RepositoryItem = rp
        End If

        dgvViewEncabezado.Columns(5).Width = 660
        dgvViewEncabezado.Appearance.HeaderPanel.FontSizeDelta = 10
        dgvViewEncabezado.Appearance.Row.FontSizeDelta = 10
    End Sub
    Public Sub cargaTotales(ByVal prmFecha As String)
        Try
            If primera Then
                Return
            End If
            Dim pResultado As New CResultado
                Dim Cls As New clsEmbarque
                Cursor.Current = Cursors.WaitCursor
                pResultado = Cls.CargaTotales(prmFecha)
                Cursor.Current = Cursors.Default
                If Not pResultado.Estado Then
                    XtraMessageBox.Show(pResultado.Texto)

                    Return
                End If
                Dim dtEncabezado As New DataTable
                Dim ds As New DataSet
                ds = pResultado.Tablas
                dtEncabezado = ds.Tables(1)
                dtEncabezado.TableName = "Encabezado"

                ds = pResultado.Tablas

                For Each dr As DataRow In ds.Tables(1).Rows

                    If dr("Encabezado") = "TOTAL" Then
                        BtnTotalN.Text = dr("Valor")
                    End If
                    If dr("Encabezado") = "LIBERADA" Then
                        BtnLiberado.Text = dr("Valor")
                    End If
                    If dr("Encabezado") = "SURTIENDO" Then
                        BtnSurtiendo.Text = dr("Valor")
                    End If
                    If dr("Encabezado") = "SURTIDA" Then
                        BtnSurtida.Text = dr("Valor")
                    End If
                    If dr("Encabezado") = "VALIDADA" Then
                        BtnValidada.Text = dr("Valor")
                    End If
                    If dr("Encabezado") = "LISTA" Then
                        BtnLista.Text = dr("Valor")
                    End If
                    'dt = ds.Tables().Copy
                Next

                If dtEncabezado.Rows.Count < 1 Then
                    XtraMessageBox.Show("No hay información de pedidos con los filtros seleccionados")

                    Return
                End If
            'GridControl1.DataSource = ds.Tables("Encabezado")
            'GridView1.BestFitColumns()
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try

    End Sub
    Public Sub cargaOrdenesEmbarque(ByVal prmFecha As String)
        Try
            If primera Then
                Return
            End If
            dgvOrdenes.DataSource = Nothing
            Dim pResultado As New CResultado
            Dim Cls As New clsEmbarque
            Cursor.Current = Cursors.WaitCursor
            pResultado = Cls.Estatus(prmFecha)
            Cursor.Current = Cursors.Default
            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                dgvOrdenes.DataSource = Nothing
                Return
            End If
            Dim dtEncabezado As New DataTable
            Dim ds As New DataSet
            ds = pResultado.Tablas
            dtEncabezado = ds.Tables(1)
            dtEncabezado.TableName = "Encabezado"
            If dtEncabezado.Rows.Count < 1 Then
                XtraMessageBox.Show("No hay información de pedidos con los filtros seleccionados")
                dgvOrdenes.DataSource = Nothing
                Return
            End If
            dgvOrdenes.DataSource = ds.Tables("Encabezado")
            dgvViewEncabezado.BestFitColumns()
            dgvViewEncabezado.Columns(5).Width = 660
            dgvViewEncabezado.Appearance.HeaderPanel.FontSizeDelta = 10
            dgvViewEncabezado.Appearance.Row.FontSizeDelta = 107


        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub cargaEstaciones(ByVal prmFecha As String)
        Try
            If primera Then
                Return
            End If
            GridControl1.DataSource = Nothing
            Dim pResultado As New CResultado
            Dim Cls As New clsEmbarque
            Cursor.Current = Cursors.WaitCursor
            pResultado = Cls.EstacionesDiaM(prmFecha)
            Cursor.Current = Cursors.Default
            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                dgvOrdenes.DataSource = Nothing
                Return
            End If
            Dim dtEncabezado As New DataTable
            Dim ds As New DataSet
            ds = pResultado.Tablas
            dtEncabezado = ds.Tables(1)
            dtEncabezado.TableName = "Encabezado"
            If dtEncabezado.Rows.Count < 1 Then
                XtraMessageBox.Show("No hay información de pedidos con los filtros seleccionados")
                GridControl1.DataSource = Nothing
                Return
            End If
            GridControl1.DataSource = ds.Tables("Encabezado")
            GridView2.BestFitColumns()
            GridView2.Columns(0).Width = 100
            GridView2.Columns(1).Width = 730
            GridView2.Columns(2).Width = 730
            GridView2.Appearance.HeaderPanel.FontSizeDelta = 5
            GridView2.Appearance.Row.FontSizeDelta = 5


        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub dtpFechaInicio_EditValueChanged(sender As Object, e As EventArgs) Handles dtpFechaInicio.EditValueChanged
        Try
            If primera Then
                Return
            End If
            Dim dInicio As New Date
            dInicio = Date.Parse(dtpFechaInicio.EditValue.ToString)
            cargaTotales(dInicio.ToString("yyyyMMdd"))

            cargaOrdenesEmbarque(dInicio.ToString("yyyyMMdd"))
            cargaEstaciones(dInicio.ToString("yyyyMMdd"))
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub
#End Region

    Private Sub FrmEstatusDiarios_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose(True)
    End Sub

    Private Function CreateSubMenuRows(ByVal view As GridView, ByVal rowHandle As Integer, ByVal NombreSubMenu As String) As DXMenuItem
        Dim subMenu As DXSubMenuItem = New DXSubMenuItem()
        Dim menuItemRow As DXMenuItem = Nothing

        Select Case NombreSubMenu
            Case "Surtido"
                subMenu.Caption = "Surtido"
                'Dim pSeleccion = view.GetRowCellDisplayText(rowHandle, "Artículo")
                'Dim existencias = cargaOrdenesEmbarque(pSeleccion)

            Case Else
        End Select
        Return subMenu
    End Function


    Private Sub dgvViewEncabezado_RowCellStyle(sender As Object, e As RowCellStyleEventArgs) Handles dgvViewEncabezado.RowCellStyle
        Try
            Dim Estatus As String = dgvViewEncabezado.GetRowCellValue(e.RowHandle, "Surtido")
            If e.Column.Name = "Surtido" Then
                Select Case Estatus
                    Case "COMPLETO"
                        e.Appearance.BackColor = Color.Green
                    Case "INCOMPLETO"
                        e.Appearance.BackColor = Color.Orange
                    Case "SIN EXISTENCIA"
                        e.Appearance.BackColor = Color.Red
                    Case Else
                End Select
            End If
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Try
            If primera Then
                Return
            End If
            Dim dInicio As New Date
            dInicio = Date.Parse(dtpFechaInicio.EditValue.ToString)
            cargaTotales(dInicio.ToString("yyyyMMdd"))

            cargaOrdenesEmbarque(dInicio.ToString("yyyyMMdd"))
            cargaEstaciones(dInicio.ToString("yyyyMMdd"))
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub
End Class