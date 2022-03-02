Public Class Withdrawal
    Inherits Transaction


    Public Sub New(owner As Account, montant As Double)
        MyBase.New(owner, montant, TransactionsType.Withdrawal)
    End Sub
End Class
