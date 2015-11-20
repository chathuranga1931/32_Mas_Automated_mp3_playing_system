Public Class PlayList
    Public noOfSongs As Integer = 0
    Dim Playlist_link As String

    Private Sub PlayList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Folder browsing dialog box
        Dim dialog As New FolderBrowserDialog()
        dialog.RootFolder = Environment.SpecialFolder.Desktop
        dialog.SelectedPath = "C:\"
        dialog.Description = "Select a folder with audio files"
        If dialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            'set the link to string variable Playlist_link
            Playlist_link = dialog.SelectedPath
        End If

        Try

            Dim newPlayList As WMPLib.IWMPPlaylist = wmp.playlistCollection.newPlaylist("soundsToPlay")

            '=============================================
            'SETTING UP MEDIA PLAYER

            'set the shuffle enable of the playlist
            wmp.settings.setMode("shuffle", True)

            'set the auto play off and then we have to start manualy it by
            'setting control.play
            wmp.settings.autoStart = False

            '==============================================

            For Each foundFile As String In My.Computer.FileSystem.GetFiles(Playlist_link)   'D:\MP3SchedulerV1\Data
                newPlayList.appendItem(wmp.newMedia(foundFile))
                noOfSongs = noOfSongs + 1

                wmp.currentPlaylist = newPlayList
                'wmp.Ctlcontrols.play()
            Next
            'wmp.currentPlaylist = newPlayList

            'we have to play manualy after setting auto play off
            wmp.Ctlcontrols.play()
            Form1.VolumePlaylist = wmp.settings.volume
        Catch ex As Exception
        End Try
    End Sub

End Class