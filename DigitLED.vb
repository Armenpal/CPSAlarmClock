Public Class DigitLED

    Public maxDigitValue As Integer
    Public minDigitValue As Integer
    Public value As Integer

    Public Function GetDigit() As String
        Return value
    End Function

    Public Sub SetColour()

    End Sub

    Public Function setDigit(obj As String)
        value = CInt(obj)
    End Function

    Public Sub New()
        minDigitValue = 0
        maxDigitValue = 0
        value = 0
    End Sub
End Class
