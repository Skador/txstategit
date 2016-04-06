Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim karatedb As New KarateDataContext

        Dim karatequery = From aMember In karatedb.Members
                          Select aMember

        DataGridView1.DataSource = karatequery


        Dim karatequeryII = From aPayment In karatedb.Payments
                            Select aPayment.ID, FullName = aPayment.Member.Last_Name + ", " + aPayment.Member.First_Name, aPayment.Payment_Date, aPayment.Amount

        DataGridView2.DataSource = karatequeryII

        For Each line In karatequeryII
            ListBox1.Items.Add("The family name is: " & line.FullName)
        Next

        Dim total As Double
        For Each aPayment In karatequeryII
            total += aPayment.Amount
        Next

        MsgBox(total)

    End Sub
End Class
