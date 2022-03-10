Imports Newtonsoft.Json
Imports System.IO
Imports System.Text

Public Class Controller
    Private banque As New Bank()
    Private swBanque As StreamWriter
    Private srBanque As StreamReader
    Private myBanqueSerializer As JsonSerializer
    Private _loggedAccount As New Account()
    Private hashedPassword As String = String.Empty
    Private errorMessage As String = String.Empty


    Public Property LoggedAccount() As Account
        Get
            LoggedAccount = _loggedAccount
        End Get
        Set(value As Account)
            _loggedAccount = value
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
                isFind = True
                _loggedAccount = banque.BankCheckingAccounts.Item("Checking")(i)
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
                    isFind = True
                    _loggedAccount = banque.BankSavingAccounts.Item("Savings")(i)
                    Exit For
                Else
                    isFind = False
                End If
            Next

            If isFind Then
                resultMsg.Add(True, "Connexion Réussi")
                Return resultMsg
            Else
                resultMsg.Add(False, "Echec de connexion. Vérifiez les informations saisis")
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

    'Public Function AccountByNumber(number As Integer)
    '    banque = ReadFile()
    '    Dim isFind As Boolean = True
    '    Dim accountFind As New Account()
    '    For i As Integer = 0 To banque.BankAccounts.Count
    '        If banque.BankAccounts.Item("Savings")(i).AccountNumber = number Then
    '            isFind = True
    '            accountFind = banque.BankAccounts.Item("Savings")(i)
    '            Exit For
    '        Else
    '            isFind = False
    '            errorMessage = "Ce compte n'existe pas"
    '        End If
    '    Next

    '    If isFind Then
    '        Return accountFind
    '    Else
    '        Return errorMessage
    '    End If
    'End Function

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
            ElseIf savingsAccount.AccountNumber < checkingAccount.AccountNumber Then
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

    Public Function passwordHash(ToHash As String) As String
        'Encrytion function
        Dim encode As Byte() = New Byte(ToHash.Length - 1) {}
        encode = Encoding.UTF8.GetBytes(ToHash)
        hashedPassword = Convert.ToBase64String(encode)
        Return hashedPassword
    End Function

End Class
