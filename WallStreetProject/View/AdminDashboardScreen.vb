Public Class AdminDashboardScreen
    Private adminDashboard As New AdminDashboard
    Private Sub AdminDashboardScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LogoutPic.Image = WallStreetProject.My.Resources.logout
        MenuContainer.Controls.Add(adminDashboard)
    End Sub
End Class
