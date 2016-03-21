Public Enum YearLevel
    Freshman
    Sophomore
    Junior
    Senior
End Enum

Public Enum AcademicStatus
    Honors
    Normal
    Warning
    Probation
End Enum

Public Class Student
    Public Property Credits As Integer
    Public Property Level As YearLevel
    Public Property GradeAverage As Double
    Public Property Status As AcademicStatus
    Public Sub New(ByVal pCredits As Integer, ByVal pLevel As YearLevel, ByVal pGradeAverage As Double, ByVal pStatus As AcademicStatus)
        Credits = pCredits
        Level = pLevel
        GradeAverage = pGradeAverage
        Status = pStatus
    End Sub
End Class
