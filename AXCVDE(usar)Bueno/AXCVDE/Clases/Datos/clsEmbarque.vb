Public Class clsEmbarque

    Public Function ConsultaOrdenEmbarque(ByVal prmOrdenEmbarque As String) As CResultado
        Dim pRespuesta As New CResultado
        Try
            Dim db As New CAccesoDatos
            Dim pResultado As CResultado
            Dim ds As DataSet
            Dim dt As DataTable

            pResultado = db.SPToDataSet("spQryListaOrdenesEmbarqueDet", prmOrdenEmbarque, "@", "@", "@", "@", "@")

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
                            pRespuesta.Texto = "Error al tratar de listar órdenes de embarque"
                    End Select
                Next
            Else
                pRespuesta.Estado = False
                pRespuesta.Texto = pResultado.Texto
            End If

            Return pRespuesta

        Catch ex As Exception
            pRespuesta.Estado = False
            pRespuesta.Texto = "Error al tratar de listar órdenes de embarque "
            Return pRespuesta
        End Try
    End Function

    Friend Function ActualizaOrden(ByVal prmOrden As String, ByVal prmEstacion As String, ByVal prmUsuario As String) As CResultado
        Dim cRespuesta As New CResultado
        Try
            Dim db As New CAccesoDatos
            Dim dr As DataRow
            Dim CResultado As CResultado

            CResultado = db.SPToDataRow("spInsInterfaceBDPedidos", prmOrden)

            If CResultado.Estado Then
                dr = CResultado.Resultado

                If dr("Estado") = "ER" Then
                    cRespuesta.Estado = False
                    cRespuesta.Texto = dr("Texto").ToString
                    cRespuesta.Resultado = Nothing
                Else
                    cRespuesta.Estado = True
                    cRespuesta.Texto = ""
                    cRespuesta.Resultado = Nothing
                End If
            Else
                cRespuesta.Estado = False
                cRespuesta.Texto = CResultado.Texto
                cRespuesta.Resultado = Nothing
            End If
        Catch ex As Exception
            cRespuesta.Estado = False
            cRespuesta.Texto = ex.Message
        End Try
        Return cRespuesta
    End Function


    Friend Function ListarPrevioPedido(ByVal prmPedido As String, ByVal prmEstacion As String, ByVal prmUsuario As String) As CResultado
        Dim pRespuesta As New CResultado
        Try
            Dim db As New CAccesoDatos
            Dim pResultado As CResultado
            Dim ds As DataSet
            Dim dt As DataTable

            pResultado = db.SPToDataSet("spQryListaxPartida", prmPedido, prmEstacion, prmUsuario)

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
                            pRespuesta.Estado = False
                            pRespuesta.Texto = "Error al tratar de listar partidas de pedido "
                    End Select
                Next
            Else
                pRespuesta.Estado = False
                pRespuesta.Texto = pResultado.Texto
            End If

            Return pRespuesta

        Catch ex As Exception
            pRespuesta.Estado = False
            pRespuesta.Texto = "Error al tratar de listar partidad de pedido"
            Return pRespuesta
        End Try
    End Function
    Friend Function AgregarPartida(ByVal prmOrdenProd As String, ByVal prmPartida As Integer, ByVal prmCantidad As Double, ByVal prmCantidadPendiente As Double, ByVal prmEstacion As String, ByVal prmEstacionValida As String, ByVal prmTiposurtido As String, ByVal prmUsuario As String) As CResultado
        Dim cRespuesta As New CResultado
        Try
            Dim db As New CAccesoDatos
            Dim dr As DataRow
            Dim ds As DataSet
            Dim dt As DataTable
            Dim CResultado As CResultado



            CResultado = db.SPToDataRow("spInsAgregaPartida", prmOrdenProd, prmPartida, prmCantidad, prmCantidadPendiente, prmEstacion, prmEstacionValida, prmTiposurtido, prmUsuario)
            If CResultado.Estado Then
                dr = CResultado.Resultado

                If dr("Estado") = "ER" Then
                    cRespuesta.Estado = False
                    cRespuesta.Texto = dr("Texto").ToString
                    cRespuesta.Resultado = Nothing
                Else
                    cRespuesta.Estado = True
                    cRespuesta.Texto = ""
                    cRespuesta.Resultado = Nothing
                End If
            Else
                cRespuesta.Estado = False
                cRespuesta.Texto = CResultado.Texto
                cRespuesta.Resultado = Nothing
            End If
        Catch ex As Exception
            cRespuesta.Estado = False
            cRespuesta.Texto = ex.Message
        End Try



        Return cRespuesta
    End Function

    Friend Function EliminarPartida(ByVal prmOrdenProd As String, ByVal prmPartida As Integer, ByVal prmPedido As String, ByVal prmCantidad As Double, ByVal prmCantidadPendiente As Double, ByVal prmTsurtido As String, ByVal prmEstacionPick As String, ByVal prmTsurtido1 As String, ByVal prmEstacionPall As String, ByVal prmEstacion As String, ByVal prmUsuario As String) As CResultado
        Dim cRespuesta As New CResultado
        Try
            Dim db As New CAccesoDatos
            Dim dr As DataRow
            Dim CResultado As CResultado

            CResultado = db.SPToDataRow("spDelEliminaPartidadOP", prmOrdenProd, prmPartida, prmCantidad, prmCantidadPendiente, prmTsurtido, prmEstacionPick, prmTsurtido1, prmEstacionPall, prmEstacion, prmUsuario)

            If CResultado.Estado Then
                dr = CResultado.Resultado

                If dr("Estado") = "ER" Then
                    cRespuesta.Estado = False
                    cRespuesta.Texto = dr("Texto").ToString
                    cRespuesta.Resultado = Nothing
                Else
                    cRespuesta.Estado = True
                    cRespuesta.Texto = ""
                    cRespuesta.Resultado = Nothing
                End If
            Else
                cRespuesta.Estado = False
                cRespuesta.Texto = CResultado.Texto
                cRespuesta.Resultado = Nothing
            End If
        Catch ex As Exception
            cRespuesta.Estado = False
            cRespuesta.Texto = ex.Message
        End Try
        Return cRespuesta
    End Function
    Friend Function ListaOrdenesEmbarqueMontitorDetalle(prmBusqueda As String, prmEstacion As String, prmUsuario As String) As CResultado
        Dim pRespuesta As New CResultado
        Try
            Dim db As New CAccesoDatos
            Dim pResultado As CResultado
            Dim ds As DataSet
            Dim dt As DataTable

            pResultado = db.SPToDataSet("spQryOrdenesEmbarqueDetalleMonitorDias", prmBusqueda, prmEstacion, prmUsuario) ', prmEstacion, prmUsuario)

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
                            pRespuesta.Estado = False
                            pRespuesta.Texto = "Error al tratar de listar órdenes de Embarque "
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



    Friend Function ConsultaSurtidos(prmBusqueda As String, prmEstacion As String, prmUsuario As String) As CResultado
        Dim pRespuesta As New CResultado
        Try
            Dim db As New CAccesoDatos
            Dim pResultado As CResultado
            Dim ds As DataSet
            Dim dt As DataTable

            pResultado = db.SPToDataSet("spQryOrdenesSurtidoPedidos", prmBusqueda, prmEstacion, prmUsuario) ', prmEstacion, prmUsuario)

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
                            pRespuesta.Estado = False
                            pRespuesta.Texto = "Error al tratar de listar órdenes de surtido"
                    End Select
                Next
            Else
                pRespuesta.Estado = False
                pRespuesta.Texto = pResultado.Texto
            End If

            Return pRespuesta

        Catch ex As Exception
            pRespuesta.Estado = False
            pRespuesta.Texto = "Error al tratar de listar órdenes de surtido."
            Return pRespuesta
        End Try
    End Function
    'Friend Function ListaOrdenesEmbarqueMontitor(prFechaInicio As String, prFechaFin As String, prmEstacion As String, prmUsuario As String) As CResultado
    '    Dim pRespuesta As New CResultado
    '    Try
    '        Dim db As New CAccesoDatos
    '        Dim pResultado As CResultado
    '        Dim ds As DataSet
    '        Dim dt As DataTable

    '        pResultado = db.SPToDataSet("spQryOrdenesEmbarqueMonitor", prFechaInicio, prFechaFin, prmEstacion, prmUsuario, prmPagina) ', prmEstacion, prmUsuario)

    '        If pResultado.Estado Then
    '            ds = pResultado.Resultado

    '            For Each dr As DataRow In ds.Tables(0).Rows

    '                Select Case dr("Estado").ToString
    '                    Case "OK"
    '                        dt = ds.Tables(1).Copy
    '                        pRespuesta.Estado = True
    '                        pRespuesta.Texto = ""
    '                        pRespuesta.Tabla = dt
    '                    Case "ER"
    '                        pRespuesta.Estado = False
    '                        pRespuesta.Texto = dr("Texto").ToString
    '                    Case Else
    '                        pRespuesta.Estado = False
    '                        pRespuesta.Texto = "Error al tratar de listar órdenes de embarque "
    '                End Select
    '            Next
    '        Else
    '            pRespuesta.Estado = False
    '            pRespuesta.Texto = pResultado.Texto
    '        End If

    '        Return pRespuesta

    '    Catch ex As Exception
    '        pRespuesta.Estado = False
    '        pRespuesta.Texto = "Error al tratar de listar órdenes de embarque."
    '        Return pRespuesta
    '    End Try
    'End Function

    Public Function ConsultaOrdenEmbarqueFiltro(ByVal prmOrdenEmbarque As String, ByVal prmTipo As String) As CResultado
        Dim pRespuesta As New CResultado
        Try
            Dim db As New CAccesoDatos
            Dim pResultado As CResultado
            Dim ds As DataSet
            Dim dt As DataTable
            ''pResultado = Cls.Filtro(TxtBusqueda.Text, My.Settings("Estacion"), DatosTemporales.Usuario, CmbTipoLib.Text, CantidadPedida, CantidadASurtir)
            If prmTipo <> "TODO" Then
                pResultado = db.SPToDataSet("spQryFiltroOrdenEmbarque", prmOrdenEmbarque, My.Settings("Estacion"), DatosTemporales.Usuario, prmTipo)
            End If

            If pResultado.Estado Then
                ds = CType(pResultado.Resultado, DataSet)

                For Each dr As DataRow In ds.Tables(1).Rows

                    Select Case dr("Estado").ToString
                        Case "OK"
                            dt = ds.Tables(0).Copy
                            pRespuesta.Estado = True
                            pRespuesta.Texto = ""
                            pRespuesta.Tabla = dt
                        Case "ER"
                            pRespuesta.Estado = False
                            pRespuesta.Texto = dr("Texto").ToString
                        Case Else
                            pRespuesta.Estado = False
                            pRespuesta.Texto = "Error al tratar de listar órdenes de embarque"
                    End Select
                Next
            Else
                pRespuesta.Estado = False
                pRespuesta.Texto = pResultado.Texto
            End If

            Return pRespuesta

        Catch ex As Exception
            pRespuesta.Estado = False
            pRespuesta.Texto = "Error al tratar de listar órdenes de embarque "
            Return pRespuesta
        End Try
    End Function

    Friend Function ListaOrdenesEmbarqueMontitor(prmDias As String, prmEstacion As String, prmUsuario As String, prmPagina As String, prmOrden As String) As CResultado
        Dim pRespuesta As New CResultado
        Dim pRespuesta2 As New CResultado
        Try
            Dim db As New CAccesoDatos
            Dim pResultado As CResultado
            Dim ds As DataSet
            Dim dt As DataTable
            Dim dt2 As DataTable


            pResultado = db.SPToDataSet("spQryOrdenesEmbarqueMonitor", prmDias, prmEstacion, prmUsuario, prmPagina, prmOrden) ', prmEstacion, prmUsuario)

            If pResultado.Estado Then
                ds = pResultado.Resultado

                For Each dr As DataRow In ds.Tables(1).Rows

                    Select Case dr("Estado").ToString
                        Case "OK"
                            dt = ds.Tables(0).Copy
                            dt = ds.Tables(2).Copy
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




    Friend Function ConsultaEmbarque(prmTipo As Integer, prmBusqueda As String, prmFechaInicio As String, prmFechaFin As String, prmEstacion As Object, prmUsuario As String) As CResultado
        Dim pRespuesta As New CResultado
        Try
            Dim db As New CAccesoDatos
            Dim pResultado As CResultado
            Dim ds As DataSet
            Dim dt As DataTable

            pResultado = db.SPToDataSet("spQryOrdenEmbarques", prmTipo, prmBusqueda, "@", prmFechaInicio, prmFechaFin, prmEstacion, prmUsuario)

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
                            pRespuesta.Texto = "Error al tratar de listar defectos"
                    End Select
                Next
            Else
                pRespuesta.Estado = False
                pRespuesta.Texto = pResultado.Texto
            End If

            Return pRespuesta

        Catch ex As Exception
            pRespuesta.Estado = False
            pRespuesta.Texto = "Error al tratar de listar defectos "
            Return pRespuesta
        End Try
    End Function

    Friend Function ConsultaDocumentos(prmFechaInicio As String, prmFechaFin As String, prmEstacion As String, prmUsuario As String) As CResultado
        Dim pRespuesta As New CResultado
        Try
            Dim db As New CAccesoDatos
            Dim pResultado As CResultado
            Dim ds As DataSet
            Dim dt As DataTable

            pResultado = db.SPToDataSet("spQryDocEmbarques", prmFechaInicio, prmFechaFin, prmEstacion, prmUsuario)

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
                            pRespuesta.Texto = "Error al tratar de listar embarques"
                    End Select
                Next
            Else
                pRespuesta.Estado = False
                pRespuesta.Texto = pResultado.Texto
            End If

            Return pRespuesta

        Catch ex As Exception
            pRespuesta.Estado = False
            pRespuesta.Texto = "Error al tratar de listar embarques "
            Return pRespuesta
        End Try
    End Function

    Public Function ConsultaOrdenesEmbarque(ByVal prmOrdenEmbarque As String) As CResultado
        Dim pRespuesta As New CResultado
        Try
            Dim db As New CAccesoDatos
            Dim pResultado As CResultado
            Dim ds As DataSet
            Dim dt As DataTable

            pResultado = db.SPToDataSet("spQryListaOrdenesEmbarque", prmOrdenEmbarque, "@", "@", "@", "@")

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
                            pRespuesta.Texto = "Error al tratar de listar órdenes de embarque"
                    End Select
                Next
            Else
                pRespuesta.Estado = False
                pRespuesta.Texto = pResultado.Texto
            End If

            Return pRespuesta

        Catch ex As Exception
            pRespuesta.Estado = False
            pRespuesta.Texto = "Error al tratar de listar órdenes de embarque "
            Return pRespuesta
        End Try
    End Function

    Public Function ConsultaOrdenEmbarque(ByVal prmOrdenEmbarque As String, ByVal prmEstatus As String) As DataSet
        Dim dato As New clsDato()
        Dim ds As New DataSet

        Try
            If String.IsNullOrEmpty(prmOrdenEmbarque) Then


            Else
                dato.Parametro("prmOrdenEmbarque") = prmOrdenEmbarque
                dato.Parametro("prmStatus") = prmEstatus
            End If
            ds = dato.Tabla("spQryListaOrdenesEmbarque")
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, " AXC")
        End Try
        Return ds
    End Function

    'Consulta orden de Embarque con fechas
    Public Function ConsultaOrdenEmbarque(ByVal prmOrdenEmbarque As String, ByVal prmFechaInicio As String, ByVal prmFechaFin As String) As DataSet
        Dim dato As New clsDato
        Dim ds As New DataSet
        Try
            If String.IsNullOrEmpty(prmOrdenEmbarque) Then
                dato.Parametro("prmFechaInicio") = prmFechaInicio
                dato.Parametro("prmFechaFin") = prmFechaFin

            Else
                dato.Parametro("prmFechaInicio") = prmFechaInicio
                dato.Parametro("prmFechaFin") = prmFechaFin
                dato.Parametro("prmOrdenEmbarque") = prmOrdenEmbarque
            End If

            ds = dato.Tabla("spQryListaOrdenesProd")
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, " AXC")
        End Try
        Return ds
    End Function


    Public Function ConsultaOrdenEmbarqueDet(ByVal prmOrdenEmbarque As String) As DataSet
        Dim dato As New clsDato()
        Dim ds As New DataSet

        Try
            If String.IsNullOrEmpty(prmOrdenEmbarque) Then


            Else
                dato.Parametro("prmOrdenEmbarque") = prmOrdenEmbarque
            End If
            ds = dato.Tabla("spQryListaOrdenesEmbarqueDet")
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, " AXC")
        End Try
        Return ds
    End Function
    Public Function ConsultaOrdenEmbarqueDet(ByVal prmOrdenEmbarque As String, ByVal prmEstatus As String) As DataSet
        Dim dato As New clsDato()
        Dim ds As New DataSet

        Try
            If String.IsNullOrEmpty(prmOrdenEmbarque) Then


            Else
                dato.Parametro("prmOrdenEmbarque") = prmOrdenEmbarque
                dato.Parametro("prmStatus") = prmEstatus
            End If
            ds = dato.Tabla("spQryListaOrdenesProdDet")
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, " AXC")
        End Try
        Return ds
    End Function

    'Consulta orden de Embarque con fechas
    Public Function ConsultaOrdenEmbarqueDet(ByVal prmOrdenEmbarque As String, ByVal prmFechaInicio As String, ByVal prmFechaFin As String) As DataSet
        Dim dato As New clsDato
        Dim ds As New DataSet
        Try
            If String.IsNullOrEmpty(prmOrdenEmbarque) Then
                dato.Parametro("prmFechaInicio") = prmFechaInicio
                dato.Parametro("prmFechaFin") = prmFechaFin

            Else
                dato.Parametro("prmFechaInicio") = prmFechaInicio
                dato.Parametro("prmFechaFin") = prmFechaFin
                dato.Parametro("prmOrdenEmbarque") = prmOrdenEmbarque
            End If

            ds = dato.Tabla("spQryListaOrdenesProdDet")
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, " AXC")
        End Try
        Return ds
    End Function
    Public Function Filtro(ByVal prmOrdenEmbarque As String,
                                  ByVal prmEstacion As String, ByVal prmUsuario As String, ByVal prmTipo As String, ByVal prmCantidadPedida As Integer, ByVal prmCantidadASurtir As Integer) As CResultado
        Dim CRespuesta As New CResultado
        Dim Dato As New clsDato
        Try
            ''Parametros

            Dato.Parametro("prmOrdenEmbarque") = prmOrdenEmbarque
            Dato.Parametro("prmEstacion") = prmEstacion
            Dato.Parametro("prmUsuario") = prmUsuario
            Dato.Parametro("prmTipo") = prmTipo
            Dato.Parametro("prmCantidadPedida") = prmCantidadPedida
            Dato.Parametro("prmCantidadASurtir") = prmCantidadASurtir
            Dato.SP(True) = "spQryFiltroOrdenEmbarque"

            Dim wpEstado As String = ""
            Dim wpTextoERR As String = ""
            While Dato.DataReader.Read

                wpEstado = Dato.DataReader.Item("Estado")
                wpTextoERR = Dato.DataReader.Item("Texto")

            End While

            If wpEstado = "ER" Then

                CRespuesta.Estado = False
                CRespuesta.Texto = wpTextoERR
                CRespuesta.Resultado = Nothing
            Else

                CRespuesta.Estado = True
                CRespuesta.Texto = wpTextoERR
                CRespuesta.Resultado = ""
            End If

        Catch ex As Exception
            CRespuesta.Estado = False
            CRespuesta.Texto = ex.Message
            CRespuesta.Resultado = Nothing
        End Try


        Return CRespuesta
    End Function
    Public Function LiberaOrdenEmbarque(ByVal prmValidacion As Integer, ByVal prmOrdenEmbarque As String,
                                  ByVal prmDetalle As String, ByVal prmGuia As String,
                                  ByVal prmEstacion As String, ByVal prmUsuario As String, ByVal prmTipo As String, ByVal prmEstado As Integer, ByVal prmCantidadPedida As Double, ByVal prmCantidadASurtir As Double) As CResultado
        Dim CRespuesta As New CResultado
        Dim Dato As New clsDato
        Try
            ''Parametros
            Dato.Parametro("prmValidacion") = prmValidacion
            Dato.Parametro("prmOrdenEmbarque") = prmOrdenEmbarque
            Dato.Parametro("prmDetalle") = prmDetalle
            Dato.Parametro("prmGuia") = prmGuia
            Dato.Parametro("prmEstacion") = prmEstacion
            Dato.Parametro("prmUsuario") = prmUsuario
            Dato.Parametro("prmTipo") = prmTipo
            Dato.Parametro("prmEstado") = prmEstado
            Dato.Parametro("prmCantidadPedida") = prmCantidadPedida
            Dato.Parametro("prmCantidadASurtir") = prmCantidadASurtir
            Dato.SP(True) = "spInsLiberaOrdenEmbarque"

            Dim wpEstado As String = ""
            Dim wpTextoERR As String = ""
            While Dato.DataReader.Read

                wpEstado = Dato.DataReader.Item("Estado")
                wpTextoERR = Dato.DataReader.Item("Texto")

            End While

            If wpEstado = "ER" Then

                CRespuesta.Estado = False
                CRespuesta.Texto = wpTextoERR
                CRespuesta.Resultado = Nothing
            Else

                CRespuesta.Estado = True
                CRespuesta.Texto = wpTextoERR
                CRespuesta.Resultado = ""
            End If

        Catch ex As Exception
            CRespuesta.Estado = False
            CRespuesta.Texto = ex.Message
            CRespuesta.Resultado = Nothing
        End Try


        Return CRespuesta
    End Function

    Public Function LiberaxPartidaOrdenEmbarque(ByVal prmValidacion As Integer, ByVal prmOrdenEmbarque As String,
                                  ByVal prmDetalle As String, ByVal prmGuia As String,
                                  ByVal prmEstacion As String, ByVal prmUsuario As String, ByVal prmTipo As String, ByVal prmEstado As Integer, ByVal prmCantidadPedida As Integer, ByVal prmCantidadASurtir As Integer,
                                                ByVal prmEsta As String, ByVal prmTipoS As String, ByVal prmEsta2 As String, ByVal prmTipoS2 As String) As CResultado
        Dim CRespuesta As New CResultado
        Dim Dato As New clsDato
        Try
            ''Parametros
            Dato.Parametro("prmValidacion") = prmValidacion
            Dato.Parametro("prmOrdenEmbarque") = prmOrdenEmbarque
            Dato.Parametro("prmDetalle") = prmDetalle
            Dato.Parametro("prmGuia") = prmGuia
            Dato.Parametro("prmEstacion") = prmEstacion
            Dato.Parametro("prmUsuario") = prmUsuario
            Dato.Parametro("prmTipo") = prmTipo
            Dato.Parametro("prmEstado") = prmEstado
            Dato.Parametro("prmCantidadPedida") = prmCantidadPedida
            Dato.Parametro("prmCantidadASurtir") = prmCantidadASurtir
            Dato.Parametro("prmEsta") = prmEsta
            Dato.Parametro("prmTipoS") = prmTipoS
            Dato.Parametro("prmEst2") = prmEsta2
            Dato.Parametro("prmTipoS2") = prmTipoS2
            Dato.SP(True) = "spInsLiberaOrdenEmbarquexP"

            Dim wpEstado As String = ""
            Dim wpTextoERR As String = ""
            While Dato.DataReader.Read

                wpEstado = Dato.DataReader.Item("Estado")
                wpTextoERR = Dato.DataReader.Item("Texto")

            End While

            If wpEstado = "ER" Then

                CRespuesta.Estado = False
                CRespuesta.Texto = wpTextoERR
                CRespuesta.Resultado = Nothing
            Else

                CRespuesta.Estado = True
                CRespuesta.Texto = wpTextoERR
                CRespuesta.Resultado = ""
            End If

        Catch ex As Exception
            CRespuesta.Estado = False
            CRespuesta.Texto = ex.Message
            CRespuesta.Resultado = Nothing
        End Try


        Return CRespuesta
    End Function

    Public Function ListaOrdenEmbarque() As DataSet
        Dim dato As New clsDato
        Dim ds As New DataSet
        Try
            ds = dato.Tabla("spQryListaOrenesEmbarqueCombo")
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, " AXC")
        End Try
        Return ds
    End Function

    Friend Function GuardarGuia(prmOrdenEmbarque As String, prmGuia As String, ByVal prmPaqueteria As String, prmEstacion As String, prmUsuario As String) As CResultado
        Dim cRespuesta As New CResultado
        Try
            Dim db As New CAccesoDatos
            Dim dr As DataRow
            Dim sResultado As CResultado

            sResultado = db.SPToDataRow("spUpdGuiaOrdenEmbarque", prmOrdenEmbarque, prmGuia, prmPaqueteria, prmEstacion, prmUsuario)

            If sResultado.Estado Then
                dr = CType(sResultado.Resultado, DataRow)


                If dr("Estado") = "ER" Then
                    cRespuesta.Estado = False
                    cRespuesta.Texto = dr("Texto").ToString
                    cRespuesta.Resultado = Nothing
                Else
                    cRespuesta.Estado = True
                    cRespuesta.Texto = ""
                    cRespuesta.Resultado = Nothing
                End If
            Else
                cRespuesta.Estado = False
                cRespuesta.Texto = sResultado.Texto
                cRespuesta.Resultado = Nothing
            End If
        Catch ex As Exception
            cRespuesta.Estado = False
            cRespuesta.Texto = ex.Message
        End Try
        Return cRespuesta
    End Function

    Friend Function GuardarGuiaCustomer(prmOrdenEmbarque As String, prmGuia As String, ByVal prmPaqueteria As String, prmEstacion As String, prmUsuario As String) As CResultado
        Dim cRespuesta As New CResultado
        Try
            Dim db As New CAccesoDatos
            Dim dr As DataRow
            Dim sResultado As CResultado

            sResultado = db.SPToDataRow("spUpdGuiaCustomerOrdenEmbarque", prmOrdenEmbarque, prmGuia, prmPaqueteria, prmEstacion, prmUsuario)

            If sResultado.Estado Then
                dr = CType(sResultado.Resultado, DataRow)


                If dr("Estado") = "ER" Then
                    cRespuesta.Estado = False
                    cRespuesta.Texto = dr("Texto").ToString
                    cRespuesta.Resultado = Nothing
                Else
                    cRespuesta.Estado = True
                    cRespuesta.Texto = ""
                    cRespuesta.Resultado = Nothing
                End If
            Else
                cRespuesta.Estado = False
                cRespuesta.Texto = sResultado.Texto
                cRespuesta.Resultado = Nothing
            End If
        Catch ex As Exception
            cRespuesta.Estado = False
            cRespuesta.Texto = ex.Message
        End Try
        Return cRespuesta
    End Function

    Public Function ListaEstaciones() As DataSet
        Dim dato As New clsDato
        Dim ds As New DataSet
        Try
            ds = dato.Tabla("spQryListaEstaciones")
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, " AXC")
        End Try
        Return ds
    End Function


    Public Function ActualizaEstacion(ByVal prmArrCadena As String, ByVal prmOrden As String) As CResultado
        Dim sResultado As New CResultado
        Dim dato As New clsDato
        Dim db As New CAccesoDatos
        Dim ds As New DataSet
        Try
            sResultado = db.SPToDataRow("spUpEstacion", prmArrCadena, prmOrden, My.Settings.Estacion, DatosTemporales.Usuario)
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, " AXC")
        End Try
        Return sResultado
    End Function
    Public Function ListaRevisiones(ByVal prmNumParteMP As String) As DataSet

        Dim dato As New clsDato
        Dim ds As New DataSet
        Try
            dato.Parametro("prmNumParte") = prmNumParteMP
            ds = dato.Tabla("spQryListaRevisiones")
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, " AXC")
        End Try
        Return ds
    End Function

    Function ListaOrdenEmbarqueMonitor(ByVal prmStatus As String, ByVal prmEstacion As String, ByVal prmUsuario As String) As DataSet
        Dim dato As New clsDato
        Dim ds As New DataSet
        Try
            dato.Parametro("prmStatus") = prmStatus
            dato.Parametro("prmEstacion") = prmEstacion
            dato.Parametro("prmUsuario") = prmUsuario
            ds = dato.Tabla("spQryListaOrdenProd")
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, " AXC")
        End Try
        Return ds
    End Function

    Function ListaPalletsSinCerrar(ByVal prmOrdenEmbarque As String, ByVal prmEstacion As String, ByVal prmUsuario As String) As CResultado
        Dim pRespuesta As New CResultado
        Try
            Dim db As New CAccesoDatos
            Dim pResultado As CResultado
            Dim ds As DataSet
            Dim dt As DataTable

            pResultado = db.SPToDataSet("spQryListaOrdenEmbarquePalletSinCerrar", prmOrdenEmbarque, prmEstacion, prmUsuario)

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
                            pRespuesta.Texto = "Error al tratar de listar pallets"
                    End Select
                Next
            Else
                pRespuesta.Estado = False
                pRespuesta.Texto = pResultado.Texto
            End If

            Return pRespuesta

        Catch ex As Exception
            pRespuesta.Estado = False
            pRespuesta.Texto = "Error al tratar de listar pallets "
            Return pRespuesta
        End Try
    End Function

    Function ListaPalletsPteValida(ByVal prmOrdenEmbarque As String, ByVal prmEstacion As String, ByVal prmUsuario As String) As CResultado
        Dim pRespuesta As New CResultado
        Try
            Dim db As New CAccesoDatos
            Dim pResultado As CResultado
            Dim ds As DataSet
            Dim dt As DataTable

            pResultado = db.SPToDataSet("spQryListaOrdenEmbarquePalletPteValida", prmOrdenEmbarque, prmEstacion, prmUsuario)

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
                            pRespuesta.Texto = "Error al tratar de listar pallets"
                    End Select
                Next
            Else
                pRespuesta.Estado = False
                pRespuesta.Texto = pResultado.Texto
            End If

            Return pRespuesta

        Catch ex As Exception
            pRespuesta.Estado = False
            pRespuesta.Texto = "Error al tratar de listar pallets "
            Return pRespuesta
        End Try
    End Function

    Function ListaPalletsPteEntrega(ByVal prmOrdenEmbarque As String, ByVal prmEstacion As String, ByVal prmUsuario As String) As CResultado
        Dim pRespuesta As New CResultado
        Try
            Dim db As New CAccesoDatos
            Dim pResultado As CResultado
            Dim ds As DataSet
            Dim dt As DataTable

            pResultado = db.SPToDataSet("spQryListaOrdenEmbarquePalletPteEntrega", prmOrdenEmbarque, prmEstacion, prmUsuario)

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
                            pRespuesta.Texto = "Error al tratar de listar pallets"
                    End Select
                Next
            Else
                pRespuesta.Estado = False
                pRespuesta.Texto = pResultado.Texto
            End If

            Return pRespuesta

        Catch ex As Exception
            pRespuesta.Estado = False
            pRespuesta.Texto = "Error al tratar de listar pallets "
            Return pRespuesta
        End Try
    End Function

    Function ListarPartidas(ByVal prmOrdenEmbarque As String, ByVal prmEstacion As String, ByVal prmUsuario As String) As CResultado
        Dim pRespuesta As New CResultado
        Try
            Dim db As New CAccesoDatos
            Dim pResultado As CResultado
            Dim ds As DataSet
            Dim dt As DataTable

            pResultado = db.SPToDataSet("spQryListaDetalleOrdenEmbarque", prmOrdenEmbarque, prmEstacion, prmUsuario)

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
                            pRespuesta.Texto = "Error al tratar de listar Partidas"
                    End Select
                Next
            Else
                pRespuesta.Estado = False
                pRespuesta.Texto = pResultado.Texto
            End If

            Return pRespuesta

        Catch ex As Exception
            pRespuesta.Estado = False
            pRespuesta.Texto = "Error al tratar de listar Partidas "
            Return pRespuesta
        End Try
    End Function

    Function ListaPalletsPteTransito(ByVal prmOrdenEmbarque As String, ByVal prmEstacion As String, ByVal prmUsuario As String) As CResultado
        Dim pRespuesta As New CResultado
        Try
            Dim db As New CAccesoDatos
            Dim pResultado As CResultado
            Dim ds As DataSet
            Dim dt As DataTable

            pResultado = db.SPToDataSet("spQryListaOrdenEmbarquePalletTransito", prmOrdenEmbarque, prmEstacion, prmUsuario)

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
                            pRespuesta.Texto = "Error al tratar de listar pallets"
                    End Select
                Next
            Else
                pRespuesta.Estado = False
                pRespuesta.Texto = pResultado.Texto
            End If

            Return pRespuesta

        Catch ex As Exception
            pRespuesta.Estado = False
            pRespuesta.Texto = "Error al tratar de listar pallets "
            Return pRespuesta
        End Try
    End Function

    Friend Function CancelaEmbarque(ByVal prmPedido As String, ByVal prmEstacion As String, ByVal prmUsuario As String) As CResultado

        Dim cRespuesta As New CResultado
        Try
            Dim db As New CAccesoDatos
            Dim dr As DataRow
            Dim CResultado As CResultado

            CResultado = db.SPToDataRow("spUpdCancelaEmbarque", prmPedido, prmEstacion, prmUsuario)

            If CResultado.Estado Then
                dr = CResultado.Resultado

                If dr("Estado") = "ER" Then
                    cRespuesta.Estado = False
                    cRespuesta.Texto = dr("Texto").ToString
                    cRespuesta.Resultado = Nothing
                Else
                    cRespuesta.Estado = True
                    cRespuesta.Texto = ""
                    cRespuesta.Resultado = Nothing
                End If
            Else
                cRespuesta.Estado = False
                cRespuesta.Texto = CResultado.Texto
                cRespuesta.Resultado = Nothing
            End If
        Catch ex As Exception
            cRespuesta.Estado = False
            cRespuesta.Texto = ex.Message
        End Try
        Return cRespuesta
    End Function


    Function ListaOrdenesTrabajo(ByVal prmOrdenTrabajo As String, ByVal prmFechaDesde As String, ByVal prmFechaHasta As String, ByVal prmEstacion As String, ByVal prmUsuario As String) As DataSet
        Dim dato As New clsDato
        Dim ds As New DataSet
        Try
            dato.Parametro("prmOrdenTrabajo") = prmOrdenTrabajo
            dato.Parametro("prmFechaDesde") = prmFechaDesde
            dato.Parametro("prmFechaHasta") = prmFechaHasta
            dato.Parametro("prmEstacion") = prmEstacion
            dato.Parametro("prmUsuario") = prmUsuario
            ds = dato.Tabla("spQryListaOrdenTrabajo")
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, " AXC")
        End Try
        Return ds
    End Function

    Function ListaOrdenesTrabajoDet(ByVal prmOrdenTrabajo As String, ByVal prmEstacion As String, ByVal prmUsuario As String) As DataSet
        Dim dato As New clsDato
        Dim ds As New DataSet
        Try
            dato.Parametro("prmOrdenTrabajo") = prmOrdenTrabajo
            dato.Parametro("prmEstacion") = prmEstacion
            dato.Parametro("prmUsuario") = prmUsuario
            ds = dato.Tabla("spQryListaOrdenTrabajoDet")
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, " AXC")
        End Try
        Return ds
    End Function

    Function ListaOrdenesTrabajoPallets(ByVal prmOrdenTrabajo As String, ByVal prmEstacion As String, ByVal prmUsuario As String) As DataSet
        Dim dato As New clsDato
        Dim ds As New DataSet
        Try
            dato.Parametro("prmOrdenTrabajo") = prmOrdenTrabajo
            dato.Parametro("prmEstacion") = prmEstacion
            dato.Parametro("prmUsuario") = prmUsuario
            ds = dato.Tabla("spQryListaOrdenTrabajoPallets")
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, " AXC")
        End Try
        Return ds
    End Function

    Function ListaOrdenEmbarqueMonitorTodas(ByVal prmOrdenEmbarque As String, ByVal prmEstacion As String, ByVal prmUsuario As String) As CResultado
        Dim pRespuesta As New CResultado
        Try
            Dim db As New CAccesoDatos
            Dim pResultado As CResultado
            Dim ds As DataSet
            Dim dt As DataTable

            pResultado = db.SPToDataSet("spQryListaOrdenEmbarqueTodas", prmOrdenEmbarque, prmEstacion, prmUsuario)

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
                            pRespuesta.Estado = False
                            pRespuesta.Texto = "Error al tratar de listar embarques"
                    End Select
                Next
            Else
                pRespuesta.Estado = False
                pRespuesta.Texto = pResultado.Texto
            End If

            Return pRespuesta

        Catch ex As Exception
            pRespuesta.Estado = False
            pRespuesta.Texto = "Error al tratar de listar embarques"
            Return pRespuesta
        End Try
    End Function

    Public Function ConsultaPalletPorEmbarque(
                                       ByVal prmEmbarque As String,
                                       ByVal prmFechaInicio As DateTime,
                                       ByVal prmFechaFinal As DateTime,
                                       ByVal prmEstacion As String,
                                       ByVal prmUsuario As String
                                       ) As DataSet
        Dim dato As New clsDato()
        Dim ds As New DataSet
        Try
            dato.Parametro("prmEmbarque") = prmEmbarque
            dato.Parametro("prmFechaInicio") = prmFechaInicio
            dato.Parametro("prmFechaFinal") = prmFechaFinal
            dato.Parametro("prmEstacion") = prmEstacion
            dato.Parametro("prmUsuario") = prmUsuario
            ds = dato.Tabla("spQryListaPalletsEmbarque")
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, " AXC")
        End Try

        Return ds
    End Function

    Friend Function ListaSurtidos(ByVal prmOrdenCompra As String, ByVal prmEstacion As String, ByVal prmUsuario As String) As CResultado
        Dim pRespuesta As New CResultado
        Try
            Dim db As New CAccesoDatos
            Dim pResultado As CResultado
            Dim ds As DataSet
            Dim dt As DataTable

            pResultado = db.SPToDataSet("spQryListaDocSurtidos", prmOrdenCompra, prmEstacion, prmUsuario)

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
                            pRespuesta.Estado = False
                            pRespuesta.Texto = "Error al tratar de listar documentos de surtidos"
                    End Select
                Next
            Else
                pRespuesta.Estado = False
                pRespuesta.Texto = pResultado.Texto
            End If

            Return pRespuesta

        Catch ex As Exception
            pRespuesta.Estado = False
            pRespuesta.Texto = "Error al tratar de listar documentos de Surtidos"
            Return pRespuesta
        End Try
    End Function

    Friend Function ListaPartidasSurtido(prmRecepcion As String, prmEstacion As String, prmUsuario As String) As CResultado
        Dim pRespuesta As New CResultado
        Try
            Dim db As New CAccesoDatos
            Dim pResultado As CResultado
            Dim ds As DataSet
            Dim dt As DataTable

            pResultado = db.SPToDataSet("spQryListaPartidasSurtido", prmRecepcion, prmEstacion, prmUsuario)

            If pResultado.Estado Then
                ds = pResultado.Resultado

                For Each dr As DataRow In ds.Tables(0).Rows

                    Select Case dr("Estado").ToString
                        Case "OK"
                            dt = ds.Tables(1).Copy
                            pRespuesta.Estado = True
                            pRespuesta.Texto = ""
                            pRespuesta.Resultado = pResultado.Resultado
                        Case "ER"
                            pRespuesta.Estado = False
                            pRespuesta.Texto = dr("Texto").ToString
                        Case Else
                            pRespuesta.Estado = False
                            pRespuesta.Texto = "Error al tratar de listar partidas "
                    End Select
                Next
            Else
                pRespuesta.Estado = False
                pRespuesta.Texto = pResultado.Texto
            End If

            Return pRespuesta

        Catch ex As Exception
            pRespuesta.Estado = False
            pRespuesta.Texto = "Error al tratar de listar partidas "
            Return pRespuesta
        End Try
    End Function

    Friend Function ListaPalletsPorSurtido(prmRecepcion As Integer, ByVal prmEstacion As String, ByVal prmUsuario As String) As CResultado
        Dim pRespuesta As New CResultado
        Try
            Dim db As New CAccesoDatos
            Dim pResultado As CResultado
            Dim ds As DataSet
            Dim dt As DataTable

            pResultado = db.SPToDataSet("spQryListaPalletsSurtido", prmRecepcion, prmEstacion, prmUsuario)

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
                            pRespuesta.Estado = False
                            pRespuesta.Texto = "Error al tratar de listar pallets"
                    End Select
                Next
            Else
                pRespuesta.Estado = False
                pRespuesta.Texto = pResultado.Texto
            End If

            Return pRespuesta

        Catch ex As Exception
            pRespuesta.Estado = False
            pRespuesta.Texto = "Error al tratar de listar pallets "
            Return pRespuesta
        End Try
    End Function

    Public Function ConsultaOEDet(ByVal prmOrdenEmbarque As String) As CResultado
        Dim pResupuesta As New CResultado
        Try
            Dim db As New CAccesoDatos
            Dim pResultado As CResultado
            Dim ds As DataSet
            Dim dt As DataTable

            pResultado = db.SPToDataSet("spQryConsultaOEDet", prmOrdenEmbarque)

            If pResultado.Estado Then
                ds = CType(pResultado.Resultado, DataSet)

                For Each dr As DataRow In ds.Tables(0).Rows
                    Select Case dr("Estado").ToString
                        Case "OK"
                            dt = ds.Tables(1).Copy
                            pResupuesta.Estado = True
                            pResupuesta.Texto = ""
                            pResupuesta.Tabla = dt
                        Case "ER"
                            pResupuesta.Estado = False
                            pResupuesta.Texto = dr("Texto").ToString
                        Case Else
                            pResupuesta.Estado = False
                            pResupuesta.Texto = "Error al tratar de listar el detalle"
                    End Select
                Next
            Else
                pResupuesta.Estado = False
                pResupuesta.Texto = pResultado.Texto
            End If

            Return pResupuesta


        Catch ex As Exception
            pResupuesta.Estado = False
            pResupuesta.Texto = "Error al tratar de listar el detalle"
            Return pResupuesta
        End Try

    End Function

    Friend Function BuscarEmbarquesPorFecha(ByVal prmFechaInicio As String, ByVal prmFechaFin As String, ByVal prmEstacion As String, ByVal prmUsuario As String) As CResultado
        Dim pRespuesta As New CResultado
        Try
            Dim db As New CAccesoDatos
            Dim pResultado As CResultado
            Dim ds As DataSet
            Dim dt As DataTable

            pResultado = db.SPToDataSet("spQryOrdenEmbarquesPorFecha", prmFechaInicio, prmFechaFin, prmEstacion, prmUsuario)

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
                            pRespuesta.Estado = False
                            pRespuesta.Texto = "Error al tratar de listar "
                    End Select
                Next
            Else
                pRespuesta.Estado = False
                pRespuesta.Texto = pResultado.Texto
            End If

            Return pRespuesta

        Catch ex As Exception
            pRespuesta.Estado = False
            pRespuesta.Texto = "Error al tratar de listar "
            Return pRespuesta
        End Try
    End Function

    Friend Function RptOrdenEmbarque(ByVal prmOrdenCompra As String, ByVal prmEstacion As String, ByVal prmUsuario As String) As CResultado
        Dim pRespuesta As New CResultado
        Try
            Dim db As New CAccesoDatos
            Dim pResultado As CResultado
            Dim ds As DataSet
            Dim dt As DataTable

            pResultado = db.SPToDataSet("spRptQryOrdenEmbarque", prmOrdenCompra, prmEstacion, prmUsuario)

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
                            pRespuesta.Texto = "Error al tratar de listar "
                    End Select
                Next
            Else
                pRespuesta.Estado = False
                pRespuesta.Texto = pResultado.Texto
            End If

            Return pRespuesta

        Catch ex As Exception
            pRespuesta.Estado = False
            pRespuesta.Texto = "Error al tratar de listar "
            Return pRespuesta
        End Try
    End Function

    Friend Function CargaTotales(prmFecha As String) As CResultado
        Dim pRespuesta As New CResultado
        Dim pRespuesta2 As New CResultado
        Try
            Dim db As New CAccesoDatos
            Dim pResultado As CResultado
            Dim ds As DataSet
            Dim dt As DataTable
            Dim dt2 As DataTable


            pResultado = db.SPToDataSet("spQryTotalesDashboardE", prmFecha)

            If pResultado.Estado Then
                ds = pResultado.Resultado

                For Each dr As DataRow In ds.Tables(0).Rows

                    Select Case dr("Estado").ToString
                        Case "OK"
                            dt = ds.Tables(1).Copy
                            'dt = ds.Tables().Copy
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

    Friend Function Estatus(prmFecha As String) As CResultado
        Dim pRespuesta As New CResultado
        Dim pRespuesta2 As New CResultado
        Try
            Dim db As New CAccesoDatos
            Dim pResultado As CResultado
            Dim ds As DataSet
            Dim dt As DataTable
            Dim dt2 As DataTable


            pResultado = db.SPToDataSet("spQryDetalleDashboardE", prmFecha)

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

    Friend Function EstacionesDiaM(prmFecha As String) As CResultado
        Dim pRespuesta As New CResultado
        Dim pRespuesta2 As New CResultado
        Try
            Dim db As New CAccesoDatos
            Dim pResultado As CResultado
            Dim ds As DataSet
            Dim dt As DataTable
            Dim dt2 As DataTable


            pResultado = db.SPToDataSet("spQryEstacionesDashboardE", prmFecha)

            If pResultado.Estado Then
                ds = pResultado.Resultado

                For Each dr As DataRow In ds.Tables(0).Rows

                    Select Case dr("Estado").ToString
                        Case "OK"
                            dt = ds.Tables(1).Copy
                            'dt = ds.Tables(2).Copy
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

End Class
