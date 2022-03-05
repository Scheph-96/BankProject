Public Class LoginScreen
    Private _bank As New Bank()
    Private userLoginScreen As New UserLoginScreen()

    Private Sub LoginScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        'UserLoginScreen.Location = New Point(0, 0)
        Debug.WriteLine("In LoginScreen")
        Debug.WriteLine(_bank.BankName)
        Debug.WriteLine(_bank.BankAddress)
        Debug.WriteLine(_bank.BankPhoneNumber)
        userLoginScreen.Bank = _bank
        Me.Controls.Add(UserLoginScreen)
    End Sub

    Public Property Bank() As Bank
        Get
            Bank = _bank
        End Get
        Set(value As Bank)
            _bank = value
        End Set
    End Property

End Class