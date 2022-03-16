Public Class UserDashboard
    Private _CurrentCheckingAccount As New CheckingAccount
    Private _CurrentSavingAccount As New SavingsAccount

    Private Sub UserDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SoldePic.Image = WallStreetProject.My.Resources.solde
        WithdrawalPic.Image = WallStreetProject.My.Resources.withdraw
        DepositPic.Image = WallStreetProject.My.Resources.deposit
        TransferPic.Image = WallStreetProject.My.Resources.transfer
        TransactionsPic.Image = WallStreetProject.My.Resources.TransactionIcon
        EditPic.Image = WallStreetProject.My.Resources.stylo_write
    End Sub

    Private Sub SoldeSection_Paint(sender As Object, e As MouseEventArgs) Handles SoldeSection.Click
        Dim soldeScreen As New SoldeScreen
        If _CurrentCheckingAccount.AccountCreationDate <> Nothing Then
            soldeScreen.CurrentCheckingAccount = _CurrentCheckingAccount
            Parent.Controls.Add(soldeScreen)
            Me.Dispose()
        ElseIf _CurrentSavingAccount.AccountCreationDate <> Nothing Then
            soldeScreen.CurrentSavingAccount = _CurrentSavingAccount
            Parent.Controls.Add(soldeScreen)
            Me.Dispose()
        End If
    End Sub

    Private Sub DepositSection_Paint(sender As Object, e As MouseEventArgs) Handles DepositSection.Click
        Dim depositScreen As New DepositeScreen
        If _CurrentCheckingAccount.AccountCreationDate <> Nothing Then
            depositScreen.CurrentCheckingAccount = _CurrentCheckingAccount
            Parent.Controls.Add(depositScreen)
            Me.Dispose()
        ElseIf _CurrentSavingAccount.AccountCreationDate <> Nothing Then
            depositScreen.CurrentSavingAccount = _CurrentSavingAccount
            Parent.Controls.Add(depositScreen)
            Me.Dispose()
        End If
    End Sub

    Private Sub WithdrawalSection_Paint(sender As Object, e As MouseEventArgs) Handles WithdrawalSection.Click
        Dim withdrawScreen As New WithdrawalScreen
        If _CurrentCheckingAccount.AccountCreationDate <> Nothing Then
            withdrawScreen.CurrentCheckingAccount = _CurrentCheckingAccount
            Parent.Controls.Add(withdrawScreen)
            Me.Dispose()
        ElseIf _CurrentSavingAccount.AccountCreationDate <> Nothing Then
            withdrawScreen.CurrentSavingAccount = _CurrentSavingAccount
            Parent.Controls.Add(withdrawScreen)
            Me.Dispose()
        End If
    End Sub

    Private Sub TransferSection_Paint(sender As Object, e As MouseEventArgs) Handles TransferSection.Click
        Dim transferScreen As New TransferScreen
        If _CurrentCheckingAccount.AccountCreationDate <> Nothing Then
            transferScreen.CurrentCheckingAccount = _CurrentCheckingAccount
            Parent.Controls.Add(transferScreen)
            Me.Dispose()
        ElseIf _CurrentSavingAccount.AccountCreationDate <> Nothing Then
            transferScreen.CurrentSavingAccount = _CurrentSavingAccount
            Parent.Controls.Add(transferScreen)
            Me.Dispose()
        End If
    End Sub

    Private Sub TransactionSection_Paint(sender As Object, e As MouseEventArgs) Handles TransactionSection.Click
        Dim transactionScreen As New PersonalTransactionScreen
        If _CurrentCheckingAccount.AccountCreationDate <> Nothing Then
            transactionScreen.CurrentCheckingAccount = _CurrentCheckingAccount
            Parent.Controls.Add(transactionScreen)
            Me.Dispose()
        ElseIf _CurrentSavingAccount.AccountCreationDate <> Nothing Then
            transactionScreen.CurrentSavingAccount = _CurrentSavingAccount
            Parent.Controls.Add(transactionScreen)
            Me.Dispose()
        End If
    End Sub

    Private Sub EditionSection_Paint(sender As Object, e As MouseEventArgs) Handles EditionSection.Click
        Dim editionScreen As New AccountEditionScreen
        If _CurrentCheckingAccount.AccountCreationDate <> Nothing Then
            editionScreen.CurrentCheckingAccount = _CurrentCheckingAccount
            Parent.Controls.Add(editionScreen)
            Me.Dispose()
        ElseIf _CurrentSavingAccount.AccountCreationDate <> Nothing Then
            editionScreen.CurrentSavingAccount = _CurrentSavingAccount
            Parent.Controls.Add(editionScreen)
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
