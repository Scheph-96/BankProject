Public Class Form1
    Private userDashborad As New UserDashboardScreen
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Me.Controls.Add(userDashborad)
    End Sub
End Class
