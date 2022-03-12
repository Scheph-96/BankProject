<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UserDashboardScreen
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.InterestSection = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.InterestValue = New System.Windows.Forms.Label()
        Me.UserName = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.UserLastName = New System.Windows.Forms.Label()
        Me.UserFirstName = New System.Windows.Forms.Label()
        Me.MenuContainer = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LogoutPic = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.InterestSection.SuspendLayout()
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
        Me.Panel1.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.MenuContainer)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.LogoutPic)
        Me.Panel2.Location = New System.Drawing.Point(13, 13)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(758, 415)
        Me.Panel2.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.InterestSection)
        Me.Panel3.Controls.Add(Me.UserName)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.UserLastName)
        Me.Panel3.Controls.Add(Me.UserFirstName)
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(510, 86)
        Me.Panel3.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(0, 42)
        Me.Label3.Margin = New System.Windows.Forms.Padding(0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(132, 18)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Nom d'utilisateur:"
        '
        'InterestSection
        '
        Me.InterestSection.Controls.Add(Me.Label2)
        Me.InterestSection.Controls.Add(Me.InterestValue)
        Me.InterestSection.Location = New System.Drawing.Point(0, 62)
        Me.InterestSection.Margin = New System.Windows.Forms.Padding(0)
        Me.InterestSection.Name = "InterestSection"
        Me.InterestSection.Size = New System.Drawing.Size(176, 23)
        Me.InterestSection.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Margin = New System.Windows.Forms.Padding(0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 18)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Taux d'intérêt:"
        '
        'InterestValue
        '
        Me.InterestValue.AutoSize = True
        Me.InterestValue.BackColor = System.Drawing.Color.Transparent
        Me.InterestValue.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.InterestValue.Location = New System.Drawing.Point(110, 0)
        Me.InterestValue.Margin = New System.Windows.Forms.Padding(0)
        Me.InterestValue.Name = "InterestValue"
        Me.InterestValue.Size = New System.Drawing.Size(28, 18)
        Me.InterestValue.TabIndex = 11
        Me.InterestValue.Text = "0.1"
        '
        'UserName
        '
        Me.UserName.AutoSize = True
        Me.UserName.BackColor = System.Drawing.Color.Transparent
        Me.UserName.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.UserName.Location = New System.Drawing.Point(132, 42)
        Me.UserName.Margin = New System.Windows.Forms.Padding(0)
        Me.UserName.Name = "UserName"
        Me.UserName.Size = New System.Drawing.Size(80, 18)
        Me.UserName.TabIndex = 9
        Me.UserName.Text = "Username"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(0, 22)
        Me.Label4.Margin = New System.Windows.Forms.Padding(0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 18)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Prénoms:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(0, 3)
        Me.Label5.Margin = New System.Windows.Forms.Padding(0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 18)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Nom:"
        '
        'UserLastName
        '
        Me.UserLastName.AutoSize = True
        Me.UserLastName.BackColor = System.Drawing.Color.Transparent
        Me.UserLastName.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.UserLastName.Location = New System.Drawing.Point(44, 3)
        Me.UserLastName.Margin = New System.Windows.Forms.Padding(0)
        Me.UserLastName.Name = "UserLastName"
        Me.UserLastName.Size = New System.Drawing.Size(71, 18)
        Me.UserLastName.TabIndex = 2
        Me.UserLastName.Text = "lastname"
        '
        'UserFirstName
        '
        Me.UserFirstName.AutoSize = True
        Me.UserFirstName.BackColor = System.Drawing.Color.Transparent
        Me.UserFirstName.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.UserFirstName.Location = New System.Drawing.Point(75, 22)
        Me.UserFirstName.Margin = New System.Windows.Forms.Padding(0)
        Me.UserFirstName.Name = "UserFirstName"
        Me.UserFirstName.Size = New System.Drawing.Size(74, 18)
        Me.UserFirstName.TabIndex = 4
        Me.UserFirstName.Text = "firstname"
        '
        'MenuContainer
        '
        Me.MenuContainer.BackColor = System.Drawing.SystemColors.Control
        Me.MenuContainer.Location = New System.Drawing.Point(0, 86)
        Me.MenuContainer.Margin = New System.Windows.Forms.Padding(0)
        Me.MenuContainer.Name = "MenuContainer"
        Me.MenuContainer.Size = New System.Drawing.Size(758, 329)
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
        'UserDashboardScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Name = "UserDashboardScreen"
        Me.Size = New System.Drawing.Size(784, 441)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.InterestSection.ResumeLayout(False)
        Me.InterestSection.PerformLayout()
        CType(Me.LogoutPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents UserFirstName As Label
    Friend WithEvents UserLastName As Label
    Friend WithEvents LogoutPic As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents MenuContainer As Panel
    Friend WithEvents InterestValue As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents UserName As Label
    Friend WithEvents InterestSection As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
