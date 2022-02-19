Public Class Epargne : Inherits Compte

    Private interet As Double
    Private type As String = "Epargne"

    Public Sub New(theNumber As Integer, theOwnerName As String, thePassword As String, theSolde As Integer, theInteret As Double)
        MyBase.New(theNumber, theOwnerName, thePassword, theSolde)
        interet = theInteret
    End Sub

    Public Property thisInteret As Double
        Get
            Return interet
        End Get
        Set(newInteret As Double)
            interet = newInteret
        End Set
    End Property

    Public Property thisType As String
        Get
            Return type
        End Get
        Set(value As String)

        End Set
    End Property

End Class
