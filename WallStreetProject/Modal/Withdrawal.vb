Public Class Withdrawal
    Inherits Transaction

    Sub New()
        MyBase.New()
    End Sub

    Public Sub New(owner As Integer, montant As Double)
        MyBase.New(owner, montant, TransactionsType.Withdrawal)
    End Sub
End Class
