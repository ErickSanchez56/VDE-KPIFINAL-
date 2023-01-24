<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMonitorSurtido
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMonitorSurtido))
        Dim ButtonImageOptions1 As DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions = New DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions()
        Dim ButtonImageOptions2 As DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions = New DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions()
        Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ButtonImageOptions3 As DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions = New DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions()
        Dim ButtonImageOptions4 As DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions = New DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions()
        Dim ButtonImageOptions5 As DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions = New DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions()
        Me.BtnBuscar = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnActualizar = New DevExpress.XtraEditors.SimpleButton()
        Me.TxtBusqueda = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.DgvResultado = New DevExpress.XtraGrid.GridControl()
        Me.DgvViewResultado = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SeparatorControl1 = New DevExpress.XtraEditors.SeparatorControl()
        Me.GroupControl4 = New DevExpress.XtraEditors.GroupControl()
        Me.DgvPartidas = New DevExpress.XtraGrid.GridControl()
        Me.DgvViewPartidas = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.DgvPalletsSinCerrar = New DevExpress.XtraGrid.GridControl()
        Me.DgvVierPalletsSinCerrar = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.DgvPalletsPendientesVal = New DevExpress.XtraGrid.GridControl()
        Me.DgvViewPalletsPendientesVal = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.DgvPalletsPendientesEntregaD = New DevExpress.XtraGrid.GridControl()
        Me.DgvViewPalletsPendientesEntrega = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GroupControl5 = New DevExpress.XtraEditors.GroupControl()
        Me.DgvPalletsEmbarcados = New DevExpress.XtraGrid.GridControl()
        Me.DgvViewEmbarcados = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.btnFechas = New DevExpress.XtraEditors.SimpleButton()
        Me.btnReporte = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.TxtBusqueda.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvResultado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvViewResultado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeparatorControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl4.SuspendLayout()
        CType(Me.DgvPartidas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvViewPartidas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.DgvPalletsSinCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvVierPalletsSinCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.DgvPalletsPendientesVal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvViewPalletsPendientesVal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.DgvPalletsPendientesEntregaD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvViewPalletsPendientesEntrega, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl5.SuspendLayout()
        CType(Me.DgvPalletsEmbarcados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvViewEmbarcados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnBuscar
        '
        Me.BtnBuscar.ImageOptions.Image = CType(resources.GetObject("BtnBuscar.ImageOptions.Image"), System.Drawing.Image)
        Me.BtnBuscar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.BtnBuscar.Location = New System.Drawing.Point(262, 12)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(34, 35)
        Me.BtnBuscar.TabIndex = 97
        '
        'BtnActualizar
        '
        Me.BtnActualizar.ImageOptions.Image = CType(resources.GetObject("BtnActualizar.ImageOptions.Image"), System.Drawing.Image)
        Me.BtnActualizar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.BtnActualizar.Location = New System.Drawing.Point(302, 12)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(34, 35)
        Me.BtnActualizar.TabIndex = 96
        '
        'TxtBusqueda
        '
        Me.TxtBusqueda.Location = New System.Drawing.Point(92, 19)
        Me.TxtBusqueda.Name = "TxtBusqueda"
        Me.TxtBusqueda.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBusqueda.Properties.Appearance.Options.UseFont = True
        Me.TxtBusqueda.Size = New System.Drawing.Size(164, 26)
        Me.TxtBusqueda.TabIndex = 95
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(12, 22)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(74, 19)
        Me.LabelControl1.TabIndex = 94
        Me.LabelControl1.Text = "Embarque:"
        '
        'DgvResultado
        '
        Me.DgvResultado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DgvResultado.Location = New System.Drawing.Point(12, 53)
        Me.DgvResultado.MainView = Me.DgvViewResultado
        Me.DgvResultado.Name = "DgvResultado"
        Me.DgvResultado.Size = New System.Drawing.Size(324, 638)
        Me.DgvResultado.TabIndex = 93
        Me.DgvResultado.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.DgvViewResultado})
        '
        'DgvViewResultado
        '
        Me.DgvViewResultado.Appearance.GroupRow.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvViewResultado.Appearance.GroupRow.Options.UseFont = True
        Me.DgvViewResultado.Appearance.HeaderPanel.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvViewResultado.Appearance.HeaderPanel.Options.UseFont = True
        Me.DgvViewResultado.Appearance.Row.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvViewResultado.Appearance.Row.Options.UseFont = True
        Me.DgvViewResultado.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2})
        Me.DgvViewResultado.GridControl = Me.DgvResultado
        Me.DgvViewResultado.Name = "DgvViewResultado"
        Me.DgvViewResultado.OptionsBehavior.Editable = False
        Me.DgvViewResultado.OptionsBehavior.ReadOnly = True
        Me.DgvViewResultado.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect
        Me.DgvViewResultado.OptionsView.ColumnAutoWidth = False
        Me.DgvViewResultado.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Orden de embarque"
        Me.GridColumn1.FieldName = "Embarque"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 119
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Fecha de creación"
        Me.GridColumn2.DisplayFormat.FormatString = "g"
        Me.GridColumn2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn2.FieldName = "Fecha Creación"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 164
        '
        'SeparatorControl1
        '
        Me.SeparatorControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SeparatorControl1.AutoSizeMode = True
        Me.SeparatorControl1.LineAlignment = DevExpress.XtraEditors.Alignment.Center
        Me.SeparatorControl1.LineOrientation = System.Windows.Forms.Orientation.Vertical
        Me.SeparatorControl1.Location = New System.Drawing.Point(342, 12)
        Me.SeparatorControl1.Name = "SeparatorControl1"
        Me.SeparatorControl1.Padding = New System.Windows.Forms.Padding(8)
        Me.SeparatorControl1.Size = New System.Drawing.Size(17, 777)
        Me.SeparatorControl1.TabIndex = 162
        '
        'GroupControl4
        '
        Me.GroupControl4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl4.AppearanceCaption.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl4.AppearanceCaption.Options.UseFont = True
        Me.GroupControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.GroupControl4.Controls.Add(Me.DgvPartidas)
        ButtonImageOptions1.Image = CType(resources.GetObject("ButtonImageOptions1.Image"), System.Drawing.Image)
        Me.GroupControl4.CustomHeaderButtons.AddRange(New DevExpress.XtraEditors.ButtonPanel.IBaseButton() {New DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("", True, ButtonImageOptions1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "Exportar a .XLSX", -1, True, Nothing, True, False, True, Nothing, -1)})
        Me.GroupControl4.CustomHeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText
        Me.GroupControl4.Location = New System.Drawing.Point(375, 12)
        Me.GroupControl4.Name = "GroupControl4"
        Me.GroupControl4.Size = New System.Drawing.Size(685, 167)
        Me.GroupControl4.TabIndex = 163
        Me.GroupControl4.Text = "Detalle de emabarque"
        '
        'DgvPartidas
        '
        Me.DgvPartidas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvPartidas.Location = New System.Drawing.Point(5, 40)
        Me.DgvPartidas.MainView = Me.DgvViewPartidas
        Me.DgvPartidas.Name = "DgvPartidas"
        Me.DgvPartidas.Size = New System.Drawing.Size(675, 122)
        Me.DgvPartidas.TabIndex = 94
        Me.DgvPartidas.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.DgvViewPartidas})
        '
        'DgvViewPartidas
        '
        Me.DgvViewPartidas.Appearance.GroupRow.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvViewPartidas.Appearance.GroupRow.Options.UseFont = True
        Me.DgvViewPartidas.Appearance.HeaderPanel.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvViewPartidas.Appearance.HeaderPanel.Options.UseFont = True
        Me.DgvViewPartidas.Appearance.Row.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvViewPartidas.Appearance.Row.Options.UseFont = True
        Me.DgvViewPartidas.GridControl = Me.DgvPartidas
        Me.DgvViewPartidas.Name = "DgvViewPartidas"
        Me.DgvViewPartidas.OptionsView.ColumnAutoWidth = False
        Me.DgvViewPartidas.OptionsView.ShowGroupPanel = False
        '
        'GroupControl1
        '
        Me.GroupControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.GroupControl1.Controls.Add(Me.DgvPalletsSinCerrar)
        ButtonImageOptions2.Image = CType(resources.GetObject("ButtonImageOptions2.Image"), System.Drawing.Image)
        Me.GroupControl1.CustomHeaderButtons.AddRange(New DevExpress.XtraEditors.ButtonPanel.IBaseButton() {New DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("", True, ButtonImageOptions2, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "Exportar a .XLSX", -1, True, SuperToolTip1, True, False, True, Nothing, -1)})
        Me.GroupControl1.CustomHeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText
        Me.GroupControl1.Location = New System.Drawing.Point(375, 185)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(686, 163)
        Me.GroupControl1.TabIndex = 164
        Me.GroupControl1.Text = "Material sin cerrar"
        '
        'DgvPalletsSinCerrar
        '
        Me.DgvPalletsSinCerrar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvPalletsSinCerrar.Location = New System.Drawing.Point(5, 40)
        Me.DgvPalletsSinCerrar.MainView = Me.DgvVierPalletsSinCerrar
        Me.DgvPalletsSinCerrar.Name = "DgvPalletsSinCerrar"
        Me.DgvPalletsSinCerrar.Size = New System.Drawing.Size(676, 118)
        Me.DgvPalletsSinCerrar.TabIndex = 94
        Me.DgvPalletsSinCerrar.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.DgvVierPalletsSinCerrar})
        '
        'DgvVierPalletsSinCerrar
        '
        Me.DgvVierPalletsSinCerrar.Appearance.GroupRow.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvVierPalletsSinCerrar.Appearance.GroupRow.Options.UseFont = True
        Me.DgvVierPalletsSinCerrar.Appearance.HeaderPanel.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvVierPalletsSinCerrar.Appearance.HeaderPanel.Options.UseFont = True
        Me.DgvVierPalletsSinCerrar.Appearance.Row.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvVierPalletsSinCerrar.Appearance.Row.Options.UseFont = True
        Me.DgvVierPalletsSinCerrar.GridControl = Me.DgvPalletsSinCerrar
        Me.DgvVierPalletsSinCerrar.Name = "DgvVierPalletsSinCerrar"
        Me.DgvVierPalletsSinCerrar.OptionsView.ColumnAutoWidth = False
        Me.DgvVierPalletsSinCerrar.OptionsView.ShowGroupPanel = False
        '
        'GroupControl2
        '
        Me.GroupControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl2.AppearanceCaption.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl2.AppearanceCaption.Options.UseFont = True
        Me.GroupControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.GroupControl2.Controls.Add(Me.DgvPalletsPendientesVal)
        ButtonImageOptions3.Image = CType(resources.GetObject("ButtonImageOptions3.Image"), System.Drawing.Image)
        Me.GroupControl2.CustomHeaderButtons.AddRange(New DevExpress.XtraEditors.ButtonPanel.IBaseButton() {New DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("", True, ButtonImageOptions3, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "Exportar a .XLSX", -1, True, Nothing, True, False, True, Nothing, -1)})
        Me.GroupControl2.CustomHeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText
        Me.GroupControl2.Location = New System.Drawing.Point(375, 354)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(686, 152)
        Me.GroupControl2.TabIndex = 164
        Me.GroupControl2.Text = "Material pendiente de validación"
        '
        'DgvPalletsPendientesVal
        '
        Me.DgvPalletsPendientesVal.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvPalletsPendientesVal.Location = New System.Drawing.Point(5, 40)
        Me.DgvPalletsPendientesVal.MainView = Me.DgvViewPalletsPendientesVal
        Me.DgvPalletsPendientesVal.Name = "DgvPalletsPendientesVal"
        Me.DgvPalletsPendientesVal.Size = New System.Drawing.Size(676, 107)
        Me.DgvPalletsPendientesVal.TabIndex = 94
        Me.DgvPalletsPendientesVal.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.DgvViewPalletsPendientesVal})
        '
        'DgvViewPalletsPendientesVal
        '
        Me.DgvViewPalletsPendientesVal.Appearance.GroupRow.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvViewPalletsPendientesVal.Appearance.GroupRow.Options.UseFont = True
        Me.DgvViewPalletsPendientesVal.Appearance.HeaderPanel.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvViewPalletsPendientesVal.Appearance.HeaderPanel.Options.UseFont = True
        Me.DgvViewPalletsPendientesVal.Appearance.Row.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvViewPalletsPendientesVal.Appearance.Row.Options.UseFont = True
        Me.DgvViewPalletsPendientesVal.GridControl = Me.DgvPalletsPendientesVal
        Me.DgvViewPalletsPendientesVal.Name = "DgvViewPalletsPendientesVal"
        Me.DgvViewPalletsPendientesVal.OptionsView.ColumnAutoWidth = False
        Me.DgvViewPalletsPendientesVal.OptionsView.ShowGroupPanel = False
        '
        'GroupControl3
        '
        Me.GroupControl3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl3.AppearanceCaption.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl3.AppearanceCaption.Options.UseFont = True
        Me.GroupControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.GroupControl3.Controls.Add(Me.DgvPalletsPendientesEntregaD)
        ButtonImageOptions4.Image = CType(resources.GetObject("ButtonImageOptions4.Image"), System.Drawing.Image)
        Me.GroupControl3.CustomHeaderButtons.AddRange(New DevExpress.XtraEditors.ButtonPanel.IBaseButton() {New DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("", True, ButtonImageOptions4, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "Exportar a .XLSX", -1, True, Nothing, True, False, True, Nothing, -1)})
        Me.GroupControl3.CustomHeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText
        Me.GroupControl3.Location = New System.Drawing.Point(375, 512)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(686, 164)
        Me.GroupControl3.TabIndex = 164
        Me.GroupControl3.Text = "Material pendiente a entrega"
        '
        'DgvPalletsPendientesEntregaD
        '
        Me.DgvPalletsPendientesEntregaD.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvPalletsPendientesEntregaD.Location = New System.Drawing.Point(5, 40)
        Me.DgvPalletsPendientesEntregaD.MainView = Me.DgvViewPalletsPendientesEntrega
        Me.DgvPalletsPendientesEntregaD.Name = "DgvPalletsPendientesEntregaD"
        Me.DgvPalletsPendientesEntregaD.Size = New System.Drawing.Size(676, 119)
        Me.DgvPalletsPendientesEntregaD.TabIndex = 94
        Me.DgvPalletsPendientesEntregaD.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.DgvViewPalletsPendientesEntrega})
        '
        'DgvViewPalletsPendientesEntrega
        '
        Me.DgvViewPalletsPendientesEntrega.Appearance.GroupRow.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvViewPalletsPendientesEntrega.Appearance.GroupRow.Options.UseFont = True
        Me.DgvViewPalletsPendientesEntrega.Appearance.HeaderPanel.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvViewPalletsPendientesEntrega.Appearance.HeaderPanel.Options.UseFont = True
        Me.DgvViewPalletsPendientesEntrega.Appearance.Row.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvViewPalletsPendientesEntrega.Appearance.Row.Options.UseFont = True
        Me.DgvViewPalletsPendientesEntrega.GridControl = Me.DgvPalletsPendientesEntregaD
        Me.DgvViewPalletsPendientesEntrega.Name = "DgvViewPalletsPendientesEntrega"
        Me.DgvViewPalletsPendientesEntrega.OptionsView.ColumnAutoWidth = False
        Me.DgvViewPalletsPendientesEntrega.OptionsView.ShowGroupPanel = False
        '
        'GroupControl5
        '
        Me.GroupControl5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl5.AppearanceCaption.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl5.AppearanceCaption.Options.UseFont = True
        Me.GroupControl5.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.GroupControl5.Controls.Add(Me.DgvPalletsEmbarcados)
        ButtonImageOptions5.Image = CType(resources.GetObject("ButtonImageOptions5.Image"), System.Drawing.Image)
        Me.GroupControl5.CustomHeaderButtons.AddRange(New DevExpress.XtraEditors.ButtonPanel.IBaseButton() {New DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("", True, ButtonImageOptions5, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "Exportar a .XLSX", -1, True, Nothing, True, False, True, Nothing, -1)})
        Me.GroupControl5.CustomHeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText
        Me.GroupControl5.Location = New System.Drawing.Point(375, 682)
        Me.GroupControl5.Name = "GroupControl5"
        Me.GroupControl5.Size = New System.Drawing.Size(686, 97)
        Me.GroupControl5.TabIndex = 165
        Me.GroupControl5.Text = "Material embarcado"
        '
        'DgvPalletsEmbarcados
        '
        Me.DgvPalletsEmbarcados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvPalletsEmbarcados.Location = New System.Drawing.Point(5, 40)
        Me.DgvPalletsEmbarcados.MainView = Me.DgvViewEmbarcados
        Me.DgvPalletsEmbarcados.Name = "DgvPalletsEmbarcados"
        Me.DgvPalletsEmbarcados.Size = New System.Drawing.Size(676, 52)
        Me.DgvPalletsEmbarcados.TabIndex = 94
        Me.DgvPalletsEmbarcados.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.DgvViewEmbarcados})
        '
        'DgvViewEmbarcados
        '
        Me.DgvViewEmbarcados.Appearance.ColumnFilterButton.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvViewEmbarcados.Appearance.ColumnFilterButton.Options.UseFont = True
        Me.DgvViewEmbarcados.Appearance.GroupRow.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvViewEmbarcados.Appearance.GroupRow.Options.UseFont = True
        Me.DgvViewEmbarcados.Appearance.Row.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvViewEmbarcados.Appearance.Row.Options.UseFont = True
        Me.DgvViewEmbarcados.GridControl = Me.DgvPalletsEmbarcados
        Me.DgvViewEmbarcados.Name = "DgvViewEmbarcados"
        Me.DgvViewEmbarcados.OptionsView.ColumnAutoWidth = False
        Me.DgvViewEmbarcados.OptionsView.ShowGroupPanel = False
        '
        'btnFechas
        '
        Me.btnFechas.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFechas.Appearance.Options.UseFont = True
        Me.btnFechas.Appearance.Options.UseTextOptions = True
        Me.btnFechas.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnFechas.Location = New System.Drawing.Point(186, 798)
        Me.btnFechas.Name = "btnFechas"
        Me.btnFechas.Size = New System.Drawing.Size(137, 45)
        Me.btnFechas.TabIndex = 168
        Me.btnFechas.Text = "Generar reporte por fechas"
        Me.btnFechas.Visible = False
        '
        'btnReporte
        '
        Me.btnReporte.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnReporte.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReporte.Appearance.Options.UseFont = True
        Me.btnReporte.Appearance.Options.UseTextOptions = True
        Me.btnReporte.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnReporte.Location = New System.Drawing.Point(12, 711)
        Me.btnReporte.Name = "btnReporte"
        Me.btnReporte.Size = New System.Drawing.Size(137, 45)
        Me.btnReporte.TabIndex = 169
        Me.btnReporte.Text = "Generar reporte por embarque"
        '
        'FrmMonitorSurtido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1076, 791)
        Me.Controls.Add(Me.btnReporte)
        Me.Controls.Add(Me.btnFechas)
        Me.Controls.Add(Me.GroupControl5)
        Me.Controls.Add(Me.GroupControl3)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.GroupControl4)
        Me.Controls.Add(Me.SeparatorControl1)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.BtnActualizar)
        Me.Controls.Add(Me.TxtBusqueda)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.DgvResultado)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.IconOptions.Image = Global.AXCVDE.My.Resources.Resources.Logo_X_150x150_01
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmMonitorSurtido"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Monitor de embarques"
        CType(Me.TxtBusqueda.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvResultado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvViewResultado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeparatorControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl4.ResumeLayout(False)
        CType(Me.DgvPartidas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvViewPartidas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.DgvPalletsSinCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvVierPalletsSinCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.DgvPalletsPendientesVal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvViewPalletsPendientesVal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        CType(Me.DgvPalletsPendientesEntregaD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvViewPalletsPendientesEntrega, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl5.ResumeLayout(False)
        CType(Me.DgvPalletsEmbarcados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvViewEmbarcados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnBuscar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnActualizar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TxtBusqueda As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DgvResultado As DevExpress.XtraGrid.GridControl
    Friend WithEvents DgvViewResultado As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SeparatorControl1 As DevExpress.XtraEditors.SeparatorControl
    Friend WithEvents GroupControl4 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents DgvPartidas As DevExpress.XtraGrid.GridControl
    Friend WithEvents DgvViewPartidas As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents DgvPalletsSinCerrar As DevExpress.XtraGrid.GridControl
    Friend WithEvents DgvVierPalletsSinCerrar As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents DgvPalletsPendientesVal As DevExpress.XtraGrid.GridControl
    Friend WithEvents DgvViewPalletsPendientesVal As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents DgvPalletsPendientesEntregaD As DevExpress.XtraGrid.GridControl
    Friend WithEvents DgvViewPalletsPendientesEntrega As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GroupControl5 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents DgvPalletsEmbarcados As DevExpress.XtraGrid.GridControl
    Friend WithEvents DgvViewEmbarcados As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnFechas As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnReporte As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
End Class
