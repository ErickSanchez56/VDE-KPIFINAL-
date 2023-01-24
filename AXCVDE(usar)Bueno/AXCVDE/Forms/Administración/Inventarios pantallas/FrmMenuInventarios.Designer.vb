<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMenuInventarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMenuInventarios))
        Me.btnTotal = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.btnProducto = New DevExpress.XtraEditors.SimpleButton()
        Me.btnPosicion = New DevExpress.XtraEditors.SimpleButton()
        Me.btnArticulo = New DevExpress.XtraEditors.SimpleButton()
        Me.dgvEjercicios = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.dgvEjercicios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnTotal
        '
        Me.btnTotal.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnTotal.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTotal.Appearance.Options.UseFont = True
        Me.btnTotal.Location = New System.Drawing.Point(137, 44)
        Me.btnTotal.Name = "btnTotal"
        Me.btnTotal.Size = New System.Drawing.Size(110, 49)
        Me.btnTotal.TabIndex = 0
        Me.btnTotal.Text = "Total"
        '
        'GroupControl1
        '
        Me.GroupControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.Controls.Add(Me.btnProducto)
        Me.GroupControl1.Controls.Add(Me.btnPosicion)
        Me.GroupControl1.Controls.Add(Me.btnArticulo)
        Me.GroupControl1.Controls.Add(Me.btnTotal)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 13)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(652, 108)
        Me.GroupControl1.TabIndex = 1
        Me.GroupControl1.Text = "Tipos de inventario"
        '
        'btnProducto
        '
        Me.btnProducto.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnProducto.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProducto.Appearance.Options.UseFont = True
        Me.btnProducto.Location = New System.Drawing.Point(399, 44)
        Me.btnProducto.Name = "btnProducto"
        Me.btnProducto.Size = New System.Drawing.Size(110, 49)
        Me.btnProducto.TabIndex = 3
        Me.btnProducto.Text = "Producto"
        '
        'btnPosicion
        '
        Me.btnPosicion.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnPosicion.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPosicion.Appearance.Options.UseFont = True
        Me.btnPosicion.Location = New System.Drawing.Point(269, 44)
        Me.btnPosicion.Name = "btnPosicion"
        Me.btnPosicion.Size = New System.Drawing.Size(110, 49)
        Me.btnPosicion.TabIndex = 2
        Me.btnPosicion.Text = "Posición"
        '
        'btnArticulo
        '
        Me.btnArticulo.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnArticulo.Appearance.Options.UseFont = True
        Me.btnArticulo.Location = New System.Drawing.Point(537, 59)
        Me.btnArticulo.Name = "btnArticulo"
        Me.btnArticulo.Size = New System.Drawing.Size(110, 49)
        Me.btnArticulo.TabIndex = 1
        Me.btnArticulo.Text = "Lote"
        Me.btnArticulo.Visible = False
        '
        'dgvEjercicios
        '
        Me.dgvEjercicios.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvEjercicios.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.dgvEjercicios.Location = New System.Drawing.Point(12, 127)
        Me.dgvEjercicios.MainView = Me.GridView1
        Me.dgvEjercicios.Name = "dgvEjercicios"
        Me.dgvEjercicios.Size = New System.Drawing.Size(652, 179)
        Me.dgvEjercicios.TabIndex = 120
        Me.dgvEjercicios.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.EvenRow.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.GridView1.Appearance.EvenRow.Options.UseFont = True
        Me.GridView1.Appearance.FixedLine.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView1.Appearance.FixedLine.Options.UseFont = True
        Me.GridView1.Appearance.FocusedRow.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.GridView1.Appearance.FocusedRow.Options.UseFont = True
        Me.GridView1.Appearance.FooterPanel.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.GridView1.Appearance.FooterPanel.Options.UseFont = True
        Me.GridView1.Appearance.GroupFooter.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.GridView1.Appearance.GroupFooter.Options.UseFont = True
        Me.GridView1.Appearance.GroupRow.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.GridView1.Appearance.GroupRow.Options.UseFont = True
        Me.GridView1.Appearance.HeaderPanel.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView1.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridView1.Appearance.OddRow.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.GridView1.Appearance.OddRow.Options.UseFont = True
        Me.GridView1.Appearance.Preview.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.GridView1.Appearance.Preview.Options.UseFont = True
        Me.GridView1.Appearance.Row.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.GridView1.Appearance.Row.Options.UseFont = True
        Me.GridView1.Appearance.RowSeparator.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.GridView1.Appearance.RowSeparator.Options.UseFont = True
        Me.GridView1.Appearance.SelectedRow.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.GridView1.Appearance.SelectedRow.Options.UseFont = True
        Me.GridView1.Appearance.TopNewRow.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.GridView1.Appearance.TopNewRow.Options.UseFont = True
        Me.GridView1.DetailHeight = 303
        Me.GridView1.GridControl = Me.dgvEjercicios
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'FrmMenuInventarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(676, 318)
        Me.Controls.Add(Me.dgvEjercicios)
        Me.Controls.Add(Me.GroupControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.IconOptions.Icon = CType(resources.GetObject("FrmMenuInventarios.IconOptions.Icon"), System.Drawing.Icon)
        Me.IconOptions.Image = Global.AXCVDE.My.Resources.Resources.Logo_X_150x150_01
        Me.LookAndFeel.TouchUIMode = DevExpress.Utils.DefaultBoolean.[False]
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmMenuInventarios"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ejercicios de inventario"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.dgvEjercicios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnTotal As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnPosicion As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnArticulo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dgvEjercicios As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnProducto As DevExpress.XtraEditors.SimpleButton
End Class
