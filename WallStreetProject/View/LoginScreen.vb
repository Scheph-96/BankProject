Public Class LoginScreen
    Private userLoginScreen As New UserLoginScreen
    Private Sub LoginScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        userLoginScreen.Location = New Point(0, 0)
        Me.Controls.Add(userLoginScreen)
    End Sub
End Class