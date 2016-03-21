Public Class Student
    Public Property studID As Integer
    'Private studID As Integer
    Public Property lastName As String
    Public Property studGPA As Double

    'Public Property StudentID() As Integer
    '    Get
    '        Return studID
    '    End Get
    '    Set(value As Integer)
    '        If value > 2 Then
    '            MsgBox("Not Possible")
    '        Else
    '            studID = value
    '        End If
    '    End Set
    'End Property

    Public Sub New(ByVal pStudID As Integer, ByVal pLastName As String, ByVal pStudGPA As Double)
        studID = pStudID
        lastName = pLastName
        studGPA = pStudGPA
    End Sub

    Public Overrides Function ToString() As String
        Return studID & " " & lastName & " " & studGPA
    End Function

End Class
