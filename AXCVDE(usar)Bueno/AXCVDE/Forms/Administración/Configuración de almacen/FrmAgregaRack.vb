Imports DevExpress.XtraEditors

Public Class FrmAgregaRack


#Region "VARIABLES"
    Dim pCierre As Boolean = False
    Dim nuevo As New ClsConfiguracionAlmacen
#End Region
    Private Sub btnAgregarPos_Click(sender As Object, e As EventArgs) Handles BtnAgregaRack.Click
        Dim resp As String = ""
        Try

            If String.IsNullOrEmpty(txtRack.Text) Then
                XtraMessageBox.Show("Ingresar un nombre en el campo [Ubicación]", "AXC")
                txtRack.Select()
                Return
            End If

            If ChkRack.Checked Then
                If NupNivel.Value <= 0 Then
                    XtraMessageBox.Show("Indicar el número de niveles a agregar", "AXC")
                    Return
                End If

            End If


            If NupPos.Value <= 0 Then
                XtraMessageBox.Show("Indicar el número de posiciones a agregar", "AXC")
                Return
            End If



            If String.IsNullOrEmpty(TxtCapacidad.Text) Then
                XtraMessageBox.Show("Ingresar capacidad de las posiciones", "AXC")
                TxtCapacidad.Select()
                Return
            End If

            If XtraMessageBox.Show("¿Desea agregar una ubicación nueva al almacén?" & vbNewLine & "Nota: Este cambio no se puede deshacer", "AXC", MessageBoxButtons.YesNo) <> DialogResult.Yes Then
                Return
            End If

            resp = nuevo.AgregaRackAlmacen(txtRack.Text, CmbAlmacen.Text, NupNivel.Value, NupPos.Value, TxtCapacidad.Text, cmbTipo.EditValue, IIf(ChkRack.Checked, "R", "P"), My.Settings("Estacion"), DatosTemporales.Usuario)

            If resp = "OK" Then
                XtraMessageBox.Show("Ubicación agregada con éxito", "AXC")
                TxtCapacidad.Text = ""
            Else
                XtraMessageBox.Show(resp, "AXC")
                TxtCapacidad.Select()
                pCierre = False
                Return
            End If

            FrmAjustesConfiguracionAlmacen.pAgregarRack = True
            pCierre = True
            Me.Close()


            NupNivel.Value = 1
            NupPos.Value = 1
        Catch ex As Exception
            XtraMessageBox.Show("Error: " + ex.Message, "AXC")
        End Try
    End Sub

    Private Sub FrmAgregaRack_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        If pCierre = False Then
            FrmAjustesConfiguracionAlmacen.pAgregarRack = False
        End If
        Me.Dispose(True)

    End Sub

    Private Sub FrmAgregaRack_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ListaAlmacenes()
            ListaTipoUbicacion()
            CmbAlmacen.EditValue = 0
            cmbTipo.EditValue = 0
            ChkRack.Checked = True
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub

    Private Sub ListaAlmacenes()
        Try


            Dim pResultado As New CResultado
            Dim pCons As New ClsAlmacen

            Cursor.Current = Cursors.WaitCursor
            pResultado = pCons.ListaAlmacen("@", "@", My.Settings.Estacion)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                Return
            End If

            Dim dt As DataTable = New DataTable
            Dim ds As New DataSet

            dt = pResultado.Tabla.Copy
            ds.Tables.Add(dt)

            CmbAlmacen.Properties.ValueMember = "ERPAlmacen"
            CmbAlmacen.Properties.DisplayMember = "ERPAlmacen"
            CmbAlmacen.Properties.DataSource = dt

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub


    Private Sub ListaTipoUbicacion()
        Try


            Dim pResultado As New CResultado
            Dim pCons As New ClsAlmacen

            Cursor.Current = Cursors.WaitCursor
            pResultado = pCons.ListaTipoUbicacion("@", My.Settings.Estacion, DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                Return
            End If

            Dim dt As DataTable = New DataTable
            Dim ds As New DataSet

            dt = pResultado.Tabla.Copy
            ds.Tables.Add(dt)

            cmbTipo.Properties.ValueMember = "DTipo"
            cmbTipo.Properties.DisplayMember = "DTipo"
            cmbTipo.Properties.DataSource = dt

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub


#Region "METODOS"


    Private Sub ChkRack_CheckedChanged(sender As Object, e As EventArgs) Handles ChkRack.CheckedChanged
        If ChkRack.Checked Then
            ChkPiso.Checked = False
            NupNivel.Enabled = True
        End If
    End Sub

    Private Sub ChkPiso_CheckedChanged(sender As Object, e As EventArgs) Handles ChkPiso.CheckedChanged
        If ChkPiso.Checked Then
            ChkRack.Checked = False
            NupNivel.Enabled = False
        End If
    End Sub

    Private Sub txtRack_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRack.KeyPress

        'If ChkRack.Checked Then
        If Not Char.IsNumber(e.KeyChar) Then
            If Not e.KeyChar = vbBack Then
                e.Handled = True
                XtraMessageBox.Show("Solo se permiten NÚMEROS cuando se desea crear una ubicación.")
            End If

        End If
        'End If
    End Sub



#End Region

End Class
