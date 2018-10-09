Public Class Keypad

    Public Digit1 As New DigitLED
    Public Digit2 As New DigitLED
    Public Digit3 As New DigitLED
    Public Digit4 As New DigitLED
    Public Digit1set As Boolean
    Public Digit2set As Boolean
    Public Digit3set As Boolean
    Public Digit4set As Boolean
    Dim dateTimeInfo As DateTime = DateTime.Now
    Dim time As String = dateTimeInfo.ToString("hh")
    Dim TimeMin As String = dateTimeInfo.ToString("mm")
    Dim AmPm As String = Format(Now, "tt")
    Dim buttonArray(10) As Button

    Public Sub ActivateKeypad()
        Visible = True
    End Sub

    Public Sub CloseKeypad()
        Visible = False
    End Sub

    Public Sub ClickDigits(sender As Object, e As EventArgs) Handles DigitButton0.Click, DigitButton1.Click,
        DigitButton2.Click, DigitButton3.Click, DigitButton4.Click, DigitButton5.Click, DigitButton6.Click,
        DigitButton7.Click, DigitButton8.Click, DigitButton9.Click

        buttonArray(0) = (DigitButton0)
        buttonArray(1) = (DigitButton1)
        buttonArray(2) = (DigitButton2)
        buttonArray(3) = (DigitButton3)
        buttonArray(4) = (DigitButton4)
        buttonArray(5) = (DigitButton5)
        buttonArray(6) = (DigitButton6)
        buttonArray(7) = (DigitButton7)
        buttonArray(8) = (DigitButton8)
        buttonArray(9) = (DigitButton9)

        Dim tab = AlarmClock.AlarmClockTabs.SelectedTab.Name
        Dim button As Button = sender

        For Each num In buttonArray

            If Digit1set = False Then

                If Digit1.minDigitValue = 0 Then
                    activateDigits(2)
                    Digit1.setDigit(button.Text)
                    Digit1set = True
                End If
                If Digit1.minDigitValue < 1 Then
                    activateDigits(1)
                    Digit1.setDigit(button.Text)
                    Digit1set = True
                End If
                Exit For
            End If

            If Digit2set = False Then
                DeactivateDigit(3)
                Digit2set = True
                Digit2.setDigit(button.Text)
                Exit For
            End If
            If Digit3set = False Then
                activateDigits(3)
                Digit3set = True
                Digit3.setDigit(button.Text)
                Exit For
            End If
            If Digit4set = False Then
                Digit4set = True
                Digit4.setDigit(button.Text)
                Exit For
            End If

        Next num

        If tab = "ClockTab" Then
            AlarmClock.ClockTimePanel.TimeLabel.Text = Digit1.GetDigit() & Digit2.GetDigit() & ":" & Digit3.GetDigit() & Digit4.GetDigit()
        End If

        If tab = "AlarmTab1" Then
            AlarmClock.Alarm1Panel.TimePanel.TimeLabel.Text = Digit1.GetDigit() & Digit2.GetDigit() & ":" & Digit3.GetDigit() & Digit4.GetDigit()
        End If

        If tab = "AlarmTab2" Then
            AlarmClock.Alarm2Panel.TimePanel.TimeLabel.Text = Digit1.GetDigit() & Digit2.GetDigit() & ":" & Digit3.GetDigit() & Digit4.GetDigit()
        End If

        If tab = "AlarmTab3" Then
            AlarmClock.Alarm3Panel.TimePanel.TimeLabel.Text = Digit1.GetDigit() & Digit2.GetDigit() & ":" & Digit3.GetDigit() & Digit4.GetDigit()
        End If

    End Sub

    Public Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        sender = AlarmClock.AlarmClockTabs.SelectedTab.Name

        If sender = "ClockTab" Then
            Digit1.setDigit(time.Chars(0))
            Digit2.setDigit(time.Chars(1))
            Digit3.setDigit(TimeMin.Chars(0))
            Digit4.setDigit(TimeMin.Chars(1))
            AlarmClock.ClockTimePanel.setTime(Digit1, Digit2, Digit3, Digit4, "clock")
            Digit1set = False
            Digit2set = False
            Digit3set = False
            Digit4set = False
            CloseKeypad()
        End If

        If sender = "AlarmTab1" Then
            Digit1.setDigit("0")
            Digit2.setDigit("0")
            Digit3.setDigit("0")
            Digit4.setDigit("0")
            AlarmClock.Alarm1Panel.TimePanel.setTime(Digit1, Digit2, Digit3, Digit4, "alarm1")
            AlarmClock.Alarm1Panel.TimePanel.AMRadioButton.Checked = True
            Digit1set = False
            Digit2set = False
            Digit3set = False
            Digit4set = False
            CloseKeypad()
        End If

        If sender = "AlarmTab2" Then
            Digit1.setDigit("0")
            Digit2.setDigit("0")
            Digit3.setDigit("0")
            Digit4.setDigit("0")
            AlarmClock.Alarm2Panel.TimePanel.setTime(Digit1, Digit2, Digit3, Digit4, "alarm2")
            AlarmClock.Alarm2Panel.TimePanel.AMRadioButton.Checked = True
            Digit1set = False
            Digit2set = False
            Digit3set = False
            Digit4set = False
            CloseKeypad()
        End If

        If sender = "AlarmTab3" Then
            Digit1.setDigit("0")
            Digit2.setDigit("0")
            Digit3.setDigit("0")
            Digit4.setDigit("0")
            AlarmClock.Alarm3Panel.TimePanel.setTime(Digit1, Digit2, Digit3, Digit4, "alarm3")
            AlarmClock.Alarm3Panel.TimePanel.AMRadioButton.Checked = True
            Digit1set = False
            Digit2set = False
            Digit3set = False
            Digit4set = False
            CloseKeypad()
        End If

    End Sub

    Public Sub OkButton_Click(sender As Object, e As EventArgs) Handles OkButton.Click
        sender = AlarmClock.AlarmClockTabs.SelectedTab.Name

        If sender = "ClockTab" Then
            AlarmClock.ClockTimePanel.setTime(Digit1, Digit2, Digit3, Digit4, "clock")
            CloseKeypad()
        End If

        If sender = "AlarmTab1" Then
            AlarmClock.Alarm1Panel.TimePanel.setTime(Digit1, Digit2, Digit3, Digit4, "alarm1")
            CloseKeypad()
        End If

        If sender = "AlarmTab2" Then
            AlarmClock.Alarm2Panel.TimePanel.setTime(Digit1, Digit2, Digit3, Digit4, "alarm2")
            CloseKeypad()
        End If

        If sender = "AlarmTab3" Then
            AlarmClock.Alarm3Panel.TimePanel.setTime(Digit1, Digit2, Digit3, Digit4, "alarm3")
            CloseKeypad()
        End If

        DeactivateDigit(1)
    End Sub

    Public Sub Keypad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DeactivateDigit(1)
    End Sub


    Public Sub DeactivateDigit(ByVal num As Integer)
        If num = 1 Then
            DigitButton2.Enabled = False
            DigitButton3.Enabled = False
            DigitButton4.Enabled = False
            DigitButton5.Enabled = False
            DigitButton6.Enabled = False
            DigitButton7.Enabled = False
            DigitButton8.Enabled = False
            DigitButton9.Enabled = False
        End If
        If num = 2 Then
            DigitButton3.Enabled = False
            DigitButton4.Enabled = False
            DigitButton5.Enabled = False
            DigitButton6.Enabled = False
            DigitButton7.Enabled = False
            DigitButton8.Enabled = False
            DigitButton9.Enabled = False
        End If
        If num = 3 Then
            DigitButton6.Enabled = False
            DigitButton7.Enabled = False
            DigitButton8.Enabled = False
            DigitButton9.Enabled = False
        End If
    End Sub

    Public Sub activateDigits(ByVal num As Integer)
        If num = 1 Then
            DigitButton2.Enabled = True
            DigitButton3.Enabled = True
            DigitButton4.Enabled = True
            DigitButton5.Enabled = True
            DigitButton6.Enabled = True
            DigitButton7.Enabled = True
            DigitButton8.Enabled = True
            DigitButton9.Enabled = True
        End If

        If num = 2 Then
            DigitButton2.Enabled = True
        End If

        If num = 3 Then
            DigitButton6.Enabled = True
            DigitButton7.Enabled = True
            DigitButton8.Enabled = True
            DigitButton9.Enabled = True
        End If
    End Sub
End Class
