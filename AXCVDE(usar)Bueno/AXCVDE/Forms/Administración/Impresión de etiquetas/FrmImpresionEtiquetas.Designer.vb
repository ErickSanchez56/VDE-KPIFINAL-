<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmImpresionEtiquetas
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
        Me.txtDescripcion = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.cmbNumParte = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.NumParte = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DNumParte1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.btnImprimirSKU = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.cmbImpresoraSKU = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.numEtiquetasSKU = New DevExpress.XtraEditors.SpinEdit()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.numEtiquetasCONT = New DevExpress.XtraEditors.SpinEdit()
        Me.cmbImprimirCONT = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.cmbImpresoraCONT = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.btnImprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.cmbImpresora = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.numEtiquetasCARR = New DevExpress.XtraEditors.SpinEdit()
        Me.GroupControl4 = New DevExpress.XtraEditors.GroupControl()
        Me.btnImprimirEMP = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.cmbImpresoraEMP = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.NumEtiquetasEMP = New DevExpress.XtraEditors.SpinEdit()
        CType(Me.txtDescripcion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbNumParte.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbImpresoraSKU.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numEtiquetasSKU.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.numEtiquetasCONT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbImpresoraCONT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.cmbImpresora.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numEtiquetasCARR.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl4.SuspendLayout()
        CType(Me.cmbImpresoraEMP.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumEtiquetasEMP.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Enabled = False
        Me.txtDescripcion.Location = New System.Drawing.Point(94, 75)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.Properties.Appearance.Options.UseFont = True
        Me.txtDescripcion.Size = New System.Drawing.Size(367, 26)
        Me.txtDescripcion.TabIndex = 132
        '
        'LabelControl13
        '
        Me.LabelControl13.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl13.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl13.Appearance.Options.UseFont = True
        Me.LabelControl13.Location = New System.Drawing.Point(5, 78)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(83, 19)
        Me.LabelControl13.TabIndex = 131
        Me.LabelControl13.Text = "Descripción:"
        '
        'cmbNumParte
        '
        Me.cmbNumParte.Location = New System.Drawing.Point(94, 43)
        Me.cmbNumParte.Name = "cmbNumParte"
        Me.cmbNumParte.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbNumParte.Properties.Appearance.Options.UseFont = True
        Me.cmbNumParte.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbNumParte.Properties.NullText = ""
        Me.cmbNumParte.Properties.PopupSizeable = False
        Me.cmbNumParte.Properties.PopupView = Me.GridLookUpEdit1View
        Me.cmbNumParte.Size = New System.Drawing.Size(367, 26)
        Me.cmbNumParte.TabIndex = 130
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
        Me.NumParte.Caption = "Artículo"
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
        Me.LabelControl7.Location = New System.Drawing.Point(29, 46)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(59, 19)
        Me.LabelControl7.TabIndex = 133
        Me.LabelControl7.Text = "Artículo:"
        '
        'btnImprimirSKU
        '
        Me.btnImprimirSKU.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimirSKU.Appearance.Options.UseFont = True
        Me.btnImprimirSKU.Location = New System.Drawing.Point(360, 131)
        Me.btnImprimirSKU.Name = "btnImprimirSKU"
        Me.btnImprimirSKU.Size = New System.Drawing.Size(101, 34)
        Me.btnImprimirSKU.TabIndex = 153
        Me.btnImprimirSKU.Text = "Imprimir"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(15, 142)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(73, 19)
        Me.LabelControl3.TabIndex = 151
        Me.LabelControl3.Text = "Impresora:"
        '
        'cmbImpresoraSKU
        '
        Me.cmbImpresoraSKU.Location = New System.Drawing.Point(94, 139)
        Me.cmbImpresoraSKU.Name = "cmbImpresoraSKU"
        Me.cmbImpresoraSKU.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbImpresoraSKU.Properties.Appearance.Options.UseFont = True
        Me.cmbImpresoraSKU.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbImpresoraSKU.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Impresora", "Impresora")})
        Me.cmbImpresoraSKU.Properties.NullText = ""
        Me.cmbImpresoraSKU.Size = New System.Drawing.Size(260, 26)
        Me.cmbImpresoraSKU.TabIndex = 152
        '
        'LabelControl1
        '
        Me.LabelControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(23, 110)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(65, 19)
        Me.LabelControl1.TabIndex = 150
        Me.LabelControl1.Text = "Cantidad:"
        '
        'numEtiquetasSKU
        '
        Me.numEtiquetasSKU.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numEtiquetasSKU.Location = New System.Drawing.Point(94, 107)
        Me.numEtiquetasSKU.Name = "numEtiquetasSKU"
        Me.numEtiquetasSKU.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numEtiquetasSKU.Properties.Appearance.Options.UseFont = True
        Me.numEtiquetasSKU.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.numEtiquetasSKU.Properties.IsFloatValue = False
        Me.numEtiquetasSKU.Properties.MaskSettings.Set("mask", "N00")
        Me.numEtiquetasSKU.Properties.MaxValue = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.numEtiquetasSKU.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numEtiquetasSKU.Size = New System.Drawing.Size(100, 26)
        Me.numEtiquetasSKU.TabIndex = 149
        '
        'GroupControl1
        '
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.Controls.Add(Me.cmbNumParte)
        Me.GroupControl1.Controls.Add(Me.LabelControl13)
        Me.GroupControl1.Controls.Add(Me.txtDescripcion)
        Me.GroupControl1.Controls.Add(Me.LabelControl7)
        Me.GroupControl1.Controls.Add(Me.btnImprimirSKU)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.cmbImpresoraSKU)
        Me.GroupControl1.Controls.Add(Me.numEtiquetasSKU)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 134)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(487, 182)
        Me.GroupControl1.TabIndex = 154
        Me.GroupControl1.Text = "Impresión de SKU"
        '
        'GroupControl2
        '
        Me.GroupControl2.AppearanceCaption.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl2.AppearanceCaption.Options.UseFont = True
        Me.GroupControl2.Controls.Add(Me.numEtiquetasCONT)
        Me.GroupControl2.Controls.Add(Me.cmbImprimirCONT)
        Me.GroupControl2.Controls.Add(Me.LabelControl2)
        Me.GroupControl2.Controls.Add(Me.cmbImpresoraCONT)
        Me.GroupControl2.Controls.Add(Me.LabelControl4)
        Me.GroupControl2.Location = New System.Drawing.Point(505, 12)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(463, 116)
        Me.GroupControl2.TabIndex = 155
        Me.GroupControl2.Text = "Impresión de contenedores"
        '
        'numEtiquetasCONT
        '
        Me.numEtiquetasCONT.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numEtiquetasCONT.Location = New System.Drawing.Point(84, 40)
        Me.numEtiquetasCONT.Name = "numEtiquetasCONT"
        Me.numEtiquetasCONT.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numEtiquetasCONT.Properties.Appearance.Options.UseFont = True
        Me.numEtiquetasCONT.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.numEtiquetasCONT.Properties.IsFloatValue = False
        Me.numEtiquetasCONT.Properties.MaskSettings.Set("mask", "N00")
        Me.numEtiquetasCONT.Properties.MaxValue = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.numEtiquetasCONT.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numEtiquetasCONT.Size = New System.Drawing.Size(114, 26)
        Me.numEtiquetasCONT.TabIndex = 149
        '
        'cmbImprimirCONT
        '
        Me.cmbImprimirCONT.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbImprimirCONT.Appearance.Options.UseFont = True
        Me.cmbImprimirCONT.Location = New System.Drawing.Point(350, 64)
        Me.cmbImprimirCONT.Name = "cmbImprimirCONT"
        Me.cmbImprimirCONT.Size = New System.Drawing.Size(101, 34)
        Me.cmbImprimirCONT.TabIndex = 153
        Me.cmbImprimirCONT.Text = "Imprimir"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(5, 75)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(73, 19)
        Me.LabelControl2.TabIndex = 151
        Me.LabelControl2.Text = "Impresora:"
        '
        'cmbImpresoraCONT
        '
        Me.cmbImpresoraCONT.Location = New System.Drawing.Point(84, 72)
        Me.cmbImpresoraCONT.Name = "cmbImpresoraCONT"
        Me.cmbImpresoraCONT.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbImpresoraCONT.Properties.Appearance.Options.UseFont = True
        Me.cmbImpresoraCONT.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbImpresoraCONT.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Impresora", "Impresora")})
        Me.cmbImpresoraCONT.Properties.NullText = ""
        Me.cmbImpresoraCONT.Size = New System.Drawing.Size(260, 26)
        Me.cmbImpresoraCONT.TabIndex = 152
        '
        'LabelControl4
        '
        Me.LabelControl4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(13, 43)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(65, 19)
        Me.LabelControl4.TabIndex = 150
        Me.LabelControl4.Text = "Cantidad:"
        '
        'GroupControl3
        '
        Me.GroupControl3.AppearanceCaption.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl3.AppearanceCaption.Options.UseFont = True
        Me.GroupControl3.Controls.Add(Me.btnImprimir)
        Me.GroupControl3.Controls.Add(Me.LabelControl8)
        Me.GroupControl3.Controls.Add(Me.cmbImpresora)
        Me.GroupControl3.Controls.Add(Me.LabelControl9)
        Me.GroupControl3.Controls.Add(Me.numEtiquetasCARR)
        Me.GroupControl3.Location = New System.Drawing.Point(12, 12)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(487, 116)
        Me.GroupControl3.TabIndex = 156
        Me.GroupControl3.Text = "Impresión de carritos"
        '
        'btnImprimir
        '
        Me.btnImprimir.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimir.Appearance.Options.UseFont = True
        Me.btnImprimir.Location = New System.Drawing.Point(360, 67)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(101, 34)
        Me.btnImprimir.TabIndex = 158
        Me.btnImprimir.Text = "Imprimir"
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl8.Appearance.Options.UseFont = True
        Me.LabelControl8.Location = New System.Drawing.Point(15, 75)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(73, 19)
        Me.LabelControl8.TabIndex = 156
        Me.LabelControl8.Text = "Impresora:"
        '
        'cmbImpresora
        '
        Me.cmbImpresora.Location = New System.Drawing.Point(94, 72)
        Me.cmbImpresora.Name = "cmbImpresora"
        Me.cmbImpresora.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbImpresora.Properties.Appearance.Options.UseFont = True
        Me.cmbImpresora.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbImpresora.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Impresora", "Impresora")})
        Me.cmbImpresora.Properties.NullText = ""
        Me.cmbImpresora.Size = New System.Drawing.Size(260, 26)
        Me.cmbImpresora.TabIndex = 157
        '
        'LabelControl9
        '
        Me.LabelControl9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl9.Appearance.Options.UseFont = True
        Me.LabelControl9.Location = New System.Drawing.Point(23, 43)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(65, 19)
        Me.LabelControl9.TabIndex = 155
        Me.LabelControl9.Text = "Cantidad:"
        '
        'numEtiquetasCARR
        '
        Me.numEtiquetasCARR.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numEtiquetasCARR.Location = New System.Drawing.Point(94, 40)
        Me.numEtiquetasCARR.Name = "numEtiquetasCARR"
        Me.numEtiquetasCARR.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numEtiquetasCARR.Properties.Appearance.Options.UseFont = True
        Me.numEtiquetasCARR.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.numEtiquetasCARR.Properties.IsFloatValue = False
        Me.numEtiquetasCARR.Properties.MaskSettings.Set("mask", "N00")
        Me.numEtiquetasCARR.Properties.MaxValue = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.numEtiquetasCARR.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numEtiquetasCARR.Size = New System.Drawing.Size(100, 26)
        Me.numEtiquetasCARR.TabIndex = 154
        '
        'GroupControl4
        '
        Me.GroupControl4.AppearanceCaption.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl4.AppearanceCaption.Options.UseFont = True
        Me.GroupControl4.Controls.Add(Me.btnImprimirEMP)
        Me.GroupControl4.Controls.Add(Me.LabelControl5)
        Me.GroupControl4.Controls.Add(Me.cmbImpresoraEMP)
        Me.GroupControl4.Controls.Add(Me.LabelControl6)
        Me.GroupControl4.Controls.Add(Me.NumEtiquetasEMP)
        Me.GroupControl4.Location = New System.Drawing.Point(505, 134)
        Me.GroupControl4.Name = "GroupControl4"
        Me.GroupControl4.Size = New System.Drawing.Size(463, 117)
        Me.GroupControl4.TabIndex = 155
        Me.GroupControl4.Text = "Impresión de empaques"
        '
        'btnImprimirEMP
        '
        Me.btnImprimirEMP.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimirEMP.Appearance.Options.UseFont = True
        Me.btnImprimirEMP.Location = New System.Drawing.Point(350, 64)
        Me.btnImprimirEMP.Name = "btnImprimirEMP"
        Me.btnImprimirEMP.Size = New System.Drawing.Size(101, 34)
        Me.btnImprimirEMP.TabIndex = 146
        Me.btnImprimirEMP.Text = "Imprimir"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Location = New System.Drawing.Point(5, 75)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(73, 19)
        Me.LabelControl5.TabIndex = 148
        Me.LabelControl5.Text = "Impresora:"
        '
        'cmbImpresoraEMP
        '
        Me.cmbImpresoraEMP.Location = New System.Drawing.Point(84, 72)
        Me.cmbImpresoraEMP.Name = "cmbImpresoraEMP"
        Me.cmbImpresoraEMP.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbImpresoraEMP.Properties.Appearance.Options.UseFont = True
        Me.cmbImpresoraEMP.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbImpresoraEMP.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Impresora", "Impresora")})
        Me.cmbImpresoraEMP.Properties.NullText = ""
        Me.cmbImpresoraEMP.Size = New System.Drawing.Size(260, 26)
        Me.cmbImpresoraEMP.TabIndex = 145
        '
        'LabelControl6
        '
        Me.LabelControl6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Appearance.Options.UseFont = True
        Me.LabelControl6.Location = New System.Drawing.Point(13, 43)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(65, 19)
        Me.LabelControl6.TabIndex = 147
        Me.LabelControl6.Text = "Cantidad:"
        '
        'NumEtiquetasEMP
        '
        Me.NumEtiquetasEMP.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumEtiquetasEMP.Location = New System.Drawing.Point(84, 40)
        Me.NumEtiquetasEMP.Name = "NumEtiquetasEMP"
        Me.NumEtiquetasEMP.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumEtiquetasEMP.Properties.Appearance.Options.UseFont = True
        Me.NumEtiquetasEMP.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.NumEtiquetasEMP.Properties.IsFloatValue = False
        Me.NumEtiquetasEMP.Properties.MaskSettings.Set("mask", "N00")
        Me.NumEtiquetasEMP.Properties.MaxValue = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.NumEtiquetasEMP.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumEtiquetasEMP.Size = New System.Drawing.Size(114, 26)
        Me.NumEtiquetasEMP.TabIndex = 144
        '
        'FrmImpresionEtiquetas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1222, 505)
        Me.Controls.Add(Me.GroupControl4)
        Me.Controls.Add(Me.GroupControl3)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmImpresionEtiquetas"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Impresión de etiquetas"
        CType(Me.txtDescripcion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbNumParte.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbImpresoraSKU.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numEtiquetasSKU.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.numEtiquetasCONT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbImpresoraCONT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        Me.GroupControl3.PerformLayout()
        CType(Me.cmbImpresora.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numEtiquetasCARR.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl4.ResumeLayout(False)
        Me.GroupControl4.PerformLayout()
        CType(Me.cmbImpresoraEMP.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumEtiquetasEMP.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtDescripcion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbNumParte As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents NumParte As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DNumParte1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnImprimirSKU As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbImpresoraSKU As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents numEtiquetasSKU As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl4 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents cmbImprimirCONT As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbImpresoraCONT As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnImprimirEMP As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbImpresoraEMP As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents NumEtiquetasEMP As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents btnImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbImpresora As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents numEtiquetasCARR As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents numEtiquetasCONT As DevExpress.XtraEditors.SpinEdit
End Class
