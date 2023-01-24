Imports System.Deployment.Application
Imports System.Reflection
Imports DevExpress.Skins
Imports DevExpress.XtraEditors

Public Class FrmMenuPrincipal
    Dim closingPending As Boolean = False
    Private formCount As Integer = 0
    Public frmGlobal As Form
    Public frmGlobalPrevio As Form
    Private Sub XtraForm2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            closingPending = False
            If ApplicationDeployment.IsNetworkDeployed Then
                'MsgBox(ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString)
                Me.Text = "AXC " + ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString
            Else
                'MsgBox(Assembly.GetExecutingAssembly.GetName.Version.ToString)
                Me.Text = "AXC " + Assembly.GetExecutingAssembly.GetName.Version.ToString
            End If
            FrmLogin.Close()

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub

    Private Sub XtraForm2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            If closingPending = False Then
                e.Cancel = True
                closingPending = True
                Return
            End If
            If XtraMessageBox.Show("Se cerrará la aplicación y las pestañas, ¿Desea continuar?", "AXC", MessageBoxButtons.YesNo) = DialogResult.No Then
                e.Cancel = True
                Return
            End If
            '  closingPending = True
            Me.Dispose(True)
            FrmLogin.Show()
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
        'FrmLogin.Show()
    End Sub
    Public Sub AddNewForm(ByVal frm As Form)
        Try

            XtraTabbedMdiManager1.MdiParent = Me
            formCount += 1
            frm.MdiParent = Me
            frm.Show()
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub

    Private Sub XtraTabbedMdiManager1_PageRemoved(sender As Object, e As DevExpress.XtraTabbedMdi.MdiTabPageEventArgs) Handles XtraTabbedMdiManager1.PageRemoved
        Try
            formCount -= 1

            If formCount = 0 Then

                XtraTabbedMdiManager1.MdiParent = Nothing

                Me.IsMdiContainer = False

            End If
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub

    Private Sub XtraForm2_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        Try
            Me.Refresh()
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub

    Private Sub AccordionControl1_StateChanged(sender As Object, e As EventArgs) Handles AccordionControl1.StateChanged
        Try
            Me.Refresh()
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub

    Private Sub AccordionControlElement29_Click(sender As Object, e As EventArgs) Handles AccordionControlElement29.Click
        Try
            AddNewForm(New FrmPermisos())
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub

    Private Sub AccordionControlElement31_Click(sender As Object, e As EventArgs) Handles AccordionControlElement31.Click
        Try
            AddNewForm(New FrmConfiguracionAlmacen())
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub



    Private Sub AccordionControlElement24_Click(sender As Object, e As EventArgs) Handles AccordionControlElement24.Click
        Try
            ' FrmLiberaOrdenCompra.ShowDialog()
            AddNewForm(New FrmLiberaOrdenCompra())

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub

    Private Sub AccordionControlElement25_Click(sender As Object, e As EventArgs) Handles AccordionControlElement25.Click
        Try
            AddNewForm(New FrmMonitorRecepcionNew())
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub

    Private Sub AccordionControlElement26_Click(sender As Object, e As EventArgs) Handles AccordionControlElement26.Click
        Try
            AddNewForm(New FrmEliminarDocRecepcion())
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub

    Private Sub AccordionControlElement27_Click(sender As Object, e As EventArgs) Handles AccordionControlElement27.Click
        Try
            AddNewForm(New FrmConsultarOrdenesCompra())
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub

    Private Sub AccordionControlElement2_Click(sender As Object, e As EventArgs) Handles AccordionControlElement2.Click
        Try
            XtraMessageBox.Show("Opción deshabilitada", "Información", MessageBoxButtons.OK)
            Return
            'AddNewForm(New FrmTraspasoSalidaPT())
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub

    Private Sub AccordionControlElement4_Click(sender As Object, e As EventArgs) Handles AccordionControlElement4.Click
        Try
            'XtraMessageBox.Show("Opción deshabilitada", "Información", MessageBoxButtons.OK)
            'Return
            'AddNewForm(New FrmMonitorTraspaso())
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub


    Private Sub AccordionControlElement13_Click(sender As Object, e As EventArgs) Handles AccordionControlElement13.Click
        Try
            AddNewForm(New FrmLiberaOrdenEmbarque())
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub

    Private Sub AccordionControlElement8_Click(sender As Object, e As EventArgs) Handles AccordionControlElement8.Click
        Try
            AddNewForm(New FrmConsEmbarque())
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub

    Private Sub AccordionControlElement36_Click(sender As Object, e As EventArgs) Handles AccordionControlElement36.Click
        Try
            AddNewForm(New FrmMonitorSurtido())
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub

    Private Sub AccordionControlElement22_Click(sender As Object, e As EventArgs) Handles AccordionControlElement22.Click
        Try
            AddNewForm(New FrmReimpresionEtiquetasPallet())
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub

    Private Sub AccordionControlElement20_Click(sender As Object, e As EventArgs) Handles AccordionControlElement20.Click
        Try
            AddNewForm(New FrmImpresionEtiquetas())
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub

    Private Sub AccordionControlElement38_Click(sender As Object, e As EventArgs) Handles AccordionControlElement38.Click
        Try

            AddNewForm(New FrmConfiguracionMaxYMin())
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub

    Private Sub AccordionControlElement39_Click(sender As Object, e As EventArgs) Handles AccordionControlElement39.Click
        Try

            AddNewForm(New FrmPrioridadReabastecimiento())
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub

    Private Sub AccordionControlElement28_Click(sender As Object, e As EventArgs) Handles AccordionControlElement28.Click
        Try
            AddNewForm(New FrmUsuarios())
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub

    Private Sub AccordionControlElement30_Click(sender As Object, e As EventArgs) Handles AccordionControlElement30.Click
        Try
            AddNewForm(New FrmConfiguracionImpresora())
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub

    Private Sub AccordionControlElement35_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub AccordionControlElement33_Click(sender As Object, e As EventArgs) Handles AccordionControlElement33.Click
        Try
            AddNewForm(New FrmReferencia())
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub

    Private Sub AccordionControlElement34_Click(sender As Object, e As EventArgs) Handles AccordionControlElement34.Click

    End Sub

    Private Sub AccordionControlElement16_Click(sender As Object, e As EventArgs) Handles AccordionControlElement16.Click
        Try
            AddNewForm(New FrmMenuInventarios())
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub

    Private Sub AccordionControlElement17_Click(sender As Object, e As EventArgs) Handles AccordionControlElement17.Click
        Try
            AddNewForm(New FrmMonitorInventarios())
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub

    Private Sub AccordionControlElement18_Click(sender As Object, e As EventArgs) Handles AccordionControlElement18.Click
        Try
            AddNewForm(New FrmResultadoInventario())
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub

    Private Sub AccordionControlElement7_Click(sender As Object, e As EventArgs) Handles AccordionControlElement7.Click
        XtraMessageBox.Show("Opción deshabilitada", "Información", MessageBoxButtons.OK)
    End Sub

    Private Sub AccordionControlElement10_Click(sender As Object, e As EventArgs) Handles AccordionControlElement10.Click
        XtraMessageBox.Show("Opción deshabilitada", "Información", MessageBoxButtons.OK)
    End Sub

    Private Sub AccordionControlElement12_Click(sender As Object, e As EventArgs) Handles AccordionControlElement12.Click
        Try
            AddNewForm(New FrmExistenciasGeneral())
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub

    Private Sub AccordionControlElement14_Click(sender As Object, e As EventArgs) Handles AccordionControlElement14.Click
        Try
            AddNewForm(New FrmConsultaPallet())
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub





    Private Sub AccordionControlElement21_Click(sender As Object, e As EventArgs) Handles AccordionControlElement21.Click
        Try
            AddNewForm(New FrmCreaRecepcion())
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub




    Private Sub AccordionControlElement43_Click(sender As Object, e As EventArgs) Handles AccordionControlElement43.Click
        Try
            AddNewForm(New FrmClientes())
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub

    Private Sub AccordionControlElement44_Click(sender As Object, e As EventArgs) Handles AccordionControlElement44.Click
        Try
            AddNewForm(New FrmCatNumParte())
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub

    Private Sub AccordionControlElement45_Click(sender As Object, e As EventArgs) Handles AccordionControlElement45.Click
        Try
            AddNewForm(New FrmEmbarques())
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub

    Private Sub AccordionControlElement19_Click(sender As Object, e As EventArgs) Handles AccordionControlElement19.Click

    End Sub

    Private Sub AccordionControlElement46_Click(sender As Object, e As EventArgs) Handles AccordionControlElement46.Click
        Try
            AddNewForm(New FrmCreaOrdenEmbarque())
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub

    Private Sub AccordionControlElement47_Click(sender As Object, e As EventArgs) Handles AccordionControlElement47.Click
        Try
            AddNewForm(New frmReimpresionEtiquetaEmpaque())
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub

    Private Sub AccordionControlElement48_Click(sender As Object, e As EventArgs) Handles AccordionControlElement48.Click
        Try
            AddNewForm(New FrmConsultaInventario())
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub

    Private Sub AccordionControlElement49_Click(sender As Object, e As EventArgs) Handles AccordionControlElement49.Click
        Try
            AddNewForm(New FrmReferencia())
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub

    Private Sub AccordionControlElement50_Click(sender As Object, e As EventArgs) Handles AccordionControlElement50.Click
        Try
            AddNewForm(New FrmLiberaOrdenCompraConsolidacion())
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub

    Private Sub AccordionControlElement51_Click(sender As Object, e As EventArgs) Handles AccordionControlElement51.Click
        Try
            AddNewForm(New FrmReinciarConteo())
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub

    Private Sub AccordionControlElement52_Click(sender As Object, e As EventArgs)
        Try
            AddNewForm(New FrmLiberaOrdenCompra())
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub

    Private Sub AccordionControlElement52_Click_1(sender As Object, e As EventArgs) Handles AccordionControlElement52.Click
        Try
            'affectacionSAP
            XtraMessageBox.Show("Opcion deshabilitada")
            Return
            AddNewForm(New FrmHojaConteoAfectación())
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub

    Private Sub FrmMenuPrincipal_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        FrmLogin.cerrarFormulario = True
    End Sub

    Private Sub AccordionControlElement54_Click(sender As Object, e As EventArgs) Handles AccordionControlElement54.Click
        Try
            AddNewForm(New FrmMonitorOrdenesPro())
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub

    Private Sub AccordionControlElement55_Click(sender As Object, e As EventArgs) Handles AccordionControlElement55.Click
        Try
            AddNewForm(New FrmLiberacionOrdenProduccion())
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub

    Private Sub AccordionControlElement56_Click(sender As Object, e As EventArgs) Handles AccordionControlElement56.Click
        Try
            AddNewForm(New FrmMonitorOrdenesEmbarque())
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub

    Private Sub AccordionControlElement58_Click(sender As Object, e As EventArgs) Handles AccordionControlElement58.Click


        Try
            AddNewForm(New FrmConsultaOrdenP())
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub

    Private Sub AccordionControlElement59_Click(sender As Object, e As EventArgs) Handles AccordionControlElement59.Click

    End Sub

    Private Sub AccordionControlElement57_Click(sender As Object, e As EventArgs) Handles AccordionControlElement57.Click

    End Sub

    Private Sub AccordionControlElement60_Click(sender As Object, e As EventArgs) Handles AccordionControlElement60.Click
        Try
            AddNewForm(New FrmMonitorTraspaso())
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub

    Private Sub AccordionControlElement61_Click(sender As Object, e As EventArgs) Handles AccordionControlElement61.Click

    End Sub

    Private Sub AccordionControlElement62_Click(sender As Object, e As EventArgs) Handles AccordionControlElement62.Click
        Try
            AddNewForm(New FrmConsultaDocTransferencia())
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub

    Private Sub AccordionControlElement63_Click(sender As Object, e As EventArgs) Handles AccordionControlElement63.Click
        Try
            AddNewForm(New FrmTraspasoSalidaPT())
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub

    Private Sub AccordionControlElement65_Click(sender As Object, e As EventArgs) Handles AccordionControlElement65.Click
        Try
            AddNewForm(New FrmMonitorInventarios())
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub

    Private Sub AccordionControlElement66_Click(sender As Object, e As EventArgs) Handles AccordionControlElement66.Click
        Try
            AddNewForm(New FrmResultadoInventario())
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try

    End Sub

    Private Sub AccordionControlElement67_Click(sender As Object, e As EventArgs) Handles AccordionControlElement67.Click
        Try
            AddNewForm(New FrmConsultaInventario())
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try

    End Sub

    Private Sub AccordionControlElement68_Click(sender As Object, e As EventArgs) Handles AccordionControlElement68.Click
        Try
            AddNewForm(New FrmMenuInventarios())
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub

    Private Sub AccordionControlElement69_Click(sender As Object, e As EventArgs) Handles AccordionControlElement69.Click
        Try
            AddNewForm(New FrmCrearOrdenTraspaso())
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub




    Private Sub AccordionControlElement23_Click(sender As Object, e As EventArgs) Handles AccordionControlElement23.Click

    End Sub

    Private Sub AccordionControlElement11_Click(sender As Object, e As EventArgs) Handles AccordionControlElement11.Click

    End Sub



    Private Sub AccordionControlElement71_Click_1(sender As Object, e As EventArgs) Handles AccordionControlElement71.Click
        Try

            AddNewForm(New FrmKpiEmbarqueRes)

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub

    Private Sub AccordionControlElement72_Click_1(sender As Object, e As EventArgs) Handles AccordionControlElement72.Click
        Try

            AddNewForm(New frmKPIsProduccion)

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub

    Private Sub AccordionControlElement73_Click(sender As Object, e As EventArgs)

    End Sub


    Private Sub AccordionControlElement74_Click_1(sender As Object, e As EventArgs) Handles AccordionControlElement74.Click
        Try
            Dim frm = New frmKPIAlmacén
            'AddHandler frm.Shown, AddressOf FormClosingEventhandler1
            'frm.padre = Me
            AddNewForm(frm)

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub

    Private Sub AccordionControlElement73_Click_1(sender As Object, e As EventArgs) Handles AccordionControlElement73.Click
        Try

            Dim frm = New FrmKPIRecepcion
            'AddHandler frm.Shown, AddressOf FormClosingEventhandler2
            'frm.padre = Me
            AddNewForm(frm)
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub





    Private Sub FormClosingEventhandler1()
        'Dim a = XtraTabbedMdiManager1.Pages
        'Dim x
        'If XtraTabbedMdiManager1.page Then
        If Not frmGlobalPrevio Is Nothing Then
            frmGlobalPrevio.Close()
        End If
        frmGlobalPrevio = frmGlobal
    End Sub


    Private Sub FormClosingEventhandler2()
        'Dim a = XtraTabbedMdiManager1.Pages
        'Dim x
        'If XtraTabbedMdiManager1.page Then
        If Not frmGlobalPrevio Is Nothing Then
            frmGlobalPrevio.Close()
        End If
        frmGlobalPrevio = frmGlobal
    End Sub

    Private Sub AccordionControlElement75_Click(sender As Object, e As EventArgs) Handles AccordionControlElement75.Click
        Try
            AddNewForm(New FrmEstatusDiarios)
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub

    Private Sub AccordionControlElement78_Click(sender As Object, e As EventArgs) Handles AccordionControlElement78.Click
        Try
            AddNewForm(New FrmBalanceCargas)
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "AXC")
        End Try
    End Sub
End Class

