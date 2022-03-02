Public Class UserDashboard
    Private soldeScreen As New SoldeScreen
    Private withdrawScreen As New WithdrawalScreen
    Private depositScreen As New DepositeScreen
    Private transferScreen As New TransferScreen
    Private Sub UserDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SoldePic.Image = WallStreetProject.My.Resources.solde
        WithdrawalPic.Image = WallStreetProject.My.Resources.withdraw
        DepositPic.Image = WallStreetProject.My.Resources.deposit
        TransferPic.Image = WallStreetProject.My.Resources.transfer
    End Sub

    Private Sub SoldeSection_Paint(sender As Object, e As MouseEventArgs) Handles SoldeSection.Click
        Parent.Controls.Add(soldeScreen)
        Me.Dispose()
    End Sub

    Private Sub DepositSection_Paint(sender As Object, e As MouseEventArgs) Handles DepositSection.Click
        Parent.Controls.Add(depositScreen)
        Me.Dispose()
    End Sub

    Private Sub WithdrawalSection_Paint(sender As Object, e As MouseEventArgs) Handles WithdrawalSection.Click
        Parent.Controls.Add(withdrawScreen)
        Me.Dispose()
    End Sub

    Private Sub TransferSection_Paint(sender As Object, e As MouseEventArgs) Handles TransferSection.Click
        Parent.Controls.Add(transferScreen)
        Me.Dispose()
    End Sub
End Class
