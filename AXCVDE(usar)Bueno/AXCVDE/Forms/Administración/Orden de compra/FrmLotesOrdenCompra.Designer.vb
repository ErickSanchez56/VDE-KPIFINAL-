<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLotesOrdenCompra
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
        Me.dgvResultados = New DevExpress.XtraGrid.GridControl()
        Me.DgvViewResultados = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemDateEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.RepositoryItemTimeSpanEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTimeSpanEdit()
        Me.RepositoryItemTimeSpanEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTimeSpanEdit()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.btnEliminarLinea = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnAgregar = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnGuardar = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.dgvResultados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvViewResultados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit2.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTimeSpanEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTimeSpanEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvResultados
        '
        Me.dgvResultados.Location = New System.Drawing.Point(5, 30)
        Me.dgvResultados.MainView = Me.DgvViewResultados
        Me.dgvResultados.Name = "dgvResultados"
        Me.dgvResultados.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTimeSpanEdit1, Me.RepositoryItemTimeSpanEdit2, Me.RepositoryItemDateEdit1, Me.RepositoryItemDateEdit2})
        Me.dgvResultados.Size = New System.Drawing.Size(805, 296)
        Me.dgvResultados.TabIndex = 0
        Me.dgvResultados.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.DgvViewResultados})
        '
        'DgvViewResultados
        '
        Me.DgvViewResultados.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7})
        Me.DgvViewResultados.GridControl = Me.dgvResultados
        Me.DgvViewResultados.Name = "DgvViewResultados"
        Me.DgvViewResultados.OptionsFilter.AllowAutoFilterConditionChange = DevExpress.Utils.DefaultBoolean.[False]
        Me.DgvViewResultados.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Partida"
        Me.GridColumn1.FieldName = "Partida"
        Me.GridColumn1.Name = "GridColumn1"
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Producto"
        Me.GridColumn2.FieldName = "NumParte"
        Me.GridColumn2.Name = "GridColumn2"
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Lote de proveedor"
        Me.GridColumn3.FieldName = "LoteProveedor"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 0
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Cantidad"
        Me.GridColumn4.FieldName = "Cantidad"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 1
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Lote interno"
        Me.GridColumn5.FieldName = "LoteInterno"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 2
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Fecha de caducidad"
        Me.GridColumn6.ColumnEdit = Me.RepositoryItemDateEdit1
        Me.GridColumn6.FieldName = "FechaCaducidad"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 3
        '
        'RepositoryItemDateEdit1
        '
        Me.RepositoryItemDateEdit1.AutoHeight = False
        Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.CalendarTimeProperties.DisplayFormat.FormatString = "d"
        Me.RepositoryItemDateEdit1.CalendarTimeProperties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.RepositoryItemDateEdit1.EditFormat.FormatString = ""
        Me.RepositoryItemDateEdit1.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.RepositoryItemDateEdit1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.RepositoryItemDateEdit1.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Fecha de producción"
        Me.GridColumn7.ColumnEdit = Me.RepositoryItemDateEdit2
        Me.GridColumn7.FieldName = "FechaProd"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 4
        '
        'RepositoryItemDateEdit2
        '
        Me.RepositoryItemDateEdit2.AutoHeight = False
        Me.RepositoryItemDateEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit2.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit2.EditFormat.FormatString = ""
        Me.RepositoryItemDateEdit2.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.RepositoryItemDateEdit2.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.RepositoryItemDateEdit2.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemDateEdit2.Name = "RepositoryItemDateEdit2"
        '
        'RepositoryItemTimeSpanEdit1
        '
        Me.RepositoryItemTimeSpanEdit1.AutoHeight = False
        Me.RepositoryItemTimeSpanEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemTimeSpanEdit1.DisplayFormat.FormatString = "d"
        Me.RepositoryItemTimeSpanEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.RepositoryItemTimeSpanEdit1.EditFormat.FormatString = "d"
        Me.RepositoryItemTimeSpanEdit1.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.RepositoryItemTimeSpanEdit1.Name = "RepositoryItemTimeSpanEdit1"
        '
        'RepositoryItemTimeSpanEdit2
        '
        Me.RepositoryItemTimeSpanEdit2.AutoHeight = False
        Me.RepositoryItemTimeSpanEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemTimeSpanEdit2.DisplayFormat.FormatString = "d"
        Me.RepositoryItemTimeSpanEdit2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.RepositoryItemTimeSpanEdit2.EditFormat.FormatString = "d"
        Me.RepositoryItemTimeSpanEdit2.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.RepositoryItemTimeSpanEdit2.Name = "RepositoryItemTimeSpanEdit2"
        '
        'GroupControl1
        '
        Me.GroupControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl1.Controls.Add(Me.dgvResultados)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 12)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(815, 337)
        Me.GroupControl1.TabIndex = 1
        Me.GroupControl1.Text = "Lotes por partida"
        '
        'btnEliminarLinea
        '
        Me.btnEliminarLinea.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnEliminarLinea.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarLinea.Appearance.Options.UseFont = True
        Me.btnEliminarLinea.Location = New System.Drawing.Point(119, 355)
        Me.btnEliminarLinea.Name = "btnEliminarLinea"
        Me.btnEliminarLinea.Size = New System.Drawing.Size(101, 34)
        Me.btnEliminarLinea.TabIndex = 142
        Me.btnEliminarLinea.Text = "Eliminar línea"
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnAgregar.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAgregar.Appearance.Options.UseFont = True
        Me.BtnAgregar.Location = New System.Drawing.Point(12, 355)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(101, 34)
        Me.BtnAgregar.TabIndex = 143
        Me.BtnAgregar.Text = "Agregar línea"
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnGuardar.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardar.Appearance.Options.UseFont = True
        Me.BtnGuardar.Location = New System.Drawing.Point(726, 355)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(101, 34)
        Me.BtnGuardar.TabIndex = 144
        Me.BtnGuardar.Text = "Guardar lotes"
        '
        'FrmLotesOrdenCompra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(839, 401)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.BtnAgregar)
        Me.Controls.Add(Me.btnEliminarLinea)
        Me.Controls.Add(Me.GroupControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.IconOptions.Image = Global.AXCSchettino.My.Resources.Resources.Logo_X_150x150_01
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmLotesOrdenCompra"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lotes "
        CType(Me.dgvResultados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvViewResultados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit2.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTimeSpanEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTimeSpanEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvResultados As DevExpress.XtraGrid.GridControl
    Friend WithEvents DgvViewResultados As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTimeSpanEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTimeSpanEdit
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTimeSpanEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTimeSpanEdit
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents RepositoryItemDateEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents btnEliminarLinea As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnAgregar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnGuardar As DevExpress.XtraEditors.SimpleButton
End Class
