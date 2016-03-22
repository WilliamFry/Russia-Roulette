Imports System.IO

Public Class Score
    Private Sub Score_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Path As String
        Dim Line As String
        Dim fileread As StreamReader
        Path = (Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) & "\Saved Games\Score.txt")
        fileread = New StreamReader(Path)


        Do Until fileread.EndOfStream
            Line = fileread.ReadLine
            Dim Array = Line.Split(" ")
            DataGridView1.Rows.Add(Array(0), Array(1))
        Loop
        DataGridView1.Sort(DataGridView1.Columns(1), System.ComponentModel.ListSortDirection.Descending)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub SortHighScore()

    End Sub
End Class
