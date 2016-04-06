Public Class Form1

    Private db As New KarateClassesDataContext

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim query = From aPerson In db.Members
                    Select aPerson
        MemberBindingSource.DataSource = query



    End Sub

    Private Sub MemberBindingNavigatorSaveItem_Click() Handles MemberBindingNavigatorSaveItem.Click
        Try
            MemberBindingSource.EndEdit()
            db.SubmitChanges()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk

    End Sub
End Class
