Imports DevExpress.XtraEditors

Public Class FrmEjercicioInvPosicion

#Region "VARIABLES"
    Dim nuevo As New ClsAlmacen
    Dim nuevoConAlmacen As New ClsConfiguracionAlmacen
#End Region

#Region "EVENTOS"
    Private Sub FrmEjercicioInvPosicion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            txtTipoEjercicio.Text = "CÍCLICO POR POSICIÓN"
            ListaAlmacenes()

        Catch ex As Exception
            XtraMessageBox.Show("Error: " + ex.Message, "AXC")
        End Try
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarRack.Click
        Try
            If cbPasillosRack.Text = "" Then
                XtraMessageBox.Show("Seleccionar el pasillo", "AXC")
                Return
            End If

            Dim dt As DataTable = DirectCast(dgvPasillosRack.DataSource, DataTable)
            Dim newDr As DataRow
            If GridViewRack.RowCount <= 0 Then
                dt = CreaTablaPasilloRack()
            End If

            Dim wpCeldaAux As DataRow
            Dim Repetido As Boolean = False

            If GridViewRack.RowCount > 0 Then

                For Each wpCeldaAux In dt.Rows
                    If cbPasillosRack.Text = wpCeldaAux("Pasillos") Then
                        Repetido = True
                    End If
                Next
            End If

            If Repetido = False Then
                newDr = dt.NewRow()
                newDr("Pasillos") = cbPasillosRack.Text
                dt.Rows.Add(newDr)
                cbPasillosRack.ItemIndex = 0
                Application.DoEvents()
            End If

            CargaGridPasillosRack(dt)
            RecargaGridPasillos()
        Catch ex As Exception
            XtraMessageBox.Show("Error: " + ex.Message, "AXC")
        End Try
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarRack.Click
        Try
            If GridViewRack.GetSelectedRows().Length <= 0 Then
                XtraMessageBox.Show("Seleccionar los pasillos a eliminar", "AXC")
                Return
            End If

            For Each i As Integer In GridViewRack.GetSelectedRows
                GridViewRack.DeleteRow(i)

            Next

            RecargaGridPasillos()
        Catch ex As Exception
            XtraMessageBox.Show("Error: " & ex.Message, "AXC")
        End Try
    End Sub

    Private Sub btnAgregarPos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarPos.Click
        Try
            If GridViewPos.GetSelectedRows().Length <= 0 Then
                XtraMessageBox.Show("Seleccionar las posiciones a agregar", "AXC")
                Return
            End If

            Dim dt As DataTable = DirectCast(dgvPosSelect.DataSource, DataTable)
            Dim newDr As DataRow
            If GridViewSelect.RowCount <= 0 Then
                dt = CreaTablaPosSelect()
            End If

            Dim wpCelda As DataGridViewCell
            Dim wpCeldaAux As DataRow
            Dim Repetido As Boolean = False

            For Each i As Integer In GridViewPos.GetSelectedRows
                Repetido = False
                If GridViewSelect.RowCount >= 0 Then
                    For Each wpCeldaAux In dt.Rows
                        If GridViewPos.GetRowCellDisplayText(i, GridViewPos.Columns("Código Posición")) = wpCeldaAux("Código Posición") Then
                            Repetido = True
                        End If
                    Next
                End If

                If Repetido = False Then
                    newDr = dt.NewRow()
                    newDr("Código Posición") = GridViewPos.GetRowCellDisplayText(i, GridViewPos.Columns("Código Posición"))
                    dt.Rows.Add(newDr)
                    Application.DoEvents()
                End If
            Next

            CargaGridSeleccionadas(dt)

        Catch ex As Exception
            XtraMessageBox.Show("Error: " & ex.Message, "AXC")
        End Try
    End Sub

    Private Sub btnEliminarPos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarPos.Click
        Try
            If GridViewSelect.GetSelectedRows().Length <= 0 Then
                XtraMessageBox.Show("Seleccionar las posiciones a eliminar", "AXC")
                Return
            End If

            For Each i As Integer In GridViewSelect.GetSelectedRows
                GridViewSelect.DeleteRow(i)

            Next
        Catch ex As Exception
            XtraMessageBox.Show("Error: " & ex.Message, "AXC")
        End Try
    End Sub

    Private Sub cbRackPos_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbPasillosAmbos.EditValueChanged
        Try
            If cbPasillosAmbos.Text = "" Then
                Exit Sub
            Else
                CargaGridPosiciones(nuevoConAlmacen.ListaPosiciones("@", cbPasillosAmbos.Text, "@", "@", My.Settings("Estacion"), DatosTemporales.Usuario))
            End If
        Catch ex As Exception
            XtraMessageBox.Show("Error: " & ex.Message, "AXC")
        End Try
    End Sub


    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim ds As New DataSet
        Dim dsAux As DataSet
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
                XtraMessageBox.Show("Seleccionar un almacén", "AXC", MessageBoxButtons.OK)
                cmbAlmacen.Select()
                Return
            End If

            Dim pResultado As New CResultado
            Dim Cls As New ClsAlmacen

            Cursor.Current = Cursors.WaitCursor
            pResultado = Cls.CreaEjercicioInventario(txtTipoEjercicio.Text, txtComentarios.Text, cmbAlmacen.Text, My.Settings.Estacion, DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto, "AXC")
                Return
            End If
            Dim dt As New DataTable
            ''  Dim ds As New DataSet


            '   Dim IdEjercicio As Long
            IdEjercicio = Convert.ToInt16(pResultado.Texto.ToString())


            IdEjercicio = Convert.ToInt16(pResultado.Texto.ToString)




            Dim wpCelda As DataGridViewRow
                Dim wpRow As DataRow

                For i = 0 To GridViewRack.RowCount - 1

                    resp = nuevo.CreaEjercicioInventarioRack(IdEjercicio, GridViewRack.GetRowCellDisplayText(i, GridViewRack.Columns("Pasillos")).ToString(), My.Settings("Estacion"), DatosTemporales.Usuario)
                Next

                For i = 0 To GridViewSelect.RowCount - 1
                    resp = nuevo.CreaEjercicioInventarioPosicion(IdEjercicio, GridViewSelect.GetRowCellDisplayText(i, GridViewSelect.Columns("Código Posición")).ToString(), My.Settings("Estacion"), DatosTemporales.Usuario)
                Next

            XtraMessageBox.Show("Ejercicio de inventario creado con éxito", "AXC")
            ReiniciaTodo()



        Catch ex As Exception
            XtraMessageBox.Show("Error: " & ex.Message, "AXC")
        End Try
    End Sub
#End Region

#Region "METODOS"

    Private Sub CargaPasillosRack()
        Try

            Dim pResultado As New CResultado
            Dim pConfigAlmacen As New CConfigAlmacen

            Cursor.Current = Cursors.WaitCursor
            pResultado = pConfigAlmacen.ListaPasillos("@", CType(IIf(String.IsNullOrEmpty(cmbAlmacen.Text), "@", cmbAlmacen.Text), String))
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto, "AXC")
                Return
            End If

            Dim dt As DataTable = New DataTable
            dt = pResultado.Tabla

            cbPasillosRack.Properties.ValueMember = "Rack"
            cbPasillosRack.Properties.DisplayMember = "Rack"
            cbPasillosRack.Properties.DataSource = dt


        Catch ex As Exception
            XtraMessageBox.Show("Error: " + ex.Message, "AXC")
        End Try
    End Sub



    Private Sub CargaPasillosAmbos()
        Try

            Dim pResultado As New CResultado
            Dim pConfigAlmacen As New CConfigAlmacen

            Cursor.Current = Cursors.WaitCursor
            pResultado = pConfigAlmacen.ListaPasillos("@", CType(IIf(String.IsNullOrEmpty(cmbAlmacen.Text), "@", cmbAlmacen.Text), String))
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto, "AXC")
                Return
            End If


            Dim dt As DataTable = New DataTable
            dt = pResultado.Tabla

            cbPasillosAmbos.Properties.ValueMember = "Rack"
            cbPasillosAmbos.Properties.DisplayMember = "Rack"
            cbPasillosAmbos.Properties.DataSource = dt
        Catch ex As Exception
            XtraMessageBox.Show("Error: " + ex.Message, "AXC")
        End Try
    End Sub

    Function CreaTablaPasilloRack() As DataTable
        Dim dt As New DataTable("PasillosRack")
        Try
            dt.Columns.Add("Pasillos")
        Catch ex As Exception
            XtraMessageBox.Show("Error: " + ex.Message, "AXC")
        End Try
        Return dt
    End Function

    Sub CargaGridPasillosRack(ByVal dt As DataTable)
        Try
            dgvPasillosRack.DataSource = dt

        Catch ex As Exception
            XtraMessageBox.Show("Error: " + ex.Message, "AXC")
        End Try
    End Sub

    Sub CargaGridPosiciones(ByVal ds As DataSet)
        Try
            dgvPos.DataSource = ds.Tables(1)

        Catch ex As Exception
            XtraMessageBox.Show("Error: " + ex.Message, "AXC")
        End Try
    End Sub

    Sub CargaGridSeleccionadas(ByVal dt As DataTable)
        Try
            dgvPosSelect.DataSource = dt

        Catch ex As Exception
            XtraMessageBox.Show("Error: " + ex.Message, "AXC")
        End Try
    End Sub

    Function CreaTablaPosSelect() As DataTable
        Dim dt As New DataTable
        Try
            dt.Columns.Add("Código Posición")
        Catch ex As Exception
            XtraMessageBox.Show("Error: " + ex.Message, "AXC")
        End Try
        Return dt
    End Function

    Sub RecargaGridPasillos()
        Try
            Dim dt As New DataTable
            Dim newDr As DataRow

            Dim wpCeldaAuxRack As DataGridViewRow
            Dim wpCeldaAuxPiso As DataGridViewRow
            Dim Repetido As Boolean = False

            dt.Columns.Add("Rack")

            Dim dtRack As DataTable = cbPasillosRack.Properties.DataSource

            For Each wpItemRack In dtRack.Rows

                Repetido = False

                If GridViewRack.RowCount >= 0 Then
                    For i = 0 To GridViewRack.RowCount - 1
                        If wpItemRack("Rack").ToString = GridViewRack.GetRowCellDisplayText(i, GridViewRack.Columns("Pasillos")).ToString() Then
                            Repetido = True
                        End If
                    Next

                End If

                If Repetido = False Then
                    newDr = dt.NewRow()
                    newDr("Rack") = wpItemRack("Rack")
                    dt.Rows.Add(newDr)
                    Application.DoEvents()
                End If

            Next

            CargaPasillosAmbos()
        Catch ex As Exception
            XtraMessageBox.Show("Error: " + ex.Message, "AXC")
        End Try
    End Sub

    Function CreaTablaPasilloPiso() As DataTable
        Dim dt As New DataTable("PasillosPiso")
        Try
            dt.Columns.Add("Pasillos")
        Catch ex As Exception
            XtraMessageBox.Show("Error: " + ex.Message, "AXC")
        End Try
        Return dt
    End Function



    Sub ReiniciaTodo()
        Try
            dgvPasillosRack.DataSource = Nothing
            dgvPos.DataSource = Nothing
            dgvPosSelect.DataSource = Nothing
            cbPasillosAmbos.ItemIndex = 0
            txtComentarios.Text = ""
        Catch ex As Exception
            XtraMessageBox.Show("Error: " + ex.Message, "AXC")
        End Try
    End Sub

    Private Sub FrmEjercicioInvPosicion_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose(True)
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

    Private Sub cmbAlmacen_EditValueChanged(sender As Object, e As EventArgs) Handles cmbAlmacen.EditValueChanged
        Try
            If String.IsNullOrEmpty(cmbAlmacen.Text) Then
                XtraMessageBox.Show("Seleccionar un almacén", "AXC", MessageBoxButtons.OK)
                cmbAlmacen.Select()
                Return
            End If

            CargaPasillosRack()
            CargaPasillosAmbos()
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
#End Region

End Class