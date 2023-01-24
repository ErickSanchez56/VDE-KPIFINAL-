<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmEstatusDiarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEstatusDiarios))
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.TabPane1 = New DevExpress.XtraBars.Navigation.TabPane()
        Me.OrdenEmbarque = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.dgvOrdenes = New DevExpress.XtraGrid.GridControl()
        Me.dgvViewEncabezado = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.dgvViewDetalle = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Estacion = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        Me.GroupControl4 = New DevExpress.XtraEditors.GroupControl()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.btnActualizar = New DevExpress.XtraEditors.SimpleButton()
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
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.TabPane1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPane1.SuspendLayout()
        Me.OrdenEmbarque.SuspendLayout()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.dgvOrdenes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvViewEncabezado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvViewDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Estacion.SuspendLayout()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl4.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.dtpFechaInicio.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaInicio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl2
        '
        Me.GroupControl2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl2.AppearanceCaption.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold)
        Me.GroupControl2.AppearanceCaption.Options.UseFont = True
        Me.GroupControl2.Controls.Add(Me.TabPane1)
        Me.GroupControl2.Controls.Add(Me.GroupControl1)
        Me.GroupControl2.CustomHeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText
        Me.GroupControl2.Location = New System.Drawing.Point(6, 4)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(1026, 571)
        Me.GroupControl2.TabIndex = 50
        Me.GroupControl2.Text = "Remisiones"
        '
        'TabPane1
        '
        Me.TabPane1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabPane1.Controls.Add(Me.OrdenEmbarque)
        Me.TabPane1.Controls.Add(Me.Estacion)
        Me.TabPane1.Location = New System.Drawing.Point(10, 238)
        Me.TabPane1.Name = "TabPane1"
        Me.TabPane1.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.Estacion, Me.OrdenEmbarque})
        Me.TabPane1.RegularSize = New System.Drawing.Size(1011, 328)
        Me.TabPane1.SelectedPage = Me.OrdenEmbarque
        Me.TabPane1.Size = New System.Drawing.Size(1011, 328)
        Me.TabPane1.TabIndex = 96
        Me.TabPane1.Text = "Orden Embarque"
        '
        'OrdenEmbarque
        '
        Me.OrdenEmbarque.Caption = "Orden Embarque"
        Me.OrdenEmbarque.Controls.Add(Me.GroupControl3)
        Me.OrdenEmbarque.Name = "OrdenEmbarque"
        Me.OrdenEmbarque.Size = New System.Drawing.Size(1011, 301)
        '
        'GroupControl3
        '
        Me.GroupControl3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl3.AppearanceCaption.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold)
        Me.GroupControl3.AppearanceCaption.Options.UseFont = True
        Me.GroupControl3.Controls.Add(Me.dgvOrdenes)
        Me.GroupControl3.CustomHeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText
        Me.GroupControl3.Location = New System.Drawing.Point(3, 14)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(1000, 273)
        Me.GroupControl3.TabIndex = 91
        Me.GroupControl3.Text = "Embarque"
        '
        'dgvOrdenes
        '
        Me.dgvOrdenes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvOrdenes.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.dgvOrdenes.Location = New System.Drawing.Point(5, 30)
        Me.dgvOrdenes.MainView = Me.dgvViewEncabezado
        Me.dgvOrdenes.Name = "dgvOrdenes"
        Me.dgvOrdenes.Size = New System.Drawing.Size(990, 231)
        Me.dgvOrdenes.TabIndex = 97
        Me.dgvOrdenes.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.dgvViewEncabezado, Me.dgvViewDetalle})
        '
        'dgvViewEncabezado
        '
        Me.dgvViewEncabezado.Appearance.GroupRow.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold)
        Me.dgvViewEncabezado.Appearance.GroupRow.Options.UseFont = True
        Me.dgvViewEncabezado.Appearance.HeaderPanel.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold)
        Me.dgvViewEncabezado.Appearance.HeaderPanel.Options.UseFont = True
        Me.dgvViewEncabezado.Appearance.Row.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.dgvViewEncabezado.Appearance.Row.Options.UseFont = True
        Me.dgvViewEncabezado.AppearancePrint.EvenRow.Font = New System.Drawing.Font("Tahoma", 15.0!)
        Me.dgvViewEncabezado.AppearancePrint.EvenRow.Options.UseFont = True
        Me.dgvViewEncabezado.AppearancePrint.GroupFooter.Font = New System.Drawing.Font("Tahoma", 15.0!)
        Me.dgvViewEncabezado.AppearancePrint.GroupFooter.Options.UseFont = True
        Me.dgvViewEncabezado.AppearancePrint.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 15.0!)
        Me.dgvViewEncabezado.AppearancePrint.HeaderPanel.Options.UseFont = True
        Me.dgvViewEncabezado.AppearancePrint.Row.Font = New System.Drawing.Font("Tahoma", 15.0!)
        Me.dgvViewEncabezado.AppearancePrint.Row.Options.UseFont = True
        Me.dgvViewEncabezado.GridControl = Me.dgvOrdenes
        Me.dgvViewEncabezado.Name = "dgvViewEncabezado"
        Me.dgvViewEncabezado.OptionsBehavior.AutoSelectAllInEditor = False
        Me.dgvViewEncabezado.OptionsBehavior.ReadOnly = True
        Me.dgvViewEncabezado.OptionsDetail.ShowDetailTabs = False
        Me.dgvViewEncabezado.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.dgvViewEncabezado.OptionsSelection.EnableAppearanceFocusedRow = False
        Me.dgvViewEncabezado.OptionsSelection.EnableAppearanceHideSelection = False
        Me.dgvViewEncabezado.OptionsSelection.EnableAppearanceHotTrackedRow = DevExpress.Utils.DefaultBoolean.[False]
        Me.dgvViewEncabezado.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = DevExpress.Utils.DefaultBoolean.[False]
        Me.dgvViewEncabezado.OptionsSelection.ShowCheckBoxSelectorInGroupRow = DevExpress.Utils.DefaultBoolean.[False]
        Me.dgvViewEncabezado.OptionsSelection.ShowCheckBoxSelectorInPrintExport = DevExpress.Utils.DefaultBoolean.[False]
        Me.dgvViewEncabezado.OptionsSelection.UseIndicatorForSelection = False
        Me.dgvViewEncabezado.OptionsView.ColumnAutoWidth = False
        Me.dgvViewEncabezado.OptionsView.ShowGroupPanel = False
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
        'Estacion
        '
        Me.Estacion.Caption = "Estacion"
        Me.Estacion.Controls.Add(Me.GroupControl4)
        Me.Estacion.Name = "Estacion"
        Me.Estacion.Size = New System.Drawing.Size(1011, 301)
        '
        'GroupControl4
        '
        Me.GroupControl4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl4.AppearanceCaption.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold)
        Me.GroupControl4.AppearanceCaption.Options.UseFont = True
        Me.GroupControl4.Controls.Add(Me.GridControl1)
        Me.GroupControl4.CustomHeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText
        Me.GroupControl4.Location = New System.Drawing.Point(5, 14)
        Me.GroupControl4.Name = "GroupControl4"
        Me.GroupControl4.Size = New System.Drawing.Size(1000, 273)
        Me.GroupControl4.TabIndex = 99
        Me.GroupControl4.Text = "Estacion"
        '
        'GridControl1
        '
        Me.GridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.GridControl1.Location = New System.Drawing.Point(5, 30)
        Me.GridControl1.MainView = Me.GridView2
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(990, 254)
        Me.GridControl1.TabIndex = 99
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2, Me.GridView1})
        '
        'GridView2
        '
        Me.GridView2.Appearance.GroupPanel.Options.UseTextOptions = True
        Me.GridView2.Appearance.GroupPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridView2.Appearance.GroupRow.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold)
        Me.GridView2.Appearance.GroupRow.Options.UseFont = True
        Me.GridView2.Appearance.HeaderPanel.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold)
        Me.GridView2.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridView2.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GridView2.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridView2.Appearance.Row.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.GridView2.Appearance.Row.Options.UseFont = True
        Me.GridView2.Appearance.Row.Options.UseTextOptions = True
        Me.GridView2.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridView2.Appearance.SelectedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridView2.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.GridView2.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridView2.AppearancePrint.FilterPanel.Font = New System.Drawing.Font("Tahoma", 20.0!)
        Me.GridView2.AppearancePrint.FilterPanel.Options.UseFont = True
        Me.GridView2.AppearancePrint.FilterPanel.Options.UseTextOptions = True
        Me.GridView2.AppearancePrint.FilterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridView2.AppearancePrint.FooterPanel.Options.UseTextOptions = True
        Me.GridView2.AppearancePrint.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridView2.AppearancePrint.GroupFooter.Font = New System.Drawing.Font("Tahoma", 15.0!)
        Me.GridView2.AppearancePrint.GroupFooter.Options.UseFont = True
        Me.GridView2.AppearancePrint.GroupFooter.Options.UseTextOptions = True
        Me.GridView2.AppearancePrint.GroupFooter.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridView2.AppearancePrint.GroupRow.Options.UseTextOptions = True
        Me.GridView2.AppearancePrint.GroupRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridView2.AppearancePrint.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 15.0!)
        Me.GridView2.AppearancePrint.HeaderPanel.Options.UseFont = True
        Me.GridView2.AppearancePrint.Lines.Font = New System.Drawing.Font("Tahoma", 15.0!)
        Me.GridView2.AppearancePrint.Lines.Options.UseFont = True
        Me.GridView2.AppearancePrint.Lines.Options.UseTextOptions = True
        Me.GridView2.AppearancePrint.Lines.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridView2.AppearancePrint.Preview.Options.UseTextOptions = True
        Me.GridView2.AppearancePrint.Preview.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridView2.AppearancePrint.Row.Font = New System.Drawing.Font("Tahoma", 15.0!)
        Me.GridView2.AppearancePrint.Row.Options.UseFont = True
        Me.GridView2.AppearancePrint.Row.Options.UseTextOptions = True
        Me.GridView2.AppearancePrint.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridView2.GridControl = Me.GridControl1
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsBehavior.ReadOnly = True
        Me.GridView2.OptionsDetail.ShowDetailTabs = False
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedRow = False
        Me.GridView2.OptionsSelection.EnableAppearanceHideSelection = False
        Me.GridView2.OptionsSelection.EnableAppearanceHotTrackedRow = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView2.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView2.OptionsSelection.ShowCheckBoxSelectorInGroupRow = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView2.OptionsSelection.ShowCheckBoxSelectorInPrintExport = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView2.OptionsSelection.UseIndicatorForSelection = False
        Me.GridView2.OptionsView.ColumnAutoWidth = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
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
        'GroupControl1
        '
        Me.GroupControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold)
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.Controls.Add(Me.btnActualizar)
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
        Me.GroupControl1.Location = New System.Drawing.Point(5, 33)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(1016, 199)
        Me.GroupControl1.TabIndex = 51
        Me.GroupControl1.Text = "Fecha"
        '
        'btnActualizar
        '
        Me.btnActualizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnActualizar.ImageOptions.Image = CType(resources.GetObject("btnActualizar.ImageOptions.Image"), System.Drawing.Image)
        Me.btnActualizar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnActualizar.Location = New System.Drawing.Point(975, 26)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(28, 30)
        Me.btnActualizar.TabIndex = 113
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
        Me.dtpFechaInicio.Properties.EditFormat.FormatString = ""
        Me.dtpFechaInicio.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
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
        Me.BtnLista.Enabled = False
        Me.BtnLista.Location = New System.Drawing.Point(859, 145)
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
        Me.BtnValidada.Enabled = False
        Me.BtnValidada.Location = New System.Drawing.Point(691, 145)
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
        Me.BtnSurtida.Enabled = False
        Me.BtnSurtida.Location = New System.Drawing.Point(519, 145)
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
        Me.BtnLiberado.Enabled = False
        Me.BtnLiberado.Location = New System.Drawing.Point(178, 145)
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
        Me.BtnSurtiendo.Enabled = False
        Me.BtnSurtiendo.Location = New System.Drawing.Point(347, 145)
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
        Me.BtnTotalN.Enabled = False
        Me.BtnTotalN.Location = New System.Drawing.Point(7, 145)
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
        Me.SimpleButton5.Enabled = False
        Me.SimpleButton5.Location = New System.Drawing.Point(859, 64)
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
        Me.SimpleButton4.Enabled = False
        Me.SimpleButton4.Location = New System.Drawing.Point(691, 64)
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
        Me.SimpleButton3.Enabled = False
        Me.SimpleButton3.Location = New System.Drawing.Point(519, 64)
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
        Me.SimpleButton2.Enabled = False
        Me.SimpleButton2.Location = New System.Drawing.Point(178, 64)
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
        Me.SimpleButton1.Enabled = False
        Me.SimpleButton1.Location = New System.Drawing.Point(347, 64)
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
        Me.btnTotal.Enabled = False
        Me.btnTotal.Location = New System.Drawing.Point(7, 64)
        Me.btnTotal.Name = "btnTotal"
        Me.btnTotal.Size = New System.Drawing.Size(149, 66)
        Me.btnTotal.TabIndex = 78
        Me.btnTotal.Text = "TOTAL"
        '
        'FrmEstatusDiarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1044, 587)
        Me.Controls.Add(Me.GroupControl2)
        Me.IconOptions.Image = Global.AXCVDE.My.Resources.Resources.Logo_X_150x150_01
        Me.Name = "FrmEstatusDiarios"
        Me.Text = "Estado Diario"
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.TabPane1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPane1.ResumeLayout(False)
        Me.OrdenEmbarque.ResumeLayout(False)
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        CType(Me.dgvOrdenes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvViewEncabezado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvViewDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Estacion.ResumeLayout(False)
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl4.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.dtpFechaInicio.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaInicio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents TabPane1 As DevExpress.XtraBars.Navigation.TabPane
    Friend WithEvents OrdenEmbarque As DevExpress.XtraBars.Navigation.TabNavigationPage
    Friend WithEvents Estacion As DevExpress.XtraBars.Navigation.TabNavigationPage
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents dgvOrdenes As DevExpress.XtraGrid.GridControl
    Friend WithEvents dgvViewEncabezado As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents dgvViewDetalle As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GroupControl4 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnActualizar As DevExpress.XtraEditors.SimpleButton
End Class
