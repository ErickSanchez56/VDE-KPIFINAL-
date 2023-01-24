<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class XtraForm2
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
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.dtpFechaInicio = New DevExpress.XtraEditors.DateEdit()
        Me.BtnLista = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnValidada = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnSurtida = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnLiberado = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnSurtiendo = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnTotalN = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton5 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.btnTotal = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.dgvOrdenes = New DevExpress.XtraGrid.GridControl()
        Me.dgvViewDetalle = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.dgvViewEncabezado = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GroupControl4 = New DevExpress.XtraEditors.GroupControl()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.dtpFechaInicio.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaInicio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.dgvOrdenes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvViewDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvViewEncabezado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl4.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl2
        '
        Me.GroupControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl2.AppearanceCaption.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold)
        Me.GroupControl2.AppearanceCaption.Options.UseFont = True
        Me.GroupControl2.Controls.Add(Me.GroupControl4)
        Me.GroupControl2.Controls.Add(Me.GroupControl3)
        Me.GroupControl2.Controls.Add(Me.GroupControl1)
        Me.GroupControl2.CustomHeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText
        Me.GroupControl2.Location = New System.Drawing.Point(12, 12)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(1020, 563)
        Me.GroupControl2.TabIndex = 49
        Me.GroupControl2.Text = "Remisiones"
        '
        'GroupControl1
        '
        Me.GroupControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold)
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.Controls.Add(Me.dtpFechaInicio)
        Me.GroupControl1.Controls.Add(Me.BtnLista)
        Me.GroupControl1.Controls.Add(Me.BtnValidada)
        Me.GroupControl1.Controls.Add(Me.BtnSurtida)
        Me.GroupControl1.Controls.Add(Me.BtnLiberado)
        Me.GroupControl1.Controls.Add(Me.BtnSurtiendo)
        Me.GroupControl1.Controls.Add(Me.BtnTotalN)
        Me.GroupControl1.Controls.Add(Me.SimpleButton5)
        Me.GroupControl1.Controls.Add(Me.SimpleButton4)
        Me.GroupControl1.Controls.Add(Me.SimpleButton3)
        Me.GroupControl1.Controls.Add(Me.SimpleButton2)
        Me.GroupControl1.Controls.Add(Me.SimpleButton1)
        Me.GroupControl1.Controls.Add(Me.btnTotal)
        Me.GroupControl1.CustomHeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText
        Me.GroupControl1.Location = New System.Drawing.Point(5, 30)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(1010, 196)
        Me.GroupControl1.TabIndex = 50
        Me.GroupControl1.Text = "Fecha"
        '
        'dtpFechaInicio
        '
        Me.dtpFechaInicio.EditValue = New Date(2022, 8, 5, 13, 44, 53, 0)
        Me.dtpFechaInicio.Location = New System.Drawing.Point(5, 30)
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
        Me.dtpFechaInicio.Size = New System.Drawing.Size(149, 26)
        Me.dtpFechaInicio.TabIndex = 90
        '
        'BtnLista
        '
        Me.BtnLista.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnLista.Appearance.Font = New System.Drawing.Font("Arial", 15.0!)
        Me.BtnLista.Appearance.Options.UseFont = True
        Me.BtnLista.AppearancePressed.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.BtnLista.AppearancePressed.Options.UseFont = True
        Me.BtnLista.Location = New System.Drawing.Point(856, 143)
        Me.BtnLista.Name = "BtnLista"
        Me.BtnLista.Size = New System.Drawing.Size(149, 29)
        Me.BtnLista.TabIndex = 89
        '
        'BtnValidada
        '
        Me.BtnValidada.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnValidada.Appearance.Font = New System.Drawing.Font("Arial", 15.0!)
        Me.BtnValidada.Appearance.Options.UseFont = True
        Me.BtnValidada.AppearancePressed.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.BtnValidada.AppearancePressed.Options.UseFont = True
        Me.BtnValidada.Location = New System.Drawing.Point(688, 143)
        Me.BtnValidada.Name = "BtnValidada"
        Me.BtnValidada.Size = New System.Drawing.Size(149, 29)
        Me.BtnValidada.TabIndex = 88
        '
        'BtnSurtida
        '
        Me.BtnSurtida.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnSurtida.Appearance.Font = New System.Drawing.Font("Arial", 15.0!)
        Me.BtnSurtida.Appearance.Options.UseFont = True
        Me.BtnSurtida.AppearancePressed.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.BtnSurtida.AppearancePressed.Options.UseFont = True
        Me.BtnSurtida.Location = New System.Drawing.Point(516, 143)
        Me.BtnSurtida.Name = "BtnSurtida"
        Me.BtnSurtida.Size = New System.Drawing.Size(149, 29)
        Me.BtnSurtida.TabIndex = 87
        '
        'BtnLiberado
        '
        Me.BtnLiberado.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnLiberado.Appearance.Font = New System.Drawing.Font("Arial", 15.0!)
        Me.BtnLiberado.Appearance.Options.UseFont = True
        Me.BtnLiberado.AppearancePressed.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.BtnLiberado.AppearancePressed.Options.UseFont = True
        Me.BtnLiberado.Location = New System.Drawing.Point(175, 143)
        Me.BtnLiberado.Name = "BtnLiberado"
        Me.BtnLiberado.Size = New System.Drawing.Size(149, 29)
        Me.BtnLiberado.TabIndex = 86
        '
        'BtnSurtiendo
        '
        Me.BtnSurtiendo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnSurtiendo.Appearance.Font = New System.Drawing.Font("Arial", 15.0!)
        Me.BtnSurtiendo.Appearance.Options.UseFont = True
        Me.BtnSurtiendo.AppearancePressed.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.BtnSurtiendo.AppearancePressed.Options.UseFont = True
        Me.BtnSurtiendo.Location = New System.Drawing.Point(344, 143)
        Me.BtnSurtiendo.Name = "BtnSurtiendo"
        Me.BtnSurtiendo.Size = New System.Drawing.Size(149, 29)
        Me.BtnSurtiendo.TabIndex = 85
        '
        'BtnTotalN
        '
        Me.BtnTotalN.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnTotalN.Appearance.Font = New System.Drawing.Font("Arial", 15.0!)
        Me.BtnTotalN.Appearance.Options.UseFont = True
        Me.BtnTotalN.AppearancePressed.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.BtnTotalN.AppearancePressed.Options.UseFont = True
        Me.BtnTotalN.Location = New System.Drawing.Point(4, 143)
        Me.BtnTotalN.Name = "BtnTotalN"
        Me.BtnTotalN.Size = New System.Drawing.Size(149, 29)
        Me.BtnTotalN.TabIndex = 84
        '
        'SimpleButton5
        '
        Me.SimpleButton5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.SimpleButton5.Appearance.Font = New System.Drawing.Font("Arial", 15.0!)
        Me.SimpleButton5.Appearance.Options.UseFont = True
        Me.SimpleButton5.AppearancePressed.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.SimpleButton5.AppearancePressed.Options.UseFont = True
        Me.SimpleButton5.Location = New System.Drawing.Point(856, 62)
        Me.SimpleButton5.Name = "SimpleButton5"
        Me.SimpleButton5.Size = New System.Drawing.Size(149, 66)
        Me.SimpleButton5.TabIndex = 83
        Me.SimpleButton5.Text = "LISTA"
        '
        'SimpleButton4
        '
        Me.SimpleButton4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.SimpleButton4.Appearance.Font = New System.Drawing.Font("Arial", 15.0!)
        Me.SimpleButton4.Appearance.Options.UseFont = True
        Me.SimpleButton4.AppearancePressed.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.SimpleButton4.AppearancePressed.Options.UseFont = True
        Me.SimpleButton4.Location = New System.Drawing.Point(688, 62)
        Me.SimpleButton4.Name = "SimpleButton4"
        Me.SimpleButton4.Size = New System.Drawing.Size(149, 66)
        Me.SimpleButton4.TabIndex = 82
        Me.SimpleButton4.Text = "VALIDADA"
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.SimpleButton3.Appearance.Font = New System.Drawing.Font("Arial", 15.0!)
        Me.SimpleButton3.Appearance.Options.UseFont = True
        Me.SimpleButton3.AppearancePressed.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.SimpleButton3.AppearancePressed.Options.UseFont = True
        Me.SimpleButton3.Location = New System.Drawing.Point(516, 62)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(149, 66)
        Me.SimpleButton3.TabIndex = 81
        Me.SimpleButton3.Text = "SURTIDA"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.SimpleButton2.Appearance.Font = New System.Drawing.Font("Arial", 15.0!)
        Me.SimpleButton2.Appearance.Options.UseFont = True
        Me.SimpleButton2.AppearancePressed.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.SimpleButton2.AppearancePressed.Options.UseFont = True
        Me.SimpleButton2.Location = New System.Drawing.Point(175, 62)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(149, 66)
        Me.SimpleButton2.TabIndex = 80
        Me.SimpleButton2.Text = "LIBERADA"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Arial", 15.0!)
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.AppearancePressed.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.SimpleButton1.AppearancePressed.Options.UseFont = True
        Me.SimpleButton1.Location = New System.Drawing.Point(344, 62)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(149, 66)
        Me.SimpleButton1.TabIndex = 79
        Me.SimpleButton1.Text = "SURTIENDO"
        '
        'btnTotal
        '
        Me.btnTotal.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnTotal.Appearance.Font = New System.Drawing.Font("Arial", 15.0!)
        Me.btnTotal.Appearance.Options.UseFont = True
        Me.btnTotal.AppearancePressed.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnTotal.AppearancePressed.Options.UseFont = True
        Me.btnTotal.Location = New System.Drawing.Point(4, 62)
        Me.btnTotal.Name = "btnTotal"
        Me.btnTotal.Size = New System.Drawing.Size(149, 66)
        Me.btnTotal.TabIndex = 78
        Me.btnTotal.Text = "TOTAL"
        '
        'GroupControl3
        '
        Me.GroupControl3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl3.AppearanceCaption.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold)
        Me.GroupControl3.AppearanceCaption.Options.UseFont = True
        Me.GroupControl3.Controls.Add(Me.dgvOrdenes)
        Me.GroupControl3.CustomHeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText
        Me.GroupControl3.Location = New System.Drawing.Point(5, 232)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(665, 326)
        Me.GroupControl3.TabIndex = 91
        Me.GroupControl3.Text = "Ordenes Embarque"
        '
        'dgvOrdenes
        '
        Me.dgvOrdenes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        GridLevelNode2.LevelTemplate = Me.dgvViewDetalle
        GridLevelNode2.RelationName = "DetalleOrdenes"
        Me.dgvOrdenes.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode2})
        Me.dgvOrdenes.Location = New System.Drawing.Point(5, 37)
        Me.dgvOrdenes.MainView = Me.dgvViewEncabezado
        Me.dgvOrdenes.Name = "dgvOrdenes"
        Me.dgvOrdenes.Size = New System.Drawing.Size(645, 284)
        Me.dgvOrdenes.TabIndex = 1
        Me.dgvOrdenes.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.dgvViewDetalle, Me.dgvViewEncabezado})
        '
        'dgvViewDetalle
        '
        Me.dgvViewDetalle.Appearance.GroupRow.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvViewDetalle.Appearance.GroupRow.Options.UseFont = True
        Me.dgvViewDetalle.Appearance.HeaderPanel.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvViewDetalle.Appearance.HeaderPanel.Options.UseFont = True
        Me.dgvViewDetalle.Appearance.Row.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvViewDetalle.Appearance.Row.Options.UseFont = True
        Me.dgvViewDetalle.GridControl = Me.dgvOrdenes
        Me.dgvViewDetalle.Name = "dgvViewDetalle"
        Me.dgvViewDetalle.OptionsBehavior.Editable = False
        Me.dgvViewDetalle.OptionsBehavior.ReadOnly = True
        Me.dgvViewDetalle.OptionsView.ColumnAutoWidth = False
        Me.dgvViewDetalle.OptionsView.ShowGroupPanel = False
        '
        'dgvViewEncabezado
        '
        Me.dgvViewEncabezado.Appearance.GroupRow.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold)
        Me.dgvViewEncabezado.Appearance.GroupRow.Options.UseFont = True
        Me.dgvViewEncabezado.Appearance.HeaderPanel.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold)
        Me.dgvViewEncabezado.Appearance.HeaderPanel.Options.UseFont = True
        Me.dgvViewEncabezado.Appearance.Row.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.dgvViewEncabezado.Appearance.Row.Options.UseFont = True
        Me.dgvViewEncabezado.GridControl = Me.dgvOrdenes
        Me.dgvViewEncabezado.Name = "dgvViewEncabezado"
        Me.dgvViewEncabezado.OptionsBehavior.ReadOnly = True
        Me.dgvViewEncabezado.OptionsDetail.ShowDetailTabs = False
        Me.dgvViewEncabezado.OptionsView.ColumnAutoWidth = False
        Me.dgvViewEncabezado.OptionsView.ShowGroupPanel = False
        '
        'GroupControl4
        '
        Me.GroupControl4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl4.AppearanceCaption.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold)
        Me.GroupControl4.AppearanceCaption.Options.UseFont = True
        Me.GroupControl4.Controls.Add(Me.GridControl1)
        Me.GroupControl4.CustomHeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText
        Me.GroupControl4.Location = New System.Drawing.Point(693, 232)
        Me.GroupControl4.Name = "GroupControl4"
        Me.GroupControl4.Size = New System.Drawing.Size(327, 326)
        Me.GroupControl4.TabIndex = 92
        Me.GroupControl4.Text = "Estaciones"
        '
        'GridControl1
        '
        Me.GridControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        GridLevelNode1.LevelTemplate = Me.GridView1
        GridLevelNode1.RelationName = "DetalleOrdenes"
        Me.GridControl1.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.GridControl1.Location = New System.Drawing.Point(5, 30)
        Me.GridControl1.MainView = Me.GridView2
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(317, 291)
        Me.GridControl1.TabIndex = 2
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1, Me.GridView2})
        '
        'GridView1
        '
        Me.GridView1.Appearance.GroupRow.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView1.Appearance.GroupRow.Options.UseFont = True
        Me.GridView1.Appearance.HeaderPanel.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView1.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridView1.Appearance.Row.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView1.Appearance.Row.Options.UseFont = True
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsBehavior.ReadOnly = True
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'GridView2
        '
        Me.GridView2.Appearance.GroupRow.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold)
        Me.GridView2.Appearance.GroupRow.Options.UseFont = True
        Me.GridView2.Appearance.HeaderPanel.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold)
        Me.GridView2.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridView2.Appearance.Row.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.GridView2.Appearance.Row.Options.UseFont = True
        Me.GridView2.GridControl = Me.GridControl1
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsBehavior.ReadOnly = True
        Me.GridView2.OptionsDetail.ShowDetailTabs = False
        Me.GridView2.OptionsView.ColumnAutoWidth = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'XtraForm2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1044, 587)
        Me.Controls.Add(Me.GroupControl2)
        Me.Name = "XtraForm2"
        Me.Text = "XtraForm2"
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.dtpFechaInicio.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaInicio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        CType(Me.dgvOrdenes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvViewDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvViewEncabezado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl4.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents dtpFechaInicio As DevExpress.XtraEditors.DateEdit
    Friend WithEvents BtnLista As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnValidada As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnSurtida As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnLiberado As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnSurtiendo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnTotalN As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton5 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton4 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnTotal As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl4 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents dgvOrdenes As DevExpress.XtraGrid.GridControl
    Friend WithEvents dgvViewDetalle As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents dgvViewEncabezado As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
End Class
