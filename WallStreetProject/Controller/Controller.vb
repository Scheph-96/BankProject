Imports Newtonsoft.Json
Imports System.IO
Imports System.Text

''' <summary>
''' Classe de control:
''' Cette classe contient toute les méthodes et fonctions nécessaire pour l'execution du programme
''' </summary>
Public Class Controller
    Private banque As New Bank()
    Private swBanque As StreamWriter
    Private srBanque As StreamReader
    Private myBanqueSerializer As JsonSerializer
    Private _loggedCheckingAccount As New CheckingAccount()
    Private _loggedSavingAccount As New SavingsAccount()


    Public Property LoggedCheckingAccount() As CheckingAccount
        Get
            LoggedCheckingAccount = _loggedCheckingAccount
        End Get
        Set(value As CheckingAccount)
            _loggedCheckingAccount = value
        End Set
    End Property

    Public Property LoggedSavingAccount() As SavingsAccount
        Get
            LoggedSavingAccount = _loggedSavingAccount
        End Get
        Set(value As SavingsAccount)
            _loggedSavingAccount = value
        End Set
    End Property

    Sub New()
        'banque = ReadFile()
    End Sub

    Public Sub WriteInFile(myBanque As Bank)
        'Serialize Object to an JSON File
        swBanque = New StreamWriter("P:\Source-Code\Git\BankProject\WallStreetProject\Project\Data\data.json", False)
        Using jsonWriter As New JsonTextWriter(swBanque)

            jsonWriter.Formatting = Formatting.Indented
            'jsonWriter.IndentChar = "-"
            jsonWriter.Indentation = 4

            myBanqueSerializer = New JsonSerializer()
            myBanqueSerializer.Serialize(jsonWriter, myBanque)

        End Using
        swBanque.Close()
    End Sub

    Public Function ReadFile() As Bank
        'Deserialize JSON to a new Banque Object
        'If File.Exists("P:\Source-Code\Git\BankProject\WallStreetProject\Project\Data\data.json") Then
        srBanque = New StreamReader("P:\Source-Code\Git\BankProject\WallStreetProject\Project\Data\data.json")
        myBanqueSerializer = New JsonSerializer()
        banque = myBanqueSerializer.Deserialize(srBanque, banque.GetType)
        srBanque.Close()
        Return banque
        'Else
        '    Dim banque As New Bank()
        '    Return banque
        'End If
        'Return Nothing
    End Function

    Public Function CustomerLogin(username As String, password As String) As Dictionary(Of Boolean, String)
        banque = ReadFile()
        Dim isFind As Boolean = True
        Dim resultMsg As New Dictionary(Of Boolean, String)
        For i As Integer = 0 To banque.BankCheckingAccounts.Item("Checking").Count - 1
            If banque.BankCheckingAccounts.Item("Checking")(i).AccountOwner.CustomerUserName = username And banque.BankCheckingAccounts.Item("Checking")(i).AccountOwner.CustomerPassword = passwordHash(password) Then
                If banque.BankCheckingAccounts.Item("Checking")(i).AccountStatus <> AccountStatus.active Then
                    resultMsg.Add(False, "Ce compte est inactif. Supprimé ou bloqué")
                    Return resultMsg
                End If
                isFind = True
                _loggedCheckingAccount = banque.BankCheckingAccounts.Item("Checking")(i)
                Exit For
            Else
                isFind = False
            End If
        Next

        If isFind Then
            resultMsg.Add(True, "Connexion Réussi")
            Return resultMsg
        Else
            For i As Integer = 0 To banque.BankSavingAccounts.Item("Savings").Count - 1
                If banque.BankSavingAccounts.Item("Savings")(i).AccountOwner.CustomerUserName = username And banque.BankSavingAccounts.Item("Savings")(i).AccountOwner.CustomerPassword = passwordHash(password) Then
                    If banque.BankSavingAccounts.Item("Savings")(i).AccountStatus <> AccountStatus.active Then
                        resultMsg.Add(False, "Ce compte est inactif. Supprimé ou bloqué")
                        Return resultMsg
                    End If
                    isFind = True
                    _loggedSavingAccount = banque.BankSavingAccounts.Item("Savings")(i)
                    Exit For
                Else
                    isFind = False
                End If
            Next

            If isFind Then
                resultMsg.Add(True, "Connexion Réussi")
                Return resultMsg
            Else
                resultMsg.Add(False, "Echec de connexion. Vérifiez les informations saisis ")
                Return resultMsg
            End If
        End If
    End Function

    Public Function AdminLogin(adminName As String, password As String)
        banque = ReadFile()
        If banque.Admin.AdminName = adminName And banque.Admin.AdminPassword = passwordHash(password) Then
            Return True
        Else
            Return False
        End If
    End Function


    ''' <summary>
    ''' Fonction:
    ''' Cette fonction retourne le compte associé au numéro de compte passé en argument
    ''' </summary>
    ''' <param name="number">Un numéro de compte</param>
    ''' <remarks></remarks>
    Public Function AccountByNumber(number As Integer)
        'Récupération de l'objet banque
        banque = ReadFile()

        'Nouvelles instances
        Dim isFind As Boolean = True
        Dim checkingAccountFind As New Dictionary(Of String, CheckingAccount) From {{"Checking", New CheckingAccount()}}
        Dim savingAccountFind As New Dictionary(Of String, SavingsAccount) From {{"Savings", New SavingsAccount()}}
        Dim errorMessage As New Dictionary(Of String, String)

        'Boucle sur la liste des comptes de type épargne
        For i As Integer = 0 To banque.BankSavingAccounts.Item("Savings").Count - 1
            'Si le numéro de compte de l'itération courante est égale au numéro passé en paramètre 
            If banque.BankSavingAccounts.Item("Savings")(i).AccountNumber = number Then
                If banque.BankSavingAccounts.Item("Savings")(i).AccountStatus <> AccountStatus.active Then
                    errorMessage.Add("Error", "Ce compte est inactif. Bloqué ou supprimé!")
                    Return errorMessage
                End If
                isFind = True
                    'Récupération du compte
                    savingAccountFind.Item("Savings") = banque.BankSavingAccounts.Item("Savings")(i)
                    'Sortie de la boucle
                    Exit For
                Else
                    isFind = False
            End If
        Next

        'Si le compte récherché est trouvé
        If isFind Then
            'Retour du compte
            Return savingAccountFind
            'Si non
        Else
            'Boucle sur la liste des comptes de type courant
            For i As Integer = 0 To banque.BankCheckingAccounts.Item("Checking").Count - 1
                'Si le numéro de compte de l'itération courante est égale au numéro passé en paramètre 
                If banque.BankCheckingAccounts.Item("Checking")(i).AccountNumber = number Then
                    If banque.BankCheckingAccounts.Item("Checking")(i).AccountStatus <> AccountStatus.active Then
                        errorMessage.Add("Error", "Ce compte est inactif. Bloqué ou supprimé!")
                        Return errorMessage
                    End If
                    isFind = True
                    'Récupération du compte
                    checkingAccountFind.Item("Checking") = banque.BankCheckingAccounts.Item("Checking")(i)
                    'Sortie de la boucle
                    Exit For
                Else
                    isFind = False
                End If
            Next

            'Si le compte récherché est trouvé
            If isFind Then
                Return checkingAccountFind
                'Si non
            Else
                'Initialisation et retour du message d'erreur
                errorMessage.Add("Error", "Ce compte n'existe pas!")
                Return errorMessage
            End If
        End If
    End Function

    Public Sub createAccount(lastname As String, firstname As String, phoneNumber As String, type As AccountsType)
        banque = ReadFile()
        Dim username = firstname + lastname
        Dim anCustomer As New Customer(lastname, firstname, username, passwordHash("@1234567890@"), phoneNumber)
        If type = AccountsType.Checking Then
            Dim anAccount As New CheckingAccount(newAccountID(), anCustomer)
            banque.BankCheckingAccounts.Item("Checking").Add(anAccount)
        ElseIf type = AccountsType.Savings Then
            Dim anAccount As New SavingsAccount(newAccountID(), anCustomer)
            banque.BankSavingAccounts.Item("Savings").Add(anAccount)
        End If
        WriteInFile(banque)
    End Sub

    Public Function deleteAccount(accountNumber As Integer, adminPassWord As String) As String
        banque = ReadFile()
        Dim isFind As Boolean = True
        If passwordHash(adminPassWord) = banque.Admin.AdminPassword Then
            For i As Integer = 0 To banque.BankSavingAccounts.Item("Savings").Count - 1
                If accountNumber = banque.BankSavingAccounts.Item("Savings")(i).AccountNumber Then
                    banque.BankSavingAccounts.Item("Savings")(i).AccountStatus = AccountStatus.delete
                    isFind = True
                    Exit For
                Else
                    isFind = False
                End If
            Next

            If isFind Then
                WriteInFile(banque)
                Return "Compte supprimé avec succès"
            Else
                For i As Integer = 0 To banque.BankCheckingAccounts.Item("Checking").Count - 1
                    If accountNumber = banque.BankCheckingAccounts.Item("Checking")(i).AccountNumber Then
                        banque.BankCheckingAccounts.Item("Checking")(i).AccountStatus = AccountStatus.delete
                        isFind = True
                        Exit For
                    Else
                        isFind = False
                    End If
                Next

                If isFind Then
                    WriteInFile(banque)
                    Return "Compte supprimé avec succès"
                Else
                    Return "Ce compte n'existe pas"
                End If
            End If
        Else
            Return "Mot de passe incorrecte"
        End If

    End Function

    Public Function blockAccount(accountNumber As Integer, adminPassWord As String) As String
        banque = ReadFile()
        Dim isFind As Boolean = True
        If passwordHash(adminPassWord) = banque.Admin.AdminPassword Then
            For i As Integer = 0 To banque.BankSavingAccounts.Item("Savings").Count - 1
                If accountNumber = banque.BankSavingAccounts.Item("Savings")(i).AccountNumber Then
                    If banque.BankSavingAccounts.Item("Savings")(i).AccountStatus = AccountStatus.delete Then
                        Return "Ce compte est supprimé et ne peut être bloqué"
                    End If
                    banque.BankSavingAccounts.Item("Savings")(i).AccountStatus = AccountStatus.blocked
                    isFind = True
                    Exit For
                Else
                    isFind = False
                End If
            Next

            If isFind Then
                WriteInFile(banque)
                Return "Compte bloqué avec succès"
            Else
                For i As Integer = 0 To banque.BankCheckingAccounts.Item("Checking").Count - 1
                    If accountNumber = banque.BankCheckingAccounts.Item("Checking")(i).AccountNumber Then
                        If banque.BankCheckingAccounts.Item("Checking")(i).AccountStatus = AccountStatus.delete Then
                            Return "Ce compte est supprimé et ne peut être bloqué"
                        End If
                        banque.BankCheckingAccounts.Item("Checking")(i).AccountStatus = AccountStatus.blocked
                        isFind = True
                        Exit For
                    Else
                        isFind = False
                    End If
                Next

                If isFind Then
                    WriteInFile(banque)
                    Return "Compte bloqué avec succès"
                Else
                    Return "Ce compte n'existe pas"
                End If
            End If
        Else
            Return "Mot de passe incorrecte"
        End If
    End Function

    Public Function activeAccount(accountNumber As Integer, adminPassword As String) As String
        banque = ReadFile()
        Dim isFind As Boolean = True
        If passwordHash(adminPassword) = banque.Admin.AdminPassword Then
            For i As Integer = 0 To banque.BankSavingAccounts.Item("Savings").Count - 1
                If accountNumber = banque.BankSavingAccounts.Item("Savings")(i).AccountNumber Then
                    If banque.BankSavingAccounts.Item("Savings")(i).AccountStatus = AccountStatus.delete Then
                        Return "Ce compte est supprimé et ne peut être réactivé"
                    End If
                    banque.BankSavingAccounts.Item("Savings")(i).AccountStatus = AccountStatus.active
                    isFind = True
                    Exit For
                Else
                    isFind = False
                End If
            Next

            If isFind Then
                WriteInFile(banque)
                Return "Compte activé avec succès"
            Else
                For i As Integer = 0 To banque.BankCheckingAccounts.Item("Checking").Count - 1
                    If accountNumber = banque.BankCheckingAccounts.Item("Checking")(i).AccountNumber Then
                        If banque.BankCheckingAccounts.Item("Checking")(i).AccountStatus = AccountStatus.delete Then
                            Return "Ce compte est supprimé et ne peut être réactivé"
                        End If
                        banque.BankCheckingAccounts.Item("Checking")(i).AccountStatus = AccountStatus.active
                        isFind = True
                        Exit For
                    Else
                        isFind = False
                    End If
                Next

                If isFind Then
                    WriteInFile(banque)
                    Return "Compte activé avec succès"
                Else
                    Return "Ce compte n'existe pas"
                End If
            End If
        Else
            Return "Mot de passe incorrecte"
        End If
    End Function

    Public Function setInterest(accountNumber As Integer, newInterest As Double, adminPassWord As String)
        banque = ReadFile()
        Dim isFind As Boolean = True
        If passwordHash(adminPassWord) = banque.Admin.AdminPassword Then

            For i As Integer = 0 To banque.BankSavingAccounts.Item("Savings").Count - 1
                If accountNumber = banque.BankSavingAccounts.Item("Savings")(i).AccountNumber Then
                    If banque.BankSavingAccounts.Item("Savings")(i).AccountStatus <> AccountStatus.active Then
                        Return "Ce compte est inactif. Bloqué ou supprimé!"
                    End If
                    Dim savingAccount As New SavingsAccount(banque.BankSavingAccounts.Item("Savings")(i), newInterest)
                    banque.BankSavingAccounts.Item("Savings")(i) = savingAccount
                    isFind = True
                    Exit For
                Else
                    isFind = False
                End If
            Next

            If isFind Then
                WriteInFile(banque)
                Return "Taux d'intèrêt fixé avec succès"
            Else
                Return "Ce compte n'existe pas"
            End If
        Else
            Return "Mot de passe incorrecte"
        End If
    End Function

    Public Function UsernameUpdate(accountNumber As Integer, newUsername As String, password As String) As Dictionary(Of Boolean, String)
        banque = ReadFile()
        Dim isFind As Boolean = True
        Dim result As New Dictionary(Of Boolean, String)

        For i As Integer = 0 To banque.BankCheckingAccounts.Item("Checking").Count - 1
            If banque.BankCheckingAccounts.Item("Checking")(i).AccountNumber = accountNumber And banque.BankCheckingAccounts.Item("Checking")(i).AccountOwner.CustomerPassword = passwordHash(password) Then
                isFind = True
                banque.BankCheckingAccounts.Item("Checking")(i).AccountOwner.CustomerUserName = newUsername
                Exit For
            Else
                isFind = False
            End If
        Next

        If isFind Then
            WriteInFile(banque)
            result.Add(True, "Nom d'utilisateur modifié avec succès")
            Return result
        Else
            For i As Integer = 0 To banque.BankSavingAccounts.Item("Savings").Count - 1
                If banque.BankSavingAccounts.Item("Savings")(i).AccountNumber = accountNumber And banque.BankSavingAccounts.Item("Savings")(i).AccountOwner.CustomerPassword = passwordHash(password) Then
                    isFind = True
                    banque.BankSavingAccounts.Item("Savings")(i).AccountOwner.CustomerUserName = newUsername
                    Exit For
                Else
                    isFind = False
                End If
            Next

            If isFind Then
                WriteInFile(banque)
                result.Add(True, "Nom d'utilisateur modifié avec succès")
                Return result
            Else
                result.Add(False, "Mot de passe incorrecte!")
                Return result
            End If
        End If
    End Function

    Public Function PasswordUpdate(accountNumber As Integer, newPassword As String, password As String) As Dictionary(Of Boolean, String)
        banque = ReadFile()
        Dim isFind As Boolean = True
        Dim result As New Dictionary(Of Boolean, String)

        For i As Integer = 0 To banque.BankCheckingAccounts.Item("Checking").Count - 1
            If banque.BankCheckingAccounts.Item("Checking")(i).AccountNumber = accountNumber And banque.BankCheckingAccounts.Item("Checking")(i).AccountOwner.CustomerPassword = passwordHash(password) Then
                isFind = True
                banque.BankCheckingAccounts.Item("Checking")(i).AccountOwner.CustomerPassword = passwordHash(newPassword)
                Exit For
            Else
                isFind = False
            End If
        Next

        If isFind Then
            WriteInFile(banque)
            result.Add(True, "Mot de passe modifié avec succès")
            Return result
        Else
            For i As Integer = 0 To banque.BankSavingAccounts.Item("Savings").Count - 1
                If banque.BankSavingAccounts.Item("Savings")(i).AccountNumber = accountNumber And banque.BankSavingAccounts.Item("Savings")(i).AccountOwner.CustomerPassword = passwordHash(password) Then
                    isFind = True
                    banque.BankSavingAccounts.Item("Savings")(i).AccountOwner.CustomerPassword = passwordHash(newPassword)
                    Exit For
                Else
                    isFind = False
                End If
            Next

            If isFind Then
                WriteInFile(banque)
                result.Add(True, "Mot de passe modifié avec succès")
                Return result
            Else
                result.Add(False, "Mot de passe incorrecte!")
                Return result
            End If
        End If
    End Function


    ''' <summary>
    ''' Fonction:
    ''' Cette fonction effectue les transaction de compte
    ''' </summary>
    ''' <param name="accountNumber">Numéro du compte qui appele la fonction</param>
    ''' <param name="type">Type du compte</param>
    ''' <param name="amount">Montant de la transaction</param>
    ''' <param name="target">La cible en cas de transfert</param>
    ''' <remarks></remarks>
    Public Function Transaction(accountNumber As Integer, type As TransactionsType, amount As Double, password As String, Optional target As Integer = 0)
        'Récupération de l'objet banque
        banque = ReadFile()
        'Instance utile
        Dim isFind As Boolean = True
        Dim result As New Dictionary(Of String, String)
        Dim newObject As Object
        Dim transferDict As New Dictionary(Of Transfer, Bank)

        'Boucle sur la list des comptes courants de la compte
        For i As Integer = 0 To banque.BankCheckingAccounts.Item("Checking").Count - 1
            'Si le numéro de compte de l'itération courante est égale au numéro passé en paramètre
            If banque.BankCheckingAccounts.Item("Checking")(i).AccountNumber = accountNumber And banque.BankCheckingAccounts.Item("Checking")(i).AccountOwner.CustomerPassword = passwordHash(password) Then
                isFind = True
                'Si un dépôt doit être effectué
                If type = TransactionsType.Deposit Then
                    'Nouvelle instance dépôt
                    Dim deposit As Deposit
                    'Réalisation du dépôt
                    deposit = banque.BankCheckingAccounts.Item("Checking")(i).Deposit(amount)
                    'Ajout du dépôt à la liste des dépôt de la banque
                    banque.BankDeposits.Item("Deposits").Add(deposit)
                    'Sortie de la boucle
                    Exit For
                    'Si un retrait doit être effectué
                ElseIf type = TransactionsType.Withdrawal Then

                    'Réalisation du retrait
                    newObject = banque.BankCheckingAccounts.Item("Checking")(i).Withdraw(amount)

                    'Verification du type de retour
                    If newObject.GetType Is GetType(Withdrawal) Then

                        'Nouvelle instance retrait
                        Dim withdrawal As Withdrawal

                        'Ajout du retrait à la liste des retrait de la banque
                        withdrawal = newObject
                        banque.BankWithdrawals.Item("Withdrawals").Add(withdrawal)

                        'Sortie de la boucle
                        Exit For
                    ElseIf newObject.GetType Is GetType(Dictionary(Of String, String)) Then
                        result = newObject
                        Return result
                    End If
                    'Si un transfert doit être effectué
                ElseIf type = TransactionsType.Transfer Then
                    'Réalisation du transfer
                    newObject = banque.BankCheckingAccounts.Item("Checking")(i).Transfer(amount, target, banque)
                    'Verification du type de retour
                    If newObject.GetType Is GetType(Dictionary(Of Transfer, Bank)) Then

                        'Nouvelle instance transfer
                        Dim transfer As Transfer

                        transferDict = newObject

                        'Ajout du transfert à la liste des transferts de la banque
                        transfer = transferDict.Keys(0)
                        banque = transferDict.Values(0)
                        banque.BankTranfers.Item("Transfers").Add(transfer)
                        Exit For
                    ElseIf newObject.GetType Is GetType(Dictionary(Of String, String)) Then
                        result = newObject
                        Return result
                    End If

                End If
            Else
                isFind = False
            End If
        Next

        If isFind Then
            result.Add("Done", "Task performed")
            WriteInFile(banque)
            Return result
        Else
            'Boucle sur la list des comptes épargne de la compte
            For i As Integer = 0 To banque.BankSavingAccounts.Item("Savings").Count - 1
                'Si le numéro de compte de l'itération courante est égale au numéro passé en paramètre
                If banque.BankSavingAccounts.Item("Savings")(i).AccountNumber = accountNumber And banque.BankSavingAccounts.Item("Savings")(i).AccountOwner.CustomerPassword = passwordHash(password) Then
                    isFind = True
                    'Si un dépôt doit être effectué
                    If type = TransactionsType.Deposit Then
                        'Nouvelle instance dépôt
                        Dim deposit As Deposit
                        'Réalisation du dépôt
                        deposit = banque.BankSavingAccounts.Item("Savings")(i).Deposit(amount)
                        'Ajout du dépôt à la liste des dépôt de la banque
                        banque.BankDeposits.Item("Deposits").Add(deposit)
                        'Sortie de la boucle
                        Exit For

                        'Si un retrait doit être effectué
                    ElseIf type = TransactionsType.Withdrawal Then

                        'Réalisation du retrait
                        newObject = banque.BankSavingAccounts.Item("Savings")(i).Withdraw(amount)

                        'Verification du type de retour
                        If newObject.GetType Is GetType(Withdrawal) Then
                            'Nouvelle instance retrait
                            Dim withdrawal As Withdrawal

                            'Ajout du retrait à la liste des retrait de la banque
                            withdrawal = newObject
                            banque.BankWithdrawals.Item("Withdrawals").Add(withdrawal)

                            'Sortie de la boucle
                            Exit For
                        ElseIf newObject.GetType Is GetType(Dictionary(Of String, String)) Then
                            result = newObject
                            Return result
                        End If

                        'Si un transfert doit être effectué
                    ElseIf type = TransactionsType.Transfer Then

                        'Réalisation du transfer
                        newObject = banque.BankSavingAccounts.Item("Savings")(i).Transfer(amount, target, banque)

                        'Verification du type de retour
                        If newObject.GetType Is GetType(Dictionary(Of Transfer, Bank)) Then

                            'Nouvelle instance transfer
                            Dim transfer As Transfer

                            transferDict = newObject

                            'Ajout du transfert à la liste des transferts de la banque
                            transfer = transferDict.Keys(0)
                            banque = transferDict.Values(0)
                            banque.BankTranfers.Item("Transfers").Add(transfer)
                            Exit For
                        ElseIf newObject.GetType Is GetType(Dictionary(Of String, String)) Then
                            result = newObject
                            Return result
                        End If

                    End If
                Else
                    isFind = False
                End If
            Next


            If isFind Then
                result.Add("Done", "Task performed")
                WriteInFile(banque)
                Return result
            Else
                result.Add("ErrorPassword", "Mot de passe incorrecte!")
                Return result
            End If
        End If
    End Function

    ''' <summary>
    ''' Methode d'addition:
    ''' Cette procédure ajoute le montant d'un transfert au solde de la cible
    ''' </summary>
    ''' <param name="target">La cible de la transaction</param>
    ''' <param name="amount">Le montant de la transaction</param>
    ''' <remarks></remarks>
    Public Function PerformTransfer(target As Integer, amount As Double, banque As Bank)
        'Déclaration de variable
        Dim isFind As Boolean = True

        'Boucle sur la liste des comptes épargne
        For i As Integer = 0 To banque.BankSavingAccounts.Item("Savings").Count - 1
            Debug.WriteLine("Start loop")
            If banque.BankSavingAccounts.Item("Savings")(i).AccountNumber = target Then
                Debug.WriteLine("Acount found")
                isFind = True

                'Ajout du montant
                banque.BankSavingAccounts.Item("Savings")(i).AccountSolde += amount
                Exit For
            Else
                isFind = False
            End If
        Next

        If isFind Then
            Debug.WriteLine("Account find in savings block")
            'Retour de l'objet banque
            Return banque
        Else
            Debug.WriteLine("In else Checking block")
            'Boucle sur la liste des compte courant
            For i As Integer = 0 To banque.BankCheckingAccounts.Item("Checking").Count - 1
                Debug.WriteLine("Start loop")
                If banque.BankCheckingAccounts.Item("Checking")(i).AccountNumber = target Then
                    Debug.WriteLine("Acount found")
                    isFind = True

                    'Ajout du montant
                    banque.BankCheckingAccounts.Item("Checking")(i).AccountSolde += amount
                    Exit For
                End If
            Next

            If isFind Then
                Debug.WriteLine("Account find in checking block")
                'Retour de l'objet banque
                Return banque
            End If
        End If
    End Function

    Public Function newAccountID() As Integer
        banque = ReadFile()
        Dim checkingAccount As New CheckingAccount()
        Dim savingsAccount As New SavingsAccount()

        If banque.BankCheckingAccounts.Item("Checking").Count = 0 And banque.BankSavingAccounts.Item("Savings").Count = 0 Then
            Return 1
        ElseIf banque.BankCheckingAccounts.Item("Checking").Count = 0 Or banque.BankSavingAccounts.Item("Savings").Count = 0 Then
            If banque.BankCheckingAccounts.Item("Checking").Count = 0 Then
                savingsAccount = banque.BankSavingAccounts.Item("Savings")(banque.BankSavingAccounts.Item("Savings").OfType(Of SavingsAccount).Count - 1)
                Return savingsAccount.AccountNumber + 1
            ElseIf banque.BankSavingAccounts.Item("Savings").Count = 0 Then
                'Debug.WriteLine("the list lenght: {0}", banque.BankAccounts.Item("Checking").OfType(Of CheckingAccount).Count)
                checkingAccount = banque.BankCheckingAccounts.Item("Checking")(banque.BankCheckingAccounts.Item("Checking").OfType(Of CheckingAccount).Count - 1)
                Return checkingAccount.AccountNumber + 1
            End If
        ElseIf banque.BankCheckingAccounts.Item("Checking").Count > 0 And banque.BankSavingAccounts.Item("Savings").Count > 0 Then
            savingsAccount = banque.BankSavingAccounts.Item("Savings")(banque.BankSavingAccounts.Item("Savings").OfType(Of SavingsAccount).Count - 1)
            checkingAccount = banque.BankCheckingAccounts.Item("Checking")(banque.BankCheckingAccounts.Item("Checking").OfType(Of CheckingAccount).Count - 1)
            If savingsAccount.AccountNumber > checkingAccount.AccountNumber Then
                Return savingsAccount.AccountNumber + 1
            ElseIf savingsAccount.AccountNumber <checkingAccount.AccountNumber Then
                Return checkingAccount.AccountNumber + 1
            End If
        End If

        Return Nothing
    End Function

    Public Function SavingAccounts() As List(Of SavingsAccount)
        banque = ReadFile()
        Dim Accounts As New List(Of SavingsAccount)

        For i As Integer = 0 To banque.BankSavingAccounts.Item("Savings").Count - 1
            'Debug.WriteLine(banque.BankSavingAccounts.Count)
            'Debug.WriteLine(banque.BankSavingAccounts.Item("Savings")(0).AccountOwner.CustomerLastName)
            'Debug.WriteLine(banque.BankSavingAccounts.Item("Savings")(1).AccountOwner.CustomerLastName)
            Accounts.Add(banque.BankSavingAccounts.Item("Savings")(i))
        Next

        Return Accounts

    End Function

    Public Function CheckingAccounts() As List(Of CheckingAccount)
        banque = ReadFile()
        Dim Accounts As New List(Of CheckingAccount)

        For i As Integer = 0 To banque.BankCheckingAccounts.Item("Checking").Count - 1
            'Debug.WriteLine(banque.BankCheckingAccounts.Count)
            'Debug.WriteLine(banque.BankCheckingAccounts.Item("Checking")(0).AccountOwner.CustomerLastName)
            'Debug.WriteLine(banque.BankCheckingAccounts.Item("Checking")(1).AccountOwner.CustomerLastName)
            Accounts.Add(banque.BankCheckingAccounts.Item("Checking")(i))
        Next

        Return Accounts

    End Function


    Public Function Deposits() As List(Of Deposit)
        banque = ReadFile()

        Return banque.BankDeposits.Item("Deposits")
    End Function

    Public Function Withdrawals() As List(Of Withdrawal)
        banque = ReadFile()

        Return banque.BankWithdrawals.Item("Withdrawals")
    End Function

    Public Function Transfers() As List(Of Transfer)
        banque = ReadFile()

        Return banque.BankTranfers.Item("Transfers")
    End Function

    ''' <summary>
    ''' Methode de hashage:
    ''' Cette fonction hash les valeurs passées en argument
    ''' </summary>
    ''' <param name="ToHash">La chaîne de caractère à hasher</param>
    ''' <remarks></remarks>
    Public Function passwordHash(ToHash As String) As String
        Dim hashedPassword As String = String.Empty
        'Encrytion function
        Dim encode As Byte() = New Byte(ToHash.Length - 1) {}
        encode = Encoding.UTF8.GetBytes(ToHash)
        hashedPassword = Convert.ToBase64String(encode)
        Return hashedPassword
    End Function

End Class
