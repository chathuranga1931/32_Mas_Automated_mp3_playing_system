Public Class NewEventMp


    Public allstring As String
    Public eventName As String
    Public eventID As String
    Public eventStartTime As String
    Public eventEndTime As String
    Public status As Boolean = 0
    Public playListLocation As String
    Public timeInSeconds As Integer
    Public index As Integer
    Public timeGap As Integer
    Public Shr As Integer
    Public Smin As Integer
    Public Ssec As Integer
    Public Ehr As Integer
    Public Emin As Integer
    Public Esec As Integer

    Dim timeCurrent As String = TimeOfDay.ToString("HH:mm:ss")
    Dim a() As String = timeCurrent.Split(":"c)
    Dim timeInSecondsCurrent As Integer = Val(a(0)) * 3600 + Val(a(1)) * 60 + Val(a(2))

    Public Sub New(ByVal all As String)
        Me.allstring = all

        Try
            Dim result As String() = allstring.Split("$"c)
            eventName = result(0).ToString
            eventID = result(1).ToString
            eventStartTime = result(2).ToString

            Dim mon As Integer = result(3)
            Dim tue As Integer = result(4)
            Dim wed As Integer = result(5)
            Dim thu As Integer = result(6)
            Dim fri As Integer = result(7)
            Dim sat As Integer = result(8)
            Dim sun As Integer = result(9)

            If Now.DayOfWeek = 1 And mon = 11 Then
                status = 1
            ElseIf Now.DayOfWeek = 2 And tue = 21 Then
                status = 1
            ElseIf Now.DayOfWeek = 3 And wed = 31 Then
                status = 1
            ElseIf Now.DayOfWeek = 4 And thu = 41 Then
                status = 1
            ElseIf Now.DayOfWeek = 5 And fri = 51 Then
                status = 1
            ElseIf Now.DayOfWeek = 6 And sat = 61 Then
                status = 1
            ElseIf Now.DayOfWeek = 0 And sun = 71 Then
                status = 1
            Else
                status = 0
            End If

            eventEndTime = result(10).ToString
            playListLocation = result(11).ToString
        Catch ex As Exception

        End Try
        Try
            If Me.status = True Then
                Dim ab() As String = eventStartTime.Split(":"c)
                'MessageBox.Show(a(0))
                'timeInSeconds = Val(a(0))
                'MessageBox.Show(timeInSeconds.ToString)
                timeInSeconds = Val(ab(0)) * 3600 + Val(ab(1)) * 60 + Val(ab(2))
                Shr = Val(ab(0))
                Smin = Val(ab(1))
                Ssec = Val(ab(2))

                timeGap = timeInSeconds - timeInSecondsCurrent
                If timeGap < 0 Then
                    timeGap = timeGap + 3600 * 24
                End If
            Else
                timeGap = 3600 * 23 + 59 * 60 + 59
            End If

        Catch ex As Exception

        End Try
    End Sub

    Sub SetIndex(ByVal f As Integer)
        index = f
    End Sub

    Public Function GetTimeGap() As Integer
        Try
            If Me.status = True Then
                Dim ab() As String = eventStartTime.Split(":"c)
                'MessageBox.Show(a(0))
                'timeInSeconds = Val(a(0))
                'MessageBox.Show(timeInSeconds.ToString)
                Dim timeCurrent As String = TimeOfDay.ToString("HH:mm:ss")
                Dim a() As String = timeCurrent.Split(":"c)
                Dim timeInSecondsCurrent As Integer = Val(a(0)) * 3600 + Val(a(1)) * 60 + Val(a(2))
                timeInSeconds = Val(ab(0)) * 3600 + Val(ab(1)) * 60 + Val(ab(2))

                timeGap = timeInSeconds - timeInSecondsCurrent
                If timeGap < 0 Then
                    timeGap = timeGap + 3600 * 24
                End If
                Return timeGap
            Else
                timeGap = 3600 * 23 + 59 * 60 + 59
                Return timeGap
            End If
        Catch ex As Exception

        End Try

    End Function



End Class
