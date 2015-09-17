Public Class Form1

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        'Creates the variables to be used
        Dim total As Decimal
        Dim subTotal As Decimal
        Dim hours As Decimal

        'Creates the constants to be used
        Const hrsInMonth As Decimal = 744
        Const rateA As Decimal = 9.95
        Const limitA As Decimal = 10
        Const extraHrsAcost As Decimal = 2
        Const rateB As Decimal = 14.95
        Const limitB As Decimal = 20
        Const extraHrsBcost As Decimal = 1
        Const rateC As Decimal = 19.95
        Const discount As Decimal = 0.2

        'First try catch to verify the hours entered are numbers
        Try
            If IsNumeric(CDec(txtNbrHrsEntered.Text)) = False Then

                'Errors on a non valid entry
                Error 1
            End If

            'Second try catch to verify the hours entered don't exceed 744 hours
            Try

                If CDec(txtNbrHrsEntered.Text) > hrsInMonth Then

                    'Errors to the message box
                    Error 1
                End If

                'Third try catch to verify a radio button was selected
                Try

                    'Checks to see if the first radio button is selected
                    If rbPackageA.Checked = True Then
                        If CDec(txtNbrHrsEntered.Text) > limitA Then
                            hours = CDec(txtNbrHrsEntered.Text) - limitA
                            subTotal = rateA + (hours * extraHrsAcost)
                        Else
                            subTotal = rateA
                        End If

                        'Checks to see if the second radio button is selected
                    ElseIf rbPackageB.Checked = True Then
                        If CDec(txtNbrHrsEntered.Text) > limitB Then
                            hours = CDec(txtNbrHrsEntered.Text) - limitB
                            subTotal = rateB + (hours * extraHrsBcost)
                        Else
                            subTotal = rateB
                        End If

                        'Checks to see if the third radio button is selected
                    ElseIf rbPackageC.Checked = True Then
                        subTotal = rateC
                    Else

                        'Errors if no radio button is selected
                        Error 1
                    End If
                Catch ex As Exception

                    'Shows the error message for not selecting a radio button
                    MessageBox.Show("Please select a package")
                End Try

                'Checks to see if the company is a nonprofit
                If cbNonProfOrg.Checked = True Then
                    total = subTotal - (subTotal * discount)
                Else
                    total = subTotal
                End If
                lblTotalAmount.Text = total.ToString("C")
            Catch ex As Exception

                'Shows the error message for entering a numeric value
                MessageBox.Show("Hours can not exceed 744 hours")
            End Try
        Catch ex As Exception

            'Shows the error message for entering a numeric value above 744 hours
            MessageBox.Show("The value must be numeric")
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clears the text field
        txtNbrHrsEntered.Clear()

        'Clears the label
        lblTotalAmount.Text = String.Empty

        'Resets the Radio buttons
        rbPackageA.Checked = False
        rbPackageB.Checked = False
        rbPackageC.Checked = False

        'Resets the Check box
        cbNonProfOrg.Checked = False
    End Sub
End Class
