Imports DevExpress.XtraCharts
Imports DevExpress.XtraEditors

Public Class FrmBalanceCargas
    Public ds As DataSet
    Public ds2 As DataSet
    Public fechainicio As String
    Public fechafin As String
    Private Sub FrmBalanceCargas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            CrearGrafica(1, 1)
        Catch ex As Exception
            XtraMessageBox.Show("Error: " + ex.Message, "AXC")
        End Try

    End Sub
    Private Function CrearGrafica(prmtipo As Integer, Optional prmFecha As Integer = 0)
        Try
            Dim dt As New DataTable

            If prmFecha = 1 Then
                dtpFechaInicio.DateTime = DateTime.Now.AddDays(-7)
                dtpFechaFin.DateTime = DateTime.Now.AddDays(-7)
            End If
            dt = ConsultaTablaBalance(prmtipo)
            ChartBalance.Series.Clear()
            Dim Series1 As Series

            Dim miView As DataView = New DataView(dt)
            For x = 0 To miView.Count - 1
                Dim nSer As Series = ChartBalance.Series(miView(x)("Posicion"))

                If nSer Is Nothing Then
                    Series1 = New Series(miView(x)("Posicion"), ViewType.StackedBar)
                    ChartBalance.Series.Add(Series1)
                    nSer = ChartBalance.Series(miView(x)("Posicion"))
                End If

                Dim sp As New SeriesPoint(miView(x)("Rack"), miView(x)("No"))
                If prmtipo = 1 Then
                    If miView(x)("Estatus") >= 10 Then
                        sp.Color = Color.Red
                    ElseIf miView(x)("Estatus") < 10 And miView(x)("Estatus") > 5 Then
                        sp.Color = Color.DarkOrange
                    ElseIf miView(x)("Estatus") <= 5 And miView(x)("Estatus") > 3 Then
                        sp.Color = Color.Gold
                    ElseIf miView(x)("Estatus") < 0 Then
                        sp.Color = Color.Black
                    Else
                        sp.Color = Color.Blue
                    End If

                Else
                    If miView(x)("Estatus") >= 100 Then
                        sp.Color = Color.Red
                    ElseIf miView(x)("Estatus") < 100 And miView(x)("Estatus") > 50 Then
                        sp.Color = Color.DarkOrange
                    ElseIf miView(x)("Estatus") <= 50 And miView(x)("Estatus") > 30 Then
                        sp.Color = Color.Gold
                    ElseIf miView(x)("Estatus") < 0 Then
                        sp.Color = Color.Black
                    Else
                        sp.Color = Color.Blue
                    End If
                End If

                nSer.LabelsVisibility = DevExpress.Utils.DefaultBoolean.False
                nSer.Points.Add(sp)

            Next

            If prmtipo = 1 Then
                lblinfo1.Text = "Mayor a 10 partidas surtidas"
                lblinfo2.Text = "Entre 6 y 10 partidas surtidas"
                lblinfo3.Text = "Entre 3 y 5 partidas surtidas"
                lblinfo4.Text = "Posicion deshabilitada"

            Else
                lblinfo1.Text = "Mayor a 100 artículos (Unidades) surtidas"
                lblinfo2.Text = "Entre 51 y 100 artículos (Unidades) surtidas"
                lblinfo3.Text = "Entre 30 y 50 artículos (Unidades) surtidas"
                lblinfo4.Text = "Posicion deshabilitada"
            End If
            For Each s As Series In ChartBalance.Series
                Dim viewS As StackedBarSeriesView = CType(s.View, StackedBarSeriesView)
                viewS.BarWidth = 0.6
            Next

            Dim diagram As XYDiagram = CType(ChartBalance.Diagram, XYDiagram)
            diagram.AxisX.Tickmarks.MinorVisible = False
            diagram.EnableAxisXScrolling = True
            diagram.EnableAxisYScrolling = True
            diagram.EnableAxisXZooming = True
            diagram.EnableAxisYZooming = True

            ChartBalance.Legend.MarkerMode = LegendMarkerMode.CheckBoxAndMarker
            ChartBalance.Legend.AlignmentHorizontal = LegendAlignmentHorizontal.Center
            ChartBalance.Legend.AlignmentVertical = LegendAlignmentVertical.TopOutside

        Catch ex As Exception
            XtraMessageBox.Show("Error: " + ex.Message, "AXC")
        End Try
    End Function

    Public Function ConsultaTablaBalance(prmDato As Integer) As DataTable
        Try
            Dim pResultado As New CResultado
            Dim pOC As New COrdenCompraR
            Dim dt As DataTable = New DataTable

            Cursor.Current = Cursors.WaitCursor
            pResultado = ConsultaBalance(prmDato)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                MsgBox(pResultado.Texto)
                Return Nothing
            End If

            dt = pResultado.Tabla

            Return dt
        Catch ex As Exception
            Cursor.Current = Cursors.Default
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function ConsultaBalance(prmTipo As Integer) As CResultado
        Dim pRespuesta As New CResultado
        Dim dt As DataTable
        Dim ds As DataSet
        Try
            Dim db As New CAccesoDatos
            Dim pResultado As CResultado

            Dim dRec As New Date
            Dim dRet As New Date

            dRec = Date.Parse(dtpFechaInicio.EditValue.ToString)
            dRet = Date.Parse(dtpFechaFin.EditValue.ToString)


            If prmTipo = 1 Then 'partidas por Estacion
                pResultado = db.SPToDataSet("spQryBalancePorPartidas", dRec.ToString("yyyyMMdd"), dRet.ToString("yyyyMMdd"))
            ElseIf prmTipo = 2 Then 'partidas por pasillos
                pResultado = db.SPToDataSet("spQryBalancePorArticulos", dRec.ToString("yyyyMMdd"), dRet.ToString("yyyyMMdd"))
            ElseIf prmTipo = 3 Then 'Artículos por pasillo
                pResultado = db.SPToDataSet("spQryBalancePorPasillos", dRec.ToString("yyyyMMdd"), dRet.ToString("yyyyMMdd"))
            Else
                pResultado = db.SPToDataSet("spQryBalancePorPartidas", dRec.ToString("yyyyMMdd"), dRet.ToString("yyyyMMdd"))
            End If

            If pResultado.Estado Then
                ds = pResultado.Resultado

                For Each dr As DataRow In ds.Tables(0).Rows

                    Select Case dr("Estado").ToString
                        Case "OK"
                            dt = ds.Tables(1).Copy

                            pRespuesta.Estado = True
                            pRespuesta.Texto = ""
                            pRespuesta.Tabla = dt
                            dgvDetalleBalance.DataSource = Nothing
                            dgvDetalleBalance.DataSource = ds.Tables(2).Copy

                            GridViewBalance.BestFitColumns()
                        Case "ER"
                            dgvDetalleBalance.DataSource = Nothing
                            pRespuesta.Estado = False
                            pRespuesta.Texto = dr("Texto").ToString

                        Case Else
                            pRespuesta.Estado = True
                            pRespuesta.Texto = "No se pudo procesar la orden"
                            pRespuesta.Resultado = Nothing
                    End Select
                Next
            Else
                pRespuesta.Estado = False
                pRespuesta.Texto = pResultado.Texto
            End If

            Return pRespuesta
        Catch ex As Exception

            pRespuesta.Estado = False
            pRespuesta.Texto = "Error al obtener OC [SP1]" + ex.Message

            Return pRespuesta
        End Try
    End Function

    Private Sub ChartBalance_Zoom(sender As Object, e As ChartZoomEventArgs) Handles ChartBalance.Zoom
        Try
            Dim chart As ChartControl = CType(sender, ChartControl)
            Dim diagram As XYDiagram = CType(chart.Diagram, XYDiagram)

            If (Convert.ToDouble(e.NewXRange.MaxValue) - Convert.ToDouble(e.NewXRange.MinValue)) < 6 Then
                For Each s As Series In ChartBalance.Series
                    s.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[True]
                    s.Label.TextPattern = "{S}"
                    CType(s.Label, BarSeriesLabel).Position = BarSeriesLabelPosition.Center
                Next
            Else
                For Each s As Series In ChartBalance.Series
                    s.LabelsVisibility = DevExpress.Utils.DefaultBoolean.False
                Next
            End If
        Catch ex As Exception
            XtraMessageBox.Show("Error: " + ex.Message, "AXC")
        End Try


    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Try
            CrearGrafica(1)
        Catch ex As Exception
            XtraMessageBox.Show("Error: " + ex.Message, "AXC")

        End Try
    End Sub


    Private Sub rdpartidas_Click(sender As Object, e As EventArgs) Handles rdpartidas.Click
        Try
            If rdpartidas.Checked Then

                rdarticulos.Checked = False
                CrearGrafica(1)
            Else
                rdpartidas.Checked = True
                CrearGrafica(2)
            End If
        Catch ex As Exception
            XtraMessageBox.Show("Error: " + ex.Message, "AXC")

        End Try
    End Sub

    Private Sub rdarticulos_Click(sender As Object, e As EventArgs) Handles rdarticulos.Click
        Try
            If rdarticulos.Checked Then

                rdpartidas.Checked = False
                CrearGrafica(2)
            Else
                rdpartidas.Checked = True
                CrearGrafica(1)
            End If
        Catch ex As Exception
            XtraMessageBox.Show("Error: " + ex.Message, "AXC")

        End Try
    End Sub


    Private Sub GroupControl2_Paint(sender As Object, e As PaintEventArgs) Handles GroupControl2.Paint

    End Sub

    Private Sub GroupControl2Prod_Paint(sender As Object, e As PaintEventArgs) Handles GroupControl2Prod.Paint

    End Sub

    Private Sub rdarticulos_CheckedChanged(sender As Object, e As EventArgs) Handles rdarticulos.CheckedChanged

    End Sub

    Private Sub rdpartidas_CheckedChanged(sender As Object, e As EventArgs) Handles rdpartidas.CheckedChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub ChartBalance_Click(sender As Object, e As EventArgs) Handles ChartBalance.Click

    End Sub
End Class