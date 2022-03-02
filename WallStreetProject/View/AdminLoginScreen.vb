Public Class AdminLoginScreen
    'Private userLoginScreen As New UserLoginScreen
    Private Sub AdminPasswordDisplayer_CheckedChanged(sender As Object, e As EventArgs) Handles AdminPasswordDisplayer.CheckedChanged
        If AdminPasswordDisplayer.Checked Then
            AdminPasswordTextBox.UseSystemPasswordChar = False
        Else
            AdminPasswordTextBox.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub UserLoginLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles UserLoginLink.LinkClicked
        Dim userLoginScreen As New UserLoginScreen
        Parent.Controls.Add(userLoginScreen)
        Me.Dispose()
    End Sub

    Private Sub AdminLoginScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs) Handles Panel5.Paint

    End Sub
End Class
