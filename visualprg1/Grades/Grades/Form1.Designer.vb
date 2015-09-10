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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblYourScore = New System.Windows.Forms.Label()
        Me.lblLetterGrade = New System.Windows.Forms.Label()
        Me.lblGradeFinal = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtGradeEntry = New System.Windows.Forms.TextBox()
        Me.btnCalcGrade = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(12, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(195, 20)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Letter Grade Computation"
        '
        'lblYourScore
        '
        Me.lblYourScore.AutoSize = True
        Me.lblYourScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYourScore.Location = New System.Drawing.Point(12, 61)
        Me.lblYourScore.Name = "lblYourScore"
        Me.lblYourScore.Size = New System.Drawing.Size(93, 20)
        Me.lblYourScore.TabIndex = 1
        Me.lblYourScore.Text = "Your Score:"
        '
        'lblLetterGrade
        '
        Me.lblLetterGrade.AutoSize = True
        Me.lblLetterGrade.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLetterGrade.Location = New System.Drawing.Point(12, 104)
        Me.lblLetterGrade.Name = "lblLetterGrade"
        Me.lblLetterGrade.Size = New System.Drawing.Size(100, 20)
        Me.lblLetterGrade.TabIndex = 2
        Me.lblLetterGrade.Text = "Letter Grade"
        '
        'lblGradeFinal
        '
        Me.lblGradeFinal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGradeFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGradeFinal.Location = New System.Drawing.Point(161, 104)
        Me.lblGradeFinal.Name = "lblGradeFinal"
        Me.lblGradeFinal.Size = New System.Drawing.Size(42, 23)
        Me.lblGradeFinal.TabIndex = 3
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(74, 180)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 31)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtGradeEntry
        '
        Me.txtGradeEntry.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGradeEntry.Location = New System.Drawing.Point(161, 61)
        Me.txtGradeEntry.Name = "txtGradeEntry"
        Me.txtGradeEntry.Size = New System.Drawing.Size(42, 26)
        Me.txtGradeEntry.TabIndex = 5
        '
        'btnCalcGrade
        '
        Me.btnCalcGrade.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalcGrade.Location = New System.Drawing.Point(12, 143)
        Me.btnCalcGrade.Name = "btnCalcGrade"
        Me.btnCalcGrade.Size = New System.Drawing.Size(114, 31)
        Me.btnCalcGrade.TabIndex = 6
        Me.btnCalcGrade.Text = "Letter Grade"
        Me.btnCalcGrade.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(128, 143)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 31)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(223, 228)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalcGrade)
        Me.Controls.Add(Me.txtGradeEntry)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblGradeFinal)
        Me.Controls.Add(Me.lblLetterGrade)
        Me.Controls.Add(Me.lblYourScore)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblYourScore As System.Windows.Forms.Label
    Friend WithEvents lblLetterGrade As System.Windows.Forms.Label
    Friend WithEvents lblGradeFinal As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents txtGradeEntry As System.Windows.Forms.TextBox
    Friend WithEvents btnCalcGrade As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button

End Class
