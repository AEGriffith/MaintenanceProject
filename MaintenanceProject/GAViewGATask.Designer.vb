<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GAViewGATask
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GAViewGATask))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbSupervisor = New System.Windows.Forms.TextBox()
        Me.tbType = New System.Windows.Forms.TextBox()
        Me.TaskBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PROJECTS1747DataSet7 = New MaintenanceProject.PROJECTS1747DataSet7()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbPriority = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbEstimatedHours = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbDate = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbInstructions = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbProgress = New System.Windows.Forms.ComboBox()
        Me.numActualHours = New System.Windows.Forms.NumericUpDown()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.TaskTableAdapter = New MaintenanceProject.PROJECTS1747DataSet7TableAdapters.TaskTableAdapter()
        CType(Me.TaskBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PROJECTS1747DataSet7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numActualHours, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 58)
        Me.Label1.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Supervisor"
        '
        'tbSupervisor
        '
        Me.tbSupervisor.Location = New System.Drawing.Point(98, 57)
        Me.tbSupervisor.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.tbSupervisor.Name = "tbSupervisor"
        Me.tbSupervisor.ReadOnly = True
        Me.tbSupervisor.Size = New System.Drawing.Size(71, 20)
        Me.tbSupervisor.TabIndex = 1
        '
        'tbType
        '
        Me.tbType.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TaskBindingSource, "Task_Type", True))
        Me.tbType.Location = New System.Drawing.Point(98, 92)
        Me.tbType.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.tbType.Name = "tbType"
        Me.tbType.ReadOnly = True
        Me.tbType.Size = New System.Drawing.Size(71, 20)
        Me.tbType.TabIndex = 3
        '
        'TaskBindingSource
        '
        Me.TaskBindingSource.DataMember = "Task"
        Me.TaskBindingSource.DataSource = Me.PROJECTS1747DataSet7
        '
        'PROJECTS1747DataSet7
        '
        Me.PROJECTS1747DataSet7.DataSetName = "PROJECTS1747DataSet7"
        Me.PROJECTS1747DataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 94)
        Me.Label2.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Task Type"
        '
        'tbPriority
        '
        Me.tbPriority.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TaskBindingSource, "Priority", True))
        Me.tbPriority.Location = New System.Drawing.Point(98, 129)
        Me.tbPriority.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.tbPriority.Name = "tbPriority"
        Me.tbPriority.ReadOnly = True
        Me.tbPriority.Size = New System.Drawing.Size(71, 20)
        Me.tbPriority.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 130)
        Me.Label3.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Priority"
        '
        'tbEstimatedHours
        '
        Me.tbEstimatedHours.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TaskBindingSource, "Estimated_Hours", True))
        Me.tbEstimatedHours.Location = New System.Drawing.Point(98, 204)
        Me.tbEstimatedHours.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.tbEstimatedHours.Name = "tbEstimatedHours"
        Me.tbEstimatedHours.ReadOnly = True
        Me.tbEstimatedHours.Size = New System.Drawing.Size(71, 20)
        Me.tbEstimatedHours.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 205)
        Me.Label5.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Estimated Hours"
        '
        'tbDate
        '
        Me.tbDate.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TaskBindingSource, "Due_Date", True))
        Me.tbDate.Location = New System.Drawing.Point(98, 169)
        Me.tbDate.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.tbDate.Name = "tbDate"
        Me.tbDate.ReadOnly = True
        Me.tbDate.Size = New System.Drawing.Size(71, 20)
        Me.tbDate.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 170)
        Me.Label6.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Due Date"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(200, 58)
        Me.Label4.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Instructions"
        '
        'tbInstructions
        '
        Me.tbInstructions.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TaskBindingSource, "Instructions", True))
        Me.tbInstructions.Location = New System.Drawing.Point(202, 73)
        Me.tbInstructions.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.tbInstructions.Multiline = True
        Me.tbInstructions.Name = "tbInstructions"
        Me.tbInstructions.ReadOnly = True
        Me.tbInstructions.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbInstructions.Size = New System.Drawing.Size(155, 74)
        Me.tbInstructions.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(200, 205)
        Me.Label7.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Actual Hours"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(200, 170)
        Me.Label8.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 13)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Progress"
        '
        'cbProgress
        '
        Me.cbProgress.FormattingEnabled = True
        Me.cbProgress.Items.AddRange(New Object() {"Not Started", "In Progress", "Completed"})
        Me.cbProgress.Location = New System.Drawing.Point(260, 169)
        Me.cbProgress.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.cbProgress.Name = "cbProgress"
        Me.cbProgress.Size = New System.Drawing.Size(98, 21)
        Me.cbProgress.TabIndex = 16
        '
        'numActualHours
        '
        Me.numActualHours.Enabled = False
        Me.numActualHours.Location = New System.Drawing.Point(310, 205)
        Me.numActualHours.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.numActualHours.Name = "numActualHours"
        Me.numActualHours.Size = New System.Drawing.Size(45, 20)
        Me.numActualHours.TabIndex = 17
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(310, 239)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(50, 24)
        Me.btnCancel.TabIndex = 18
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(254, 239)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(50, 24)
        Me.btnUpdate.TabIndex = 19
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'TaskTableAdapter
        '
        Me.TaskTableAdapter.ClearBeforeFill = True
        '
        'GAViewGATask
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(381, 273)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.numActualHours)
        Me.Controls.Add(Me.cbProgress)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.tbInstructions)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tbEstimatedHours)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tbDate)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tbPriority)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbType)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbSupervisor)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.Name = "GAViewGATask"
        Me.Text = "View Task"
        CType(Me.TaskBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PROJECTS1747DataSet7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numActualHours, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents tbSupervisor As TextBox
    Friend WithEvents tbType As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tbPriority As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tbEstimatedHours As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tbDate As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents tbInstructions As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents cbProgress As ComboBox
    Friend WithEvents numActualHours As NumericUpDown
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents PROJECTS1747DataSet7 As PROJECTS1747DataSet7
    Friend WithEvents TaskBindingSource As BindingSource
    Friend WithEvents TaskTableAdapter As PROJECTS1747DataSet7TableAdapters.TaskTableAdapter
End Class
