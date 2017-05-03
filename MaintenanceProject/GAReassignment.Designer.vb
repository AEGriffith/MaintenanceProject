<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GAReassignment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GAReassignment))
        Me.cbSupervisor = New System.Windows.Forms.ComboBox()
        Me.ViewGASupervisorsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PROJECTS1747DataSet7 = New MaintenanceProject.PROJECTS1747DataSet7()
        Me.numHours = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblStudent = New System.Windows.Forms.Label()
        Me.lblSemester = New System.Windows.Forms.Label()
        Me.lblHours = New System.Windows.Forms.Label()
        Me.btnReassign = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.lblHours1 = New System.Windows.Forms.Label()
        Me.ViewGASupervisorsTableAdapter = New MaintenanceProject.PROJECTS1747DataSet7TableAdapters.viewGASupervisorsTableAdapter()
        CType(Me.ViewGASupervisorsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PROJECTS1747DataSet7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numHours, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbSupervisor
        '
        Me.cbSupervisor.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ViewGASupervisorsBindingSource, "User_ID", True))
        Me.cbSupervisor.DataSource = Me.ViewGASupervisorsBindingSource
        Me.cbSupervisor.DisplayMember = "Supervisor"
        Me.cbSupervisor.FormattingEnabled = True
        Me.cbSupervisor.Location = New System.Drawing.Point(71, 87)
        Me.cbSupervisor.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.cbSupervisor.Name = "cbSupervisor"
        Me.cbSupervisor.Size = New System.Drawing.Size(104, 21)
        Me.cbSupervisor.TabIndex = 0
        Me.cbSupervisor.ValueMember = "User_ID"
        '
        'ViewGASupervisorsBindingSource
        '
        Me.ViewGASupervisorsBindingSource.DataMember = "viewGASupervisors"
        Me.ViewGASupervisorsBindingSource.DataSource = Me.PROJECTS1747DataSet7
        '
        'PROJECTS1747DataSet7
        '
        Me.PROJECTS1747DataSet7.DataSetName = "PROJECTS1747DataSet7"
        Me.PROJECTS1747DataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'numHours
        '
        Me.numHours.Increment = New Decimal(New Integer() {10, 0, 0, 0})
        Me.numHours.Location = New System.Drawing.Point(128, 117)
        Me.numHours.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.numHours.Minimum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.numHours.Name = "numHours"
        Me.numHours.Size = New System.Drawing.Size(45, 20)
        Me.numHours.TabIndex = 1
        Me.numHours.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 88)
        Me.Label1.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Supervisor"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 117)
        Me.Label2.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Total Weekly Hours"
        '
        'lblStudent
        '
        Me.lblStudent.AutoSize = True
        Me.lblStudent.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudent.Location = New System.Drawing.Point(6, 11)
        Me.lblStudent.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblStudent.Name = "lblStudent"
        Me.lblStudent.Size = New System.Drawing.Size(112, 20)
        Me.lblStudent.TabIndex = 4
        Me.lblStudent.Text = "Student Name"
        '
        'lblSemester
        '
        Me.lblSemester.AutoSize = True
        Me.lblSemester.Location = New System.Drawing.Point(9, 32)
        Me.lblSemester.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblSemester.Name = "lblSemester"
        Me.lblSemester.Size = New System.Drawing.Size(51, 13)
        Me.lblSemester.TabIndex = 5
        Me.lblSemester.Text = "Semester"
        '
        'lblHours
        '
        Me.lblHours.AutoSize = True
        Me.lblHours.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHours.Location = New System.Drawing.Point(8, 138)
        Me.lblHours.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblHours.Name = "lblHours"
        Me.lblHours.Size = New System.Drawing.Size(34, 13)
        Me.lblHours.TabIndex = 6
        Me.lblHours.Text = "Hours"
        '
        'btnReassign
        '
        Me.btnReassign.Location = New System.Drawing.Point(45, 215)
        Me.btnReassign.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.btnReassign.Name = "btnReassign"
        Me.btnReassign.Size = New System.Drawing.Size(60, 22)
        Me.btnReassign.TabIndex = 7
        Me.btnReassign.Text = "Reassign"
        Me.btnReassign.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(113, 215)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(60, 22)
        Me.btnCancel.TabIndex = 8
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'lblHours1
        '
        Me.lblHours1.AutoSize = True
        Me.lblHours1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHours1.Location = New System.Drawing.Point(10, 154)
        Me.lblHours1.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblHours1.Name = "lblHours1"
        Me.lblHours1.Size = New System.Drawing.Size(34, 13)
        Me.lblHours1.TabIndex = 9
        Me.lblHours1.Text = "Hours"
        '
        'ViewGASupervisorsTableAdapter
        '
        Me.ViewGASupervisorsTableAdapter.ClearBeforeFill = True
        '
        'GAReassignment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(188, 249)
        Me.Controls.Add(Me.lblHours1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnReassign)
        Me.Controls.Add(Me.lblHours)
        Me.Controls.Add(Me.lblSemester)
        Me.Controls.Add(Me.lblStudent)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.numHours)
        Me.Controls.Add(Me.cbSupervisor)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.Name = "GAReassignment"
        Me.Text = "Reassign GA"
        CType(Me.ViewGASupervisorsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PROJECTS1747DataSet7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numHours, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbSupervisor As ComboBox
    Friend WithEvents numHours As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblStudent As Label
    Friend WithEvents lblSemester As Label
    Friend WithEvents lblHours As Label

    Friend WithEvents btnReassign As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents lblHours1 As Label
    Friend WithEvents PROJECTS1747DataSet7 As PROJECTS1747DataSet7
    Friend WithEvents ViewGASupervisorsBindingSource As BindingSource
    Friend WithEvents ViewGASupervisorsTableAdapter As PROJECTS1747DataSet7TableAdapters.viewGASupervisorsTableAdapter
End Class
