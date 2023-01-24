Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Base

Public Class FrmAlmacen
#Region "VARIABLES"
    Public pAlmacenSeleccionado As Int64
#End Region
#Region "EVENTOS"


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

            If String.IsNullOrEmpty(TxtNombre.Text) Then
                XtraMessageBox.Show("el campo [Nombre] no puede estar vacío")
                TxtNombre.Select()
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
            If String.IsNullOrEmpty(TxtNombre.Text) Then
                XtraMessageBox.Show("el campo [Nombre] no puede estar vacío")
                TxtNombre.Select()
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
            Dim Cls As New ClsAlmacen

            Cursor.Current = Cursors.WaitCursor
            pResultado = Cls.ListaAlmacen("@", prmBusqueda, My.Settings.Estacion)
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
            Dim Cls As New ClsAlmacen

            Cursor.Current = Cursors.WaitCursor
            ' pResultado = Cls.Agregar(TxtNombre.Text, My.Settings.Estacion, DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                Return
            End If

            XtraMessageBox.Show("Almacén agregado exitosamente")

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Editar()
        Try
            Dim pResultado As New CResultado
            Dim Cls As New ClsAlmacen

            Cursor.Current = Cursors.WaitCursor
            ' pResultado = Cls.Editar(pAlmacenSeleccionado, TxtNombre.Text, My.Settings.Estacion, DatosTemporales.Usuario)
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

        TxtNombre.Enabled = True
        TxtNombre.Text = ""
        TxtNombre.Select()

    End Sub

    Sub ConfigCancelar()
        BtnNuevo.Enabled = True
        TxtNombre.Enabled = False
        TxtNombre.Text = ""
        BtnCancelar.Visible = False
        BtnEditar.Visible = False
        BtnGuardar.Visible = False
    End Sub

    Sub ConfigEditarOEliminar()
        BtnNuevo.Enabled = False
        TxtNombre.Enabled = True
        TxtNombre.Select()
        BtnGuardar.Visible = False
        BtnEditar.Visible = True
        BtnCancelar.Visible = True
    End Sub

    Private Sub FrmAlmacen_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GridView1_Click(sender As Object, e As EventArgs) Handles GridView1.Click
        Try
            If IsNothing(DgvResultado.DataSource) Then
                Return
            End If

            Dim ds As New DataSet


            Dim view As ColumnView = CType(DgvResultado.MainView, ColumnView)
            Dim selectedRowHandles As Integer() = view.GetSelectedRows()
            TxtNombre.Text = view.GetRowCellDisplayText(selectedRowHandles(0), view.Columns("ERPAlmacen"))
            pAlmacenSeleccionado = CLng(view.GetRowCellDisplayText(selectedRowHandles(0), view.Columns("IdAlmacen")))
            ConfigEditarOEliminar()

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
            ConfigCancelar()
        End Try
    End Sub

#End Region
End Class