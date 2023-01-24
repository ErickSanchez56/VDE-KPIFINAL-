<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLiberacionOrdenProduccion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLiberacionOrdenProduccion))
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.CmbTipoLib = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.TxtBusqueda = New DevExpress.XtraEditors.TextEdit()
        Me.BtnActualizar = New DevExpress.XtraEditors.SimpleButton()
        Me.ChkEstacion = New DevExpress.XtraEditors.CheckEdit()
        Me.BtnBuscar = New DevExpress.XtraEditors.SimpleButton()
        Me.CmbEstacion = New DevExpress.XtraEditors.LookUpEdit()
        Me.BtnLiberar = New DevExpress.XtraEditors.SimpleButton()
        Me.DgvResultado = New DevExpress.XtraGrid.GridControl()
        Me.DgvViewResultado = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CmbEstacionGrid = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.CmbLoteGrid = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.RepositoryItemGridLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridEstacion = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.CmbTipoLib.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtBusqueda.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChkEstacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CmbEstacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvResultado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvViewResultado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CmbEstacionGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CmbLoteGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridEstacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.Controls.Add(Me.LabelControl5)
        Me.GroupControl1.Controls.Add(Me.CmbTipoLib)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.TxtBusqueda)
        Me.GroupControl1.Controls.Add(Me.BtnActualizar)
        Me.GroupControl1.Controls.Add(Me.ChkEstacion)
        Me.GroupControl1.Controls.Add(Me.BtnBuscar)
        Me.GroupControl1.Controls.Add(Me.CmbEstacion)
        Me.GroupControl1.Location = New System.Drawing.Point(11, 13)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(960, 129)
        Me.GroupControl1.TabIndex = 180
        Me.GroupControl1.Text = "Seleccionar orden de producción"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Location = New System.Drawing.Point(315, 76)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(130, 19)
        Me.LabelControl5.TabIndex = 173
        Me.LabelControl5.Text = "Tipo de Liberación:"
        '
        'CmbTipoLib
        '
        Me.CmbTipoLib.Location = New System.Drawing.Point(451, 73)
        Me.CmbTipoLib.Name = "CmbTipoLib"
        Me.CmbTipoLib.Properties.AcceptEditorTextAsNewValue = DevExpress.Utils.DefaultBoolean.[False]
        Me.CmbTipoLib.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.CmbTipoLib.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbTipoLib.Properties.Appearance.ForeColor = System.Drawing.Color.Transparent
        Me.CmbTipoLib.Properties.Appearance.Options.UseBackColor = True
        Me.CmbTipoLib.Properties.Appearance.Options.UseFont = True
        Me.CmbTipoLib.Properties.Appearance.Options.UseForeColor = True
        Me.CmbTipoLib.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbTipoLib.Properties.AppearanceDropDown.Options.UseFont = True
        Me.CmbTipoLib.Properties.AppearanceDropDownHeader.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbTipoLib.Properties.AppearanceDropDownHeader.Options.UseFont = True
        Me.CmbTipoLib.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CmbTipoLib.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("TipoLiberacion", "Tipo Liberacion")})
        Me.CmbTipoLib.Properties.NullText = ""
        Me.CmbTipoLib.Properties.PopupSizeable = False
        Me.CmbTipoLib.Size = New System.Drawing.Size(160, 26)
        Me.CmbTipoLib.TabIndex = 172
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(7, 76)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(61, 19)
        Me.LabelControl3.TabIndex = 171
        Me.LabelControl3.Text = "Estación:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(7, 39)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(129, 19)
        Me.LabelControl1.TabIndex = 89
        Me.LabelControl1.Text = "Orden Producción:"
        '
        'TxtBusqueda
        '
        Me.TxtBusqueda.Location = New System.Drawing.Point(139, 36)
        Me.TxtBusqueda.Name = "TxtBusqueda"
        Me.TxtBusqueda.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBusqueda.Properties.Appearance.Options.UseFont = True
        Me.TxtBusqueda.Size = New System.Drawing.Size(204, 26)
        Me.TxtBusqueda.TabIndex = 90
        '
        'BtnActualizar
        '
        Me.BtnActualizar.ImageOptions.Image = CType(resources.GetObject("BtnActualizar.ImageOptions.Image"), System.Drawing.Image)
        Me.BtnActualizar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.BtnActualizar.Location = New System.Drawing.Point(389, 32)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(34, 35)
        Me.BtnActualizar.TabIndex = 91
        '
        'ChkEstacion
        '
        Me.ChkEstacion.EditValue = True
        Me.ChkEstacion.Location = New System.Drawing.Point(7, 74)
        Me.ChkEstacion.Name = "ChkEstacion"
        Me.ChkEstacion.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkEstacion.Properties.Appearance.Options.UseFont = True
        Me.ChkEstacion.Properties.Caption = "Cargar todo a:"
        Me.ChkEstacion.Size = New System.Drawing.Size(104, 23)
        Me.ChkEstacion.TabIndex = 168
        Me.ChkEstacion.Visible = False
        '
        'BtnBuscar
        '
        Me.BtnBuscar.ImageOptions.Image = CType(resources.GetObject("BtnBuscar.ImageOptions.Image"), System.Drawing.Image)
        Me.BtnBuscar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.BtnBuscar.Location = New System.Drawing.Point(349, 32)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(34, 35)
        Me.BtnBuscar.TabIndex = 92
        '
        'CmbEstacion
        '
        Me.CmbEstacion.Location = New System.Drawing.Point(139, 73)
        Me.CmbEstacion.Name = "CmbEstacion"
        Me.CmbEstacion.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbEstacion.Properties.Appearance.Options.UseFont = True
        Me.CmbEstacion.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbEstacion.Properties.AppearanceDropDown.Options.UseFont = True
        Me.CmbEstacion.Properties.AppearanceDropDownHeader.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbEstacion.Properties.AppearanceDropDownHeader.Options.UseFont = True
        Me.CmbEstacion.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CmbEstacion.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Estacion", "Estacion", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Estacion", "Estación")})
        Me.CmbEstacion.Properties.NullText = ""
        Me.CmbEstacion.Properties.PopupSizeable = False
        Me.CmbEstacion.Size = New System.Drawing.Size(160, 26)
        Me.CmbEstacion.TabIndex = 169
        '
        'BtnLiberar
        '
        Me.BtnLiberar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnLiberar.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLiberar.Appearance.Options.UseFont = True
        Me.BtnLiberar.Appearance.Options.UseTextOptions = True
        Me.BtnLiberar.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.BtnLiberar.Location = New System.Drawing.Point(863, 531)
        Me.BtnLiberar.Name = "BtnLiberar"
        Me.BtnLiberar.Size = New System.Drawing.Size(108, 45)
        Me.BtnLiberar.TabIndex = 178
        Me.BtnLiberar.Text = "Liberar"
        '
        'DgvResultado
        '
        Me.DgvResultado.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvResultado.Location = New System.Drawing.Point(12, 149)
        Me.DgvResultado.MainView = Me.DgvViewResultado
        Me.DgvResultado.Name = "DgvResultado"
        Me.DgvResultado.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.CmbEstacionGrid, Me.CmbLoteGrid, Me.RepositoryItemGridLookUpEdit1, Me.GridEstacion, Me.RepositoryItemLookUpEdit1, Me.RepositoryItemTextEdit1})
        Me.DgvResultado.Size = New System.Drawing.Size(960, 359)
        Me.DgvResultado.TabIndex = 177
        Me.DgvResultado.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.DgvViewResultado})
        '
        'DgvViewResultado
        '
        Me.DgvViewResultado.Appearance.GroupRow.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.DgvViewResultado.Appearance.GroupRow.Options.UseFont = True
        Me.DgvViewResultado.Appearance.HeaderPanel.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.DgvViewResultado.Appearance.HeaderPanel.Options.UseFont = True
        Me.DgvViewResultado.Appearance.Row.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.DgvViewResultado.Appearance.Row.Options.UseFont = True
        Me.DgvViewResultado.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn9, Me.GridColumn3, Me.GridColumn4, Me.GridColumn10, Me.GridColumn5, Me.GridColumn12, Me.GridColumn6, Me.GridColumn7, Me.GridColumn11, Me.GridColumn8})
        Me.DgvViewResultado.GridControl = Me.DgvResultado
        Me.DgvViewResultado.Name = "DgvViewResultado"
        Me.DgvViewResultado.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Partida"
        Me.GridColumn1.FieldName = "Partida"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowEdit = False
        Me.GridColumn1.OptionsColumn.ReadOnly = True
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Artículo"
        Me.GridColumn2.FieldName = "NumParte"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.AllowEdit = False
        Me.GridColumn2.OptionsColumn.ReadOnly = True
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "Descripción"
        Me.GridColumn9.FieldName = "Descripcion"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.OptionsColumn.AllowEdit = False
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 2
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Cantidad pedida"
        Me.GridColumn3.FieldName = "CantidadPedida"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.AllowEdit = False
        Me.GridColumn3.OptionsColumn.ReadOnly = True
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 3
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Cantidad surtida"
        Me.GridColumn4.FieldName = "CantidadSurtida"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.OptionsColumn.AllowEdit = False
        Me.GridColumn4.OptionsColumn.ReadOnly = True
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 5
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "Cantidad A Surtir"
        Me.GridColumn10.FieldName = "CantidadASurtir"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 4
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Cantidad pendiente"
        Me.GridColumn5.FieldName = "CantidadPendiente"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.OptionsColumn.AllowEdit = False
        Me.GridColumn5.OptionsColumn.ReadOnly = True
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 6
        '
        'GridColumn12
        '
        Me.GridColumn12.Caption = "UM"
        Me.GridColumn12.FieldName = "UnidadMedida"
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.Visible = True
        Me.GridColumn12.VisibleIndex = 10
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Estatus"
        Me.GridColumn6.FieldName = "DStatus"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.OptionsColumn.AllowEdit = False
        Me.GridColumn6.OptionsColumn.ReadOnly = True
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 7
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Estación"
        Me.GridColumn7.FieldName = "Estacion"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.OptionsColumn.AllowEdit = False
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 9
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "Estacion Asignada"
        Me.GridColumn11.FieldName = "EstacionAsignada"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 8
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Lote"
        Me.GridColumn8.FieldName = "Lote"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.OptionsColumn.AllowEdit = False
        '
        'CmbEstacionGrid
        '
        Me.CmbEstacionGrid.AutoHeight = False
        Me.CmbEstacionGrid.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.CmbEstacionGrid.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CmbEstacionGrid.Name = "CmbEstacionGrid"
        '
        'CmbLoteGrid
        '
        Me.CmbLoteGrid.AutoHeight = False
        Me.CmbLoteGrid.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CmbLoteGrid.Name = "CmbLoteGrid"
        '
        'RepositoryItemGridLookUpEdit1
        '
        Me.RepositoryItemGridLookUpEdit1.AutoHeight = False
        Me.RepositoryItemGridLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit1.Name = "RepositoryItemGridLookUpEdit1"
        Me.RepositoryItemGridLookUpEdit1.PopupView = Me.GridView1
        '
        'GridView1
        '
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'GridEstacion
        '
        Me.GridEstacion.AutoHeight = False
        Me.GridEstacion.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GridEstacion.Name = "GridEstacion"
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'FrmLiberacionOrdenProduccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(983, 594)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.BtnLiberar)
        Me.Controls.Add(Me.DgvResultado)
        Me.IconOptions.Image = Global.AXCVDE.My.Resources.Resources.Logo_X_150x150_01
        Me.Name = "FrmLiberacionOrdenProduccion"
        Me.Text = "Liberacion de órdenes de  producción"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.CmbTipoLib.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtBusqueda.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChkEstacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CmbEstacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvResultado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvViewResultado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CmbEstacionGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CmbLoteGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridEstacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents CmbTipoLib As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtBusqueda As DevExpress.XtraEditors.TextEdit
    Friend WithEvents BtnActualizar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ChkEstacion As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents BtnBuscar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents CmbEstacion As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents BtnLiberar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DgvResultado As DevExpress.XtraGrid.GridControl
    Friend WithEvents DgvViewResultado As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CmbEstacionGrid As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents CmbLoteGrid As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents RepositoryItemGridLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridEstacion As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
End Class
