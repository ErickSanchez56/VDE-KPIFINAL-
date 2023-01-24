<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmTraspasoSalidaPT
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTraspasoSalidaPT))
        Me.btnActualizar = New DevExpress.XtraEditors.SimpleButton()
        Me.txtTraspasoSalida = New DevExpress.XtraEditors.TextEdit()
        Me.btnBuscaFolio = New DevExpress.XtraEditors.SimpleButton()
        Me.btnGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.grdPartidasTraspaso = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.CmbTipoLib = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.ChkEstacion = New DevExpress.XtraEditors.CheckEdit()
        Me.CmbEstacion = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        CType(Me.txtTraspasoSalida.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdPartidasTraspaso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CmbTipoLib.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChkEstacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CmbEstacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnActualizar
        '
        Me.btnActualizar.ImageOptions.Image = CType(resources.GetObject("btnActualizar.ImageOptions.Image"), System.Drawing.Image)
        Me.btnActualizar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnActualizar.Location = New System.Drawing.Point(308, 37)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(28, 30)
        Me.btnActualizar.TabIndex = 112
        '
        'txtTraspasoSalida
        '
        Me.txtTraspasoSalida.Location = New System.Drawing.Point(97, 42)
        Me.txtTraspasoSalida.Name = "txtTraspasoSalida"
        Me.txtTraspasoSalida.Size = New System.Drawing.Size(167, 20)
        Me.txtTraspasoSalida.TabIndex = 102
        '
        'btnBuscaFolio
        '
        Me.btnBuscaFolio.ImageOptions.Image = CType(resources.GetObject("btnBuscaFolio.ImageOptions.Image"), System.Drawing.Image)
        Me.btnBuscaFolio.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnBuscaFolio.Location = New System.Drawing.Point(270, 37)
        Me.btnBuscaFolio.Name = "btnBuscaFolio"
        Me.btnBuscaFolio.Size = New System.Drawing.Size(30, 30)
        Me.btnBuscaFolio.TabIndex = 103
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnGuardar.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Appearance.Options.UseFont = True
        Me.btnGuardar.Appearance.Options.UseTextOptions = True
        Me.btnGuardar.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnGuardar.Location = New System.Drawing.Point(922, 454)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(101, 34)
        Me.btnGuardar.TabIndex = 135
        Me.btnGuardar.Text = "Liberar"
        '
        'grdPartidasTraspaso
        '
        Me.grdPartidasTraspaso.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdPartidasTraspaso.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.grdPartidasTraspaso.Location = New System.Drawing.Point(18, 147)
        Me.grdPartidasTraspaso.MainView = Me.GridView1
        Me.grdPartidasTraspaso.Name = "grdPartidasTraspaso"
        Me.grdPartidasTraspaso.Size = New System.Drawing.Size(1005, 300)
        Me.grdPartidasTraspaso.TabIndex = 133
        Me.grdPartidasTraspaso.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.DetailHeight = 303
        Me.GridView1.GridControl = Me.grdPartidasTraspaso
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsPrint.AutoWidth = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Location = New System.Drawing.Point(334, 86)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(130, 19)
        Me.LabelControl5.TabIndex = 178
        Me.LabelControl5.Text = "Tipo de Liberación:"
        '
        'CmbTipoLib
        '
        Me.CmbTipoLib.Location = New System.Drawing.Point(470, 83)
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
        Me.CmbTipoLib.TabIndex = 177
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(19, 86)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(61, 19)
        Me.LabelControl3.TabIndex = 176
        Me.LabelControl3.Text = "Estación:"
        '
        'ChkEstacion
        '
        Me.ChkEstacion.EditValue = True
        Me.ChkEstacion.Location = New System.Drawing.Point(19, 84)
        Me.ChkEstacion.Name = "ChkEstacion"
        Me.ChkEstacion.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkEstacion.Properties.Appearance.Options.UseFont = True
        Me.ChkEstacion.Properties.Caption = "Cargar todo a:"
        Me.ChkEstacion.Size = New System.Drawing.Size(104, 23)
        Me.ChkEstacion.TabIndex = 174
        Me.ChkEstacion.Visible = False
        '
        'CmbEstacion
        '
        Me.CmbEstacion.Location = New System.Drawing.Point(97, 83)
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
        Me.CmbEstacion.Size = New System.Drawing.Size(167, 26)
        Me.CmbEstacion.TabIndex = 175
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(19, 41)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(64, 19)
        Me.LabelControl1.TabIndex = 179
        Me.LabelControl1.Text = "Traspaso:"
        '
        'GroupControl1
        '
        Me.GroupControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.btnBuscaFolio)
        Me.GroupControl1.Controls.Add(Me.LabelControl5)
        Me.GroupControl1.Controls.Add(Me.txtTraspasoSalida)
        Me.GroupControl1.Controls.Add(Me.CmbTipoLib)
        Me.GroupControl1.Controls.Add(Me.btnActualizar)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.CmbEstacion)
        Me.GroupControl1.Controls.Add(Me.ChkEstacion)
        Me.GroupControl1.Location = New System.Drawing.Point(18, 12)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(1005, 129)
        Me.GroupControl1.TabIndex = 181
        Me.GroupControl1.Text = "Seleccionar Traspaso "
        '
        'FrmTraspasoSalidaPT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1046, 500)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.grdPartidasTraspaso)
        Me.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Glow
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.IconOptions.Icon = CType(resources.GetObject("FrmTraspasoSalidaPT.IconOptions.Icon"), System.Drawing.Icon)
        Me.IconOptions.Image = Global.AXCVDE.My.Resources.Resources.Logo_X_150x150_01
        Me.LookAndFeel.TouchUIMode = DevExpress.Utils.DefaultBoolean.[False]
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmTraspasoSalidaPT"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Liberación de transferencias"
        CType(Me.txtTraspasoSalida.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdPartidasTraspaso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CmbTipoLib.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChkEstacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CmbEstacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnActualizar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtTraspasoSalida As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnBuscaFolio As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents grdPartidasTraspaso As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents CmbTipoLib As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ChkEstacion As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents CmbEstacion As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
End Class
