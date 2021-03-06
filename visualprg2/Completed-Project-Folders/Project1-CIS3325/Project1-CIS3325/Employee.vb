﻿Public Class Employee

    Public Property firstName As String
    Public Property lastName As String
    Public Property salarPerHour As Double

    Private numberofweeks As Integer
    Private hoursweekly As Integer
    Private monthspayment As Integer

    Public Property NoOfWeeks() As Integer
        Get
            Return numberofweeks
        End Get
        Set(ByVal value As Integer)
            If value < 1 Then
                MsgBox("Please enter a value of 1 or greater for the number of weeks worked.")
            ElseIf value > 4 Then
                MsgBox("Please enter a value of 4 or less for the number of weeks worked.")
            Else
                numberofweeks = value
            End If
        End Set
    End Property

    Public Property WeeklyHours() As Integer
        Get
            Return hoursweekly
        End Get
        Set(ByVal value As Integer)
            If value < 1 Then
                MsgBox("Please enter a value of 1 or greater for the number of hours worked weekly.")
            ElseIf value > 40 Then
                MsgBox("Please enter a value of 40 or less for the number of hours worked weekly.")
            Else
                hoursweekly = value
            End If
        End Set
    End Property

    Public Property monthsOfPayments() As Integer
        Get
            Return monthspayment
        End Get
        Set(ByVal value As Integer)
            If value > 12 Then
                MsgBox("Error: Number of months is higher than 12.")
            Else
                monthspayment = value
            End If
        End Set
    End Property

    Public Function monthlySalary() As Double
        Dim SalaryMonthly As Double

        SalaryMonthly = numberofweeks * hoursweekly * salarPerHour

        Return SalaryMonthly
    End Function

    Public Function yearlySalary() As Double
        Dim SalaryYearly As Double

        SalaryYearly = monthlySalary() * monthsOfPayments

        Return SalaryYearly
    End Function

End Class
