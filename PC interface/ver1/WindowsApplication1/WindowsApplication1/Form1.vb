Public Class Form1

    Dim audio As New AudioFile("F:\MEDIA\Songs\Hindi\Leavin.mp3")


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        audio.Play()
    End Sub
End Class
