Public Class DigitLED

    Public maxDigitValue As Integer = 0
    Public minDigitValue As Integer = 0

    Public Function GetDigit() As String
        Return minDigitValue
    End Function

    Public Property MaxDigit As Integer
        Get
            Return maxDigitValue
        End Get
        Set(value As Integer)
            minDigitValue = value
        End Set
    End Property

    Public Property MinDigit As Integer
        Get
            Return minDigitValue
        End Get
        Set(value As Integer)
            minDigitValue = value
        End Set
    End Property

    Public Sub setDigit(obj As String)
        minDigitValue = CInt(obj)
    End Sub

End Class
