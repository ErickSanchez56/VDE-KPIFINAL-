Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Base
Imports System.IO
Imports System.Drawing.Imaging
Public Class FrmMonitorRecepcion
#Region "VARIABLES"
    Dim nuevo As New ClsMaterialRecibido
    Public pOrdenCompra As String = ""
#End Region

#Region "EVENTOS"

    Private Sub FrmMonitoreoRecepcion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            CargaGridOrdenes(nuevo.ConsultaReciboCompra("@", "@", My.Settings("Estacion"), DatosTemporales.Usuario))
            RedibujaGrids()
        Catch ex As Exception
            XtraMessageBox.Show("Error: " + ex.Message, "AXC")
        End Try
    End Sub

    'Private Sub FrmMonitoreoRecepcion_AfterLoad(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.L
    '    Try
    '        CargaGridOrdenes(nuevo.ConsultaReciboCompra("@", "@", My.Settings("Estacion"), DatosTemporales.Usuario))

    '    Catch ex As Exception
    '        XtraMessageBox.Show("Error: " + ex.Message, "AXC")
    '    End Try
    'End Sub
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Try
            Dim pOrdenCompra As String
            Dim pStatus As String

            If String.IsNullOrEmpty(TxtBusqueda.Text) Then
                pOrdenCompra = "@"
                pStatus = "@"
            Else
                pOrdenCompra = TxtBusqueda.Text
                pStatus = "@"
            End If


            LimpiarGrids()
            CargaGridOrdenes(nuevo.ConsultaReciboCompra(pOrdenCompra, pStatus, My.Settings("Estacion"), DatosTemporales.Usuario))

            cargarOCAsociadas(pOrdenCompra)
            Consultaimagen(pOrdenCompra)
        Catch ex As Exception
            XtraMessageBox.Show("Error: " + ex.Message, "AXC")
        End Try
    End Sub
    Private Sub Consultaimagen(prmBusqueda As String)
        Try
            Evidencia1.Image = Nothing
            Evidencia2.Image = Nothing
            Evidencia3.Image = Nothing

            Dim pResultado As New CResultado
            Dim Cls As New clsConsOC

            Cursor.Current = Cursors.WaitCursor
            pResultado = Cls.Cargarevidencia("7000011830")
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                Evidencia1.Image = Nothing
                Evidencia2.Image = Nothing
                Evidencia3.Image = Nothing
                Return
            End If
            'Dim dt As New DataTable
            Dim ds As New DataSet

            ds = pResultado.Resultado
            'ds.Tables.Add(dt)

            If ds.Tables(0).Rows.Count < 1 Then
                XtraMessageBox.Show("No hay evidencias")
                Evidencia1.Image = Nothing
                Evidencia2.Image = Nothing
                Evidencia3.Image = Nothing
                Return
            End If

            '//AQUI EMPEZAREMOS A LLENAR LAS IMAGENES
            txtIdProveedor.Text = ds.Tables(0).Rows(0)("Proveedor").ToString
            txtContenedor.Text = ds.Tables(0).Rows(0)("Contenedor").ToString
            TXTPLACAS.Text = ds.Tables(0).Rows(0)("Placa").ToString
            txtnombre.Text = ds.Tables(0).Rows(0)("Nombre").ToString
            txtestacón.Text = ds.Tables(0).Rows(0)("Estación").ToString

            If ds.Tables(0).Rows(0)("Foto1").ToString = "" Then
                XtraMessageBox.Show("No hay evidencia")
            Else
                Evidencia1.Image = Base64ToImage(ds.Tables(0).Rows(0)("Foto1").ToString)
            End If
            If ds.Tables(0).Rows(0)("Foto2").ToString = "" Then
                XtraMessageBox.Show("No hay evidencia 2")
            Else
                Evidencia2.Image = Base64ToImage(ds.Tables(0).Rows(0)("Foto2").ToString)
            End If
            If ds.Tables(0).Rows(0)("Foto3").ToString = "" Then
                XtraMessageBox.Show("No hay evidencia 3")
            Else
                Evidencia3.Image = Base64ToImage(ds.Tables(0).Rows(0)("Foto3").ToString)
            End If
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try

    End Sub
    Public Function Base64ToImage(ByVal base64String As String) As Image
        Dim imageBytes As Byte() = Convert.FromBase64String(base64String)
        Using ms = New MemoryStream(imageBytes, 0, imageBytes.Length)
            Dim image As Image = image.FromStream(ms, True)
            Return image
        End Using
    End Function
    Private Sub txtOrdenCompra_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtBusqueda.KeyPress
        Try
            If e.KeyChar = Convert.ToChar(Keys.Enter) Then
                Dim pOrdenCompra As String
                Dim pStatus As String

                If String.IsNullOrEmpty(TxtBusqueda.Text) Then
                    pOrdenCompra = "@"
                    pStatus = "LIBERADA"
                Else
                    pOrdenCompra = TxtBusqueda.Text
                    pStatus = "@"
                End If


                LimpiarGrids()
                CargaGridOrdenes(nuevo.ConsultaReciboCompra(pOrdenCompra, pStatus, My.Settings("Estacion"), DatosTemporales.Usuario))

                Dim ordenCompra = TxtBusqueda.Text
                cargarOCAsociadas(ordenCompra)
            End If

        Catch ex As Exception
            XtraMessageBox.Show("Error: " + ex.Message, "AXC")
        End Try
    End Sub

    Private Sub FrmMonitorRecepcion_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        RedibujaGrids()
    End Sub


#End Region

#Region "METODOS"

    Sub CargaGridOrdenes(ByVal ds As DataSet)

        Try
            DgvResultado.DataSource = ds.Tables(1)
            DgvViewResultado.BestFitColumns()
        Catch ex As Exception
            XtraMessageBox.Show("Error: " + ex.Message, "AXC")
        End Try
    End Sub

    Sub CargaGridDetalle(ByVal ds As DataSet)
        Try
            DgvDetalleOrden.DataSource = ds.Tables(1)
            DgvViewDetalleOrden.Columns("Orden de Compra").Visible = False
            DgvViewDetalleOrden.Columns("Revisión").Visible = False
            DgvViewDetalleOrden.BestFitColumns()
        Catch ex As Exception
            XtraMessageBox.Show("Error: " + ex.Message, "AXC")
        End Try
    End Sub

    Sub CargaGridPorValidarCalidad(ByVal ds As DataSet)

        Try
            DgvPorValidarCalidad.DataSource = ds.Tables(1)

            DgvViewPorValidarCalidad.Columns("IdPallet").Visible = False
            DgvViewPorValidarCalidad.Columns("Revisión").Visible = False
            DgvViewPorValidarCalidad.BestFitColumns()
        Catch ex As Exception
            XtraMessageBox.Show("Error: " + ex.Message, "AXC")
        End Try
    End Sub

    Sub CargaGridPorValidarAlmacen(ByVal ds As DataSet)

        Try
            DgvPorValidarAlmacen.DataSource = ds.Tables(1)

            DgvViewPorValidarAlmacen.Columns("IdPallet").Visible = False
            DgvViewPorValidarAlmacen.Columns("Revisión").Visible = False
            DgvViewPorValidarAlmacen.BestFitColumns()
        Catch ex As Exception
            XtraMessageBox.Show("Error: " + ex.Message, "AXC")
        End Try
    End Sub

    Sub CargaGridSinColocar(ByVal ds As DataSet)

        Try
            DgvSinColocar.DataSource = ds.Tables(1)

            DgvViewSinColocar.Columns("IdPallet").Visible = False
            DgvViewSinColocar.Columns("Revisión").Visible = False
            DgvViewSinColocar.BestFitColumns()
        Catch ex As Exception
            XtraMessageBox.Show("Error: " + ex.Message, "AXC")
        End Try
    End Sub
    Sub CargaGridAlmacen(ByVal ds As DataSet)

        Try
            DgvAlmacen.DataSource = ds.Tables(1)

            DgvViewAlmacen.Columns("IdPallet").Visible = False
            DgvViewAlmacen.Columns("Revisión").Visible = False
            DgvViewAlmacen.BestFitColumns()
        Catch ex As Exception
            XtraMessageBox.Show("Error: " + ex.Message, "AXC")
        End Try
    End Sub

    Public Sub LimpiarGrids()
        DgvResultado.DataSource = Nothing
        DgvDetalleOrden.DataSource = Nothing
        DgvSinColocar.DataSource = Nothing
        DgvAlmacen.DataSource = Nothing
        DgvPorValidarCalidad.DataSource = Nothing



    End Sub

    Private Sub DgvViewResultado_DoubleClick(sender As Object, e As EventArgs) Handles DgvViewResultado.DoubleClick
        Try

            If DgvViewResultado.RowCount <= 0 Then
                Exit Sub
            End If
            Dim view As ColumnView = CType(DgvResultado.MainView, ColumnView)

            Dim selectedRowHandles As Integer() = view.GetSelectedRows

            Dim ordenCompra As String = view.GetRowCellValue(selectedRowHandles(0), "Orden de Compra")
            Dim reciboCompra As Integer = CInt(view.GetRowCellValue(selectedRowHandles(0), "IdRecibo"))

            TxtBusqueda.Text = ordenCompra
            CargaGridDetalle(nuevo.ConsutaReciboCompraDet(reciboCompra, ordenCompra, My.Settings("Estacion"), DatosTemporales.Usuario))

            CargaGridPorValidarCalidad(nuevo.ConsultaPalletPorStatus(reciboCompra, ordenCompra, "PENDIENTE VALIDAR CALIDAD", My.Settings("Estacion"), DatosTemporales.Usuario))
            CargaGridPorValidarAlmacen(nuevo.ConsultaPalletPorStatus(reciboCompra, ordenCompra, "PENDIENTE VALIDAR ALMACÉN", My.Settings("Estacion"), DatosTemporales.Usuario))
            CargaGridSinColocar(nuevo.ConsultaPalletPorStatus(reciboCompra, ordenCompra, "SIN COLOCAR", My.Settings("Estacion"), DatosTemporales.Usuario))
            CargaGridAlmacen(nuevo.ConsultaPalletPorStatus(reciboCompra, ordenCompra, "COLOCADO DISPONIBLE", My.Settings("Estacion"), DatosTemporales.Usuario))

            pOrdenCompra = view.GetRowCellValue(selectedRowHandles(0), "Orden de Compra").ToString

            cargarOCAsociadas(ordenCompra)

        Catch ex As Exception
            XtraMessageBox.Show("Error: " + ex.Message, "AXC")
        End Try
    End Sub

    Private Sub FrmMonitorRecepcion_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose(True)
    End Sub

    Private Sub btnCierreParcial_Click(sender As Object, e As EventArgs) Handles btnCierreParcial.Click
        Try
            If String.IsNullOrEmpty(pOrdenCompra) Then
                XtraMessageBox.Show("Seleccionar una orden de compra", "Información", MessageBoxButtons.OK)
                Return
            End If

            If XtraMessageBox.Show("¿Deseas cerrar la orden de compra?", "Confirmación", MessageBoxButtons.YesNo) <> DialogResult.Yes Then
                Return
            End If

            CierreParcial(pOrdenCompra)
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub CierreParcial(ByVal prmOrdenCompra As String)
        Try
            Dim pResultado As New CResultado
            Dim Cls As New ClsOrdenCompra

            Cursor.Current = Cursors.WaitCursor
            pResultado = Cls.CierreParcial(prmOrdenCompra, My.Settings.Estacion, DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                Return
            End If

            XtraMessageBox.Show("Orden de compra cerrada con éxito")

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub RedibujaGrids()
        Dim tamaño = TabPane1.Size
        Dim espaciosH = 30
        Dim espaciosW = 20
        Dim tamañoHCadaControl = (tamaño.Height - (espaciosH * 2)) / 2
        Dim tamañoWCadaControl = (tamaño.Width - (espaciosW * 2))

        'page1
        GroupControl1.Width = tamañoWCadaControl
        GroupControl1.Height = tamañoHCadaControl

        GroupControl5.Width = tamañoWCadaControl
        GroupControl5.Height = tamañoHCadaControl - 10

        'page2
        GroupControl2.Width = tamañoWCadaControl
        GroupControl2.Height = tamañoHCadaControl

        GroupControl3.Width = tamañoWCadaControl
        GroupControl3.Height = tamañoHCadaControl - 10

        'page1
        Dim localizacion As Point = New Point(espaciosW, espaciosH - 15)
        GroupControl1.Location = localizacion
        localizacion = New Point(espaciosW, espaciosH + tamañoHCadaControl)
        GroupControl5.Location = localizacion
        'page2
        localizacion = New Point(espaciosW, espaciosH - 15)
        GroupControl2.Location = localizacion
        localizacion = New Point(espaciosW, espaciosH + tamañoHCadaControl)
        GroupControl3.Location = localizacion
        Me.Refresh()
    End Sub

    Private Sub TabPane1_SizeChanged(sender As Object, e As EventArgs) Handles TabPane1.SizeChanged
        RedibujaGrids()
    End Sub

    Private Sub TabPane1_Resize(sender As Object, e As EventArgs) Handles TabPane1.Resize
        RedibujaGrids()
    End Sub

    Private Sub TabPane1_ControlLoaded(sender As Object, e As DevExpress.XtraBars.Navigation.DeferredControlLoadEventArgs) Handles TabPane1.ControlLoaded
        RedibujaGrids()
    End Sub


    Private Sub cargarOCAsociadas(prmOC$)
        Try
            Dim pResultado As New CResultado
            Dim Cls As New clsConsOC

            Cursor.Current = Cursors.WaitCursor
            pResultado = Cls.OrdenesCompraAsociadasCons(prmOC, My.Settings.Estacion, DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                If pResultado.Texto = "No existe la orden de compra" Then
                    DgvOCAsociadas.DataSource = Nothing
                Else
                    XtraMessageBox.Show(pResultado.Texto, "AXC")
                End If
                Return
            End If
            DgvOCAsociadas.DataSource = pResultado.Tabla


        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub LabelControl3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextEdit1_EditValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub LabelControl13_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtContenedor_EditValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub LabelControl2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtIdProveedor_EditValueChanged(sender As Object, e As EventArgs)

    End Sub




#End Region
End Class