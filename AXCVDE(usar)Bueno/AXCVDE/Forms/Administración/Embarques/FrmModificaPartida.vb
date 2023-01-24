Imports DevExpress.XtraEditors

Public Class FrmModificaPartida
    Public pNumParte As String
    Public pLote As String
    Public chkLote As Boolean = False
    Public pEstacion As String
    Public pOrdenEmbarque As String


    Private Sub FrmModificaPartida_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            FrmLiberaOrdenEmbarque.pEstacion = CmbEstacion.Text
            FrmLiberaOrdenEmbarque.pLote = CmbLote.Text
        Else
            FrmLiberaOrdenEmbarque.pEstacion = CmbEstacion.Text
            FrmLiberaOrdenEmbarque.pLote = ""
        End If

        If XtraMessageBox.Show("¿Desea Actualizar la estacion??", "AXC", MessageBoxButtons.YesNo) <> DialogResult.Yes Then
            Return
        End If
        ' pOrdenEmbarque = FrmLiberaOrdenEmbarque.pOrdenEmbarque
        Dim pResultado As New CResultado
        Dim Cls As New clsEmbarque
        'If CmbTipoLib.Text = "TODO" Then
        Cursor.Current = Cursors.WaitCursor
        Dim Estacion As String() = CmbEstacion.Text.Split("/")
        pResultado = Cls.ActualizaEstacion(Estacion(0), pOrdenEmbarque)
        Cursor.Current = Cursors.Default
        'End If



        Me.Close()

    End Sub

    Private Sub FrmModificaPartida_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed

    End Sub
End Class