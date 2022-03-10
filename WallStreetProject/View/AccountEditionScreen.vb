Public Class AccountEditionScreen
    Private Sub AccountEditionScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BackPic.Image = WallStreetProject.My.Resources.back_ico3
    End Sub

    Private Sub BackPic_Click(sender As Object, e As EventArgs) Handles BackPic.Click
        Dim dashboard As New UserDashboard
        Parent.Controls.Add(dashboard)
        Me.Dispose()
    End Sub

    Private Sub UserPasswordDisplayer_CheckedChanged(sender As Object, e As EventArgs) Handles UserPasswordDisplayer.CheckedChanged
        If UserPasswordDisplayer.Checked Then
            UserPassword.UseSystemPasswordChar = False
        Else
            UserPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub OldPasswordDisplayer_CheckedChanged(sender As Object, e As EventArgs) Handles OldPasswordDisplayer.CheckedChanged
        If OldPasswordDisplayer.Checked Then
            OldPassword.UseSystemPasswordChar = False
        Else
            OldPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub NewPasswordDisplayer_CheckedChanged(sender As Object, e As EventArgs) Handles NewPasswordDisplayer.CheckedChanged
        If NewPasswordDisplayer.Checked Then
            NewPassword.UseSystemPasswordChar = False
        Else
            NewPassword.UseSystemPasswordChar = True
        End If
    End Sub
End Class
