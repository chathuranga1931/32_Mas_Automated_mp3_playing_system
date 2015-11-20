Imports System
Imports System.IO

Public Class Add_Event
    Dim startTIme As String
    Dim fd As OpenFileDialog = New OpenFileDialog()


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


        'TextBox1.Text = strFileName
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

            Dim savingString As String = tbEventName.Text + "$" + "AAAA" + "$" + cbHour.Text + ":" + cbMinute.Text + ":" + cbSecond.Text + "$" + mon + "$" + tue + "$" + wed + "$" + thu + "$" + fri + "$" + sat + "$" + sun + "$" + tbFileLocaion.Text
            Dim currentProfileTXT As New System.IO.StreamWriter("CurrentProfile.txt", False)
            Dim result As Integer = MessageBox.Show("Do you want to create a new event", "Comfirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)

            If result = DialogResult.No Then
            ElseIf result = DialogResult.Yes Then
                For j = 0 To Form1.totalEvents - 1
                    Dim saved As String = Form1.eventArray(j).allstring
                    currentProfileTXT.WriteLine(saved)
                Next j
                currentProfileTXT.WriteLine(savingString)
                currentProfileTXT.Close()
                Form1.Timer3.Start()
                Me.Close()
            End If
        Catch ae As Exception
            Console.WriteLine("An error occurred: '{0}'", ae)
        End Try
    End Sub

    Private Sub Add_Event_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Form1.Timer3.Stop()
        Catch ex As Exception

        End Try
    End Sub

End Class