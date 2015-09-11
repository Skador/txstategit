Public Class Form1

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Closing the window
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Clears the text for all input boxes
        txtTSClassA.Clear()
        txtTSClassB.Clear()
        txtTSClassC.Clear()
        ' Clears the text for all output boxes
        lblRGClassATotal.Text = String.Empty
        lblRGClassBTotal.Text = String.Empty
        lblRGClassCTotal.Text = String.Empty
        lblRGTotalRevTotal.Text = String.Empty
    End Sub

    Private Sub btnCalcRev_Click(sender As Object, e As EventArgs) Handles btnCalcRev.Click
        ' Variables to be used for calculations
        Dim calcAsubTotal As Decimal
        Dim calcBsubTotal As Decimal
        Dim calcCsubTotal As Decimal
        Dim calcFinalTotal As Decimal
        ' Consts that were given in the Program 1 Problem
        Const costClassA As Decimal = 15D
        Const costClassB As Decimal = 12D
        Const costClassC As Decimal = 9D
        Try
            ' Calculates the subtotals for each ticket type
            calcAsubTotal = CDec(txtTSClassA.Text * costClassA)
            calcBsubTotal = CDec(txtTSClassB.Text * costClassB)
            calcCsubTotal = CDec(txtTSClassC.Text * costClassC)

            ' Sums up all subtotals for a final Total
            calcFinalTotal = calcAsubTotal + calcBsubTotal + calcCsubTotal

            ' Displays all subtotals and totals
            lblRGClassATotal.Text = calcAsubTotal.ToString("c")
            lblRGClassBTotal.Text = calcBsubTotal.ToString("c")
            lblRGClassCTotal.Text = calcCsubTotal.ToString("c")
            lblRGTotalRevTotal.Text = calcFinalTotal.ToString("c")

        Catch ex As Exception
            ' Asks the user to only use intergers
            MessageBox.Show("Please only use whole intergers")
        End Try
    End Sub
End Class
