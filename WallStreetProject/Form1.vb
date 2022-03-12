Public Class Form1
    Private userDashborad As New UserDashboardScreen
    Private adminDashboard As New AdminDashboardScreen
    Private _incomeRequest As String
    Private _logSavingAccount As New SavingsAccount
    Private _logCheckingAccount As New CheckingAccount

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        Me.MinimizeBox = False
        Me.MaximizeBox = False
        Me.Icon = WallStreetProject.My.Resources.Bank_icon
        'Me.Controls.Add(adminDashboard)
        If _incomeRequest = "admin" Then
            Me.Controls.Add(adminDashboard)
        ElseIf _incomeRequest = "user" Then
            If _logCheckingAccount.AccountCreationDate <> Nothing Then
                userDashborad.CheckingAccount = _logCheckingAccount
                Me.Controls.Add(userDashborad)
            ElseIf _logSavingAccount.AccountCreationDate <> Nothing Then
                userDashborad.SavingAccount = _logSavingAccount
                Me.Controls.Add(userDashborad)
            End If
        End If
    End Sub

    Public Property IncomeRequest() As String
        Get
            IncomeRequest = _incomeRequest
        End Get
        Set(value As String)
            _incomeRequest = value
        End Set
    End Property

    Public Property LogSavingAccount() As SavingsAccount
        Get
            LogSavingAccount = _logSavingAccount
        End Get
        Set(value As SavingsAccount)
            _logSavingAccount = value
        End Set
    End Property

    Public Property LogCheckingAccount() As CheckingAccount
        Get
            LogCheckingAccount = _logCheckingAccount
        End Get
        Set(value As CheckingAccount)
            _logCheckingAccount = value
        End Set
    End Property
End Class
