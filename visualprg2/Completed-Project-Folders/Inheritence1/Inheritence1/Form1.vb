Imports System.Data
Imports System.Data.SqlClient

Public Class Form1
    Dim p1 As New Person("Mike")
    '    Dim p2 As New Person()
    Dim p2 As Person
    Dim h1 As New Hero("Saitama", "Average")

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''p1.Name = "Mike"
        'MsgBox("Name: " & p1.Name)

        ''h1.Name = "Saitama"
        ''h1.Ability = "Average"

        'MsgBox("Name: " & h1.Name & " Ability: " & h1.Ability)

        'p1 = h1
        'MsgBox(p1.Name)

        p2 = New Hero("Adam", "Spiderman")

        MessageBox.Show(CType(p2, Hero).Ability)

        MsgBox(p1.ToString)
        MsgBox(h1.ToString)

    End Sub
End Class
