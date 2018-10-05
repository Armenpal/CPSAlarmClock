Public Class AlarmClock

    Public see As Boolean
    Public DigitLED1 As New DigitLED()
    Public DigitLED2 As New DigitLED()
    Public DigitLED3 As New DigitLED()
    Public DigitLED4 As New DigitLED()
    Public DigitButton0 As Button
    Public DigitButton1 As Button
    Public num As Integer

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
        'PlaySoundEffect()
    End Sub


End Class
