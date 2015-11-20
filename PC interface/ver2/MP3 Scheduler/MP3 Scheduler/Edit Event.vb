Public Class Edit_Event
    Dim selecteditem As Integer
    Dim fd As OpenFileDialog = New OpenFileDialog()

    Private Sub cbSelectEvnt_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbSelectEvnt.SelectedIndexChanged

        gbEdit.Enabled = True
        Try
            For j = 0 To Form1.totalEvents - 1
                If cbSelectEvnt.Text = Form1.eventArray(j).eventName Then
                    tbEventName.Text = Form1.eventArray(j).eventName
                    cbHour.Text = Form1.eventArray(j).hr
                    cbMinute.Text = Form1.eventArray(j).min
                    cbSecond.Text = Form1.eventArray(j).sec
                    tbFileLocaion.Text = Form1.eventArray(j).fileLocation
                    selecteditem = j
                End If
            Next j

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Edit_Event_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            For j = 0 To Form1.totalEvents - 1
                cbSelectEvnt.Items.Add(Form1.eventArray(j).eventName)
            Next j
        Catch ex As Exception
        End Try

    End Sub

    Private Sub BtnAddEvent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click

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
        Try
            Form1.eventArray(selecteditem).eventName = tbEventName.Text
            Form1.eventArray(selecteditem).hr = cbHour.Text
            Form1.eventArray(selecteditem).min = cbMinute.Text
            Form1.eventArray(selecteditem).sec = cbSecond.Text
            Form1.eventArray(selecteditem).fileLocation = tbFileLocaion.Text

            Dim savingString As String = tbEventName.Text + "$" + "AAAA" + "$" + cbHour.Text + ":" + cbMinute.Text + ":" + cbSecond.Text + "$" + mon + "$" + tue + "$" + wed + "$" + thu + "$" + fri + "$" + sat + "$" + sun + "$" + tbFileLocaion.Text
            Form1.eventArray(selecteditem).allstring = savingString
            Dim currentProfileTXT As New System.IO.StreamWriter("CurrentProfile.txt", False)
            Dim result As Integer = MessageBox.Show("Do you want to save the new settings", "caption", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
            If result = DialogResult.No Then
            ElseIf result = DialogResult.Yes Then
                For j = 0 To Form1.totalEvents - 1
                    Dim saved As String = Form1.eventArray(j).allstring
                    currentProfileTXT.WriteLine(saved)
                Next j
                currentProfileTXT.Close()
                Form1.Timer3.Start()
                Me.Close()
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub BtnBrowseAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBrowseAdd.Click
        Try
            fd.Title = "Open File Dialog"
            fd.InitialDirectory = "F:\MEDIA\Songs"
            fd.Filter = "mp3 files (*.mp3)|*.mp3|All files (*.*)|*.*"
            fd.FilterIndex = 2
            fd.RestoreDirectory = True

            If fd.ShowDialog() = DialogResult.OK Then
                tbFileLocaion.Text = fd.FileName
            End If

        Catch ex As Exception

        End Try


    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Try
            Form1.Timer3.Start()
            Me.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDel.Click
        Try
            Dim currentProfileTXT As New System.IO.StreamWriter("CurrentProfile.txt", False)
            Dim result As Integer = MessageBox.Show("Do you want to delete this event", "caption", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
            If result = DialogResult.No Then
            ElseIf result = DialogResult.Yes Then
                For j = selecteditem To Form1.totalEvents - 2
                    Form1.eventArray(j) = Form1.eventArray(j + 1)
                Next j
                Form1.totalEvents = Form1.totalEvents - 1
                For j = 0 To Form1.totalEvents - 1
                    Dim saved As String = Form1.eventArray(j).allstring
                    currentProfileTXT.WriteLine(saved)
                Next j
                currentProfileTXT.Close()
                Form1.Timer3.Start()
                Me.Close()
            End If

        Catch ex As Exception

        End Try
    End Sub
End Class