Public Class Form1

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim index As Integer
        Dim givenAccountNumbers() As String = {5658845, 4520125, 7895122, 877541, 8451277,
                                                1302850, 8080152, 4562555, 5552012, 5050552,
                                                7825877, 1250255, 1005231, 6545231, 3852085,
                                                7576651, 7881200, 4581002}
        Dim userAccountNumber As String = TextBox1.Text
        Dim found As Boolean

        Try
            If IsNumeric(CDec(userAccountNumber)) = False Then

                'Errors on a non valid entry
                Error 0
            End If

            For index = 0 To givenAccountNumbers.Length - 1
                If userAccountNumber = givenAccountNumbers(index) Then
                    found = True
                    Exit For
                End If
            Next

            If found Then
                MessageBox.Show("User account is VAILD")
            Else : MessageBox.Show("User account could not be found")
            End If

        Catch ex As Exception
            MessageBox.Show("Please enter numeric characters only.")
        End Try
            

    End Sub
End Class
