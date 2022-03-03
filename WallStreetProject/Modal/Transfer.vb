﻿Public Class Transfer
    Inherits Transaction

    Private _target As Integer


    Public Sub New(owner As Account, montant As Double, target As Integer)
        MyBase.New(owner, montant, TransactionsType.Transfer)
        _target = target
    End Sub


    Public Property TransferTarget() As Integer
        Get
            TransferTarget = _target
        End Get
        Set(value As Integer)
            _target = value
        End Set
    End Property
End Class
