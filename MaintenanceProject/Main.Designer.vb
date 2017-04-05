<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ApplicantProfileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewApplicantBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PROJECTS1747DataSet = New MaintenanceProject.PROJECTS1747DataSet()
        Me.btnViewApplicant = New System.Windows.Forms.Button()
        Me.ViewApplicantTableAdapter = New MaintenanceProject.PROJECTS1747DataSetTableAdapters.viewApplicantTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbFName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbLName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbProgram = New System.Windows.Forms.ComboBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbEmployer = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbTWE = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tbGender = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tbEthnicity = New System.Windows.Forms.TextBox()
        Me.numMinAge = New System.Windows.Forms.NumericUpDown()
        Me.numMaxAge = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProgramDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApplicationDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MissingStatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReceivedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NotesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VerbalQuantitativeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GMATDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GMATVerbalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GMATVerbalDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GMATQuantitativeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GMATQuantitativeDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AWADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GREDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GREVerbalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GREVerbalDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GREQuantitativeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GREQuantitativeDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WRDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TOEFLDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TimeWithEmployerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CurrentEmployerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UndergraduateGPADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GraduateGPADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UndergraduateInstitutionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UndergraduateDegreeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UndergraduateMajorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GraduateInstitutionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GraduateDegreeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GraduateMajorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GenderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EthnicityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AgeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PostalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CountryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ResidencyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tbUDegree = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tbResidency = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.numGMATMax = New System.Windows.Forms.NumericUpDown()
        Me.numGMATMin = New System.Windows.Forms.NumericUpDown()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.numGREMax = New System.Windows.Forms.NumericUpDown()
        Me.numGREMin = New System.Windows.Forms.NumericUpDown()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.numUGPAMax = New System.Windows.Forms.NumericUpDown()
        Me.numUGPAMin = New System.Windows.Forms.NumericUpDown()
        Me.cbGMAT = New System.Windows.Forms.CheckBox()
        Me.cbGRE = New System.Windows.Forms.CheckBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.ViewApplicantBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PROJECTS1747DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numMinAge, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numMaxAge, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numGMATMax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numGMATMin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numGREMax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numGREMin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numUGPAMax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numUGPAMin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(40, 40)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(2, 1, 0, 1)
        Me.MenuStrip1.Size = New System.Drawing.Size(490, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem, Me.ApplicantProfileToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 22)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ApplicantProfileToolStripMenuItem
        '
        Me.ApplicantProfileToolStripMenuItem.Name = "ApplicantProfileToolStripMenuItem"
        Me.ApplicantProfileToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.ApplicantProfileToolStripMenuItem.Text = "Applicant Profile"
        '
        'ViewApplicantBindingSource
        '
        Me.ViewApplicantBindingSource.DataMember = "viewApplicant"
        Me.ViewApplicantBindingSource.DataSource = Me.PROJECTS1747DataSet
        '
        'PROJECTS1747DataSet
        '
        Me.PROJECTS1747DataSet.DataSetName = "PROJECTS1747DataSet"
        Me.PROJECTS1747DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnViewApplicant
        '
        Me.btnViewApplicant.Location = New System.Drawing.Point(324, 369)
        Me.btnViewApplicant.Margin = New System.Windows.Forms.Padding(0)
        Me.btnViewApplicant.Name = "btnViewApplicant"
        Me.btnViewApplicant.Size = New System.Drawing.Size(80, 23)
        Me.btnViewApplicant.TabIndex = 10
        Me.btnViewApplicant.Text = "View Profile"
        Me.btnViewApplicant.UseVisualStyleBackColor = True
        '
        'ViewApplicantTableAdapter
        '
        Me.ViewApplicantTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 26)
        Me.Label1.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "First Name"
        '
        'tbFName
        '
        Me.tbFName.Location = New System.Drawing.Point(7, 41)
        Me.tbFName.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.tbFName.Name = "tbFName"
        Me.tbFName.Size = New System.Drawing.Size(83, 20)
        Me.tbFName.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(101, 26)
        Me.Label2.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Last Name"
        '
        'tbLName
        '
        Me.tbLName.Location = New System.Drawing.Point(103, 41)
        Me.tbLName.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.tbLName.Name = "tbLName"
        Me.tbLName.Size = New System.Drawing.Size(83, 20)
        Me.tbLName.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(197, 26)
        Me.Label3.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Program"
        '
        'cbProgram
        '
        Me.cbProgram.FormattingEnabled = True
        Me.cbProgram.Items.AddRange(New Object() {"MIS", "PMIS"})
        Me.cbProgram.Location = New System.Drawing.Point(199, 42)
        Me.cbProgram.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.cbProgram.Name = "cbProgram"
        Me.cbProgram.Size = New System.Drawing.Size(66, 21)
        Me.cbProgram.TabIndex = 16
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(410, 34)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(0)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(80, 23)
        Me.btnClear.TabIndex = 18
        Me.btnClear.Text = "Clear Filters"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(5, 65)
        Me.Label5.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Current Employer"
        '
        'tbEmployer
        '
        Me.tbEmployer.Location = New System.Drawing.Point(7, 80)
        Me.tbEmployer.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.tbEmployer.Name = "tbEmployer"
        Me.tbEmployer.Size = New System.Drawing.Size(92, 20)
        Me.tbEmployer.TabIndex = 20
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(108, 65)
        Me.Label6.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 13)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Time With Employer"
        '
        'tbTWE
        '
        Me.tbTWE.Location = New System.Drawing.Point(110, 80)
        Me.tbTWE.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.tbTWE.Name = "tbTWE"
        Me.tbTWE.Size = New System.Drawing.Size(101, 20)
        Me.tbTWE.TabIndex = 22
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(276, 26)
        Me.Label8.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 13)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "Gender"
        '
        'tbGender
        '
        Me.tbGender.Location = New System.Drawing.Point(279, 41)
        Me.tbGender.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.tbGender.Name = "tbGender"
        Me.tbGender.Size = New System.Drawing.Size(38, 20)
        Me.tbGender.TabIndex = 26
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(328, 26)
        Me.Label9.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(47, 13)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "Ethnicity"
        '
        'tbEthnicity
        '
        Me.tbEthnicity.Location = New System.Drawing.Point(330, 41)
        Me.tbEthnicity.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.tbEthnicity.Name = "tbEthnicity"
        Me.tbEthnicity.Size = New System.Drawing.Size(70, 20)
        Me.tbEthnicity.TabIndex = 28
        '
        'numMinAge
        '
        Me.numMinAge.Location = New System.Drawing.Point(7, 128)
        Me.numMinAge.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.numMinAge.Name = "numMinAge"
        Me.numMinAge.Size = New System.Drawing.Size(36, 20)
        Me.numMinAge.TabIndex = 29
        '
        'numMaxAge
        '
        Me.numMaxAge.Location = New System.Drawing.Point(54, 128)
        Me.numMaxAge.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.numMaxAge.Name = "numMaxAge"
        Me.numMaxAge.Size = New System.Drawing.Size(36, 20)
        Me.numMaxAge.TabIndex = 30
        Me.numMaxAge.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(30, 103)
        Me.Label4.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 13)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Age"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(410, 369)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(80, 23)
        Me.btnClose.TabIndex = 32
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.FirstNameDataGridViewTextBoxColumn, Me.LastNameDataGridViewTextBoxColumn, Me.ProgramDataGridViewTextBoxColumn, Me.ApplicationDateDataGridViewTextBoxColumn, Me.MissingStatusDataGridViewTextBoxColumn, Me.ReceivedDataGridViewTextBoxColumn, Me.NotesDataGridViewTextBoxColumn, Me.VerbalQuantitativeDataGridViewTextBoxColumn, Me.GMATDataGridViewTextBoxColumn, Me.GMATVerbalDataGridViewTextBoxColumn, Me.GMATVerbalDataGridViewTextBoxColumn1, Me.GMATQuantitativeDataGridViewTextBoxColumn, Me.GMATQuantitativeDataGridViewTextBoxColumn1, Me.AWADataGridViewTextBoxColumn, Me.GREDataGridViewTextBoxColumn, Me.GREVerbalDataGridViewTextBoxColumn, Me.GREVerbalDataGridViewTextBoxColumn1, Me.GREQuantitativeDataGridViewTextBoxColumn, Me.GREQuantitativeDataGridViewTextBoxColumn1, Me.WRDataGridViewTextBoxColumn, Me.TOEFLDataGridViewTextBoxColumn, Me.TimeWithEmployerDataGridViewTextBoxColumn, Me.CurrentEmployerDataGridViewTextBoxColumn, Me.UndergraduateGPADataGridViewTextBoxColumn, Me.GraduateGPADataGridViewTextBoxColumn, Me.UndergraduateInstitutionDataGridViewTextBoxColumn, Me.UndergraduateDegreeDataGridViewTextBoxColumn, Me.UndergraduateMajorDataGridViewTextBoxColumn, Me.GraduateInstitutionDataGridViewTextBoxColumn, Me.GraduateDegreeDataGridViewTextBoxColumn, Me.GraduateMajorDataGridViewTextBoxColumn, Me.GenderDataGridViewTextBoxColumn, Me.EthnicityDataGridViewTextBoxColumn, Me.AgeDataGridViewTextBoxColumn, Me.CityDataGridViewTextBoxColumn, Me.StateDataGridViewTextBoxColumn, Me.PostalDataGridViewTextBoxColumn, Me.CountryDataGridViewTextBoxColumn, Me.ResidencyDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ViewApplicantBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(7, 156)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 40
        Me.DataGridView1.Size = New System.Drawing.Size(531, 160)
        Me.DataGridView1.TabIndex = 0
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDDataGridViewTextBoxColumn.Width = 43
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
        'ProgramDataGridViewTextBoxColumn
        '
        Me.ProgramDataGridViewTextBoxColumn.DataPropertyName = "Program"
        Me.ProgramDataGridViewTextBoxColumn.HeaderText = "Program"
        Me.ProgramDataGridViewTextBoxColumn.Name = "ProgramDataGridViewTextBoxColumn"
        Me.ProgramDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProgramDataGridViewTextBoxColumn.Width = 71
        '
        'ApplicationDateDataGridViewTextBoxColumn
        '
        Me.ApplicationDateDataGridViewTextBoxColumn.DataPropertyName = "Application Date"
        Me.ApplicationDateDataGridViewTextBoxColumn.HeaderText = "Application Date"
        Me.ApplicationDateDataGridViewTextBoxColumn.Name = "ApplicationDateDataGridViewTextBoxColumn"
        Me.ApplicationDateDataGridViewTextBoxColumn.ReadOnly = True
        Me.ApplicationDateDataGridViewTextBoxColumn.Width = 101
        '
        'MissingStatusDataGridViewTextBoxColumn
        '
        Me.MissingStatusDataGridViewTextBoxColumn.DataPropertyName = "Missing Status"
        Me.MissingStatusDataGridViewTextBoxColumn.HeaderText = "Missing Status"
        Me.MissingStatusDataGridViewTextBoxColumn.Name = "MissingStatusDataGridViewTextBoxColumn"
        Me.MissingStatusDataGridViewTextBoxColumn.ReadOnly = True
        Me.MissingStatusDataGridViewTextBoxColumn.Width = 92
        '
        'ReceivedDataGridViewTextBoxColumn
        '
        Me.ReceivedDataGridViewTextBoxColumn.DataPropertyName = "Received"
        Me.ReceivedDataGridViewTextBoxColumn.HeaderText = "Received"
        Me.ReceivedDataGridViewTextBoxColumn.Name = "ReceivedDataGridViewTextBoxColumn"
        Me.ReceivedDataGridViewTextBoxColumn.ReadOnly = True
        Me.ReceivedDataGridViewTextBoxColumn.Width = 78
        '
        'NotesDataGridViewTextBoxColumn
        '
        Me.NotesDataGridViewTextBoxColumn.DataPropertyName = "Notes"
        Me.NotesDataGridViewTextBoxColumn.HeaderText = "Notes"
        Me.NotesDataGridViewTextBoxColumn.Name = "NotesDataGridViewTextBoxColumn"
        Me.NotesDataGridViewTextBoxColumn.ReadOnly = True
        Me.NotesDataGridViewTextBoxColumn.Width = 60
        '
        'VerbalQuantitativeDataGridViewTextBoxColumn
        '
        Me.VerbalQuantitativeDataGridViewTextBoxColumn.DataPropertyName = "Verbal + Quantitative"
        Me.VerbalQuantitativeDataGridViewTextBoxColumn.HeaderText = "Verbal + Quantitative"
        Me.VerbalQuantitativeDataGridViewTextBoxColumn.Name = "VerbalQuantitativeDataGridViewTextBoxColumn"
        Me.VerbalQuantitativeDataGridViewTextBoxColumn.ReadOnly = True
        Me.VerbalQuantitativeDataGridViewTextBoxColumn.Width = 120
        '
        'GMATDataGridViewTextBoxColumn
        '
        Me.GMATDataGridViewTextBoxColumn.DataPropertyName = "GMAT"
        Me.GMATDataGridViewTextBoxColumn.HeaderText = "GMAT"
        Me.GMATDataGridViewTextBoxColumn.Name = "GMATDataGridViewTextBoxColumn"
        Me.GMATDataGridViewTextBoxColumn.ReadOnly = True
        Me.GMATDataGridViewTextBoxColumn.Width = 63
        '
        'GMATVerbalDataGridViewTextBoxColumn
        '
        Me.GMATVerbalDataGridViewTextBoxColumn.DataPropertyName = "GMAT Verbal"
        Me.GMATVerbalDataGridViewTextBoxColumn.HeaderText = "GMAT Verbal"
        Me.GMATVerbalDataGridViewTextBoxColumn.Name = "GMATVerbalDataGridViewTextBoxColumn"
        Me.GMATVerbalDataGridViewTextBoxColumn.ReadOnly = True
        Me.GMATVerbalDataGridViewTextBoxColumn.Width = 88
        '
        'GMATVerbalDataGridViewTextBoxColumn1
        '
        Me.GMATVerbalDataGridViewTextBoxColumn1.DataPropertyName = "GMAT Verbal %"
        Me.GMATVerbalDataGridViewTextBoxColumn1.HeaderText = "GMAT Verbal %"
        Me.GMATVerbalDataGridViewTextBoxColumn1.Name = "GMATVerbalDataGridViewTextBoxColumn1"
        Me.GMATVerbalDataGridViewTextBoxColumn1.ReadOnly = True
        Me.GMATVerbalDataGridViewTextBoxColumn1.Width = 88
        '
        'GMATQuantitativeDataGridViewTextBoxColumn
        '
        Me.GMATQuantitativeDataGridViewTextBoxColumn.DataPropertyName = "GMAT Quantitative"
        Me.GMATQuantitativeDataGridViewTextBoxColumn.HeaderText = "GMAT Quantitative"
        Me.GMATQuantitativeDataGridViewTextBoxColumn.Name = "GMATQuantitativeDataGridViewTextBoxColumn"
        Me.GMATQuantitativeDataGridViewTextBoxColumn.ReadOnly = True
        Me.GMATQuantitativeDataGridViewTextBoxColumn.Width = 113
        '
        'GMATQuantitativeDataGridViewTextBoxColumn1
        '
        Me.GMATQuantitativeDataGridViewTextBoxColumn1.DataPropertyName = "GMAT Quantitative %"
        Me.GMATQuantitativeDataGridViewTextBoxColumn1.HeaderText = "GMAT Quantitative %"
        Me.GMATQuantitativeDataGridViewTextBoxColumn1.Name = "GMATQuantitativeDataGridViewTextBoxColumn1"
        Me.GMATQuantitativeDataGridViewTextBoxColumn1.ReadOnly = True
        Me.GMATQuantitativeDataGridViewTextBoxColumn1.Width = 113
        '
        'AWADataGridViewTextBoxColumn
        '
        Me.AWADataGridViewTextBoxColumn.DataPropertyName = "AWA"
        Me.AWADataGridViewTextBoxColumn.HeaderText = "AWA"
        Me.AWADataGridViewTextBoxColumn.Name = "AWADataGridViewTextBoxColumn"
        Me.AWADataGridViewTextBoxColumn.ReadOnly = True
        Me.AWADataGridViewTextBoxColumn.Width = 57
        '
        'GREDataGridViewTextBoxColumn
        '
        Me.GREDataGridViewTextBoxColumn.DataPropertyName = "GRE"
        Me.GREDataGridViewTextBoxColumn.HeaderText = "GRE"
        Me.GREDataGridViewTextBoxColumn.Name = "GREDataGridViewTextBoxColumn"
        Me.GREDataGridViewTextBoxColumn.ReadOnly = True
        Me.GREDataGridViewTextBoxColumn.Width = 55
        '
        'GREVerbalDataGridViewTextBoxColumn
        '
        Me.GREVerbalDataGridViewTextBoxColumn.DataPropertyName = "GRE Verbal"
        Me.GREVerbalDataGridViewTextBoxColumn.HeaderText = "GRE Verbal"
        Me.GREVerbalDataGridViewTextBoxColumn.Name = "GREVerbalDataGridViewTextBoxColumn"
        Me.GREVerbalDataGridViewTextBoxColumn.ReadOnly = True
        Me.GREVerbalDataGridViewTextBoxColumn.Width = 81
        '
        'GREVerbalDataGridViewTextBoxColumn1
        '
        Me.GREVerbalDataGridViewTextBoxColumn1.DataPropertyName = "GRE Verbal %"
        Me.GREVerbalDataGridViewTextBoxColumn1.HeaderText = "GRE Verbal %"
        Me.GREVerbalDataGridViewTextBoxColumn1.Name = "GREVerbalDataGridViewTextBoxColumn1"
        Me.GREVerbalDataGridViewTextBoxColumn1.ReadOnly = True
        Me.GREVerbalDataGridViewTextBoxColumn1.Width = 84
        '
        'GREQuantitativeDataGridViewTextBoxColumn
        '
        Me.GREQuantitativeDataGridViewTextBoxColumn.DataPropertyName = "GRE Quantitative"
        Me.GREQuantitativeDataGridViewTextBoxColumn.HeaderText = "GRE Quantitative"
        Me.GREQuantitativeDataGridViewTextBoxColumn.Name = "GREQuantitativeDataGridViewTextBoxColumn"
        Me.GREQuantitativeDataGridViewTextBoxColumn.ReadOnly = True
        Me.GREQuantitativeDataGridViewTextBoxColumn.Width = 105
        '
        'GREQuantitativeDataGridViewTextBoxColumn1
        '
        Me.GREQuantitativeDataGridViewTextBoxColumn1.DataPropertyName = "GRE Quantitative %"
        Me.GREQuantitativeDataGridViewTextBoxColumn1.HeaderText = "GRE Quantitative %"
        Me.GREQuantitativeDataGridViewTextBoxColumn1.Name = "GREQuantitativeDataGridViewTextBoxColumn1"
        Me.GREQuantitativeDataGridViewTextBoxColumn1.ReadOnly = True
        Me.GREQuantitativeDataGridViewTextBoxColumn1.Width = 105
        '
        'WRDataGridViewTextBoxColumn
        '
        Me.WRDataGridViewTextBoxColumn.DataPropertyName = "WR"
        Me.WRDataGridViewTextBoxColumn.HeaderText = "WR"
        Me.WRDataGridViewTextBoxColumn.Name = "WRDataGridViewTextBoxColumn"
        Me.WRDataGridViewTextBoxColumn.ReadOnly = True
        Me.WRDataGridViewTextBoxColumn.Width = 51
        '
        'TOEFLDataGridViewTextBoxColumn
        '
        Me.TOEFLDataGridViewTextBoxColumn.DataPropertyName = "TOEFL"
        Me.TOEFLDataGridViewTextBoxColumn.HeaderText = "TOEFL"
        Me.TOEFLDataGridViewTextBoxColumn.Name = "TOEFLDataGridViewTextBoxColumn"
        Me.TOEFLDataGridViewTextBoxColumn.ReadOnly = True
        Me.TOEFLDataGridViewTextBoxColumn.Width = 66
        '
        'TimeWithEmployerDataGridViewTextBoxColumn
        '
        Me.TimeWithEmployerDataGridViewTextBoxColumn.DataPropertyName = "Time With Employer"
        Me.TimeWithEmployerDataGridViewTextBoxColumn.HeaderText = "Time With Employer"
        Me.TimeWithEmployerDataGridViewTextBoxColumn.Name = "TimeWithEmployerDataGridViewTextBoxColumn"
        Me.TimeWithEmployerDataGridViewTextBoxColumn.ReadOnly = True
        Me.TimeWithEmployerDataGridViewTextBoxColumn.Width = 115
        '
        'CurrentEmployerDataGridViewTextBoxColumn
        '
        Me.CurrentEmployerDataGridViewTextBoxColumn.DataPropertyName = "Current Employer"
        Me.CurrentEmployerDataGridViewTextBoxColumn.HeaderText = "Current Employer"
        Me.CurrentEmployerDataGridViewTextBoxColumn.Name = "CurrentEmployerDataGridViewTextBoxColumn"
        Me.CurrentEmployerDataGridViewTextBoxColumn.ReadOnly = True
        Me.CurrentEmployerDataGridViewTextBoxColumn.Width = 103
        '
        'UndergraduateGPADataGridViewTextBoxColumn
        '
        Me.UndergraduateGPADataGridViewTextBoxColumn.DataPropertyName = "Undergraduate GPA"
        Me.UndergraduateGPADataGridViewTextBoxColumn.HeaderText = "Undergraduate GPA"
        Me.UndergraduateGPADataGridViewTextBoxColumn.Name = "UndergraduateGPADataGridViewTextBoxColumn"
        Me.UndergraduateGPADataGridViewTextBoxColumn.ReadOnly = True
        Me.UndergraduateGPADataGridViewTextBoxColumn.Width = 117
        '
        'GraduateGPADataGridViewTextBoxColumn
        '
        Me.GraduateGPADataGridViewTextBoxColumn.DataPropertyName = "Graduate GPA"
        Me.GraduateGPADataGridViewTextBoxColumn.HeaderText = "Graduate GPA"
        Me.GraduateGPADataGridViewTextBoxColumn.Name = "GraduateGPADataGridViewTextBoxColumn"
        Me.GraduateGPADataGridViewTextBoxColumn.ReadOnly = True
        Me.GraduateGPADataGridViewTextBoxColumn.Width = 93
        '
        'UndergraduateInstitutionDataGridViewTextBoxColumn
        '
        Me.UndergraduateInstitutionDataGridViewTextBoxColumn.DataPropertyName = "Undergraduate Institution"
        Me.UndergraduateInstitutionDataGridViewTextBoxColumn.HeaderText = "Undergraduate Institution"
        Me.UndergraduateInstitutionDataGridViewTextBoxColumn.Name = "UndergraduateInstitutionDataGridViewTextBoxColumn"
        Me.UndergraduateInstitutionDataGridViewTextBoxColumn.ReadOnly = True
        Me.UndergraduateInstitutionDataGridViewTextBoxColumn.Width = 138
        '
        'UndergraduateDegreeDataGridViewTextBoxColumn
        '
        Me.UndergraduateDegreeDataGridViewTextBoxColumn.DataPropertyName = "Undergraduate Degree"
        Me.UndergraduateDegreeDataGridViewTextBoxColumn.HeaderText = "Undergraduate Degree"
        Me.UndergraduateDegreeDataGridViewTextBoxColumn.Name = "UndergraduateDegreeDataGridViewTextBoxColumn"
        Me.UndergraduateDegreeDataGridViewTextBoxColumn.ReadOnly = True
        Me.UndergraduateDegreeDataGridViewTextBoxColumn.Width = 129
        '
        'UndergraduateMajorDataGridViewTextBoxColumn
        '
        Me.UndergraduateMajorDataGridViewTextBoxColumn.DataPropertyName = "Undergraduate Major"
        Me.UndergraduateMajorDataGridViewTextBoxColumn.HeaderText = "Undergraduate Major"
        Me.UndergraduateMajorDataGridViewTextBoxColumn.Name = "UndergraduateMajorDataGridViewTextBoxColumn"
        Me.UndergraduateMajorDataGridViewTextBoxColumn.ReadOnly = True
        Me.UndergraduateMajorDataGridViewTextBoxColumn.Width = 121
        '
        'GraduateInstitutionDataGridViewTextBoxColumn
        '
        Me.GraduateInstitutionDataGridViewTextBoxColumn.DataPropertyName = "Graduate Institution"
        Me.GraduateInstitutionDataGridViewTextBoxColumn.HeaderText = "Graduate Institution"
        Me.GraduateInstitutionDataGridViewTextBoxColumn.Name = "GraduateInstitutionDataGridViewTextBoxColumn"
        Me.GraduateInstitutionDataGridViewTextBoxColumn.ReadOnly = True
        Me.GraduateInstitutionDataGridViewTextBoxColumn.Width = 114
        '
        'GraduateDegreeDataGridViewTextBoxColumn
        '
        Me.GraduateDegreeDataGridViewTextBoxColumn.DataPropertyName = "Graduate Degree"
        Me.GraduateDegreeDataGridViewTextBoxColumn.HeaderText = "Graduate Degree"
        Me.GraduateDegreeDataGridViewTextBoxColumn.Name = "GraduateDegreeDataGridViewTextBoxColumn"
        Me.GraduateDegreeDataGridViewTextBoxColumn.ReadOnly = True
        Me.GraduateDegreeDataGridViewTextBoxColumn.Width = 105
        '
        'GraduateMajorDataGridViewTextBoxColumn
        '
        Me.GraduateMajorDataGridViewTextBoxColumn.DataPropertyName = "Graduate Major"
        Me.GraduateMajorDataGridViewTextBoxColumn.HeaderText = "Graduate Major"
        Me.GraduateMajorDataGridViewTextBoxColumn.Name = "GraduateMajorDataGridViewTextBoxColumn"
        Me.GraduateMajorDataGridViewTextBoxColumn.ReadOnly = True
        Me.GraduateMajorDataGridViewTextBoxColumn.Width = 96
        '
        'GenderDataGridViewTextBoxColumn
        '
        Me.GenderDataGridViewTextBoxColumn.DataPropertyName = "Gender"
        Me.GenderDataGridViewTextBoxColumn.HeaderText = "Gender"
        Me.GenderDataGridViewTextBoxColumn.Name = "GenderDataGridViewTextBoxColumn"
        Me.GenderDataGridViewTextBoxColumn.ReadOnly = True
        Me.GenderDataGridViewTextBoxColumn.Width = 67
        '
        'EthnicityDataGridViewTextBoxColumn
        '
        Me.EthnicityDataGridViewTextBoxColumn.DataPropertyName = "Ethnicity"
        Me.EthnicityDataGridViewTextBoxColumn.HeaderText = "Ethnicity"
        Me.EthnicityDataGridViewTextBoxColumn.Name = "EthnicityDataGridViewTextBoxColumn"
        Me.EthnicityDataGridViewTextBoxColumn.ReadOnly = True
        Me.EthnicityDataGridViewTextBoxColumn.Width = 72
        '
        'AgeDataGridViewTextBoxColumn
        '
        Me.AgeDataGridViewTextBoxColumn.DataPropertyName = "Age"
        Me.AgeDataGridViewTextBoxColumn.HeaderText = "Age"
        Me.AgeDataGridViewTextBoxColumn.Name = "AgeDataGridViewTextBoxColumn"
        Me.AgeDataGridViewTextBoxColumn.ReadOnly = True
        Me.AgeDataGridViewTextBoxColumn.Width = 51
        '
        'CityDataGridViewTextBoxColumn
        '
        Me.CityDataGridViewTextBoxColumn.DataPropertyName = "City"
        Me.CityDataGridViewTextBoxColumn.HeaderText = "City"
        Me.CityDataGridViewTextBoxColumn.Name = "CityDataGridViewTextBoxColumn"
        Me.CityDataGridViewTextBoxColumn.ReadOnly = True
        Me.CityDataGridViewTextBoxColumn.Width = 49
        '
        'StateDataGridViewTextBoxColumn
        '
        Me.StateDataGridViewTextBoxColumn.DataPropertyName = "State"
        Me.StateDataGridViewTextBoxColumn.HeaderText = "State"
        Me.StateDataGridViewTextBoxColumn.Name = "StateDataGridViewTextBoxColumn"
        Me.StateDataGridViewTextBoxColumn.ReadOnly = True
        Me.StateDataGridViewTextBoxColumn.Width = 57
        '
        'PostalDataGridViewTextBoxColumn
        '
        Me.PostalDataGridViewTextBoxColumn.DataPropertyName = "Postal"
        Me.PostalDataGridViewTextBoxColumn.HeaderText = "Postal"
        Me.PostalDataGridViewTextBoxColumn.Name = "PostalDataGridViewTextBoxColumn"
        Me.PostalDataGridViewTextBoxColumn.ReadOnly = True
        Me.PostalDataGridViewTextBoxColumn.Width = 61
        '
        'CountryDataGridViewTextBoxColumn
        '
        Me.CountryDataGridViewTextBoxColumn.DataPropertyName = "Country"
        Me.CountryDataGridViewTextBoxColumn.HeaderText = "Country"
        Me.CountryDataGridViewTextBoxColumn.Name = "CountryDataGridViewTextBoxColumn"
        Me.CountryDataGridViewTextBoxColumn.ReadOnly = True
        Me.CountryDataGridViewTextBoxColumn.Width = 68
        '
        'ResidencyDataGridViewTextBoxColumn
        '
        Me.ResidencyDataGridViewTextBoxColumn.DataPropertyName = "Residency"
        Me.ResidencyDataGridViewTextBoxColumn.HeaderText = "Residency"
        Me.ResidencyDataGridViewTextBoxColumn.Name = "ResidencyDataGridViewTextBoxColumn"
        Me.ResidencyDataGridViewTextBoxColumn.ReadOnly = True
        Me.ResidencyDataGridViewTextBoxColumn.Width = 82
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(5, 114)
        Me.Label7.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(33, 13)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "From:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(52, 114)
        Me.Label10.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(21, 13)
        Me.Label10.TabIndex = 34
        Me.Label10.Text = "To:"
        '
        'tbUDegree
        '
        Me.tbUDegree.Location = New System.Drawing.Point(220, 80)
        Me.tbUDegree.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.tbUDegree.Name = "tbUDegree"
        Me.tbUDegree.Size = New System.Drawing.Size(115, 20)
        Me.tbUDegree.TabIndex = 35
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(218, 65)
        Me.Label11.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(116, 13)
        Me.Label11.TabIndex = 36
        Me.Label11.Text = "Undergraduate Degree"
        '
        'tbResidency
        '
        Me.tbResidency.Location = New System.Drawing.Point(344, 80)
        Me.tbResidency.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.tbResidency.Name = "tbResidency"
        Me.tbResidency.Size = New System.Drawing.Size(59, 20)
        Me.tbResidency.TabIndex = 37
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(341, 65)
        Me.Label12.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(57, 13)
        Me.Label12.TabIndex = 38
        Me.Label12.Text = "Residency"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(149, 114)
        Me.Label14.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(21, 13)
        Me.Label14.TabIndex = 45
        Me.Label14.Text = "To:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(102, 114)
        Me.Label15.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(33, 13)
        Me.Label15.TabIndex = 44
        Me.Label15.Text = "From:"
        '
        'numGMATMax
        '
        Me.numGMATMax.Enabled = False
        Me.numGMATMax.Increment = New Decimal(New Integer() {20, 0, 0, 0})
        Me.numGMATMax.Location = New System.Drawing.Point(151, 128)
        Me.numGMATMax.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.numGMATMax.Maximum = New Decimal(New Integer() {800, 0, 0, 0})
        Me.numGMATMax.Minimum = New Decimal(New Integer() {200, 0, 0, 0})
        Me.numGMATMax.Name = "numGMATMax"
        Me.numGMATMax.Size = New System.Drawing.Size(36, 20)
        Me.numGMATMax.TabIndex = 42
        Me.numGMATMax.Value = New Decimal(New Integer() {800, 0, 0, 0})
        '
        'numGMATMin
        '
        Me.numGMATMin.Enabled = False
        Me.numGMATMin.Increment = New Decimal(New Integer() {20, 0, 0, 0})
        Me.numGMATMin.Location = New System.Drawing.Point(104, 128)
        Me.numGMATMin.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.numGMATMin.Maximum = New Decimal(New Integer() {800, 0, 0, 0})
        Me.numGMATMin.Minimum = New Decimal(New Integer() {200, 0, 0, 0})
        Me.numGMATMin.Name = "numGMATMin"
        Me.numGMATMin.Size = New System.Drawing.Size(36, 20)
        Me.numGMATMin.TabIndex = 41
        Me.numGMATMin.Value = New Decimal(New Integer() {200, 0, 0, 0})
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(246, 114)
        Me.Label17.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(21, 13)
        Me.Label17.TabIndex = 50
        Me.Label17.Text = "To:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(199, 114)
        Me.Label18.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(33, 13)
        Me.Label18.TabIndex = 49
        Me.Label18.Text = "From:"
        '
        'numGREMax
        '
        Me.numGREMax.Enabled = False
        Me.numGREMax.Increment = New Decimal(New Integer() {5, 0, 0, 0})
        Me.numGREMax.Location = New System.Drawing.Point(248, 128)
        Me.numGREMax.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.numGREMax.Maximum = New Decimal(New Integer() {340, 0, 0, 0})
        Me.numGREMax.Minimum = New Decimal(New Integer() {260, 0, 0, 0})
        Me.numGREMax.Name = "numGREMax"
        Me.numGREMax.Size = New System.Drawing.Size(36, 20)
        Me.numGREMax.TabIndex = 47
        Me.numGREMax.Value = New Decimal(New Integer() {340, 0, 0, 0})
        '
        'numGREMin
        '
        Me.numGREMin.Enabled = False
        Me.numGREMin.Increment = New Decimal(New Integer() {5, 0, 0, 0})
        Me.numGREMin.Location = New System.Drawing.Point(201, 128)
        Me.numGREMin.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.numGREMin.Maximum = New Decimal(New Integer() {340, 0, 0, 0})
        Me.numGREMin.Minimum = New Decimal(New Integer() {260, 0, 0, 0})
        Me.numGREMin.Name = "numGREMin"
        Me.numGREMin.Size = New System.Drawing.Size(36, 20)
        Me.numGREMin.TabIndex = 46
        Me.numGREMin.Value = New Decimal(New Integer() {260, 0, 0, 0})
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(342, 114)
        Me.Label20.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(21, 13)
        Me.Label20.TabIndex = 56
        Me.Label20.Text = "To:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(295, 114)
        Me.Label21.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(33, 13)
        Me.Label21.TabIndex = 55
        Me.Label21.Text = "From:"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(306, 103)
        Me.Label22.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(56, 13)
        Me.Label22.TabIndex = 54
        Me.Label22.Text = "UDG GPA"
        '
        'numUGPAMax
        '
        Me.numUGPAMax.DecimalPlaces = 2
        Me.numUGPAMax.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.numUGPAMax.Location = New System.Drawing.Point(344, 128)
        Me.numUGPAMax.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.numUGPAMax.Maximum = New Decimal(New Integer() {4, 0, 0, 0})
        Me.numUGPAMax.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numUGPAMax.Name = "numUGPAMax"
        Me.numUGPAMax.Size = New System.Drawing.Size(37, 20)
        Me.numUGPAMax.TabIndex = 53
        Me.numUGPAMax.Value = New Decimal(New Integer() {4, 0, 0, 0})
        '
        'numUGPAMin
        '
        Me.numUGPAMin.DecimalPlaces = 2
        Me.numUGPAMin.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.numUGPAMin.Location = New System.Drawing.Point(297, 128)
        Me.numUGPAMin.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.numUGPAMin.Maximum = New Decimal(New Integer() {4, 0, 0, 0})
        Me.numUGPAMin.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numUGPAMin.Name = "numUGPAMin"
        Me.numUGPAMin.Size = New System.Drawing.Size(38, 20)
        Me.numUGPAMin.TabIndex = 52
        Me.numUGPAMin.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'cbGMAT
        '
        Me.cbGMAT.AutoSize = True
        Me.cbGMAT.Location = New System.Drawing.Point(110, 102)
        Me.cbGMAT.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.cbGMAT.Name = "cbGMAT"
        Me.cbGMAT.Size = New System.Drawing.Size(57, 17)
        Me.cbGMAT.TabIndex = 57
        Me.cbGMAT.Text = "GMAT"
        Me.cbGMAT.UseVisualStyleBackColor = True
        '
        'cbGRE
        '
        Me.cbGRE.AutoSize = True
        Me.cbGRE.Location = New System.Drawing.Point(208, 102)
        Me.cbGRE.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.cbGRE.Name = "cbGRE"
        Me.cbGRE.Size = New System.Drawing.Size(49, 17)
        Me.cbGRE.TabIndex = 58
        Me.cbGRE.Text = "GRE"
        Me.cbGRE.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(478, 403)
        Me.Controls.Add(Me.cbGRE)
        Me.Controls.Add(Me.cbGMAT)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.numUGPAMax)
        Me.Controls.Add(Me.numUGPAMin)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.numGREMax)
        Me.Controls.Add(Me.numGREMin)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.numGMATMax)
        Me.Controls.Add(Me.numGMATMin)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.tbResidency)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.tbUDegree)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.numMaxAge)
        Me.Controls.Add(Me.numMinAge)
        Me.Controls.Add(Me.tbEthnicity)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.tbGender)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.tbTWE)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tbEmployer)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.cbProgram)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbLName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbFName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnViewApplicant)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.Name = "Main"
        Me.Text = "Applicants"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.ViewApplicantBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PROJECTS1747DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numMinAge, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numMaxAge, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numGMATMax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numGMATMin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numGREMax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numGREMin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numUGPAMax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numUGPAMin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ApplicantProfileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnViewApplicant As Button
    Friend WithEvents PROJECTS1747DataSet As PROJECTS1747DataSet
    Friend WithEvents ViewApplicantBindingSource As BindingSource
    Friend WithEvents ViewApplicantTableAdapter As PROJECTS1747DataSetTableAdapters.viewApplicantTableAdapter
    Friend WithEvents Label1 As Label
    Friend WithEvents tbFName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tbLName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cbProgram As ComboBox
    Friend WithEvents btnClear As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents tbEmployer As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents tbTWE As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents tbGender As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents tbEthnicity As TextBox
    Friend WithEvents numMinAge As NumericUpDown
    Friend WithEvents numMaxAge As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProgramDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ApplicationDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MissingStatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ReceivedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NotesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VerbalQuantitativeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GMATDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GMATVerbalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GMATVerbalDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents GMATQuantitativeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GMATQuantitativeDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents AWADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GREDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GREVerbalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GREVerbalDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents GREQuantitativeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GREQuantitativeDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents WRDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TOEFLDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TimeWithEmployerDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CurrentEmployerDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UndergraduateGPADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GraduateGPADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UndergraduateInstitutionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UndergraduateDegreeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UndergraduateMajorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GraduateInstitutionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GraduateDegreeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GraduateMajorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GenderDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EthnicityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AgeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PostalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CountryDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ResidencyDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label7 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents tbUDegree As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents tbResidency As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents numGMATMax As NumericUpDown
    Friend WithEvents numGMATMin As NumericUpDown
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents numGREMax As NumericUpDown
    Friend WithEvents numGREMin As NumericUpDown
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents numUGPAMax As NumericUpDown
    Friend WithEvents numUGPAMin As NumericUpDown
    Friend WithEvents cbGMAT As CheckBox
    Friend WithEvents cbGRE As CheckBox
End Class
