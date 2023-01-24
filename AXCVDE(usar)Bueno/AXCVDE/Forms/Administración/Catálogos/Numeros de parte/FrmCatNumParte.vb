Imports System.Drawing.Drawing2D
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Base

Public Class FrmCatNumParte
#Region "VARIABLES"
    Public pNumeroSeleccionada As String = ""

    Public pNumParte As String
    Public pIdNumParte As Int64
    Public pAccion As Integer
    Public dt As New DataTable
    Public ds As New DataSet
    Public pIdImagenResultado As String
    Public pIdImagenSeleccionada As Integer
    Public pImagenBytes As System.IO.MemoryStream
#End Region

#Region "EVENTOS"
    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        Try
            Accion()
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

    Private Sub DgvResultado_Click(sender As Object, e As EventArgs) Handles DgvResultado.Click

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

    Private Sub ListaClientes(prmBusqueda As String)
        Try
            Dim pResultado As New CResultado
            Dim Cls As New clsCliente

            Cursor.Current = Cursors.WaitCursor
            pResultado = Cls.ResultadoListaClientes(prmBusqueda, My.Settings.Estacion, DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                Return
            End If
            Dim dt As New DataTable
            Dim ds As New DataSet

            dt = pResultado.Tabla
            ds.Tables.Add(dt)


            cmbCliente.Properties.DataSource = dt
            cmbCliente.Properties.DisplayMember = "Cliente"
            cmbCliente.Properties.ValueMember = "IdCliente"
            cmbCliente.Properties.BestFitMode = BestFitMode.BestFitResizePopup


        Catch ex As Exception
            XtraMessageBox.Show(ex.Message.ToString, "Error", MessageBoxButtons.OK)
        End Try
    End Sub
    Private Sub ResultadoLista(prmBusqueda As String)
        Try
            DgvResultado.DataSource = Nothing

            Dim pResultado As New CResultado
            Dim Cls As New clsNumParte

            Cursor.Current = Cursors.WaitCursor
            pResultado = Cls.ResultadoListaNumParte(prmBusqueda, My.Settings.Estacion, DatosTemporales.Usuario)
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

            If dt.Rows.Count < 1 Then
                XtraMessageBox.Show("Sin información")
                DgvResultado.DataSource = Nothing
                Return
            End If

            DgvResultado.DataSource = dt

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub Accion()
        Try

            LlenaComboUM()
            If pAccion = 1 Then
                ConfigEditarOEliminar()
                ListaDetalle(pNumParte)
                ConsultarTotalImagenes(pNumParte)
                ConsultarImagen(pNumParte, ObtieneIdImagen(1))
            Else
                ConfigAgregar()
            End If
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ListaDetalle(ByVal prmNumParte As String)
        Try
            Dim pResultado As New CResultado
            Dim Cls As New clsNumParte

            Cursor.Current = Cursors.WaitCursor
            pResultado = Cls.ResultadoListaNumParte(prmNumParte, My.Settings.Estacion, DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                Return
            End If
            Dim dt As New DataTable
            Dim ds As New DataSet

            dt = pResultado.Tabla
            ds.Tables.Add(dt)
            TxtNumParte.Text = ds.Tables(0).Rows(0)("Artículo").ToString
            TxtDesc1.Text = ds.Tables(0).Rows(0)("Descripcion").ToString
            txtUPC.Text = ds.Tables(0).Rows(0)("UPC").ToString
            txtCategoria.Text = ds.Tables(0).Rows(0)("Categoria").ToString
            txtDescCategoria.Text = ds.Tables(0).Rows(0)("DescCategoria").ToString
            cmbCliente.EditValue = ds.Tables(0).Rows(0)("IdCliente").ToString
            CmbUM.Text = ds.Tables(0).Rows(0)("UnidadMedida").ToString


        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub LlenaComboUM()
        Dim UM = New List(Of String)()
        UM.Add("EA")
        UM.Add("KG")
        UM.Add("G")
        UM.Add("LTS")
        UM.Add("LBS")
        CmbUM.Properties.DataSource = UM
    End Sub

    Sub ConfigAgregar()
        BtnGuardar.Visible = True
        BtnCancelar.Visible = True
        BtnEliminar.Visible = False
        BtnEditar.Visible = False
        TxtNumParte.Enabled = True
        TxtNumParte.Text = ""
        TxtNumParte.Select()
        TxtDesc1.Enabled = True
        TxtDesc1.Text = ""
        txtCategoria.Enabled = True
        txtCategoria.Text = ""
        txtDescCategoria.Enabled = True
        txtDescCategoria.Text = ""
        txtUPC.Enabled = True
        txtUPC.Text = ""
        CmbUM.Enabled = True
        cmbCliente.Enabled = True
        BtnNuevo.Enabled = False
    End Sub

    Sub ConfigCancelar()
        TxtNumParte.Enabled = False
        TxtNumParte.Text = ""
        TxtDesc1.Enabled = False
        TxtDesc1.Text = ""
        txtCategoria.Enabled = False
        txtCategoria.Text = ""
        txtDescCategoria.Enabled = False
        txtDescCategoria.Text = ""
        txtUPC.Enabled = False
        txtUPC.Text = ""
        CmbUM.Enabled = False
        cmbCliente.Enabled = False

        BtnNuevo.Enabled = True
        BtnCancelar.Visible = False
        BtnEditar.Visible = False
        BtnGuardar.Visible = False
    End Sub

    Sub ConfigEditarOEliminar()
        BtnNuevo.Enabled = False
        TxtNumParte.Enabled = True
        TxtNumParte.Select()
        TxtDesc1.Enabled = True
        txtCategoria.Enabled = True
        txtDescCategoria.Enabled = True
        txtUPC.Enabled = True
        CmbUM.Enabled = True
        cmbCliente.Enabled = True
        BtnEditar.Visible = True
        BtnCancelar.Visible = True
        BtnEliminar.Visible = False
    End Sub

    ''Valores de prmAccion
    'Load = 1
    'Primer = 2
    'Atras = 3
    'Adelante = 4
    'Ultimo = 5

    Public Function ObtieneIdImagen(ByVal prmAccion As Integer) As String
        Dim VMaximo As Integer = 0
        Dim VMinimo As Integer = Integer.MaxValue
        Dim pAnterior As Integer = 0
        Dim pSiguiente As Integer = 0

        If ds.Tables.Count = 0 Then
            Return "1"
        End If

        If prmAccion = 1 Then
            pIdImagenResultado = Microsoft.VisualBasic.Left(Microsoft.VisualBasic.Right(ds.Tables(0).Rows(0)(0).ToString, 5), 1)
        End If


        If prmAccion = 2 Or prmAccion = 5 Then
            If ds.Tables(0).Rows.Count > 0 Then
                For Each Row As DataRow In ds.Tables(0).Rows

                    Dim valor As Integer = Convert.ToInt32(Microsoft.VisualBasic.Left(Microsoft.VisualBasic.Right(Row("Nombre").ToString, 5), 1))
                    If valor > VMaximo Then
                        VMaximo = valor
                    End If
                    If valor < VMinimo Then
                        VMinimo = valor
                    End If
                Next
            End If
            If prmAccion = 2 Then
                pIdImagenResultado = CType(VMinimo, String)
            Else
                pIdImagenResultado = CType(VMaximo, String)
            End If
        End If


        If prmAccion = 3 Or prmAccion = 4 Then
            If ds.Tables(0).Rows.Count > 0 Then
                For Each Row As DataRow In ds.Tables(0).Rows
                    Dim pValorAnterior As Integer
                    Dim Pbandera As Boolean

                    Dim valor As Integer = Convert.ToInt32(Microsoft.VisualBasic.Left(Microsoft.VisualBasic.Right(Row("Nombre").ToString, 5), 1))
                    If valor = pIdImagenSeleccionada Then
                        pAnterior = pValorAnterior
                        Pbandera = True
                    End If

                    pValorAnterior = Convert.ToInt32(Microsoft.VisualBasic.Left(Microsoft.VisualBasic.Right(Row("Nombre").ToString.ToString, 5), 1))

                    If Pbandera Then
                        pSiguiente = valor
                        If pSiguiente = pIdImagenSeleccionada Then

                        Else
                            Pbandera = False
                            Exit For
                        End If

                    End If

                Next
                If prmAccion = 3 Then
                    pIdImagenResultado = CType(pAnterior, String)
                Else
                    pIdImagenResultado = CType(pSiguiente, String)
                End If
            End If
        End If

        Return pIdImagenResultado
    End Function

    Private Sub ConsultarImagen(ByVal prmNumParte As String, ByVal prmIdImagen As String)
        Try
            If Not CInt(prmIdImagen) <> 0 Then

                Return
            End If
            Dim CRespuesta As New CResultado
            Dim pResultado As New wsAXC.CResultado
            Dim ws As New wsAXC.wsAXCMP
            Dim pUrl As String = My.Settings("AXCVDE_wsAXC_wsAXCMP")
            Dim Posicion As Integer = pUrl.ToString.IndexOf("/wsAXCVDE")
            Dim IP As String = ""

            If ds.Tables.Count = 0 Then
                PictureBox1.Image = My.Resources.s_img
            Else
                IP = pUrl.ToString.Substring(0, Posicion)
                pUrl = IP & "/wsAXCVDE/wsaxcmp.asmx"
                ws.Url = pUrl
                pResultado = ws.WM_ConsultaImagenNumParte(prmNumParte, prmIdImagen, My.Settings("Estacion"), DatosTemporales.Usuario)

                If Not pResultado.Estado Then
                    MsgBox(pResultado.Texto)
                    Return
                End If

                Dim pByte As Byte()

                pByte = pResultado.Objeto
                If pByte.Length = 0 Then
                    PictureBox1.Image = My.Resources.s_img
                Else
                    Dim ImgBytes As New System.IO.MemoryStream(pByte)
                    PictureBox1.Image = Image.FromStream(ImgBytes)

                    SetImage(PictureBox1)
                    pIdImagenSeleccionada = CInt(prmIdImagen)
                    pImagenBytes = ImgBytes
                End If
            End If



        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ConsultarTotalImagenes(ByVal prmNumParte As String)
        Try
            Dim CRespuesta As New CResultado
            Dim pResultado As New wsAXC.CResultado
            Dim ws As New wsAXC.wsAXCMP

            Dim pUrl As String = My.Settings("AXCVDE_wsAXC_wsAXCMP")

            Dim Posicion As Integer = pUrl.ToString.IndexOf("/wsAXCVDE")
            Dim IP As String = ""
            IP = pUrl.ToString.Substring(0, Posicion)
            pUrl = IP & "/wsAXCVDE/wsaxcmp.asmx"
            ws.Url = pUrl
            pResultado = ws.WM_ConsultaImagenNumParte(prmNumParte, "", My.Settings("Estacion"), DatosTemporales.Usuario)

            If Not pResultado.Estado Then
            Else
                dt = pResultado.Tabla
                dt.TableName = "Imagenes"
                ds.Tables.Add(dt)


                If ds.Tables(0).Rows.Count <= 0 Then
                    ds.Tables.Clear()

                End If

            End If





        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub SetImage(ByVal pb As PictureBox)
        Try
            'create a temp image
            Dim img As Image = pb.Image

            'calculate the size of the image
            Dim imgSize As Size = GenerateImageDimensions(img.Width, img.Height, Me.PictureBox1.Width, Me.PictureBox1.Height)

            'create a new Bitmap with the proper dimensions
            Dim finalImg As New Bitmap(img, imgSize.Width, imgSize.Height)

            'create a new Graphics object from the image
            Dim gfx As Graphics = Graphics.FromImage(img)

            'clean up the image (take care of any image loss from resizing)
            gfx.InterpolationMode = InterpolationMode.HighQualityBicubic

            'empty the PictureBox
            pb.Image = Nothing

            'center the new image
            PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage

            'set the new image
            PictureBox1.Image = finalImg
        Catch e As System.Exception
            XtraMessageBox.Show(e.Message)
        End Try
    End Sub

    Public Function GenerateImageDimensions(ByVal currW As Integer, ByVal currH As Integer, ByVal destW As Integer, ByVal destH As Integer) As Size
        'double to hold the final multiplier to use when scaling the image
        Dim multiplier As Double = 0

        'string for holding layout
        Dim layout As String

        'determine if it's Portrait or Landscape
        If currH > currW Then
            layout = "portrait"
        Else
            layout = "landscape"
        End If

        Select Case layout.ToLower()
            Case "portrait"
                'calculate multiplier on heights
                If destH > destW Then
                    multiplier = CDbl(destW) / CDbl(currW)
                Else

                    multiplier = CDbl(destH) / CDbl(currH)
                End If
                Exit Select
            Case "landscape"
                'calculate multiplier on widths
                If destH > destW Then
                    multiplier = CDbl(destW) / CDbl(currW)
                Else

                    multiplier = CDbl(destH) / CDbl(currH)
                End If
                Exit Select
        End Select

        'return the new image dimensions
        Return New Size(CInt((currW * (multiplier * 0.8))), CInt((currH * (multiplier * 0.8))))
    End Function

    Private Sub GuardarImagen(ByVal prmNumparte As String)
        Try
            Dim openFileDialog1 As New OpenFileDialog()
            Dim dialogo As New DialogResult
            Dim Imagen As Object
            Dim pByte As Byte()

            openFileDialog1.Filter = "Imagen (JPG,BMP,PNG)|*.JPG;*.BMP;*.PNG|All files (*.*)|*.*"
            openFileDialog1.FilterIndex = 1
            openFileDialog1.RestoreDirectory = True
            openFileDialog1.Title = "Seleccionar imagen para guardar"
            dialogo = openFileDialog1.ShowDialog()
            If (dialogo = DialogResult.OK) Then
                Imagen = System.IO.File.ReadAllBytes(openFileDialog1.FileName)

                pByte = CType(Imagen, Byte())
                If pByte.Length = 0 Then
                    XtraMessageBox.Show("Error al convertir la imagen")
                    Return
                End If

                Dim CRespuesta As New CResultado
                Dim pResultado As New wsAXC.CResultado
                Dim ws As New wsAXC.wsAXCMP
                Dim pUrl As String = CType(My.Settings("AXCVDE_wsAXC_wsAXCMP"), String)
                Dim Posicion As Integer = pUrl.ToString.IndexOf("/wsAXCVDE")
                Dim IP As String = ""
                Dim pUltimaImagen As Integer = 0

                If ds.Tables.Count > 0 Then
                    If ds.Tables(0).Rows.Count > 0 Then
                        For Each Row As DataRow In ds.Tables(0).Rows

                            Dim valor As Integer = Convert.ToInt32(Microsoft.VisualBasic.Left(Microsoft.VisualBasic.Right(Row("Nombre").ToString, 5), 1))
                            If valor > pUltimaImagen Then
                                pUltimaImagen = valor
                            End If
                        Next
                    End If
                End If



                pUltimaImagen = pUltimaImagen + 1

                IP = pUrl.ToString.Substring(0, Posicion)
                pUrl = IP & "/wsAXCVDE/wsaxcmp.asmx"
                ws.Url = pUrl
                pResultado = ws.WM_GuardaFoto(prmNumparte, pUltimaImagen, Imagen, CType(My.Settings("Estacion"), String), DatosTemporales.Usuario)

                If Not pResultado.Estado Then
                    XtraMessageBox.Show(pResultado.Texto)
                    Return
                End If

                XtraMessageBox.Show("Imagen agregada con éxito")
                dt = New DataTable
                ds = New DataSet
                ConsultarTotalImagenes(pNumParte)
                pIdImagenSeleccionada = pUltimaImagen
                ConsultarImagen(pNumParte, ObtieneIdImagen(5))


            End If



        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Agregar()
        Try
            Dim pResultado As New CResultado
            Dim Cls As New clsNumParte

            Cursor.Current = Cursors.WaitCursor
            pResultado = Cls.Agregar(TxtNumParte.Text, TxtDesc1.Text, txtUPC.Text, txtCategoria.Text, txtDescCategoria.Text, cmbCliente.Text, CmbUM.Text, My.Settings.Estacion, DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                Return
            End If

            XtraMessageBox.Show("Artículo creado con éxito")
            pNumParte = TxtNumParte.Text
            ListaDetalle(pNumParte)
            ConsultarTotalImagenes(pNumParte)
            ConsultarImagen(pNumParte, ObtieneIdImagen(1))
            ConfigCancelar()


        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Editar()
        Try
            Dim pResultado As New CResultado
            Dim Cls As New clsNumParte

            Cursor.Current = Cursors.WaitCursor
            pResultado = Cls.Editar(pIdNumParte, TxtNumParte.Text, TxtDesc1.Text, txtUPC.Text, txtCategoria.Text, txtDescCategoria.Text, cmbCliente.Text, CmbUM.Text, My.Settings.Estacion, DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                Return
            End If

            XtraMessageBox.Show("Artículo editado con éxito")
            pNumParte = TxtNumParte.Text
            ListaDetalle(pNumParte)
            ConsultarTotalImagenes(pNumParte)
            ConsultarImagen(pNumParte, ObtieneIdImagen(1))
            ConfigCancelar()
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub FrmCatNumParte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ListaClientes("@")
            cmbCliente.EditValue = 0
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        ConfigCancelar()

    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click

    End Sub

    Private Sub GridView1_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GridView1.RowClick
        Try
            If IsNothing(DgvResultado.DataSource) Then
                Return
            End If

            ds = New DataSet
            dt = New DataTable


            Dim view As ColumnView = CType(DgvResultado.MainView, ColumnView)
            Dim selectedRowHandles As Integer() = view.GetSelectedRows()

            pNumeroSeleccionada = view.GetRowCellDisplayText(selectedRowHandles(0), view.Columns("Artículo"))

            pNumParte = pNumeroSeleccionada
            pAccion = 1
            Accion()



        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnImagenAdelante_Click(sender As Object, e As EventArgs) Handles BtnImagenAdelante.Click
        Try
            ConsultarImagen(pNumParte, ObtieneIdImagen(4))
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnPrimerImagen_Click(sender As Object, e As EventArgs) Handles BtnPrimerImagen.Click
        Try
            ConsultarImagen(pNumParte, ObtieneIdImagen(2))
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnImagenAtras_Click(sender As Object, e As EventArgs) Handles BtnImagenAtras.Click
        Try
            ConsultarImagen(pNumParte, ObtieneIdImagen(3))
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnUltimaImagen_Click(sender As Object, e As EventArgs) Handles BtnUltimaImagen.Click
        Try
            ConsultarImagen(pNumParte, ObtieneIdImagen(5))
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnAgregarImagen_Click(sender As Object, e As EventArgs) Handles BtnAgregarImagen.Click
        Try
            GuardarImagen(pNumParte)
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub PictureBox1_DoubleClick(sender As Object, e As EventArgs) Handles PictureBox1.DoubleClick
        Try
            FrmVisorImagen.pImagen = pImagenBytes
            FrmVisorImagen.ShowDialog()
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Try
            If String.IsNullOrEmpty(TxtNumParte.Text) Then
                XtraMessageBox.Show("El campo [Artículo] no puede estar vacío", "Información", MessageBoxButtons.OK)
                TxtNumParte.Select()
                Return
            End If

            If String.IsNullOrEmpty(TxtDesc1.Text) Then
                XtraMessageBox.Show("El Campo [Descripción] no puede estar vacío", "Información", MessageBoxButtons.OK)
                TxtDesc1.Select()
                Return
            End If

            If String.IsNullOrEmpty(txtCategoria.Text) Then
                XtraMessageBox.Show("El campo [Categoría]", "Información", MessageBoxButtons.OK)
                txtCategoria.Select()
                Return
            End If

            If String.IsNullOrEmpty(cmbCliente.Text) Then
                XtraMessageBox.Show("Seleccionar un cliente", "Información", MessageBoxButtons.OK)
                cmbCliente.Select()
                Return
            End If

            If XtraMessageBox.Show("¿Desea agregar el artículo [" + TxtNumParte.Text + "] con el cliente [" + cmbCliente.Text + "] al sistema?", "Confirmación", MessageBoxButtons.YesNo) <> DialogResult.Yes Then
                Return
            End If

            Agregar()

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        Try
            If String.IsNullOrEmpty(TxtNumParte.Text) Then
                XtraMessageBox.Show("El campo [Artículo] no puede estar vacío", "Información", MessageBoxButtons.OK)
                TxtNumParte.Select()
                Return
            End If

            If String.IsNullOrEmpty(TxtDesc1.Text) Then
                XtraMessageBox.Show("El Campo [Descripción] no puede estar vacío", "Información", MessageBoxButtons.OK)
                TxtDesc1.Select()
                Return
            End If

            If String.IsNullOrEmpty(txtCategoria.Text) Then
                XtraMessageBox.Show("El campo [Categoría]", "Información", MessageBoxButtons.OK)
                txtCategoria.Select()
                Return
            End If

            If String.IsNullOrEmpty(cmbCliente.Text) Then
                XtraMessageBox.Show("Seleccionar un cliente", "Información", MessageBoxButtons.OK)
                cmbCliente.Select()
                Return
            End If

            If XtraMessageBox.Show("¿Desea editar el artículo [" + pNumParte + "] en el sistema?", "Confirmación", MessageBoxButtons.YesNo) <> DialogResult.Yes Then
                Return
            End If

            Editar()

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub


#End Region
End Class