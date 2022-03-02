Public Class UserDashboardScreen
    Private dashboard As New UserDashboard
    Private Sub UserDashboardScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MenuContainer.Controls.Add(dashboard)
        ' ProfilePicBox.Image = WallStreetProject.My.Resources.profile_pic
        LogoutPic.Image = WallStreetProject.My.Resources.logout
    End Sub
End Class
