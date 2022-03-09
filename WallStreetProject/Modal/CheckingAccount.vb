Public Class CheckingAccount
    Inherits Account

    Sub New()

    End Sub
    Sub New(number As Integer, customer As Customer)
        MyBase.New(number, customer, AccountsType.Checking)
    End Sub
End Class
