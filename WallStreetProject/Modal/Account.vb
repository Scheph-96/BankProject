﻿Public Class Account
    Private _number As Integer
    Private _customer As New Customer()
    Private _solde As Double = 0.0
    Private _type As AccountsType
    Private _transactions As New List(Of Transaction)()
    Private _dateCreation As String
    Private _status As AccountStatus


    Public Sub New()

    End Sub

    Public Sub New(number As Integer, customer As Customer, type As AccountsType)
        _number = number
        _customer = customer
        _type = type
        _dateCreation = DateTime.Now
        _status = AccountStatus.active
    End Sub


    Public Property AccountNumber() As Integer
        Get
            AccountNumber = _number
        End Get
        Set(value As Integer)
            If _number = Nothing Then
                _number = value
            End If
        End Set
    End Property

    Public Property AccountOwner() As Customer
        Get
            AccountOwner = _customer
        End Get
        Set(value As Customer)
            _customer = value
        End Set
    End Property

    Public Property AccountSolde() As Double
        Get
            AccountSolde = _solde
        End Get
        Set(value As Double)
            _solde = value
        End Set
    End Property

    Public Property AccountType() As AccountsType
        Get
            AccountType = _type
        End Get
        Set(value As AccountsType)
            _type = value
        End Set
    End Property

    Public Property AccountTransactions() As List(Of Transaction)
        Get
            AccountTransactions = _transactions
        End Get
        Set(value As List(Of Transaction))
            _transactions = value
        End Set
    End Property

    Public Property AccountCreationDate() As String
        Get
            AccountCreationDate = _dateCreation
        End Get
        Set(value As String)
            _dateCreation = value
        End Set
    End Property

    Public Property AccountStatus() As AccountStatus
        Get
            AccountStatus = _status
        End Get
        Set(value As AccountStatus)
            _status = value
        End Set
    End Property
End Class
