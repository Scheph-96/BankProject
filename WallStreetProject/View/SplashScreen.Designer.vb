<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SplashScreen
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
        Me.SplashScreenBg = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SplashScreenImage = New System.Windows.Forms.PictureBox()
        Me.SplashScreenBg.SuspendLayout()
        CType(Me.SplashScreenImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplashScreenBg
        '
        Me.SplashScreenBg.BackColor = System.Drawing.SystemColors.GrayText
        Me.SplashScreenBg.Controls.Add(Me.Label7)
        Me.SplashScreenBg.Controls.Add(Me.Label6)
        Me.SplashScreenBg.Controls.Add(Me.Label5)
        Me.SplashScreenBg.Controls.Add(Me.Label4)
        Me.SplashScreenBg.Controls.Add(Me.Label3)
        Me.SplashScreenBg.Controls.Add(Me.Label2)
        Me.SplashScreenBg.Controls.Add(Me.Label1)
        Me.SplashScreenBg.Controls.Add(Me.SplashScreenImage)
        Me.SplashScreenBg.Location = New System.Drawing.Point(0, 0)
        Me.SplashScreenBg.Name = "SplashScreenBg"
        Me.SplashScreenBg.Size = New System.Drawing.Size(800, 450)
        Me.SplashScreenBg.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.ForeColor = System.Drawing.Color.Silver
        Me.Label7.Location = New System.Drawing.Point(12, 354)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(117, 24)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "All Right Reserved"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Agency FB", 39.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(12, 234)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(153, 63)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "STUDIO"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Agency FB", 39.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(12, 171)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(263, 63)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "MANAGEMENT"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.Silver
        Me.Label4.Location = New System.Drawing.Point(12, 330)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 24)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "(C)2022"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Agency FB", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(12, 410)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 31)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "v1.0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Agency FB", 39.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 63)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "BANK"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Agency FB", 39.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 63)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "OMAR'S"
        '
        'SplashScreenImage
        '
        Me.SplashScreenImage.Location = New System.Drawing.Point(320, 45)
        Me.SplashScreenImage.Name = "SplashScreenImage"
        Me.SplashScreenImage.Size = New System.Drawing.Size(480, 360)
        Me.SplashScreenImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.SplashScreenImage.TabIndex = 0
        Me.SplashScreenImage.TabStop = False
        '
        'SplashScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.SplashScreenBg)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SplashScreen"
        Me.Text = "SplashScreen"
        Me.SplashScreenBg.ResumeLayout(False)
        Me.SplashScreenBg.PerformLayout()
        CType(Me.SplashScreenImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplashScreenBg As Panel
    Friend WithEvents SplashScreenImage As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
End Class
