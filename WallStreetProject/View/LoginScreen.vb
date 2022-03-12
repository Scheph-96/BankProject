Public Class LoginScreen
    Private _bank As New Bank()
    Private userLoginScreen As New UserLoginScreen()

    Private Sub LoginScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        'UserLoginScreen.Location = New Point(0, 0)
        'Debug.WriteLine("In LoginScreen")
        'Debug.WriteLine(_bank.BankName)
        'Debug.WriteLine(_bank.BankAddress)
        'Debug.WriteLine(_bank.BankPhoneNumber)
        userLoginScreen.Bank = _bank
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        Me.MinimizeBox = False
        Me.MaximizeBox = False
        Me.Icon = WallStreetProject.My.Resources.Bank_icon
        Me.Controls.Add(userLoginScreen)
    End Sub

    'Private Function LoadIconFromFile(ByVal fileName As String) As Icon
    '    Return New Icon(fileName, New Size(48, 48))
    'End Function

    Public Property Bank() As Bank
        Get
            Bank = _bank
        End Get
        Set(value As Bank)
            _bank = value
        End Set
    End Property

End Class