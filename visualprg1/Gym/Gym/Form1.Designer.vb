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
        Me.gbTypeOfMembership = New System.Windows.Forms.GroupBox()
        Me.gbOptions = New System.Windows.Forms.GroupBox()
        Me.gbMembershipLength = New System.Windows.Forms.GroupBox()
        Me.gbMembershipFees = New System.Windows.Forms.GroupBox()
        Me.rbStandardAdult = New System.Windows.Forms.RadioButton()
        Me.rbChild = New System.Windows.Forms.RadioButton()
        Me.rbStudent = New System.Windows.Forms.RadioButton()
        Me.rbSenior = New System.Windows.Forms.RadioButton()
        Me.cbYoga = New System.Windows.Forms.CheckBox()
        Me.cbKarate = New System.Windows.Forms.CheckBox()
        Me.cbPersonalTrainer = New System.Windows.Forms.CheckBox()
        Me.lblNumOfMonthTxt = New System.Windows.Forms.Label()
        Me.txtNumMonths = New System.Windows.Forms.TextBox()
        Me.lblMonthlyFeesTxt = New System.Windows.Forms.Label()
        Me.lblMonthlyFee = New System.Windows.Forms.Label()
        Me.lblTotalTxt = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.gbTypeOfMembership.SuspendLayout()
        Me.gbOptions.SuspendLayout()
        Me.gbMembershipLength.SuspendLayout()
        Me.gbMembershipFees.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbTypeOfMembership
        '
        Me.gbTypeOfMembership.Controls.Add(Me.rbSenior)
        Me.gbTypeOfMembership.Controls.Add(Me.rbStudent)
        Me.gbTypeOfMembership.Controls.Add(Me.rbChild)
        Me.gbTypeOfMembership.Controls.Add(Me.rbStandardAdult)
        Me.gbTypeOfMembership.Location = New System.Drawing.Point(15, 12)
        Me.gbTypeOfMembership.Name = "gbTypeOfMembership"
        Me.gbTypeOfMembership.Size = New System.Drawing.Size(139, 114)
        Me.gbTypeOfMembership.TabIndex = 1
        Me.gbTypeOfMembership.TabStop = False
        Me.gbTypeOfMembership.Text = "Type of Membership"
        '
        'gbOptions
        '
        Me.gbOptions.Controls.Add(Me.cbPersonalTrainer)
        Me.gbOptions.Controls.Add(Me.cbKarate)
        Me.gbOptions.Controls.Add(Me.cbYoga)
        Me.gbOptions.Location = New System.Drawing.Point(160, 12)
        Me.gbOptions.Name = "gbOptions"
        Me.gbOptions.Size = New System.Drawing.Size(148, 114)
        Me.gbOptions.TabIndex = 0
        Me.gbOptions.TabStop = False
        Me.gbOptions.Text = "Options"
        '
        'gbMembershipLength
        '
        Me.gbMembershipLength.Controls.Add(Me.txtNumMonths)
        Me.gbMembershipLength.Controls.Add(Me.lblNumOfMonthTxt)
        Me.gbMembershipLength.Location = New System.Drawing.Point(15, 132)
        Me.gbMembershipLength.Name = "gbMembershipLength"
        Me.gbMembershipLength.Size = New System.Drawing.Size(139, 100)
        Me.gbMembershipLength.TabIndex = 0
        Me.gbMembershipLength.TabStop = False
        Me.gbMembershipLength.Text = "Membership Length"
        '
        'gbMembershipFees
        '
        Me.gbMembershipFees.Controls.Add(Me.lblTotal)
        Me.gbMembershipFees.Controls.Add(Me.lblTotalTxt)
        Me.gbMembershipFees.Controls.Add(Me.lblMonthlyFee)
        Me.gbMembershipFees.Controls.Add(Me.lblMonthlyFeesTxt)
        Me.gbMembershipFees.Location = New System.Drawing.Point(160, 132)
        Me.gbMembershipFees.Name = "gbMembershipFees"
        Me.gbMembershipFees.Size = New System.Drawing.Size(148, 100)
        Me.gbMembershipFees.TabIndex = 0
        Me.gbMembershipFees.TabStop = False
        Me.gbMembershipFees.Text = "Membership Fees"
        '
        'rbStandardAdult
        '
        Me.rbStandardAdult.AutoSize = True
        Me.rbStandardAdult.Location = New System.Drawing.Point(6, 19)
        Me.rbStandardAdult.Name = "rbStandardAdult"
        Me.rbStandardAdult.Size = New System.Drawing.Size(95, 17)
        Me.rbStandardAdult.TabIndex = 0
        Me.rbStandardAdult.TabStop = True
        Me.rbStandardAdult.Text = "Standard Adult"
        Me.rbStandardAdult.UseVisualStyleBackColor = True
        '
        'rbChild
        '
        Me.rbChild.AutoSize = True
        Me.rbChild.CausesValidation = False
        Me.rbChild.Location = New System.Drawing.Point(6, 42)
        Me.rbChild.Name = "rbChild"
        Me.rbChild.Size = New System.Drawing.Size(95, 17)
        Me.rbChild.TabIndex = 1
        Me.rbChild.TabStop = True
        Me.rbChild.Text = "Child Under 12"
        Me.rbChild.UseVisualStyleBackColor = True
        '
        'rbStudent
        '
        Me.rbStudent.AutoSize = True
        Me.rbStudent.Location = New System.Drawing.Point(6, 65)
        Me.rbStudent.Name = "rbStudent"
        Me.rbStudent.Size = New System.Drawing.Size(62, 17)
        Me.rbStudent.TabIndex = 2
        Me.rbStudent.TabStop = True
        Me.rbStudent.Text = "Student"
        Me.rbStudent.UseVisualStyleBackColor = True
        '
        'rbSenior
        '
        Me.rbSenior.AutoSize = True
        Me.rbSenior.Location = New System.Drawing.Point(6, 88)
        Me.rbSenior.Name = "rbSenior"
        Me.rbSenior.Size = New System.Drawing.Size(89, 17)
        Me.rbSenior.TabIndex = 3
        Me.rbSenior.TabStop = True
        Me.rbSenior.Text = "Senior Citizen"
        Me.rbSenior.UseVisualStyleBackColor = True
        '
        'cbYoga
        '
        Me.cbYoga.AutoSize = True
        Me.cbYoga.Location = New System.Drawing.Point(6, 20)
        Me.cbYoga.Name = "cbYoga"
        Me.cbYoga.Size = New System.Drawing.Size(51, 17)
        Me.cbYoga.TabIndex = 0
        Me.cbYoga.Text = "Yoga"
        Me.cbYoga.UseVisualStyleBackColor = True
        '
        'cbKarate
        '
        Me.cbKarate.AutoSize = True
        Me.cbKarate.Location = New System.Drawing.Point(6, 43)
        Me.cbKarate.Name = "cbKarate"
        Me.cbKarate.Size = New System.Drawing.Size(57, 17)
        Me.cbKarate.TabIndex = 1
        Me.cbKarate.Text = "Karate"
        Me.cbKarate.UseVisualStyleBackColor = True
        '
        'cbPersonalTrainer
        '
        Me.cbPersonalTrainer.AutoSize = True
        Me.cbPersonalTrainer.Location = New System.Drawing.Point(6, 66)
        Me.cbPersonalTrainer.Name = "cbPersonalTrainer"
        Me.cbPersonalTrainer.Size = New System.Drawing.Size(103, 17)
        Me.cbPersonalTrainer.TabIndex = 2
        Me.cbPersonalTrainer.Text = "Personal Trainer"
        Me.cbPersonalTrainer.UseVisualStyleBackColor = True
        '
        'lblNumOfMonthTxt
        '
        Me.lblNumOfMonthTxt.Location = New System.Drawing.Point(6, 28)
        Me.lblNumOfMonthTxt.Name = "lblNumOfMonthTxt"
        Me.lblNumOfMonthTxt.Size = New System.Drawing.Size(100, 33)
        Me.lblNumOfMonthTxt.TabIndex = 0
        Me.lblNumOfMonthTxt.Text = "Enter the number of Months:"
        '
        'txtNumMonths
        '
        Me.txtNumMonths.Location = New System.Drawing.Point(6, 64)
        Me.txtNumMonths.Name = "txtNumMonths"
        Me.txtNumMonths.Size = New System.Drawing.Size(100, 20)
        Me.txtNumMonths.TabIndex = 1
        '
        'lblMonthlyFeesTxt
        '
        Me.lblMonthlyFeesTxt.AutoSize = True
        Me.lblMonthlyFeesTxt.Location = New System.Drawing.Point(6, 28)
        Me.lblMonthlyFeesTxt.Name = "lblMonthlyFeesTxt"
        Me.lblMonthlyFeesTxt.Size = New System.Drawing.Size(62, 13)
        Me.lblMonthlyFeesTxt.TabIndex = 0
        Me.lblMonthlyFeesTxt.Text = "Montly Fee:"
        '
        'lblMonthlyFee
        '
        Me.lblMonthlyFee.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMonthlyFee.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblMonthlyFee.Location = New System.Drawing.Point(69, 28)
        Me.lblMonthlyFee.Name = "lblMonthlyFee"
        Me.lblMonthlyFee.Size = New System.Drawing.Size(65, 23)
        Me.lblMonthlyFee.TabIndex = 1
        '
        'lblTotalTxt
        '
        Me.lblTotalTxt.AutoSize = True
        Me.lblTotalTxt.Location = New System.Drawing.Point(29, 64)
        Me.lblTotalTxt.Name = "lblTotalTxt"
        Me.lblTotalTxt.Size = New System.Drawing.Size(34, 13)
        Me.lblTotalTxt.TabIndex = 2
        Me.lblTotalTxt.Text = "Total:"
        '
        'lblTotal
        '
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotal.Location = New System.Drawing.Point(69, 61)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(65, 23)
        Me.lblTotal.TabIndex = 3
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(14, 247)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 2
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(123, 247)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(232, 247)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 278)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(323, 22)
        Me.StatusStrip1.TabIndex = 5
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblStatus
        '
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(121, 17)
        Me.lblStatus.Text = "ToolStripStatusLabel1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(323, 300)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.gbOptions)
        Me.Controls.Add(Me.gbMembershipLength)
        Me.Controls.Add(Me.gbMembershipFees)
        Me.Controls.Add(Me.gbTypeOfMembership)
        Me.Name = "Form1"
        Me.Text = "Membership Fee Calculator"
        Me.gbTypeOfMembership.ResumeLayout(False)
        Me.gbTypeOfMembership.PerformLayout()
        Me.gbOptions.ResumeLayout(False)
        Me.gbOptions.PerformLayout()
        Me.gbMembershipLength.ResumeLayout(False)
        Me.gbMembershipLength.PerformLayout()
        Me.gbMembershipFees.ResumeLayout(False)
        Me.gbMembershipFees.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gbTypeOfMembership As System.Windows.Forms.GroupBox
    Friend WithEvents gbOptions As System.Windows.Forms.GroupBox
    Friend WithEvents gbMembershipLength As System.Windows.Forms.GroupBox
    Friend WithEvents gbMembershipFees As System.Windows.Forms.GroupBox
    Friend WithEvents rbSenior As System.Windows.Forms.RadioButton
    Friend WithEvents rbStudent As System.Windows.Forms.RadioButton
    Friend WithEvents rbChild As System.Windows.Forms.RadioButton
    Friend WithEvents rbStandardAdult As System.Windows.Forms.RadioButton
    Friend WithEvents cbPersonalTrainer As System.Windows.Forms.CheckBox
    Friend WithEvents cbKarate As System.Windows.Forms.CheckBox
    Friend WithEvents cbYoga As System.Windows.Forms.CheckBox
    Friend WithEvents txtNumMonths As System.Windows.Forms.TextBox
    Friend WithEvents lblNumOfMonthTxt As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents lblTotalTxt As System.Windows.Forms.Label
    Friend WithEvents lblMonthlyFee As System.Windows.Forms.Label
    Friend WithEvents lblMonthlyFeesTxt As System.Windows.Forms.Label
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblStatus As System.Windows.Forms.ToolStripStatusLabel

End Class
