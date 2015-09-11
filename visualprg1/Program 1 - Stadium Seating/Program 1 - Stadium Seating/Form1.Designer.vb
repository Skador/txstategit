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
        Me.txtTSClassA = New System.Windows.Forms.TextBox()
        Me.txtTSClassB = New System.Windows.Forms.TextBox()
        Me.txtTSClassC = New System.Windows.Forms.TextBox()
        Me.lblTSClassC = New System.Windows.Forms.Label()
        Me.lblTSClassB = New System.Windows.Forms.Label()
        Me.lblTSClassA = New System.Windows.Forms.Label()
        Me.lblInformation = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblRGTotalRevTotal = New System.Windows.Forms.Label()
        Me.lblRGClassCTotal = New System.Windows.Forms.Label()
        Me.lblRGClassBTotal = New System.Windows.Forms.Label()
        Me.lblRGClassA = New System.Windows.Forms.Label()
        Me.lblRGClassB = New System.Windows.Forms.Label()
        Me.lblRGClassC = New System.Windows.Forms.Label()
        Me.lblRGTotalRev = New System.Windows.Forms.Label()
        Me.lblRGClassATotal = New System.Windows.Forms.Label()
        Me.btnCalcRev = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtTSClassA)
        Me.GroupBox1.Controls.Add(Me.txtTSClassB)
        Me.GroupBox1.Controls.Add(Me.txtTSClassC)
        Me.GroupBox1.Controls.Add(Me.lblTSClassC)
        Me.GroupBox1.Controls.Add(Me.lblTSClassB)
        Me.GroupBox1.Controls.Add(Me.lblTSClassA)
        Me.GroupBox1.Controls.Add(Me.lblInformation)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(271, 148)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tickets Sold"
        '
        'txtTSClassA
        '
        Me.txtTSClassA.Location = New System.Drawing.Point(121, 58)
        Me.txtTSClassA.Name = "txtTSClassA"
        Me.txtTSClassA.Size = New System.Drawing.Size(100, 20)
        Me.txtTSClassA.TabIndex = 13
        '
        'txtTSClassB
        '
        Me.txtTSClassB.Location = New System.Drawing.Point(121, 84)
        Me.txtTSClassB.Name = "txtTSClassB"
        Me.txtTSClassB.Size = New System.Drawing.Size(100, 20)
        Me.txtTSClassB.TabIndex = 14
        '
        'txtTSClassC
        '
        Me.txtTSClassC.Location = New System.Drawing.Point(121, 110)
        Me.txtTSClassC.Name = "txtTSClassC"
        Me.txtTSClassC.Size = New System.Drawing.Size(100, 20)
        Me.txtTSClassC.TabIndex = 15
        '
        'lblTSClassC
        '
        Me.lblTSClassC.AutoSize = True
        Me.lblTSClassC.Location = New System.Drawing.Point(29, 114)
        Me.lblTSClassC.Name = "lblTSClassC"
        Me.lblTSClassC.Size = New System.Drawing.Size(45, 13)
        Me.lblTSClassC.TabIndex = 4
        Me.lblTSClassC.Text = "Class C:"
        '
        'lblTSClassB
        '
        Me.lblTSClassB.AutoSize = True
        Me.lblTSClassB.Location = New System.Drawing.Point(29, 87)
        Me.lblTSClassB.Name = "lblTSClassB"
        Me.lblTSClassB.Size = New System.Drawing.Size(45, 13)
        Me.lblTSClassB.TabIndex = 3
        Me.lblTSClassB.Text = "Class B:"
        '
        'lblTSClassA
        '
        Me.lblTSClassA.AutoSize = True
        Me.lblTSClassA.Location = New System.Drawing.Point(29, 61)
        Me.lblTSClassA.Name = "lblTSClassA"
        Me.lblTSClassA.Size = New System.Drawing.Size(45, 13)
        Me.lblTSClassA.TabIndex = 2
        Me.lblTSClassA.Text = "Class A:"
        '
        'lblInformation
        '
        Me.lblInformation.Location = New System.Drawing.Point(29, 22)
        Me.lblInformation.Name = "lblInformation"
        Me.lblInformation.Size = New System.Drawing.Size(174, 33)
        Me.lblInformation.TabIndex = 1
        Me.lblInformation.Text = "Enter the niumber of tickets sold for each class of seats:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblRGTotalRevTotal)
        Me.GroupBox2.Controls.Add(Me.lblRGClassCTotal)
        Me.GroupBox2.Controls.Add(Me.lblRGClassBTotal)
        Me.GroupBox2.Controls.Add(Me.lblRGClassA)
        Me.GroupBox2.Controls.Add(Me.lblRGClassB)
        Me.GroupBox2.Controls.Add(Me.lblRGClassC)
        Me.GroupBox2.Controls.Add(Me.lblRGTotalRev)
        Me.GroupBox2.Controls.Add(Me.lblRGClassATotal)
        Me.GroupBox2.Location = New System.Drawing.Point(289, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(283, 148)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Revenue Generated"
        '
        'lblRGTotalRevTotal
        '
        Me.lblRGTotalRevTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRGTotalRevTotal.Location = New System.Drawing.Point(93, 107)
        Me.lblRGTotalRevTotal.Name = "lblRGTotalRevTotal"
        Me.lblRGTotalRevTotal.Size = New System.Drawing.Size(100, 23)
        Me.lblRGTotalRevTotal.TabIndex = 12
        '
        'lblRGClassCTotal
        '
        Me.lblRGClassCTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRGClassCTotal.Location = New System.Drawing.Point(93, 76)
        Me.lblRGClassCTotal.Name = "lblRGClassCTotal"
        Me.lblRGClassCTotal.Size = New System.Drawing.Size(100, 23)
        Me.lblRGClassCTotal.TabIndex = 11
        '
        'lblRGClassBTotal
        '
        Me.lblRGClassBTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRGClassBTotal.Location = New System.Drawing.Point(93, 44)
        Me.lblRGClassBTotal.Name = "lblRGClassBTotal"
        Me.lblRGClassBTotal.Size = New System.Drawing.Size(100, 23)
        Me.lblRGClassBTotal.TabIndex = 10
        '
        'lblRGClassA
        '
        Me.lblRGClassA.AutoSize = True
        Me.lblRGClassA.Location = New System.Drawing.Point(21, 22)
        Me.lblRGClassA.Name = "lblRGClassA"
        Me.lblRGClassA.Size = New System.Drawing.Size(45, 13)
        Me.lblRGClassA.TabIndex = 5
        Me.lblRGClassA.Text = "Class A:"
        '
        'lblRGClassB
        '
        Me.lblRGClassB.AutoSize = True
        Me.lblRGClassB.Location = New System.Drawing.Point(21, 49)
        Me.lblRGClassB.Name = "lblRGClassB"
        Me.lblRGClassB.Size = New System.Drawing.Size(45, 13)
        Me.lblRGClassB.TabIndex = 6
        Me.lblRGClassB.Text = "Class B:"
        '
        'lblRGClassC
        '
        Me.lblRGClassC.AutoSize = True
        Me.lblRGClassC.Location = New System.Drawing.Point(21, 77)
        Me.lblRGClassC.Name = "lblRGClassC"
        Me.lblRGClassC.Size = New System.Drawing.Size(45, 13)
        Me.lblRGClassC.TabIndex = 7
        Me.lblRGClassC.Text = "Class C:"
        '
        'lblRGTotalRev
        '
        Me.lblRGTotalRev.AutoSize = True
        Me.lblRGTotalRev.Location = New System.Drawing.Point(6, 108)
        Me.lblRGTotalRev.Name = "lblRGTotalRev"
        Me.lblRGTotalRev.Size = New System.Drawing.Size(81, 13)
        Me.lblRGTotalRev.TabIndex = 8
        Me.lblRGTotalRev.Text = "Total Revenue:"
        '
        'lblRGClassATotal
        '
        Me.lblRGClassATotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRGClassATotal.Location = New System.Drawing.Point(93, 16)
        Me.lblRGClassATotal.Name = "lblRGClassATotal"
        Me.lblRGClassATotal.Size = New System.Drawing.Size(100, 23)
        Me.lblRGClassATotal.TabIndex = 9
        '
        'btnCalcRev
        '
        Me.btnCalcRev.Location = New System.Drawing.Point(12, 166)
        Me.btnCalcRev.Name = "btnCalcRev"
        Me.btnCalcRev.Size = New System.Drawing.Size(117, 23)
        Me.btnCalcRev.TabIndex = 16
        Me.btnCalcRev.Text = "Calculate Revenue"
        Me.btnCalcRev.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(245, 166)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 17
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(497, 166)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 18
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 202)
        Me.Controls.Add(Me.btnCalcRev)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblRGClassC As System.Windows.Forms.Label
    Friend WithEvents lblRGClassB As System.Windows.Forms.Label
    Friend WithEvents lblRGClassA As System.Windows.Forms.Label
    Friend WithEvents lblTSClassC As System.Windows.Forms.Label
    Friend WithEvents lblTSClassB As System.Windows.Forms.Label
    Friend WithEvents lblTSClassA As System.Windows.Forms.Label
    Friend WithEvents lblInformation As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblRGTotalRev As System.Windows.Forms.Label
    Friend WithEvents lblRGClassATotal As System.Windows.Forms.Label
    Friend WithEvents txtTSClassA As System.Windows.Forms.TextBox
    Friend WithEvents txtTSClassB As System.Windows.Forms.TextBox
    Friend WithEvents txtTSClassC As System.Windows.Forms.TextBox
    Friend WithEvents lblRGTotalRevTotal As System.Windows.Forms.Label
    Friend WithEvents lblRGClassCTotal As System.Windows.Forms.Label
    Friend WithEvents lblRGClassBTotal As System.Windows.Forms.Label
    Friend WithEvents btnCalcRev As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
