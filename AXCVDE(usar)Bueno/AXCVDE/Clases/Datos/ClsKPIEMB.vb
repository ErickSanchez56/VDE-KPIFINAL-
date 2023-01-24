Public Class ClsKPIEMB

    Friend Function Estatus(ByVal prmFechaInicio2 As Date, ByVal prmFechaFin2 As Date, ByVal prmDias As Integer) As CResultado
        Dim pRespuesta As New CResultado
        Dim pRespuesta2 As New CResultado
        Try
            Dim db As New CAccesoDatos
            Dim pResultado As CResultado
            Dim ds As DataSet
            Dim dt As DataTable
            Dim dt2 As DataTable


            pResultado = db.SPToDataSet("spQryDetalleDashboardkpi", prmFechaInicio2, prmFechaFin2, prmDias)

            If pResultado.Estado Then
                ds = pResultado.Resultado

                For Each dr As DataRow In ds.Tables(0).Rows

                    Select Case dr("Estado").ToString
                        Case "OK"
                            dt = ds.Tables(1).Copy
                            pRespuesta.Estado = True
                            pRespuesta.Texto = ""
                            pRespuesta.Tablas = ds


                        Case "ER"
                            pRespuesta.Estado = False
                            pRespuesta.Texto = dr("Texto").ToString
                        Case Else
                            pRespuesta.Estado = False
                            pRespuesta.Texto = "Error al tratar de listar órdenes de embarque "
                    End Select
                Next
            Else
                pRespuesta.Estado = False
                pRespuesta.Texto = pResultado.Texto
            End If

            Return pRespuesta

        Catch ex As Exception
            pRespuesta.Estado = False
            pRespuesta.Texto = "Error al tratar de listar órdenes de embarque."
            Return pRespuesta
        End Try
    End Function
    Friend Function KPIOrdenesXusuario(ByVal prmFechaInicio2 As Date, ByVal prmFechaFin2 As Date, ByVal prmDias As Integer, ByVal prmEstacion As String, ByVal prmUsuario As String) As CResultado
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

            pResultado = db.SPToDataSet("spQryKPIOrdenesCompletasPorFecha", prmFechaInicio, prmFechaFin, prmDias, prmEstacion, prmUsuario)

            If pResultado.Estado Then
                ds = CType(pResultado.Resultado, DataSet)

                For Each dr As DataRow In ds.Tables(1).Rows

                    Select Case dr("Estado").ToString
                        Case "OK"
                            dt = ds.Tables(0).Copy
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
    Friend Function KPIOrdenesCompletasEmbarcadas(ByVal prmFechaInicio2 As Date, ByVal prmFechaFin2 As Date, ByVal prmDias As Integer, ByVal prmEstacion As String, ByVal prmUsuario As String) As CResultado
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

            pResultado = db.SPToDataSet("spQryKPIOrdenesCompletasEmbarcadas", prmFechaInicio, prmFechaFin, prmDias, prmEstacion, prmUsuario)

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
    Friend Function ResultadoListaOrdenesCompletasEmbES(ByVal prmFecha2 As DateTime, ByVal prmFecha3 As DateTime, ByVal prmDias As Integer, ByVal prmEstacion As String, ByVal prmUsuario As String) As CResultado
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
            pResultado = db.SPToDataSet("SpInsRegOrdEmbarcadoCompletoHistorico", prmFecha, prmFechaFin, prmDias)



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
    Friend Function TiempoSurtido(ByVal prmNombreAlm As String, ByVal prmFecha2 As Date, ByVal prmFecha3 As Date, ByVal prmDias As Integer, ByVal prmEstacion As String, ByVal prmUsuario As String) As CResultado
        Dim pRespuesta As New CResultado
        Try
            Dim db As New CAccesoDatos
            Dim pResultado As CResultado
            Dim ds As DataSet
            Dim dt As DataTable
            Dim prmFechaInicio = prmFecha2.ToString("yyyyMMdd")
            Dim prmFechaFin = prmFecha3.ToString("yyyyMMdd")
            pResultado = db.SPToDataSet("SpQryKPITiempoSurtido", prmNombreAlm, prmFechaInicio, prmFechaFin, prmDias, "TODO", prmEstacion, prmUsuario)

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

    Friend Function ResultadoListaOrdSurtidasEmbarcadas(ByVal prmFecha2 As Date, ByVal prmFecha3 As Date, ByVal prmdias As Integer, ByVal prmEstacion As String, ByVal prmUsuario As String) As CResultado
        Dim pRespuesta As New CResultado
        Try
            Dim db As New CAccesoDatos
            Dim pResultado As CResultado
            Dim ds As DataSet
            Dim dt As DataTable
            Dim prmFecha = prmFecha2.ToString("yyyyMMdd")
            Dim prmFechaFin = prmFecha3.ToString("yyyyMMdd")
            pResultado = db.SPToDataSet("spQryKPIOrdSurtidasEmbarcadas", prmFecha, prmFechaFin, prmdias, prmEstacion, prmUsuario)

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
