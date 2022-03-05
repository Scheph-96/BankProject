Public Class Administrator
    Private _adminName As String
    Private _password As String

    Sub New()

    End Sub

    Sub New(adminName As String, password As String)
        _adminName = adminName
        _password = password
    End Sub

    Public Property AdminName() As String
        Get
            AdminName = _adminName
        End Get
        Set(value As String)
            _adminName = value
        End Set
    End Property

    Public Property AdminPassword() As String
        Get
            AdminPassword = _password
        End Get
        Set(value As String)
            _password = value
        End Set
    End Property
End Class
