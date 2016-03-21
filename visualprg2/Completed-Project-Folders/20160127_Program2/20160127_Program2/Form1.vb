Imports System.IO

Public Class Form1
    Dim writeFile As StreamWriter
    Dim readFile As StreamReader
    'Button 1 See's if a file exists and if it doesn't, Creates the file
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If File.Exists("../../Student.txt") Then
            MsgBox("The file exists")
            'Every time you mess with a file, you MUST CLOSE THE FILE
            'To Append the file, use AppendText
            writeFile = File.AppendText("../../Student.txt")
            writeFile.WriteLine(TextBox1.Text & vbTab & TextBox2.Text & vbTab & TextBox3.Text)
            MsgBox("Data was appended and saved to the file")
            writeFile.Close()
        Else
            MsgBox("The file does not exist")
            'Every time you mess with a file, you MUST CLOSE THE FILE
            TextBox1.Focus()
            MsgBox("A file named Student.txt will be created")
            writeFile = File.CreateText("../../Student.txt")
            Dim result As Integer = MsgBox("Do you want to add data to the file?", vbYesNo + vbQuestion, "Data Adding")
            If result = vbYes Then
                'To Write data in the file, use WriteLine
                'Every time you mess with a file, you MUST CLOSE THE FILE
                writeFile.WriteLine(TextBox1.Text & vbTab & TextBox2.Text & vbTab & TextBox3.Text)
                MsgBox("Data was saved to the file")
                writeFile.Close()
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        readFile = File.OpenText("../../Student.txt")
        'Clears the listbox everytime that the file is read
        ListBox1.Items.Clear()
        While Not readFile.EndOfStream
            ' ListBox1.Items.Clear()
            ListBox1.Items.Add(readFile.ReadLine)
        End While
        'MsgBox(readFile.ReadLine)
        readFile.Close()
    End Sub
End Class
