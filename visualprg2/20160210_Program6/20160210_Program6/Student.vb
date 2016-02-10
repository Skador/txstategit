Public Class Student
    Public Property studID As Integer
    Public Property lastName As String
    Public Property studGPA As Double

    Public Sub New(ByVal pStudID As Integer = 0, ByVal pLastName As String = "", ByVal pStudGPA As Double)
        studID = pStudID
        lastName = pLastName
        studGPA = pStudGPA
    End Sub

End Class
