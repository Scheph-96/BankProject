Public Class AdminDashboardScreen
    Private adminDashboard As New AdminDashboard

    Private Sub AdminDashboardScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LogoutPic.Image = WallStreetProject.My.Resources.logout
        MenuContainer.Controls.Add(adminDashboard)
    End Sub

    Private Sub LogoutPic_Click(sender As Object, e As EventArgs) Handles LogoutPic.Click
        Dim loginScreen As New LoginScreen()
        Parent.Dispose()
        loginScreen.ShowDialog()
    End Sub
End Class
