<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.gbSubscriptionPackage = New System.Windows.Forms.GroupBox()
        Me.rbPackageC = New System.Windows.Forms.RadioButton()
        Me.rbPackageB = New System.Windows.Forms.RadioButton()
        Me.rbPackageA = New System.Windows.Forms.RadioButton()
        Me.gbDiscount = New System.Windows.Forms.GroupBox()
        Me.cbNonProfOrg = New System.Windows.Forms.CheckBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lblNbrOfHrsUsed = New System.Windows.Forms.Label()
        Me.lblTotalAmountText = New System.Windows.Forms.Label()
        Me.txtNbrHrsEntered = New System.Windows.Forms.TextBox()
        Me.lblTotalAmount = New System.Windows.Forms.Label()
        Me.gbSubscriptionPackage.SuspendLayout()
        Me.gbDiscount.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbSubscriptionPackage
        '
        Me.gbSubscriptionPackage.Controls.Add(Me.rbPackageC)
        Me.gbSubscriptionPackage.Controls.Add(Me.rbPackageB)
        Me.gbSubscriptionPackage.Controls.Add(Me.rbPackageA)
        Me.gbSubscriptionPackage.Controls.Add(Me.gbDiscount)
        Me.gbSubscriptionPackage.Location = New System.Drawing.Point(0, 0)
        Me.gbSubscriptionPackage.Name = "gbSubscriptionPackage"
        Me.gbSubscriptionPackage.Size = New System.Drawing.Size(264, 98)
        Me.gbSubscriptionPackage.TabIndex = 0
        Me.gbSubscriptionPackage.TabStop = False
        Me.gbSubscriptionPackage.Text = "Select a Subscription Package"
        '
        'rbPackageC
        '
        Me.rbPackageC.AutoSize = True
        Me.rbPackageC.Location = New System.Drawing.Point(6, 70)
        Me.rbPackageC.Name = "rbPackageC"
        Me.rbPackageC.Size = New System.Drawing.Size(78, 17)
        Me.rbPackageC.TabIndex = 3
        Me.rbPackageC.TabStop = True
        Me.rbPackageC.Text = "Package C"
        Me.rbPackageC.UseVisualStyleBackColor = True
        '
        'rbPackageB
        '
        Me.rbPackageB.AutoSize = True
        Me.rbPackageB.Location = New System.Drawing.Point(6, 47)
        Me.rbPackageB.Name = "rbPackageB"
        Me.rbPackageB.Size = New System.Drawing.Size(78, 17)
        Me.rbPackageB.TabIndex = 2
        Me.rbPackageB.TabStop = True
        Me.rbPackageB.Text = "Package B"
        Me.rbPackageB.UseVisualStyleBackColor = True
        '
        'rbPackageA
        '
        Me.rbPackageA.AutoSize = True
        Me.rbPackageA.Location = New System.Drawing.Point(6, 24)
        Me.rbPackageA.Name = "rbPackageA"
        Me.rbPackageA.Size = New System.Drawing.Size(78, 17)
        Me.rbPackageA.TabIndex = 1
        Me.rbPackageA.TabStop = True
        Me.rbPackageA.Text = "Package A"
        Me.rbPackageA.UseVisualStyleBackColor = True
        '
        'gbDiscount
        '
        Me.gbDiscount.Controls.Add(Me.cbNonProfOrg)
        Me.gbDiscount.Location = New System.Drawing.Point(118, 47)
        Me.gbDiscount.Name = "gbDiscount"
        Me.gbDiscount.Size = New System.Drawing.Size(146, 51)
        Me.gbDiscount.TabIndex = 0
        Me.gbDiscount.TabStop = False
        Me.gbDiscount.Text = "Select a Discount"
        '
        'cbNonProfOrg
        '
        Me.cbNonProfOrg.AutoSize = True
        Me.cbNonProfOrg.Location = New System.Drawing.Point(6, 19)
        Me.cbNonProfOrg.Name = "cbNonProfOrg"
        Me.cbNonProfOrg.Size = New System.Drawing.Size(131, 17)
        Me.cbNonProfOrg.TabIndex = 4
        Me.cbNonProfOrg.Text = "Nonprofit Organization"
        Me.cbNonProfOrg.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(181, 165)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(93, 165)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(82, 23)
        Me.btnClear.TabIndex = 2
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(12, 165)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 3
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'lblNbrOfHrsUsed
        '
        Me.lblNbrOfHrsUsed.AutoSize = True
        Me.lblNbrOfHrsUsed.Location = New System.Drawing.Point(12, 111)
        Me.lblNbrOfHrsUsed.Name = "lblNbrOfHrsUsed"
        Me.lblNbrOfHrsUsed.Size = New System.Drawing.Size(164, 13)
        Me.lblNbrOfHrsUsed.TabIndex = 4
        Me.lblNbrOfHrsUsed.Text = "Enter the Number of Hours Used:"
        '
        'lblTotalAmountText
        '
        Me.lblTotalAmountText.AutoSize = True
        Me.lblTotalAmountText.Location = New System.Drawing.Point(80, 138)
        Me.lblTotalAmountText.Name = "lblTotalAmountText"
        Me.lblTotalAmountText.Size = New System.Drawing.Size(96, 13)
        Me.lblTotalAmountText.TabIndex = 5
        Me.lblTotalAmountText.Text = "Total Amount Due:"
        '
        'txtNbrHrsEntered
        '
        Me.txtNbrHrsEntered.Location = New System.Drawing.Point(182, 108)
        Me.txtNbrHrsEntered.Name = "txtNbrHrsEntered"
        Me.txtNbrHrsEntered.Size = New System.Drawing.Size(73, 20)
        Me.txtNbrHrsEntered.TabIndex = 6
        '
        'lblTotalAmount
        '
        Me.lblTotalAmount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalAmount.Location = New System.Drawing.Point(182, 137)
        Me.lblTotalAmount.Name = "lblTotalAmount"
        Me.lblTotalAmount.Size = New System.Drawing.Size(73, 23)
        Me.lblTotalAmount.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(268, 198)
        Me.Controls.Add(Me.lblTotalAmount)
        Me.Controls.Add(Me.txtNbrHrsEntered)
        Me.Controls.Add(Me.lblTotalAmountText)
        Me.Controls.Add(Me.lblNbrOfHrsUsed)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.gbSubscriptionPackage)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.gbSubscriptionPackage.ResumeLayout(False)
        Me.gbSubscriptionPackage.PerformLayout()
        Me.gbDiscount.ResumeLayout(False)
        Me.gbDiscount.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gbSubscriptionPackage As System.Windows.Forms.GroupBox
    Friend WithEvents rbPackageC As System.Windows.Forms.RadioButton
    Friend WithEvents rbPackageB As System.Windows.Forms.RadioButton
    Friend WithEvents rbPackageA As System.Windows.Forms.RadioButton
    Friend WithEvents gbDiscount As System.Windows.Forms.GroupBox
    Friend WithEvents cbNonProfOrg As System.Windows.Forms.CheckBox
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents lblNbrOfHrsUsed As System.Windows.Forms.Label
    Friend WithEvents lblTotalAmountText As System.Windows.Forms.Label
    Friend WithEvents txtNbrHrsEntered As System.Windows.Forms.TextBox
    Friend WithEvents lblTotalAmount As System.Windows.Forms.Label

End Class
