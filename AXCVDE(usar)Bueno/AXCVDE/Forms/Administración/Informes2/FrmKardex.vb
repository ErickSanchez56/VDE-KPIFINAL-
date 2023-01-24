Imports DevExpress.XtraEditors





Public Class FrmKardex

#Region "VARIABLES"
    Dim dsReporte As New DataSet
#End Region
    Private Sub FrmKardex_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ListaNumParte()
            LlenarTipoBusqueda()
            ListaTipoAjuste("@")
            dtpFechaFin.EditValue = Date.Now.ToShortDateString
            dtpFechaInicio.EditValue = Date.Now.ToShortDateString
            cmbNumParte.EditValue = 0
            CmbMovimiento.ItemIndex = 0
            CmbTipoAjuste.EditValue = 0

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

#Region "EVENTOS"
    Private Sub cmbNumParte_EditValueChanged(sender As Object, e As EventArgs) Handles cmbNumParte.EditValueChanged
        Try
            Dim text As String = cmbNumParte.Text
            If text.Equals("System.Data.DataRowView") Then
                Return
            End If

            If cmbNumParte.Text = "TODOS" Then
                Return
            End If
            ConsultaNumParte()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            ListaResultado()
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region

#Region "METODOS"
    Private Sub ListaNumParte()
        Try
            Dim pResultado As New CResultado
            Dim pOC As New COrdenCompraR

            Cursor.Current = Cursors.WaitCursor
            pResultado = pOC.ListaNumParte()
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                Return
            End If

            Dim dt As DataTable = New DataTable
            Dim ds As New DataSet

            dt = pResultado.Tabla.Copy
            ds.Tables.Add(dt)

            Dim row As DataRow = ds.Tables(0).NewRow
            row.Item(0) = 0
            row.Item(1) = "TODOS"
            ds.Tables(0).Rows.InsertAt(row, 0)
            cmbNumParte.Properties.ValueMember = "IdNumParte"
            cmbNumParte.Properties.DisplayMember = "NumParte"
            cmbNumParte.Properties.DataSource = ds.Tables(0)
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ConsultaNumParte()
        Try
            Dim pResultado As New CResultado
            Dim pOP As New COrdenProd

            Cursor.Current = Cursors.WaitCursor
            pResultado = pOP.ConsultaNumParte(cmbNumParte.Text)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)

                Return
            End If

            Dim dt As DataTable = New DataTable
            dt = pResultado.Tabla

            txtDescripcion.Text = dt.Rows(0).Item("DNumParte1")

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub LlenarTipoBusqueda()
        Try
            Dim TipoBus = New List(Of String)()
            TipoBus.Add("TODOS")
            TipoBus.Add("ENTRADA")
            TipoBus.Add("SALIDA")
            CmbMovimiento.Properties.DataSource = TipoBus

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub

    Private Sub ListaTipoAjuste(prmBusqueda As String)
        Try


            Dim pResultado As New CResultado
            Dim Cls As New ClsHerramientas

            Dim Movimiento As String = "@"
            Dim TipoAjuste As String = "@"

            If CmbMovimiento.Text <> "TODOS" Then
                Movimiento = CmbMovimiento.Text
            End If

            If Movimiento = "ENTRADA" Then
                Movimiento = "E"
            End If

            If Movimiento = "SALIDA" Then
                Movimiento = "S"
            End If


            Cursor.Current = Cursors.WaitCursor
            pResultado = Cls.ListaTipoAjuste("@", Movimiento, My.Settings.Estacion, DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                Return
            End If
            Dim dt As New DataTable
            Dim ds As New DataSet

            dt = pResultado.Tabla
            ds.Tables.Add(dt)
            Dim row As DataRow = ds.Tables(0).NewRow
            row.Item(0) = 0
            row.Item(1) = "TODOS"
            ds.Tables(0).Rows.InsertAt(row, 0)

            CmbTipoAjuste.Properties.ValueMember = "IdTipo"
            CmbTipoAjuste.Properties.DisplayMember = "Tipo"
            CmbTipoAjuste.Properties.DataSource = dt



        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ListaResultado()
        Try
            grdDetalle.DataSource = Nothing

            Dim pResultado As New CResultado
            Dim Cls As New ClsHerramientas
            dsReporte = New DataSet
            Dim dInicio As New Date
            Dim dFin As New Date
            Dim Movimiento As String = "@"

            dInicio = Date.Parse(dtpFechaInicio.EditValue.ToString)
            dFin = Date.Parse(dtpFechaFin.EditValue.ToString)

            If CmbMovimiento.Text <> "TODOS" Then
                Movimiento = CmbMovimiento.Text
            End If

            If Movimiento = "ENTRADA" Then
                Movimiento = "E"
            End If

            If Movimiento = "SALIDA" Then
                Movimiento = "S"
            End If



            Cursor.Current = Cursors.WaitCursor
            pResultado = Cls.ListaMovimientos(
                                    IIf(cmbNumParte.Text = "TODOS", "@", cmbNumParte.Text),
                                  Movimiento,
                                    IIf(CmbTipoAjuste.Text = "TODOS", "@", CmbTipoAjuste.Text),
                                    dInicio.ToString("yyyyMMdd"),
                                    dFin.ToString("yyyyMMdd"),
                                       IIf(String.IsNullOrEmpty(TxtLote.Text), "@", TxtLote.Text),
                                    My.Settings.Estacion, DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                grdDetalle.DataSource = Nothing
                Return
            End If
            Dim dt As New DataTable
            Dim ds As New DataSet

            dt = pResultado.Tabla
            ds = pResultado.Tablas.Copy


            If ds.Tables(1).Rows.Count < 1 Then
                XtraMessageBox.Show("No hay información con los filtros seleccionados")
                grdDetalle.DataSource = Nothing
                Return
            End If

            grdDetalle.DataSource = ds.Tables(1)
            dsReporte.Tables.Add(ds.Tables(1).Copy)
            GridView1.BestFitColumns()


            LblInicial.Text = ds.Tables(2).Rows(0).Item(0).ToString()
            LblEntradas.Text = ds.Tables(2).Rows(0).Item(1).ToString()
            LblSalidas.Text = ds.Tables(2).Rows(0).Item(2).ToString()
            LblExistencia.Text = ds.Tables(2).Rows(0).Item(3).ToString()


        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub PanelControl4_Paint(sender As Object, e As PaintEventArgs) Handles PanelControl4.Paint

    End Sub

    Private Sub FrmKardex_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose(True)
    End Sub

    Private Sub CmbMovimiento_EditValueChanged(sender As Object, e As EventArgs) Handles CmbMovimiento.EditValueChanged
        ListaTipoAjuste("@")
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Try
            If vbNo = MsgBox("¿Generar reporte?", MsgBoxStyle.YesNo, "AXC") Then
                Return
            End If

            If grdDetalle.DataSource Is Nothing Then
                XtraMessageBox.Show("No hay información para generar el reporte", "AXC")
                Return
            End If

            If dsReporte.Tables Is Nothing Then

            End If

            'FrmVisorReportes.CargaReporte(dsReporte, 9)
            'FrmVisorReportes.Show()

        Catch ex As Exception
            XtraMessageBox.Show("Error: " + ex.Message, "AXC")
        End Try
    End Sub

#End Region
End Class