Public Class Game
    Dim Obj As New ClassRR
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Obj.Bullets = New PictureBox() {Bullet1, Bullet2, Bullet3, Bullet4, Bullet5, Bullet6}
        For i As Integer = 0 To 5
            Obj.Bullets(i).Image = My.Resources.Bullets
        Next

        SpinBtn.Enabled = False
        ButtonFire.Enabled = False
        Info.Text = "Load Bullet"
        PictureBox2.Image = My.Resources.MagnumLeft
        Label3.Text = Form1.TextBox1.Text
        PictureBox1.Image = My.Resources.TedCruz
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles SpinBtn.Click
        Obj.SpinChamber()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles ButtonFire.Click
        Obj.Shoot()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ButtonLoadBullet.Click
        Obj.LoadBullet()
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles PointAway.CheckedChanged
        PictureBox2.Image = My.Resources.Magnum
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles PointAtHead.CheckedChanged
        PictureBox2.Image = My.Resources.MagnumLeft
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles BackBtn.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles PlayBtn.Click
        Obj.Restart()
    End Sub
End Class
