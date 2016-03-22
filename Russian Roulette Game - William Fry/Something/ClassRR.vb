Public Class ClassRR
    Public Random As New Random
    Public Bullet As Integer
    Public Chambers(6) As Integer
    Public Bullets(6) As PictureBox
    Public Barrel As Integer
    Public Spin As Boolean
    Public BulletRemove As Integer = -1
    Public ShootAway As Integer = 0

    'Shoot
    Public Sub Shoot()
        If Spin = True Then
            If Game.PointAtHead.Checked Then
                ShootSelf()
            End If
            If Game.PointAway.Checked Then
                If ShootAway <> 2 Then
                    If Spin = True Then
                        PointAway()
                    Else : Game.Info.Text = "Out of Shoot Aways"
                    End If
                End If
            End If
        End If
    End Sub

    'If gun if point at head
    Public Sub ShootSelf()
        If Chambers(Barrel) = 0 Then
            Barrel = Barrel + 1
            My.Computer.Audio.Play(My.Resources.Dry, AudioPlayMode.Background)
            Game.Info.Text = "You Lived"
        Else
            Game.Info.Text = "You Die"
            If BulletRemove = 5 Then
                MsgBox("You Survided " & Game.Score.Text & " Rounds")
                SaveScore()
                Game.ButtonLoadBullet.Enabled = False
            End If
            My.Computer.Audio.Play(My.Resources.GunShot, AudioPlayMode.Background)
            Spin = False
            Game.SpinBtn.Enabled = False
            Game.ButtonFire.Enabled = False
            Game.ButtonLoadBullet.Enabled = True
        End If
    End Sub

    'If Gun is pointing away
    Public Sub PointAway()
        If Chambers(Barrel) = 0 Then
            Barrel = Barrel + 1
            My.Computer.Audio.Play(My.Resources.Dry, AudioPlayMode.Background)
            Game.Info.Text = "Empty"
            ShootAway = ShootAway + 1
            Game.ShootAway.Text = Game.ShootAway.Text - 1
        Else
            Game.Info.Text = "Round Won"
            Game.Score.Text = Game.Score.Text + 1
            If BulletRemove = 5 Then
                MsgBox("You Survided " & Game.Score.Text & " Rounds")
                SaveScore()
                Game.ButtonLoadBullet.Enabled = False
            End If
            ShootAway = ShootAway + 1
            Game.SpinBtn.Enabled = False
            Game.ButtonFire.Enabled = False
            Game.ButtonLoadBullet.Enabled = True
            My.Computer.Audio.Play(My.Resources.GunShot, AudioPlayMode.Background)
            If Game.ShootAway.Text <> 0 Then
                Game.ShootAway.Text = Game.ShootAway.Text - 1
            End If
            Spin = False
            Game.SpinBtn.Enabled = True
        End If
    End Sub

    'Hides bullet image
    Public Sub LoadBullet()
        Game.SpinBtn.Enabled = True
        Game.ButtonLoadBullet.Enabled = False
        Game.Info.Text = "Spin Chamber"
        ShootAway = 0
        Game.ShootAway.Text = 2
        If BulletRemove <> 5 Then
            BulletRemove = BulletRemove + 1
            Bullets(BulletRemove).Hide()
        End If
    End Sub

    'Randomly selects bullet location in chamber
    Public Sub SpinChamber()
        Barrel = 0

        Bullet = Random.Next(0, 6)
        For i As Integer = 0 To Chambers.Count - 1
            Chambers(i) = 0
        Next

        Chambers(Bullet) = 1

        My.Computer.Audio.Play(My.Resources.Spin, AudioPlayMode.Background)

        Spin = True
        Game.Info.Text = ""

        Game.SpinBtn.Enabled = False
        Game.ButtonFire.Enabled = True
    End Sub

    Public Sub SaveScore()
        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter((Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) & "\Saved Games\Score.txt"), True)
        file.WriteLine(Form1.TextBox1.Text & " " & Game.Score.Text)
        file.Close()

    End Sub

    Public Sub Restart()
        Score.Text = 0
        BulletRemove = -1
        Bullets = New PictureBox() {Game.Bullet1, Game.Bullet2, Game.Bullet3, Game.Bullet4, Game.Bullet5, Game.Bullet6}
        For i As Integer = 0 To 5
            Bullets(i).Show()
        Next
        Game.ButtonFire.Enabled = False
        Game.SpinBtn.Enabled = False
        ShootAway = 0
        Game.Info.Text = "Load Bullet"
        Game.ButtonLoadBullet.Enabled = True
    End Sub
End Class
