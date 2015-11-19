Public Class Form1

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstDorm.SelectedIndexChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnMealPlans_Click(sender As Object, e As EventArgs) Handles btnMealPlans.Click
        Form2.Show()

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        lblTotal.Text = ""
        lblDorm.Text = ""
        lblMealPlan.Text = ""
        lstDorm.SelectedIndex = -1
        Form2.lstMeal.SelectedIndex = -1


    End Sub

    Private Sub btnAddDorm_Click(sender As Object, e As EventArgs) Handles btnAddDorm.Click
        Dim allenHall As Decimal = 1500
        Dim pikeHall As Decimal = 1600
        Dim farthingHall As Decimal = 1200
        Dim universityHall As Decimal = 1800

        If lstDorm.SelectedIndex = -1 Then
            MessageBox.Show("Please select a dorm.")
            lblDorm.Text = ""
        End If

        If lstDorm.SelectedIndex = 0 Then
            dorm = allenHall
        ElseIf lstDorm.SelectedIndex = 1 Then
            dorm = pikeHall
        ElseIf lstDorm.SelectedIndex = 2 Then
            dorm = farthingHall
        ElseIf lstDorm.SelectedIndex = 3 Then
            dorm = universityHall
        ElseIf lstDorm.SelectedIndex = -1 Then

        End If

        lblDorm.Text = dorm.ToString("C")
        lblTotal.Text = TotalCost().ToString("C")


    End Sub
End Class
