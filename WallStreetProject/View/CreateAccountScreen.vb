Public Class CreateAccountScreen
    Private Sub CreateAccountScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BackPic.Image = WallStreetProject.My.Resources.back_ico3
    End Sub

    Private Sub BackPic_Click(sender As Object, e As EventArgs) Handles BackPic.Click
        Dim dashboard As New AdminDashboard
        Parent.Controls.Add(dashboard)
        Me.Dispose()
    End Sub

    Private Sub Reload()
        InitializeComponent()

    End Sub


    Private Sub ConfirmAccountCreation_Click(sender As Object, e As EventArgs) Handles ConfirmAccountCreation.Click
        Dim controller As New Controller()

        'If CheckingAccountRadioBtn.Checked Then
        '    MessageBox.Show("checking is checked")
        'ElseIf Not CheckingAccountRadioBtn.Checked Then
        '    MessageBox.Show("Checking not checked")
        'End If
        If CustomerLastName.Text = "" Or CustomerFirstName.Text = "" Or CustomerPhoneNumber.Text = "" Then
            MessageBox.Show("Veuillez renseigner tous les champs")
        Else
            If CheckingAccountRadioBtn.Checked Then
                controller.createAccount(CustomerLastName.Text, CustomerFirstName.Text, CustomerPhoneNumber.Text, AccountsType.Checking)
                MessageBox.Show("Compte créé avec succès")
            ElseIf SavingAccountRadioBtn.Checked Then
                controller.createAccount(CustomerLastName.Text, CustomerFirstName.Text, CustomerPhoneNumber.Text, AccountsType.Savings)
                MessageBox.Show("Compte créé avec succès")
            Else
                MessageBox.Show("Choisissez un type de compte")
            End If
        End If



    End Sub
End Class
