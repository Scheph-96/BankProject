﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminDashboardScreen
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.MenuContainer = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LogoutPic = New System.Windows.Forms.PictureBox()
        Me.UserLastName = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.LogoutPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(10)
        Me.Panel1.Size = New System.Drawing.Size(784, 441)
        Me.Panel1.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.MenuContainer)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.LogoutPic)
        Me.Panel2.Controls.Add(Me.UserLastName)
        Me.Panel2.Location = New System.Drawing.Point(13, 13)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(758, 415)
        Me.Panel2.TabIndex = 1
        '
        'MenuContainer
        '
        Me.MenuContainer.BackColor = System.Drawing.SystemColors.Control
        Me.MenuContainer.Location = New System.Drawing.Point(0, 77)
        Me.MenuContainer.Margin = New System.Windows.Forms.Padding(0)
        Me.MenuContainer.Name = "MenuContainer"
        Me.MenuContainer.Size = New System.Drawing.Size(758, 338)
        Me.MenuContainer.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(599, 16)
        Me.Label6.Margin = New System.Windows.Forms.Padding(0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(102, 18)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Déconnexion"
        '
        'LogoutPic
        '
        Me.LogoutPic.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LogoutPic.Location = New System.Drawing.Point(710, 0)
        Me.LogoutPic.Margin = New System.Windows.Forms.Padding(0)
        Me.LogoutPic.Name = "LogoutPic"
        Me.LogoutPic.Size = New System.Drawing.Size(48, 48)
        Me.LogoutPic.TabIndex = 6
        Me.LogoutPic.TabStop = False
        '
        'UserLastName
        '
        Me.UserLastName.AutoSize = True
        Me.UserLastName.BackColor = System.Drawing.Color.Transparent
        Me.UserLastName.Font = New System.Drawing.Font("Arial", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.UserLastName.Location = New System.Drawing.Point(0, 9)
        Me.UserLastName.Margin = New System.Windows.Forms.Padding(0)
        Me.UserLastName.Name = "UserLastName"
        Me.UserLastName.Size = New System.Drawing.Size(206, 32)
        Me.UserLastName.TabIndex = 2
        Me.UserLastName.Text = "OMAR'S BANK"
        '
        'AdminDashboardScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Name = "AdminDashboardScreen"
        Me.Size = New System.Drawing.Size(784, 441)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.LogoutPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents MenuContainer As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents LogoutPic As PictureBox
    Friend WithEvents UserLastName As Label
End Class
