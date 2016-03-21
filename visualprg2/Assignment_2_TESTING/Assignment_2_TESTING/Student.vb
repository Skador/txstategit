Imports DepartmentDLL.Class1
Public Class Student
    Dim Calculate As New DepartmentDLL.Class1
    Dim Started As Boolean = False
    Public Function TotalFee() As Integer
        Try
            If Started = False Then
                Form1.DataGridView1.Columns.Add("TotalFee", "TotalFee")
                Started = True
            End If

            For Each row As DataGridViewRow In Form1.DataGridView1.Rows


                Dim Type1 As Integer = convert(row.Cells(2).Value)
                Dim Count As Integer = row.Cells(3).Value
                Dim Move As Integer
                Dim Fee As Integer
                Fee = Calculate.TotalFees(Type1, Count)
                MsgBox(Fee)
                row.Cells(4).Value = Fee

                Move = Move + 1
            Next
        Catch
        End Try
        Return TotalFee
    End Function

    Private Function convert(x As String)
        MsgBox(x)
        Select Case x
            Case "Graduate"
                Return 0
            Case "Undergraduate"
                Return 1
            Case Else
                Return MsgBox("Students of type Undergraduate or Graduate do not exist, please check your database for errors.")

        End Select
    End Function
End Class
