Imports System.Diagnostics
Public Class UserLoginScreen
    Private adminLoginScreen As New AdminLoginScreen
    Private Sub PasswordDisplayer_CheckedChanged(sender As Object, e As EventArgs) Handles PasswordDisplayer.CheckedChanged
        If PasswordDisplayer.Checked Then
            PasswordTextBox.UseSystemPasswordChar = False
        Else
            PasswordTextBox.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub AdminLoginLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles AdminLoginLink.LinkClicked
        Parent.Controls.Add(adminLoginScreen)
        Me.Dispose()
    End Sub

    Private Sub UserLoginScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel5.Anchor = AnchorStyles.None
    End Sub
End Class
