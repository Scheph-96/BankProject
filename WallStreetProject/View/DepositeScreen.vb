Public Class DepositeScreen
    Private _CurrentCheckingAccount As New CheckingAccount
    Private _CurrentSavingAccount As New SavingsAccount

    Private Sub DepositeScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        Dim dashboard As New UserDashboard
        'Si le compte connecté est un compte courant alors initialiser l'attribut compte courant
        'de la nouvelle instance de dashboard avant d'y retourner
        If _CurrentCheckingAccount.AccountCreationDate <> Nothing Then
            dashboard.CurrentCheckingAccount = _CurrentCheckingAccount
            Parent.Controls.Add(dashboard)
            Me.Dispose()
            'Si le compte connecté est un compte épargne alors initialiser l'attribut compte épargne
            'de la nouvelle instance de dashboard avant d'y retourner 
        ElseIf _CurrentSavingAccount.AccountCreationDate <> Nothing Then
            dashboard.CurrentSavingAccount = _CurrentSavingAccount
            Parent.Controls.Add(dashboard)
            Me.Dispose()
        End If
    End Sub

    Private Sub ConfirmDeposite_Click(sender As Object, e As EventArgs) Handles ConfirmDeposite.Click
        'Creation des instances
        Dim controller As New Controller
        Dim depositeStatus As Dictionary(Of String, String)

        'Verification des entrées utilisateur et exiger le remplissage de tous les champs
        If DepositAmount.Text = "" Or UserPassword.Text = "" Then
            MessageBox.Show("Veuillez remplir tous les champs!")
        Else

            'Vérification du type de compte connecté
            If _CurrentCheckingAccount.AccountCreationDate <> Nothing Then

                'Réaliation du dépôt
                depositeStatus = controller.Transaction(_CurrentCheckingAccount.AccountNumber, TransactionsType.Deposit, DepositAmount.Text, UserPassword.Text)

                'Verification du type de retour de la fonction Transaction
                If depositeStatus.ContainsKey("Done") Then
                    _CurrentCheckingAccount.AccountSolde += DepositAmount.Text
                    MessageBox.Show("Dépôt effectué avec succès")
                ElseIf depositeStatus.ContainsKey("ErrorPassword") Then
                    MessageBox.Show(depositeStatus.Item("ErrorPassword"))
                End If

            ElseIf _CurrentSavingAccount.AccountCreationDate <> Nothing Then

                'Réaliation du dépôt
                depositeStatus = controller.Transaction(_CurrentSavingAccount.AccountNumber, TransactionsType.Deposit, DepositAmount.Text, UserPassword.Text)

                'Verification du type de retour de la fonction Transaction
                If depositeStatus.ContainsKey("Done") Then
                    _CurrentSavingAccount.AccountSolde += DepositAmount.Text
                    MessageBox.Show("Dépôt effectué avec succès")
                ElseIf depositeStatus.ContainsKey("ErrorPassword") Then
                    MessageBox.Show(depositeStatus.Item("ErrorPassword"))
                End If
            End If
        End If

    End Sub


    Public Property CurrentCheckingAccount() As CheckingAccount
        Get
            CurrentCheckingAccount = _CurrentCheckingAccount
        End Get
        Set(value As CheckingAccount)
            _CurrentCheckingAccount = value
        End Set
    End Property

    Public Property CurrentSavingAccount() As SavingsAccount
        Get
            CurrentSavingAccount = _CurrentSavingAccount
        End Get
        Set(value As SavingsAccount)
            _CurrentSavingAccount = value
        End Set
    End Property
End Class
