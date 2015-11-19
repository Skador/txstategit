Imports System.IO
Public Class Form1
    'Class level declarations
    Dim strFilename As String 'To hold the file name

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'get the file to use as output file.
        strFilename = InputBox("Enter the name of the file.", "Input Needed")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Close the current form
        Me.Close()
    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        'Declare the output file
        Dim outputFile As System.IO.StreamWriter

        'Open the file
        outputFile = System.IO.File.AppendText(strFilename)

        'Write the record we entered on the screen
        outputFile.WriteLine(txtNameInput.Text)

        'Close the file
        outputFile.Close()
    End Sub
End Class
