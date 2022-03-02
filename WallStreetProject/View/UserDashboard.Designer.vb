<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserDashboard
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
        Me.MenuLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.TransferSection = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TransferPic = New System.Windows.Forms.PictureBox()
        Me.WithdrawalSection = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.WithdrawalPic = New System.Windows.Forms.PictureBox()
        Me.DepositSection = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DepositPic = New System.Windows.Forms.PictureBox()
        Me.SoldeSection = New System.Windows.Forms.Panel()
        Me.SoldePic = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MenuLayout.SuspendLayout()
        Me.TransferSection.SuspendLayout()
        CType(Me.TransferPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.WithdrawalSection.SuspendLayout()
        CType(Me.WithdrawalPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DepositSection.SuspendLayout()
        CType(Me.DepositPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SoldeSection.SuspendLayout()
        CType(Me.SoldePic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuLayout
        '
        Me.MenuLayout.ColumnCount = 2
        Me.MenuLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.MenuLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.MenuLayout.Controls.Add(Me.TransferSection, 1, 1)
        Me.MenuLayout.Controls.Add(Me.WithdrawalSection, 0, 1)
        Me.MenuLayout.Controls.Add(Me.DepositSection, 1, 0)
        Me.MenuLayout.Controls.Add(Me.SoldeSection, 0, 0)
        Me.MenuLayout.Location = New System.Drawing.Point(0, 0)
        Me.MenuLayout.Margin = New System.Windows.Forms.Padding(0)
        Me.MenuLayout.Name = "MenuLayout"
        Me.MenuLayout.RowCount = 2
        Me.MenuLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.MenuLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.MenuLayout.Size = New System.Drawing.Size(758, 329)
        Me.MenuLayout.TabIndex = 7
        '
        'TransferSection
        '
        Me.TransferSection.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.TransferSection.Controls.Add(Me.Label3)
        Me.TransferSection.Controls.Add(Me.TransferPic)
        Me.TransferSection.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TransferSection.Location = New System.Drawing.Point(384, 169)
        Me.TransferSection.Margin = New System.Windows.Forms.Padding(5)
        Me.TransferSection.Name = "TransferSection"
        Me.TransferSection.Padding = New System.Windows.Forms.Padding(7)
        Me.TransferSection.Size = New System.Drawing.Size(369, 155)
        Me.TransferSection.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(257, 7)
        Me.Label3.Margin = New System.Windows.Forms.Padding(0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 26)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Transfert"
        '
        'TransferPic
        '
        Me.TransferPic.Location = New System.Drawing.Point(10, 73)
        Me.TransferPic.Name = "TransferPic"
        Me.TransferPic.Size = New System.Drawing.Size(72, 72)
        Me.TransferPic.TabIndex = 10
        Me.TransferPic.TabStop = False
        '
        'WithdrawalSection
        '
        Me.WithdrawalSection.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.WithdrawalSection.Controls.Add(Me.Label5)
        Me.WithdrawalSection.Controls.Add(Me.WithdrawalPic)
        Me.WithdrawalSection.Cursor = System.Windows.Forms.Cursors.Hand
        Me.WithdrawalSection.Location = New System.Drawing.Point(5, 169)
        Me.WithdrawalSection.Margin = New System.Windows.Forms.Padding(5)
        Me.WithdrawalSection.Name = "WithdrawalSection"
        Me.WithdrawalSection.Padding = New System.Windows.Forms.Padding(7)
        Me.WithdrawalSection.Size = New System.Drawing.Size(369, 155)
        Me.WithdrawalSection.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(283, 7)
        Me.Label5.Margin = New System.Windows.Forms.Padding(0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 26)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Retrait"
        '
        'WithdrawalPic
        '
        Me.WithdrawalPic.Location = New System.Drawing.Point(10, 73)
        Me.WithdrawalPic.Name = "WithdrawalPic"
        Me.WithdrawalPic.Size = New System.Drawing.Size(72, 72)
        Me.WithdrawalPic.TabIndex = 9
        Me.WithdrawalPic.TabStop = False
        '
        'DepositSection
        '
        Me.DepositSection.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.DepositSection.Controls.Add(Me.Label4)
        Me.DepositSection.Controls.Add(Me.DepositPic)
        Me.DepositSection.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DepositSection.Location = New System.Drawing.Point(384, 5)
        Me.DepositSection.Margin = New System.Windows.Forms.Padding(5)
        Me.DepositSection.Name = "DepositSection"
        Me.DepositSection.Padding = New System.Windows.Forms.Padding(7)
        Me.DepositSection.Size = New System.Drawing.Size(369, 154)
        Me.DepositSection.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(289, 7)
        Me.Label4.Margin = New System.Windows.Forms.Padding(0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 26)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Dépôt"
        '
        'DepositPic
        '
        Me.DepositPic.Location = New System.Drawing.Point(10, 72)
        Me.DepositPic.Name = "DepositPic"
        Me.DepositPic.Size = New System.Drawing.Size(72, 72)
        Me.DepositPic.TabIndex = 8
        Me.DepositPic.TabStop = False
        '
        'SoldeSection
        '
        Me.SoldeSection.BackColor = System.Drawing.Color.GreenYellow
        Me.SoldeSection.Controls.Add(Me.SoldePic)
        Me.SoldeSection.Controls.Add(Me.Label2)
        Me.SoldeSection.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SoldeSection.Location = New System.Drawing.Point(5, 5)
        Me.SoldeSection.Margin = New System.Windows.Forms.Padding(5)
        Me.SoldeSection.Name = "SoldeSection"
        Me.SoldeSection.Padding = New System.Windows.Forms.Padding(7)
        Me.SoldeSection.Size = New System.Drawing.Size(369, 154)
        Me.SoldeSection.TabIndex = 2
        '
        'SoldePic
        '
        Me.SoldePic.Location = New System.Drawing.Point(10, 72)
        Me.SoldePic.Name = "SoldePic"
        Me.SoldePic.Size = New System.Drawing.Size(72, 72)
        Me.SoldePic.TabIndex = 7
        Me.SoldePic.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(292, 7)
        Me.Label2.Margin = New System.Windows.Forms.Padding(0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 26)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Solde"
        '
        'UserDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.MenuLayout)
        Me.Name = "UserDashboard"
        Me.Size = New System.Drawing.Size(758, 329)
        Me.MenuLayout.ResumeLayout(False)
        Me.TransferSection.ResumeLayout(False)
        Me.TransferSection.PerformLayout()
        CType(Me.TransferPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.WithdrawalSection.ResumeLayout(False)
        Me.WithdrawalSection.PerformLayout()
        CType(Me.WithdrawalPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DepositSection.ResumeLayout(False)
        Me.DepositSection.PerformLayout()
        CType(Me.DepositPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SoldeSection.ResumeLayout(False)
        Me.SoldeSection.PerformLayout()
        CType(Me.SoldePic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MenuLayout As TableLayoutPanel
    Friend WithEvents TransferSection As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents TransferPic As PictureBox
    Friend WithEvents WithdrawalSection As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents WithdrawalPic As PictureBox
    Friend WithEvents DepositSection As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents DepositPic As PictureBox
    Friend WithEvents SoldeSection As Panel
    Friend WithEvents SoldePic As PictureBox
    Friend WithEvents Label2 As Label
End Class
