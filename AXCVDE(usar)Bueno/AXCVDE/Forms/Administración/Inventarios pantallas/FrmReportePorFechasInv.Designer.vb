<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReportePorFechasInv
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
        Me.btnReporte = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.dtpFechaInicio = New DevExpress.XtraEditors.DateEdit()
        Me.dtpFechaFin = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.dtpFechaInicio.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaInicio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaFin.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaFin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnReporte
        '
        Me.btnReporte.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnReporte.Appearance.Options.UseFont = True
        Me.btnReporte.Appearance.Options.UseTextOptions = True
        Me.btnReporte.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnReporte.Location = New System.Drawing.Point(306, 63)
        Me.btnReporte.Name = "btnReporte"
        Me.btnReporte.Size = New System.Drawing.Size(124, 44)
        Me.btnReporte.TabIndex = 5
        Me.btnReporte.Text = "Generar reporte"
        '
        'GroupControl1
        '
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.dtpFechaInicio)
        Me.GroupControl1.Controls.Add(Me.dtpFechaFin)
        Me.GroupControl1.Controls.Add(Me.LabelControl5)
        Me.GroupControl1.Controls.Add(Me.btnReporte)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 12)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(460, 135)
        Me.GroupControl1.TabIndex = 4
        Me.GroupControl1.Text = "Filtro"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Appearance.Options.UseTextOptions = True
        Me.LabelControl3.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.LabelControl3.Location = New System.Drawing.Point(27, 84)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(42, 19)
        Me.LabelControl3.TabIndex = 105
        Me.LabelControl3.Text = "Hasta:"
        '
        'dtpFechaInicio
        '
        Me.dtpFechaInicio.EditValue = Nothing
        Me.dtpFechaInicio.Location = New System.Drawing.Point(75, 47)
        Me.dtpFechaInicio.Name = "dtpFechaInicio"
        Me.dtpFechaInicio.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.dtpFechaInicio.Properties.Appearance.Options.UseFont = True
        Me.dtpFechaInicio.Properties.AppearanceCalendar.Button.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.dtpFechaInicio.Properties.AppearanceCalendar.Button.Options.UseFont = True
        Me.dtpFechaInicio.Properties.AppearanceCalendar.ButtonHighlighted.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.dtpFechaInicio.Properties.AppearanceCalendar.ButtonHighlighted.Options.UseFont = True
        Me.dtpFechaInicio.Properties.AppearanceCalendar.ButtonPressed.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.dtpFechaInicio.Properties.AppearanceCalendar.ButtonPressed.Options.UseFont = True
        Me.dtpFechaInicio.Properties.AppearanceCalendar.CalendarHeader.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaInicio.Properties.AppearanceCalendar.CalendarHeader.Options.UseFont = True
        Me.dtpFechaInicio.Properties.AppearanceCalendar.DayCell.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.dtpFechaInicio.Properties.AppearanceCalendar.DayCell.Options.UseFont = True
        Me.dtpFechaInicio.Properties.AppearanceCalendar.DayCellDisabled.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.dtpFechaInicio.Properties.AppearanceCalendar.DayCellDisabled.Options.UseFont = True
        Me.dtpFechaInicio.Properties.AppearanceCalendar.DayCellHighlighted.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.dtpFechaInicio.Properties.AppearanceCalendar.DayCellHighlighted.Options.UseFont = True
        Me.dtpFechaInicio.Properties.AppearanceCalendar.DayCellHoliday.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.dtpFechaInicio.Properties.AppearanceCalendar.DayCellHoliday.Options.UseFont = True
        Me.dtpFechaInicio.Properties.AppearanceCalendar.DayCellInactive.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.dtpFechaInicio.Properties.AppearanceCalendar.DayCellInactive.Options.UseFont = True
        Me.dtpFechaInicio.Properties.AppearanceCalendar.DayCellPressed.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.dtpFechaInicio.Properties.AppearanceCalendar.DayCellPressed.Options.UseFont = True
        Me.dtpFechaInicio.Properties.AppearanceCalendar.DayCellSelected.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.dtpFechaInicio.Properties.AppearanceCalendar.DayCellSelected.Options.UseFont = True
        Me.dtpFechaInicio.Properties.AppearanceCalendar.DayCellSpecial.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.dtpFechaInicio.Properties.AppearanceCalendar.DayCellSpecial.Options.UseFont = True
        Me.dtpFechaInicio.Properties.AppearanceCalendar.DayCellSpecialHighlighted.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.dtpFechaInicio.Properties.AppearanceCalendar.DayCellSpecialHighlighted.Options.UseFont = True
        Me.dtpFechaInicio.Properties.AppearanceCalendar.DayCellSpecialPressed.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.dtpFechaInicio.Properties.AppearanceCalendar.DayCellSpecialPressed.Options.UseFont = True
        Me.dtpFechaInicio.Properties.AppearanceCalendar.DayCellSpecialSelected.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.dtpFechaInicio.Properties.AppearanceCalendar.DayCellSpecialSelected.Options.UseFont = True
        Me.dtpFechaInicio.Properties.AppearanceCalendar.DayCellToday.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.dtpFechaInicio.Properties.AppearanceCalendar.DayCellToday.Options.UseFont = True
        Me.dtpFechaInicio.Properties.AppearanceCalendar.Header.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaInicio.Properties.AppearanceCalendar.Header.Options.UseFont = True
        Me.dtpFechaInicio.Properties.AppearanceCalendar.HeaderHighlighted.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaInicio.Properties.AppearanceCalendar.HeaderHighlighted.Options.UseFont = True
        Me.dtpFechaInicio.Properties.AppearanceCalendar.HeaderPressed.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaInicio.Properties.AppearanceCalendar.HeaderPressed.Options.UseFont = True
        Me.dtpFechaInicio.Properties.AppearanceCalendar.WeekDay.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.dtpFechaInicio.Properties.AppearanceCalendar.WeekDay.Options.UseFont = True
        Me.dtpFechaInicio.Properties.AppearanceCalendar.WeekNumber.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.dtpFechaInicio.Properties.AppearanceCalendar.WeekNumber.Options.UseFont = True
        Me.dtpFechaInicio.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.dtpFechaInicio.Properties.AppearanceDisabled.Options.UseFont = True
        Me.dtpFechaInicio.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpFechaInicio.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpFechaInicio.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Fluent
        Me.dtpFechaInicio.Properties.MaskSettings.Set("mask", "yyyyMMdd")
        Me.dtpFechaInicio.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.[False]
        Me.dtpFechaInicio.Size = New System.Drawing.Size(196, 26)
        Me.dtpFechaInicio.TabIndex = 102
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.EditValue = Nothing
        Me.dtpFechaFin.Location = New System.Drawing.Point(75, 81)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.dtpFechaFin.Properties.Appearance.Options.UseFont = True
        Me.dtpFechaFin.Properties.AppearanceCalendar.Button.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.dtpFechaFin.Properties.AppearanceCalendar.Button.Options.UseFont = True
        Me.dtpFechaFin.Properties.AppearanceCalendar.ButtonHighlighted.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.dtpFechaFin.Properties.AppearanceCalendar.ButtonHighlighted.Options.UseFont = True
        Me.dtpFechaFin.Properties.AppearanceCalendar.ButtonPressed.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.dtpFechaFin.Properties.AppearanceCalendar.ButtonPressed.Options.UseFont = True
        Me.dtpFechaFin.Properties.AppearanceCalendar.CalendarHeader.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaFin.Properties.AppearanceCalendar.CalendarHeader.Options.UseFont = True
        Me.dtpFechaFin.Properties.AppearanceCalendar.DayCell.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.dtpFechaFin.Properties.AppearanceCalendar.DayCell.Options.UseFont = True
        Me.dtpFechaFin.Properties.AppearanceCalendar.DayCellDisabled.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.dtpFechaFin.Properties.AppearanceCalendar.DayCellDisabled.Options.UseFont = True
        Me.dtpFechaFin.Properties.AppearanceCalendar.DayCellHighlighted.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.dtpFechaFin.Properties.AppearanceCalendar.DayCellHighlighted.Options.UseFont = True
        Me.dtpFechaFin.Properties.AppearanceCalendar.DayCellHoliday.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.dtpFechaFin.Properties.AppearanceCalendar.DayCellHoliday.Options.UseFont = True
        Me.dtpFechaFin.Properties.AppearanceCalendar.DayCellInactive.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.dtpFechaFin.Properties.AppearanceCalendar.DayCellInactive.Options.UseFont = True
        Me.dtpFechaFin.Properties.AppearanceCalendar.DayCellPressed.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.dtpFechaFin.Properties.AppearanceCalendar.DayCellPressed.Options.UseFont = True
        Me.dtpFechaFin.Properties.AppearanceCalendar.DayCellSelected.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.dtpFechaFin.Properties.AppearanceCalendar.DayCellSelected.Options.UseFont = True
        Me.dtpFechaFin.Properties.AppearanceCalendar.DayCellSpecial.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.dtpFechaFin.Properties.AppearanceCalendar.DayCellSpecial.Options.UseFont = True
        Me.dtpFechaFin.Properties.AppearanceCalendar.DayCellSpecialHighlighted.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.dtpFechaFin.Properties.AppearanceCalendar.DayCellSpecialHighlighted.Options.UseFont = True
        Me.dtpFechaFin.Properties.AppearanceCalendar.DayCellSpecialPressed.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.dtpFechaFin.Properties.AppearanceCalendar.DayCellSpecialPressed.Options.UseFont = True
        Me.dtpFechaFin.Properties.AppearanceCalendar.DayCellSpecialSelected.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.dtpFechaFin.Properties.AppearanceCalendar.DayCellSpecialSelected.Options.UseFont = True
        Me.dtpFechaFin.Properties.AppearanceCalendar.DayCellToday.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.dtpFechaFin.Properties.AppearanceCalendar.DayCellToday.Options.UseFont = True
        Me.dtpFechaFin.Properties.AppearanceCalendar.Header.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaFin.Properties.AppearanceCalendar.Header.Options.UseFont = True
        Me.dtpFechaFin.Properties.AppearanceCalendar.HeaderHighlighted.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaFin.Properties.AppearanceCalendar.HeaderHighlighted.Options.UseFont = True
        Me.dtpFechaFin.Properties.AppearanceCalendar.HeaderPressed.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaFin.Properties.AppearanceCalendar.HeaderPressed.Options.UseFont = True
        Me.dtpFechaFin.Properties.AppearanceCalendar.WeekDay.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.dtpFechaFin.Properties.AppearanceCalendar.WeekDay.Options.UseFont = True
        Me.dtpFechaFin.Properties.AppearanceCalendar.WeekNumber.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.dtpFechaFin.Properties.AppearanceCalendar.WeekNumber.Options.UseFont = True
        Me.dtpFechaFin.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.dtpFechaFin.Properties.AppearanceDisabled.Options.UseFont = True
        Me.dtpFechaFin.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpFechaFin.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpFechaFin.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Fluent
        Me.dtpFechaFin.Properties.MaskSettings.Set("mask", "yyyyMMdd")
        Me.dtpFechaFin.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.[False]
        Me.dtpFechaFin.Size = New System.Drawing.Size(196, 26)
        Me.dtpFechaFin.TabIndex = 103
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Appearance.Options.UseTextOptions = True
        Me.LabelControl5.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.LabelControl5.Location = New System.Drawing.Point(24, 50)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(45, 19)
        Me.LabelControl5.TabIndex = 104
        Me.LabelControl5.Text = "Desde:"
        '
        'FrmReportePorFechasInv
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(480, 165)
        Me.Controls.Add(Me.GroupControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.IconOptions.Image = Global.AXCVDE.My.Resources.Resources.Logo_X_150x150_01
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmReportePorFechasInv"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte de inventarios por fechas"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.dtpFechaInicio.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaInicio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaFin.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaFin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnReporte As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dtpFechaInicio As DevExpress.XtraEditors.DateEdit
    Friend WithEvents dtpFechaFin As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
End Class
