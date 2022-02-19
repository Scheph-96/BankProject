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
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.AppTitle = New System.Windows.Forms.Label()
        Me.SplashScreenBg.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplashScreenBg
        '
        Me.SplashScreenBg.BackColor = System.Drawing.Color.LimeGreen
        Me.SplashScreenBg.Controls.Add(Me.ProgressBar1)
        Me.SplashScreenBg.Controls.Add(Me.AppTitle)
        Me.SplashScreenBg.Location = New System.Drawing.Point(0, 0)
        Me.SplashScreenBg.Name = "SplashScreenBg"
        Me.SplashScreenBg.Size = New System.Drawing.Size(720, 480)
        Me.SplashScreenBg.TabIndex = 0
        '
        'ProgressBar1
        '
        Me.ProgressBar1.BackColor = System.Drawing.Color.Silver
        Me.ProgressBar1.ForeColor = System.Drawing.Color.Gold
        Me.ProgressBar1.Location = New System.Drawing.Point(63, 337)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(606, 35)
        Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ProgressBar1.TabIndex = 1
        Me.ProgressBar1.Value = 40
        '
        'AppTitle
        '
        Me.AppTitle.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.AppTitle.ForeColor = System.Drawing.Color.White
        Me.AppTitle.Location = New System.Drawing.Point(0, 35)
        Me.AppTitle.Name = "AppTitle"
        Me.AppTitle.Size = New System.Drawing.Size(720, 74)
        Me.AppTitle.TabIndex = 0
        Me.AppTitle.Text = "Bank Managing App"
        Me.AppTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SplashScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(720, 480)
        Me.Controls.Add(Me.SplashScreenBg)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SplashScreen"
        Me.Text = "SplashScreen"
        Me.SplashScreenBg.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplashScreenBg As Panel
    Friend WithEvents AppTitle As Label
    Friend WithEvents ProgressBar1 As ProgressBar
End Class
