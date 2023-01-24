<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUsuarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmUsuarios))
        Me.BtnGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnEliminar = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnEditar = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.TxtUsuario = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.TxtNombre = New DevExpress.XtraEditors.TextEdit()
        Me.BtnNuevo = New DevExpress.XtraEditors.SimpleButton()
        Me.TxtBusqueda = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.DgvResultado = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.IdUsuario = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Usuario = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BtnBuscar = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnActualizar = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.TxtConfirmContrasena = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.TxtContrasena = New DevExpress.XtraEditors.TextEdit()
        Me.SeparatorControl1 = New DevExpress.XtraEditors.SeparatorControl()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.CmbHabilitado = New DevExpress.XtraEditors.LookUpEdit()
        CType(Me.TxtUsuario.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNombre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtBusqueda.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvResultado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtConfirmContrasena.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtContrasena.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeparatorControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CmbHabilitado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardar.Appearance.Options.UseFont = True
        Me.BtnGuardar.Location = New System.Drawing.Point(614, 281)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(81, 34)
        Me.BtnGuardar.TabIndex = 10
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.Visible = False
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.Appearance.Options.UseFont = True
        Me.BtnCancelar.Location = New System.Drawing.Point(875, 281)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(81, 34)
        Me.BtnCancelar.TabIndex = 13
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.Visible = False
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminar.Appearance.Options.UseFont = True
        Me.BtnEliminar.Location = New System.Drawing.Point(788, 281)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(81, 34)
        Me.BtnEliminar.TabIndex = 12
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.Visible = False
        '
        'BtnEditar
        '
        Me.BtnEditar.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEditar.Appearance.Options.UseFont = True
        Me.BtnEditar.Location = New System.Drawing.Point(701, 281)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(81, 34)
        Me.BtnEditar.TabIndex = 11
        Me.BtnEditar.Text = "Editar"
        Me.BtnEditar.Visible = False
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(559, 116)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(56, 19)
        Me.LabelControl3.TabIndex = 129
        Me.LabelControl3.Text = "Usuario:"
        '
        'TxtUsuario
        '
        Me.TxtUsuario.EditValue = ""
        Me.TxtUsuario.Enabled = False
        Me.TxtUsuario.Location = New System.Drawing.Point(621, 113)
        Me.TxtUsuario.Name = "TxtUsuario"
        Me.TxtUsuario.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUsuario.Properties.Appearance.Options.UseFont = True
        Me.TxtUsuario.Size = New System.Drawing.Size(335, 26)
        Me.TxtUsuario.TabIndex = 6
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(555, 77)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(60, 19)
        Me.LabelControl2.TabIndex = 127
        Me.LabelControl2.Text = "Nombre:"
        '
        'TxtNombre
        '
        Me.TxtNombre.Enabled = False
        Me.TxtNombre.Location = New System.Drawing.Point(621, 74)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombre.Properties.Appearance.Options.UseFont = True
        Me.TxtNombre.Size = New System.Drawing.Size(335, 26)
        Me.TxtNombre.TabIndex = 5
        '
        'BtnNuevo
        '
        Me.BtnNuevo.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.BtnNuevo.ImageOptions.SvgImage = CType(resources.GetObject("BtnNuevo.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.BtnNuevo.Location = New System.Drawing.Point(402, 10)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(34, 35)
        Me.BtnNuevo.TabIndex = 4
        '
        'TxtBusqueda
        '
        Me.TxtBusqueda.Location = New System.Drawing.Point(85, 14)
        Me.TxtBusqueda.Name = "TxtBusqueda"
        Me.TxtBusqueda.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBusqueda.Properties.Appearance.Options.UseFont = True
        Me.TxtBusqueda.Size = New System.Drawing.Size(231, 26)
        Me.TxtBusqueda.TabIndex = 1
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(23, 16)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(56, 19)
        Me.LabelControl1.TabIndex = 122
        Me.LabelControl1.Text = "Usuario:"
        '
        'DgvResultado
        '
        Me.DgvResultado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DgvResultado.Location = New System.Drawing.Point(23, 51)
        Me.DgvResultado.MainView = Me.GridView1
        Me.DgvResultado.Name = "DgvResultado"
        Me.DgvResultado.Size = New System.Drawing.Size(480, 445)
        Me.DgvResultado.TabIndex = 121
        Me.DgvResultado.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.GroupRow.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView1.Appearance.GroupRow.Options.UseFont = True
        Me.GridView1.Appearance.HeaderPanel.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView1.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridView1.Appearance.Row.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView1.Appearance.Row.Options.UseFont = True
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.IdUsuario, Me.Usuario, Me.GridColumn2, Me.GridColumn1})
        Me.GridView1.GridControl = Me.DgvResultado
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'IdUsuario
        '
        Me.IdUsuario.Caption = "Id"
        Me.IdUsuario.FieldName = "IdUsuario"
        Me.IdUsuario.Name = "IdUsuario"
        '
        'Usuario
        '
        Me.Usuario.Caption = "Usuario"
        Me.Usuario.FieldName = "Usuario"
        Me.Usuario.Name = "Usuario"
        Me.Usuario.Visible = True
        Me.Usuario.VisibleIndex = 0
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Nombre"
        Me.GridColumn2.FieldName = "Nombre"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Activo"
        Me.GridColumn1.FieldName = "Activo"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 2
        '
        'BtnBuscar
        '
        Me.BtnBuscar.ImageOptions.Image = CType(resources.GetObject("BtnBuscar.ImageOptions.Image"), System.Drawing.Image)
        Me.BtnBuscar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.BtnBuscar.Location = New System.Drawing.Point(322, 10)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(34, 35)
        Me.BtnBuscar.TabIndex = 2
        '
        'BtnActualizar
        '
        Me.BtnActualizar.ImageOptions.Image = CType(resources.GetObject("BtnActualizar.ImageOptions.Image"), System.Drawing.Image)
        Me.BtnActualizar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.BtnActualizar.Location = New System.Drawing.Point(362, 10)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(34, 35)
        Me.BtnActualizar.TabIndex = 3
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Location = New System.Drawing.Point(535, 211)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(80, 38)
        Me.LabelControl5.TabIndex = 142
        Me.LabelControl5.Text = "Confirmar " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "contraseña:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'TxtConfirmContrasena
        '
        Me.TxtConfirmContrasena.Enabled = False
        Me.TxtConfirmContrasena.Location = New System.Drawing.Point(621, 223)
        Me.TxtConfirmContrasena.Name = "TxtConfirmContrasena"
        Me.TxtConfirmContrasena.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtConfirmContrasena.Properties.Appearance.Options.UseFont = True
        Me.TxtConfirmContrasena.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtConfirmContrasena.Size = New System.Drawing.Size(335, 26)
        Me.TxtConfirmContrasena.TabIndex = 9
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Appearance.Options.UseFont = True
        Me.LabelControl6.Location = New System.Drawing.Point(534, 189)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(81, 19)
        Me.LabelControl6.TabIndex = 140
        Me.LabelControl6.Text = "Contraseña:"
        '
        'TxtContrasena
        '
        Me.TxtContrasena.Enabled = False
        Me.TxtContrasena.Location = New System.Drawing.Point(621, 186)
        Me.TxtContrasena.Name = "TxtContrasena"
        Me.TxtContrasena.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtContrasena.Properties.Appearance.Options.UseFont = True
        Me.TxtContrasena.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtContrasena.Size = New System.Drawing.Size(335, 26)
        Me.TxtContrasena.TabIndex = 8
        '
        'SeparatorControl1
        '
        Me.SeparatorControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SeparatorControl1.AutoSizeMode = True
        Me.SeparatorControl1.LineAlignment = DevExpress.XtraEditors.Alignment.Center
        Me.SeparatorControl1.LineOrientation = System.Windows.Forms.Orientation.Vertical
        Me.SeparatorControl1.Location = New System.Drawing.Point(509, -3)
        Me.SeparatorControl1.Name = "SeparatorControl1"
        Me.SeparatorControl1.Padding = New System.Windows.Forms.Padding(8)
        Me.SeparatorControl1.Size = New System.Drawing.Size(17, 512)
        Me.SeparatorControl1.TabIndex = 144
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl10.Appearance.Options.UseFont = True
        Me.LabelControl10.Location = New System.Drawing.Point(540, 152)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(75, 19)
        Me.LabelControl10.TabIndex = 145
        Me.LabelControl10.Text = "Habilitado:"
        '
        'CmbHabilitado
        '
        Me.CmbHabilitado.Enabled = False
        Me.CmbHabilitado.Location = New System.Drawing.Point(621, 149)
        Me.CmbHabilitado.Name = "CmbHabilitado"
        Me.CmbHabilitado.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbHabilitado.Properties.Appearance.Options.UseFont = True
        Me.CmbHabilitado.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CmbHabilitado.Properties.DropDownRows = 3
        Me.CmbHabilitado.Properties.NullText = ""
        Me.CmbHabilitado.Properties.PopupSizeable = False
        Me.CmbHabilitado.Size = New System.Drawing.Size(86, 26)
        Me.CmbHabilitado.TabIndex = 7
        '
        'FrmUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1006, 508)
        Me.Controls.Add(Me.LabelControl10)
        Me.Controls.Add(Me.CmbHabilitado)
        Me.Controls.Add(Me.SeparatorControl1)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.TxtConfirmContrasena)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.TxtContrasena)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnEditar)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.TxtUsuario)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.BtnActualizar)
        Me.Controls.Add(Me.TxtBusqueda)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.DgvResultado)
        Me.IconOptions.Image = Global.AXCVDE.My.Resources.Resources.Logo_X_150x150_01
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmUsuarios"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cátalogo de usuarios"
        CType(Me.TxtUsuario.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNombre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtBusqueda.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvResultado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtConfirmContrasena.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtContrasena.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeparatorControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CmbHabilitado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnEliminar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnEditar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtUsuario As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtNombre As DevExpress.XtraEditors.TextEdit
    Friend WithEvents BtnBuscar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnNuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnActualizar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TxtBusqueda As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DgvResultado As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtConfirmContrasena As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtContrasena As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SeparatorControl1 As DevExpress.XtraEditors.SeparatorControl
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents CmbHabilitado As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents IdUsuario As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Usuario As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
End Class
