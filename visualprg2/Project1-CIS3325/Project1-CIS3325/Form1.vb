Imports System.IO
Public Class Form1
    Dim salEmployee As New Employee

    Dim writeFile As StreamWriter
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

        'Imports the data gathered form the user into a text file called 'Employee'
        If File.Exists("../../Employee.txt") Then
            MsgBox("Data will be appended to the 'Employee' record file.")
            writeFile = File.AppendText("../../Employee.txt")
            writeFile.WriteLine("First Name: " & FirstNameTxt.Text & vbNewLine & "Last Name: " & LastNameTxt.Text & vbNewLine & "Number of Weeks Worked: " & NoOfWeekTxt.Text & vbNewLine & "Weekly Hours: " & WeeklyHoursTxt.Text & vbNewLine & "Salary per Hour: " & SalaryPerHourTxt.Text & vbNewLine & "Monthly Salary: " & MonthlySalaryLbl.Text & vbNewLine & "Months of Payment: " & MonthsOfPaymentTxt.Text & vbNewLine & "Yearly Salary: " & YearlySalaryLbl.Text & vbNewLine)
            MsgBox("Data was successfully appended to the 'Employee' record file.")
            writeFile.Close()
        Else
            MsgBox("A record file has not been created. A file named 'Employee' will be created.")
            writeFile = File.CreateText("../../Employee.txt")
            MsgBox("A record has been created for " & FirstNameTxt.Text & " " & LastNameTxt.Text & " in the 'Employee' file.")
            writeFile.WriteLine("First Name: " & FirstNameTxt.Text & vbNewLine & "Last Name: " & LastNameTxt.Text & vbNewLine & "Number of Weeks Worked: " & NoOfWeekTxt.Text & vbNewLine & "Weekly Hours: " & WeeklyHoursTxt.Text & vbNewLine & "Salary per Hour: " & SalaryPerHourTxt.Text & vbNewLine & "Monthly Salary: " & MonthlySalaryLbl.Text & vbNewLine & "Months of Payment: " & MonthsOfPaymentTxt.Text & vbNewLine & "Yearly Salary: " & YearlySalaryLbl.Text & vbNewLine)
            MsgBox("Employee record was successfully added to file.")
            writeFile.Close()
        End If
    End Sub
End Class
