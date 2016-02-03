Public Class Form1

    Dim Names() As String = {"Espresso", "Cappuccino", "Latte"}
    Dim Prices() As Double = {2.0, 3.5, 3.4}


    Dim drinks(2) As DrinkType

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Use AddRange to add an array of values
        'ListBox1.Items.AddRange(Names)

        For i As Integer = 0 To Names.Count - 1
            drinks(i) = New DrinkType
            drinks(i).Name = Names(i)
            drinks(i).Price = Prices(i)

        Next
        ListBox1.Items.AddRange(drinks)

        Dim btn1 As New Button
        btn1.Text = "Purchase"
        FlowLayoutPanel1.Controls.Add(btn1)
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Dim aDrink As DrinkType = CType(ListBox1.SelectedItem, DrinkType)
        'Dim aDrink As DrinkType = ListBox1.SelectedItem
        Label2.Text = aDrink.Price.ToString("c")
    End Sub
End Class
