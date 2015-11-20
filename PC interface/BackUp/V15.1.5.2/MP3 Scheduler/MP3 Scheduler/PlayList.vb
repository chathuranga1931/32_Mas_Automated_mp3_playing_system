Public Class PlayList
    Public noOfSongs As Integer = 0
    Private Sub PlayList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        MessageBox.Show("Save your all files on following link to play all play list 'D:\MP3SchedulerV1\Data'")

        'For Each foundFile As String In My.Computer.FileSystem.GetFiles("D:\MP3SchedulerV1\Data")
        'My.Computer.FileSystem.DeleteFile(foundFile, FileIO.UIOption.AllDialogs, FileIO.RecycleOption.DeletePermanently)
        'Next

        Try

            'Dim newPlayList As WMPLib.IWMPPlaylist = wmp.playlistCollection.newPlaylist("abc")
            Dim newPlayList As WMPLib.IWMPPlaylist = wmp.newPlaylist("Original Sorted Playlist", "file:///C:\Users\Chathuranga\Music\Playlists\ata.wpl")
            '=============================================
            'SETTING UP MEDIA PLAYER

            'set the shuffle enable of the playlist
            wmp.settings.setMode("shuffle", True)

            'set the auto play off and then we have to start manualy it by
            'setting control.play
            wmp.settings.autoStart = False

            '==============================================
            'GET THE ALL MEDIA IN THE GIVEN FOLDER TO THE PLAYLIST

            For Each foundFile As String In My.Computer.FileSystem.GetFiles("D:\MP3SchedulerV1\Data")
                newPlayList.appendItem(wmp.newMedia(foundFile))
                noOfSongs = noOfSongs + 1
            Next
            wmp.currentPlaylist = newPlayList
            '==============================================
            'DELETING THE ITEMS IN THE PLAYLIST

            'this code segment is working properly
            'remove the top 5 items from the play list
            Dim mediaItem = newPlayList.Item(0)
            For i As Integer = 0 To (noOfSongs - 6)
                'get the first item from the list
                ''mediaItem = newPlayList.Item(0)
                'remove that item from the list
                ''newPlayList.removeItem(mediaItem)
            Next

            '==============================================

            'we have to play manualy after setting auto play off
            wmp.Ctlcontrols.play()
            Form1.VolumePlaylist = wmp.settings.volume
        Catch ex As Exception
        End Try
    End Sub

End Class