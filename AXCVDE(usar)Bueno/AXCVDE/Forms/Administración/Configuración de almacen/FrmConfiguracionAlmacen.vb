Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Base

Public Class FrmConfiguracionAlmacen

#Region "VARIABLES"

    Dim nuevo As New ClsConfiguracionAlmacen
    Public dsPosiciones As New DataSet

#End Region

#Region "EVENTOS"
    Private Sub frmLayoutMP_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            RemoveHandler Me.cmbAlmacen.EditValueChanged, New EventHandler(AddressOf cmbAlmacen_SelectedIndexChanged)
            ListaAlmacenes()
            AddHandler Me.cmbAlmacen.EditValueChanged, New EventHandler(AddressOf Me.cmbAlmacen_SelectedIndexChanged)
            cmbAlmacen.EditValue = ""
            LlenarTipoBusqueda()
            cmbTipo.ItemIndex = 0
        Catch ex As Exception
            XtraMessageBox.Show("Error: " + ex.Message, "AXC")
        End Try
    End Sub

    Private Sub cmdPallet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPallet.Click
        Dim Tipo As String = "PALLET"
        Try
            If XtraMessageBox.Show("¿Desea aplicar la configuración?", "AXC", MessageBoxButtons.YesNo) <> DialogResult.Yes Then
                Return
            Else

                Dim wpCelda As DataGridViewCell

                If String.IsNullOrEmpty(CmbPasillo.Text) Then
                    Exit Sub
                End If

                Dim wpDato As clsDato

                For Each wpCelda In dgLayout.SelectedCells

                    wpDato = New clsDato

                    Dim dr = nuevo.ActualizaTipoEstante(wpCelda.Value, Tipo, My.Settings("Estacion"), DatosTemporales.Usuario)
                    If dr <> "" Then
                        XtraMessageBox.Show("Error: " + dr, "AXC")
                    End If

                    wpDato.Cerrar()
                    wpDato = Nothing

                Next


                CargaLayout(CmbPasillo.EditValue)

            End If
        Catch ex As Exception
            XtraMessageBox.Show("Error: " + ex.Message, "AXC")
        End Try
    End Sub

    Private Sub cmdPicking_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPicking.Click
        Dim Tipo As String = "PICKING"
        Try

            If XtraMessageBox.Show("¿Desea aplicar la configuración?", "AXC", MessageBoxButtons.YesNo) <> DialogResult.Yes Then
                Return
            Else

                Dim wpCelda As DataGridViewCell

                If String.IsNullOrEmpty(CmbPasillo.Text) Then
                    Exit Sub
                End If


                Dim wpDato As clsDato

                For Each wpCelda In dgLayout.SelectedCells

                    wpDato = New clsDato

                    Dim dr = nuevo.ActualizaTipoEstante(wpCelda.Value, Tipo, My.Settings("Estacion"), DatosTemporales.Usuario)
                    If dr <> "" Then
                        XtraMessageBox.Show("Error: " + dr, "AXC")
                    End If

                    wpDato.Cerrar()
                    wpDato = Nothing
                Next

                CargaLayout(CmbPasillo.EditValue)

            End If
        Catch ex As Exception
            XtraMessageBox.Show("Error: " + ex.Message, "AXC")
        End Try
    End Sub

    Private Sub dgLayout_ColumnAdded(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewColumnEventArgs) Handles dgLayout.ColumnAdded
        e.Column.SortMode = DataGridViewColumnSortMode.NotSortable
    End Sub

    Private Sub btnAgregaFamilia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAgregaFamilia.Click
        Try
            If XtraMessageBox.Show("¿Desea asignar la(s) familia(s) seleccionada(s) a la ubicación(es)? seleccionada(s)", "AXC", MessageBoxButtons.YesNo) <> DialogResult.Yes Then
                Return
            End If
            Dim view As ColumnView = CType(DgvExcluidas.MainView, ColumnView)
            Dim selectedRowHandles As Integer() = view.GetSelectedRows()

            If DgvViewExcluidas.RowCount <= 0 Then
                XtraMessageBox.Show("No hay datos para asignar")
                Return
            End If

            Dim wpCelda As DataGridViewCell

            For Each wpCelda In dgLayout.SelectedCells

                For i As Integer = 0 To selectedRowHandles.Count - 1

                    nuevo.AsociaFamilia(view.GetRowCellDisplayText(selectedRowHandles(i), view.Columns("DFamilia")), wpCelda.Value, My.Settings.Estacion, DatosTemporales.Usuario)
                Next

            Next

            CargaGridsFamilias()

        Catch ex As Exception
            XtraMessageBox.Show("Error: " + ex.Message, "AXC")
        End Try
    End Sub

    Private Sub btnEliminaFamilia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminarFamilia.Click
        Try

            If XtraMessageBox.Show("¿Desea desasignar la(s) familia(s) seleccionada(s) a la ubicación(es)? seleccionada(s)?", "AXC", MessageBoxButtons.YesNo) <> DialogResult.Yes Then
                Return
            End If

            Dim view As ColumnView = CType(DgvIncluidas.MainView, ColumnView)
            Dim selectedRowHandles As Integer() = view.GetSelectedRows()

            If DgvViewIncluidas.RowCount <= 0 Then
                XtraMessageBox.Show("No hay datos para desasignar")
                Return
            End If

            Dim wpCelda As DataGridViewCell

            For Each wpCelda In dgLayout.SelectedCells

                For i As Integer = 0 To selectedRowHandles.Count - 1

                    nuevo.DesasociaFamilia(view.GetRowCellDisplayText(selectedRowHandles(i), view.Columns("DFamilia")), wpCelda.Value, My.Settings.Estacion, DatosTemporales.Usuario)
                Next

            Next
            CargaGridsFamilias()

        Catch ex As Exception
            XtraMessageBox.Show("Error: " + ex.Message, "AXC")
        End Try
    End Sub

    Private Sub dgLayout_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgLayout.MouseUp
        Try
            Dim contador = dgLayout.SelectedCells.Count
            Dim checkDivididas = False
            Dim checkNoDivididas = False
            Dim checkCantidadDivididas = 0
            For i As Integer = 0 To contador - 1
                If dgLayout.SelectedCells.Item(i).Style.BackColor = Color.FromArgb(0, 128, 128) Then
                    checkDivididas = True
                    checkCantidadDivididas += 1
                Else
                    checkNoDivididas = True
                End If
            Next

            If checkDivididas And checkNoDivididas Then
                XtraMessageBox.Show("No puede seleccionar posiciones divididas y no divididas al mismo tiempo")
                Return
            End If
            If checkDivididas And checkCantidadDivididas > 1 Then
                XtraMessageBox.Show("No puede seleccionar más de una posición dividida al mismo tiempo")
                Return
            End If

            If dgLayout.SelectedCells.Item(0).Style.BackColor = Color.FromArgb(0, 128, 128) Then

                'Dim tabla As DataTable
                'tabla.Columns.Add("Posición", GetType(String))


                'For Each posicion As String In arregloPosiciones
                '    'MsgBox(posicion)
                '    table.Rows.Add(posicion)
                '    cadena = cadena + posicion + ", "
                'Next

                'Dim valor = dgLayout.SelectedCells.Item(0).Value


                'If dgLayout.SelectedCells.Item(0).Value Then

                'End If
                ConsultaPosicionesSubdivididas(CmbPasillo.Text, dgLayout.SelectedCells.Item(0).Value)
                btnRegresarDivision.Visible = True
                Exit Sub
            End If
            CargaGridsFamilias()
            dsPosiciones = New DataSet
            dsPosiciones = CreaTabla()
            ConsultaPosiciones()
        Catch ex As Exception
            XtraMessageBox.Show("Error: " + ex.Message, "AXC")
        End Try
    End Sub

    Private Sub dgLayout_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgLayout.SelectionChanged
        Try
            CargaGridsFamilias()
        Catch ex As Exception
            MsgBox("Error: " + ex.Message, MsgBoxStyle.Critical, "AXC")
        End Try
    End Sub

    Private Sub FrmConfiguracionAlmacen_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose(True)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        FrmConfiguracionMaxYMin.ShowDialog()
    End Sub



    Private Sub BtnImprimirSeleccion_Click(sender As Object, e As EventArgs) Handles BtnImprimirSeleccion.Click
        Try
            If XtraMessageBox.Show("¿Desea imprimir las etiquetas seleccionadas?", "AXC", MessageBoxButtons.YesNo) <> DialogResult.Yes Then
                Return
            End If
            ImprimeEtiquetas()

        Catch ex As Exception
            XtraMessageBox.Show("Error: " + ex.Message, "AXC")
        End Try
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Try
            If XtraMessageBox.Show("¿Desea imprimir las etiquetas seleccionadas?", "AXC", MessageBoxButtons.YesNo) <> DialogResult.Yes Then
                Return
            End If

            ImprimeEtiquetasNombres()

        Catch ex As Exception
            XtraMessageBox.Show("Error: " + ex.Message, "AXC")
        End Try
    End Sub

    Private Sub BtnAgregarRack_Click(sender As Object, e As EventArgs) Handles BtnAgregarRack.Click
        Try
            FrmAjustesConfiguracionAlmacen.ShowDialog()
            CargaPasillos(nuevo.ListaPasillos(IIf(ChkRack.Checked, "R", "P"), cmbAlmacen.Text))
        Catch ex As Exception
            XtraMessageBox.Show("Error: " + ex.Message, "AXC")
        End Try
    End Sub

    Private Sub BtnBaja_Click(sender As Object, e As EventArgs) Handles BtnBaja.Click
        Try
            If dsPosiciones.Tables.Count < 1 Then
                XtraMessageBox.Show("Seleccionar Posiciones", "AXC", MessageBoxButtons.OK)
                Return
            End If
            If XtraMessageBox.Show("¿Dar de baja las posiciones seleccionadas?", "AXC", MessageBoxButtons.YesNo) <> DialogResult.Yes Then
                Return
            End If

            BajaPosiciones()
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub


    Private Sub CmbPasillo_EditValueChanged(sender As Object, e As EventArgs) Handles CmbPasillo.EditValueChanged
        Try
            If String.IsNullOrEmpty(CmbPasillo.Text) Then
                Exit Sub
            End If
            dgLayout.Columns.Clear()
            dgLayout.Rows.Clear()
            CargaLayout(CmbPasillo.EditValue)
            DgvSeleccionadas.DataSource = Nothing
        Catch ex As Exception
            XtraMessageBox.Show("Error: " + ex.Message, "AXC")
        End Try
    End Sub

    Private Sub cndCuarentena_Click(sender As Object, e As EventArgs) Handles cndCuarentena.Click
        Dim Tipo As String = "CUARENTENA"
        Try
            If XtraMessageBox.Show("¿Desea aplicar la configuración?", "AXC", MessageBoxButtons.YesNo) <> DialogResult.Yes Then
                Return
            Else

                Dim wpCelda As DataGridViewCell

                If String.IsNullOrEmpty(CmbPasillo.Text) Then
                    Exit Sub
                End If

                Dim wpDato As clsDato

                For Each wpCelda In dgLayout.SelectedCells

                    wpDato = New clsDato

                    Dim dr = nuevo.ActualizaTipoEstante(wpCelda.Value, Tipo, My.Settings("Estacion"), DatosTemporales.Usuario)
                    If dr <> "" Then
                        XtraMessageBox.Show("Error: " + dr, "AXC")
                    End If

                    wpDato.Cerrar()
                    wpDato = Nothing
                Next

                CargaLayout(CmbPasillo.EditValue)

            End If
        Catch ex As Exception
            XtraMessageBox.Show("Error: " + ex.Message, "AXC")
        End Try
    End Sub

    Private Sub BtnActiva_Click(sender As Object, e As EventArgs) Handles BtnActiva.Click
        Try
            If dsPosiciones.Tables.Count < 1 Then
                XtraMessageBox.Show("Seleccionar Posiciones", "AXC", MessageBoxButtons.OK)
                Return
            End If
            If XtraMessageBox.Show("¿Activar las posiciones seleccionadas?", "AXC", MessageBoxButtons.YesNo) <> DialogResult.Yes Then
                Return
            End If

            ActivaPosiciones()
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub


    Private Sub BtnBloqueado_Click(sender As Object, e As EventArgs) Handles BtnBloqueado.Click
        Try
            If dsPosiciones.Tables.Count < 1 Then
                XtraMessageBox.Show("Seleccionar Posiciones", "AXC", MessageBoxButtons.OK)
                Return
            End If
            If XtraMessageBox.Show("¿Bloquear las posiciones seleccionadas?", "AXC", MessageBoxButtons.YesNo) <> DialogResult.Yes Then
                Return
            End If

            BloqueaPosiciones()
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub

    Public Sub cmbAlmacen_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbAlmacen.EditValueChanged
        'Almacen = cmbAlmacen.EditValue.text
        Try
            dgLayout.Columns.Clear()
            dgLayout.Rows.Clear()

            If cmbAlmacen.EditValue = "" Then
                Exit Sub
            End If
            DgvSeleccionadas.DataSource = Nothing
            CargaPasillos(nuevo.ListaPasillos(IIf(ChkRack.Checked, "R", "P"), cmbAlmacen.EditValue.ToString))
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "AXC")
        End Try
    End Sub



    Private Sub ChkRack_CheckedChanged(sender As Object, e As EventArgs) Handles ChkRack.CheckedChanged

        If ChkRack.Checked Then
            ChkPiso.Checked = False
            CargaPasillos(nuevo.ListaPasillos(IIf(ChkRack.Checked, "R", "P"), cmbAlmacen.EditValue.ToString))
            DgvSeleccionadas.DataSource = Nothing
            dgLayout.Columns.Clear()
            CmbPasillo.EditValue = ""
        ElseIf Not ChkRack.Checked And Not ChkPiso.Checked Then
            DgvSeleccionadas.DataSource = Nothing
            dgLayout.Columns.Clear()
            CmbPasillo.EditValue = ""
        End If
    End Sub

    Private Sub ChkPiso_CheckedChanged(sender As Object, e As EventArgs) Handles ChkPiso.CheckedChanged
        If ChkPiso.Checked Then
            ChkRack.Checked = False
            CargaPasillos(nuevo.ListaPasillos(IIf(ChkRack.Checked, "R", "P"), cmbAlmacen.EditValue.ToString))
            DgvSeleccionadas.DataSource = Nothing
            dgLayout.Columns.Clear()
            CmbPasillo.EditValue = ""
        ElseIf Not ChkRack.Checked And Not ChkPiso.Checked Then
            DgvSeleccionadas.DataSource = Nothing
            dgLayout.Columns.Clear()
            CmbPasillo.EditValue = ""
        End If
    End Sub

    Private Sub cmdKanbanPK_Click(sender As Object, e As EventArgs) Handles cmdKanbanPK.Click
        Dim Tipo As String = "PICKING KANBAN"
        Try
            If XtraMessageBox.Show("¿Desea aplicar la configuración?", "AXC", MessageBoxButtons.YesNo) <> DialogResult.Yes Then
                Return
            Else

                Dim wpCelda As DataGridViewCell

                If String.IsNullOrEmpty(CmbPasillo.Text) Then
                    Exit Sub
                End If

                Dim wpDato As clsDato

                For Each wpCelda In dgLayout.SelectedCells

                    wpDato = New clsDato

                    nuevo.ActualizaTipoEstante(wpCelda.Value, Tipo, My.Settings("Estacion"), DatosTemporales.Usuario)

                    wpDato.Cerrar()
                    wpDato = Nothing
                Next

                CargaLayout(CmbPasillo.EditValue)

            End If
        Catch ex As Exception
            XtraMessageBox.Show("Error: " + ex.Message, "AXC")
        End Try
    End Sub

    Private Sub cmdKanban_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdKanban.Click
        Dim Tipo As String = "PALLET KANBAN"
        Try
            If XtraMessageBox.Show("¿Desea aplicar la configuración?", "AXC", MessageBoxButtons.YesNo) <> DialogResult.Yes Then
                Return
            Else

                Dim wpCelda As DataGridViewCell

                If String.IsNullOrEmpty(CmbPasillo.Text) Then
                    Exit Sub
                End If


                Dim wpDato As clsDato

                For Each wpCelda In dgLayout.SelectedCells

                    wpDato = New clsDato

                    nuevo.ActualizaTipoEstante(wpCelda.Value, Tipo, My.Settings("Estacion"), DatosTemporales.Usuario)

                    wpDato.Cerrar()
                    wpDato = Nothing
                Next


                CargaLayout(CmbPasillo.EditValue)

            End If
        Catch ex As Exception
            XtraMessageBox.Show("Error: " + ex.Message, "AXC")
        End Try
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

    Private Sub CargaLayout(ByVal prmPasillo As String)
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
                dgLayout.Rows.Item(wpCont).HeaderCell.Value = (wpMaxRen - wpCont).ToString
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

                        Case 6

                            wpColor = Color.FromArgb(0, 128, 128)

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
    Private Sub ConsultaPosicionesSubdivididas(ByVal prmPasillo As String, prmPosicion$)
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

            wpDato1 = nuevo.CalculaLayoutDivisiones(prmPosicion, prmPasillo, cmbAlmacen.Text)

            With wpDato1.DataReader

                While .Read

                    'wpMaxRen = .Item("Niveles")
                    'wpMaxCol = .Item("Posiciones")
                    wpMaxRen = .Item("Posiciones")
                    wpMaxCol = .Item("Niveles")

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

            wpDato1 = nuevo.ListaLayoutDivisiones(prmPosicion, prmPasillo, cmbAlmacen.Text)

            Dim wpCodigo As String = ""
            Dim wpColor As Color = Color.AliceBlue

            Dim contador = 0
            With wpDato1.DataReader

                While .Read
                    'wpDato1.Tabla.
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

                        Case 6

                            wpColor = Color.FromArgb(0, 128, 128)

                    End Select

                    Select Case .Item("IdStatus")

                        Case 2
                            wpColor = Color.Black

                    End Select

                    If wpMaxRen = 0 Then
                        wpMaxRen = dgLayout.Rows.Count
                    End If

                    dgLayout.Item(contador, 0).Style.BackColor = wpColor
                    dgLayout.Item(contador, 0).Value = wpCodigo

                    wpMaxRen = wpMaxRen - 1
                    contador += 1
                End While

            End With


        Catch ex As Exception
            XtraMessageBox.Show("Error: " + ex.Message, "AXC")
        End Try
    End Sub

    Private Function CargaFamiliasExcluidas(ByVal ds As DataSet)
        Try

            DgvExcluidas.DataSource = ds.Tables(1)
            DgvViewExcluidas.BestFitColumns()

            If ds.Tables(1).Rows.Count <= 0 Then
                HabilitaBotonAgregar(False)
            Else
                HabilitaBotonAgregar(True)
            End If
        Catch ex As Exception
            XtraMessageBox.Show("Error: " + ex.Message, "AXC")
        End Try
    End Function

    Private Function CargaFamiliasIncluidas(ByVal ds As DataSet)
        Try
            DgvIncluidas.DataSource = ds.Tables(1)
            DgvViewIncluidas.BestFitColumns()
            If ds.Tables(1).Rows.Count <= 0 Then
                HabilitaBotonEliminar(False)
            Else
                HabilitaBotonEliminar(True)
            End If
        Catch ex As Exception
            XtraMessageBox.Show("Error: " + ex.Message, "AXC")
        End Try
    End Function

    Sub CargaGridsFamilias()
        Try
            Dim ds As New DataSet
            ds = CreaTabla()
            CargaFamiliasExcluidas(nuevo.CargaFamiliasExcluidas(ds.GetXml(), My.Settings("Estacion"), DatosTemporales.Usuario))
            CargaFamiliasIncluidas(nuevo.CargaFamiliasIncluidas(ds.GetXml(), My.Settings("Estacion"), DatosTemporales.Usuario))
        Catch ex As Exception
            XtraMessageBox.Show("Error: " + ex.Message, "AXC")
        End Try
    End Sub

    Private Function CreaTabla() As DataSet
        Try
            Dim dt As DataTable = New DataTable("Layout")
            Dim newDr As DataRow
            Dim ds As DataSet = New DataSet("NewDataSet")
            dt.Columns.Add("CodigoEstante")

            For Each aux As DataGridViewCell In dgLayout.SelectedCells
                newDr = dt.NewRow()
                newDr("CodigoEstante") = aux.Value
                dt.Rows.Add(newDr)
            Next

            ds.Tables.Add(dt)
            Return ds
        Catch ex As Exception
            XtraMessageBox.Show("Error: " + ex.Message, "AXC")
        End Try
    End Function

    Private Sub ImprimeEtiquetas()
        Try
            Dim Posicion1 As String
            Dim Posicion2 As String
            Dim Impresora As String

            Dim nuevoUsuario As New clsUsuario

            Dim ds As DataSet


            Dim CRespuesta As New CResultado

            Dim pResultado As New wsAXC.CResultado
            Dim ws As New wsAXC.wsAXCMP

            ds = nuevoUsuario.ImpresioraCredencialPorEstacion(My.Settings("Estacion"), "POS", My.Settings("Estacion"), DatosTemporales.Usuario)
            Impresora = ds.Tables(1).Rows(0)(0).ToString()

            Dim pUrl As String = My.Settings("AXCVDE_wsAXC_wsAXCMP")

            If pUrl = "" Then
                pUrl = "http://192.168.1.181/axcVDEpt/wsAXCMP.asmx"
            End If

            ws.Url = pUrl
            Cursor.Current = Cursors.WaitCursor
            Dim pOpcion As String = ""

            If cmbTipo.ItemIndex = 0 Then
                pOpcion = 1
            ElseIf cmbTipo.ItemIndex = 1 Then
                pOpcion = 2
            Else
                pOpcion = 3
            End If

            For Each aux As DataGridViewCell In dgLayout.SelectedCells
                Posicion1 = aux.Value
                pResultado = ws.WM_ImprimeEtiquetaPosicion(Posicion1, pOpcion, Impresora)
                Posicion1 = ""
            Next
            pOpcion = ""

            XtraMessageBox.Show("Impresión enviada con éxito", "AXC", MessageBoxButtons.OK)



        Catch ex As Exception
            XtraMessageBox.Show("Error: " + ex.Message, "AXC")
        End Try
    End Sub

    Sub HabilitaBotonAgregar(ByVal Habilita As Boolean)
        Try
            BtnAgregaFamilia.Enabled = Habilita
        Catch ex As Exception
            XtraMessageBox.Show("Error: " + ex.Message, "AXC")
        End Try
    End Sub

    Sub HabilitaBotonEliminar(ByVal Habilita As Boolean)
        Try
            BtnEliminarFamilia.Enabled = Habilita
        Catch ex As Exception
            XtraMessageBox.Show("Error: " + ex.Message, "AXC")
        End Try
    End Sub

    Private Sub ImprimeEtiquetasNombres()
        Try
            Dim Posicion1 As String
            Dim Posicion2 As String
            Dim Impresora As String

            Dim nuevoUsuario As New clsUsuario

            Dim ds As DataSet


            Dim CRespuesta As New CResultado

            Dim pResultado As New wsAXC.CResultado
            Dim ws As New wsAXC.wsAXCMP

            ds = nuevoUsuario.ImpresioraCredencialPorEstacion(My.Settings("Estacion"), "POS", My.Settings("Estacion"), DatosTemporales.Usuario)
            Impresora = ds.Tables(1).Rows(0)(0).ToString()

            Dim pUrl As String = My.Settings("AXCVDE_wsAXC_wsAXCMP")

            If pUrl = "" Then
                pUrl = "http://192.168.1.181/axcVDEpt/wsAXCMP.asmx"
            End If

            ws.Url = pUrl
            Cursor.Current = Cursors.WaitCursor

            'If dgLayout.SelectedCells.Count = 1 Then

            '    For Each aux As DataGridViewCell In dgLayout.SelectedCells
            '        Posicion1 = aux.Value
            '    Next

            '    pResultado = ws.WM_ImprimeEtiquetaNombres(Posicion1, "", Impresora)
            'Else

            '    Dim i As Integer = 1
            '    Dim Con As Integer = 0
            '    For Each aux As DataGridViewCell In dgLayout.SelectedCells

            '        If i = 1 Then
            '            Posicion1 = aux.Value
            '            i = 2
            '            Con = Con + 1
            '        ElseIf i = 2 Then
            '            Posicion2 = aux.Value
            '            i = 1
            '            Con = Con + 1
            '        End If

            '        If Con = dgLayout.SelectedCells.Count And ((dgLayout.SelectedCells.Count Mod 2) <> 0) Then
            '            pResultado = ws.WM_ImprimeEtiquetaNombres(Posicion1, "", Impresora)
            '        End If

            '        If i = 1 Then
            '            pResultado = ws.WM_ImprimeEtiquetaNombres(Posicion1, Posicion2, Impresora)
            '            Posicion1 = ""
            '            Posicion2 = ""
            '        End If

            '    Next
            'End If
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then

                XtraMessageBox.Show("ER" + pResultado.Texto)
                Return
            Else
                XtraMessageBox.Show("Impresión enviada con éxito", "AXC")
            End If

        Catch ex As Exception
            XtraMessageBox.Show("Error: " + ex.Message, "AXC")
        End Try
    End Sub

    Private Sub BajaPosiciones()
        Try
            Dim pResultado As New CResultado
            Dim Cls As New ClsConfiguracionAlmacen


            Cursor.Current = Cursors.WaitCursor
            pResultado = Cls.BajaPosiciones(dsPosiciones.GetXml(), cmbAlmacen.Text, My.Settings.Estacion, DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                Return
            End If

            XtraMessageBox.Show("Posiciones dadas de baja con éxito")
            If String.IsNullOrEmpty(CmbPasillo.Text) Then
                Exit Sub
            End If
            dgLayout.Columns.Clear()
            dgLayout.Rows.Clear()
            CargaLayout(CmbPasillo.EditValue)

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ActivaPosiciones()
        Try
            Dim pResultado As New CResultado
            Dim Cls As New ClsConfiguracionAlmacen


            Cursor.Current = Cursors.WaitCursor
            pResultado = Cls.ActivaPosiciones(dsPosiciones.GetXml(), cmbAlmacen.Text, My.Settings.Estacion, DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                Return
            End If

            XtraMessageBox.Show("Posiciones activadas con éxito")
            If String.IsNullOrEmpty(CmbPasillo.Text) Then
                Exit Sub
            End If
            dgLayout.Columns.Clear()
            dgLayout.Rows.Clear()
            CargaLayout(CmbPasillo.EditValue)

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BloqueaPosiciones()
        Try
            Dim pResultado As New CResultado
            Dim Cls As New ClsConfiguracionAlmacen


            Cursor.Current = Cursors.WaitCursor
            pResultado = Cls.BloqueaPosiciones(dsPosiciones.GetXml(), cmbAlmacen.Text, My.Settings.Estacion, DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                Return
            End If

            XtraMessageBox.Show("Posiciones bloqueadas con éxito")
            If String.IsNullOrEmpty(CmbPasillo.Text) Then
                Exit Sub
            End If
            dgLayout.Columns.Clear()
            dgLayout.Rows.Clear()
            CargaLayout(CmbPasillo.EditValue)

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ConsultaPosiciones()
        Try
            DgvSeleccionadas.DataSource = Nothing

            Dim pResultado As New CResultado
            Dim Cls As New ClsConfiguracionAlmacen

            Cursor.Current = Cursors.WaitCursor
            pResultado = Cls.ConsultaPosiciones(dsPosiciones.GetXml, cmbAlmacen.Text, My.Settings.Estacion, DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                DgvSeleccionadas.DataSource = Nothing
                Return
            End If
            Dim dt As New DataTable
            dt = pResultado.Tabla

            If dt.Rows.Count < 1 Then
                XtraMessageBox.Show("Seleccionar un rack para poder consultar sus posiciones.")
                DgvSeleccionadas.DataSource = Nothing
                Return
            End If

            DgvSeleccionadas.DataSource = dt




            Dim ds As New DataSet
            ds.Tables.Add(ListaNumParte)

            Dim row As DataRow = ds.Tables(0).NewRow
            row.Item(0) = 0
            row.Item(1) = "TODOS"
            ds.Tables(0).Rows.InsertAt(row, 0)

            RepositoryItemLookUpEdit1.DataSource = ds.Tables(0)
            RepositoryItemLookUpEdit1.ValueMember = "NumParte"
            RepositoryItemLookUpEdit1.DisplayMember = "NumParte"

            DgvViewSeleccionadas.Columns("Producto").ColumnEdit = RepositoryItemLookUpEdit1

            'DgvViewSeleccionadas.Columns("Capacidad").ColumnEdit = dt.Columns("Capacidad").ToString
            DgvViewSeleccionadas.BestFitColumns()

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Function ListaNumParte() As DataTable
        Try
            Dim pResultado As New CResultado
            Dim pOC As New COrdenCompraR
            Dim dt As DataTable = New DataTable

            Cursor.Current = Cursors.WaitCursor
            pResultado = pOC.ListaNumParte()
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                Return dt
            End If

            dt = pResultado.Tabla
            Return dt

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try

    End Function

    Private Sub BtnActualizar_Click_1(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        Try
            If DgvViewSeleccionadas.RowCount <= 0 Then
                XtraMessageBox.Show("Seleccionar Posiciones", "AXC", MessageBoxButtons.OK)
                Return
            End If
            If XtraMessageBox.Show("¿Actualizar las posiciones seleccionadas?", "AXC", MessageBoxButtons.YesNo) <> DialogResult.Yes Then
                Return
            End If

            ActualizaPosiciones()
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub

    Private Sub ActualizaPosiciones()
        Try
            Dim pResultado As New CResultado
            Dim Cls As New ClsConfiguracionAlmacen

            Dim dt As New DataTable
            Dim ds As New DataSet

            dt = TryCast(DgvSeleccionadas.DataSource, DataTable)
            ds.Tables.Add(dt.Copy)
            Cursor.Current = Cursors.WaitCursor
            pResultado = Cls.ActualizaPosiciones(ds.GetXml, cmbAlmacen.Text, My.Settings.Estacion, DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                Return
            End If

            XtraMessageBox.Show("Posiciones actualizadas con éxito")
            If String.IsNullOrEmpty(CmbPasillo.Text) Then
                Exit Sub
            End If
            dgLayout.Columns.Clear()
            dgLayout.Rows.Clear()
            DgvSeleccionadas.DataSource = Nothing
            DgvViewSeleccionadas.RefreshData()

            CargaLayout(CmbPasillo.EditValue)

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
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
            cmbAlmacen.Properties.ValueMember = "Almacen"
            cmbAlmacen.Properties.DisplayMember = "Almacen"
            cmbAlmacen.Properties.DataSource = dt

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub



    Public Sub LlenarTipoBusqueda()
        Try
            Dim TipoBus = New List(Of String)()
            TipoBus.Add("OPCIÓN 1")
            TipoBus.Add("OPCIÓN 2")
            'TipoBus.Add("OPCIÓN 3")

            cmbTipo.Properties.DataSource = TipoBus

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub

    Public Sub recargarLayout()
        Try
            If String.IsNullOrEmpty(CmbPasillo.Text) Then
                Exit Sub
            End If
            dgLayout.Columns.Clear()
            dgLayout.Rows.Clear()
            CargaLayout(CmbPasillo.EditValue)
            DgvSeleccionadas.DataSource = Nothing
        Catch ex As Exception
            XtraMessageBox.Show("Error: " + ex.Message, "AXC")
        End Try
    End Sub

    Private Sub GroupControl1_Paint(sender As Object, e As PaintEventArgs) Handles GroupControl1.Paint

    End Sub

    Private Sub BtnPicking_Click(sender As Object, e As EventArgs) Handles BtnPicking.Click
        Try
            FrmConfiguracionMaxYMin.ShowDialog()
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub

    Private Sub btnSubdividir_Click(sender As Object, e As EventArgs) Handles btnSubdividir.Click
        Try
            If DgvViewSeleccionadas.RowCount <= 0 Then
                XtraMessageBox.Show("Debe haber al menos una posición seleccionada para subdividir", "AXC")
                Return
            End If

            If ChkPiso.Checked Then
                XtraMessageBox.Show("Las posiciones de tipo piso no pueden ser divididas", "AXC")
                Return
            End If


            Dim contador = dgLayout.SelectedCells.Count
            Dim checkDivididas = False
            Dim checkNoDivididas = False
            Dim checkCantidadDivididas = 0
            For j As Integer = 0 To contador - 1
                Dim valorUltimaLetra = dgLayout.SelectedCells.Item(j).Value.ToString.Substring(Len(dgLayout.SelectedCells.Item(j).Value.ToString) - 1, 1) 'selecciono la ultima letra para comprarar si es un número
                If valorUltimaLetra = "1" Or
                    valorUltimaLetra = "2" Or
                    valorUltimaLetra = "3" Or
                    valorUltimaLetra = "4" Or
                    valorUltimaLetra = "5" Or
                    valorUltimaLetra = "6" Or
                    valorUltimaLetra = "7" Or
                    valorUltimaLetra = "8" Or
                    valorUltimaLetra = "9" Then

                    XtraMessageBox.Show("No puedes dividir ubicaciones subdivididas", "AXC")
                    Return
                End If

                If dgLayout.SelectedCells.Item(j).Style.BackColor <> Color.DarkViolet Then
                    XtraMessageBox.Show("Solo se pueden subdividir posiciones de tipo picking", "AXC")
                    Return
                End If
            Next


            Dim filas = DgvViewSeleccionadas.RowCount
            Dim formS As New FrmSubidivirPosicion
            Dim arreglo(filas - 1) As String

            Dim i As Integer = 0
            Do While i < DgvViewSeleccionadas.RowCount
                Dim row As DataRow = DgvViewSeleccionadas.GetDataRow(i)
                If Not row Is Nothing Then
                    'MsgBox(row.Item(0).ToString)
                    arreglo(i) = row.Item(0).ToString

                End If
                i += 1
            Loop
            formS.almacen = cmbAlmacen.Text
            formS.arregloPosiciones = arreglo
            formS.ShowDialog()


            'formS.arregloPosiciones.
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try

    End Sub

    Private Sub btnRegresarDivision_Click(sender As Object, e As EventArgs) Handles btnRegresarDivision.Click
        Try
            If String.IsNullOrEmpty(CmbPasillo.Text) Then
                Exit Sub
            End If
            dgLayout.Columns.Clear()
            dgLayout.Rows.Clear()
            CargaLayout(CmbPasillo.EditValue)
            DgvSeleccionadas.DataSource = Nothing
            btnRegresarDivision.Visible = False
        Catch ex As Exception
            XtraMessageBox.Show("Error: " + ex.Message, "AXC")
        End Try
    End Sub

#End Region
End Class