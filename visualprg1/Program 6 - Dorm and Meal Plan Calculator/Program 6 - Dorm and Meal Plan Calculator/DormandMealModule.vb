Module DormandMealModule

    Public total As Decimal
    Public mealPlan As Decimal
    Public dorm As Decimal
    Public Function TotalCost() As Decimal
        total = mealPlan + dorm
        Return total
    End Function




End Module
