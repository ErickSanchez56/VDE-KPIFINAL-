Imports DevExpress.XtraEditors

Public Class FrmImpresionEtiquetas
    Private Sub frmEtiquetaSKU_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ListaNumParte()
            ListarImpresora()

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
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
                XtraMessageBox.Show(pResultado.Texto, "AXC")
                Return
            End If
            Dim dt As New DataTable
            Dim ds As New DataSet

            dt = pResultado.Tabla
            ds.Tables.Add(dt)

            cmbImpresora.Properties.ValueMember = "Impresora"
            cmbImpresora.Properties.DisplayMember = "Impresora"
            cmbImpresora.Properties.DataSource = dt

            cmbImpresoraCONT.Properties.ValueMember = "Impresora"
            cmbImpresoraCONT.Properties.DisplayMember = "Impresora"
            cmbImpresoraCONT.Properties.DataSource = dt

            cmbImpresoraEMP.Properties.ValueMember = "Impresora"
            cmbImpresoraEMP.Properties.DisplayMember = "Impresora"
            cmbImpresoraEMP.Properties.DataSource = dt

            cmbImpresoraSKU.Properties.ValueMember = "Impresora"
            cmbImpresoraSKU.Properties.DisplayMember = "Impresora"
            cmbImpresoraSKU.Properties.DataSource = dt

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

#Region "SKU"
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
            dt = pResultado.Tabla

            cmbNumParte.Properties.ValueMember = "CodigoExterno"
            cmbNumParte.Properties.DisplayMember = "NumParte"
            cmbNumParte.Properties.DataSource = dt
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
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
                XtraMessageBox.Show(pResultado.Texto, "AXC")

                Return
            End If

            Dim dt As DataTable = New DataTable
            dt = pResultado.Tabla

            txtDescripcion.Text = dt.Rows(0).Item("DNumParte1")
            ' lblExistencia.Text = dt.Rows(0).Item("Existencia")
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub

    Private Sub btnImprimirSKU_Click(sender As Object, e As EventArgs) Handles btnImprimirSKU.Click
        Try
            If String.IsNullOrEmpty(cmbImpresoraSKU.Text) Then
                XtraMessageBox.Show("Seleccionar impresora", "Información", MessageBoxButtons.OK)
                cmbImpresoraSKU.Select()
                Return
            End If

            If numEtiquetasSKU.Value = 0 Then
                XtraMessageBox.Show("Valor introducido no válido", "AXC")
                Return
            End If

            If String.IsNullOrEmpty(cmbNumParte.Text) Then
                XtraMessageBox.Show("Seleccionar Artículo", "Información", MessageBoxButtons.OK)
                cmbNumParte.Select()
                Return
            End If

            If XtraMessageBox.Show("¿Desea imprimir las etiquetas de SKU?", "AXC", MessageBoxButtons.YesNo) <> DialogResult.Yes Then
                Return
            End If



            ImprimeEtiquetasSKU()
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub ImprimeEtiquetasSKU()
        Try
            Dim CRespuesta As New CResultado

            Dim pResultado As New wsAXC.CResultado
            Dim ws As New wsAXC.wsAXCMP

            Dim pUrl As String = My.Settings("AXCVDE_wsAXC_wsAXCMP")

            If pUrl = "" Then
                pUrl = "http://192.168.1.181/wsAXCMP/wsAXCMP.asmx"
            End If

            ws.Url = pUrl
            Cursor.Current = Cursors.WaitCursor
            pResultado = ws.WM_ImprimeSKU(cmbNumParte.Text, cmbNumParte.EditValue, txtDescripcion.Text, numEtiquetasSKU.Value, cmbImpresoraSKU.Text, My.Settings.Estacion, DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then

                XtraMessageBox.Show("ER" + pResultado.Texto, "AXC")
                Return
            Else
                XtraMessageBox.Show("Impresión enviada con exito", "AXC")
            End If

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region


#Region "CARRITO"
    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        Try
            If String.IsNullOrEmpty(cmbImpresora.Text) Then
                XtraMessageBox.Show("Seleccionar impresora", "Información", MessageBoxButtons.OK)
                cmbImpresora.Select()
                Return
            End If

            If numEtiquetasCARR.Value = 0 Then
                XtraMessageBox.Show("Valor introducido no válido", "AXC")
                Return
            End If

            If XtraMessageBox.Show("¿Desea imprimir las etiquetas de carrito?", "AXC", MessageBoxButtons.YesNo) <> DialogResult.Yes Then
                Return
            End If



            ImprimeEtiquetasCARR()
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ImprimeEtiquetasCARR()
        Try
            Dim CRespuesta As New CResultado

            Dim pResultado As New wsAXC.CResultado
            Dim ws As New wsAXC.wsAXCMP

            Dim pUrl As String = My.Settings("AXCVDE_wsAXC_wsAXCMP")

            If pUrl = "" Then
                pUrl = "http://192.168.1.181/wsAXCMP/wsAXCMP.asmx"
            End If

            ws.Url = pUrl
            Cursor.Current = Cursors.WaitCursor
            pResultado = ws.WM_ImpContenedor(numEtiquetasCARR.Value, cmbImpresora.Text, "2", My.Settings.Estacion, DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then

                XtraMessageBox.Show("ER" + pResultado.Texto, "AXC")
                Return
            Else
                XtraMessageBox.Show("Impresión enviada con exito", "AXC")
            End If

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub numEtiquetasCARR_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles numEtiquetasCARR.Leave
        If ((numEtiquetasCARR.Value Mod 2) <> 0) Then
            numEtiquetasCARR.Value = numEtiquetasCARR.Value + 1
        End If
    End Sub
#End Region

#Region "CONTENEDOR"
    Private Sub cmbImprimirCONT_Click(sender As Object, e As EventArgs) Handles cmbImprimirCONT.Click
        Try
            If String.IsNullOrEmpty(cmbImpresoraCONT.Text) Then
                XtraMessageBox.Show("Seleccionar impresora", "Información", MessageBoxButtons.OK)
                cmbImpresoraCONT.Select()
                Return
            End If

            If numEtiquetasCONT.Value = 0 Then
                XtraMessageBox.Show("Valor introducido no válido", "AXC")
                Return
            End If

            If XtraMessageBox.Show("¿Desea imprimir las etiquetas de Contenedor?", "AXC", MessageBoxButtons.YesNo) <> DialogResult.Yes Then
                Return
            End If

            ImprimeEtiquetasCONT()
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub numEtiquetas_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If ((numEtiquetasCONT.Value Mod 2) <> 0) Then
            numEtiquetasCONT.Value = numEtiquetasCONT.Value + 1
        End If
    End Sub

    Private Sub ImprimeEtiquetasCONT()
        Try
            Dim CRespuesta As New CResultado

            Dim pResultado As New wsAXC.CResultado
            Dim ws As New wsAXC.wsAXCMP

            Dim pUrl As String = My.Settings("AXCVDE_wsAXC_wsAXCMP")

            If pUrl = "" Then
                pUrl = "http://192.168.1.181/wsAXCMP/wsAXCMP.asmx"
            End If

            ws.Url = pUrl
            Cursor.Current = Cursors.WaitCursor
            pResultado = ws.WM_ImpContenedor(numEtiquetasCONT.Value, cmbImpresoraCONT.Text, "1", My.Settings.Estacion, DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then

                XtraMessageBox.Show("ER" + pResultado.Texto, "AXC")
                Return
            Else
                XtraMessageBox.Show("Impresión enviada con exito", "AXC")
            End If

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

#Region "EMPAQUES"
    Private Sub btnImprimirEMP_Click(sender As Object, e As EventArgs) Handles btnImprimirEMP.Click
        Try
            If String.IsNullOrEmpty(cmbImpresoraEMP.Text) Then
                XtraMessageBox.Show("Seleccionar impresora", "Información", MessageBoxButtons.OK)
                cmbImpresoraEMP.Select()
                Return
            End If

            If NumEtiquetasEMP.Value = 0 Then
                XtraMessageBox.Show("Valor introducido no válido", "AXC")
                Return
            End If

            If XtraMessageBox.Show("¿Desea imprimir las etiquetas de Empaque?", "AXC", MessageBoxButtons.YesNo) <> DialogResult.Yes Then
                Return
            End If


            ImprimeEtiquetasEMP()
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ImprimeEtiquetasEMP()
        Try
            Dim CRespuesta As New CResultado

            Dim pResultado As New wsAXC.CResultado
            Dim ws As New wsAXC.wsAXCMP

            Dim pUrl As String = My.Settings("AXCVDE_wsAXC_wsAXCMP")

            If pUrl = "" Then
                pUrl = "http://192.168.1.181/axcVDEpt/wsAXCMP.asmx"
            End If


            ws.Url = pUrl
            Cursor.Current = Cursors.WaitCursor
            pResultado = ws.WM_ImprimeEtiquetaEmpaque(cmbImpresoraEMP.Text, NumEtiquetasEMP.Value, My.Settings.Estacion, DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default


            If Not pResultado.Estado Then

                XtraMessageBox.Show("ER" + pResultado.Texto, "AXC")
                Return
            Else
                XtraMessageBox.Show("Impresión enviada con éxito", "AXC")
            End If

        Catch ex As Exception
            XtraMessageBox.Show("Error: " + ex.Message, "AXC")
        End Try
    End Sub

    Private Sub cmbNumParte_EditValueChanged(sender As Object, e As EventArgs) Handles cmbNumParte.EditValueChanged
        Try
            Dim text As String = cmbNumParte.Text
            If text.Equals("System.Data.DataRowView") Then
                Return
            End If
            ConsultaNumParte()
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

#End Region
End Class