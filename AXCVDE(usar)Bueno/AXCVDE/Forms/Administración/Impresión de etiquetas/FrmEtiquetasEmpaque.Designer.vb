<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEtiquetasEmpaque
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
        Me.numEtiquetas = New DevExpress.XtraEditors.SpinEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.CmbImpresora = New DevExpress.XtraEditors.LookUpEdit()
        Me.TxtLote = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.btnImprimir = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.numEtiquetas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CmbImpresora.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtLote.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(42, 33)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(53, 15)
        Me.LabelControl1.TabIndex = 139
        Me.LabelControl1.Text = "Cantidad:"
        '
        'numEtiquetas
        '
        Me.numEtiquetas.EditValue = New Decimal(New Integer() {2, 0, 0, 0})
        Me.numEtiquetas.Location = New System.Drawing.Point(110, 31)
        Me.numEtiquetas.Name = "numEtiquetas"
        Me.numEtiquetas.Properties.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numEtiquetas.Properties.Appearance.Options.UseFont = True
        Me.numEtiquetas.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.numEtiquetas.Properties.Increment = New Decimal(New Integer() {2, 0, 0, 0})
        Me.numEtiquetas.Properties.IsFloatValue = False
        Me.numEtiquetas.Properties.Mask.EditMask = "N00"
        Me.numEtiquetas.Properties.MaxValue = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.numEtiquetas.Properties.MinValue = New Decimal(New Integer() {2, 0, 0, 0})
        Me.numEtiquetas.Size = New System.Drawing.Size(114, 22)
        Me.numEtiquetas.TabIndex = 2
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(42, 70)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(62, 15)
        Me.LabelControl3.TabIndex = 140
        Me.LabelControl3.Text = "Impresora:"
        '
        'CmbImpresora
        '
        Me.CmbImpresora.Location = New System.Drawing.Point(110, 68)
        Me.CmbImpresora.Name = "CmbImpresora"
        Me.CmbImpresora.Properties.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbImpresora.Properties.Appearance.Options.UseFont = True
        Me.CmbImpresora.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CmbImpresora.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Impresora", "Impresora")})
        Me.CmbImpresora.Properties.NullText = ""
        Me.CmbImpresora.Size = New System.Drawing.Size(241, 22)
        Me.CmbImpresora.TabIndex = 3
        '
        'TxtLote
        '
        Me.TxtLote.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtLote.Location = New System.Drawing.Point(110, 31)
        Me.TxtLote.Name = "TxtLote"
        Me.TxtLote.Properties.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtLote.Properties.Appearance.Options.UseFont = True
        Me.TxtLote.Size = New System.Drawing.Size(241, 22)
        Me.TxtLote.TabIndex = 1
        Me.TxtLote.Visible = False
        '
        'LabelControl13
        '
        Me.LabelControl13.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl13.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl13.Appearance.Options.UseFont = True
        Me.LabelControl13.Location = New System.Drawing.Point(42, 33)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(28, 15)
        Me.LabelControl13.TabIndex = 142
        Me.LabelControl13.Text = "Lote:"
        Me.LabelControl13.Visible = False
        '
        'btnImprimir
        '
        Me.btnImprimir.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnImprimir.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimir.Appearance.Options.UseFont = True
        Me.btnImprimir.Location = New System.Drawing.Point(250, 24)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(101, 34)
        Me.btnImprimir.TabIndex = 4
        Me.btnImprimir.Text = "Imprimir"
        '
        'FrmEtiquetasEmpaque
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(381, 126)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.CmbImpresora)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.numEtiquetas)
        Me.Controls.Add(Me.TxtLote)
        Me.Controls.Add(Me.LabelControl13)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.IconOptions.Image = Global.AXCVDE.My.Resources.Resources.Logo_X_150x150_01
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmEtiquetasEmpaque"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Etiquetas de empaque"
        CType(Me.numEtiquetas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CmbImpresora.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtLote.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents numEtiquetas As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents CmbImpresora As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents TxtLote As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnImprimir As DevExpress.XtraEditors.SimpleButton
End Class
