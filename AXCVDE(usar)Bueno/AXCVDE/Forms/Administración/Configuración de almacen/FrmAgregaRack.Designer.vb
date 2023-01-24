<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAgregaRack
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
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.NupNivel = New DevExpress.XtraEditors.SpinEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.TxtCapacidad = New DevExpress.XtraEditors.TextEdit()
        Me.NupPos = New DevExpress.XtraEditors.SpinEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.cmbTipo = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtRack = New DevExpress.XtraEditors.TextEdit()
        Me.ChkPiso = New DevExpress.XtraEditors.CheckEdit()
        Me.ChkRack = New DevExpress.XtraEditors.CheckEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.CmbAlmacen = New DevExpress.XtraEditors.LookUpEdit()
        Me.BtnAgregaRack = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.NupNivel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtCapacidad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NupPos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbTipo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRack.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChkPiso.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChkRack.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CmbAlmacen.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.GroupControl1.Controls.Add(Me.NupNivel)
        Me.GroupControl1.Controls.Add(Me.LabelControl6)
        Me.GroupControl1.Controls.Add(Me.TxtCapacidad)
        Me.GroupControl1.Controls.Add(Me.NupPos)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.LabelControl5)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.cmbTipo)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.txtRack)
        Me.GroupControl1.Controls.Add(Me.ChkPiso)
        Me.GroupControl1.Controls.Add(Me.ChkRack)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.CmbAlmacen)
        Me.GroupControl1.Controls.Add(Me.BtnAgregaRack)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 12)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(483, 183)
        Me.GroupControl1.TabIndex = 465
        Me.GroupControl1.Text = "Seleccionar ubicación"
        '
        'NupNivel
        '
        Me.NupNivel.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NupNivel.Location = New System.Drawing.Point(413, 70)
        Me.NupNivel.Name = "NupNivel"
        Me.NupNivel.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NupNivel.Properties.Appearance.Options.UseFont = True
        Me.NupNivel.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.NupNivel.Properties.IsFloatValue = False
        Me.NupNivel.Properties.MaskSettings.Set("mask", "N00")
        Me.NupNivel.Properties.MaxValue = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.NupNivel.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NupNivel.Size = New System.Drawing.Size(56, 26)
        Me.NupNivel.TabIndex = 198
        '
        'LabelControl6
        '
        Me.LabelControl6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Appearance.Options.UseFont = True
        Me.LabelControl6.Appearance.Options.UseTextOptions = True
        Me.LabelControl6.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.LabelControl6.Location = New System.Drawing.Point(304, 73)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(103, 19)
        Me.LabelControl6.TabIndex = 197
        Me.LabelControl6.Text = "No. De Niveles:"
        '
        'TxtCapacidad
        '
        Me.TxtCapacidad.Location = New System.Drawing.Point(413, 102)
        Me.TxtCapacidad.Name = "TxtCapacidad"
        Me.TxtCapacidad.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCapacidad.Properties.Appearance.Options.UseFont = True
        Me.TxtCapacidad.Size = New System.Drawing.Size(56, 26)
        Me.TxtCapacidad.TabIndex = 196
        '
        'NupPos
        '
        Me.NupPos.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NupPos.Location = New System.Drawing.Point(413, 38)
        Me.NupPos.Name = "NupPos"
        Me.NupPos.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NupPos.Properties.Appearance.Options.UseFont = True
        Me.NupPos.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.NupPos.Properties.IsFloatValue = False
        Me.NupPos.Properties.MaskSettings.Set("mask", "N00")
        Me.NupPos.Properties.MaxValue = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.NupPos.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NupPos.Size = New System.Drawing.Size(56, 26)
        Me.NupPos.TabIndex = 195
        '
        'LabelControl4
        '
        Me.LabelControl4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Appearance.Options.UseTextOptions = True
        Me.LabelControl4.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.LabelControl4.Location = New System.Drawing.Point(282, 41)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(125, 19)
        Me.LabelControl4.TabIndex = 194
        Me.LabelControl4.Text = "No. De posiciones:"
        '
        'LabelControl5
        '
        Me.LabelControl5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Location = New System.Drawing.Point(333, 105)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(74, 19)
        Me.LabelControl5.TabIndex = 193
        Me.LabelControl5.Text = "Capacidad:"
        '
        'LabelControl3
        '
        Me.LabelControl3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(47, 128)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(34, 19)
        Me.LabelControl3.TabIndex = 191
        Me.LabelControl3.Text = "Tipo:"
        '
        'cmbTipo
        '
        Me.cmbTipo.Location = New System.Drawing.Point(87, 125)
        Me.cmbTipo.Name = "cmbTipo"
        Me.cmbTipo.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTipo.Properties.Appearance.Options.UseFont = True
        Me.cmbTipo.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTipo.Properties.AppearanceDisabled.Options.UseFont = True
        Me.cmbTipo.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTipo.Properties.AppearanceDropDown.Options.UseFont = True
        Me.cmbTipo.Properties.AppearanceDropDownHeader.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTipo.Properties.AppearanceDropDownHeader.Options.UseFont = True
        Me.cmbTipo.Properties.AppearanceFocused.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTipo.Properties.AppearanceFocused.Options.UseFont = True
        Me.cmbTipo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbTipo.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DTipo", "Tipo de ubicación", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.Ascending, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.cmbTipo.Properties.NullText = ""
        Me.cmbTipo.Properties.PopupSizeable = False
        Me.cmbTipo.Size = New System.Drawing.Size(171, 26)
        Me.cmbTipo.TabIndex = 192
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(10, 96)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(71, 19)
        Me.LabelControl2.TabIndex = 190
        Me.LabelControl2.Text = "Ubicación:"
        '
        'txtRack
        '
        Me.txtRack.Location = New System.Drawing.Point(87, 93)
        Me.txtRack.Name = "txtRack"
        Me.txtRack.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRack.Properties.Appearance.Options.UseFont = True
        Me.txtRack.Properties.BeepOnError = False
        Me.txtRack.Properties.MaxLength = 5
        Me.txtRack.Size = New System.Drawing.Size(171, 26)
        Me.txtRack.TabIndex = 189
        '
        'ChkPiso
        '
        Me.ChkPiso.Location = New System.Drawing.Point(166, 67)
        Me.ChkPiso.Name = "ChkPiso"
        Me.ChkPiso.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkPiso.Properties.Appearance.Options.UseFont = True
        Me.ChkPiso.Properties.Caption = "Piso"
        Me.ChkPiso.Size = New System.Drawing.Size(75, 23)
        Me.ChkPiso.TabIndex = 188
        '
        'ChkRack
        '
        Me.ChkRack.Location = New System.Drawing.Point(85, 67)
        Me.ChkRack.Name = "ChkRack"
        Me.ChkRack.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkRack.Properties.Appearance.Options.UseFont = True
        Me.ChkRack.Properties.Caption = "Rack"
        Me.ChkRack.Size = New System.Drawing.Size(75, 23)
        Me.ChkRack.TabIndex = 187
        '
        'LabelControl1
        '
        Me.LabelControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(16, 41)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(63, 19)
        Me.LabelControl1.TabIndex = 185
        Me.LabelControl1.Text = "Almacén:"
        '
        'CmbAlmacen
        '
        Me.CmbAlmacen.Location = New System.Drawing.Point(85, 38)
        Me.CmbAlmacen.Name = "CmbAlmacen"
        Me.CmbAlmacen.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbAlmacen.Properties.Appearance.Options.UseFont = True
        Me.CmbAlmacen.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbAlmacen.Properties.AppearanceDisabled.Options.UseFont = True
        Me.CmbAlmacen.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbAlmacen.Properties.AppearanceDropDown.Options.UseFont = True
        Me.CmbAlmacen.Properties.AppearanceDropDownHeader.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbAlmacen.Properties.AppearanceDropDownHeader.Options.UseFont = True
        Me.CmbAlmacen.Properties.AppearanceFocused.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbAlmacen.Properties.AppearanceFocused.Options.UseFont = True
        Me.CmbAlmacen.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CmbAlmacen.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ERPAlmacen", "Almacen")})
        Me.CmbAlmacen.Properties.NullText = ""
        Me.CmbAlmacen.Properties.PopupSizeable = False
        Me.CmbAlmacen.Size = New System.Drawing.Size(173, 26)
        Me.CmbAlmacen.TabIndex = 186
        '
        'BtnAgregaRack
        '
        Me.BtnAgregaRack.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAgregaRack.Appearance.Options.UseFont = True
        Me.BtnAgregaRack.Appearance.Options.UseTextOptions = True
        Me.BtnAgregaRack.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.BtnAgregaRack.Location = New System.Drawing.Point(363, 134)
        Me.BtnAgregaRack.Name = "BtnAgregaRack"
        Me.BtnAgregaRack.Size = New System.Drawing.Size(106, 36)
        Me.BtnAgregaRack.TabIndex = 180
        Me.BtnAgregaRack.Text = "Agregar"
        '
        'FrmAgregaRack
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(505, 210)
        Me.Controls.Add(Me.GroupControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.IconOptions.Image = Global.AXCVDE.My.Resources.Resources.Logo_X_150x150_01
        Me.LookAndFeel.TouchUIMode = DevExpress.Utils.DefaultBoolean.[False]
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmAgregaRack"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar ubicación"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.NupNivel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtCapacidad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NupPos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbTipo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRack.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChkPiso.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChkRack.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CmbAlmacen.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents ChkPiso As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ChkRack As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents CmbAlmacen As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents BtnAgregaRack As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtRack As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbTipo As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents NupNivel As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtCapacidad As DevExpress.XtraEditors.TextEdit
    Friend WithEvents NupPos As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
End Class
