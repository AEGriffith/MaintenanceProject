<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Advising
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MISToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MISToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PMISToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnView = New System.Windows.Forms.Button()
        Me.PROJECTS1747DataSet = New MaintenanceProject.PROJECTS1747DataSet()
        Me.ViewStudentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ViewStudentTableAdapter = New MaintenanceProject.PROJECTS1747DataSetTableAdapters.viewStudentTableAdapter()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PROJECTS1747DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ViewStudentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.DataGridView1.DataSource = Me.ViewStudentBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(32, 291)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 40
        Me.DataGridView1.Size = New System.Drawing.Size(1441, 544)
        Me.DataGridView1.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(40, 40)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ViewToolStripMenuItem, Me.ViewToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(16, 5, 0, 5)
        Me.MenuStrip1.Size = New System.Drawing.Size(1507, 55)
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
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(12, 45)
        '
        'ViewToolStripMenuItem1
        '
        Me.ViewToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MISToolStripMenuItem})
        Me.ViewToolStripMenuItem1.Name = "ViewToolStripMenuItem1"
        Me.ViewToolStripMenuItem1.Size = New System.Drawing.Size(94, 45)
        Me.ViewToolStripMenuItem1.Text = "View"
        '
        'MISToolStripMenuItem
        '
        Me.MISToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MISToolStripMenuItem1, Me.PMISToolStripMenuItem1})
        Me.MISToolStripMenuItem.Name = "MISToolStripMenuItem"
        Me.MISToolStripMenuItem.Size = New System.Drawing.Size(316, 46)
        Me.MISToolStripMenuItem.Text = "Requirements"
        '
        'MISToolStripMenuItem1
        '
        Me.MISToolStripMenuItem1.Name = "MISToolStripMenuItem1"
        Me.MISToolStripMenuItem1.Size = New System.Drawing.Size(201, 46)
        Me.MISToolStripMenuItem1.Text = "MIS"
        '
        'PMISToolStripMenuItem1
        '
        Me.PMISToolStripMenuItem1.Name = "PMISToolStripMenuItem1"
        Me.PMISToolStripMenuItem1.Size = New System.Drawing.Size(201, 46)
        Me.PMISToolStripMenuItem1.Text = "PMIS"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 32)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Students"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(1313, 867)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(160, 45)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "&Close"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnView
        '
        Me.btnView.Location = New System.Drawing.Point(1137, 867)
        Me.btnView.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(160, 45)
        Me.btnView.TabIndex = 4
        Me.btnView.Text = "&View"
        Me.btnView.UseVisualStyleBackColor = True
        '
        'PROJECTS1747DataSet
        '
        Me.PROJECTS1747DataSet.DataSetName = "PROJECTS1747DataSet"
        Me.PROJECTS1747DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ViewStudentBindingSource
        '
        Me.ViewStudentBindingSource.DataMember = "viewStudent"
        Me.ViewStudentBindingSource.DataSource = Me.PROJECTS1747DataSet
        '
        'ViewStudentTableAdapter
        '
        Me.ViewStudentTableAdapter.ClearBeforeFill = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 96
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "First Name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "First Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 206
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Last Name"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Last Name"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 205
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Program"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Program"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 177
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Concentration"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Concentration"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 247
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "GPA"
        Me.DataGridViewTextBoxColumn6.HeaderText = "GPA"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 129
        '
        'Advising
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1507, 975)
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Advising"
        Me.Text = "Advising"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PROJECTS1747DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ViewStudentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnView As Button

    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProgramDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ConcentrationDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GPADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ViewToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents MISToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MISToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents PMISToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents PROJECTS1747DataSet As PROJECTS1747DataSet
    Friend WithEvents ViewStudentBindingSource As BindingSource
    Friend WithEvents ViewStudentTableAdapter As PROJECTS1747DataSetTableAdapters.viewStudentTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
End Class
