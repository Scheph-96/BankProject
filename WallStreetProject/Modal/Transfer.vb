Public Class Transfer
    Inherits Transaction

    Private _target As Account


    Public Sub New(owner As Account, montant As Double, target As Account)
        MyBase.New(owner, montant, TransactionsType.Transfer)
        _target = target
    End Sub


    Public Property TransferTarget() As Account
        Get
            TransferTarget = _target
        End Get
        Set(value As Account)
            _target = value
        End Set
    End Property
End Class
