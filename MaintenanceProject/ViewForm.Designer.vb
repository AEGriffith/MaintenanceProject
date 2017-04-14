<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewForm
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
        Me.Label32 = New System.Windows.Forms.Label()
        Me.tbOther2 = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.tbDuties = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.tbOther = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tbStatisticalPackages = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.numHours = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.numGAs = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbEmail = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbRequestReason = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.PROJECTS1747DataSet5 = New MaintenanceProject.PROJECTS1747DataSet5()
        Me.ViewRequestedGABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ViewRequestedGATableAdapter = New MaintenanceProject.PROJECTS1747DataSet5TableAdapters.viewRequestedGATableAdapter()
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HoursRequestedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalHoursAssignedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InternetDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WordProcessingDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SpreadsheetsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatabaseDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatisticalPackagesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WritingDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EditingDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EnglishSpeakingDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OtherCommunicationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FormDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.GARequestBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GA_RequestTableAdapter = New MaintenanceProject.PROJECTS1747DataSet5TableAdapters.GA_RequestTableAdapter()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.numHours, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numGAs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PROJECTS1747DataSet5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ViewRequestedGABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GARequestBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(26, 712)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(215, 32)
        Me.Label32.TabIndex = 51
        Me.Label32.Text = "Requested GAs"
        '
        'tbOther2
        '
        Me.tbOther2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GARequestBindingSource, "Other_Comments", True))
        Me.tbOther2.Location = New System.Drawing.Point(1226, 614)
        Me.tbOther2.Multiline = True
        Me.tbOther2.Name = "tbOther2"
        Me.tbOther2.ReadOnly = True
        Me.tbOther2.Size = New System.Drawing.Size(621, 112)
        Me.tbOther2.TabIndex = 40
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.1!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(1220, 579)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(237, 32)
        Me.Label23.TabIndex = 42
        Me.Label23.Text = "Other Comments:"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(497, 579)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(277, 32)
        Me.Label22.TabIndex = 49
        Me.Label22.Text = "Description of Duties"
        '
        'tbDuties
        '
        Me.tbDuties.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GARequestBindingSource, "Job_Description", True))
        Me.tbDuties.Location = New System.Drawing.Point(497, 614)
        Me.tbDuties.Multiline = True
        Me.tbDuties.Name = "tbDuties"
        Me.tbDuties.ReadOnly = True
        Me.tbDuties.Size = New System.Drawing.Size(625, 112)
        Me.tbDuties.TabIndex = 48
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(1713, 1065)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(150, 67)
        Me.btnCancel.TabIndex = 43
        Me.btnCancel.Text = "Close"
        Me.btnCancel.UseVisualStyleBackColor = True
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
        Me.GroupBox2.Location = New System.Drawing.Point(1208, 115)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(655, 457)
        Me.GroupBox2.TabIndex = 41
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Communication Skills"
        '
        'tbOther
        '
        Me.tbOther.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GARequestBindingSource, "Other_Communication_Skills", True))
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
        Me.GroupBox1.Location = New System.Drawing.Point(489, 115)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(655, 457)
        Me.GroupBox1.TabIndex = 39
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Computer Skills"
        '
        'tbStatisticalPackages
        '
        Me.tbStatisticalPackages.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GARequestBindingSource, "Statistical_Packages", True))
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
        'numHours
        '
        Me.numHours.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.GARequestBindingSource, "Weekly_Hours_Needed", True))
        Me.numHours.Location = New System.Drawing.Point(296, 594)
        Me.numHours.Name = "numHours"
        Me.numHours.ReadOnly = True
        Me.numHours.Size = New System.Drawing.Size(120, 38)
        Me.numHours.TabIndex = 38
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(26, 596)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(190, 32)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "Weekly Hours"
        '
        'numGAs
        '
        Me.numGAs.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.GARequestBindingSource, "Total_GAs_Needed", True))
        Me.numGAs.Location = New System.Drawing.Point(296, 508)
        Me.numGAs.Name = "numGAs"
        Me.numGAs.ReadOnly = True
        Me.numGAs.Size = New System.Drawing.Size(120, 38)
        Me.numGAs.TabIndex = 36
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(26, 510)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(208, 32)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "Number of GAs"
        '
        'tbEmail
        '
        Me.tbEmail.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GARequestBindingSource, "Email", True))
        Me.tbEmail.Location = New System.Drawing.Point(119, 166)
        Me.tbEmail.Name = "tbEmail"
        Me.tbEmail.ReadOnly = True
        Me.tbEmail.Size = New System.Drawing.Size(297, 38)
        Me.tbEmail.TabIndex = 34
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 169)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 32)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Email"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 243)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(274, 32)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Reason for Request:"
        '
        'tbRequestReason
        '
        Me.tbRequestReason.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GARequestBindingSource, "Requesting_Reasons", True))
        Me.tbRequestReason.Location = New System.Drawing.Point(26, 278)
        Me.tbRequestReason.Multiline = True
        Me.tbRequestReason.Name = "tbRequestReason"
        Me.tbRequestReason.ReadOnly = True
        Me.tbRequestReason.Size = New System.Drawing.Size(390, 197)
        Me.tbRequestReason.TabIndex = 31
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(26, 95)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(90, 32)
        Me.lblName.TabIndex = 30
        Me.lblName.Text = "Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(497, 46)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Graduate Assitant Request"
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GARequestBindingSource, "Internet_Skills", True))
        Me.TextBox1.Location = New System.Drawing.Point(242, 38)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(71, 41)
        Me.TextBox1.TabIndex = 35
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GARequestBindingSource, "Word_Processing_Skills", True))
        Me.TextBox2.Location = New System.Drawing.Point(242, 101)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(71, 41)
        Me.TextBox2.TabIndex = 36
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GARequestBindingSource, "Spreadsheets", True))
        Me.TextBox3.Location = New System.Drawing.Point(242, 167)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(71, 41)
        Me.TextBox3.TabIndex = 37
        '
        'TextBox4
        '
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GARequestBindingSource, "Database_Skills", True))
        Me.TextBox4.Location = New System.Drawing.Point(242, 227)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(71, 41)
        Me.TextBox4.TabIndex = 38
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FirstNameDataGridViewTextBoxColumn, Me.LastNameDataGridViewTextBoxColumn, Me.HoursRequestedDataGridViewTextBoxColumn, Me.TotalHoursAssignedDataGridViewTextBoxColumn, Me.InternetDataGridViewTextBoxColumn, Me.WordProcessingDataGridViewTextBoxColumn, Me.SpreadsheetsDataGridViewTextBoxColumn, Me.DatabaseDataGridViewTextBoxColumn, Me.StatisticalPackagesDataGridViewTextBoxColumn, Me.WritingDataGridViewTextBoxColumn, Me.EditingDataGridViewTextBoxColumn, Me.EnglishSpeakingDataGridViewTextBoxColumn, Me.OtherCommunicationDataGridViewTextBoxColumn, Me.FormDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ViewRequestedGABindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(20, 747)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 40
        Me.DataGridView1.Size = New System.Drawing.Size(1841, 312)
        Me.DataGridView1.TabIndex = 52
        '
        'PROJECTS1747DataSet5
        '
        Me.PROJECTS1747DataSet5.DataSetName = "PROJECTS1747DataSet5"
        Me.PROJECTS1747DataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ViewRequestedGABindingSource
        '
        Me.ViewRequestedGABindingSource.DataMember = "viewRequestedGA"
        Me.ViewRequestedGABindingSource.DataSource = Me.PROJECTS1747DataSet5
        '
        'ViewRequestedGATableAdapter
        '
        Me.ViewRequestedGATableAdapter.ClearBeforeFill = True
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
        'HoursRequestedDataGridViewTextBoxColumn
        '
        Me.HoursRequestedDataGridViewTextBoxColumn.DataPropertyName = "Hours Requested"
        Me.HoursRequestedDataGridViewTextBoxColumn.HeaderText = "Hours Requested"
        Me.HoursRequestedDataGridViewTextBoxColumn.Name = "HoursRequestedDataGridViewTextBoxColumn"
        Me.HoursRequestedDataGridViewTextBoxColumn.ReadOnly = True
        Me.HoursRequestedDataGridViewTextBoxColumn.Width = 265
        '
        'TotalHoursAssignedDataGridViewTextBoxColumn
        '
        Me.TotalHoursAssignedDataGridViewTextBoxColumn.DataPropertyName = "Total Hours Assigned"
        Me.TotalHoursAssignedDataGridViewTextBoxColumn.HeaderText = "Total Hours Assigned"
        Me.TotalHoursAssignedDataGridViewTextBoxColumn.Name = "TotalHoursAssignedDataGridViewTextBoxColumn"
        Me.TotalHoursAssignedDataGridViewTextBoxColumn.ReadOnly = True
        Me.TotalHoursAssignedDataGridViewTextBoxColumn.Width = 205
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
        'FormDataGridViewTextBoxColumn
        '
        Me.FormDataGridViewTextBoxColumn.DataPropertyName = "Form"
        Me.FormDataGridViewTextBoxColumn.HeaderText = "Form"
        Me.FormDataGridViewTextBoxColumn.Name = "FormDataGridViewTextBoxColumn"
        Me.FormDataGridViewTextBoxColumn.ReadOnly = True
        Me.FormDataGridViewTextBoxColumn.Width = 134
        '
        'TextBox5
        '
        Me.TextBox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GARequestBindingSource, "Writing_Skills", True))
        Me.TextBox5.Location = New System.Drawing.Point(259, 38)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.ReadOnly = True
        Me.TextBox5.Size = New System.Drawing.Size(71, 41)
        Me.TextBox5.TabIndex = 53
        '
        'TextBox6
        '
        Me.TextBox6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GARequestBindingSource, "Editing_Skills", True))
        Me.TextBox6.Location = New System.Drawing.Point(259, 101)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.ReadOnly = True
        Me.TextBox6.Size = New System.Drawing.Size(71, 41)
        Me.TextBox6.TabIndex = 54
        '
        'TextBox7
        '
        Me.TextBox7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GARequestBindingSource, "English_Speaking_Skills", True))
        Me.TextBox7.Location = New System.Drawing.Point(259, 167)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.ReadOnly = True
        Me.TextBox7.Size = New System.Drawing.Size(71, 41)
        Me.TextBox7.TabIndex = 55
        '
        'GARequestBindingSource
        '
        Me.GARequestBindingSource.DataMember = "GA_Request"
        Me.GARequestBindingSource.DataSource = Me.PROJECTS1747DataSet5
        '
        'GA_RequestTableAdapter
        '
        Me.GA_RequestTableAdapter.ClearBeforeFill = True
        '
        'ViewForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1902, 1148)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.tbOther2)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.tbDuties)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.numHours)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.numGAs)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tbEmail)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbRequestReason)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ViewForm"
        Me.Text = "ViewForm"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.numHours, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numGAs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PROJECTS1747DataSet5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ViewRequestedGABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GARequestBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label32 As Label
    Friend WithEvents tbOther2 As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents tbDuties As TextBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents GroupBox2 As GroupBox
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
    Friend WithEvents numHours As NumericUpDown
    Friend WithEvents Label6 As Label
    Friend WithEvents numGAs As NumericUpDown
    Friend WithEvents Label5 As Label
    Friend WithEvents tbEmail As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tbRequestReason As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents PROJECTS1747DataSet5 As PROJECTS1747DataSet5
    Friend WithEvents ViewRequestedGABindingSource As BindingSource
    Friend WithEvents ViewRequestedGATableAdapter As PROJECTS1747DataSet5TableAdapters.viewRequestedGATableAdapter
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HoursRequestedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalHoursAssignedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents InternetDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents WordProcessingDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SpreadsheetsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DatabaseDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StatisticalPackagesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents WritingDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EditingDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EnglishSpeakingDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OtherCommunicationDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FormDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GARequestBindingSource As BindingSource
    Friend WithEvents GA_RequestTableAdapter As PROJECTS1747DataSet5TableAdapters.GA_RequestTableAdapter
End Class
