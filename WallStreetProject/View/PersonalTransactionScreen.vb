Public Class PersonalTransactionScreen
    Private _CurrentCheckingAccount As New CheckingAccount
    Private _CurrentSavingAccount As New SavingsAccount

    Private Sub PersonalTransactionScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BackPic.Image = WallStreetProject.My.Resources.back_ico3
        If _CurrentCheckingAccount.AccountCreationDate <> Nothing Then

            For i As Integer = 0 To _CurrentCheckingAccount.AccountDeposits.Item("Deposits").Count - 1
                DataGridView1.Rows.Add(_CurrentCheckingAccount.AccountDeposits.Item("Deposits")(i).TransactionOwner,
                                       _CurrentCheckingAccount.AccountDeposits.Item("Deposits")(i).TransactionMontant.ToString("N"),
                                       _CurrentCheckingAccount.AccountDeposits.Item("Deposits")(i).TransactionType.ToString,
                                       "Néant",
                                       _CurrentCheckingAccount.AccountDeposits.Item("Deposits")(i).TransactionDate)
            Next

            For i As Integer = 0 To _CurrentCheckingAccount.AccountWithdrawals.Item("Withdrawals").Count - 1
                DataGridView1.Rows.Add(_CurrentCheckingAccount.AccountWithdrawals.Item("Withdrawals")(i).TransactionOwner,
                                       _CurrentCheckingAccount.AccountWithdrawals.Item("Withdrawals")(i).TransactionMontant.ToString("N"),
                                       _CurrentCheckingAccount.AccountWithdrawals.Item("Withdrawals")(i).TransactionType.ToString,
                                       "Néant",
                                       _CurrentCheckingAccount.AccountWithdrawals.Item("Withdrawals")(i).TransactionDate)
            Next

            For i As Integer = 0 To _CurrentCheckingAccount.AccountTranfers.Item("Transfers").Count - 1
                DataGridView1.Rows.Add(_CurrentCheckingAccount.AccountTranfers.Item("Transfers")(i).TransactionOwner,
                                       _CurrentCheckingAccount.AccountTranfers.Item("Transfers")(i).TransactionMontant.ToString("N"),
                                       _CurrentCheckingAccount.AccountTranfers.Item("Transfers")(i).TransactionType.ToString,
                                       _CurrentCheckingAccount.AccountTranfers.Item("Transfers")(i).TransferTarget,
                                       _CurrentCheckingAccount.AccountTranfers.Item("Transfers")(i).TransactionDate)
            Next

        ElseIf _CurrentSavingAccount.AccountCreationDate <> Nothing Then

            For i As Integer = 0 To _CurrentSavingAccount.AccountDeposits.Item("Deposits").Count - 1
                DataGridView1.Rows.Add(_CurrentSavingAccount.AccountDeposits.Item("Deposits")(i).TransactionOwner,
                                       _CurrentSavingAccount.AccountDeposits.Item("Deposits")(i).TransactionMontant.ToString("N"),
                                       _CurrentSavingAccount.AccountDeposits.Item("Deposits")(i).TransactionType.ToString,
                                       "Néant",
                                       _CurrentSavingAccount.AccountDeposits.Item("Deposits")(i).TransactionDate)
            Next

            For i As Integer = 0 To _CurrentSavingAccount.AccountWithdrawals.Item("Withdrawals").Count - 1
                DataGridView1.Rows.Add(_CurrentSavingAccount.AccountWithdrawals.Item("Withdrawals")(i).TransactionOwner,
                                       _CurrentSavingAccount.AccountWithdrawals.Item("Withdrawals")(i).TransactionMontant.ToString("N"),
                                       _CurrentSavingAccount.AccountWithdrawals.Item("Withdrawals")(i).TransactionType.ToString,
                                       "Néant",
                                       _CurrentSavingAccount.AccountWithdrawals.Item("Withdrawals")(i).TransactionDate)
            Next

            For i As Integer = 0 To _CurrentSavingAccount.AccountTranfers.Item("Transfers").Count - 1
                DataGridView1.Rows.Add(_CurrentSavingAccount.AccountTranfers.Item("Transfers")(i).TransactionOwner,
                                       _CurrentSavingAccount.AccountTranfers.Item("Transfers")(i).TransactionMontant.ToString("N"),
                                       _CurrentSavingAccount.AccountTranfers.Item("Transfers")(i).TransactionType.ToString,
                                       _CurrentSavingAccount.AccountTranfers.Item("Transfers")(i).TransferTarget,
                                       _CurrentSavingAccount.AccountTranfers.Item("Transfers")(i).TransactionDate)
            Next

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
