<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminLoginScreen
    Inherits System.Windows.Forms.UserControl

    'UserControl remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.LoginErrorMessage = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.UserLoginLink = New System.Windows.Forms.LinkLabel()
        Me.AdminPasswordDisplayer = New System.Windows.Forms.CheckBox()
        Me.AdminLoginButton = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.AdminPasswordTextBox = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.AdminNameTextBox = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(465, 321)
        Me.Panel1.TabIndex = 2
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel5, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(465, 321)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.LoginErrorMessage)
        Me.Panel5.Controls.Add(Me.Panel4)
        Me.Panel5.Controls.Add(Me.AdminPasswordDisplayer)
        Me.Panel5.Controls.Add(Me.AdminLoginButton)
        Me.Panel5.Controls.Add(Me.Label3)
        Me.Panel5.Controls.Add(Me.AdminPasswordTextBox)
        Me.Panel5.Controls.Add(Me.Panel3)
        Me.Panel5.Controls.Add(Me.Label2)
        Me.Panel5.Controls.Add(Me.AdminNameTextBox)
        Me.Panel5.Controls.Add(Me.Panel2)
        Me.Panel5.Controls.Add(Me.Label1)
        Me.Panel5.Location = New System.Drawing.Point(57, 3)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(351, 304)
        Me.Panel5.TabIndex = 14
        '
        'LoginErrorMessage
        '
        Me.LoginErrorMessage.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LoginErrorMessage.ForeColor = System.Drawing.Color.Red
        Me.LoginErrorMessage.Location = New System.Drawing.Point(0, 199)
        Me.LoginErrorMessage.Name = "LoginErrorMessage"
        Me.LoginErrorMessage.Size = New System.Drawing.Size(345, 17)
        Me.LoginErrorMessage.TabIndex = 25
        Me.LoginErrorMessage.Text = "Label5"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.UserLoginLink)
        Me.Panel4.Location = New System.Drawing.Point(3, 274)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(345, 27)
        Me.Panel4.TabIndex = 22
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(95, 5)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 18)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Login as User"
        '
        'UserLoginLink
        '
        Me.UserLoginLink.ActiveLinkColor = System.Drawing.Color.MediumBlue
        Me.UserLoginLink.AutoSize = True
        Me.UserLoginLink.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.UserLoginLink.LinkColor = System.Drawing.Color.DodgerBlue
        Me.UserLoginLink.Location = New System.Drawing.Point(206, 5)
        Me.UserLoginLink.Name = "UserLoginLink"
        Me.UserLoginLink.Size = New System.Drawing.Size(47, 18)
        Me.UserLoginLink.TabIndex = 9
        Me.UserLoginLink.TabStop = True
        Me.UserLoginLink.Text = "Login"
        '
        'AdminPasswordDisplayer
        '
        Me.AdminPasswordDisplayer.AutoSize = True
        Me.AdminPasswordDisplayer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AdminPasswordDisplayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AdminPasswordDisplayer.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.AdminPasswordDisplayer.Location = New System.Drawing.Point(0, 173)
        Me.AdminPasswordDisplayer.Name = "AdminPasswordDisplayer"
        Me.AdminPasswordDisplayer.Size = New System.Drawing.Size(124, 20)
        Me.AdminPasswordDisplayer.TabIndex = 21
        Me.AdminPasswordDisplayer.Text = "Show Password"
        Me.AdminPasswordDisplayer.UseVisualStyleBackColor = True
        '
        'AdminLoginButton
        '
        Me.AdminLoginButton.BackColor = System.Drawing.Color.DodgerBlue
        Me.AdminLoginButton.FlatAppearance.BorderSize = 0
        Me.AdminLoginButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue
        Me.AdminLoginButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.AdminLoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AdminLoginButton.Font = New System.Drawing.Font("Arial", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.AdminLoginButton.ForeColor = System.Drawing.Color.White
        Me.AdminLoginButton.Location = New System.Drawing.Point(3, 224)
        Me.AdminLoginButton.Name = "AdminLoginButton"
        Me.AdminLoginButton.Size = New System.Drawing.Size(345, 44)
        Me.AdminLoginButton.TabIndex = 20
        Me.AdminLoginButton.Text = "Login"
        Me.AdminLoginButton.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(3, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 21)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Password"
        '
        'AdminPasswordTextBox
        '
        Me.AdminPasswordTextBox.BackColor = System.Drawing.Color.White
        Me.AdminPasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.AdminPasswordTextBox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.AdminPasswordTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.AdminPasswordTextBox.Location = New System.Drawing.Point(3, 145)
        Me.AdminPasswordTextBox.Name = "AdminPasswordTextBox"
        Me.AdminPasswordTextBox.Size = New System.Drawing.Size(345, 19)
        Me.AdminPasswordTextBox.TabIndex = 18
        Me.AdminPasswordTextBox.UseSystemPasswordChar = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(3, 166)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(345, 1)
        Me.Panel3.TabIndex = 17
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(3, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 21)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "AdminName"
        '
        'AdminNameTextBox
        '
        Me.AdminNameTextBox.BackColor = System.Drawing.Color.White
        Me.AdminNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.AdminNameTextBox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.AdminNameTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.AdminNameTextBox.Location = New System.Drawing.Point(3, 76)
        Me.AdminNameTextBox.MaxLength = 100
        Me.AdminNameTextBox.Name = "AdminNameTextBox"
        Me.AdminNameTextBox.Size = New System.Drawing.Size(345, 19)
        Me.AdminNameTextBox.TabIndex = 15
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(3, 97)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(345, 1)
        Me.Panel2.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(351, 36)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Login As Administrator"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AdminLoginScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Name = "AdminLoginScreen"
        Me.Size = New System.Drawing.Size(465, 321)
        Me.Panel1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents UserLoginLink As LinkLabel
    Friend WithEvents AdminPasswordDisplayer As CheckBox
    Friend WithEvents AdminLoginButton As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents AdminPasswordTextBox As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents AdminNameTextBox As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents LoginErrorMessage As Label
End Class
