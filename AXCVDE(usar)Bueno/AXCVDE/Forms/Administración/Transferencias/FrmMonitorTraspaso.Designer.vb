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
        Dim ButtonImageOptions1 As DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions = New DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMonitorTraspaso))
        Dim ButtonImageOptions2 As DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions = New DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions()
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.dgvOrdenesProduccion = New DevExpress.XtraGrid.GridControl()
        Me.dgvViewDetalle = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.dgvViewEncabezado = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.dgvOrdenesProduccion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvViewDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvViewEncabezado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl2
        '
        Me.GroupControl2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl2.AppearanceCaption.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold)
        Me.GroupControl2.AppearanceCaption.Options.UseFont = True
        Me.GroupControl2.Controls.Add(Me.dgvOrdenesProduccion)
        ButtonImageOptions1.SvgImage = CType(resources.GetObject("ButtonImageOptions1.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        ButtonImageOptions2.Image = CType(resources.GetObject("ButtonImageOptions2.Image"), System.Drawing.Image)
        Me.GroupControl2.CustomHeaderButtons.AddRange(New DevExpress.XtraEditors.ButtonPanel.IBaseButton() {New DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("", False, ButtonImageOptions1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "Filtro días hacía atras", -1, True, Nothing, True, False, True, "Filtro", -1), New DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Button", False, ButtonImageOptions2, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "Exportar a .XLSX", -1, True, Nothing, True, False, True, "Excel", -1)})
        Me.GroupControl2.CustomHeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText
        Me.GroupControl2.Location = New System.Drawing.Point(11, 23)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(581, 305)
        Me.GroupControl2.TabIndex = 47
        Me.GroupControl2.Text = "Resultado"
        '
        'dgvOrdenesProduccion
        '
        Me.dgvOrdenesProduccion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        GridLevelNode1.LevelTemplate = Me.dgvViewDetalle
        GridLevelNode1.RelationName = "DetalleOrdenesTraspaso"
        Me.dgvOrdenesProduccion.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.dgvOrdenesProduccion.Location = New System.Drawing.Point(5, 40)
        Me.dgvOrdenesProduccion.MainView = Me.dgvViewEncabezado
        Me.dgvOrdenesProduccion.Name = "dgvOrdenesProduccion"
        Me.dgvOrdenesProduccion.Size = New System.Drawing.Size(571, 260)
        Me.dgvOrdenesProduccion.TabIndex = 0
        Me.dgvOrdenesProduccion.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.dgvViewDetalle, Me.dgvViewEncabezado})
        '
        'dgvViewDetalle
        '
        Me.dgvViewDetalle.Appearance.GroupRow.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvViewDetalle.Appearance.GroupRow.Options.UseFont = True
        Me.dgvViewDetalle.Appearance.HeaderPanel.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvViewDetalle.Appearance.HeaderPanel.Options.UseFont = True
        Me.dgvViewDetalle.Appearance.Row.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvViewDetalle.Appearance.Row.Options.UseFont = True
        Me.dgvViewDetalle.GridControl = Me.dgvOrdenesProduccion
        Me.dgvViewDetalle.Name = "dgvViewDetalle"
        Me.dgvViewDetalle.OptionsBehavior.Editable = False
        Me.dgvViewDetalle.OptionsBehavior.ReadOnly = True
        Me.dgvViewDetalle.OptionsView.ColumnAutoWidth = False
        Me.dgvViewDetalle.OptionsView.ShowGroupPanel = False
        '
        'dgvViewEncabezado
        '
        Me.dgvViewEncabezado.Appearance.GroupRow.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvViewEncabezado.Appearance.GroupRow.Options.UseFont = True
        Me.dgvViewEncabezado.Appearance.HeaderPanel.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvViewEncabezado.Appearance.HeaderPanel.Options.UseFont = True
        Me.dgvViewEncabezado.Appearance.Row.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvViewEncabezado.Appearance.Row.Options.UseFont = True
        Me.dgvViewEncabezado.GridControl = Me.dgvOrdenesProduccion
        Me.dgvViewEncabezado.Name = "dgvViewEncabezado"
        Me.dgvViewEncabezado.OptionsBehavior.Editable = False
        Me.dgvViewEncabezado.OptionsBehavior.ReadOnly = True
        Me.dgvViewEncabezado.OptionsDetail.ShowDetailTabs = False
        Me.dgvViewEncabezado.OptionsView.ColumnAutoWidth = False
        Me.dgvViewEncabezado.OptionsView.ShowGroupPanel = False
        '
        'FrmMonitorTraspaso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(603, 350)
        Me.Controls.Add(Me.GroupControl2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.IconOptions.Icon = CType(resources.GetObject("FrmMonitorTraspaso.IconOptions.Icon"), System.Drawing.Icon)
        Me.IconOptions.Image = Global.AXCVDE.My.Resources.Resources.Logo_X_150x150_01
        Me.LookAndFeel.TouchUIMode = DevExpress.Utils.DefaultBoolean.[False]
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmMonitorTraspaso"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Monitoreo de traspasos"
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.dgvOrdenesProduccion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvViewDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvViewEncabezado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents dgvOrdenesProduccion As DevExpress.XtraGrid.GridControl
    Friend WithEvents dgvViewDetalle As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents dgvViewEncabezado As DevExpress.XtraGrid.Views.Grid.GridView
End Class
