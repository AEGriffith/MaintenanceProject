<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GAProfile
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.ViewRequestedGABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PROJECTS1747DataSet7 = New MaintenanceProject.PROJECTS1747DataSet7()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.tbOther = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.tbStatisticalPackages = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ViewRequestedGATableAdapter = New MaintenanceProject.PROJECTS1747DataSet7TableAdapters.viewRequestedGATableAdapter()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.PROJECTS1747DataSet11 = New MaintenanceProject.PROJECTS1747DataSet11()
        Me.ViewGAsRequestedByBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ViewGAsRequestedByTableAdapter = New MaintenanceProject.PROJECTS1747DataSet11TableAdapters.viewGAsRequestedByTableAdapter()
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HoursDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReasonForRequestDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DutiesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InternetDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WordProcessingDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SpreadsheetDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatabaseDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatisticalPackagesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WritingDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EditingDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EnglishSpeakingDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OtherCommunicationSkillsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CommentsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GAFormIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StudentIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ViewRequestedGABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PROJECTS1747DataSet7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PROJECTS1747DataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ViewGAsRequestedByBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TextBox7)
        Me.GroupBox2.Controls.Add(Me.TextBox6)
        Me.GroupBox2.Controls.Add(Me.TextBox5)
        Me.GroupBox2.Controls.Add(Me.tbOther)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.Label28)
        Me.GroupBox2.Controls.Add(Me.Label30)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(706, 96)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(655, 457)
        Me.GroupBox2.TabIndex = 43
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Communication Skills"
        '
        'TextBox7
        '
        Me.TextBox7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ViewRequestedGABindingSource, "English Speaking", True))
        Me.TextBox7.Location = New System.Drawing.Point(259, 167)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.ReadOnly = True
        Me.TextBox7.Size = New System.Drawing.Size(71, 41)
        Me.TextBox7.TabIndex = 55
        '
        'ViewRequestedGABindingSource
        '
        Me.ViewRequestedGABindingSource.DataMember = "viewRequestedGA"
        Me.ViewRequestedGABindingSource.DataSource = Me.PROJECTS1747DataSet7
        '
        'PROJECTS1747DataSet7
        '
        Me.PROJECTS1747DataSet7.DataSetName = "PROJECTS1747DataSet7"
        Me.PROJECTS1747DataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TextBox6
        '
        Me.TextBox6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ViewRequestedGABindingSource, "Editing", True))
        Me.TextBox6.Location = New System.Drawing.Point(259, 101)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.ReadOnly = True
        Me.TextBox6.Size = New System.Drawing.Size(71, 41)
        Me.TextBox6.TabIndex = 54
        '
        'TextBox5
        '
        Me.TextBox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ViewRequestedGABindingSource, "Writing", True))
        Me.TextBox5.Location = New System.Drawing.Point(259, 38)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.ReadOnly = True
        Me.TextBox5.Size = New System.Drawing.Size(71, 41)
        Me.TextBox5.TabIndex = 53
        '
        'tbOther
        '
        Me.tbOther.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ViewRequestedGABindingSource, "Other Communication", True))
        Me.tbOther.Location = New System.Drawing.Point(18, 282)
        Me.tbOther.Multiline = True
        Me.tbOther.Name = "tbOther"
        Me.tbOther.ReadOnly = True
        Me.tbOther.Size = New System.Drawing.Size(621, 131)
        Me.tbOther.TabIndex = 12
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.1!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(12, 227)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(413, 32)
        Me.Label19.TabIndex = 12
        Me.Label19.Text = "Other Communication (specify):"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.1!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(12, 167)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(237, 32)
        Me.Label20.TabIndex = 15
        Me.Label20.Text = "English Speaking"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.1!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(12, 107)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(104, 32)
        Me.Label28.TabIndex = 7
        Me.Label28.Text = "Editing"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(12, 43)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(110, 36)
        Me.Label30.TabIndex = 1
        Me.Label30.Text = "Writing"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.tbStatisticalPackages)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(20, 96)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(655, 457)
        Me.GroupBox1.TabIndex = 42
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Computer Skills"
        '
        'TextBox4
        '
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ViewRequestedGABindingSource, "Database", True))
        Me.TextBox4.Location = New System.Drawing.Point(242, 227)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(71, 41)
        Me.TextBox4.TabIndex = 38
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ViewRequestedGABindingSource, "Spreadsheets", True))
        Me.TextBox3.Location = New System.Drawing.Point(242, 167)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(71, 41)
        Me.TextBox3.TabIndex = 37
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ViewRequestedGABindingSource, "Word Processing", True))
        Me.TextBox2.Location = New System.Drawing.Point(242, 101)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(71, 41)
        Me.TextBox2.TabIndex = 36
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ViewRequestedGABindingSource, "Internet", True))
        Me.TextBox1.Location = New System.Drawing.Point(242, 38)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(71, 41)
        Me.TextBox1.TabIndex = 35
        '
        'tbStatisticalPackages
        '
        Me.tbStatisticalPackages.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ViewRequestedGABindingSource, "Statistical Packages", True))
        Me.tbStatisticalPackages.Location = New System.Drawing.Point(12, 336)
        Me.tbStatisticalPackages.Multiline = True
        Me.tbStatisticalPackages.Name = "tbStatisticalPackages"
        Me.tbStatisticalPackages.ReadOnly = True
        Me.tbStatisticalPackages.Size = New System.Drawing.Size(621, 77)
        Me.tbStatisticalPackages.TabIndex = 12
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.1!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(6, 287)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(279, 32)
        Me.Label18.TabIndex = 12
        Me.Label18.Text = "Statistical Packages:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.1!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(6, 167)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(177, 32)
        Me.Label17.TabIndex = 15
        Me.Label17.Text = "Spreadsheet"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.1!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(6, 227)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(137, 32)
        Me.Label16.TabIndex = 14
        Me.Label16.Text = "Database"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.1!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(6, 107)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(230, 32)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "Word Processing"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 36)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Internet"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FirstNameDataGridViewTextBoxColumn, Me.LastNameDataGridViewTextBoxColumn, Me.HoursDataGridViewTextBoxColumn, Me.ReasonForRequestDataGridViewTextBoxColumn, Me.DutiesDataGridViewTextBoxColumn, Me.InternetDataGridViewTextBoxColumn, Me.WordProcessingDataGridViewTextBoxColumn, Me.SpreadsheetDataGridViewTextBoxColumn, Me.DatabaseDataGridViewTextBoxColumn, Me.StatisticalPackagesDataGridViewTextBoxColumn, Me.WritingDataGridViewTextBoxColumn, Me.EditingDataGridViewTextBoxColumn, Me.EnglishSpeakingDataGridViewTextBoxColumn, Me.OtherCommunicationSkillsDataGridViewTextBoxColumn, Me.CommentsDataGridViewTextBoxColumn, Me.GAFormIDDataGridViewTextBoxColumn, Me.StudentIDDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ViewGAsRequestedByBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 674)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 40
        Me.DataGridView1.Size = New System.Drawing.Size(1368, 286)
        Me.DataGridView1.TabIndex = 44
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 639)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(201, 32)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "Requested By:"
        '
        'ViewRequestedGATableAdapter
        '
        Me.ViewRequestedGATableAdapter.ClearBeforeFill = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(718, 566)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(294, 32)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "Total Assigned Hours:"
        '
        'TextBox8
        '
        Me.TextBox8.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ViewRequestedGABindingSource, "Total Hours Assigned", True))
        Me.TextBox8.Location = New System.Drawing.Point(1018, 563)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.ReadOnly = True
        Me.TextBox8.Size = New System.Drawing.Size(71, 38)
        Me.TextBox8.TabIndex = 56
        '
        'PROJECTS1747DataSet11
        '
        Me.PROJECTS1747DataSet11.DataSetName = "PROJECTS1747DataSet11"
        Me.PROJECTS1747DataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ViewGAsRequestedByBindingSource
        '
        Me.ViewGAsRequestedByBindingSource.DataMember = "viewGAsRequestedBy"
        Me.ViewGAsRequestedByBindingSource.DataSource = Me.PROJECTS1747DataSet11
        '
        'ViewGAsRequestedByTableAdapter
        '
        Me.ViewGAsRequestedByTableAdapter.ClearBeforeFill = True
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
        'HoursDataGridViewTextBoxColumn
        '
        Me.HoursDataGridViewTextBoxColumn.DataPropertyName = "Hours"
        Me.HoursDataGridViewTextBoxColumn.HeaderText = "Hours"
        Me.HoursDataGridViewTextBoxColumn.Name = "HoursDataGridViewTextBoxColumn"
        Me.HoursDataGridViewTextBoxColumn.ReadOnly = True
        Me.HoursDataGridViewTextBoxColumn.Width = 144
        '
        'ReasonForRequestDataGridViewTextBoxColumn
        '
        Me.ReasonForRequestDataGridViewTextBoxColumn.DataPropertyName = "Reason for Request"
        Me.ReasonForRequestDataGridViewTextBoxColumn.HeaderText = "Reason for Request"
        Me.ReasonForRequestDataGridViewTextBoxColumn.Name = "ReasonForRequestDataGridViewTextBoxColumn"
        Me.ReasonForRequestDataGridViewTextBoxColumn.ReadOnly = True
        Me.ReasonForRequestDataGridViewTextBoxColumn.Width = 197
        '
        'DutiesDataGridViewTextBoxColumn
        '
        Me.DutiesDataGridViewTextBoxColumn.DataPropertyName = "Duties"
        Me.DutiesDataGridViewTextBoxColumn.HeaderText = "Duties"
        Me.DutiesDataGridViewTextBoxColumn.Name = "DutiesDataGridViewTextBoxColumn"
        Me.DutiesDataGridViewTextBoxColumn.ReadOnly = True
        Me.DutiesDataGridViewTextBoxColumn.Width = 150
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
        'SpreadsheetDataGridViewTextBoxColumn
        '
        Me.SpreadsheetDataGridViewTextBoxColumn.DataPropertyName = "Spreadsheet"
        Me.SpreadsheetDataGridViewTextBoxColumn.HeaderText = "Spreadsheet"
        Me.SpreadsheetDataGridViewTextBoxColumn.Name = "SpreadsheetDataGridViewTextBoxColumn"
        Me.SpreadsheetDataGridViewTextBoxColumn.ReadOnly = True
        Me.SpreadsheetDataGridViewTextBoxColumn.Width = 231
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
        'OtherCommunicationSkillsDataGridViewTextBoxColumn
        '
        Me.OtherCommunicationSkillsDataGridViewTextBoxColumn.DataPropertyName = "Other Communication Skills"
        Me.OtherCommunicationSkillsDataGridViewTextBoxColumn.HeaderText = "Other Communication Skills"
        Me.OtherCommunicationSkillsDataGridViewTextBoxColumn.Name = "OtherCommunicationSkillsDataGridViewTextBoxColumn"
        Me.OtherCommunicationSkillsDataGridViewTextBoxColumn.ReadOnly = True
        Me.OtherCommunicationSkillsDataGridViewTextBoxColumn.Width = 322
        '
        'CommentsDataGridViewTextBoxColumn
        '
        Me.CommentsDataGridViewTextBoxColumn.DataPropertyName = "Comments"
        Me.CommentsDataGridViewTextBoxColumn.HeaderText = "Comments"
        Me.CommentsDataGridViewTextBoxColumn.Name = "CommentsDataGridViewTextBoxColumn"
        Me.CommentsDataGridViewTextBoxColumn.ReadOnly = True
        Me.CommentsDataGridViewTextBoxColumn.Width = 205
        '
        'GAFormIDDataGridViewTextBoxColumn
        '
        Me.GAFormIDDataGridViewTextBoxColumn.DataPropertyName = "GAForm_ID"
        Me.GAFormIDDataGridViewTextBoxColumn.HeaderText = "GAForm_ID"
        Me.GAFormIDDataGridViewTextBoxColumn.Name = "GAFormIDDataGridViewTextBoxColumn"
        Me.GAFormIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.GAFormIDDataGridViewTextBoxColumn.Width = 217
        '
        'StudentIDDataGridViewTextBoxColumn
        '
        Me.StudentIDDataGridViewTextBoxColumn.DataPropertyName = "Student_ID"
        Me.StudentIDDataGridViewTextBoxColumn.HeaderText = "Student_ID"
        Me.StudentIDDataGridViewTextBoxColumn.Name = "StudentIDDataGridViewTextBoxColumn"
        Me.StudentIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.StudentIDDataGridViewTextBoxColumn.Width = 210
        '
        'GAProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1392, 1066)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "GAProfile"
        Me.Text = "GAProfile"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.ViewRequestedGABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PROJECTS1747DataSet7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PROJECTS1747DataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ViewGAsRequestedByBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents tbOther As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents tbStatisticalPackages As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents PROJECTS1747DataSet7 As PROJECTS1747DataSet7
    Friend WithEvents ViewRequestedGABindingSource As BindingSource
    Friend WithEvents ViewRequestedGATableAdapter As PROJECTS1747DataSet7TableAdapters.viewRequestedGATableAdapter
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents PROJECTS1747DataSet11 As PROJECTS1747DataSet11
    Friend WithEvents ViewGAsRequestedByBindingSource As BindingSource
    Friend WithEvents ViewGAsRequestedByTableAdapter As PROJECTS1747DataSet11TableAdapters.viewGAsRequestedByTableAdapter
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HoursDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ReasonForRequestDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DutiesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents InternetDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents WordProcessingDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SpreadsheetDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DatabaseDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StatisticalPackagesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents WritingDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EditingDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EnglishSpeakingDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OtherCommunicationSkillsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CommentsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GAFormIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StudentIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
