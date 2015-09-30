Public Class Form1

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtNumMin.Clear()
        lblTotalChargeMonth.Text = String.Empty
        rbDaytime.Checked = False
        rbEvening.Checked = False
        rbOffPeak.Checked = False
        cbFederal.Checked = False
        cbLongTerm.Checked = False
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim varcost As Decimal
        Dim totalCost As Decimal
        Dim disc As Decimal

        Const dayTimeRate As Decimal = 5
        Const eveningTimeRate As Decimal = 4
        Const offPeakTimeRate As Decimal = 3
        Const fccTax As Decimal = 15
        Const localTax As Decimal = 20
        Const discRate As Decimal = 0.1
        Const discDollar As Decimal = 20
        Const fedDiscRate As Decimal = 0.25

        If rbDaytime.Checked = True Then
            varcost = CInt(txtNumMin.Text) * dayTimeRate
            varcost = varcost + fccTax 'FCC Tax
            varcost = varcost + localTax 'Local Tax

            If cbLongTerm.Checked = True Then
                disc = varcost * discRate
                If disc > discDollar Then
                    varcost = varcost - disc
                Else : varcost = varcost - discDollar
                End If
            End If
            If cbFederal.Checked = True Then
                varcost = varcost - (varcost * fedDiscRate)
            End If
        End If
        If rbEvening.Checked = True Then
            varcost = CInt(txtNumMin.Text) * eveningTimeRate
            varcost = varcost + fccTax 'FCC Tax
            varcost = varcost + localTax 'Local Tax

            If cbLongTerm.Checked = True Then
                disc = varcost * discRate
                If disc > discDollar Then
                    varcost = varcost - disc
                Else : varcost = varcost - discDollar
                End If
            End If
            If cbFederal.Checked = True Then
                varcost = varcost - (varcost * fedDiscRate)
            End If
        End If
        If rbOffPeak.Checked = True Then
            varcost = CInt(txtNumMin.Text) * offPeakTimeRate
            varcost = varcost + fccTax 'FCC Tax
            varcost = varcost + localTax 'Local Tax

            If cbLongTerm.Checked = True Then
                disc = varcost * discRate
                If disc > discDollar Then
                    varcost = varcost - disc
                Else : varcost = varcost - discDollar
                End If
            End If
            If cbFederal.Checked = True Then
                varcost = varcost - (varcost * fedDiscRate)
            End If
        End If
        lblTotalChargeMonth.Text = varcost.ToString("c")
    End Sub
End Class
