Public Class SavingsAccount
    Inherits Account

    Private _interest As Double = 0.1


    Sub New(number As Integer, customer As Customer)
        MyBase.New(number, customer, AccountsType.Savings)
    End Sub


    Public Property AccountInterest() As Double
        Get
            AccountInterest = _interest
        End Get
        Set(value As Double)
            _interest = value
        End Set
    End Property
End Class
