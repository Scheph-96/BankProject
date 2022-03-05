Public Class CreateAccountScreen
    Private Sub CreateAccountScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BackPic.Image = WallStreetProject.My.Resources.back_ico3
    End Sub

    Private Sub BackPic_Click(sender As Object, e As EventArgs) Handles BackPic.Click
        Dim dashboard As New AdminDashboard
        Parent.Controls.Add(dashboard)
        Me.Dispose()
    End Sub

    Private Sub ConfirmAccountCreation_Click(sender As Object, e As EventArgs) Handles ConfirmAccountCreation.Click
        If CustomerLastName.Text = "" And CustomerFirstName.Text = "" And CustomerPhoneNumber.Text = "" And Not CheckingAccountRadioBtn.Checked And Not SavingAccountRadioBtn.Checked Then
            MessageBox.Show("Veuillez renseigner tous les champs")
        Else
        End If
    End Sub
End Class
