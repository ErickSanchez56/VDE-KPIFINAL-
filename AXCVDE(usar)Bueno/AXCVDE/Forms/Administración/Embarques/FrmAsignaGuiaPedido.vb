
Imports DevExpress.XtraEditors

Public Class FrmAsignaGuiaPedido
    Public pPedido As String = ""

    Private Sub FrmAsignaGuiaPedido_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            Dim TipoBus = New List(Of String)()
            TipoBus.Add("EXPRESS")
            TipoBus.Add("ESTAFETA")
            cmbPaqueteria.Properties.DataSource = TipoBus
            cmbPaqueteria.ItemIndex = 0
            ListaConsolidados(pPedido)

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ListaConsolidados(prmBusqueda As String)
        Try


            Dim pResultado As New CResultado
            Dim Cls As New clsConsEM



            Cursor.Current = Cursors.WaitCursor
            pResultado = Cls.ListaConsolidados(prmBusqueda, My.Settings.Estacion, DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                Return
            End If
            Dim dt As New DataTable
            Dim ds As New DataSet

            dt = pResultado.Tabla
            ds.Tables.Add(dt)

            dgvResultados.DataSource = dt
            GridView1.BestFitColumns()

            If Not String.IsNullOrEmpty(ds.Tables(0).Rows(0)("Guia").ToString) Then
                If ds.Tables(0).Rows(0)("Guia").ToString = "NA" Then
                    ChkCustomer.Checked = True
                Else
                    ChkCustomer.Checked = False
                    cmbPaqueteria.Text = ds.Tables(0).Rows(0)("Paqueteria").ToString
                End If
            Else
                ChkCustomer.Checked = False
                cmbPaqueteria.Text = ds.Tables(0).Rows(0)("Paqueteria").ToString
            End If



        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            If ChkCustomer.Checked Then
                If XtraMessageBox.Show("Al guardar seleccionado Customer Pickup no se asigna guía para validación. ¿Deseas guardar?", "Confirmación", MessageBoxButtons.YesNo) <> DialogResult.Yes Then
                    Return
                End If

                AsignarGuiaCustomer()

            Else


            End If

            If String.IsNullOrEmpty(cmbPaqueteria.Text) Then
                XtraMessageBox.Show("Seleccionar paquetería", "Información", MessageBoxButtons.OK)
                cmbPaqueteria.Select()
                Return
            End If

            If cmbPaqueteria.Text = "EXPRESS" Then

                For i As Integer = 0 To GridView1.RowCount - 1
                    Dim Guia As String = GridView1.GetRowCellValue(i, "Guía")

                    If String.IsNullOrEmpty(Guia) Then
                        XtraMessageBox.Show("Todos los pedidos deben de tener una guía asignada", "Información", MessageBoxButtons.OK)
                        Return
                    End If

                Next

            Else

                For i As Integer = 0 To GridView1.RowCount - 1
                    Dim Guia As String = GridView1.GetRowCellValue(i, "Guía")

                    If Not String.IsNullOrEmpty(Guia) Then
                        XtraMessageBox.Show("Para esta paquetería no es necesario ingresar un Guía, ya que estas seran asignadas en la validación.", "Información", MessageBoxButtons.OK)
                        Return
                    End If

                Next

                If XtraMessageBox.Show("¿Al guardar seleccionado Paquetería ESTAFETA, en la validación tendrás que asignar las guías correspondientes a cada empaque.", "Confirmación", MessageBoxButtons.YesNo) <> DialogResult.Yes Then
                    Return
                End If

                If XtraMessageBox.Show("¿Guardar las guías asignadas a los pedidos? Si ya tenian una guía asignada será actualizada.", "Confirmación", MessageBoxButtons.YesNo) <> DialogResult.Yes Then
                    Return
                End If

                AsignarGuia()
            End If

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub AsignarGuia()
        Try
            Dim pResultado As New CResultado
            Dim Cls As New clsConsEM

            Dim ds As New DataSet
            Dim dt As New DataTable
            dt = TryCast(dgvResultados.DataSource, DataTable)

            Cursor.Current = Cursors.WaitCursor
            pResultado = Cls.AsignarGuia(pPedido, dt.DataSet.GetXml, cmbPaqueteria.Text, My.Settings.Estacion, DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                Return
            End If

            XtraMessageBox.Show("Guías asignadas con éxito")
            ListaConsolidados(pPedido)

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub AsignarGuiaCustomer()
        Try
            Dim pResultado As New CResultado
            Dim Cls As New clsConsEM

            Dim ds As New DataSet
            Dim dt As New DataTable
            dt = TryCast(dgvResultados.DataSource, DataTable)

            Cursor.Current = Cursors.WaitCursor
            pResultado = Cls.AsignarGuiaCustomer(pPedido, dt.DataSet.GetXml, cmbPaqueteria.Text, My.Settings.Estacion, DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                Return
            End If

            XtraMessageBox.Show("Guías asignadas con éxito")
            ListaConsolidados(pPedido)

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub FrmAsignaGuiaPedido_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Try

            Me.Dispose()
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ChkCustomer_CheckedChanged(sender As Object, e As EventArgs) Handles ChkCustomer.CheckedChanged
        If ChkCustomer.Checked Then
            cmbPaqueteria.Enabled = False
            dgvResultados.Enabled = False
        Else
            cmbPaqueteria.Enabled = True
            dgvResultados.Enabled = True
        End If
    End Sub
End Class