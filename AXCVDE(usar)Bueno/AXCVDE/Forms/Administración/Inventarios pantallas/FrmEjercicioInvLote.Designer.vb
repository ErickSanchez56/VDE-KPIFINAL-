<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEjercicioInvLote
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
        Me.txtTipoEjercicio = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtComentarios = New DevExpress.XtraEditors.MemoEdit()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.btnGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.dgvPosSelect = New DevExpress.XtraGrid.GridControl()
        Me.GridViewSelect = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtDescripcion = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.cmbNumParte = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.NumParte = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DNumParte1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cmbAlmacen = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.txtTipoEjercicio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtComentarios.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.dgvPosSelect, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewSelect, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescripcion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbNumParte.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbAlmacen.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtTipoEjercicio
        '
        Me.txtTipoEjercicio.Location = New System.Drawing.Point(12, 31)
        Me.txtTipoEjercicio.Name = "txtTipoEjercicio"
        Me.txtTipoEjercicio.Properties.ReadOnly = True
        Me.txtTipoEjercicio.Size = New System.Drawing.Size(233, 20)
        Me.txtTipoEjercicio.TabIndex = 135
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(337, 12)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(76, 15)
        Me.LabelControl2.TabIndex = 134
        Me.LabelControl2.Text = "Comentarios:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(12, 12)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(103, 15)
        Me.LabelControl1.TabIndex = 133
        Me.LabelControl1.Text = "Tipo de inventario:"
        '
        'txtComentarios
        '
        Me.txtComentarios.Location = New System.Drawing.Point(337, 33)
        Me.txtComentarios.Name = "txtComentarios"
        Me.txtComentarios.Size = New System.Drawing.Size(417, 80)
        Me.txtComentarios.TabIndex = 136
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.btnGuardar)
        Me.GroupControl1.Controls.Add(Me.dgvPosSelect)
        Me.GroupControl1.Controls.Add(Me.txtDescripcion)
        Me.GroupControl1.Controls.Add(Me.LabelControl7)
        Me.GroupControl1.Controls.Add(Me.LabelControl13)
        Me.GroupControl1.Controls.Add(Me.cmbNumParte)
        Me.GroupControl1.Location = New System.Drawing.Point(8, 119)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(746, 296)
        Me.GroupControl1.TabIndex = 137
        Me.GroupControl1.Text = "Seleccionar producto"
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnGuardar.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Appearance.Options.UseFont = True
        Me.btnGuardar.Location = New System.Drawing.Point(613, 235)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(118, 41)
        Me.btnGuardar.TabIndex = 129
        Me.btnGuardar.Text = "Guardar Inventario"
        '
        'dgvPosSelect
        '
        Me.dgvPosSelect.Location = New System.Drawing.Point(434, 42)
        Me.dgvPosSelect.MainView = Me.GridViewSelect
        Me.dgvPosSelect.Name = "dgvPosSelect"
        Me.dgvPosSelect.Size = New System.Drawing.Size(297, 187)
        Me.dgvPosSelect.TabIndex = 126
        Me.dgvPosSelect.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewSelect})
        '
        'GridViewSelect
        '
        Me.GridViewSelect.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1})
        Me.GridViewSelect.GridControl = Me.dgvPosSelect
        Me.GridViewSelect.Name = "GridViewSelect"
        Me.GridViewSelect.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridViewSelect.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridViewSelect.OptionsBehavior.Editable = False
        Me.GridViewSelect.OptionsLayout.Columns.AddNewColumns = False
        Me.GridViewSelect.OptionsSelection.MultiSelect = True
        Me.GridViewSelect.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect
        Me.GridViewSelect.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Lote"
        Me.GridColumn1.FieldName = "LoteAXC"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 1
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Enabled = False
        Me.txtDescripcion.Location = New System.Drawing.Point(84, 66)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(289, 20)
        Me.txtDescripcion.TabIndex = 113
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl7.Appearance.Options.UseFont = True
        Me.LabelControl7.Location = New System.Drawing.Point(23, 41)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(55, 15)
        Me.LabelControl7.TabIndex = 111
        Me.LabelControl7.Text = "Producto:"
        '
        'LabelControl13
        '
        Me.LabelControl13.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl13.Appearance.Options.UseFont = True
        Me.LabelControl13.Location = New System.Drawing.Point(7, 68)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(71, 15)
        Me.LabelControl13.TabIndex = 112
        Me.LabelControl13.Text = "Descripción:"
        '
        'cmbNumParte
        '
        Me.cmbNumParte.Location = New System.Drawing.Point(84, 39)
        Me.cmbNumParte.Name = "cmbNumParte"
        Me.cmbNumParte.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbNumParte.Properties.NullText = ""
        Me.cmbNumParte.Properties.PopupSizeable = False
        Me.cmbNumParte.Properties.PopupView = Me.GridLookUpEdit1View
        Me.cmbNumParte.Size = New System.Drawing.Size(289, 20)
        Me.cmbNumParte.TabIndex = 110
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.NumParte, Me.DNumParte1})
        Me.GridLookUpEdit1View.DetailHeight = 303
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'NumParte
        '
        Me.NumParte.Caption = "Artículo"
        Me.NumParte.FieldName = "NumParte"
        Me.NumParte.MinWidth = 17
        Me.NumParte.Name = "NumParte"
        Me.NumParte.Visible = True
        Me.NumParte.VisibleIndex = 0
        Me.NumParte.Width = 64
        '
        'DNumParte1
        '
        Me.DNumParte1.Caption = "Descripción"
        Me.DNumParte1.FieldName = "DNumParte1"
        Me.DNumParte1.MinWidth = 17
        Me.DNumParte1.Name = "DNumParte1"
        Me.DNumParte1.Visible = True
        Me.DNumParte1.VisibleIndex = 1
        Me.DNumParte1.Width = 64
        '
        'cmbAlmacen
        '
        Me.cmbAlmacen.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbAlmacen.Location = New System.Drawing.Point(71, 57)
        Me.cmbAlmacen.Name = "cmbAlmacen"
        Me.cmbAlmacen.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbAlmacen.Properties.NullText = ""
        Me.cmbAlmacen.Properties.PopupSizeable = False
        Me.cmbAlmacen.Properties.PopupView = Me.GridView3
        Me.cmbAlmacen.Size = New System.Drawing.Size(251, 20)
        Me.cmbAlmacen.TabIndex = 138
        '
        'GridView3
        '
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
        'LabelControl3
        '
        Me.LabelControl3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(12, 59)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(53, 15)
        Me.LabelControl3.TabIndex = 139
        Me.LabelControl3.Text = "Almacén:"
        '
        'FrmEjercicioInvLote
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(766, 427)
        Me.Controls.Add(Me.cmbAlmacen)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.txtTipoEjercicio)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txtComentarios)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.IconOptions.Image = Global.AXCCiesa.My.Resources.Resources.Logo_X_150x150_01
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmEjercicioInvLote"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inventario por lote"
        CType(Me.txtTipoEjercicio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtComentarios.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.dgvPosSelect, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewSelect, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescripcion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbNumParte.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents txtDescripcion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbNumParte As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents NumParte As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DNumParte1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents dgvPosSelect As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewSelect As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmbAlmacen As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
End Class
