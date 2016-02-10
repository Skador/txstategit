Public Class Form1

    Dim myStudentList As New List(Of Student)

    'Dim salaries As New Dictionary(Of Integer, Decimal)
    'Dim myNumbers() As Integer = {4, 104, 2, 102, 1, 101, 3, 103}

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        myStudentList.Add(New Student(1, "Anna", 3.75))
        myStudentList.Add(New Student(5, "John", 4.0))
        myStudentList.Add(New Student(4, "Smith", 4.0))
        myStudentList.Add(New Student(2, "Carol", 3.0))
        myStudentList.Add(New Student(3, "Michael", 2.0))

    End Sub
End Class
