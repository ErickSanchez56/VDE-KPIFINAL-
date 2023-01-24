Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraReports.UI

Public Class FrmConsultaPallet

#Region "VARIABLES"
    Public dsReporte As New DataSet
#End Region
    Private Sub ChkLote_CheckedChanged(sender As Object, e As EventArgs) Handles ChkFechas.CheckedChanged
        Try
            If ChkFechas.Checked Then
                dtpFechaInicio.Enabled = True
                dtpFechaFin.Enabled = True
            Else
                dtpFechaInicio.Enabled = False
                dtpFechaFin.Enabled = False

            End If

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Try
            Dim pBusqueda As String = "@"


            If String.IsNullOrEmpty(TxtBusqueda.Text.Trim()) Then
                pBusqueda = "@"
            Else
                pBusqueda = TxtBusqueda.Text
            End If

            cargarResultados(pBusqueda)

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try

    End Sub

#Region "METODOS"
    Private Sub cargarResultados(prmBusqueda As String)
        Try
            dsReporte = New DataSet
            DgvResultado.DataSource = Nothing

            Dim pResultado As New CResultado
            Dim Cls As New clsExistencias

            Dim dInicio As New Date
            Dim dFin As New Date
            If ChkFechas.Checked Then
                dInicio = Date.Parse(dtpFechaInicio.EditValue.ToString)
                dFin = Date.Parse(dtpFechaFin.EditValue.ToString)
            End If


            Cursor.Current = Cursors.WaitCursor
            pResultado = Cls.ResultadoConsultaPallet(cmbTipo.ItemIndex, prmBusqueda, IIf(CmbEstatus.Text = "TODOS", "@", CmbEstatus.Text),
                                                     IIf(ChkFechas.Checked = True, dInicio.ToString("yyyyMMdd"), ""), IIf(ChkFechas.Checked = True, dFin.ToString("yyyyMMdd"), ""), ChkFechas.CheckState, My.Settings.Estacion, DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                DgvResultado.DataSource = Nothing
                Return
            End If
            Dim dt As New DataTable
            Dim ds As New DataSet

            dt = pResultado.Tabla
            ds.Tables.Add(dt)
            dsReporte.Tables.Add(ds.Tables(0).Copy())

            If dt.Rows.Count < 1 Then
                XtraMessageBox.Show("No hay información con los filtros")
                DgvResultado.DataSource = Nothing
                Return
            End If

            DgvResultado.DataSource = dt

            DgvViewResultado.Columns("FechaCrea").DisplayFormat.FormatString = "g"
            DgvViewResultado.BestFitColumns()


        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ListaEstatus()
        Try


            Dim pResultado As New CResultado
            Dim pCons As New clsExistencias

            Cursor.Current = Cursors.WaitCursor
            pResultado = pCons.ListaEstatusPallet(My.Settings.Estacion, DatosTemporales.Usuario)
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
            row.Item(0) = -1
            row.Item(1) = "TODOS"
            ds.Tables(0).Rows.InsertAt(row, 0)

            CmbEstatus.Properties.ValueMember = "IdStatus"
            CmbEstatus.Properties.DisplayMember = "DStatus"
            CmbEstatus.Properties.DataSource = dt

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub

    Private Sub FrmConsultaPallet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            LlenarTipoBusqueda()
            cmbTipo.ItemIndex = 0
            TxtBusqueda.Select()
            ListaEstatus()
            CmbEstatus.ItemIndex = 0
            dtpFechaFin.EditValue = Date.Now
            dtpFechaInicio.EditValue = Date.Now
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub LlenarTipoBusqueda()
        Try
            Dim TipoBus = New List(Of String)()
            TipoBus.Add("CÓDIGO DE PALLET")
            TipoBus.Add("ARTÍCULO")
            TipoBus.Add("LOTE")
            TipoBus.Add("ALMACÉN")

            cmbTipo.Properties.DataSource = TipoBus

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub

    Private Sub BtnReporte_Click(sender As Object, e As EventArgs) Handles BtnReporte.Click
        Try
            If XtraMessageBox.Show("Generar reporte?", "Confirmación", MessageBoxButtons.YesNo) <> DialogResult.Yes Then
                Return
            End If

            If DgvResultado.DataSource Is Nothing Then
                XtraMessageBox.Show("No hay información para generar el reporte", "AXC")
                Return
            End If


            If dsReporte.Tables Is Nothing Then

            End If


            'Dim RepExistencias As New DevRepPallets
            'RepExistencias.CargaReporte(dsReporte, 1)
            'Dim designTool As New ReportPrintTool(RepExistencias)
            'designTool.ShowPreview()
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try

    End Sub

    Private Sub GroupControl2_CustomButtonClick(sender As Object, e As DevExpress.XtraBars.Docking2010.BaseButtonEventArgs) Handles GroupControl2.CustomButtonClick
        Try
            If DgvResultado.DataSource Is Nothing Then
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
                    CType(DgvResultado.MainView, GridView).OptionsPrint.PrintHorzLines = False
                    CType(DgvResultado.MainView, GridView).OptionsPrint.PrintVertLines = False
                    CType(DgvResultado.MainView, GridView).OptionsPrint.PrintHeader = True
                    Dim advOptions As XlsxExportOptionsEx = New XlsxExportOptionsEx()
                    advOptions.SheetName = "Consulta de pallets"
                    advOptions.ShowColumnHeaders = DevExpress.Utils.DefaultBoolean.True

                    DgvResultado.ExportToXlsx(path, advOptions)
                    Process.Start(path)

                End If
            End If
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region
End Class