<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmLiberaOrdenEmbarque
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLiberaOrdenEmbarque))
        Me.BtnBuscar = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnActualizar = New DevExpress.XtraEditors.SimpleButton()
        Me.TxtBusqueda = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.DgvResultado = New DevExpress.XtraGrid.GridControl()
        Me.DgvViewResultado = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn25 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LCarga = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CmbEstacionGrid = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.CmbLoteGrid = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.RepositoryItemGridLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.RepositoryItemGridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridEstacion = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.BtnLiberar = New DevExpress.XtraEditors.SimpleButton()
        Me.ChkEstacion = New DevExpress.XtraEditors.CheckEdit()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.CmbTipoLib = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.CmbEstacion = New DevExpress.XtraEditors.LookUpEdit()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn15 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn16 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn17 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn18 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn19 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn20 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn21 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn22 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn23 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn24 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.RepositoryItemComboBox2 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.RepositoryItemGridLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RepositoryItemLookUpEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.lblEstacion = New DevExpress.XtraEditors.LabelControl()
        Me.CmbEsta = New DevExpress.XtraEditors.LookUpEdit()
        Me.lblEstacion2 = New DevExpress.XtraEditors.LabelControl()
        Me.CmbEst2 = New DevExpress.XtraEditors.LookUpEdit()
        Me.lblTipolib = New DevExpress.XtraEditors.LabelControl()
        Me.CmbT = New DevExpress.XtraEditors.LookUpEdit()
        Me.lblTipolib2 = New DevExpress.XtraEditors.LabelControl()
        Me.CmbT2 = New DevExpress.XtraEditors.LookUpEdit()
        Me.BtnElimina = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnAgregar = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.TxtBusqueda.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvResultado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvViewResultado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CmbEstacionGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CmbLoteGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridEstacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChkEstacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.CmbTipoLib.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CmbEstacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CmbEsta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CmbEst2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CmbT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CmbT2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnBuscar
        '
        Me.BtnBuscar.ImageOptions.Image = CType(resources.GetObject("BtnBuscar.ImageOptions.Image"), System.Drawing.Image)
        Me.BtnBuscar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.BtnBuscar.Location = New System.Drawing.Point(349, 31)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(34, 35)
        Me.BtnBuscar.TabIndex = 92
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
        'TxtBusqueda
        '
        Me.TxtBusqueda.Location = New System.Drawing.Point(139, 36)
        Me.TxtBusqueda.Name = "TxtBusqueda"
        Me.TxtBusqueda.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBusqueda.Properties.Appearance.Options.UseFont = True
        Me.TxtBusqueda.Size = New System.Drawing.Size(204, 26)
        Me.TxtBusqueda.TabIndex = 90
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(49, 39)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(74, 19)
        Me.LabelControl1.TabIndex = 89
        Me.LabelControl1.Text = "Embarque:"
        '
        'DgvResultado
        '
        Me.DgvResultado.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvResultado.Location = New System.Drawing.Point(12, 148)
        Me.DgvResultado.MainView = Me.DgvViewResultado
        Me.DgvResultado.Name = "DgvResultado"
        Me.DgvResultado.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.CmbEstacionGrid, Me.CmbLoteGrid, Me.RepositoryItemGridLookUpEdit1, Me.GridEstacion, Me.RepositoryItemLookUpEdit1, Me.RepositoryItemTextEdit1})
        Me.DgvResultado.Size = New System.Drawing.Size(960, 162)
        Me.DgvResultado.TabIndex = 88
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
        Me.DgvViewResultado.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn9, Me.GridColumn3, Me.GridColumn4, Me.GridColumn10, Me.GridColumn5, Me.GridColumn6, Me.GridColumn25, Me.GridColumn7, Me.GridColumn8, Me.LCarga})
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
        Me.GridColumn10.OptionsColumn.AllowEdit = False
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
        'GridColumn25
        '
        Me.GridColumn25.Caption = "Estacion Asignada"
        Me.GridColumn25.FieldName = "EstacionAsignada"
        Me.GridColumn25.Name = "GridColumn25"
        Me.GridColumn25.Visible = True
        Me.GridColumn25.VisibleIndex = 8
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
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Lote"
        Me.GridColumn8.FieldName = "Lote"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.OptionsColumn.AllowEdit = False
        '
        'LCarga
        '
        Me.LCarga.Caption = "Línea"
        Me.LCarga.FieldName = "LCarga"
        Me.LCarga.Name = "LCarga"
        Me.LCarga.Visible = True
        Me.LCarga.VisibleIndex = 10
        Me.LCarga.Width = 56
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
        Me.RepositoryItemGridLookUpEdit1.PopupView = Me.RepositoryItemGridLookUpEdit1View
        '
        'RepositoryItemGridLookUpEdit1View
        '
        Me.RepositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit1View.Name = "RepositoryItemGridLookUpEdit1View"
        Me.RepositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = False
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
        'BtnLiberar
        '
        Me.BtnLiberar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnLiberar.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLiberar.Appearance.Options.UseFont = True
        Me.BtnLiberar.Appearance.Options.UseTextOptions = True
        Me.BtnLiberar.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.BtnLiberar.Location = New System.Drawing.Point(864, 515)
        Me.BtnLiberar.Name = "BtnLiberar"
        Me.BtnLiberar.Size = New System.Drawing.Size(108, 60)
        Me.BtnLiberar.TabIndex = 167
        Me.BtnLiberar.Text = "Liberar"
        '
        'ChkEstacion
        '
        Me.ChkEstacion.EditValue = True
        Me.ChkEstacion.Location = New System.Drawing.Point(29, 69)
        Me.ChkEstacion.Name = "ChkEstacion"
        Me.ChkEstacion.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkEstacion.Properties.Appearance.Options.UseFont = True
        Me.ChkEstacion.Properties.Caption = "Cargar todo a:"
        Me.ChkEstacion.Size = New System.Drawing.Size(104, 23)
        Me.ChkEstacion.TabIndex = 168
        Me.ChkEstacion.Visible = False
        '
        'GroupControl1
        '
        Me.GroupControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.Controls.Add(Me.CmbTipoLib)
        Me.GroupControl1.Controls.Add(Me.LabelControl5)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.TxtBusqueda)
        Me.GroupControl1.Controls.Add(Me.BtnActualizar)
        Me.GroupControl1.Controls.Add(Me.ChkEstacion)
        Me.GroupControl1.Controls.Add(Me.BtnBuscar)
        Me.GroupControl1.Controls.Add(Me.CmbEstacion)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 12)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(960, 129)
        Me.GroupControl1.TabIndex = 171
        Me.GroupControl1.Text = "Seleccionar embarque"
        '
        'CmbTipoLib
        '
        Me.CmbTipoLib.Location = New System.Drawing.Point(141, 100)
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
        Me.CmbTipoLib.TabIndex = 174
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Location = New System.Drawing.Point(5, 102)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(130, 19)
        Me.LabelControl5.TabIndex = 173
        Me.LabelControl5.Text = "Tipo de Liberacion:"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(72, 71)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(61, 19)
        Me.LabelControl3.TabIndex = 171
        Me.LabelControl3.Text = "Estación:"
        '
        'CmbEstacion
        '
        Me.CmbEstacion.Location = New System.Drawing.Point(139, 68)
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
        'GridControl1
        '
        Me.GridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl1.Location = New System.Drawing.Point(12, 366)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemComboBox1, Me.RepositoryItemComboBox2, Me.RepositoryItemGridLookUpEdit2, Me.RepositoryItemLookUpEdit2, Me.RepositoryItemLookUpEdit3, Me.RepositoryItemTextEdit2})
        Me.GridControl1.Size = New System.Drawing.Size(960, 143)
        Me.GridControl1.TabIndex = 177
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        Me.GridControl1.Visible = False
        '
        'GridView1
        '
        Me.GridView1.Appearance.GroupRow.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GridView1.Appearance.GroupRow.Options.UseFont = True
        Me.GridView1.Appearance.HeaderPanel.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GridView1.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridView1.Appearance.Row.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.GridView1.Appearance.Row.Options.UseFont = True
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn11, Me.GridColumn12, Me.GridColumn13, Me.GridColumn14, Me.GridColumn15, Me.GridColumn16, Me.GridColumn17, Me.GridColumn18, Me.GridColumn19, Me.GridColumn20, Me.GridColumn21, Me.GridColumn22, Me.GridColumn23, Me.GridColumn24})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "Partida"
        Me.GridColumn11.FieldName = "Partida"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.OptionsColumn.AllowEdit = False
        Me.GridColumn11.OptionsColumn.ReadOnly = True
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 0
        '
        'GridColumn12
        '
        Me.GridColumn12.Caption = "Artículo"
        Me.GridColumn12.FieldName = "NumParte"
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.OptionsColumn.AllowEdit = False
        Me.GridColumn12.OptionsColumn.ReadOnly = True
        Me.GridColumn12.Visible = True
        Me.GridColumn12.VisibleIndex = 1
        '
        'GridColumn13
        '
        Me.GridColumn13.Caption = "Descripción"
        Me.GridColumn13.FieldName = "Descripcion"
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.OptionsColumn.AllowEdit = False
        Me.GridColumn13.Visible = True
        Me.GridColumn13.VisibleIndex = 2
        '
        'GridColumn14
        '
        Me.GridColumn14.Caption = "Cantidad pedida"
        Me.GridColumn14.FieldName = "CantidadPedida"
        Me.GridColumn14.Name = "GridColumn14"
        Me.GridColumn14.OptionsColumn.AllowEdit = False
        Me.GridColumn14.OptionsColumn.ReadOnly = True
        Me.GridColumn14.Visible = True
        Me.GridColumn14.VisibleIndex = 3
        '
        'GridColumn15
        '
        Me.GridColumn15.Caption = "Cantidad surtida"
        Me.GridColumn15.FieldName = "CantidadSurtida"
        Me.GridColumn15.Name = "GridColumn15"
        Me.GridColumn15.OptionsColumn.AllowEdit = False
        Me.GridColumn15.OptionsColumn.ReadOnly = True
        Me.GridColumn15.Visible = True
        Me.GridColumn15.VisibleIndex = 5
        '
        'GridColumn16
        '
        Me.GridColumn16.Caption = "Cantidad A Surtir"
        Me.GridColumn16.FieldName = "CantidadASurtir"
        Me.GridColumn16.Name = "GridColumn16"
        Me.GridColumn16.OptionsColumn.AllowEdit = False
        Me.GridColumn16.Visible = True
        Me.GridColumn16.VisibleIndex = 4
        '
        'GridColumn17
        '
        Me.GridColumn17.Caption = "Cantidad pendiente"
        Me.GridColumn17.FieldName = "CantidadPendiente"
        Me.GridColumn17.Name = "GridColumn17"
        Me.GridColumn17.OptionsColumn.AllowEdit = False
        Me.GridColumn17.OptionsColumn.ReadOnly = True
        Me.GridColumn17.Visible = True
        Me.GridColumn17.VisibleIndex = 6
        '
        'GridColumn18
        '
        Me.GridColumn18.Caption = "Estatus"
        Me.GridColumn18.FieldName = "DStatus"
        Me.GridColumn18.Name = "GridColumn18"
        Me.GridColumn18.OptionsColumn.AllowEdit = False
        Me.GridColumn18.OptionsColumn.ReadOnly = True
        Me.GridColumn18.Visible = True
        Me.GridColumn18.VisibleIndex = 7
        '
        'GridColumn19
        '
        Me.GridColumn19.Caption = "Estación"
        Me.GridColumn19.FieldName = "Estacion"
        Me.GridColumn19.Name = "GridColumn19"
        Me.GridColumn19.OptionsColumn.AllowEdit = False
        Me.GridColumn19.Visible = True
        Me.GridColumn19.VisibleIndex = 8
        '
        'GridColumn20
        '
        Me.GridColumn20.Caption = "Lote"
        Me.GridColumn20.FieldName = "Lote"
        Me.GridColumn20.Name = "GridColumn20"
        Me.GridColumn20.OptionsColumn.AllowEdit = False
        '
        'GridColumn21
        '
        Me.GridColumn21.Caption = "TipoSurtido"
        Me.GridColumn21.FieldName = "TipoSurtido"
        Me.GridColumn21.Name = "GridColumn21"
        Me.GridColumn21.Visible = True
        Me.GridColumn21.VisibleIndex = 9
        '
        'GridColumn22
        '
        Me.GridColumn22.Caption = "EstacionPicking"
        Me.GridColumn22.FieldName = "EstacionPicking"
        Me.GridColumn22.Name = "GridColumn22"
        Me.GridColumn22.Visible = True
        Me.GridColumn22.VisibleIndex = 10
        '
        'GridColumn23
        '
        Me.GridColumn23.Caption = "TipoSurtido1"
        Me.GridColumn23.FieldName = "TipoSurtido1"
        Me.GridColumn23.Name = "GridColumn23"
        Me.GridColumn23.Visible = True
        Me.GridColumn23.VisibleIndex = 11
        '
        'GridColumn24
        '
        Me.GridColumn24.Caption = "EstacionPallet"
        Me.GridColumn24.FieldName = "EstacionPallet"
        Me.GridColumn24.Name = "GridColumn24"
        Me.GridColumn24.Visible = True
        Me.GridColumn24.VisibleIndex = 12
        '
        'RepositoryItemComboBox1
        '
        Me.RepositoryItemComboBox1.AutoHeight = False
        Me.RepositoryItemComboBox1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.RepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox1.Name = "RepositoryItemComboBox1"
        '
        'RepositoryItemComboBox2
        '
        Me.RepositoryItemComboBox2.AutoHeight = False
        Me.RepositoryItemComboBox2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox2.Name = "RepositoryItemComboBox2"
        '
        'RepositoryItemGridLookUpEdit2
        '
        Me.RepositoryItemGridLookUpEdit2.AutoHeight = False
        Me.RepositoryItemGridLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit2.Name = "RepositoryItemGridLookUpEdit2"
        Me.RepositoryItemGridLookUpEdit2.PopupView = Me.GridView2
        '
        'GridView2
        '
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'RepositoryItemLookUpEdit2
        '
        Me.RepositoryItemLookUpEdit2.AutoHeight = False
        Me.RepositoryItemLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit2.Name = "RepositoryItemLookUpEdit2"
        '
        'RepositoryItemLookUpEdit3
        '
        Me.RepositoryItemLookUpEdit3.AutoHeight = False
        Me.RepositoryItemLookUpEdit3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit3.Name = "RepositoryItemLookUpEdit3"
        '
        'RepositoryItemTextEdit2
        '
        Me.RepositoryItemTextEdit2.AutoHeight = False
        Me.RepositoryItemTextEdit2.Name = "RepositoryItemTextEdit2"
        '
        'lblEstacion
        '
        Me.lblEstacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblEstacion.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstacion.Appearance.Options.UseFont = True
        Me.lblEstacion.Location = New System.Drawing.Point(361, 522)
        Me.lblEstacion.Name = "lblEstacion"
        Me.lblEstacion.Size = New System.Drawing.Size(61, 19)
        Me.lblEstacion.TabIndex = 180
        Me.lblEstacion.Text = "Estación:"
        Me.lblEstacion.Visible = False
        '
        'CmbEsta
        '
        Me.CmbEsta.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CmbEsta.Location = New System.Drawing.Point(428, 519)
        Me.CmbEsta.Name = "CmbEsta"
        Me.CmbEsta.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbEsta.Properties.Appearance.Options.UseFont = True
        Me.CmbEsta.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbEsta.Properties.AppearanceDropDown.Options.UseFont = True
        Me.CmbEsta.Properties.AppearanceDropDownHeader.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbEsta.Properties.AppearanceDropDownHeader.Options.UseFont = True
        Me.CmbEsta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CmbEsta.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Estacion", "Estacion", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Estacion", "Estación")})
        Me.CmbEsta.Properties.NullText = ""
        Me.CmbEsta.Properties.PopupSizeable = False
        Me.CmbEsta.Size = New System.Drawing.Size(160, 26)
        Me.CmbEsta.TabIndex = 179
        Me.CmbEsta.Visible = False
        '
        'lblEstacion2
        '
        Me.lblEstacion2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblEstacion2.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstacion2.Appearance.Options.UseFont = True
        Me.lblEstacion2.Location = New System.Drawing.Point(361, 568)
        Me.lblEstacion2.Name = "lblEstacion2"
        Me.lblEstacion2.Size = New System.Drawing.Size(61, 19)
        Me.lblEstacion2.TabIndex = 182
        Me.lblEstacion2.Text = "Estación:"
        Me.lblEstacion2.Visible = False
        '
        'CmbEst2
        '
        Me.CmbEst2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CmbEst2.Location = New System.Drawing.Point(428, 565)
        Me.CmbEst2.Name = "CmbEst2"
        Me.CmbEst2.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbEst2.Properties.Appearance.Options.UseFont = True
        Me.CmbEst2.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbEst2.Properties.AppearanceDropDown.Options.UseFont = True
        Me.CmbEst2.Properties.AppearanceDropDownHeader.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbEst2.Properties.AppearanceDropDownHeader.Options.UseFont = True
        Me.CmbEst2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CmbEst2.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Estacion", "Estacion", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Estacion", "Estación")})
        Me.CmbEst2.Properties.NullText = ""
        Me.CmbEst2.Properties.PopupSizeable = False
        Me.CmbEst2.Size = New System.Drawing.Size(160, 26)
        Me.CmbEst2.TabIndex = 181
        Me.CmbEst2.Visible = False
        '
        'lblTipolib
        '
        Me.lblTipolib.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblTipolib.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipolib.Appearance.Options.UseFont = True
        Me.lblTipolib.Location = New System.Drawing.Point(12, 522)
        Me.lblTipolib.Name = "lblTipolib"
        Me.lblTipolib.Size = New System.Drawing.Size(130, 19)
        Me.lblTipolib.TabIndex = 184
        Me.lblTipolib.Text = "Tipo de Liberacion:"
        Me.lblTipolib.Visible = False
        '
        'CmbT
        '
        Me.CmbT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CmbT.Enabled = False
        Me.CmbT.Location = New System.Drawing.Point(146, 520)
        Me.CmbT.Name = "CmbT"
        Me.CmbT.Properties.AcceptEditorTextAsNewValue = DevExpress.Utils.DefaultBoolean.[False]
        Me.CmbT.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.CmbT.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbT.Properties.Appearance.ForeColor = System.Drawing.Color.Transparent
        Me.CmbT.Properties.Appearance.Options.UseBackColor = True
        Me.CmbT.Properties.Appearance.Options.UseFont = True
        Me.CmbT.Properties.Appearance.Options.UseForeColor = True
        Me.CmbT.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbT.Properties.AppearanceDropDown.Options.UseFont = True
        Me.CmbT.Properties.AppearanceDropDownHeader.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbT.Properties.AppearanceDropDownHeader.Options.UseFont = True
        Me.CmbT.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CmbT.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("TipoLiberacion", "Tipo Liberacion")})
        Me.CmbT.Properties.NullText = ""
        Me.CmbT.Properties.PopupSizeable = False
        Me.CmbT.Size = New System.Drawing.Size(160, 26)
        Me.CmbT.TabIndex = 183
        Me.CmbT.Visible = False
        '
        'lblTipolib2
        '
        Me.lblTipolib2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblTipolib2.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipolib2.Appearance.Options.UseFont = True
        Me.lblTipolib2.Location = New System.Drawing.Point(12, 563)
        Me.lblTipolib2.Name = "lblTipolib2"
        Me.lblTipolib2.Size = New System.Drawing.Size(130, 19)
        Me.lblTipolib2.TabIndex = 186
        Me.lblTipolib2.Text = "Tipo de Liberacion:"
        Me.lblTipolib2.Visible = False
        '
        'CmbT2
        '
        Me.CmbT2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CmbT2.Enabled = False
        Me.CmbT2.Location = New System.Drawing.Point(146, 561)
        Me.CmbT2.Name = "CmbT2"
        Me.CmbT2.Properties.AcceptEditorTextAsNewValue = DevExpress.Utils.DefaultBoolean.[False]
        Me.CmbT2.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.CmbT2.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbT2.Properties.Appearance.ForeColor = System.Drawing.Color.Transparent
        Me.CmbT2.Properties.Appearance.Options.UseBackColor = True
        Me.CmbT2.Properties.Appearance.Options.UseFont = True
        Me.CmbT2.Properties.Appearance.Options.UseForeColor = True
        Me.CmbT2.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbT2.Properties.AppearanceDropDown.Options.UseFont = True
        Me.CmbT2.Properties.AppearanceDropDownHeader.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbT2.Properties.AppearanceDropDownHeader.Options.UseFont = True
        Me.CmbT2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CmbT2.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("TipoLiberacion", "Tipo Liberacion")})
        Me.CmbT2.Properties.NullText = ""
        Me.CmbT2.Properties.PopupSizeable = False
        Me.CmbT2.Size = New System.Drawing.Size(160, 26)
        Me.CmbT2.TabIndex = 185
        Me.CmbT2.Visible = False
        '
        'BtnElimina
        '
        Me.BtnElimina.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.BtnElimina.ImageOptions.Image = CType(resources.GetObject("BtnElimina.ImageOptions.Image"), System.Drawing.Image)
        Me.BtnElimina.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.BtnElimina.Location = New System.Drawing.Point(635, 557)
        Me.BtnElimina.Name = "BtnElimina"
        Me.BtnElimina.Size = New System.Drawing.Size(34, 35)
        Me.BtnElimina.TabIndex = 188
        Me.BtnElimina.Visible = False
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.BtnAgregar.ImageOptions.Image = CType(resources.GetObject("BtnAgregar.ImageOptions.Image"), System.Drawing.Image)
        Me.BtnAgregar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.BtnAgregar.Location = New System.Drawing.Point(685, 556)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(34, 35)
        Me.BtnAgregar.TabIndex = 187
        Me.BtnAgregar.Visible = False
        '
        'FrmLiberaOrdenEmbarque
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(983, 594)
        Me.Controls.Add(Me.BtnElimina)
        Me.Controls.Add(Me.BtnAgregar)
        Me.Controls.Add(Me.lblTipolib2)
        Me.Controls.Add(Me.CmbT2)
        Me.Controls.Add(Me.lblTipolib)
        Me.Controls.Add(Me.CmbT)
        Me.Controls.Add(Me.lblEstacion2)
        Me.Controls.Add(Me.CmbEst2)
        Me.Controls.Add(Me.lblEstacion)
        Me.Controls.Add(Me.CmbEsta)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.BtnLiberar)
        Me.Controls.Add(Me.DgvResultado)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.IconOptions.Image = Global.AXCVDE.My.Resources.Resources.Logo_X_150x150_01
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmLiberaOrdenEmbarque"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Liberación de órdenes de embarque"
        CType(Me.TxtBusqueda.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvResultado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvViewResultado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CmbEstacionGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CmbLoteGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridEstacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChkEstacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.CmbTipoLib.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CmbEstacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CmbEsta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CmbEst2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CmbT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CmbT2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnBuscar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnActualizar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TxtBusqueda As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DgvResultado As DevExpress.XtraGrid.GridControl
    Friend WithEvents DgvViewResultado As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents BtnLiberar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ChkEstacion As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CmbLoteGrid As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents CmbEstacionGrid As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents CmbEstacion As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridEstacion As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn15 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn16 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn17 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn18 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn19 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn20 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents RepositoryItemComboBox2 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents RepositoryItemGridLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemLookUpEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents lblEstacion As DevExpress.XtraEditors.LabelControl
    Friend WithEvents CmbEsta As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblEstacion2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents CmbEst2 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblTipolib As DevExpress.XtraEditors.LabelControl
    Friend WithEvents CmbT As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblTipolib2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents CmbT2 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents BtnElimina As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnAgregar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridColumn21 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn22 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn23 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn24 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn25 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CmbTipoLib As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LCarga As DevExpress.XtraGrid.Columns.GridColumn
End Class
