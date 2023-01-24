<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmModificaPartida
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
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.CmbEstacion = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.CmbLote = New DevExpress.XtraEditors.LookUpEdit()
        Me.BtnLiberar = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.CmbEstacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CmbLote.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(12, 61)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(61, 19)
        Me.LabelControl1.TabIndex = 170
        Me.LabelControl1.Text = "Estación:"
        '
        'CmbEstacion
        '
        Me.CmbEstacion.Location = New System.Drawing.Point(79, 58)
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
        Me.CmbEstacion.TabIndex = 171
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(32, 25)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(34, 19)
        Me.LabelControl2.TabIndex = 172
        Me.LabelControl2.Text = "Lote:"
        Me.LabelControl2.Visible = False
        '
        'CmbLote
        '
        Me.CmbLote.Location = New System.Drawing.Point(79, 26)
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
        Me.CmbLote.TabIndex = 173
        Me.CmbLote.Visible = False
        '
        'BtnLiberar
        '
        Me.BtnLiberar.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLiberar.Appearance.Options.UseFont = True
        Me.BtnLiberar.Appearance.Options.UseTextOptions = True
        Me.BtnLiberar.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.BtnLiberar.Location = New System.Drawing.Point(179, 90)
        Me.BtnLiberar.Name = "BtnLiberar"
        Me.BtnLiberar.Size = New System.Drawing.Size(100, 37)
        Me.BtnLiberar.TabIndex = 174
        Me.BtnLiberar.Text = "Guardar"
        '
        'FrmModificaPartida
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(299, 145)
        Me.Controls.Add(Me.BtnLiberar)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.CmbLote)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.CmbEstacion)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.IconOptions.Image = Global.AXCVDE.My.Resources.Resources.Logo_X_150x150_01
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmModificaPartida"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modifica partida"
        CType(Me.CmbEstacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CmbLote.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents CmbEstacion As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents CmbLote As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents BtnLiberar As DevExpress.XtraEditors.SimpleButton
End Class
