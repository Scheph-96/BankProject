Public Class UserLoginScreen
    Private _bank As New Bank()
    Private adminLoginScreen As New AdminLoginScreen
    Private userDashBoard As New UserDashboardScreen
    Private errorMessage As String
    Private form As New Form1()

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
        Dim controller As New Controller()
        Dim loginStatus As New Dictionary(Of Boolean, String)
        If UsernameTextBox.Text = "" Or PasswordTextBox.Text = "" Then
            MessageBox.Show("Veuillez remplir tous les champs!")
        Else
            loginStatus = controller.CustomerLogin(UsernameTextBox.Text, PasswordTextBox.Text)
            If loginStatus.ContainsKey(True) Then
                Parent.Dispose()
                form.IncomeRequest = "user"
                If controller.LoggedCheckingAccount.AccountCreationDate <> Nothing Then
                    form.LogCheckingAccount = controller.LoggedCheckingAccount
                    form.ShowDialog()
                ElseIf controller.LoggedSavingAccount.AccountCreationDate <> Nothing Then
                    form.LogSavingAccount = controller.LoggedSavingAccount
                    form.ShowDialog()
                End If

            ElseIf loginStatus.ContainsKey(False) Then
                    MessageBox.Show(loginStatus.Values(0))
            End If
        End If
    End Sub
End Class
