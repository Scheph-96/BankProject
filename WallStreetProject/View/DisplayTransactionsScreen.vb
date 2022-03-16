Public Class DisplayTransactionsScreen
    Private Sub DisplayTransactionsScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BackPic.Image = WallStreetProject.My.Resources.back_ico3
        Dim controller As New Controller

        For i As Integer = 0 To controller.Deposits.Count - 1
            DataGridView1.Rows.Add(controller.Deposits(i).TransactionOwner, controller.Deposits(i).TransactionMontant.ToString("N"), controller.Deposits(i).TransactionType.ToString, controller.Deposits(i).TransactionOwner, controller.Deposits(i).TransactionDate)
        Next

        For i As Integer = 0 To controller.Withdrawals.Count - 1
            DataGridView1.Rows.Add(controller.Withdrawals(i).TransactionOwner, controller.Withdrawals(i).TransactionMontant.ToString("N"), controller.Withdrawals(i).TransactionType.ToString, controller.Withdrawals(i).TransactionOwner, controller.Withdrawals(i).TransactionDate)
        Next

        For i As Integer = 0 To controller.Transfers.Count - 1
            DataGridView1.Rows.Add(controller.Transfers(i).TransactionOwner, controller.Transfers(i).TransactionMontant.ToString("N"), controller.Transfers(i).TransactionType.ToString, controller.Transfers(i).TransferTarget, controller.Transfers(i).TransactionDate)
        Next

    End Sub

    Private Sub BackPic_Click(sender As Object, e As EventArgs) Handles BackPic.Click
        Dim dashboard As New AdminDashboard
        Parent.Controls.Add(dashboard)
        Me.Dispose()
    End Sub
End Class
