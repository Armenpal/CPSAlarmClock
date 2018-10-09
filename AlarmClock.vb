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
        ClockKeypad.CloseKeypad()
        Timer.Start()
    End Sub

    Public Sub Alarm1Panel_Load(sender As Object, e As EventArgs) Handles Alarm1Panel.Load
        Alarm1Panel.TimePanel.DigitLED1.setDigit("0")
        Alarm1Panel.TimePanel.DigitLED2.setDigit("0")
        Alarm1Panel.TimePanel.DigitLED3.setDigit("0")
        Alarm1Panel.TimePanel.DigitLED4.setDigit("0")
        Alarm1Panel.TimePanel.TimeLabel.Text = DigitLED1.minDigitValue & DigitLED2.minDigitValue & ":" &
        DigitLED3.minDigitValue & DigitLED4.minDigitValue
        Alarm1Panel.TimePanel.AMRadioButton.Checked = True
        Alarm1Panel.AlarmKeypad.CloseKeypad()

    End Sub

    Public Sub Alarm2Panel_Load(sender As Object, e As EventArgs) Handles Alarm2Panel.Load
        Alarm2Panel.TimePanel.DigitLED1.setDigit("0")
        Alarm2Panel.TimePanel.DigitLED2.setDigit("0")
        Alarm2Panel.TimePanel.DigitLED3.setDigit("0")
        Alarm2Panel.TimePanel.DigitLED4.setDigit("0")
        Alarm2Panel.TimePanel.TimeLabel.Text = DigitLED1.minDigitValue & DigitLED2.minDigitValue & ":" &
        DigitLED3.minDigitValue & DigitLED4.minDigitValue
        Alarm2Panel.TimePanel.AMRadioButton.Checked = True
        Alarm2Panel.AlarmKeypad.CloseKeypad()

    End Sub

    Public Sub Alarm3Panel_Load(sender As Object, e As EventArgs) Handles Alarm3Panel.Load
        Alarm3Panel.TimePanel.DigitLED1.setDigit("0")
        Alarm3Panel.TimePanel.DigitLED2.setDigit("0")
        Alarm3Panel.TimePanel.DigitLED3.setDigit("0")
        Alarm3Panel.TimePanel.DigitLED4.setDigit("0")
        Alarm3Panel.TimePanel.TimeLabel.Text = DigitLED1.GetDigit() & DigitLED2.minDigitValue & ":" &
        DigitLED3.minDigitValue & DigitLED4.minDigitValue
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

        If Alarm1Panel.TimePanel.getTime() = timeCheck And Alarm1Panel.TimePanel.AMRadioButton.Checked = True Then
            PlaySoundEffect(Alarm1Panel.Alarmsound)
            Alarm1Panel.AnimatePicture()
        End If
        If Alarm1Panel.TimePanel.getTime() = timeCheck And Alarm1Panel.TimePanel.PMRadioButton.Checked = True Then
            PlaySoundEffect(Alarm1Panel.Alarmsound)
            Alarm1Panel.AnimatePicture()
        End If

        If Alarm2Panel.TimePanel.getTime() = timeCheck And Alarm2Panel.TimePanel.AMRadioButton.Checked = True Then
            PlaySoundEffect(Alarm2Panel.Alarmsound)
            Alarm2Panel.AnimatePicture()
        End If
        If Alarm2Panel.TimePanel.getTime() = timeCheck And Alarm2Panel.TimePanel.PMRadioButton.Checked = True Then
            PlaySoundEffect(Alarm2Panel.Alarmsound)
            Alarm2Panel.AnimatePicture()
        End If


        If Alarm3Panel.TimePanel.getTime() = timeCheck And Alarm3Panel.TimePanel.AMRadioButton.Checked = True Then
            PlaySoundEffect(Alarm3Panel.Alarmsound)
            Alarm3Panel.AnimatePicture()
        End If
        If Alarm3Panel.TimePanel.getTime() = timeCheck And Alarm3Panel.TimePanel.PMRadioButton.Checked = True Then
            PlaySoundEffect(Alarm3Panel.Alarmsound)
            Alarm3Panel.AnimatePicture()
        End If
    End Sub


End Class
