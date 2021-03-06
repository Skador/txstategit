﻿Public Class ScubaForm


    Private Sub btnCalcTotal_Click(sender As Object, e As EventArgs) Handles btnCalcTotal.Click
        ' Constant for the price per person for this package
        Const decSCUBA_PRICE_PER_PERSON As Decimal = 3000D

        ' Local variables
        Dim intNumberPeople As Integer ' Number of people
        Dim decDiscount As Decimal ' Amount of discount
        Dim decTotal As Decimal ' Total cost

        Try
            ' Get the number of people.
            intNumberPeople = CInt(txtNumberPeople.Text)
            ' Get the total before any discount is applied.
            decTotal = intNumberPeople * decSCUBA_PRICE_PER_PERSON

            ' Determine whether a discount can be given.
            If intNumberPeople >= g_intMINIMUM_FOR_DISCOUNT Then
                ' Get the amount of the discount.
                decDiscount = CalcDiscount(decTotal)

                ' Subtract the discount from the total.
                decTotal = decTotal - decDiscount
            Else
                ' The discount is $0.
                decDiscount = 0D
            End If

            ' Display the results.
            lblDiscount.Text = decDiscount.ToString("c")
            lblTotal.Text = decTotal.ToString("c")
        Catch ex As Exception
            ' Error message for invalid input.
            MessageBox.Show("Enter a valid integer for number of people.")
        End Try
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ' Clear the text box and the display labels.
        txtNumberPeople.Clear()
        lblDiscount.Text = String.Empty
        lblTotal.Text = String.Empty

        ' Reset the focus.
        txtNumberPeople.Focus()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        ' Close the form.
        Me.Close()
    End Sub
End Class