Imports AioiSystems.Lightstep
Public Class FrmPTLConecction
    Private WithEvents _controller As New EthernetController
    Public Sub Conectar()
        '_controller.Connect("192.168.1.80", 5003)
        _controller.SynchronizingObject = Me
        _controller.SendCommand("PP5050000m133#100801003")
    End Sub
    Private Sub _controller_CommandReceived(ByVal sender As System.Object,
 ByVal e As System.EventArgs) Handles _controller.CommandReceived

        Dim command As CommandInfo = _controller.GetCommand()
        If Not command Is Nothing Then
            Console.WriteLine(command.GetCommandText())
        End If
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Conectar()
    End Sub
End Class