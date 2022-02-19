Public Class Banque

    Private name As String
    Private address As String
    Private phoneNumber As String
    Private comptes As List(Of Compte)

    Public Sub New(theName As String, theAddress As String, thePhoneNumber As String)
        name = theName
        address = theAddress
        phoneNumber = thePhoneNumber
    End Sub

    Public Property thisName As String
        Get
            Return name
        End Get
        Set(newName As String)
            name = newName
        End Set
    End Property

    Public Property thisAddress As String
        Get
            Return address
        End Get
        Set(newAddress As String)
            address = newAddress
        End Set
    End Property

    Public Property thisPhoneNumber As String
        Get
            Return phoneNumber
        End Get
        Set(newPhoneNumber As String)
            phoneNumber = newPhoneNumber
        End Set
    End Property

    Public Sub addCompte(newCompte As Compte)
        comptes.Add(newCompte)
    End Sub

    Public Property thisCompte As List(Of Compte)
        Get
            Return comptes
        End Get
        Set(value As List(Of Compte))

        End Set
    End Property


End Class
