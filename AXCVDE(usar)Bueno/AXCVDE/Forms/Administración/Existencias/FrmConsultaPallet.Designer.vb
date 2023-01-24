<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConsultaPallet
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmConsultaPallet))
        Dim ButtonImageOptions1 As DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions = New DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions()
        Me.TxtBusqueda = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.DgvResultado = New DevExpress.XtraGrid.GridControl()
        Me.DgvViewResultado = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.dtpFechaFin = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.dtpFechaInicio = New DevExpress.XtraEditors.DateEdit()
        Me.BtnBuscar = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.CmbEstatus = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.cmbTipo = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.ChkFechas = New DevExpress.XtraEditors.CheckEdit()
        Me.BtnReporte = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        CType(Me.TxtBusqueda.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvResultado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvViewResultado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaFin.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaFin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaInicio.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaInicio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.CmbEstatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbTipo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChkFechas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TxtBusqueda
        '
        Me.TxtBusqueda.Location = New System.Drawing.Point(82, 69)
        Me.TxtBusqueda.Name = "TxtBusqueda"
        Me.TxtBusqueda.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBusqueda.Properties.Appearance.Options.UseFont = True
        Me.TxtBusqueda.Size = New System.Drawing.Size(251, 26)
        Me.TxtBusqueda.TabIndex = 2
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(5, 72)
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
        Me.DgvResultado.Location = New System.Drawing.Point(5, 40)
        Me.DgvResultado.MainView = Me.DgvViewResultado
        Me.DgvResultado.Name = "DgvResultado"
        Me.DgvResultado.Size = New System.Drawing.Size(1046, 466)
        Me.DgvResultado.TabIndex = 97
        Me.DgvResultado.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.DgvViewResultado})
        '
        'DgvViewResultado
        '
        Me.DgvViewResultado.Appearance.GroupRow.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvViewResultado.Appearance.GroupRow.Options.UseFont = True
        Me.DgvViewResultado.Appearance.HeaderPanel.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvViewResultado.Appearance.HeaderPanel.Options.UseFont = True
        Me.DgvViewResultado.Appearance.Row.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvViewResultado.Appearance.Row.Options.UseFont = True
        Me.DgvViewResultado.GridControl = Me.DgvResultado
        Me.DgvViewResultado.Name = "DgvViewResultado"
        Me.DgvViewResultado.OptionsBehavior.ReadOnly = True
        Me.DgvViewResultado.OptionsView.ColumnAutoWidth = False
        Me.DgvViewResultado.OptionsView.ShowGroupPanel = False
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Appearance.Options.UseTextOptions = True
        Me.LabelControl3.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.LabelControl3.Location = New System.Drawing.Point(488, 72)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(42, 19)
        Me.LabelControl3.TabIndex = 101
        Me.LabelControl3.Text = "Hasta:"
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.EditValue = Nothing
        Me.dtpFechaFin.Enabled = False
        Me.dtpFechaFin.Location = New System.Drawing.Point(536, 69)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaFin.Properties.Appearance.Options.UseFont = True
        Me.dtpFechaFin.Properties.AppearanceCalendar.Header.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaFin.Properties.AppearanceCalendar.Header.Options.UseFont = True
        Me.dtpFechaFin.Properties.AppearanceCalendar.HeaderPressed.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaFin.Properties.AppearanceCalendar.HeaderPressed.Options.UseFont = True
        Me.dtpFechaFin.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaFin.Properties.AppearanceDropDown.Options.UseFont = True
        Me.dtpFechaFin.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpFechaFin.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpFechaFin.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Fluent
        Me.dtpFechaFin.Properties.Mask.EditMask = "yyyyMMdd"
        Me.dtpFechaFin.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.[False]
        Me.dtpFechaFin.Size = New System.Drawing.Size(196, 26)
        Me.dtpFechaFin.TabIndex = 6
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Appearance.Options.UseTextOptions = True
        Me.LabelControl5.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.LabelControl5.Location = New System.Drawing.Point(485, 42)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(45, 19)
        Me.LabelControl5.TabIndex = 99
        Me.LabelControl5.Text = "Desde:"
        '
        'dtpFechaInicio
        '
        Me.dtpFechaInicio.EditValue = Nothing
        Me.dtpFechaInicio.Enabled = False
        Me.dtpFechaInicio.Location = New System.Drawing.Point(536, 37)
        Me.dtpFechaInicio.Name = "dtpFechaInicio"
        Me.dtpFechaInicio.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaInicio.Properties.Appearance.Options.UseFont = True
        Me.dtpFechaInicio.Properties.AppearanceCalendar.Header.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaInicio.Properties.AppearanceCalendar.Header.Options.UseFont = True
        Me.dtpFechaInicio.Properties.AppearanceCalendar.HeaderPressed.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaInicio.Properties.AppearanceCalendar.HeaderPressed.Options.UseFont = True
        Me.dtpFechaInicio.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaInicio.Properties.AppearanceDropDown.Options.UseFont = True
        Me.dtpFechaInicio.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpFechaInicio.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpFechaInicio.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Fluent
        Me.dtpFechaInicio.Properties.Mask.EditMask = "yyyyMMdd"
        Me.dtpFechaInicio.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.[False]
        Me.dtpFechaInicio.Size = New System.Drawing.Size(196, 26)
        Me.dtpFechaInicio.TabIndex = 5
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuscar.Appearance.Options.UseFont = True
        Me.BtnBuscar.ImageOptions.Image = CType(resources.GetObject("BtnBuscar.ImageOptions.Image"), System.Drawing.Image)
        Me.BtnBuscar.Location = New System.Drawing.Point(740, 40)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(121, 49)
        Me.BtnBuscar.TabIndex = 7
        Me.BtnBuscar.Text = "Buscar"
        '
        'GroupControl1
        '
        Me.GroupControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl1.Controls.Add(Me.CmbEstatus)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.cmbTipo)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.ChkFechas)
        Me.GroupControl1.Controls.Add(Me.TxtBusqueda)
        Me.GroupControl1.Controls.Add(Me.BtnBuscar)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.dtpFechaInicio)
        Me.GroupControl1.Controls.Add(Me.dtpFechaFin)
        Me.GroupControl1.Controls.Add(Me.LabelControl5)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 12)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(1056, 140)
        Me.GroupControl1.TabIndex = 103
        Me.GroupControl1.Text = "Filtros"
        '
        'CmbEstatus
        '
        Me.CmbEstatus.Location = New System.Drawing.Point(82, 101)
        Me.CmbEstatus.Name = "CmbEstatus"
        Me.CmbEstatus.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbEstatus.Properties.Appearance.Options.UseFont = True
        Me.CmbEstatus.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbEstatus.Properties.AppearanceDropDown.Options.UseFont = True
        Me.CmbEstatus.Properties.AppearanceDropDownHeader.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbEstatus.Properties.AppearanceDropDownHeader.Options.UseFont = True
        Me.CmbEstatus.Properties.AppearanceFocused.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbEstatus.Properties.AppearanceFocused.Options.UseFont = True
        Me.CmbEstatus.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CmbEstatus.Properties.DropDownRows = 3
        Me.CmbEstatus.Properties.NullText = ""
        Me.CmbEstatus.Properties.PopupSizeable = False
        Me.CmbEstatus.Properties.ShowFooter = False
        Me.CmbEstatus.Size = New System.Drawing.Size(251, 26)
        Me.CmbEstatus.TabIndex = 3
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(23, 104)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(53, 19)
        Me.LabelControl4.TabIndex = 174
        Me.LabelControl4.Text = "Estatus:"
        '
        'cmbTipo
        '
        Me.cmbTipo.Location = New System.Drawing.Point(82, 37)
        Me.cmbTipo.Name = "cmbTipo"
        Me.cmbTipo.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTipo.Properties.Appearance.Options.UseFont = True
        Me.cmbTipo.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTipo.Properties.AppearanceDropDown.Options.UseFont = True
        Me.cmbTipo.Properties.AppearanceDropDownHeader.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTipo.Properties.AppearanceDropDownHeader.Options.UseFont = True
        Me.cmbTipo.Properties.AppearanceFocused.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTipo.Properties.AppearanceFocused.Options.UseFont = True
        Me.cmbTipo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbTipo.Properties.DropDownRows = 3
        Me.cmbTipo.Properties.NullText = ""
        Me.cmbTipo.Properties.PopupSizeable = False
        Me.cmbTipo.Properties.ShowFooter = False
        Me.cmbTipo.Size = New System.Drawing.Size(251, 26)
        Me.cmbTipo.TabIndex = 1
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(48, 40)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(28, 19)
        Me.LabelControl2.TabIndex = 172
        Me.LabelControl2.Text = "Por:"
        '
        'ChkFechas
        '
        Me.ChkFechas.Location = New System.Drawing.Point(339, 38)
        Me.ChkFechas.Name = "ChkFechas"
        Me.ChkFechas.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkFechas.Properties.Appearance.Options.UseFont = True
        Me.ChkFechas.Properties.Caption = "Habilitar fechas"
        Me.ChkFechas.Size = New System.Drawing.Size(140, 23)
        Me.ChkFechas.TabIndex = 4
        '
        'BtnReporte
        '
        Me.BtnReporte.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReporte.Appearance.Options.UseFont = True
        Me.BtnReporte.Location = New System.Drawing.Point(757, 357)
        Me.BtnReporte.Name = "BtnReporte"
        Me.BtnReporte.Size = New System.Drawing.Size(118, 38)
        Me.BtnReporte.TabIndex = 104
        Me.BtnReporte.Text = "Generar reporte"
        Me.BtnReporte.Visible = False
        '
        'GroupControl2
        '
        Me.GroupControl2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl2.Controls.Add(Me.DgvResultado)
        Me.GroupControl2.Controls.Add(Me.BtnReporte)
        ButtonImageOptions1.Image = CType(resources.GetObject("ButtonImageOptions1.Image"), System.Drawing.Image)
        Me.GroupControl2.CustomHeaderButtons.AddRange(New DevExpress.XtraEditors.ButtonPanel.IBaseButton() {New DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Button", False, ButtonImageOptions1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "Exportar  a .XLSX", -1, True, Nothing, True, False, True, Nothing, -1)})
        Me.GroupControl2.CustomHeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText
        Me.GroupControl2.Location = New System.Drawing.Point(12, 158)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(1056, 511)
        Me.GroupControl2.TabIndex = 175
        Me.GroupControl2.Text = "Filtros"
        '
        'FrmConsultaPallet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1075, 680)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.IconOptions.Image = Global.AXCVDE.My.Resources.Resources.Logo_X_150x150_01
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmConsultaPallet"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de pallet"
        CType(Me.TxtBusqueda.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvResultado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvViewResultado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaFin.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaFin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaInicio.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaInicio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.CmbEstatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbTipo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChkFechas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TxtBusqueda As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DgvResultado As DevExpress.XtraGrid.GridControl
    Friend WithEvents DgvViewResultado As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dtpFechaFin As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dtpFechaInicio As DevExpress.XtraEditors.DateEdit
    Friend WithEvents BtnBuscar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents BtnReporte As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ChkFechas As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents cmbTipo As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents CmbEstatus As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
End Class
