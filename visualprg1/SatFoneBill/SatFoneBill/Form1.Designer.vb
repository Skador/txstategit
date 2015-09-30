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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbDaytime = New System.Windows.Forms.RadioButton()
        Me.rbEvening = New System.Windows.Forms.RadioButton()
        Me.rbOffPeak = New System.Windows.Forms.RadioButton()
        Me.cbLongTerm = New System.Windows.Forms.CheckBox()
        Me.cbFederal = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNumMin = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblTotalChargeMonth = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbOffPeak)
        Me.GroupBox1.Controls.Add(Me.rbEvening)
        Me.GroupBox1.Controls.Add(Me.rbDaytime)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(236, 50)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select a Rate Catagory"
        '
        'rbDaytime
        '
        Me.rbDaytime.AutoSize = True
        Me.rbDaytime.Location = New System.Drawing.Point(6, 19)
        Me.rbDaytime.Name = "rbDaytime"
        Me.rbDaytime.Size = New System.Drawing.Size(63, 17)
        Me.rbDaytime.TabIndex = 0
        Me.rbDaytime.TabStop = True
        Me.rbDaytime.Text = "Daytime"
        Me.rbDaytime.UseVisualStyleBackColor = True
        '
        'rbEvening
        '
        Me.rbEvening.AutoSize = True
        Me.rbEvening.Location = New System.Drawing.Point(84, 19)
        Me.rbEvening.Name = "rbEvening"
        Me.rbEvening.Size = New System.Drawing.Size(64, 17)
        Me.rbEvening.TabIndex = 1
        Me.rbEvening.TabStop = True
        Me.rbEvening.Text = "Evening"
        Me.rbEvening.UseVisualStyleBackColor = True
        '
        'rbOffPeak
        '
        Me.rbOffPeak.AutoSize = True
        Me.rbOffPeak.Location = New System.Drawing.Point(163, 19)
        Me.rbOffPeak.Name = "rbOffPeak"
        Me.rbOffPeak.Size = New System.Drawing.Size(67, 17)
        Me.rbOffPeak.TabIndex = 2
        Me.rbOffPeak.TabStop = True
        Me.rbOffPeak.Text = "Off-Peak"
        Me.rbOffPeak.UseVisualStyleBackColor = True
        '
        'cbLongTerm
        '
        Me.cbLongTerm.AutoSize = True
        Me.cbLongTerm.Location = New System.Drawing.Point(18, 80)
        Me.cbLongTerm.Name = "cbLongTerm"
        Me.cbLongTerm.Size = New System.Drawing.Size(120, 17)
        Me.cbLongTerm.TabIndex = 1
        Me.cbLongTerm.Text = "Long-Term Contract"
        Me.cbLongTerm.UseVisualStyleBackColor = True
        '
        'cbFederal
        '
        Me.cbFederal.AutoSize = True
        Me.cbFederal.Location = New System.Drawing.Point(144, 80)
        Me.cbFederal.Name = "cbFederal"
        Me.cbFederal.Size = New System.Drawing.Size(104, 17)
        Me.cbFederal.TabIndex = 2
        Me.cbFederal.Text = "Federal Account"
        Me.cbFederal.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 115)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Enter number of minutes:"
        '
        'txtNumMin
        '
        Me.txtNumMin.Location = New System.Drawing.Point(156, 112)
        Me.txtNumMin.Name = "txtNumMin"
        Me.txtNumMin.Size = New System.Drawing.Size(86, 20)
        Me.txtNumMin.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 147)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Total Charge for the Month:"
        '
        'lblTotalChargeMonth
        '
        Me.lblTotalChargeMonth.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalChargeMonth.Location = New System.Drawing.Point(157, 138)
        Me.lblTotalChargeMonth.Name = "lblTotalChargeMonth"
        Me.lblTotalChargeMonth.Size = New System.Drawing.Size(86, 22)
        Me.lblTotalChargeMonth.TabIndex = 6
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(12, 184)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 7
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(96, 184)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(66, 23)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(168, 184)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(255, 219)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblTotalChargeMonth)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNumMin)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbFederal)
        Me.Controls.Add(Me.cbLongTerm)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Sat Phone Billing"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbDaytime As System.Windows.Forms.RadioButton
    Friend WithEvents rbOffPeak As System.Windows.Forms.RadioButton
    Friend WithEvents rbEvening As System.Windows.Forms.RadioButton
    Friend WithEvents cbLongTerm As System.Windows.Forms.CheckBox
    Friend WithEvents cbFederal As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNumMin As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblTotalChargeMonth As System.Windows.Forms.Label
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
