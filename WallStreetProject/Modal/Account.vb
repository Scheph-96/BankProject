Public Class Account
    Private _number As Integer
    Private _customer As New Customer()
    Private _solde As Double
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
        _solde = 0.0
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

    Public Function Deposit(amount As Double) As Deposit

        'Addition du montant au solde
        _solde += amount

        'Nouvelle instance de dépôt
        Dim newDeposit As New Deposit(_number, amount)

        'Ajout de l'objet dépôt àla liste des dépôt
        _deposits.Item("Deposits").Add(newDeposit)

        'Retour de l'objet dépôt
        Return newDeposit
    End Function

    Public Function Withdraw(amount As Double)
        If _solde < amount Then
            Dim errorMessage As New Dictionary(Of String, String) From {{"Error", "Solde insuffisant"}}

            Return errorMessage
        Else
            'Soustraction du montant du solde
            _solde -= amount

            'Nouvelle instance de retrait
            Dim newWithdraw As New Withdrawal(_number, amount)

            'Ajout de l'objet retrait à la liste des retraits
            _withdrawals.Item("Withdrawals").Add(newWithdraw)

            'Retour de l'objet retrait
            Return newWithdraw
        End If
    End Function

    Public Function Transfer(amount As Double, target As Integer, banque As Bank)

        If _solde < amount Then
            Dim errorMessage As New Dictionary(Of String, String) From {{"Error", "Solde insuffisant"}}

            Return errorMessage
        Else
            Dim controller As New Controller()
            Dim newObject As Object

            newObject = controller.AccountByNumber(target)
            'Verfication du type de retour de la fonction AccountByNumber qui retourne un compte en fonction
            'du numéro passé en argument
            If newObject.GetType Is GetType(Dictionary(Of String, CheckingAccount)) Then

                ''Instanciation de la classe CheckingAccount
                'Dim targetAccount As New CheckingAccount()

                ''Affectation du compte retourné à l'instance de CheckingAccount
                'targetAccount = newObject.Item("Checking")

                'Montant débiter sur le compte
                _solde -= amount

                'Montant crédité sur le compte cible
                banque = controller.PerformTransfer(target, amount, banque)

                'Initialisation de l'objet transfert
                Dim newTransfer As New Transfer(_number, amount, target)

                'Dictionnaire de transfer et de bank
                Dim transferDict As New Dictionary(Of Transfer, Bank) From {{newTransfer, banque}}

                'Ajout de l'objet transfer à la liste des transferts
                _transfers.Item("Transfers").Add(newTransfer)

                Return transferDict
            ElseIf newObject.GetType Is GetType(Dictionary(Of String, SavingsAccount)) Then

                ''Instanciation de la classe SavingsAccount
                'Dim targetAccount As SavingsAccount

                ''Affectation du compte retourné à l'instance de SavingsAccount
                'targetAccount = newObject.Item("Savings")

                'Montant débiter sur le compte
                _solde -= amount

                'Montant crédité sur le compte cible
                banque = controller.PerformTransfer(target, amount, banque)

                'Initialisation de l'objet transfert
                Dim newTransfer As New Transfer(_number, amount, target)

                'Dictionnaire de transfer et de bank
                Dim transferDict As New Dictionary(Of Transfer, Bank) From {{newTransfer, banque}}

                'Ajout de l'objet transfer à la liste des transferts
                _transfers.Item("Transfers").Add(newTransfer)

                Return transferDict
            ElseIf newObject.GetType Is GetType(Dictionary(Of String, String)) Then
                'Message d'erreur
                Dim errorMsg As New Dictionary(Of String, String)

                'Initialisation du message d'erreur
                errorMsg = newObject

                'Retour du message d'erreur
                Return errorMsg
            End If
        End If

    End Function
End Class
