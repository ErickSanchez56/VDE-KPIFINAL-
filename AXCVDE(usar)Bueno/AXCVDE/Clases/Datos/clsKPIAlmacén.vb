Public Class clsKPIAlmacén
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

    Friend Function TiempoUbicaciónPallet(ByVal prmFecha2 As Date, ByVal prmFecha3 As Date, ByVal prmEstacion As String, ByVal prmUsuario As String) As CResultado
        Dim pRespuesta As New CResultado
        Try
            Dim db As New CAccesoDatos
            Dim pResultado As CResultado
            Dim ds As DataSet
            Dim dt As DataTable
            Dim prmFechaInicio = prmFecha2.ToString("yyyyMMdd")
            Dim prmFechaFin = prmFecha3.ToString("yyyyMMdd")
            pResultado = db.SPToDataSet("SpQryKPITiempoUbicacionPalletCompleto", prmFechaInicio, prmFechaFin, prmEstacion, prmUsuario)

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




    Friend Function KPIColocacionesUsuario(ByVal prmNombreUsuario As String, ByVal prmFechaInicio2 As Date, ByVal prmFechaFin2 As Date, ByVal prmEstacion As String, ByVal prmUsuario As String) As CResultado
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

            pResultado = db.SPToDataSet("spQryKPIColocacionesUsuarioHistorico", prmNombreUsuario, prmFechaInicio, prmFechaFin, prmEstacion, prmUsuario)

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


    Friend Function KPIReabastecimiento(ByVal prmFechaInicio2 As Date, ByVal prmFechaFin2 As Date, ByVal prmEstacion As String, ByVal prmUsuario As String) As CResultado
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

            pResultado = db.SPToDataSet("spQryKPIReabastecimiento", prmFechaInicio, prmFechaFin, prmEstacion, prmUsuario)

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

    Friend Function KPIInventario(ByVal prmFechaInicio2 As Date, ByVal prmFechaFin2 As Date, ByVal prmEstacion As String, ByVal prmUsuario As String) As CResultado
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

            pResultado = db.SPToDataSet("spQryKPIInventarios", prmFechaInicio, prmFechaFin, prmEstacion, prmUsuario)

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
    Friend Function KPIColocaciones(ByVal prmFechaInicio2 As Date, ByVal prmFechaFin2 As Date, ByVal prmEstacion As String, ByVal prmUsuario As String) As CResultado
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

            pResultado = db.SPToDataSet("spQryKPIColocacionesPosSugPosEsc", prmFechaInicio, prmFechaFin, prmEstacion, prmUsuario)

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

    Friend Function KPIInventarios2(ByVal prmFechaInicio2 As Date, ByVal prmFechaFin2 As Date, ByVal prmEstacion As String, ByVal prmUsuario As String) As CResultado
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

            pResultado = db.SPToDataSet("spQryKPIInventariosDiferencias", prmFechaInicio, prmFechaFin, prmEstacion, prmUsuario)

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
