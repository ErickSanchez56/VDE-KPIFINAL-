<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDetalleRequerimientoClienteEmb
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDetalleRequerimientoClienteEmb))
        Me.SimpleButton9 = New DevExpress.XtraEditors.SimpleButton()
        Me.dtpFechaInicio = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.BtnBuscar = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.dtpFechaFin = New DevExpress.XtraEditors.DateEdit()
        Me.LabelPrincipal = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton8 = New DevExpress.XtraEditors.SimpleButton()
        Me.SeparatorControl3 = New DevExpress.XtraEditors.SeparatorControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.DgvDetalleOrdenesCP = New DevExpress.XtraGrid.GridControl()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ChartControl3 = New DevExpress.XtraCharts.ChartControl()
        Me.Lblporcentajeembcom = New DevExpress.XtraEditors.LabelControl()
        Me.Lblporcentajesurtidascom = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton5 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton6 = New DevExpress.XtraEditors.SimpleButton()
        Me.ChartControl1 = New DevExpress.XtraCharts.ChartControl()
        CType(Me.dtpFechaInicio.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaInicio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaFin.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaFin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeparatorControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.DgvDetalleOrdenesCP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChartControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SimpleButton9
        '
        Me.SimpleButton9.ImageOptions.Image = CType(resources.GetObject("SimpleButton9.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton9.Location = New System.Drawing.Point(400, 4)
        Me.SimpleButton9.MinimumSize = New System.Drawing.Size(40, 40)
        Me.SimpleButton9.Name = "SimpleButton9"
        Me.SimpleButton9.Size = New System.Drawing.Size(40, 40)
        Me.SimpleButton9.TabIndex = 516
        '
        'dtpFechaInicio
        '
        Me.dtpFechaInicio.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dtpFechaInicio.EditValue = Nothing
        Me.dtpFechaInicio.Location = New System.Drawing.Point(51, 10)
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
        Me.dtpFechaInicio.Size = New System.Drawing.Size(111, 26)
        Me.dtpFechaInicio.TabIndex = 519
        '
        'LabelControl3
        '
        Me.LabelControl3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(2, 15)
        Me.LabelControl3.Margin = New System.Windows.Forms.Padding(2)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(45, 19)
        Me.LabelControl3.TabIndex = 520
        Me.LabelControl3.Text = "Desde:"
        '
        'BtnBuscar
        '
        Me.BtnBuscar.ImageOptions.Image = CType(resources.GetObject("BtnBuscar.ImageOptions.Image"), System.Drawing.Image)
        Me.BtnBuscar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.BtnBuscar.Location = New System.Drawing.Point(347, 10)
        Me.BtnBuscar.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(34, 25)
        Me.BtnBuscar.TabIndex = 523
        '
        'LabelControl5
        '
        Me.LabelControl5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Location = New System.Drawing.Point(179, 15)
        Me.LabelControl5.Margin = New System.Windows.Forms.Padding(2)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(42, 19)
        Me.LabelControl5.TabIndex = 522
        Me.LabelControl5.Text = "Hasta:"
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dtpFechaFin.EditValue = Nothing
        Me.dtpFechaFin.Location = New System.Drawing.Point(225, 10)
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
        Me.dtpFechaFin.Size = New System.Drawing.Size(111, 26)
        Me.dtpFechaFin.TabIndex = 521
        '
        'LabelPrincipal
        '
        Me.LabelPrincipal.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelPrincipal.Appearance.Font = New System.Drawing.Font("Calibri", 20.0!, System.Drawing.FontStyle.Bold)
        Me.LabelPrincipal.Appearance.Options.UseFont = True
        Me.LabelPrincipal.Appearance.Options.UseTextOptions = True
        Me.LabelPrincipal.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelPrincipal.Location = New System.Drawing.Point(478, 4)
        Me.LabelPrincipal.MinimumSize = New System.Drawing.Size(500, 0)
        Me.LabelPrincipal.Name = "LabelPrincipal"
        Me.LabelPrincipal.Size = New System.Drawing.Size(500, 33)
        Me.LabelPrincipal.TabIndex = 518
        Me.LabelPrincipal.Text = "Órdenes con cantidad completa embarcada"
        '
        'SimpleButton8
        '
        Me.SimpleButton8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton8.ImageOptions.Image = CType(resources.GetObject("SimpleButton8.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton8.Location = New System.Drawing.Point(997, 3)
        Me.SimpleButton8.MinimumSize = New System.Drawing.Size(40, 40)
        Me.SimpleButton8.Name = "SimpleButton8"
        Me.SimpleButton8.Size = New System.Drawing.Size(40, 40)
        Me.SimpleButton8.TabIndex = 517
        '
        'SeparatorControl3
        '
        Me.SeparatorControl3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SeparatorControl3.AutoSizeMode = True
        Me.SeparatorControl3.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.SeparatorControl3.LineAlignment = DevExpress.XtraEditors.Alignment.Center
        Me.SeparatorControl3.LineColor = System.Drawing.Color.ForestGreen
        Me.SeparatorControl3.LineThickness = 3
        Me.SeparatorControl3.Location = New System.Drawing.Point(1, 34)
        Me.SeparatorControl3.Name = "SeparatorControl3"
        Me.SeparatorControl3.Padding = New System.Windows.Forms.Padding(8)
        Me.SeparatorControl3.Size = New System.Drawing.Size(1029, 19)
        Me.SeparatorControl3.TabIndex = 524
        '
        'GroupControl1
        '
        Me.GroupControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Calibri", 15.0!, System.Drawing.FontStyle.Bold)
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.Controls.Add(Me.DgvDetalleOrdenesCP)
        Me.GroupControl1.Location = New System.Drawing.Point(2, 311)
        Me.GroupControl1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(1035, 336)
        Me.GroupControl1.TabIndex = 525
        Me.GroupControl1.Text = "Detalle de órdenes con la cantidad completa"
        '
        'DgvDetalleOrdenesCP
        '
        Me.DgvDetalleOrdenesCP.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvDetalleOrdenesCP.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(2)
        Me.DgvDetalleOrdenesCP.Location = New System.Drawing.Point(1, 29)
        Me.DgvDetalleOrdenesCP.MainView = Me.GridView3
        Me.DgvDetalleOrdenesCP.Margin = New System.Windows.Forms.Padding(2)
        Me.DgvDetalleOrdenesCP.Name = "DgvDetalleOrdenesCP"
        Me.DgvDetalleOrdenesCP.Size = New System.Drawing.Size(1030, 303)
        Me.DgvDetalleOrdenesCP.TabIndex = 217
        Me.DgvDetalleOrdenesCP.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView3, Me.GridView4})
        '
        'GridView3
        '
        Me.GridView3.DetailHeight = 284
        Me.GridView3.GridControl = Me.DgvDetalleOrdenesCP
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsCustomization.AllowSort = False
        Me.GridView3.OptionsPrint.AutoWidth = False
        Me.GridView3.OptionsView.ColumnAutoWidth = False
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'GridView4
        '
        Me.GridView4.DetailHeight = 284
        Me.GridView4.GridControl = Me.DgvDetalleOrdenesCP
        Me.GridView4.Name = "GridView4"
        '
        'ChartControl3
        '
        Me.ChartControl3.Location = New System.Drawing.Point(6, 50)
        Me.ChartControl3.Margin = New System.Windows.Forms.Padding(2)
        Me.ChartControl3.Name = "ChartControl3"
        Me.ChartControl3.SeriesSerializable = New DevExpress.XtraCharts.Series(-1) {}
        Me.ChartControl3.Size = New System.Drawing.Size(515, 249)
        Me.ChartControl3.TabIndex = 526
        '
        'Lblporcentajeembcom
        '
        Me.Lblporcentajeembcom.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Lblporcentajeembcom.Appearance.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblporcentajeembcom.Appearance.Options.UseFont = True
        Me.Lblporcentajeembcom.Location = New System.Drawing.Point(285, 245)
        Me.Lblporcentajeembcom.Name = "Lblporcentajeembcom"
        Me.Lblporcentajeembcom.Size = New System.Drawing.Size(12, 19)
        Me.Lblporcentajeembcom.TabIndex = 532
        Me.Lblporcentajeembcom.Text = "N"
        '
        'Lblporcentajesurtidascom
        '
        Me.Lblporcentajesurtidascom.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Lblporcentajesurtidascom.Appearance.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblporcentajesurtidascom.Appearance.Options.UseFont = True
        Me.Lblporcentajesurtidascom.Location = New System.Drawing.Point(293, 266)
        Me.Lblporcentajesurtidascom.Name = "Lblporcentajesurtidascom"
        Me.Lblporcentajesurtidascom.Size = New System.Drawing.Size(12, 19)
        Me.Lblporcentajesurtidascom.TabIndex = 531
        Me.Lblporcentajesurtidascom.Text = "N"
        '
        'LabelControl2
        '
        Me.LabelControl2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(39, 278)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(248, 18)
        Me.LabelControl2.TabIndex = 530
        Me.LabelControl2.Text = "Órdenes incompletas embarcadas :"
        '
        'LabelControl1
        '
        Me.LabelControl1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(39, 257)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(240, 18)
        Me.LabelControl1.TabIndex = 527
        Me.LabelControl1.Text = "Órdenes completas  embarcadas :"
        '
        'SimpleButton5
        '
        Me.SimpleButton5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton5.Appearance.BackColor = System.Drawing.Color.LightSeaGreen
        Me.SimpleButton5.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton5.Appearance.Options.UseBackColor = True
        Me.SimpleButton5.Appearance.Options.UseFont = True
        Me.SimpleButton5.Location = New System.Drawing.Point(11, 255)
        Me.SimpleButton5.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.SimpleButton5.Name = "SimpleButton5"
        Me.SimpleButton5.Size = New System.Drawing.Size(23, 21)
        Me.SimpleButton5.TabIndex = 529
        '
        'SimpleButton6
        '
        Me.SimpleButton6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton6.Appearance.BackColor = System.Drawing.Color.Red
        Me.SimpleButton6.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton6.Appearance.Options.UseBackColor = True
        Me.SimpleButton6.Appearance.Options.UseFont = True
        Me.SimpleButton6.Location = New System.Drawing.Point(11, 278)
        Me.SimpleButton6.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.SimpleButton6.Name = "SimpleButton6"
        Me.SimpleButton6.Size = New System.Drawing.Size(23, 21)
        Me.SimpleButton6.TabIndex = 528
        '
        'ChartControl1
        '
        Me.ChartControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChartControl1.Location = New System.Drawing.Point(525, 50)
        Me.ChartControl1.Margin = New System.Windows.Forms.Padding(2)
        Me.ChartControl1.Name = "ChartControl1"
        Me.ChartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series(-1) {}
        Me.ChartControl1.Size = New System.Drawing.Size(512, 259)
        Me.ChartControl1.TabIndex = 533
        '
        'FrmDetalleRequerimientoClienteEmb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1040, 648)
        Me.Controls.Add(Me.ChartControl1)
        Me.Controls.Add(Me.Lblporcentajeembcom)
        Me.Controls.Add(Me.Lblporcentajesurtidascom)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.SimpleButton5)
        Me.Controls.Add(Me.SimpleButton6)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.SimpleButton9)
        Me.Controls.Add(Me.dtpFechaInicio)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.dtpFechaFin)
        Me.Controls.Add(Me.LabelPrincipal)
        Me.Controls.Add(Me.SimpleButton8)
        Me.Controls.Add(Me.SeparatorControl3)
        Me.Controls.Add(Me.ChartControl3)
        Me.IconOptions.Image = Global.AXCVDE.My.Resources.Resources.Logo_X_150x150_01
        Me.Name = "FrmDetalleRequerimientoClienteEmb"
        Me.Text = "Órdenes que cumplieron con el requeriminto del cliente"
        CType(Me.dtpFechaInicio.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaInicio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaFin.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaFin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeparatorControl3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.DgvDetalleOrdenesCP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartControl3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SimpleButton9 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dtpFechaInicio As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents BtnBuscar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dtpFechaFin As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelPrincipal As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton8 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SeparatorControl3 As DevExpress.XtraEditors.SeparatorControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents DgvDetalleOrdenesCP As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ChartControl3 As DevExpress.XtraCharts.ChartControl
    Friend WithEvents Lblporcentajeembcom As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Lblporcentajesurtidascom As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton5 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton6 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ChartControl1 As DevExpress.XtraCharts.ChartControl
End Class
