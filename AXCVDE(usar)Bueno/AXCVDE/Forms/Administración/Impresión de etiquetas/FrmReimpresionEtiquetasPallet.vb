Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Base

Public Class FrmReimpresionEtiquetasPallet
    Private Sub FrmReimpresionEtiquetasPallet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim TipoBus = New List(Of String)()
            TipoBus.Add("CÓDIGO DE PALLET")
            TipoBus.Add("PRODUCTO")
            TipoBus.Add("ORDEN DE PRODUCCIÓN")
            TipoBus.Add("LOTE")

            cmbTipo.Properties.DataSource = TipoBus
            cmbTipo.ItemIndex = 0
            ListarImpresora()
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            Dim pBusqueda As String = "@"


            If String.IsNullOrEmpty(txtBusqueda.Text.Trim()) Then
                pBusqueda = "@"
            Else
                pBusqueda = txtBusqueda.Text
            End If

            cargarResultados(pBusqueda)

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub


    Private Sub cargarResultados(prmBusqueda As String)
        Try
            dgvResultado.DataSource = Nothing

            Dim pResultado As New CResultado

            Dim Cls As New clsImpresiones

            Cursor.Current = Cursors.WaitCursor
            pResultado = Cls.ListaPalletReimpresion(cmbTipo.ItemIndex, prmBusqueda, My.Settings.Estacion, DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto, "AXC")
                dgvResultado.DataSource = Nothing
                Return
            End If
            Dim dt As New DataTable
            Dim ds As New DataSet

            dt = pResultado.Tabla
            ds.Tables.Add(dt)

            If dt.Rows.Count < 1 Then
                XtraMessageBox.Show("No hay información con los filtros selccionados", "AXC")
                dgvResultado.DataSource = Nothing
                Return
            End If

            dgvResultado.DataSource = dt
            GridView1.BestFitColumns()

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnReporte_Click(sender As Object, e As EventArgs) Handles BtnReporte.Click
        Try

            If XtraMessageBox.Show("¿Desea reimprimir la etiqueta seleccionada?", "AXC", MessageBoxButtons.YesNo) <> DialogResult.Yes Then
                Return
            End If

            Dim view As ColumnView = CType(dgvResultado.MainView, ColumnView)
            Dim selectedRowHandles As Integer() = view.GetSelectedRows()

            If Not selectedRowHandles.Count > 0 Then
                XtraMessageBox.Show("Seleccionar el Pallet a imprimir", "AXC")
                Return
            End If

            If String.IsNullOrEmpty(CmbImpresora.Text) Then
                XtraMessageBox.Show("Seleccionar impresora.", "AXC")
                Return
            End If

            Dim OrdenProduccion As String
            Dim Lote As String
            Dim Estacion As String
            Dim CodigoPallet As String
            Dim NumParte As String
            Dim Descripcion As String
            Dim Cajas As String
            Dim Cantidad As String
            Dim FechaCaducidad As String
            'Dim Mercado As String
            Dim Linea As String
            Dim TipoEtiquetado As String


            CodigoPallet = view.GetRowCellDisplayText(selectedRowHandles(0), view.Columns("Código Pallet"))
            NumParte = view.GetRowCellDisplayText(selectedRowHandles(0), view.Columns("Producto"))
            OrdenProduccion = view.GetRowCellDisplayText(selectedRowHandles(0), view.Columns("Documento"))
            Lote = view.GetRowCellDisplayText(selectedRowHandles(0), view.Columns("Lote AXC"))
            Descripcion = view.GetRowCellDisplayText(selectedRowHandles(0), view.Columns("Descripción"))
            Estacion = view.GetRowCellDisplayText(selectedRowHandles(0), view.Columns("Estación"))
            Cajas = view.GetRowCellDisplayText(selectedRowHandles(0), view.Columns("Paquetes"))
            Cantidad = view.GetRowCellDisplayText(selectedRowHandles(0), view.Columns("Cantidad Actual"))
            FechaCaducidad = view.GetRowCellDisplayText(selectedRowHandles(0), view.Columns("FechaCaducidad"))
            Linea = view.GetRowCellDisplayText(selectedRowHandles(0), view.Columns("Linea"))
            TipoEtiquetado = "" 'view.GetRowCellDisplayText(selectedRowHandles(0), view.Columns("TipoEtiquetado"))
            ImprimeEtiquetas(OrdenProduccion, Lote, Estacion, CodigoPallet, NumParte, Descripcion, Cajas, Cantidad, FechaCaducidad, "", Linea, TipoEtiquetado)

        Catch ex As Exception
            XtraMessageBox.Show("Error: " & ex.Message, " AXC")
        End Try
    End Sub

    Private Sub ImprimeEtiquetas(ByVal prmOrdenProd As String,
                              ByVal prmLote As String,
                              ByVal prmEstacion As String,
                              ByVal prmCodigoPallet As String,
                              ByVal prmNumParte As String,
                              ByVal prmDescripcion As String,
                              ByVal prmCajas As String,
                              ByVal prmCantidad As String,
                                 ByVal prmFechaCaducidad As String, ByVal prmMercado As String, ByVal prmLinea As String, prmTipoEtiquetado As String)
        Try
            Dim CRespuesta As New CResultado

            Dim pResultado As New wsAXC.CResultado
            Dim ws As New wsAXC.wsAXCMP

            Dim pUrl As String = My.Settings("AXCVDE_wsAXC_wsAXCMP")

            If pUrl = "" Then
                pUrl = "http://192.168.1.181:1000/wsAXCVDE/wsAXCMP.asmx"
            End If

            ws.Url = pUrl
            'Cursor.Current = Cursors.WaitCursor'

            If Strings.Left(prmCodigoPallet, 2) = "97" Then
                pResultado = ws.WM_ReimprimeRempaque(prmCodigoPallet, prmEstacion, DatosTemporales.Usuario, CmbImpresora.Text)
                'pResultado = ws.WM_ReimprimePalletMP(prmOrdenProd, "", prmLote, prmLote, prmEstacion, prmCodigoPallet, prmNumParte, prmDescripcion, prmCajas, prmCantidad, prmTipoEtiquetado, "", prmFechaCaducidad, CmbImpresora.Text, IIf(CmbImpresora.Text = "ZEBRAPICKING", "203", "300"), DatosTemporales.Usuario, prmMercado, prmLinea)
            Else
                pResultado = ws.WM_ReimprimePalletMP(prmOrdenProd, "", prmLote, prmLote, prmEstacion, prmCodigoPallet, prmNumParte, prmDescripcion, prmCajas, prmCantidad, prmTipoEtiquetado, "", prmFechaCaducidad, CmbImpresora.Text, IIf(CmbImpresora.Text = "ZEBRAPICKING", "203", "203"), DatosTemporales.Usuario, prmLinea)
            End If


            '    pResultado = ws.WM_ReimprimeRempaque(prmCodigoPallet, prmEstacion, DatosTemporales.Usuario, CmbImpresora.Text)
            'Else
            '    pResultado = ws.WM_ReimprimePalletMP(prmOrdenProd, "", prmLote, prmLote, prmEstacion, prmCodigoPallet, prmNumParte, prmDescripcion, prmCajas, prmCantidad, prmTipoEtiquetado, "", prmFechaCaducidad, CmbImpresora.Text, IIf(CmbImpresora.Text = "ZEBRAPICKING", "300", "203"), DatosTemporales.Usuario, prmMercado, prmLinea)
            'End If

            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then


                XtraMessageBox.Show("ER: " + pResultado.Texto, "AXC")
                Return
            Else
                XtraMessageBox.Show("Impresión enviada con exito", "AXC")
            End If

        Catch ex As Exception
            XtraMessageBox.Show("Error: " + ex.Message, "AXC")
        End Try
    End Sub

    Private Sub ListarImpresora()

        Try

            Dim pResultado As New CResultado
            Dim pCons As New clsImpresora

            Cursor.Current = Cursors.WaitCursor
            pResultado = pCons.CargarImpresora(My.Settings.Estacion, DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                MsgBox(pResultado.Texto)
                Return
            End If
            Dim dt As New DataTable
            Dim ds As New DataSet

            dt = pResultado.Tabla
            ds.Tables.Add(dt)

            CmbImpresora.Properties.ValueMember = "Impresora"
            CmbImpresora.Properties.DisplayMember = "Impresora"
            CmbImpresora.Properties.DataSource = dt

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub

    Private Sub txtBusqueda_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBusqueda.KeyPress
        Try

            If e.KeyChar = Convert.ToChar(Keys.Enter) Then
                btnBuscar.PerformClick()
            End If
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub
End Class