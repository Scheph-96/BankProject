Public Class Bank
    Private _name As String
    Private _address As String
    Private _phoneNumber As String
    Private _checkingAccounts As New Dictionary(Of String, List(Of CheckingAccount)) From {{"Checking", New List(Of CheckingAccount)}}
    Private _savingAccounts As New Dictionary(Of String, List(Of SavingsAccount)) From {{"Savings", New List(Of SavingsAccount)}}
    Private _transactions As New List(Of Transaction)()
    Private _admin As New Administrator("Scheph", "YWRtaW5QYXNzV29yZA==") ' Password as adminPassWord


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

    Public Property BankCheckingAccounts As Dictionary(Of String, List(Of CheckingAccount))
        Get
            BankCheckingAccounts = _checkingAccounts
        End Get
        Set(value As Dictionary(Of String, List(Of CheckingAccount)))
            _checkingAccounts = value
        End Set
    End Property

    Public Property BankSavingAccounts As Dictionary(Of String, List(Of SavingsAccount))
        Get
            BankSavingAccounts = _savingAccounts
        End Get
        Set(value As Dictionary(Of String, List(Of SavingsAccount)))
            _savingAccounts = value
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
