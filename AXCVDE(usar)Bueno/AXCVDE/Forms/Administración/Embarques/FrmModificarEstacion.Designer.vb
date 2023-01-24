<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmModificarEstacion
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
        Me.BtnLiberar = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.CmbLote = New DevExpress.XtraEditors.LookUpEdit()
        Me.CmbEstacion = New DevExpress.XtraEditors.LookUpEdit()
        CType(Me.CmbLote.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CmbEstacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnLiberar
        '
        Me.BtnLiberar.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLiberar.Appearance.Options.UseFont = True
        Me.BtnLiberar.Appearance.Options.UseTextOptions = True
        Me.BtnLiberar.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.BtnLiberar.Location = New System.Drawing.Point(186, 85)
        Me.BtnLiberar.Name = "BtnLiberar"
        Me.BtnLiberar.Size = New System.Drawing.Size(100, 37)
        Me.BtnLiberar.TabIndex = 179
        Me.BtnLiberar.Text = "Guardar"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(39, 20)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(34, 19)
        Me.LabelControl2.TabIndex = 177
        Me.LabelControl2.Text = "Lote:"
        Me.LabelControl2.Visible = False
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(19, 56)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(61, 19)
        Me.LabelControl1.TabIndex = 175
        Me.LabelControl1.Text = "Estación:"
        '
        'CmbLote
        '
        Me.CmbLote.Location = New System.Drawing.Point(86, 21)
        Me.CmbLote.Name = "CmbLote"
        Me.CmbLote.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbLote.Properties.Appearance.Options.UseFont = True
        Me.CmbLote.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbLote.Properties.AppearanceDropDown.Options.UseFont = True
        Me.CmbLote.Properties.AppearanceDropDownHeader.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbLote.Properties.AppearanceDropDownHeader.Options.UseFont = True
        Me.CmbLote.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CmbLote.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("LoteAXC", "Lote", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("LoteAXC", "Lote")})
        Me.CmbLote.Properties.NullText = ""
        Me.CmbLote.Properties.PopupSizeable = False
        Me.CmbLote.Size = New System.Drawing.Size(200, 26)
        Me.CmbLote.TabIndex = 178
        Me.CmbLote.Visible = False
        '
        'CmbEstacion
        '
        Me.CmbEstacion.Location = New System.Drawing.Point(86, 53)
        Me.CmbEstacion.Name = "CmbEstacion"
        Me.CmbEstacion.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbEstacion.Properties.Appearance.Options.UseFont = True
        Me.CmbEstacion.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbEstacion.Properties.AppearanceDropDown.Options.UseFont = True
        Me.CmbEstacion.Properties.AppearanceDropDownHeader.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbEstacion.Properties.AppearanceDropDownHeader.Options.UseFont = True
        Me.CmbEstacion.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CmbEstacion.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Estacion", "Estacion", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Estacion", "Estación")})
        Me.CmbEstacion.Properties.NullText = ""
        Me.CmbEstacion.Properties.PopupSizeable = False
        Me.CmbEstacion.Size = New System.Drawing.Size(200, 26)
        Me.CmbEstacion.TabIndex = 176
        '
        'FrmModificarEstacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(306, 139)
        Me.Controls.Add(Me.BtnLiberar)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.CmbLote)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.CmbEstacion)
        Me.IconOptions.Image = Global.AXCVDE.My.Resources.Resources.Logo_X_150x150_01
        Me.Name = "FrmModificarEstacion"
        Me.Text = "Modificar Partida"
        CType(Me.CmbLote.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CmbEstacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnLiberar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents CmbLote As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents CmbEstacion As DevExpress.XtraEditors.LookUpEdit
End Class
