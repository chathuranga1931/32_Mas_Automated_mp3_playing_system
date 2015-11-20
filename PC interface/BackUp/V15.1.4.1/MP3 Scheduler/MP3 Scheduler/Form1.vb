
Imports System.IO

Public Class Form1


    Dim xRead As New System.IO.StreamReader("CurrentProfile.txt")
    Dim timeOfNextEvent As String
    Dim locationOfNextEvent As String
    Public eventArray(40) As Events
    Dim timeInSecondsCurrent As Integer
    Public totalEvents As Integer

    Private Sub NewEventToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewEventToolStripMenuItem.Click
        Add_Event.Show()
        Timer3.Stop()
        Try
            xRead.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub EditEventToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditEventToolStripMenuItem.Click
        Try
            Edit_Event.Show()
            Timer3.Stop()
        Catch ex As Exception
        End Try
        Try
            xRead.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        Dim today As String = Now.DayOfWeek
        CurrentTime.Text = TimeOfDay.ToString("HH:mm:ss")
        CurrentTime.Visible = True

        Dim timeCurrent As String = TimeOfDay.ToString("HH:mm:ss")
        Dim a() As String = timeCurrent.Split(":"c)
        Dim timeInSecondsCurrent As Integer = Val(a(0)) * 3600 + Val(a(1)) * 60 + Val(a(2))
        Try
            If eventArray(0).GetTimeGap() < 60 Then
                lb1.Visible = True
                lb1.Text = eventArray(0).GetTimeGap().ToString
            Else
                lb1.Visible = False
            End If
        Catch ex As Exception

        End Try
        Try
            If eventArray(0).GetTimeGap() = 0 Then
                locationOfNextEvent = eventArray(0).fileLocation
                wmp.URL = locationOfNextEvent '"F:\ELECTRONIC\2015\Projects\32.Mars Automated mp3 playing system\PC interface\ver2\MP3 Scheduler\MP3 Scheduler\Audio\Leavin.mp3"
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
        Timer3.Start()
        Try
            Dim i = 0
            Do Until xRead.EndOfStream
                'tbXRead.Text = tbXRead.Text + xRead.ReadLine + vbCrLf
                Dim input As String = xRead.ReadLine
                eventArray(i) = New Events(input)
                'tbXRead.Text = tbXRead.Text + vbCrLf + (i + 1).ToString + "\t" + eventArray(i).eventName + "\t" + eventArray(i).timeInSeconds.ToString + eventArray(i).eventStartTime
                i = i + 1
            Loop
            totalEvents = i
            'MessageBox.Show(totalEvents.ToString)

            For j = 1 To totalEvents - 1
                For k = 1 To totalEvents - 1
                    Dim SwapEvent As Events
                    If eventArray(k).timeGap < eventArray(k - 1).timeGap Then
                        SwapEvent = eventArray(k)
                        eventArray(k) = eventArray(k - 1)
                        eventArray(k - 1) = SwapEvent
                    End If
                Next k
            Next j
            Dim l = 0
            tbXRead.Text = (l + 1).ToString + ".)" + vbTab + eventArray(l).eventStartTime + vbTab + eventArray(l).eventName + vbTab + eventArray(l).timeGap.ToString
            For j = 1 To totalEvents - 1
                tbXRead.Text = tbXRead.Text + vbCrLf + (j + 1).ToString + ".)" + vbTab + eventArray(j).eventStartTime + vbTab + eventArray(j).eventName + vbTab + eventArray(j).timeGap.ToString
            Next j
            xRead.Close()
        Catch ex As Exception
        End Try
    End Sub


    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        Dim i = 0
        Try
            xRead = New System.IO.StreamReader("CurrentProfile.txt")
        Catch ex As Exception
            MessageBox.Show("Check your file in the same destination with name 'CurrentProfile.txt'")
        End Try
        Try
            Do Until xRead.EndOfStream
                'tbXRead.Text = tbXRead.Text + xRead.ReadLine + vbCrLf
                Dim input As String = xRead.ReadLine
                eventArray(i) = New Events(input)
                'tbXRead.Text = tbXRead.Text + vbCrLf + (i + 1).ToString + "\t" + eventArray(i).eventName + "\t" + eventArray(i).timeInSeconds.ToString + eventArray(i).eventStartTime
                i = i + 1
            Loop
            totalEvents = i
            'MessageBox.Show(totalEvents.ToString)

            For j = 1 To totalEvents - 1
                For k = 1 To totalEvents - 1
                    Dim SwapEvent As Events
                    If eventArray(k).timeGap < eventArray(k - 1).timeGap Then
                        SwapEvent = eventArray(k)
                        eventArray(k) = eventArray(k - 1)
                        eventArray(k - 1) = SwapEvent
                    End If
                Next k
            Next j
            Dim l = 0
            tbXRead.Text = (l + 1).ToString + ".)" + vbTab + eventArray(l).eventStartTime + vbTab + eventArray(l).eventName + vbTab + eventArray(l).timeGap.ToString
            For j = 1 To totalEvents - 1
                tbXRead.Text = tbXRead.Text + vbCrLf + (j + 1).ToString + ".)" + vbTab + eventArray(j).eventStartTime + vbTab + eventArray(j).eventName + vbTab + eventArray(j).timeGap.ToString
            Next j
            xRead.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub PlayToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PlayToolStripMenuItem.Click
        'Dim newPlayList As WMPLib.IWMPPlaylist = wmpControl.playlistCollection.newPlaylist("soundsToPlay")
        'newPlayList.appendItem(wmpControl.newMedia("C:\Sample1.mp3"))
        'newPlayList.appendItem(wmpControl.newMedia("C:\Sample2.mp3"))
        'play the list
        'wmpControl.Visible = False
        'wmpControl.currentPlaylist = newPlayList
        'wmpControl.stretchToFit = True
        'wmpControl.Ctlcontrols.play()
        'For Each foundFile As String In My.Computer.FileSystem.GetFiles(
        'My.Computer.FileSystem.SpecialDirectories.MyDocuments)

        'listBox1.Items.Add(foundFile)
        'Next

        MessageBox.Show("Save your all files on following link to play all play list 'D:\MP3SchedulerV1\Data'")

        Try
            Dim newPlayList As WMPLib.IWMPPlaylist = wmp.playlistCollection.newPlaylist("soundsToPlay")
            For Each foundFile As String In My.Computer.FileSystem.GetFiles("D:\MP3SchedulerV1\Data")
                newPlayList.appendItem(wmp.newMedia(foundFile))
            Next
            wmp.currentPlaylist = newPlayList
            wmp.Ctlcontrols.play()
        Catch ex As Exception

        End Try

    End Sub
End Class
