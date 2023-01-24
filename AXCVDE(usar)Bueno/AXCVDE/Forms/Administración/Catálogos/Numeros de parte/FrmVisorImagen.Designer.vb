<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVisorImagen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmVisorImagen))
        Me.PbImagen = New System.Windows.Forms.PictureBox()
        CType(Me.PbImagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PbImagen
        '
        Me.PbImagen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PbImagen.Location = New System.Drawing.Point(0, 0)
        Me.PbImagen.Name = "PbImagen"
        Me.PbImagen.Size = New System.Drawing.Size(1344, 457)
        Me.PbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PbImagen.TabIndex = 0
        Me.PbImagen.TabStop = False
        '
        'FrmVisorImagen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1344, 457)
        Me.Controls.Add(Me.PbImagen)
        Me.IconOptions.Icon = CType(resources.GetObject("FrmVisorImagen.IconOptions.Icon"), System.Drawing.Icon)
        Me.IconOptions.Image = Global.AXCVDE.My.Resources.Resources.Logo_X_150x150_01
        Me.MinimizeBox = False
        Me.Name = "FrmVisorImagen"
        Me.ShowInTaskbar = False
        Me.Text = "Visor de imagenes "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PbImagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PbImagen As PictureBox
End Class
