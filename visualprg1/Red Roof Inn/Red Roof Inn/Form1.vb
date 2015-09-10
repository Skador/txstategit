Public Class Form1


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblDateToday.Text = Now.ToString("D")
        lblTimeToday.Text = Now.ToString("T")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Declare variables for the calculations.
        Dim decRoomCharges As Decimal ' Room charges total
        Dim decAddCharges As Decimal ' Additional charges
        Dim decSubtotal As Decimal ' Subtotal
        Dim decTax As Decimal ' Tax
        Dim decTotal As Decimal ' Total of all charges
        Const decTAX_RATE As Decimal = 0.08D ' Tax rate

        '  lblStatus.Text = String.Empty

        Try
            ' Calculate and display the room charges.
            decRoomCharges = CDec(txtNights.Text) * CDec(txtNightlyCharge.Text)
            lblRoomCharges.Text = decRoomCharges.ToString("c")

            ' Calculate and display the additional charges.
            decAddCharges = CDec(txtRoomService.Text) + CDec(txtTelephone.Text) + CDec(txtMisc.Text)
            lblAddCharges.Text = decAddCharges.ToString("c")

            ' Calculate and display the subtotal.
            decSubtotal = decRoomCharges + decAddCharges
            lblSubtotal.Text = decSubtotal.ToString("c")

            ' Calculate and display the tax.
            decTax = decSubtotal * decTAX_RATE
            lblTax.Text = decTax.ToString("c")

            ' Calculate and display the total charges.
            decTotal = decSubtotal + decTax
            lblTotal.Text = decTotal.ToString("c")

        Catch
            ' Error message
            MessageBox.Show("All input must be valid numeric values.")
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        ' Clear the room info fields.
        txtNights.Clear()
        txtNightlyCharge.Clear()
        ' Clear the additional charges fields.
        txtRoomService.Clear()
        txtTelephone.Clear()
        txtMisc.Clear()
        ' Clear the decTotal fields.
        lblRoomCharges.Text = String.Empty
        lblAddCharges.Text = String.Empty
        lblSubtotal.Text = String.Empty
        lblTax.Text = String.Empty
        lblTotal.Text = String.Empty
        ' Get today's date from the operating system and display it.
        lblDateToday.Text = Now.ToString("D")
        ' Get the current time from the operating system and display it.
        lblTimeToday.Text = Now.ToString("T")
        ' Reset the focus to the first field.
        txtNights.Focus()

    End Sub
End Class
