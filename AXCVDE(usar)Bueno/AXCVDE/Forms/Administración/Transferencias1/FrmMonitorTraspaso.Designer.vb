<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMonitorTraspaso
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim GridLevelNode2 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim ButtonImageOptions3 As DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions = New DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMonitorTraspaso))
        Dim ButtonImageOptions4 As DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions = New DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions()
        Me.dgvViewDetalle = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.dgvOrdenesProduccion = New DevExpress.XtraGrid.GridControl()
        Me.dgvViewEncabezado = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.dgvViewDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvOrdenesProduccion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvViewEncabezado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvViewDetalle
        '
        Me.dgvViewDetalle.Appearance.GroupRow.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvViewDetalle.Appearance.GroupRow.Options.UseFont = True
        Me.dgvViewDetalle.Appearance.HeaderPanel.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvViewDetalle.Appearance.HeaderPanel.Options.UseFont = True
        Me.dgvViewDetalle.Appearance.Row.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvViewDetalle.Appearance.Row.Options.UseFont = True
        Me.dgvViewDetalle.DetailHeight = 431
        Me.dgvViewDetalle.GridControl = Me.dgvOrdenesProduccion
        Me.dgvViewDetalle.Name = "dgvViewDetalle"
        Me.dgvViewDetalle.OptionsBehavior.Editable = False
        Me.dgvViewDetalle.OptionsBehavior.ReadOnly = True
        Me.dgvViewDetalle.OptionsView.ColumnAutoWidth = False
        Me.dgvViewDetalle.OptionsView.ShowGroupPanel = False
        '
        'dgvOrdenesProduccion
        '
        Me.dgvOrdenesProduccion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvOrdenesProduccion.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        GridLevelNode2.LevelTemplate = Me.dgvViewDetalle
        GridLevelNode2.RelationName = "DetalleOrdenesTraspaso"
        Me.dgvOrdenesProduccion.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode2})
        Me.dgvOrdenesProduccion.Location = New System.Drawing.Point(16, 43)
        Me.dgvOrdenesProduccion.MainView = Me.dgvViewEncabezado
        Me.dgvOrdenesProduccion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgvOrdenesProduccion.Name = "dgvOrdenesProduccion"
        Me.dgvOrdenesProduccion.Size = New System.Drawing.Size(761, 278)
        Me.dgvOrdenesProduccion.TabIndex = 0
        Me.dgvOrdenesProduccion.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.dgvViewEncabezado, Me.dgvViewDetalle})
        '
        'dgvViewEncabezado
        '
        Me.dgvViewEncabezado.Appearance.GroupRow.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvViewEncabezado.Appearance.GroupRow.Options.UseFont = True
        Me.dgvViewEncabezado.Appearance.HeaderPanel.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvViewEncabezado.Appearance.HeaderPanel.Options.UseFont = True
        Me.dgvViewEncabezado.Appearance.Row.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvViewEncabezado.Appearance.Row.Options.UseFont = True
        Me.dgvViewEncabezado.DetailHeight = 431
        Me.dgvViewEncabezado.GridControl = Me.dgvOrdenesProduccion
        Me.dgvViewEncabezado.Name = "dgvViewEncabezado"
        Me.dgvViewEncabezado.OptionsBehavior.Editable = False
        Me.dgvViewEncabezado.OptionsBehavior.ReadOnly = True
        Me.dgvViewEncabezado.OptionsDetail.ShowDetailTabs = False
        Me.dgvViewEncabezado.OptionsView.ColumnAutoWidth = False
        Me.dgvViewEncabezado.OptionsView.ShowGroupPanel = False
        '
        'GroupControl2
        '
        Me.GroupControl2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl2.AppearanceCaption.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold)
        Me.GroupControl2.AppearanceCaption.Options.UseFont = True
        Me.GroupControl2.Controls.Add(Me.LabelControl1)
        Me.GroupControl2.Controls.Add(Me.SimpleButton2)
        Me.GroupControl2.Controls.Add(Me.SimpleButton1)
        Me.GroupControl2.Controls.Add(Me.dgvOrdenesProduccion)
        ButtonImageOptions3.SvgImage = CType(resources.GetObject("ButtonImageOptions3.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        ButtonImageOptions4.Image = CType(resources.GetObject("ButtonImageOptions4.Image"), System.Drawing.Image)
        Me.GroupControl2.CustomHeaderButtons.AddRange(New DevExpress.XtraEditors.ButtonPanel.IBaseButton() {New DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("", False, ButtonImageOptions3, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "Filtro días hacía atras", -1, True, Nothing, True, False, True, "Filtro", -1), New DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Button", False, ButtonImageOptions4, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "Exportar a .XLSX", -1, True, Nothing, True, False, True, "Excel", -1)})
        Me.GroupControl2.CustomHeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText
        Me.GroupControl2.Location = New System.Drawing.Point(15, 40)
        Me.GroupControl2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(775, 363)
        Me.GroupControl2.TabIndex = 47
        Me.GroupControl2.Text = "Resultado"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton2.Location = New System.Drawing.Point(660, 329)
        Me.SimpleButton2.Margin = New System.Windows.Forms.Padding(4)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(100, 28)
        Me.SimpleButton2.TabIndex = 53
        Me.SimpleButton2.Text = ">>"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Location = New System.Drawing.Point(552, 329)
        Me.SimpleButton1.Margin = New System.Windows.Forms.Padding(4)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(100, 28)
        Me.SimpleButton1.TabIndex = 52
        Me.SimpleButton1.Text = "<<"
        '
        'TextEdit1
        '
        Me.TextEdit1.Location = New System.Drawing.Point(15, 13)
        Me.TextEdit1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Size = New System.Drawing.Size(156, 22)
        Me.TextEdit1.TabIndex = 53
        '
        'LabelControl1
        '
        Me.LabelControl1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelControl1.Location = New System.Drawing.Point(703, 49)
        Me.LabelControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(43, 16)
        Me.LabelControl1.TabIndex = 54
        Me.LabelControl1.Text = "Pagina"
        '
        'FrmMonitorTraspaso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(804, 431)
        Me.Controls.Add(Me.TextEdit1)
        Me.Controls.Add(Me.GroupControl2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.IconOptions.Icon = CType(resources.GetObject("FrmMonitorTraspaso.IconOptions.Icon"), System.Drawing.Icon)
        Me.IconOptions.Image = Global.AXCVDE.My.Resources.Resources.Logo_X_150x150_01
        Me.LookAndFeel.TouchUIMode = DevExpress.Utils.DefaultBoolean.[False]
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmMonitorTraspaso"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Monitoreo de traspasos"
        CType(Me.dgvViewDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvOrdenesProduccion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvViewEncabezado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents dgvOrdenesProduccion As DevExpress.XtraGrid.GridControl
    Friend WithEvents dgvViewDetalle As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents dgvViewEncabezado As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
End Class
