Imports System.Data
Imports System.Data.SqlClient

Public Class Form1

    Dim myConnectionStr As String = "Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Student.mdf;Integrated Security=True;Connect Timeout=30"
    Dim myConnection As New SqlConnection(myConnectionStr)
    Dim myDA As New SqlDataAdapter
    Dim myDS As New DataSet
    Dim myBindingSource As New BindingSource

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        myDA.SelectCommand = New SqlCommand("select * from Student", myConnection)
        myDA.Fill(myDS, "Student")
        DataGridView1.DataSource = myDS
        DataGridView1.DataMember = "Student"
        myBindingSource.DataSource = myDS.Tables("Student")
        TextBox1.DataBindings.Add(New Binding("Text", myBindingSource, "StudentId"))
        TextBox2.DataBindings.Add(New Binding("Text", myBindingSource, "StudentFName"))
        TextBox3.DataBindings.Add(New Binding("Text", myBindingSource, "StudentLName"))
    End Sub

    Private Sub DGUpdate()
        DataGridView1.ClearSelection()
        DataGridView1.Rows(myBindingSource.Position).Selected = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        myBindingSource.MoveFirst()
        DGUpdate()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        myBindingSource.MoveLast()
        DGUpdate()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        myBindingSource.MovePrevious()
        DGUpdate()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        myBindingSource.MoveNext()
        DGUpdate()
    End Sub

    Private Sub Insert_Click(sender As Object, e As EventArgs) Handles Insert.Click
        myDA.InsertCommand = New SqlCommand("INSERT into Student(StudentId, StudentFName, StudentLName) values (@StudentId, @StudentFName, @StudentLName)", myConnection)

        myDA.InsertCommand.Parameters.Add("@StudentId", SqlDbType.BigInt).Value = CInt(TextBox1.Text)
        myDA.InsertCommand.Parameters.Add("@StudentFName", SqlDbType.VarChar).Value = TextBox2.Text
        myDA.InsertCommand.Parameters.Add("@StudentLName", SqlDbType.VarChar).Value = TextBox3.Text

        myConnection.Open()
        myDA.InsertCommand.ExecuteNonQuery()
        myConnection.Close()
        myDS.Clear()
        myDA.Fill(myDS, "Student")
    End Sub
End Class
