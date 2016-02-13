Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        Dim salEmployee As New Employee
        'Once the button is pressed, The values in the textboxes are transfered to the new Employee
        salEmployee.firstName = FirstNameTxt.Text
        salEmployee.lastName = LastNameTxt.Text
        salEmployee.salarPerHour = CType(SalaryPerHourTxt.Text, Double)
        salEmployee.NoOfWeeks = CType(NoOfWeekTxt.Text, Integer)
        salEmployee.WeeklyHours = CType(WeeklyHoursTxt.Text, Integer)
        salEmployee.monthsOfPayments = CType(MonthsOfPaymentTxt.Text, Integer)

        'Shows the Salary data in a Currency format
        MonthlySalaryLbl.Text = salEmployee.monthlySalary().ToString("c")
        YearlySalaryLbl.Text = salEmployee.yearlySalary().ToString("c")
    End Sub

    Private Sub NoOfWeekTxt_Leave(sender As Object, e As EventArgs) Handles NoOfWeekTxt.Leave
        Try
            If IsNumeric(CDec(NoOfWeekTxt.Text)) = True Then
                If CDec(NoOfWeekTxt.Text) < 1 Or CDec(NoOfWeekTxt.Text) > 4 Then
                    MsgBox("Please enter an interger between the values of 1 and 4.")
                    NoOfWeekTxt.Focus()
                End If
            End If
            
        Catch ex As Exception
            MsgBox("Please only enter integers")
            NoOfWeekTxt.Focus()
        End Try
    End Sub

    Private Sub WeeklyHoursTxt_Leave(sender As Object, e As EventArgs) Handles WeeklyHoursTxt.Leave
          Try
            If IsNumeric(CDec(WeeklyHoursTxt.Text)) = True Then
                If CDec(WeeklyHoursTxt.Text) < 1 Or CDec(WeeklyHoursTxt.Text) > 40 Then
                    MsgBox("Please enter an interger between the values of 1 and 40.")
                    WeeklyHoursTxt.Focus()
                End If
            End If
        Catch ex As Exception
            MsgBox("Please only enter integers")
            WeeklyHoursTxt.Focus()
        End Try
    End Sub

    Private Sub SalaryPerHourTxt_Leave(sender As Object, e As EventArgs) Handles SalaryPerHourTxt.Leave
        Try
            If IsNumeric(CDec(SalaryPerHourTxt.Text)) = True Then
            End If
        Catch ex As Exception
            MsgBox("Please only enter integers")
            SalaryPerHourTxt.Focus()
        End Try
    End Sub

    Private Sub MonthsOfPaymentTxt_Leave(sender As Object, e As EventArgs) Handles MonthsOfPaymentTxt.Leave
        Try
            If IsNumeric(CDec(MonthsOfPaymentTxt.Text)) = True Then
                If CDec(MonthsOfPaymentTxt.Text) < 1 Or CDec(MonthsOfPaymentTxt.Text) > 12 Then
                    MsgBox("Please enter an interger between the values of 1 and 12.")
                    MonthsOfPaymentTxt.Focus()
                End If
            End If
        Catch ex As Exception
            MsgBox("Please only enter integers")
            MonthsOfPaymentTxt.Focus()
        End Try
    End Sub
End Class
