Public Class Keypad


    Public Digit1 As New DigitLED
    Public Digit2 As New DigitLED
    Public Digit3 As New DigitLED
    Public Digit4 As New DigitLED
    Public Digit1set As Boolean
    Public Digit2set As Boolean
    Public Digit3set As Boolean
    Public Digit4set As Boolean
    Public keypadValue As Integer
    Public obj As String
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

        Dim button As Button = sender

        For Each num In buttonArray
            If Digit1.GetDigit() IsNot "2" Then
                activateDigits(1)
                Digit1.setDigit(button.Text)
            End If
            If Digit2.GetDigit() IsNot "-1" Then
                Digit2set = True
                Digit2.setDigit(button.Text)
            End If
            If Digit3.GetDigit() IsNot "9" Then
                Digit3set = True
                Digit3.setDigit(button.Text)
            End If
            If Digit4.GetDigit() IsNot "9" Then
                Digit4set = True
                Digit4.setDigit(button.Text)
            End If

        Next num
        AlarmClock.ClockTimePanel.TimeLabel.Text = Digit1.GetDigit() & Digit2.GetDigit() & ":" & Digit3.GetDigit() & Digit4.GetDigit()

    End Sub

    Public Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        CloseKeypad()
    End Sub

    Public Sub OkButton_Click(sender As Object, e As EventArgs) Handles OkButton.Click
        AlarmClock.ClockTimePanel.setTime(Digit1, Digit2, Digit3, Digit4)
        CloseKeypad()
    End Sub

    Public Sub Keypad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
    End Sub
End Class
