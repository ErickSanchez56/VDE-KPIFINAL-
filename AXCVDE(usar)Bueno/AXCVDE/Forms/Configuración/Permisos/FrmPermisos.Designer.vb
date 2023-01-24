<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPermisos
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPermisos))
        Me.BtnBuscar = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnNuevo = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnActualizar = New DevExpress.XtraEditors.SimpleButton()
        Me.TxtBusqueda = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.DgvResultadoGrupos = New DevExpress.XtraGrid.GridControl()
        Me.DgvViewResultadoGrupos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SeparatorControl1 = New DevExpress.XtraEditors.SeparatorControl()
        Me.GroupControl4 = New DevExpress.XtraEditors.GroupControl()
        Me.BtnGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.TabPane1 = New DevExpress.XtraBars.Navigation.TabPane()
        Me.TUsuarios = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        Me.BtnEliminarUsuario = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnAgregarUsuario = New DevExpress.XtraEditors.SimpleButton()
        Me.DgvIncluidaUs = New DevExpress.XtraGrid.GridControl()
        Me.DgvViewIncluidaUs = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DgvExcluidaUs = New DevExpress.XtraGrid.GridControl()
        Me.DgvViewExcluidaUs = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Usuarios = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        Me.BtnEliminaTransaccion = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnAgregaTransaccion = New DevExpress.XtraEditors.SimpleButton()
        Me.DgvIncluida = New DevExpress.XtraGrid.GridControl()
        Me.DgvViewIncluidaTr = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DgvExcluida = New DevExpress.XtraGrid.GridControl()
        Me.DgvViewExcluidaTr = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LblGrupoSeleccionado = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.BehaviorManager1 = New DevExpress.Utils.Behaviors.BehaviorManager(Me.components)
        CType(Me.TxtBusqueda.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvResultadoGrupos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvViewResultadoGrupos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeparatorControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl4.SuspendLayout()
        CType(Me.TabPane1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPane1.SuspendLayout()
        Me.TUsuarios.SuspendLayout()
        CType(Me.DgvIncluidaUs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvViewIncluidaUs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvExcluidaUs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvViewExcluidaUs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Usuarios.SuspendLayout()
        CType(Me.DgvIncluida, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvViewIncluidaTr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvExcluida, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvViewExcluidaTr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BehaviorManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnBuscar
        '
        Me.BtnBuscar.ImageOptions.Image = CType(resources.GetObject("BtnBuscar.ImageOptions.Image"), System.Drawing.Image)
        Me.BtnBuscar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.BtnBuscar.Location = New System.Drawing.Point(234, 21)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(34, 35)
        Me.BtnBuscar.TabIndex = 87
        '
        'BtnNuevo
        '
        Me.BtnNuevo.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.BtnNuevo.ImageOptions.SvgImage = CType(resources.GetObject("BtnNuevo.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.BtnNuevo.Location = New System.Drawing.Point(314, 21)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(34, 35)
        Me.BtnNuevo.TabIndex = 86
        '
        'BtnActualizar
        '
        Me.BtnActualizar.ImageOptions.Image = CType(resources.GetObject("BtnActualizar.ImageOptions.Image"), System.Drawing.Image)
        Me.BtnActualizar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.BtnActualizar.Location = New System.Drawing.Point(274, 21)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(34, 35)
        Me.BtnActualizar.TabIndex = 85
        '
        'TxtBusqueda
        '
        Me.TxtBusqueda.Location = New System.Drawing.Point(64, 28)
        Me.TxtBusqueda.Name = "TxtBusqueda"
        Me.TxtBusqueda.Properties.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBusqueda.Properties.Appearance.Options.UseFont = True
        Me.TxtBusqueda.Size = New System.Drawing.Size(163, 22)
        Me.TxtBusqueda.TabIndex = 84
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(11, 28)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(47, 19)
        Me.LabelControl1.TabIndex = 83
        Me.LabelControl1.Text = "Grupo:"
        '
        'DgvResultadoGrupos
        '
        Me.DgvResultadoGrupos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DgvResultadoGrupos.Location = New System.Drawing.Point(11, 75)
        Me.DgvResultadoGrupos.MainView = Me.DgvViewResultadoGrupos
        Me.DgvResultadoGrupos.Name = "DgvResultadoGrupos"
        Me.DgvResultadoGrupos.Size = New System.Drawing.Size(337, 419)
        Me.DgvResultadoGrupos.TabIndex = 82
        Me.DgvResultadoGrupos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.DgvViewResultadoGrupos})
        '
        'DgvViewResultadoGrupos
        '
        Me.DgvViewResultadoGrupos.Appearance.GroupRow.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvViewResultadoGrupos.Appearance.GroupRow.Options.UseFont = True
        Me.DgvViewResultadoGrupos.Appearance.HeaderPanel.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvViewResultadoGrupos.Appearance.HeaderPanel.Options.UseFont = True
        Me.DgvViewResultadoGrupos.Appearance.Row.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvViewResultadoGrupos.Appearance.Row.Options.UseFont = True
        Me.DgvViewResultadoGrupos.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2})
        Me.DgvViewResultadoGrupos.GridControl = Me.DgvResultadoGrupos
        Me.DgvViewResultadoGrupos.Name = "DgvViewResultadoGrupos"
        Me.DgvViewResultadoGrupos.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Id"
        Me.GridColumn1.FieldName = "IdGrupo"
        Me.GridColumn1.Name = "GridColumn1"
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Grupo"
        Me.GridColumn2.FieldName = "Grupo"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 0
        '
        'SeparatorControl1
        '
        Me.SeparatorControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SeparatorControl1.AutoSizeMode = True
        Me.SeparatorControl1.LineAlignment = DevExpress.XtraEditors.Alignment.Center
        Me.SeparatorControl1.LineOrientation = System.Windows.Forms.Orientation.Vertical
        Me.SeparatorControl1.Location = New System.Drawing.Point(354, 12)
        Me.SeparatorControl1.Name = "SeparatorControl1"
        Me.SeparatorControl1.Padding = New System.Windows.Forms.Padding(8)
        Me.SeparatorControl1.Size = New System.Drawing.Size(17, 485)
        Me.SeparatorControl1.TabIndex = 161
        '
        'GroupControl4
        '
        Me.GroupControl4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.GroupControl4.Controls.Add(Me.BtnGuardar)
        Me.GroupControl4.Controls.Add(Me.TabPane1)
        Me.GroupControl4.Controls.Add(Me.LblGrupoSeleccionado)
        Me.GroupControl4.Controls.Add(Me.LabelControl2)
        Me.GroupControl4.Location = New System.Drawing.Point(367, 18)
        Me.GroupControl4.MinimumSize = New System.Drawing.Size(1027, 781)
        Me.GroupControl4.Name = "GroupControl4"
        Me.GroupControl4.Size = New System.Drawing.Size(1027, 781)
        Me.GroupControl4.TabIndex = 162
        Me.GroupControl4.Text = "Permisos y usuarios por grupo"
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnGuardar.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardar.Appearance.Options.UseFont = True
        Me.BtnGuardar.Appearance.Options.UseTextOptions = True
        Me.BtnGuardar.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.BtnGuardar.Location = New System.Drawing.Point(878, 31)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(137, 45)
        Me.BtnGuardar.TabIndex = 166
        Me.BtnGuardar.Text = "Configuración de usuarios"
        '
        'TabPane1
        '
        Me.TabPane1.AllowTransitionAnimation = DevExpress.Utils.DefaultBoolean.[True]
        Me.TabPane1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabPane1.AppearanceButton.Hovered.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPane1.AppearanceButton.Hovered.Options.UseFont = True
        Me.TabPane1.AppearanceButton.Normal.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPane1.AppearanceButton.Normal.Options.UseFont = True
        Me.TabPane1.AppearanceButton.Pressed.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPane1.AppearanceButton.Pressed.Options.UseFont = True
        Me.TabPane1.Controls.Add(Me.TUsuarios)
        Me.TabPane1.Controls.Add(Me.Usuarios)
        Me.TabPane1.Location = New System.Drawing.Point(5, 82)
        Me.TabPane1.MinimumSize = New System.Drawing.Size(1017, 588)
        Me.TabPane1.Name = "TabPane1"
        Me.TabPane1.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.TUsuarios, Me.Usuarios})
        Me.TabPane1.RegularSize = New System.Drawing.Size(1017, 738)
        Me.TabPane1.SelectedPage = Me.Usuarios
        Me.TabPane1.Size = New System.Drawing.Size(1017, 738)
        Me.TabPane1.TabIndex = 165
        Me.TabPane1.Text = "Usuarios"
        '
        'TUsuarios
        '
        Me.TUsuarios.Caption = "Usuarios"
        Me.TUsuarios.Controls.Add(Me.BtnEliminarUsuario)
        Me.TUsuarios.Controls.Add(Me.BtnAgregarUsuario)
        Me.TUsuarios.Controls.Add(Me.DgvIncluidaUs)
        Me.TUsuarios.Controls.Add(Me.DgvExcluidaUs)
        Me.TUsuarios.Name = "TUsuarios"
        Me.TUsuarios.Size = New System.Drawing.Size(1017, 708)
        '
        'BtnEliminarUsuario
        '
        Me.BtnEliminarUsuario.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnEliminarUsuario.ImageOptions.Image = CType(resources.GetObject("BtnEliminarUsuario.ImageOptions.Image"), System.Drawing.Image)
        Me.BtnEliminarUsuario.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.BtnEliminarUsuario.Location = New System.Drawing.Point(491, 254)
        Me.BtnEliminarUsuario.Name = "BtnEliminarUsuario"
        Me.BtnEliminarUsuario.Size = New System.Drawing.Size(34, 35)
        Me.BtnEliminarUsuario.TabIndex = 98
        '
        'BtnAgregarUsuario
        '
        Me.BtnAgregarUsuario.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnAgregarUsuario.ImageOptions.Image = CType(resources.GetObject("BtnAgregarUsuario.ImageOptions.Image"), System.Drawing.Image)
        Me.BtnAgregarUsuario.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.BtnAgregarUsuario.Location = New System.Drawing.Point(491, 194)
        Me.BtnAgregarUsuario.Name = "BtnAgregarUsuario"
        Me.BtnAgregarUsuario.Size = New System.Drawing.Size(34, 35)
        Me.BtnAgregarUsuario.TabIndex = 97
        '
        'DgvIncluidaUs
        '
        Me.DgvIncluidaUs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvIncluidaUs.Location = New System.Drawing.Point(535, 13)
        Me.DgvIncluidaUs.MainView = Me.DgvViewIncluidaUs
        Me.DgvIncluidaUs.MaximumSize = New System.Drawing.Size(475, 600)
        Me.DgvIncluidaUs.MinimumSize = New System.Drawing.Size(475, 600)
        Me.DgvIncluidaUs.Name = "DgvIncluidaUs"
        Me.DgvIncluidaUs.Size = New System.Drawing.Size(475, 600)
        Me.DgvIncluidaUs.TabIndex = 86
        Me.DgvIncluidaUs.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.DgvViewIncluidaUs})
        '
        'DgvViewIncluidaUs
        '
        Me.DgvViewIncluidaUs.Appearance.GroupRow.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvViewIncluidaUs.Appearance.GroupRow.Options.UseFont = True
        Me.DgvViewIncluidaUs.Appearance.HeaderPanel.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvViewIncluidaUs.Appearance.HeaderPanel.Options.UseFont = True
        Me.DgvViewIncluidaUs.Appearance.Row.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvViewIncluidaUs.Appearance.Row.Options.UseFont = True
        Me.DgvViewIncluidaUs.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn3})
        Me.DgvViewIncluidaUs.GridControl = Me.DgvIncluidaUs
        Me.DgvViewIncluidaUs.Name = "DgvViewIncluidaUs"
        Me.DgvViewIncluidaUs.OptionsSelection.MultiSelect = True
        Me.DgvViewIncluidaUs.OptionsView.ShowGroupPanel = False
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Usuario"
        Me.GridColumn3.FieldName = "Usuario"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 0
        '
        'DgvExcluidaUs
        '
        Me.DgvExcluidaUs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DgvExcluidaUs.Location = New System.Drawing.Point(10, 13)
        Me.DgvExcluidaUs.MainView = Me.DgvViewExcluidaUs
        Me.DgvExcluidaUs.MaximumSize = New System.Drawing.Size(475, 600)
        Me.DgvExcluidaUs.MinimumSize = New System.Drawing.Size(475, 600)
        Me.DgvExcluidaUs.Name = "DgvExcluidaUs"
        Me.DgvExcluidaUs.Size = New System.Drawing.Size(475, 600)
        Me.DgvExcluidaUs.TabIndex = 85
        Me.DgvExcluidaUs.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.DgvViewExcluidaUs})
        '
        'DgvViewExcluidaUs
        '
        Me.DgvViewExcluidaUs.Appearance.GroupRow.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvViewExcluidaUs.Appearance.GroupRow.Options.UseFont = True
        Me.DgvViewExcluidaUs.Appearance.HeaderPanel.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvViewExcluidaUs.Appearance.HeaderPanel.Options.UseFont = True
        Me.DgvViewExcluidaUs.Appearance.Row.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvViewExcluidaUs.Appearance.Row.Options.UseFont = True
        Me.DgvViewExcluidaUs.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn5})
        Me.DgvViewExcluidaUs.GridControl = Me.DgvExcluidaUs
        Me.DgvViewExcluidaUs.Name = "DgvViewExcluidaUs"
        Me.DgvViewExcluidaUs.OptionsSelection.MultiSelect = True
        Me.DgvViewExcluidaUs.OptionsView.ShowGroupPanel = False
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Usuario"
        Me.GridColumn5.FieldName = "Usuario"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 0
        '
        'Usuarios
        '
        Me.Usuarios.Caption = "Transacciones"
        Me.Usuarios.Controls.Add(Me.BtnEliminaTransaccion)
        Me.Usuarios.Controls.Add(Me.BtnAgregaTransaccion)
        Me.Usuarios.Controls.Add(Me.DgvIncluida)
        Me.Usuarios.Controls.Add(Me.DgvExcluida)
        Me.Usuarios.Name = "Usuarios"
        Me.Usuarios.Size = New System.Drawing.Size(1017, 708)
        '
        'BtnEliminaTransaccion
        '
        Me.BtnEliminaTransaccion.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnEliminaTransaccion.ImageOptions.Image = CType(resources.GetObject("BtnEliminaTransaccion.ImageOptions.Image"), System.Drawing.Image)
        Me.BtnEliminaTransaccion.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.BtnEliminaTransaccion.Location = New System.Drawing.Point(495, 251)
        Me.BtnEliminaTransaccion.Name = "BtnEliminaTransaccion"
        Me.BtnEliminaTransaccion.Size = New System.Drawing.Size(34, 35)
        Me.BtnEliminaTransaccion.TabIndex = 98
        '
        'BtnAgregaTransaccion
        '
        Me.BtnAgregaTransaccion.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnAgregaTransaccion.ImageOptions.Image = CType(resources.GetObject("BtnAgregaTransaccion.ImageOptions.Image"), System.Drawing.Image)
        Me.BtnAgregaTransaccion.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.BtnAgregaTransaccion.Location = New System.Drawing.Point(495, 191)
        Me.BtnAgregaTransaccion.Name = "BtnAgregaTransaccion"
        Me.BtnAgregaTransaccion.Size = New System.Drawing.Size(34, 35)
        Me.BtnAgregaTransaccion.TabIndex = 97
        '
        'DgvIncluida
        '
        Me.DgvIncluida.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvIncluida.Location = New System.Drawing.Point(535, 12)
        Me.DgvIncluida.MainView = Me.DgvViewIncluidaTr
        Me.DgvIncluida.MaximumSize = New System.Drawing.Size(475, 600)
        Me.DgvIncluida.MinimumSize = New System.Drawing.Size(475, 600)
        Me.DgvIncluida.Name = "DgvIncluida"
        Me.DgvIncluida.Size = New System.Drawing.Size(475, 600)
        Me.DgvIncluida.TabIndex = 84
        Me.DgvIncluida.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.DgvViewIncluidaTr})
        '
        'DgvViewIncluidaTr
        '
        Me.DgvViewIncluidaTr.Appearance.GroupRow.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvViewIncluidaTr.Appearance.GroupRow.Options.UseFont = True
        Me.DgvViewIncluidaTr.Appearance.HeaderPanel.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvViewIncluidaTr.Appearance.HeaderPanel.Options.UseFont = True
        Me.DgvViewIncluidaTr.Appearance.Row.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvViewIncluidaTr.Appearance.Row.Options.UseFont = True
        Me.DgvViewIncluidaTr.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn10, Me.GridColumn9, Me.GridColumn6})
        Me.DgvViewIncluidaTr.GridControl = Me.DgvIncluida
        Me.DgvViewIncluidaTr.Name = "DgvViewIncluidaTr"
        Me.DgvViewIncluidaTr.OptionsSelection.MultiSelect = True
        Me.DgvViewIncluidaTr.OptionsView.ColumnAutoWidth = False
        Me.DgvViewIncluidaTr.OptionsView.ShowGroupPanel = False
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "Tipo de dispositivo"
        Me.GridColumn10.FieldName = "Dispositivo"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 0
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "Módulo"
        Me.GridColumn9.FieldName = "Modulo"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 1
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Transacción"
        Me.GridColumn6.FieldName = "Transaccion"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 2
        '
        'DgvExcluida
        '
        Me.DgvExcluida.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DgvExcluida.Location = New System.Drawing.Point(10, 12)
        Me.DgvExcluida.MainView = Me.DgvViewExcluidaTr
        Me.DgvExcluida.MaximumSize = New System.Drawing.Size(475, 600)
        Me.DgvExcluida.MinimumSize = New System.Drawing.Size(475, 600)
        Me.DgvExcluida.Name = "DgvExcluida"
        Me.DgvExcluida.Size = New System.Drawing.Size(475, 600)
        Me.DgvExcluida.TabIndex = 83
        Me.DgvExcluida.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.DgvViewExcluidaTr})
        '
        'DgvViewExcluidaTr
        '
        Me.DgvViewExcluidaTr.Appearance.GroupRow.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvViewExcluidaTr.Appearance.GroupRow.Options.UseFont = True
        Me.DgvViewExcluidaTr.Appearance.HeaderPanel.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvViewExcluidaTr.Appearance.HeaderPanel.Options.UseFont = True
        Me.DgvViewExcluidaTr.Appearance.Row.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvViewExcluidaTr.Appearance.Row.Options.UseFont = True
        Me.DgvViewExcluidaTr.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn8, Me.GridColumn7, Me.GridColumn4})
        Me.DgvViewExcluidaTr.GridControl = Me.DgvExcluida
        Me.DgvViewExcluidaTr.Name = "DgvViewExcluidaTr"
        Me.DgvViewExcluidaTr.OptionsSelection.MultiSelect = True
        Me.DgvViewExcluidaTr.OptionsView.ColumnAutoWidth = False
        Me.DgvViewExcluidaTr.OptionsView.ShowGroupPanel = False
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Tipo de dispositivo"
        Me.GridColumn8.FieldName = "Dispositivo"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 0
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Módulo"
        Me.GridColumn7.FieldName = "Modulo"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 1
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Transacción"
        Me.GridColumn4.FieldName = "Transaccion"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 2
        '
        'LblGrupoSeleccionado
        '
        Me.LblGrupoSeleccionado.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblGrupoSeleccionado.Appearance.Options.UseFont = True
        Me.LblGrupoSeleccionado.Location = New System.Drawing.Point(160, 41)
        Me.LblGrupoSeleccionado.Name = "LblGrupoSeleccionado"
        Me.LblGrupoSeleccionado.Size = New System.Drawing.Size(5, 19)
        Me.LblGrupoSeleccionado.TabIndex = 164
        Me.LblGrupoSeleccionado.Text = "-"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(15, 41)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(139, 19)
        Me.LabelControl2.TabIndex = 163
        Me.LabelControl2.Text = "Grupo seleccionado:"
        '
        'FrmPermisos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1406, 689)
        Me.Controls.Add(Me.GroupControl4)
        Me.Controls.Add(Me.SeparatorControl1)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.BtnActualizar)
        Me.Controls.Add(Me.TxtBusqueda)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.DgvResultadoGrupos)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmPermisos"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Grupos y permisos"
        CType(Me.TxtBusqueda.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvResultadoGrupos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvViewResultadoGrupos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeparatorControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl4.ResumeLayout(False)
        Me.GroupControl4.PerformLayout()
        CType(Me.TabPane1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPane1.ResumeLayout(False)
        Me.TUsuarios.ResumeLayout(False)
        CType(Me.DgvIncluidaUs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvViewIncluidaUs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvExcluidaUs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvViewExcluidaUs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Usuarios.ResumeLayout(False)
        CType(Me.DgvIncluida, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvViewIncluidaTr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvExcluida, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvViewExcluidaTr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BehaviorManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnBuscar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnNuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnActualizar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TxtBusqueda As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DgvResultadoGrupos As DevExpress.XtraGrid.GridControl
    Friend WithEvents DgvViewResultadoGrupos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SeparatorControl1 As DevExpress.XtraEditors.SeparatorControl
    Friend WithEvents GroupControl4 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LblGrupoSeleccionado As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TabPane1 As DevExpress.XtraBars.Navigation.TabPane
    Friend WithEvents TUsuarios As DevExpress.XtraBars.Navigation.TabNavigationPage
    Friend WithEvents Usuarios As DevExpress.XtraBars.Navigation.TabNavigationPage
    Friend WithEvents DgvIncluida As DevExpress.XtraGrid.GridControl
    Friend WithEvents DgvViewIncluidaTr As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DgvExcluida As DevExpress.XtraGrid.GridControl
    Friend WithEvents DgvViewExcluidaTr As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DgvIncluidaUs As DevExpress.XtraGrid.GridControl
    Friend WithEvents DgvViewIncluidaUs As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DgvExcluidaUs As DevExpress.XtraGrid.GridControl
    Friend WithEvents DgvViewExcluidaUs As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BtnGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnEliminarUsuario As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnAgregarUsuario As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnEliminaTransaccion As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnAgregaTransaccion As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BehaviorManager1 As DevExpress.Utils.Behaviors.BehaviorManager
End Class
