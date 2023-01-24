<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCrearOrdenTraspaso
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCrearOrdenTraspaso))
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
        Me.btnAgregarNP = New DevExpress.XtraEditors.SimpleButton()
        Me.txtCantidad = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.txtDescripcion = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.grdDetalle = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.SeparatorControl1 = New DevExpress.XtraEditors.SeparatorControl()
        Me.txtOrdenTras = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.btnBuscar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnNuevo = New DevExpress.XtraEditors.SimpleButton()
        Me.cmbNumParte = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Artículo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Descripcion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.cmbAlmacenDestino = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Origen = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cmbAlmacenOrigen = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Almacen = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnLiberar = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.txtEditaCantidad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPartida.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNumParte.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPartidaOC.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCantidad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescripcion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeparatorControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOrdenTras.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbNumParte.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbAlmacenDestino.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbAlmacenOrigen.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnEliminar
        '
        Me.btnEliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEliminar.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.Appearance.Options.UseFont = True
        Me.btnEliminar.Location = New System.Drawing.Point(1399, 729)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(140, 42)
        Me.btnEliminar.TabIndex = 117
        Me.btnEliminar.Text = "Eliminar"
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGuardar.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Appearance.Options.UseFont = True
        Me.btnGuardar.Location = New System.Drawing.Point(1251, 729)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(140, 42)
        Me.btnGuardar.TabIndex = 116
        Me.btnGuardar.Text = "Guardar"
        '
        'btnEditar
        '
        Me.btnEditar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEditar.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditar.Appearance.Options.UseFont = True
        Me.btnEditar.Location = New System.Drawing.Point(1103, 729)
        Me.btnEditar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(140, 42)
        Me.btnEditar.TabIndex = 115
        Me.btnEditar.Text = "Editar"
        '
        'txtEditaCantidad
        '
        Me.txtEditaCantidad.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEditaCantidad.Enabled = False
        Me.txtEditaCantidad.Location = New System.Drawing.Point(993, 735)
        Me.txtEditaCantidad.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEditaCantidad.Name = "txtEditaCantidad"
        Me.txtEditaCantidad.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEditaCantidad.Properties.Appearance.Options.UseFont = True
        Me.txtEditaCantidad.Size = New System.Drawing.Size(59, 30)
        Me.txtEditaCantidad.TabIndex = 114
        '
        'LabelControl15
        '
        Me.LabelControl15.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelControl15.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl15.Appearance.Options.UseFont = True
        Me.LabelControl15.Location = New System.Drawing.Point(899, 738)
        Me.LabelControl15.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(82, 24)
        Me.LabelControl15.TabIndex = 113
        Me.LabelControl15.Text = "Cantidad:"
        '
        'txtPartida
        '
        Me.txtPartida.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtPartida.Enabled = False
        Me.txtPartida.Location = New System.Drawing.Point(635, 735)
        Me.txtPartida.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPartida.Name = "txtPartida"
        Me.txtPartida.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPartida.Properties.Appearance.Options.UseFont = True
        Me.txtPartida.Size = New System.Drawing.Size(240, 30)
        Me.txtPartida.TabIndex = 112
        '
        'LabelControl16
        '
        Me.LabelControl16.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl16.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl16.Appearance.Options.UseFont = True
        Me.LabelControl16.Location = New System.Drawing.Point(555, 738)
        Me.LabelControl16.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(67, 24)
        Me.LabelControl16.TabIndex = 111
        Me.LabelControl16.Text = "Partida:"
        '
        'txtNumParte
        '
        Me.txtNumParte.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNumParte.Enabled = False
        Me.txtNumParte.Location = New System.Drawing.Point(993, 686)
        Me.txtNumParte.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNumParte.Name = "txtNumParte"
        Me.txtNumParte.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumParte.Properties.Appearance.Options.UseFont = True
        Me.txtNumParte.Size = New System.Drawing.Size(545, 30)
        Me.txtNumParte.TabIndex = 110
        '
        'LabelControl14
        '
        Me.LabelControl14.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelControl14.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl14.Appearance.Options.UseFont = True
        Me.LabelControl14.Location = New System.Drawing.Point(907, 689)
        Me.LabelControl14.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(72, 24)
        Me.LabelControl14.TabIndex = 109
        Me.LabelControl14.Text = "Artículo:"
        '
        'txtPartidaOC
        '
        Me.txtPartidaOC.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtPartidaOC.Enabled = False
        Me.txtPartidaOC.Location = New System.Drawing.Point(636, 686)
        Me.txtPartidaOC.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPartidaOC.Name = "txtPartidaOC"
        Me.txtPartidaOC.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPartidaOC.Properties.Appearance.Options.UseFont = True
        Me.txtPartidaOC.Size = New System.Drawing.Size(240, 30)
        Me.txtPartidaOC.TabIndex = 108
        '
        'LabelControl13
        '
        Me.LabelControl13.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl13.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl13.Appearance.Options.UseFont = True
        Me.LabelControl13.Location = New System.Drawing.Point(516, 689)
        Me.LabelControl13.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(104, 24)
        Me.LabelControl13.TabIndex = 107
        Me.LabelControl13.Text = "Documento:"
        '
        'btnAgregarNP
        '
        Me.btnAgregarNP.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarNP.Appearance.Options.UseFont = True
        Me.btnAgregarNP.Location = New System.Drawing.Point(848, 109)
        Me.btnAgregarNP.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAgregarNP.Name = "btnAgregarNP"
        Me.btnAgregarNP.Size = New System.Drawing.Size(204, 42)
        Me.btnAgregarNP.TabIndex = 101
        Me.btnAgregarNP.Text = "Agregar artículo"
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(635, 116)
        Me.txtCantidad.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidad.Properties.Appearance.Options.UseFont = True
        Me.txtCantidad.Size = New System.Drawing.Size(127, 30)
        Me.txtCantidad.TabIndex = 99
        '
        'LabelControl12
        '
        Me.LabelControl12.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl12.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl12.Appearance.Options.UseFont = True
        Me.LabelControl12.Location = New System.Drawing.Point(540, 119)
        Me.LabelControl12.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(82, 24)
        Me.LabelControl12.TabIndex = 106
        Me.LabelControl12.Text = "Cantidad:"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Enabled = False
        Me.txtDescripcion.Location = New System.Drawing.Point(635, 70)
        Me.txtDescripcion.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.Properties.Appearance.Options.UseFont = True
        Me.txtDescripcion.Size = New System.Drawing.Size(725, 30)
        Me.txtDescripcion.TabIndex = 105
        '
        'LabelControl6
        '
        Me.LabelControl6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Appearance.Options.UseFont = True
        Me.LabelControl6.Location = New System.Drawing.Point(548, 34)
        Me.LabelControl6.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(72, 24)
        Me.LabelControl6.TabIndex = 103
        Me.LabelControl6.Text = "Artículo:"
        '
        'LabelControl10
        '
        Me.LabelControl10.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl10.Appearance.Options.UseFont = True
        Me.LabelControl10.Location = New System.Drawing.Point(516, 74)
        Me.LabelControl10.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(103, 24)
        Me.LabelControl10.TabIndex = 104
        Me.LabelControl10.Text = "Descripción:"
        '
        'grdDetalle
        '
        Me.grdDetalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdDetalle.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4)
        Me.grdDetalle.Font = New System.Drawing.Font("Arial", 8.0!)
        GridLevelNode1.RelationName = "Level1"
        Me.grdDetalle.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.grdDetalle.Location = New System.Drawing.Point(516, 159)
        Me.grdDetalle.MainView = Me.GridView1
        Me.grdDetalle.Margin = New System.Windows.Forms.Padding(4)
        Me.grdDetalle.Name = "grdDetalle"
        Me.grdDetalle.Size = New System.Drawing.Size(1023, 503)
        Me.grdDetalle.TabIndex = 102
        Me.grdDetalle.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.DetailHeight = 373
        Me.GridView1.GridControl = Me.grdDetalle
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'SeparatorControl1
        '
        Me.SeparatorControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SeparatorControl1.AutoSizeMode = True
        Me.SeparatorControl1.LineAlignment = DevExpress.XtraEditors.Alignment.Center
        Me.SeparatorControl1.LineOrientation = System.Windows.Forms.Orientation.Vertical
        Me.SeparatorControl1.Location = New System.Drawing.Point(485, 12)
        Me.SeparatorControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.SeparatorControl1.Name = "SeparatorControl1"
        Me.SeparatorControl1.Padding = New System.Windows.Forms.Padding(11, 10, 11, 10)
        Me.SeparatorControl1.Size = New System.Drawing.Size(23, 762)
        Me.SeparatorControl1.TabIndex = 100
        '
        'txtOrdenTras
        '
        Me.txtOrdenTras.Location = New System.Drawing.Point(141, 31)
        Me.txtOrdenTras.Margin = New System.Windows.Forms.Padding(4)
        Me.txtOrdenTras.Name = "txtOrdenTras"
        Me.txtOrdenTras.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOrdenTras.Properties.Appearance.Options.UseFont = True
        Me.txtOrdenTras.Size = New System.Drawing.Size(232, 30)
        Me.txtOrdenTras.TabIndex = 95
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(21, 35)
        Me.LabelControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(104, 24)
        Me.LabelControl1.TabIndex = 94
        Me.LabelControl1.Text = "Documento:"
        '
        'btnBuscar
        '
        Me.btnBuscar.ImageOptions.Image = CType(resources.GetObject("btnBuscar.ImageOptions.Image"), System.Drawing.Image)
        Me.btnBuscar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnBuscar.Location = New System.Drawing.Point(381, 26)
        Me.btnBuscar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(45, 43)
        Me.btnBuscar.TabIndex = 96
        '
        'btnNuevo
        '
        Me.btnNuevo.ImageOptions.Image = CType(resources.GetObject("btnNuevo.ImageOptions.Image"), System.Drawing.Image)
        Me.btnNuevo.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnNuevo.Location = New System.Drawing.Point(432, 26)
        Me.btnNuevo.Margin = New System.Windows.Forms.Padding(4)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(45, 43)
        Me.btnNuevo.TabIndex = 97
        '
        'cmbNumParte
        '
        Me.cmbNumParte.Location = New System.Drawing.Point(635, 31)
        Me.cmbNumParte.Margin = New System.Windows.Forms.Padding(4)
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
        Me.cmbNumParte.Size = New System.Drawing.Size(725, 30)
        Me.cmbNumParte.TabIndex = 98
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Artículo, Me.Descripcion})
        Me.GridLookUpEdit1View.DetailHeight = 373
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'Artículo
        '
        Me.Artículo.Caption = "Artículo"
        Me.Artículo.FieldName = "Artículo"
        Me.Artículo.MinWidth = 23
        Me.Artículo.Name = "Artículo"
        Me.Artículo.Visible = True
        Me.Artículo.VisibleIndex = 0
        Me.Artículo.Width = 85
        '
        'Descripcion
        '
        Me.Descripcion.Caption = "Descripción"
        Me.Descripcion.FieldName = "Descripcion"
        Me.Descripcion.MinWidth = 23
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.Visible = True
        Me.Descripcion.VisibleIndex = 1
        Me.Descripcion.Width = 85
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(21, 80)
        Me.LabelControl4.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(136, 24)
        Me.LabelControl4.TabIndex = 121
        Me.LabelControl4.Text = "Almacen origen:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(21, 125)
        Me.LabelControl2.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(146, 24)
        Me.LabelControl2.TabIndex = 123
        Me.LabelControl2.Text = "Almacen destino:"
        '
        'cmbAlmacenDestino
        '
        Me.cmbAlmacenDestino.Location = New System.Drawing.Point(177, 122)
        Me.cmbAlmacenDestino.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbAlmacenDestino.Name = "cmbAlmacenDestino"
        Me.cmbAlmacenDestino.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAlmacenDestino.Properties.Appearance.Options.UseFont = True
        Me.cmbAlmacenDestino.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAlmacenDestino.Properties.AppearanceDisabled.Options.UseFont = True
        Me.cmbAlmacenDestino.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAlmacenDestino.Properties.AppearanceDropDown.Options.UseFont = True
        Me.cmbAlmacenDestino.Properties.AppearanceFocused.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAlmacenDestino.Properties.AppearanceFocused.Options.UseFont = True
        Me.cmbAlmacenDestino.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbAlmacenDestino.Properties.NullText = ""
        Me.cmbAlmacenDestino.Properties.PopupSizeable = False
        Me.cmbAlmacenDestino.Properties.PopupView = Me.GridView2
        Me.cmbAlmacenDestino.Size = New System.Drawing.Size(301, 30)
        Me.cmbAlmacenDestino.TabIndex = 129
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Origen})
        Me.GridView2.DetailHeight = 373
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'Origen
        '
        Me.Origen.Caption = "Almacen Destino"
        Me.Origen.FieldName = "Almacen"
        Me.Origen.Name = "Origen"
        Me.Origen.Visible = True
        Me.Origen.VisibleIndex = 0
        '
        'cmbAlmacenOrigen
        '
        Me.cmbAlmacenOrigen.Location = New System.Drawing.Point(177, 84)
        Me.cmbAlmacenOrigen.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbAlmacenOrigen.Name = "cmbAlmacenOrigen"
        Me.cmbAlmacenOrigen.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAlmacenOrigen.Properties.Appearance.Options.UseFont = True
        Me.cmbAlmacenOrigen.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAlmacenOrigen.Properties.AppearanceDisabled.Options.UseFont = True
        Me.cmbAlmacenOrigen.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAlmacenOrigen.Properties.AppearanceDropDown.Options.UseFont = True
        Me.cmbAlmacenOrigen.Properties.AppearanceFocused.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAlmacenOrigen.Properties.AppearanceFocused.Options.UseFont = True
        Me.cmbAlmacenOrigen.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbAlmacenOrigen.Properties.NullText = ""
        Me.cmbAlmacenOrigen.Properties.PopupSizeable = False
        Me.cmbAlmacenOrigen.Properties.PopupView = Me.GridView3
        Me.cmbAlmacenOrigen.Size = New System.Drawing.Size(301, 30)
        Me.cmbAlmacenOrigen.TabIndex = 130
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Almacen})
        Me.GridView3.DetailHeight = 373
        Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'Almacen
        '
        Me.Almacen.Caption = "Almacen Origen"
        Me.Almacen.FieldName = "Almacen"
        Me.Almacen.Name = "Almacen"
        Me.Almacen.Visible = True
        Me.Almacen.VisibleIndex = 0
        '
        'btnLiberar
        '
        Me.btnLiberar.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLiberar.Appearance.Options.UseFont = True
        Me.btnLiberar.Location = New System.Drawing.Point(1103, 107)
        Me.btnLiberar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLiberar.Name = "btnLiberar"
        Me.btnLiberar.Size = New System.Drawing.Size(204, 42)
        Me.btnLiberar.TabIndex = 131
        Me.btnLiberar.Text = "Liberar "
        '
        'FrmCrearOrdenTraspaso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1580, 810)
        Me.Controls.Add(Me.btnLiberar)
        Me.Controls.Add(Me.cmbAlmacenOrigen)
        Me.Controls.Add(Me.cmbAlmacenDestino)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl4)
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
        Me.Controls.Add(Me.btnAgregarNP)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.LabelControl12)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.LabelControl10)
        Me.Controls.Add(Me.grdDetalle)
        Me.Controls.Add(Me.SeparatorControl1)
        Me.Controls.Add(Me.txtOrdenTras)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.cmbNumParte)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmCrearOrdenTraspaso"
        Me.Text = "CrearOrdenTraspaso"
        CType(Me.txtEditaCantidad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPartida.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNumParte.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPartidaOC.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCantidad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescripcion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeparatorControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOrdenTras.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbNumParte.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbAlmacenDestino.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbAlmacenOrigen.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
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
    Friend WithEvents btnAgregarNP As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtCantidad As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDescripcion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents grdDetalle As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SeparatorControl1 As DevExpress.XtraEditors.SeparatorControl
    Friend WithEvents txtOrdenTras As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnBuscar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnNuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmbNumParte As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Artículo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Descripcion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbAlmacenDestino As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cmbAlmacenOrigen As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Almacen As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Origen As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnLiberar As DevExpress.XtraEditors.SimpleButton
End Class
