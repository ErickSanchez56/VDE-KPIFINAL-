Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Base

Public Class FrmPermisos

#Region "VARIABLES"
    Public pGrupo As String = ""
    Public pGrupoSeleccionado As String = ""
#End Region


#Region "EVENTOS"

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Try
            Dim pBusqueda As String
            If String.IsNullOrEmpty(TxtBusqueda.Text) Then
                pBusqueda = "@"
            Else
                pBusqueda = TxtBusqueda.Text
            End If
            ResultadoLista(pBusqueda)
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub TxtBusqueda_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtBusqueda.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            Dim pBusqueda As String = "@"


            If String.IsNullOrEmpty(TxtBusqueda.Text.Trim()) Then
                pBusqueda = "@"
            Else
                pBusqueda = TxtBusqueda.Text
            End If

            ResultadoLista(pBusqueda)
        End If
    End Sub

    Private Sub DgvResultadoGrupos_Click(sender As Object, e As EventArgs) Handles DgvResultadoGrupos.Click
        Try
            Dim view As ColumnView = CType(DgvResultadoGrupos.MainView, ColumnView)
            Dim selectedRowHandles As Integer() = view.GetSelectedRows()



            pGrupo = view.GetRowCellDisplayText(selectedRowHandles(0), view.Columns("Grupo"))

            LblGrupoSeleccionado.Text = pGrupo
            LlenarUsuariosExcluidos(pGrupo)
            LlenarUsuariosIncluidos(pGrupo)
            LlenarTransaccionesIncluidas(pGrupo)
            LlenarTransaccionesExcluidas(pGrupo)


        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

#End Region

#Region "METODOS"
    Private Sub ResultadoLista(prmBusqueda As String)
        Try
            DgvResultadoGrupos.DataSource = Nothing

            Dim pResultado As New CResultado
            Dim Cls As New clsUsuario

            Cursor.Current = Cursors.WaitCursor
            pResultado = Cls.ResultadoListaGrupos(prmBusqueda, My.Settings.Estacion, DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                DgvResultadoGrupos.DataSource = Nothing
                Return
            End If
            Dim dt As New DataTable
            Dim ds As New DataSet

            dt = pResultado.Tabla
            ds.Tables.Add(dt)

            If dt.Rows.Count < 1 Then
                XtraMessageBox.Show("Sin información")
                DgvResultadoGrupos.DataSource = Nothing
                Return
            End If

            DgvResultadoGrupos.DataSource = dt

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub LlenarUsuariosExcluidos(prmBusqueda As String)
        Try
            DgvExcluidaUs.DataSource = Nothing

            Dim pResultado As New CResultado
            Dim Cls As New clsUsuario

            Cursor.Current = Cursors.WaitCursor
            pResultado = Cls.ListaUsuariosExcluidos(prmBusqueda, My.Settings.Estacion, DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                DgvExcluidaUs.DataSource = Nothing
                Return
            End If
            Dim dt As New DataTable
            Dim ds As New DataSet

            dt = pResultado.Tabla
            ds.Tables.Add(dt)

            DgvExcluidaUs.DataSource = dt

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub LlenarUsuariosIncluidos(prmBusqueda As String)
        Try
            DgvIncluidaUs.DataSource = Nothing

            Dim pResultado As New CResultado
            Dim Cls As New clsUsuario

            Cursor.Current = Cursors.WaitCursor
            pResultado = Cls.ListaUsuariosIncluidos(prmBusqueda, My.Settings.Estacion, DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                DgvIncluidaUs.DataSource = Nothing
                Return
            End If
            Dim dt As New DataTable
            Dim ds As New DataSet

            dt = pResultado.Tabla
            ds.Tables.Add(dt)


            DgvIncluidaUs.DataSource = dt

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub LlenarTransaccionesIncluidas(prmBusqueda As String)
        Try
            DgvIncluida.DataSource = Nothing

            Dim pResultado As New CResultado
            Dim Cls As New clsUsuario

            Cursor.Current = Cursors.WaitCursor
            pResultado = Cls.ListaTransaccionesIncluidas(prmBusqueda, My.Settings.Estacion, DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                DgvIncluida.DataSource = Nothing
                Return
            End If
            Dim dt As New DataTable
            Dim ds As New DataSet

            dt = pResultado.Tabla
            ds.Tables.Add(dt)


            DgvIncluida.DataSource = dt
            DgvViewIncluidaTr.BestFitColumns()

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub LlenarTransaccionesExcluidas(prmBusqueda As String)
        Try
            DgvExcluida.DataSource = Nothing

            Dim pResultado As New CResultado
            Dim Cls As New clsUsuario

            Cursor.Current = Cursors.WaitCursor
            pResultado = Cls.ListaTransaccionesExcluida(prmBusqueda, My.Settings.Estacion, DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                DgvExcluida.DataSource = Nothing
                Return
            End If
            Dim dt As New DataTable
            Dim ds As New DataSet

            dt = pResultado.Tabla
            ds.Tables.Add(dt)


            DgvExcluida.DataSource = dt
            DgvViewExcluidaTr.BestFitColumns()


        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub AsignarUsuario()
        Try
            Dim pResultado As New CResultado
            Dim Cls As New clsUsuario

            Dim view As ColumnView = CType(DgvExcluidaUs.MainView, ColumnView)
            Dim selectedRowHandles As Integer() = view.GetSelectedRows()


            For i As Integer = 0 To selectedRowHandles.Count - 1

                pResultado = Cls.AsignarUsuariosPorGrupo(pGrupo, view.GetRowCellDisplayText(selectedRowHandles(i), view.Columns("Usuario")),
                                                                  My.Settings.Estacion, DatosTemporales.Usuario)
            Next

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                Return
            End If

            XtraMessageBox.Show("Usuarios asignados exitosamente")
            LlenarUsuariosIncluidos(pGrupo)
            LlenarUsuariosExcluidos(pGrupo)
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub DesasignarUsuario()
        Try
            Dim pResultado As New CResultado
            Dim Cls As New clsUsuario

            Dim view As ColumnView = CType(DgvIncluidaUs.MainView, ColumnView)
            Dim selectedRowHandles As Integer() = view.GetSelectedRows()


            For i As Integer = 0 To selectedRowHandles.Count - 1

                pResultado = Cls.DesasignarUsuarioPorGrupo(pGrupo, view.GetRowCellDisplayText(selectedRowHandles(i), view.Columns("Usuario")), My.Settings.Estacion, DatosTemporales.Usuario)
            Next

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                Return
            End If

            XtraMessageBox.Show("Usuarios desasignados exitosamente")
            LlenarUsuariosIncluidos(pGrupo)
            LlenarUsuariosExcluidos(pGrupo)
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub AsignarTransaccion()
        Try
            Dim pResultado As New CResultado
            Dim Cls As New clsUsuario

            Dim view As ColumnView = CType(DgvExcluida.MainView, ColumnView)
            Dim selectedRowHandles As Integer() = view.GetSelectedRows()


            For i As Integer = 0 To selectedRowHandles.Count - 1

                pResultado = Cls.AsignarTransaccionPorGrupo(pGrupo,
                                                            view.GetRowCellDisplayText(selectedRowHandles(i), view.Columns("Transaccion")),
                                                                  My.Settings.Estacion, DatosTemporales.Usuario)
            Next

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                Return
            End If

            XtraMessageBox.Show("Transacciones asignadas exitosamente")
            LlenarTransaccionesIncluidas(pGrupo)
            LlenarTransaccionesExcluidas(pGrupo)
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub DesasignarTransaccion()
        Try
            Dim pResultado As New CResultado
            Dim Cls As New clsUsuario

            Dim view As ColumnView = CType(DgvIncluida.MainView, ColumnView)
            Dim selectedRowHandles As Integer() = view.GetSelectedRows()


            For i As Integer = 0 To selectedRowHandles.Count - 1

                pResultado = Cls.DesasignarTransaccionPorGrupo(pGrupo, view.GetRowCellDisplayText(selectedRowHandles(i), view.Columns("Transaccion")), My.Settings.Estacion, DatosTemporales.Usuario)
            Next

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                Return
            End If

            XtraMessageBox.Show("Transacciones desasignadas exitosamente")
            LlenarTransaccionesIncluidas(pGrupo)
            LlenarTransaccionesExcluidas(pGrupo)
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnAgregarUsuario_Click(sender As Object, e As EventArgs) Handles BtnAgregarUsuario.Click
        Try
            If XtraMessageBox.Show("Agregar usuarios al grupo " + LblGrupoSeleccionado.Text + "?", "Confirmación", MessageBoxButtons.YesNo) <> DialogResult.Yes Then
                Return
            End If

            If DgvViewExcluidaUs.RowCount <= 0 Then
                XtraMessageBox.Show("No hay datos para asignar")
                Return
            End If

            Dim view As ColumnView = CType(DgvExcluidaUs.MainView, ColumnView)
            Dim selectedRowHandles As Integer() = view.GetSelectedRows()


            For i As Integer = 0 To selectedRowHandles.Count - 1
                If String.IsNullOrEmpty(view.GetRowCellDisplayText(selectedRowHandles(i), view.Columns("Usuario")).ToString) Then
                    MsgBox("El valor de la columna [Usuario] no puede estar vacío")
                    Return
                End If
            Next

            Cursor.Current = Cursors.WaitCursor

            AsignarUsuario()

            Cursor.Current = Cursors.Default

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnEliminarUsuario_Click(sender As Object, e As EventArgs) Handles BtnEliminarUsuario.Click
        Try
            If XtraMessageBox.Show("eliminar Usuarios del grupo " + LblGrupoSeleccionado.Text + "?", "Confirmación", MessageBoxButtons.YesNo) <> DialogResult.Yes Then
                Return
            End If

            If DgvViewIncluidaUs.RowCount <= 0 Then
                XtraMessageBox.Show("No hay datos para desasignar")
                Return
            End If

            Dim view As ColumnView = CType(DgvIncluidaUs.MainView, ColumnView)
            Dim selectedRowHandles As Integer() = view.GetSelectedRows()


            For i As Integer = 0 To selectedRowHandles.Count - 1

                If String.IsNullOrEmpty(view.GetRowCellDisplayText(selectedRowHandles(i), view.Columns("Usuario")).ToString) Then
                    MsgBox("El valor de la columna [Usuario] no puede estar vacío")
                    Return
                End If
            Next

            Cursor.Current = Cursors.WaitCursor

            DesasignarUsuario()

            Cursor.Current = Cursors.Default

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Try
            FrmUsuarios.ShowDialog()
            LlenarUsuariosExcluidos(pGrupo)
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnAgregaTransaccion_Click(sender As Object, e As EventArgs) Handles BtnAgregaTransaccion.Click
        Try
            If XtraMessageBox.Show("Agregar transacciones al grupo " + LblGrupoSeleccionado.Text + "?", "Confirmación", MessageBoxButtons.YesNo) <> DialogResult.Yes Then
                Return
            End If

            If DgvViewExcluidaTr.RowCount <= 0 Then
                XtraMessageBox.Show("No hay datos para asignar")
                Return
            End If

            Dim view As ColumnView = CType(DgvExcluida.MainView, ColumnView)
            Dim selectedRowHandles As Integer() = view.GetSelectedRows()


            For i As Integer = 0 To selectedRowHandles.Count - 1
                If String.IsNullOrEmpty(view.GetRowCellDisplayText(selectedRowHandles(i), view.Columns("Transaccion")).ToString) Then
                    MsgBox("El valor de la columna [Transaccion] no puede estar vacío")
                    Return
                End If
            Next

            Cursor.Current = Cursors.WaitCursor

            AsignarTransaccion()

            Cursor.Current = Cursors.Default

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnEliminaTransaccion_Click(sender As Object, e As EventArgs) Handles BtnEliminaTransaccion.Click
        Try
            If XtraMessageBox.Show("eliminar transacciones del grupo " + LblGrupoSeleccionado.Text + "?", "Confirmación", MessageBoxButtons.YesNo) <> DialogResult.Yes Then
                Return
            End If

            If DgvViewIncluidaTr.RowCount <= 0 Then
                XtraMessageBox.Show("No hay datos para desasignar")
                Return
            End If

            Dim view As ColumnView = CType(DgvIncluida.MainView, ColumnView)
            Dim selectedRowHandles As Integer() = view.GetSelectedRows()


            For i As Integer = 0 To selectedRowHandles.Count - 1

                If String.IsNullOrEmpty(view.GetRowCellDisplayText(selectedRowHandles(i), view.Columns("Transaccion")).ToString) Then
                    MsgBox("El valor de la columna [Transaccion] no puede estar vacío")
                    Return
                End If
            Next

            Cursor.Current = Cursors.WaitCursor

            DesasignarTransaccion()

            Cursor.Current = Cursors.Default

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub DgvResultadoGrupos_DoubleClick(sender As Object, e As EventArgs) Handles DgvResultadoGrupos.DoubleClick
        Try
            Dim view As ColumnView = CType(DgvResultadoGrupos.MainView, ColumnView)
            Dim selectedRowHandles As Integer() = view.GetSelectedRows()

            pGrupoSeleccionado = view.GetRowCellDisplayText(selectedRowHandles(0), view.Columns("Grupo"))

            FrmGrupo.pGrupo = pGrupoSeleccionado
            FrmGrupo.pAccion = 1
            FrmGrupo.ShowDialog()

            Dim pBusqueda As String
            If String.IsNullOrEmpty(TxtBusqueda.Text) Then
                pBusqueda = "@"
            Else
                pBusqueda = TxtBusqueda.Text
            End If
            ResultadoLista(pBusqueda)


        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        Try
            FrmGrupo.pAccion = 2
            FrmGrupo.ShowDialog()
            Dim pBusqueda As String
            If String.IsNullOrEmpty(TxtBusqueda.Text) Then
                pBusqueda = "@"
            Else
                pBusqueda = TxtBusqueda.Text
            End If
            ResultadoLista(pBusqueda)
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

#End Region
End Class