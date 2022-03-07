Public Class BlockAccountScreen
    Private Sub BlockAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BackPic.Image = WallStreetProject.My.Resources.back_ico3
    End Sub

    Private Sub PasswordDisplayer_CheckedChanged(sender As Object, e As EventArgs) Handles PasswordDisplayer.CheckedChanged
        If PasswordDisplayer.Checked Then
            AdminPassword.UseSystemPasswordChar = False
        Else
            AdminPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub BackPic_Click(sender As Object, e As EventArgs) Handles BackPic.Click
        Dim dashboard As New AdminDashboard
        Parent.Controls.Add(dashboard)
        Me.Dispose()
    End Sub

    Public Sub ConfirmBlock_Click(sender As Object, e As EventArgs) Handles ConfirmBlock.Click
        Dim controller As New Controller
        Dim msg As String
        If AccountNumber.Text = "" Or AdminPassword.Text = "" Then
            MessageBox.Show("Veuillez renseigner tous les champs")
        Else
            msg = controller.blockAccount(AccountNumber.Text, AdminPassword.Text)
            MessageBox.Show(msg)
        End If
    End Sub

End Class
