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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Advising))
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbConcentration = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ViewStudentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PROJECTS1747DataSet1 = New MaintenanceProject.PROJECTS1747DataSet1()
        Me.ViewStudentTableAdapter = New MaintenanceProject.PROJECTS1747DataSet1TableAdapters.viewStudentTableAdapter()
        Me.tbFName = New System.Windows.Forms.TextBox()
        Me.tbLName = New System.Windows.Forms.TextBox()
        Me.cbProgram = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.ViewStudentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PROJECTS1747DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(40, 40)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ViewToolStripMenuItem, Me.ViewToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(478, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(12, 20)
        '
        'ViewToolStripMenuItem1
        '
        Me.ViewToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MISToolStripMenuItem})
        Me.ViewToolStripMenuItem1.Name = "ViewToolStripMenuItem1"
        Me.ViewToolStripMenuItem1.Size = New System.Drawing.Size(44, 20)
        Me.ViewToolStripMenuItem1.Text = "View"
        '
        'MISToolStripMenuItem
        '
        Me.MISToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MISToolStripMenuItem1, Me.PMISToolStripMenuItem1})
        Me.MISToolStripMenuItem.Name = "MISToolStripMenuItem"
        Me.MISToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.MISToolStripMenuItem.Text = "Requirements"
        '
        'MISToolStripMenuItem1
        '
        Me.MISToolStripMenuItem1.Name = "MISToolStripMenuItem1"
        Me.MISToolStripMenuItem1.Size = New System.Drawing.Size(101, 22)
        Me.MISToolStripMenuItem1.Text = "MIS"
        '
        'PMISToolStripMenuItem1
        '
        Me.PMISToolStripMenuItem1.Name = "PMISToolStripMenuItem1"
        Me.PMISToolStripMenuItem1.Size = New System.Drawing.Size(101, 22)
        Me.PMISToolStripMenuItem1.Text = "PMIS"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 31)
        Me.Label1.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Students"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(567, 386)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(60, 19)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "&Close"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnView
        '
        Me.btnView.Location = New System.Drawing.Point(501, 386)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(60, 19)
        Me.btnView.TabIndex = 4
        Me.btnView.Text = "&View"
        Me.btnView.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(202, 54)
        Me.Label3.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Program"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(106, 55)
        Me.Label2.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Last Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 55)
        Me.Label4.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "First Name"
        '
        'cbConcentration
        '
        Me.cbConcentration.FormattingEnabled = True
        Me.cbConcentration.Items.AddRange(New Object() {"Enterprise Resource Planning", "Enterprise Systems", "Information Technology", "Software Engineering"})
        Me.cbConcentration.Location = New System.Drawing.Point(283, 70)
        Me.cbConcentration.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.cbConcentration.Name = "cbConcentration"
        Me.cbConcentration.Size = New System.Drawing.Size(96, 21)
        Me.cbConcentration.TabIndex = 23
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(281, 54)
        Me.Label5.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 13)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Concentration"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(392, 62)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(66, 19)
        Me.Button1.TabIndex = 25
        Me.Button1.Text = "Clear Filter"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ViewStudentBindingSource
        '
        Me.ViewStudentBindingSource.DataMember = "viewStudent"
        Me.ViewStudentBindingSource.DataSource = Me.PROJECTS1747DataSet1
        '
        'PROJECTS1747DataSet1
        '
        Me.PROJECTS1747DataSet1.DataSetName = "PROJECTS1747DataSet1"
        Me.PROJECTS1747DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ViewStudentTableAdapter
        '
        Me.ViewStudentTableAdapter.ClearBeforeFill = True
        '
        'tbFName
        '
        Me.tbFName.Location = New System.Drawing.Point(12, 70)
        Me.tbFName.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.tbFName.Name = "tbFName"
        Me.tbFName.Size = New System.Drawing.Size(87, 20)
        Me.tbFName.TabIndex = 27
        '
        'tbLName
        '
        Me.tbLName.Location = New System.Drawing.Point(108, 69)
        Me.tbLName.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.tbLName.Name = "tbLName"
        Me.tbLName.Size = New System.Drawing.Size(88, 20)
        Me.tbLName.TabIndex = 28
        '
        'cbProgram
        '
        Me.cbProgram.FormattingEnabled = True
        Me.cbProgram.Items.AddRange(New Object() {"MIS", "PMIS"})
        Me.cbProgram.Location = New System.Drawing.Point(204, 70)
        Me.cbProgram.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.cbProgram.Name = "cbProgram"
        Me.cbProgram.Size = New System.Drawing.Size(73, 21)
        Me.cbProgram.TabIndex = 29
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.DataGridView1.DataSource = Me.ViewStudentBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(11, 101)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 40
        Me.DataGridView1.Size = New System.Drawing.Size(637, 280)
        Me.DataGridView1.TabIndex = 30
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 43
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "First Name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "First Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 82
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Last Name"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Last Name"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 83
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Program"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Program"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 71
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Concentration"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Concentration"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 98
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "GPA"
        Me.DataGridViewTextBoxColumn6.HeaderText = "GPA"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 54
        '
        'Advising
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(478, 418)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.cbProgram)
        Me.Controls.Add(Me.tbLName)
        Me.Controls.Add(Me.tbFName)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cbConcentration)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.Name = "Advising"
        Me.Text = "Advising"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.ViewStudentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PROJECTS1747DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

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
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cbConcentration As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents PROJECTS1747DataSet1 As PROJECTS1747DataSet1
    Friend WithEvents ViewStudentBindingSource As BindingSource
    Friend WithEvents ViewStudentTableAdapter As PROJECTS1747DataSet1TableAdapters.viewStudentTableAdapter
    Friend WithEvents tbFName As TextBox
    Friend WithEvents tbLName As TextBox
    Friend WithEvents cbProgram As ComboBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
End Class
