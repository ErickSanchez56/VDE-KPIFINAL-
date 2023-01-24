<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMonitorInventarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMonitorInventarios))
        Dim ButtonImageOptions1 As DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions = New DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions()
        Dim ButtonImageOptions2 As DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions = New DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions()
        Dim ButtonImageOptions3 As DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions = New DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.BtnActualizar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmbAlmacen = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.cbIds = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.cbTipoInventario = New DevExpress.XtraEditors.LookUpEdit()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.dgvPallets = New DevExpress.XtraGrid.GridControl()
        Me.GridViewTotal = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.btnCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCierra = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupControl4 = New DevExpress.XtraEditors.GroupControl()
        Me.dgvPalletsNoLeidos = New DevExpress.XtraGrid.GridControl()
        Me.GridViewSinLec = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GroupControl5 = New DevExpress.XtraEditors.GroupControl()
        Me.dgvPalletsEnRegistro = New DevExpress.XtraGrid.GridControl()
        Me.GridViewLeido = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.cmbAlmacen.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbIds.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbTipoInventario.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.dgvPallets, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl4.SuspendLayout()
        CType(Me.dgvPalletsNoLeidos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewSinLec, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl5.SuspendLayout()
        CType(Me.dgvPalletsEnRegistro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewLeido, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.BtnActualizar)
        Me.GroupControl1.Controls.Add(Me.cmbAlmacen)
        Me.GroupControl1.Controls.Add(Me.LabelControl5)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.cbIds)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.cbTipoInventario)
        Me.GroupControl1.Location = New System.Drawing.Point(9, 12)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(801, 110)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "Seleccionar ejercicio"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(506, 77)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(0, 19)
        Me.LabelControl4.TabIndex = 151
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(347, 77)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(153, 19)
        Me.LabelControl3.TabIndex = 150
        Me.LabelControl3.Text = "Estatus del Inventario:"
        '
        'BtnActualizar
        '
        Me.BtnActualizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnActualizar.ImageOptions.Image = CType(resources.GetObject("BtnActualizar.ImageOptions.Image"), System.Drawing.Image)
        Me.BtnActualizar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.BtnActualizar.Location = New System.Drawing.Point(762, 28)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(34, 35)
        Me.BtnActualizar.TabIndex = 149
        '
        'cmbAlmacen
        '
        Me.cmbAlmacen.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbAlmacen.Location = New System.Drawing.Point(142, 35)
        Me.cmbAlmacen.Name = "cmbAlmacen"
        Me.cmbAlmacen.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAlmacen.Properties.Appearance.Options.UseFont = True
        Me.cmbAlmacen.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbAlmacen.Properties.NullText = ""
        Me.cmbAlmacen.Properties.PopupSizeable = False
        Me.cmbAlmacen.Properties.PopupView = Me.GridView3
        Me.cmbAlmacen.Size = New System.Drawing.Size(185, 26)
        Me.cmbAlmacen.TabIndex = 144
        '
        'GridView3
        '
        Me.GridView3.Appearance.EvenRow.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView3.Appearance.EvenRow.Options.UseFont = True
        Me.GridView3.Appearance.FixedLine.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView3.Appearance.FixedLine.Options.UseFont = True
        Me.GridView3.Appearance.FocusedRow.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView3.Appearance.FocusedRow.Options.UseFont = True
        Me.GridView3.Appearance.FooterPanel.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.GridView3.Appearance.FooterPanel.Options.UseFont = True
        Me.GridView3.Appearance.GroupFooter.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.GridView3.Appearance.GroupFooter.Options.UseFont = True
        Me.GridView3.Appearance.GroupRow.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView3.Appearance.GroupRow.Options.UseFont = True
        Me.GridView3.Appearance.HeaderPanel.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView3.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridView3.Appearance.OddRow.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView3.Appearance.OddRow.Options.UseFont = True
        Me.GridView3.Appearance.Preview.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.GridView3.Appearance.Preview.Options.UseFont = True
        Me.GridView3.Appearance.Row.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView3.Appearance.Row.Options.UseFont = True
        Me.GridView3.Appearance.RowSeparator.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView3.Appearance.RowSeparator.Options.UseFont = True
        Me.GridView3.Appearance.SelectedRow.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView3.Appearance.SelectedRow.Options.UseFont = True
        Me.GridView3.Appearance.TopNewRow.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView3.Appearance.TopNewRow.Options.UseFont = True
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn2})
        Me.GridView3.DetailHeight = 303
        Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Almacén"
        Me.GridColumn2.FieldName = "ERPAlmacen"
        Me.GridColumn2.MinWidth = 17
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 0
        Me.GridColumn2.Width = 64
        '
        'LabelControl5
        '
        Me.LabelControl5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Location = New System.Drawing.Point(73, 38)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(63, 19)
        Me.LabelControl5.TabIndex = 145
        Me.LabelControl5.Text = "Almacén:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(347, 38)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(75, 19)
        Me.LabelControl1.TabIndex = 7
        Me.LabelControl1.Text = "Inventario:"
        '
        'cbIds
        '
        Me.cbIds.Location = New System.Drawing.Point(428, 35)
        Me.cbIds.Name = "cbIds"
        Me.cbIds.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbIds.Properties.Appearance.Options.UseFont = True
        Me.cbIds.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.cbIds.Properties.AppearanceDropDown.Options.UseFont = True
        Me.cbIds.Properties.AppearanceDropDownHeader.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbIds.Properties.AppearanceDropDownHeader.Options.UseFont = True
        Me.cbIds.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbIds.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("FechaHora", "Fecha")})
        Me.cbIds.Properties.NullText = ""
        Me.cbIds.Properties.PopupSizeable = False
        Me.cbIds.Properties.PopupWidthMode = DevExpress.XtraEditors.PopupWidthMode.ContentWidth
        Me.cbIds.Size = New System.Drawing.Size(307, 26)
        Me.cbIds.TabIndex = 8
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(6, 77)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(130, 19)
        Me.LabelControl2.TabIndex = 5
        Me.LabelControl2.Text = "Tipo de inventario:"
        '
        'cbTipoInventario
        '
        Me.cbTipoInventario.Location = New System.Drawing.Point(142, 74)
        Me.cbTipoInventario.Name = "cbTipoInventario"
        Me.cbTipoInventario.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTipoInventario.Properties.Appearance.Options.UseFont = True
        Me.cbTipoInventario.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.cbTipoInventario.Properties.AppearanceDropDown.Options.UseFont = True
        Me.cbTipoInventario.Properties.AppearanceDropDownHeader.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTipoInventario.Properties.AppearanceDropDownHeader.Options.UseFont = True
        Me.cbTipoInventario.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbTipoInventario.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Tipo", "Tipo")})
        Me.cbTipoInventario.Properties.DropDownRows = 3
        Me.cbTipoInventario.Properties.NullText = ""
        Me.cbTipoInventario.Properties.PopupSizeable = False
        Me.cbTipoInventario.Properties.PopupWidthMode = DevExpress.XtraEditors.PopupWidthMode.ContentWidth
        Me.cbTipoInventario.Size = New System.Drawing.Size(185, 26)
        Me.cbTipoInventario.TabIndex = 6
        '
        'GroupControl2
        '
        Me.GroupControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl2.AppearanceCaption.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl2.AppearanceCaption.Options.UseFont = True
        Me.GroupControl2.Controls.Add(Me.dgvPallets)
        ButtonImageOptions1.Image = CType(resources.GetObject("ButtonImageOptions1.Image"), System.Drawing.Image)
        Me.GroupControl2.CustomHeaderButtons.AddRange(New DevExpress.XtraEditors.ButtonPanel.IBaseButton() {New DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("", True, ButtonImageOptions1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "Exportar a .XLSX", -1, True, Nothing, True, False, True, Nothing, -1)})
        Me.GroupControl2.CustomHeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText
        Me.GroupControl2.Location = New System.Drawing.Point(9, 128)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(1063, 176)
        Me.GroupControl2.TabIndex = 1
        Me.GroupControl2.Text = "Total de pallets a inventariar"
        '
        'dgvPallets
        '
        Me.dgvPallets.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvPallets.Location = New System.Drawing.Point(5, 40)
        Me.dgvPallets.MainView = Me.GridViewTotal
        Me.dgvPallets.Name = "dgvPallets"
        Me.dgvPallets.Size = New System.Drawing.Size(1052, 131)
        Me.dgvPallets.TabIndex = 0
        Me.dgvPallets.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewTotal})
        '
        'GridViewTotal
        '
        Me.GridViewTotal.Appearance.EvenRow.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridViewTotal.Appearance.EvenRow.Options.UseFont = True
        Me.GridViewTotal.Appearance.FixedLine.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridViewTotal.Appearance.FixedLine.Options.UseFont = True
        Me.GridViewTotal.Appearance.FocusedRow.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridViewTotal.Appearance.FocusedRow.Options.UseFont = True
        Me.GridViewTotal.Appearance.FooterPanel.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.GridViewTotal.Appearance.FooterPanel.Options.UseFont = True
        Me.GridViewTotal.Appearance.GroupFooter.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.GridViewTotal.Appearance.GroupFooter.Options.UseFont = True
        Me.GridViewTotal.Appearance.GroupRow.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridViewTotal.Appearance.GroupRow.Options.UseFont = True
        Me.GridViewTotal.Appearance.HeaderPanel.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridViewTotal.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridViewTotal.Appearance.OddRow.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridViewTotal.Appearance.OddRow.Options.UseFont = True
        Me.GridViewTotal.Appearance.Preview.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.GridViewTotal.Appearance.Preview.Options.UseFont = True
        Me.GridViewTotal.Appearance.Row.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridViewTotal.Appearance.Row.Options.UseFont = True
        Me.GridViewTotal.Appearance.RowSeparator.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridViewTotal.Appearance.RowSeparator.Options.UseFont = True
        Me.GridViewTotal.Appearance.SelectedRow.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridViewTotal.Appearance.SelectedRow.Options.UseFont = True
        Me.GridViewTotal.Appearance.TopNewRow.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridViewTotal.Appearance.TopNewRow.Options.UseFont = True
        Me.GridViewTotal.GridControl = Me.dgvPallets
        Me.GridViewTotal.Name = "GridViewTotal"
        Me.GridViewTotal.OptionsBehavior.Editable = False
        Me.GridViewTotal.OptionsView.ColumnAutoWidth = False
        Me.GridViewTotal.OptionsView.ShowGroupPanel = False
        '
        'GroupControl3
        '
        Me.GroupControl3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl3.AppearanceCaption.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl3.AppearanceCaption.Options.UseFont = True
        Me.GroupControl3.Controls.Add(Me.btnCancelar)
        Me.GroupControl3.Controls.Add(Me.btnCierra)
        Me.GroupControl3.Location = New System.Drawing.Point(816, 12)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(257, 110)
        Me.GroupControl3.TabIndex = 1
        Me.GroupControl3.Text = "Acciones"
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnCancelar.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Appearance.Options.UseFont = True
        Me.btnCancelar.Appearance.Options.UseTextOptions = True
        Me.btnCancelar.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnCancelar.Location = New System.Drawing.Point(132, 42)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(112, 50)
        Me.btnCancelar.TabIndex = 1
        Me.btnCancelar.Text = "Cancelar Inventario"
        '
        'btnCierra
        '
        Me.btnCierra.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnCierra.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCierra.Appearance.Options.UseFont = True
        Me.btnCierra.Appearance.Options.UseTextOptions = True
        Me.btnCierra.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnCierra.Location = New System.Drawing.Point(14, 42)
        Me.btnCierra.Name = "btnCierra"
        Me.btnCierra.Size = New System.Drawing.Size(112, 50)
        Me.btnCierra.TabIndex = 0
        Me.btnCierra.Text = "Cerrar Inventario"
        '
        'GroupControl4
        '
        Me.GroupControl4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl4.AppearanceCaption.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl4.AppearanceCaption.Options.UseFont = True
        Me.GroupControl4.Controls.Add(Me.dgvPalletsNoLeidos)
        ButtonImageOptions2.Image = CType(resources.GetObject("ButtonImageOptions2.Image"), System.Drawing.Image)
        Me.GroupControl4.CustomHeaderButtons.AddRange(New DevExpress.XtraEditors.ButtonPanel.IBaseButton() {New DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("", True, ButtonImageOptions2, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "Exportar a .XLSX", -1, True, Nothing, True, False, True, Nothing, -1)})
        Me.GroupControl4.CustomHeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText
        Me.GroupControl4.Location = New System.Drawing.Point(9, 310)
        Me.GroupControl4.Name = "GroupControl4"
        Me.GroupControl4.Size = New System.Drawing.Size(1063, 192)
        Me.GroupControl4.TabIndex = 1
        Me.GroupControl4.Text = "Pallets sin lectura"
        '
        'dgvPalletsNoLeidos
        '
        Me.dgvPalletsNoLeidos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvPalletsNoLeidos.Location = New System.Drawing.Point(5, 40)
        Me.dgvPalletsNoLeidos.MainView = Me.GridViewSinLec
        Me.dgvPalletsNoLeidos.Name = "dgvPalletsNoLeidos"
        Me.dgvPalletsNoLeidos.Size = New System.Drawing.Size(1052, 147)
        Me.dgvPalletsNoLeidos.TabIndex = 1
        Me.dgvPalletsNoLeidos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewSinLec})
        '
        'GridViewSinLec
        '
        Me.GridViewSinLec.Appearance.EvenRow.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridViewSinLec.Appearance.EvenRow.Options.UseFont = True
        Me.GridViewSinLec.Appearance.FixedLine.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridViewSinLec.Appearance.FixedLine.Options.UseFont = True
        Me.GridViewSinLec.Appearance.FocusedRow.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridViewSinLec.Appearance.FocusedRow.Options.UseFont = True
        Me.GridViewSinLec.Appearance.FooterPanel.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.GridViewSinLec.Appearance.FooterPanel.Options.UseFont = True
        Me.GridViewSinLec.Appearance.GroupFooter.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.GridViewSinLec.Appearance.GroupFooter.Options.UseFont = True
        Me.GridViewSinLec.Appearance.GroupRow.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridViewSinLec.Appearance.GroupRow.Options.UseFont = True
        Me.GridViewSinLec.Appearance.HeaderPanel.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridViewSinLec.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridViewSinLec.Appearance.OddRow.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridViewSinLec.Appearance.OddRow.Options.UseFont = True
        Me.GridViewSinLec.Appearance.Preview.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.GridViewSinLec.Appearance.Preview.Options.UseFont = True
        Me.GridViewSinLec.Appearance.Row.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridViewSinLec.Appearance.Row.Options.UseFont = True
        Me.GridViewSinLec.Appearance.RowSeparator.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridViewSinLec.Appearance.RowSeparator.Options.UseFont = True
        Me.GridViewSinLec.Appearance.SelectedRow.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridViewSinLec.Appearance.SelectedRow.Options.UseFont = True
        Me.GridViewSinLec.Appearance.TopNewRow.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridViewSinLec.Appearance.TopNewRow.Options.UseFont = True
        Me.GridViewSinLec.GridControl = Me.dgvPalletsNoLeidos
        Me.GridViewSinLec.Name = "GridViewSinLec"
        Me.GridViewSinLec.OptionsBehavior.Editable = False
        Me.GridViewSinLec.OptionsView.ColumnAutoWidth = False
        Me.GridViewSinLec.OptionsView.ShowGroupPanel = False
        '
        'GroupControl5
        '
        Me.GroupControl5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl5.AppearanceCaption.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl5.AppearanceCaption.Options.UseFont = True
        Me.GroupControl5.Controls.Add(Me.dgvPalletsEnRegistro)
        ButtonImageOptions3.Image = CType(resources.GetObject("ButtonImageOptions3.Image"), System.Drawing.Image)
        Me.GroupControl5.CustomHeaderButtons.AddRange(New DevExpress.XtraEditors.ButtonPanel.IBaseButton() {New DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("", True, ButtonImageOptions3, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "Exportar a .XLSX", -1, True, Nothing, True, False, True, Nothing, -1)})
        Me.GroupControl5.CustomHeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText
        Me.GroupControl5.Location = New System.Drawing.Point(9, 508)
        Me.GroupControl5.Name = "GroupControl5"
        Me.GroupControl5.Size = New System.Drawing.Size(1063, 135)
        Me.GroupControl5.TabIndex = 1
        Me.GroupControl5.Text = "Pallets leídos"
        '
        'dgvPalletsEnRegistro
        '
        Me.dgvPalletsEnRegistro.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvPalletsEnRegistro.Location = New System.Drawing.Point(5, 40)
        Me.dgvPalletsEnRegistro.MainView = Me.GridViewLeido
        Me.dgvPalletsEnRegistro.Name = "dgvPalletsEnRegistro"
        Me.dgvPalletsEnRegistro.Size = New System.Drawing.Size(1052, 89)
        Me.dgvPalletsEnRegistro.TabIndex = 2
        Me.dgvPalletsEnRegistro.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewLeido})
        '
        'GridViewLeido
        '
        Me.GridViewLeido.Appearance.EvenRow.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.GridViewLeido.Appearance.EvenRow.Options.UseFont = True
        Me.GridViewLeido.Appearance.FixedLine.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridViewLeido.Appearance.FixedLine.Options.UseFont = True
        Me.GridViewLeido.Appearance.FocusedRow.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.GridViewLeido.Appearance.FocusedRow.Options.UseFont = True
        Me.GridViewLeido.Appearance.FooterPanel.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.GridViewLeido.Appearance.FooterPanel.Options.UseFont = True
        Me.GridViewLeido.Appearance.GroupFooter.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.GridViewLeido.Appearance.GroupFooter.Options.UseFont = True
        Me.GridViewLeido.Appearance.GroupRow.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.GridViewLeido.Appearance.GroupRow.Options.UseFont = True
        Me.GridViewLeido.Appearance.HeaderPanel.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridViewLeido.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridViewLeido.Appearance.OddRow.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.GridViewLeido.Appearance.OddRow.Options.UseFont = True
        Me.GridViewLeido.Appearance.Preview.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.GridViewLeido.Appearance.Preview.Options.UseFont = True
        Me.GridViewLeido.Appearance.Row.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.GridViewLeido.Appearance.Row.Options.UseFont = True
        Me.GridViewLeido.Appearance.RowSeparator.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.GridViewLeido.Appearance.RowSeparator.Options.UseFont = True
        Me.GridViewLeido.Appearance.SelectedRow.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.GridViewLeido.Appearance.SelectedRow.Options.UseFont = True
        Me.GridViewLeido.Appearance.TopNewRow.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.GridViewLeido.Appearance.TopNewRow.Options.UseFont = True
        Me.GridViewLeido.GridControl = Me.dgvPalletsEnRegistro
        Me.GridViewLeido.Name = "GridViewLeido"
        Me.GridViewLeido.OptionsBehavior.Editable = False
        Me.GridViewLeido.OptionsView.ColumnAutoWidth = False
        Me.GridViewLeido.OptionsView.ShowGroupPanel = False
        '
        'FrmMonitorInventarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1080, 652)
        Me.Controls.Add(Me.GroupControl5)
        Me.Controls.Add(Me.GroupControl4)
        Me.Controls.Add(Me.GroupControl3)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.IconOptions.Icon = CType(resources.GetObject("FrmMonitorInventarios.IconOptions.Icon"), System.Drawing.Icon)
        Me.IconOptions.Image = Global.AXCVDE.My.Resources.Resources.Logo_X_150x150_01
        Me.LookAndFeel.TouchUIMode = DevExpress.Utils.DefaultBoolean.[False]
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmMonitorInventarios"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Monitor de ejercicios de inventario"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.cmbAlmacen.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbIds.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbTipoInventario.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.dgvPallets, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl4.ResumeLayout(False)
        CType(Me.dgvPalletsNoLeidos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewSinLec, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl5.ResumeLayout(False)
        CType(Me.dgvPalletsEnRegistro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewLeido, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl4 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl5 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents dgvPallets As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewTotal As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents dgvPalletsNoLeidos As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewSinLec As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents dgvPalletsEnRegistro As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewLeido As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbIds As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbTipoInventario As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents btnCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCierra As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmbAlmacen As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents BtnActualizar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
End Class
