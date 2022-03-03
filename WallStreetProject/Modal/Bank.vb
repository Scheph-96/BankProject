Public Class Bank
    Private _name As String
    Private _address As String
    Private _phoneNumber As String
    Private _accounts As New List(Of Account)()
    Private _transactions As New List(Of Transaction)()
    Private _admin As New Administrator("Scheph", "adminPassWord")


    Public Sub New()
    End Sub

    Public Sub New(theName As String, theAddress As String, thePhoneNumber As String)
        _name = theName
        _address = theAddress
        _phoneNumber = thePhoneNumber
    End Sub


    Public Property BankName() As String
        Get
            BankName = _name
        End Get
        Set(value As String)
            _name = value
        End Set
    End Property

    Public Property BankAddress() As String
        Get
            BankAddress = _address
        End Get
        Set(value As String)
            _address = value
        End Set
    End Property

    Public Property BankPhoneNumber() As String
        Get
            BankPhoneNumber = _phoneNumber
        End Get
        Set(value As String)
            _phoneNumber = value
        End Set
    End Property

    Public Property BankAccounts As List(Of Account)
        Get
            BankAccounts = _accounts
        End Get
        Set(value As List(Of Account))
            _accounts = value
        End Set
    End Property

    Public Property BankTransactions() As List(Of Transaction)
        Get
            BankTransactions = _transactions
        End Get
        Set(value As List(Of Transaction))
            _transactions = value
        End Set
    End Property

    Public Property Admin() As Administrator
        Get
            Admin = _admin
        End Get
        Set(value As Administrator)
            _admin = value
        End Set
    End Property
End Class
