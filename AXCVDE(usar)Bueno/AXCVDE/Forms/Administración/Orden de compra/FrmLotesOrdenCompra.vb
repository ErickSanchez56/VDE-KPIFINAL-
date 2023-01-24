Imports DevExpress.XtraEditors

Public Class FrmLotesOrdenCompra
    Private Sub FrmLotesOrdenCompra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try


            Dim ds As DataSet = New DataSet
            Dim sLotes As String

            dgvResultados.DataSource = Nothing
            sLotes = FrmLiberaOrdenCompra.pLotes
            If sLotes = "" Or sLotes = "<NewDataSet />" Then
                sLotes = ""
                sLotes = sLotes + "<NewDataSet>"
                sLotes = sLotes + "   <Table1>"
                sLotes = sLotes + "	   <Partida>" + FrmLiberaOrdenCompra.pPartida + "</Partida>"
                sLotes = sLotes + "	   <NumParte>" + FrmLiberaOrdenCompra.pNumParte + "</NumParte>"
                sLotes = sLotes + "	   <LoteProveedor></LoteProveedor>"
                sLotes = sLotes + "	   <Cantidad></Cantidad>"
                sLotes = sLotes + "	   <LoteInterno></LoteInterno>"
                sLotes = sLotes + "	   <FechaCaducidad></FechaCaducidad>"
                sLotes = sLotes + "	   <FechaProd></FechaProd>"
                sLotes = sLotes + "   </Table1>"
                sLotes = sLotes + "</NewDataSet>"
            End If

            Dim SR = New System.IO.StringReader(sLotes)
            ds.ReadXml(SR)
            dgvResultados.DataSource = ds.Tables(0)

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub

    Private Sub btnEliminarLinea_Click(sender As Object, e As EventArgs) Handles btnEliminarLinea.Click
        Try
            If IsNothing(dgvResultados.DataSource) Then
                dgvResultados.DataSource = dgvResultados
            End If

            If DgvViewResultados.RowCount = 0 Then
                Return
            End If
            If XtraMessageBox.Show("¿Eliminar línea seleccionada?", "AXC", MessageBoxButtons.YesNo) <> DialogResult.Yes Then
                Return
            End If
            DgvViewResultados.DeleteRow(DgvViewResultados.FocusedRowHandle) ' = view.GetRowCellDisplayText(selectedRowHandles(0), view.Columns("Partida"))
            DgvViewResultados.RefreshData()
            dgvResultados.Refresh()



        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        Try
            If IsNothing(dgvResultados.DataSource) Then
                dgvResultados.DataSource = dgvResultados
            End If

            If DgvViewResultados.RowCount = 0 Then
                Return
            End If
            If XtraMessageBox.Show("¿Agregar línea?", "AXC", MessageBoxButtons.YesNo) <> DialogResult.Yes Then
                Return
            End If
            Dim sPartida As String
            Dim sNumParte As String
            sPartida = FrmLiberaOrdenCompra.pPartida
            sNumParte = FrmLiberaOrdenCompra.pNumParte
            DgvViewResultados.AddNewRow() ' = view.GetRowCellDisplayText(selectedRowHandles(0), view.Columns("Partida"))

            DgvViewResultados.SetRowCellValue(dgvResultados.NewItemRowHandle, DgvViewResultados.Columns("Partida"), sPartida)
            DgvViewResultados.SetRowCellValue(dgvResultados.NewItemRowHandle, DgvViewResultados.Columns("NumParte"), sNumParte)
            DgvViewResultados.RefreshData()
            dgvResultados.Refresh()



        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Dim iError As Integer = 0
        Dim fCantidadARecibir As Double

        If DgvViewResultados.RowCount > 0 Then

            For i As Integer = 0 To DgvViewResultados.RowCount - 1

                Dim sLote = DgvViewResultados.GetRowCellValue(i, "LoteProveedor").ToString
                Dim sCantidadARecibir As Double = DgvViewResultados.GetRowCellValue(i, "Cantidad").ToString
                If Not IsNumeric(sCantidadARecibir) Then
                    XtraMessageBox.Show("La cantidad debe ser un valor numerico", "AXC")
                    iError = 1
                    Exit For
                End If
                If sCantidadARecibir = 0 Then
                    XtraMessageBox.Show("La cantidad debe tener un valor", "AXC")
                    iError = 1
                    Exit For
                End If
                If sLote.Trim() = "" Then
                    XtraMessageBox.Show("Debe ingresar un lote", "AXC")
                    iError = 1
                    Exit For
                End If
                fCantidadARecibir = fCantidadARecibir + sCantidadARecibir
            Next


            If iError = 1 Then
                Return
            End If
            fCantidadARecibir = Math.Round(fCantidadARecibir, 3)

            If fCantidadARecibir <> Convert.ToDouble(FrmLiberaOrdenCompra.pCantidad) Then
                XtraMessageBox.Show("Error - La cantidad de la partida es: " + FrmLiberaOrdenCompra.pCantidad.ToString + " la cantidad de los lotes es: " + fCantidadARecibir.ToString, "AXC")
                Return
            End If

        End If


        Dim ds As DataSet = New DataSet
        ds.Merge(dgvResultados.DataSource)
        FrmLiberaOrdenCompra.pLotes = ds.GetXml()
        'FrmLiberaOrdenCompra.dsLotes.Merge(ds)
        FrmLiberaOrdenCompra.tblLotes = ds.Tables(0)
        Me.Close()

    End Sub
End Class