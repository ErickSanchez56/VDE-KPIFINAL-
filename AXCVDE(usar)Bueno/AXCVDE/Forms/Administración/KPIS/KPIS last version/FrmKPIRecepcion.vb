Imports DevExpress.XtraCharts
Imports DevExpress.XtraEditors
Imports DevExpress.Utils
Imports DevExpress.XtraGrid.Views.Grid


Public Class FrmKPIRecepcion
    Public activaInfo As Boolean = True
#Region "Principal"
    Private Sub FrmTiempoRecepcion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim fecha1 As Date = New Date(2022, 11, 25)
        Dim fecha1 As Date = Date.Now
        fecha1 = fecha1.AddDays(-7)
        Dim fecha2 As Date = Date.Now
        dtpFechaInicio.Text = (fecha1)
        dtpFechaFin.Text = (fecha2)

        DatosCicloRecibo(fecha1, fecha2)
        PorcentajeOrdenes(fecha1, fecha2)
        KPITiempoPromedioRecepcion(fecha1, fecha2)
        PorcentajePallets(fecha1, fecha2)
        TiempoPromedioPallets(fecha1, fecha2)
        PorcentajePalletsPendientes(fecha1, fecha2)



    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Dim fecha1 As New Date
        Dim fecha2 As New Date

        If String.IsNullOrEmpty(dtpFechaInicio.Text) Then
            'fecha1 = New Date(2022, 11, 25)
            fecha1 = Date.Now
            fecha1 = fecha1.AddDays(-7)
            dtpFechaInicio.Text = (fecha1)
        Else
            fecha1 = Date.Parse(dtpFechaInicio.EditValue.ToString)
        End If


        If String.IsNullOrEmpty(dtpFechaFin.Text) Then
            fecha2 = Date.Now
            dtpFechaFin.Text = (fecha2)
        Else
            fecha2 = Date.Parse(dtpFechaFin.EditValue.ToString)
        End If


        DatosCicloRecibo(fecha1, fecha2)
        PorcentajeOrdenes(fecha1, fecha2)
        KPITiempoPromedioRecepcion(fecha1, fecha2)
        PorcentajePallets(fecha1, fecha2)
        TiempoPromedioPallets(fecha1, fecha2)
        PorcentajePalletsPendientes(fecha1, fecha2)
    End Sub

#End Region

#Region "Pestaña 1"
    Private Sub DatosCicloRecibo(prmFechaInicio As Date, prmFechaFin As Date)
        Try
            Dim pResultado As New CResultado
            Dim Cls As New clsKPIRecepcion
            Dim ds As New DataSet


            GridControl1.DataSource = Nothing


            Cursor.Current = Cursors.WaitCursor
            pResultado = Cls.ClsDatosCicloRecibo(prmFechaInicio, prmFechaFin, My.Settings.Estacion, DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                GridControl1.DataSource = Nothing
                Return
            End If


            ds = pResultado.Tablas


            Dim tablaPromedioGeneral As DataTable
            Dim tablaDetalleOrdenes As DataTable

            tablaPromedioGeneral = ds.Tables(1)
            tablaDetalleOrdenes = ds.Tables(2)


            If tablaPromedioGeneral.Rows.Count < 1 Then
                XtraMessageBox.Show("Sin información en el sistema", "AXC", MessageBoxButtons.OK)
                GridControl1.DataSource = Nothing
                Return
            End If

            DigitalGauge1.Text = tablaPromedioGeneral.Rows(0).Item("Días")
            DigitalGauge2.Text = tablaPromedioGeneral.Rows(0).Item("Horas")
            DigitalGauge3.Text = tablaPromedioGeneral.Rows(0).Item("Minutos")


        Catch ex As Exception
            XtraMessageBox.Show(ex.Message.ToString, "Error", MessageBoxButtons.OK)
        End Try
    End Sub


    Private Sub PorcentajeOrdenes(prmFechaInicio As Date, prmFechaFin As Date)
        Try
            Dim pResultado As New CResultado
            Dim Cls As New clsKPIRecepcion
            Dim dt As New DataTable

            dt = pResultado.Tabla


            GridControl7.DataSource = Nothing


            Cursor.Current = Cursors.WaitCursor
            pResultado = Cls.PorcentajeOrdenesRecepcion(prmFechaInicio, prmFechaFin, My.Settings.Estacion, DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                GridControl7.DataSource = Nothing
                Return
            End If

            Dim ds As New DataSet

            dt = pResultado.Tabla
            ds.Tables.Add(dt)


            Dim tablaGeneral As DataTable
            tablaGeneral = dt
            Dim tablaDetalle As DataTable
            tablaDetalle = pResultado.Tablas.Tables(2)

            Dim tablahistorial As DataTable
            tablahistorial = pResultado.Tablas.Tables(3)



            If dt.Rows.Count < 1 Then
                XtraMessageBox.Show("Sin información en el sistema", "AXC", MessageBoxButtons.OK)
                GridControl7.DataSource = Nothing
                Return
            End If


            GridControl7.DataSource = tablaDetalle
            GridView7.BestFitColumns()

            Label1.Text = tablaGeneral.Rows(0).Item("TotalPartidas")
            Label2.Text = tablaGeneral.Rows(0).Item("PartidasCompletas")
            Label3.Text = tablaGeneral.Rows(0).Item("PartidasPendientes")
            Label12.Text = tablaGeneral.Rows(0).Item("PartidasRecibiendo")

            LabelControl37.Text = tablaGeneral.Rows(0).Item("porcentajePartidasCompletas")
            LabelControl37.Text = LabelControl37.Text + "%"
            LabelControl38.Text = tablaGeneral.Rows(0).Item("porcentajePartidasPendientes")
            LabelControl38.Text = LabelControl38.Text + "%"
            LabelControl52.Text = tablaGeneral.Rows(0).Item("porcentajePartidasProceso")
            LabelControl52.Text = LabelControl52.Text + "%"



            NordenesTotales.Text = tablaGeneral.Rows(0).Item("total")
            NordenesPendientes.Text = tablaGeneral.Rows(0).Item("pendientes")
            NordenesProceso.Text = tablaGeneral.Rows(0).Item("recibiendo")
            NordenesRecibidas.Text = tablaGeneral.Rows(0).Item("completos")


            LblPorcentajePendientes.Text = tablaGeneral.Rows(0).Item("porcentajePendiente")
            LblPorcentajePendientes.Text = LblPorcentajePendientes.Text + "%"
            LblPorcentajesProceso.Text = tablaGeneral.Rows(0).Item("porcentajeRecibiendo")
            LblPorcentajesProceso.Text = LblPorcentajesProceso.Text + "%"
            LblPorcentajesRecibidas.Text = tablaGeneral.Rows(0).Item("porcentajeCompleto")
            LblPorcentajesRecibidas.Text = LblPorcentajesRecibidas.Text + "%"


            'pestaña ordenes
            Label10.Text = tablaGeneral.Rows(0).Item("total")
            Label9.Text = tablaGeneral.Rows(0).Item("pendientes")
            Label8.Text = tablaGeneral.Rows(0).Item("recibiendo")
            Label11.Text = tablaGeneral.Rows(0).Item("completos")


            LabelControl41.Text = tablaGeneral.Rows(0).Item("porcentajePendiente")
            LabelControl41.Text = LabelControl41.Text + "%"
            LabelControl39.Text = tablaGeneral.Rows(0).Item("porcentajeRecibiendo")
            LabelControl39.Text = LabelControl39.Text + "%"
            LabelControl50.Text = tablaGeneral.Rows(0).Item("porcentajeCompleto")
            LabelControl50.Text = LabelControl50.Text + "%"





            '--------------------------------------------------DONA----------------------------------------------
            Dim series1 As New Series("Doughnut Series 1", ViewType.Pie)

            ' Populate the series with points.
            ChartControl1.Series.Clear()
            ChartControl1.Titles.Clear()
            ChartControl1.DataSource = tablaGeneral
            series1.Points.Add(New SeriesPoint("Pendientes", dt.Rows(0).Item("porcentajePendiente")))
            series1.Points.Add(New SeriesPoint("En Proceso", dt.Rows(0).Item("porcentajeRecibiendo")))
            series1.Points.Add(New SeriesPoint("Completas", dt.Rows(0).Item("porcentajeCompleto")))


            '' series1.Points.Add(New SeriesPoint("TOTAL ENVIADAS", dt.Rows(0).Item("Totalembarques")))
            ' Add the series to the chart.
            ChartControl1.Series.Add(series1)
            ChartControl1.Legend.Title.Text = "Porcentaje"
            ChartControl1.Legend.Title.Font = New Font("Calibri", 12, FontStyle.Bold)
            ChartControl1.Legend.Title.TextColor = Color.AliceBlue
            ChartControl1.Legend.Title.Visible = True
            ChartControl1.Legend.MarkerMode = LegendMarkerMode.Marker
            'ChartControl3.Legend


            ' Adjust the value numeric options of the series.
            series1.PointOptions.ValueNumericOptions.Format = NumericFormat.Percent
            series1.PointOptions.ValueNumericOptions.Precision = 2



            ' Add a title to the chart and hide the legend.
            Dim chartTitle1 As New ChartTitle()
            chartTitle1.Text = "Órdenes de recepción"
            ChartControl1.Titles.Add(chartTitle1)
            ChartControl1.Legend.Visible = False



            ' Add the chart to the form.
            ChartControl1.Dock = DockStyle.None
            'Rotacion de Char3d
            ChartControl1.RuntimeRotation = True



            '===========================================PUNTOS============================
            ChartOrdenesembXDIA.Titles.Clear()
            ChartOrdenesembXDIA.Series.Clear()


            ChartOrdenesembXDIA.DataSource = tablahistorial


            If tablahistorial.Rows.Count > 0 Then
                Dim series() As Series
                ReDim series(0)
                Dim contador = 0
                For Each rowAlm As DataRow In tablahistorial.Rows
                    series(contador) = New Series(rowAlm.Item("Almacen"), ViewType.Line)

                    Dim almacen = rowAlm.Item("Almacen")
                    For Each rowOcupados As DataRow In tablahistorial.Rows
                        If rowOcupados.Item("Almacen") = almacen Then
                            series(contador).Points.Add(New SeriesPoint(rowOcupados.Item("Fecha"), rowOcupados.Item("Órdenes recibidas")))
                        End If

                    Next
                    ChartOrdenesembXDIA.Series.Add(series(contador))


                    CType(series(contador).View, LineSeriesView).MarkerVisibility = DevExpress.Utils.DefaultBoolean.True
                    CType(series(contador).View, LineSeriesView).LineMarkerOptions.Size = 10
                    CType(series(contador).View, LineSeriesView).LineMarkerOptions.Kind = MarkerKind.Circle
                    CType(series(contador).View, LineSeriesView).LineStyle.DashStyle = DashStyle.Dash
                    Exit For
                Next

                ' Add a title to the chart and hide the legend.
                Dim chartTitle2 As New ChartTitle()
                chartTitle2.Text = "Total de órdenes de recepción por día"
                ChartOrdenesembXDIA.Titles.Add(chartTitle2)
                ChartOrdenesembXDIA.Legend.Visible = False


                'Cast the chart's diagram to the XYDiagram type, to access its axes.
                Dim diagram As XYDiagram = CType(ChartOrdenesembXDIA.Diagram, XYDiagram)
                Dim axisX As AxisX = diagram.AxisX
                axisX.Label.Angle = 315

                diagram.EnableAxisXScrolling = True
                diagram.EnableAxisXZooming = True

                diagram.EnableAxisYScrolling = True
                diagram.EnableAxisYZooming = True


            End If




        Catch ex As Exception
            XtraMessageBox.Show(ex.Message.ToString, "Error", MessageBoxButtons.OK)
        End Try
    End Sub

#End Region
#Region "Pestaña 2"
    Private Sub KPITiempoPromedioRecepcion(prmFechaInicio As Date, prmFechaFin As Date)
        Try
            Dim pResultado As New CResultado
            Dim Cls As New clsKPIRecepcion
            Dim dt As New DataTable

            dt = pResultado.Tabla


            GridControl1.DataSource = Nothing


            Cursor.Current = Cursors.WaitCursor
            pResultado = Cls.ClsKPITiempoPromedioRecepcion(prmFechaInicio, prmFechaFin, My.Settings.Estacion, DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                GridControl1.DataSource = Nothing
                Return
            End If

            Dim ds As New DataSet

            dt = pResultado.Tabla
            ds.Tables.Add(dt)


            Dim tablaPromedioGeneral As DataTable
            Dim tablaPromedioPartidas As DataTable
            Dim tablaDetalleOrdenes As DataTable



            tablaPromedioGeneral = pResultado.Tablas.Tables(1)
            tablaPromedioPartidas = pResultado.Tablas.Tables(2)
            tablaDetalleOrdenes = pResultado.Tablas.Tables(3)



            If dt.Rows.Count < 1 Then
                XtraMessageBox.Show("Sin información en el sistema", "AXC", MessageBoxButtons.OK)
                GridControl1.DataSource = Nothing
                Return
            End If

            'Pestaña
            DigitalGauge6.Text = tablaPromedioGeneral.Rows(0).Item("Días")
            DigitalGauge5.Text = tablaPromedioGeneral.Rows(0).Item("Horas")
            DigitalGauge4.Text = tablaPromedioGeneral.Rows(0).Item("Minutos")


            DigitalGauge12.Text = tablaPromedioPartidas.Rows(0).Item("Días")
            DigitalGauge11.Text = tablaPromedioPartidas.Rows(0).Item("Horas")
            DigitalGauge10.Text = tablaPromedioPartidas.Rows(0).Item("Minutos")

            GridControl1.DataSource = tablaDetalleOrdenes
            GridView1.Columns("TotalMinutos").Visible = False
            GridView1.Columns("TotalHoras").Visible = False
            GridView1.BestFitColumns()

            ChartControl2.Titles.Clear()
            ChartControl2.Series.Clear()
            ChartControl2.DataSource = tablaDetalleOrdenes
            ChartControl2.Titles.Add(New ChartTitle() With {.Text = "Órdenes con mayor tiempo de recepción"})
            ChartControl2.Legend.Title.Text = "Órdenes"
            ChartControl2.Legend.Title.Font = New Font("Calibri", 12, FontStyle.Bold)
            ChartControl2.Legend.Title.TextColor = Color.AliceBlue
            ChartControl2.Legend.Title.Visible = True
            ChartControl2.SeriesDataMember = "Orden"
            ChartControl2.SeriesTemplate.ValueDataMembers.AddRange(New String() {"TotalHoras"})
            ChartControl2.SeriesTemplate.ArgumentDataMember = "No"
            ChartControl2.RuntimeHitTesting = True
            Dim view As SideBySideBarSeriesView = TryCast(ChartControl2.SeriesTemplate.View, SideBySideBarSeriesView)
            Dim diagram As XYDiagram = CType(ChartControl2.Diagram, XYDiagram)

            Dim axisX As AxisX = diagram.AxisX
            'axisX.Label.Angle = -90
            axisX.QualitativeScaleOptions.AutoGrid = False


            diagram.AxisX.Title.Visible = True
            diagram.AxisX.Title.Alignment = StringAlignment.Center
            diagram.AxisX.Title.Text = "Órdenes"
            diagram.AxisX.Title.TextColor = Color.White
            diagram.AxisX.Title.Antialiasing = True

            diagram.AxisY.Title.Visible = True
            diagram.AxisY.Title.Alignment = StringAlignment.Center
            diagram.AxisY.Title.Text = "Tiempo en Horas"
            diagram.AxisY.Title.TextColor = Color.White
            diagram.AxisY.Title.Antialiasing = True

            diagram.EnableAxisXScrolling = True
            diagram.EnableAxisXZooming = True
            diagram.EnableAxisYScrolling = True
            diagram.EnableAxisYZooming = True
            view.BarDistance = 0.5
            view.BarDistanceFixed = 0.5
            view.BarWidth = 3

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message.ToString, "Error", MessageBoxButtons.OK)
        End Try
    End Sub
#End Region


#Region "PAGINA 3"
    Private Sub PorcentajePallets(prmFechaInicio As Date, prmFechaFin As Date)
        Try
            Dim pResultado As New CResultado
            Dim Cls As New clsKPIRecepcion
            Dim dt As New DataTable

            dt = pResultado.Tabla


            'GridControl1.DataSource = Nothing


            Cursor.Current = Cursors.WaitCursor
            pResultado = Cls.PorcentajeKPIPallets(prmFechaInicio, prmFechaFin, My.Settings.Estacion, DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                'GridControl1.DataSource = Nothing
                Return
            End If

            Dim ds As New DataSet

            dt = pResultado.Tabla
            ds.Tables.Add(dt)


            Dim tablaCantidad As DataTable
            Dim tablaPorcentaje As DataTable


            tablaCantidad = pResultado.Tablas.Tables(1)
            tablaPorcentaje = pResultado.Tablas.Tables(2)


            If dt.Rows.Count < 1 Then
                XtraMessageBox.Show("Sin información en el sistema", "AXC", MessageBoxButtons.OK)
                'GridControl1.DataSource = Nothing
                Return
            End If





            'RESUMEN

            Label4.Text = tablaCantidad.Rows(0).Item("ContadorCreacion")
            Label6.Text = tablaCantidad.Rows(0).Item("ContadorCalidad")
            Label7.Text = tablaCantidad.Rows(0).Item("ContadorAlmacen")
            Label5.Text = tablaCantidad.Rows(0).Item("ContadorColocacion")


            LabelControl17.Text = tablaPorcentaje.Rows(0).Item("Creacion")
            LabelControl17.Text = LabelControl17.Text + "%"
            LabelControl32.Text = tablaPorcentaje.Rows(0).Item("Calidad")
            LabelControl32.Text = LabelControl32.Text + "%"
            LabelControl34.Text = tablaPorcentaje.Rows(0).Item("Almacen")
            LabelControl34.Text = LabelControl34.Text + "%"
            LabelControl28.Text = tablaPorcentaje.Rows(0).Item("Colocacion")
            LabelControl28.Text = LabelControl28.Text + "%"






            '--------------------------------------------------DONA Resumen----------------------------------------------
            Dim series2 As New Series("Doughnut Series 1", ViewType.Pie)

            ' Populate the series with points.
            ChartControl3.Series.Clear()
            ChartControl3.Titles.Clear()
            ChartControl3.DataSource = tablaPorcentaje
            series2.Points.Add(New SeriesPoint("Pendientes validar almacen", tablaPorcentaje.Rows(0).Item("Calidad")))
            series2.Points.Add(New SeriesPoint("Sin colocar", tablaPorcentaje.Rows(0).Item("Almacen")))
            series2.Points.Add(New SeriesPoint("Colocados", tablaPorcentaje.Rows(0).Item("Colocacion")))
            series2.Points.Add(New SeriesPoint("Pendientes validar calidad", tablaPorcentaje.Rows(0).Item("Creacion")))




            '' series2.Points.Add(New SeriesPoint("TOTAL ENVIADAS", dt.Rows(0).Item("Totalembarques")))
            ' Add the series to the chart.
            ChartControl3.Series.Add(series2)
            ChartControl3.Legend.Title.Text = "Porcentaje"
            ChartControl3.Legend.Title.Font = New Font("Calibri", 12, FontStyle.Bold)
            ChartControl3.Legend.Title.TextColor = Color.AliceBlue
            ChartControl3.Legend.Title.Visible = True
            ChartControl3.Legend.MarkerMode = LegendMarkerMode.Marker



            ' Adjust the value numeric options of the series.
            series2.PointOptions.ValueNumericOptions.Format = NumericFormat.Percent
            series2.PointOptions.ValueNumericOptions.Precision = 2



            ' Add a title to the chart and hide the legend.
            Dim chartTitle2 As New ChartTitle()
            chartTitle2.Text = "Pallets recibidos por estatus"
            ChartControl3.Titles.Add(chartTitle2)
            ChartControl3.Legend.Visible = False



            ' Add the chart to the form.
            ChartControl3.Dock = DockStyle.None
            'Rotacion de Char3d
            ChartControl3.RuntimeRotation = True


        Catch ex As Exception
            XtraMessageBox.Show(ex.Message.ToString, "Error", MessageBoxButtons.OK)
        End Try
    End Sub



    Private Sub PorcentajePalletsPendientes(prmFechaInicio As Date, prmFechaFin As Date)
        Try
            Dim pResultado As New CResultado
            Dim Cls As New clsKPIRecepcion
            Dim dt As New DataTable

            dt = pResultado.Tabla


            ChartControl3.DataSource = Nothing


            Cursor.Current = Cursors.WaitCursor
            pResultado = Cls.PorcentajeKPIPalletsPendientes(prmFechaInicio, prmFechaFin, My.Settings.Estacion, DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                ChartControl3.DataSource = Nothing
                Return
            End If

            Dim ds As New DataSet

            dt = pResultado.Tabla
            ds.Tables.Add(dt)


            Dim tablaCantidad As DataTable
            Dim tablaPorcentaje As DataTable
            Dim tablaDetallepallets As DataTable

            tablaCantidad = pResultado.Tablas.Tables(1)
            tablaPorcentaje = pResultado.Tablas.Tables(2)
            tablaDetallepallets = pResultado.Tablas.Tables(3)

            If dt.Rows.Count < 1 Then
                XtraMessageBox.Show("Sin información en el sistema", "AXC", MessageBoxButtons.OK)
                ChartControl3.DataSource = Nothing
                Return
            End If


            GridControl5.DataSource = tablaDetallepallets
            GridView5.BestFitColumns()



            'Dim color3 As Color = System.Drawing.ColorTranslator.FromHtml("#EB641B")
            'Dim color2 As Color = System.Drawing.ColorTranslator.FromHtml("#DA1F28")
            'Dim color1 As Color = System.Drawing.ColorTranslator.FromHtml("#0080FF")


            'AddHandler GridView5.RowCellStyle, Sub(sender, e)
            '                                       Dim view2 As GridView = TryCast(sender, GridView)
            '                                       Dim marca As String = (view2.GetRowCellValue(e.RowHandle, "Estatus"))
            '                                       If e.Column.FieldName = "Estatus" Then
            '                                           If marca = "Pendiente validar calidad" Then
            '                                               e.Appearance.BackColor = color3
            '                                           End If

            '                                           If marca = "Pendiente validar almacén" Then
            '                                               e.Appearance.BackColor = color1
            '                                           End If

            '                                           If marca = "Sin colocar" Then
            '                                               e.Appearance.BackColor = color2
            '                                           End If

            '                                       End If
            '                                   End Sub


            LblCantidadTotal.Text = tablaCantidad.Rows(0).Item("ContadorTotal")
            LblCantidadCalidad.Text = tablaCantidad.Rows(0).Item("ContadorCalidad")
            LblCantidadAlmacen.Text = tablaCantidad.Rows(0).Item("ContadorAlmacen")
            LblCantidadCreacion.Text = tablaCantidad.Rows(0).Item("ContadorCreacion")



            LblPorcentajeCalidad.Text = tablaPorcentaje.Rows(0).Item("Calidad")
            LblPorcentajeCalidad.Text = LblPorcentajeCalidad.Text + "%"
            LblPorcentajeAlmacen.Text = tablaPorcentaje.Rows(0).Item("Almacen")
            LblPorcentajeAlmacen.Text = LblPorcentajeAlmacen.Text + "%"
            LblPorcentajeCreacion.Text = tablaPorcentaje.Rows(0).Item("Creacion")
            LblPorcentajeCreacion.Text = LblPorcentajeCreacion.Text + "%"






            '--------------------------------------------------DONA----------------------------------------------
            Dim series1 As New Series("Doughnut Series 1", ViewType.Pie)

            ' Populate the series with points.
            ChartControl4.Series.Clear()
            ChartControl4.Titles.Clear()
            ChartControl4.DataSource = tablaPorcentaje
            series1.Points.Add(New SeriesPoint("Pendientes validar almacen", tablaPorcentaje.Rows(0).Item("Calidad")))
            series1.Points.Add(New SeriesPoint("Sin colocar", tablaPorcentaje.Rows(0).Item("Almacen")))
            series1.Points.Add(New SeriesPoint("Pendientes validar calidad", tablaPorcentaje.Rows(0).Item("Creacion")))




            '' series1.Points.Add(New SeriesPoint("TOTAL ENVIADAS", dt.Rows(0).Item("Totalembarques")))
            ' Add the series to the chart.
            ChartControl4.Series.Add(series1)
            ChartControl4.Legend.Title.Text = "Porcentaje"
            ChartControl4.Legend.Title.Font = New Font("Calibri", 12, FontStyle.Bold)
            ChartControl4.Legend.Title.TextColor = Color.AliceBlue
            ChartControl4.Legend.Title.Visible = True
            ChartControl4.Legend.MarkerMode = LegendMarkerMode.Marker



            ' Adjust the value numeric options of the series.
            series1.PointOptions.ValueNumericOptions.Format = NumericFormat.Percent
            series1.PointOptions.ValueNumericOptions.Precision = 2



            ' Add a title to the chart and hide the legend.
            Dim chartTitle1 As New ChartTitle()
            chartTitle1.Text = "Pallets pendientes por colocar"
            ChartControl4.Titles.Add(chartTitle1)
            ChartControl4.Legend.Visible = False



            ' Add the chart to the form.
            ChartControl4.Dock = DockStyle.None
            'Rotacion de Char3d
            ChartControl4.RuntimeRotation = True



        Catch ex As Exception
            XtraMessageBox.Show(ex.Message.ToString, "Error", MessageBoxButtons.OK)
        End Try
    End Sub


    Private Sub TiempoPromedioPallets(prmFechaInicio As Date, prmFechaFin As Date)
        Try
            Dim pResultado As New CResultado
            Dim Cls As New clsKPIRecepcion
            Dim dt As New DataTable

            dt = pResultado.Tabla


            GridControl2.DataSource = Nothing


            Cursor.Current = Cursors.WaitCursor
            pResultado = Cls.KPITiempoUbicaciónPalletRecepcion(prmFechaInicio, prmFechaFin, My.Settings.Estacion, DatosTemporales.Usuario)
            Cursor.Current = Cursors.Default

            If Not pResultado.Estado Then
                XtraMessageBox.Show(pResultado.Texto)
                GridControl2.DataSource = Nothing
                Return
            End If

            Dim ds As New DataSet

            dt = pResultado.Tabla
            ds.Tables.Add(dt)

            Dim tablaPromedioGeneral As DataTable
            Dim tablaPromedioCalidad As DataTable
            Dim tablaPromedioAlmacen As DataTable
            Dim tablaPromedioColocación As DataTable
            Dim tablaRangos As DataTable
            Dim tablaDetalle As DataTable

            tablaPromedioGeneral = pResultado.Tablas.Tables(1)
            tablaPromedioCalidad = pResultado.Tablas.Tables(2)
            tablaPromedioAlmacen = pResultado.Tablas.Tables(3)
            tablaPromedioColocación = pResultado.Tablas.Tables(4)
            tablaRangos = pResultado.Tablas.Tables(5)
            tablaDetalle = pResultado.Tablas.Tables(6)


            If dt.Rows.Count < 1 Then
                XtraMessageBox.Show("Sin información en el sistema", "AXC", MessageBoxButtons.OK)
                GridControl2.DataSource = Nothing
                Return
            End If

            GridControl2.DataSource = tablaDetalle
            GridView2.BestFitColumns()

            'Dim rango5 As Color = System.Drawing.ColorTranslator.FromHtml("#474B78")
            'Dim rango4 As Color = System.Drawing.ColorTranslator.FromHtml("#39639D")
            'Dim rango3 As Color = System.Drawing.ColorTranslator.FromHtml("#EB641B")
            'Dim rango2 As Color = System.Drawing.ColorTranslator.FromHtml("#DA1F28")
            'Dim rango1 As Color = System.Drawing.ColorTranslator.FromHtml("#0080FF")


            'AddHandler GridView2.RowCellStyle, Sub(sender, e)
            '                                       Dim view2 As GridView = TryCast(sender, GridView)
            '                                       Dim marca As String = (view2.GetRowCellValue(e.RowHandle, "Rango"))
            '                                       If e.Column.FieldName = "Rango" Then
            '                                           If marca = "R1" Then
            '                                               e.Appearance.BackColor = rango1
            '                                           End If

            '                                           If marca = "R2" Then
            '                                               e.Appearance.BackColor = rango2
            '                                           End If

            '                                           If marca = "R3" Then
            '                                               e.Appearance.BackColor = rango3
            '                                           End If


            '                                           If marca = "R4" Then
            '                                               e.Appearance.BackColor = rango4
            '                                           End If

            '                                           If marca = "R5" Then
            '                                               e.Appearance.BackColor = rango5
            '                                           End If

            '                                       End If
            '                                   End Sub


            'Calidad
            DigitalGauge9.Text = tablaPromedioCalidad.Rows(0).Item("Dias")
            DigitalGauge8.Text = tablaPromedioCalidad.Rows(0).Item("Horas")
            DigitalGauge7.Text = tablaPromedioCalidad.Rows(0).Item("Minutos")

            'Almacen
            DigitalGauge15.Text = tablaPromedioAlmacen.Rows(0).Item("Dias")
            DigitalGauge14.Text = tablaPromedioAlmacen.Rows(0).Item("Horas")
            DigitalGauge13.Text = tablaPromedioAlmacen.Rows(0).Item("Minutos")

            'Colocacion
            DigitalGauge18.Text = tablaPromedioColocación.Rows(0).Item("Dias")
            DigitalGauge17.Text = tablaPromedioColocación.Rows(0).Item("Horas")
            DigitalGauge16.Text = tablaPromedioColocación.Rows(0).Item("Minutos")


            ChartControl5.Titles.Clear()
            ChartControl5.Series.Clear()
            ChartControl5.DataSource = tablaRangos
            ChartControl5.Titles.Add(New ChartTitle() With {.Text = "Pallets recibidos por rangos de tiempo"})
            ChartControl5.Legend.Title.Text = "Rangos"
            ChartControl5.Legend.Title.Font = New Font("Calibri", 12, FontStyle.Bold)
            ChartControl5.Legend.Title.TextColor = Color.AliceBlue
            ChartControl5.Legend.Title.Visible = True
            ChartControl5.SeriesDataMember = "Rangos"
            ChartControl5.SeriesTemplate.ValueDataMembers.AddRange(New String() {"Cantidades"})
            ChartControl5.SeriesTemplate.ArgumentDataMember = "Rangos"
            ChartControl5.RuntimeHitTesting = True
            Dim view As SideBySideBarSeriesView = TryCast(ChartControl5.SeriesTemplate.View, SideBySideBarSeriesView)
            Dim diagram As XYDiagram = CType(ChartControl5.Diagram, XYDiagram)

            Dim axisX As AxisX = diagram.AxisX
            'axisX.Label.Angle = -90
            axisX.QualitativeScaleOptions.AutoGrid = False


            diagram.AxisX.Title.Visible = True
            diagram.AxisX.Title.Alignment = StringAlignment.Center
            diagram.AxisX.Title.Text = "Horas"
            diagram.AxisX.Title.TextColor = Color.White
            diagram.AxisX.Title.Antialiasing = True

            diagram.AxisY.Title.Visible = True
            diagram.AxisY.Title.Alignment = StringAlignment.Center
            diagram.AxisY.Title.Text = "Cantidad"
            diagram.AxisY.Title.TextColor = Color.White
            diagram.AxisY.Title.Antialiasing = True

            diagram.EnableAxisXScrolling = True
            diagram.EnableAxisXZooming = True
            diagram.EnableAxisYScrolling = True
            diagram.EnableAxisYZooming = True
            view.BarDistance = 0.5
            view.BarDistanceFixed = 0.5
            view.BarWidth = 3

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message.ToString, "Error", MessageBoxButtons.OK)
        End Try
    End Sub

#End Region


#Region "Navegadores"
    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        NavigationFrame1.SelectNextPage()
        CambiarLabel()
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        NavigationFrame1.SelectPrevPage()
        CambiarLabel()
    End Sub

    Private Sub CambiarLabel()
        If NavigationFrame1.SelectedPageIndex = 0 Then
            LabelPrincipal.Text = "Resumen"
        End If
        If NavigationFrame1.SelectedPageIndex = 1 Then
            LabelPrincipal.Text = "Tiempo promedio recepción"
        End If
        If NavigationFrame1.SelectedPageIndex = 2 Then
            LabelPrincipal.Text = "Órdenes de recepción"
        End If
        If NavigationFrame1.SelectedPageIndex = 3 Then
            LabelPrincipal.Text = "Detalle Pallets"
        End If
    End Sub

    Private Sub Panel6_Click(sender As Object, e As EventArgs) Handles Panel6.Click
        If activaInfo Then
            XtraMessageBox.Show("Muestra el total de órdenes de recibo de las fechas seleccionadas / Desde " + dtpFechaInicio.Text + " hasta " + dtpFechaFin.Text + "", "AXC")
        End If
    End Sub

    Private Sub LabelControl12_Click(sender As Object, e As EventArgs) Handles LabelControl12.Click
        If activaInfo Then
            XtraMessageBox.Show("Muestra el total de órdenes de recibo de las fechas seleccionadas / Desde " + dtpFechaInicio.Text + " hasta " + dtpFechaFin.Text + "", "AXC")
        End If
    End Sub

    Private Sub Panel8_Click(sender As Object, e As EventArgs) Handles Panel8.Click
        If activaInfo Then
            XtraMessageBox.Show("Muestra el total de órdenes de recepción que se han liberado y no se han comenzado a recibir, / Desde " + dtpFechaInicio.Text + " hasta " + dtpFechaFin.Text + "", "AXC")
        End If
    End Sub

    Private Sub LabelControl48_Click(sender As Object, e As EventArgs) Handles LabelControl48.Click
        If activaInfo Then
            XtraMessageBox.Show("Muestra el total de órdenes de recepción que se han liberado y no se han comenzado a recibir, / Desde " + dtpFechaInicio.Text + " hasta " + dtpFechaFin.Text + "", "AXC")
        End If
    End Sub

    Private Sub Panel5_Click(sender As Object, e As EventArgs) Handles Panel5.Click
        If activaInfo Then
            XtraMessageBox.Show("Muestra el total de órdenes de recepción que se han liberado, y aun no finaliza la recepción, / Desde " + dtpFechaInicio.Text + " hasta " + dtpFechaFin.Text + "", "AXC")
        End If
    End Sub

    Private Sub LabelControl45_Click(sender As Object, e As EventArgs) Handles LabelControl45.Click
        If activaInfo Then
            XtraMessageBox.Show("Muestra el total de órdenes de recepción que se han liberado, y aun no finaliza la recepción, / Desde " + dtpFechaInicio.Text + " hasta " + dtpFechaFin.Text + "", "AXC")
        End If
    End Sub

    Private Sub Panel1_Click(sender As Object, e As EventArgs) Handles Panel1.Click
        If activaInfo Then
            XtraMessageBox.Show("Muestra el total de órdenes de recepción que se han liberado y se completo la recepción, / Desde " + dtpFechaInicio.Text + " hasta " + dtpFechaFin.Text + "", "AXC")
        End If
    End Sub

    Private Sub LabelControl7_Click(sender As Object, e As EventArgs) Handles LabelControl7.Click
        If activaInfo Then
            XtraMessageBox.Show("Muestra el total de órdenes de recepción que se han liberado y se completo la recepción, / Desde " + dtpFechaInicio.Text + " hasta " + dtpFechaFin.Text + "", "AXC")
        End If
    End Sub

    Private Sub Panel12_Click(sender As Object, e As EventArgs) Handles Panel12.Click

    End Sub





#End Region

End Class