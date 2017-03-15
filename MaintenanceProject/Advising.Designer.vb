<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Advising
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.StudentViewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PROJECTS1747DataSet4 = New MaintenanceProject.PROJECTS1747DataSet4()
        Me.Student_ViewTableAdapter = New MaintenanceProject.PROJECTS1747DataSet4TableAdapters.Student_ViewTableAdapter()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnView = New System.Windows.Forms.Button()
        Me.PROJECTS1747DataSet6 = New MaintenanceProject.PROJECTS1747DataSet6()
        Me.ViewStudentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ViewStudentTableAdapter = New MaintenanceProject.PROJECTS1747DataSet6TableAdapters.viewStudentTableAdapter()
        Me.PROJECTS1747DataSet7 = New MaintenanceProject.PROJECTS1747DataSet7()
        Me.PROJECTS1747DataSet7BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ViewStudentBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ViewStudentTableAdapter1 = New MaintenanceProject.PROJECTS1747DataSet7TableAdapters.viewStudentTableAdapter()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProgramDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ConcentrationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GPADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentViewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PROJECTS1747DataSet4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PROJECTS1747DataSet6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ViewStudentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PROJECTS1747DataSet7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PROJECTS1747DataSet7BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ViewStudentBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.FirstNameDataGridViewTextBoxColumn, Me.LastNameDataGridViewTextBoxColumn, Me.ProgramDataGridViewTextBoxColumn, Me.ConcentrationDataGridViewTextBoxColumn, Me.GPADataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ViewStudentBindingSource1
        Me.DataGridView1.Location = New System.Drawing.Point(12, 122)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 40
        Me.DataGridView1.Size = New System.Drawing.Size(1649, 606)
        Me.DataGridView1.TabIndex = 0
        '
        'StudentViewBindingSource
        '
        Me.StudentViewBindingSource.DataMember = "Student_View"
        Me.StudentViewBindingSource.DataSource = Me.PROJECTS1747DataSet4
        '
        'PROJECTS1747DataSet4
        '
        Me.PROJECTS1747DataSet4.DataSetName = "PROJECTS1747DataSet4"
        Me.PROJECTS1747DataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Student_ViewTableAdapter
        '
        Me.Student_ViewTableAdapter.ClearBeforeFill = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(40, 40)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ViewToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1673, 49)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(75, 45)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(94, 45)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 32)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Students"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(1488, 760)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(161, 45)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnView
        '
        Me.btnView.Location = New System.Drawing.Point(1309, 760)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(161, 45)
        Me.btnView.TabIndex = 4
        Me.btnView.Text = "View"
        Me.btnView.UseVisualStyleBackColor = True
        '
        'PROJECTS1747DataSet6
        '
        Me.PROJECTS1747DataSet6.DataSetName = "PROJECTS1747DataSet6"
        Me.PROJECTS1747DataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ViewStudentBindingSource
        '
        Me.ViewStudentBindingSource.DataMember = "viewStudent"
        Me.ViewStudentBindingSource.DataSource = Me.PROJECTS1747DataSet6
        '
        'ViewStudentTableAdapter
        '
        Me.ViewStudentTableAdapter.ClearBeforeFill = True
        '
        'PROJECTS1747DataSet7
        '
        Me.PROJECTS1747DataSet7.DataSetName = "PROJECTS1747DataSet7"
        Me.PROJECTS1747DataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PROJECTS1747DataSet7BindingSource
        '
        Me.PROJECTS1747DataSet7BindingSource.DataSource = Me.PROJECTS1747DataSet7
        Me.PROJECTS1747DataSet7BindingSource.Position = 0
        '
        'ViewStudentBindingSource1
        '
        Me.ViewStudentBindingSource1.DataMember = "viewStudent"
        Me.ViewStudentBindingSource1.DataSource = Me.PROJECTS1747DataSet7BindingSource
        '
        'ViewStudentTableAdapter1
        '
        Me.ViewStudentTableAdapter1.ClearBeforeFill = True
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FirstNameDataGridViewTextBoxColumn
        '
        Me.FirstNameDataGridViewTextBoxColumn.DataPropertyName = "First Name"
        Me.FirstNameDataGridViewTextBoxColumn.HeaderText = "First Name"
        Me.FirstNameDataGridViewTextBoxColumn.Name = "FirstNameDataGridViewTextBoxColumn"
        Me.FirstNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LastNameDataGridViewTextBoxColumn
        '
        Me.LastNameDataGridViewTextBoxColumn.DataPropertyName = "Last Name"
        Me.LastNameDataGridViewTextBoxColumn.HeaderText = "Last Name"
        Me.LastNameDataGridViewTextBoxColumn.Name = "LastNameDataGridViewTextBoxColumn"
        Me.LastNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ProgramDataGridViewTextBoxColumn
        '
        Me.ProgramDataGridViewTextBoxColumn.DataPropertyName = "Program"
        Me.ProgramDataGridViewTextBoxColumn.HeaderText = "Program"
        Me.ProgramDataGridViewTextBoxColumn.Name = "ProgramDataGridViewTextBoxColumn"
        Me.ProgramDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ConcentrationDataGridViewTextBoxColumn
        '
        Me.ConcentrationDataGridViewTextBoxColumn.DataPropertyName = "Concentration"
        Me.ConcentrationDataGridViewTextBoxColumn.HeaderText = "Concentration"
        Me.ConcentrationDataGridViewTextBoxColumn.Name = "ConcentrationDataGridViewTextBoxColumn"
        Me.ConcentrationDataGridViewTextBoxColumn.ReadOnly = True
        '
        'GPADataGridViewTextBoxColumn
        '
        Me.GPADataGridViewTextBoxColumn.DataPropertyName = "GPA"
        Me.GPADataGridViewTextBoxColumn.HeaderText = "GPA"
        Me.GPADataGridViewTextBoxColumn.Name = "GPADataGridViewTextBoxColumn"
        Me.GPADataGridViewTextBoxColumn.ReadOnly = True
        '
        'Advising
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1673, 833)
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Advising"
        Me.Text = "Advising"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentViewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PROJECTS1747DataSet4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PROJECTS1747DataSet6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ViewStudentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PROJECTS1747DataSet7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PROJECTS1747DataSet7BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ViewStudentBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents PROJECTS1747DataSet4 As PROJECTS1747DataSet4
    Friend WithEvents StudentViewBindingSource As BindingSource
    Friend WithEvents Student_ViewTableAdapter As PROJECTS1747DataSet4TableAdapters.Student_ViewTableAdapter
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnView As Button
    Friend WithEvents PROJECTS1747DataSet6 As PROJECTS1747DataSet6
    Friend WithEvents ViewStudentBindingSource As BindingSource
    Friend WithEvents ViewStudentTableAdapter As PROJECTS1747DataSet6TableAdapters.viewStudentTableAdapter
    Friend WithEvents PROJECTS1747DataSet7BindingSource As BindingSource
    Friend WithEvents PROJECTS1747DataSet7 As PROJECTS1747DataSet7
    Friend WithEvents ViewStudentBindingSource1 As BindingSource
    Friend WithEvents ViewStudentTableAdapter1 As PROJECTS1747DataSet7TableAdapters.viewStudentTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProgramDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ConcentrationDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GPADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
