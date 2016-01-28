Imports System.IO

Public Class Form1
    Dim writeFile As StreamWriter
    Dim readFile As StreamReader
    'Button 1 See's if a file exists and if it doesn't, Creates the file
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If File.Exists("../../Student.txt") Then
            MsgBox("The file exists")

        Else
            MsgBox("The file does not exist")
            'Every time you mess with a file, you MUST CLOSE THE FILE
            writeFile = File.CreateText("../../Student.txt")
            'To Write data in the file, use WriteLine
            writeFile.WriteLine(TextBox1.Text & vbTab & TextBox2.Text & vbTab & TextBox3.Text)


            writeFile.Close()
        End If

    End Sub
End Class
