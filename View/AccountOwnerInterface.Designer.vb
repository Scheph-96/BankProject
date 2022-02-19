<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AccountOwnerInterface
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.accountInteret = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.logoutButton = New System.Windows.Forms.Button()
        Me.setPasswordButton = New System.Windows.Forms.Button()
        Me.withdrawButton = New System.Windows.Forms.Button()
        Me.addButton = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.accountSolde = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.accountType = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.ownerName = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.accountNumber = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Panel7)
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(704, 441)
        Me.Panel1.TabIndex = 0
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.Label2)
        Me.Panel7.Controls.Add(Me.accountInteret)
        Me.Panel7.Location = New System.Drawing.Point(414, 157)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(275, 43)
        Me.Panel7.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(3, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(170, 32)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Taux d'intérêt:"
        '
        'accountInteret
        '
        Me.accountInteret.AutoSize = True
        Me.accountInteret.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.accountInteret.ForeColor = System.Drawing.Color.Black
        Me.accountInteret.Location = New System.Drawing.Point(179, 6)
        Me.accountInteret.Name = "accountInteret"
        Me.accountInteret.Size = New System.Drawing.Size(63, 32)
        Me.accountInteret.TabIndex = 2
        Me.accountInteret.Text = "0.1%"
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.logoutButton)
        Me.Panel6.Controls.Add(Me.setPasswordButton)
        Me.Panel6.Controls.Add(Me.withdrawButton)
        Me.Panel6.Controls.Add(Me.addButton)
        Me.Panel6.Location = New System.Drawing.Point(12, 263)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(680, 166)
        Me.Panel6.TabIndex = 11
        '
        'logoutButton
        '
        Me.logoutButton.BackColor = System.Drawing.Color.Silver
        Me.logoutButton.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.logoutButton.Location = New System.Drawing.Point(212, 120)
        Me.logoutButton.Name = "logoutButton"
        Me.logoutButton.Size = New System.Drawing.Size(260, 43)
        Me.logoutButton.TabIndex = 3
        Me.logoutButton.Text = "Déconnexion"
        Me.logoutButton.UseVisualStyleBackColor = False
        '
        'setPasswordButton
        '
        Me.setPasswordButton.BackColor = System.Drawing.Color.Silver
        Me.setPasswordButton.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.setPasswordButton.Location = New System.Drawing.Point(212, 3)
        Me.setPasswordButton.Name = "setPasswordButton"
        Me.setPasswordButton.Size = New System.Drawing.Size(260, 43)
        Me.setPasswordButton.TabIndex = 2
        Me.setPasswordButton.Text = "Modifier mot de passe"
        Me.setPasswordButton.UseVisualStyleBackColor = False
        '
        'withdrawButton
        '
        Me.withdrawButton.BackColor = System.Drawing.Color.Silver
        Me.withdrawButton.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.withdrawButton.Location = New System.Drawing.Point(538, 66)
        Me.withdrawButton.Name = "withdrawButton"
        Me.withdrawButton.Size = New System.Drawing.Size(139, 43)
        Me.withdrawButton.TabIndex = 1
        Me.withdrawButton.Text = "Retrait"
        Me.withdrawButton.UseVisualStyleBackColor = False
        '
        'addButton
        '
        Me.addButton.BackColor = System.Drawing.Color.Silver
        Me.addButton.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.addButton.Location = New System.Drawing.Point(3, 66)
        Me.addButton.Name = "addButton"
        Me.addButton.Size = New System.Drawing.Size(139, 43)
        Me.addButton.TabIndex = 0
        Me.addButton.Text = "Créditer"
        Me.addButton.UseVisualStyleBackColor = False
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.accountSolde)
        Me.Panel5.Controls.Add(Me.Label5)
        Me.Panel5.Location = New System.Drawing.Point(12, 86)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(328, 43)
        Me.Panel5.TabIndex = 11
        '
        'accountSolde
        '
        Me.accountSolde.AutoSize = True
        Me.accountSolde.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.accountSolde.ForeColor = System.Drawing.Color.Black
        Me.accountSolde.Location = New System.Drawing.Point(89, 6)
        Me.accountSolde.Name = "accountSolde"
        Me.accountSolde.Size = New System.Drawing.Size(79, 32)
        Me.accountSolde.TabIndex = 6
        Me.accountSolde.Text = "20000"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(3, 6)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 32)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Solde:"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.accountType)
        Me.Panel4.Location = New System.Drawing.Point(12, 157)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(278, 43)
        Me.Panel4.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(3, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 32)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Type:"
        '
        'accountType
        '
        Me.accountType.AutoSize = True
        Me.accountType.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.accountType.ForeColor = System.Drawing.Color.Black
        Me.accountType.Location = New System.Drawing.Point(80, 6)
        Me.accountType.Name = "accountType"
        Me.accountType.Size = New System.Drawing.Size(102, 32)
        Me.accountType.TabIndex = 2
        Me.accountType.Text = "Courant"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.ownerName)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Location = New System.Drawing.Point(12, 12)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(459, 43)
        Me.Panel3.TabIndex = 10
        '
        'ownerName
        '
        Me.ownerName.AutoSize = True
        Me.ownerName.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ownerName.ForeColor = System.Drawing.Color.Black
        Me.ownerName.Location = New System.Drawing.Point(82, 6)
        Me.ownerName.Name = "ownerName"
        Me.ownerName.Size = New System.Drawing.Size(258, 32)
        Me.ownerName.TabIndex = 7
        Me.ownerName.Text = "Humberto Al-Chatone"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(3, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nom:"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.accountNumber)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Location = New System.Drawing.Point(414, 86)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(278, 43)
        Me.Panel2.TabIndex = 9
        '
        'accountNumber
        '
        Me.accountNumber.AutoSize = True
        Me.accountNumber.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.accountNumber.ForeColor = System.Drawing.Color.Black
        Me.accountNumber.Location = New System.Drawing.Point(116, 6)
        Me.accountNumber.Name = "accountNumber"
        Me.accountNumber.Size = New System.Drawing.Size(141, 32)
        Me.accountNumber.TabIndex = 8
        Me.accountNumber.Text = "1232323980"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(1, 6)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(109, 32)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Numéro:"
        '
        'AccountOwnerInterface
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(704, 441)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "AccountOwnerInterface"
        Me.Text = "AccountOwnerInterface"
        Me.Panel1.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents addButton As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents accountSolde As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents accountType As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents ownerName As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents accountNumber As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents setPasswordButton As Button
    Friend WithEvents withdrawButton As Button
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents accountInteret As Label
    Friend WithEvents logoutButton As Button
End Class
