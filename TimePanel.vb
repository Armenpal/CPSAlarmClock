
Public Class TimePanel

    Public alarmTime As String
    Public DigitLED1 As New DigitLED()
    Public DigitLED2 As New DigitLED()
    Public DigitLED3 As New DigitLED()
    Public DigitLED4 As New DigitLED()
    Dim dateTimeInfo As DateTime = DateTime.Now
    Dim time As String = dateTimeInfo.ToString("hh")
    Dim TimeMin As String = dateTimeInfo.ToString("mm")
    Dim AmPm As String = Format(Now, "tt")


    Public Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        ResetTime()
    End Sub

    Public Sub ResetTime()
        If AlarmClock.AlarmClockTabs.SelectedTab.Name = "ClockTab" Then
            DigitLED1.setDigit(time.Chars(0))
            DigitLED2.setDigit(time.Chars(1))
            DigitLED3.setDigit(TimeMin.Chars(0))
            DigitLED4.setDigit(TimeMin.Chars(1))
            setTime(DigitLED1, DigitLED2, DigitLED3, DigitLED4, "clock")
            AlarmClock.ClockKeypad.CloseKeypad()
        End If

        If AlarmClock.AlarmClockTabs.SelectedTab.Name = "AlarmTab1" Then
            DigitLED1.setDigit("0")
            DigitLED2.setDigit("0")
            DigitLED3.setDigit("0")
            DigitLED4.setDigit("0")
            setTime(DigitLED1, DigitLED2, DigitLED3, DigitLED4, "alarm1")
            AlarmClock.Alarm1Panel.TimePanel.AMRadioButton.Checked = True
            AlarmClock.Alarm1Panel.AlarmKeypad.CloseKeypad()
        End If

        If AlarmClock.AlarmClockTabs.SelectedTab.Name = "AlarmTab2" Then
            DigitLED1.setDigit("0")
            DigitLED2.setDigit("0")
            DigitLED3.setDigit("0")
            DigitLED4.setDigit("0")
            setTime(DigitLED1, DigitLED2, DigitLED3, DigitLED4, "alarm2")
            AlarmClock.Alarm2Panel.TimePanel.AMRadioButton.Checked = True
            AlarmClock.Alarm2Panel.AlarmKeypad.CloseKeypad()
        End If

        If AlarmClock.AlarmClockTabs.SelectedTab.Name = "AlarmTab3" Then
            DigitLED1.setDigit("0")
            DigitLED2.setDigit("0")
            DigitLED3.setDigit("0")
            DigitLED4.setDigit("0")
            setTime(DigitLED1, DigitLED2, DigitLED3, DigitLED4, "alarm3")
            AlarmClock.Alarm3Panel.TimePanel.AMRadioButton.Checked = True
            AlarmClock.Alarm3Panel.AlarmKeypad.CloseKeypad()
        End If
    End Sub

    Public Sub SetButton_Click(sender As Object, e As EventArgs) Handles SetButton.Click
        sender = AlarmClock.AlarmClockTabs.SelectedTab.Name

        If sender = "ClockTab" Then
            DigitLED1.setDigit("0")
            DigitLED2.setDigit("0")
            DigitLED3.setDigit("0")
            DigitLED4.setDigit("0")
            setTime(DigitLED1, DigitLED2, DigitLED3, DigitLED4, "clock")
            AlarmClock.ClockKeypad.ActivateKeypad()
        End If

        If sender = "AlarmTab1" Then
            AlarmClock.Alarm1Panel.AlarmKeypad.ActivateKeypad()
        End If

        If sender = "AlarmTab2" Then
            AlarmClock.Alarm2Panel.AlarmKeypad.ActivateKeypad()
        End If

        If sender = "AlarmTab3" Then
            AlarmClock.Alarm3Panel.AlarmKeypad.ActivateKeypad()
        End If
    End Sub

    Public Sub setTime(time As DigitLED, time2 As DigitLED, time3 As DigitLED, time4 As DigitLED, type As String)

        If AmPm = "PM" Then
            AlarmClock.ClockTimePanel.PMRadioButton.Checked = True
        End If

        If AmPm = "AM" Then
            AlarmClock.ClockTimePanel.AMRadioButton.Checked = True
        End If

        If type = "clock" Then
            alarmTime = time.GetDigit() & time2.GetDigit() & ":" & time3.GetDigit() & time4.GetDigit()
            AlarmClock.ClockTimePanel.TimeLabel.Text = time.GetDigit() & time2.GetDigit() & ":" & time3.GetDigit() & time4.GetDigit()
        End If

        If type = "alarm1" Then
            alarmTime = time.GetDigit() & time2.GetDigit() & ":" & time3.GetDigit() & time4.GetDigit()
            AlarmClock.Alarm1Panel.TimePanel.TimeLabel.Text = time.GetDigit() & time2.GetDigit() & ":" & time3.GetDigit() & time4.GetDigit()
        End If

        If type = "alarm2" Then
            alarmTime = time.GetDigit() & time2.GetDigit() & ":" & time3.GetDigit() & time4.GetDigit()
            AlarmClock.Alarm2Panel.TimePanel.TimeLabel.Text = time.GetDigit() & time2.GetDigit() & ":" & time3.GetDigit() & time4.GetDigit()
        End If

        If type = "alarm3" Then
            alarmTime = time.GetDigit() & time2.GetDigit() & ":" & time3.GetDigit() & time4.GetDigit()
            AlarmClock.Alarm3Panel.TimePanel.TimeLabel.Text = time.GetDigit() & time2.GetDigit() & ":" & time3.GetDigit() & time4.GetDigit()
        End If
    End Sub

    Public Function getTime() As String
        Return alarmtime
    End Function
End Class
