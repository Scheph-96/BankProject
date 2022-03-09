Public Class AdminDashboard
    Private createAccountScreen As New CreateAccountScreen
    Private displayAccountsScreen As New DisplayAccountsScreen
    Private deleteAccountScreen As New DeleteAccountScreen
    Private interestScreen As New SetAccountInterestScreen
    Private blockAccountScreen As New BlockAccountScreen
    Private activeAccountScreen As New ActiveAccountScreen
    Private displayTransactionsScreen As New DisplayTransactionsScreen

    Private Sub AdminDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CreateAccountPic.Image = WallStreetProject.My.Resources.AddUserIcon
        DisplayAccountsPic.Image = WallStreetProject.My.Resources.ListIcon
        DeleteAccountPic.Image = WallStreetProject.My.Resources.DeleteUserIcon
        InterestPic.Image = WallStreetProject.My.Resources.InterestIcon
        BlockAccountPic.Image = WallStreetProject.My.Resources.BlockUserIcon
        ActiveAccountPic.Image = WallStreetProject.My.Resources.ActiveAccountPic
        DisplayTransactionsPic.Image = WallStreetProject.My.Resources.TransactionIcon
    End Sub

    Private Sub CreateAccountSection_Paint(sender As Object, e As MouseEventArgs) Handles CreateAccountSection.Click
        Parent.Controls.Add(createAccountScreen)
        Me.Dispose()
    End Sub

    Private Sub DisplayAccountsSection_Paint(sender As Object, e As MouseEventArgs) Handles DisplayAccountsSection.Click
        Parent.Controls.Add(displayAccountsScreen)
        Me.Dispose()
    End Sub

    Private Sub DeleteAccountSection_Paint(sender As Object, e As MouseEventArgs) Handles DeleteAccountSection.Click
        Parent.Controls.Add(deleteAccountScreen)
        Me.Dispose()
    End Sub

    Private Sub InterestSection_Paint(sender As Object, e As MouseEventArgs) Handles InterestSection.Click
        Parent.Controls.Add(interestScreen)
        Me.Dispose()
    End Sub

    Private Sub BlockAccountSection_Paint(sender As Object, e As MouseEventArgs) Handles BlockAccountSection.Click
        Parent.Controls.Add(blockAccountScreen)
        Me.Dispose()
    End Sub

    Private Sub DisplayTransactionSection_Paint(sender As Object, e As MouseEventArgs) Handles DisplayTransactionSection.Click
        Parent.Controls.Add(displayTransactionsScreen)
        Me.Dispose()
    End Sub

    Private Sub ActiveAccountSection_Paint(sender As Object, e As MouseEventArgs) Handles ActiveAccountSection.Click
        Parent.Controls.Add(activeAccountScreen)
        Me.Dispose()
    End Sub
End Class
