﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.ConfirmWithdraw = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.WithdrawAmount = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BackPic = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
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
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.TextBox2)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.ConfirmWithdraw)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.WithdrawAmount)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(211, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(336, 338)
        Me.Panel1.TabIndex = 2
        '
        'ConfirmWithdraw
        '
        Me.ConfirmWithdraw.BackColor = System.Drawing.Color.DodgerBlue
        Me.ConfirmWithdraw.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ConfirmWithdraw.FlatAppearance.BorderSize = 0
        Me.ConfirmWithdraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ConfirmWithdraw.Font = New System.Drawing.Font("Arial", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ConfirmWithdraw.ForeColor = System.Drawing.Color.White
        Me.ConfirmWithdraw.Location = New System.Drawing.Point(0, 267)
        Me.ConfirmWithdraw.Name = "ConfirmWithdraw"
        Me.ConfirmWithdraw.Size = New System.Drawing.Size(336, 45)
        Me.ConfirmWithdraw.TabIndex = 7
        Me.ConfirmWithdraw.Text = "Confirmer"
        Me.ConfirmWithdraw.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(3, 53)
        Me.Label2.Margin = New System.Windows.Forms.Padding(0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 21)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nom"
        '
        'WithdrawAmount
        '
        Me.WithdrawAmount.BackColor = System.Drawing.SystemColors.Control
        Me.WithdrawAmount.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WithdrawAmount.Font = New System.Drawing.Font("Arial", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.WithdrawAmount.Location = New System.Drawing.Point(3, 78)
        Me.WithdrawAmount.Margin = New System.Windows.Forms.Padding(0)
        Me.WithdrawAmount.Name = "WithdrawAmount"
        Me.WithdrawAmount.Size = New System.Drawing.Size(336, 20)
        Me.WithdrawAmount.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Black
        Me.Panel2.Location = New System.Drawing.Point(3, 98)
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
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(0, 125)
        Me.Label4.Margin = New System.Windows.Forms.Padding(0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 21)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Prénoms"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Arial", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextBox1.Location = New System.Drawing.Point(0, 150)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(336, 20)
        Me.TextBox1.TabIndex = 10
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Black
        Me.Panel4.Location = New System.Drawing.Point(0, 170)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(336, 1)
        Me.Panel4.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(0, 202)
        Me.Label5.Margin = New System.Windows.Forms.Padding(0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(182, 21)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Numéro de téléphone"
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Font = New System.Drawing.Font("Arial", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextBox2.Location = New System.Drawing.Point(0, 227)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(0)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(336, 20)
        Me.TextBox2.TabIndex = 13
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Black
        Me.Panel5.Location = New System.Drawing.Point(0, 247)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(336, 1)
        Me.Panel5.TabIndex = 12
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
        CType(Me.BackPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents ConfirmWithdraw As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents WithdrawAmount As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents BackPic As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Panel5 As Panel
End Class
