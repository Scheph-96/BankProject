Public Class Deposit
    Inherits Transaction


    Public Sub New(owner As Account, montant As Double)
        MyBase.New(owner, montant, TransactionsType.Deposit)
    End Sub
End Class
