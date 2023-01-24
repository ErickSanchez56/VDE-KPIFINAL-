Imports DevExpress.XtraEditors

Public Class FrmSubidivirPosicion
    Public arregloPosiciones() As String = {}
    Public cadena As String
    Dim table As New DataTable
    Public almacen As String

#Region "MÉTODOS"
    Public Sub LlenarSubdivision()
        Try
            Dim Subdivisiones = New List(Of String)()
            Subdivisiones.Add("1")
            Subdivisiones.Add("2")
            Subdivisiones.Add("3")
            Subdivisiones.Add("4")
            Subdivisiones.Add("5")
            Subdivisiones.Add("6")
            Subdivisiones.Add("7")
            Subdivisiones.Add("8")
            Subdivisiones.Add("9")

            cmbDivision.Properties.DataSource = Subdivisiones

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub

    Public Sub LlenarGrid()
        Try
            GridControl1.DataSource = crearTabla()
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub

    Public Function crearTabla() As DataTable
        Try
            ' Create new DataTable instance.


            ' Create 3 typed columns in the DataTable.
            table.Columns.Add("Posición", GetType(String))


            For Each posicion As String In arregloPosiciones
                'MsgBox(posicion)
                table.Rows.Add(posicion)
                cadena = cadena + posicion + ", "
            Next
            ''Add five rows with those columns filled in the DataTable.
            'table.Rows.Add(25, "Drug A", "10")

            Return table
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Function

#End Region

#Region "EVENTOS"
    Private Sub FrmSubidivirPosicion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            LblAlmacen.Text = almacen
            LlenarSubdivision()
            LlenarGrid()
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Try
            'Dim limpiarcadena As String
            If cmbDivision.Text = "Divisiones" Then
                XtraMessageBox.Show("Seleccione una cantidad de divisiones válida", "AXC")
                cmbDivision.Select()
                Return
            End If

            If String.IsNullOrEmpty(txtCantidad.Text) Then
                XtraMessageBox.Show("Ingrese una cantidad válida", "AXC")
                txtCantidad.Select()
                Return
            End If

            If String.IsNullOrEmpty(LblAlmacen.Text) Then
                XtraMessageBox.Show("El almacén no se capturó de la pantalla anterior", "AXC")
                Return
            End If

            Dim divisiones = "divisiones"
            If GridView1.RowCount = 1 Then
                cadena = cadena.Replace(",", "")

            End If

            If cmbDivision.Text = "1" Then
                divisiones = "división"
            End If

            If XtraMessageBox.Show("Está seguro que desea subdivir la(s) posicion(es) " + cadena + " en " + cmbDivision.Text + " " + divisiones + "? Este cambio no puede ser revertido", "Confirmación", MessageBoxButtons.YesNo) <> DialogResult.No Then
                'e.Cancel = True
                Dim objAlmacen As New ClsConfiguracionAlmacen
                Dim posicionesNoDivididas() As String = {}
                Dim posicionesDivididas() As String = {}

                Dim posicionesNoDivididasPrevio(GridView1.RowCount) As String
                Dim posicionesDivididasPrevio(GridView1.RowCount) As String

                Dim mensajesError(GridView1.RowCount) As String
                Dim contador As Integer = 0
                Dim contadorPosicionesDivididas As Integer = 0
                For Each row As DataRow In table.Rows
                    'MsgBox(row.Item("Posición"))
                    Dim respuesta = objAlmacen.DividePosicion(LblAlmacen.Text, row.Item("Posición"), CInt(cmbDivision.Text), CInt(txtCantidad.Text), My.Settings("Estacion"), DatosTemporales.Usuario)
                    If Not respuesta.Estado Then
                        posicionesNoDivididasPrevio(contador) = row.Item("Posición")
                        mensajesError(contador) = respuesta.Texto
                        contador += 1
                    Else
                        posicionesDivididasPrevio(contadorPosicionesDivididas) = row.Item("Posición")
                        contadorPosicionesDivididas += 1
                    End If

                Next row

                posicionesDivididas = posicionesDivididasPrevio
                posicionesNoDivididas = posicionesNoDivididasPrevio


                For i As Integer = contadorPosicionesDivididas - 1 To 0 Step -1
                    For j As Integer = contadorPosicionesDivididas - 1 To j = 0 Step -1
                        Dim booleano As Boolean = False
                        If table.Rows.Item(i).Item("Posición") = posicionesDivididas(j) Then
                            table.Rows.RemoveAt(i)
                            XtraMessageBox.Show("Posición [" + posicionesDivididas(j) + "] dividida con exito", "AXC")
                            booleano = True
                        End If
                        If booleano Then
                            Exit For
                        End If

                    Next
                Next


                For i As Integer = 0 To i >= contador
                    XtraMessageBox.Show("Posicion: " + posicionesNoDivididas(i) + ". ER: " + mensajesError(i), "AXC")
                Next

                GridControl1.DataSource = Nothing
                GridControl1.DataSource = table

                'FrmConfiguracionAlmacen.recargarLayout()

            End If
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub
#End Region
End Class