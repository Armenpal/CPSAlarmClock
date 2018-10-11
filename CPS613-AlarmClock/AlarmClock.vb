Public Class AlarmClock

    Public DigitLED1 As New DigitLED()
    Public DigitLED2 As New DigitLED()
    Public DigitLED3 As New DigitLED()
    Public DigitLED4 As New DigitLED()
    Public num As Integer
    Dim dateTimeInfo As DateTime = DateTime.Now
    Dim time As String = dateTimeInfo.ToString("hh")
    Dim TimeMin As String = dateTimeInfo.ToString("mm")
    Dim AmPm As String = Format(Now, "tt")
    Dim timeCheck As String

    Public Sub AlarmClock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DigitLED1.setDigit(time.Chars(0))
        DigitLED2.setDigit(time.Chars(1))
        DigitLED3.setDigit(TimeMin.Chars(0))
        DigitLED4.setDigit(TimeMin.Chars(1))
        ClockTimePanel.setTime(DigitLED1, DigitLED2, DigitLED3, DigitLED4, "clock")
        ClockKeypad.CloseKeypad()
        Timer.Start()
    End Sub

    Public Sub Alarm1Panel_Load(sender As Object, e As EventArgs) Handles Alarm1Panel.Load
        DigitLED1.setDigit("0")
        DigitLED2.setDigit("0")
        DigitLED3.setDigit("0")
        DigitLED4.setDigit("0")
        Alarm1Panel.TimePanel.setTime(DigitLED1, DigitLED2, DigitLED3, DigitLED4, "alarm1")
        Alarm1Panel.TimePanel.AMRadioButton.Checked = True
        Alarm1Panel.AlarmKeypad.CloseKeypad()

    End Sub

    Public Sub Alarm2Panel_load(sender As Object, e As EventArgs) Handles Alarm2Panel.Load
        DigitLED1.setDigit("0")
        DigitLED2.setDigit("0")
        DigitLED3.setDigit("0")
        DigitLED4.setDigit("0")
        Alarm2Panel.TimePanel.setTime(DigitLED1, DigitLED2, DigitLED3, DigitLED4, "alarm2")
        Alarm2Panel.TimePanel.AMRadioButton.Checked = True
        Alarm2Panel.AlarmKeypad.CloseKeypad()
    End Sub


    Public Sub Alarm3Panel_Load(sender As Object, e As EventArgs) Handles Alarm3Panel.Load
        DigitLED1.setDigit("0")
        DigitLED2.setDigit("0")
        DigitLED3.setDigit("0")
        DigitLED4.setDigit("0")
        Alarm3Panel.TimePanel.setTime(DigitLED1, DigitLED2, DigitLED3, DigitLED4, "alarm3")
        Alarm3Panel.TimePanel.AMRadioButton.Checked = True
        Alarm3Panel.AlarmKeypad.CloseKeypad()
    End Sub

    Public Sub Alarm1CheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles Alarm1CheckBox.CheckedChanged
        If Alarm1CheckBox.Checked Then
            Alarm1Panel.AlarmCheckBox.Checked = True
        ElseIf Alarm1CheckBox.Checked = False Then
            Alarm1Panel.AlarmCheckBox.Checked = False
        End If
    End Sub

    Public Sub Alarm2CheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles Alarm2CheckBox.CheckedChanged
        If Alarm2CheckBox.Checked Then
            Alarm2Panel.AlarmCheckBox.Checked = True
        ElseIf Alarm2CheckBox.Checked = False Then
            Alarm2Panel.AlarmCheckBox.Checked = False
        End If
    End Sub

    Public Sub Alarm3CheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles Alarm3CheckBox.CheckedChanged
        If Alarm3CheckBox.Checked Then
            Alarm3Panel.AlarmCheckBox.Checked = True
        ElseIf Alarm3CheckBox.Checked = False Then
            Alarm3Panel.AlarmCheckBox.Checked = False
        End If
    End Sub

    Public Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick

        DigitLED1.setDigit(time.Chars(0))
        DigitLED2.setDigit(time.Chars(1))
        DigitLED3.setDigit(TimeMin.Chars(0))
        DigitLED4.setDigit(TimeMin.Chars(1))
        timeCheck = DigitLED1.GetDigit() & DigitLED2.GetDigit() & ":" & DigitLED3.GetDigit() & DigitLED4.GetDigit()

        If Alarm1Panel.TimePanel.getTime() = timeCheck And Alarm1Panel.TimePanel.AMRadioButton.Checked = True And Alarm1Panel.AlarmCheckBox.Checked = True Then
            PlaySoundEffect(Alarm1Panel.Alarmsound)
            Alarm1Panel.AnimatePicture()
        End If
        If Alarm1Panel.TimePanel.getTime() = timeCheck And Alarm1Panel.TimePanel.PMRadioButton.Checked = True And Alarm1Panel.AlarmCheckBox.Checked = True Then
            PlaySoundEffect(Alarm1Panel.Alarmsound)
            Alarm1Panel.AnimatePicture()
        End If

        If Alarm2Panel.TimePanel.getTime() = timeCheck And Alarm2Panel.TimePanel.AMRadioButton.Checked = True And Alarm2Panel.AlarmCheckBox.Checked = True Then
            PlaySoundEffect(Alarm2Panel.Alarmsound)
            Alarm2Panel.AnimatePicture()
        End If
        If Alarm2Panel.TimePanel.getTime() = timeCheck And Alarm2Panel.TimePanel.PMRadioButton.Checked = True And Alarm2Panel.AlarmCheckBox.Checked = True Then
            PlaySoundEffect(Alarm2Panel.Alarmsound)
            Alarm2Panel.AnimatePicture()
        End If


        If Alarm3Panel.TimePanel.getTime() = timeCheck And Alarm3Panel.TimePanel.AMRadioButton.Checked = True And Alarm3Panel.AlarmCheckBox.Checked = True Then
            PlaySoundEffect(Alarm3Panel.Alarmsound)
            Alarm3Panel.AnimatePicture()
        End If
        If Alarm3Panel.TimePanel.getTime() = timeCheck And Alarm3Panel.TimePanel.PMRadioButton.Checked = True And Alarm3Panel.AlarmCheckBox.Checked = True Then
            PlaySoundEffect(Alarm3Panel.Alarmsound)
            Alarm3Panel.AnimatePicture()
        End If
    End Sub


End Class
