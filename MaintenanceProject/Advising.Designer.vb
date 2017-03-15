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
        Me.LastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GPADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProgramDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ConcentrationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StudentViewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PROJECTS1747DataSet4 = New MaintenanceProject.PROJECTS1747DataSet4()
        Me.Student_ViewTableAdapter = New MaintenanceProject.PROJECTS1747DataSet4TableAdapters.Student_ViewTableAdapter()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RequirementsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MISToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PMISToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnView = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentViewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PROJECTS1747DataSet4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.LastNameDataGridViewTextBoxColumn, Me.FirstNameDataGridViewTextBoxColumn, Me.GPADataGridViewTextBoxColumn, Me.ProgramDataGridViewTextBoxColumn, Me.ConcentrationDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.StudentViewBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(4, 51)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(1)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 40
        Me.DataGridView1.Size = New System.Drawing.Size(334, 198)
        Me.DataGridView1.TabIndex = 0
        '
        'LastNameDataGridViewTextBoxColumn
        '
        Me.LastNameDataGridViewTextBoxColumn.DataPropertyName = "Last Name"
        Me.LastNameDataGridViewTextBoxColumn.HeaderText = "Last Name"
        Me.LastNameDataGridViewTextBoxColumn.Name = "LastNameDataGridViewTextBoxColumn"
        '
        'FirstNameDataGridViewTextBoxColumn
        '
        Me.FirstNameDataGridViewTextBoxColumn.DataPropertyName = "First Name"
        Me.FirstNameDataGridViewTextBoxColumn.HeaderText = "First Name"
        Me.FirstNameDataGridViewTextBoxColumn.Name = "FirstNameDataGridViewTextBoxColumn"
        '
        'GPADataGridViewTextBoxColumn
        '
        Me.GPADataGridViewTextBoxColumn.DataPropertyName = "GPA"
        Me.GPADataGridViewTextBoxColumn.HeaderText = "GPA"
        Me.GPADataGridViewTextBoxColumn.Name = "GPADataGridViewTextBoxColumn"
        '
        'ProgramDataGridViewTextBoxColumn
        '
        Me.ProgramDataGridViewTextBoxColumn.DataPropertyName = "Program"
        Me.ProgramDataGridViewTextBoxColumn.HeaderText = "Program"
        Me.ProgramDataGridViewTextBoxColumn.Name = "ProgramDataGridViewTextBoxColumn"
        '
        'ConcentrationDataGridViewTextBoxColumn
        '
        Me.ConcentrationDataGridViewTextBoxColumn.DataPropertyName = "Concentration"
        Me.ConcentrationDataGridViewTextBoxColumn.HeaderText = "Concentration"
        Me.ConcentrationDataGridViewTextBoxColumn.Name = "ConcentrationDataGridViewTextBoxColumn"
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
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(2, 1, 0, 1)
        Me.MenuStrip1.Size = New System.Drawing.Size(343, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 22)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RequirementsToolStripMenuItem})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(44, 22)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'RequirementsToolStripMenuItem
        '
        Me.RequirementsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MISToolStripMenuItem, Me.PMISToolStripMenuItem})
        Me.RequirementsToolStripMenuItem.Name = "RequirementsToolStripMenuItem"
        Me.RequirementsToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.RequirementsToolStripMenuItem.Text = "Requirements"
        '
        'MISToolStripMenuItem
        '
        Me.MISToolStripMenuItem.Name = "MISToolStripMenuItem"
        Me.MISToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.MISToolStripMenuItem.Text = "MIS"
        '
        'PMISToolStripMenuItem
        '
        Me.PMISToolStripMenuItem.Name = "PMISToolStripMenuItem"
        Me.PMISToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PMISToolStripMenuItem.Text = "PMIS"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 33)
        Me.Label1.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Students"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(278, 265)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(1)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(60, 19)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnView
        '
        Me.btnView.Location = New System.Drawing.Point(211, 265)
        Me.btnView.Margin = New System.Windows.Forms.Padding(1)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(60, 19)
        Me.btnView.TabIndex = 4
        Me.btnView.Text = "View"
        Me.btnView.UseVisualStyleBackColor = True
        '
        'Advising
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(343, 306)
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(1)
        Me.Name = "Advising"
        Me.Text = "Advising"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentViewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PROJECTS1747DataSet4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents PROJECTS1747DataSet4 As PROJECTS1747DataSet4
    Friend WithEvents StudentViewBindingSource As BindingSource
    Friend WithEvents Student_ViewTableAdapter As PROJECTS1747DataSet4TableAdapters.Student_ViewTableAdapter
    Friend WithEvents LastNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GPADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProgramDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ConcentrationDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnView As Button
    Friend WithEvents RequirementsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MISToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PMISToolStripMenuItem As ToolStripMenuItem
End Class
