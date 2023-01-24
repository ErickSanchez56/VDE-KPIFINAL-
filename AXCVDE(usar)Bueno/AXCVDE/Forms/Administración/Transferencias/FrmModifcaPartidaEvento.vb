Imports DevExpress.XtraEditors

Public Class FrmModifcaPartidaEvento
#Region "VARIABLES"

    Public pNumParte As String
    Public pLote As String
    Public chkLote As Boolean = False
    Public pEstacion As String
    Public pOrdenProd As String
#End Region

#Region "EVENTOS"
    Private Sub FrmModificaTransferPT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            If chkLote Then
                CmbLote.Enabled = True
            Else
                CmbLote.Enabled = False
            End If

            Dim strNumParte As String
            strNumParte = pNumParte
            ListaEstaciones("@")
            ListaLote(strNumParte)
            CmbEstacion.EditValue = pEstacion
            CmbLote.EditValue = pLote
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub ListaLote(ByVal prmNumParte As String)
        Try
            Dim pResultado As New CResultado
            Dim pOrdenProd As New clsOrdenProd

            Cursor.Current = Cursors.WaitCursor
            pResultado = pOrdenProd.ListaLotes(prmNumParte, My.Settings.Estacion, DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                Return
            End If
            Dim dt As New DataTable
            Dim ds As New DataSet

            dt = pResultado.Tabla


            CmbLote.Properties.DisplayMember = "LoteAXC"
            CmbLote.Properties.ValueMember = "LoteAXC"
            CmbLote.Properties.DataSource = dt

        Catch ex As Exception
            XtraMessageBox.Show("Error: " + ex.Message, "AXC")
        End Try
    End Sub

    Private Sub ListaEstaciones(prmBusqueda As String)
        Try


            Dim pResultado As New CResultado
            Dim Cls As New clsOrdenProd

            Cursor.Current = Cursors.WaitCursor
            pResultado = Cls.ListaEstaciones()
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                Return
            End If
            Dim dt As New DataTable
            Dim ds As New DataSet

            dt = pResultado.Tabla
            ds.Tables.Add(dt)

            CmbEstacion.Properties.ValueMember = "Estacion"
            CmbEstacion.Properties.DisplayMember = "Estacion"
            CmbEstacion.Properties.DataSource = dt

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnLiberar_Click(sender As Object, e As EventArgs) Handles BtnLiberar.Click
        If chkLote Then
            FrmTraspasoSalidaPT.pEstacion = CmbEstacion.Text
            'FrmLiberacionFrmTraspasoSalidaPTOrdenProduccion.pLote = CmbLote.Text
        Else
            FrmTraspasoSalidaPT.pEstacion = CmbEstacion.Text
            'FrmTraspasoSalidaPT.pLote = ""
        End If

        If XtraMessageBox.Show("¿Desea Actualizar la estacion??", "AXC", MessageBoxButtons.YesNo) <> DialogResult.Yes Then
            Return
        End If
        ' pOrdenEmbarque = FrmLiberaOrdenEmbarque.pOrdenEmbarque
        Dim pResultado As New CResultado
        Dim Cls As New clsTransfer
        'If CmbTipoLib.Text = "TODO" Then
        Cursor.Current = Cursors.WaitCursor
        Dim Estacion As String() = CmbEstacion.Text.Split("/")
        pResultado = Cls.ActualizaEstacion(Estacion(0), pOrdenProd)
        Cursor.Current = Cursors.Default
        'End If



        Me.Close()
#End Region
    End Sub
End Class