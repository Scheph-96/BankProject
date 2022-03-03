Imports Newtonsoft.Json
Imports System.IO
Imports System.Text

Public Class Controller
    Private banque As New Bank()
    Private swBanque As StreamWriter
    Private srBanque As StreamReader
    Private loggedAccount As New Account()
    Private hashedPassword As String = String.Empty
    Private errorMessage As String = String.Empty

    Public Sub WriteInFile(myBanque As Bank)
        'Serialize Object to an JSON File
        swBanque = New StreamWriter("P:\Source-Code\Git\BankProject\WallStreetProject\Project\Data\data.json", False)
        Dim myBanqueSerializer As New JsonSerializer()
        myBanqueSerializer.Serialize(swBanque, myBanque)
        swBanque.Close()
    End Sub

    Public Function ReadFile() As Bank
        'Deserialize JSON to a new Banque Object
        srBanque = New StreamReader("P:\Source-Code\Git\BankProject\WallStreetProject\Project\Data\data.json")
        Dim myBanqueSerializer As New JsonSerializer()
        banque = myBanqueSerializer.Deserialize(srBanque, banque.GetType)
        srBanque.Close()
        Return banque
    End Function

    Public Function CustomerLogin(username As String, password As String)
        banque = ReadFile()
        Dim isFind As Boolean = True
        For i As Integer = 0 To banque.BankAccounts.Count
            If banque.BankAccounts(i).AccountOwner.CustomerUserName = username And banque.BankAccounts(i).AccountOwner.CustomerPassword = passwordHash(password) Then
                isFind = True
                loggedAccount = banque.BankAccounts(i)
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
        banque = ReadFile()
        If banque.Admin.AdminName = adminName And banque.Admin.AdminPassword = passwordHash(password) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function deposit(owner As Account, amount As Double)
        owner.AccountSolde = amount
        Dim newDeposit As New Deposit(owner, amount)
        banque.BankTransactions.Add(newDeposit)
        WriteInFile(banque)
    End Function

    Public Function passwordHash(ToHash As String) As String
        'Encrytion function
        Dim encode As Byte() = New Byte(ToHash.Length - 1) {}
        encode = Encoding.UTF8.GetBytes(ToHash)
        hashedPassword = Convert.ToBase64String(encode)
        Return hashedPassword
    End Function

End Class
