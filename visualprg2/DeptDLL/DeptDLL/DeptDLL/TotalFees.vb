Public Class TotalFees
    Public Enum classType
        Graduate
        Undergraduate
    End Enum

    Public Function TotalFees(ByVal x As classType, ByVal y As Integer)
        Select Case x
            Case classType.Graduate
                Return y * 1300
            Case classType.Undergraduate
                Return y * 900
            Case Else
                Return y * 0
        End Select

    End Function
End Class
