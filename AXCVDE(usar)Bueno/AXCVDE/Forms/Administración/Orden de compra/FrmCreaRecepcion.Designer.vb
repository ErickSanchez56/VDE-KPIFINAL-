<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCreaRecepcion
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCreaRecepcion))
        Me.btnRecepciones = New DevExpress.XtraEditors.SimpleButton()
        Me.SeparatorControl1 = New DevExpress.XtraEditors.SeparatorControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtOrdenCompra = New DevExpress.XtraEditors.TextEdit()
        Me.txtDireccionCliente = New DevExpress.XtraEditors.TextEdit()
        Me.btnBuscar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnNuevo = New DevExpress.XtraEditors.SimpleButton()
        Me.TxtCaracteristica = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCantidad = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.txtDescripcion = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.cmbNumParte = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.NumParte = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DNumParte1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnAgregarNP = New DevExpress.XtraEditors.SimpleButton()
        Me.TxtEditaCaracteristica = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.btnEliminar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnEditar = New DevExpress.XtraEditors.SimpleButton()
        Me.txtEditaCantidad = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl()
        Me.txtPartida = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl()
        Me.txtNumParte = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl()
        Me.txtPartidaOC = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.grdDetalle = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.cmbCliente = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.SeparatorControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOrdenCompra.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDireccionCliente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtCaracteristica.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCantidad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescripcion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbNumParte.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtEditaCaracteristica.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEditaCantidad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPartida.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNumParte.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPartidaOC.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbCliente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnRecepciones
        '
        Me.btnRecepciones.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRecepciones.Appearance.Options.UseFont = True
        Me.btnRecepciones.Location = New System.Drawing.Point(31, 535)
        Me.btnRecepciones.Name = "btnRecepciones"
        Me.btnRecepciones.Size = New System.Drawing.Size(237, 34)
        Me.btnRecepciones.TabIndex = 64
        Me.btnRecepciones.Text = "Recepciones programadas"
        Me.btnRecepciones.Visible = False
        '
        'SeparatorControl1
        '
        Me.SeparatorControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SeparatorControl1.AutoSizeMode = True
        Me.SeparatorControl1.LineAlignment = DevExpress.XtraEditors.Alignment.Center
        Me.SeparatorControl1.LineOrientation = System.Windows.Forms.Orientation.Vertical
        Me.SeparatorControl1.Location = New System.Drawing.Point(351, -2)
        Me.SeparatorControl1.Name = "SeparatorControl1"
        Me.SeparatorControl1.Padding = New System.Windows.Forms.Padding(8)
        Me.SeparatorControl1.Size = New System.Drawing.Size(17, 601)
        Me.SeparatorControl1.TabIndex = 59
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(7, 109)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(84, 19)
        Me.LabelControl1.TabIndex = 45
        Me.LabelControl1.Text = "Documento:"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(23, 178)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(68, 19)
        Me.LabelControl3.TabIndex = 55
        Me.LabelControl3.Text = "Dirección:"
        '
        'txtOrdenCompra
        '
        Me.txtOrdenCompra.Location = New System.Drawing.Point(97, 106)
        Me.txtOrdenCompra.Name = "txtOrdenCompra"
        Me.txtOrdenCompra.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOrdenCompra.Properties.Appearance.Options.UseFont = True
        Me.txtOrdenCompra.Size = New System.Drawing.Size(176, 26)
        Me.txtOrdenCompra.TabIndex = 46
        '
        'txtDireccionCliente
        '
        Me.txtDireccionCliente.Enabled = False
        Me.txtDireccionCliente.Location = New System.Drawing.Point(97, 175)
        Me.txtDireccionCliente.Name = "txtDireccionCliente"
        Me.txtDireccionCliente.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccionCliente.Properties.Appearance.Options.UseFont = True
        Me.txtDireccionCliente.Size = New System.Drawing.Size(252, 26)
        Me.txtDireccionCliente.TabIndex = 57
        '
        'btnBuscar
        '
        Me.btnBuscar.ImageOptions.Image = CType(resources.GetObject("btnBuscar.ImageOptions.Image"), System.Drawing.Image)
        Me.btnBuscar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnBuscar.Location = New System.Drawing.Point(279, 102)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(32, 35)
        Me.btnBuscar.TabIndex = 48
        '
        'btnNuevo
        '
        Me.btnNuevo.ImageOptions.Image = CType(resources.GetObject("btnNuevo.ImageOptions.Image"), System.Drawing.Image)
        Me.btnNuevo.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnNuevo.Location = New System.Drawing.Point(317, 102)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(32, 35)
        Me.btnNuevo.TabIndex = 52
        '
        'TxtCaracteristica
        '
        Me.TxtCaracteristica.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtCaracteristica.Location = New System.Drawing.Point(795, 89)
        Me.TxtCaracteristica.Name = "TxtCaracteristica"
        Me.TxtCaracteristica.Size = New System.Drawing.Size(82, 20)
        Me.TxtCaracteristica.TabIndex = 67
        Me.TxtCaracteristica.Visible = False
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl8.Appearance.Options.UseFont = True
        Me.LabelControl8.Location = New System.Drawing.Point(569, 79)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(96, 19)
        Me.LabelControl8.TabIndex = 72
        Me.LabelControl8.Text = "Característica:"
        Me.LabelControl8.Visible = False
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(462, 85)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidad.Properties.Appearance.Options.UseFont = True
        Me.txtCantidad.Size = New System.Drawing.Size(95, 26)
        Me.txtCantidad.TabIndex = 66
        '
        'LabelControl12
        '
        Me.LabelControl12.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl12.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl12.Appearance.Options.UseFont = True
        Me.LabelControl12.Location = New System.Drawing.Point(391, 88)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(65, 19)
        Me.LabelControl12.TabIndex = 71
        Me.LabelControl12.Text = "Cantidad:"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Enabled = False
        Me.txtDescripcion.Location = New System.Drawing.Point(462, 48)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.Properties.Appearance.Options.UseFont = True
        Me.txtDescripcion.Size = New System.Drawing.Size(450, 26)
        Me.txtDescripcion.TabIndex = 70
        '
        'LabelControl6
        '
        Me.LabelControl6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Appearance.Options.UseFont = True
        Me.LabelControl6.Location = New System.Drawing.Point(397, 19)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(59, 19)
        Me.LabelControl6.TabIndex = 68
        Me.LabelControl6.Text = "Artículo:"
        '
        'LabelControl10
        '
        Me.LabelControl10.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl10.Appearance.Options.UseFont = True
        Me.LabelControl10.Location = New System.Drawing.Point(373, 51)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(83, 19)
        Me.LabelControl10.TabIndex = 69
        Me.LabelControl10.Text = "Descripción:"
        '
        'cmbNumParte
        '
        Me.cmbNumParte.Location = New System.Drawing.Point(462, 16)
        Me.cmbNumParte.Name = "cmbNumParte"
        Me.cmbNumParte.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbNumParte.Properties.Appearance.Options.UseFont = True
        Me.cmbNumParte.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbNumParte.Properties.AppearanceDisabled.Options.UseFont = True
        Me.cmbNumParte.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbNumParte.Properties.AppearanceDropDown.Options.UseFont = True
        Me.cmbNumParte.Properties.AppearanceFocused.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbNumParte.Properties.AppearanceFocused.Options.UseFont = True
        Me.cmbNumParte.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbNumParte.Properties.NullText = ""
        Me.cmbNumParte.Properties.PopupSizeable = False
        Me.cmbNumParte.Properties.PopupView = Me.GridLookUpEdit1View
        Me.cmbNumParte.Size = New System.Drawing.Size(450, 26)
        Me.cmbNumParte.TabIndex = 65
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.NumParte, Me.DNumParte1, Me.GridColumn8, Me.GridColumn9, Me.GridColumn10, Me.GridColumn11})
        Me.GridLookUpEdit1View.DetailHeight = 303
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'NumParte
        '
        Me.NumParte.Caption = "Artículo"
        Me.NumParte.FieldName = "Artículo"
        Me.NumParte.MinWidth = 17
        Me.NumParte.Name = "NumParte"
        Me.NumParte.Visible = True
        Me.NumParte.VisibleIndex = 0
        Me.NumParte.Width = 64
        '
        'DNumParte1
        '
        Me.DNumParte1.Caption = "Descripción"
        Me.DNumParte1.FieldName = "Descripcion"
        Me.DNumParte1.MinWidth = 17
        Me.DNumParte1.Name = "DNumParte1"
        Me.DNumParte1.Visible = True
        Me.DNumParte1.VisibleIndex = 1
        Me.DNumParte1.Width = 64
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "UPC"
        Me.GridColumn8.FieldName = "UPC"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 2
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "Categoría"
        Me.GridColumn9.FieldName = "Categoria"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 3
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "Descripción de categoría"
        Me.GridColumn10.FieldName = "DescCategoria"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 4
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "Unidad de medida"
        Me.GridColumn11.FieldName = "UnidadMedida"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 5
        '
        'btnAgregarNP
        '
        Me.btnAgregarNP.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarNP.Appearance.Options.UseFont = True
        Me.btnAgregarNP.Location = New System.Drawing.Point(759, 79)
        Me.btnAgregarNP.Name = "btnAgregarNP"
        Me.btnAgregarNP.Size = New System.Drawing.Size(153, 34)
        Me.btnAgregarNP.TabIndex = 73
        Me.btnAgregarNP.Text = "Agregar artículo"
        '
        'TxtEditaCaracteristica
        '
        Me.TxtEditaCaracteristica.Enabled = False
        Me.TxtEditaCaracteristica.Location = New System.Drawing.Point(111, 354)
        Me.TxtEditaCaracteristica.Name = "TxtEditaCaracteristica"
        Me.TxtEditaCaracteristica.Size = New System.Drawing.Size(157, 20)
        Me.TxtEditaCaracteristica.TabIndex = 87
        Me.TxtEditaCaracteristica.Visible = False
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl9.Appearance.Options.UseFont = True
        Me.LabelControl9.Location = New System.Drawing.Point(15, 357)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(84, 15)
        Me.LabelControl9.TabIndex = 86
        Me.LabelControl9.Text = "Característica:"
        Me.LabelControl9.Visible = False
        '
        'btnEliminar
        '
        Me.btnEliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEliminar.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.Appearance.Options.UseFont = True
        Me.btnEliminar.Location = New System.Drawing.Point(882, 533)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(105, 34)
        Me.btnEliminar.TabIndex = 85
        Me.btnEliminar.Text = "Eliminar"
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGuardar.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Appearance.Options.UseFont = True
        Me.btnGuardar.Location = New System.Drawing.Point(771, 533)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(105, 34)
        Me.btnGuardar.TabIndex = 84
        Me.btnGuardar.Text = "Guardar"
        '
        'btnEditar
        '
        Me.btnEditar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEditar.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditar.Appearance.Options.UseFont = True
        Me.btnEditar.Location = New System.Drawing.Point(660, 533)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(105, 34)
        Me.btnEditar.TabIndex = 83
        Me.btnEditar.Text = "Editar"
        '
        'txtEditaCantidad
        '
        Me.txtEditaCantidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEditaCantidad.Enabled = False
        Me.txtEditaCantidad.Location = New System.Drawing.Point(548, 530)
        Me.txtEditaCantidad.Name = "txtEditaCantidad"
        Me.txtEditaCantidad.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEditaCantidad.Properties.Appearance.Options.UseFont = True
        Me.txtEditaCantidad.Size = New System.Drawing.Size(76, 26)
        Me.txtEditaCantidad.TabIndex = 82
        '
        'LabelControl15
        '
        Me.LabelControl15.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl15.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl15.Appearance.Options.UseFont = True
        Me.LabelControl15.Location = New System.Drawing.Point(477, 533)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(65, 19)
        Me.LabelControl15.TabIndex = 81
        Me.LabelControl15.Text = "Cantidad:"
        '
        'txtPartida
        '
        Me.txtPartida.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPartida.Enabled = False
        Me.txtPartida.Location = New System.Drawing.Point(463, 530)
        Me.txtPartida.Name = "txtPartida"
        Me.txtPartida.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPartida.Properties.Appearance.Options.UseFont = True
        Me.txtPartida.Size = New System.Drawing.Size(0, 26)
        Me.txtPartida.TabIndex = 80
        '
        'LabelControl16
        '
        Me.LabelControl16.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl16.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl16.Appearance.Options.UseFont = True
        Me.LabelControl16.Location = New System.Drawing.Point(402, 533)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(54, 19)
        Me.LabelControl16.TabIndex = 79
        Me.LabelControl16.Text = "Partida:"
        '
        'txtNumParte
        '
        Me.txtNumParte.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNumParte.Enabled = False
        Me.txtNumParte.Location = New System.Drawing.Point(548, 498)
        Me.txtNumParte.Name = "txtNumParte"
        Me.txtNumParte.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumParte.Properties.Appearance.Options.UseFont = True
        Me.txtNumParte.Size = New System.Drawing.Size(440, 26)
        Me.txtNumParte.TabIndex = 78
        '
        'LabelControl14
        '
        Me.LabelControl14.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl14.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl14.Appearance.Options.UseFont = True
        Me.LabelControl14.Location = New System.Drawing.Point(483, 501)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(59, 19)
        Me.LabelControl14.TabIndex = 77
        Me.LabelControl14.Text = "Artículo:"
        '
        'txtPartidaOC
        '
        Me.txtPartidaOC.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPartidaOC.Enabled = False
        Me.txtPartidaOC.Location = New System.Drawing.Point(463, 498)
        Me.txtPartidaOC.Name = "txtPartidaOC"
        Me.txtPartidaOC.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPartidaOC.Properties.Appearance.Options.UseFont = True
        Me.txtPartidaOC.Size = New System.Drawing.Size(0, 26)
        Me.txtPartidaOC.TabIndex = 76
        '
        'LabelControl13
        '
        Me.LabelControl13.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl13.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl13.Appearance.Options.UseFont = True
        Me.LabelControl13.Location = New System.Drawing.Point(372, 501)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(84, 19)
        Me.LabelControl13.TabIndex = 75
        Me.LabelControl13.Text = "Documento:"
        '
        'grdDetalle
        '
        Me.grdDetalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdDetalle.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.grdDetalle.Location = New System.Drawing.Point(373, 120)
        Me.grdDetalle.MainView = Me.GridView1
        Me.grdDetalle.Name = "grdDetalle"
        Me.grdDetalle.Size = New System.Drawing.Size(615, 363)
        Me.grdDetalle.TabIndex = 74
        Me.grdDetalle.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.DetailHeight = 303
        Me.GridView1.GridControl = Me.grdDetalle
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(40, 146)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(51, 19)
        Me.LabelControl4.TabIndex = 89
        Me.LabelControl4.Text = "Cliente:"
        '
        'cmbCliente
        '
        Me.cmbCliente.Location = New System.Drawing.Point(97, 143)
        Me.cmbCliente.Name = "cmbCliente"
        Me.cmbCliente.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCliente.Properties.Appearance.Options.UseFont = True
        Me.cmbCliente.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCliente.Properties.AppearanceDisabled.Options.UseFont = True
        Me.cmbCliente.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.cmbCliente.Properties.AppearanceDropDown.Options.UseFont = True
        Me.cmbCliente.Properties.AppearanceFocused.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.cmbCliente.Properties.AppearanceFocused.Options.UseFont = True
        Me.cmbCliente.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbCliente.Properties.NullText = ""
        Me.cmbCliente.Properties.PopupSizeable = False
        Me.cmbCliente.Properties.PopupView = Me.GridView2
        Me.cmbCliente.Size = New System.Drawing.Size(252, 26)
        Me.cmbCliente.TabIndex = 88
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7})
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Nombre de cliente"
        Me.GridColumn1.FieldName = "Cliente"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.FixedWidth = True
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Código de cliente"
        Me.GridColumn2.FieldName = "CodigoCliente"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Dirección"
        Me.GridColumn3.FieldName = "Dreccion"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Ciudad"
        Me.GridColumn4.FieldName = "Ciudad"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 3
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Estado"
        Me.GridColumn5.FieldName = "Estado"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 4
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Código postal"
        Me.GridColumn6.FieldName = "CodigoPostal"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 5
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "País"
        Me.GridColumn7.FieldName = "Pais"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 6
        '
        'FrmCreaRecepcion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 594)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.cmbCliente)
        Me.Controls.Add(Me.TxtEditaCaracteristica)
        Me.Controls.Add(Me.LabelControl9)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.txtEditaCantidad)
        Me.Controls.Add(Me.LabelControl15)
        Me.Controls.Add(Me.txtPartida)
        Me.Controls.Add(Me.LabelControl16)
        Me.Controls.Add(Me.txtNumParte)
        Me.Controls.Add(Me.LabelControl14)
        Me.Controls.Add(Me.txtPartidaOC)
        Me.Controls.Add(Me.LabelControl13)
        Me.Controls.Add(Me.grdDetalle)
        Me.Controls.Add(Me.btnAgregarNP)
        Me.Controls.Add(Me.TxtCaracteristica)
        Me.Controls.Add(Me.LabelControl8)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.LabelControl12)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.LabelControl10)
        Me.Controls.Add(Me.cmbNumParte)
        Me.Controls.Add(Me.btnRecepciones)
        Me.Controls.Add(Me.SeparatorControl1)
        Me.Controls.Add(Me.txtOrdenCompra)
        Me.Controls.Add(Me.txtDireccionCliente)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnNuevo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCreaRecepcion"
        Me.ShowInTaskbar = False
        Me.Text = "Creación de orden de compra"
        CType(Me.SeparatorControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOrdenCompra.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDireccionCliente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtCaracteristica.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCantidad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescripcion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbNumParte.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtEditaCaracteristica.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEditaCantidad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPartida.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNumParte.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPartidaOC.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbCliente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnRecepciones As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SeparatorControl1 As DevExpress.XtraEditors.SeparatorControl
    Friend WithEvents txtOrdenCompra As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDireccionCliente As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnBuscar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnNuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TxtCaracteristica As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCantidad As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDescripcion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbNumParte As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents NumParte As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DNumParte1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnAgregarNP As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TxtEditaCaracteristica As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnEliminar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEditar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtEditaCantidad As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPartida As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNumParte As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPartidaOC As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents grdDetalle As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbCliente As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
End Class
