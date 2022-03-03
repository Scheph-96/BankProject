Public Class CreateAccountScreen
    Private Sub CreateAccountScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BackPic.Image = WallStreetProject.My.Resources.back_ico3
    End Sub

    Private Sub BackPic_Click(sender As Object, e As EventArgs) Handles BackPic.Click
        Dim dashboard As New AdminDashboard
        Parent.Controls.Add(dashboard)
        Me.Dispose()
    End Sub
End Class
