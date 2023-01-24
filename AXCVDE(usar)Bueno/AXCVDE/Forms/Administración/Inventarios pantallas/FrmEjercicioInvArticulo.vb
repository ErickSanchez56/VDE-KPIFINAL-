Imports DevExpress.XtraEditors

Public Class FrmEjercicioInvArticulo
#Region "VARIABLES"
    Dim nuevo As New ClsAlmacen
    Dim nuevoNumParte As New clsNumParte
#End Region

#Region "EVENTOS"
    Private Sub FrmEjercicioInvArticulo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            txtTipoEjercicio.Text = "CÍCLICO POR PRODUCTO"
            CargaGridNumParte(nuevoNumParte.ListaNumParteInventarios("@", My.Settings("Estacion"), DatosTemporales.Usuario))
            ListaAlmacenes()
            cmbAlmacen.EditValue = 1

        Catch ex As Exception
            XtraMessageBox.Show("Error: " & ex.Message, "AXC")
        End Try
    End Sub



    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Try
            If GridView1.GetSelectedRows().Length <= 0 Then
                XtraMessageBox.Show("Seleccionar los Productos a agregar", "AXC")
                Return
            End If

            Dim dt As DataTable = DirectCast(dgvArticulos.DataSource, DataTable)
            Dim newDr As DataRow
            If GridView2.RowCount <= 0 Then
                dt = CreaTabla()
            End If

            Dim wpCeldaAux As DataRow
            Dim Repetido As Boolean = False

            For Each i As Integer In GridView1.GetSelectedRows
                Repetido = False
                If GridView2.RowCount >= 0 Then
                    For Each wpCeldaAux In dt.Rows
                        If GridView1.GetRowCellDisplayText(i, GridView1.Columns("Producto")) = wpCeldaAux("Producto") Then
                            Repetido = True
                        End If
                    Next
                End If

                If Repetido = False Then
                    newDr = dt.NewRow()
                    newDr("Producto") = GridView1.GetRowCellDisplayText(i, GridView1.Columns("Producto"))
                    dt.Rows.Add(newDr)
                    Application.DoEvents()
                End If
            Next


            CargaGridSeleccionadas(dt)

        Catch ex As Exception
            XtraMessageBox.Show("Error: " & ex.Message, "AXC")
        End Try
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Try
            If GridView1.GetSelectedRows().Length <= 0 Then
                XtraMessageBox.Show("Seleccionar los productos a eliminar", "AXC")
                Return
            End If


            For Each i As Integer In GridView2.GetSelectedRows
                GridView2.DeleteRow(i)

            Next

        Catch ex As Exception
            XtraMessageBox.Show("Error: " & ex.Message, "AXC")
        End Try
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim ds As DataSet
        Dim IdEjercicio%
        Dim resp$
        Try

            If XtraMessageBox.Show("¿Crear ejercicio de inventario?", "AXC", MessageBoxButtons.YesNo) <> DialogResult.Yes Then
                Return
            End If

            If String.IsNullOrEmpty(txtComentarios.Text) Then
                XtraMessageBox.Show("Ingresar comentarios", "AXC")
                Return
            End If

            If String.IsNullOrEmpty(cmbAlmacen.Text) Then
                XtraMessageBox.Show("Seleccionar almacén", "AXC", MessageBoxButtons.OK)
                cmbAlmacen.Select()
                Return
            End If
            Dim pResultado As New CResultado
            Dim Cls As New ClsAlmacen

            Cursor.Current = Cursors.WaitCursor
            pResultado = Cls.CreaEjercicioInventario(txtTipoEjercicio.Text, txtComentarios.Text, cmbAlmacen.Text, My.Settings.Estacion, DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                Return
            End If
            Dim dt As New DataTable

            dt = pResultado.Tabla


            If pResultado.Estado Then
                IdEjercicio = Convert.ToInt16(pResultado.Texto.ToString)

                Dim wpCelda As DataGridViewRow

                For i = 0 To GridView2.RowCount - 1
                    resp = nuevo.CreaEjercicioInventarioArticulo(IdEjercicio, GridView2.GetRowCellDisplayText(i, GridView2.Columns("Producto")).ToString(), My.Settings("Estacion"), DatosTemporales.Usuario)

                Next


                XtraMessageBox.Show("Ejercicio de inventario creado con éxito", "AXC")
                ReiniciaTodo()
            Else
                XtraMessageBox.Show(ds.Tables(0).Rows(0)(1).ToString(), "AXC")
                Return
            End If

        Catch ex As Exception
            XtraMessageBox.Show("Error: " & ex.Message, "AXC")
        End Try
    End Sub

#End Region

#Region "METODOS"
    Sub CargaGridNumParte(ByVal ds As DataSet)
        Try
            ' Dim dg As DataGridView = dgvNumParte

            If ds.Tables.Count = 1 Then
                XtraMessageBox.Show("No se encuentra el producto", "AXC")
                dgvNumParte.DataSource = Nothing
                Exit Sub
            End If

            dgvNumParte.DataSource = ds.Tables(1)
            'dg.RowHeadersVisible = False
            'dg.SelectionMode = SelectionMode.One
            'dg.ReadOnly = True
            'dg.RowHeadersVisible = False
            'dg.DefaultCellStyle.ForeColor = Color.Black
            'dg.DefaultCellStyle.Alignment = ContentAlignment.MiddleCenter
            'dg.AllowUserToAddRows = False
            'dg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            'dg.AllowUserToDeleteRows = False
            'dg.AllowUserToOrderColumns = False
            'dg.AllowUserToResizeColumns = False
            'dg.AllowUserToResizeRows = False
        Catch ex As Exception
            XtraMessageBox.Show("Error: " & ex.Message, "AXC")
        End Try
    End Sub

    Sub CargaGridSeleccionadas(ByVal dt As DataTable)
        Try
            ' Dim dg As DataGridView = dgvArticulos
            dgvArticulos.DataSource = dt
            'dg.RowHeadersVisible = False
            'dg.SelectionMode = SelectionMode.One
            'dg.ReadOnly = True
            'dg.RowHeadersVisible = False
            'dg.DefaultCellStyle.ForeColor = Color.Black
            'dg.DefaultCellStyle.Alignment = ContentAlignment.MiddleCenter
            'dg.AllowUserToAddRows = False
            'dg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            'dg.AllowUserToDeleteRows = False
            'dg.AllowUserToOrderColumns = False
            'dg.AllowUserToResizeColumns = False
            'dg.AllowUserToResizeRows = False
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "AXC")
        End Try
    End Sub

    Function CreaTabla() As DataTable
        Dim dt As New DataTable
        Try
            dt.Columns.Add("Producto")
        Catch ex As Exception
            MsgBox("Error: " + ex.Message, MsgBoxStyle.Critical, "AXC")
        End Try
        Return dt
    End Function

    Sub ReiniciaTodo()
        Try
            txtComentarios.Text = ""
            dgvArticulos.DataSource = Nothing
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "AXC")
        End Try
    End Sub

    Private Sub ListaAlmacenes()
        Try
            Dim pResultado As New CResultado
            Dim pAlmacen As New ClsAlmacen

            Cursor.Current = Cursors.WaitCursor
            pResultado = pAlmacen.ListaAlmacen("@", "@", My.Settings.Estacion)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto, "AXC")
                Return
            End If

            Dim dtOrigen As DataTable = New DataTable
            dtOrigen = pResultado.Tabla.Copy


            cmbAlmacen.Properties.DataSource = dtOrigen
            cmbAlmacen.Properties.ValueMember = "ERPAlmacen"
            cmbAlmacen.Properties.DisplayMember = "ERPAlmacen"

            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Cursor.Current = Cursors.Default
            XtraMessageBox.Show(ex.Message, "AXC", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region
End Class