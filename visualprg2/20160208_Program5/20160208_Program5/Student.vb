Public Class Student
    Implements IComparable

    Public Property firstName As String
    Public Property lastName As String

    Public Sub New(Optional ByVal pFirstName As String = "", Optional ByVal pLastName As String = "")
        firstName = pFirstName
        lastName = pLastName
    End Sub

    Public Function CompareTo(ByVal obj As Object) As Integer Implements IComparable.CompareTo
        Dim s As Student = CType(obj, Student)
        Return Me.lastName.CompareTo(s.lastName)
    End Function

    Public Overrides Function Equals(obj As Object) As Boolean
        Return Me.firstName.Equals(CType(obj, Student).firstName)
    End Function
    
End Class
