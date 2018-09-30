
Public Class TimePanel

    Public OldTime As String
    Public NewTime As String
    Public currentDigit As Integer
    Public Alarmkeypad As Keypad
    Public DigitLED1 As New DigitLED()
    Public DigitLED2 As New DigitLED()
    Public DigitLED3 As New DigitLED()
    Public DigitLED4 As New DigitLED()
    Dim dateTimeInfo As DateTime = DateTime.Now
    Dim time As String = dateTimeInfo.ToString("hh")
    Dim TimeMin As String = dateTimeInfo.ToString("mm")
    Dim AmPm As String = Format(Now, "tt")


    Public Sub TimePanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DigitLED1.setDigit(time.Chars(0))
        DigitLED2.setDigit(time.Chars(1))
        DigitLED3.setDigit(TimeMin.Chars(0))
        DigitLED4.setDigit(TimeMin.Chars(1))
        OldTime = DigitLED1.minDigitValue & DigitLED2.minDigitValue & ":" & DigitLED3.minDigitValue & DigitLED4.minDigitValue
        setTime(DigitLED1, DigitLED2, DigitLED3, DigitLED4)

    End Sub

    Public Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        ResetTime()
    End Sub

    Public Sub ResetTime()
        If AlarmClock.AlarmClockTabs.SelectedTab.Name = "ClockTab" Then
            DigitLED1.setDigit(time.Chars(0))
            DigitLED2.setDigit(time.Chars(1))
            DigitLED3.setDigit(TimeMin.Chars(0))
            DigitLED4.setDigit(TimeMin.Chars(1))
            setTime(DigitLED1, DigitLED2, DigitLED3, DigitLED4)
            AlarmClock.ClockKeypad.CloseKeypad()
        End If

        If AlarmClock.AlarmClockTabs.SelectedTab.Name = "AlarmTab1" Then
            DigitLED1.setDigit("0")
            DigitLED2.setDigit("0")
            DigitLED3.setDigit("0")
            DigitLED4.setDigit("0")
            setTime(DigitLED1, DigitLED2, DigitLED3, DigitLED4)
            AlarmClock.Alarm1Panel.AlarmKeypad.CloseKeypad()
        End If

        If AlarmClock.AlarmClockTabs.SelectedTab.Name = "AlarmTab2" Then
            DigitLED1.setDigit("0")
            DigitLED2.setDigit("0")
            DigitLED3.setDigit("0")
            DigitLED4.setDigit("0")
            setTime(DigitLED1, DigitLED2, DigitLED3, DigitLED4)
            AlarmClock.Alarm2Panel.AlarmKeypad.CloseKeypad()
        End If

        If AlarmClock.AlarmClockTabs.SelectedTab.Name = "AlarmTab3" Then
            DigitLED1.setDigit("0")
            DigitLED2.setDigit("0")
            DigitLED3.setDigit("0")
            DigitLED4.setDigit("0")
            setTime(DigitLED1, DigitLED2, DigitLED3, DigitLED4)
            AlarmClock.Alarm3Panel.AlarmKeypad.CloseKeypad()
        End If
    End Sub

    Public Sub SetButton_Click(sender As Object, e As EventArgs) Handles SetButton.Click
        If AlarmClock.AlarmClockTabs.SelectedTab.Name = "ClockTab" Then
            DigitLED1.setDigit("0")
            DigitLED2.setDigit("0")
            DigitLED3.setDigit("0")
            DigitLED4.setDigit("0")
            setTime(DigitLED1, DigitLED2, DigitLED3, DigitLED4)
            AlarmClock.ClockKeypad.ActivateKeypad()
        End If

        If AlarmClock.AlarmClockTabs.SelectedTab.Name = "AlarmTab1" Then
            AlarmClock.Alarm1Panel.AlarmKeypad.ActivateKeypad()
        End If

        If AlarmClock.AlarmClockTabs.SelectedTab.Name = "AlarmTab2" Then
            AlarmClock.Alarm2Panel.AlarmKeypad.ActivateKeypad()
        End If

        If AlarmClock.AlarmClockTabs.SelectedTab.Name = "AlarmTab3" Then
            AlarmClock.Alarm3Panel.AlarmKeypad.ActivateKeypad()
        End If
    End Sub

    Public Sub setTime(time As DigitLED, time2 As DigitLED, time3 As DigitLED, time4 As DigitLED)
        If AmPm = "PM" Then
            AlarmClock.ClockTimePanel.PMRadioButton.Checked = True
        End If

        If AmPm = "AM" Then
            AlarmClock.ClockTimePanel.AMRadioButton.Checked = True
        End If
        AlarmClock.ClockTimePanel.TimeLabel.Text = time.GetDigit() & time2.GetDigit() & ":" & time3.GetDigit() & time4.GetDigit()
    End Sub

    Public Function getTime() As String
        Return OldTime
    End Function
End Class
