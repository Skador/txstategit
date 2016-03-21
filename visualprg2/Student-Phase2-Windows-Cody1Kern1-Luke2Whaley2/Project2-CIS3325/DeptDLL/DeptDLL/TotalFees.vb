Public Class TotalFees
    Public Enum classType
        Graduate
        Undergraduate
    End Enum

    Public Function TotalFees(ByVal pClassification As classType, ByVal pNoOfCourses As Integer)
        Select Case pClassification
            Case classType.Graduate
                Return pNoOfCourses * 1300
            Case classType.Undergraduate
                Return pNoOfCourses * 900
            Case Else
                Return pNoOfCourses * 0
        End Select

    End Function
End Class
