<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateAccountScreen
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.SavingAccountRadioBtn = New System.Windows.Forms.RadioButton()
        Me.CheckingAccountRadioBtn = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CustomerPhoneNumber = New System.Windows.Forms.TextBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CustomerFirstName = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.ConfirmAccountCreation = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CustomerLastName = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BackPic = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.BackPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.BackPic, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(758, 338)
        Me.TableLayoutPanel1.TabIndex = 4
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.CustomerPhoneNumber)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.CustomerFirstName)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.ConfirmAccountCreation)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.CustomerLastName)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(211, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(336, 338)
        Me.Panel1.TabIndex = 2
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.SavingAccountRadioBtn)
        Me.Panel3.Controls.Add(Me.CheckingAccountRadioBtn)
        Me.Panel3.Location = New System.Drawing.Point(44, 229)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(251, 40)
        Me.Panel3.TabIndex = 18
        '
        'SavingAccountRadioBtn
        '
        Me.SavingAccountRadioBtn.AutoSize = True
        Me.SavingAccountRadioBtn.Font = New System.Drawing.Font("Arial", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.SavingAccountRadioBtn.Location = New System.Drawing.Point(151, 10)
        Me.SavingAccountRadioBtn.Name = "SavingAccountRadioBtn"
        Me.SavingAccountRadioBtn.Size = New System.Drawing.Size(96, 25)
        Me.SavingAccountRadioBtn.TabIndex = 16
        Me.SavingAccountRadioBtn.TabStop = True
        Me.SavingAccountRadioBtn.Text = "Epargne"
        Me.SavingAccountRadioBtn.UseVisualStyleBackColor = True
        '
        'CheckingAccountRadioBtn
        '
        Me.CheckingAccountRadioBtn.AutoSize = True
        Me.CheckingAccountRadioBtn.Font = New System.Drawing.Font("Arial", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CheckingAccountRadioBtn.Location = New System.Drawing.Point(3, 10)
        Me.CheckingAccountRadioBtn.Name = "CheckingAccountRadioBtn"
        Me.CheckingAccountRadioBtn.Size = New System.Drawing.Size(92, 25)
        Me.CheckingAccountRadioBtn.TabIndex = 15
        Me.CheckingAccountRadioBtn.TabStop = True
        Me.CheckingAccountRadioBtn.Text = "Courant"
        Me.CheckingAccountRadioBtn.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(0, 205)
        Me.Label3.Margin = New System.Windows.Forms.Padding(0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(138, 21)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Type de compte"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(1, 147)
        Me.Label5.Margin = New System.Windows.Forms.Padding(0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(182, 21)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Numéro de téléphone"
        '
        'CustomerPhoneNumber
        '
        Me.CustomerPhoneNumber.BackColor = System.Drawing.SystemColors.Control
        Me.CustomerPhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CustomerPhoneNumber.Font = New System.Drawing.Font("Arial", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CustomerPhoneNumber.Location = New System.Drawing.Point(1, 172)
        Me.CustomerPhoneNumber.Margin = New System.Windows.Forms.Padding(0)
        Me.CustomerPhoneNumber.Name = "CustomerPhoneNumber"
        Me.CustomerPhoneNumber.Size = New System.Drawing.Size(336, 20)
        Me.CustomerPhoneNumber.TabIndex = 13
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Black
        Me.Panel5.Location = New System.Drawing.Point(1, 192)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(336, 1)
        Me.Panel5.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(1, 92)
        Me.Label4.Margin = New System.Windows.Forms.Padding(0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 21)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Prénoms"
        '
        'CustomerFirstName
        '
        Me.CustomerFirstName.BackColor = System.Drawing.SystemColors.Control
        Me.CustomerFirstName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CustomerFirstName.Font = New System.Drawing.Font("Arial", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CustomerFirstName.Location = New System.Drawing.Point(1, 117)
        Me.CustomerFirstName.Margin = New System.Windows.Forms.Padding(0)
        Me.CustomerFirstName.Name = "CustomerFirstName"
        Me.CustomerFirstName.Size = New System.Drawing.Size(336, 20)
        Me.CustomerFirstName.TabIndex = 10
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Black
        Me.Panel4.Location = New System.Drawing.Point(1, 137)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(336, 1)
        Me.Panel4.TabIndex = 9
        '
        'ConfirmAccountCreation
        '
        Me.ConfirmAccountCreation.BackColor = System.Drawing.Color.DodgerBlue
        Me.ConfirmAccountCreation.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ConfirmAccountCreation.FlatAppearance.BorderSize = 0
        Me.ConfirmAccountCreation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ConfirmAccountCreation.Font = New System.Drawing.Font("Arial", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ConfirmAccountCreation.ForeColor = System.Drawing.Color.White
        Me.ConfirmAccountCreation.Location = New System.Drawing.Point(0, 281)
        Me.ConfirmAccountCreation.Name = "ConfirmAccountCreation"
        Me.ConfirmAccountCreation.Size = New System.Drawing.Size(336, 45)
        Me.ConfirmAccountCreation.TabIndex = 7
        Me.ConfirmAccountCreation.Text = "Confirmer"
        Me.ConfirmAccountCreation.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(0, 37)
        Me.Label2.Margin = New System.Windows.Forms.Padding(0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 21)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nom"
        '
        'CustomerLastName
        '
        Me.CustomerLastName.BackColor = System.Drawing.SystemColors.Control
        Me.CustomerLastName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CustomerLastName.Font = New System.Drawing.Font("Arial", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CustomerLastName.Location = New System.Drawing.Point(0, 62)
        Me.CustomerLastName.Margin = New System.Windows.Forms.Padding(0)
        Me.CustomerLastName.Name = "CustomerLastName"
        Me.CustomerLastName.Size = New System.Drawing.Size(336, 20)
        Me.CustomerLastName.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Black
        Me.Panel2.Location = New System.Drawing.Point(0, 82)
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
        Me.Label1.Text = "Créer un nouveau compte"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BackPic
        '
        Me.BackPic.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BackPic.Location = New System.Drawing.Point(0, 0)
        Me.BackPic.Margin = New System.Windows.Forms.Padding(0)
        Me.BackPic.Name = "BackPic"
        Me.BackPic.Size = New System.Drawing.Size(48, 48)
        Me.BackPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BackPic.TabIndex = 1
        Me.BackPic.TabStop = False
        '
        'CreateAccountScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "CreateAccountScreen"
        Me.Size = New System.Drawing.Size(758, 338)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.BackPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents CustomerFirstName As TextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents ConfirmAccountCreation As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents CustomerLastName As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents BackPic As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents CustomerPhoneNumber As TextBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents SavingAccountRadioBtn As RadioButton
    Friend WithEvents CheckingAccountRadioBtn As RadioButton
    Friend WithEvents Label3 As Label
End Class
