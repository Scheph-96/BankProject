<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AccountEditionScreen
    Inherits System.Windows.Forms.UserControl

    'UserControl remplace la méthode Dispose pour nettoyer la liste des composants.
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.UserPasswordDisplayer = New System.Windows.Forms.CheckBox()
        Me.ConfirmUsernameUpdate = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.UserPassword = New System.Windows.Forms.TextBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.NewUsername = New System.Windows.Forms.TextBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.OldPasswordDisplayer = New System.Windows.Forms.CheckBox()
        Me.NewPasswordDisplayer = New System.Windows.Forms.CheckBox()
        Me.ConfirmPasswordUpdate = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.NewPassword = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.OldPassword = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BackPic = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.BackPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.Panel4, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.BackPic, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.Padding = New System.Windows.Forms.Padding(0, 0, 100, 0)
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(758, 329)
        Me.TableLayoutPanel1.TabIndex = 5
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.UserPasswordDisplayer)
        Me.Panel4.Controls.Add(Me.ConfirmUsernameUpdate)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.UserPassword)
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.NewUsername)
        Me.Panel4.Controls.Add(Me.Panel6)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Location = New System.Drawing.Point(64, 6)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(6)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(336, 317)
        Me.Panel4.TabIndex = 3
        '
        'UserPasswordDisplayer
        '
        Me.UserPasswordDisplayer.AutoSize = True
        Me.UserPasswordDisplayer.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.UserPasswordDisplayer.Location = New System.Drawing.Point(0, 196)
        Me.UserPasswordDisplayer.Name = "UserPasswordDisplayer"
        Me.UserPasswordDisplayer.Size = New System.Drawing.Size(195, 22)
        Me.UserPasswordDisplayer.TabIndex = 8
        Me.UserPasswordDisplayer.Text = "Afficher le mot de passe"
        Me.UserPasswordDisplayer.UseVisualStyleBackColor = True
        '
        'ConfirmUsernameUpdate
        '
        Me.ConfirmUsernameUpdate.BackColor = System.Drawing.Color.Maroon
        Me.ConfirmUsernameUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ConfirmUsernameUpdate.FlatAppearance.BorderSize = 0
        Me.ConfirmUsernameUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ConfirmUsernameUpdate.Font = New System.Drawing.Font("Arial", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ConfirmUsernameUpdate.ForeColor = System.Drawing.Color.White
        Me.ConfirmUsernameUpdate.Location = New System.Drawing.Point(0, 244)
        Me.ConfirmUsernameUpdate.Name = "ConfirmUsernameUpdate"
        Me.ConfirmUsernameUpdate.Size = New System.Drawing.Size(336, 45)
        Me.ConfirmUsernameUpdate.TabIndex = 7
        Me.ConfirmUsernameUpdate.Text = "Confirmer"
        Me.ConfirmUsernameUpdate.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(0, 128)
        Me.Label4.Margin = New System.Windows.Forms.Padding(0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 21)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Mot de passe"
        '
        'UserPassword
        '
        Me.UserPassword.BackColor = System.Drawing.SystemColors.Control
        Me.UserPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.UserPassword.Font = New System.Drawing.Font("Arial", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.UserPassword.Location = New System.Drawing.Point(0, 153)
        Me.UserPassword.Margin = New System.Windows.Forms.Padding(0)
        Me.UserPassword.Name = "UserPassword"
        Me.UserPassword.Size = New System.Drawing.Size(336, 20)
        Me.UserPassword.TabIndex = 5
        Me.UserPassword.UseSystemPasswordChar = True
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Black
        Me.Panel5.Location = New System.Drawing.Point(0, 173)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(336, 1)
        Me.Panel5.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(0, 62)
        Me.Label5.Margin = New System.Windows.Forms.Padding(0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(216, 21)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Nouveau nom d'utilisateur"
        '
        'NewUsername
        '
        Me.NewUsername.BackColor = System.Drawing.SystemColors.Control
        Me.NewUsername.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.NewUsername.Font = New System.Drawing.Font("Arial", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.NewUsername.Location = New System.Drawing.Point(0, 87)
        Me.NewUsername.Margin = New System.Windows.Forms.Padding(0)
        Me.NewUsername.Name = "NewUsername"
        Me.NewUsername.Size = New System.Drawing.Size(336, 20)
        Me.NewUsername.TabIndex = 2
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Black
        Me.Panel6.Location = New System.Drawing.Point(0, 107)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(336, 1)
        Me.Panel6.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label6.Font = New System.Drawing.Font("Arial", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(0, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(336, 32)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Modifier nom d'utilisateur"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.OldPasswordDisplayer)
        Me.Panel1.Controls.Add(Me.NewPasswordDisplayer)
        Me.Panel1.Controls.Add(Me.ConfirmPasswordUpdate)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.NewPassword)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.OldPassword)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(412, 6)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(336, 317)
        Me.Panel1.TabIndex = 2
        '
        'OldPasswordDisplayer
        '
        Me.OldPasswordDisplayer.AutoSize = True
        Me.OldPasswordDisplayer.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.OldPasswordDisplayer.Location = New System.Drawing.Point(0, 111)
        Me.OldPasswordDisplayer.Name = "OldPasswordDisplayer"
        Me.OldPasswordDisplayer.Size = New System.Drawing.Size(195, 22)
        Me.OldPasswordDisplayer.TabIndex = 9
        Me.OldPasswordDisplayer.Text = "Afficher le mot de passe"
        Me.OldPasswordDisplayer.UseVisualStyleBackColor = True
        '
        'NewPasswordDisplayer
        '
        Me.NewPasswordDisplayer.AutoSize = True
        Me.NewPasswordDisplayer.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.NewPasswordDisplayer.Location = New System.Drawing.Point(0, 208)
        Me.NewPasswordDisplayer.Name = "NewPasswordDisplayer"
        Me.NewPasswordDisplayer.Size = New System.Drawing.Size(195, 22)
        Me.NewPasswordDisplayer.TabIndex = 8
        Me.NewPasswordDisplayer.Text = "Afficher le mot de passe"
        Me.NewPasswordDisplayer.UseVisualStyleBackColor = True
        '
        'ConfirmPasswordUpdate
        '
        Me.ConfirmPasswordUpdate.BackColor = System.Drawing.Color.OliveDrab
        Me.ConfirmPasswordUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ConfirmPasswordUpdate.FlatAppearance.BorderSize = 0
        Me.ConfirmPasswordUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ConfirmPasswordUpdate.Font = New System.Drawing.Font("Arial", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ConfirmPasswordUpdate.ForeColor = System.Drawing.Color.White
        Me.ConfirmPasswordUpdate.Location = New System.Drawing.Point(0, 244)
        Me.ConfirmPasswordUpdate.Name = "ConfirmPasswordUpdate"
        Me.ConfirmPasswordUpdate.Size = New System.Drawing.Size(336, 45)
        Me.ConfirmPasswordUpdate.TabIndex = 7
        Me.ConfirmPasswordUpdate.Text = "Confirmer"
        Me.ConfirmPasswordUpdate.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(0, 156)
        Me.Label3.Margin = New System.Windows.Forms.Padding(0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(194, 21)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Nouveau mot de passe"
        '
        'NewPassword
        '
        Me.NewPassword.BackColor = System.Drawing.SystemColors.Control
        Me.NewPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.NewPassword.Font = New System.Drawing.Font("Arial", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.NewPassword.Location = New System.Drawing.Point(0, 181)
        Me.NewPassword.Margin = New System.Windows.Forms.Padding(0)
        Me.NewPassword.Name = "NewPassword"
        Me.NewPassword.Size = New System.Drawing.Size(336, 20)
        Me.NewPassword.TabIndex = 5
        Me.NewPassword.UseSystemPasswordChar = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Black
        Me.Panel3.Location = New System.Drawing.Point(0, 201)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(336, 1)
        Me.Panel3.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(0, 62)
        Me.Label2.Margin = New System.Windows.Forms.Padding(0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(176, 21)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Ancien mot de passe"
        '
        'OldPassword
        '
        Me.OldPassword.BackColor = System.Drawing.SystemColors.Control
        Me.OldPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.OldPassword.Font = New System.Drawing.Font("Arial", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.OldPassword.Location = New System.Drawing.Point(0, 87)
        Me.OldPassword.Margin = New System.Windows.Forms.Padding(0)
        Me.OldPassword.Name = "OldPassword"
        Me.OldPassword.Size = New System.Drawing.Size(336, 20)
        Me.OldPassword.TabIndex = 2
        Me.OldPassword.UseSystemPasswordChar = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Black
        Me.Panel2.Location = New System.Drawing.Point(0, 107)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(336, 1)
        Me.Panel2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Arial", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(336, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Modifier mot de passe"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BackPic
        '
        Me.BackPic.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BackPic.Location = New System.Drawing.Point(0, 0)
        Me.BackPic.Margin = New System.Windows.Forms.Padding(0, 0, 10, 0)
        Me.BackPic.Name = "BackPic"
        Me.BackPic.Size = New System.Drawing.Size(48, 48)
        Me.BackPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BackPic.TabIndex = 1
        Me.BackPic.TabStop = False
        '
        'AccountEditionScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "AccountEditionScreen"
        Me.Size = New System.Drawing.Size(758, 329)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.BackPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents UserPasswordDisplayer As CheckBox
    Friend WithEvents ConfirmUsernameUpdate As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents UserPassword As TextBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents NewUsername As TextBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents OldPasswordDisplayer As CheckBox
    Friend WithEvents NewPasswordDisplayer As CheckBox
    Friend WithEvents ConfirmPasswordUpdate As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents NewPassword As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents OldPassword As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents BackPic As PictureBox
End Class
