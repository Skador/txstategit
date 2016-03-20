Imports System.Data
Imports System.Data.SqlClient
Public Class Form1
    Dim myConS As String = "Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True"
    Dim myConn As New SqlConnection(myConS)
    Dim myDA As New SqlDataAdapter
    Dim myDS As New DataSet
    Dim myBDS As New BindingSource

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myDA.SelectCommand = New SqlCommand("select * from STUDENT", myConn)
        myDA.Fill(myDS, "STUDENT")
        DataGridView1.DataSource = myDS
        DataGridView1.DataMember = "STUDENT"
        myBDS.DataSource = myDS.Tables("STUDENT")

        TextBox1.DataBindings.Add(New Binding("Text", myBDS, "StudentID"))
        TextBox4.DataBindings.Add(New Binding("Text", myBDS, "StudentID"))
        TextBox2.DataBindings.Add(New Binding("Text", myBDS, "Name"))
        ComboBox1.DataBindings.Add(New Binding("Text", myBDS, "Type"))
        TextBox3.DataBindings.Add(New Binding("Text", myBDS, "NoOfCourses"))

        DataGridView1.Visible = False
        Button4.Visible = False
        Button5.Visible = False
        Button6.Visible = False
        Button7.Visible = False

        Label1.Visible = False
        Label2.Visible = False
        Label3.Visible = False
        Label4.Visible = False
        TextBox1.Visible = False
        TextBox2.Visible = False
        TextBox3.Visible = False
        ComboBox1.Visible = False
        Button1.Visible = False
        Button2.Visible = False

        Label5.Visible = False
        Button3.Visible = False
        TextBox4.Visible = False
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = False Then
            DataGridView1.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
        ElseIf CheckBox1.Checked = True Then
            DataGridView1.Visible = True
            Button4.Visible = True
            Button5.Visible = True
            Button6.Visible = True
            Button7.Visible = True
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = False Then
            Label1.Visible = False
            Label2.Visible = False
            Label3.Visible = False
            Label4.Visible = False
            TextBox1.Visible = False
            TextBox2.Visible = False
            TextBox3.Visible = False
            ComboBox1.Visible = False
            Button1.Visible = False
            Button2.Visible = False
        ElseIf CheckBox2.Checked = True Then
            Label1.Visible = True
            Label2.Visible = True
            Label3.Visible = True
            Label4.Visible = True
            TextBox1.Visible = True
            TextBox2.Visible = True
            TextBox3.Visible = True
            ComboBox1.Visible = True
            Button1.Visible = True
            Button2.Visible = True
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = False Then
            Label5.Visible = False
            Button3.Visible = False
            TextBox4.Visible = False
        ElseIf CheckBox3.Checked = True Then
            Label5.Visible = True
            Button3.Visible = True
            TextBox4.Visible = True
        End If
    End Sub

    Private Sub DGUpdate()
        DataGridView1.ClearSelection()
        DataGridView1.Rows(myBDS.Position).Selected = True
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        myBDS.MoveFirst()
        DGUpdate()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        myBDS.MoveNext()
        DGUpdate()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        myBDS.MovePrevious()
        DGUpdate()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        myBDS.MoveLast()
        DGUpdate()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        myDA.InsertCommand = New SqlCommand("insert into STUDENT(StudentID, Name, Type, NoOfCourses) values (@StudentID, @Name, @Type, @NoOfCourses)", myConn)

        myDA.InsertCommand.Parameters.Add("@StudentID", SqlDbType.BigInt).Value = CInt(TextBox1.Text)
        myDA.InsertCommand.Parameters.Add("@Name", SqlDbType.VarChar).Value = TextBox2.Text
        myDA.InsertCommand.Parameters.Add("@Type", SqlDbType.VarChar).Value = ComboBox1.Text
        myDA.InsertCommand.Parameters.Add("@NoOfCourses", SqlDbType.BigInt).Value = CInt(TextBox3.Text)

        myConn.Open()
        myDA.InsertCommand.ExecuteNonQuery()
        myConn.Close()

        myDS.Clear()
        myDA.Fill(myDS, "STUDENT")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        myDA.UpdateCommand = New SqlCommand("update STUDENT set StudentID=@StudentID, Name=@Name, Type=@Type, NoOfCourses=@NoOfCourses where StudentID=@StudentID", myConn)

        myDA.UpdateCommand.Parameters.Add("@StudentID", SqlDbType.BigInt).Value = myDS.Tables("STUDENT").Rows(myBDS.Position)("StudentID")
        myDA.UpdateCommand.Parameters.Add("@Name", SqlDbType.VarChar).Value = TextBox2.Text
        myDA.UpdateCommand.Parameters.Add("@Type", SqlDbType.VarChar).Value = ComboBox1.Text
        myDA.UpdateCommand.Parameters.Add("@NoOfCourses", SqlDbType.BigInt).Value = CInt(TextBox3.Text)

        myConn.Open()
        myDA.UpdateCommand.ExecuteNonQuery()
        myConn.Close()

        myDS.Clear()
        myDA.Fill(myDS, "STUDENT")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        myDA.DeleteCommand = New SqlCommand("Delete from STUDENT where StudentID=@StudentID", myConn)

        myDA.DeleteCommand.Parameters.Add("@StudentID", SqlDbType.BigInt).Value = myDS.Tables("STUDENT").Rows(myBDS.Position)("StudentID")

        myConn.Open()
        myDA.DeleteCommand.ExecuteNonQuery()
        myConn.Close()

        myDS.Clear()
        myDA.Fill(myDS, "STUDENT")
    End Sub
End Class
