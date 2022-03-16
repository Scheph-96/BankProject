Public Class Transaction
    Private _owner As Integer
    Private _montant As Double
    Private _type As TransactionsType
    Private _dateCreation As String


    Sub New()
        _dateCreation = DateTime.Now
    End Sub

    Sub New(owner As Integer, montant As Double, type As TransactionsType)
        _owner = owner
        _montant = montant
        _type = type
        _dateCreation = DateTime.Now
    End Sub


    Public Property TransactionMontant() As Double
        Get
            TransactionMontant = _montant
        End Get
        Set(value As Double)
            _montant = value
        End Set
    End Property

    Public Property TransactionDate() As String
        Get
            TransactionDate = _dateCreation
        End Get
        Set(value As String)
            _dateCreation = value
        End Set
    End Property

    Public Property TransactionOwner() As Integer
        Get
            TransactionOwner = _owner
        End Get
        Set(value As Integer)
            _owner = value
        End Set
    End Property

    Public Property TransactionType() As TransactionsType
        Get
            TransactionType = _type
        End Get
        Set(value As TransactionsType)
            _type = value
        End Set
    End Property
End Class
