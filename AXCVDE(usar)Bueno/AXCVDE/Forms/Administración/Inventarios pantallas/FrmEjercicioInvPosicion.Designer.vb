<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEjercicioInvPosicion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEjercicioInvPosicion))
        Me.txtTipoEjercicio = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtComentarios = New DevExpress.XtraEditors.MemoEdit()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.btnEliminarRack = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAgregarRack = New DevExpress.XtraEditors.SimpleButton()
        Me.dgvPasillosRack = New DevExpress.XtraGrid.GridControl()
        Me.GridViewRack = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.cbPasillosRack = New DevExpress.XtraEditors.LookUpEdit()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.btnEliminarPos = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAgregarPos = New DevExpress.XtraEditors.SimpleButton()
        Me.dgvPosSelect = New DevExpress.XtraGrid.GridControl()
        Me.GridViewSelect = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.dgvPos = New DevExpress.XtraGrid.GridControl()
        Me.GridViewPos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.cbPasillosAmbos = New DevExpress.XtraEditors.LookUpEdit()
        Me.btnGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmbAlmacen = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.txtTipoEjercicio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtComentarios.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.dgvPasillosRack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewRack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbPasillosRack.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.dgvPosSelect, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewSelect, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvPos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewPos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbPasillosAmbos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbAlmacen.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtTipoEjercicio
        '
        Me.txtTipoEjercicio.Location = New System.Drawing.Point(144, 30)
        Me.txtTipoEjercicio.Name = "txtTipoEjercicio"
        Me.txtTipoEjercicio.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.txtTipoEjercicio.Properties.Appearance.Options.UseFont = True
        Me.txtTipoEjercicio.Properties.ReadOnly = True
        Me.txtTipoEjercicio.Size = New System.Drawing.Size(193, 26)
        Me.txtTipoEjercicio.TabIndex = 131
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(343, 6)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(90, 19)
        Me.LabelControl2.TabIndex = 130
        Me.LabelControl2.Text = "Comentarios:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(8, 32)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(130, 19)
        Me.LabelControl1.TabIndex = 129
        Me.LabelControl1.Text = "Tipo de inventario:"
        '
        'txtComentarios
        '
        Me.txtComentarios.Location = New System.Drawing.Point(343, 31)
        Me.txtComentarios.Name = "txtComentarios"
        Me.txtComentarios.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.txtComentarios.Properties.Appearance.Options.UseFont = True
        Me.txtComentarios.Size = New System.Drawing.Size(251, 62)
        Me.txtComentarios.TabIndex = 132
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.btnEliminarRack)
        Me.GroupControl1.Controls.Add(Me.btnAgregarRack)
        Me.GroupControl1.Controls.Add(Me.dgvPasillosRack)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.cbPasillosRack)
        Me.GroupControl1.Location = New System.Drawing.Point(8, 108)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(591, 189)
        Me.GroupControl1.TabIndex = 133
        Me.GroupControl1.Text = "Agregar ubicación completa"
        '
        'btnEliminarRack
        '
        Me.btnEliminarRack.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnEliminarRack.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarRack.Appearance.Options.UseFont = True
        Me.btnEliminarRack.Appearance.Options.UseTextOptions = True
        Me.btnEliminarRack.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnEliminarRack.Location = New System.Drawing.Point(112, 150)
        Me.btnEliminarRack.Name = "btnEliminarRack"
        Me.btnEliminarRack.Size = New System.Drawing.Size(88, 34)
        Me.btnEliminarRack.TabIndex = 43
        Me.btnEliminarRack.Text = "Eliminar"
        '
        'btnAgregarRack
        '
        Me.btnAgregarRack.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnAgregarRack.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarRack.Appearance.Options.UseFont = True
        Me.btnAgregarRack.Appearance.Options.UseTextOptions = True
        Me.btnAgregarRack.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnAgregarRack.Location = New System.Drawing.Point(10, 150)
        Me.btnAgregarRack.Name = "btnAgregarRack"
        Me.btnAgregarRack.Size = New System.Drawing.Size(88, 34)
        Me.btnAgregarRack.TabIndex = 42
        Me.btnAgregarRack.Text = "Agregar"
        '
        'dgvPasillosRack
        '
        Me.dgvPasillosRack.Location = New System.Drawing.Point(215, 30)
        Me.dgvPasillosRack.MainView = Me.GridViewRack
        Me.dgvPasillosRack.Name = "dgvPasillosRack"
        Me.dgvPasillosRack.Size = New System.Drawing.Size(371, 154)
        Me.dgvPasillosRack.TabIndex = 7
        Me.dgvPasillosRack.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewRack})
        '
        'GridViewRack
        '
        Me.GridViewRack.Appearance.EvenRow.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.GridViewRack.Appearance.EvenRow.Options.UseFont = True
        Me.GridViewRack.Appearance.FixedLine.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridViewRack.Appearance.FixedLine.Options.UseFont = True
        Me.GridViewRack.Appearance.FocusedRow.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.GridViewRack.Appearance.FocusedRow.Options.UseFont = True
        Me.GridViewRack.Appearance.FooterPanel.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.GridViewRack.Appearance.FooterPanel.Options.UseFont = True
        Me.GridViewRack.Appearance.GroupFooter.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.GridViewRack.Appearance.GroupFooter.Options.UseFont = True
        Me.GridViewRack.Appearance.GroupRow.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.GridViewRack.Appearance.GroupRow.Options.UseFont = True
        Me.GridViewRack.Appearance.HeaderPanel.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridViewRack.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridViewRack.Appearance.OddRow.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.GridViewRack.Appearance.OddRow.Options.UseFont = True
        Me.GridViewRack.Appearance.Preview.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.GridViewRack.Appearance.Preview.Options.UseFont = True
        Me.GridViewRack.Appearance.Row.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.GridViewRack.Appearance.Row.Options.UseFont = True
        Me.GridViewRack.Appearance.RowSeparator.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.GridViewRack.Appearance.RowSeparator.Options.UseFont = True
        Me.GridViewRack.Appearance.SelectedRow.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.GridViewRack.Appearance.SelectedRow.Options.UseFont = True
        Me.GridViewRack.Appearance.TopNewRow.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.GridViewRack.Appearance.TopNewRow.Options.UseFont = True
        Me.GridViewRack.GridControl = Me.dgvPasillosRack
        Me.GridViewRack.Name = "GridViewRack"
        Me.GridViewRack.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridViewRack.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridViewRack.OptionsBehavior.Editable = False
        Me.GridViewRack.OptionsLayout.Columns.AddNewColumns = False
        Me.GridViewRack.OptionsView.ShowGroupPanel = False
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(10, 48)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(71, 19)
        Me.LabelControl3.TabIndex = 5
        Me.LabelControl3.Text = "Ubicación:"
        '
        'cbPasillosRack
        '
        Me.cbPasillosRack.Location = New System.Drawing.Point(87, 45)
        Me.cbPasillosRack.Name = "cbPasillosRack"
        Me.cbPasillosRack.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.cbPasillosRack.Properties.Appearance.Options.UseFont = True
        Me.cbPasillosRack.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.cbPasillosRack.Properties.AppearanceDropDown.Options.UseFont = True
        Me.cbPasillosRack.Properties.AppearanceDropDownHeader.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPasillosRack.Properties.AppearanceDropDownHeader.Options.UseFont = True
        Me.cbPasillosRack.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbPasillosRack.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Rack", "Rack")})
        Me.cbPasillosRack.Properties.NullText = ""
        Me.cbPasillosRack.Properties.PopupSizeable = False
        Me.cbPasillosRack.Properties.PopupWidthMode = DevExpress.XtraEditors.PopupWidthMode.ContentWidth
        Me.cbPasillosRack.Size = New System.Drawing.Size(113, 26)
        Me.cbPasillosRack.TabIndex = 6
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.btnEliminarPos)
        Me.GroupControl2.Controls.Add(Me.btnAgregarPos)
        Me.GroupControl2.Controls.Add(Me.dgvPosSelect)
        Me.GroupControl2.Controls.Add(Me.dgvPos)
        Me.GroupControl2.Controls.Add(Me.LabelControl4)
        Me.GroupControl2.Controls.Add(Me.cbPasillosAmbos)
        Me.GroupControl2.Location = New System.Drawing.Point(8, 303)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(591, 276)
        Me.GroupControl2.TabIndex = 134
        Me.GroupControl2.Text = "Agregar posiciones"
        '
        'btnEliminarPos
        '
        Me.btnEliminarPos.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnEliminarPos.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarPos.Appearance.Options.UseFont = True
        Me.btnEliminarPos.Appearance.Options.UseTextOptions = True
        Me.btnEliminarPos.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnEliminarPos.Location = New System.Drawing.Point(260, 179)
        Me.btnEliminarPos.Name = "btnEliminarPos"
        Me.btnEliminarPos.Size = New System.Drawing.Size(69, 34)
        Me.btnEliminarPos.TabIndex = 127
        Me.btnEliminarPos.Text = "Eliminar"
        '
        'btnAgregarPos
        '
        Me.btnAgregarPos.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnAgregarPos.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarPos.Appearance.Options.UseFont = True
        Me.btnAgregarPos.Appearance.Options.UseTextOptions = True
        Me.btnAgregarPos.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnAgregarPos.Location = New System.Drawing.Point(260, 122)
        Me.btnAgregarPos.Name = "btnAgregarPos"
        Me.btnAgregarPos.Size = New System.Drawing.Size(69, 34)
        Me.btnAgregarPos.TabIndex = 126
        Me.btnAgregarPos.Text = "Agregar"
        '
        'dgvPosSelect
        '
        Me.dgvPosSelect.Location = New System.Drawing.Point(337, 69)
        Me.dgvPosSelect.MainView = Me.GridViewSelect
        Me.dgvPosSelect.Name = "dgvPosSelect"
        Me.dgvPosSelect.Size = New System.Drawing.Size(249, 202)
        Me.dgvPosSelect.TabIndex = 125
        Me.dgvPosSelect.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewSelect})
        '
        'GridViewSelect
        '
        Me.GridViewSelect.Appearance.EvenRow.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.GridViewSelect.Appearance.EvenRow.Options.UseFont = True
        Me.GridViewSelect.Appearance.FixedLine.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridViewSelect.Appearance.FixedLine.Options.UseFont = True
        Me.GridViewSelect.Appearance.FocusedRow.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.GridViewSelect.Appearance.FocusedRow.Options.UseFont = True
        Me.GridViewSelect.Appearance.FooterPanel.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.GridViewSelect.Appearance.FooterPanel.Options.UseFont = True
        Me.GridViewSelect.Appearance.GroupFooter.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.GridViewSelect.Appearance.GroupFooter.Options.UseFont = True
        Me.GridViewSelect.Appearance.GroupRow.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.GridViewSelect.Appearance.GroupRow.Options.UseFont = True
        Me.GridViewSelect.Appearance.HeaderPanel.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridViewSelect.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridViewSelect.Appearance.OddRow.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.GridViewSelect.Appearance.OddRow.Options.UseFont = True
        Me.GridViewSelect.Appearance.Preview.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.GridViewSelect.Appearance.Preview.Options.UseFont = True
        Me.GridViewSelect.Appearance.Row.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.GridViewSelect.Appearance.Row.Options.UseFont = True
        Me.GridViewSelect.Appearance.RowSeparator.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.GridViewSelect.Appearance.RowSeparator.Options.UseFont = True
        Me.GridViewSelect.Appearance.SelectedRow.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.GridViewSelect.Appearance.SelectedRow.Options.UseFont = True
        Me.GridViewSelect.Appearance.TopNewRow.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.GridViewSelect.Appearance.TopNewRow.Options.UseFont = True
        Me.GridViewSelect.GridControl = Me.dgvPosSelect
        Me.GridViewSelect.Name = "GridViewSelect"
        Me.GridViewSelect.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridViewSelect.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridViewSelect.OptionsBehavior.Editable = False
        Me.GridViewSelect.OptionsLayout.Columns.AddNewColumns = False
        Me.GridViewSelect.OptionsView.ShowGroupPanel = False
        '
        'dgvPos
        '
        Me.dgvPos.Location = New System.Drawing.Point(10, 69)
        Me.dgvPos.MainView = Me.GridViewPos
        Me.dgvPos.Name = "dgvPos"
        Me.dgvPos.Size = New System.Drawing.Size(244, 202)
        Me.dgvPos.TabIndex = 124
        Me.dgvPos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewPos})
        '
        'GridViewPos
        '
        Me.GridViewPos.Appearance.EvenRow.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.GridViewPos.Appearance.EvenRow.Options.UseFont = True
        Me.GridViewPos.Appearance.FixedLine.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridViewPos.Appearance.FixedLine.Options.UseFont = True
        Me.GridViewPos.Appearance.FocusedRow.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.GridViewPos.Appearance.FocusedRow.Options.UseFont = True
        Me.GridViewPos.Appearance.FooterPanel.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.GridViewPos.Appearance.FooterPanel.Options.UseFont = True
        Me.GridViewPos.Appearance.GroupFooter.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.GridViewPos.Appearance.GroupFooter.Options.UseFont = True
        Me.GridViewPos.Appearance.GroupRow.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.GridViewPos.Appearance.GroupRow.Options.UseFont = True
        Me.GridViewPos.Appearance.HeaderPanel.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridViewPos.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridViewPos.Appearance.OddRow.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.GridViewPos.Appearance.OddRow.Options.UseFont = True
        Me.GridViewPos.Appearance.Preview.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.GridViewPos.Appearance.Preview.Options.UseFont = True
        Me.GridViewPos.Appearance.Row.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.GridViewPos.Appearance.Row.Options.UseFont = True
        Me.GridViewPos.Appearance.RowSeparator.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.GridViewPos.Appearance.RowSeparator.Options.UseFont = True
        Me.GridViewPos.Appearance.SelectedRow.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.GridViewPos.Appearance.SelectedRow.Options.UseFont = True
        Me.GridViewPos.Appearance.TopNewRow.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.GridViewPos.Appearance.TopNewRow.Options.UseFont = True
        Me.GridViewPos.GridControl = Me.dgvPos
        Me.GridViewPos.Name = "GridViewPos"
        Me.GridViewPos.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridViewPos.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridViewPos.OptionsBehavior.Editable = False
        Me.GridViewPos.OptionsLayout.Columns.AddNewColumns = False
        Me.GridViewPos.OptionsView.ShowGroupPanel = False
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(10, 36)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(71, 19)
        Me.LabelControl4.TabIndex = 7
        Me.LabelControl4.Text = "Ubicación:"
        '
        'cbPasillosAmbos
        '
        Me.cbPasillosAmbos.Location = New System.Drawing.Point(87, 34)
        Me.cbPasillosAmbos.Name = "cbPasillosAmbos"
        Me.cbPasillosAmbos.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.cbPasillosAmbos.Properties.Appearance.Options.UseFont = True
        Me.cbPasillosAmbos.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.cbPasillosAmbos.Properties.AppearanceDropDown.Options.UseFont = True
        Me.cbPasillosAmbos.Properties.AppearanceDropDownHeader.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPasillosAmbos.Properties.AppearanceDropDownHeader.Options.UseFont = True
        Me.cbPasillosAmbos.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbPasillosAmbos.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Rack", "Rack")})
        Me.cbPasillosAmbos.Properties.NullText = ""
        Me.cbPasillosAmbos.Properties.PopupSizeable = False
        Me.cbPasillosAmbos.Properties.PopupWidthMode = DevExpress.XtraEditors.PopupWidthMode.ContentWidth
        Me.cbPasillosAmbos.Size = New System.Drawing.Size(167, 26)
        Me.cbPasillosAmbos.TabIndex = 8
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnGuardar.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Appearance.Options.UseFont = True
        Me.btnGuardar.Appearance.Options.UseTextOptions = True
        Me.btnGuardar.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnGuardar.Location = New System.Drawing.Point(437, 585)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(162, 41)
        Me.btnGuardar.TabIndex = 128
        Me.btnGuardar.Text = "Guardar Inventario"
        '
        'cmbAlmacen
        '
        Me.cmbAlmacen.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbAlmacen.Location = New System.Drawing.Point(144, 67)
        Me.cmbAlmacen.Name = "cmbAlmacen"
        Me.cmbAlmacen.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.cmbAlmacen.Properties.Appearance.Options.UseFont = True
        Me.cmbAlmacen.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.cmbAlmacen.Properties.AppearanceDropDown.Options.UseFont = True
        Me.cmbAlmacen.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbAlmacen.Properties.NullText = ""
        Me.cmbAlmacen.Properties.PopupSizeable = False
        Me.cmbAlmacen.Properties.PopupView = Me.GridView3
        Me.cmbAlmacen.Size = New System.Drawing.Size(193, 26)
        Me.cmbAlmacen.TabIndex = 140
        '
        'GridView3
        '
        Me.GridView3.Appearance.Empty.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.GridView3.Appearance.Empty.Options.UseFont = True
        Me.GridView3.Appearance.EvenRow.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.GridView3.Appearance.EvenRow.Options.UseFont = True
        Me.GridView3.Appearance.FixedLine.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView3.Appearance.FixedLine.Options.UseFont = True
        Me.GridView3.Appearance.FocusedRow.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.GridView3.Appearance.FocusedRow.Options.UseFont = True
        Me.GridView3.Appearance.FooterPanel.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.GridView3.Appearance.FooterPanel.Options.UseFont = True
        Me.GridView3.Appearance.GroupFooter.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.GridView3.Appearance.GroupFooter.Options.UseFont = True
        Me.GridView3.Appearance.GroupRow.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.GridView3.Appearance.GroupRow.Options.UseFont = True
        Me.GridView3.Appearance.HeaderPanel.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView3.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridView3.Appearance.OddRow.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.GridView3.Appearance.OddRow.Options.UseFont = True
        Me.GridView3.Appearance.Preview.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.GridView3.Appearance.Preview.Options.UseFont = True
        Me.GridView3.Appearance.Row.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.GridView3.Appearance.Row.Options.UseFont = True
        Me.GridView3.Appearance.RowSeparator.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.GridView3.Appearance.RowSeparator.Options.UseFont = True
        Me.GridView3.Appearance.SelectedRow.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.GridView3.Appearance.SelectedRow.Options.UseFont = True
        Me.GridView3.Appearance.TopNewRow.Font = New System.Drawing.Font("Calibri", 12.0!)
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
        Me.LabelControl5.Location = New System.Drawing.Point(75, 70)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(63, 19)
        Me.LabelControl5.TabIndex = 141
        Me.LabelControl5.Text = "Almacén:"
        '
        'FrmEjercicioInvPosicion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(606, 636)
        Me.Controls.Add(Me.cmbAlmacen)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.txtTipoEjercicio)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txtComentarios)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.IconOptions.Icon = CType(resources.GetObject("FrmEjercicioInvPosicion.IconOptions.Icon"), System.Drawing.Icon)
        Me.IconOptions.Image = Global.AXCVDE.My.Resources.Resources.Logo_X_150x150_01
        Me.LookAndFeel.TouchUIMode = DevExpress.Utils.DefaultBoolean.[False]
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmEjercicioInvPosicion"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Liberar inventario por posición"
        CType(Me.txtTipoEjercicio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtComentarios.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.dgvPasillosRack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewRack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbPasillosRack.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.dgvPosSelect, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewSelect, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvPos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewPos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbPasillosAmbos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbAlmacen.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtTipoEjercicio As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtComentarios As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbPasillosRack As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents dgvPasillosRack As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewRack As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnEliminarRack As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAgregarRack As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbPasillosAmbos As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents btnEliminarPos As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAgregarPos As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dgvPosSelect As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewSelect As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents dgvPos As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewPos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmbAlmacen As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
End Class
