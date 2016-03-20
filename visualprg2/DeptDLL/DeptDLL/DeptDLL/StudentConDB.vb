Public Class StudentConDB
    Class ObtainTotal
        Shared Function GetTotal(ByVal TotalClassesTaken As Integer, ByVal Classification As String)
            Dim TotalFees As Integer
            Try
                If Classification = "Graduate" Then
                    Return TotalFees = (TotalClassesTaken * 1300)
                ElseIf Classification = "Undergraduate" Then
                    Return TotalFees = (TotalClassesTaken * 900)
                End If
            Catch ex As Exception
                Return MsgBox("The student must either be a graduate, or an undergraduate. Please update the student classification")
            End Try
        End Function
    End Class
End Class
