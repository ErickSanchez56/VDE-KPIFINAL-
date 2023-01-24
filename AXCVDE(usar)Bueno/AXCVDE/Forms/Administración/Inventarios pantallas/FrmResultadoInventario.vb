Imports DevExpress.XtraEditors
Imports DevExpress.XtraReports.UI

Public Class FrmResultadoInventario

#Region "VARIABLES"
    Dim nuevo As New ClsAlmacen
    Dim IdInventario As Integer
    Dim prmAgrupa As Integer
#End Region

#Region "EVENTOS"
    Private Sub FrmResultadoInventario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            ListaAlmacenes()
            CargaComboInventarios(nuevo.ListaTiposInventarios(My.Settings("Estacion"), DatosTemporales.Usuario))
        Catch ex As Exception
            XtraMessageBox.Show("Error: " + ex.Message, "AXC")
        End Try
    End Sub

    Private Sub btnReporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReporte.Click
        Dim dsG As New DataSet
        Try
            If XtraMessageBox.Show("¿Generar reporte?", "AXC", MessageBoxButtons.YesNo) <> DialogResult.Yes Then
                Return
            End If
            If cbTipoInventario.ItemIndex <= -1 Then
                XtraMessageBox.Show("Seleccionar el tipo de inventario", "AXC")
                Return
            End If

            If ChkPos.Checked Then
                prmAgrupa = 1
            Else
                prmAgrupa = 2
            End If

            Dim ds As DataSet = nuevo.ListaResultadosInventario(cbIds.EditValue, "", "", My.Settings("Estacion"), DatosTemporales.Usuario, prmAgrupa)

            If ds.Tables(1).Rows.Count <= 0 Then
                XtraMessageBox.Show("No se registraron cambios", "AXC")
                Exit Sub
            End If

            If prmAgrupa = 1 Then
                dsG.Tables.Add(ds.Tables(1).Copy)
                Dim RepExistencias As New DevRepResultadoInventario
                RepExistencias.CargaReporte(dsG, 1)
                Dim designTool As New ReportPrintTool(RepExistencias)
                designTool.ShowPreviewDialog()
                dsG = New DataSet
            Else
                dsG.Tables.Add(ds.Tables(1).Copy)
                Dim RepExistencias As New DevRepResultadoInventario2
                RepExistencias.CargaReporte(dsG, 1)
                Dim designTool As New ReportPrintTool(RepExistencias)
                designTool.ShowPreviewDialog()
                dsG = New DataSet
            End If

        Catch ex As Exception
            XtraMessageBox.Show("Error: " + ex.Message, "AXC")
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

    Sub CargaGrid(ByVal ds As DataSet)
        Try
            If ds.Tables.Count = 1 Then
                XtraMessageBox.Show(ds.Tables(0).Rows(0)(1).ToString(), "AXC")
                Return
            End If

            If ds.Tables(1).Rows.Count <= 0 Then
                XtraMessageBox.Show("No se registraron cambios", "AXC")
                Exit Sub
            End If

            dgvResultados.DataSource = ds.Tables(1)


            GridViewTotal.Columns("NumParte").Caption = "Número de Parte "
            GridViewTotal.Columns("CantidadAnterior").Caption = "Cantidad Anterior"
            GridViewTotal.Columns("CantidadActual").Caption = "Cantidad Actual"


            GridViewTotal.Columns("DNumParte1").Caption = "Descripción"
            GridViewTotal.Columns("FechaCrea").Caption = "Fecha de creación "
            GridViewTotal.Columns("FechaCrea").DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
            GridViewTotal.Columns("FechaCrea").DisplayFormat.FormatString = "g"
            GridViewTotal.Columns("FechaCierre").Caption = "Fecha de cierre"
            GridViewTotal.Columns("FechaCierre").DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
            GridViewTotal.Columns("FechaCierre").DisplayFormat.FormatString = "g"
            GridViewTotal.BestFitColumns()


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
            cbIds.Properties.DataSource = Nothing
            cbIds.RefreshEditValue()
            cbIds.Properties.DisplayMember = "FechaHora"
            cbIds.Properties.ValueMember = "IdEjercicio"
            cbIds.Properties.DataSource = ds.Tables(1)
            cbIds.EditValue = Nothing
        Catch ex As Exception
            XtraMessageBox.Show("Error: " + ex.Message, "AXC")
        End Try
    End Sub

#End Region

    Private Sub LimpiaTodo()
        GridViewTotal.Columns.Clear()
        dgvResultados.DataSource = Nothing
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Try
            Dim frmRepFech As New FrmReportePorFechasInv

            If ChkPos.Checked Then
                prmAgrupa = 1
            Else
                prmAgrupa = 2
            End If

            frmRepFech.prmAgrupa = prmAgrupa
            frmRepFech.ShowDialog()
        Catch ex As Exception
            XtraMessageBox.Show("Error: " + ex.Message, "AXC")
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

    Private Sub BtnActualizarPrevio_Click(sender As Object, e As EventArgs) Handles BtnActualizarPrevio.Click
        Try
            Actualizar()
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Actualizar()
        Try
            Dim pResultado As New CResultado
            Dim Cls As New ClsAlmacen

            If cbIds.EditValue Is Nothing Then
                XtraMessageBox.Show("Seleccionar inventario", "Información", MessageBoxButtons.OK)
                Return
            End If

            Cursor.Current = Cursors.WaitCursor
            pResultado = Cls.ActualizarInformacionInventario(cbIds.EditValue, My.Settings.Estacion, DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto, "AXC")
                Return
            End If

            XtraMessageBox.Show("Actualizado exitosamente", "AXC")
            LimpiaTodo()
            If ChkPos.Checked Then
                prmAgrupa = 1
            Else
                prmAgrupa = 2
            End If

            CargaGrid(nuevo.ListaResultadosInventario(cbIds.EditValue, "", "", My.Settings("Estacion"), DatosTemporales.Usuario, prmAgrupa))

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cbIds_EditValueChanged(sender As Object, e As EventArgs) Handles cbIds.EditValueChanged
        Try
            LimpiaTodo()

            If ChkPos.Checked Then
                prmAgrupa = 1
            Else
                prmAgrupa = 2
            End If
            CargaGrid(nuevo.ListaResultadosInventario(cbIds.EditValue, "", "", My.Settings("Estacion"), DatosTemporales.Usuario, prmAgrupa))
        Catch ex As Exception
            XtraMessageBox.Show("Error: " + ex.Message, "AXC")
        End Try
    End Sub

    Private Sub cbTipoInventario_EditValueChanged(sender As Object, e As EventArgs) Handles cbTipoInventario.EditValueChanged
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
            CargaComboIds(nuevo.ListaIdsInventarios(cbTipoInventario.Text, cmbAlmacen.Text, My.Settings("Estacion"), DatosTemporales.Usuario))
        Catch ex As Exception
            MsgBox("Error: " + ex.Message, MsgBoxStyle.Critical, "AXC")
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

    Private Sub FrmResultadoInventario_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose(True)
    End Sub

    Private Sub ChkPos_CheckedChanged(sender As Object, e As EventArgs) Handles ChkPos.CheckedChanged
        If ChkPos.Checked Then
            Chkpro.Checked = False
        End If
    End Sub

    Private Sub Chkpro_CheckedChanged(sender As Object, e As EventArgs) Handles Chkpro.CheckedChanged
        If Chkpro.Checked Then
            ChkPos.Checked = False
        End If
    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs)
        LimpiaTodo()

        If ChkPos.Checked Then
            prmAgrupa = 1
        Else
            prmAgrupa = 2
        End If
        CargaGrid(nuevo.ListaResultadosInventario(cbIds.EditValue, "", "", My.Settings("Estacion"), DatosTemporales.Usuario, prmAgrupa))
    End Sub
End Class