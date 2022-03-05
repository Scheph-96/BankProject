Imports System.IO
Imports System.IO.File

Public Class SplashScreen
    Private controller As New Controller()
    Private loadingCount As Integer
    Private myBanque As New Bank()
    Private userLogin As New LoginScreen()

    Private Sub SplashScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SplashScreenImage.Image = WallStreetProject.My.Resources.piggy
        Timer1.Enabled = True
        If Not File.Exists("P:\Source-Code\Git\BankProject\WallStreetProject\Project\Data\data.json") Then
            Dim myBanque As New Bank("Omar'sBank", "Somewhere 12", 90000000)
            controller.WriteInFile(myBanque)
        End If
        Me.CenterToScreen()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        loadingCount += 2

        If loadingCount = 20 Then
            myBanque = controller.ReadFile()
        ElseIf loadingCount = 70 Then
            Debug.WriteLine("In SplashScreen")
            Debug.WriteLine(myBanque.BankName)
            Debug.WriteLine(myBanque.BankAddress)
            Debug.WriteLine(myBanque.BankPhoneNumber)
            userLogin.Bank = myBanque
            Me.Dispose()
            userLogin.ShowDialog()
        End If
    End Sub
End Class