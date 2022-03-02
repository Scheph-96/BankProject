<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.UserFirstName = New System.Windows.Forms.Label()
        Me.UserLastName = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.MenuContainer.SuspendLayout()
        CType(Me.LogoutPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel2.Controls.Add(Me.UserFirstName)
        Me.Panel2.Controls.Add(Me.UserLastName)
        Me.Panel2.Location = New System.Drawing.Point(13, 13)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(758, 415)
        Me.Panel2.TabIndex = 1
        '
        'MenuContainer
        '
        Me.MenuContainer.BackColor = System.Drawing.SystemColors.Control
        Me.MenuContainer.Controls.Add(Me.TableLayoutPanel1)
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
        'UserFirstName
        '
        Me.UserFirstName.AutoSize = True
        Me.UserFirstName.BackColor = System.Drawing.Color.Transparent
        Me.UserFirstName.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.UserFirstName.Location = New System.Drawing.Point(0, 22)
        Me.UserFirstName.Margin = New System.Windows.Forms.Padding(0)
        Me.UserFirstName.Name = "UserFirstName"
        Me.UserFirstName.Size = New System.Drawing.Size(74, 18)
        Me.UserFirstName.TabIndex = 4
        Me.UserFirstName.Text = "firstname"
        '
        'UserLastName
        '
        Me.UserLastName.AutoSize = True
        Me.UserLastName.BackColor = System.Drawing.Color.Transparent
        Me.UserLastName.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.UserLastName.Location = New System.Drawing.Point(0, 0)
        Me.UserLastName.Margin = New System.Windows.Forms.Padding(0)
        Me.UserLastName.Name = "UserLastName"
        Me.UserLastName.Size = New System.Drawing.Size(71, 18)
        Me.UserLastName.TabIndex = 2
        Me.UserLastName.Text = "lastname"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel8, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel7, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel6, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel5, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel4, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel3, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(758, 338)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.GreenYellow
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Location = New System.Drawing.Point(5, 5)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(5)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(7)
        Me.Panel3.Size = New System.Drawing.Size(242, 159)
        Me.Panel3.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.Panel4.Location = New System.Drawing.Point(257, 5)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(5)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Padding = New System.Windows.Forms.Padding(7)
        Me.Panel4.Size = New System.Drawing.Size(242, 159)
        Me.Panel4.TabIndex = 1
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel5.Location = New System.Drawing.Point(509, 5)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(5)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Padding = New System.Windows.Forms.Padding(7)
        Me.Panel5.Size = New System.Drawing.Size(242, 159)
        Me.Panel5.TabIndex = 1
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel6.Location = New System.Drawing.Point(509, 174)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(5)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Padding = New System.Windows.Forms.Padding(7)
        Me.Panel6.Size = New System.Drawing.Size(242, 159)
        Me.Panel6.TabIndex = 1
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.Panel7.Location = New System.Drawing.Point(257, 174)
        Me.Panel7.Margin = New System.Windows.Forms.Padding(5)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Padding = New System.Windows.Forms.Padding(7)
        Me.Panel7.Size = New System.Drawing.Size(242, 159)
        Me.Panel7.TabIndex = 1
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel8.Location = New System.Drawing.Point(5, 174)
        Me.Panel8.Margin = New System.Windows.Forms.Padding(5)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Padding = New System.Windows.Forms.Padding(7)
        Me.Panel8.Size = New System.Drawing.Size(242, 159)
        Me.Panel8.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(10, 49)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(72, 72)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
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
        Me.MenuContainer.ResumeLayout(False)
        CType(Me.LogoutPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents MenuContainer As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label6 As Label
    Friend WithEvents LogoutPic As PictureBox
    Friend WithEvents UserFirstName As Label
    Friend WithEvents UserLastName As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox1 As PictureBox
End Class
