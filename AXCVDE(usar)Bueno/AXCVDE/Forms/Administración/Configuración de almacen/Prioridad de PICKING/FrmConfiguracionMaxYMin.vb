Imports DevExpress.XtraEditors

Public Class FrmConfiguracionMaxYMin
#Region "VARIABLES"
    Public pPosicionSeleccionada As String
    Private pNumParte As String
    Private dtPosiciones As DataTable
    Dim nuevo As New ClsConfiguracionAlmacen
#End Region

#Region "EVENTOS"
    Private Sub FrmConfiguracionMaxYMin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            RemoveHandler Me.cmbAlmacen.EditValueChanged, New EventHandler(AddressOf cmbAlmacen_SelectedIndexChanged)
            ListaAlmacenes()
            AddHandler Me.cmbAlmacen.EditValueChanged, New EventHandler(AddressOf Me.cmbAlmacen_SelectedIndexChanged)
            cargarNumParte()
            ' cargarPosicionesPK()
            CargaPasillos(nuevo.ListaPasillosPK("R"))
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub cmbAlmacen_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbAlmacen.EditValueChanged
        Try
            dgLayout.Columns.Clear()
            dgLayout.Rows.Clear()

            If cmbAlmacen.EditValue = "" Then
                Exit Sub
            End If
            CargaPasillos(nuevo.ListaPasillos("R", cmbAlmacen.Text))
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "AXC")
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

            cmbAlmacen.Properties.ValueMember = "ERPAlmacen"
            cmbAlmacen.Properties.DisplayMember = "ERPAlmacen"
            cmbAlmacen.Properties.DataSource = dt

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub

    Private Sub btnAgregar_Click(sender As System.Object, e As System.EventArgs) Handles btnAgregar.Click
        Try
            If numMinimo.Value = numMaximo.Value Then
                XtraMessageBox.Show("No se puede configurar el minimo y el máximo con el mismo valor", "AXC")
                Return
            End If

            If numMinimo.Value > numMaximo.Value Then
                XtraMessageBox.Show("El valor máximo no puede ser menor que el minimo", "AXC")
                Return
            End If

            AgregarNumParte()

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub




    Private Sub cmPasillo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPasillo.EditValueChanged
        Try
            If cmbPasillo.ItemIndex < 0 Then
                Exit Sub
            End If

            DgvSeleccionadas.DataSource = Nothing
            LblUbicacionSeleccionada.Text = ""
            dgLayout.Columns.Clear()
            dgLayout.Rows.Clear()

            CargaLayout(cmbPasillo.EditValue, "")
        Catch ex As Exception
            XtraMessageBox.Show("Error: " + ex.Message, "AXC")
        End Try
    End Sub

    Private Sub dgLayout_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgLayout.MouseUp
        Try
            For Each aux As DataGridViewCell In dgLayout.SelectedCells
                DgvSeleccionadas.DataSource = Nothing

                If aux.Value = "" Then
                    LblUbicacionSeleccionada.Text = ""
                    Exit For
                End If
                ' Dim dr As DataRow = dtPosiciones.Rows(cmbPicking.SelectedIndex)
                LblUbicacionSeleccionada.Text = aux.Value
                cargarNumPartePorPosicion(aux.Value)

            Next
        Catch ex As Exception
            XtraMessageBox.Show("Error: " + ex.Message, "AXC")
        End Try
    End Sub
#End Region

#Region "METODOS"

    Private Sub cargarNumParte()
        Try

            Dim pResultado As New CResultado
            Dim pArticulo As New clsNumParte

            Cursor.Current = Cursors.WaitCursor
            pResultado = pArticulo.BuscarArticuloRPK
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto, "AXC")
                Return
            End If

            Dim dt As DataTable = New DataTable
            dt = pResultado.Tabla

            cmbNumParte.Properties.DataSource = dt
            cmbNumParte.Properties.ValueMember = "NumParte"
            cmbNumParte.Properties.DisplayMember = "Descripcion"

        Catch ex As Exception
            Cursor.Current = Cursors.Default
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub

    'Private Sub cargarPosicionesPK()
    '    Try

    '        Dim pResultado As New CResultado
    '        Dim pPicking As New CPicking

    '        Cursor.Current = Cursors.WaitCursor
    '        pResultado = pPicking.ObtenerPosicionesPK("E100")
    '        Cursor.Current = Cursors.Default

    '        If Not pResultado.Estado Then
    '            MsgBox(pResultado.Texto)
    '            Return
    '        End If

    '        Dim dt As DataTable = New DataTable
    '        dt = pResultado.Tabla
    '        dtPosiciones = pResultado.Tabla.Copy

    '        cmbPicking.ValueMember = "Posicion"
    '        cmbPicking.DisplayMember = "CodigoPos"
    '        cmbPicking.DataSource = dt
    '    Catch ex As Exception
    '        Cursor.Current = Cursors.Default
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub

    Private Sub cargarNumPartePorPosicion(prmPosicion As String)
        Try

            Dim pResultado As New CResultado
            Dim pPicking As New CPicking

            Cursor.Current = Cursors.WaitCursor
            pResultado = pPicking.NumPartePorPosicionPK(prmPosicion, My.Settings.Estacion)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                MsgBox(pResultado.Texto)
                Return
            End If

            Dim dt As DataTable = New DataTable
            dt = pResultado.Tabla

            DgvSeleccionadas.DataSource = dt
            DgvViewSeleccionadas.BestFitColumns()

        Catch ex As Exception
            Cursor.Current = Cursors.Default
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub AgregarNumParte()
        Try

            Dim pResultado As New CResultado
            Dim pPicking As New CPicking

            Cursor.Current = Cursors.WaitCursor
            pResultado = pPicking.AgregarNumParte(LblUbicacionSeleccionada.Text, cmbNumParte.EditValue, numMinimo.Value, numMaximo.Value, My.Settings.Estacion, DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto, "AXC")
                Return
            End If

            XtraMessageBox.Show("Agregado con éxito", "AXC")
            cargarNumPartePorPosicion(LblUbicacionSeleccionada.Text)
        Catch ex As Exception
            Cursor.Current = Cursors.Default
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub

    Private Sub CargaPasillos(ByVal ds As DataSet)
        Try
            cmbPasillo.Properties.DisplayMember = "Rack"
            cmbPasillo.Properties.ValueMember = "Rack"
            cmbPasillo.Properties.DataSource = ds.Tables(0)
            cmbPasillo.EditValue = 0
        Catch ex As Exception
            XtraMessageBox.Show("Error: " + ex.Message, "AXC")
        End Try
    End Sub


    Private Sub CargaLayout(ByVal prmPasillo As String, ByVal prmLado As String)
        Try
            Dim wpCol As Integer
            Dim wpRen As Integer
            Dim wpMaxCol As Integer = 0
            Dim wpMaxRen As Integer = 0
            Dim wpCont As Integer = 0

            Dim wpDato1 As New clsDato

            dgLayout.Rows.Clear()
            dgLayout.Columns.Clear()

            Application.DoEvents()

            wpDato1 = nuevo.CalculaLayout(prmPasillo, cmbAlmacen.Text)

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
                dgLayout.Rows.Item(wpCont).HeaderCell.Value = Chr(64 + wpMaxRen - wpCont).ToString
                dgLayout.Rows.Item(wpCont).Height = 50
            Next

            wpDato1.Cerrar()

            wpDato1 = New clsDato

            wpDato1 = nuevo.ListaLayout(prmPasillo, cmbAlmacen.Text)

            Dim wpCodigo As String = ""
            Dim wpColor As Color = Color.AliceBlue

            With wpDato1.DataReader

                While .Read

                    wpRen = .Item("Nivel")
                    wpCol = .Item("Posicion")
                    wpCodigo = .Item("CodigoPos")

                    If wpMaxRen = 0 Then
                        wpMaxRen = dgLayout.Rows.Count
                    End If



                    Select Case .Item("IdTipo")
                        Case 2

                            wpColor = Color.DarkViolet
                            dgLayout.Item(wpCol - 1, wpMaxRen - 1).Style.BackColor = wpColor
                            dgLayout.Item(wpCol - 1, wpMaxRen - 1).Value = wpCodigo

                        Case 4

                            wpColor = Color.LimeGreen
                            dgLayout.Item(wpCol - 1, wpMaxRen - 1).Style.BackColor = wpColor
                            dgLayout.Item(wpCol - 1, wpMaxRen - 1).Value = wpCodigo

                        Case Else

                            wpColor = Color.Black
                            dgLayout.Item(wpCol - 1, wpMaxRen - 1).Style.BackColor = wpColor
                            '  dgLayout.Item(wpCol - 1, wpMaxRen - 1).Value = wpCodigo

                    End Select
                    wpMaxRen = wpMaxRen - 1

                End While
                For Each column As DataGridViewColumn In dgLayout.Columns
                    column.SortMode = DataGridViewColumnSortMode.NotSortable
                Next
            End With

        Catch ex As Exception
            XtraMessageBox.Show("Error: " + ex.Message, "AXC")
        End Try
    End Sub
#End Region



    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles btnOrdenes.Click
        FrmPrioridadReabastecimiento.ShowDialog()
    End Sub

End Class