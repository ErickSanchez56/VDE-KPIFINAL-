Imports AXCDemo

Public Class clsKPI
    Friend Function ResultadoListaOrdenesProd(ByVal prmFecha2 As Date, ByVal prmFecha3 As Date) As CResultado
        Dim pRespuesta As New CResultado
        Try
            Dim db As New CAccesoDatos
            Dim pResultado As CResultado
            Dim ds As DataSet
            Dim dt As DataTable
            Dim dt2 As DataTable
            Dim dt3 As DataTable
            Dim prmFecha = prmFecha2.ToString("yyyyMMdd")
            Dim prmFechaFin = prmFecha3.ToString("yyyyMMdd")
            pResultado = db.SPToDataSet("SpInsRegTiempoSurtidoProdHistorico", prmFecha, prmFechaFin)



            If pResultado.Estado Then
                ds = CType(pResultado.Resultado, DataSet)

                For Each dr As DataRow In ds.Tables(3).Rows

                    Select Case dr("Estado").ToString
                        Case "OK"
                            dt = ds.Tables(0).Copy
                            dt2 = ds.Tables(1).Copy
                            dt3 = ds.Tables(2).Copy
                            pRespuesta.Estado = True
                            pRespuesta.Texto = ""
                            pRespuesta.Tablas = ds.Copy()
                        Case "ER"
                            pRespuesta.Estado = False
                            pRespuesta.Texto = dr("Texto").ToString
                        Case Else
                            pRespuesta.Estado = False
                            pRespuesta.Texto = "Error en tiempo de ejecucion"
                    End Select
                Next
            Else
                pRespuesta.Estado = False
                pRespuesta.Texto = pResultado.Texto
            End If

            Return pRespuesta

        Catch ex As Exception
            pRespuesta.Estado = False
            pRespuesta.Texto = "Error en tiempo de ejecucion"
            Return pRespuesta
        End Try
    End Function
    Friend Function DatosCicloRecibo(ByVal prmNombreAlm As String, ByVal prmFecha2 As Date, ByVal prmFecha3 As Date, ByVal prmEstacion As String, ByVal prmUsuario As String) As CResultado
        Dim pRespuesta As New CResultado
        Try
            Dim db As New CAccesoDatos
            Dim pResultado As CResultado
            Dim ds As DataSet
            Dim dt As DataTable
            Dim prmFechaInicio = prmFecha2.ToString("yyyyMMdd")
            Dim prmFechaFin = prmFecha3.ToString("yyyyMMdd")
            pResultado = db.SPToDataSet("spQryKPIDatosCicloRecibo", prmNombreAlm, prmFechaInicio, prmFechaFin, prmEstacion, prmUsuario)

            If pResultado.Estado Then
                ds = CType(pResultado.Resultado, DataSet)

                For Each dr As DataRow In ds.Tables(0).Rows

                    Select Case dr("Estado").ToString
                        Case "OK"
                            dt = ds.Tables(2).Copy
                            pRespuesta.Estado = True
                            pRespuesta.Texto = ""
                            pRespuesta.Tabla = dt
                            pRespuesta.Tablas = ds
                        Case "ER"
                            pRespuesta.Estado = False
                            pRespuesta.Texto = dr("Texto").ToString
                        Case Else
                            pRespuesta.Estado = False
                            pRespuesta.Texto = "Error en tiempo de ejecucion"
                    End Select
                Next
            Else
                pRespuesta.Estado = False
                pRespuesta.Texto = pResultado.Texto
            End If

            Return pRespuesta

        Catch ex As Exception
            pRespuesta.Estado = False
            pRespuesta.Texto = "Error en tiempo de ejecucion"
            Return pRespuesta
        End Try
    End Function

    Friend Function TiempoUbicaciónPallet(ByVal prmNombreAlm As String, ByVal prmFecha2 As Date, ByVal prmFecha3 As Date, ByVal prmEstacion As String, ByVal prmUsuario As String) As CResultado
        Dim pRespuesta As New CResultado
        Try
            Dim db As New CAccesoDatos
            Dim pResultado As CResultado
            Dim ds As DataSet
            Dim dt As DataTable
            Dim prmFechaInicio = prmFecha2.ToString("yyyyMMdd")
            Dim prmFechaFin = prmFecha3.ToString("yyyyMMdd")
            pResultado = db.SPToDataSet("SpQryKPITiempoUbicacionPallet", prmNombreAlm, prmFechaInicio, prmFechaFin, prmEstacion, prmUsuario)

            If pResultado.Estado Then
                ds = CType(pResultado.Resultado, DataSet)

                For Each dr As DataRow In ds.Tables(0).Rows

                    Select Case dr("Estado").ToString
                        Case "OK"
                            dt = ds.Tables(3).Copy
                            pRespuesta.Estado = True
                            pRespuesta.Texto = ""
                            pRespuesta.Tabla = dt
                            pRespuesta.Tablas = ds
                        Case "ER"
                            pRespuesta.Estado = False
                            pRespuesta.Texto = dr("Texto").ToString
                        Case Else
                            pRespuesta.Estado = False
                            pRespuesta.Texto = "Error en tiempo de ejecucion"
                    End Select
                Next
            Else
                pRespuesta.Estado = False
                pRespuesta.Texto = pResultado.Texto
            End If

            Return pRespuesta

        Catch ex As Exception
            pRespuesta.Estado = False
            pRespuesta.Texto = "Error en tiempo de ejecucion"
            Return pRespuesta
        End Try
    End Function


    Friend Function TiempoSurtido(ByVal prmNombreAlm As String, ByVal prmFecha2 As Date, ByVal prmFecha3 As Date, ByVal prmEstacion As String, ByVal prmUsuario As String) As CResultado
        Dim pRespuesta As New CResultado
        Try
            Dim db As New CAccesoDatos
            Dim pResultado As CResultado
            Dim ds As DataSet
            Dim dt As DataTable
            Dim prmFechaInicio = prmFecha2.ToString("yyyyMMdd")
            Dim prmFechaFin = prmFecha3.ToString("yyyyMMdd")
            pResultado = db.SPToDataSet("SpQryKPITiempoSurtido", prmNombreAlm, prmFechaInicio, prmFechaFin, "TODO", prmEstacion, prmUsuario)

            If pResultado.Estado Then
                ds = CType(pResultado.Resultado, DataSet)

                For Each dr As DataRow In ds.Tables(0).Rows

                    Select Case dr("Estado").ToString
                        Case "OK"
                            dt = ds.Tables(2).Copy
                            pRespuesta.Estado = True
                            pRespuesta.Texto = ""
                            pRespuesta.Tabla = dt
                            pRespuesta.Tablas = ds
                        Case "ER"
                            pRespuesta.Estado = False
                            pRespuesta.Texto = dr("Texto").ToString
                        Case Else
                            pRespuesta.Estado = False
                            pRespuesta.Texto = "Error en tiempo de ejecucion"
                    End Select
                Next
            Else
                pRespuesta.Estado = False
                pRespuesta.Texto = pResultado.Texto
            End If

            Return pRespuesta

        Catch ex As Exception
            pRespuesta.Estado = False
            pRespuesta.Texto = "Error en tiempo de ejecucion"
            Return pRespuesta
        End Try
    End Function



    Friend Function ResultadoListaPartidasRec(ByVal prmFecha2 As DateTime, ByVal prmFecha3 As DateTime, ByVal prmEstacion As String, ByVal prmUsuario As String) As CResultado
        Dim pRespuesta As New CResultado
        Try
            Dim db As New CAccesoDatos
            Dim pResultado As CResultado
            Dim ds As DataSet
            Dim dt As DataTable
            Dim dt2 As DataTable
            Dim dt3 As DataTable
            Dim prmFecha = prmFecha2.ToString("yyyyMMdd")
            Dim prmFechaFin = prmFecha3.ToString("yyyyMMdd")
            pResultado = db.SPToDataSet("SpInsRegTiempoXPartidaHistorico1", prmFecha, prmFechaFin)



            If pResultado.Estado Then
                ds = CType(pResultado.Resultado, DataSet)

                For Each dr As DataRow In ds.Tables(3).Rows

                    Select Case dr("Estado").ToString
                        Case "OK"
                            dt = ds.Tables(0).Copy
                            dt2 = ds.Tables(1).Copy
                            dt3 = ds.Tables(2).Copy
                            pRespuesta.Estado = True
                            pRespuesta.Texto = ""
                            pRespuesta.Tablas = ds.Copy()
                        Case "ER"
                            pRespuesta.Estado = False
                            pRespuesta.Texto = dr("Texto").ToString
                        Case Else
                            pRespuesta.Estado = False
                            pRespuesta.Texto = "Error en tiempo de ejecucion"
                    End Select
                Next
            Else
                pRespuesta.Estado = False
                pRespuesta.Texto = pResultado.Texto
            End If

            Return pRespuesta

        Catch ex As Exception
            pRespuesta.Estado = False
            pRespuesta.Texto = "Error en tiempo de ejecucion"
            Return pRespuesta
        End Try
    End Function
    Friend Function KPIAlmacenamientoUtilizado(ByVal prmAlmacen As String, ByVal prmFechaInicio2 As Date, ByVal prmFechaFin2 As Date, ByVal prmEstacion As String, ByVal prmUsuario As String) As CResultado
            Dim pRespuesta As New CResultado
            Try
                Dim db As New CAccesoDatos
                Dim pResultado As CResultado
                Dim ds As DataSet
                Dim dt As DataTable
                Dim prmFechaFin As String = "@"
                Dim prmFechaInicio As String = "@"
                If IsDate(prmFechaInicio2) Then
                    prmFechaInicio = prmFechaInicio2.ToString("yyyyMMdd")
                End If

                If IsDate(prmFechaFin2) Then
                    prmFechaFin = prmFechaFin2.ToString("yyyyMMdd")
                End If

                pResultado = db.SPToDataSet("spQryKPIAlmacenamientoHistorico", prmAlmacen, prmFechaInicio, prmFechaFin, prmEstacion, prmUsuario)

                If pResultado.Estado Then
                    ds = CType(pResultado.Resultado, DataSet)

                    For Each dr As DataRow In ds.Tables(0).Rows

                        Select Case dr("Estado").ToString
                            Case "OK"
                                dt = ds.Tables(1).Copy
                                pRespuesta.Estado = True
                                pRespuesta.Texto = ""
                                pRespuesta.Tabla = dt
                                pRespuesta.Tablas = ds
                            Case "ER"
                                pRespuesta.Estado = False
                                pRespuesta.Texto = dr("Texto").ToString
                            Case Else
                                pRespuesta.Estado = False
                                pRespuesta.Texto = "Error en tiempo de ejecucion"
                        End Select
                    Next
                Else
                    pRespuesta.Estado = False
                    pRespuesta.Texto = pResultado.Texto
                End If

                Return pRespuesta

            Catch ex As Exception
                pRespuesta.Estado = False
                pRespuesta.Texto = "Error en tiempo de ejecucion"
                Return pRespuesta
            End Try
        End Function

        Friend Function KPIOrdenesCompletasEmbarcadas(ByVal prmFechaInicio2 As Date, ByVal prmFechaFin2 As Date, ByVal prmEstacion As String, ByVal prmUsuario As String) As CResultado
            Dim pRespuesta As New CResultado
            Try
                Dim db As New CAccesoDatos
                Dim pResultado As CResultado
                Dim ds As DataSet
                Dim dt As DataTable
                Dim prmFechaFin As String = "@"
                Dim prmFechaInicio As String = "@"
                If IsDate(prmFechaInicio2) Then
                    prmFechaInicio = prmFechaInicio2.ToString("yyyyMMdd")
                End If

                If IsDate(prmFechaFin2) Then
                    prmFechaFin = prmFechaFin2.ToString("yyyyMMdd")
                End If

                pResultado = db.SPToDataSet("spQryKPIOrdenesCompletasEmbarcadas", prmFechaInicio, prmFechaFin, prmEstacion, prmUsuario)

                If pResultado.Estado Then
                    ds = CType(pResultado.Resultado, DataSet)

                    For Each dr As DataRow In ds.Tables(0).Rows

                        Select Case dr("Estado").ToString
                            Case "OK"
                                dt = ds.Tables(1).Copy
                                pRespuesta.Estado = True
                                pRespuesta.Texto = ""
                                pRespuesta.Tabla = dt
                                pRespuesta.Tablas = ds
                            Case "ER"
                                pRespuesta.Estado = False
                                pRespuesta.Texto = dr("Texto").ToString
                            Case Else
                                pRespuesta.Estado = False
                                pRespuesta.Texto = "Error en tiempo de ejecucion"
                        End Select
                    Next
                Else
                    pRespuesta.Estado = False
                    pRespuesta.Texto = pResultado.Texto
                End If

                Return pRespuesta

            Catch ex As Exception
                pRespuesta.Estado = False
                pRespuesta.Texto = "Error en tiempo de ejecucion"
                Return pRespuesta
            End Try
        End Function

        Friend Function KPITiempoCicloRecepcion(ByVal prmFechaInicio2 As Date, ByVal prmFechaFin2 As Date, ByVal prmEstacion As String, ByVal prmUsuario As String) As CResultado
            Dim pRespuesta As New CResultado
            Try
                Dim db As New CAccesoDatos
                Dim pResultado As CResultado
                Dim ds As DataSet
                Dim dt As DataTable
                Dim prmFechaFin As String = "@"
                Dim prmFechaInicio As String = "@"
                If IsDate(prmFechaInicio2) Then
                    prmFechaInicio = prmFechaInicio2.ToString("yyyyMMdd")
                End If

                If IsDate(prmFechaFin2) Then
                    prmFechaFin = prmFechaFin2.ToString("yyyyMMdd")
                End If

            pResultado = db.SPToDataSet("spQryKPIDatosCicloRecibo", "@", prmFechaInicio, prmFechaFin, prmEstacion, prmUsuario)

            If pResultado.Estado Then
                    ds = CType(pResultado.Resultado, DataSet)

                    For Each dr As DataRow In ds.Tables(0).Rows

                        Select Case dr("Estado").ToString
                            Case "OK"
                                dt = ds.Tables(1).Copy
                                pRespuesta.Estado = True
                                pRespuesta.Texto = ""
                                pRespuesta.Tabla = dt
                                pRespuesta.Tablas = ds
                            Case "ER"
                                pRespuesta.Estado = False
                                pRespuesta.Texto = dr("Texto").ToString
                            Case Else
                                pRespuesta.Estado = False
                                pRespuesta.Texto = "Error en tiempo de ejecucion"
                        End Select
                    Next
                Else
                    pRespuesta.Estado = False
                    pRespuesta.Texto = pResultado.Texto
                End If

                Return pRespuesta

            Catch ex As Exception
                pRespuesta.Estado = False
                pRespuesta.Texto = "Error en tiempo de ejecucion"
                Return pRespuesta
            End Try
        End Function

        Friend Function KPIPresicionInv(ByVal prmFechaInicio2 As Date, ByVal prmFechaFin2 As Date, ByVal prmEstacion As String, ByVal prmUsuario As String) As CResultado
            Dim pRespuesta As New CResultado
            Try
                Dim db As New CAccesoDatos
                Dim pResultado As CResultado
                Dim ds As DataSet
                Dim dt As DataTable
                Dim prmFechaFin As String = "@"
                Dim prmFechaInicio As String = "@"
                If IsDate(prmFechaInicio2) Then
                    prmFechaInicio = prmFechaInicio2.ToString("yyyyMMdd")
                End If

                If IsDate(prmFechaFin2) Then
                    prmFechaFin = prmFechaFin2.ToString("yyyyMMdd")
                End If

                pResultado = db.SPToDataSet("spQryKPIPresicionInvXUbicacion", prmFechaInicio, prmFechaFin, prmEstacion, prmUsuario)

                If pResultado.Estado Then
                    ds = CType(pResultado.Resultado, DataSet)

                    For Each dr As DataRow In ds.Tables(0).Rows

                        Select Case dr("Estado").ToString
                            Case "OK"
                                dt = ds.Tables(1).Copy
                                pRespuesta.Estado = True
                                pRespuesta.Texto = ""
                                pRespuesta.Tabla = dt
                                pRespuesta.Tablas = ds
                            Case "ER"
                                pRespuesta.Estado = False
                                pRespuesta.Texto = dr("Texto").ToString
                            Case Else
                                pRespuesta.Estado = False
                                pRespuesta.Texto = "Error en tiempo de ejecucion"
                        End Select
                    Next
                Else
                    pRespuesta.Estado = False
                    pRespuesta.Texto = pResultado.Texto
                End If

                Return pRespuesta

            Catch ex As Exception
                pRespuesta.Estado = False
                pRespuesta.Texto = "Error en tiempo de ejecucion"
                Return pRespuesta
            End Try
        End Function



        Friend Function ResultadoListaEmpaques(ByVal prmNombreAlm As String, ByVal prmFecha2 As Date, ByVal prmFecha3 As Date, ByVal prmEstacion As String, ByVal prmUsuario As String) As CResultado
        Dim pRespuesta As New CResultado
        Try
            Dim db As New CAccesoDatos
            Dim pResultado As CResultado
            Dim ds As DataSet
            Dim dt As DataTable
            Dim prmFecha = prmFecha2.ToString("yyyyMMdd")
            Dim prmFechaFin = prmFecha3.ToString("yyyyMMdd")
            pResultado = db.SPToDataSet("spQryAlmacenamientoHistorico", prmNombreAlm, prmFecha, prmFechaFin, prmEstacion, prmUsuario)

            If pResultado.Estado Then
                ds = CType(pResultado.Resultado, DataSet)

                For Each dr As DataRow In ds.Tables(0).Rows

                    Select Case dr("Estado").ToString
                        Case "OK"
                            dt = ds.Tables(1).Copy
                            pRespuesta.Estado = True
                            pRespuesta.Texto = ""
                            pRespuesta.Tabla = dt
                        Case "ER"
                            pRespuesta.Estado = False
                            pRespuesta.Texto = dr("Texto").ToString
                        Case Else
                            pRespuesta.Estado = False
                            pRespuesta.Texto = "Error en tiempo de ejecucion"
                    End Select
                Next
            Else
                pRespuesta.Estado = False
                pRespuesta.Texto = pResultado.Texto
            End If

            Return pRespuesta

        Catch ex As Exception
            pRespuesta.Estado = False
            pRespuesta.Texto = "Error en tiempo de ejecucion"
            Return pRespuesta
        End Try
    End Function
    Function ListaAlmacenHistorico(ByVal prmPlanta As String, ByVal prmAlmacen As String, ByVal prmEstacion As String) As CResultado
        Dim pRespuesta As New CResultado
        Dim dt As DataTable
        Dim ds As DataSet
        Try
            Dim db As New CAccesoDatos
            Dim pResultado As CResultado

            pResultado = db.SPToDataSet("spQryListadoAlmacenHistorico", prmPlanta, prmAlmacen, prmEstacion)

            If pResultado.Estado Then
                ds = pResultado.Resultado

                For Each dr As DataRow In ds.Tables(0).Rows

                    Select Case dr("Estado").ToString
                        Case "OK"
                            dt = ds.Tables(1).Copy

                            pRespuesta.Estado = True
                            pRespuesta.Texto = ""
                            pRespuesta.Tabla = dt

                        Case "ER"
                            pRespuesta.Estado = False
                            pRespuesta.Texto = dr("Texto").ToString

                        Case Else
                            pRespuesta.Estado = True
                            pRespuesta.Texto = "Error"
                            pRespuesta.Resultado = Nothing
                    End Select
                Next
            Else
                pRespuesta.Estado = False
                pRespuesta.Texto = pResultado.Texto
            End If

            Return pRespuesta
        Catch ex As Exception
            CMetodos.EscribirBitacora(CMetodos.Bitacora.INCIDENCIA, ex, "clsAlmacen.ListadoAlmacen")
            pRespuesta.Estado = False
            pRespuesta.Texto = "Runtime error" + ex.Message

            Return pRespuesta
        End Try
    End Function
    Friend Function ResultadoListaOrdenesCompletasEmbES(ByVal prmFecha2 As DateTime, ByVal prmFecha3 As DateTime, ByVal prmEstacion As String, ByVal prmUsuario As String) As CResultado
        Dim pRespuesta As New CResultado
        Try
            Dim db As New CAccesoDatos
            Dim pResultado As CResultado
            Dim ds As DataSet
            Dim dt As DataTable
            Dim dt2 As DataTable
            Dim dt3 As DataTable
            Dim prmFecha = prmFecha2.ToString("yyyyMMdd")
            Dim prmFechaFin = prmFecha3.ToString("yyyyMMdd")
            pResultado = db.SPToDataSet("SpInsRegOrdEmbarcadoCompletoHistorico", prmFecha, prmFechaFin)



            If pResultado.Estado Then
                ds = CType(pResultado.Resultado, DataSet)

                For Each dr As DataRow In ds.Tables(3).Rows

                    Select Case dr("Estado").ToString
                        Case "OK"
                            dt = ds.Tables(0).Copy
                            dt2 = ds.Tables(1).Copy
                            dt3 = ds.Tables(2).Copy
                            pRespuesta.Estado = True
                            pRespuesta.Texto = ""
                            pRespuesta.Tablas = ds.Copy()
                        Case "ER"
                            pRespuesta.Estado = False
                            pRespuesta.Texto = dr("Texto").ToString
                        Case Else
                            pRespuesta.Estado = False
                            pRespuesta.Texto = "Error en tiempo de ejecucion"
                    End Select
                Next
            Else
                pRespuesta.Estado = False
                pRespuesta.Texto = pResultado.Texto
            End If

            Return pRespuesta

        Catch ex As Exception
            pRespuesta.Estado = False
            pRespuesta.Texto = "Error en tiempo de ejecucion"
            Return pRespuesta
        End Try
    End Function

    Friend Function ResultadoOrdenEmb(ByVal prmOrdenEmb As String) As CResultado
        Dim pRespuesta As New CResultado
        Try
            Dim db As New CAccesoDatos
            Dim pResultado As CResultado
            Dim ds As DataSet
            Dim dt As DataTable
            Dim dt2 As DataTable
            pResultado = db.SPToDataSet("SpQryKPITiempoPreparacionEmbarqueErick", prmOrdenEmb)



            If pResultado.Estado Then
                ds = CType(pResultado.Resultado, DataSet)

                For Each dr As DataRow In ds.Tables(2).Rows

                    Select Case dr("Estado").ToString
                        Case "OK"
                            dt = ds.Tables(0).Copy
                            dt2 = ds.Tables(1).Copy
                            pRespuesta.Estado = True
                            pRespuesta.Texto = ""
                            pRespuesta.Tablas = ds.Copy()
                        Case "ER"
                            pRespuesta.Estado = False
                            pRespuesta.Texto = dr("Texto").ToString
                        Case Else
                            pRespuesta.Estado = False
                            pRespuesta.Texto = "Error en tiempo de ejecucion"
                    End Select
                Next
            Else
                pRespuesta.Estado = False
                pRespuesta.Texto = pResultado.Texto
            End If

            Return pRespuesta

        Catch ex As Exception
            pRespuesta.Estado = False
            pRespuesta.Texto = "Error en tiempo de ejecucion"
            Return pRespuesta
        End Try
    End Function
    'Friend Function ResultadoListaEmpaques() As CResultado
    '    Throw New NotImplementedException()
    'End Function
    Friend Function ResultadoListaOrdenesCompletasEmb(ByVal prmFecha2 As Date, ByVal prmFecha3 As Date, ByVal prmEstacion As String, ByVal prmUsuario As String) As CResultado
        Dim pRespuesta As New CResultado
        Try
            Dim db As New CAccesoDatos
            Dim pResultado As CResultado
            Dim ds As DataSet
            Dim dt As DataTable
            Dim prmFecha = prmFecha2.ToString("yyyyMMdd")
            Dim prmFechaFin = prmFecha3.ToString("yyyyMMdd")
            pResultado = db.SPToDataSet("spQryKPIOrdenesCompletasEmbarcadas", prmFecha, prmFechaFin, prmEstacion, prmUsuario)

            If pResultado.Estado Then
                ds = CType(pResultado.Resultado, DataSet)

                For Each dr As DataRow In ds.Tables(0).Rows

                    Select Case dr("Estado").ToString
                        Case "OK"
                            dt = ds.Tables(1).Copy
                            pRespuesta.Estado = True
                            pRespuesta.Texto = ""
                            pRespuesta.Tabla = dt
                        Case "ER"
                            pRespuesta.Estado = False
                            pRespuesta.Texto = dr("Texto").ToString
                        Case Else
                            pRespuesta.Estado = False
                            pRespuesta.Texto = "Error en tiempo de ejecucion"
                    End Select
                Next
            Else
                pRespuesta.Estado = False
                pRespuesta.Texto = pResultado.Texto
            End If

            Return pRespuesta

        Catch ex As Exception
            pRespuesta.Estado = False
            pRespuesta.Texto = "Error en tiempo de ejecucion"
            Return pRespuesta
        End Try
    End Function

    Friend Function ResultadoListaOrdSurtidasEmbarcadas(ByVal prmFecha2 As Date, ByVal prmFecha3 As Date, ByVal prmEstacion As String, ByVal prmUsuario As String) As CResultado
        Dim pRespuesta As New CResultado
        Try
            Dim db As New CAccesoDatos
            Dim pResultado As CResultado
            Dim ds As DataSet
            Dim dt As DataTable
            Dim prmFecha = prmFecha2.ToString("yyyyMMdd")
            Dim prmFechaFin = prmFecha3.ToString("yyyyMMdd")
            pResultado = db.SPToDataSet("spQryKPIOrdSurtidasEmbarcadas", prmFecha, prmFechaFin, prmEstacion, prmUsuario)

            If pResultado.Estado Then
                ds = CType(pResultado.Resultado, DataSet)

                For Each dr As DataRow In ds.Tables(0).Rows

                    Select Case dr("Estado").ToString
                        Case "OK"
                            dt = ds.Tables(1).Copy
                            pRespuesta.Estado = True
                            pRespuesta.Texto = ""
                            pRespuesta.Tabla = dt
                            pRespuesta.Tablas = ds
                        Case "ER"
                            pRespuesta.Estado = False
                            pRespuesta.Texto = dr("Texto").ToString
                        Case Else
                            pRespuesta.Estado = False
                            pRespuesta.Texto = "Error en tiempo de ejecucion"
                    End Select
                Next
            Else
                pRespuesta.Estado = False
                pRespuesta.Texto = pResultado.Texto
            End If

            Return pRespuesta

        Catch ex As Exception
            pRespuesta.Estado = False
            pRespuesta.Texto = "Error en tiempo de ejecucion"
            Return pRespuesta
        End Try
    End Function


    Friend Function ResultadoListaTiempoRecepcioOrdCompra(ByVal prmFecha2 As Date, ByVal prmFecha3 As Date, ByVal prmEstacion As String, ByVal prmUsuario As String) As CResultado
        Dim pRespuesta As New CResultado
        Try
            Dim db As New CAccesoDatos
            Dim pResultado As CResultado
            Dim ds As DataSet
            Dim dt As DataTable
            Dim prmFecha = prmFecha2.ToString("yyyyMMdd")
            Dim prmFechaFin = prmFecha3.ToString("yyyyMMdd")
            pResultado = db.SPToDataSet("spQryKPITiempoRecepcion", prmFecha, prmFechaFin, prmEstacion, prmUsuario)

            If pResultado.Estado Then
                ds = CType(pResultado.Resultado, DataSet)

                For Each dr As DataRow In ds.Tables(0).Rows

                    Select Case dr("Estado").ToString
                        Case "OK"
                            dt = ds.Tables(1).Copy
                            pRespuesta.Estado = True
                            pRespuesta.Texto = ""
                            pRespuesta.Tabla = dt
                            pRespuesta.Tablas = ds
                        Case "ER"
                            pRespuesta.Estado = False
                            pRespuesta.Texto = dr("Texto").ToString
                        Case Else
                            pRespuesta.Estado = False
                            pRespuesta.Texto = "Error en tiempo de ejecucion"
                    End Select
                Next
            Else
                pRespuesta.Estado = False
                pRespuesta.Texto = pResultado.Texto
            End If

            Return pRespuesta

        Catch ex As Exception
            pRespuesta.Estado = False
            pRespuesta.Texto = "Error en tiempo de ejecucion"
            Return pRespuesta
        End Try
    End Function

    Friend Function ResultadoListaUsuarioXRecepcion(ByVal prmFecha2 As Date, ByVal prmFecha3 As Date, ByVal prmEstacion As String, ByVal prmUsuario As String) As CResultado
        Dim pRespuesta As New CResultado
        Try
            Dim db As New CAccesoDatos
            Dim pResultado As CResultado
            Dim ds As DataSet
            Dim dt As DataTable
            Dim prmFecha = prmFecha2.ToString("yyyyMMdd")
            Dim prmFechaFin = prmFecha3.ToString("yyyyMMdd")
            pResultado = db.SPToDataSet("spQryKPITotalUsuariosxRecepcion", prmFecha, prmFechaFin, prmEstacion, prmUsuario)

            If pResultado.Estado Then
                ds = CType(pResultado.Resultado, DataSet)

                For Each dr As DataRow In ds.Tables(0).Rows

                    Select Case dr("Estado").ToString
                        Case "OK"
                            dt = ds.Tables(1).Copy
                            pRespuesta.Estado = True
                            pRespuesta.Texto = ""
                            pRespuesta.Tabla = dt
                            pRespuesta.Tablas = ds
                        Case "ER"
                            pRespuesta.Estado = False
                            pRespuesta.Texto = dr("Texto").ToString
                        Case Else
                            pRespuesta.Estado = False
                            pRespuesta.Texto = "Error en tiempo de ejecucion"
                    End Select
                Next
            Else
                pRespuesta.Estado = False
                pRespuesta.Texto = pResultado.Texto
            End If

            Return pRespuesta

        Catch ex As Exception
            pRespuesta.Estado = False
            pRespuesta.Texto = "Error en tiempo de ejecucion"
            Return pRespuesta
        End Try
    End Function






    Friend Function ResultadoListaCantSurtidoTipos(ByVal prmFecha2 As Date, ByVal prmFecha3 As Date, ByVal prmEstacion As String, ByVal prmUsuario As String) As CResultado
        Dim pRespuesta As New CResultado
        Try
            Dim db As New CAccesoDatos
            Dim pResultado As CResultado
            Dim ds As DataSet
            Dim dt As DataTable
            Dim prmFecha = prmFecha2.ToString("yyyyMMdd")
            Dim prmFechaFin = prmFecha3.ToString("yyyyMMdd")
            pResultado = db.SPToDataSet("spQryKPIConsultaCantSurtidosTipoTurno", prmFecha, prmFechaFin, prmEstacion, prmUsuario)

            If pResultado.Estado Then
                ds = CType(pResultado.Resultado, DataSet)

                For Each dr As DataRow In ds.Tables(0).Rows

                    Select Case dr("Estado").ToString
                        Case "OK"
                            dt = ds.Tables(1).Copy
                            pRespuesta.Estado = True
                            pRespuesta.Texto = ""
                            pRespuesta.Tabla = dt
                            pRespuesta.Tablas = ds
                        Case "ER"
                            pRespuesta.Estado = False
                            pRespuesta.Texto = dr("Texto").ToString
                        Case Else
                            pRespuesta.Estado = False
                            pRespuesta.Texto = "Error en tiempo de ejecucion"
                    End Select
                Next
            Else
                pRespuesta.Estado = False
                pRespuesta.Texto = pResultado.Texto
            End If

            Return pRespuesta

        Catch ex As Exception
            pRespuesta.Estado = False
            pRespuesta.Texto = "Error en tiempo de ejecucion"
            Return pRespuesta
        End Try
    End Function

    Friend Function ResultadoListaProductosPorOrdenProduccion(ByVal prmFecha2 As Date, ByVal prmFecha3 As Date, ByVal prmEstacion As String, ByVal prmUsuario As String) As CResultado
        Dim pRespuesta As New CResultado
        Try
            Dim db As New CAccesoDatos
            Dim pResultado As CResultado
            Dim ds As DataSet
            Dim dt As DataTable
            Dim prmFecha = prmFecha2.ToString("yyyyMMdd")
            Dim prmFechaFin = prmFecha3.ToString("yyyyMMdd")
            pResultado = db.SPToDataSet("spQryKPIProductosPorOrdenProd", prmFecha, prmFechaFin, prmEstacion, prmUsuario)

            If pResultado.Estado Then
                ds = CType(pResultado.Resultado, DataSet)

                For Each dr As DataRow In ds.Tables(0).Rows

                    Select Case dr("Estado").ToString
                        Case "OK"
                            dt = ds.Tables(1).Copy
                            pRespuesta.Estado = True
                            pRespuesta.Texto = ""
                            pRespuesta.Tabla = dt
                            pRespuesta.Tablas = ds
                        Case "ER"
                            pRespuesta.Estado = False
                            pRespuesta.Texto = dr("Texto").ToString
                        Case Else
                            pRespuesta.Estado = False
                            pRespuesta.Texto = "Error en tiempo de ejecucion"
                    End Select
                Next
            Else
                pRespuesta.Estado = False
                pRespuesta.Texto = pResultado.Texto
            End If

            Return pRespuesta

        Catch ex As Exception
            pRespuesta.Estado = False
            pRespuesta.Texto = "Error en tiempo de ejecucion"
            Return pRespuesta
        End Try
    End Function
    Friend Function ResultadoListaTiempoRegistroproductoTerminado(ByVal prmFecha2 As Date, ByVal prmFecha3 As Date, ByVal prmEstacion As String, ByVal prmUsuario As String) As CResultado
        Dim pRespuesta As New CResultado
        Try
            Dim db As New CAccesoDatos
            Dim pResultado As CResultado
            Dim ds As DataSet
            Dim dt As DataTable
            Dim prmFecha = prmFecha2.ToString("yyyyMMdd")
            Dim prmFechaFin = prmFecha3.ToString("yyyyMMdd")
            pResultado = db.SPToDataSet("spQryKPITiempoRegistroPTHistorico", prmFecha, prmFechaFin, prmEstacion, prmUsuario)

            If pResultado.Estado Then
                ds = CType(pResultado.Resultado, DataSet)

                For Each dr As DataRow In ds.Tables(0).Rows

                    Select Case dr("Estado").ToString
                        Case "OK"
                            dt = ds.Tables(1).Copy
                            pRespuesta.Estado = True
                            pRespuesta.Texto = ""
                            pRespuesta.Tabla = dt
                            pRespuesta.Tablas = ds
                        Case "ER"
                            pRespuesta.Estado = False
                            pRespuesta.Texto = dr("Texto").ToString
                        Case Else
                            pRespuesta.Estado = False
                            pRespuesta.Texto = "Error en tiempo de ejecucion"
                    End Select
                Next
            Else
                pRespuesta.Estado = False
                pRespuesta.Texto = pResultado.Texto
            End If

            Return pRespuesta

        Catch ex As Exception
            pRespuesta.Estado = False
            pRespuesta.Texto = "Error en tiempo de ejecucion"
            Return pRespuesta
        End Try
    End Function





End Class
