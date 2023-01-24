Imports DevExpress.XtraEditors

Public Class FrmGrupo


#Region "VARIABLES"
    Public pGrupo As String
    Public pIdGrupo As Int64
    Public pAccion As Integer
#End Region

#Region "EVENTOS"
    Private Sub FrmGrupo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If pAccion = 1 Then
                ConfigEditarOEliminar()
                ListaDetalle(pGrupo)

            Else
                ConfigAgregar()
            End If
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        Try
            If String.IsNullOrEmpty(TxtGrupo.Text) Then
                XtraMessageBox.Show("El campo [Grupo] no puede estar vacío")
                TxtGrupo.Select()
                Return
            End If

            Editar()
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Try
            If String.IsNullOrEmpty(TxtGrupo.Text) Then
                XtraMessageBox.Show("El campo [Grupo] no puede estar vacío")
                TxtGrupo.Select()
                Return
            End If

            Agregar()

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub s_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dispose(True)
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        ConfigCancelar()
    End Sub
#End Region


#Region "METODOS"

    Private Sub ListaDetalle(prmBusqueda As String)
        Try

            Dim pResultado As New CResultado
            Dim Cls As New clsUsuario

            Cursor.Current = Cursors.WaitCursor
            pResultado = Cls.ResultadoListaGrupos(prmBusqueda, My.Settings.Estacion, DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                Return
            End If
            Dim dt As New DataTable
            Dim ds As New DataSet

            dt = pResultado.Tabla
            ds.Tables.Add(dt)
            TxtGrupo.Text = ds.Tables(0).Rows(0)("Grupo").ToString
            pIdGrupo = CLng(ds.Tables(0).Rows(0)("IdGrupo").ToString)


        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub Editar()
        Try
            Dim pResultado As New CResultado
            Dim Cls As New clsUsuario

            Cursor.Current = Cursors.WaitCursor
            pResultado = Cls.EditarGrupo(pIdGrupo, TxtGrupo.Text, My.Settings.Estacion, DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                Return
            End If

            XtraMessageBox.Show("Grupo editado exitosamente")
            ConfigCancelar()
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Agregar()
        Try
            Dim pResultado As New CResultado
            Dim Cls As New clsUsuario

            Cursor.Current = Cursors.WaitCursor
            pResultado = Cls.AgregarGrupo(TxtGrupo.Text, My.Settings.Estacion, DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                Return
            End If

            XtraMessageBox.Show("Grupo agregado exitosamente")
            ConfigCancelar()

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Eliminar()
        Try
            Dim pResultado As New CResultado
            Dim Cls As New clsUsuario

            Cursor.Current = Cursors.WaitCursor
            pResultado = Cls.EliminarGrupo(pIdGrupo, My.Settings.Estacion, DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                Return
            End If

            XtraMessageBox.Show("Grupo eliminado exitosamente")
            ConfigCancelar()


        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub ConfigAgregar()
        BtnGuardar.Visible = True
        BtnCancelar.Visible = True
        BtnEliminar.Visible = False
        BtnEditar.Visible = False

        TxtGrupo.Enabled = True
        TxtGrupo.Text = ""
        TxtGrupo.Select()

    End Sub

    Sub ConfigCancelar()
        Close()
    End Sub

    Sub ConfigEditarOEliminar()
        TxtGrupo.Enabled = True
        TxtGrupo.Select()

        BtnEditar.Visible = True
        BtnEliminar.Visible = True
        BtnCancelar.Visible = True
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Try
            If String.IsNullOrEmpty(TxtGrupo.Text) Then
                XtraMessageBox.Show("El campo [Grupo] no puede estar vacío")
                TxtGrupo.Select()
                Return
            End If

            Eliminar()
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region
End Class