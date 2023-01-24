Imports DevExpress.XtraEditors

Public Class FrmAjustesConfiguracionAlmacen


#Region "VARIABLES"
    Dim nuevo As New ClsConfiguracionAlmacen
    Dim wpPasillo As String = ""
    Dim wpLado As String = ""
    Dim wpLadoBusqueda As String = ""
    Public pAgregarRack As Boolean = False
#End Region

#Region "EVENTOS"
    Private Sub FrmAjustesConfiguracionAlmacen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            RemoveHandler Me.CmbAlmacen.EditValueChanged, New EventHandler(AddressOf cmbAlmacen_SelectedIndexChanged)
            ListaAlmacenes()
            AddHandler Me.CmbAlmacen.EditValueChanged, New EventHandler(AddressOf Me.cmbAlmacen_SelectedIndexChanged)
            CmbAlmacen.EditValue = ""
            '  CargaPasillos(nuevo.ListaPasillos(IIf(ChkRack.Checked, "R", "P"), CmbAlmacen.Text))
        Catch ex As Exception
            XtraMessageBox.Show("Error: " + ex.Message, "AXC")
        End Try
    End Sub

    Private Sub cmPasillo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbPasillo.EditValueChanged
        Try
            If CmbPasillo.EditValue = "" Then
                Exit Sub
            End If

            dgLayout.Columns.Clear()
            dgLayout.Rows.Clear()

            CargaLayout(CmbPasillo.EditValue)
        Catch ex As Exception
            XtraMessageBox.Show("Error: " + ex.Message, "AXC")
        End Try
    End Sub

    Private Sub dgLayout_ColumnAdded(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewColumnEventArgs) Handles dgLayout.ColumnAdded
        e.Column.SortMode = DataGridViewColumnSortMode.NotSortable
    End Sub

    Private Sub btnAgregarPos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarPos.Click
        Dim resp As CResultado
        Try
            If dgLayout.Rows.Count <= 0 Then
                XtraMessageBox.Show("No se ha seleccionado una ubicación", "AXC")
                Return
            End If

            If NupPos.Value <= 0 Then
                XtraMessageBox.Show("Indicar el número de posiciones a agregar", "AXC")
                Return
            End If

            If String.IsNullOrEmpty(TxtCapacidadPos.Text) Then
                XtraMessageBox.Show("Ingresar capacidad de las posiciones", "AXC")
                TxtCapacidadPos.Select()
                Return
            End If

            If XtraMessageBox.Show("¿Desea agregar " + NupPos.Value.ToString() + " posición(es)?" & vbNewLine & vbNewLine & "Nota: Este cambio no se puede deshacer", "AXC", MessageBoxButtons.YesNo) <> DialogResult.Yes Then
                Return
            End If

            'Continuar
            'Dim obj As ClsConfiguracionAlmacen
            resp = nuevo.AgregaPosicionAlmacen(CmbPasillo.EditValue, CInt(NupPos.Value), TxtCapacidadPos.Text, CmbAlmacen.Text, IIf(ChkRack.Checked, "R", "P"), My.Settings("Estacion"), DatosTemporales.Usuario)
            If Not resp.Estado Then
                XtraMessageBox.Show(resp.Texto, " AXC")
                TxtCapacidadPos.Select()
                Return
            End If
            XtraMessageBox.Show("Posicion(es) agregada(s) con éxito", "AXC")
            TxtCapacidadPos.Text = ""
            'If resp.Estado = "OK" Then
            '    XtraMessageBox.Show("Posicion(es) agregada(s) con éxito", "AXC")
            '    TxtCapacidadPos.Text = ""
            'Else
            '    XtraMessageBox.Show(resp, " AXC")
            '    TxtCapacidadPos.Select()
            '    Return
            'End If

            CargaLayout(CmbPasillo.EditValue)
            NupPos.Value = 0
        Catch ex As Exception
            XtraMessageBox.Show("Error: " + ex.Message, "AXC")
        End Try
    End Sub

    Private Sub btnAgregarNivel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAgregaNivel.Click
        Dim resp As String = ""
        Try
            If dgLayout.Rows.Count <= 0 Then
                XtraMessageBox.Show("No se ha agregado el lado " & wpLado & " al rack", "AXC")
                Return
            End If

            If NupNivel.Value <= 0 Then
                XtraMessageBox.Show("Indicar el número de niveles a agregar", "AXC")
                Return
            End If


            If String.IsNullOrEmpty(TxtCapacidadNiv.Text) Then
                XtraMessageBox.Show("Ingresar capacidad de los niveles", "AXC")
                TxtCapacidadNiv.Select()
                Return
            End If

            If XtraMessageBox.Show("¿Desea agregar " + NupNivel.Value.ToString() + "  nivel(es) ?" & vbNewLine & vbNewLine & "Nota: Este cambio no se puede deshacer", "AXC", MessageBoxButtons.YesNo) <> DialogResult.Yes Then
                Return
            End If

            resp = nuevo.AgregaNivelAlmacen(CmbPasillo.EditValue, NupNivel.Value, TxtCapacidadNiv.Text, CmbAlmacen.Text, IIf(ChkRack.Checked, "R", "P"), My.Settings("Estacion"), DatosTemporales.Usuario)
            If resp = "OK" Then
                XtraMessageBox.Show("Nivel(es) agregado(s) con éxito", "AXC")
                TxtCapacidadNiv.Text = ""
            Else
                XtraMessageBox.Show(resp, "AXC")
                TxtCapacidadNiv.Select()
                Return
            End If

            CargaLayout(CmbPasillo.EditValue)
            NupNivel.Value = 0
        Catch ex As Exception
            XtraMessageBox.Show("Error: " + ex.Message, "AXC")
        End Try
    End Sub

    Private Sub btnAgregarRack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAgregaRack.Click

        Try

            FrmAgregaRack.ShowDialog()

            If pAgregarRack Then
                CargaPasillos(nuevo.ListaPasillos(IIf(ChkRack.Checked, "R", "P"), CmbAlmacen.Text))
                CargaLayout(CmbPasillo.EditValue)
            End If

            NupNivel.Value = 0
            NupPos.Value = 0
        Catch ex As Exception
            MsgBox("Error: " + ex.Message, MsgBoxStyle.Critical, "AXC")
        End Try
    End Sub

    Public Sub cmbAlmacen_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbAlmacen.EditValueChanged
        Try
            dgLayout.Columns.Clear()
            dgLayout.Rows.Clear()

            If CmbAlmacen.EditValue = "" Then
                Exit Sub
            End If
            CargaPasillos(nuevo.ListaPasillos(IIf(ChkRack.Checked, "R", "P"), CmbAlmacen.Text))
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub

    Private Sub ChkRack_CheckedChanged(sender As Object, e As EventArgs) Handles ChkRack.CheckedChanged
        If ChkRack.Checked Then
            ChkPiso.Checked = False
            CargaPasillos(nuevo.ListaPasillos(IIf(ChkRack.Checked, "R", "P"), CmbAlmacen.Text))
        End If
    End Sub

    Private Sub ChkPiso_CheckedChanged(sender As Object, e As EventArgs) Handles ChkPiso.CheckedChanged
        If ChkPiso.Checked Then
            ChkRack.Checked = False
            CargaPasillos(nuevo.ListaPasillos(IIf(ChkRack.Checked, "R", "P"), CmbAlmacen.Text))
        End If
    End Sub

#End Region

#Region "METODOS"
    Private Sub CargaPasillos(ByVal ds As DataSet)
        Try
            CmbPasillo.Properties.DisplayMember = "Rack"
            CmbPasillo.Properties.ValueMember = "Rack"
            CmbPasillo.Properties.DataSource = ds.Tables(0)
        Catch ex As Exception
            XtraMessageBox.Show("Error: " + ex.Message, "AXC")
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


    Private Sub CargaLayout(ByVal prmPasillo As String)
        Try
            Dim wpCol As Integer
            Dim wpRen As Integer
            Dim wpMaxCol As Integer = 0
            Dim wpMaxRen As Integer = 0
            Dim wpCont As Integer = 0

            Dim wpDato1 As New clsDato

            If String.IsNullOrEmpty(prmPasillo) Then
                'XtraMessageBox.Show()
                Return
            End If

            dgLayout.Rows.Clear()
            dgLayout.Columns.Clear()

            Application.DoEvents()

            wpDato1 = nuevo.CalculaLayout(prmPasillo, CmbAlmacen.Text)

            With wpDato1.DataReader

                While .Read

                    wpMaxRen = .Item("Niveles")
                    wpMaxCol = .Item("Posiciones")

                End While

            End With

            For wpCont = 1 To wpMaxCol

                dgLayout.Columns.Add(wpCont.ToString, wpCont.ToString)

            Next

            If wpMaxRen <= 0 Then
                Exit Sub
            End If

            dgLayout.Rows.Add(wpMaxRen)

            dgLayout.RowHeadersWidth = 60
            dgLayout.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
            dgLayout.ColumnHeadersHeight = 50
            dgLayout.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing

            For wpCont = 0 To wpMaxRen - 1
                dgLayout.Rows.Item(wpCont).HeaderCell.Value = (wpMaxRen - wpCont).ToString
                dgLayout.Rows.Item(wpCont).Height = 50
            Next

            wpDato1.Cerrar()

            wpDato1 = New clsDato

            wpDato1 = nuevo.ListaLayout(prmPasillo, CmbAlmacen.Text)

            Dim wpCodigo As String = ""
            Dim wpColor As Color = Color.AliceBlue

            With wpDato1.DataReader

                While .Read

                    wpRen = .Item("Nivel")
                    wpCol = .Item("Posicion")
                    wpCodigo = .Item("CodigoPos")

                    Select Case .Item("IdTipo")

                        Case 1

                            wpColor = Color.Blue

                        Case 2

                            wpColor = Color.DarkViolet

                        Case 3

                            wpColor = Color.OliveDrab

                        Case 4

                            wpColor = Color.LimeGreen

                        Case 5

                            wpColor = Color.FromArgb(255, 128, 0)

                    End Select

                    Select Case .Item("IdStatus")

                        Case 2
                            wpColor = Color.Black

                    End Select

                    If wpMaxRen = 0 Then
                        wpMaxRen = dgLayout.Rows.Count
                    End If

                    dgLayout.Item(wpCol - 1, wpMaxRen - 1).Style.BackColor = wpColor
                    dgLayout.Item(wpCol - 1, wpMaxRen - 1).Value = wpCodigo

                    wpMaxRen = wpMaxRen - 1



                End While

            End With

        Catch ex As Exception
            XtraMessageBox.Show("Error: " + ex.Message, "AXC")
        End Try
    End Sub

    Private Sub txtCapacidadPos_KeyPress(sender As Object, e As KeyPressEventArgs)

    End Sub

    Private Sub txtCapacidadNiv_KeyPress(sender As Object, e As KeyPressEventArgs)

    End Sub

    Private Sub FrmAjustesConfiguracionAlmacen_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose(True)
    End Sub

#End Region
End Class