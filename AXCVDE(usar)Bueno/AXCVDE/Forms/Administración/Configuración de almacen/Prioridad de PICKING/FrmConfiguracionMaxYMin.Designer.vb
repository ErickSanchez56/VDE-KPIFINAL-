<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmConfiguracionMaxYMin
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgLayout = New System.Windows.Forms.DataGridView()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.btnAgregar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmbNumParte = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.NumParte = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DNumParte1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.DgvSeleccionadas = New DevExpress.XtraGrid.GridControl()
        Me.DgvViewSeleccionadas = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.spCapacidad = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.cmbAlmacen = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.btnOrdenes = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.LblUbicacionSeleccionada = New DevExpress.XtraEditors.LabelControl()
        Me.btnDeshabilitar = New DevExpress.XtraEditors.SimpleButton()
        Me.numMaximo = New DevExpress.XtraEditors.SpinEdit()
        Me.numMinimo = New DevExpress.XtraEditors.SpinEdit()
        Me.cmbPasillo = New DevExpress.XtraEditors.LookUpEdit()
        CType(Me.dgLayout, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbNumParte.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvSeleccionadas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvViewSeleccionadas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spCapacidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.cmbAlmacen.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        CType(Me.numMaximo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numMinimo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbPasillo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgLayout
        '
        Me.dgLayout.AllowUserToAddRows = False
        Me.dgLayout.AllowUserToDeleteRows = False
        Me.dgLayout.AllowUserToResizeColumns = False
        Me.dgLayout.AllowUserToResizeRows = False
        Me.dgLayout.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgLayout.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSkyBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 8.25!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgLayout.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgLayout.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Blue
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 8.25!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Navy
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgLayout.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgLayout.Location = New System.Drawing.Point(12, 12)
        Me.dgLayout.MultiSelect = False
        Me.dgLayout.Name = "dgLayout"
        Me.dgLayout.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Indigo
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 8.25!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkMagenta
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgLayout.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgLayout.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgLayout.Size = New System.Drawing.Size(1229, 423)
        Me.dgLayout.TabIndex = 462
        '
        'LabelControl1
        '
        Me.LabelControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(275, 155)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(59, 19)
        Me.LabelControl1.TabIndex = 111
        Me.LabelControl1.Text = "Máximo:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(16, 155)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(57, 19)
        Me.LabelControl2.TabIndex = 112
        Me.LabelControl2.Text = "Mínimo:"
        '
        'btnAgregar
        '
        Me.btnAgregar.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.Appearance.Options.UseFont = True
        Me.btnAgregar.Appearance.Options.UseTextOptions = True
        Me.btnAgregar.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnAgregar.Location = New System.Drawing.Point(342, 218)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(108, 44)
        Me.btnAgregar.TabIndex = 169
        Me.btnAgregar.Text = "Agregar"
        '
        'cmbNumParte
        '
        Me.cmbNumParte.Location = New System.Drawing.Point(79, 120)
        Me.cmbNumParte.Name = "cmbNumParte"
        Me.cmbNumParte.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbNumParte.Properties.Appearance.Options.UseFont = True
        Me.cmbNumParte.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbNumParte.Properties.AppearanceDropDown.Options.UseFont = True
        Me.cmbNumParte.Properties.AppearanceFocused.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbNumParte.Properties.AppearanceFocused.Options.UseFont = True
        Me.cmbNumParte.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbNumParte.Properties.NullText = ""
        Me.cmbNumParte.Properties.PopupSizeable = False
        Me.cmbNumParte.Properties.PopupView = Me.GridLookUpEdit1View
        Me.cmbNumParte.Size = New System.Drawing.Size(371, 26)
        Me.cmbNumParte.TabIndex = 107
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.NumParte, Me.DNumParte1})
        Me.GridLookUpEdit1View.DetailHeight = 303
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'NumParte
        '
        Me.NumParte.Caption = "Producto"
        Me.NumParte.FieldName = "NumParte"
        Me.NumParte.MinWidth = 17
        Me.NumParte.Name = "NumParte"
        Me.NumParte.Visible = True
        Me.NumParte.VisibleIndex = 0
        Me.NumParte.Width = 64
        '
        'DNumParte1
        '
        Me.DNumParte1.Caption = "Descripción"
        Me.DNumParte1.FieldName = "DNumParte1"
        Me.DNumParte1.MinWidth = 17
        Me.DNumParte1.Name = "DNumParte1"
        Me.DNumParte1.Visible = True
        Me.DNumParte1.VisibleIndex = 1
        Me.DNumParte1.Width = 64
        '
        'LabelControl7
        '
        Me.LabelControl7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl7.Appearance.Options.UseFont = True
        Me.LabelControl7.Location = New System.Drawing.Point(5, 121)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(68, 19)
        Me.LabelControl7.TabIndex = 108
        Me.LabelControl7.Text = "Producto:"
        '
        'DgvSeleccionadas
        '
        Me.DgvSeleccionadas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvSeleccionadas.Location = New System.Drawing.Point(470, 91)
        Me.DgvSeleccionadas.MainView = Me.DgvViewSeleccionadas
        Me.DgvSeleccionadas.Name = "DgvSeleccionadas"
        Me.DgvSeleccionadas.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit1, Me.spCapacidad})
        Me.DgvSeleccionadas.Size = New System.Drawing.Size(754, 200)
        Me.DgvSeleccionadas.TabIndex = 178
        Me.DgvSeleccionadas.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.DgvViewSeleccionadas, Me.GridView1})
        '
        'DgvViewSeleccionadas
        '
        Me.DgvViewSeleccionadas.GridControl = Me.DgvSeleccionadas
        Me.DgvViewSeleccionadas.Name = "DgvViewSeleccionadas"
        Me.DgvViewSeleccionadas.OptionsView.ColumnAutoWidth = False
        Me.DgvViewSeleccionadas.OptionsView.ShowGroupPanel = False
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.AutoSearchColumnIndex = 1
        Me.RepositoryItemLookUpEdit1.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("NumParte", "Producto"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DNumParte1", "Descripción")})
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        Me.RepositoryItemLookUpEdit1.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete
        '
        'spCapacidad
        '
        Me.spCapacidad.AutoHeight = False
        Me.spCapacidad.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.spCapacidad.Name = "spCapacidad"
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.DgvSeleccionadas
        Me.GridView1.Name = "GridView1"
        '
        'LabelControl4
        '
        Me.LabelControl4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(6, 18)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(162, 19)
        Me.LabelControl4.TabIndex = 180
        Me.LabelControl4.Text = "Ubicación seleccionada:"
        '
        'GroupControl1
        '
        Me.GroupControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.GroupControl1.Controls.Add(Me.cmbAlmacen)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.LabelControl5)
        Me.GroupControl1.Controls.Add(Me.btnOrdenes)
        Me.GroupControl1.Controls.Add(Me.GroupBox5)
        Me.GroupControl1.Controls.Add(Me.btnDeshabilitar)
        Me.GroupControl1.Controls.Add(Me.numMaximo)
        Me.GroupControl1.Controls.Add(Me.numMinimo)
        Me.GroupControl1.Controls.Add(Me.DgvSeleccionadas)
        Me.GroupControl1.Controls.Add(Me.LabelControl7)
        Me.GroupControl1.Controls.Add(Me.cmbNumParte)
        Me.GroupControl1.Controls.Add(Me.btnAgregar)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.cmbPasillo)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 441)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(1229, 304)
        Me.GroupControl1.TabIndex = 180
        Me.GroupControl1.Text = "Configuración"
        '
        'cmbAlmacen
        '
        Me.cmbAlmacen.Location = New System.Drawing.Point(186, 50)
        Me.cmbAlmacen.Name = "cmbAlmacen"
        Me.cmbAlmacen.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAlmacen.Properties.Appearance.Options.UseFont = True
        Me.cmbAlmacen.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbAlmacen.Properties.NullText = ""
        Me.cmbAlmacen.Properties.PopupSizeable = False
        Me.cmbAlmacen.Properties.PopupView = Me.GridView2
        Me.cmbAlmacen.Size = New System.Drawing.Size(264, 26)
        Me.cmbAlmacen.TabIndex = 192
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn5})
        Me.GridView2.DetailHeight = 303
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Almacén"
        Me.GridColumn5.FieldName = "ERPAlmacen"
        Me.GridColumn5.MinWidth = 17
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 0
        Me.GridColumn5.Width = 64
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(37, 53)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(143, 19)
        Me.LabelControl3.TabIndex = 191
        Me.LabelControl3.Text = "Seleccionar almacén:"
        '
        'LabelControl5
        '
        Me.LabelControl5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Location = New System.Drawing.Point(37, 89)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(36, 19)
        Me.LabelControl5.TabIndex = 190
        Me.LabelControl5.Text = "Rack:"
        '
        'btnOrdenes
        '
        Me.btnOrdenes.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOrdenes.Appearance.Options.UseFont = True
        Me.btnOrdenes.Appearance.Options.UseTextOptions = True
        Me.btnOrdenes.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnOrdenes.Location = New System.Drawing.Point(79, 219)
        Me.btnOrdenes.Name = "btnOrdenes"
        Me.btnOrdenes.Size = New System.Drawing.Size(108, 44)
        Me.btnOrdenes.TabIndex = 188
        Me.btnOrdenes.Text = "Ver órdenes"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.LabelControl4)
        Me.GroupBox5.Controls.Add(Me.LblUbicacionSeleccionada)
        Me.GroupBox5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox5.ForeColor = System.Drawing.Color.White
        Me.GroupBox5.Location = New System.Drawing.Point(470, 39)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(754, 46)
        Me.GroupBox5.TabIndex = 187
        Me.GroupBox5.TabStop = False
        '
        'LblUbicacionSeleccionada
        '
        Me.LblUbicacionSeleccionada.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblUbicacionSeleccionada.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUbicacionSeleccionada.Appearance.Options.UseFont = True
        Me.LblUbicacionSeleccionada.Location = New System.Drawing.Point(174, 18)
        Me.LblUbicacionSeleccionada.Name = "LblUbicacionSeleccionada"
        Me.LblUbicacionSeleccionada.Size = New System.Drawing.Size(5, 19)
        Me.LblUbicacionSeleccionada.TabIndex = 182
        Me.LblUbicacionSeleccionada.Text = "-"
        '
        'btnDeshabilitar
        '
        Me.btnDeshabilitar.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeshabilitar.Appearance.Options.UseFont = True
        Me.btnDeshabilitar.Appearance.Options.UseTextOptions = True
        Me.btnDeshabilitar.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnDeshabilitar.Location = New System.Drawing.Point(228, 218)
        Me.btnDeshabilitar.Name = "btnDeshabilitar"
        Me.btnDeshabilitar.Size = New System.Drawing.Size(108, 45)
        Me.btnDeshabilitar.TabIndex = 186
        Me.btnDeshabilitar.Text = "Deshabilitar"
        Me.btnDeshabilitar.Visible = False
        '
        'numMaximo
        '
        Me.numMaximo.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numMaximo.Location = New System.Drawing.Point(340, 152)
        Me.numMaximo.Name = "numMaximo"
        Me.numMaximo.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numMaximo.Properties.Appearance.Options.UseFont = True
        Me.numMaximo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.numMaximo.Size = New System.Drawing.Size(110, 26)
        Me.numMaximo.TabIndex = 185
        '
        'numMinimo
        '
        Me.numMinimo.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numMinimo.Location = New System.Drawing.Point(79, 152)
        Me.numMinimo.Name = "numMinimo"
        Me.numMinimo.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numMinimo.Properties.Appearance.Options.UseFont = True
        Me.numMinimo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.numMinimo.Size = New System.Drawing.Size(110, 26)
        Me.numMinimo.TabIndex = 184
        '
        'cmbPasillo
        '
        Me.cmbPasillo.Location = New System.Drawing.Point(79, 88)
        Me.cmbPasillo.Name = "cmbPasillo"
        Me.cmbPasillo.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPasillo.Properties.Appearance.Options.UseFont = True
        Me.cmbPasillo.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPasillo.Properties.AppearanceDropDown.Options.UseFont = True
        Me.cmbPasillo.Properties.AppearanceFocused.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPasillo.Properties.AppearanceFocused.Options.UseFont = True
        Me.cmbPasillo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbPasillo.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Rack", "Rack")})
        Me.cmbPasillo.Properties.NullText = ""
        Me.cmbPasillo.Properties.PopupSizeable = False
        Me.cmbPasillo.Size = New System.Drawing.Size(371, 26)
        Me.cmbPasillo.TabIndex = 189
        '
        'FrmConfiguracionMaxYMin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1257, 747)
        Me.Controls.Add(Me.dgLayout)
        Me.Controls.Add(Me.GroupControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.IconOptions.Image = Global.AXCVDE.My.Resources.Resources.Logo_X_150x150_01
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmConfiguracionMaxYMin"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configuración de posición"
        CType(Me.dgLayout, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbNumParte.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvSeleccionadas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvViewSeleccionadas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spCapacidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.cmbAlmacen.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.numMaximo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numMinimo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbPasillo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgLayout As DataGridView
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnAgregar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmbNumParte As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents NumParte As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DNumParte1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DgvSeleccionadas As DevExpress.XtraGrid.GridControl
    Friend WithEvents DgvViewSeleccionadas As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents spCapacidad As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnDeshabilitar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents numMaximo As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents numMinimo As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LblUbicacionSeleccionada As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents btnOrdenes As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbPasillo As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cmbAlmacen As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
End Class
