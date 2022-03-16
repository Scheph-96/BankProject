Public Class SoldeScreen
    Private _CurrentCheckingAccount As New CheckingAccount
    Private _CurrentSavingAccount As New SavingsAccount

    Private Sub SoldeScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BackPic.Image = WallStreetProject.My.Resources.back_ico3
        If _CurrentCheckingAccount.AccountCreationDate <> Nothing Then
            AccountSolde.Text = _CurrentCheckingAccount.AccountSolde.ToString("N")
        ElseIf _CurrentSavingAccount.AccountCreationDate <> Nothing Then
            AccountSolde.Text = _CurrentSavingAccount.AccountSolde.ToString("N")
        End If
    End Sub

    Private Sub BackPic_Click(sender As Object, e As EventArgs) Handles BackPic.Click
        Dim dashboard As New UserDashboard
        'Si le compte connecté est un compte courant alors initialiser l'attribut compte courant
        'de la nouvelle instance de dashboard avant d'y retourner
        If _CurrentCheckingAccount.AccountCreationDate <> Nothing Then
            dashboard.CurrentCheckingAccount = _CurrentCheckingAccount
            Parent.Controls.Add(dashboard)
            Me.Dispose()
            'Si le compte connecté est un compte épargne alors initialiser l'attribut compte épargne
            'de la nouvelle instance de dashboard avant d'y retourner 
        ElseIf _CurrentSavingAccount.AccountCreationDate <> Nothing Then
            dashboard.CurrentSavingAccount = _CurrentSavingAccount
            Parent.Controls.Add(dashboard)
            Me.Dispose()
        End If
    End Sub


    Public Property CurrentCheckingAccount() As CheckingAccount
        Get
            CurrentCheckingAccount = _CurrentCheckingAccount
        End Get
        Set(value As CheckingAccount)
            _CurrentCheckingAccount = value
        End Set
    End Property

    Public Property CurrentSavingAccount() As SavingsAccount
        Get
            CurrentSavingAccount = _CurrentSavingAccount
        End Get
        Set(value As SavingsAccount)
            _CurrentSavingAccount = value
        End Set
    End Property
End Class
