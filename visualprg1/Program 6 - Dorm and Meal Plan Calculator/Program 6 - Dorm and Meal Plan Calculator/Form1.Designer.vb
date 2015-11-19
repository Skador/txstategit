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
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnAddDorm = New System.Windows.Forms.Button()
        Me.btnMealPlans = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.lstDorm = New System.Windows.Forms.ListBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblDorm = New System.Windows.Forms.Label()
        Me.lblMealPlan = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lstDorm)
        Me.GroupBox1.Location = New System.Drawing.Point(21, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(259, 171)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select a Dormitory"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(465, 239)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(89, 66)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnAddDorm
        '
        Me.btnAddDorm.Location = New System.Drawing.Point(12, 239)
        Me.btnAddDorm.Name = "btnAddDorm"
        Me.btnAddDorm.Size = New System.Drawing.Size(89, 66)
        Me.btnAddDorm.TabIndex = 2
        Me.btnAddDorm.Text = "Add Dormitory"
        Me.btnAddDorm.UseVisualStyleBackColor = True
        '
        'btnMealPlans
        '
        Me.btnMealPlans.Location = New System.Drawing.Point(163, 239)
        Me.btnMealPlans.Name = "btnMealPlans"
        Me.btnMealPlans.Size = New System.Drawing.Size(89, 66)
        Me.btnMealPlans.TabIndex = 3
        Me.btnMealPlans.Text = "View Meal Plans"
        Me.btnMealPlans.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(314, 239)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(89, 66)
        Me.btnReset.TabIndex = 4
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'lstDorm
        '
        Me.lstDorm.FormattingEnabled = True
        Me.lstDorm.ItemHeight = 16
        Me.lstDorm.Items.AddRange(New Object() {"Allen Hall", "Pike Hall", "Farthing Hall", "University Hall"})
        Me.lstDorm.Location = New System.Drawing.Point(21, 47)
        Me.lstDorm.Name = "lstDorm"
        Me.lstDorm.Size = New System.Drawing.Size(208, 84)
        Me.lstDorm.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblTotal)
        Me.GroupBox2.Controls.Add(Me.lblMealPlan)
        Me.GroupBox2.Controls.Add(Me.lblDorm)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(301, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(253, 171)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Charges for the Semester"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(68, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Dormitory:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(67, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Meal Plan:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(97, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Total:"
        '
        'lblDorm
        '
        Me.lblDorm.BackColor = System.Drawing.SystemColors.Control
        Me.lblDorm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDorm.Location = New System.Drawing.Point(147, 25)
        Me.lblDorm.Name = "lblDorm"
        Me.lblDorm.Size = New System.Drawing.Size(100, 23)
        Me.lblDorm.TabIndex = 3
        '
        'lblMealPlan
        '
        Me.lblMealPlan.BackColor = System.Drawing.SystemColors.Control
        Me.lblMealPlan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMealPlan.Location = New System.Drawing.Point(147, 77)
        Me.lblMealPlan.Name = "lblMealPlan"
        Me.lblMealPlan.Size = New System.Drawing.Size(100, 23)
        Me.lblMealPlan.TabIndex = 4
        '
        'lblTotal
        '
        Me.lblTotal.BackColor = System.Drawing.SystemColors.Control
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotal.Location = New System.Drawing.Point(147, 129)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(100, 23)
        Me.lblTotal.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(568, 317)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnMealPlans)
        Me.Controls.Add(Me.btnAddDorm)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Dorm and Meal Plan Calculator"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnAddDorm As System.Windows.Forms.Button
    Friend WithEvents btnMealPlans As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents lstDorm As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents lblMealPlan As System.Windows.Forms.Label
    Friend WithEvents lblDorm As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
