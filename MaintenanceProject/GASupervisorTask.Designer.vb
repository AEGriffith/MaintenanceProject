<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GASupervisorTask
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbGA = New System.Windows.Forms.ComboBox()
        Me.ViewAssignedGAsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ViewAssignedGAs = New MaintenanceProject.viewAssignedGAs()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbTaskType = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbInstructions = New System.Windows.Forms.TextBox()
        Me.cbPriority = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dateDue = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.ViewAssignedGAsTableAdapter = New MaintenanceProject.viewAssignedGAsTableAdapters.viewAssignedGAsTableAdapter()
        CType(Me.ViewAssignedGAsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ViewAssignedGAs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 110)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(257, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Graduate Assistant"
        '
        'cbGA
        '
        Me.cbGA.DataSource = Me.ViewAssignedGAsBindingSource
        Me.cbGA.DisplayMember = "GA"
        Me.cbGA.FormattingEnabled = True
        Me.cbGA.Location = New System.Drawing.Point(28, 145)
        Me.cbGA.Name = "cbGA"
        Me.cbGA.Size = New System.Drawing.Size(268, 39)
        Me.cbGA.TabIndex = 1
        Me.cbGA.ValueMember = "Student_ID"
        '
        'ViewAssignedGAsBindingSource
        '
        Me.ViewAssignedGAsBindingSource.DataMember = "viewAssignedGAs"
        Me.ViewAssignedGAsBindingSource.DataSource = Me.ViewAssignedGAs
        '
        'ViewAssignedGAs
        '
        Me.ViewAssignedGAs.DataSetName = "viewAssignedGAs"
        Me.ViewAssignedGAs.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 210)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(146, 32)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Task Type"
        '
        'cbTaskType
        '
        Me.cbTaskType.FormattingEnabled = True
        Me.cbTaskType.Items.AddRange(New Object() {"Research", "Teaching", "Service", "Administrative"})
        Me.cbTaskType.Location = New System.Drawing.Point(28, 245)
        Me.cbTaskType.Name = "cbTaskType"
        Me.cbTaskType.Size = New System.Drawing.Size(268, 39)
        Me.cbTaskType.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 404)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(228, 32)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Task Instructions"
        '
        'tbInstructions
        '
        Me.tbInstructions.Location = New System.Drawing.Point(28, 439)
        Me.tbInstructions.MaxLength = 512
        Me.tbInstructions.Multiline = True
        Me.tbInstructions.Name = "tbInstructions"
        Me.tbInstructions.Size = New System.Drawing.Size(612, 187)
        Me.tbInstructions.TabIndex = 5
        '
        'cbPriority
        '
        Me.cbPriority.FormattingEnabled = True
        Me.cbPriority.Items.AddRange(New Object() {"Low", "Medium", "High"})
        Me.cbPriority.Location = New System.Drawing.Point(372, 145)
        Me.cbPriority.Name = "cbPriority"
        Me.cbPriority.Size = New System.Drawing.Size(268, 39)
        Me.cbPriority.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(366, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(172, 32)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Task Priority"
        '
        'dateDue
        '
        Me.dateDue.CustomFormat = ""
        Me.dateDue.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dateDue.Location = New System.Drawing.Point(372, 246)
        Me.dateDue.MaxDate = New Date(2017, 12, 22, 0, 0, 0, 0)
        Me.dateDue.MinDate = New Date(2017, 8, 14, 0, 0, 0, 0)
        Me.dateDue.Name = "dateDue"
        Me.dateDue.Size = New System.Drawing.Size(268, 38)
        Me.dateDue.TabIndex = 8
        Me.dateDue.Value = New Date(2017, 8, 16, 0, 0, 0, 0)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(366, 210)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(134, 32)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Due Date"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(27, 330)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(224, 32)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Estimated Hours"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(287, 328)
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(120, 38)
        Me.NumericUpDown1.TabIndex = 11
        Me.NumericUpDown1.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'btnCreate
        '
        Me.btnCreate.Location = New System.Drawing.Point(322, 651)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(152, 57)
        Me.btnCreate.TabIndex = 12
        Me.btnCreate.Text = "Create"
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(488, 651)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(152, 57)
        Me.btnCancel.TabIndex = 13
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'ViewAssignedGAsTableAdapter
        '
        Me.ViewAssignedGAsTableAdapter.ClearBeforeFill = True
        '
        'GASupervisorTask
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(674, 740)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnCreate)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dateDue)
        Me.Controls.Add(Me.cbPriority)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tbInstructions)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbTaskType)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbGA)
        Me.Controls.Add(Me.Label1)
        Me.Name = "GASupervisorTask"
        Me.Text = "Create Task Assignment"
        CType(Me.ViewAssignedGAsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ViewAssignedGAs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cbGA As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cbTaskType As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tbInstructions As TextBox
    Friend WithEvents cbPriority As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents dateDue As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents btnCreate As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents ViewAssignedGAs As viewAssignedGAs
    Friend WithEvents ViewAssignedGAsBindingSource As BindingSource
    Friend WithEvents ViewAssignedGAsTableAdapter As viewAssignedGAsTableAdapters.viewAssignedGAsTableAdapter
End Class
