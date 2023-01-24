<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmAlmacenHistorico
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
        Dim LinearScaleRange1 As DevExpress.XtraGauges.Core.Model.LinearScaleRange = New DevExpress.XtraGauges.Core.Model.LinearScaleRange()
        Dim LinearScaleRange2 As DevExpress.XtraGauges.Core.Model.LinearScaleRange = New DevExpress.XtraGauges.Core.Model.LinearScaleRange()
        Dim LinearScaleRange3 As DevExpress.XtraGauges.Core.Model.LinearScaleRange = New DevExpress.XtraGauges.Core.Model.LinearScaleRange()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAlmacenHistorico))
        Me.ChartControl4 = New DevExpress.XtraCharts.ChartControl()
        Me.TabPane1 = New DevExpress.XtraBars.Navigation.TabPane()
        Me.TabNavigationPage1 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        Me.GaugeControl1 = New DevExpress.XtraGauges.Win.GaugeControl()
        Me.linearGauge9 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearGauge()
        Me.LinearScaleBackgroundLayerComponent1 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleBackgroundLayerComponent()
        Me.LinearScaleComponent1 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent()
        Me.LinearScaleLevelComponent1 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleLevelComponent()
        Me.Grafica = New DevExpress.XtraCharts.ChartControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.dgvResultado = New DevExpress.XtraGrid.GridControl()
        Me.dgvViewResultado = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.BtnBuscar = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.dtpFechaInicio = New DevExpress.XtraEditors.DateEdit()
        Me.cmbAlmacen = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.dtpFechaFin = New DevExpress.XtraEditors.DateEdit()
        Me.TabNavigationPage2 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        Me.ChartControl3 = New DevExpress.XtraCharts.ChartControl()
        Me.SeparatorControl1 = New DevExpress.XtraEditors.SeparatorControl()
        Me.GaugeControl2 = New DevExpress.XtraGauges.Win.GaugeControl()
        Me.dGauge1 = New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge()
        Me.DigitalBackgroundLayerComponent1 = New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent()
        CType(Me.ChartControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabPane1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPane1.SuspendLayout()
        Me.TabNavigationPage1.SuspendLayout()
        CType(Me.linearGauge9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LinearScaleBackgroundLayerComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LinearScaleComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LinearScaleLevelComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grafica, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.dgvResultado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvViewResultado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaInicio.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaInicio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbAlmacen.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaFin.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaFin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabNavigationPage2.SuspendLayout()
        CType(Me.ChartControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeparatorControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dGauge1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DigitalBackgroundLayerComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ChartControl4
        '
        Me.ChartControl4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ChartControl4.Location = New System.Drawing.Point(658, 19)
        Me.ChartControl4.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ChartControl4.Name = "ChartControl4"
        Me.ChartControl4.SeriesSerializable = New DevExpress.XtraCharts.Series(-1) {}
        Me.ChartControl4.Size = New System.Drawing.Size(321, 158)
        Me.ChartControl4.TabIndex = 185
        '
        'TabPane1
        '
        Me.TabPane1.Controls.Add(Me.TabNavigationPage1)
        Me.TabPane1.Controls.Add(Me.TabNavigationPage2)
        Me.TabPane1.Location = New System.Drawing.Point(9, 10)
        Me.TabPane1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabPane1.Name = "TabPane1"
        Me.TabPane1.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.TabNavigationPage1, Me.TabNavigationPage2})
        Me.TabPane1.RegularSize = New System.Drawing.Size(627, 630)
        Me.TabPane1.SelectedPage = Me.TabNavigationPage1
        Me.TabPane1.Size = New System.Drawing.Size(627, 630)
        Me.TabPane1.TabIndex = 184
        Me.TabPane1.Text = "TabPane1"
        '
        'TabNavigationPage1
        '
        Me.TabNavigationPage1.Caption = "Almacenamiento Histórico"
        Me.TabNavigationPage1.Controls.Add(Me.GaugeControl1)
        Me.TabNavigationPage1.Controls.Add(Me.Grafica)
        Me.TabNavigationPage1.Controls.Add(Me.GroupControl1)
        Me.TabNavigationPage1.Controls.Add(Me.BtnBuscar)
        Me.TabNavigationPage1.Controls.Add(Me.LabelControl3)
        Me.TabNavigationPage1.Controls.Add(Me.dtpFechaInicio)
        Me.TabNavigationPage1.Controls.Add(Me.cmbAlmacen)
        Me.TabNavigationPage1.Controls.Add(Me.LabelControl2)
        Me.TabNavigationPage1.Controls.Add(Me.LabelControl1)
        Me.TabNavigationPage1.Controls.Add(Me.dtpFechaFin)
        Me.TabNavigationPage1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabNavigationPage1.Name = "TabNavigationPage1"
        Me.TabNavigationPage1.Size = New System.Drawing.Size(627, 603)
        '
        'GaugeControl1
        '
        Me.GaugeControl1.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.linearGauge9})
        Me.GaugeControl1.LayoutInterval = 4
        Me.GaugeControl1.LayoutPadding = New DevExpress.XtraGauges.Core.Base.Thickness(4, 5, 4, 5)
        Me.GaugeControl1.Location = New System.Drawing.Point(6, 449)
        Me.GaugeControl1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GaugeControl1.Name = "GaugeControl1"
        Me.GaugeControl1.Size = New System.Drawing.Size(126, 150)
        Me.GaugeControl1.TabIndex = 143
        '
        'linearGauge9
        '
        Me.linearGauge9.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleBackgroundLayerComponent() {Me.LinearScaleBackgroundLayerComponent1})
        Me.linearGauge9.Bounds = New System.Drawing.Rectangle(4, 5, 118, 140)
        Me.linearGauge9.Levels.AddRange(New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleLevelComponent() {Me.LinearScaleLevelComponent1})
        Me.linearGauge9.Name = "linearGauge9"
        Me.linearGauge9.OptionsToolTip.TooltipTitleFormat = "{0}"
        Me.linearGauge9.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent() {Me.LinearScaleComponent1})
        '
        'LinearScaleBackgroundLayerComponent1
        '
        Me.LinearScaleBackgroundLayerComponent1.LinearScale = Me.LinearScaleComponent1
        Me.LinearScaleBackgroundLayerComponent1.Name = "bg1"
        Me.LinearScaleBackgroundLayerComponent1.ScaleStartPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.5!, 0.85!)
        Me.LinearScaleBackgroundLayerComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.Linear_Style25
        Me.LinearScaleBackgroundLayerComponent1.ZOrder = 1000
        '
        'LinearScaleComponent1
        '
        Me.LinearScaleComponent1.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
        Me.LinearScaleComponent1.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
        Me.LinearScaleComponent1.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
        Me.LinearScaleComponent1.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
        Me.LinearScaleComponent1.AppearanceTickmarkText.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.LinearScaleComponent1.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
        Me.LinearScaleComponent1.EndPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(62.5!, 38.0!)
        Me.LinearScaleComponent1.MajorTickCount = 6
        Me.LinearScaleComponent1.MajorTickmark.FormatString = "{0:F0}"
        Me.LinearScaleComponent1.MajorTickmark.ShapeOffset = -25.0!
        Me.LinearScaleComponent1.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style25_1
        Me.LinearScaleComponent1.MajorTickmark.TextOffset = -35.0!
        Me.LinearScaleComponent1.MaxValue = 100.0!
        Me.LinearScaleComponent1.MinorTickCount = 4
        Me.LinearScaleComponent1.MinorTickmark.ShapeOffset = -22.0!
        Me.LinearScaleComponent1.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style25_2
        Me.LinearScaleComponent1.Name = "scale1"
        LinearScaleRange1.AppearanceRange.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#7AC463")
        LinearScaleRange1.EndThickness = 3.0!
        LinearScaleRange1.EndValue = 33.0!
        LinearScaleRange1.Name = "Range0"
        LinearScaleRange1.ShapeOffset = -12.0!
        LinearScaleRange1.StartThickness = 3.0!
        LinearScaleRange2.AppearanceRange.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#F1D183")
        LinearScaleRange2.EndThickness = 3.0!
        LinearScaleRange2.EndValue = 66.0!
        LinearScaleRange2.Name = "Range1"
        LinearScaleRange2.ShapeOffset = -12.0!
        LinearScaleRange2.StartThickness = 3.0!
        LinearScaleRange2.StartValue = 33.0!
        LinearScaleRange3.AppearanceRange.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#F1877E")
        LinearScaleRange3.EndThickness = 3.0!
        LinearScaleRange3.EndValue = 100.0!
        LinearScaleRange3.Name = "Range2"
        LinearScaleRange3.ShapeOffset = -12.0!
        LinearScaleRange3.StartThickness = 3.0!
        LinearScaleRange3.StartValue = 66.0!
        Me.LinearScaleComponent1.Ranges.AddRange(New DevExpress.XtraGauges.Core.Model.IRange() {LinearScaleRange1, LinearScaleRange2, LinearScaleRange3})
        Me.LinearScaleComponent1.StartPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(62.5!, 212.0!)
        Me.LinearScaleComponent1.Value = 50.0!
        '
        'LinearScaleLevelComponent1
        '
        Me.LinearScaleLevelComponent1.LinearScale = Me.LinearScaleComponent1
        Me.LinearScaleLevelComponent1.Name = "level1"
        Me.LinearScaleLevelComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.LevelShapeSetType.Style21
        Me.LinearScaleLevelComponent1.ZOrder = -50
        '
        'Grafica
        '
        Me.Grafica.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Grafica.Location = New System.Drawing.Point(4, 220)
        Me.Grafica.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Grafica.Name = "Grafica"
        Me.Grafica.SeriesSerializable = New DevExpress.XtraCharts.Series(-1) {}
        Me.Grafica.Size = New System.Drawing.Size(620, 231)
        Me.Grafica.TabIndex = 142
        '
        'GroupControl1
        '
        Me.GroupControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl1.Controls.Add(Me.dgvResultado)
        Me.GroupControl1.Location = New System.Drawing.Point(6, 82)
        Me.GroupControl1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(619, 136)
        Me.GroupControl1.TabIndex = 141
        Me.GroupControl1.Text = "Almacenamiento Historico"
        '
        'dgvResultado
        '
        Me.dgvResultado.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvResultado.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dgvResultado.Location = New System.Drawing.Point(4, 29)
        Me.dgvResultado.MainView = Me.dgvViewResultado
        Me.dgvResultado.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dgvResultado.Name = "dgvResultado"
        Me.dgvResultado.Size = New System.Drawing.Size(615, 102)
        Me.dgvResultado.TabIndex = 3
        Me.dgvResultado.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.dgvViewResultado, Me.GridView1})
        '
        'dgvViewResultado
        '
        Me.dgvViewResultado.DetailHeight = 284
        Me.dgvViewResultado.GridControl = Me.dgvResultado
        Me.dgvViewResultado.Name = "dgvViewResultado"
        Me.dgvViewResultado.OptionsCustomization.AllowSort = False
        Me.dgvViewResultado.OptionsView.ShowGroupPanel = False
        '
        'GridView1
        '
        Me.GridView1.DetailHeight = 284
        Me.GridView1.GridControl = Me.dgvResultado
        Me.GridView1.Name = "GridView1"
        '
        'BtnBuscar
        '
        Me.BtnBuscar.ImageOptions.Image = CType(resources.GetObject("BtnBuscar.ImageOptions.Image"), System.Drawing.Image)
        Me.BtnBuscar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.BtnBuscar.Location = New System.Drawing.Point(357, 41)
        Me.BtnBuscar.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(34, 35)
        Me.BtnBuscar.TabIndex = 140
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(308, 11)
        Me.LabelControl3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(42, 19)
        Me.LabelControl3.TabIndex = 139
        Me.LabelControl3.Text = "Hasta:"
        '
        'dtpFechaInicio
        '
        Me.dtpFechaInicio.EditValue = Nothing
        Me.dtpFechaInicio.Location = New System.Drawing.Point(136, 10)
        Me.dtpFechaInicio.Name = "dtpFechaInicio"
        Me.dtpFechaInicio.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaInicio.Properties.Appearance.Options.UseFont = True
        Me.dtpFechaInicio.Properties.AppearanceCalendar.Header.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaInicio.Properties.AppearanceCalendar.Header.Options.UseFont = True
        Me.dtpFechaInicio.Properties.AppearanceCalendar.HeaderHighlighted.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaInicio.Properties.AppearanceCalendar.HeaderHighlighted.Options.UseFont = True
        Me.dtpFechaInicio.Properties.AppearanceCalendar.HeaderPressed.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaInicio.Properties.AppearanceCalendar.HeaderPressed.Options.UseFont = True
        Me.dtpFechaInicio.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpFechaInicio.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpFechaInicio.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Fluent
        Me.dtpFechaInicio.Properties.MaskSettings.Set("mask", "yyyyMMdd")
        Me.dtpFechaInicio.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.[False]
        Me.dtpFechaInicio.Size = New System.Drawing.Size(164, 26)
        Me.dtpFechaInicio.TabIndex = 138
        '
        'cmbAlmacen
        '
        Me.cmbAlmacen.Location = New System.Drawing.Point(136, 41)
        Me.cmbAlmacen.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmbAlmacen.Name = "cmbAlmacen"
        Me.cmbAlmacen.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAlmacen.Properties.Appearance.Options.UseFont = True
        Me.cmbAlmacen.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbAlmacen.Properties.NullText = ""
        Me.cmbAlmacen.Properties.PopupSizeable = False
        Me.cmbAlmacen.Properties.PopupView = Me.GridView3
        Me.cmbAlmacen.Size = New System.Drawing.Size(164, 26)
        Me.cmbAlmacen.TabIndex = 137
        '
        'GridView3
        '
        Me.GridView3.Appearance.EvenRow.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.GridView3.Appearance.EvenRow.Options.UseFont = True
        Me.GridView3.Appearance.FixedLine.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView3.Appearance.FixedLine.Options.UseFont = True
        Me.GridView3.Appearance.FocusedRow.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.GridView3.Appearance.FocusedRow.Options.UseFont = True
        Me.GridView3.Appearance.FooterPanel.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.GridView3.Appearance.FooterPanel.Options.UseFont = True
        Me.GridView3.Appearance.GroupFooter.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.GridView3.Appearance.GroupFooter.Options.UseFont = True
        Me.GridView3.Appearance.GroupRow.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.GridView3.Appearance.GroupRow.Options.UseFont = True
        Me.GridView3.Appearance.HeaderPanel.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView3.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridView3.Appearance.OddRow.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.GridView3.Appearance.OddRow.Options.UseFont = True
        Me.GridView3.Appearance.Preview.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.GridView3.Appearance.Preview.Options.UseFont = True
        Me.GridView3.Appearance.Row.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.GridView3.Appearance.Row.Options.UseFont = True
        Me.GridView3.Appearance.RowSeparator.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.GridView3.Appearance.RowSeparator.Options.UseFont = True
        Me.GridView3.Appearance.SelectedRow.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.GridView3.Appearance.SelectedRow.Options.UseFont = True
        Me.GridView3.Appearance.TopNewRow.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.GridView3.Appearance.TopNewRow.Options.UseFont = True
        Me.GridView3.DetailHeight = 303
        Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(6, 42)
        Me.LabelControl2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(63, 19)
        Me.LabelControl2.TabIndex = 135
        Me.LabelControl2.Text = "Almacen:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(6, 14)
        Me.LabelControl1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(136, 19)
        Me.LabelControl1.TabIndex = 134
        Me.LabelControl1.Text = "Intervalo de Fechas:"
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.EditValue = Nothing
        Me.dtpFechaFin.Location = New System.Drawing.Point(357, 11)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaFin.Properties.Appearance.Options.UseFont = True
        Me.dtpFechaFin.Properties.AppearanceCalendar.Header.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaFin.Properties.AppearanceCalendar.Header.Options.UseFont = True
        Me.dtpFechaFin.Properties.AppearanceCalendar.HeaderHighlighted.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaFin.Properties.AppearanceCalendar.HeaderHighlighted.Options.UseFont = True
        Me.dtpFechaFin.Properties.AppearanceCalendar.HeaderPressed.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaFin.Properties.AppearanceCalendar.HeaderPressed.Options.UseFont = True
        Me.dtpFechaFin.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpFechaFin.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpFechaFin.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Fluent
        Me.dtpFechaFin.Properties.MaskSettings.Set("mask", "yyyyMMdd")
        Me.dtpFechaFin.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.[False]
        Me.dtpFechaFin.Size = New System.Drawing.Size(160, 26)
        Me.dtpFechaFin.TabIndex = 133
        '
        'TabNavigationPage2
        '
        Me.TabNavigationPage2.Caption = "TabNavigationPage2"
        Me.TabNavigationPage2.Controls.Add(Me.ChartControl3)
        Me.TabNavigationPage2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabNavigationPage2.Name = "TabNavigationPage2"
        Me.TabNavigationPage2.Size = New System.Drawing.Size(627, 602)
        '
        'ChartControl3
        '
        Me.ChartControl3.Location = New System.Drawing.Point(2, 245)
        Me.ChartControl3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ChartControl3.Name = "ChartControl3"
        Me.ChartControl3.SeriesSerializable = New DevExpress.XtraCharts.Series(-1) {}
        Me.ChartControl3.Size = New System.Drawing.Size(625, 354)
        Me.ChartControl3.TabIndex = 0
        '
        'SeparatorControl1
        '
        Me.SeparatorControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SeparatorControl1.AutoSizeMode = True
        Me.SeparatorControl1.LineAlignment = DevExpress.XtraEditors.Alignment.Center
        Me.SeparatorControl1.LineOrientation = System.Windows.Forms.Orientation.Vertical
        Me.SeparatorControl1.Location = New System.Drawing.Point(638, 10)
        Me.SeparatorControl1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.SeparatorControl1.Name = "SeparatorControl1"
        Me.SeparatorControl1.Padding = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.SeparatorControl1.Size = New System.Drawing.Size(17, 618)
        Me.SeparatorControl1.TabIndex = 183
        '
        'GaugeControl2
        '
        Me.GaugeControl2.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.dGauge1})
        Me.GaugeControl2.LayoutInterval = 4
        Me.GaugeControl2.LayoutPadding = New DevExpress.XtraGauges.Core.Base.Thickness(4, 5, 4, 5)
        Me.GaugeControl2.Location = New System.Drawing.Point(689, 223)
        Me.GaugeControl2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GaugeControl2.Name = "GaugeControl2"
        Me.GaugeControl2.Size = New System.Drawing.Size(188, 203)
        Me.GaugeControl2.TabIndex = 186
        '
        'dGauge1
        '
        Me.dGauge1.AppearanceOff.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#0FD4F2FF")
        Me.dGauge1.AppearanceOn.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#D4F2FF")
        Me.dGauge1.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent() {Me.DigitalBackgroundLayerComponent1})
        Me.dGauge1.Bounds = New System.Drawing.Rectangle(4, 5, 180, 193)
        Me.dGauge1.DigitCount = 4
        Me.dGauge1.DisplayMode = DevExpress.XtraGauges.Core.Model.DigitalGaugeDisplayMode.SevenSegment
        Me.dGauge1.Name = "dGauge1"
        Me.dGauge1.Text = "00:00"
        '
        'DigitalBackgroundLayerComponent1
        '
        Me.DigitalBackgroundLayerComponent1.BottomRight = New DevExpress.XtraGauges.Core.Base.PointF2D(205.1!, 106.075!)
        Me.DigitalBackgroundLayerComponent1.Name = "b1"
        Me.DigitalBackgroundLayerComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.DigitalBackgroundShapeSetType.Style2
        Me.DigitalBackgroundLayerComponent1.TopLeft = New DevExpress.XtraGauges.Core.Base.PointF2D(20.0!, 0!)
        Me.DigitalBackgroundLayerComponent1.ZOrder = 1000
        '
        'FrmAlmacenHistorico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(980, 649)
        Me.Controls.Add(Me.GaugeControl2)
        Me.Controls.Add(Me.SeparatorControl1)
        Me.Controls.Add(Me.ChartControl4)
        Me.Controls.Add(Me.TabPane1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "FrmAlmacenHistorico"
        Me.Text = "FrmAlmacenHistorico"
        CType(Me.ChartControl4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabPane1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPane1.ResumeLayout(False)
        Me.TabNavigationPage1.ResumeLayout(False)
        Me.TabNavigationPage1.PerformLayout()
        CType(Me.linearGauge9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LinearScaleBackgroundLayerComponent1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LinearScaleComponent1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LinearScaleLevelComponent1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grafica, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.dgvResultado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvViewResultado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaInicio.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaInicio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbAlmacen.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaFin.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaFin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabNavigationPage2.ResumeLayout(False)
        CType(Me.ChartControl3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeparatorControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dGauge1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DigitalBackgroundLayerComponent1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ChartControl4 As DevExpress.XtraCharts.ChartControl
    Friend WithEvents TabPane1 As DevExpress.XtraBars.Navigation.TabPane
    Friend WithEvents TabNavigationPage1 As DevExpress.XtraBars.Navigation.TabNavigationPage
    Friend WithEvents Grafica As DevExpress.XtraCharts.ChartControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents dgvResultado As DevExpress.XtraGrid.GridControl
    Friend WithEvents dgvViewResultado As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents BtnBuscar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dtpFechaInicio As DevExpress.XtraEditors.DateEdit
    Friend WithEvents cmbAlmacen As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dtpFechaFin As DevExpress.XtraEditors.DateEdit
    Friend WithEvents TabNavigationPage2 As DevExpress.XtraBars.Navigation.TabNavigationPage
    Friend WithEvents ChartControl3 As DevExpress.XtraCharts.ChartControl
    Friend WithEvents SeparatorControl1 As DevExpress.XtraEditors.SeparatorControl
    Friend WithEvents GaugeControl1 As DevExpress.XtraGauges.Win.GaugeControl
    Friend WithEvents linearGauge9 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearGauge
    Private WithEvents LinearScaleBackgroundLayerComponent1 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleBackgroundLayerComponent
    Private WithEvents LinearScaleComponent1 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent
    Private WithEvents LinearScaleLevelComponent1 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleLevelComponent
    Friend WithEvents GaugeControl2 As DevExpress.XtraGauges.Win.GaugeControl
    Friend WithEvents dGauge1 As DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge
    Private WithEvents DigitalBackgroundLayerComponent1 As DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent
End Class
