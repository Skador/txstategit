Public Class Person

    Public Property Name As String

    Sub New(ByVal pName As String)
        Name = pName
    End Sub

    'Sub New(Optional ByVal pName As String = "x")
    '    Name = pName
    'End Sub

    Public Overrides Function ToString() As String
        Return "My Name is : " & Name
    End Function

End Class
