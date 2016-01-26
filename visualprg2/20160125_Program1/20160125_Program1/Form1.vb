Public Class Form1

    'Defines a new object via the specified class
    Dim freshman As New Student
    'Different way to define the specified class
    Dim freshman2 As Student

    'Creates a new "Form" object
    Dim frmMyForm As New Form

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Second half of the different way
        freshman2 = New Student

        'Examples for setting public class variables
        freshman.firstName = "Marry"
        freshman.lastName = "Johnson"
        freshman.studentId = 123

        'Another Example of setting public class variables using the different way
        freshman2.firstName = "John"
        freshman2.lastName = "Johnson"
        freshman2.studentId = 124

        'Changes the background colour of the new Form to Aqua And shows the new form
        frmMyForm.BackColor = Color.Aqua
        frmMyForm.Show()

    End Sub
End Class
