Public Class AdminLoginScreen
    Private _bank As New Bank()
    'Private userLoginScreen As New UserLoginScreen
    Private controller As New Controller()
    Private isVerified As Boolean = True
    Private form As New Form1()

    Private Sub AdminLoginScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoginErrorMessage.Visible = False
    End Sub

    Public Property Bank() As Bank
        Get
            Bank = _bank
        End Get
        Set(value As Bank)
            _bank = value
        End Set
    End Property

    Private Sub AdminPasswordDisplayer_CheckedChanged(sender As Object, e As EventArgs) Handles AdminPasswordDisplayer.CheckedChanged
        If AdminPasswordDisplayer.Checked Then
            AdminPasswordTextBox.UseSystemPasswordChar = False
        Else
            AdminPasswordTextBox.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub UserLoginLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles UserLoginLink.LinkClicked
        Dim userLoginScreen As New UserLoginScreen()
        userLoginScreen.Bank = _bank
        Parent.Controls.Add(userLoginScreen)
        Me.Dispose()
    End Sub

    Private Sub AdminLoginButton_Click(sender As Object, e As EventArgs) Handles AdminLoginButton.Click
        If AdminNameTextBox.Text = "" And AdminPasswordTextBox.Text = "" Then
            MessageBox.Show("Veuillez remplir tous les champs")
        ElseIf AdminNameTextBox.Text = "" Or AdminPasswordTextBox.Text = "" Then
            If AdminNameTextBox.Text = "" Then
                MessageBox.Show("Veuillez renseigner le nom de l'administrateur")
            Else
                MessageBox.Show("Veuillez renseigner le mot de passe de l'administrateur")
            End If
        Else
            isVerified = controller.AdminLogin(AdminNameTextBox.Text, AdminPasswordTextBox.Text)
            If isVerified Then
                Parent.Dispose()
                form.IncomeRequest = "admin"
                form.ShowDialog()
            Else
                LoginErrorMessage.Visible = True
                LoginErrorMessage.Text = "Identifiants incorrecte"
            End If
        End If
    End Sub
End Class
