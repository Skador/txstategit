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
        Me.components = New System.ComponentModel.Container()
        Dim StudentIDLabel As System.Windows.Forms.Label
        Dim StuFirstNameLabel As System.Windows.Forms.Label
        Dim StuLastNameLabel As System.Windows.Forms.Label
        Dim DateOfBirthLabel As System.Windows.Forms.Label
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.StudentIDTextBox = New System.Windows.Forms.TextBox()
        Me.StuFirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.StuLastNameTextBox = New System.Windows.Forms.TextBox()
        Me.DateOfBirthDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.StudentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database1DataSet1 = New _20160222_Program7.Database1DataSet1()
        Me.StudentIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StuFirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StuLastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateOfBirthDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StudentTableAdapter = New _20160222_Program7.Database1DataSet1TableAdapters.StudentTableAdapter()
        Me.TableAdapterManager = New _20160222_Program7.Database1DataSet1TableAdapters.TableAdapterManager()
        StudentIDLabel = New System.Windows.Forms.Label()
        StuFirstNameLabel = New System.Windows.Forms.Label()
        StuLastNameLabel = New System.Windows.Forms.Label()
        DateOfBirthLabel = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.StudentIDDataGridViewTextBoxColumn, Me.StuFirstNameDataGridViewTextBoxColumn, Me.StuLastNameDataGridViewTextBoxColumn, Me.DateOfBirthDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.StudentBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 52)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(703, 445)
        Me.DataGridView1.TabIndex = 0
        '
        'StudentIDLabel
        '
        StudentIDLabel.AutoSize = True
        StudentIDLabel.Location = New System.Drawing.Point(9, 15)
        StudentIDLabel.Name = "StudentIDLabel"
        StudentIDLabel.Size = New System.Drawing.Size(61, 13)
        StudentIDLabel.TabIndex = 1
        StudentIDLabel.Text = "Student ID:"
        '
        'StudentIDTextBox
        '
        Me.StudentIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentBindingSource, "StudentID", True))
        Me.StudentIDTextBox.Location = New System.Drawing.Point(76, 12)
        Me.StudentIDTextBox.Name = "StudentIDTextBox"
        Me.StudentIDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.StudentIDTextBox.TabIndex = 2
        '
        'StuFirstNameLabel
        '
        StuFirstNameLabel.AutoSize = True
        StuFirstNameLabel.Location = New System.Drawing.Point(182, 15)
        StuFirstNameLabel.Name = "StuFirstNameLabel"
        StuFirstNameLabel.Size = New System.Drawing.Size(79, 13)
        StuFirstNameLabel.TabIndex = 3
        StuFirstNameLabel.Text = "Stu First Name:"
        '
        'StuFirstNameTextBox
        '
        Me.StuFirstNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentBindingSource, "StuFirstName", True))
        Me.StuFirstNameTextBox.Location = New System.Drawing.Point(267, 12)
        Me.StuFirstNameTextBox.Name = "StuFirstNameTextBox"
        Me.StuFirstNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.StuFirstNameTextBox.TabIndex = 4
        '
        'StuLastNameLabel
        '
        StuLastNameLabel.AutoSize = True
        StuLastNameLabel.Location = New System.Drawing.Point(368, 15)
        StuLastNameLabel.Name = "StuLastNameLabel"
        StuLastNameLabel.Size = New System.Drawing.Size(80, 13)
        StuLastNameLabel.TabIndex = 5
        StuLastNameLabel.Text = "Stu Last Name:"
        '
        'StuLastNameTextBox
        '
        Me.StuLastNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentBindingSource, "StuLastName", True))
        Me.StuLastNameTextBox.Location = New System.Drawing.Point(454, 12)
        Me.StuLastNameTextBox.Name = "StuLastNameTextBox"
        Me.StuLastNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.StuLastNameTextBox.TabIndex = 6
        '
        'DateOfBirthLabel
        '
        DateOfBirthLabel.AutoSize = True
        DateOfBirthLabel.Location = New System.Drawing.Point(560, 15)
        DateOfBirthLabel.Name = "DateOfBirthLabel"
        DateOfBirthLabel.Size = New System.Drawing.Size(71, 13)
        DateOfBirthLabel.TabIndex = 7
        DateOfBirthLabel.Text = "Date Of Birth:"
        '
        'DateOfBirthDateTimePicker
        '
        Me.DateOfBirthDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.StudentBindingSource, "DateOfBirth", True))
        Me.DateOfBirthDateTimePicker.Location = New System.Drawing.Point(637, 9)
        Me.DateOfBirthDateTimePicker.Name = "DateOfBirthDateTimePicker"
        Me.DateOfBirthDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DateOfBirthDateTimePicker.TabIndex = 8
        '
        'btnSelect
        '
        Me.btnSelect.Location = New System.Drawing.Point(721, 51)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(75, 23)
        Me.btnSelect.TabIndex = 9
        Me.btnSelect.Text = "Select"
        Me.btnSelect.UseVisualStyleBackColor = True
        '
        'btnInsert
        '
        Me.btnInsert.Location = New System.Drawing.Point(721, 97)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(75, 23)
        Me.btnInsert.TabIndex = 10
        Me.btnInsert.Text = "Insert"
        Me.btnInsert.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(721, 144)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 11
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(721, 194)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 12
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'StudentBindingSource
        '
        Me.StudentBindingSource.DataMember = "Student"
        Me.StudentBindingSource.DataSource = Me.Database1DataSet1
        '
        'Database1DataSet1
        '
        Me.Database1DataSet1.DataSetName = "Database1DataSet1"
        Me.Database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StudentIDDataGridViewTextBoxColumn
        '
        Me.StudentIDDataGridViewTextBoxColumn.DataPropertyName = "StudentID"
        Me.StudentIDDataGridViewTextBoxColumn.HeaderText = "StudentID"
        Me.StudentIDDataGridViewTextBoxColumn.Name = "StudentIDDataGridViewTextBoxColumn"
        Me.StudentIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'StuFirstNameDataGridViewTextBoxColumn
        '
        Me.StuFirstNameDataGridViewTextBoxColumn.DataPropertyName = "StuFirstName"
        Me.StuFirstNameDataGridViewTextBoxColumn.HeaderText = "StuFirstName"
        Me.StuFirstNameDataGridViewTextBoxColumn.Name = "StuFirstNameDataGridViewTextBoxColumn"
        '
        'StuLastNameDataGridViewTextBoxColumn
        '
        Me.StuLastNameDataGridViewTextBoxColumn.DataPropertyName = "StuLastName"
        Me.StuLastNameDataGridViewTextBoxColumn.HeaderText = "StuLastName"
        Me.StuLastNameDataGridViewTextBoxColumn.Name = "StuLastNameDataGridViewTextBoxColumn"
        '
        'DateOfBirthDataGridViewTextBoxColumn
        '
        Me.DateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "DateOfBirth"
        Me.DateOfBirthDataGridViewTextBoxColumn.HeaderText = "DateOfBirth"
        Me.DateOfBirthDataGridViewTextBoxColumn.Name = "DateOfBirthDataGridViewTextBoxColumn"
        '
        'StudentTableAdapter
        '
        Me.StudentTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.StudentTableAdapter = Me.StudentTableAdapter
        Me.TableAdapterManager.UpdateOrder = _20160222_Program7.Database1DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(865, 523)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnInsert)
        Me.Controls.Add(Me.btnSelect)
        Me.Controls.Add(DateOfBirthLabel)
        Me.Controls.Add(Me.DateOfBirthDateTimePicker)
        Me.Controls.Add(StuLastNameLabel)
        Me.Controls.Add(Me.StuLastNameTextBox)
        Me.Controls.Add(StuFirstNameLabel)
        Me.Controls.Add(Me.StuFirstNameTextBox)
        Me.Controls.Add(StudentIDLabel)
        Me.Controls.Add(Me.StudentIDTextBox)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Database1DataSet1 As _20160222_Program7.Database1DataSet1
    Friend WithEvents StudentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StudentTableAdapter As _20160222_Program7.Database1DataSet1TableAdapters.StudentTableAdapter
    Friend WithEvents StudentIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StuFirstNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StuLastNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateOfBirthDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TableAdapterManager As _20160222_Program7.Database1DataSet1TableAdapters.TableAdapterManager
    Friend WithEvents StudentIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StuFirstNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StuLastNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DateOfBirthDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnSelect As System.Windows.Forms.Button
    Friend WithEvents btnInsert As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button

End Class
