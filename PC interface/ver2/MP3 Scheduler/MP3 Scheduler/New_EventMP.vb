Public Class New_EventMP
    Public saveHere As Boolean = 0
    Private Sub New_EventMP_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'This is to avoid duplication if button was clicked more than once
        lbPlaylist.Items.Clear()
        For i = 0 To Form1.lbPlaylist.Items.Count - 1
            lbPlaylist.Items.Add(Form1.lbPlaylist.Items(i).ToString)
        Next

        'Dim currentProfileMPTXT As New System.IO.StreamReader("CurrentProfileMP.txt", False)
    End Sub

    Private Sub lbPlaylist_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbPlaylist.SelectedIndexChanged
        Dim curItem As String = lbPlaylist.SelectedItem.ToString()
        tbAddPL.Text = curItem
    End Sub

    Private Sub lbPlaylistAdded_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim curItem As Integer = lbPlaylistAdded.SelectedIndex

    End Sub

    Private Sub BtnAddEvent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddEvent.Click
        Try
            Dim mon, tue, wed, thu, fri, sat, sun As String

            If cbMon.Checked = True Then
                mon = "11"
            Else
                mon = "10"
            End If
            If cbTue.Checked = True Then
                tue = "21"
            Else
                tue = "20"
            End If
            If cbWed.Checked = True Then
                wed = "31"
            Else
                wed = "30"
            End If
            If cbThu.Checked = True Then
                thu = "41"
            Else
                thu = "40"
            End If
            If cbFri.Checked = True Then
                fri = "51"
            Else
                fri = "50"
            End If
            If cbSat.Checked = True Then
                sat = "61"
            Else
                sat = "60"
            End If
            If cbSun.Checked = True Then
                sun = "71"
            Else
                sun = "70"
            End If

            Dim savingString As String = tbEventName.Text + "$" + "AAAA" + "$" + cbHour.Text + ":" + cbMinute.Text + ":" + cbSecond.Text + "$" + mon + "$" + tue + "$" + wed + "$" + thu + "$" + fri + "$" + sat + "$" + sun + "$" + cbEHour.Text + ":" + cbEMinute.Text + ":" + cbEsecond.Text + "$" + tbAddPL.Text
            Dim currentProfileMPTXT As New System.IO.StreamWriter("CurrentProfileMP.txt", False)
            Dim result As Integer = MessageBox.Show("Do you want to create a new event", "Comfirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)

            If result = DialogResult.No Then
            ElseIf result = DialogResult.Yes Then
                For j = 0 To Form1.totalEvents - 1
                    Dim saved As String = Form1.eventMPArray(j).allstring
                    currentProfileMPTXT.WriteLine(saved)
                Next j
                currentProfileMPTXT.WriteLine(savingString)
                currentProfileMPTXT.Close()
                Form1.Timer3.Start()
                Me.Close()
            End If
        Catch ae As Exception
            MessageBox.Show(ae.ToString)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim result As Integer = MessageBox.Show("Do you want to remove this from the playlist", "Comfirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)

        If result = DialogResult.No Then

        ElseIf result = DialogResult.Yes Then
            'newPlayList.appendItem(wmp2.newMedia(curItem))
            'lbPlaylistAdded.Items.Remove(lbPlaylistAdded.SelectedItem)
        End If
    End Sub

    Private Sub btNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btNew.Click
        saveHere = True
        PlayList.Show()
    End Sub
End Class