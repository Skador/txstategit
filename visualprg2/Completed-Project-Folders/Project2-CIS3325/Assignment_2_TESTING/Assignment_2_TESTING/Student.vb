Imports DeptDLL.TotalFees
Public Class Student
    Dim Calculate As New DeptDLL.TotalFees
    Dim Started As Boolean = False
    Public Function TotalFee() As Integer
        Try
            If Started = False Then
                Form1.DataGridView1.Columns.Add("TotalFee", "TotalFee")
                Started = True
            End If

            For Each row As DataGridViewRow In Form1.DataGridView1.Rows

                Dim Classification As Integer
                If Not String.IsNullOrEmpty(row.Cells(2).Value) Then
                    Classification = convert(row.Cells(2).Value)
                    Dim Count As Integer = row.Cells(3).Value
                    Dim Fee As Integer
                    Fee = Calculate.TotalFees(Classification, Count)
                    row.Cells(4).Value = Fee
                Else
                    Return TotalFee
                End If
            Next
        Catch
        End Try
        Return TotalFee
    End Function

    Private Function convert(pClassification As String)
        Select Case pClassification
            Case "Graduate"
                Return 0
            Case "Undergraduate"
                Return 1
            Case Else
                Return 2
        End Select
    End Function
End Class
