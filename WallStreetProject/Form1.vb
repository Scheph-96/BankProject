Public Class Form1
    Private userDashborad As New UserDashboardScreen
    Private adminDashboard As New AdminDashboardScreen
    Private _incomeRequest As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Me.Controls.Add(adminDashboard)
        'If _incomeRequest = "admin" Then
        '    Me.Controls.Add(adminDashboard)
        'Else
        '    Me.Controls.Add(userDashborad)
        'End If
    End Sub

    Public Property IncomeRequest() As String
        Get
            IncomeRequest = _incomeRequest
        End Get
        Set(value As String)
            _incomeRequest = value
        End Set
    End Property
End Class
