Public Class AlarmClock

    Public see As Boolean
    Public DigitLED1 As New DigitLED()
    Public DigitLED2 As New DigitLED()
    Public DigitLED3 As New DigitLED()
    Public DigitLED4 As New DigitLED()
    Public DigitButton0 As Button
    Public DigitButton1 As Button
    Public DigitButton2 As Button
    Public DigitButton3 As Button
    Public DigitButton4 As Button
    Public DigitButton5 As Button
    Public DigitButton6 As Button
    Public DigitButton7 As Button
    Public DigitButton8 As Button
    Public DigitButton9 As Button
    Public DigitArray As New ArrayList

    Public Sub AlarmClock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ClockKeypad.Hide()
    End Sub

    Public Sub Alarm1Panel_Load(sender As Object, e As EventArgs) Handles Alarm1Panel.Load
        Alarm1Panel.TimePanel.DigitLED1.setDigit("0")
        Alarm1Panel.TimePanel.DigitLED2.setDigit("0")
        Alarm1Panel.TimePanel.DigitLED3.setDigit("0")
        Alarm1Panel.TimePanel.DigitLED4.setDigit("0")
        Alarm1Panel.TimePanel.setTime(DigitLED1, DigitLED2, DigitLED3, DigitLED4)
        Alarm1Panel.AlarmKeypad.Hide()
        If AlarmClockTabs.SelectedTab.Name = "AlarmTab1" Then

        End If
    End Sub

    Public Sub Alarm2Panel_Load(sender As Object, e As EventArgs) Handles Alarm2Panel.Load
        see = Alarm2Panel.TimePanel.SetButtonClick
        Alarm2Panel.TimePanel.DigitLED1.setDigit("0")
        Alarm2Panel.TimePanel.DigitLED2.setDigit("0")
        Alarm2Panel.TimePanel.DigitLED3.setDigit("0")
        Alarm2Panel.TimePanel.DigitLED4.setDigit("0")
        Alarm2Panel.TimePanel.setTime(DigitLED1, DigitLED2, DigitLED3, DigitLED4)
        Alarm2Panel.AlarmKeypad.Hide()
        If AlarmClockTabs.SelectedTab.Name = "AlarmTab2" Then

            If see = True Then
                Alarm2Panel.AlarmKeypad.ActivateKeypad()
            End If
        End If

    End Sub

    Public Sub Alarm3Panel_Load(sender As Object, e As EventArgs) Handles Alarm3Panel.Load
        Alarm3Panel.TimePanel.DigitLED1.setDigit("0")
        Alarm3Panel.TimePanel.DigitLED2.setDigit("0")
        Alarm3Panel.TimePanel.DigitLED3.setDigit("0")
        Alarm3Panel.TimePanel.DigitLED4.setDigit("0")
        Alarm3Panel.TimePanel.setTime(DigitLED1, DigitLED2, DigitLED3, DigitLED4)
        Alarm3Panel.AlarmKeypad.Hide()
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

    Private Sub Alarm3CheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles Alarm3CheckBox.CheckedChanged
        If Alarm3CheckBox.Checked Then
            Alarm3Panel.AlarmCheckBox.Checked = True
        ElseIf Alarm3CheckBox.Checked = False Then
            Alarm3Panel.AlarmCheckBox.Checked = False
        End If
    End Sub
End Class
