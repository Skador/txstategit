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
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lblTotal_rtn = New System.Windows.Forms.Label()
        Me.lblTax_rtn = New System.Windows.Forms.Label()
        Me.lblParts_rtn = New System.Windows.Forms.Label()
        Me.lblServices_rtn = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtboxLabor = New System.Windows.Forms.TextBox()
        Me.txtboxParts = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.chkTireRotation = New System.Windows.Forms.CheckBox()
        Me.chkReplaceMuffler = New System.Windows.Forms.CheckBox()
        Me.chkInspection = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.chkTransFlush = New System.Windows.Forms.CheckBox()
        Me.chkRadFlush = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.chkLubeJob = New System.Windows.Forms.CheckBox()
        Me.chkOilChg = New System.Windows.Forms.CheckBox()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(356, 432)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(91, 36)
        Me.btnExit.TabIndex = 12
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(214, 432)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(91, 35)
        Me.btnClear.TabIndex = 11
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(71, 432)
        Me.btnCalculate.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(91, 35)
        Me.btnCalculate.TabIndex = 10
        Me.btnCalculate.Text = "Calculate Total"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label18)
        Me.GroupBox5.Controls.Add(Me.Label17)
        Me.GroupBox5.Controls.Add(Me.Label16)
        Me.GroupBox5.Controls.Add(Me.Label15)
        Me.GroupBox5.Controls.Add(Me.lblTotal_rtn)
        Me.GroupBox5.Controls.Add(Me.lblTax_rtn)
        Me.GroupBox5.Controls.Add(Me.lblParts_rtn)
        Me.GroupBox5.Controls.Add(Me.lblServices_rtn)
        Me.GroupBox5.Location = New System.Drawing.Point(11, 235)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GroupBox5.Size = New System.Drawing.Size(497, 175)
        Me.GroupBox5.TabIndex = 6
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Summary"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(181, 140)
        Me.Label18.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(57, 13)
        Me.Label18.TabIndex = 7
        Me.Label18.Text = "Total Fees"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(165, 101)
        Me.Label17.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(72, 13)
        Me.Label17.TabIndex = 6
        Me.Label17.Text = "Tax (on parts)"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(207, 62)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(31, 13)
        Me.Label16.TabIndex = 5
        Me.Label16.Text = "Parts"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(151, 23)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(87, 13)
        Me.Label15.TabIndex = 4
        Me.Label15.Text = "Services && Labor"
        '
        'lblTotal_rtn
        '
        Me.lblTotal_rtn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotal_rtn.Location = New System.Drawing.Point(254, 140)
        Me.lblTotal_rtn.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTotal_rtn.Name = "lblTotal_rtn"
        Me.lblTotal_rtn.Size = New System.Drawing.Size(75, 19)
        Me.lblTotal_rtn.TabIndex = 3
        '
        'lblTax_rtn
        '
        Me.lblTax_rtn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTax_rtn.Location = New System.Drawing.Point(254, 100)
        Me.lblTax_rtn.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTax_rtn.Name = "lblTax_rtn"
        Me.lblTax_rtn.Size = New System.Drawing.Size(75, 19)
        Me.lblTax_rtn.TabIndex = 2
        '
        'lblParts_rtn
        '
        Me.lblParts_rtn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblParts_rtn.Location = New System.Drawing.Point(254, 62)
        Me.lblParts_rtn.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblParts_rtn.Name = "lblParts_rtn"
        Me.lblParts_rtn.Size = New System.Drawing.Size(75, 19)
        Me.lblParts_rtn.TabIndex = 1
        '
        'lblServices_rtn
        '
        Me.lblServices_rtn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblServices_rtn.Location = New System.Drawing.Point(254, 23)
        Me.lblServices_rtn.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblServices_rtn.Name = "lblServices_rtn"
        Me.lblServices_rtn.Size = New System.Drawing.Size(75, 19)
        Me.lblServices_rtn.TabIndex = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.txtboxLabor)
        Me.GroupBox4.Controls.Add(Me.txtboxParts)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Location = New System.Drawing.Point(256, 112)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GroupBox4.Size = New System.Drawing.Size(252, 118)
        Me.GroupBox4.TabIndex = 7
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Parts and Labor"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(153, 58)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "($20.00 per hour)"
        '
        'txtboxLabor
        '
        Me.txtboxLabor.Location = New System.Drawing.Point(69, 55)
        Me.txtboxLabor.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtboxLabor.Name = "txtboxLabor"
        Me.txtboxLabor.Size = New System.Drawing.Size(76, 20)
        Me.txtboxLabor.TabIndex = 3
        '
        'txtboxParts
        '
        Me.txtboxParts.Location = New System.Drawing.Point(69, 27)
        Me.txtboxParts.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtboxParts.Name = "txtboxParts"
        Me.txtboxParts.Size = New System.Drawing.Size(76, 20)
        Me.txtboxParts.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 58)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Labor"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 29)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Parts"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.chkTireRotation)
        Me.GroupBox3.Controls.Add(Me.chkReplaceMuffler)
        Me.GroupBox3.Controls.Add(Me.chkInspection)
        Me.GroupBox3.Location = New System.Drawing.Point(11, 112)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GroupBox3.Size = New System.Drawing.Size(241, 118)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Misc"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(143, 88)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(46, 13)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "($20.00)"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(143, 58)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 13)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "($100.00)"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(143, 27)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 13)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "($15.00)"
        '
        'chkTireRotation
        '
        Me.chkTireRotation.AutoSize = True
        Me.chkTireRotation.Location = New System.Drawing.Point(35, 88)
        Me.chkTireRotation.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.chkTireRotation.Name = "chkTireRotation"
        Me.chkTireRotation.Size = New System.Drawing.Size(87, 17)
        Me.chkTireRotation.TabIndex = 2
        Me.chkTireRotation.Text = "Tire Rotation"
        Me.chkTireRotation.UseVisualStyleBackColor = True
        '
        'chkReplaceMuffler
        '
        Me.chkReplaceMuffler.AutoSize = True
        Me.chkReplaceMuffler.Location = New System.Drawing.Point(35, 58)
        Me.chkReplaceMuffler.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.chkReplaceMuffler.Name = "chkReplaceMuffler"
        Me.chkReplaceMuffler.Size = New System.Drawing.Size(101, 17)
        Me.chkReplaceMuffler.TabIndex = 1
        Me.chkReplaceMuffler.Text = "Replace Muffler"
        Me.chkReplaceMuffler.UseVisualStyleBackColor = True
        '
        'chkInspection
        '
        Me.chkInspection.AutoSize = True
        Me.chkInspection.Location = New System.Drawing.Point(35, 26)
        Me.chkInspection.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.chkInspection.Name = "chkInspection"
        Me.chkInspection.Size = New System.Drawing.Size(75, 17)
        Me.chkInspection.TabIndex = 0
        Me.chkInspection.Text = "Inspection"
        Me.chkInspection.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.chkTransFlush)
        Me.GroupBox2.Controls.Add(Me.chkRadFlush)
        Me.GroupBox2.Location = New System.Drawing.Point(256, 12)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GroupBox2.Size = New System.Drawing.Size(252, 94)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Flushes"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(153, 62)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 13)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "($80.00)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(153, 29)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "($30.00)"
        '
        'chkTransFlush
        '
        Me.chkTransFlush.AutoSize = True
        Me.chkTransFlush.Location = New System.Drawing.Point(18, 62)
        Me.chkTransFlush.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.chkTransFlush.Name = "chkTransFlush"
        Me.chkTransFlush.Size = New System.Drawing.Size(115, 17)
        Me.chkTransFlush.TabIndex = 1
        Me.chkTransFlush.Text = "Transmission Flush"
        Me.chkTransFlush.UseVisualStyleBackColor = True
        '
        'chkRadFlush
        '
        Me.chkRadFlush.AutoSize = True
        Me.chkRadFlush.Location = New System.Drawing.Point(18, 29)
        Me.chkRadFlush.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.chkRadFlush.Name = "chkRadFlush"
        Me.chkRadFlush.Size = New System.Drawing.Size(94, 17)
        Me.chkRadFlush.TabIndex = 0
        Me.chkRadFlush.Text = "Radiator Flush"
        Me.chkRadFlush.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.chkLubeJob)
        Me.GroupBox1.Controls.Add(Me.chkOilChg)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 12)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GroupBox1.Size = New System.Drawing.Size(241, 94)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Oil && Lube"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(143, 62)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "($18.00)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(143, 29)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "($26.00)"
        '
        'chkLubeJob
        '
        Me.chkLubeJob.AutoSize = True
        Me.chkLubeJob.Location = New System.Drawing.Point(35, 62)
        Me.chkLubeJob.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.chkLubeJob.Name = "chkLubeJob"
        Me.chkLubeJob.Size = New System.Drawing.Size(70, 17)
        Me.chkLubeJob.TabIndex = 1
        Me.chkLubeJob.Text = "Lube Job"
        Me.chkLubeJob.UseVisualStyleBackColor = True
        '
        'chkOilChg
        '
        Me.chkOilChg.AutoSize = True
        Me.chkOilChg.Location = New System.Drawing.Point(35, 29)
        Me.chkOilChg.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.chkOilChg.Name = "chkOilChg"
        Me.chkOilChg.Size = New System.Drawing.Size(78, 17)
        Me.chkOilChg.TabIndex = 0
        Me.chkOilChg.Text = "Oil Change"
        Me.chkOilChg.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(523, 485)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents lblTotal_rtn As System.Windows.Forms.Label
    Friend WithEvents lblTax_rtn As System.Windows.Forms.Label
    Friend WithEvents lblParts_rtn As System.Windows.Forms.Label
    Friend WithEvents lblServices_rtn As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtboxLabor As System.Windows.Forms.TextBox
    Friend WithEvents txtboxParts As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents chkTireRotation As System.Windows.Forms.CheckBox
    Friend WithEvents chkReplaceMuffler As System.Windows.Forms.CheckBox
    Friend WithEvents chkInspection As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents chkTransFlush As System.Windows.Forms.CheckBox
    Friend WithEvents chkRadFlush As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents chkLubeJob As System.Windows.Forms.CheckBox
    Friend WithEvents chkOilChg As System.Windows.Forms.CheckBox

End Class
