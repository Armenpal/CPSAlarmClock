Public Class Keypad

    Public keypadValue As Integer
    Public obj As String

    Public Sub ActivateKeypad()
        Visible = True
    End Sub

    Public Sub CloseKeypad()
        Visible = False
    End Sub

    Public Sub ActivateDigits(sender As Object, e As EventArgs) Handles DigitButton0.Click, DigitButton1.Click,
        DigitButton2.Click, DigitButton3.Click, DigitButton4.Click, DigitButton5.Click, DigitButton6.Click,
        DigitButton7.Click, DigitButton8.Click, DigitButton9.Click

        Dim b As Button = DirectCast(sender, Button)
        obj = b.Text
        AlarmClock.ClockTimePanel.DigitLED1.setDigit(obj)

    End Sub

    Public Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        CloseKeypad()
    End Sub

    Public Sub OkButton_Click(sender As Object, e As EventArgs) Handles OkButton.Click
        CloseKeypad()
    End Sub


End Class
