<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Game
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
        Me.Info = New System.Windows.Forms.Label()
        Me.Score = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SpinBtn = New System.Windows.Forms.Button()
        Me.BackBtn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ShootAway = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PointAway = New System.Windows.Forms.RadioButton()
        Me.PointAtHead = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ButtonLoadBullet = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Bullet1 = New System.Windows.Forms.PictureBox()
        Me.Bullet2 = New System.Windows.Forms.PictureBox()
        Me.Bullet3 = New System.Windows.Forms.PictureBox()
        Me.Bullet4 = New System.Windows.Forms.PictureBox()
        Me.Bullet6 = New System.Windows.Forms.PictureBox()
        Me.Bullet5 = New System.Windows.Forms.PictureBox()
        Me.ButtonFire = New System.Windows.Forms.Button()
        Me.PlayBtn = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bullet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bullet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bullet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bullet4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bullet6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bullet5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Info
        '
        Me.Info.AutoSize = True
        Me.Info.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Info.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Info.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Info.Location = New System.Drawing.Point(24, 266)
        Me.Info.Name = "Info"
        Me.Info.Size = New System.Drawing.Size(0, 31)
        Me.Info.TabIndex = 23
        '
        'Score
        '
        Me.Score.AutoSize = True
        Me.Score.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Score.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Score.Location = New System.Drawing.Point(109, 9)
        Me.Score.Name = "Score"
        Me.Score.Size = New System.Drawing.Size(23, 25)
        Me.Score.TabIndex = 22
        Me.Score.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(12, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 25)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Survived:"
        '
        'SpinBtn
        '
        Me.SpinBtn.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.SpinBtn.Location = New System.Drawing.Point(19, 77)
        Me.SpinBtn.Name = "SpinBtn"
        Me.SpinBtn.Size = New System.Drawing.Size(140, 34)
        Me.SpinBtn.TabIndex = 20
        Me.SpinBtn.Text = "Spin Chambers"
        Me.SpinBtn.UseVisualStyleBackColor = False
        '
        'BackBtn
        '
        Me.BackBtn.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.BackBtn.Location = New System.Drawing.Point(576, 336)
        Me.BackBtn.Name = "BackBtn"
        Me.BackBtn.Size = New System.Drawing.Size(68, 23)
        Me.BackBtn.TabIndex = 34
        Me.BackBtn.Text = "Back"
        Me.BackBtn.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(495, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 25)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Shoot Away:"
        '
        'ShootAway
        '
        Me.ShootAway.AutoSize = True
        Me.ShootAway.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.ShootAway.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ShootAway.Location = New System.Drawing.Point(621, 8)
        Me.ShootAway.Name = "ShootAway"
        Me.ShootAway.Size = New System.Drawing.Size(23, 25)
        Me.ShootAway.TabIndex = 36
        Me.ShootAway.Text = "2"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.PointAway)
        Me.GroupBox1.Controls.Add(Me.PointAtHead)
        Me.GroupBox1.Location = New System.Drawing.Point(460, 36)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(184, 111)
        Me.GroupBox1.TabIndex = 37
        Me.GroupBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Label3"
        '
        'PointAway
        '
        Me.PointAway.AutoSize = True
        Me.PointAway.Location = New System.Drawing.Point(19, 43)
        Me.PointAway.Name = "PointAway"
        Me.PointAway.Size = New System.Drawing.Size(78, 17)
        Me.PointAway.TabIndex = 1
        Me.PointAway.TabStop = True
        Me.PointAway.Text = "Point Away"
        Me.PointAway.UseVisualStyleBackColor = True
        '
        'PointAtHead
        '
        Me.PointAtHead.AutoSize = True
        Me.PointAtHead.Checked = True
        Me.PointAtHead.Location = New System.Drawing.Point(19, 20)
        Me.PointAtHead.Name = "PointAtHead"
        Me.PointAtHead.Size = New System.Drawing.Size(90, 17)
        Me.PointAtHead.TabIndex = 0
        Me.PointAtHead.TabStop = True
        Me.PointAtHead.Text = "Point at Head"
        Me.PointAtHead.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ButtonLoadBullet)
        Me.GroupBox2.Controls.Add(Me.SpinBtn)
        Me.GroupBox2.Location = New System.Drawing.Point(460, 153)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(184, 148)
        Me.GroupBox2.TabIndex = 38
        Me.GroupBox2.TabStop = False
        '
        'ButtonLoadBullet
        '
        Me.ButtonLoadBullet.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ButtonLoadBullet.Location = New System.Drawing.Point(19, 37)
        Me.ButtonLoadBullet.Name = "ButtonLoadBullet"
        Me.ButtonLoadBullet.Size = New System.Drawing.Size(140, 34)
        Me.ButtonLoadBullet.TabIndex = 21
        Me.ButtonLoadBullet.Text = "Load Bullet"
        Me.ButtonLoadBullet.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.PictureBox2)
        Me.GroupBox3.Controls.Add(Me.PictureBox1)
        Me.GroupBox3.Controls.Add(Me.Bullet1)
        Me.GroupBox3.Controls.Add(Me.Bullet2)
        Me.GroupBox3.Controls.Add(Me.Bullet3)
        Me.GroupBox3.Controls.Add(Me.Bullet4)
        Me.GroupBox3.Controls.Add(Me.Bullet6)
        Me.GroupBox3.Controls.Add(Me.Bullet5)
        Me.GroupBox3.Location = New System.Drawing.Point(15, 36)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(442, 265)
        Me.GroupBox3.TabIndex = 39
        Me.GroupBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(231, 24)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(205, 120)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(6, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(219, 216)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Bullet1
        '
        Me.Bullet1.Location = New System.Drawing.Point(260, 194)
        Me.Bullet1.Name = "Bullet1"
        Me.Bullet1.Size = New System.Drawing.Size(20, 59)
        Me.Bullet1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Bullet1.TabIndex = 24
        Me.Bullet1.TabStop = False
        '
        'Bullet2
        '
        Me.Bullet2.Location = New System.Drawing.Point(286, 194)
        Me.Bullet2.Name = "Bullet2"
        Me.Bullet2.Size = New System.Drawing.Size(20, 59)
        Me.Bullet2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Bullet2.TabIndex = 25
        Me.Bullet2.TabStop = False
        '
        'Bullet3
        '
        Me.Bullet3.Location = New System.Drawing.Point(312, 194)
        Me.Bullet3.Name = "Bullet3"
        Me.Bullet3.Size = New System.Drawing.Size(20, 59)
        Me.Bullet3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Bullet3.TabIndex = 26
        Me.Bullet3.TabStop = False
        '
        'Bullet4
        '
        Me.Bullet4.Location = New System.Drawing.Point(338, 194)
        Me.Bullet4.Name = "Bullet4"
        Me.Bullet4.Size = New System.Drawing.Size(20, 59)
        Me.Bullet4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Bullet4.TabIndex = 27
        Me.Bullet4.TabStop = False
        '
        'Bullet6
        '
        Me.Bullet6.Location = New System.Drawing.Point(390, 194)
        Me.Bullet6.Name = "Bullet6"
        Me.Bullet6.Size = New System.Drawing.Size(20, 59)
        Me.Bullet6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Bullet6.TabIndex = 29
        Me.Bullet6.TabStop = False
        '
        'Bullet5
        '
        Me.Bullet5.Location = New System.Drawing.Point(364, 194)
        Me.Bullet5.Name = "Bullet5"
        Me.Bullet5.Size = New System.Drawing.Size(20, 59)
        Me.Bullet5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Bullet5.TabIndex = 28
        Me.Bullet5.TabStop = False
        '
        'ButtonFire
        '
        Me.ButtonFire.Location = New System.Drawing.Point(17, 307)
        Me.ButtonFire.Name = "ButtonFire"
        Me.ButtonFire.Size = New System.Drawing.Size(442, 52)
        Me.ButtonFire.TabIndex = 40
        Me.ButtonFire.Text = "Fire"
        Me.ButtonFire.UseVisualStyleBackColor = True
        '
        'PlayBtn
        '
        Me.PlayBtn.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.PlayBtn.Location = New System.Drawing.Point(488, 336)
        Me.PlayBtn.Name = "PlayBtn"
        Me.PlayBtn.Size = New System.Drawing.Size(82, 23)
        Me.PlayBtn.TabIndex = 22
        Me.PlayBtn.Text = "Play Again"
        Me.PlayBtn.UseVisualStyleBackColor = False
        '
        'Game
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(656, 373)
        Me.Controls.Add(Me.PlayBtn)
        Me.Controls.Add(Me.Info)
        Me.Controls.Add(Me.ButtonFire)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.ShootAway)
        Me.Controls.Add(Me.BackBtn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Score)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Game"
        Me.Text = "Game"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bullet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bullet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bullet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bullet4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bullet6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bullet5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Bullet6 As PictureBox
    Friend WithEvents Bullet5 As PictureBox
    Friend WithEvents Bullet4 As PictureBox
    Friend WithEvents Bullet3 As PictureBox
    Friend WithEvents Bullet2 As PictureBox
    Friend WithEvents Bullet1 As PictureBox
    Friend WithEvents Info As Label
    Friend WithEvents Score As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents SpinBtn As Button
    Friend WithEvents BackBtn As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents ShootAway As Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PointAway As System.Windows.Forms.RadioButton
    Friend WithEvents PointAtHead As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonLoadBullet As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ButtonFire As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PlayBtn As System.Windows.Forms.Button
End Class
