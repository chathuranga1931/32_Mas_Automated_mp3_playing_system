Public Class PlayList

    Private Sub btOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btOpen.Click
        Try
            Dim newPlayList As WMPLib.IWMPPlaylist = wmp.playlistCollection.newPlaylist("soundsToPlay")
            fd.Title = "Open File Dialog"
            fd.InitialDirectory = "F:\MEDIA\Songs"
            'fd.Filter = "mp3 files (*.mp3)|*.mp3|All files (*.*)|*.*"
            fd.Filter = "Playlist files (*.wpl)|*.wpl|All files (*.*)|*.*"
            fd.FilterIndex = 2
            fd.RestoreDirectory = True
            fd.Multiselect = True

            If fd.ShowDialog() = DialogResult.OK Then
                For Each fName In fd.FileNames
                    newPlayList.appendItem(wmp.newMedia(fName))
                    lbPlaylist.Items.Add(fName)
                Next
            End If

            'set the genarated playlist to current play list
            wmp.currentPlaylist = newPlayList

            'no of items in the playlist
            'MessageBox.Show(wmp.currentPlaylist.count)

            ' Play the media item.
            wmp.Ctlcontrols.play()

        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ' Create a random number generator. 
        'Dim randGenerator As System.Random = New System.Random()

        ' Store the count of all media items in the media collection.
        'Dim count As Integer = wmp.mediaCollection.getAll().count

        ' Get a random integer using the count as the max value.
        'Dim rand As Integer = randGenerator.Next(count)

        ' Make the random media item the current media item.
        'wmp.currentMedia = wmp.mediaCollection.getAll().Item(rand)

        '


    End Sub
End Class