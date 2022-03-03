Public Class SplashScreen
    Private controller As New Controller()
    Private userLogin As New LoginScreen

    Private Sub SplashScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SplashScreenImage.Image = WallStreetProject.My.Resources.piggy
        Me.CenterToScreen()
    End Sub

    Private Sub SplashScreen_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Threading.Thread.Sleep(2000)
        MessageBox.Show("You are in the Form.Shown event.")
        'Dim myBanque As New Bank()
        'myBanque = controller.ReadFile()
        'Threading.Thread.Sleep(2000)
        'Me.Dispose()
    End Sub

    Private Sub SplashScreen_Close(sender As Object, e As EventArgs) Handles MyBase.Closed
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub
End Class