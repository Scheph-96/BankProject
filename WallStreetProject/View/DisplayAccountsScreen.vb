Public Class DisplayAccountsScreen
    Private Sub DisplayAccountsScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim controller As New Controller()
        Dim SavingAccounts As New List(Of SavingsAccount)
        Dim CheckingAccounts As New List(Of CheckingAccount)
        SavingAccounts = controller.SavingAccounts
        CheckingAccounts = controller.CheckingAccounts
        BackPic.Image = WallStreetProject.My.Resources.back_ico3

        For i As Integer = 0 To SavingAccounts.Count - 1
            DataGridView1.Rows.Add(SavingAccounts(i).AccountNumber, SavingAccounts(i).AccountOwner.CustomerLastName, SavingAccounts(i).AccountOwner.CustomerFirstName, SavingAccounts(i).AccountType.ToString, SavingAccounts(i).AccountInterest, SavingAccounts(i).AccountSolde, SavingAccounts(i).AccountCreationDate, SavingAccounts(i).AccountStatus.ToString)
        Next

        For i As Integer = 0 To CheckingAccounts.Count - 1
            DataGridView1.Rows.Add(CheckingAccounts(i).AccountNumber, CheckingAccounts(i).AccountOwner.CustomerLastName, CheckingAccounts(i).AccountOwner.CustomerFirstName, CheckingAccounts(i).AccountType.ToString, "Néant", CheckingAccounts(i).AccountSolde, CheckingAccounts(i).AccountCreationDate, CheckingAccounts(i).AccountStatus.ToString)
        Next
    End Sub

    Private Sub BackPic_Click(sender As Object, e As EventArgs) Handles BackPic.Click
        Dim dashboard As New AdminDashboard
        Parent.Controls.Add(dashboard)
        Me.Dispose()
    End Sub
End Class
