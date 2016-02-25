Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet1.Student' table. You can move, or remove it, as needed.
        
    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        Me.StudentTableAdapter.Fill(Me.Database1DataSet1.Student)
    End Sub


    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        Me.StudentTableAdapter.InsertQuery(StuFirstNameTextBox.Text, StuLastNameTextBox.Text, DateOfBirthDateTimePicker.Text)
        Me.StudentTableAdapter.Fill(Me.Database1DataSet1.Student)
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Me.StudentTableAdapter.DeleteQuery(StuFirstNameTextBox.Text)
        Me.StudentTableAdapter.Fill(Me.Database1DataSet1.Student)
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Me.StudentTableAdapter.UpdateQuery(StuFirstNameTextBox.Text, StuLastNameTextBox.Text, DateOfBirthDateTimePicker.Text, StudentIDTextBox.Text)
        Me.StudentTableAdapter.Fill(Me.Database1DataSet1.Student)
    End Sub
End Class
