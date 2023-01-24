<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBalanceCargas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBalanceCargas))
        Dim XyDiagram1 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
        Dim Series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim FullStackedBarSeriesView1 As DevExpress.XtraCharts.FullStackedBarSeriesView = New DevExpress.XtraCharts.FullStackedBarSeriesView()
        Dim FullStackedBarSeriesView2 As DevExpress.XtraCharts.FullStackedBarSeriesView = New DevExpress.XtraCharts.FullStackedBarSeriesView()
        Dim ChartTitle1 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
        Dim ChartTitle2 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
        Dim ChartTitle3 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
        Dim ChartTitle4 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
        Me.BtnBuscar = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.dtpFechaInicio = New DevExpress.XtraEditors.DateEdit()
        Me.dtpFechaFin = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.LabelPrincipal = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton9 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton8 = New DevExpress.XtraEditors.SimpleButton()
        Me.ChartBalance = New DevExpress.XtraCharts.ChartControl()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rdpartidas = New System.Windows.Forms.RadioButton()
        Me.rdarticulos = New System.Windows.Forms.RadioButton()
        Me.dgvDetalleBalance = New DevExpress.XtraGrid.GridControl()
        Me.GridViewBalance = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GroupControl2Prod = New DevExpress.XtraEditors.GroupControl()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.lblinfo4 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.lblinfo3 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.lblinfo2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblinfo1 = New System.Windows.Forms.Label()
        CType(Me.dtpFechaInicio.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaInicio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaFin.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaFin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.ChartBalance, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(XyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(FullStackedBarSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(FullStackedBarSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDetalleBalance, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewBalance, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2Prod, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2Prod.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuscar.Appearance.Options.UseFont = True
        Me.BtnBuscar.ImageOptions.Image = CType(resources.GetObject("BtnBuscar.ImageOptions.Image"), System.Drawing.Image)
        Me.BtnBuscar.Location = New System.Drawing.Point(338, 8)
        Me.BtnBuscar.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(38, 32)
        Me.BtnBuscar.TabIndex = 4
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Appearance.Options.UseTextOptions = True
        Me.LabelControl3.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.LabelControl3.Location = New System.Drawing.Point(171, 15)
        Me.LabelControl3.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(42, 19)
        Me.LabelControl3.TabIndex = 101
        Me.LabelControl3.Text = "Hasta:"
        '
        'dtpFechaInicio
        '
        Me.dtpFechaInicio.EditValue = Nothing
        Me.dtpFechaInicio.Location = New System.Drawing.Point(56, 12)
        Me.dtpFechaInicio.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.dtpFechaInicio.Name = "dtpFechaInicio"
        Me.dtpFechaInicio.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaInicio.Properties.Appearance.Options.UseFont = True
        Me.dtpFechaInicio.Properties.AppearanceCalendar.CalendarHeader.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaInicio.Properties.AppearanceCalendar.CalendarHeader.Options.UseFont = True
        Me.dtpFechaInicio.Properties.AppearanceCalendar.Header.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaInicio.Properties.AppearanceCalendar.Header.Options.UseFont = True
        Me.dtpFechaInicio.Properties.AppearanceCalendar.HeaderHighlighted.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaInicio.Properties.AppearanceCalendar.HeaderHighlighted.Options.UseFont = True
        Me.dtpFechaInicio.Properties.AppearanceCalendar.HeaderPressed.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaInicio.Properties.AppearanceCalendar.HeaderPressed.Options.UseFont = True
        Me.dtpFechaInicio.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaInicio.Properties.AppearanceDropDown.Options.UseFont = True
        Me.dtpFechaInicio.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpFechaInicio.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpFechaInicio.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Fluent
        Me.dtpFechaInicio.Properties.MaskSettings.Set("mask", "yyyyMMdd")
        Me.dtpFechaInicio.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.[False]
        Me.dtpFechaInicio.Size = New System.Drawing.Size(111, 26)
        Me.dtpFechaInicio.TabIndex = 2
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.EditValue = Nothing
        Me.dtpFechaFin.Location = New System.Drawing.Point(216, 11)
        Me.dtpFechaFin.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaFin.Properties.Appearance.Options.UseFont = True
        Me.dtpFechaFin.Properties.AppearanceCalendar.CalendarHeader.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaFin.Properties.AppearanceCalendar.CalendarHeader.Options.UseFont = True
        Me.dtpFechaFin.Properties.AppearanceCalendar.Header.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaFin.Properties.AppearanceCalendar.Header.Options.UseFont = True
        Me.dtpFechaFin.Properties.AppearanceCalendar.HeaderHighlighted.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaFin.Properties.AppearanceCalendar.HeaderHighlighted.Options.UseFont = True
        Me.dtpFechaFin.Properties.AppearanceCalendar.HeaderPressed.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaFin.Properties.AppearanceCalendar.HeaderPressed.Options.UseFont = True
        Me.dtpFechaFin.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaFin.Properties.AppearanceDropDown.Options.UseFont = True
        Me.dtpFechaFin.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpFechaFin.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpFechaFin.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Fluent
        Me.dtpFechaFin.Properties.MaskSettings.Set("mask", "yyyyMMdd")
        Me.dtpFechaFin.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.[False]
        Me.dtpFechaFin.Size = New System.Drawing.Size(111, 26)
        Me.dtpFechaFin.TabIndex = 3
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Appearance.Options.UseTextOptions = True
        Me.LabelControl5.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.LabelControl5.Location = New System.Drawing.Point(4, 15)
        Me.LabelControl5.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(45, 19)
        Me.LabelControl5.TabIndex = 99
        Me.LabelControl5.Text = "Desde:"
        '
        'GroupControl1
        '
        Me.GroupControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.Controls.Add(Me.LabelPrincipal)
        Me.GroupControl1.Controls.Add(Me.SimpleButton9)
        Me.GroupControl1.Controls.Add(Me.SimpleButton8)
        Me.GroupControl1.Controls.Add(Me.BtnBuscar)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.dtpFechaInicio)
        Me.GroupControl1.Controls.Add(Me.dtpFechaFin)
        Me.GroupControl1.Controls.Add(Me.LabelControl5)
        Me.GroupControl1.Location = New System.Drawing.Point(9, 12)
        Me.GroupControl1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.ShowCaption = False
        Me.GroupControl1.Size = New System.Drawing.Size(1019, 51)
        Me.GroupControl1.TabIndex = 315
        Me.GroupControl1.Text = "Filtros"
        '
        'LabelPrincipal
        '
        Me.LabelPrincipal.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelPrincipal.Appearance.Font = New System.Drawing.Font("Calibri", 20.0!, System.Drawing.FontStyle.Bold)
        Me.LabelPrincipal.Appearance.Options.UseFont = True
        Me.LabelPrincipal.Appearance.Options.UseTextOptions = True
        Me.LabelPrincipal.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelPrincipal.Location = New System.Drawing.Point(448, 8)
        Me.LabelPrincipal.MinimumSize = New System.Drawing.Size(500, 0)
        Me.LabelPrincipal.Name = "LabelPrincipal"
        Me.LabelPrincipal.Size = New System.Drawing.Size(500, 33)
        Me.LabelPrincipal.TabIndex = 543
        Me.LabelPrincipal.Text = "Balance de cargas"
        '
        'SimpleButton9
        '
        Me.SimpleButton9.ImageOptions.Image = CType(resources.GetObject("SimpleButton9.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton9.Location = New System.Drawing.Point(381, 5)
        Me.SimpleButton9.MinimumSize = New System.Drawing.Size(40, 40)
        Me.SimpleButton9.Name = "SimpleButton9"
        Me.SimpleButton9.Size = New System.Drawing.Size(40, 40)
        Me.SimpleButton9.TabIndex = 541
        '
        'SimpleButton8
        '
        Me.SimpleButton8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton8.ImageOptions.Image = CType(resources.GetObject("SimpleButton8.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton8.Location = New System.Drawing.Point(974, 5)
        Me.SimpleButton8.MinimumSize = New System.Drawing.Size(40, 40)
        Me.SimpleButton8.Name = "SimpleButton8"
        Me.SimpleButton8.Size = New System.Drawing.Size(40, 40)
        Me.SimpleButton8.TabIndex = 542
        '
        'ChartBalance
        '
        Me.ChartBalance.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChartBalance.AnimationStartMode = DevExpress.XtraCharts.ChartAnimationMode.OnDataChanged
        Me.ChartBalance.AppearanceNameSerializable = "Dark"
        Me.ChartBalance.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ChartBalance.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.[True]
        XyDiagram1.AxisX.Reverse = True
        XyDiagram1.AxisX.Visibility = DevExpress.Utils.DefaultBoolean.[False]
        XyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
        XyDiagram1.AxisY.GridLines.Visible = False
        XyDiagram1.AxisY.Interlaced = True
        XyDiagram1.AxisY.MinorCount = 4
        XyDiagram1.AxisY.Visibility = DevExpress.Utils.DefaultBoolean.[False]
        XyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
        Me.ChartBalance.Diagram = XyDiagram1
        Me.ChartBalance.Legend.Name = "Default Legend"
        Me.ChartBalance.Location = New System.Drawing.Point(3, 104)
        Me.ChartBalance.Margin = New System.Windows.Forms.Padding(2)
        Me.ChartBalance.Name = "ChartBalance"
        Me.ChartBalance.PaletteBaseColorNumber = 2
        Me.ChartBalance.PaletteName = "Flow"
        Series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[True]
        Series1.LegendName = "Default Legend"
        Series1.Name = "Cantidad"
        Series1.View = FullStackedBarSeriesView1
        Me.ChartBalance.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series1}
        Me.ChartBalance.SeriesTemplate.View = FullStackedBarSeriesView2
        Me.ChartBalance.Size = New System.Drawing.Size(724, 510)
        Me.ChartBalance.TabIndex = 316
        ChartTitle1.Text = "Almacén (Vista aérea)"
        ChartTitle2.Dock = DevExpress.XtraCharts.ChartTitleDockStyle.Bottom
        ChartTitle2.Text = "Andén"
        ChartTitle3.Dock = DevExpress.XtraCharts.ChartTitleDockStyle.Right
        ChartTitle3.Text = "Oficinas"
        ChartTitle4.Dock = DevExpress.XtraCharts.ChartTitleDockStyle.Left
        ChartTitle4.Text = "Nave 2"
        Me.ChartBalance.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ChartTitle1, ChartTitle2, ChartTitle3, ChartTitle4})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(16, 83)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 19)
        Me.Label1.TabIndex = 319
        Me.Label1.Text = "Tipo:"
        '
        'rdpartidas
        '
        Me.rdpartidas.AutoSize = True
        Me.rdpartidas.Checked = True
        Me.rdpartidas.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.rdpartidas.Location = New System.Drawing.Point(67, 81)
        Me.rdpartidas.Margin = New System.Windows.Forms.Padding(2)
        Me.rdpartidas.Name = "rdpartidas"
        Me.rdpartidas.Size = New System.Drawing.Size(194, 23)
        Me.rdpartidas.TabIndex = 321
        Me.rdpartidas.TabStop = True
        Me.rdpartidas.Text = "Por cantidad de partidas"
        Me.rdpartidas.UseVisualStyleBackColor = True
        '
        'rdarticulos
        '
        Me.rdarticulos.AutoSize = True
        Me.rdarticulos.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.rdarticulos.Location = New System.Drawing.Point(262, 81)
        Me.rdarticulos.Margin = New System.Windows.Forms.Padding(2)
        Me.rdarticulos.Name = "rdarticulos"
        Me.rdarticulos.Size = New System.Drawing.Size(197, 23)
        Me.rdarticulos.TabIndex = 322
        Me.rdarticulos.Text = "Por cantidad de artículos"
        Me.rdarticulos.UseVisualStyleBackColor = True
        '
        'dgvDetalleBalance
        '
        Me.dgvDetalleBalance.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvDetalleBalance.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvDetalleBalance.Location = New System.Drawing.Point(4, 28)
        Me.dgvDetalleBalance.MainView = Me.GridViewBalance
        Me.dgvDetalleBalance.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvDetalleBalance.Name = "dgvDetalleBalance"
        Me.dgvDetalleBalance.Size = New System.Drawing.Size(288, 367)
        Me.dgvDetalleBalance.TabIndex = 323
        Me.dgvDetalleBalance.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewBalance})
        '
        'GridViewBalance
        '
        Me.GridViewBalance.DetailHeight = 284
        Me.GridViewBalance.GridControl = Me.dgvDetalleBalance
        Me.GridViewBalance.Name = "GridViewBalance"
        Me.GridViewBalance.OptionsBehavior.ReadOnly = True
        Me.GridViewBalance.OptionsView.ColumnAutoWidth = False
        Me.GridViewBalance.OptionsView.ShowGroupPanel = False
        '
        'GroupControl2Prod
        '
        Me.GroupControl2Prod.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl2Prod.AppearanceCaption.FontSizeDelta = 5
        Me.GroupControl2Prod.AppearanceCaption.FontStyleDelta = System.Drawing.FontStyle.Bold
        Me.GroupControl2Prod.AppearanceCaption.Options.UseFont = True
        Me.GroupControl2Prod.Controls.Add(Me.dgvDetalleBalance)
        Me.GroupControl2Prod.Location = New System.Drawing.Point(732, 67)
        Me.GroupControl2Prod.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupControl2Prod.Name = "GroupControl2Prod"
        Me.GroupControl2Prod.Size = New System.Drawing.Size(296, 399)
        Me.GroupControl2Prod.TabIndex = 324
        Me.GroupControl2Prod.Text = "Artículos surtidos"
        '
        'GroupControl2
        '
        Me.GroupControl2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl2.AppearanceCaption.FontSizeDelta = 5
        Me.GroupControl2.AppearanceCaption.FontStyleDelta = System.Drawing.FontStyle.Bold
        Me.GroupControl2.AppearanceCaption.Options.UseFont = True
        Me.GroupControl2.Controls.Add(Me.Button4)
        Me.GroupControl2.Controls.Add(Me.lblinfo4)
        Me.GroupControl2.Controls.Add(Me.Button3)
        Me.GroupControl2.Controls.Add(Me.lblinfo3)
        Me.GroupControl2.Controls.Add(Me.Button2)
        Me.GroupControl2.Controls.Add(Me.lblinfo2)
        Me.GroupControl2.Controls.Add(Me.Button1)
        Me.GroupControl2.Controls.Add(Me.lblinfo1)
        Me.GroupControl2.Location = New System.Drawing.Point(736, 470)
        Me.GroupControl2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(292, 135)
        Me.GroupControl2.TabIndex = 325
        Me.GroupControl2.Text = "Información"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Black
        Me.Button4.Location = New System.Drawing.Point(16, 100)
        Me.Button4.Margin = New System.Windows.Forms.Padding(2)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(56, 19)
        Me.Button4.TabIndex = 333
        Me.Button4.UseVisualStyleBackColor = False
        '
        'lblinfo4
        '
        Me.lblinfo4.AutoSize = True
        Me.lblinfo4.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblinfo4.Location = New System.Drawing.Point(77, 98)
        Me.lblinfo4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblinfo4.Name = "lblinfo4"
        Me.lblinfo4.Size = New System.Drawing.Size(53, 19)
        Me.lblinfo4.TabIndex = 332
        Me.lblinfo4.Text = "Label6"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Gold
        Me.Button3.Location = New System.Drawing.Point(16, 76)
        Me.Button3.Margin = New System.Windows.Forms.Padding(2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(56, 19)
        Me.Button3.TabIndex = 331
        Me.Button3.UseVisualStyleBackColor = False
        '
        'lblinfo3
        '
        Me.lblinfo3.AutoSize = True
        Me.lblinfo3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblinfo3.Location = New System.Drawing.Point(77, 74)
        Me.lblinfo3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblinfo3.Name = "lblinfo3"
        Me.lblinfo3.Size = New System.Drawing.Size(53, 19)
        Me.lblinfo3.TabIndex = 330
        Me.lblinfo3.Text = "Label5"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DarkOrange
        Me.Button2.Location = New System.Drawing.Point(16, 53)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(56, 19)
        Me.Button2.TabIndex = 329
        Me.Button2.UseVisualStyleBackColor = False
        '
        'lblinfo2
        '
        Me.lblinfo2.AutoSize = True
        Me.lblinfo2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblinfo2.Location = New System.Drawing.Point(77, 50)
        Me.lblinfo2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblinfo2.Name = "lblinfo2"
        Me.lblinfo2.Size = New System.Drawing.Size(53, 19)
        Me.lblinfo2.TabIndex = 328
        Me.lblinfo2.Text = "Label4"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.ForeColor = System.Drawing.Color.Red
        Me.Button1.Location = New System.Drawing.Point(16, 29)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(56, 19)
        Me.Button1.TabIndex = 327
        Me.Button1.UseVisualStyleBackColor = False
        '
        'lblinfo1
        '
        Me.lblinfo1.AutoSize = True
        Me.lblinfo1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblinfo1.Location = New System.Drawing.Point(77, 27)
        Me.lblinfo1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblinfo1.Name = "lblinfo1"
        Me.lblinfo1.Size = New System.Drawing.Size(61, 19)
        Me.lblinfo1.TabIndex = 326
        Me.lblinfo1.Text = "lblinfo1"
        '
        'FrmBalanceCargas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1035, 616)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl2Prod)
        Me.Controls.Add(Me.rdarticulos)
        Me.Controls.Add(Me.rdpartidas)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ChartBalance)
        Me.Controls.Add(Me.GroupControl1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FrmBalanceCargas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmBalanceCargas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dtpFechaInicio.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaInicio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaFin.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaFin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(XyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(FullStackedBarSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(FullStackedBarSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartBalance, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDetalleBalance, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewBalance, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2Prod, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2Prod.ResumeLayout(False)
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnBuscar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dtpFechaInicio As DevExpress.XtraEditors.DateEdit
    Friend WithEvents dtpFechaFin As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents ChartBalance As DevExpress.XtraCharts.ChartControl
    Friend WithEvents Label1 As Label
    Friend WithEvents rdpartidas As RadioButton
    Friend WithEvents rdarticulos As RadioButton
    Friend WithEvents dgvDetalleBalance As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewBalance As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GroupControl2Prod As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Button4 As Button
    Friend WithEvents lblinfo4 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents lblinfo3 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents lblinfo2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents lblinfo1 As Label
    Friend WithEvents LabelPrincipal As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton9 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton8 As DevExpress.XtraEditors.SimpleButton
End Class
