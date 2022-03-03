Public Class SetAccountInterestScreen
    Private Sub SetAccountInterestScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BackPic.Image = WallStreetProject.My.Resources.back_ico3
    End Sub

    Private Sub PasswordDisplayer_CheckedChanged(sender As Object, e As EventArgs) Handles PasswordDisplayer.CheckedChanged
        If PasswordDisplayer.Checked Then
            UserPassword.UseSystemPasswordChar = False
        Else
            UserPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub BackPic_Click(sender As Object, e As EventArgs) Handles BackPic.Click
        Dim dashboard As New AdminDashboard
        Parent.Controls.Add(dashboard)
        Me.Dispose()
    End Sub
End Class
