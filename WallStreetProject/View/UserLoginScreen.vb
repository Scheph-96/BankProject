Imports System.Diagnostics
Public Class UserLoginScreen
    Private _bank As New Bank()
    Private adminLoginScreen As New AdminLoginScreen
    Private controller As New Controller()
    Private userDashBoard As New UserDashboardScreen
    Private errorMessage As String

    Private Sub UserLoginScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UsernameErrorMessage.Visible = False
        PasswordErrorMessage.Visible = False
    End Sub

    Public Property Bank() As Bank
        Get
            Bank = _bank
        End Get
        Set(value As Bank)
            _bank = value
        End Set
    End Property

    Private Sub PasswordDisplayer_CheckedChanged(sender As Object, e As EventArgs) Handles PasswordDisplayer.CheckedChanged
        If PasswordDisplayer.Checked Then
            PasswordTextBox.UseSystemPasswordChar = False
        Else
            PasswordTextBox.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub AdminLoginLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles AdminLoginLink.LinkClicked
        adminLoginScreen.Bank = _bank
        Parent.Controls.Add(adminLoginScreen)
        Me.Dispose()
    End Sub

    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click

        If UsernameTextBox.Text = "" And PasswordTextBox.Text = "" Then
            MessageBox.Show("Vous devez remplir tous les champs!")
        ElseIf UsernameTextBox.Text = "" Or PasswordTextBox.Text = "" Then
            MessageBox.Show("Vous devez remplir tous les champs!")
        Else
            'errorMessage = controller.CustomerLogin(UsernameTextBox.Text, PasswordTextBox.Text, userDashBoard, Me)
            If errorMessage IsNot "" Then

            End If
        End If
    End Sub
End Class
