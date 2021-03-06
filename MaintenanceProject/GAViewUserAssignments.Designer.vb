﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GAViewUserAssignments
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GAViewUserAssignments))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.SupervisorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StudentDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SemesterDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HoursDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AssignmentIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StudentIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SupervisorIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ViewGAAssignmentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PROJECTS1747DataSet6 = New MaintenanceProject.PROJECTS1747DataSet6()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ViewGAAssignmentsTableAdapter = New MaintenanceProject.PROJECTS1747DataSet6TableAdapters.viewGAAssignmentsTableAdapter()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnReassign = New System.Windows.Forms.Button()
        Me.tbSemester = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ViewGAAssignmentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PROJECTS1747DataSet6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SupervisorDataGridViewTextBoxColumn, Me.StudentDataGridViewTextBoxColumn, Me.SemesterDataGridViewTextBoxColumn, Me.HoursDataGridViewTextBoxColumn, Me.AssignmentIDDataGridViewTextBoxColumn, Me.StudentIDDataGridViewTextBoxColumn, Me.SupervisorIDDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ViewGAAssignmentsBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(4, 95)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 40
        Me.DataGridView1.Size = New System.Drawing.Size(548, 261)
        Me.DataGridView1.TabIndex = 1
        '
        'SupervisorDataGridViewTextBoxColumn
        '
        Me.SupervisorDataGridViewTextBoxColumn.DataPropertyName = "Supervisor"
        Me.SupervisorDataGridViewTextBoxColumn.HeaderText = "Supervisor"
        Me.SupervisorDataGridViewTextBoxColumn.Name = "SupervisorDataGridViewTextBoxColumn"
        Me.SupervisorDataGridViewTextBoxColumn.ReadOnly = True
        Me.SupervisorDataGridViewTextBoxColumn.Width = 82
        '
        'StudentDataGridViewTextBoxColumn
        '
        Me.StudentDataGridViewTextBoxColumn.DataPropertyName = "Student"
        Me.StudentDataGridViewTextBoxColumn.HeaderText = "Student"
        Me.StudentDataGridViewTextBoxColumn.Name = "StudentDataGridViewTextBoxColumn"
        Me.StudentDataGridViewTextBoxColumn.ReadOnly = True
        Me.StudentDataGridViewTextBoxColumn.Width = 69
        '
        'SemesterDataGridViewTextBoxColumn
        '
        Me.SemesterDataGridViewTextBoxColumn.DataPropertyName = "Semester"
        Me.SemesterDataGridViewTextBoxColumn.HeaderText = "Semester"
        Me.SemesterDataGridViewTextBoxColumn.Name = "SemesterDataGridViewTextBoxColumn"
        Me.SemesterDataGridViewTextBoxColumn.Width = 76
        '
        'HoursDataGridViewTextBoxColumn
        '
        Me.HoursDataGridViewTextBoxColumn.DataPropertyName = "Hours"
        Me.HoursDataGridViewTextBoxColumn.HeaderText = "Hours"
        Me.HoursDataGridViewTextBoxColumn.Name = "HoursDataGridViewTextBoxColumn"
        Me.HoursDataGridViewTextBoxColumn.Width = 60
        '
        'AssignmentIDDataGridViewTextBoxColumn
        '
        Me.AssignmentIDDataGridViewTextBoxColumn.DataPropertyName = "Assignment_ID"
        Me.AssignmentIDDataGridViewTextBoxColumn.HeaderText = "Assignment_ID"
        Me.AssignmentIDDataGridViewTextBoxColumn.Name = "AssignmentIDDataGridViewTextBoxColumn"
        Me.AssignmentIDDataGridViewTextBoxColumn.Width = 103
        '
        'StudentIDDataGridViewTextBoxColumn
        '
        Me.StudentIDDataGridViewTextBoxColumn.DataPropertyName = "Student_ID"
        Me.StudentIDDataGridViewTextBoxColumn.HeaderText = "Student_ID"
        Me.StudentIDDataGridViewTextBoxColumn.Name = "StudentIDDataGridViewTextBoxColumn"
        Me.StudentIDDataGridViewTextBoxColumn.Width = 86
        '
        'SupervisorIDDataGridViewTextBoxColumn
        '
        Me.SupervisorIDDataGridViewTextBoxColumn.DataPropertyName = "Supervisor_ID"
        Me.SupervisorIDDataGridViewTextBoxColumn.HeaderText = "Supervisor_ID"
        Me.SupervisorIDDataGridViewTextBoxColumn.Name = "SupervisorIDDataGridViewTextBoxColumn"
        Me.SupervisorIDDataGridViewTextBoxColumn.Width = 99
        '
        'ViewGAAssignmentsBindingSource
        '
        Me.ViewGAAssignmentsBindingSource.DataMember = "viewGAAssignments"
        Me.ViewGAAssignmentsBindingSource.DataSource = Me.PROJECTS1747DataSet6
        '
        'PROJECTS1747DataSet6
        '
        Me.PROJECTS1747DataSet6.DataSetName = "PROJECTS1747DataSet6"
        Me.PROJECTS1747DataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(2, 73)
        Me.Label1.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Graduate Assistant Assignments"
        '
        'ViewGAAssignmentsTableAdapter
        '
        Me.ViewGAAssignmentsTableAdapter.ClearBeforeFill = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(482, 369)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(70, 19)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnReassign
        '
        Me.btnReassign.Location = New System.Drawing.Point(404, 369)
        Me.btnReassign.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.btnReassign.Name = "btnReassign"
        Me.btnReassign.Size = New System.Drawing.Size(70, 19)
        Me.btnReassign.TabIndex = 4
        Me.btnReassign.Text = "Reassign"
        Me.btnReassign.UseVisualStyleBackColor = True
        '
        'tbSemester
        '
        Me.tbSemester.Location = New System.Drawing.Point(447, 73)
        Me.tbSemester.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.tbSemester.Name = "tbSemester"
        Me.tbSemester.Size = New System.Drawing.Size(107, 20)
        Me.tbSemester.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(394, 75)
        Me.Label2.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Semester"
        '
        'GAViewUserAssignments
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(560, 433)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbSemester)
        Me.Controls.Add(Me.btnReassign)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.Name = "GAViewUserAssignments"
        Me.Text = "GA Assignments"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ViewGAAssignmentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PROJECTS1747DataSet6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents PROJECTS1747DataSet6 As PROJECTS1747DataSet6
    Friend WithEvents ViewGAAssignmentsBindingSource As BindingSource
    Friend WithEvents ViewGAAssignmentsTableAdapter As PROJECTS1747DataSet6TableAdapters.viewGAAssignmentsTableAdapter
    Friend WithEvents SupervisorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StudentDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SemesterDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HoursDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AssignmentIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StudentIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SupervisorIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btnClose As Button
    Friend WithEvents btnReassign As Button
    Friend WithEvents tbSemester As TextBox
    Friend WithEvents Label2 As Label
End Class
