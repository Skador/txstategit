Public Class CoffeeShopForm

    ' Array to hold the prices of drink
    Private ReadOnly mPrices As Double() = {1.75, 2.5, 3.5, 3.75}
    Private ReadOnly mSalesTaxRate As Double = 0.065

    Private Sub CoffeeShopForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnPurchase_Click(sender As Object, e As EventArgs) Handles btnPurchase.Click
        ' User has clicked the Purchase Button
        MessageBox.Show("Thank you!")
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        'User has clicked the OK button to log in
        pnlLogin.Visible = False
        cboDrinkType.Visible = True
    End Sub

    Private Sub mnuAccountLogin_Click(sender As Object, e As EventArgs) Handles mnuAccountLogin.Click
        'User has selected Log In from the menu.
        pnlLogin.Visible = True
    End Sub

    Private Sub mnuAccountLogout_Click(sender As Object, e As EventArgs) Handles mnuAccountLogout.Click
        'User has logged out from the menu
        cboDrinkType.Visible = False
        pnlLogin.Visible = False
        pnlCost.Visible = False
        btnPurchase.Visible = False
    End Sub

    Private Sub cboDrinkType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDrinkType.SelectedIndexChanged
        'User has selected a drink from the combo box

        Dim cost As Double = mPrices(cboDrinkType.SelectedIndex)
        Dim tax As Double = cost * mSalesTaxRate
        Dim total As Double = cost + tax

        lblCost.Text = cost.ToString("n")
        lblTax.Text = tax.ToString("n")
        lblTotal.Text = total.ToString("c")

        'Show drink cost panel and enable Purchase button.
        pnlCost.Visible = True
        btnPurchase.Visible = True
    End Sub
End Class
