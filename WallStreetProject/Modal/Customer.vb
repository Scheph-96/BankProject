Public Class Customer
    Private _lastName As String
    Private _firstName As String
    Private _password As String
    Private _phoneNumber As String

    Public Sub New()

    End Sub

    Public Sub New(lastName As String, firstName As String, password As String, phoneNumber As String)
        _lastName = lastName
        _firstName = firstName
        _password = password
        _phoneNumber = phoneNumber
    End Sub


    Public Property CustomerLastName() As String
        Get
            CustomerLastName = _lastName
        End Get
        Set(value As String)
            _lastName = value
        End Set
    End Property

    Public Property CustomerFirstName() As String
        Get
            CustomerFirstName = _firstName
        End Get
        Set(value As String)
            _firstName = value
        End Set
    End Property

    Public Property CustomerPassword() As String
        Get
            CustomerPassword = _password
        End Get
        Set(value As String)
            _password = value
        End Set
    End Property
    Public Property CustomerPhoneNumber() As String
        Get
            CustomerPhoneNumber = _phoneNumber
        End Get
        Set(value As String)
            _phoneNumber = value
        End Set
    End Property
End Class
