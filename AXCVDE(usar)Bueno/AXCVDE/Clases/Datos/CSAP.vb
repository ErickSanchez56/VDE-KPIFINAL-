Imports SAP.Middleware.Connector

Public Class CSAP
    Public Function NotificarOCSAP(prmDocumento As String, prmFactura As String, prmDatos As DataSet, prmLotes As DataSet) As String
        'Parametros de  conexión a SAP
        Dim sapParametros As New RfcConfigParameters
        sapParametros(RfcConfigParameters.User) = CMetodos.ConfigLeer("SAPuser")
        sapParametros(RfcConfigParameters.Password) = CMetodos.ConfigLeer("SAPpass")
        sapParametros(RfcConfigParameters.SystemID) = CMetodos.ConfigLeer("SAPsystemId")
        sapParametros(RfcConfigParameters.Client) = CMetodos.ConfigLeer("SAPclient")
        sapParametros(RfcConfigParameters.Name) = CMetodos.ConfigLeer("SAPname")
        sapParametros(RfcConfigParameters.AppServerHost) = CMetodos.ConfigLeer("SAPhost")
        sapParametros(RfcConfigParameters.SystemNumber) = CMetodos.ConfigLeer("SAPsystemNumber")
        sapParametros(RfcConfigParameters.Language) = "ES"

        Try
            'Conexión a SAP
            Dim destino As RfcDestination
            destino = RfcDestinationManager.GetDestination(sapParametros)

            destino.Ping()
            'Función para ejecutar BAPI_GOODSMVT_CREATE
            Dim funcion As IRfcFunction
            funcion = destino.Repository.CreateFunction("BAPI_GOODSMVT_CREATE")



            'Encabezado GOODSMVT_HEADER
            Dim str_GOODSMVT_HEADER As IRfcStructure = funcion.GetStructure("GOODSMVT_HEADER")
            str_GOODSMVT_HEADER.SetValue("PSTNG_DATE", Format(Now, "yyyyMMdd"))
            str_GOODSMVT_HEADER.SetValue("DOC_DATE", Format(Now, "yyyyMMdd"))
            str_GOODSMVT_HEADER.SetValue("PR_UNAME", "soporteaxc") 'Revisar usuario que nos darán
            str_GOODSMVT_HEADER.SetValue("REF_DOC_NO", prmFactura)

            'Parametros para GOODSMVT_CODE
            Dim str_GOODSMVT_CODE As IRfcStructure = funcion.GetStructure("GOODSMVT_CODE")
            str_GOODSMVT_CODE.SetValue("GM_CODE", "01")

            'Movimimentos de productos a generar en SAP
            Dim tblGOODSMVT_ITEM As IRfcTable = funcion.GetTable("GOODSMVT_ITEM")

            For Each drow As DataRow In prmDatos.Tables(0).Rows
                If Double.Parse(drow("CantidadARecibir").ToString) > 0 Then


                    For Each dLote As DataRow In prmLotes.Tables(0).Rows
                        Dim FechaCaducidad As String = ""
                        Dim FechaProd As String = ""
                        Dim pLoteInterno As String = ""
                        Dim pValorSAP_NO_MORE_GR As String

                        If String.IsNullOrEmpty(My.Settings("SAP_NO_MORE_GR").ToString) Then
                            pValorSAP_NO_MORE_GR = "1"
                        Else
                            pValorSAP_NO_MORE_GR = My.Settings("SAP_NO_MORE_GR").ToString
                        End If

                        If String.IsNullOrEmpty(dLote("FechaCaducidad").ToString) Then
                            FechaCaducidad = ""
                        Else
                            FechaCaducidad = Format(CDate(dLote("FechaCaducidad")), "yyyyMMdd")
                        End If

                        'If String.IsNullOrEmpty(dLote("FechaProd")) Then
                        '    FechaProd = ""
                        'Else
                        '    FechaProd = Format(CDate(dLote("FechaProd")), "yyyyMMdd")
                        'End If

                        If drow("Partida").ToString.Equals(dLote("Partida").ToString) Then
                            If String.IsNullOrEmpty(dLote("LoteInterno").ToString) Then
                                pLoteInterno = ""
                            Else
                                pLoteInterno = dLote("LoteInterno").ToString
                            End If
                            tblGOODSMVT_ITEM.Append()
                            tblGOODSMVT_ITEM.SetValue("MATERIAL", drow("CodigoExterno")) '000000000000303367 'Producto
                            tblGOODSMVT_ITEM.SetValue("PLANT", drow("Tag1")) '1000 'centro
                            tblGOODSMVT_ITEM.SetValue("STGE_LOC", drow("Tag2")) '3000 'almacén origen
                            tblGOODSMVT_ITEM.SetValue("BATCH", pLoteInterno) ' 'Lote
                            tblGOODSMVT_ITEM.SetValue("MOVE_TYPE", "101") '101 'tipo de movimiento de la posición
                            tblGOODSMVT_ITEM.SetValue("MVT_IND", "B")
                            tblGOODSMVT_ITEM.SetValue("ENTRY_QNT", dLote("Cantidad")) '120 'Cantidad

                            If pValorSAP_NO_MORE_GR = "1" Then
                                tblGOODSMVT_ITEM.SetValue("NO_MORE_GR", "X") 'Solo se envía fijo
                            End If
                            tblGOODSMVT_ITEM.SetValue("PO_NUMBER", prmDocumento) '4500088062 ' Documento
                            tblGOODSMVT_ITEM.SetValue("PO_ITEM", dLote("Partida"))
                            tblGOODSMVT_ITEM.SetValue("EXPIRYDATE", FechaCaducidad)
                            tblGOODSMVT_ITEM.SetValue("VENDRBATCH", dLote("LoteProveedor").ToString)
                            tblGOODSMVT_ITEM.SetValue("PROD_DATE", Format(CDate(dLote("FechaProd")), "yyyyMMdd"))
                            'tblGOODSMVT_ITEM.SetValue("PROD_DATE", "20190725")
                        End If

                    Next
                End If

            Next

            'Ejecutar la BAPI

            Dim ejecuta As New RfcTransaction
            funcion.Invoke(destino)
            ejecuta.AddFunction(funcion)
            ejecuta.Commit(destino)

            'resultado
            Dim tbl_RETURN As IRfcTable = funcion.GetTable("RETURN")
            Dim count As Integer

            count = tbl_RETURN.RowCount
            If count > 0 Then
                Dim field As String = "Error SAP: "
                For Each row As IRfcStructure In tbl_RETURN
                    field = field & row.GetString("MESSAGE")
                Next
                Return field
            End If
            Return "OK"
        Catch ex As Exception
            'MsgBox(ex.Message)
            Return "Error SAP: " & ex.Message
        End Try
    End Function

    Public Function NotificarOCSAPOriginal(prmDocumento As String, prmFactura As String, prmDatos As DataSet, prmLotes As DataSet) As String
        'Parametros de  conexión a SAP
        Dim sapParametros As New RfcConfigParameters
        sapParametros(RfcConfigParameters.User) = CMetodos.ConfigLeer("SAPuser")
        sapParametros(RfcConfigParameters.Password) = CMetodos.ConfigLeer("SAPpass")
        sapParametros(RfcConfigParameters.SystemID) = CMetodos.ConfigLeer("SAPsystemId")
        sapParametros(RfcConfigParameters.Client) = CMetodos.ConfigLeer("SAPclient")
        sapParametros(RfcConfigParameters.Name) = CMetodos.ConfigLeer("SAPname")
        sapParametros(RfcConfigParameters.AppServerHost) = CMetodos.ConfigLeer("SAPhost")
        sapParametros(RfcConfigParameters.SystemNumber) = CMetodos.ConfigLeer("SAPsystemNumber")
        sapParametros(RfcConfigParameters.Language) = "ES"

        Try
            'Conexión a SAP
            Dim destino As RfcDestination
            destino = RfcDestinationManager.GetDestination(sapParametros)

            'Función para ejecutar BAPI_GOODSMVT_CREATE
            Dim funcion As IRfcFunction = destino.Repository.CreateFunction("BAPI_GOODSMVT_CREATE")

            'Encabezado GOODSMVT_HEADER
            Dim str_GOODSMVT_HEADER As IRfcStructure = funcion.GetStructure("GOODSMVT_HEADER")
            str_GOODSMVT_HEADER.SetValue("PSTNG_DATE", Format(Now, "yyyyMMdd"))
            str_GOODSMVT_HEADER.SetValue("DOC_DATE", Format(Now, "yyyyMMdd"))
            str_GOODSMVT_HEADER.SetValue("PR_UNAME", "soporteaxc") 'Revisar usuario que nos darán
            str_GOODSMVT_HEADER.SetValue("REF_DOC_NO", prmFactura)

            'Parametros para GOODSMVT_CODE
            Dim str_GOODSMVT_CODE As IRfcStructure = funcion.GetStructure("GOODSMVT_CODE")
            str_GOODSMVT_CODE.SetValue("GM_CODE", "01")

            'Movimimentos de productos a generar en SAP
            Dim tblGOODSMVT_ITEM As IRfcTable = funcion.GetTable("GOODSMVT_ITEM")

            For Each drow As DataRow In prmDatos.Tables(0).Rows
                If Double.Parse(drow("CantidadARecibir").ToString) > 0 Then


                    For Each dLote As DataRow In prmLotes.Tables(0).Rows
                        If drow("Partida").ToString.Equals(dLote("Partida").ToString) Then
                            tblGOODSMVT_ITEM.Append()
                            tblGOODSMVT_ITEM.SetValue("MATERIAL", drow("CodigoExterno")) '000000000000303367 'Producto
                            tblGOODSMVT_ITEM.SetValue("PLANT", drow("Tag1")) '1000 'centro
                            tblGOODSMVT_ITEM.SetValue("STGE_LOC", drow("Tag2")) '3000 'almacén origen
                            tblGOODSMVT_ITEM.SetValue("BATCH", dLote("LoteInterno").ToString) ' 'Lote
                            tblGOODSMVT_ITEM.SetValue("MOVE_TYPE", "101") '101 'tipo de movimiento de la posición
                            tblGOODSMVT_ITEM.SetValue("MVT_IND", "B")
                            tblGOODSMVT_ITEM.SetValue("ENTRY_QNT", dLote("Cantidad")) '120 'Cantidad
                            tblGOODSMVT_ITEM.SetValue("NO_MORE_GR", "X") 'Solo se envía fijo
                            tblGOODSMVT_ITEM.SetValue("PO_NUMBER", prmDocumento) '4500088062 ' Documento
                            tblGOODSMVT_ITEM.SetValue("PO_ITEM", dLote("Partida"))
                            tblGOODSMVT_ITEM.SetValue("EXPIRYDATE", Format(CDate(dLote("FechaCaducidad")), "yyyyMMdd"))
                            tblGOODSMVT_ITEM.SetValue("VENDRBATCH", dLote("LoteProveedor"))
                            '  tblGOODSMVT_ITEM.SetValue("PROD_DATE", Format(CDate(dLote("FechaProd")), "yyyyMMdd"))
                            tblGOODSMVT_ITEM.SetValue("PROD_DATE", "20190725")
                        End If

                    Next
                End If

            Next

            'Ejecutar la BAPI

            Dim ejecuta As New RfcTransaction
            funcion.Invoke(destino)
            ejecuta.AddFunction(funcion)
            ejecuta.Commit(destino)

            'resultado
            Dim tbl_RETURN As IRfcTable = funcion.GetTable("RETURN")
            Dim count As Integer

            count = tbl_RETURN.RowCount
            If count > 0 Then
                Dim field As String = "Error SAP: "
                For Each row As IRfcStructure In tbl_RETURN
                    field = field & row.GetString("MESSAGE")
                Next
                Return field
            End If
            Return "OK"
        Catch ex As Exception
            'MsgBox(ex.Message)
            Return "Error SAP: " & ex.Message
        End Try
    End Function

    Public Function CierraReciboTraspasoParcialSap(ByVal prmDocumento As String, ByVal prmEstacion As String, prmUsuario As String, prmVerifica As Integer) As CResultado
        Dim pRespuesta As New CResultado

        Try
            Dim db As New CAccesoDatos
            Dim pResultado As CResultado
            Dim ds As DataSet
            Dim dt As DataTable
            ' pRespuesta.Estado = True
            ' pRespuesta.Texto = ""
            pResultado = db.SPToDataSet("spQrySAPReciboTransferAdmin", prmDocumento, prmEstacion, prmUsuario, prmVerifica)

            If pResultado.Estado Then
                ds = pResultado.Resultado

                For Each dr As DataRow In ds.Tables(0).Rows

                    Select Case dr("Estado").ToString
                        Case "OK"
                            dt = ds.Tables(1).Copy

                            pRespuesta.Estado = True
                            pRespuesta.Texto = ""
                            pRespuesta.Tabla = dt

                            Dim respuesta As String = ""


                            If prmDocumento.Substring(0, 2) = "49" Then

                                ' respuesta = NotificarReciboTraspasoSAP49(prmDocumento, dt.Copy)

                            Else
                                If prmDocumento.Substring(0, 4) = "0084" Then
                                    ' respuesta = NotificaPedidoPT(prmDocumento)
                                Else
                                    respuesta = NotificarReciboTraspasoSAP8(prmDocumento, dt.Copy)
                                End If

                            End If

                            If Not respuesta.Equals("OK") Then
                                pRespuesta.Estado = False
                                pRespuesta.Texto = respuesta
                            Else
                                pRespuesta.Estado = True
                                pRespuesta.Texto = respuesta
                            End If


                        Case "ER"
                            pRespuesta.Estado = False
                            pRespuesta.Texto = dr("Texto").ToString

                        Case Else
                            pRespuesta.Estado = False
                            pRespuesta.Texto = "Error al cerrar orden en SAP"
                    End Select
                Next
            Else
                pRespuesta.Estado = False
                pRespuesta.Texto = pResultado.Texto
            End If

            Return pRespuesta
        Catch ex As Exception

            pRespuesta.Estado = False
            pRespuesta.Texto = "Error al cerrar orden de traspaso [SP1] " + ex.Message

            Return pRespuesta
        End Try
    End Function



    Public Function NotificarReciboTraspasoSAP8(prmDocumento As String, prmDatos As DataTable) As String
        'Parametros de  conexión a SAP
        Dim sapParametros As New RfcConfigParameters
        sapParametros(RfcConfigParameters.User) = CMetodos.ConfigLeer("SAPuser")
        sapParametros(RfcConfigParameters.Password) = CMetodos.ConfigLeer("SAPpass")
        sapParametros(RfcConfigParameters.SystemID) = CMetodos.ConfigLeer("SAPsystemId")
        sapParametros(RfcConfigParameters.Client) = CMetodos.ConfigLeer("SAPclient")
        sapParametros(RfcConfigParameters.Name) = CMetodos.ConfigLeer("SAPname")
        sapParametros(RfcConfigParameters.AppServerHost) = CMetodos.ConfigLeer("SAPhost")
        sapParametros(RfcConfigParameters.SystemNumber) = CMetodos.ConfigLeer("SAPsystemNumber")
        sapParametros(RfcConfigParameters.Language) = "ES"

        Try
            'Conexión a SAP
            Dim destino As RfcDestination
            destino = RfcDestinationManager.GetDestination(sapParametros)

            'Función para ejecutar BAPI_GOODSMVT_CREATE
            Dim funcion As IRfcFunction = destino.Repository.CreateFunction("BAPI_GOODSMVT_CREATE")

            'Encabezado GOODSMVT_HEADER
            Dim str_GOODSMVT_HEADER As IRfcStructure = funcion.GetStructure("GOODSMVT_HEADER")
            str_GOODSMVT_HEADER.SetValue("PSTNG_DATE", Format(Now, "yyyyMMdd"))
            str_GOODSMVT_HEADER.SetValue("DOC_DATE", Format(Now, "yyyyMMdd"))
            str_GOODSMVT_HEADER.SetValue("PR_UNAME", "soporteaxc")

            'Parametros para GOODSMVT_CODE
            Dim str_GOODSMVT_CODE As IRfcStructure = funcion.GetStructure("GOODSMVT_CODE")
            str_GOODSMVT_CODE.SetValue("GM_CODE", "01")

            'Movimimentos de productos a generar en SAP
            Dim tblGOODSMVT_ITEM As IRfcTable = funcion.GetTable("GOODSMVT_ITEM")



            For Each drow As DataRow In prmDatos.Rows
                tblGOODSMVT_ITEM.Append()
                tblGOODSMVT_ITEM.SetValue("MATERIAL", drow("CodigoExterno").ToString)
                tblGOODSMVT_ITEM.SetValue("PLANT", drow("Planta").ToString)
                tblGOODSMVT_ITEM.SetValue("STGE_LOC", drow("Almacen").ToString)
                tblGOODSMVT_ITEM.SetValue("BATCH", drow("Lote").ToString)
                tblGOODSMVT_ITEM.SetValue("MOVE_TYPE", drow("Mov").ToString)
                tblGOODSMVT_ITEM.SetValue("ENTRY_QNT", drow("CantidadRecibida").ToString)
                tblGOODSMVT_ITEM.SetValue("ENTRY_UOM", drow("UM").ToString)
                tblGOODSMVT_ITEM.SetValue("PO_NUMBER", drow("OrdenCompra").ToString)
                tblGOODSMVT_ITEM.SetValue("PO_ITEM", drow("OCPos").ToString)
                tblGOODSMVT_ITEM.SetValue("MVT_IND", "B")
                tblGOODSMVT_ITEM.SetValue("EXPIRYDATE", drow("FechaCaducidad").ToString)
                tblGOODSMVT_ITEM.SetValue("PROD_DATE", drow("FechaProduccion").ToString)
                tblGOODSMVT_ITEM.SetValue("DELIV_NUMB", prmDocumento)
                tblGOODSMVT_ITEM.SetValue("DELIV_ITEM", drow("OriginPos").ToString)

            Next

            'Ejecutar la BAPI
            '  CMetodos.EscribirBitacora(CMetodos.Bitacora.INCIDENCIA, funcion.ToString, "Interface.Taspaso8")

            Dim ejecuta As New RfcTransaction
            funcion.Invoke(destino)
            ejecuta.AddFunction(funcion)
            ejecuta.Commit(destino)
            '  CMetodos.EscribirBitacora(CMetodos.Bitacora.INCIDENCIA, funcion.ToString, "Interface.Taspaso8")

            'resultado
            Dim tbl_RETURN As IRfcTable = funcion.GetTable("RETURN")
            Dim count As Integer

            count = tbl_RETURN.RowCount
            If count > 0 Then
                Dim field As String = "Error SAP: "
                For Each row As IRfcStructure In tbl_RETURN
                    field = field & row.GetString("MESSAGE")
                Next
                Return field
            End If
            Return "OK"
        Catch ex As Exception
            'MsgBox(ex.Message)
            Return "Error SAP: " & ex.Message
        End Try
    End Function

End Class
