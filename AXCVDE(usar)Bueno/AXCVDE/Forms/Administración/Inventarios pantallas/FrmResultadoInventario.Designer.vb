<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmResultadoInventario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmResultadoInventario))
        Me.BtnActualizarPrevio = New DevExpress.XtraEditors.SimpleButton()
        Me.Button1 = New DevExpress.XtraEditors.SimpleButton()
        Me.btnReporte = New DevExpress.XtraEditors.SimpleButton()
        Me.dgvResultados = New DevExpress.XtraGrid.GridControl()
        Me.GridViewTotal = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.Chkpro = New DevExpress.XtraEditors.CheckEdit()
        Me.ChkPos = New DevExpress.XtraEditors.CheckEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.cmbAlmacen = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.cbIds = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.cbTipoInventario = New DevExpress.XtraEditors.LookUpEdit()
        CType(Me.dgvResultados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.Chkpro.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChkPos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbAlmacen.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbIds.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbTipoInventario.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnActualizarPrevio
        '
        Me.BtnActualizarPrevio.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnActualizarPrevio.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnActualizarPrevio.Appearance.Options.UseFont = True
        Me.BtnActualizarPrevio.Appearance.Options.UseTextOptions = True
        Me.BtnActualizarPrevio.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.BtnActualizarPrevio.Location = New System.Drawing.Point(813, 421)
        Me.BtnActualizarPrevio.Name = "BtnActualizarPrevio"
        Me.BtnActualizarPrevio.Size = New System.Drawing.Size(122, 49)
        Me.BtnActualizarPrevio.TabIndex = 10
        Me.BtnActualizarPrevio.Text = "Actualizar previo"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Appearance.Options.UseFont = True
        Me.Button1.Appearance.Options.UseTextOptions = True
        Me.Button1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.Button1.Location = New System.Drawing.Point(678, 421)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(122, 49)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Generar reporte por fechas"
        '
        'btnReporte
        '
        Me.btnReporte.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnReporte.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReporte.Appearance.Options.UseFont = True
        Me.btnReporte.Appearance.Options.UseTextOptions = True
        Me.btnReporte.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnReporte.Location = New System.Drawing.Point(543, 421)
        Me.btnReporte.Name = "btnReporte"
        Me.btnReporte.Size = New System.Drawing.Size(122, 49)
        Me.btnReporte.TabIndex = 8
        Me.btnReporte.Text = "Generar reporte"
        '
        'dgvResultados
        '
        Me.dgvResultados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvResultados.Location = New System.Drawing.Point(12, 141)
        Me.dgvResultados.MainView = Me.GridViewTotal
        Me.dgvResultados.Name = "dgvResultados"
        Me.dgvResultados.Size = New System.Drawing.Size(923, 271)
        Me.dgvResultados.TabIndex = 7
        Me.dgvResultados.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewTotal})
        '
        'GridViewTotal
        '
        Me.GridViewTotal.Appearance.EvenRow.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.GridViewTotal.Appearance.EvenRow.Options.UseFont = True
        Me.GridViewTotal.Appearance.FixedLine.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridViewTotal.Appearance.FixedLine.Options.UseFont = True
        Me.GridViewTotal.Appearance.FocusedRow.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.GridViewTotal.Appearance.FocusedRow.Options.UseFont = True
        Me.GridViewTotal.Appearance.FooterPanel.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.GridViewTotal.Appearance.FooterPanel.Options.UseFont = True
        Me.GridViewTotal.Appearance.GroupFooter.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.GridViewTotal.Appearance.GroupFooter.Options.UseFont = True
        Me.GridViewTotal.Appearance.HeaderPanel.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridViewTotal.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridViewTotal.Appearance.HideSelectionRow.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.GridViewTotal.Appearance.HideSelectionRow.Options.UseFont = True
        Me.GridViewTotal.Appearance.OddRow.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.GridViewTotal.Appearance.OddRow.Options.UseFont = True
        Me.GridViewTotal.Appearance.Preview.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.GridViewTotal.Appearance.Preview.Options.UseFont = True
        Me.GridViewTotal.Appearance.Row.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.GridViewTotal.Appearance.Row.Options.UseFont = True
        Me.GridViewTotal.Appearance.RowSeparator.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.GridViewTotal.Appearance.RowSeparator.Options.UseFont = True
        Me.GridViewTotal.Appearance.SelectedRow.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.GridViewTotal.Appearance.SelectedRow.Options.UseFont = True
        Me.GridViewTotal.Appearance.TopNewRow.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.GridViewTotal.Appearance.TopNewRow.Options.UseFont = True
        Me.GridViewTotal.GridControl = Me.dgvResultados
        Me.GridViewTotal.Name = "GridViewTotal"
        Me.GridViewTotal.OptionsBehavior.Editable = False
        Me.GridViewTotal.OptionsView.ColumnAutoWidth = False
        Me.GridViewTotal.OptionsView.ShowGroupPanel = False
        '
        'GroupControl1
        '
        Me.GroupControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.Controls.Add(Me.Chkpro)
        Me.GroupControl1.Controls.Add(Me.ChkPos)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.cmbAlmacen)
        Me.GroupControl1.Controls.Add(Me.LabelControl5)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.cbIds)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.cbTipoInventario)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 12)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(923, 111)
        Me.GroupControl1.TabIndex = 6
        Me.GroupControl1.Text = "Seleccionar ejercicio"
        '
        'Chkpro
        '
        Me.Chkpro.Location = New System.Drawing.Point(703, 74)
        Me.Chkpro.Name = "Chkpro"
        Me.Chkpro.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chkpro.Properties.Appearance.Options.UseFont = True
        Me.Chkpro.Properties.Caption = "Producto"
        Me.Chkpro.Size = New System.Drawing.Size(85, 22)
        Me.Chkpro.TabIndex = 152
        '
        'ChkPos
        '
        Me.ChkPos.EditValue = True
        Me.ChkPos.Location = New System.Drawing.Point(568, 74)
        Me.ChkPos.Name = "ChkPos"
        Me.ChkPos.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkPos.Properties.Appearance.Options.UseFont = True
        Me.ChkPos.Properties.Caption = "Posición"
        Me.ChkPos.Size = New System.Drawing.Size(85, 22)
        Me.ChkPos.TabIndex = 151
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(417, 75)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(88, 19)
        Me.LabelControl3.TabIndex = 150
        Me.LabelControl3.Text = "Agrupar por:"
        '
        'cmbAlmacen
        '
        Me.cmbAlmacen.Location = New System.Drawing.Point(148, 37)
        Me.cmbAlmacen.Name = "cmbAlmacen"
        Me.cmbAlmacen.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.cmbAlmacen.Properties.Appearance.Options.UseFont = True
        Me.cmbAlmacen.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbAlmacen.Properties.NullText = ""
        Me.cmbAlmacen.Properties.PopupSizeable = False
        Me.cmbAlmacen.Properties.PopupView = Me.GridView3
        Me.cmbAlmacen.Size = New System.Drawing.Size(251, 26)
        Me.cmbAlmacen.TabIndex = 146
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
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn2})
        Me.GridView3.DetailHeight = 303
        Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Almacén"
        Me.GridColumn2.FieldName = "ERPAlmacen"
        Me.GridColumn2.MinWidth = 17
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 0
        Me.GridColumn2.Width = 64
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Location = New System.Drawing.Point(79, 40)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(63, 19)
        Me.LabelControl5.TabIndex = 147
        Me.LabelControl5.Text = "Almacén:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(417, 40)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(75, 19)
        Me.LabelControl1.TabIndex = 7
        Me.LabelControl1.Text = "Inventario:"
        '
        'cbIds
        '
        Me.cbIds.Location = New System.Drawing.Point(498, 37)
        Me.cbIds.Name = "cbIds"
        Me.cbIds.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.cbIds.Properties.Appearance.Options.UseFont = True
        Me.cbIds.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.cbIds.Properties.AppearanceDropDown.Options.UseFont = True
        Me.cbIds.Properties.AppearanceDropDownHeader.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbIds.Properties.AppearanceDropDownHeader.Options.UseFont = True
        Me.cbIds.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbIds.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("FechaHora", "Fecha")})
        Me.cbIds.Properties.NullText = ""
        Me.cbIds.Properties.PopupSizeable = False
        Me.cbIds.Properties.PopupWidthMode = DevExpress.XtraEditors.PopupWidthMode.ContentWidth
        Me.cbIds.Size = New System.Drawing.Size(415, 26)
        Me.cbIds.TabIndex = 8
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(12, 75)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(130, 19)
        Me.LabelControl2.TabIndex = 5
        Me.LabelControl2.Text = "Tipo de inventario:"
        '
        'cbTipoInventario
        '
        Me.cbTipoInventario.Location = New System.Drawing.Point(148, 72)
        Me.cbTipoInventario.Name = "cbTipoInventario"
        Me.cbTipoInventario.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.cbTipoInventario.Properties.Appearance.Options.UseFont = True
        Me.cbTipoInventario.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.cbTipoInventario.Properties.AppearanceDropDown.Options.UseFont = True
        Me.cbTipoInventario.Properties.AppearanceDropDownHeader.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTipoInventario.Properties.AppearanceDropDownHeader.Options.UseFont = True
        Me.cbTipoInventario.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbTipoInventario.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Tipo", "Tipo")})
        Me.cbTipoInventario.Properties.DropDownRows = 3
        Me.cbTipoInventario.Properties.NullText = ""
        Me.cbTipoInventario.Properties.PopupSizeable = False
        Me.cbTipoInventario.Properties.PopupWidthMode = DevExpress.XtraEditors.PopupWidthMode.ContentWidth
        Me.cbTipoInventario.Size = New System.Drawing.Size(251, 26)
        Me.cbTipoInventario.TabIndex = 6
        '
        'FrmResultadoInventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(947, 479)
        Me.Controls.Add(Me.BtnActualizarPrevio)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnReporte)
        Me.Controls.Add(Me.dgvResultados)
        Me.Controls.Add(Me.GroupControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.IconOptions.Icon = CType(resources.GetObject("FrmResultadoInventario.IconOptions.Icon"), System.Drawing.Icon)
        Me.IconOptions.Image = Global.AXCVDE.My.Resources.Resources.Logo_X_150x150_01
        Me.LookAndFeel.TouchUIMode = DevExpress.Utils.DefaultBoolean.[False]
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmResultadoInventario"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Resultado de inventarios"
        CType(Me.dgvResultados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.Chkpro.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChkPos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbAlmacen.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbIds.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbTipoInventario.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnActualizarPrevio As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Button1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnReporte As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dgvResultados As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewTotal As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbIds As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbTipoInventario As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cmbAlmacen As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Chkpro As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ChkPos As DevExpress.XtraEditors.CheckEdit
End Class
