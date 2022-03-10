<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PersonalTransactionScreen
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
        Me.TransactionOwner = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TransactionAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TransactionType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TransactionTarget = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TransactionDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BackPic = New System.Windows.Forms.PictureBox()
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TransactionOwner, Me.TransactionAmount, Me.TransactionType, Me.TransactionTarget, Me.TransactionDate})
        Me.DataGridView1.Location = New System.Drawing.Point(60, 0)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(698, 329)
        Me.DataGridView1.TabIndex = 5
        '
        'TransactionOwner
        '
        Me.TransactionOwner.HeaderText = "Initiateur de la transaction"
        Me.TransactionOwner.Name = "TransactionOwner"
        Me.TransactionOwner.ReadOnly = True
        '
        'TransactionAmount
        '
        Me.TransactionAmount.HeaderText = "Montant"
        Me.TransactionAmount.Name = "TransactionAmount"
        Me.TransactionAmount.ReadOnly = True
        '
        'TransactionType
        '
        Me.TransactionType.HeaderText = "Type de transaction"
        Me.TransactionType.Name = "TransactionType"
        Me.TransactionType.ReadOnly = True
        '
        'TransactionTarget
        '
        Me.TransactionTarget.HeaderText = "Destinataire"
        Me.TransactionTarget.Name = "TransactionTarget"
        Me.TransactionTarget.ReadOnly = True
        '
        'TransactionDate
        '
        Me.TransactionDate.HeaderText = "Date de la transaction"
        Me.TransactionDate.Name = "TransactionDate"
        Me.TransactionDate.ReadOnly = True
        '
        'BackPic
        '
        Me.BackPic.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BackPic.Location = New System.Drawing.Point(0, 0)
        Me.BackPic.Margin = New System.Windows.Forms.Padding(0)
        Me.BackPic.Name = "BackPic"
        Me.BackPic.Size = New System.Drawing.Size(48, 48)
        Me.BackPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BackPic.TabIndex = 6
        Me.BackPic.TabStop = False
        '
        'PersonalTransactionScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.BackPic)
        Me.Name = "PersonalTransactionScreen"
        Me.Size = New System.Drawing.Size(758, 329)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BackPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TransactionOwner As DataGridViewTextBoxColumn
    Friend WithEvents TransactionAmount As DataGridViewTextBoxColumn
    Friend WithEvents TransactionType As DataGridViewTextBoxColumn
    Friend WithEvents TransactionTarget As DataGridViewTextBoxColumn
    Friend WithEvents TransactionDate As DataGridViewTextBoxColumn
    Friend WithEvents BackPic As PictureBox
End Class
