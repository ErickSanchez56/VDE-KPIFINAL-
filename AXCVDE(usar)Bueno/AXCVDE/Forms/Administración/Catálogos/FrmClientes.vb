Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Base

Public Class FrmClientes


#Region "VARIABLES"
    Public pClienteSeleccionada As String = ""
    Public pCliente As String
    Public pIdCliente As Int64
    Public pAccion As Integer
#End Region

#Region "EVENTOS"
    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        Try
            pAccion = 2
            Accion()
            Dim pBusqueda As String
            If String.IsNullOrEmpty(TxtBusqueda.Text) Then
                pBusqueda = "@"
            Else
                pBusqueda = TxtBusqueda.Text
            End If
            ResultadoLista(pBusqueda)
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message.ToString, "Error", MessageBoxButtons.OK)
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
            XtraMessageBox.Show(ex.Message.ToString, "Error", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Try

            If String.IsNullOrEmpty(txtCliente.Text) Then
                XtraMessageBox.Show("El campo [Cliente] no puede estar vacío")
                txtCliente.Select()
                Return
            End If

            Agregar()

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message.ToString, "Error", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        Try

            If String.IsNullOrEmpty(txtCliente.Text) Then
                XtraMessageBox.Show("El campo [Cliente] no puede estar vacío")
                txtCliente.Select()
                Return
            End If

            Editar()


        Catch ex As Exception
            XtraMessageBox.Show(ex.Message.ToString, "Error", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Try
            Eliminar()
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message.ToString, "Error", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        ConfigCancelar()
    End Sub
#End Region


#Region "METODOS"
    Private Sub ResultadoLista(prmBusqueda As String)
        Try
            dgvResultado.DataSource = Nothing

            Dim pResultado As New CResultado
            Dim Cls As New clsCliente

            Cursor.Current = Cursors.WaitCursor
            pResultado = Cls.ResultadoListaClientes(prmBusqueda, My.Settings.Estacion, DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                dgvResultado.DataSource = Nothing
                Return
            End If
            Dim dt As New DataTable
            Dim ds As New DataSet

            dt = pResultado.Tabla
            ds.Tables.Add(dt)

            If dt.Rows.Count < 1 Then
                XtraMessageBox.Show("Sin información en el sistema", "AXC", MessageBoxButtons.OK)
                dgvResultado.DataSource = Nothing
                Return
            End If

            dgvResultado.DataSource = dt
            dgvViewResultado.BestFitColumns()

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message.ToString, "Error", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub DgvResultado_Click(sender As Object, e As EventArgs) Handles dgvResultado.Click
        Try
            If IsNothing(dgvResultado.DataSource) Then
                Return
            End If

            Dim ds As New DataSet


            Dim view As ColumnView = CType(dgvResultado.MainView, ColumnView)
            Dim selectedRowHandles As Integer() = view.GetSelectedRows()

            pClienteSeleccionada = view.GetRowCellDisplayText(selectedRowHandles(0), view.Columns("Cliente"))

            pIdCliente = CLng(view.GetRowCellDisplayText(selectedRowHandles(0), view.Columns("IdCliente")))
            pCliente = pClienteSeleccionada
            pAccion = 1

            Accion()


        Catch ex As Exception
            XtraMessageBox.Show(ex.Message.ToString, "Error", MessageBoxButtons.OK)
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
            XtraMessageBox.Show(ex.Message.ToString, "Error", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub FrmLineas_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose(True)
    End Sub

    Private Sub ListaDetalle(ByVal prmLinea As String)
        Try

            Dim pResultado As New CResultado
            Dim Cls As New clsCliente

            Cursor.Current = Cursors.WaitCursor
            pResultado = Cls.ResultadoListaClientes(prmLinea, My.Settings.Estacion, DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                Return
            End If
            Dim dt As New DataTable
            Dim ds As New DataSet

            dt = pResultado.Tabla
            ds.Tables.Add(dt)

            txtCodigo.Text = ds.Tables(0).Rows(0)("CodigoCliente").ToString
            txtCliente.Text = ds.Tables(0).Rows(0)("Cliente").ToString
            txtDireccion.Text = ds.Tables(0).Rows(0)("Direccion").ToString
            txtCiudad.Text = ds.Tables(0).Rows(0)("Ciudad").ToString
            txtEstado.Text = ds.Tables(0).Rows(0)("Estado").ToString
            txtCodigoPostal.Text = ds.Tables(0).Rows(0)("CodigoPostal").ToString
            txtPais.Text = ds.Tables(0).Rows(0)("Pais").ToString

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message.ToString, "Error", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub Agregar()
        Try
            Dim pResultado As New CResultado
            Dim Cls As New clsCliente

            Cursor.Current = Cursors.WaitCursor
            pResultado = Cls.Agregar(txtCliente.Text, txtCodigo.Text, txtDireccion.Text, txtCiudad.Text, txtEstado.Text, txtCodigoPostal.Text, txtPais.Text, My.Settings.Estacion, DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                Return
            End If

            XtraMessageBox.Show("Cliente creado con éxito")
            ResultadoLista("@")
            ConfigCancelar()
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message.ToString, "Error", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub Editar()
        Try
            Dim pResultado As New CResultado
            Dim Cls As New clsCliente

            Cursor.Current = Cursors.WaitCursor
            pResultado = Cls.Editar(pIdCliente, txtCliente.Text, txtCodigo.Text, txtDireccion.Text, txtCiudad.Text, txtEstado.Text, txtCodigoPostal.Text, txtPais.Text, My.Settings.Estacion, DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                Return
            End If

            XtraMessageBox.Show("Cliente editado con éxito")
            ResultadoLista("@")
            ConfigCancelar()
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message.ToString, "Error", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub Eliminar()
        Try
            Dim pResultado As New CResultado
            Dim Cls As New clsCliente

            Cursor.Current = Cursors.WaitCursor
            pResultado = Cls.Eliminar(pIdCliente, My.Settings.Estacion, DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                Return
            End If

            XtraMessageBox.Show("Cliente eliminado con éxito")
            ConfigCancelar()
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message.ToString, "Error", MessageBoxButtons.OK)
        End Try
    End Sub

    Sub ConfigAgregar()
        BtnGuardar.Visible = True
        BtnCancelar.Visible = True
        BtnEliminar.Visible = False
        BtnEditar.Visible = False
        txtCliente.Enabled = True
        txtCliente.Text = ""
        txtCliente.Select()
        txtCodigo.Enabled = True
        txtCodigo.Text = ""
        txtDireccion.Enabled = True
        txtDireccion.Text = ""
        txtEstado.Enabled = True
        txtEstado.Text = ""
        txtCiudad.Enabled = True
        txtCiudad.Text = ""
        txtCodigoPostal.Enabled = True
        txtCodigoPostal.Text = ""
        txtPais.Enabled = True
        txtPais.Text = ""
        BtnNuevo.Enabled = False
    End Sub

    Sub ConfigCancelar()
        BtnGuardar.Visible = False
        BtnCancelar.Visible = False
        BtnEliminar.Visible = False
        BtnEditar.Visible = False
        txtCliente.Enabled = False
        txtCliente.Text = ""
        txtCodigo.Enabled = False
        txtCodigo.Text = ""
        txtDireccion.Enabled = False
        txtDireccion.Text = ""
        txtEstado.Enabled = False
        txtEstado.Text = ""
        txtCiudad.Enabled = False
        txtCiudad.Text = ""
        txtCodigoPostal.Enabled = False
        txtCodigoPostal.Text = ""
        txtPais.Enabled = False
        txtPais.Text = ""
        BtnNuevo.Enabled = True
    End Sub

    Sub ConfigEditarOEliminar()
        txtCliente.Enabled = True
        txtCliente.Select()
        txtCodigo.Enabled = True
        txtDireccion.Enabled = True
        txtEstado.Enabled = True
        txtCiudad.Enabled = True
        txtCodigoPostal.Enabled = True
        txtPais.Enabled = True
        BtnGuardar.Visible = False
        BtnEditar.Visible = True
        BtnEliminar.Visible = False
        BtnCancelar.Visible = True

        BtnNuevo.Enabled = False
    End Sub

    Public Sub Accion()
        Try

            If pAccion = 1 Then
                ListaDetalle(pCliente)
                ConfigEditarOEliminar()
            Else
                ConfigAgregar()
            End If
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message.ToString, "Error", MessageBoxButtons.OK)
        End Try
    End Sub



    Private Sub FrmClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


#End Region

End Class