Public Class Form1

    Dim scores() As Integer = {80, 60, 75, 100}
    Dim scoreList As New ArrayList(scores)

    'Dim myCustList As New ArrayList

    Dim stud1 As New Student("Marry", "Johns")
    Dim stud2 As New Student("Marry", "Poppins")

    Dim studList As New ArrayList

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'scoreList.Add(100)
        'scoreList.Insert(0, 99)

        ''For Each blahblahblah As Integer In scoreList
        ''    MsgBox(blahblahblah)
        ''Next

        'scoreList.Sort()
        'scoreList.Reverse()

        'For Each element As Integer In scoreList
        '    ListBox1.Items.add(element)
        'Next

        'studList.Add(New Student("Marlon", "Johny"))

        Dim i As Integer = stud1.CompareTo(stud2)
        MsgBox(i)

        ''scoreList.Add(90)
        'scoreList.Insert(0, 90)
        'scoreList.Sort()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        scoreList.Add(CInt(TextBox1.Text))
    End Sub
End Class
