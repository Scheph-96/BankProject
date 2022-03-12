Public Class UserDashboardScreen
    Private _dashboard As New UserDashboard
    Private _checkingAccount As New CheckingAccount
    Private _savingAccount As New SavingsAccount
    Private _admin As New Administrator

    Private Sub UserDashboardScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LogoutPic.Image = WallStreetProject.My.Resources.logout
        If _checkingAccount.AccountCreationDate <> Nothing Then
            UserLastName.Text = _checkingAccount.AccountOwner.CustomerLastName
            UserFirstName.Text = _checkingAccount.AccountOwner.CustomerFirstName
            UserName.Text = _checkingAccount.AccountOwner.CustomerUserName
            InterestSection.Visible = False
            _dashboard.CurrentCheckingAccount = _checkingAccount
            MenuContainer.Controls.Add(_dashboard)
        ElseIf _savingAccount.AccountCreationDate <> Nothing Then
            UserLastName.Text = _savingAccount.AccountOwner.CustomerLastName
            UserFirstName.Text = _savingAccount.AccountOwner.CustomerFirstName
            UserName.Text = _savingAccount.AccountOwner.CustomerUserName
            InterestValue.Text = _savingAccount.AccountInterest
            _dashboard.CurrentSavingAccount = _savingAccount
            MenuContainer.Controls.Add(_dashboard)
        End If
    End Sub

    Private Sub LogoutPic_Click(sender As Object, e As EventArgs) Handles LogoutPic.Click
        Dim loginScreen As New LoginScreen()
        Parent.Dispose()
        loginScreen.ShowDialog()
    End Sub

#Disable Warning BC40005 ' Le membre masque une méthode substituable dans le type de base
    Public Sub Refresh(NewUsername As String)
#Enable Warning BC40005 ' Le membre masque une méthode substituable dans le type de base
        If _checkingAccount.AccountCreationDate <> Nothing Then
            _checkingAccount.AccountOwner.CustomerUserName = NewUsername
            UserName.Text = NewUsername
        ElseIf _savingAccount.AccountCreationDate <> Nothing Then
            _savingAccount.AccountOwner.CustomerUserName = NewUsername
            UserName.Text = NewUsername
        End If
    End Sub

    Public Property CheckingAccount() As CheckingAccount
        Get
            CheckingAccount = _checkingAccount
        End Get
        Set(value As CheckingAccount)
            _checkingAccount = value
        End Set
    End Property

    Public Property SavingAccount() As SavingsAccount
        Get
            SavingAccount = _savingAccount
        End Get
        Set(value As SavingsAccount)
            _savingAccount = value
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
