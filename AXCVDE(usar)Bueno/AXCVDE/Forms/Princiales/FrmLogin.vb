Imports System.Deployment.Application
Imports System.Reflection
Imports DevExpress.XtraEditors

Public Class FrmLogin
    Public wgPermiso As Boolean
    Public wgSuperUsuario As Boolean
    Private wgAccesoDB As New AccesoDatos
    Public cerrarFormulario As Boolean = True
    Private Sub FrmLogin_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If ApplicationDeployment.IsNetworkDeployed Then
            'MsgBox(ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString)
            Me.Text = "AXC " + ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString
        Else
            'MsgBox(Assembly.GetExecutingAssembly.GetName.Version.ToString)
            Me.Text = "AXC " + Assembly.GetExecutingAssembly.GetName.Version.ToString
        End If
        txtUsuario.Select()
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Try
            InicioSesion()
        Catch ex As Exception
            XtraMessageBox.Show("Error: " + ex.Message, "AXC")
        End Try
    End Sub


    Sub InicioSesion()
        Try

            If Trim(txtUsuario.Text) = "" Then
                XtraMessageBox.Show("Escriba un usuario para iniciar sesión", "AXC")
                txtUsuario.Select()
                Exit Sub
            End If

            If Trim(txtPassword.Text) = "" Then
                XtraMessageBox.Show("Escriba un password para iniciar sesión", "AXC")
                txtPassword.Select()
                Exit Sub
            End If

            Dim pUsuario As New clsUsuario
            Dim cResultado As New CResultado

            If My.Settings("Estacion") = "" Then
                XtraMessageBox.Show("Reinicie la aplicación", "AXC")
                Exit Sub
            End If

            cResultado = pUsuario.Login(txtUsuario.Text, txtPassword.Text, My.Settings("Estacion"), "")

            If Not cResultado.Estado Then
                XtraMessageBox.Show(cResultado.Texto, "AXC")
                txtPassword.SelectAll()
                Return
            End If
            DatosTemporales.Usuario = txtUsuario.Text

            FrmMenuPrincipal.Show()
        Catch ex As Exception
            Metodos.EscribirBitacora(Metodos.Bitacora.INCIDENCIA, ex, "FrmLogin.btnAceptar_Click")

            XtraMessageBox.Show("Error al tratar de iniciar sesión, intente nuevamente", "AXC")
        End Try
    End Sub


    Private Sub txtUsuario_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUsuario.KeyPress
        Try
            If e.KeyChar = Convert.ToChar(Keys.Return) Then
                txtPassword.Select()
            End If
        Catch ex As Exception
            XtraMessageBox.Show("Error: " + ex.Message, "AXC")
        End Try
    End Sub

    Private Sub txtPassword_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPassword.KeyPress
        Try
            If e.KeyChar = Convert.ToChar(Keys.Return) Then
                InicioSesion()
            End If
        Catch ex As Exception
            XtraMessageBox.Show("Error: " + ex.Message, "AXC")
        End Try
    End Sub

    Private Sub FrmLogin_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Try
            If cerrarFormulario Then
                Application.Exit()
            End If
        Catch ex As Exception
            XtraMessageBox.Show("Error: " + ex.Message, "AXC")
        End Try
    End Sub
End Class