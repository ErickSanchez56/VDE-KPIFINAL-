Imports DevExpress.XtraCharts
Imports DevExpress.XtraEditors
Public Class frmKPIAlmacén
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
        llenarGraficaTiempoUbicaciónPallet(fecha, fecha2)
        llenarGraficaColocacionesUsuario()
        llenarGraficaReabastecimiento()
        llenarGraficasInventarios()
        llenarGraficasColocaciones()
        llenarGraficasInventarios2()
    End Sub
    Private Sub llenarGraficaAlmacenamientoDashbord()

        Try
            Dim objKPI As New clsKPIAlmacén

            Dim resultado = objKPI.KPIAlmacenamientoUtilizado("@", IIf(String.IsNullOrEmpty(dtpFechaInicio.Text), "@", dtpFechaInicio.Text), IIf(String.IsNullOrEmpty(dtpFechaFin.Text), "@", dtpFechaFin.Text), My.Settings.Estacion, DatosTemporales.Usuario)
            If Not resultado.Estado Then
                XtraMessageBox.Show(resultado.Texto, "AXC")
                Return
            End If

            Dim tablaPromedio = resultado.Tablas.Tables(2)
            Dim tablaGeneral = resultado.Tablas.Tables(3)
            Dim tablaGeneral2 = resultado.Tablas.Tables(4)
            Dim tablaDistintosAlmacenes = resultado.Tablas.Tables(1)

            llenarGraficasAlmacenamientoPestañaAlmacenamiento(tablaPromedio, tablaGeneral, tablaGeneral2, tablaDistintosAlmacenes)


        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try

    End Sub

    Private Sub llenarGraficasAlmacenamientoPestañaAlmacenamiento(ByVal tablaPromedio As DataTable, ByVal tablaGeneral As DataTable, ByVal tablaGeneral2 As DataTable, ByVal tablaDistintosAlmacenes As DataTable)
        Try

            Label1.Text = Nothing
            Label1.Text = tablaGeneral.Rows(0).Item("Ocupación").ToString + "%"
            Label4.Text = Nothing
            Label4.Text = tablaGeneral.Rows(0).Item("Ocupación").ToString + "%"
            Label30.Text = Nothing
            Label30.Text = tablaGeneral2.Rows(0).Item("Total de Pallets")
            Label32.Text = Nothing
            Label32.Text = tablaGeneral2.Rows(0).Item("CapacidadTeórica")
            Label33.Text = Nothing
            Label33.Text = tablaGeneral.Rows(0).Item("Vacio").ToString + "%"
            GridControl2.DataSource = Nothing
            GridControl2.DataSource = tablaGeneral2
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
                chartTitle1.Text = "Historial de ocupación del almacén"
                ChartControl1.Titles.Add(chartTitle1)
                ChartControl1.Legend.Visible = False


                'Cast the chart's diagram to the XYDiagram type, to access its axes.
                Dim diagram As XYDiagram = CType(ChartControl1.Diagram, XYDiagram)
                Dim axisX As AxisX = diagram.AxisX
                axisX.Label.Angle = 315
                diagram.AxisX.Title.Visible = True
                diagram.AxisX.Title.Alignment = StringAlignment.Center
                diagram.AxisX.Title.Text = ""
                diagram.AxisX.Title.TextColor = Color.White
                diagram.AxisX.Title.Antialiasing = True
                diagram.AxisX.QualitativeScaleOptions.AutoGrid = False

                diagram.AxisY.Title.Visible = True
                diagram.AxisY.Title.Alignment = StringAlignment.Center
                diagram.AxisY.Title.Text = "Porcentaje"
                diagram.AxisY.Title.TextColor = Color.White
                diagram.AxisY.Title.Antialiasing = True



                diagram.EnableAxisXScrolling = True
                diagram.EnableAxisXZooming = True

                diagram.EnableAxisYScrolling = True
                diagram.EnableAxisYZooming = True


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
                chartTitle2.Text = "Historial de ocupación del almacén"
                ChartControl2.Titles.Add(chartTitle2)
                ChartControl2.Legend.Visible = False


                'Cast the chart's diagram to the XYDiagram type, to access its axes.
                Dim diagram2 As XYDiagram = CType(ChartControl2.Diagram, XYDiagram)
                Dim axisX As AxisX = diagram2.AxisX
                axisX.Label.Angle = 315
                diagram2.AxisX.Title.Visible = True
                diagram2.AxisX.Title.Alignment = StringAlignment.Center
                diagram2.AxisX.Title.Text = ""
                diagram2.AxisX.Title.TextColor = Color.White
                diagram2.AxisX.Title.Antialiasing = True
                diagram2.AxisX.QualitativeScaleOptions.AutoGrid = False


                diagram2.AxisY.Title.Visible = True
                diagram2.AxisY.Title.Alignment = StringAlignment.Center
                diagram2.AxisY.Title.Text = "Porcentaje ocupación"
                diagram2.AxisY.Title.TextColor = Color.White



                diagram2.EnableAxisXScrolling = True
                diagram2.EnableAxisXZooming = True

                diagram2.EnableAxisYScrolling = True
                diagram2.EnableAxisYZooming = True



            End If

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub


    Private Sub llenarGraficaOrdenesPrecisionInv()

        Try
            Dim objKPI As New clsKPIAlmacén

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
    Private Sub llenarGraficaTiempoUbicaciónPallet(prmBusqueda2 As Date, prmBusqueda3 As Date)

        Try
            Dim objKPI As New clsKPIAlmacén

            Dim resultado = objKPI.TiempoUbicaciónPallet(IIf(String.IsNullOrEmpty(dtpFechaInicio.Text), "@", dtpFechaInicio.Text), IIf(String.IsNullOrEmpty(dtpFechaFin.Text), "@", dtpFechaFin.Text), My.Settings.Estacion, DatosTemporales.Usuario)
            If Not resultado.Estado Then

                GridControl1.DataSource = Nothing
                XtraMessageBox.Show(resultado.Texto, "AXC")
                Return
            End If

            Dim tablaPromedio = resultado.Tablas.Tables(1)
            Dim tablaRangos = resultado.Tablas.Tables(2)
            Dim TablaDetalle = resultado.Tablas.Tables(3)

            DigitalGauge9Prod.Text = tablaPromedio.Rows(0).Item("Dias")
            DigitalGauge10Prod.Text = tablaPromedio.Rows(0).Item("Horas")
            DigitalGauge11Prod.Text = tablaPromedio.Rows(0).Item("Minutos")

            GridControl1.DataSource = TablaDetalle
            GridView1.BestFitColumns()

            ChartControl3.Titles.Clear()
            ChartControl3.Series.Clear()
            ChartControl3.DataSource = tablaRangos
            ChartControl3.Titles.Add(New ChartTitle() With {.Text = "Pallets colocados por rangos de tiempo"})
            ChartControl3.Legend.Title.Text = ""
            ChartControl3.SeriesDataMember = "Rangos"
            ChartControl3.SeriesTemplate.ValueDataMembers.AddRange(New String() {"Cantidades"})
            ChartControl3.SeriesTemplate.ArgumentDataMember = "Rangos"
            ChartControl3.RuntimeHitTesting = True
            Dim view As SideBySideBarSeriesView = TryCast(ChartControl3.SeriesTemplate.View, SideBySideBarSeriesView)
            Dim diagram As XYDiagram = CType(ChartControl3.Diagram, XYDiagram)

            diagram.EnableAxisXScrolling = True
            diagram.EnableAxisXZooming = True
            diagram.EnableAxisYScrolling = True
            diagram.EnableAxisYZooming = True
            view.BarDistance = 0.5
            view.BarDistanceFixed = 0.5
            view.BarWidth = 3
            'Cast the chart's diagram to the XYDiagram type, to access its axes.
            Dim axisX As AxisX = diagram.AxisX
            axisX.Label.Angle = 0
            diagram.AxisX.Title.Visible = True
            diagram.AxisX.Title.Alignment = StringAlignment.Center
            diagram.AxisX.Title.Text = "Horas"
            diagram.AxisX.Title.TextColor = Color.White
            diagram.AxisX.Title.Antialiasing = True
            diagram.AxisX.QualitativeScaleOptions.AutoGrid = False

            diagram.AxisY.Title.Visible = True
            diagram.AxisY.Title.Alignment = StringAlignment.Center
            diagram.AxisY.Title.Text = "Cantidad de pallets"
            diagram.AxisY.Title.TextColor = Color.White
            diagram.AxisY.Title.Antialiasing = True


            diagram.EnableAxisXScrolling = True
            diagram.EnableAxisXZooming = True

            diagram.EnableAxisYScrolling = True
            diagram.EnableAxisYZooming = True

            ChartControl6.Titles.Clear()
            ChartControl6.Series.Clear()
            ChartControl6.DataSource = tablaRangos
            ChartControl6.Titles.Add(New ChartTitle() With {.Text = "Pallets colocados por rangos de tiempo"})
            ChartControl6.Legend.Title.Text = ""
            ChartControl6.SeriesDataMember = "Rangos"
            ChartControl6.SeriesTemplate.ValueDataMembers.AddRange(New String() {"Cantidades"})
            ChartControl6.SeriesTemplate.ArgumentDataMember = "Rangos"
            ChartControl6.RuntimeHitTesting = True
            Dim view2 As SideBySideBarSeriesView = TryCast(ChartControl6.SeriesTemplate.View, SideBySideBarSeriesView)
            Dim diagram2 As XYDiagram = CType(ChartControl6.Diagram, XYDiagram)
            axisX.Label.Angle = 0
            diagram2.AxisX.Title.Visible = True
            diagram2.AxisX.Title.Alignment = StringAlignment.Center
            diagram2.AxisX.Title.Text = "Horas"
            diagram2.AxisX.Title.TextColor = Color.White
            diagram2.AxisX.Title.Antialiasing = True
            diagram2.AxisX.QualitativeScaleOptions.AutoGrid = False

            diagram2.AxisY.Title.Visible = True
            diagram2.AxisY.Title.Alignment = StringAlignment.Center
            diagram2.AxisY.Title.Text = "Cantidad de pallets"
            diagram2.AxisY.Title.TextColor = Color.White
            diagram2.AxisY.Title.Antialiasing = True

            diagram2.EnableAxisXScrolling = True
            diagram2.EnableAxisXZooming = True
            diagram2.EnableAxisYScrolling = True
            diagram2.EnableAxisYZooming = True
            view2.BarDistance = 0.5
            view2.BarDistanceFixed = 0.5
            view2.BarWidth = 3

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub


    Private Sub llenarGraficaColocacionesUsuario()

        Try
            Dim objKPI As New clsKPIAlmacén

            Dim resultado = objKPI.KPIColocacionesUsuario("@", IIf(String.IsNullOrEmpty(dtpFechaInicio.Text), "@", dtpFechaInicio.Text), IIf(String.IsNullOrEmpty(dtpFechaFin.Text), "@", dtpFechaFin.Text), My.Settings.Estacion, DatosTemporales.Usuario)
            If Not resultado.Estado Then
                GridControl4.DataSource = Nothing
                XtraMessageBox.Show(resultado.Texto, "AXC")
                Return
            End If


            Dim tablaGeneral = resultado.Tablas.Tables(1)
            Dim tablaTotales = resultado.Tablas.Tables(2)
            Dim tablatop10 = resultado.Tablas.Tables(3)
            Label10.Text = Nothing
            Label10.Text = tablaTotales.Rows(0).Item("ColocacionesTotales")
            Label6.Text = Nothing
            Label6.Text = tablaTotales.Rows(0).Item("ColocacionesTotales").ToString
            Label18.Text = Nothing
            Label18.Text = tablatop10.Rows(0).Item("Colocaciones")
            GridControl4.DataSource = tablaGeneral
            GridView4.BestFitColumns()

            ChartControl4.Titles.Clear()
            ChartControl4.Series.Clear()
            ChartControl4.DataSource = tablatop10
            ChartControl4.Titles.Add(New ChartTitle() With {.Text = "Usuarios con mayor cantidad de colocaciones"})
            ChartControl4.Legend.Title.Text = ""
            ChartControl4.SeriesDataMember = "CodigoUsuario"
            ChartControl4.SeriesTemplate.ValueDataMembers.AddRange(New String() {"Colocaciones"})
            ChartControl4.SeriesTemplate.ArgumentDataMember = "Usuario"
            ChartControl4.RuntimeHitTesting = True
            Dim view As SideBySideBarSeriesView = TryCast(ChartControl4.SeriesTemplate.View, SideBySideBarSeriesView)
            Dim diagram As XYDiagram = CType(ChartControl4.Diagram, XYDiagram)

            diagram.EnableAxisXScrolling = True
            diagram.EnableAxisXZooming = True
            diagram.EnableAxisYScrolling = True
            diagram.EnableAxisYZooming = True
            view.BarDistance = 0.5
            view.BarDistanceFixed = 0.5
            view.BarWidth = 5



            Dim axisX As AxisX = diagram.AxisX
            axisX.Label.Angle = 0
            diagram.AxisX.Title.Visible = True
            diagram.AxisX.Title.Alignment = StringAlignment.Center
            diagram.AxisX.Title.Text = "Usuarios"
            diagram.AxisX.Title.TextColor = Color.White
            diagram.AxisX.Title.Antialiasing = True

            diagram.AxisY.Title.Visible = True
            diagram.AxisY.Title.Alignment = StringAlignment.Center
            diagram.AxisY.Title.Text = "Colocaciones"
            diagram.AxisY.Title.TextColor = Color.White
            diagram.AxisY.Title.Antialiasing = True
            diagram.AxisX.QualitativeScaleOptions.AutoGrid = False



        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try

    End Sub



    Private Sub llenarGraficaReabastecimiento()

        Try
            Dim objKPI As New clsKPIAlmacén

            Dim resultado = objKPI.KPIReabastecimiento(IIf(String.IsNullOrEmpty(dtpFechaInicio.Text), "@", dtpFechaInicio.Text), IIf(String.IsNullOrEmpty(dtpFechaFin.Text), "@", dtpFechaFin.Text), My.Settings.Estacion, DatosTemporales.Usuario)
            If Not resultado.Estado Then

                GridControl7.DataSource = Nothing
                GridControl12.DataSource = Nothing
                XtraMessageBox.Show("No hay información con los filtros solicitados", "AXC")
                Return
            End If

            Dim tablaDetalle = resultado.Tablas.Tables(1)
            Dim tablaCantidades = resultado.Tablas.Tables(2)
            Dim tablaPorcentaje = resultado.Tablas.Tables(3)
            Dim tablaSinDocumento = resultado.Tablas.Tables(4)
            Dim totalReabastecimientoSinOrden = resultado.Tablas.Tables(5)
            Dim ususariosReabastecimientosinOrden = resultado.Tablas.Tables(6)
            Dim posicionesReabastecimientosinOrden = resultado.Tablas.Tables(7)
            Dim sumareabastecimientofull = resultado.Tablas.Tables(8)
            GridControl7.DataSource = tablaDetalle
            GridView7.BestFitColumns()
            GridControl12.DataSource = tablaSinDocumento
            GridView12.BestFitColumns()
            Label3.Text = Nothing
            Label5.Text = Nothing
            Label7.Text = Nothing
            Label8.Text = Nothing
            Label9.Text = Nothing
            Label19.Text = Nothing
            Label29.Text = Nothing
            Label31.Text = Nothing
            Label34.Text = Nothing
            LabelOrdenesPendientes.Text = Nothing
            LabelOrdenesReabastecidas.Text = Nothing
            LabelOrdenesDeshabilitadas.Text = Nothing
            Label3.Text = tablaCantidades.Rows(0).Item("TotalÓrdenesReabastecimiento")
            Label5.Text = tablaCantidades.Rows(0).Item("TotalÓrdenesReabastecimiento")
            Label7.Text = tablaCantidades.Rows(0).Item("CantidadÓrdenesLiberadas")
            Label8.Text = tablaCantidades.Rows(0).Item("CantidadórdenesReabastecidas")
            Label9.Text = tablaCantidades.Rows(0).Item("CantidadórdenesDeshabilitadas")
            Label19.Text = totalReabastecimientoSinOrden.Rows(0).Item("CantidadReabastecimientosinDocumento")
            Label29.Text = ususariosReabastecimientosinOrden.Rows(0).Item("CantidadRebastecimientosinDocumento")
            Label31.Text = posicionesReabastecimientosinOrden.Rows(0).Item("CantidadReabastecimientosinDocumento")
            Label34.Text = sumareabastecimientofull.Rows(0).Item("Total")
            LabelOrdenesPendientes.Text = tablaPorcentaje.Rows(0).Item("PorcentajeórdenesLiberadas").ToString + "%"
            LabelOrdenesReabastecidas.Text = tablaPorcentaje.Rows(0).Item("PorcentajeÓrdenesReabastecidas").ToString + "%"
            LabelOrdenesDeshabilitadas.Text = tablaPorcentaje.Rows(0).Item("PorcentajeórdenesDeshabilitadas").ToString + "%"
            ChartControl9.DataSource = tablaPorcentaje

            Dim series1 As New Series("Doughnut Series 1", ViewType.Pie)

            ' Populate the series with points.
            ChartControl9.Series.Clear()
            ChartControl9.Titles.Clear()
            series1.Points.Add(New SeriesPoint("Órdenes liberadas", tablaPorcentaje.Rows(0).Item("PorcentajeórdenesLiberadas")))
            series1.Points.Add(New SeriesPoint("Órdenes reabastecidas", tablaPorcentaje.Rows(0).Item("PorcentajeÓrdenesReabastecidas")))
            series1.Points.Add(New SeriesPoint("órdenes deshabilitadas", tablaPorcentaje.Rows(0).Item("PorcentajeórdenesDeshabilitadas")))



            ' Add the series to the chart.
            ChartControl9.Series.Add(series1)
            CType(series1.View, PieSeriesView).MinAllowedSizePercentage = 100
            ChartControl9.Legend.Title.Text = "ORDENES"
            ChartControl9.Legend.MarkerMode = LegendMarkerMode.Marker
            ' Adjust the value numeric options of the series.
            series1.PointOptions.ValueNumericOptions.Format = NumericFormat.Percent
            series1.PointOptions.ValueNumericOptions.Precision = 2
            ' Add a title to the chart and hide the legend.
            Dim chartTitle1 As New ChartTitle()
            chartTitle1.Text = "Total de órdenes de reabastecimiento"
            ChartControl9.Titles.Add(chartTitle1)
            ChartControl9.Legend.Visible = False
            ' Add the chart to the form.
            ChartControl9.Dock = DockStyle.None
            Dim size As Size = New Size(500, 200)




        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try

    End Sub
    Private Sub llenarGraficasInventarios()

        Try
            Dim objKPI As New clsKPIAlmacén

            Dim resultado = objKPI.KPIInventario(IIf(String.IsNullOrEmpty(dtpFechaInicio.Text), "@", dtpFechaInicio.Text), IIf(String.IsNullOrEmpty(dtpFechaFin.Text), "@", dtpFechaFin.Text), My.Settings.Estacion, DatosTemporales.Usuario)
            If Not resultado.Estado Then

                GridControl5.DataSource = Nothing
                XtraMessageBox.Show("No hay información con los filtros solicitados", "AXC")
                Return
            End If

            Dim tablaInventariosGeneral = resultado.Tablas.Tables(2)
            Dim tablaInventariosGeneralDetalle = resultado.Tablas.Tables(1)
            Dim tablaInventariosTotalesDetalle = resultado.Tablas.Tables(3)
            Dim tablaInventariosTotales = resultado.Tablas.Tables(4)
            Dim tablaInventariosProductoDetalle = resultado.Tablas.Tables(5)
            Dim tablaInventariosProducto = resultado.Tablas.Tables(6)
            Dim tablaInventariosPosicionDetalle = resultado.Tablas.Tables(7)
            Dim tablaInventariosPosicion = resultado.Tablas.Tables(8)

            GridControl5.DataSource = tablaInventariosGeneralDetalle
            GridView5.BestFitColumns()

            ''''GENERAL
            Label11.Text = Nothing
            Label15.Text = Nothing
            Label14.Text = Nothing
            Label13.Text = Nothing
            Label12.Text = Nothing
            LabelInventariosGeneralAbiertos.Text = Nothing
            LabelInventariosGeneralCancelados.Text = Nothing
            LabelInventariosGeneralCerrados.Text = Nothing
            Label11.Text = tablaInventariosGeneral.Rows(0).Item("TotalInventarios")
            Label15.Text = tablaInventariosGeneral.Rows(0).Item("TotalInventarios")
            Label14.Text = tablaInventariosGeneral.Rows(0).Item("InventariosAbiertos")
            Label13.Text = tablaInventariosGeneral.Rows(0).Item("InventariosCerrados")
            Label12.Text = tablaInventariosGeneral.Rows(0).Item("InventariosCancelados")
            LabelInventariosGeneralAbiertos.Text = tablaInventariosGeneral.Rows(0).Item("PorcentajeInventariosAbiertos").ToString + "%"
            LabelInventariosGeneralCerrados.Text = tablaInventariosGeneral.Rows(0).Item("PorcentajeInventariosCerrados").ToString + "%"
            LabelInventariosGeneralCancelados.Text = tablaInventariosGeneral.Rows(0).Item("PorcentajeInventariosCancelados").ToString + "%"

            ChartControl7.DataSource = tablaInventariosGeneral





            Dim Series2 As New Series("Doughnut Series 1", ViewType.Pie)

            ' Populate the series with points.
            ChartControl7.Series.Clear()
            ChartControl7.Titles.Clear()

            If tablaInventariosGeneral.Rows(0).Item("PorcentajeInventariosCerrados") = 0 And tablaInventariosGeneral.Rows(0).Item("PorcentajeInventariosCancelados") = 0 And tablaInventariosGeneral.Rows(0).Item("PorcentajeInventariosAbiertos") = 0 Then
                Return
            End If

            Series2.Points.Add(New SeriesPoint("Inventarios abiertos", tablaInventariosGeneral.Rows(0).Item("PorcentajeInventariosAbiertos")))
            Series2.Points.Add(New SeriesPoint("Inventarios cerrados", tablaInventariosGeneral.Rows(0).Item("PorcentajeInventariosCerrados")))
            Series2.Points.Add(New SeriesPoint("Inventarios cancelados", tablaInventariosGeneral.Rows(0).Item("PorcentajeInventariosCancelados")))



            ' Add the series to the chart.
            ChartControl7.Series.Add(Series2)
            CType(Series2.View, PieSeriesView).MinAllowedSizePercentage = 80
            ChartControl7.Legend.Title.Text = ""
            ChartControl7.Legend.MarkerMode = LegendMarkerMode.Marker
            ' Adjust the value numeric options of the series.
            Series2.PointOptions.ValueNumericOptions.Format = NumericFormat.Percent
            Series2.PointOptions.ValueNumericOptions.Precision = 2
            ' Add a title to the chart and hide the legend.
            Dim chartTitle2 As New ChartTitle()
            chartTitle2.Text = "Total de ejercicios de inventario"
            ChartControl7.Titles.Add(chartTitle2)
            ChartControl7.Legend.Visible = False
            ' Add the chart to the form.
            ChartControl7.Dock = DockStyle.None
            Dim size2 As Size = New Size(500, 200)

            ''''INVENTARIO POR PRODUCTO
            Label23.Text = Nothing
            Label22.Text = Nothing
            Label21.Text = Nothing
            Label20.Text = Nothing
            LabelCerradosProducto.Text = Nothing
            LabelCanceladosProducto.Text = Nothing
            LabelAbiertosProducto.Text = Nothing
            Label23.Text = tablaInventariosProducto.Rows(0).Item("TotalInventarios")
            Label22.Text = tablaInventariosProducto.Rows(0).Item("InventariosAbiertos")
            Label21.Text = tablaInventariosProducto.Rows(0).Item("InventariosCerrados")
            Label20.Text = tablaInventariosProducto.Rows(0).Item("InventariosCancelados")
            LabelAbiertosProducto.Text = tablaInventariosProducto.Rows(0).Item("PorcentajeInventariosAbiertos").ToString + "%"
            LabelCerradosProducto.Text = tablaInventariosProducto.Rows(0).Item("PorcentajeInventariosCerrados").ToString + "%"
            LabelCanceladosProducto.Text = tablaInventariosProducto.Rows(0).Item("PorcentajeInventariosCancelados").ToString + "%"
            GridControl8.DataSource = Nothing
            GridControl8.DataSource = tablaInventariosProductoDetalle
            GridView8.BestFitColumns()




            ''''INVENTARIO POR POSICION
            Label27.Text = Nothing
            Label26.Text = Nothing
            Label25.Text = Nothing
            Label24.Text = Nothing
            LabelPosicionAbiertos.Text = Nothing
            LabelPosicionCerrados.Text = Nothing
            LabelPosicionCancelados.Text = Nothing
            Label27.Text = tablaInventariosPosicion.Rows(0).Item("TotalInventarios")
            Label26.Text = tablaInventariosPosicion.Rows(0).Item("InventariosAbiertos")
            Label25.Text = tablaInventariosPosicion.Rows(0).Item("InventariosCerrados")
            Label24.Text = tablaInventariosPosicion.Rows(0).Item("InventariosCancelados")
            LabelPosicionAbiertos.Text = tablaInventariosPosicion.Rows(0).Item("PorcentajeInventariosAbiertos").ToString + "%"
            LabelPosicionCerrados.Text = tablaInventariosPosicion.Rows(0).Item("PorcentajeInventariosCerrados").ToString + "%"
            LabelPosicionCancelados.Text = tablaInventariosPosicion.Rows(0).Item("PorcentajeInventariosCancelados").ToString + "%"
            GridControl9.DataSource = Nothing
            GridControl9.DataSource = tablaInventariosPosicionDetalle
            GridView9.BestFitColumns()







        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try

    End Sub

    Private Sub llenarGraficasColocaciones()

        Try
            Dim objKPI As New clsKPIAlmacén

            Dim resultado = objKPI.KPIColocaciones(IIf(String.IsNullOrEmpty(dtpFechaInicio.Text), "@", dtpFechaInicio.Text), IIf(String.IsNullOrEmpty(dtpFechaFin.Text), "@", dtpFechaFin.Text), My.Settings.Estacion, DatosTemporales.Usuario)
            If Not resultado.Estado Then


                XtraMessageBox.Show("No hay información con los filtros solicitados", "AXC")
                Return
            End If

            Dim tablaGeneral = resultado.Tablas.Tables(1)
            Dim tablaPorcentaje = resultado.Tablas.Tables(2)
            Dim tablaDetalle = resultado.Tablas.Tables(3)
            Dim tablaPendientes = resultado.Tablas.Tables(4)

            Label10.Text = Nothing
            Label10.Text = tablaGeneral.Rows(0).Item("TotalColocaciones")
            Label17.Text = Nothing
            Label17.Text = tablaGeneral.Rows(0).Item("ColocacionesCorrectas")
            Label28.Text = Nothing
            Label28.Text = tablaGeneral.Rows(0).Item("ColocacionesCorrectas")
            Label16.Text = Nothing
            Label16.Text = tablaPendientes.Rows(0).Item("PendienteColocar")




        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try

    End Sub

    Private Sub llenarGraficasInventarios2()

        Try
            Dim objKPI As New clsKPIAlmacén

            Dim resultado = objKPI.KPIInventarios2(IIf(String.IsNullOrEmpty(dtpFechaInicio.Text), "@", dtpFechaInicio.Text), IIf(String.IsNullOrEmpty(dtpFechaFin.Text), "@", dtpFechaFin.Text), My.Settings.Estacion, DatosTemporales.Usuario)
            If Not resultado.Estado Then
                GridControl6.DataSource = Nothing
                GridControl10.DataSource = Nothing
                GridControl3.DataSource = Nothing
                GridControl11.DataSource = Nothing

                XtraMessageBox.Show("No hay información con los filtros solicitados", "AXC")
                Return
            End If

            Dim tablaArticulosInventariados = resultado.Tablas.Tables(1)
            Dim tablaDiferenciasInventarioProducto = resultado.Tablas.Tables(2)
            Dim tablaPosiciones = resultado.Tablas.Tables(3)
            Dim tablaDiferenciasInventarioPosicion = resultado.Tablas.Tables(4)


            GridControl6.DataSource = tablaDiferenciasInventarioProducto
            GridView6.BestFitColumns()
            GridControl10.DataSource = tablaDiferenciasInventarioPosicion
            GridView10.BestFitColumns()
            GridControl3.DataSource = tablaPosiciones
            GridView3.BestFitColumns()
            GridControl11.DataSource = tablaArticulosInventariados
            GridView11.BestFitColumns()





        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try

    End Sub

    Private Sub CambiarLabel()
        If NavigationFrame1.SelectedPageIndex = 0 Then
            LabelPrincipal.Text = "Resumen"
        End If
        If NavigationFrame1.SelectedPageIndex = 1 Then
            LabelPrincipal.Text = "Ocupación"
        End If
        If NavigationFrame1.SelectedPageIndex = 2 Then
            LabelPrincipal.Text = "Reabastecimiento"
        End If
        If NavigationFrame1.SelectedPageIndex = 3 Then
            LabelPrincipal.Text = "Ejercicios de inventario"
        End If
        If NavigationFrame1.SelectedPageIndex = 4 Then
            LabelPrincipal.Text = "Ejercicios por producto"
        End If
        If NavigationFrame1.SelectedPageIndex = 5 Then
            LabelPrincipal.Text = "Ejercicios por posición"
        End If
        If NavigationFrame1.SelectedPageIndex = 6 Then
            LabelPrincipal.Text = "Tiempo colocación pallet"
        End If
        If NavigationFrame1.SelectedPageIndex = 7 Then
            LabelPrincipal.Text = "Colocaciones"
        End If
    End Sub

    Private Sub BtnBuscar_Click_1(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Try

            llenarPantallaDashboard()


        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub

    Private Sub SimpleButton1_Click_1(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        NavigationFrame1.SelectPrevPage()
        CambiarLabel()

    End Sub

    Private Sub SimpleButton2_Click_1(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        NavigationFrame1.SelectNextPage()
        CambiarLabel()
    End Sub

    Private Sub Almacén_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim FechaFin As Date = Date.Now
        Dim FechaInicio As Date = FechaFin.AddDays(-20)
        dtpFechaInicio.Text = FechaInicio
        dtpFechaFin.Text = FechaFin

        llenarPantallaDashboard()
    End Sub


End Class