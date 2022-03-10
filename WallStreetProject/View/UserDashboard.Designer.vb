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
        Me.TransactionSection = New System.Windows.Forms.Panel()
        Me.FlowLayoutPanel6 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.EditionSection = New System.Windows.Forms.Panel()
        Me.FlowLayoutPanel5 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.EditPic = New System.Windows.Forms.PictureBox()
        Me.TransferSection = New System.Windows.Forms.Panel()
        Me.FlowLayoutPanel4 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TransferPic = New System.Windows.Forms.PictureBox()
        Me.WithdrawalSection = New System.Windows.Forms.Panel()
        Me.FlowLayoutPanel3 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.WithdrawalPic = New System.Windows.Forms.PictureBox()
        Me.DepositSection = New System.Windows.Forms.Panel()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DepositPic = New System.Windows.Forms.PictureBox()
        Me.SoldeSection = New System.Windows.Forms.Panel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SoldePic = New System.Windows.Forms.PictureBox()
        Me.TransactionsPic = New System.Windows.Forms.PictureBox()
        Me.MenuLayout.SuspendLayout()
        Me.TransactionSection.SuspendLayout()
        Me.FlowLayoutPanel6.SuspendLayout()
        Me.EditionSection.SuspendLayout()
        Me.FlowLayoutPanel5.SuspendLayout()
        CType(Me.EditPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TransferSection.SuspendLayout()
        Me.FlowLayoutPanel4.SuspendLayout()
        CType(Me.TransferPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.WithdrawalSection.SuspendLayout()
        Me.FlowLayoutPanel3.SuspendLayout()
        CType(Me.WithdrawalPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DepositSection.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        CType(Me.DepositPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SoldeSection.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.SoldePic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransactionsPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuLayout
        '
        Me.MenuLayout.ColumnCount = 3
        Me.MenuLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.MenuLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.MenuLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.MenuLayout.Controls.Add(Me.TransactionSection, 2, 0)
        Me.MenuLayout.Controls.Add(Me.EditionSection, 2, 1)
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
        'TransactionSection
        '
        Me.TransactionSection.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TransactionSection.Controls.Add(Me.TransactionsPic)
        Me.TransactionSection.Controls.Add(Me.FlowLayoutPanel6)
        Me.TransactionSection.Controls.Add(Me.Label12)
        Me.TransactionSection.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TransactionSection.Location = New System.Drawing.Point(509, 5)
        Me.TransactionSection.Margin = New System.Windows.Forms.Padding(5)
        Me.TransactionSection.Name = "TransactionSection"
        Me.TransactionSection.Padding = New System.Windows.Forms.Padding(7)
        Me.TransactionSection.Size = New System.Drawing.Size(242, 154)
        Me.TransactionSection.TabIndex = 12
        '
        'FlowLayoutPanel6
        '
        Me.FlowLayoutPanel6.Controls.Add(Me.Label11)
        Me.FlowLayoutPanel6.Location = New System.Drawing.Point(88, 10)
        Me.FlowLayoutPanel6.Name = "FlowLayoutPanel6"
        Me.FlowLayoutPanel6.Size = New System.Drawing.Size(144, 78)
        Me.FlowLayoutPanel6.TabIndex = 11
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Arial", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(0, 0)
        Me.Label11.Margin = New System.Windows.Forms.Padding(0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(138, 52)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "Liste des transactions"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Arial", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(10, 121)
        Me.Label12.Margin = New System.Windows.Forms.Padding(0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(133, 26)
        Me.Label12.TabIndex = 10
        Me.Label12.Text = "Transaction"
        '
        'EditionSection
        '
        Me.EditionSection.BackColor = System.Drawing.Color.OliveDrab
        Me.EditionSection.Controls.Add(Me.FlowLayoutPanel5)
        Me.EditionSection.Controls.Add(Me.Label10)
        Me.EditionSection.Controls.Add(Me.EditPic)
        Me.EditionSection.Cursor = System.Windows.Forms.Cursors.Hand
        Me.EditionSection.Location = New System.Drawing.Point(509, 169)
        Me.EditionSection.Margin = New System.Windows.Forms.Padding(5)
        Me.EditionSection.Name = "EditionSection"
        Me.EditionSection.Padding = New System.Windows.Forms.Padding(7)
        Me.EditionSection.Size = New System.Drawing.Size(242, 155)
        Me.EditionSection.TabIndex = 13
        '
        'FlowLayoutPanel5
        '
        Me.FlowLayoutPanel5.Controls.Add(Me.Label9)
        Me.FlowLayoutPanel5.Location = New System.Drawing.Point(85, 10)
        Me.FlowLayoutPanel5.Name = "FlowLayoutPanel5"
        Me.FlowLayoutPanel5.Size = New System.Drawing.Size(147, 79)
        Me.FlowLayoutPanel5.TabIndex = 12
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Arial", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(0, 0)
        Me.Label9.Margin = New System.Windows.Forms.Padding(0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(145, 78)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Modifier les informations utlisateurs"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Arial", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(10, 122)
        Me.Label10.Margin = New System.Windows.Forms.Padding(0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(92, 26)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Modifier"
        '
        'EditPic
        '
        Me.EditPic.Location = New System.Drawing.Point(10, 36)
        Me.EditPic.Name = "EditPic"
        Me.EditPic.Size = New System.Drawing.Size(72, 72)
        Me.EditPic.TabIndex = 10
        Me.EditPic.TabStop = False
        '
        'TransferSection
        '
        Me.TransferSection.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.TransferSection.Controls.Add(Me.FlowLayoutPanel4)
        Me.TransferSection.Controls.Add(Me.Label8)
        Me.TransferSection.Controls.Add(Me.TransferPic)
        Me.TransferSection.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TransferSection.Location = New System.Drawing.Point(257, 169)
        Me.TransferSection.Margin = New System.Windows.Forms.Padding(5)
        Me.TransferSection.Name = "TransferSection"
        Me.TransferSection.Padding = New System.Windows.Forms.Padding(7)
        Me.TransferSection.Size = New System.Drawing.Size(242, 155)
        Me.TransferSection.TabIndex = 6
        '
        'FlowLayoutPanel4
        '
        Me.FlowLayoutPanel4.Controls.Add(Me.Label3)
        Me.FlowLayoutPanel4.Location = New System.Drawing.Point(97, 10)
        Me.FlowLayoutPanel4.Name = "FlowLayoutPanel4"
        Me.FlowLayoutPanel4.Size = New System.Drawing.Size(135, 79)
        Me.FlowLayoutPanel4.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Margin = New System.Windows.Forms.Padding(0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(130, 52)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Effectuer un transfert"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Arial", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(10, 122)
        Me.Label8.Margin = New System.Windows.Forms.Padding(0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(105, 26)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Transfert"
        '
        'TransferPic
        '
        Me.TransferPic.Location = New System.Drawing.Point(10, 36)
        Me.TransferPic.Name = "TransferPic"
        Me.TransferPic.Size = New System.Drawing.Size(72, 72)
        Me.TransferPic.TabIndex = 10
        Me.TransferPic.TabStop = False
        '
        'WithdrawalSection
        '
        Me.WithdrawalSection.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.WithdrawalSection.Controls.Add(Me.FlowLayoutPanel3)
        Me.WithdrawalSection.Controls.Add(Me.Label7)
        Me.WithdrawalSection.Controls.Add(Me.WithdrawalPic)
        Me.WithdrawalSection.Cursor = System.Windows.Forms.Cursors.Hand
        Me.WithdrawalSection.Location = New System.Drawing.Point(5, 169)
        Me.WithdrawalSection.Margin = New System.Windows.Forms.Padding(5)
        Me.WithdrawalSection.Name = "WithdrawalSection"
        Me.WithdrawalSection.Padding = New System.Windows.Forms.Padding(7)
        Me.WithdrawalSection.Size = New System.Drawing.Size(242, 155)
        Me.WithdrawalSection.TabIndex = 6
        '
        'FlowLayoutPanel3
        '
        Me.FlowLayoutPanel3.Controls.Add(Me.Label5)
        Me.FlowLayoutPanel3.Location = New System.Drawing.Point(125, 10)
        Me.FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        Me.FlowLayoutPanel3.Size = New System.Drawing.Size(107, 82)
        Me.FlowLayoutPanel3.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(0, 0)
        Me.Label5.Margin = New System.Windows.Forms.Padding(0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 52)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Effectuer un retrait"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Arial", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(10, 122)
        Me.Label7.Margin = New System.Windows.Forms.Padding(0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 26)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Retrait"
        '
        'WithdrawalPic
        '
        Me.WithdrawalPic.Location = New System.Drawing.Point(10, 36)
        Me.WithdrawalPic.Name = "WithdrawalPic"
        Me.WithdrawalPic.Size = New System.Drawing.Size(72, 72)
        Me.WithdrawalPic.TabIndex = 9
        Me.WithdrawalPic.TabStop = False
        '
        'DepositSection
        '
        Me.DepositSection.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.DepositSection.Controls.Add(Me.FlowLayoutPanel2)
        Me.DepositSection.Controls.Add(Me.Label6)
        Me.DepositSection.Controls.Add(Me.DepositPic)
        Me.DepositSection.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DepositSection.Location = New System.Drawing.Point(257, 5)
        Me.DepositSection.Margin = New System.Windows.Forms.Padding(5)
        Me.DepositSection.Name = "DepositSection"
        Me.DepositSection.Padding = New System.Windows.Forms.Padding(7)
        Me.DepositSection.Size = New System.Drawing.Size(242, 154)
        Me.DepositSection.TabIndex = 1
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Controls.Add(Me.Label4)
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(124, 10)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(108, 78)
        Me.FlowLayoutPanel2.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(0, 0)
        Me.Label4.Margin = New System.Windows.Forms.Padding(0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 52)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Effectuer un dépôt"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Arial", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(10, 121)
        Me.Label6.Margin = New System.Windows.Forms.Padding(0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 26)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Dépôt"
        '
        'DepositPic
        '
        Me.DepositPic.Location = New System.Drawing.Point(10, 36)
        Me.DepositPic.Name = "DepositPic"
        Me.DepositPic.Size = New System.Drawing.Size(72, 72)
        Me.DepositPic.TabIndex = 8
        Me.DepositPic.TabStop = False
        '
        'SoldeSection
        '
        Me.SoldeSection.BackColor = System.Drawing.Color.GreenYellow
        Me.SoldeSection.Controls.Add(Me.FlowLayoutPanel1)
        Me.SoldeSection.Controls.Add(Me.Label1)
        Me.SoldeSection.Controls.Add(Me.SoldePic)
        Me.SoldeSection.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SoldeSection.Location = New System.Drawing.Point(5, 5)
        Me.SoldeSection.Margin = New System.Windows.Forms.Padding(5)
        Me.SoldeSection.Name = "SoldeSection"
        Me.SoldeSection.Padding = New System.Windows.Forms.Padding(7)
        Me.SoldeSection.Size = New System.Drawing.Size(242, 154)
        Me.SoldeSection.TabIndex = 2
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.Label2)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(113, 10)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(119, 82)
        Me.FlowLayoutPanel1.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Margin = New System.Windows.Forms.Padding(0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 78)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Consulter votre solde"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(10, 121)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 26)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Solde"
        '
        'SoldePic
        '
        Me.SoldePic.Location = New System.Drawing.Point(10, 36)
        Me.SoldePic.Name = "SoldePic"
        Me.SoldePic.Size = New System.Drawing.Size(72, 72)
        Me.SoldePic.TabIndex = 7
        Me.SoldePic.TabStop = False
        '
        'TransactionsPic
        '
        Me.TransactionsPic.Location = New System.Drawing.Point(10, 36)
        Me.TransactionsPic.Name = "TransactionsPic"
        Me.TransactionsPic.Size = New System.Drawing.Size(72, 72)
        Me.TransactionsPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.TransactionsPic.TabIndex = 12
        Me.TransactionsPic.TabStop = False
        '
        'UserDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.MenuLayout)
        Me.Name = "UserDashboard"
        Me.Size = New System.Drawing.Size(758, 329)
        Me.MenuLayout.ResumeLayout(False)
        Me.TransactionSection.ResumeLayout(False)
        Me.TransactionSection.PerformLayout()
        Me.FlowLayoutPanel6.ResumeLayout(False)
        Me.FlowLayoutPanel6.PerformLayout()
        Me.EditionSection.ResumeLayout(False)
        Me.EditionSection.PerformLayout()
        Me.FlowLayoutPanel5.ResumeLayout(False)
        Me.FlowLayoutPanel5.PerformLayout()
        CType(Me.EditPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TransferSection.ResumeLayout(False)
        Me.TransferSection.PerformLayout()
        Me.FlowLayoutPanel4.ResumeLayout(False)
        Me.FlowLayoutPanel4.PerformLayout()
        CType(Me.TransferPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.WithdrawalSection.ResumeLayout(False)
        Me.WithdrawalSection.PerformLayout()
        Me.FlowLayoutPanel3.ResumeLayout(False)
        Me.FlowLayoutPanel3.PerformLayout()
        CType(Me.WithdrawalPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DepositSection.ResumeLayout(False)
        Me.DepositSection.PerformLayout()
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.FlowLayoutPanel2.PerformLayout()
        CType(Me.DepositPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SoldeSection.ResumeLayout(False)
        Me.SoldeSection.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        CType(Me.SoldePic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransactionsPic, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Label1 As Label
    Friend WithEvents FlowLayoutPanel4 As FlowLayoutPanel
    Friend WithEvents Label8 As Label
    Friend WithEvents FlowLayoutPanel3 As FlowLayoutPanel
    Friend WithEvents Label7 As Label
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents Label6 As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents TransactionSection As Panel
    Friend WithEvents FlowLayoutPanel6 As FlowLayoutPanel
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents EditionSection As Panel
    Friend WithEvents FlowLayoutPanel5 As FlowLayoutPanel
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents EditPic As PictureBox
    Friend WithEvents TransactionsPic As PictureBox
End Class
