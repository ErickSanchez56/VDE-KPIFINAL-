<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmImpresionCarritos
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
        Me.btnImprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.cmbImpresora = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.numEtiquetas = New DevExpress.XtraEditors.SpinEdit()
        CType(Me.cmbImpresora.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numEtiquetas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnImprimir
        '
        Me.btnImprimir.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnImprimir.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimir.Appearance.Options.UseFont = True
        Me.btnImprimir.Location = New System.Drawing.Point(243, 89)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(101, 34)
        Me.btnImprimir.TabIndex = 153
        Me.btnImprimir.Text = "Imprimir"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(35, 63)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(62, 15)
        Me.LabelControl3.TabIndex = 151
        Me.LabelControl3.Text = "Impresora:"
        '
        'cmbImpresora
        '
        Me.cmbImpresora.Location = New System.Drawing.Point(103, 61)
        Me.cmbImpresora.Name = "cmbImpresora"
        Me.cmbImpresora.Properties.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbImpresora.Properties.Appearance.Options.UseFont = True
        Me.cmbImpresora.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbImpresora.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Impresora", "Impresora")})
        Me.cmbImpresora.Properties.NullText = ""
        Me.cmbImpresora.Size = New System.Drawing.Size(241, 22)
        Me.cmbImpresora.TabIndex = 152
        '
        'LabelControl1
        '
        Me.LabelControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(44, 30)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(53, 15)
        Me.LabelControl1.TabIndex = 150
        Me.LabelControl1.Text = "Cantidad:"
        '
        'numEtiquetas
        '
        Me.numEtiquetas.EditValue = New Decimal(New Integer() {2, 0, 0, 0})
        Me.numEtiquetas.Location = New System.Drawing.Point(103, 28)
        Me.numEtiquetas.Name = "numEtiquetas"
        Me.numEtiquetas.Properties.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numEtiquetas.Properties.Appearance.Options.UseFont = True
        Me.numEtiquetas.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.numEtiquetas.Properties.Increment = New Decimal(New Integer() {2, 0, 0, 0})
        Me.numEtiquetas.Properties.IsFloatValue = False
        Me.numEtiquetas.Properties.Mask.EditMask = "N00"
        Me.numEtiquetas.Properties.MaxValue = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.numEtiquetas.Properties.MinValue = New Decimal(New Integer() {2, 0, 0, 0})
        Me.numEtiquetas.Size = New System.Drawing.Size(100, 22)
        Me.numEtiquetas.TabIndex = 149
        '
        'FrmImpresionCarritos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(378, 143)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.cmbImpresora)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.numEtiquetas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.IconOptions.Image = Global.AXCVDE.My.Resources.Resources.Logo_X_150x150_01
        Me.LookAndFeel.TouchUIMode = DevExpress.Utils.DefaultBoolean.[False]
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmImpresionCarritos"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Impresión de carros"
        CType(Me.cmbImpresora.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numEtiquetas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbImpresora As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents numEtiquetas As DevExpress.XtraEditors.SpinEdit
End Class
