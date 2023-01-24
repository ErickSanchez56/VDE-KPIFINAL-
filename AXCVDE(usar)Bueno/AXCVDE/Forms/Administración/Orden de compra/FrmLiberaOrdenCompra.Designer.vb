<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLiberaOrdenCompra
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLiberaOrdenCompra))
        Me.SeparatorControl1 = New DevExpress.XtraEditors.SeparatorControl()
        Me.txtOrdenCompra = New DevExpress.XtraEditors.TextEdit()
        Me.txtDireccionProv = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.btnBuscar = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtIdProveedor = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txtFactura = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.txtReferencia = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.dgvResultado = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.btnLiberar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnActualizar = New DevExpress.XtraEditors.SimpleButton()
        Me.dtpFechaRecibe = New DevExpress.XtraEditors.DateEdit()
        Me.txtFechaCrea = New DevExpress.XtraEditors.TextEdit()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.txtPedimento = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.txtClavePedimento = New DevExpress.XtraEditors.TextEdit()
        Me.dtFechaPedimento = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCabecera = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.TxtNota = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.txtContenedor = New DevExpress.XtraEditors.TextEdit()
        CType(Me.SeparatorControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOrdenCompra.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDireccionProv.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIdProveedor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFactura.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtReferencia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvResultado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaRecibe.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaRecibe.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFechaCrea.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPedimento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtClavePedimento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFechaPedimento.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFechaPedimento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCabecera.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNota.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtContenedor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SeparatorControl1
        '
        Me.SeparatorControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SeparatorControl1.AutoSizeMode = True
        Me.SeparatorControl1.LineAlignment = DevExpress.XtraEditors.Alignment.Center
        Me.SeparatorControl1.LineOrientation = System.Windows.Forms.Orientation.Vertical
        Me.SeparatorControl1.Location = New System.Drawing.Point(483, -12)
        Me.SeparatorControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.SeparatorControl1.Name = "SeparatorControl1"
        Me.SeparatorControl1.Padding = New System.Windows.Forms.Padding(11, 10, 11, 10)
        Me.SeparatorControl1.Size = New System.Drawing.Size(23, 592)
        Me.SeparatorControl1.TabIndex = 53
        '
        'txtOrdenCompra
        '
        Me.txtOrdenCompra.Location = New System.Drawing.Point(209, 64)
        Me.txtOrdenCompra.Margin = New System.Windows.Forms.Padding(4)
        Me.txtOrdenCompra.Name = "txtOrdenCompra"
        Me.txtOrdenCompra.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOrdenCompra.Properties.Appearance.Options.UseFont = True
        Me.txtOrdenCompra.Size = New System.Drawing.Size(169, 30)
        Me.txtOrdenCompra.TabIndex = 1
        '
        'txtDireccionProv
        '
        Me.txtDireccionProv.Enabled = False
        Me.txtDireccionProv.Location = New System.Drawing.Point(209, 149)
        Me.txtDireccionProv.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDireccionProv.Name = "txtDireccionProv"
        Me.txtDireccionProv.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccionProv.Properties.Appearance.Options.UseFont = True
        Me.txtDireccionProv.Size = New System.Drawing.Size(275, 30)
        Me.txtDireccionProv.TabIndex = 51
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(11, 68)
        Me.LabelControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(104, 24)
        Me.LabelControl1.TabIndex = 44
        Me.LabelControl1.Text = "Documento:"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(11, 153)
        Me.LabelControl3.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(84, 24)
        Me.LabelControl3.TabIndex = 50
        Me.LabelControl3.Text = "Dirección:"
        '
        'btnBuscar
        '
        Me.btnBuscar.ImageOptions.Image = CType(resources.GetObject("btnBuscar.ImageOptions.Image"), System.Drawing.Image)
        Me.btnBuscar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnBuscar.Location = New System.Drawing.Point(387, 59)
        Me.btnBuscar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(45, 43)
        Me.btnBuscar.TabIndex = 2
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(11, 113)
        Me.LabelControl2.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(93, 24)
        Me.LabelControl2.TabIndex = 47
        Me.LabelControl2.Text = "Proveedor:"
        '
        'txtIdProveedor
        '
        Me.txtIdProveedor.Enabled = False
        Me.txtIdProveedor.Location = New System.Drawing.Point(209, 110)
        Me.txtIdProveedor.Margin = New System.Windows.Forms.Padding(4)
        Me.txtIdProveedor.Name = "txtIdProveedor"
        Me.txtIdProveedor.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdProveedor.Properties.Appearance.Options.UseFont = True
        Me.txtIdProveedor.Size = New System.Drawing.Size(271, 30)
        Me.txtIdProveedor.TabIndex = 48
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(11, 266)
        Me.LabelControl4.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(68, 24)
        Me.LabelControl4.TabIndex = 60
        Me.LabelControl4.Text = "Factura:"
        '
        'txtFactura
        '
        Me.txtFactura.Location = New System.Drawing.Point(209, 262)
        Me.txtFactura.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFactura.Name = "txtFactura"
        Me.txtFactura.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFactura.Properties.Appearance.Options.UseFont = True
        Me.txtFactura.Size = New System.Drawing.Size(272, 30)
        Me.txtFactura.TabIndex = 4
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Appearance.Options.UseFont = True
        Me.LabelControl6.Location = New System.Drawing.Point(513, 23)
        Me.LabelControl6.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(113, 24)
        Me.LabelControl6.TabIndex = 62
        Me.LabelControl6.Text = "Comentarios:"
        '
        'txtReferencia
        '
        Me.txtReferencia.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtReferencia.Location = New System.Drawing.Point(641, 20)
        Me.txtReferencia.Margin = New System.Windows.Forms.Padding(4)
        Me.txtReferencia.Name = "txtReferencia"
        Me.txtReferencia.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReferencia.Properties.Appearance.Options.UseFont = True
        Me.txtReferencia.Size = New System.Drawing.Size(332, 30)
        Me.txtReferencia.TabIndex = 9
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl7.Appearance.Options.UseFont = True
        Me.LabelControl7.Location = New System.Drawing.Point(11, 310)
        Me.LabelControl7.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(115, 24)
        Me.LabelControl7.TabIndex = 64
        Me.LabelControl7.Text = "Fecha Recibo:"
        '
        'dgvResultado
        '
        Me.dgvResultado.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvResultado.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvResultado.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.dgvResultado.Location = New System.Drawing.Point(513, 59)
        Me.dgvResultado.MainView = Me.GridView1
        Me.dgvResultado.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvResultado.Name = "dgvResultado"
        Me.dgvResultado.Size = New System.Drawing.Size(460, 467)
        Me.dgvResultado.TabIndex = 66
        Me.dgvResultado.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.EvenRow.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView1.Appearance.EvenRow.Options.UseFont = True
        Me.GridView1.Appearance.FixedLine.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView1.Appearance.FixedLine.Options.UseFont = True
        Me.GridView1.Appearance.FocusedRow.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView1.Appearance.FocusedRow.Options.UseFont = True
        Me.GridView1.Appearance.GroupRow.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView1.Appearance.GroupRow.Options.UseFont = True
        Me.GridView1.Appearance.HeaderPanel.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView1.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridView1.Appearance.HideSelectionRow.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView1.Appearance.HideSelectionRow.Options.UseFont = True
        Me.GridView1.Appearance.HotTrackedRow.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView1.Appearance.HotTrackedRow.Options.UseFont = True
        Me.GridView1.Appearance.OddRow.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView1.Appearance.OddRow.Options.UseFont = True
        Me.GridView1.Appearance.Row.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView1.Appearance.Row.Options.UseFont = True
        Me.GridView1.Appearance.RowSeparator.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView1.Appearance.RowSeparator.Options.UseFont = True
        Me.GridView1.Appearance.SelectedRow.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView1.Appearance.SelectedRow.Options.UseFont = True
        Me.GridView1.Appearance.TopNewRow.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView1.Appearance.TopNewRow.Options.UseFont = True
        Me.GridView1.DetailHeight = 373
        Me.GridView1.GridControl = Me.dgvResultado
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'btnLiberar
        '
        Me.btnLiberar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLiberar.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLiberar.Appearance.Options.UseFont = True
        Me.btnLiberar.Location = New System.Drawing.Point(801, 533)
        Me.btnLiberar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLiberar.Name = "btnLiberar"
        Me.btnLiberar.Size = New System.Drawing.Size(172, 47)
        Me.btnLiberar.TabIndex = 10
        Me.btnLiberar.Text = "Liberar"
        '
        'btnActualizar
        '
        Me.btnActualizar.ImageOptions.Image = CType(resources.GetObject("btnActualizar.ImageOptions.Image"), System.Drawing.Image)
        Me.btnActualizar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnActualizar.Location = New System.Drawing.Point(439, 59)
        Me.btnActualizar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(45, 43)
        Me.btnActualizar.TabIndex = 3
        '
        'dtpFechaRecibe
        '
        Me.dtpFechaRecibe.EditValue = Nothing
        Me.dtpFechaRecibe.Location = New System.Drawing.Point(209, 302)
        Me.dtpFechaRecibe.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpFechaRecibe.Name = "dtpFechaRecibe"
        Me.dtpFechaRecibe.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaRecibe.Properties.Appearance.Options.UseFont = True
        Me.dtpFechaRecibe.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpFechaRecibe.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpFechaRecibe.Properties.DisplayFormat.FormatString = ""
        Me.dtpFechaRecibe.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtpFechaRecibe.Properties.EditFormat.FormatString = ""
        Me.dtpFechaRecibe.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtpFechaRecibe.Properties.MaskSettings.Set("mask", "")
        Me.dtpFechaRecibe.Size = New System.Drawing.Size(272, 30)
        Me.dtpFechaRecibe.TabIndex = 5
        '
        'txtFechaCrea
        '
        Me.txtFechaCrea.Enabled = False
        Me.txtFechaCrea.Location = New System.Drawing.Point(209, 193)
        Me.txtFechaCrea.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFechaCrea.Name = "txtFechaCrea"
        Me.txtFechaCrea.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaCrea.Properties.Appearance.Options.UseFont = True
        Me.txtFechaCrea.Properties.DisplayFormat.FormatString = "d"
        Me.txtFechaCrea.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txtFechaCrea.Properties.EditFormat.FormatString = "d"
        Me.txtFechaCrea.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txtFechaCrea.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.DateTimeMaskManager))
        Me.txtFechaCrea.Properties.MaskSettings.Set("mask", "yyyyMMdd")
        Me.txtFechaCrea.Size = New System.Drawing.Size(275, 30)
        Me.txtFechaCrea.TabIndex = 54
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.Location = New System.Drawing.Point(621, 533)
        Me.SimpleButton1.Margin = New System.Windows.Forms.Padding(4)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(172, 47)
        Me.SimpleButton1.TabIndex = 69
        Me.SimpleButton1.Text = "Liberar SAP"
        Me.SimpleButton1.Visible = False
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl8.Appearance.Options.UseFont = True
        Me.LabelControl8.Location = New System.Drawing.Point(11, 470)
        Me.LabelControl8.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(98, 24)
        Me.LabelControl8.TabIndex = 70
        Me.LabelControl8.Text = "Pedimento:"
        Me.LabelControl8.Visible = False
        '
        'txtPedimento
        '
        Me.txtPedimento.Location = New System.Drawing.Point(209, 466)
        Me.txtPedimento.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPedimento.Name = "txtPedimento"
        Me.txtPedimento.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPedimento.Properties.Appearance.Options.UseFont = True
        Me.txtPedimento.Size = New System.Drawing.Size(271, 30)
        Me.txtPedimento.TabIndex = 6
        Me.txtPedimento.Visible = False
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl9.Appearance.Options.UseFont = True
        Me.LabelControl9.Location = New System.Drawing.Point(11, 550)
        Me.LabelControl9.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(177, 24)
        Me.LabelControl9.TabIndex = 72
        Me.LabelControl9.Text = "Fecha de pedimento:"
        Me.LabelControl9.Visible = False
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl10.Appearance.Options.UseFont = True
        Me.LabelControl10.Location = New System.Drawing.Point(11, 509)
        Me.LabelControl10.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(148, 24)
        Me.LabelControl10.TabIndex = 74
        Me.LabelControl10.Text = "Clave pedimento:"
        Me.LabelControl10.Visible = False
        '
        'txtClavePedimento
        '
        Me.txtClavePedimento.Location = New System.Drawing.Point(209, 506)
        Me.txtClavePedimento.Margin = New System.Windows.Forms.Padding(4)
        Me.txtClavePedimento.Name = "txtClavePedimento"
        Me.txtClavePedimento.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClavePedimento.Properties.Appearance.Options.UseFont = True
        Me.txtClavePedimento.Size = New System.Drawing.Size(271, 30)
        Me.txtClavePedimento.TabIndex = 7
        Me.txtClavePedimento.Visible = False
        '
        'dtFechaPedimento
        '
        Me.dtFechaPedimento.EditValue = Nothing
        Me.dtFechaPedimento.Location = New System.Drawing.Point(209, 546)
        Me.dtFechaPedimento.Margin = New System.Windows.Forms.Padding(4)
        Me.dtFechaPedimento.Name = "dtFechaPedimento"
        Me.dtFechaPedimento.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtFechaPedimento.Properties.Appearance.Options.UseFont = True
        Me.dtFechaPedimento.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtFechaPedimento.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtFechaPedimento.Properties.DisplayFormat.FormatString = ""
        Me.dtFechaPedimento.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtFechaPedimento.Properties.EditFormat.FormatString = ""
        Me.dtFechaPedimento.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtFechaPedimento.Properties.MaskSettings.Set("mask", "")
        Me.dtFechaPedimento.Size = New System.Drawing.Size(271, 30)
        Me.dtFechaPedimento.TabIndex = 8
        Me.dtFechaPedimento.Visible = False
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Location = New System.Drawing.Point(11, 197)
        Me.LabelControl5.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(129, 24)
        Me.LabelControl5.TabIndex = 75
        Me.LabelControl5.Text = "Fecha creación:"
        '
        'LabelControl11
        '
        Me.LabelControl11.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl11.Appearance.Options.UseFont = True
        Me.LabelControl11.Location = New System.Drawing.Point(11, 346)
        Me.LabelControl11.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(158, 24)
        Me.LabelControl11.TabIndex = 77
        Me.LabelControl11.Text = "Texto de cabecera:"
        '
        'txtCabecera
        '
        Me.txtCabecera.Location = New System.Drawing.Point(209, 342)
        Me.txtCabecera.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCabecera.Name = "txtCabecera"
        Me.txtCabecera.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCabecera.Properties.Appearance.Options.UseFont = True
        Me.txtCabecera.Size = New System.Drawing.Size(271, 30)
        Me.txtCabecera.TabIndex = 76
        '
        'LabelControl12
        '
        Me.LabelControl12.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl12.Appearance.Options.UseFont = True
        Me.LabelControl12.Location = New System.Drawing.Point(11, 388)
        Me.LabelControl12.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(142, 24)
        Me.LabelControl12.TabIndex = 79
        Me.LabelControl12.Text = "Nota de entrega:"
        '
        'TxtNota
        '
        Me.TxtNota.Location = New System.Drawing.Point(209, 383)
        Me.TxtNota.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtNota.Name = "TxtNota"
        Me.TxtNota.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNota.Properties.Appearance.Options.UseFont = True
        Me.TxtNota.Size = New System.Drawing.Size(271, 30)
        Me.TxtNota.TabIndex = 78
        '
        'LabelControl13
        '
        Me.LabelControl13.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl13.Appearance.Options.UseFont = True
        Me.LabelControl13.Location = New System.Drawing.Point(11, 427)
        Me.LabelControl13.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(106, 24)
        Me.LabelControl13.TabIndex = 81
        Me.LabelControl13.Text = "Contenedor:"
        '
        'txtContenedor
        '
        Me.txtContenedor.Location = New System.Drawing.Point(209, 424)
        Me.txtContenedor.Margin = New System.Windows.Forms.Padding(4)
        Me.txtContenedor.Name = "txtContenedor"
        Me.txtContenedor.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContenedor.Properties.Appearance.Options.UseFont = True
        Me.txtContenedor.Size = New System.Drawing.Size(271, 30)
        Me.txtContenedor.TabIndex = 80
        '
        'FrmLiberaOrdenCompra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(989, 595)
        Me.Controls.Add(Me.LabelControl13)
        Me.Controls.Add(Me.txtContenedor)
        Me.Controls.Add(Me.LabelControl12)
        Me.Controls.Add(Me.TxtNota)
        Me.Controls.Add(Me.LabelControl11)
        Me.Controls.Add(Me.txtCabecera)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.dtFechaPedimento)
        Me.Controls.Add(Me.LabelControl10)
        Me.Controls.Add(Me.txtClavePedimento)
        Me.Controls.Add(Me.LabelControl9)
        Me.Controls.Add(Me.LabelControl8)
        Me.Controls.Add(Me.txtPedimento)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.btnLiberar)
        Me.Controls.Add(Me.dgvResultado)
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.txtReferencia)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.txtFactura)
        Me.Controls.Add(Me.SeparatorControl1)
        Me.Controls.Add(Me.txtOrdenCompra)
        Me.Controls.Add(Me.txtDireccionProv)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.txtIdProveedor)
        Me.Controls.Add(Me.txtFechaCrea)
        Me.Controls.Add(Me.dtpFechaRecibe)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.IconOptions.Image = Global.AXCVDE.My.Resources.Resources.Logo_X_150x150_01
        Me.IconOptions.LargeImage = CType(resources.GetObject("FrmLiberaOrdenCompra.IconOptions.LargeImage"), System.Drawing.Image)
        Me.LookAndFeel.SkinName = "The Bezier"
        Me.LookAndFeel.TouchUIMode = DevExpress.Utils.DefaultBoolean.[False]
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "FrmLiberaOrdenCompra"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Liberación de orden de compra nacional"
        CType(Me.SeparatorControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOrdenCompra.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDireccionProv.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIdProveedor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFactura.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtReferencia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvResultado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaRecibe.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaRecibe.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFechaCrea.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPedimento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtClavePedimento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFechaPedimento.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFechaPedimento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCabecera.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNota.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtContenedor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SeparatorControl1 As DevExpress.XtraEditors.SeparatorControl
    Friend WithEvents txtOrdenCompra As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDireccionProv As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnBuscar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtIdProveedor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtFactura As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtReferencia As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dgvResultado As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnLiberar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnActualizar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dtpFechaRecibe As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtFechaCrea As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPedimento As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtClavePedimento As DevExpress.XtraEditors.TextEdit
    Friend WithEvents dtFechaPedimento As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCabecera As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtNota As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtContenedor As DevExpress.XtraEditors.TextEdit
End Class
