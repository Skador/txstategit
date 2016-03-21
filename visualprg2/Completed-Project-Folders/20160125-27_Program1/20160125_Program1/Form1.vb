Public Class Form1

    'Defines a new object via the specified class
    Dim freshman As New Student(100, "Mary", "Johnson")
    'Different way to define the specified class
    'Dim freshman2 As Student

    'Define via the new "NEW"
    Dim freshman2 As New Student(111)
    Dim freshman3 As New Student(112, "Mark")
    Dim freshman4 As New Student(113, , "Jennings")

    'Adding Behaviour


    'Creates a new "Form" object
    Dim frmMyForm As New Form

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Second half of the different way
        'freshman2 = New Student

        'Displays the current freshman's details
        MsgBox("First Half " & freshman.StudentId & " " & freshman.studentFirstName & " " & freshman.studentLastName)
        MsgBox("First Half " & freshman2.StudentId & " " & freshman2.studentFirstName & " " & freshman2.studentLastName)
        MsgBox("First Half " & freshman3.StudentId & " " & freshman3.studentFirstName & " " & freshman3.studentLastName)
        MsgBox("First Half " & freshman4.StudentId & " " & freshman4.studentFirstName & " " & freshman4.studentLastName)

        'Examples for setting public class variables Useing Public Properties
        freshman.studentFirstName = "John"
        freshman.studentLastName = "Johnson"
        freshman.StudentId = 125

        'Another Example of setting public class variables using the different way
        freshman2.studentFirstName = "Stacey"
        freshman2.studentLastName = "Johnson"
        freshman2.StudentId = 124

        'Utilizing the Clear() method
        freshman3.Clear()

        'Displays the freshman's details after changes
        MsgBox("Second Half " & freshman.StudentId & " " & freshman.studentFirstName & " " & freshman.studentLastName)
        MsgBox("Second Half " & freshman2.StudentId & " " & freshman2.studentFirstName & " " & freshman2.studentLastName)
        MsgBox("Second Half " & freshman3.StudentId & " " & freshman3.studentFirstName & " " & freshman3.studentLastName)
        MsgBox("Second Half " & freshman4.StudentId & " " & freshman4.studentFirstName & " " & freshman4.studentLastName)

        'Displays the freshman talk.

        freshman4.Talking()

        'Changes the background colour of the new Form to Aqua And shows the new form
        'frmMyForm.BackColor = Color.Aqua
        'frmMyForm.Show()

    End Sub
End Class
