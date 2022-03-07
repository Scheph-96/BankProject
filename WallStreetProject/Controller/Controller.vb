Imports Newtonsoft.Json
Imports System.IO
Imports System.Text

Public Class Controller
    Private banque As New Bank()
    Private swBanque As StreamWriter
    Private srBanque As StreamReader
    Private myBanqueSerializer As JsonSerializer
    Private loggedAccount As New Account()
    Private hashedPassword As String = String.Empty
    Private errorMessage As String = String.Empty

    Sub New()
        banque = ReadFile()
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
        srBanque = New StreamReader("P:\Source-Code\Git\BankProject\WallStreetProject\Project\Data\data.json")
        myBanqueSerializer = New JsonSerializer()
        banque = myBanqueSerializer.Deserialize(srBanque, banque.GetType)
        srBanque.Close()
        Return banque
    End Function

    Public Function CustomerLogin(username As String, password As String, userDashBoard As UserDashboardScreen, userLoginScreen As UserLoginScreen)
        'banque = ReadFile()
        Dim isFind As Boolean = True
        For i As Integer = 0 To banque.BankAccounts.Count
            If banque.BankAccounts(i).AccountOwner.CustomerUserName = username And banque.BankAccounts(i).AccountOwner.CustomerPassword = passwordHash(password) Then
                'isFind = True
                'loggedAccount = banque.BankAccounts(i)
                userDashBoard.Owner = banque.BankAccounts(i)
                userLoginScreen.Dispose()
                userDashBoard.Show()
                Exit For
            Else
                isFind = False
                errorMessage = "Informations incorrecte"
            End If
        Next

        If isFind Then
            Return loggedAccount
        Else
            Return errorMessage
        End If
    End Function

    Public Function AdminLogin(adminName As String, password As String)
        'banque = ReadFile()
        If banque.Admin.AdminName = adminName And banque.Admin.AdminPassword = passwordHash(password) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function AccountByNumber(number As Integer)
        'banque = ReadFile()
        Dim isFind As Boolean = True
        Dim accountFind As New Account()
        For i As Integer = 0 To banque.BankAccounts.Count
            If banque.BankAccounts(i).AccountNumber = number Then
                isFind = True
                accountFind = banque.BankAccounts(i)
                Exit For
            Else
                isFind = False
                errorMessage = "Ce compte n'existe pas"
            End If
        Next

        If isFind Then
            Return accountFind
        Else
            Return errorMessage
        End If
    End Function

    Public Sub createAccount(lastname As String, firstname As String, phoneNumber As String, type As AccountsType)
        'banque = ReadFile()
        Dim username = firstname + lastname
        Dim anCustomer As New Customer(lastname, firstname, username, passwordHash("@1234567890@"), phoneNumber)
        If type = AccountsType.Checking Then
            Dim anAccount As New CheckingAccount(newAccountID(), anCustomer)
            banque.BankAccounts.Add(anAccount)
        ElseIf type = AccountsType.Savings Then
            Dim anAccount As New SavingsAccount(newAccountID(), anCustomer)
            banque.BankAccounts.Add(anAccount)
        End If
        WriteInFile(banque)
    End Sub

    Public Function deleteAccount(accountNumber As Integer, adminPassWord As String) As String
        Dim isFind As Boolean = True
        If passwordHash(adminPassWord) = banque.Admin.AdminPassword Then
            For i As Integer = 0 To banque.BankAccounts.Count - 1
                If accountNumber = banque.BankAccounts(i).AccountNumber Then
                    banque.BankAccounts(i).AccountStatus = AccountStatus.delete
                    isFind = True
                    Exit For
                Else
                    isFind = False
                End If
            Next

            If isFind Then
                WriteInFile(banque)
                Return "Suppression effectué avec succès"
            Else
                Return "Ce compte n'existe pas"
            End If
        Else
            Return "Mot de passe incorrecte"
        End If

    End Function

    Public Function blockAccount(accountNumber As Integer, adminPassWord As String) As String
        Dim isFind As Boolean = True
        If passwordHash(adminPassWord) = banque.Admin.AdminPassword Then
            For i As Integer = 0 To banque.BankAccounts.Count - 1
                If accountNumber = banque.BankAccounts(i).AccountNumber Then
                    banque.BankAccounts(i).AccountStatus = AccountStatus.blocked
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
        Else
            Return "Mot de passe incorrecte"
        End If
    End Function

    Public Function setInterest(accountNumber As Integer, newInterest As Double, adminPassWord As String)
        Dim isFind As Boolean = True
        If passwordHash(adminPassWord) = banque.Admin.AdminPassword Then

            For i As Integer = 0 To banque.BankAccounts.Count - 1
                If banque.BankAccounts(i).AccountType = AccountsType.Savings And accountNumber = banque.BankAccounts(i).AccountNumber Then
                    Dim savingAccount As New SavingsAccount(banque.BankAccounts(i), newInterest)
                    banque.BankAccounts(i) = savingAccount
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
        'banque = ReadFile()
        Dim anAccount As New Account()

        If banque.BankAccounts.Count = 0 Then
            Return 1
        Else
            anAccount = banque.BankAccounts(banque.BankAccounts.Count - 1)
            Return anAccount.AccountNumber + 1
        End If
    End Function

    Public Function passwordHash(ToHash As String) As String
        'Encrytion function
        Dim encode As Byte() = New Byte(ToHash.Length - 1) {}
        encode = Encoding.UTF8.GetBytes(ToHash)
        hashedPassword = Convert.ToBase64String(encode)
        Return hashedPassword
    End Function

End Class
