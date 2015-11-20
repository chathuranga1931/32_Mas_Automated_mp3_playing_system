Public Class PlayList
    Dim newPlayList As WMPLib.IWMPPlaylist
    Private Sub btOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btOpen.Click

        btOpen.Visible = False
        btAdd.Visible = True

        Try
            newPlayList = Form1.wmp2.playlistCollection.newPlaylist(tbPlaylist.Text)
            fd.Title = "Open File Dialog"
            fd.InitialDirectory = "F:\MEDIA\Songs"
            fd.Filter = "mp3 files (*.mp3)|*.mp3|All files (*.*)|*.*"
            'fd.Filter = "Playlist files (*.wpl)|*.wpl|All files (*.*)|*.*"
            fd.FilterIndex = 2
            fd.RestoreDirectory = True
            fd.Multiselect = True

            If fd.ShowDialog() = DialogResult.OK Then
                For Each fName In fd.FileNames
                    newPlayList.appendItem(Form1.wmp2.newMedia(fName))
                    lbPlaylist.Items.Add(fName)
                Next
            End If

            'set the genarated playlist to current play list
            'wmp2.currentPlaylist = newPlayList

            'no of items in the playlist
            'MessageBox.Show(wmp.currentPlaylist.count)

            ' Play the media item.
            'wmp2.Ctlcontrols.play()

        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSave.Click
        Form1.lbPlaylist.Items.Add("C:\Users\Chathuranga\Music\Playlists\" + tbPlaylist.Text + ".wpl")
        If New_EventMP.saveHere = True Then
            New_EventMP.tbAddPL.Text = "C:\Users\Chathuranga\Music\Playlists\" + tbPlaylist.Text + ".wpl"
        End If

    End Sub

    Private Sub PlayList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub lbPlaylist_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbPlaylist.SelectedIndexChanged
        
    End Sub

    Private Sub btAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAdd.Click
        Try
            fd.Title = "Open File Dialog"
            fd.InitialDirectory = "F:\MEDIA\Songs"
            fd.Filter = "mp3 files (*.mp3)|*.mp3|All files (*.*)|*.*"
            'fd.Filter = "Playlist files (*.wpl)|*.wpl|All files (*.*)|*.*"
            fd.FilterIndex = 2
            fd.RestoreDirectory = True
            fd.Multiselect = True

            If fd.ShowDialog() = DialogResult.OK Then
                For Each fName In fd.FileNames
                    newPlayList.appendItem(Form1.wmp2.newMedia(fName))
                    lbPlaylist.Items.Add(fName)
                Next
            End If
        Catch ex As Exception
        End Try
    End Sub
End Class