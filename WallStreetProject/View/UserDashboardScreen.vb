﻿Public Class UserDashboardScreen
    Private _dashboard As New UserDashboard
    Private _owner As New Account
    Private _admin As New Administrator

    Private Sub UserDashboardScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MenuContainer.Controls.Add(_dashboard)
        LogoutPic.Image = WallStreetProject.My.Resources.logout
    End Sub

    Public Property Owner() As Account
        Get
            Owner = _owner
        End Get
        Set(value As Account)
            _owner = value
        End Set
    End Property

    Public Property Admin() As Administrator
        Get
            Admin = _admin
        End Get
        Set(value As Administrator)
            _admin = value
        End Set
    End Property
End Class
