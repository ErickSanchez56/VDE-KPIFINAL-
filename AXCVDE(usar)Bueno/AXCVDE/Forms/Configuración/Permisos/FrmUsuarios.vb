Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Base

Public Class FrmUsuarios
#Region "VARIABLES"
    Public PUsuarioSeleccionado As Int64
#End Region
#Region "EVENTOS"
    Private Sub FrmUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            LlenaComboHabilitado()
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Try
            Dim pBusqueda As String
            If String.IsNullOrEmpty(TxtBusqueda.Text) Then
                pBusqueda = "@"
            Else
                pBusqueda = TxtBusqueda.Text
            End If
            ResultadoLista(pBusqueda)
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Try

            If String.IsNullOrEmpty(TxtUsuario.Text) Then
                XtraMessageBox.Show("El campo [Usuario] no puede estar vacío")
                TxtUsuario.Select()
                Return
            End If

            If String.IsNullOrEmpty(TxtNombre.Text) Then
                XtraMessageBox.Show("el campo [Nombre] no puede estar vacío")
                TxtNombre.Select()
                Return
            End If

            If String.IsNullOrEmpty(CmbHabilitado.Text) Then
                XtraMessageBox.Show("el campo [Habilitado] no puede estar vacío")
                CmbHabilitado.Select()
                Return
            End If

            If String.IsNullOrEmpty(TxtContrasena.Text) Then
                XtraMessageBox.Show("el campo [Contraseña] no puede estar vacío")
                TxtContrasena.Select()
                Return
            End If

            If String.IsNullOrEmpty(TxtConfirmContrasena.Text) Then
                XtraMessageBox.Show("el campo [Confirmar contraseña] no puede estar vacío")
                TxtConfirmContrasena.Select()
                Return
            End If

            If TxtContrasena.Text <> TxtConfirmContrasena.Text Then
                XtraMessageBox.Show("Las contraseñas no coinciden")
                TxtContrasena.Select()
                Return
            End If

            Agregar()

            ConfigCancelar()
            ResultadoLista("@")


        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        Try
            If String.IsNullOrEmpty(CmbHabilitado.Text) Then
                XtraMessageBox.Show("el campo [Habilitado] no puede estar vacío")
                CmbHabilitado.Select()
                Return
            End If

            If String.IsNullOrEmpty(TxtContrasena.Text) Then
                XtraMessageBox.Show("el campo [Contraseña] no puede estar vacío")
                TxtContrasena.Select()
                Return
            End If

            If String.IsNullOrEmpty(TxtConfirmContrasena.Text) Then
                XtraMessageBox.Show("el campo [Confirmar contraseña] no puede estar vacío")
                TxtConfirmContrasena.Select()
                Return
            End If

            If TxtContrasena.Text <> TxtConfirmContrasena.Text Then
                XtraMessageBox.Show("Las contraseñas no coinciden")
                TxtContrasena.Select()
                Return
            End If

            Editar()
            ConfigCancelar()
            ResultadoLista("@")

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Try
            ConfigCancelar()
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub DgvResultado_Click(sender As Object, e As EventArgs) Handles DgvResultado.Click
        Try
            If IsNothing(DgvResultado.DataSource) Then
                Return
            End If

            Dim ds As New DataSet


            Dim view As ColumnView = CType(DgvResultado.MainView, ColumnView)
            Dim selectedRowHandles As Integer() = view.GetSelectedRows()


            TxtUsuario.Text = view.GetRowCellDisplayText(selectedRowHandles(0), view.Columns("Usuario"))
            TxtNombre.Text = view.GetRowCellDisplayText(selectedRowHandles(0), view.Columns("Nombre"))
            CmbHabilitado.ItemIndex = CInt(IIf(CBool(view.GetRowCellValue(selectedRowHandles(0), view.Columns("Activo"))) = True, 1, 0))

            ConfigEditarOEliminar()

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
            ConfigCancelar()
        End Try
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        Try
            ConfigAgregar()
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        Try
            Dim pBusqueda As String
            If String.IsNullOrEmpty(TxtBusqueda.Text) Then
                pBusqueda = "@"
            Else
                pBusqueda = TxtBusqueda.Text
            End If
            ResultadoLista(pBusqueda)
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region



#Region "METODOS"
    Private Sub ResultadoLista(prmBusqueda As String)
        Try
            DgvResultado.DataSource = Nothing

            Dim pResultado As New CResultado
            Dim Cls As New clsUsuario

            Cursor.Current = Cursors.WaitCursor
            pResultado = Cls.ListaUsuarios(prmBusqueda, My.Settings.Estacion, DatosTemporales.Usuario)
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
            DgvResultado.DataSource = dt

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Agregar()
        Try
            Dim pResultado As New CResultado
            Dim Cls As New clsUsuario

            Cursor.Current = Cursors.WaitCursor
            pResultado = Cls.Agregar(TxtUsuario.Text, TxtNombre.Text, CmbHabilitado.ItemIndex, TxtContrasena.Text, My.Settings.Estacion, DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                Return
            End If

            XtraMessageBox.Show("Usuario agregado exitosamente")

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Editar()
        Try
            Dim pResultado As New CResultado
            Dim Cls As New clsUsuario

            Cursor.Current = Cursors.WaitCursor
            pResultado = Cls.Editar(TxtUsuario.Text, CmbHabilitado.ItemIndex, TxtContrasena.Text, My.Settings.Estacion, DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                Return
            End If

            XtraMessageBox.Show("Usuario editado exitosamente")

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub



    Sub ConfigAgregar()
        BtnNuevo.Enabled = False
        BtnGuardar.Visible = True
        BtnCancelar.Visible = True
        BtnEditar.Visible = False
        TxtUsuario.Enabled = True
        TxtUsuario.Text = ""
        TxtUsuario.Select()
        TxtNombre.Enabled = True
        TxtNombre.Text = ""
        CmbHabilitado.Enabled = True
        TxtContrasena.Enabled = True
        TxtContrasena.Text = ""
        TxtConfirmContrasena.Enabled = True
        TxtConfirmContrasena.Text = ""
    End Sub

    Sub ConfigCancelar()
        BtnNuevo.Enabled = True
        TxtUsuario.Enabled = False
        TxtUsuario.Text = ""
        TxtNombre.Enabled = False
        TxtNombre.Text = ""
        CmbHabilitado.Enabled = False
        TxtConfirmContrasena.Enabled = False
        TxtConfirmContrasena.Text = ""
        TxtContrasena.Enabled = False
        TxtContrasena.Text = ""
        BtnCancelar.Visible = False
        BtnEditar.Visible = False
        BtnGuardar.Visible = False
    End Sub

    Sub ConfigEditarOEliminar()
        BtnNuevo.Enabled = False
        CmbHabilitado.Enabled = True
        CmbHabilitado.Select()
        TxtContrasena.Enabled = True
        TxtContrasena.Text = ""
        TxtConfirmContrasena.Enabled = True
        TxtConfirmContrasena.Text = ""
        BtnGuardar.Visible = False
        BtnEditar.Visible = True
        BtnCancelar.Visible = True
    End Sub

    Sub LlenaComboHabilitado()
        Dim Habilitado = New List(Of String)()
        Habilitado.Add("NO")
        Habilitado.Add("SI")

        CmbHabilitado.Properties.DataSource = Habilitado
    End Sub


#End Region
End Class