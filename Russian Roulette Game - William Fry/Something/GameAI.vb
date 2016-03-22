Public Class GameAI
    Dim Random As New Random
    Dim Bullet As Integer
    Dim Chambers(6) As Integer
    Dim Bullets(6) As PictureBox
    Dim Barrel As Integer
    Dim Spin As Boolean
    Dim BulletRemove As Integer = -1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Barrel = 0

        Bullet = Random.Next(0, 6)
        For i As Integer = 0 To Chambers.Count - 1
            Chambers(i) = 0
        Next

        Chambers(Bullet) = 1

        'My.Computer.Audio.Play("C:\Users\owner\Desktop\Russian Roulette\Spin.wav", AudioPlayMode.Background)

        Spin = True

        If BulletRemove <> 5 Then
            BulletRemove = BulletRemove + 1
            Bullets(BulletRemove).Image = My.Resources.BulletsEmpty
        End If

        Label3.Text = "Your Turn"

        Button1.Enabled = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Spin = True Then
            If Chambers(Barrel) = 0 Then
                Barrel = Barrel + 1
                'My.Computer.Audio.Play("C:\Users\owner\Desktop\Russian Roulette\Dry.wav", AudioPlayMode.Background)
                Label3.Text = "You Lived"
                TmrAI.Start()
            Else
                Label3.Text = "You Die"
                ComputerScore.Text = ComputerScore.Text + 1
                Spin = False
                Button1.Enabled = True
            End If
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Bullets = New PictureBox() {Bullet1, Bullet2, Bullet3, Bullet4, Bullet5, Bullet6}
        For i As Integer = 0 To 5
            Bullets(i).Image = My.Resources.Bullets1
        Next
    End Sub

    Private Sub TmrAI_Tick(sender As Object, e As EventArgs) Handles TmrAI.Tick
        If Spin = True Then
            TmrAI.Stop()
            If Chambers(Barrel) = 0 Then
                Barrel = Barrel + 1
                'My.Computer.Audio.Play("C:\Users\owner\Desktop\Russian Roulette\Dry.wav", AudioPlayMode.Background)
                Label3.Text = "Computer Lived"
            Else
                Label3.Text = "Computer Died"
                Score.Text = Score.Text + 1
                Button1.Enabled = True
            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Form1.Show()
    End Sub
End Class
