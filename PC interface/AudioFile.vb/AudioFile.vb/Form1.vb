Public Class Form1
    Dim audio As New AudioFile("F:\MEDIA\Songs\01_Levels_(Radio_Edit).mp3")
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        audio.Play()
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        audio.Pause()
    End Sub
End Class
