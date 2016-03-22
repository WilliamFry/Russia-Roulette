<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GameAI
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ComputerScore = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Bullet6 = New System.Windows.Forms.PictureBox()
        Me.Bullet5 = New System.Windows.Forms.PictureBox()
        Me.Bullet4 = New System.Windows.Forms.PictureBox()
        Me.Bullet3 = New System.Windows.Forms.PictureBox()
        Me.Bullet2 = New System.Windows.Forms.PictureBox()
        Me.Bullet1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Score = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TmrAI = New System.Windows.Forms.Timer(Me.components)
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.Bullet6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bullet5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bullet4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bullet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bullet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bullet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComputerScore
        '
        Me.ComputerScore.AutoSize = True
        Me.ComputerScore.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.ComputerScore.Location = New System.Drawing.Point(293, 4)
        Me.ComputerScore.Name = "ComputerScore"
        Me.ComputerScore.Size = New System.Drawing.Size(13, 13)
        Me.ComputerScore.TabIndex = 32
        Me.ComputerScore.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Location = New System.Drawing.Point(201, 4)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 13)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Computer Score:"
        '
        'Bullet6
        '
        Me.Bullet6.Location = New System.Drawing.Point(206, 217)
        Me.Bullet6.Name = "Bullet6"
        Me.Bullet6.Size = New System.Drawing.Size(38, 59)
        Me.Bullet6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Bullet6.TabIndex = 29
        Me.Bullet6.TabStop = False
        '
        'Bullet5
        '
        Me.Bullet5.Location = New System.Drawing.Point(172, 217)
        Me.Bullet5.Name = "Bullet5"
        Me.Bullet5.Size = New System.Drawing.Size(38, 59)
        Me.Bullet5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Bullet5.TabIndex = 28
        Me.Bullet5.TabStop = False
        '
        'Bullet4
        '
        Me.Bullet4.Location = New System.Drawing.Point(138, 217)
        Me.Bullet4.Name = "Bullet4"
        Me.Bullet4.Size = New System.Drawing.Size(38, 59)
        Me.Bullet4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Bullet4.TabIndex = 27
        Me.Bullet4.TabStop = False
        '
        'Bullet3
        '
        Me.Bullet3.Location = New System.Drawing.Point(104, 217)
        Me.Bullet3.Name = "Bullet3"
        Me.Bullet3.Size = New System.Drawing.Size(38, 59)
        Me.Bullet3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Bullet3.TabIndex = 26
        Me.Bullet3.TabStop = False
        '
        'Bullet2
        '
        Me.Bullet2.Location = New System.Drawing.Point(70, 217)
        Me.Bullet2.Name = "Bullet2"
        Me.Bullet2.Size = New System.Drawing.Size(38, 59)
        Me.Bullet2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Bullet2.TabIndex = 25
        Me.Bullet2.TabStop = False
        '
        'Bullet1
        '
        Me.Bullet1.Location = New System.Drawing.Point(36, 217)
        Me.Bullet1.Name = "Bullet1"
        Me.Bullet1.Size = New System.Drawing.Size(38, 59)
        Me.Bullet1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Bullet1.TabIndex = 24
        Me.Bullet1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(106, 180)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 13)
        Me.Label3.TabIndex = 23
        '
        'Score
        '
        Me.Score.AutoSize = True
        Me.Score.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Score.Location = New System.Drawing.Point(49, 4)
        Me.Score.Name = "Score"
        Me.Score.Size = New System.Drawing.Size(13, 13)
        Me.Score.TabIndex = 22
        Me.Score.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(5, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Score:"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Button1.Location = New System.Drawing.Point(104, 67)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 42)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "Spin"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Button2.Location = New System.Drawing.Point(104, 115)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(90, 42)
        Me.Button2.TabIndex = 19
        Me.Button2.Text = "Shoot Self"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'TmrAI
        '
        Me.TmrAI.Interval = 1000
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Button3.Location = New System.Drawing.Point(250, 253)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(56, 23)
        Me.Button3.TabIndex = 33
        Me.Button3.Text = "Back"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'GameAI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(318, 284)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.ComputerScore)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Bullet6)
        Me.Controls.Add(Me.Bullet5)
        Me.Controls.Add(Me.Bullet4)
        Me.Controls.Add(Me.Bullet3)
        Me.Controls.Add(Me.Bullet2)
        Me.Controls.Add(Me.Bullet1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Score)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Name = "GameAI"
        Me.Text = "GameAI"
        CType(Me.Bullet6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bullet5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bullet4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bullet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bullet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bullet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComputerScore As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Bullet6 As PictureBox
    Friend WithEvents Bullet5 As PictureBox
    Friend WithEvents Bullet4 As PictureBox
    Friend WithEvents Bullet3 As PictureBox
    Friend WithEvents Bullet2 As PictureBox
    Friend WithEvents Bullet1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Score As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents TmrAI As Timer
    Friend WithEvents Button3 As Button
End Class
