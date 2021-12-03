Public Class SplashScreen
    Private Sub SplashScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i = 0 To 100
            ProgressBar1.Value = i

        Next

    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Timer1.Stop()
        frmTelaInicial.Show()

        Me.Hide()
    End Sub


    Dim newpoint As New System.Drawing.Point
    Dim mouseX, mouseY As Integer

    Private Sub Header_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseDown
        mouseX = Control.MousePosition.X - Me.Location.X
        mouseY = Control.MousePosition.Y - Me.Location.Y
    End Sub

    Private Sub Header_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove
        If e.Button = MouseButtons.Left Then
            newpoint = Control.MousePosition
            newpoint.X -= mouseX
            newpoint.Y -= mouseY
            Me.Location = newpoint
        End If
    End Sub

End Class