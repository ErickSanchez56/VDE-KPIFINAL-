<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmModifcaPartidaEvento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmModifcaPartidaEvento))
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCantidad = New DevExpress.XtraEditors.TextEdit()
        Me.cmbNumParte = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.NumParte = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DNumParte1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnAceptar = New DevExpress.XtraEditors.SimpleButton()
        Me.txtDescripcion = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.txtCantidad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbNumParte.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescripcion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(51, 26)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(40, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Artículo:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(51, 78)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(47, 13)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = "Cantidad:"
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(118, 75)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(72, 20)
        Me.txtCantidad.TabIndex = 3
        '
        'cmbNumParte
        '
        Me.cmbNumParte.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbNumParte.Location = New System.Drawing.Point(118, 23)
        Me.cmbNumParte.Name = "cmbNumParte"
        Me.cmbNumParte.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbNumParte.Properties.NullText = ""
        Me.cmbNumParte.Properties.PopupSizeable = False
        Me.cmbNumParte.Properties.PopupView = Me.GridLookUpEdit1View
        Me.cmbNumParte.Size = New System.Drawing.Size(269, 20)
        Me.cmbNumParte.TabIndex = 128
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
        'btnAceptar
        '
        Me.btnAceptar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnAceptar.Location = New System.Drawing.Point(183, 105)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(101, 34)
        Me.btnAceptar.TabIndex = 129
        Me.btnAceptar.Text = "Aceptar"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Enabled = False
        Me.txtDescripcion.Location = New System.Drawing.Point(118, 49)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(269, 20)
        Me.txtDescripcion.TabIndex = 131
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(51, 52)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(58, 13)
        Me.LabelControl3.TabIndex = 130
        Me.LabelControl3.Text = "Descripción:"
        '
        'FrmModifcaPartidaEvento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(463, 151)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.cmbNumParte)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.IconOptions.Icon = CType(resources.GetObject("FrmModifcaPartidaEvento.IconOptions.Icon"), System.Drawing.Icon)
        Me.IconOptions.Image = Global.AXCVDE.My.Resources.Resources.Logo_X_150x150_01
        Me.LookAndFeel.TouchUIMode = DevExpress.Utils.DefaultBoolean.[False]
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmModifcaPartidaEvento"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modificar partida"
        CType(Me.txtCantidad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbNumParte.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescripcion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCantidad As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmbNumParte As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents NumParte As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DNumParte1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtDescripcion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
End Class
