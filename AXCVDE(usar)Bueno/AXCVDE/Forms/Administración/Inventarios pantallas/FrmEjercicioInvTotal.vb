Imports DevExpress.XtraEditors

Public Class FrmEjercicioInvTotal
#Region "VARIABLES"
    Dim nuevo As New ClsAlmacen
#End Region

#Region "EVENTOS"
    Private Sub FrmCreaEjercicioInventario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            txtTipoEjercicio.Text = "TOTAL"
            ListaAlmacenes()
            cmbAlmacen.EditValue = 0
        Catch ex As Exception
            XtraMessageBox.Show("Error: " & ex.Message, "AXC")
        End Try
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim ds As DataSet
        Dim resp$
        Dim IdEjercicio%
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

            'dt = pResultado.Tabla
            'ds.Tables.Add(dt)

            IdEjercicio = Convert.ToInt16(pResultado.Texto.ToString)

            If pResultado.Estado.ToString() = True Then

                resp = nuevo.CreaEjercicioInventarioTotal(IdEjercicio, My.Settings("Estacion"), DatosTemporales.Usuario)

                If resp = "OK" Then
                    XtraMessageBox.Show("Ejercicio de inventario creado con éxito", "AXC")
                    txtComentarios.Text = ""
                Else
                    XtraMessageBox.Show(resp, "AXC")
                End If

            Else
                XtraMessageBox.Show(ds.Tables(0).Rows(0)(1).ToString(), "AXC")
            End If

        Catch ex As Exception
            XtraMessageBox.Show("Error: " & ex.Message, "AXC")
        End Try
    End Sub

    Private Sub FrmEjercicioInvTotal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose(True)
    End Sub

#End Region


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
End Class