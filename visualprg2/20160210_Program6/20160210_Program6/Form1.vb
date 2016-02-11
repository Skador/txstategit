Public Class Form1

    Dim myStudentList As New List(Of Student)

    Dim salaries As New Dictionary(Of Integer, Decimal)


    Dim myNumbers() As Integer = {4, 104, 2, 102, 1, 101, 3, 103}

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        myStudentList.Add(New Student(1, "Anna", 3.75))
        myStudentList.Add(New Student(5, "John", 4.0))
        myStudentList.Add(New Student(4, "Smith", 4.0))
        myStudentList.Add(New Student(2, "Carol", 3.0))
        myStudentList.Add(New Student(3, "Michael", 2.0))

        ''Dim stud1 As New Student()
        ''stud1.StudentID = 7

        'myStudentList.Sort(AddressOf CompareID)

        'For Each item In myStudentList
        '    ListBox1.Items.Add(item)
        'Next

        'myStudentList.Sort(AddressOf CompareName)

        'For Each item In myStudentList
        '    ListBox1.Items.Add(item)
        'Next

        ''myStudentList.Sort(AddressOf CompareGPA)

        ''For Each item In myStudentList
        ''    ListBox1.Items.Add(item)
        ''Next

        ''For Dictionaries, variable.Add(KEY, VALUE)
        'salaries.Add(3001, 3000D)
        'salaries.Add(3002, 4000D)
        'salaries.Add(2001, 3000D)
        'Dim entry As KeyValuePair(Of Integer, Decimal)

        'For Each entry In salaries
        '    ListBox1.Items.Add(entry.Key & " ----> " & entry.Value)
        'Next

        ''MsgBox(salaries.Values.Sum)
        ''MsgBox(salaries.Values.Average)

        'Dim query = From aStudent In myStudentList
        '            Select aStudent
        '            Order By aStudent.studID Descending

        'Dim query = From aStudent In myStudentList
        '            Select aStudent
        '            Order By aStudent.lastName Ascending

        ''Dim query = From aStudent In myStudentList
        ''            Select aStudent
        ''            Order By aStudent.studGPA Descending

        'For Each item In query
        '    ListBox1.Items.Add(item)
        'Next

        'DataGridView1.DataSource = query.ToList

        Dim intQuery = From item As Integer In myNumbers
                       Select item
                       Where item > 4

        For Each item In intQuery
            ListBox1.Items.Add(item)
        Next

        DataGridView1.DataSource = intQuery.ToList

    End Sub

    Public Function CompareID(ByVal x As Student, ByVal y As Student)
        Return x.StudID.CompareTo(y.StudID)
    End Function

    'Public Function CompareID(ByVal x As Student, ByVal y As Student)
    '    Return x.StudentID().CompareTo(y.StudentID())
    'End Function


    Public Function CompareName(ByVal x As Student, ByVal y As Student)
        Return x.lastName.CompareTo(y.lastName)
    End Function

    Public Function CompareGPA(ByVal x As Student, ByVal y As Student)
        Return x.studGPA.CompareTo(y.studGPA)
    End Function
End Class
