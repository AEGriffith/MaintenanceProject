<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GAAssignment
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
        Me.InternetDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WordProcessingDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SpreadsheetsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatabaseDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatisticalPackagesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WritingDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EditingDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EnglishSpeakingDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OtherCommunicationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CommentsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ViewGARequestBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PROJECTS1747DataSet6 = New MaintenanceProject.PROJECTS1747DataSet6()
        Me.dgvGA = New System.Windows.Forms.DataGridView()
        Me.FirstNameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastNameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HoursAssignedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InternetDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WordProcessingDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.PROJECTS1747DataSet9 = New MaintenanceProject.PROJECTS1747DataSet9()
        Me.btnAssignment = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.ViewGARequestTableAdapter = New MaintenanceProject.PROJECTS1747DataSet6TableAdapters.viewGARequestTableAdapter()
        Me.ViewAvailableGAsTableAdapter = New MaintenanceProject.PROJECTS1747DataSet9TableAdapters.viewAvailableGAsTableAdapter()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbHours = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbSupervisorHours = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tbGAs = New System.Windows.Forms.TextBox()
        Me.dgvAssigned = New System.Windows.Forms.DataGridView()
        CType(Me.numHours, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvRequest, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ViewGARequestBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PROJECTS1747DataSet6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvGA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ViewAvailableGAsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PROJECTS1747DataSet9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvAssigned, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(178, 39)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Assign GA"
        '
        'cbSemester
        '
        Me.cbSemester.FormattingEnabled = True
        Me.cbSemester.Items.AddRange(New Object() {"Fa2017", "Sp2018"})
        Me.cbSemester.Location = New System.Drawing.Point(1683, 652)
        Me.cbSemester.Name = "cbSemester"
        Me.cbSemester.Size = New System.Drawing.Size(219, 39)
        Me.cbSemester.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(1541, 655)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(136, 32)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Semester"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(1541, 713)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(190, 32)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Weekly Hours"
        '
        'numHours
        '
        Me.numHours.Location = New System.Drawing.Point(1765, 711)
        Me.numHours.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.numHours.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numHours.Name = "numHours"
        Me.numHours.Size = New System.Drawing.Size(137, 38)
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
        Me.dgvRequest.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FormDataGridViewTextBoxColumn, Me.FirstNameDataGridViewTextBoxColumn, Me.LastNameDataGridViewTextBoxColumn, Me.ReasonsForRequestDataGridViewTextBoxColumn, Me.NumberOfGAsDataGridViewTextBoxColumn, Me.WeeklyHoursDataGridViewTextBoxColumn, Me.InternetDataGridViewTextBoxColumn, Me.WordProcessingDataGridViewTextBoxColumn, Me.SpreadsheetsDataGridViewTextBoxColumn, Me.DatabaseDataGridViewTextBoxColumn, Me.StatisticalPackagesDataGridViewTextBoxColumn, Me.WritingDataGridViewTextBoxColumn, Me.EditingDataGridViewTextBoxColumn, Me.EnglishSpeakingDataGridViewTextBoxColumn, Me.OtherCommunicationDataGridViewTextBoxColumn, Me.CommentsDataGridViewTextBoxColumn})
        Me.dgvRequest.DataSource = Me.ViewGARequestBindingSource
        Me.dgvRequest.Location = New System.Drawing.Point(20, 133)
        Me.dgvRequest.Name = "dgvRequest"
        Me.dgvRequest.ReadOnly = True
        Me.dgvRequest.RowTemplate.Height = 40
        Me.dgvRequest.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvRequest.Size = New System.Drawing.Size(1421, 334)
        Me.dgvRequest.TabIndex = 9
        '
        'FormDataGridViewTextBoxColumn
        '
        Me.FormDataGridViewTextBoxColumn.DataPropertyName = "Form"
        Me.FormDataGridViewTextBoxColumn.HeaderText = "Form"
        Me.FormDataGridViewTextBoxColumn.Name = "FormDataGridViewTextBoxColumn"
        Me.FormDataGridViewTextBoxColumn.ReadOnly = True
        Me.FormDataGridViewTextBoxColumn.Width = 134
        '
        'FirstNameDataGridViewTextBoxColumn
        '
        Me.FirstNameDataGridViewTextBoxColumn.DataPropertyName = "First Name"
        Me.FirstNameDataGridViewTextBoxColumn.HeaderText = "First Name"
        Me.FirstNameDataGridViewTextBoxColumn.Name = "FirstNameDataGridViewTextBoxColumn"
        Me.FirstNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.FirstNameDataGridViewTextBoxColumn.Width = 190
        '
        'LastNameDataGridViewTextBoxColumn
        '
        Me.LastNameDataGridViewTextBoxColumn.DataPropertyName = "Last Name"
        Me.LastNameDataGridViewTextBoxColumn.HeaderText = "Last Name"
        Me.LastNameDataGridViewTextBoxColumn.Name = "LastNameDataGridViewTextBoxColumn"
        Me.LastNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.LastNameDataGridViewTextBoxColumn.Width = 189
        '
        'ReasonsForRequestDataGridViewTextBoxColumn
        '
        Me.ReasonsForRequestDataGridViewTextBoxColumn.DataPropertyName = "Reasons for Request"
        Me.ReasonsForRequestDataGridViewTextBoxColumn.HeaderText = "Reasons for Request"
        Me.ReasonsForRequestDataGridViewTextBoxColumn.Name = "ReasonsForRequestDataGridViewTextBoxColumn"
        Me.ReasonsForRequestDataGridViewTextBoxColumn.ReadOnly = True
        Me.ReasonsForRequestDataGridViewTextBoxColumn.Width = 305
        '
        'NumberOfGAsDataGridViewTextBoxColumn
        '
        Me.NumberOfGAsDataGridViewTextBoxColumn.DataPropertyName = "Number of GAs"
        Me.NumberOfGAsDataGridViewTextBoxColumn.HeaderText = "Number of GAs"
        Me.NumberOfGAsDataGridViewTextBoxColumn.Name = "NumberOfGAsDataGridViewTextBoxColumn"
        Me.NumberOfGAsDataGridViewTextBoxColumn.ReadOnly = True
        Me.NumberOfGAsDataGridViewTextBoxColumn.Width = 191
        '
        'WeeklyHoursDataGridViewTextBoxColumn
        '
        Me.WeeklyHoursDataGridViewTextBoxColumn.DataPropertyName = "Weekly Hours"
        Me.WeeklyHoursDataGridViewTextBoxColumn.HeaderText = "Weekly Hours"
        Me.WeeklyHoursDataGridViewTextBoxColumn.Name = "WeeklyHoursDataGridViewTextBoxColumn"
        Me.WeeklyHoursDataGridViewTextBoxColumn.ReadOnly = True
        Me.WeeklyHoursDataGridViewTextBoxColumn.Width = 224
        '
        'InternetDataGridViewTextBoxColumn
        '
        Me.InternetDataGridViewTextBoxColumn.DataPropertyName = "Internet"
        Me.InternetDataGridViewTextBoxColumn.HeaderText = "Internet"
        Me.InternetDataGridViewTextBoxColumn.Name = "InternetDataGridViewTextBoxColumn"
        Me.InternetDataGridViewTextBoxColumn.ReadOnly = True
        Me.InternetDataGridViewTextBoxColumn.Width = 165
        '
        'WordProcessingDataGridViewTextBoxColumn
        '
        Me.WordProcessingDataGridViewTextBoxColumn.DataPropertyName = "Word Processing"
        Me.WordProcessingDataGridViewTextBoxColumn.HeaderText = "Word Processing"
        Me.WordProcessingDataGridViewTextBoxColumn.Name = "WordProcessingDataGridViewTextBoxColumn"
        Me.WordProcessingDataGridViewTextBoxColumn.ReadOnly = True
        Me.WordProcessingDataGridViewTextBoxColumn.Width = 260
        '
        'SpreadsheetsDataGridViewTextBoxColumn
        '
        Me.SpreadsheetsDataGridViewTextBoxColumn.DataPropertyName = "Spreadsheets"
        Me.SpreadsheetsDataGridViewTextBoxColumn.HeaderText = "Spreadsheets"
        Me.SpreadsheetsDataGridViewTextBoxColumn.Name = "SpreadsheetsDataGridViewTextBoxColumn"
        Me.SpreadsheetsDataGridViewTextBoxColumn.ReadOnly = True
        Me.SpreadsheetsDataGridViewTextBoxColumn.Width = 245
        '
        'DatabaseDataGridViewTextBoxColumn
        '
        Me.DatabaseDataGridViewTextBoxColumn.DataPropertyName = "Database"
        Me.DatabaseDataGridViewTextBoxColumn.HeaderText = "Database"
        Me.DatabaseDataGridViewTextBoxColumn.Name = "DatabaseDataGridViewTextBoxColumn"
        Me.DatabaseDataGridViewTextBoxColumn.ReadOnly = True
        Me.DatabaseDataGridViewTextBoxColumn.Width = 191
        '
        'StatisticalPackagesDataGridViewTextBoxColumn
        '
        Me.StatisticalPackagesDataGridViewTextBoxColumn.DataPropertyName = "Statistical Packages"
        Me.StatisticalPackagesDataGridViewTextBoxColumn.HeaderText = "Statistical Packages"
        Me.StatisticalPackagesDataGridViewTextBoxColumn.Name = "StatisticalPackagesDataGridViewTextBoxColumn"
        Me.StatisticalPackagesDataGridViewTextBoxColumn.ReadOnly = True
        Me.StatisticalPackagesDataGridViewTextBoxColumn.Width = 297
        '
        'WritingDataGridViewTextBoxColumn
        '
        Me.WritingDataGridViewTextBoxColumn.DataPropertyName = "Writing"
        Me.WritingDataGridViewTextBoxColumn.HeaderText = "Writing"
        Me.WritingDataGridViewTextBoxColumn.Name = "WritingDataGridViewTextBoxColumn"
        Me.WritingDataGridViewTextBoxColumn.ReadOnly = True
        Me.WritingDataGridViewTextBoxColumn.Width = 158
        '
        'EditingDataGridViewTextBoxColumn
        '
        Me.EditingDataGridViewTextBoxColumn.DataPropertyName = "Editing"
        Me.EditingDataGridViewTextBoxColumn.HeaderText = "Editing"
        Me.EditingDataGridViewTextBoxColumn.Name = "EditingDataGridViewTextBoxColumn"
        Me.EditingDataGridViewTextBoxColumn.ReadOnly = True
        Me.EditingDataGridViewTextBoxColumn.Width = 158
        '
        'EnglishSpeakingDataGridViewTextBoxColumn
        '
        Me.EnglishSpeakingDataGridViewTextBoxColumn.DataPropertyName = "English Speaking"
        Me.EnglishSpeakingDataGridViewTextBoxColumn.HeaderText = "English Speaking"
        Me.EnglishSpeakingDataGridViewTextBoxColumn.Name = "EnglishSpeakingDataGridViewTextBoxColumn"
        Me.EnglishSpeakingDataGridViewTextBoxColumn.ReadOnly = True
        Me.EnglishSpeakingDataGridViewTextBoxColumn.Width = 267
        '
        'OtherCommunicationDataGridViewTextBoxColumn
        '
        Me.OtherCommunicationDataGridViewTextBoxColumn.DataPropertyName = "Other Communication"
        Me.OtherCommunicationDataGridViewTextBoxColumn.HeaderText = "Other Communication"
        Me.OtherCommunicationDataGridViewTextBoxColumn.Name = "OtherCommunicationDataGridViewTextBoxColumn"
        Me.OtherCommunicationDataGridViewTextBoxColumn.ReadOnly = True
        Me.OtherCommunicationDataGridViewTextBoxColumn.Width = 315
        '
        'CommentsDataGridViewTextBoxColumn
        '
        Me.CommentsDataGridViewTextBoxColumn.DataPropertyName = "Comments"
        Me.CommentsDataGridViewTextBoxColumn.HeaderText = "Comments"
        Me.CommentsDataGridViewTextBoxColumn.Name = "CommentsDataGridViewTextBoxColumn"
        Me.CommentsDataGridViewTextBoxColumn.ReadOnly = True
        Me.CommentsDataGridViewTextBoxColumn.Width = 205
        '
        'ViewGARequestBindingSource
        '
        Me.ViewGARequestBindingSource.DataMember = "viewGARequest"
        Me.ViewGARequestBindingSource.DataSource = Me.PROJECTS1747DataSet6
        '
        'PROJECTS1747DataSet6
        '
        Me.PROJECTS1747DataSet6.DataSetName = "PROJECTS1747DataSet6"
        Me.PROJECTS1747DataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.dgvGA.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FirstNameDataGridViewTextBoxColumn1, Me.LastNameDataGridViewTextBoxColumn1, Me.HoursAssignedDataGridViewTextBoxColumn, Me.InternetDataGridViewTextBoxColumn1, Me.WordProcessingDataGridViewTextBoxColumn1, Me.SpreadsheetDataGridViewTextBoxColumn, Me.DatabaseDataGridViewTextBoxColumn1, Me.StatisticalPackagesDataGridViewTextBoxColumn1, Me.WritingDataGridViewTextBoxColumn1, Me.EditingDataGridViewTextBoxColumn1, Me.EnglishSpeakingDataGridViewTextBoxColumn1, Me.OtherDataGridViewTextBoxColumn, Me.StudentIDDataGridViewTextBoxColumn, Me.ApplicationIDDataGridViewTextBoxColumn})
        Me.dgvGA.DataSource = Me.ViewAvailableGAsBindingSource
        Me.dgvGA.Location = New System.Drawing.Point(20, 547)
        Me.dgvGA.Name = "dgvGA"
        Me.dgvGA.ReadOnly = True
        Me.dgvGA.RowTemplate.Height = 40
        Me.dgvGA.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvGA.Size = New System.Drawing.Size(1416, 358)
        Me.dgvGA.TabIndex = 10
        '
        'FirstNameDataGridViewTextBoxColumn1
        '
        Me.FirstNameDataGridViewTextBoxColumn1.DataPropertyName = "First name"
        Me.FirstNameDataGridViewTextBoxColumn1.HeaderText = "First name"
        Me.FirstNameDataGridViewTextBoxColumn1.Name = "FirstNameDataGridViewTextBoxColumn1"
        Me.FirstNameDataGridViewTextBoxColumn1.ReadOnly = True
        Me.FirstNameDataGridViewTextBoxColumn1.Width = 187
        '
        'LastNameDataGridViewTextBoxColumn1
        '
        Me.LastNameDataGridViewTextBoxColumn1.DataPropertyName = "Last Name"
        Me.LastNameDataGridViewTextBoxColumn1.HeaderText = "Last Name"
        Me.LastNameDataGridViewTextBoxColumn1.Name = "LastNameDataGridViewTextBoxColumn1"
        Me.LastNameDataGridViewTextBoxColumn1.ReadOnly = True
        Me.LastNameDataGridViewTextBoxColumn1.Width = 189
        '
        'HoursAssignedDataGridViewTextBoxColumn
        '
        Me.HoursAssignedDataGridViewTextBoxColumn.DataPropertyName = "Hours Assigned"
        Me.HoursAssignedDataGridViewTextBoxColumn.HeaderText = "Hours Assigned"
        Me.HoursAssignedDataGridViewTextBoxColumn.Name = "HoursAssignedDataGridViewTextBoxColumn"
        Me.HoursAssignedDataGridViewTextBoxColumn.ReadOnly = True
        Me.HoursAssignedDataGridViewTextBoxColumn.Width = 247
        '
        'InternetDataGridViewTextBoxColumn1
        '
        Me.InternetDataGridViewTextBoxColumn1.DataPropertyName = "Internet"
        Me.InternetDataGridViewTextBoxColumn1.HeaderText = "Internet"
        Me.InternetDataGridViewTextBoxColumn1.Name = "InternetDataGridViewTextBoxColumn1"
        Me.InternetDataGridViewTextBoxColumn1.ReadOnly = True
        Me.InternetDataGridViewTextBoxColumn1.Width = 165
        '
        'WordProcessingDataGridViewTextBoxColumn1
        '
        Me.WordProcessingDataGridViewTextBoxColumn1.DataPropertyName = "Word Processing"
        Me.WordProcessingDataGridViewTextBoxColumn1.HeaderText = "Word Processing"
        Me.WordProcessingDataGridViewTextBoxColumn1.Name = "WordProcessingDataGridViewTextBoxColumn1"
        Me.WordProcessingDataGridViewTextBoxColumn1.ReadOnly = True
        Me.WordProcessingDataGridViewTextBoxColumn1.Width = 260
        '
        'SpreadsheetDataGridViewTextBoxColumn
        '
        Me.SpreadsheetDataGridViewTextBoxColumn.DataPropertyName = "Spreadsheet"
        Me.SpreadsheetDataGridViewTextBoxColumn.HeaderText = "Spreadsheet"
        Me.SpreadsheetDataGridViewTextBoxColumn.Name = "SpreadsheetDataGridViewTextBoxColumn"
        Me.SpreadsheetDataGridViewTextBoxColumn.ReadOnly = True
        Me.SpreadsheetDataGridViewTextBoxColumn.Width = 231
        '
        'DatabaseDataGridViewTextBoxColumn1
        '
        Me.DatabaseDataGridViewTextBoxColumn1.DataPropertyName = "Database"
        Me.DatabaseDataGridViewTextBoxColumn1.HeaderText = "Database"
        Me.DatabaseDataGridViewTextBoxColumn1.Name = "DatabaseDataGridViewTextBoxColumn1"
        Me.DatabaseDataGridViewTextBoxColumn1.ReadOnly = True
        Me.DatabaseDataGridViewTextBoxColumn1.Width = 191
        '
        'StatisticalPackagesDataGridViewTextBoxColumn1
        '
        Me.StatisticalPackagesDataGridViewTextBoxColumn1.DataPropertyName = "Statistical Packages"
        Me.StatisticalPackagesDataGridViewTextBoxColumn1.HeaderText = "Statistical Packages"
        Me.StatisticalPackagesDataGridViewTextBoxColumn1.Name = "StatisticalPackagesDataGridViewTextBoxColumn1"
        Me.StatisticalPackagesDataGridViewTextBoxColumn1.ReadOnly = True
        Me.StatisticalPackagesDataGridViewTextBoxColumn1.Width = 297
        '
        'WritingDataGridViewTextBoxColumn1
        '
        Me.WritingDataGridViewTextBoxColumn1.DataPropertyName = "Writing"
        Me.WritingDataGridViewTextBoxColumn1.HeaderText = "Writing"
        Me.WritingDataGridViewTextBoxColumn1.Name = "WritingDataGridViewTextBoxColumn1"
        Me.WritingDataGridViewTextBoxColumn1.ReadOnly = True
        Me.WritingDataGridViewTextBoxColumn1.Width = 158
        '
        'EditingDataGridViewTextBoxColumn1
        '
        Me.EditingDataGridViewTextBoxColumn1.DataPropertyName = "Editing"
        Me.EditingDataGridViewTextBoxColumn1.HeaderText = "Editing"
        Me.EditingDataGridViewTextBoxColumn1.Name = "EditingDataGridViewTextBoxColumn1"
        Me.EditingDataGridViewTextBoxColumn1.ReadOnly = True
        Me.EditingDataGridViewTextBoxColumn1.Width = 158
        '
        'EnglishSpeakingDataGridViewTextBoxColumn1
        '
        Me.EnglishSpeakingDataGridViewTextBoxColumn1.DataPropertyName = "English Speaking"
        Me.EnglishSpeakingDataGridViewTextBoxColumn1.HeaderText = "English Speaking"
        Me.EnglishSpeakingDataGridViewTextBoxColumn1.Name = "EnglishSpeakingDataGridViewTextBoxColumn1"
        Me.EnglishSpeakingDataGridViewTextBoxColumn1.ReadOnly = True
        Me.EnglishSpeakingDataGridViewTextBoxColumn1.Width = 267
        '
        'OtherDataGridViewTextBoxColumn
        '
        Me.OtherDataGridViewTextBoxColumn.DataPropertyName = "Other"
        Me.OtherDataGridViewTextBoxColumn.HeaderText = "Other"
        Me.OtherDataGridViewTextBoxColumn.Name = "OtherDataGridViewTextBoxColumn"
        Me.OtherDataGridViewTextBoxColumn.ReadOnly = True
        Me.OtherDataGridViewTextBoxColumn.Width = 140
        '
        'StudentIDDataGridViewTextBoxColumn
        '
        Me.StudentIDDataGridViewTextBoxColumn.DataPropertyName = "Student_ID"
        Me.StudentIDDataGridViewTextBoxColumn.HeaderText = "Student_ID"
        Me.StudentIDDataGridViewTextBoxColumn.Name = "StudentIDDataGridViewTextBoxColumn"
        Me.StudentIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.StudentIDDataGridViewTextBoxColumn.Width = 210
        '
        'ApplicationIDDataGridViewTextBoxColumn
        '
        Me.ApplicationIDDataGridViewTextBoxColumn.DataPropertyName = "Application_ID"
        Me.ApplicationIDDataGridViewTextBoxColumn.HeaderText = "Application_ID"
        Me.ApplicationIDDataGridViewTextBoxColumn.Name = "ApplicationIDDataGridViewTextBoxColumn"
        Me.ApplicationIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.ApplicationIDDataGridViewTextBoxColumn.Width = 253
        '
        'ViewAvailableGAsBindingSource
        '
        Me.ViewAvailableGAsBindingSource.DataMember = "viewAvailableGAs"
        Me.ViewAvailableGAsBindingSource.DataSource = Me.PROJECTS1747DataSet9
        '
        'PROJECTS1747DataSet9
        '
        Me.PROJECTS1747DataSet9.DataSetName = "PROJECTS1747DataSet9"
        Me.PROJECTS1747DataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnAssignment
        '
        Me.btnAssignment.Location = New System.Drawing.Point(1625, 899)
        Me.btnAssignment.Name = "btnAssignment"
        Me.btnAssignment.Size = New System.Drawing.Size(189, 60)
        Me.btnAssignment.TabIndex = 12
        Me.btnAssignment.Text = "Assign"
        Me.btnAssignment.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(1820, 899)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(138, 60)
        Me.btnClose.TabIndex = 11
        Me.btnClose.Text = "Cancel"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'ViewGARequestTableAdapter
        '
        Me.ViewGARequestTableAdapter.ClearBeforeFill = True
        '
        'ViewAvailableGAsTableAdapter
        '
        Me.ViewAvailableGAsTableAdapter.ClearBeforeFill = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(208, 32)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Select Request"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 512)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(143, 32)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Select GA"
        '
        'tbHours
        '
        Me.tbHours.Location = New System.Drawing.Point(1336, 911)
        Me.tbHours.Name = "tbHours"
        Me.tbHours.ReadOnly = True
        Me.tbHours.Size = New System.Drawing.Size(100, 38)
        Me.tbHours.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(1009, 914)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(321, 32)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Current Hours Per Week"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(761, 479)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(291, 32)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Total Hours Per Week"
        '
        'tbSupervisorHours
        '
        Me.tbSupervisorHours.Location = New System.Drawing.Point(1069, 476)
        Me.tbSupervisorHours.Name = "tbSupervisorHours"
        Me.tbSupervisorHours.ReadOnly = True
        Me.tbSupervisorHours.Size = New System.Drawing.Size(100, 38)
        Me.tbSupervisorHours.TabIndex = 17
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(1189, 479)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(141, 32)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Total GAs"
        '
        'tbGAs
        '
        Me.tbGAs.Location = New System.Drawing.Point(1336, 476)
        Me.tbGAs.Name = "tbGAs"
        Me.tbGAs.ReadOnly = True
        Me.tbGAs.Size = New System.Drawing.Size(100, 38)
        Me.tbGAs.TabIndex = 19
        '
        'dgvAssigned
        '
        Me.dgvAssigned.AllowUserToAddRows = False
        Me.dgvAssigned.AllowUserToDeleteRows = False
        Me.dgvAssigned.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvAssigned.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvAssigned.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAssigned.Location = New System.Drawing.Point(1466, 133)
        Me.dgvAssigned.Name = "dgvAssigned"
        Me.dgvAssigned.ReadOnly = True
        Me.dgvAssigned.RowTemplate.Height = 40
        Me.dgvAssigned.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvAssigned.Size = New System.Drawing.Size(501, 334)
        Me.dgvAssigned.TabIndex = 21
        '
        'GAAssignment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1975, 981)
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
        Me.Name = "GAAssignment"
        Me.Padding = New System.Windows.Forms.Padding(5)
        Me.Text = "GAAssignment"
        CType(Me.numHours, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvRequest, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ViewGARequestBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PROJECTS1747DataSet6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvGA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ViewAvailableGAsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PROJECTS1747DataSet9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvAssigned, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents PROJECTS1747DataSet6 As PROJECTS1747DataSet6
    Friend WithEvents ViewGARequestBindingSource As BindingSource
    Friend WithEvents ViewGARequestTableAdapter As PROJECTS1747DataSet6TableAdapters.viewGARequestTableAdapter
    Friend WithEvents FormDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ReasonsForRequestDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NumberOfGAsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents WeeklyHoursDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents InternetDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents WordProcessingDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SpreadsheetsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DatabaseDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StatisticalPackagesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents WritingDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EditingDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EnglishSpeakingDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OtherCommunicationDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CommentsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PROJECTS1747DataSet9 As PROJECTS1747DataSet9
    Friend WithEvents ViewAvailableGAsBindingSource As BindingSource
    Friend WithEvents ViewAvailableGAsTableAdapter As PROJECTS1747DataSet9TableAdapters.viewAvailableGAsTableAdapter
    Friend WithEvents FirstNameDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents HoursAssignedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents InternetDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents WordProcessingDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents SpreadsheetDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DatabaseDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents StatisticalPackagesDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents WritingDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents EditingDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents EnglishSpeakingDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents OtherDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StudentIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ApplicationIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents tbHours As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents tbSupervisorHours As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents tbGAs As TextBox
    Friend WithEvents dgvAssigned As DataGridView
End Class
