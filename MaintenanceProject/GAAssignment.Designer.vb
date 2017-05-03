<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GAAssignment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GAAssignment))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbSemester = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.numHours = New System.Windows.Forms.NumericUpDown()
        Me.dgvRequest = New System.Windows.Forms.DataGridView()
        Me.FormDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReasonsForRequestDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumberOfGAsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WeeklyHoursDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ResearchDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProgrammingDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SpreadsheetsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatabaseDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatisticalPackagesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WritingDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EditingDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EnglishSpeakingDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OtherCommunicationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CommentsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ViewGARequestBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PROJECTS1747DataSet15 = New MaintenanceProject.PROJECTS1747DataSet15()
        Me.dgvGA = New System.Windows.Forms.DataGridView()
        Me.FirstNameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastNameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ResearchDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProgrammingDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SpreadsheetDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatabaseDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatisticalPackagesDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WritingDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EditingDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EnglishSpeakingDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OtherDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StudentIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApplicationIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ViewAvailableGAsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnAssignment = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbHours = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbSupervisorHours = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tbGAs = New System.Windows.Forms.TextBox()
        Me.dgvAssigned = New System.Windows.Forms.DataGridView()
        Me.ViewGARequestTableAdapter = New MaintenanceProject.PROJECTS1747DataSet15TableAdapters.viewGARequestTableAdapter()
        Me.ViewAvailableGAsTableAdapter = New MaintenanceProject.PROJECTS1747DataSet15TableAdapters.viewAvailableGAsTableAdapter()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FilesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GAAssignmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.numHours, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvRequest, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ViewGARequestBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PROJECTS1747DataSet15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvGA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ViewAvailableGAsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvAssigned, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 33)
        Me.Label1.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Assign GA"
        '
        'cbSemester
        '
        Me.cbSemester.FormattingEnabled = True
        Me.cbSemester.Items.AddRange(New Object() {"Fa2017", "Sp2018"})
        Me.cbSemester.Location = New System.Drawing.Point(631, 299)
        Me.cbSemester.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.cbSemester.Name = "cbSemester"
        Me.cbSemester.Size = New System.Drawing.Size(85, 21)
        Me.cbSemester.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(578, 300)
        Me.Label4.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Semester"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(578, 324)
        Me.Label5.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Weekly Hours"
        '
        'numHours
        '
        Me.numHours.Increment = New Decimal(New Integer() {10, 0, 0, 0})
        Me.numHours.Location = New System.Drawing.Point(662, 323)
        Me.numHours.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.numHours.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.numHours.Minimum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.numHours.Name = "numHours"
        Me.numHours.Size = New System.Drawing.Size(51, 20)
        Me.numHours.TabIndex = 8
        Me.numHours.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'dgvRequest
        '
        Me.dgvRequest.AllowUserToAddRows = False
        Me.dgvRequest.AllowUserToDeleteRows = False
        Me.dgvRequest.AutoGenerateColumns = False
        Me.dgvRequest.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvRequest.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvRequest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRequest.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FormDataGridViewTextBoxColumn, Me.FirstNameDataGridViewTextBoxColumn, Me.LastNameDataGridViewTextBoxColumn, Me.ReasonsForRequestDataGridViewTextBoxColumn, Me.NumberOfGAsDataGridViewTextBoxColumn, Me.WeeklyHoursDataGridViewTextBoxColumn, Me.ResearchDataGridViewTextBoxColumn, Me.ProgrammingDataGridViewTextBoxColumn, Me.SpreadsheetsDataGridViewTextBoxColumn, Me.DatabaseDataGridViewTextBoxColumn, Me.StatisticalPackagesDataGridViewTextBoxColumn, Me.WritingDataGridViewTextBoxColumn, Me.EditingDataGridViewTextBoxColumn, Me.EnglishSpeakingDataGridViewTextBoxColumn, Me.OtherCommunicationDataGridViewTextBoxColumn, Me.CommentsDataGridViewTextBoxColumn})
        Me.dgvRequest.DataSource = Me.ViewGARequestBindingSource
        Me.dgvRequest.Location = New System.Drawing.Point(8, 81)
        Me.dgvRequest.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.dgvRequest.Name = "dgvRequest"
        Me.dgvRequest.ReadOnly = True
        Me.dgvRequest.RowTemplate.Height = 40
        Me.dgvRequest.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvRequest.Size = New System.Drawing.Size(533, 140)
        Me.dgvRequest.TabIndex = 9
        '
        'FormDataGridViewTextBoxColumn
        '
        Me.FormDataGridViewTextBoxColumn.DataPropertyName = "Form"
        Me.FormDataGridViewTextBoxColumn.HeaderText = "Form"
        Me.FormDataGridViewTextBoxColumn.Name = "FormDataGridViewTextBoxColumn"
        Me.FormDataGridViewTextBoxColumn.ReadOnly = True
        Me.FormDataGridViewTextBoxColumn.Width = 55
        '
        'FirstNameDataGridViewTextBoxColumn
        '
        Me.FirstNameDataGridViewTextBoxColumn.DataPropertyName = "First Name"
        Me.FirstNameDataGridViewTextBoxColumn.HeaderText = "First Name"
        Me.FirstNameDataGridViewTextBoxColumn.Name = "FirstNameDataGridViewTextBoxColumn"
        Me.FirstNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.FirstNameDataGridViewTextBoxColumn.Width = 76
        '
        'LastNameDataGridViewTextBoxColumn
        '
        Me.LastNameDataGridViewTextBoxColumn.DataPropertyName = "Last Name"
        Me.LastNameDataGridViewTextBoxColumn.HeaderText = "Last Name"
        Me.LastNameDataGridViewTextBoxColumn.Name = "LastNameDataGridViewTextBoxColumn"
        Me.LastNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.LastNameDataGridViewTextBoxColumn.Width = 77
        '
        'ReasonsForRequestDataGridViewTextBoxColumn
        '
        Me.ReasonsForRequestDataGridViewTextBoxColumn.DataPropertyName = "Reasons for Request"
        Me.ReasonsForRequestDataGridViewTextBoxColumn.HeaderText = "Reasons for Request"
        Me.ReasonsForRequestDataGridViewTextBoxColumn.Name = "ReasonsForRequestDataGridViewTextBoxColumn"
        Me.ReasonsForRequestDataGridViewTextBoxColumn.ReadOnly = True
        Me.ReasonsForRequestDataGridViewTextBoxColumn.Width = 121
        '
        'NumberOfGAsDataGridViewTextBoxColumn
        '
        Me.NumberOfGAsDataGridViewTextBoxColumn.DataPropertyName = "Number of GAs"
        Me.NumberOfGAsDataGridViewTextBoxColumn.HeaderText = "Number of GAs"
        Me.NumberOfGAsDataGridViewTextBoxColumn.Name = "NumberOfGAsDataGridViewTextBoxColumn"
        Me.NumberOfGAsDataGridViewTextBoxColumn.ReadOnly = True
        Me.NumberOfGAsDataGridViewTextBoxColumn.Width = 78
        '
        'WeeklyHoursDataGridViewTextBoxColumn
        '
        Me.WeeklyHoursDataGridViewTextBoxColumn.DataPropertyName = "Weekly Hours"
        Me.WeeklyHoursDataGridViewTextBoxColumn.HeaderText = "Weekly Hours"
        Me.WeeklyHoursDataGridViewTextBoxColumn.Name = "WeeklyHoursDataGridViewTextBoxColumn"
        Me.WeeklyHoursDataGridViewTextBoxColumn.ReadOnly = True
        Me.WeeklyHoursDataGridViewTextBoxColumn.Width = 91
        '
        'ResearchDataGridViewTextBoxColumn
        '
        Me.ResearchDataGridViewTextBoxColumn.DataPropertyName = "Research"
        Me.ResearchDataGridViewTextBoxColumn.HeaderText = "Research"
        Me.ResearchDataGridViewTextBoxColumn.Name = "ResearchDataGridViewTextBoxColumn"
        Me.ResearchDataGridViewTextBoxColumn.ReadOnly = True
        Me.ResearchDataGridViewTextBoxColumn.Width = 78
        '
        'ProgrammingDataGridViewTextBoxColumn
        '
        Me.ProgrammingDataGridViewTextBoxColumn.DataPropertyName = "Programming"
        Me.ProgrammingDataGridViewTextBoxColumn.HeaderText = "Programming"
        Me.ProgrammingDataGridViewTextBoxColumn.Name = "ProgrammingDataGridViewTextBoxColumn"
        Me.ProgrammingDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProgrammingDataGridViewTextBoxColumn.Width = 93
        '
        'SpreadsheetsDataGridViewTextBoxColumn
        '
        Me.SpreadsheetsDataGridViewTextBoxColumn.DataPropertyName = "Spreadsheets"
        Me.SpreadsheetsDataGridViewTextBoxColumn.HeaderText = "Spreadsheets"
        Me.SpreadsheetsDataGridViewTextBoxColumn.Name = "SpreadsheetsDataGridViewTextBoxColumn"
        Me.SpreadsheetsDataGridViewTextBoxColumn.ReadOnly = True
        Me.SpreadsheetsDataGridViewTextBoxColumn.Width = 97
        '
        'DatabaseDataGridViewTextBoxColumn
        '
        Me.DatabaseDataGridViewTextBoxColumn.DataPropertyName = "Database"
        Me.DatabaseDataGridViewTextBoxColumn.HeaderText = "Database"
        Me.DatabaseDataGridViewTextBoxColumn.Name = "DatabaseDataGridViewTextBoxColumn"
        Me.DatabaseDataGridViewTextBoxColumn.ReadOnly = True
        Me.DatabaseDataGridViewTextBoxColumn.Width = 78
        '
        'StatisticalPackagesDataGridViewTextBoxColumn
        '
        Me.StatisticalPackagesDataGridViewTextBoxColumn.DataPropertyName = "Statistical Packages"
        Me.StatisticalPackagesDataGridViewTextBoxColumn.HeaderText = "Statistical Packages"
        Me.StatisticalPackagesDataGridViewTextBoxColumn.Name = "StatisticalPackagesDataGridViewTextBoxColumn"
        Me.StatisticalPackagesDataGridViewTextBoxColumn.ReadOnly = True
        Me.StatisticalPackagesDataGridViewTextBoxColumn.Width = 117
        '
        'WritingDataGridViewTextBoxColumn
        '
        Me.WritingDataGridViewTextBoxColumn.DataPropertyName = "Writing"
        Me.WritingDataGridViewTextBoxColumn.HeaderText = "Writing"
        Me.WritingDataGridViewTextBoxColumn.Name = "WritingDataGridViewTextBoxColumn"
        Me.WritingDataGridViewTextBoxColumn.ReadOnly = True
        Me.WritingDataGridViewTextBoxColumn.Width = 65
        '
        'EditingDataGridViewTextBoxColumn
        '
        Me.EditingDataGridViewTextBoxColumn.DataPropertyName = "Editing"
        Me.EditingDataGridViewTextBoxColumn.HeaderText = "Editing"
        Me.EditingDataGridViewTextBoxColumn.Name = "EditingDataGridViewTextBoxColumn"
        Me.EditingDataGridViewTextBoxColumn.ReadOnly = True
        Me.EditingDataGridViewTextBoxColumn.Width = 64
        '
        'EnglishSpeakingDataGridViewTextBoxColumn
        '
        Me.EnglishSpeakingDataGridViewTextBoxColumn.DataPropertyName = "English Speaking"
        Me.EnglishSpeakingDataGridViewTextBoxColumn.HeaderText = "English Speaking"
        Me.EnglishSpeakingDataGridViewTextBoxColumn.Name = "EnglishSpeakingDataGridViewTextBoxColumn"
        Me.EnglishSpeakingDataGridViewTextBoxColumn.ReadOnly = True
        Me.EnglishSpeakingDataGridViewTextBoxColumn.Width = 105
        '
        'OtherCommunicationDataGridViewTextBoxColumn
        '
        Me.OtherCommunicationDataGridViewTextBoxColumn.DataPropertyName = "Other Communication"
        Me.OtherCommunicationDataGridViewTextBoxColumn.HeaderText = "Other Communication"
        Me.OtherCommunicationDataGridViewTextBoxColumn.Name = "OtherCommunicationDataGridViewTextBoxColumn"
        Me.OtherCommunicationDataGridViewTextBoxColumn.ReadOnly = True
        Me.OtherCommunicationDataGridViewTextBoxColumn.Width = 122
        '
        'CommentsDataGridViewTextBoxColumn
        '
        Me.CommentsDataGridViewTextBoxColumn.DataPropertyName = "Comments"
        Me.CommentsDataGridViewTextBoxColumn.HeaderText = "Comments"
        Me.CommentsDataGridViewTextBoxColumn.Name = "CommentsDataGridViewTextBoxColumn"
        Me.CommentsDataGridViewTextBoxColumn.ReadOnly = True
        Me.CommentsDataGridViewTextBoxColumn.Width = 81
        '
        'ViewGARequestBindingSource
        '
        Me.ViewGARequestBindingSource.DataMember = "viewGARequest"
        Me.ViewGARequestBindingSource.DataSource = Me.PROJECTS1747DataSet15
        '
        'PROJECTS1747DataSet15
        '
        Me.PROJECTS1747DataSet15.DataSetName = "PROJECTS1747DataSet15"
        Me.PROJECTS1747DataSet15.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dgvGA
        '
        Me.dgvGA.AllowUserToAddRows = False
        Me.dgvGA.AllowUserToDeleteRows = False
        Me.dgvGA.AllowUserToOrderColumns = True
        Me.dgvGA.AutoGenerateColumns = False
        Me.dgvGA.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvGA.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvGA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGA.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FirstNameDataGridViewTextBoxColumn1, Me.LastNameDataGridViewTextBoxColumn1, Me.ResearchDataGridViewTextBoxColumn1, Me.ProgrammingDataGridViewTextBoxColumn1, Me.SpreadsheetDataGridViewTextBoxColumn, Me.DatabaseDataGridViewTextBoxColumn1, Me.StatisticalPackagesDataGridViewTextBoxColumn1, Me.WritingDataGridViewTextBoxColumn1, Me.EditingDataGridViewTextBoxColumn1, Me.EnglishSpeakingDataGridViewTextBoxColumn1, Me.OtherDataGridViewTextBoxColumn, Me.StudentIDDataGridViewTextBoxColumn, Me.ApplicationIDDataGridViewTextBoxColumn})
        Me.dgvGA.DataSource = Me.ViewAvailableGAsBindingSource
        Me.dgvGA.Location = New System.Drawing.Point(8, 255)
        Me.dgvGA.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.dgvGA.Name = "dgvGA"
        Me.dgvGA.ReadOnly = True
        Me.dgvGA.RowTemplate.Height = 40
        Me.dgvGA.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvGA.Size = New System.Drawing.Size(531, 150)
        Me.dgvGA.TabIndex = 10
        '
        'FirstNameDataGridViewTextBoxColumn1
        '
        Me.FirstNameDataGridViewTextBoxColumn1.DataPropertyName = "First name"
        Me.FirstNameDataGridViewTextBoxColumn1.HeaderText = "First name"
        Me.FirstNameDataGridViewTextBoxColumn1.Name = "FirstNameDataGridViewTextBoxColumn1"
        Me.FirstNameDataGridViewTextBoxColumn1.ReadOnly = True
        Me.FirstNameDataGridViewTextBoxColumn1.Width = 74
        '
        'LastNameDataGridViewTextBoxColumn1
        '
        Me.LastNameDataGridViewTextBoxColumn1.DataPropertyName = "Last Name"
        Me.LastNameDataGridViewTextBoxColumn1.HeaderText = "Last Name"
        Me.LastNameDataGridViewTextBoxColumn1.Name = "LastNameDataGridViewTextBoxColumn1"
        Me.LastNameDataGridViewTextBoxColumn1.ReadOnly = True
        Me.LastNameDataGridViewTextBoxColumn1.Width = 77
        '
        'ResearchDataGridViewTextBoxColumn1
        '
        Me.ResearchDataGridViewTextBoxColumn1.DataPropertyName = "Research"
        Me.ResearchDataGridViewTextBoxColumn1.HeaderText = "Research"
        Me.ResearchDataGridViewTextBoxColumn1.Name = "ResearchDataGridViewTextBoxColumn1"
        Me.ResearchDataGridViewTextBoxColumn1.ReadOnly = True
        Me.ResearchDataGridViewTextBoxColumn1.Width = 78
        '
        'ProgrammingDataGridViewTextBoxColumn1
        '
        Me.ProgrammingDataGridViewTextBoxColumn1.DataPropertyName = "Programming"
        Me.ProgrammingDataGridViewTextBoxColumn1.HeaderText = "Programming"
        Me.ProgrammingDataGridViewTextBoxColumn1.Name = "ProgrammingDataGridViewTextBoxColumn1"
        Me.ProgrammingDataGridViewTextBoxColumn1.ReadOnly = True
        Me.ProgrammingDataGridViewTextBoxColumn1.Width = 93
        '
        'SpreadsheetDataGridViewTextBoxColumn
        '
        Me.SpreadsheetDataGridViewTextBoxColumn.DataPropertyName = "Spreadsheet"
        Me.SpreadsheetDataGridViewTextBoxColumn.HeaderText = "Spreadsheet"
        Me.SpreadsheetDataGridViewTextBoxColumn.Name = "SpreadsheetDataGridViewTextBoxColumn"
        Me.SpreadsheetDataGridViewTextBoxColumn.ReadOnly = True
        Me.SpreadsheetDataGridViewTextBoxColumn.Width = 92
        '
        'DatabaseDataGridViewTextBoxColumn1
        '
        Me.DatabaseDataGridViewTextBoxColumn1.DataPropertyName = "Database"
        Me.DatabaseDataGridViewTextBoxColumn1.HeaderText = "Database"
        Me.DatabaseDataGridViewTextBoxColumn1.Name = "DatabaseDataGridViewTextBoxColumn1"
        Me.DatabaseDataGridViewTextBoxColumn1.ReadOnly = True
        Me.DatabaseDataGridViewTextBoxColumn1.Width = 78
        '
        'StatisticalPackagesDataGridViewTextBoxColumn1
        '
        Me.StatisticalPackagesDataGridViewTextBoxColumn1.DataPropertyName = "Statistical Packages"
        Me.StatisticalPackagesDataGridViewTextBoxColumn1.HeaderText = "Statistical Packages"
        Me.StatisticalPackagesDataGridViewTextBoxColumn1.Name = "StatisticalPackagesDataGridViewTextBoxColumn1"
        Me.StatisticalPackagesDataGridViewTextBoxColumn1.ReadOnly = True
        Me.StatisticalPackagesDataGridViewTextBoxColumn1.Width = 117
        '
        'WritingDataGridViewTextBoxColumn1
        '
        Me.WritingDataGridViewTextBoxColumn1.DataPropertyName = "Writing"
        Me.WritingDataGridViewTextBoxColumn1.HeaderText = "Writing"
        Me.WritingDataGridViewTextBoxColumn1.Name = "WritingDataGridViewTextBoxColumn1"
        Me.WritingDataGridViewTextBoxColumn1.ReadOnly = True
        Me.WritingDataGridViewTextBoxColumn1.Width = 65
        '
        'EditingDataGridViewTextBoxColumn1
        '
        Me.EditingDataGridViewTextBoxColumn1.DataPropertyName = "Editing"
        Me.EditingDataGridViewTextBoxColumn1.HeaderText = "Editing"
        Me.EditingDataGridViewTextBoxColumn1.Name = "EditingDataGridViewTextBoxColumn1"
        Me.EditingDataGridViewTextBoxColumn1.ReadOnly = True
        Me.EditingDataGridViewTextBoxColumn1.Width = 64
        '
        'EnglishSpeakingDataGridViewTextBoxColumn1
        '
        Me.EnglishSpeakingDataGridViewTextBoxColumn1.DataPropertyName = "English Speaking"
        Me.EnglishSpeakingDataGridViewTextBoxColumn1.HeaderText = "English Speaking"
        Me.EnglishSpeakingDataGridViewTextBoxColumn1.Name = "EnglishSpeakingDataGridViewTextBoxColumn1"
        Me.EnglishSpeakingDataGridViewTextBoxColumn1.ReadOnly = True
        Me.EnglishSpeakingDataGridViewTextBoxColumn1.Width = 105
        '
        'OtherDataGridViewTextBoxColumn
        '
        Me.OtherDataGridViewTextBoxColumn.DataPropertyName = "Other"
        Me.OtherDataGridViewTextBoxColumn.HeaderText = "Other"
        Me.OtherDataGridViewTextBoxColumn.Name = "OtherDataGridViewTextBoxColumn"
        Me.OtherDataGridViewTextBoxColumn.ReadOnly = True
        Me.OtherDataGridViewTextBoxColumn.Width = 58
        '
        'StudentIDDataGridViewTextBoxColumn
        '
        Me.StudentIDDataGridViewTextBoxColumn.DataPropertyName = "Student_ID"
        Me.StudentIDDataGridViewTextBoxColumn.HeaderText = "Student_ID"
        Me.StudentIDDataGridViewTextBoxColumn.Name = "StudentIDDataGridViewTextBoxColumn"
        Me.StudentIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.StudentIDDataGridViewTextBoxColumn.Width = 86
        '
        'ApplicationIDDataGridViewTextBoxColumn
        '
        Me.ApplicationIDDataGridViewTextBoxColumn.DataPropertyName = "Application_ID"
        Me.ApplicationIDDataGridViewTextBoxColumn.HeaderText = "Application_ID"
        Me.ApplicationIDDataGridViewTextBoxColumn.Name = "ApplicationIDDataGridViewTextBoxColumn"
        Me.ApplicationIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.ApplicationIDDataGridViewTextBoxColumn.Width = 101
        '
        'ViewAvailableGAsBindingSource
        '
        Me.ViewAvailableGAsBindingSource.DataMember = "viewAvailableGAs"
        Me.ViewAvailableGAsBindingSource.DataSource = Me.PROJECTS1747DataSet15
        '
        'btnAssignment
        '
        Me.btnAssignment.Location = New System.Drawing.Point(609, 402)
        Me.btnAssignment.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.btnAssignment.Name = "btnAssignment"
        Me.btnAssignment.Size = New System.Drawing.Size(71, 25)
        Me.btnAssignment.TabIndex = 12
        Me.btnAssignment.Text = "Assign"
        Me.btnAssignment.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(682, 402)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(52, 25)
        Me.btnClose.TabIndex = 11
        Me.btnClose.Text = "Cancel"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 67)
        Me.Label2.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Select Request"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 240)
        Me.Label3.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Select GA"
        '
        'tbHours
        '
        Me.tbHours.Location = New System.Drawing.Point(501, 407)
        Me.tbHours.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.tbHours.Name = "tbHours"
        Me.tbHours.ReadOnly = True
        Me.tbHours.Size = New System.Drawing.Size(40, 20)
        Me.tbHours.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(378, 408)
        Me.Label6.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(123, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Current Hours Per Week"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(285, 226)
        Me.Label7.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(113, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Total Hours Per Week"
        '
        'tbSupervisorHours
        '
        Me.tbSupervisorHours.Location = New System.Drawing.Point(401, 225)
        Me.tbSupervisorHours.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.tbSupervisorHours.Name = "tbSupervisorHours"
        Me.tbSupervisorHours.ReadOnly = True
        Me.tbSupervisorHours.Size = New System.Drawing.Size(40, 20)
        Me.tbSupervisorHours.TabIndex = 17
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(446, 226)
        Me.Label8.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 13)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Total GAs"
        '
        'tbGAs
        '
        Me.tbGAs.Location = New System.Drawing.Point(501, 225)
        Me.tbGAs.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.tbGAs.Name = "tbGAs"
        Me.tbGAs.ReadOnly = True
        Me.tbGAs.Size = New System.Drawing.Size(40, 20)
        Me.tbGAs.TabIndex = 19
        '
        'dgvAssigned
        '
        Me.dgvAssigned.AllowUserToAddRows = False
        Me.dgvAssigned.AllowUserToDeleteRows = False
        Me.dgvAssigned.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvAssigned.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvAssigned.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAssigned.Location = New System.Drawing.Point(550, 81)
        Me.dgvAssigned.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.dgvAssigned.Name = "dgvAssigned"
        Me.dgvAssigned.ReadOnly = True
        Me.dgvAssigned.RowTemplate.Height = 40
        Me.dgvAssigned.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvAssigned.Size = New System.Drawing.Size(188, 140)
        Me.dgvAssigned.TabIndex = 21
        '
        'ViewGARequestTableAdapter
        '
        Me.ViewGARequestTableAdapter.ClearBeforeFill = True
        '
        'ViewAvailableGAsTableAdapter
        '
        Me.ViewAvailableGAsTableAdapter.ClearBeforeFill = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(40, 40)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FilesToolStripMenuItem, Me.EditToolStripMenuItem, Me.ViewToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(2, 2)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(2, 1, 0, 1)
        Me.MenuStrip1.Size = New System.Drawing.Size(714, 24)
        Me.MenuStrip1.TabIndex = 57
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FilesToolStripMenuItem
        '
        Me.FilesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CloseToolStripMenuItem})
        Me.FilesToolStripMenuItem.Name = "FilesToolStripMenuItem"
        Me.FilesToolStripMenuItem.Size = New System.Drawing.Size(42, 22)
        Me.FilesToolStripMenuItem.Text = "Files"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 22)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GAAssignmentToolStripMenuItem})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(44, 22)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'GAAssignmentToolStripMenuItem
        '
        Me.GAAssignmentToolStripMenuItem.Name = "GAAssignmentToolStripMenuItem"
        Me.GAAssignmentToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.GAAssignmentToolStripMenuItem.Text = "GA Assignment"
        '
        'GAAssignment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(718, 430)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.dgvAssigned)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.tbGAs)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.tbSupervisorHours)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tbHours)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnAssignment)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.dgvGA)
        Me.Controls.Add(Me.dgvRequest)
        Me.Controls.Add(Me.numHours)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbSemester)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.Name = "GAAssignment"
        Me.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Text = "Graduate Assistant Assignment"
        CType(Me.numHours, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvRequest, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ViewGARequestBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PROJECTS1747DataSet15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvGA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ViewAvailableGAsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvAssigned, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents cbSemester As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents numHours As NumericUpDown
    Friend WithEvents dgvRequest As DataGridView
    Friend WithEvents dgvGA As DataGridView
    Friend WithEvents btnAssignment As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents tbHours As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents tbSupervisorHours As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents tbGAs As TextBox
    Friend WithEvents dgvAssigned As DataGridView
    Friend WithEvents PROJECTS1747DataSet15 As PROJECTS1747DataSet15
    Friend WithEvents ViewGARequestBindingSource As BindingSource
    Friend WithEvents ViewGARequestTableAdapter As PROJECTS1747DataSet15TableAdapters.viewGARequestTableAdapter
    Friend WithEvents FormDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ReasonsForRequestDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NumberOfGAsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents WeeklyHoursDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ResearchDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProgrammingDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SpreadsheetsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DatabaseDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StatisticalPackagesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents WritingDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EditingDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EnglishSpeakingDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OtherCommunicationDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CommentsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ViewAvailableGAsBindingSource As BindingSource
    Friend WithEvents ViewAvailableGAsTableAdapter As PROJECTS1747DataSet15TableAdapters.viewAvailableGAsTableAdapter
    Friend WithEvents FirstNameDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents ResearchDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents ProgrammingDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents SpreadsheetDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DatabaseDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents StatisticalPackagesDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents WritingDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents EditingDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents EnglishSpeakingDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents OtherDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StudentIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ApplicationIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FilesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GAAssignmentToolStripMenuItem As ToolStripMenuItem
End Class
