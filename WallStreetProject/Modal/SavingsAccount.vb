Public Class SavingsAccount
    Inherits Account

    Private _interest As Double = 0.1

    Public Sub New()

    End Sub
    Sub New(number As Integer, customer As Customer)
        MyBase.New(number, customer, AccountsType.Savings)
    End Sub

    Sub New(account As Account, interest As Double)
        MyBase.New(account)
        _interest = interest
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
