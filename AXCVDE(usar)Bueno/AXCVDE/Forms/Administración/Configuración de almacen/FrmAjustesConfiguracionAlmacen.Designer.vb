<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAjustesConfiguracionAlmacen
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgLayout = New System.Windows.Forms.DataGridView()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.TxtCapacidadNiv = New DevExpress.XtraEditors.TextEdit()
        Me.NupNivel = New DevExpress.XtraEditors.SpinEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.BtnAgregaNivel = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.TxtCapacidadPos = New DevExpress.XtraEditors.TextEdit()
        Me.NupPos = New DevExpress.XtraEditors.SpinEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.btnAgregarPos = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.ChkPiso = New DevExpress.XtraEditors.CheckEdit()
        Me.ChkRack = New DevExpress.XtraEditors.CheckEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.CmbAlmacen = New DevExpress.XtraEditors.LookUpEdit()
        Me.BtnAgregaRack = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.CmbPasillo = New DevExpress.XtraEditors.LookUpEdit()
        CType(Me.dgLayout, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.TxtCapacidadNiv.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NupNivel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.TxtCapacidadPos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NupPos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.ChkPiso.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChkRack.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CmbAlmacen.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CmbPasillo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgLayout
        '
        Me.dgLayout.AllowUserToAddRows = False
        Me.dgLayout.AllowUserToDeleteRows = False
        Me.dgLayout.AllowUserToResizeColumns = False
        Me.dgLayout.AllowUserToResizeRows = False
        Me.dgLayout.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.LightSkyBlue
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Tahoma", 8.25!)
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgLayout.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgLayout.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.Blue
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Tahoma", 8.25!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Chartreuse
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Navy
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgLayout.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgLayout.Location = New System.Drawing.Point(12, 144)
        Me.dgLayout.Name = "dgLayout"
        Me.dgLayout.ReadOnly = True
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.Indigo
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Tahoma", 8.25!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DarkMagenta
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgLayout.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgLayout.Size = New System.Drawing.Size(1060, 353)
        Me.dgLayout.TabIndex = 34
        '
        'GroupControl3
        '
        Me.GroupControl3.AppearanceCaption.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl3.AppearanceCaption.Options.UseFont = True
        Me.GroupControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.GroupControl3.Controls.Add(Me.TxtCapacidadNiv)
        Me.GroupControl3.Controls.Add(Me.NupNivel)
        Me.GroupControl3.Controls.Add(Me.LabelControl4)
        Me.GroupControl3.Controls.Add(Me.BtnAgregaNivel)
        Me.GroupControl3.Controls.Add(Me.LabelControl5)
        Me.GroupControl3.Location = New System.Drawing.Point(857, 12)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(215, 126)
        Me.GroupControl3.TabIndex = 191
        Me.GroupControl3.Text = "Agregar niveles"
        '
        'TxtCapacidadNiv
        '
        Me.TxtCapacidadNiv.Location = New System.Drawing.Point(148, 61)
        Me.TxtCapacidadNiv.Name = "TxtCapacidadNiv"
        Me.TxtCapacidadNiv.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCapacidadNiv.Properties.Appearance.Options.UseFont = True
        Me.TxtCapacidadNiv.Size = New System.Drawing.Size(56, 26)
        Me.TxtCapacidadNiv.TabIndex = 187
        '
        'NupNivel
        '
        Me.NupNivel.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NupNivel.Location = New System.Drawing.Point(148, 30)
        Me.NupNivel.Name = "NupNivel"
        Me.NupNivel.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NupNivel.Properties.Appearance.Options.UseFont = True
        Me.NupNivel.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.NupNivel.Properties.IsFloatValue = False
        Me.NupNivel.Properties.MaskSettings.Set("mask", "N00")
        Me.NupNivel.Properties.MaxValue = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.NupNivel.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NupNivel.Size = New System.Drawing.Size(56, 26)
        Me.NupNivel.TabIndex = 186
        '
        'LabelControl4
        '
        Me.LabelControl4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(5, 33)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(137, 19)
        Me.LabelControl4.TabIndex = 185
        Me.LabelControl4.Text = "Cantidad de niveles:"
        '
        'BtnAgregaNivel
        '
        Me.BtnAgregaNivel.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAgregaNivel.Appearance.Options.UseFont = True
        Me.BtnAgregaNivel.Appearance.Options.UseTextOptions = True
        Me.BtnAgregaNivel.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.BtnAgregaNivel.Location = New System.Drawing.Point(132, 92)
        Me.BtnAgregaNivel.Name = "BtnAgregaNivel"
        Me.BtnAgregaNivel.Size = New System.Drawing.Size(72, 27)
        Me.BtnAgregaNivel.TabIndex = 180
        Me.BtnAgregaNivel.Text = "Agregar"
        '
        'LabelControl5
        '
        Me.LabelControl5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Location = New System.Drawing.Point(68, 64)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(74, 19)
        Me.LabelControl5.TabIndex = 109
        Me.LabelControl5.Text = "Capacidad:"
        '
        'GroupControl2
        '
        Me.GroupControl2.AppearanceCaption.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl2.AppearanceCaption.Options.UseFont = True
        Me.GroupControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.GroupControl2.Controls.Add(Me.TxtCapacidadPos)
        Me.GroupControl2.Controls.Add(Me.NupPos)
        Me.GroupControl2.Controls.Add(Me.LabelControl2)
        Me.GroupControl2.Controls.Add(Me.btnAgregarPos)
        Me.GroupControl2.Controls.Add(Me.LabelControl3)
        Me.GroupControl2.Location = New System.Drawing.Point(598, 12)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(237, 126)
        Me.GroupControl2.TabIndex = 190
        Me.GroupControl2.Text = "Agregar posiciones"
        '
        'TxtCapacidadPos
        '
        Me.TxtCapacidadPos.Location = New System.Drawing.Point(172, 61)
        Me.TxtCapacidadPos.Name = "TxtCapacidadPos"
        Me.TxtCapacidadPos.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCapacidadPos.Properties.Appearance.Options.UseFont = True
        Me.TxtCapacidadPos.Size = New System.Drawing.Size(56, 26)
        Me.TxtCapacidadPos.TabIndex = 187
        '
        'NupPos
        '
        Me.NupPos.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NupPos.Location = New System.Drawing.Point(172, 30)
        Me.NupPos.Name = "NupPos"
        Me.NupPos.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NupPos.Properties.Appearance.Options.UseFont = True
        Me.NupPos.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.NupPos.Properties.IsFloatValue = False
        Me.NupPos.Properties.MaskSettings.Set("mask", "N00")
        Me.NupPos.Properties.MaxValue = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.NupPos.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NupPos.Size = New System.Drawing.Size(56, 26)
        Me.NupPos.TabIndex = 186
        '
        'LabelControl2
        '
        Me.LabelControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(5, 33)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(161, 19)
        Me.LabelControl2.TabIndex = 185
        Me.LabelControl2.Text = "Cantidad de posiciones:"
        '
        'btnAgregarPos
        '
        Me.btnAgregarPos.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarPos.Appearance.Options.UseFont = True
        Me.btnAgregarPos.Appearance.Options.UseTextOptions = True
        Me.btnAgregarPos.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnAgregarPos.Location = New System.Drawing.Point(156, 92)
        Me.btnAgregarPos.Name = "btnAgregarPos"
        Me.btnAgregarPos.Size = New System.Drawing.Size(72, 27)
        Me.btnAgregarPos.TabIndex = 180
        Me.btnAgregarPos.Text = "Agregar"
        '
        'LabelControl3
        '
        Me.LabelControl3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(92, 64)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(74, 19)
        Me.LabelControl3.TabIndex = 109
        Me.LabelControl3.Text = "Capacidad:"
        '
        'GroupControl1
        '
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.GroupControl1.Controls.Add(Me.ChkPiso)
        Me.GroupControl1.Controls.Add(Me.ChkRack)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.CmbAlmacen)
        Me.GroupControl1.Controls.Add(Me.BtnAgregaRack)
        Me.GroupControl1.Controls.Add(Me.LabelControl7)
        Me.GroupControl1.Controls.Add(Me.CmbPasillo)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 12)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(580, 126)
        Me.GroupControl1.TabIndex = 189
        Me.GroupControl1.Text = "Seleccionar ubicación"
        '
        'ChkPiso
        '
        Me.ChkPiso.Location = New System.Drawing.Point(80, 90)
        Me.ChkPiso.Name = "ChkPiso"
        Me.ChkPiso.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkPiso.Properties.Appearance.Options.UseFont = True
        Me.ChkPiso.Properties.Caption = "Piso"
        Me.ChkPiso.Size = New System.Drawing.Size(75, 23)
        Me.ChkPiso.TabIndex = 188
        '
        'ChkRack
        '
        Me.ChkRack.Location = New System.Drawing.Point(80, 66)
        Me.ChkRack.Name = "ChkRack"
        Me.ChkRack.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkRack.Properties.Appearance.Options.UseFont = True
        Me.ChkRack.Properties.Caption = "Rack"
        Me.ChkRack.Size = New System.Drawing.Size(75, 23)
        Me.ChkRack.TabIndex = 187
        '
        'LabelControl1
        '
        Me.LabelControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(11, 41)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(63, 19)
        Me.LabelControl1.TabIndex = 185
        Me.LabelControl1.Text = "Almacén:"
        '
        'CmbAlmacen
        '
        Me.CmbAlmacen.Location = New System.Drawing.Point(80, 38)
        Me.CmbAlmacen.Name = "CmbAlmacen"
        Me.CmbAlmacen.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbAlmacen.Properties.Appearance.Options.UseFont = True
        Me.CmbAlmacen.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbAlmacen.Properties.AppearanceDisabled.Options.UseFont = True
        Me.CmbAlmacen.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbAlmacen.Properties.AppearanceDropDown.Options.UseFont = True
        Me.CmbAlmacen.Properties.AppearanceDropDownHeader.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbAlmacen.Properties.AppearanceDropDownHeader.Options.UseFont = True
        Me.CmbAlmacen.Properties.AppearanceFocused.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbAlmacen.Properties.AppearanceFocused.Options.UseFont = True
        Me.CmbAlmacen.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CmbAlmacen.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ERPAlmacen", "Almacen")})
        Me.CmbAlmacen.Properties.NullText = ""
        Me.CmbAlmacen.Properties.PopupSizeable = False
        Me.CmbAlmacen.Size = New System.Drawing.Size(173, 26)
        Me.CmbAlmacen.TabIndex = 186
        '
        'BtnAgregaRack
        '
        Me.BtnAgregaRack.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAgregaRack.Appearance.Options.UseFont = True
        Me.BtnAgregaRack.Appearance.Options.UseTextOptions = True
        Me.BtnAgregaRack.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.BtnAgregaRack.Location = New System.Drawing.Point(426, 77)
        Me.BtnAgregaRack.Name = "BtnAgregaRack"
        Me.BtnAgregaRack.Size = New System.Drawing.Size(138, 36)
        Me.BtnAgregaRack.TabIndex = 180
        Me.BtnAgregaRack.Text = "Agregar ubicación"
        '
        'LabelControl7
        '
        Me.LabelControl7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl7.Appearance.Options.UseFont = True
        Me.LabelControl7.Location = New System.Drawing.Point(314, 41)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(71, 19)
        Me.LabelControl7.TabIndex = 109
        Me.LabelControl7.Text = "Ubicación:"
        '
        'CmbPasillo
        '
        Me.CmbPasillo.Location = New System.Drawing.Point(391, 38)
        Me.CmbPasillo.Name = "CmbPasillo"
        Me.CmbPasillo.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbPasillo.Properties.Appearance.Options.UseFont = True
        Me.CmbPasillo.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbPasillo.Properties.AppearanceDisabled.Options.UseFont = True
        Me.CmbPasillo.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbPasillo.Properties.AppearanceDropDown.Options.UseFont = True
        Me.CmbPasillo.Properties.AppearanceDropDownHeader.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbPasillo.Properties.AppearanceDropDownHeader.Options.UseFont = True
        Me.CmbPasillo.Properties.AppearanceFocused.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbPasillo.Properties.AppearanceFocused.Options.UseFont = True
        Me.CmbPasillo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CmbPasillo.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Rack", "Rack")})
        Me.CmbPasillo.Properties.NullText = ""
        Me.CmbPasillo.Properties.PopupSizeable = False
        Me.CmbPasillo.Size = New System.Drawing.Size(173, 26)
        Me.CmbPasillo.TabIndex = 111
        '
        'FrmAjustesConfiguracionAlmacen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1084, 513)
        Me.Controls.Add(Me.GroupControl3)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.dgLayout)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.IconOptions.Image = Global.AXCVDE.My.Resources.Resources.Logo_X_150x150_01
        Me.LookAndFeel.TouchUIMode = DevExpress.Utils.DefaultBoolean.[False]
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmAjustesConfiguracionAlmacen"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar ubicación"
        CType(Me.dgLayout, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        Me.GroupControl3.PerformLayout()
        CType(Me.TxtCapacidadNiv.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NupNivel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.TxtCapacidadPos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NupPos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.ChkPiso.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChkRack.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CmbAlmacen.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CmbPasillo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgLayout As DataGridView
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents TxtCapacidadNiv As DevExpress.XtraEditors.TextEdit
    Friend WithEvents NupNivel As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents BtnAgregaNivel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents TxtCapacidadPos As DevExpress.XtraEditors.TextEdit
    Friend WithEvents NupPos As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnAgregarPos As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents ChkPiso As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ChkRack As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents CmbAlmacen As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents BtnAgregaRack As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents CmbPasillo As DevExpress.XtraEditors.LookUpEdit
End Class
