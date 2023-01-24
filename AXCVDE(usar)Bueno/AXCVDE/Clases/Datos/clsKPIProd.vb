Imports AXCDemo

Public Class clsKPIProd
    'es
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
    'Este sí
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
    'este sí
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
                            dt = ds.Tables(5).Copy
                            dt = ds.Tables(6).Copy
                            dt = ds.Tables(7).Copy
                            dt = ds.Tables(8).Copy
                            dt = ds.Tables(9).Copy
                            dt = ds.Tables(10).Copy
                            dt = ds.Tables(11).Copy
                            dt = ds.Tables(12).Copy
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
    'este sí
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
    'este sí
    Friend Function ResultadoOrdenesAutSurtVal(ByVal prmFecha2 As Date, ByVal prmFecha3 As Date, ByVal prmEstacion As String, ByVal prmUsuario As String) As CResultado
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
            pResultado = db.SPToDataSet("spQryKPIOrdenesProdAutorizadas", prmFecha, prmFechaFin)

            If pResultado.Estado Then
                ds = CType(pResultado.Resultado, DataSet)

                For Each dr As DataRow In ds.Tables(0).Rows

                    Select Case dr("Estado").ToString
                        Case "OK"
                            dt = ds.Tables(0).Copy
                            dt = ds.Tables(1).Copy
                            dt = ds.Tables(2).Copy
                            dt = ds.Tables(3).Copy
                            dt = ds.Tables(4).Copy
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
End Class
