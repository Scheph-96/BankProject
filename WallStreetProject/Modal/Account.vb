Public Class Account
    Private _number As Integer
    Private _customer As New Customer()
    Private _solde As Double = 0.0
    Private _type As AccountsType
    Private _transactions As New List(Of Transaction)()
    Private _dateCreation As String
    Private _status As AccountStatus


    Public Sub New()

    End Sub

    Public Sub New(number As Integer, customer As Customer, type As AccountsType)
        _number = number
        _customer = customer
        _type = type
        _dateCreation = DateTime.Now
        _status = AccountStatus.active
    End Sub

    Public Sub New(account As Account)
        _number = account.AccountNumber
        _customer = account.AccountOwner
        _solde = account.AccountSolde
        _type = account.AccountType
        _transactions = account.AccountTransactions
        _dateCreation = account.AccountCreationDate
        _status = account.AccountStatus
    End Sub


    Public Property AccountNumber() As Integer
        Get
            AccountNumber = _number
        End Get
        Set(value As Integer)
            If _number = Nothing Then
                _number = value
            End If
        End Set
    End Property

    Public Property AccountOwner() As Customer
        Get
            AccountOwner = _customer
        End Get
        Set(value As Customer)
            _customer = value
        End Set
    End Property

    Public Property AccountSolde() As Double
        Get
            AccountSolde = _solde
        End Get
        Set(value As Double)
            _solde = value
        End Set
    End Property

    Public Property AccountType() As AccountsType
        Get
            AccountType = _type
        End Get
        Set(value As AccountsType)
            _type = value
        End Set
    End Property

    Public Property AccountTransactions() As List(Of Transaction)
        Get
            AccountTransactions = _transactions
        End Get
        Set(value As List(Of Transaction))
            _transactions = value
        End Set
    End Property

    Public Property AccountCreationDate() As String
        Get
            AccountCreationDate = _dateCreation
        End Get
        Set(value As String)
            _dateCreation = value
        End Set
    End Property

    Public Property AccountStatus() As AccountStatus
        Get
            AccountStatus = _status
        End Get
        Set(value As AccountStatus)
            _status = value
        End Set
    End Property

    Public Sub deposit(amount As Double)
        Me.AccountSolde = amount
        Dim newDeposit As New Deposit(Me, amount)
        _transactions.Add(newDeposit)
        'Return newDeposit
        'banque.BankTransactions.Add(newDeposit)
        'WriteInFile(banque)
    End Sub

    Public Sub withdraw(amount As Double)
        Me.AccountSolde = amount
        Dim newWithdraw As New Withdrawal(Me, amount)
        _transactions.Add(newWithdraw)
    End Sub

    Public Sub transfer(amount As Double, target As Integer)
        Me.AccountSolde = Me.AccountSolde - amount
        Dim controller As New Controller()
        Dim targetAccount As New Account()

        controller.AccountByNumber(target)
        targetAccount.AccountSolde = targetAccount.AccountSolde + amount
        Dim newTransfer As New Transfer(Me, amount, target)
        _transactions.Add(newTransfer)
    End Sub
End Class
