Imports DevExpress.XtraCharts
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Base

Public Class Almacén
    Private Sub llenarGraficaAlmacenamientoDashbord()

        Try
            Dim objKPI As New clsKPIF

            Dim resultado = objKPI.KPIAlmacenamientoUtilizado("@",IIf(String.IsNullOrEmpty(dtpFechaInicio.Text), "@", dtpFechaInicio.Text), IIf(String.IsNullOrEmpty(dtpFechaFin.Text), "@", dtpFechaFin.Text), My.Settings.Estacion, DatosTemporales.Usuario)
            If Not resultado.Estado Then
                XtraMessageBox.Show(resultado.Texto, "AXC")
                Return
            End If

            Dim tablaPromedio = resultado.Tablas.Tables(2)
            Dim tablaGeneral = resultado.Tablas.Tables(3)
            Dim tablaDistintosAlmacenes = resultado.Tablas.Tables(1)

            'llenarGraficasAlmacenamientoPestañaDashboard(tablaPromedio, tablaGeneral)
            llenarGraficasAlmacenamientoPestañaAlmacenamiento(tablaPromedio, tablaGeneral, tablaDistintosAlmacenes)

            'dgvDetalle6.DataSource = tablaGeneral

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try

    End Sub
    'Private Sub llenarGraficasAlmacenamientoPestañaDashboard(ByVal tablaPromedio As DataTable, ByVal tablaGeneral As DataTable)
    '    Try
    '        If tablaPromedio.Rows.Count > 0 Then
    '            For Each row As DataRow In tablaPromedio.Rows
    '                If row.Item("Almacén") = "CEDIS" Then
    '                    ArcScaleComponent3.Value = row.Item("Ocupación")

    '                    LabelComponent3.Text = row.Item("Ocupación").ToString
    '                    LabelComponent7.Text = row.Item("Almacén").ToString
    '                End If
    '            Next
    '        End If

    '    Catch ex As Exception

    '    End Try
    'End Sub

    Private Sub llenarGraficasAlmacenamientoPestañaAlmacenamiento(ByVal tablaPromedio As DataTable, ByVal tablaGeneral As DataTable, ByVal tablaDistintosAlmacenes As DataTable)
        Try
            'If tablaPromedio.Rows.Count > 0 Then

            '    'LLENAR TABLAS PESTAÑA ALMACENAMIENTO
            '    'dgvDetalle5.DataSource = tablaPromedio

            '    'LLENAR GRAFICAS PESTAÑA ALMACENAMIENTO
            '    For Each row As DataRow In tablaPromedio.Rows
            '        If row.Item("Almacén") = "CEDIS" Then
            '            ArcScaleComponent2.Value = row.Item("Ocupación")
            '            LabelComponent2.Text = row.Item("Ocupación").ToString
            '            LabelComponent6.Text = row.Item("Almacén").ToString

            '        End If
            '    Next

            'End If
            Label1.Text = Nothing
            Label1.Text = tablaGeneral.Rows(0).Item("Ocupación").ToString + "%"
            Label4.Text = Nothing
            Label4.Text = tablaGeneral.Rows(0).Item("Ocupación").ToString + "%"

            GridControl2.DataSource = tablaGeneral
            GridView2.BestFitColumns()

            ChartControl1.Titles.Clear()
            ChartControl1.Series.Clear()
            ChartControl2.Titles.Clear()
            ChartControl2.Series.Clear()

            ChartControl2.DataSource = tablaGeneral
            ChartControl1.DataSource = tablaGeneral
            If tablaGeneral.Rows.Count > 0 Then
                Dim series() As Series
                ReDim series(tablaDistintosAlmacenes.Rows.Count - 1)
                Dim contador = 0
                For Each rowAlm As DataRow In tablaDistintosAlmacenes.Rows
                    series(contador) = New Series(rowAlm.Item("Almacén"), ViewType.Line)

                    Dim almacen = rowAlm.Item("Almacén")
                    For Each rowOcupados As DataRow In tablaGeneral.Rows
                        If rowOcupados.Item("Almacén") = almacen Then
                            series(contador).Points.Add(New SeriesPoint(rowOcupados.Item("Fecha"), rowOcupados.Item("Ocupación")))
                        End If

                    Next
                    ChartControl1.Series.Add(series(contador))


                    CType(series(contador).View, LineSeriesView).MarkerVisibility = DevExpress.Utils.DefaultBoolean.True
                    CType(series(contador).View, LineSeriesView).LineMarkerOptions.Size = 10
                    CType(series(contador).View, LineSeriesView).LineMarkerOptions.Kind = MarkerKind.Circle
                    CType(series(contador).View, LineSeriesView).LineStyle.DashStyle = DashStyle.Dash
                    contador += 1
                Next

                ' Add a title to the chart and hide the legend.
                Dim chartTitle1 As New ChartTitle()
                chartTitle1.Text = "Ocupación de almacén"
                ChartControl1.Titles.Add(chartTitle1)
                ChartControl1.Legend.Visible = False


                'Cast the chart's diagram to the XYDiagram type, to access its axes.
                Dim diagram As XYDiagram = CType(ChartControl1.Diagram, XYDiagram)


                diagram.EnableAxisXScrolling = True
                diagram.EnableAxisXZooming = True

                diagram.EnableAxisYScrolling = True
                diagram.EnableAxisYZooming = True
                diagram.AxisX.WholeRange.SetMinMaxValues(dtpFechaInicio, dtpFechaFin)

            End If

            If tablaGeneral.Rows.Count > 0 Then
                Dim series2() As Series
                ReDim series2(tablaDistintosAlmacenes.Rows.Count - 1)
                Dim contador1 = 0
                For Each rowAlm As DataRow In tablaDistintosAlmacenes.Rows
                    series2(contador1) = New Series(rowAlm.Item("Almacén"), ViewType.Line)

                    Dim almacen = rowAlm.Item("Almacén")
                    For Each rowOcupados As DataRow In tablaGeneral.Rows
                        If rowOcupados.Item("Almacén") = almacen Then
                            series2(contador1).Points.Add(New SeriesPoint(rowOcupados.Item("Fecha"), rowOcupados.Item("Ocupación")))
                        End If

                    Next
                    ChartControl2.Series.Add(series2(contador1))


                    CType(series2(contador1).View, LineSeriesView).MarkerVisibility = DevExpress.Utils.DefaultBoolean.True
                    CType(series2(contador1).View, LineSeriesView).LineMarkerOptions.Size = 10
                    CType(series2(contador1).View, LineSeriesView).LineMarkerOptions.Kind = MarkerKind.Circle
                    CType(series2(contador1).View, LineSeriesView).LineStyle.DashStyle = DashStyle.Dash
                    contador1 += 1
                Next

                ' Add a title to the chart and hide the legend.
                Dim chartTitle2 As New ChartTitle()
                chartTitle2.Text = "Ocupación de almacén"
                ChartControl2.Titles.Add(chartTitle2)
                ChartControl2.Legend.Visible = False


                'Cast the chart's diagram to the XYDiagram type, to access its axes.
                Dim diagram As XYDiagram = CType(ChartControl1.Diagram, XYDiagram)


                diagram.EnableAxisXScrolling = True
                diagram.EnableAxisXZooming = True

                diagram.EnableAxisYScrolling = True
                diagram.EnableAxisYZooming = True
                diagram.AxisX.WholeRange.SetMinMaxValues(dtpFechaInicio, dtpFechaFin)


            End If

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub

    Private Sub llenarPantallaDashboard()

        Dim prmBusqueda2 As String
        Dim prmBusqueda3 As String

        If String.IsNullOrEmpty(dtpFechaInicio.Text) Then
            prmBusqueda2 = "@"
        Else
            prmBusqueda2 = dtpFechaInicio.Text
        End If
        Dim fecha As New Date
        fecha = Date.Parse(dtpFechaInicio.EditValue.ToString)
        'ResultadoLista(prmBusqueda2, fecha)
        If String.IsNullOrEmpty(dtpFechaFin.Text) Then
            prmBusqueda3 = "@"
        Else
            prmBusqueda3 = dtpFechaFin.Text
        End If
        Dim fecha2 As New Date
        fecha2 = Date.Parse(dtpFechaFin.EditValue.ToString)

        ''ALMACEN
        llenarGraficaAlmacenamientoDashbord()
        llenarGraficaOrdenesPrecisionInv()
        llenarGraficaDatosCicloRecibo(fecha, fecha2)
        llenarGraficaPresicionSurtidoOrdenes()

    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Try

            llenarPantallaDashboard()


        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try

    End Sub

    Private Sub llenarGraficaOrdenesPrecisionInv()

        Try
            Dim objKPI As New clsKPIF

            Dim resultado = objKPI.KPIPresicionInv(IIf(String.IsNullOrEmpty(dtpFechaInicio.Text), "@", dtpFechaInicio.Text), IIf(String.IsNullOrEmpty(dtpFechaFin.Text), "@", dtpFechaFin.Text), My.Settings.Estacion, DatosTemporales.Usuario)
            If Not resultado.Estado Then
                XtraMessageBox.Show("No hay información con los filtros solicitados", "AXC")
                Return
            End If

            Dim tablaPromedio = resultado.Tablas.Tables(1)
            Dim tablaGeneral = resultado.Tablas.Tables(2)

            Label2.Text = Nothing

            Label2.Text = tablaPromedio.Rows(0).Item("Precisión").ToString + "%"


        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try

    End Sub
    Private Sub llenarGraficaDatosCicloRecibo(prmBusqueda2 As Date, prmBusqueda3 As Date)

        Try
            Dim objKPI As New clsKPIF

            Dim resultado = objKPI.DatosCicloRecibo(IIf(String.IsNullOrEmpty(dtpFechaInicio.Text), "@", dtpFechaInicio.Text), IIf(String.IsNullOrEmpty(dtpFechaFin.Text), "@", dtpFechaFin.Text), My.Settings.Estacion, DatosTemporales.Usuario)
            If Not resultado.Estado Then

                GridControl1.DataSource = Nothing
                XtraMessageBox.Show(resultado.Texto, "AXC")
                Return
            End If

            Dim tablaPromedio = resultado.Tablas.Tables(1)
            Dim tablaGeneral = resultado.Tablas.Tables(2)
            Dim TablaMinMax = resultado.Tablas.Tables(3)

            digitalGauge1.Text = tablaPromedio.Rows(0).Item("Días")
            DigitalGauge2.Text = tablaPromedio.Rows(0).Item("Horas")
            DigitalGauge3.Text = tablaPromedio.Rows(0).Item("Minutos")

            DigitalGauge5.Text = tablaPromedio.Rows(0).Item("Días")
            DigitalGauge6.Text = tablaPromedio.Rows(0).Item("Horas")
            DigitalGauge4.Text = tablaPromedio.Rows(0).Item("Minutos")

            GridControl1.DataSource = tablaGeneral
            GridView1.BestFitColumns()

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub

    Private Sub llenarGraficaPresicionSurtidoOrdenes()

        Try
            Dim objKPI As New clsKPIF

            Dim resultado = objKPI.KPIPresicionSurtidoOrdenes(IIf(String.IsNullOrEmpty(dtpFechaInicio.Text), "@", dtpFechaInicio.Text), IIf(String.IsNullOrEmpty(dtpFechaFin.Text), "@", dtpFechaFin.Text), My.Settings.Estacion, DatosTemporales.Usuario)
            If Not resultado.Estado Then
                XtraMessageBox.Show("No hay información con los filtros solicitados", "AXC")
                Return
            End If

            Dim tablaCantidades = resultado.Tablas.Tables(1)
            Dim tablaGeneral = resultado.Tablas.Tables(2)

            Label3.Text = Nothing

            Label3.Text = tablaCantidades.Rows(0).Item("PresicionTotal").ToString + "%"


        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try

    End Sub
    Private Sub LabelControl2_Click(sender As Object, e As EventArgs) Handles LabelControl2.Click

    End Sub

    Private Sub Almacén_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TabNavigationPage1_Paint(sender As Object, e As PaintEventArgs) Handles TabNavigationPage1.Paint

    End Sub

    Private Sub LabelControl6_Click(sender As Object, e As EventArgs) Handles LabelControl6.Click

    End Sub
End Class