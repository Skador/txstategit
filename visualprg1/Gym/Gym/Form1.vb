Public Class Form1

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Closes the Program
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clears the lables
        lblMonthlyFee.Text = String.Empty
        lblTotal.Text = String.Empty

        'Clears the radio buttons
        rbStandardAdult.Checked = False
        rbChild.Checked = False
        rbStudent.Checked = False
        rbSenior.Checked = False

        'Clears the checkboxes
        cbYoga.Checked = False
        cbPersonalTrainer.Checked = False
        cbKarate.Checked = False

        'Clears the text box
        txtNumMonths.Clear()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Notifies the program has started
        lblStatus.Text = "The program has started"
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'Initializes severeal variables
        Dim decBaseFee As Decimal
        Dim decTotalFee As Decimal
        Dim intMonths As Integer
        Dim blnInputOk As Boolean = True

        'Initializes and sets several constants
        Const decADULT_FEE As Decimal = 40D
        Const decChild_FEE As Decimal = 20D
        Const decSTUDENT_FEE As Decimal = 25D
        Const decSENIOR_FEE As Decimal = 30D

        Const decYOGA_FEE As Decimal = 10D
        Const decKARATE_FEE As Decimal = 30D
        Const decTRAINER_FEE As Decimal = 50D

        'Clears the Status String
        lblStatus.Text = String.Empty

        'Verifies if the input is a number
        If Integer.TryParse(txtNumMonths.Text, intMonths) = False Then
            lblStatus.Text = "Months must be an integer."
            blnInputOk = False
        ElseIf intMonths < 1 Or intMonths > 24 Then
            lblStatus.Text = "Months must be in the range of 1 - 24."
            blnInputOk = False
        End If

        'Verifies if the input is within the range provided


        'Runs the remainder of the program if nothing went wrong
        If blnInputOk = True Then

            'Finds the checked radio button and sets the base fee
            If rbStandardAdult.Checked = True Then
                decBaseFee = decADULT_FEE
            ElseIf rbChild.Checked = True Then
                decBaseFee = decChild_FEE
            ElseIf rbStudent.Checked = True Then
                decBaseFee = decSTUDENT_FEE
            ElseIf rbSenior.Checked = True Then
                decBaseFee = decSENIOR_FEE
            End If

            'Checks if Yoga is included and adds the fee
            If cbYoga.Checked Then
                decBaseFee += decYOGA_FEE
            End If

            'Checks if Karate is included and adds the fee
            If cbKarate.Checked Then
                decBaseFee += decKARATE_FEE
            End If

            'Checks if Personal Trainer is included and adds the fee
            If cbPersonalTrainer.Checked Then
                decBaseFee += decTRAINER_FEE
            End If

            'Multiples the fee by the months provided
            decTotalFee = decBaseFee * intMonths

            'Displays the values
            lblMonthlyFee.Text = decBaseFee.ToString("c")
            lblTotal.Text = decTotalFee.ToString("c")
        End If
    End Sub
End Class
