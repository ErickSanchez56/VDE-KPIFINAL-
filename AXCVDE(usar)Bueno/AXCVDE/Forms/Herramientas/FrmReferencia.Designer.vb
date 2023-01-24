<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReferencia
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
        Me.TxtBusqueda = New DevExpress.XtraEditors.TextEdit()
        Me.BtnBuscar = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.DgvResultado = New DevExpress.XtraGrid.GridControl()
        Me.DgvViewResultado = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.btnExportar = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.TxtBusqueda.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvResultado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvViewResultado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.Controls.Add(Me.TxtBusqueda)
        Me.GroupControl1.Controls.Add(Me.BtnBuscar)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 12)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(1376, 108)
        Me.GroupControl1.TabIndex = 107
        Me.GroupControl1.Text = "Filtros"
        '
        'TxtBusqueda
        '
        Me.TxtBusqueda.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtBusqueda.Location = New System.Drawing.Point(517, 57)
        Me.TxtBusqueda.Name = "TxtBusqueda"
        Me.TxtBusqueda.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBusqueda.Properties.Appearance.Options.UseFont = True
        Me.TxtBusqueda.Size = New System.Drawing.Size(279, 26)
        Me.TxtBusqueda.TabIndex = 2
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnBuscar.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuscar.Appearance.Options.UseFont = True
        Me.BtnBuscar.Location = New System.Drawing.Point(802, 44)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(121, 49)
        Me.BtnBuscar.TabIndex = 4
        Me.BtnBuscar.Text = "Buscar"
        '
        'LabelControl1
        '
        Me.LabelControl1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(440, 61)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(71, 19)
        Me.LabelControl1.TabIndex = 93
        Me.LabelControl1.Text = "Búsqueda:"
        '
        'DgvResultado
        '
        Me.DgvResultado.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvResultado.Location = New System.Drawing.Point(10, 126)
        Me.DgvResultado.MainView = Me.DgvViewResultado
        Me.DgvResultado.Name = "DgvResultado"
        Me.DgvResultado.Size = New System.Drawing.Size(1378, 465)
        Me.DgvResultado.TabIndex = 106
        Me.DgvResultado.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.DgvViewResultado})
        '
        'DgvViewResultado
        '
        Me.DgvViewResultado.GridControl = Me.DgvResultado
        Me.DgvViewResultado.Name = "DgvViewResultado"
        Me.DgvViewResultado.OptionsBehavior.Editable = False
        Me.DgvViewResultado.OptionsBehavior.ReadOnly = True
        Me.DgvViewResultado.OptionsClipboard.AllowCopy = DevExpress.Utils.DefaultBoolean.[True]
        Me.DgvViewResultado.OptionsClipboard.AllowCsvFormat = DevExpress.Utils.DefaultBoolean.[True]
        Me.DgvViewResultado.OptionsClipboard.AllowExcelFormat = DevExpress.Utils.DefaultBoolean.[True]
        Me.DgvViewResultado.OptionsClipboard.ClipboardMode = DevExpress.Export.ClipboardMode.Formatted
        Me.DgvViewResultado.OptionsClipboard.CopyColumnHeaders = DevExpress.Utils.DefaultBoolean.[True]
        Me.DgvViewResultado.OptionsView.ColumnAutoWidth = False
        Me.DgvViewResultado.OptionsView.ShowGroupPanel = False
        '
        'btnExportar
        '
        Me.btnExportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExportar.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExportar.Appearance.Options.UseFont = True
        Me.btnExportar.Location = New System.Drawing.Point(1267, 597)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(121, 49)
        Me.btnExportar.TabIndex = 94
        Me.btnExportar.Text = "Exportar a excel"
        '
        'FrmReferencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1400, 653)
        Me.Controls.Add(Me.btnExportar)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.DgvResultado)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.IconOptions.Image = Global.AXCVDE.My.Resources.Resources.Logo_X_150x150_01
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmReferencia"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de transacciones"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.TxtBusqueda.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvResultado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvViewResultado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents TxtBusqueda As DevExpress.XtraEditors.TextEdit
    Friend WithEvents BtnBuscar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DgvResultado As DevExpress.XtraGrid.GridControl
    Friend WithEvents DgvViewResultado As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnExportar As DevExpress.XtraEditors.SimpleButton
End Class
