
Imports System.IO

Public Class Form1

    Dim xRead As New System.IO.StreamReader("CurrentProfile.txt")
    Dim timeOfNextEvent As String
    Dim locationOfNextEvent As String
    Public eventArray(40) As Events
    Dim timeInSecondsCurrent As Integer
    Public totalEvents As Integer
    Public VolumePlaylist As Integer

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
                If eventArray(0).GetTimeGap() < 30 Then
                    PlayList.wmp.settings.volume = PlayList.wmp.settings.volume - 2
                End If
            Else
                lb1.Visible = False
            End If
        Catch ex As Exception
        End Try

        Try
            Dim c As Integer = wmp.playState
            If c = 0 Or c = 3 Or c = 10 Then
            Else

                PlayList.wmp.Ctlcontrols.play()
                If VolumePlaylist = PlayList.wmp.settings.volume Then
                Else
                    PlayList.wmp.settings.volume = PlayList.wmp.settings.volume + 1
                End If
            End If
        Catch ex As Exception
        End Try

        Try
            If eventArray(0).GetTimeGap() = 0 Then
                locationOfNextEvent = eventArray(0).fileLocation
                wmp.URL = locationOfNextEvent '"F:\ELECTRONIC\2015\Projects\32.Mars Automated mp3 playing system\PC interface\ver2\MP3 Scheduler\MP3 Scheduler\Audio\Leavin.mp3"
                PlayList.wmp.Ctlcontrols.pause()
            End If
        Catch ex As Exception
        End Try

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Check the lisons and check it with the hard coded
        'Whent that returns 1 
        'Program is running correctly else stop the application with showing the message

        If CheckLisons() = True Then
            'MessageBox.Show("ok")
        Else
            MessageBox.Show("You don't have permission to run this application in this computer please contact the author Chathuranga (+94718501416) ")
            'close all the application
            Application.Exit()
        End If

        'Timer1
        'Running the time in the form 
        'Check about the events to be handle
        Timer1.Start()

        'updating the event list and display them on the text box
        Timer3.Start()

        'read the text file that includes the events to the text box
        'put those events to the object array of the events
        '===========================================================
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
        PlayList.Show()
    End Sub

    'Fuction that get the processor and the sytem key of the computer 
    '----------------------------------------------------------------
    Private Function SystemSerialNumber() As String
        ' Get the Windows Management Instrumentation object.
        Dim wmi As Object = GetObject("WinMgmts:")

        ' Get the "base boards" (mother boards).
        Dim serial_numbers As String = ""
        Dim mother_boards As Object = wmi.InstancesOf("Win32_BaseBoard")
        For Each board As Object In mother_boards
            serial_numbers &= ", " & board.SerialNumber
        Next board
        If serial_numbers.Length > 0 Then serial_numbers = serial_numbers.Substring(2)

        Return serial_numbers
    End Function

    Private Function CpuId() As String
        Dim computer As String = "."
        Dim wmi As Object = GetObject("winmgmts:" & _
            "{impersonationLevel=impersonate}!\\" & _
            computer & "\root\cimv2")
        Dim processors As Object = wmi.ExecQuery("Select * from Win32_Processor")

        Dim cpu_ids As String = ""
        For Each cpu As Object In processors
            cpu_ids = cpu_ids & ", " & cpu.ProcessorId
        Next cpu
        If cpu_ids.Length > 0 Then cpu_ids = cpu_ids.Substring(2)

        Return cpu_ids
    End Function
    '----------------------------------------------------------------

    Private Function CheckLisons() As Boolean

        'Make a stream to connect to the key.txt file
        Dim keyfile As New System.IO.StreamReader("key.txt")
        'Dim keyTXT As New System.IO.StreamWriter("KeyGen.txt", False)

        'read the key file and store the key in key as string
        Dim key As String = keyfile.ReadLine

        'genarate the unique id from the computer
        Dim beforEncrypt As String = SystemSerialNumber() + CpuId()

        'convert the string in to byte array
        Dim keyInBytes() As Byte = System.Text.Encoding.Unicode.GetBytes(beforEncrypt)

        'define a integer array to store encrypted keys
        'byte can only keep values betwn -128 to 127
        'adding two of them may overflow
        Dim keyInIntigers(beforEncrypt.Length) As Integer

        'genarate the key using the byte array and store it in integer array
        For i = 0 To beforEncrypt.Length - 1
            keyInIntigers(i) = keyInBytes(i) * 2 + keyInBytes(i + 1)
        Next

        'convert generated key array in to one string
        Dim afterEncrypt As String = keyInIntigers(0).ToString
        For i = 1 To beforEncrypt.Length - 1
            afterEncrypt = afterEncrypt + keyInIntigers(i).ToString
        Next

        'keyTXT.WriteLine(afterEncrypt)
        'MessageBox.Show(afterEncrypt)
        'keyTXT.Close()

        'If (SystemSerialNumber() + CpuId() = "CB22109644BFEBFBFF000206A7") Then
        If (afterEncrypt = key) Then
            Return True
        Else
            Return False
        End If
        'MessageBox.Show(SystemSerialNumber() + CpuId())
    End Function

   
End Class
