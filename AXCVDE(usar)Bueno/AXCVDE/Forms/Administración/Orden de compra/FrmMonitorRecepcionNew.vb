Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraPivotGrid
Imports System.Drawing
Imports System.IO

Public Class FrmMonitorRecepcionNew
#Region "VARIABLES"
    Dim nuevo As New ClsMaterialRecibido
    Public pOrdenCompra As String = ""
#End Region

#Region "EVENTOS"

    Private Sub FrmMonitoreoRecepcion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            CargaGridOrdenes(nuevo.ConsultaReciboCompra("@", "@", My.Settings("Estacion"), DatosTemporales.Usuario))
            RedibujaGrids()
            'Evidencia2.Width = 410
            ''Evidencia2.Height = Evidencia1.Height
            'Evidencia3.Width = 410
            'Evidencia3.Height = Evidencia1.Height

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
            'Consultaimagen(pOrdenCompra)
        Catch ex As Exception
            XtraMessageBox.Show("Error: " + ex.Message, "AXC")
        End Try
    End Sub

    Private Sub txtOrdenCompra_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtBusqueda.KeyPress
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


        End If
    End Sub

    Private Sub FrmMonitorRecepcionNew_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        RedibujaGrids()
    End Sub



#End Region

#Region "METODOS"



    Private Sub Consultaimagen(prmBusqueda As String)
        Try
            Evidencia1.Image = Nothing
            Evidencia2.Image = Nothing
            Evidencia3.Image = Nothing

            Dim pResultado As New CResultado
            Dim Cls As New clsConsOC

            Cursor.Current = Cursors.WaitCursor
            pResultado = Cls.Cargarevidencia(prmBusqueda)
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



            Dim imagen As String = "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"


            If ds.Tables(0).Rows(0)("Foto1").ToString = "" Then
                XtraMessageBox.Show("No hay evidencia")
                Evidencia1.Image = Base64ToImage(imagen)
            Else

                Evidencia1.Image = Base64ToImage(ds.Tables(0).Rows(0)("Foto1").ToString)
            End If
            If ds.Tables(0).Rows(0)("Foto2").ToString = "" Then
                XtraMessageBox.Show("No hay evidencia 2")
                Evidencia2.Image = Base64ToImage(imagen)
            Else

                Evidencia2.Image = Base64ToImage(ds.Tables(0).Rows(0)("Foto2").ToString)
            End If
            If ds.Tables(0).Rows(0)("Foto3").ToString = "" Then
                XtraMessageBox.Show("No hay evidencia 3")
                Evidencia3.Image = Base64ToImage(imagen)
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
            'DgvViewDetalleOrden.Columns("Orden de Compra").Visible = False
            DgvViewDetalleOrden.Columns("Revisión").Visible = False

            DgvViewDetalleOrden.BestFitColumns()


        Catch ex As Exception
            XtraMessageBox.Show("Error: " + ex.Message, "AXC")
        End Try
    End Sub

    Private Sub DgvViewDetalleOrden_CustomDrawCell(sender As Object, e As RowCellCustomDrawEventArgs) Handles DgvViewDetalleOrden.CustomDrawCell
        Try
            Dim View As GridView = sender
            If DgvViewDetalleOrden.RowCount > 0 Then
                Dim CantidadP As String = ""
                CantidadP = View.GetRowCellDisplayText(e.RowHandle, View.Columns("Cantidad Pendiente"))
                If CantidadP = "" Then
                    CantidadP = 0
                End If
                If CantidadP = 0 Then
                    If e.Column.CustomizationSearchCaption = "Estado" Then
                        e.Appearance.BackColor = Color.LightSeaGreen
                    End If
                End If
                DgvViewDetalleOrden.FocusInvalidRow()
            End If
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
        DvgNoOrden.DataSource = Nothing



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
            Consultaimagen(pOrdenCompra)
            Dim pResultado As New CResultado
            Dim Cls As New clsConsOC

            Cursor.Current = Cursors.WaitCursor
            pResultado = Cls.OrdenesCompraAsociadasCons(ordenCompra, My.Settings.Estacion, DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                Return
            End If
            DvgNoOrden.DataSource = pResultado.Tabla
            DvgViewDetalleNoOrden.BestFitColumns()

        Catch ex As Exception
            XtraMessageBox.Show("Error: " + ex.Message, "AXC")
        End Try
    End Sub

    Private Sub FrmMonitorRecepcionNew_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
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








#End Region
End Class