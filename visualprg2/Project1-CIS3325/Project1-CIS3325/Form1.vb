Public Class Form1
    Dim salEmployee As New Employee
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
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
End Class
