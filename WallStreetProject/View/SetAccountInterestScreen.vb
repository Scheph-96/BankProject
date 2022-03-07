﻿Public Class SetAccountInterestScreen
    Private Sub SetAccountInterestScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BackPic.Image = WallStreetProject.My.Resources.back_ico3
    End Sub

    Private Sub PasswordDisplayer_CheckedChanged(sender As Object, e As EventArgs) Handles PasswordDisplayer.CheckedChanged
        If PasswordDisplayer.Checked Then
            AdminPassword.UseSystemPasswordChar = False
        Else
            AdminPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub BackPic_Click(sender As Object, e As EventArgs) Handles BackPic.Click
        Dim dashboard As New AdminDashboard
        Parent.Controls.Add(dashboard)
        Me.Dispose()
    End Sub

    Private Sub ConfirmSetting_Click(sender As Object, e As EventArgs) Handles ConfirmSetting.Click
        Dim controller As New Controller
        Dim msg As String
        If AccountNumber.Text = "" Or NewInterest.Text = "" Or AdminPassword.Text = "" Then
            MessageBox.Show("Veuillez renseigner tous les champs")
        Else
            msg = controller.setInterest(AccountNumber.Text, Convert.ToDouble(NewInterest.Text.Replace(".", ",")), AdminPassword.Text)
            MessageBox.Show(msg)
        End If
    End Sub

    Private Sub AccountNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles AccountNumber.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "1234567890." 'allowed In textbox
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                'e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub NewInterest_KeyPress(sender As Object, e As KeyPressEventArgs) Handles NewInterest.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "1234567890." 'allowed In textbox
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                'e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub
End Class
