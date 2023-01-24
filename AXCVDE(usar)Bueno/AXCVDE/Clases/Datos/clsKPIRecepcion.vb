Imports AXCDemo

Public Class clsKPIRecepcion

#Region "Nuevas Funciones"
    Friend Function ClsDatosCicloRecibo(ByVal prmFecha1 As Date, ByVal prmFecha2 As Date, ByVal prmEstacion As String, ByVal prmUsuario As String) As CResultado
        Dim pRespuesta As New CResultado
        Try
            Dim db As New CAccesoDatos
            Dim pResultado As CResultado
            Dim ds As DataSet


            Dim prmFechaInicio = prmFecha1.ToString("yyyyMMdd")
            Dim prmFechaFin = prmFecha2.ToString("yyyyMMdd")

            pResultado = db.SPToDataSet("spQryKPIDatosCicloRecibo", prmFechaInicio, prmFechaFin, prmEstacion, prmUsuario)

            If pResultado.Estado Then
                ds = CType(pResultado.Resultado, DataSet)

                For Each dr As DataRow In ds.Tables(0).Rows

                    Select Case dr("Estado").ToString
                        Case "OK"
                            pRespuesta.Estado = True
                            pRespuesta.Texto = ""
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


    Friend Function KPITiempoUbicaciónPalletRecepcion(ByVal prmFecha1 As Date, ByVal prmFecha2 As Date, ByVal prmEstacion As String, ByVal prmUsuario As String) As CResultado
        Dim pRespuesta As New CResultado
        Try
            Dim db As New CAccesoDatos
            Dim pResultado As CResultado
            Dim ds As DataSet
            Dim dt As DataTable
            Dim prmFechaInicio = prmFecha1.ToString("yyyyMMdd")
            Dim prmFechaFin = prmFecha2.ToString("yyyyMMdd")
            pResultado = db.SPToDataSet("SpQryKPIDetalleTiempoUbicacionPallet", prmFechaInicio, prmFechaFin, prmEstacion, prmUsuario)

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


    Friend Function PorcentajeKPIPallets(ByVal prmFecha1 As Date, ByVal prmFecha2 As Date, ByVal prmEstacion As String, ByVal prmUsuario As String) As CResultado
        Dim pRespuesta As New CResultado
        Try
            Dim db As New CAccesoDatos
            Dim pResultado As CResultado
            Dim ds As DataSet
            Dim dt As DataTable

            Dim prmFechaInicio = prmFecha1.ToString("yyyyMMdd")
            Dim prmFechaFin = prmFecha2.ToString("yyyyMMdd")

            pResultado = db.SPToDataSet("SpQryKPIPromedioCantidadUbicacionPallet", prmFechaInicio, prmFechaFin, prmEstacion, prmUsuario)

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

    Friend Function PorcentajeKPIPalletsPendientes(ByVal prmFecha1 As Date, ByVal prmFecha2 As Date, ByVal prmEstacion As String, ByVal prmUsuario As String) As CResultado
        Dim pRespuesta As New CResultado
        Try
            Dim db As New CAccesoDatos
            Dim pResultado As CResultado
            Dim ds As DataSet
            Dim dt As DataTable

            Dim prmFechaInicio = prmFecha1.ToString("yyyyMMdd")
            Dim prmFechaFin = prmFecha2.ToString("yyyyMMdd")

            pResultado = db.SPToDataSet("SpQryKPICantidadPalletsPendientes", prmFechaInicio, prmFechaFin, prmEstacion, prmUsuario)

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

    Friend Function PorcentajeOrdenesRecepcion(ByVal prmFecha1 As Date, ByVal prmFecha2 As Date, ByVal prmEstacion As String, ByVal prmUsuario As String) As CResultado
        Dim pRespuesta As New CResultado
        Try
            Dim db As New CAccesoDatos
            Dim pResultado As CResultado
            Dim ds As DataSet
            Dim dt As DataTable

            Dim prmFechaInicio = prmFecha1.ToString("yyyyMMdd")
            Dim prmFechaFin = prmFecha2.ToString("yyyyMMdd")

            pResultado = db.SPToDataSet("spQryKPIPorcentajeOrdenesRecepcion", prmFechaInicio, prmFechaFin, prmEstacion, prmUsuario)

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


    Friend Function ClsKPITiempoPromedioRecepcion(ByVal prmFecha1 As Date, ByVal prmFecha2 As Date, ByVal prmEstacion As String, ByVal prmUsuario As String) As CResultado
        Dim pRespuesta As New CResultado
        Try
            Dim db As New CAccesoDatos
            Dim pResultado As CResultado
            Dim ds As DataSet
            Dim dt As DataTable

            Dim prmFechaInicio = prmFecha1.ToString("yyyyMMdd")
            Dim prmFechaFin = prmFecha2.ToString("yyyyMMdd")

            pResultado = db.SPToDataSet("spQryKPITiempoOrdenRecepcion", prmFechaInicio, prmFechaFin, prmEstacion, prmUsuario)

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


#End Region




End Class
