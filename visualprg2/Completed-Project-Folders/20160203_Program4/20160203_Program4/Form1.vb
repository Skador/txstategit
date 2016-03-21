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

        'This creates a button dynamically at run time.
        Dim btn1 As New Button
        btn1.Text = "Purchase"
        btn1.BackColor = Color.Yellow
        btn1.Height = 30
        btn1.Width = 100

        FlowLayoutPanel1.Controls.Add(btn1)

        AddHandler btn1.Click, AddressOf btn1_Click

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Dim aDrink As DrinkType = CType(ListBox1.SelectedItem, DrinkType)
        'Dim aDrink As DrinkType = ListBox1.SelectedItem
        Label2.Text = aDrink.Price.ToString("c")
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs)
        MsgBox("Ha ha ha")
    End Sub

End Class
