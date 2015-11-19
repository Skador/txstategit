Public Class Form2

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sevenMeals As Decimal = 560
        Dim fourteenMeals As Decimal = 1095
        Dim unlimitedMeals As Decimal = 1500

        If lstMeal.SelectedIndex = 0 Then
            mealPlan = sevenMeals
        ElseIf lstMeal.SelectedIndex = 1 Then
            mealPlan = fourteenMeals
        ElseIf lstMeal.SelectedIndex = 2 Then
            mealPlan = unlimitedMeals
        ElseIf lstMeal.SelectedIndex = -1 Then
            mealPlan = 0
        End If

        Form1.lblMealPlan.Text = mealPlan.ToString("C")
        Form1.lblTotal.Text = TotalCost().ToString("C")


    End Sub
End Class