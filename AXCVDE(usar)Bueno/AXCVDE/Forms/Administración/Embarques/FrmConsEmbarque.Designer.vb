<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConsEmbarque
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmConsEmbarque))
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.BtnBuscar = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnActualizar = New DevExpress.XtraEditors.SimpleButton()
        Me.TxtBusqueda = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.dgvResultados = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LblPedidoVenta = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnNuevo = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnBuscarPedido = New DevExpress.XtraEditors.SimpleButton()
        Me.LblNumPedido = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl4 = New DevExpress.XtraEditors.GroupControl()
        Me.DgvPreviaPartidas = New DevExpress.XtraGrid.GridControl()
        Me.DgvViewPreviaPedidos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.BtnCancelaEmbarque = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.CmbEmbarque = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.GroupControl5 = New DevExpress.XtraEditors.GroupControl()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnLiberar = New DevExpress.XtraEditors.SimpleButton()
        Me.DgvTotalPedido = New DevExpress.XtraGrid.GridControl()
        Me.DgvViewTotalPedido = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.BtnElimina = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnAgregar = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.TxtBusqueda.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.dgvResultados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl4.SuspendLayout()
        CType(Me.DgvPreviaPartidas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvViewPreviaPedidos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CmbEmbarque.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl5.SuspendLayout()
        CType(Me.DgvTotalPedido, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvViewTotalPedido, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.Controls.Add(Me.BtnBuscar)
        Me.GroupControl1.Controls.Add(Me.BtnActualizar)
        Me.GroupControl1.Controls.Add(Me.TxtBusqueda)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 12)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(418, 93)
        Me.GroupControl1.TabIndex = 1
        Me.GroupControl1.Text = "Búsqueda"
        '
        'BtnBuscar
        '
        Me.BtnBuscar.ImageOptions.Image = CType(resources.GetObject("BtnBuscar.ImageOptions.Image"), System.Drawing.Image)
        Me.BtnBuscar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.BtnBuscar.Location = New System.Drawing.Point(309, 33)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(34, 35)
        Me.BtnBuscar.TabIndex = 101
        '
        'BtnActualizar
        '
        Me.BtnActualizar.ImageOptions.Image = CType(resources.GetObject("BtnActualizar.ImageOptions.Image"), System.Drawing.Image)
        Me.BtnActualizar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.BtnActualizar.Location = New System.Drawing.Point(349, 33)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(34, 35)
        Me.BtnActualizar.TabIndex = 100
        '
        'TxtBusqueda
        '
        Me.TxtBusqueda.Location = New System.Drawing.Point(88, 42)
        Me.TxtBusqueda.Name = "TxtBusqueda"
        Me.TxtBusqueda.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBusqueda.Properties.Appearance.Options.UseFont = True
        Me.TxtBusqueda.Size = New System.Drawing.Size(215, 26)
        Me.TxtBusqueda.TabIndex = 99
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(8, 43)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(74, 19)
        Me.LabelControl1.TabIndex = 98
        Me.LabelControl1.Text = "Embarque:"
        '
        'GroupControl2
        '
        Me.GroupControl2.AppearanceCaption.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl2.AppearanceCaption.Options.UseFont = True
        Me.GroupControl2.Controls.Add(Me.dgvResultados)
        Me.GroupControl2.Controls.Add(Me.LblPedidoVenta)
        Me.GroupControl2.Controls.Add(Me.LabelControl2)
        Me.GroupControl2.Location = New System.Drawing.Point(12, 111)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(418, 329)
        Me.GroupControl2.TabIndex = 102
        Me.GroupControl2.Text = "Partidas de documento seleccionado"
        '
        'dgvResultados
        '
        Me.dgvResultados.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.dgvResultados.Location = New System.Drawing.Point(8, 61)
        Me.dgvResultados.MainView = Me.GridView1
        Me.dgvResultados.Name = "dgvResultados"
        Me.dgvResultados.Size = New System.Drawing.Size(405, 263)
        Me.dgvResultados.TabIndex = 111
        Me.dgvResultados.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.GroupRow.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView1.Appearance.GroupRow.Options.UseFont = True
        Me.GridView1.Appearance.HeaderPanel.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView1.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridView1.Appearance.Row.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView1.Appearance.Row.Options.UseFont = True
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4})
        Me.GridView1.DetailHeight = 303
        Me.GridView1.GridControl = Me.dgvResultados
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Partida"
        Me.GridColumn1.FieldName = "Partida"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Producto"
        Me.GridColumn2.FieldName = "NumParte"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Cantidad pedida"
        Me.GridColumn3.FieldName = "CantidadPedida"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "UM"
        Me.GridColumn4.FieldName = "UnidadMedida"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 3
        '
        'LblPedidoVenta
        '
        Me.LblPedidoVenta.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPedidoVenta.Appearance.Options.UseFont = True
        Me.LblPedidoVenta.Location = New System.Drawing.Point(88, 30)
        Me.LblPedidoVenta.Name = "LblPedidoVenta"
        Me.LblPedidoVenta.Size = New System.Drawing.Size(0, 19)
        Me.LblPedidoVenta.TabIndex = 99
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(8, 30)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(74, 19)
        Me.LabelControl2.TabIndex = 98
        Me.LabelControl2.Text = "Embarque:"
        '
        'GroupControl3
        '
        Me.GroupControl3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl3.AppearanceCaption.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl3.AppearanceCaption.Options.UseFont = True
        Me.GroupControl3.Controls.Add(Me.SimpleButton2)
        Me.GroupControl3.Controls.Add(Me.BtnNuevo)
        Me.GroupControl3.Controls.Add(Me.BtnBuscarPedido)
        Me.GroupControl3.Controls.Add(Me.LblNumPedido)
        Me.GroupControl3.Controls.Add(Me.LabelControl4)
        Me.GroupControl3.Location = New System.Drawing.Point(476, 12)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(623, 93)
        Me.GroupControl3.TabIndex = 102
        Me.GroupControl3.Text = "Pedido consolidado"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton2.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton2.Appearance.Options.UseFont = True
        Me.SimpleButton2.Appearance.Options.UseTextOptions = True
        Me.SimpleButton2.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.SimpleButton2.Location = New System.Drawing.Point(218, 34)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(126, 40)
        Me.SimpleButton2.TabIndex = 118
        Me.SimpleButton2.Text = "Asignar Guías"
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnNuevo.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNuevo.Appearance.Options.UseFont = True
        Me.BtnNuevo.Appearance.Options.UseTextOptions = True
        Me.BtnNuevo.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.BtnNuevo.Location = New System.Drawing.Point(350, 33)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(126, 40)
        Me.BtnNuevo.TabIndex = 117
        Me.BtnNuevo.Text = "Nuevo pedido"
        '
        'BtnBuscarPedido
        '
        Me.BtnBuscarPedido.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnBuscarPedido.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuscarPedido.Appearance.Options.UseFont = True
        Me.BtnBuscarPedido.Appearance.Options.UseTextOptions = True
        Me.BtnBuscarPedido.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.BtnBuscarPedido.Location = New System.Drawing.Point(482, 33)
        Me.BtnBuscarPedido.Name = "BtnBuscarPedido"
        Me.BtnBuscarPedido.Size = New System.Drawing.Size(126, 40)
        Me.BtnBuscarPedido.TabIndex = 116
        Me.BtnBuscarPedido.Text = "Buscar pedido"
        '
        'LblNumPedido
        '
        Me.LblNumPedido.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNumPedido.Appearance.Options.UseFont = True
        Me.LblNumPedido.Location = New System.Drawing.Point(94, 33)
        Me.LblNumPedido.Name = "LblNumPedido"
        Me.LblNumPedido.Size = New System.Drawing.Size(0, 19)
        Me.LblNumPedido.TabIndex = 99
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(8, 33)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(80, 19)
        Me.LabelControl4.TabIndex = 98
        Me.LabelControl4.Text = "No. Pedido:"
        '
        'GroupControl4
        '
        Me.GroupControl4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl4.AppearanceCaption.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl4.AppearanceCaption.Options.UseFont = True
        Me.GroupControl4.Controls.Add(Me.DgvPreviaPartidas)
        Me.GroupControl4.Controls.Add(Me.BtnCancelaEmbarque)
        Me.GroupControl4.Controls.Add(Me.LabelControl3)
        Me.GroupControl4.Controls.Add(Me.CmbEmbarque)
        Me.GroupControl4.Location = New System.Drawing.Point(476, 111)
        Me.GroupControl4.Name = "GroupControl4"
        Me.GroupControl4.Size = New System.Drawing.Size(623, 329)
        Me.GroupControl4.TabIndex = 103
        Me.GroupControl4.Text = "Partidas seleccionadas de embarques"
        '
        'DgvPreviaPartidas
        '
        Me.DgvPreviaPartidas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvPreviaPartidas.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.DgvPreviaPartidas.Location = New System.Drawing.Point(8, 30)
        Me.DgvPreviaPartidas.MainView = Me.DgvViewPreviaPedidos
        Me.DgvPreviaPartidas.Name = "DgvPreviaPartidas"
        Me.DgvPreviaPartidas.Size = New System.Drawing.Size(610, 294)
        Me.DgvPreviaPartidas.TabIndex = 112
        Me.DgvPreviaPartidas.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.DgvViewPreviaPedidos})
        '
        'DgvViewPreviaPedidos
        '
        Me.DgvViewPreviaPedidos.Appearance.GroupRow.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvViewPreviaPedidos.Appearance.GroupRow.Options.UseFont = True
        Me.DgvViewPreviaPedidos.Appearance.HeaderPanel.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvViewPreviaPedidos.Appearance.HeaderPanel.Options.UseFont = True
        Me.DgvViewPreviaPedidos.Appearance.Row.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvViewPreviaPedidos.Appearance.Row.Options.UseFont = True
        Me.DgvViewPreviaPedidos.DetailHeight = 303
        Me.DgvViewPreviaPedidos.GridControl = Me.DgvPreviaPartidas
        Me.DgvViewPreviaPedidos.Name = "DgvViewPreviaPedidos"
        Me.DgvViewPreviaPedidos.OptionsBehavior.Editable = False
        Me.DgvViewPreviaPedidos.OptionsView.ShowGroupPanel = False
        '
        'BtnCancelaEmbarque
        '
        Me.BtnCancelaEmbarque.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelaEmbarque.Appearance.Options.UseFont = True
        Me.BtnCancelaEmbarque.Appearance.Options.UseTextOptions = True
        Me.BtnCancelaEmbarque.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.BtnCancelaEmbarque.Location = New System.Drawing.Point(648, 30)
        Me.BtnCancelaEmbarque.Name = "BtnCancelaEmbarque"
        Me.BtnCancelaEmbarque.Size = New System.Drawing.Size(115, 40)
        Me.BtnCancelaEmbarque.TabIndex = 119
        Me.BtnCancelaEmbarque.Text = "Cancelar embarque"
        Me.BtnCancelaEmbarque.Visible = False
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(256, 40)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(147, 15)
        Me.LabelControl3.TabIndex = 114
        Me.LabelControl3.Text = "Embarques consolidados:"
        Me.LabelControl3.Visible = False
        '
        'CmbEmbarque
        '
        Me.CmbEmbarque.Location = New System.Drawing.Point(409, 37)
        Me.CmbEmbarque.Name = "CmbEmbarque"
        Me.CmbEmbarque.Properties.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbEmbarque.Properties.Appearance.Options.UseFont = True
        Me.CmbEmbarque.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CmbEmbarque.Size = New System.Drawing.Size(233, 22)
        Me.CmbEmbarque.TabIndex = 113
        Me.CmbEmbarque.Visible = False
        '
        'GroupControl5
        '
        Me.GroupControl5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl5.AppearanceCaption.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl5.AppearanceCaption.Options.UseFont = True
        Me.GroupControl5.Controls.Add(Me.SimpleButton1)
        Me.GroupControl5.Controls.Add(Me.BtnLiberar)
        Me.GroupControl5.Controls.Add(Me.DgvTotalPedido)
        Me.GroupControl5.Location = New System.Drawing.Point(12, 446)
        Me.GroupControl5.Name = "GroupControl5"
        Me.GroupControl5.Size = New System.Drawing.Size(1087, 184)
        Me.GroupControl5.TabIndex = 104
        Me.GroupControl5.Text = "Resumen de pedido"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.Appearance.Options.UseTextOptions = True
        Me.SimpleButton1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.SimpleButton1.Location = New System.Drawing.Point(956, 136)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(126, 40)
        Me.SimpleButton1.TabIndex = 117
        Me.SimpleButton1.Text = "Cancelar pedido"
        '
        'BtnLiberar
        '
        Me.BtnLiberar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnLiberar.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLiberar.Appearance.Options.UseFont = True
        Me.BtnLiberar.Appearance.Options.UseTextOptions = True
        Me.BtnLiberar.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.BtnLiberar.Location = New System.Drawing.Point(956, 90)
        Me.BtnLiberar.Name = "BtnLiberar"
        Me.BtnLiberar.Size = New System.Drawing.Size(126, 40)
        Me.BtnLiberar.TabIndex = 116
        Me.BtnLiberar.Text = "Liberar pedido"
        '
        'DgvTotalPedido
        '
        Me.DgvTotalPedido.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvTotalPedido.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.DgvTotalPedido.Location = New System.Drawing.Point(8, 30)
        Me.DgvTotalPedido.MainView = Me.DgvViewTotalPedido
        Me.DgvTotalPedido.Name = "DgvTotalPedido"
        Me.DgvTotalPedido.Size = New System.Drawing.Size(925, 146)
        Me.DgvTotalPedido.TabIndex = 112
        Me.DgvTotalPedido.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.DgvViewTotalPedido})
        '
        'DgvViewTotalPedido
        '
        Me.DgvViewTotalPedido.Appearance.GroupRow.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvViewTotalPedido.Appearance.GroupRow.Options.UseFont = True
        Me.DgvViewTotalPedido.Appearance.HeaderPanel.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvViewTotalPedido.Appearance.HeaderPanel.Options.UseFont = True
        Me.DgvViewTotalPedido.Appearance.Row.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvViewTotalPedido.Appearance.Row.Options.UseFont = True
        Me.DgvViewTotalPedido.DetailHeight = 303
        Me.DgvViewTotalPedido.GridControl = Me.DgvTotalPedido
        Me.DgvViewTotalPedido.Name = "DgvViewTotalPedido"
        Me.DgvViewTotalPedido.OptionsBehavior.Editable = False
        Me.DgvViewTotalPedido.OptionsView.ShowGroupPanel = False
        '
        'BtnElimina
        '
        Me.BtnElimina.ImageOptions.Image = CType(resources.GetObject("BtnElimina.ImageOptions.Image"), System.Drawing.Image)
        Me.BtnElimina.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.BtnElimina.Location = New System.Drawing.Point(436, 297)
        Me.BtnElimina.Name = "BtnElimina"
        Me.BtnElimina.Size = New System.Drawing.Size(34, 35)
        Me.BtnElimina.TabIndex = 106
        '
        'BtnAgregar
        '
        Me.BtnAgregar.ImageOptions.Image = CType(resources.GetObject("BtnAgregar.ImageOptions.Image"), System.Drawing.Image)
        Me.BtnAgregar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.BtnAgregar.Location = New System.Drawing.Point(436, 237)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(34, 35)
        Me.BtnAgregar.TabIndex = 105
        '
        'FrmConsEmbarque
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1111, 642)
        Me.Controls.Add(Me.BtnElimina)
        Me.Controls.Add(Me.BtnAgregar)
        Me.Controls.Add(Me.GroupControl5)
        Me.Controls.Add(Me.GroupControl4)
        Me.Controls.Add(Me.GroupControl3)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.IconOptions.Image = Global.AXCVDE.My.Resources.Resources.Logo_X_150x150_01
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmConsEmbarque"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consolidación de embarques"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.TxtBusqueda.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.dgvResultados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        Me.GroupControl3.PerformLayout()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl4.ResumeLayout(False)
        Me.GroupControl4.PerformLayout()
        CType(Me.DgvPreviaPartidas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvViewPreviaPedidos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CmbEmbarque.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl5.ResumeLayout(False)
        CType(Me.DgvTotalPedido, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvViewTotalPedido, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents BtnBuscar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnActualizar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TxtBusqueda As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LblPedidoVenta As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dgvResultados As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LblNumPedido As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl4 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl5 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents DgvPreviaPartidas As DevExpress.XtraGrid.GridControl
    Friend WithEvents DgvViewPreviaPedidos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DgvTotalPedido As DevExpress.XtraGrid.GridControl
    Friend WithEvents DgvViewTotalPedido As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents BtnNuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnBuscarPedido As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnLiberar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnElimina As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnAgregar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BtnCancelaEmbarque As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents CmbEmbarque As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
End Class
