<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DisplayAccountsScreen
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BackPic = New System.Windows.Forms.PictureBox()
        Me.UserAccountNumberColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserLastNameColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserFirstNameColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserAccountType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserAccountInterest = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserAccountSolde = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserAccountDateCreation = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BackPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UserAccountNumberColumn, Me.UserLastNameColumn, Me.UserFirstNameColumn, Me.UserAccountType, Me.UserAccountInterest, Me.UserAccountSolde, Me.UserAccountDateCreation})
        Me.DataGridView1.Location = New System.Drawing.Point(60, 0)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(698, 338)
        Me.DataGridView1.TabIndex = 0
        '
        'BackPic
        '
        Me.BackPic.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BackPic.Location = New System.Drawing.Point(0, 0)
        Me.BackPic.Margin = New System.Windows.Forms.Padding(0)
        Me.BackPic.Name = "BackPic"
        Me.BackPic.Size = New System.Drawing.Size(48, 48)
        Me.BackPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BackPic.TabIndex = 2
        Me.BackPic.TabStop = False
        '
        'UserAccountNumberColumn
        '
        Me.UserAccountNumberColumn.HeaderText = "Numéro de compte"
        Me.UserAccountNumberColumn.Name = "UserAccountNumberColumn"
        Me.UserAccountNumberColumn.ReadOnly = True
        '
        'UserLastNameColumn
        '
        Me.UserLastNameColumn.HeaderText = "Nom"
        Me.UserLastNameColumn.Name = "UserLastNameColumn"
        Me.UserLastNameColumn.ReadOnly = True
        '
        'UserFirstNameColumn
        '
        Me.UserFirstNameColumn.HeaderText = "Prénoms"
        Me.UserFirstNameColumn.Name = "UserFirstNameColumn"
        Me.UserFirstNameColumn.ReadOnly = True
        '
        'UserAccountType
        '
        Me.UserAccountType.HeaderText = "Type de compte"
        Me.UserAccountType.Name = "UserAccountType"
        Me.UserAccountType.ReadOnly = True
        '
        'UserAccountInterest
        '
        Me.UserAccountInterest.HeaderText = "Intérêt"
        Me.UserAccountInterest.Name = "UserAccountInterest"
        Me.UserAccountInterest.ReadOnly = True
        '
        'UserAccountSolde
        '
        Me.UserAccountSolde.HeaderText = "Solde"
        Me.UserAccountSolde.Name = "UserAccountSolde"
        Me.UserAccountSolde.ReadOnly = True
        '
        'UserAccountDateCreation
        '
        Me.UserAccountDateCreation.HeaderText = "Date de création"
        Me.UserAccountDateCreation.Name = "UserAccountDateCreation"
        Me.UserAccountDateCreation.ReadOnly = True
        '
        'DisplayAccountsScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.BackPic)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "DisplayAccountsScreen"
        Me.Size = New System.Drawing.Size(758, 338)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BackPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BackPic As PictureBox
    Friend WithEvents UserAccountNumberColumn As DataGridViewTextBoxColumn
    Friend WithEvents UserLastNameColumn As DataGridViewTextBoxColumn
    Friend WithEvents UserFirstNameColumn As DataGridViewTextBoxColumn
    Friend WithEvents UserAccountType As DataGridViewTextBoxColumn
    Friend WithEvents UserAccountInterest As DataGridViewTextBoxColumn
    Friend WithEvents UserAccountSolde As DataGridViewTextBoxColumn
    Friend WithEvents UserAccountDateCreation As DataGridViewTextBoxColumn
End Class
