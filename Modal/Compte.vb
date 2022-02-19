Public Class Compte

    Private number As Integer
    Private ownerName As String
    Private password As String
    Private solde As Integer
    Private type As String = "Courant"

    Public Sub New(theNumber As Integer, theOwnerName As String, thePassword As String, theSolde As Integer)
        number = theNumber
        ownerName = theOwnerName
        password = thePassword
        solde = theSolde
    End Sub

    Public Property thisNumber As Integer
        Get
            Return number
        End Get
        Set(newNumber As Integer)

        End Set
    End Property

    Public Property thisOwnerName As String
        Get
            Return ownerName
        End Get
        Set(value As String)

        End Set
    End Property

    Public Property thisPassword As String
        Get
            Return password
        End Get
        Set(newPassword As String)
            password = newPassword
        End Set
    End Property

    Public Property thisSolde As Integer
        Get
            Return solde
        End Get
        Set(newSolde As Integer)
            solde = newSolde
        End Set
    End Property

End Class
