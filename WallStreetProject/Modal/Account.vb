Public Class Account
    Private _number As Integer
    Private _customer As New Customer()
    Private _solde As Double = 0.0
    Private _type As AccountsType
    Private _deposits As New Dictionary(Of String, List(Of Deposit)) From {{"Deposits", New List(Of Deposit)}}
    Private _withdrawals As New Dictionary(Of String, List(Of Withdrawal)) From {{"Withdrawals", New List(Of Withdrawal)}}
    Private _transfers As New Dictionary(Of String, List(Of Transfer)) From {{"Transfers", New List(Of Transfer)}}
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
        _deposits = account.AccountDeposits
        _withdrawals = account.AccountWithdrawals
        _transfers = account.AccountTranfers
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

    Public Property AccountDeposits() As Dictionary(Of String, List(Of Deposit))
        Get
            AccountDeposits = _deposits
        End Get
        Set(value As Dictionary(Of String, List(Of Deposit)))
            _deposits = value
        End Set
    End Property

    Public Property AccountWithdrawals() As Dictionary(Of String, List(Of Withdrawal))
        Get
            AccountWithdrawals = _withdrawals
        End Get
        Set(value As Dictionary(Of String, List(Of Withdrawal)))
            _withdrawals = value
        End Set
    End Property

    Public Property AccountTranfers() As Dictionary(Of String, List(Of Transfer))
        Get
            AccountTranfers = _transfers
        End Get
        Set(value As Dictionary(Of String, List(Of Transfer)))
            _transfers = value
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

    Public Sub Deposit(amount As Double)
        _solde = amount
        Dim newDeposit As New Deposit(Me, amount)
        _deposits.Item("Deposits").Add(newDeposit)
    End Sub

    Public Sub Withdraw(amount As Double)
        _solde -= amount
        Dim newWithdraw As New Withdrawal(Me, amount)
        _withdrawals.Item("Withdrawals").Add(newWithdraw)
    End Sub

    Public Sub transfer(amount As Double, target As Integer)
        _solde -= amount
        Dim controller As New Controller()
        Dim targetAccount As New Account()

        controller.AccountByNumber(target)
        targetAccount.AccountSolde = targetAccount.AccountSolde + amount
        Dim newTransfer As New Transfer(Me, amount, target)
        _transactions.Add(newTransfer)
    End Sub
End Class
