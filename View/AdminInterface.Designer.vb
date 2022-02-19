<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminInterface
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.logoutButton = New System.Windows.Forms.Button()
        Me.comptesView = New System.Windows.Forms.DataGridView()
        Me.Titulaire = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Solde = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateCreation = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.interet = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.bankPhoneNumber = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.bankAddress = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bankNameLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.comptesView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.logoutButton)
        Me.Panel1.Controls.Add(Me.comptesView)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.bankNameLabel)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(704, 441)
        Me.Panel1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(13, 166)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 30)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Comptes:"
        '
        'logoutButton
        '
        Me.logoutButton.BackColor = System.Drawing.Color.Silver
        Me.logoutButton.Font = New System.Drawing.Font("Segoe UI Semibold", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.logoutButton.Location = New System.Drawing.Point(532, 166)
        Me.logoutButton.Name = "logoutButton"
        Me.logoutButton.Size = New System.Drawing.Size(160, 30)
        Me.logoutButton.TabIndex = 4
        Me.logoutButton.Text = "Déconnexion"
        Me.logoutButton.UseVisualStyleBackColor = False
        '
        'comptesView
        '
        Me.comptesView.AllowUserToDeleteRows = False
        Me.comptesView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.comptesView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.comptesView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Titulaire, Me.Solde, Me.DateCreation, Me.Type, Me.interet})
        Me.comptesView.Location = New System.Drawing.Point(12, 218)
        Me.comptesView.Name = "comptesView"
        Me.comptesView.ReadOnly = True
        Me.comptesView.RowTemplate.Height = 25
        Me.comptesView.Size = New System.Drawing.Size(680, 211)
        Me.comptesView.TabIndex = 3
        '
        'Titulaire
        '
        Me.Titulaire.HeaderText = "Titulaire"
        Me.Titulaire.Name = "Titulaire"
        Me.Titulaire.ReadOnly = True
        '
        'Solde
        '
        Me.Solde.HeaderText = "Solde"
        Me.Solde.Name = "Solde"
        Me.Solde.ReadOnly = True
        '
        'DateCreation
        '
        Me.DateCreation.HeaderText = "Date de création"
        Me.DateCreation.Name = "DateCreation"
        Me.DateCreation.ReadOnly = True
        '
        'Type
        '
        Me.Type.HeaderText = "Type"
        Me.Type.Name = "Type"
        Me.Type.ReadOnly = True
        '
        'interet
        '
        Me.interet.HeaderText = "intérêt"
        Me.interet.Name = "interet"
        Me.interet.ReadOnly = True
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.bankPhoneNumber)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Location = New System.Drawing.Point(391, 67)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(301, 49)
        Me.Panel3.TabIndex = 2
        '
        'bankPhoneNumber
        '
        Me.bankPhoneNumber.AutoSize = True
        Me.bankPhoneNumber.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.bankPhoneNumber.Location = New System.Drawing.Point(104, 9)
        Me.bankPhoneNumber.Name = "bankPhoneNumber"
        Me.bankPhoneNumber.Size = New System.Drawing.Size(184, 30)
        Me.bankPhoneNumber.TabIndex = 1
        Me.bankPhoneNumber.Text = "+228 00 00 00 00"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(1, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 30)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Numéro:"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.bankAddress)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(12, 67)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(373, 49)
        Me.Panel2.TabIndex = 1
        '
        'bankAddress
        '
        Me.bankAddress.AutoSize = True
        Me.bankAddress.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.bankAddress.Location = New System.Drawing.Point(100, 9)
        Me.bankAddress.Name = "bankAddress"
        Me.bankAddress.Size = New System.Drawing.Size(238, 30)
        Me.bankAddress.TabIndex = 1
        Me.bankAddress.Text = "Something, somewhere"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(1, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Adresse:"
        '
        'bankNameLabel
        '
        Me.bankNameLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bankNameLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.bankNameLabel.ForeColor = System.Drawing.Color.White
        Me.bankNameLabel.Location = New System.Drawing.Point(0, 9)
        Me.bankNameLabel.Name = "bankNameLabel"
        Me.bankNameLabel.Size = New System.Drawing.Size(704, 42)
        Me.bankNameLabel.TabIndex = 0
        Me.bankNameLabel.Text = "BANK NAME"
        Me.bankNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AdminInterface
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(704, 441)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "AdminInterface"
        Me.Text = "AdminInterface"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.comptesView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents comptesView As DataGridView
    Friend WithEvents Titulaire As DataGridViewTextBoxColumn
    Friend WithEvents Solde As DataGridViewTextBoxColumn
    Friend WithEvents DateCreation As DataGridViewTextBoxColumn
    Friend WithEvents Type As DataGridViewTextBoxColumn
    Friend WithEvents interet As DataGridViewTextBoxColumn
    Friend WithEvents Panel3 As Panel
    Friend WithEvents bankPhoneNumber As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents bankAddress As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents bankNameLabel As Label
    Friend WithEvents logoutButton As Button
    Friend WithEvents Label2 As Label
End Class
