<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CoffeeShopForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CoffeeShopForm))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnAccount = New System.Windows.Forms.ToolStripDropDownButton()
        Me.mnuAccountLogin = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAccountLogout = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.cboDrinkType = New System.Windows.Forms.ToolStripComboBox()
        Me.btnPurchase = New System.Windows.Forms.ToolStripButton()
        Me.pnlCost = New System.Windows.Forms.Panel()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lblCost = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlLogin = New System.Windows.Forms.Panel()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        Me.pnlCost.SuspendLayout()
        Me.pnlLogin.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnAccount, Me.ToolStripSeparator1, Me.cboDrinkType, Me.btnPurchase})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(488, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnAccount
        '
        Me.btnAccount.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnAccount.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAccountLogin, Me.mnuAccountLogout})
        Me.btnAccount.Image = CType(resources.GetObject("btnAccount.Image"), System.Drawing.Image)
        Me.btnAccount.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAccount.Name = "btnAccount"
        Me.btnAccount.Size = New System.Drawing.Size(65, 22)
        Me.btnAccount.Text = "Account"
        '
        'mnuAccountLogin
        '
        Me.mnuAccountLogin.Name = "mnuAccountLogin"
        Me.mnuAccountLogin.Size = New System.Drawing.Size(152, 22)
        Me.mnuAccountLogin.Text = "Log In"
        '
        'mnuAccountLogout
        '
        Me.mnuAccountLogout.Name = "mnuAccountLogout"
        Me.mnuAccountLogout.Size = New System.Drawing.Size(152, 22)
        Me.mnuAccountLogout.Text = "Log Out"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'cboDrinkType
        '
        Me.cboDrinkType.Items.AddRange(New Object() {"Daily Brew", "Espresso", "Cappuccino", "Latte"})
        Me.cboDrinkType.Name = "cboDrinkType"
        Me.cboDrinkType.Size = New System.Drawing.Size(121, 25)
        Me.cboDrinkType.Text = "Drink Type"
        Me.cboDrinkType.Visible = False
        '
        'btnPurchase
        '
        Me.btnPurchase.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnPurchase.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnPurchase.Image = CType(resources.GetObject("btnPurchase.Image"), System.Drawing.Image)
        Me.btnPurchase.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPurchase.Name = "btnPurchase"
        Me.btnPurchase.Size = New System.Drawing.Size(59, 22)
        Me.btnPurchase.Text = "Purchase"
        Me.btnPurchase.Visible = False
        '
        'pnlCost
        '
        Me.pnlCost.Controls.Add(Me.lblTotal)
        Me.pnlCost.Controls.Add(Me.lblTax)
        Me.pnlCost.Controls.Add(Me.lblCost)
        Me.pnlCost.Controls.Add(Me.Label3)
        Me.pnlCost.Controls.Add(Me.Label2)
        Me.pnlCost.Controls.Add(Me.Label1)
        Me.pnlCost.Location = New System.Drawing.Point(0, 28)
        Me.pnlCost.Name = "pnlCost"
        Me.pnlCost.Size = New System.Drawing.Size(227, 145)
        Me.pnlCost.TabIndex = 1
        Me.pnlCost.Visible = False
        '
        'lblTotal
        '
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotal.Location = New System.Drawing.Point(98, 94)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(100, 23)
        Me.lblTotal.TabIndex = 5
        '
        'lblTax
        '
        Me.lblTax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTax.Location = New System.Drawing.Point(98, 62)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(100, 23)
        Me.lblTax.TabIndex = 6
        '
        'lblCost
        '
        Me.lblCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCost.Location = New System.Drawing.Point(98, 29)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(100, 23)
        Me.lblCost.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(58, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Total:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(64, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tax:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Beverage Cost:"
        '
        'pnlLogin
        '
        Me.pnlLogin.Controls.Add(Me.btnOk)
        Me.pnlLogin.Controls.Add(Me.txtPassword)
        Me.pnlLogin.Controls.Add(Me.txtUserName)
        Me.pnlLogin.Controls.Add(Me.Label5)
        Me.pnlLogin.Controls.Add(Me.Label4)
        Me.pnlLogin.Location = New System.Drawing.Point(233, 28)
        Me.pnlLogin.Name = "pnlLogin"
        Me.pnlLogin.Size = New System.Drawing.Size(237, 145)
        Me.pnlLogin.TabIndex = 2
        Me.pnlLogin.Visible = False
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(77, 109)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(75, 23)
        Me.btnOk.TabIndex = 3
        Me.btnOk.Text = "OK"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(77, 72)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(100, 20)
        Me.txtPassword.TabIndex = 6
        '
        'txtUserName
        '
        Me.txtUserName.Location = New System.Drawing.Point(77, 27)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(100, 20)
        Me.txtUserName.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 72)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Psasword:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Username:"
        '
        'CoffeeShopForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(488, 195)
        Me.Controls.Add(Me.pnlLogin)
        Me.Controls.Add(Me.pnlCost)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "CoffeeShopForm"
        Me.Text = "Kip & Tony's Coffee Express"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.pnlCost.ResumeLayout(False)
        Me.pnlCost.PerformLayout()
        Me.pnlLogin.ResumeLayout(False)
        Me.pnlLogin.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnAccount As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents mnuAccountLogin As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuAccountLogout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pnlCost As System.Windows.Forms.Panel
    Friend WithEvents pnlLogin As System.Windows.Forms.Panel
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cboDrinkType As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents btnPurchase As System.Windows.Forms.ToolStripButton
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents lblTax As System.Windows.Forms.Label
    Friend WithEvents lblCost As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtUserName As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnOk As System.Windows.Forms.Button

End Class
