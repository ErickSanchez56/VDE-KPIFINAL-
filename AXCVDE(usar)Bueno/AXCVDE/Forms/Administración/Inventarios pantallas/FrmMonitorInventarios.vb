Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraPrinting

Public Class FrmMonitorInventarios

#Region "VARIABLES"
    Dim nuevo As New ClsAlmacen
#End Region

#Region "EVENTOS"
    Private Sub FrmMonitorInventarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            CargaComboInventarios(nuevo.ListaTiposInventarios(My.Settings("Estacion"), DatosTemporales.Usuario))
            ListaAlmacenes()

        Catch ex As Exception
            XtraMessageBox.Show("Error: " + ex.Message, "AXC")
        End Try
    End Sub

    Private Sub cbTipoInventario_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbTipoInventario.EditValueChanged
        Try
            LimpiaTodo()
            cbIds.Properties.DataSource = Nothing

            If cbTipoInventario.ItemIndex = -1 Then
                Return
            End If

            If String.IsNullOrEmpty(cmbAlmacen.Text) Then
                XtraMessageBox.Show("Seleccionar un almacén", "AXC", MessageBoxButtons.OK)
                cmbAlmacen.Select()
                Return
            End If
            CargaComboIds(nuevo.ListaIdsInventarios(cbTipoInventario.Text, CType(IIf(String.IsNullOrEmpty(cmbAlmacen.Text), "@", cmbAlmacen.Text), String), My.Settings("Estacion"), DatosTemporales.Usuario))
        Catch ex As Exception
            XtraMessageBox.Show("Error: " + ex.Message, "AXC")
        End Try
    End Sub

    Private Sub btnCierra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCierra.Click
        Dim resp$ = ""
        Dim IdInventario%
        Try
            If XtraMessageBox.Show("¿Cerrar el inventario?", "AXC", MessageBoxButtons.YesNo) <> DialogResult.Yes Then
                Return
            End If

            If cbTipoInventario.Text = "" Then
                XtraMessageBox.Show("Seleccionar un tipo de inventario", "AXC")
                Return
            End If

            Try
                IdInventario = Convert.ToInt16(nuevo.ObtieneUltimoIdInventarios(cbTipoInventario.Text, cmbAlmacen.Text, My.Settings("Estacion"), DatosTemporales.Usuario))

                resp = nuevo.CierraInventario(IdInventario, My.Settings("Estacion"), DatosTemporales.Usuario)

                If resp = "OK" Then
                    XtraMessageBox.Show("Ejercicio de inventario cerrado con éxito", "AXC")
                Else
                    XtraMessageBox.Show(resp, "AXC")
                End If

            Catch ex As Exception
                XtraMessageBox.Show("No existe algún ejercicio actual de ese tipo", "AXC")
            End Try

        Catch ex As Exception
            XtraMessageBox.Show("Error: " + ex.Message, "AXC")
        End Try
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Dim resp$ = ""
        Dim IdInventario%
        Try
            If XtraMessageBox.Show("¿Cancelar el inventario?", "AXC", MessageBoxButtons.YesNo) <> DialogResult.Yes Then
                Return
            End If

            If cbTipoInventario.Text = "" Then
                XtraMessageBox.Show("Seleccionar un tipo de inventario", "AXC")
                Return
            End If

            Try
                IdInventario = Convert.ToInt16(nuevo.ObtieneUltimoIdInventarios(cbTipoInventario.Text, cmbAlmacen.Text, My.Settings("Estacion"), DatosTemporales.Usuario))

                resp = nuevo.CancelaInventario(IdInventario, My.Settings("Estacion"), DatosTemporales.Usuario)

                If resp = "OK" Then
                    XtraMessageBox.Show("Ejercicio de inventario cancelado con éxito", "AXC")
                Else
                    XtraMessageBox.Show(resp, "AXC")
                End If

            Catch ex As Exception
                XtraMessageBox.Show("No existe algún ejercicio actual de ese tipo", "AXC")
            End Try

        Catch ex As Exception
            XtraMessageBox.Show("Error: " + ex.Message, "AXC")
        End Try
    End Sub

    Private Sub cbIds_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbIds.EditValueChanged
        Try
            LimpiaTodo()
            CargaGridPallets(nuevo.ListaPalletsInventario(cbIds.EditValue, "", "", My.Settings("Estacion"), DatosTemporales.Usuario))
            CargaGridPalletsNoLeidos(nuevo.ListaPalletsInventarioNoLeidos(cbIds.EditValue, "", "", My.Settings("Estacion"), DatosTemporales.Usuario))
            CargaGridPalletsEnRegistro(nuevo.ListaPalletsInventarioEnRegistro(cbIds.EditValue, "", "", My.Settings("Estacion"), DatosTemporales.Usuario))
            CargaEstatusInventario(nuevo.EstatusInventario(cbIds.EditValue, My.Settings("Estacion"), DatosTemporales.Usuario))
        Catch ex As Exception

        End Try
    End Sub
#End Region

#Region "METODOS"


    Sub CargaComboInventarios(ByVal ds As DataSet)
        Try
            cbTipoInventario.Properties.DisplayMember = "Tipo"
            cbTipoInventario.Properties.ValueMember = "Tipo"
            cbTipoInventario.Properties.DataSource = ds.Tables(1)

        Catch ex As Exception
            XtraMessageBox.Show("Error: " + ex.Message, "AXC")
        End Try
    End Sub

    Sub CargaComboIds(ByVal ds As DataSet)
        Try
            If ds.Tables.Count <= 1 Then
                XtraMessageBox.Show("No se encuentra ningún tipo ejercicio de inventario de ese tipo", "AXC")
                cbIds.Properties.DataSource = Nothing
                Exit Sub
            End If

            cbIds.Properties.DisplayMember = "FechaHora"
            cbIds.Properties.ValueMember = "IdEjercicio"
            cbIds.Properties.DataSource = ds.Tables(1)
            cbIds.EditValue = Nothing
        Catch ex As Exception
            XtraMessageBox.Show("Error: " + ex.Message, "AXC")
        End Try
    End Sub

    Sub CargaGridPallets(ByVal ds As DataSet)
        Try
            If ds.Tables.Count = 1 Then
                dgvPallets.DataSource = Nothing
                XtraMessageBox.Show(ds.Tables(0).Rows(0)(1).ToString(), "AXC")
                Return
            End If
            dgvPallets.DataSource = ds.Tables(1)
            GridViewTotal.BestFitColumns()
        Catch ex As Exception
            XtraMessageBox.Show("Error: " + ex.Message, "AXC")
        End Try
    End Sub

    Sub CargaGridPalletsNoLeidos(ByVal ds As DataSet)
        Try

            If ds.Tables.Count = 1 Then
                dgvPalletsNoLeidos.DataSource = Nothing
                Return
            End If
            dgvPalletsNoLeidos.DataSource = ds.Tables(1)
            GridViewSinLec.BestFitColumns()
        Catch ex As Exception
            XtraMessageBox.Show("Error: " + ex.Message, "AXC")
        End Try
    End Sub

    Sub CargaGridPalletsEnRegistro(ByVal ds As DataSet)
        Try

            If ds.Tables.Count = 1 Then
                dgvPalletsEnRegistro.DataSource = Nothing
                Return
            End If

            dgvPalletsEnRegistro.DataSource = ds.Tables(1)
            GridViewLeido.BestFitColumns()
        Catch ex As Exception
            XtraMessageBox.Show("Error: " + ex.Message, "AXC")
        End Try
    End Sub

    Sub CargaEstatusInventario(ByVal ds As DataSet)
        Try

            If ds.Tables.Count = 1 Then
                LabelControl4.Text = ""
                Return
            End If

            LabelControl4.Text = ds.Tables(1).Rows(0)(0).ToString()

        Catch ex As Exception
            XtraMessageBox.Show("Error: " + ex.Message, "AXC")
        End Try
    End Sub

    Sub LimpiaTodo()
        Try
            dgvPallets.DataSource = Nothing
            dgvPallets.Refresh()
            dgvPalletsEnRegistro.DataSource = Nothing
            dgvPalletsEnRegistro.Refresh()
            dgvPalletsNoLeidos.DataSource = Nothing
            dgvPalletsNoLeidos.Refresh()
            'cbIds.DataSource = Nothing
        Catch ex As Exception
            XtraMessageBox.Show("Error: " + ex.Message, "AXC")
        End Try
    End Sub

    Private Sub FrmMonitorInventarios_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose(True)
    End Sub

    Private Sub GroupControl2_CustomButtonClick(sender As Object, e As DevExpress.XtraBars.Docking2010.BaseButtonEventArgs) Handles GroupControl2.CustomButtonClick
        Try

            If dgvPallets.DataSource Is Nothing Then
                XtraMessageBox.Show("No hay información para exportar", "Información", MessageBoxButtons.OK)
                Return
            End If
            Dim path As String = ""

            Dim sv As New SaveFileDialog
            sv.Filter = "Excel Workbook|*.xlsx"
            If sv.ShowDialog() = DialogResult.OK And sv.FileName <> Nothing Then
                If sv.FileName.EndsWith(".xlsx") Then
                    path = sv.FileName.ToString()
                    ' Customize export options
                    CType(dgvPallets.MainView, GridView).OptionsPrint.PrintHorzLines = False
                    CType(dgvPallets.MainView, GridView).OptionsPrint.PrintVertLines = False
                    CType(dgvPallets.MainView, GridView).OptionsPrint.PrintHeader = True
                    Dim advOptions As XlsxExportOptionsEx = New XlsxExportOptionsEx()
                    'advOptions.AllowGrouping = DevExpress.Utils.DefaultBoolean.False
                    'advOptions.ShowTotalSummaries = DevExpress.Utils.DefaultBoolean.False
                    advOptions.SheetName = "Pallets a inventariar"
                    advOptions.ShowColumnHeaders = DevExpress.Utils.DefaultBoolean.True

                    dgvPallets.ExportToXlsx(path, advOptions)
                    ' Open the created XLSX file with the default application.
                    Process.Start(path)

                End If
            End If

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub GroupControl4_CustomButtonClick(sender As Object, e As DevExpress.XtraBars.Docking2010.BaseButtonEventArgs) Handles GroupControl4.CustomButtonClick
        Try

            If dgvPalletsNoLeidos.DataSource Is Nothing Then
                XtraMessageBox.Show("No hay información para exportar", "Información", MessageBoxButtons.OK)
                Return
            End If
            Dim path As String = ""

            Dim sv As New SaveFileDialog
            sv.Filter = "Excel Workbook|*.xlsx"
            If sv.ShowDialog() = DialogResult.OK And sv.FileName <> Nothing Then
                If sv.FileName.EndsWith(".xlsx") Then
                    path = sv.FileName.ToString()
                    ' Customize export options
                    CType(dgvPalletsNoLeidos.MainView, GridView).OptionsPrint.PrintHorzLines = False
                    CType(dgvPalletsNoLeidos.MainView, GridView).OptionsPrint.PrintVertLines = False
                    CType(dgvPalletsNoLeidos.MainView, GridView).OptionsPrint.PrintHeader = True
                    Dim advOptions As XlsxExportOptionsEx = New XlsxExportOptionsEx()
                    'advOptions.AllowGrouping = DevExpress.Utils.DefaultBoolean.False
                    'advOptions.ShowTotalSummaries = DevExpress.Utils.DefaultBoolean.False
                    advOptions.SheetName = "Pallets sin lectura"
                    advOptions.ShowColumnHeaders = DevExpress.Utils.DefaultBoolean.True

                    dgvPalletsNoLeidos.ExportToXlsx(path, advOptions)
                    ' Open the created XLSX file with the default application.
                    Process.Start(path)

                End If
            End If

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub GroupControl5_CustomButtonClick(sender As Object, e As DevExpress.XtraBars.Docking2010.BaseButtonEventArgs) Handles GroupControl5.CustomButtonClick
        Try

            If dgvPalletsEnRegistro.DataSource Is Nothing Then
                XtraMessageBox.Show("No hay información para exportar", "Información", MessageBoxButtons.OK)
                Return
            End If
            Dim path As String = ""

            Dim sv As New SaveFileDialog
            sv.Filter = "Excel Workbook|*.xlsx"
            If sv.ShowDialog() = DialogResult.OK And sv.FileName <> Nothing Then
                If sv.FileName.EndsWith(".xlsx") Then
                    path = sv.FileName.ToString()
                    ' Customize export options
                    CType(dgvPalletsEnRegistro.MainView, GridView).OptionsPrint.PrintHorzLines = False
                    CType(dgvPalletsEnRegistro.MainView, GridView).OptionsPrint.PrintVertLines = False
                    CType(dgvPalletsEnRegistro.MainView, GridView).OptionsPrint.PrintHeader = True
                    Dim advOptions As XlsxExportOptionsEx = New XlsxExportOptionsEx()
                    'advOptions.AllowGrouping = DevExpress.Utils.DefaultBoolean.False
                    'advOptions.ShowTotalSummaries = DevExpress.Utils.DefaultBoolean.False
                    advOptions.SheetName = "Pallets en registro(Registrados)"
                    advOptions.ShowColumnHeaders = DevExpress.Utils.DefaultBoolean.True

                    dgvPalletsEnRegistro.ExportToXlsx(path, advOptions)
                    ' Open the created XLSX file with the default application.
                    Process.Start(path)

                End If
            End If

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
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

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        Try
            LimpiaTodo()
            CargaGridPallets(nuevo.ListaPalletsInventario(cbIds.EditValue, "", "", My.Settings("Estacion"), DatosTemporales.Usuario))
            CargaGridPalletsNoLeidos(nuevo.ListaPalletsInventarioNoLeidos(cbIds.EditValue, "", "", My.Settings("Estacion"), DatosTemporales.Usuario))
            CargaGridPalletsEnRegistro(nuevo.ListaPalletsInventarioEnRegistro(cbIds.EditValue, "", "", My.Settings("Estacion"), DatosTemporales.Usuario))
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmbAlmacen_EditValueChanged(sender As Object, e As EventArgs) Handles cmbAlmacen.EditValueChanged
        Try
            LimpiaTodo()
            cbTipoInventario.Properties.DataSource = Nothing
            cbIds.Properties.DataSource = Nothing
            CargaComboInventarios(nuevo.ListaTiposInventarios(My.Settings("Estacion"), DatosTemporales.Usuario))


        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LabelControl5_Click(sender As Object, e As EventArgs) Handles LabelControl5.Click

    End Sub

#End Region

End Class