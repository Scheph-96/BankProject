Public Class AccountEditionScreen
    Private _CurrentCheckingAccount As New CheckingAccount
    Private _CurrentSavingAccount As New SavingsAccount

    ''' <summary>
    ''' Methode de Chargement:
    ''' Elle s'execute lors du chargement de ce UserForm
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub AccountEditionScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BackPic.Image = WallStreetProject.My.Resources.back_ico3
    End Sub

    ''' <summary>
    ''' Methode de retour:
    ''' Elle lance le dashboard via une nouvelle instance 
    ''' et détruit l'interface d'édition du compte 
    ''' </summary>
    ''' <remarks></remarks>
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

    ''' <summary>
    ''' Methode d'affichage:
    ''' Affiche le contenu du textbox lié à ce déclencheur
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub UserPasswordDisplayer_CheckedChanged(sender As Object, e As EventArgs) Handles UserPasswordDisplayer.CheckedChanged
        If UserPasswordDisplayer.Checked Then
            UserPassword.UseSystemPasswordChar = False
        Else
            UserPassword.UseSystemPasswordChar = True
        End If
    End Sub

    ''' <summary>
    ''' Methode d'affichage:
    ''' Affiche le contenu du textbox lié à ce déclencheur
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub OldPasswordDisplayer_CheckedChanged(sender As Object, e As EventArgs) Handles OldPasswordDisplayer.CheckedChanged
        If OldPasswordDisplayer.Checked Then
            OldPassword.UseSystemPasswordChar = False
        Else
            OldPassword.UseSystemPasswordChar = True
        End If
    End Sub

    ''' <summary>
    ''' Methode d'affichage:
    ''' Affiche le contenu du textbox lié à ce déclencheur
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub NewPasswordDisplayer_CheckedChanged(sender As Object, e As EventArgs) Handles NewPasswordDisplayer.CheckedChanged
        If NewPasswordDisplayer.Checked Then
            NewPassword.UseSystemPasswordChar = False
        Else
            NewPassword.UseSystemPasswordChar = True
        End If
    End Sub

    ''' <summary>
    ''' Methode d'action:
    ''' Action lancé lors de l'évènement clique du bouton
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub ConfirmUsernameUpdate_Click(sender As Object, e As EventArgs) Handles ConfirmUsernameUpdate.Click
        'Creation des instances
        Dim controller As New Controller
        Dim UpdateStatus As New Dictionary(Of Boolean, String)
        'Verification des entrées utilisateur et exiger le remplissage de tous les champs
        If NewUsername.Text = "" Or UserPassword.Text = "" Then
            MessageBox.Show("Veuillez remplir tous les champs!")
        Else
            'Si le compte connecté est un compte courant
            If _CurrentCheckingAccount.AccountCreationDate <> Nothing Then
                'Modification du nom d'utilisateur via la fonction userUpdate de la classe controller
                'qui retourne un dictionnaire fesant état de la modification
                UpdateStatus = controller.UsernameUpdate(_CurrentCheckingAccount.AccountNumber, NewUsername.Text, UserPassword.Text)
                'Si le dictionnaire renvoyé contient la clé True alors la mise à jour
                'à été effectué avec succès
                If UpdateStatus.ContainsKey(True) Then
                    'Mise à jour de l'instance connecté
                    _CurrentCheckingAccount.AccountOwner.CustomerUserName = NewUsername.Text
                    'Mise à jour du label affichant le nom d'utilisateur situé dans
                    'le conteneur du dashboard
                    CType(Parent.Parent.Parent.Parent, UserDashboardScreen).Refresh(NewUsername.Text)
                    'Affichage du message renvoyé par la fonction userUpdate à l'utilisateur
                    MessageBox.Show(UpdateStatus.Values(0))
                    'Si le dictionnaire renvoyé contient la clé False alors la mise à jour est un echec
                ElseIf UpdateStatus.ContainsKey(False) Then
                    'Affichage du message renvoyé par la fonction userUpdate à l'utilisateur
                    MessageBox.Show(UpdateStatus.Values(0))
                End If
                'Si le compte connecté est un compte épargne
            ElseIf _CurrentSavingAccount.AccountCreationDate <> Nothing Then
                'Modification du nom d'utilisateur via la fonction userUpdate de la classe controller
                'qui retourne un dictionnaire fesant état de la modification
                UpdateStatus = controller.UsernameUpdate(_CurrentSavingAccount.AccountNumber, NewUsername.Text, UserPassword.Text)
                'Si le dictionnaire renvoyé contient la clé True alors la mise à jour
                'à été effectué avec succès
                If UpdateStatus.ContainsKey(True) Then
                    'Mise à jour de l'instance connecté
                    _CurrentSavingAccount.AccountOwner.CustomerUserName = NewUsername.Text
                    'Mise à jour du label affichant le nom d'utilisateur situé dans
                    'le conteneur du dashboard
                    CType(Parent.Parent.Parent.Parent, UserDashboardScreen).Refresh(NewUsername.Text)
                    'Affichage du message renvoyé par la fonction userUpdate à l'utilisateur
                    MessageBox.Show(UpdateStatus.Values(0))
                    'Si le dictionnaire renvoyé contient la clé False alors la mise à jour est un echec
                ElseIf UpdateStatus.ContainsKey(False) Then
                    'Affichage du message renvoyé par la fonction userUpdate à l'utilisateur
                    MessageBox.Show(UpdateStatus.Values(0))
                End If
            End If
        End If
    End Sub

    Private Sub ConfirmPasswordUpdate_Click(sender As Object, e As EventArgs) Handles ConfirmPasswordUpdate.Click
        'Creation des instances
        Dim controller As New Controller
        Dim UpdateStatus As New Dictionary(Of Boolean, String)
        'Verification des entrées utilisateur et exiger le remplissage de tous les champs
        If OldPassword.Text = "" Or NewPassword.Text = "" Then
            MessageBox.Show("Veuillez remplir tous les champs!")
        Else
            'Si le compte connecté est un compte courant
            If _CurrentCheckingAccount.AccountCreationDate <> Nothing Then
                'Modification du mot de passe via la fonction PasswordUpdate de la classe controller
                'qui retourne un dictionnaire fesant état de la modification
                UpdateStatus = controller.PasswordUpdate(_CurrentCheckingAccount.AccountNumber, NewPassword.Text, OldPassword.Text)
                'Si le dictionnaire renvoyé contient la clé True alors la mise à jour
                'à été effectué avec succès
                If UpdateStatus.ContainsKey(True) Then
                    'Mise à jour de l'instance connecté
                    _CurrentCheckingAccount.AccountOwner.CustomerPassword = controller.passwordHash(NewPassword.Text)
                    'Affichage du message renvoyé par la fonction PasswordUpdate à l'utilisateur
                    MessageBox.Show(UpdateStatus.Values(0))
                    'Si le dictionnaire renvoyé contient la clé False alors la mise à jour est un echec
                ElseIf UpdateStatus.ContainsKey(False) Then
                    'Affichage du message renvoyé par la fonction PasswordUpdate à l'utilisateur
                    MessageBox.Show(UpdateStatus.Values(0))
                End If
                'Si le compte connecté est un compte épargne
            ElseIf _CurrentSavingAccount.AccountCreationDate <> Nothing Then
                'Modification du mot de passe via la fonction PasswordUpdate de la classe controller
                'qui retourne un dictionnaire fesant état de la modification
                UpdateStatus = controller.PasswordUpdate(_CurrentSavingAccount.AccountNumber, NewPassword.Text, OldPassword.Text)
                'Si le dictionnaire renvoyé contient la clé True alors la mise à jour
                'à été effectué avec succès
                If UpdateStatus.ContainsKey(True) Then
                    'Mise à jour de l'instance connecté
                    _CurrentSavingAccount.AccountOwner.CustomerPassword = controller.passwordHash(NewPassword.Text)
                    'Affichage du message renvoyé par la fonction PasswordUpdate à l'utilisateur
                    MessageBox.Show(UpdateStatus.Values(0))
                    'Si le dictionnaire renvoyé contient la clé False alors la mise à jour est un echec
                ElseIf UpdateStatus.ContainsKey(False) Then
                    'Affichage du message renvoyé par la fonction PasswordUpdate à l'utilisateur
                    MessageBox.Show(UpdateStatus.Values(0))
                End If
            End If
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
