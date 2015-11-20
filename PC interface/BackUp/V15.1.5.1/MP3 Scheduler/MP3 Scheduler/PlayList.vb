Public Class PlayList

    Private Sub PlayList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MessageBox.Show("Save your all files on following link to play all play list 'D:\MP3SchedulerV1\Data'")
        Try
            'Dim newPlayList As WMPLib.IWMPPlaylist = wmp.playlistCollection.newPlaylist("soundsToPlay")
            Dim newPlayList As WMPLib.IWMPPlaylist = wmp.playlistCollection.newPlaylist("soundsToPlay")
            For Each foundFile As String In My.Computer.FileSystem.GetFiles("D:\MP3SchedulerV1\Data") '("D:\MP3SchedulerV1\Data")
                newPlayList.appendItem(wmp.newMedia(foundFile))

                wmp.currentPlaylist = newPlayList
                wmp.Ctlcontrols.play()
                'If Form1.wmp.playState = 3 Then
                'Else if 
                '    wmp.URL = foundFile
                'End If
            Next
            'wmp.currentPlaylist = newPlayList
            'wmp.Ctlcontrols.play()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        
    End Sub
End Class