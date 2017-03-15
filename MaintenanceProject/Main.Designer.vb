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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ApplicantProfileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProgramDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ConcentrationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApplicationDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ResidencyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApplicantViewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PROJECTS1747DataSet8 = New MaintenanceProject.PROJECTS1747DataSet8()
        Me.ViewApplicationTableBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PROJECTS1747DataSet3BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PROJECTS1747DataSet3 = New MaintenanceProject.PROJECTS1747DataSet3()
        Me.ViewApplicationTableBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PROJECTS1747DataSet2 = New MaintenanceProject.PROJECTS1747DataSet2()
        Me.ApplicationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PROJECTS1747DataSet = New MaintenanceProject.PROJECTS1747DataSet()
        Me.cbFilter1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbFilter2 = New System.Windows.Forms.ComboBox()
        Me.tbFilter1 = New System.Windows.Forms.TextBox()
        Me.tbFilter2 = New System.Windows.Forms.TextBox()
        Me.ApplicationTableAdapter = New MaintenanceProject.PROJECTS1747DataSetTableAdapters.ApplicationTableAdapter()
        Me.ProjectS1730DataSet1 = New MaintenanceProject.PROJECTS1730DataSet()
        Me.btnViewApplicant = New System.Windows.Forms.Button()
        Me.PROJECTS1747DataSet1 = New MaintenanceProject.PROJECTS1747DataSet1()
        Me.PROJECTS1747DataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ApplicationBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ApplicationTableAdapter1 = New MaintenanceProject.PROJECTS1747DataSet1TableAdapters.ApplicationTableAdapter()
        Me.ViewApplicationTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_ApplicationTableTableAdapter = New MaintenanceProject.PROJECTS1747DataSet1TableAdapters.View_ApplicationTableTableAdapter()
        Me.View_ApplicationTableTableAdapter1 = New MaintenanceProject.PROJECTS1747DataSet2TableAdapters.View_ApplicationTableTableAdapter()
        Me.View_ApplicationTableTableAdapter2 = New MaintenanceProject.PROJECTS1747DataSet3TableAdapters.View_ApplicationTableTableAdapter()
        Me.ApplicationViewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ApplicationViewTableAdapter = New MaintenanceProject.PROJECTS1747DataSet8TableAdapters.ApplicationViewTableAdapter()
        Me.ApplicantViewTableAdapter = New MaintenanceProject.PROJECTS1747DataSet8TableAdapters.ApplicantViewTableAdapter()
        Me.ApplicationViewBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ApplicantViewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PROJECTS1747DataSet8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ViewApplicationTableBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PROJECTS1747DataSet3BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PROJECTS1747DataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ViewApplicationTableBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PROJECTS1747DataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ApplicationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PROJECTS1747DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProjectS1730DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PROJECTS1747DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PROJECTS1747DataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ApplicationBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ViewApplicationTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ApplicationViewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ApplicationViewBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(40, 40)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(2, 1, 0, 1)
        Me.MenuStrip1.Size = New System.Drawing.Size(434, 24)
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
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.DataGridView1)
        Me.Panel2.Location = New System.Drawing.Point(0, 108)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(429, 231)
        Me.Panel2.TabIndex = 3
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.FirstNameDataGridViewTextBoxColumn, Me.LastNameDataGridViewTextBoxColumn, Me.ProgramDataGridViewTextBoxColumn, Me.ConcentrationDataGridViewTextBoxColumn, Me.ApplicationDateDataGridViewTextBoxColumn, Me.ResidencyDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ApplicantViewBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(0, 1)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 40
        Me.DataGridView1.Size = New System.Drawing.Size(428, 230)
        Me.DataGridView1.TabIndex = 0
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
        'ApplicationDateDataGridViewTextBoxColumn
        '
        Me.ApplicationDateDataGridViewTextBoxColumn.DataPropertyName = "Application Date"
        Me.ApplicationDateDataGridViewTextBoxColumn.HeaderText = "Application Date"
        Me.ApplicationDateDataGridViewTextBoxColumn.Name = "ApplicationDateDataGridViewTextBoxColumn"
        Me.ApplicationDateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ResidencyDataGridViewTextBoxColumn
        '
        Me.ResidencyDataGridViewTextBoxColumn.DataPropertyName = "Residency"
        Me.ResidencyDataGridViewTextBoxColumn.HeaderText = "Residency"
        Me.ResidencyDataGridViewTextBoxColumn.Name = "ResidencyDataGridViewTextBoxColumn"
        Me.ResidencyDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ApplicantViewBindingSource
        '
        Me.ApplicantViewBindingSource.DataMember = "ApplicantView"
        Me.ApplicantViewBindingSource.DataSource = Me.PROJECTS1747DataSet8
        '
        'PROJECTS1747DataSet8
        '
        Me.PROJECTS1747DataSet8.DataSetName = "PROJECTS1747DataSet8"
        Me.PROJECTS1747DataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ViewApplicationTableBindingSource2
        '
        Me.ViewApplicationTableBindingSource2.DataMember = "View_ApplicationTable"
        Me.ViewApplicationTableBindingSource2.DataSource = Me.PROJECTS1747DataSet3BindingSource
        '
        'PROJECTS1747DataSet3BindingSource
        '
        Me.PROJECTS1747DataSet3BindingSource.DataSource = Me.PROJECTS1747DataSet3
        Me.PROJECTS1747DataSet3BindingSource.Position = 0
        '
        'PROJECTS1747DataSet3
        '
        Me.PROJECTS1747DataSet3.DataSetName = "PROJECTS1747DataSet3"
        Me.PROJECTS1747DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ViewApplicationTableBindingSource1
        '
        Me.ViewApplicationTableBindingSource1.DataMember = "View_ApplicationTable"
        Me.ViewApplicationTableBindingSource1.DataSource = Me.PROJECTS1747DataSet2
        '
        'PROJECTS1747DataSet2
        '
        Me.PROJECTS1747DataSet2.DataSetName = "PROJECTS1747DataSet2"
        Me.PROJECTS1747DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ApplicationBindingSource
        '
        Me.ApplicationBindingSource.DataMember = "Application"
        Me.ApplicationBindingSource.DataSource = Me.PROJECTS1747DataSet
        '
        'PROJECTS1747DataSet
        '
        Me.PROJECTS1747DataSet.DataSetName = "PROJECTS1747DataSet"
        Me.PROJECTS1747DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cbFilter1
        '
        Me.cbFilter1.FormattingEnabled = True
        Me.cbFilter1.Items.AddRange(New Object() {"First_Name", "Last_Name", "App_Date", "Decision", "GA", "Eval_I20", "Trsc", "Letters_Frm", "Fee", "U_GPA", "Toefl", "Gender", "Ethnicity", "TWE", "Current_Employer", "U_Inst", "U_Deg", "UDRG_Major", "GRAD", "G_Degree", "ELAC_Reg", "GMAT", "Verb", "Quan", "WR", "UA_Email", "Non_UA_Email", "Phone", "Address", "First_Name", "Last_Name", "App_Date", "Decision", "GA", "Eval_I20", "Trsc", "Letters_Frm", "Fee", "U_GPA", "Toefl", "Gender", "Ethnicity", "TWE", "Current_Employer", "U_Inst", "U_Deg", "UDRG_Major", "GRAD", "G_Degree", "ELAC_Reg", "GMAT", "Verb", "Quan", "WR", "UA_Email", "Non_UA_Email", "Phone", "Address"})
        Me.cbFilter1.Location = New System.Drawing.Point(70, 38)
        Me.cbFilter1.Name = "cbFilter1"
        Me.cbFilter1.Size = New System.Drawing.Size(93, 21)
        Me.cbFilter1.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Filter By: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Filter By:"
        '
        'cbFilter2
        '
        Me.cbFilter2.Enabled = False
        Me.cbFilter2.FormattingEnabled = True
        Me.cbFilter2.Items.AddRange(New Object() {"First_Name", "Last_Name", "App_Date", "Decision", "GA", "Eval_I20", "Trsc", "Letters_Frm", "Fee", "U_GPA", "Toefl", "Gender", "Ethnicity", "TWE", "Current_Employer", "U_Inst", "U_Deg", "UDRG_Major", "GRAD", "G_Degree", "ELAC_Reg", "GMAT", "Verb", "Quan", "WR", "UA_Email", "Non_UA_Email", "Phone", "Address", "First_Name", "Last_Name", "App_Date", "Decision", "GA", "Eval_I20", "Trsc", "Letters_Frm", "Fee", "U_GPA", "Toefl", "Gender", "Ethnicity", "TWE", "Current_Employer", "U_Inst", "U_Deg", "UDRG_Major", "GRAD", "G_Degree", "ELAC_Reg", "GMAT", "Verb", "Quan", "WR", "UA_Email", "Non_UA_Email", "Phone", "Address"})
        Me.cbFilter2.Location = New System.Drawing.Point(70, 60)
        Me.cbFilter2.Name = "cbFilter2"
        Me.cbFilter2.Size = New System.Drawing.Size(93, 21)
        Me.cbFilter2.TabIndex = 7
        '
        'tbFilter1
        '
        Me.tbFilter1.Enabled = False
        Me.tbFilter1.Location = New System.Drawing.Point(169, 39)
        Me.tbFilter1.Name = "tbFilter1"
        Me.tbFilter1.Size = New System.Drawing.Size(110, 20)
        Me.tbFilter1.TabIndex = 8
        '
        'tbFilter2
        '
        Me.tbFilter2.Enabled = False
        Me.tbFilter2.Location = New System.Drawing.Point(169, 60)
        Me.tbFilter2.Name = "tbFilter2"
        Me.tbFilter2.Size = New System.Drawing.Size(110, 20)
        Me.tbFilter2.TabIndex = 9
        '
        'ApplicationTableAdapter
        '
        Me.ApplicationTableAdapter.ClearBeforeFill = True
        '
        'ProjectS1730DataSet1
        '
        Me.ProjectS1730DataSet1.DataSetName = "PROJECTS1730DataSet"
        Me.ProjectS1730DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnViewApplicant
        '
        Me.btnViewApplicant.Location = New System.Drawing.Point(316, 34)
        Me.btnViewApplicant.Margin = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Me.btnViewApplicant.Name = "btnViewApplicant"
        Me.btnViewApplicant.Size = New System.Drawing.Size(100, 58)
        Me.btnViewApplicant.TabIndex = 10
        Me.btnViewApplicant.Text = "View Profile"
        Me.btnViewApplicant.UseVisualStyleBackColor = True
        '
        'PROJECTS1747DataSet1
        '
        Me.PROJECTS1747DataSet1.DataSetName = "PROJECTS1747DataSet1"
        Me.PROJECTS1747DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PROJECTS1747DataSet1BindingSource
        '
        Me.PROJECTS1747DataSet1BindingSource.DataSource = Me.PROJECTS1747DataSet1
        Me.PROJECTS1747DataSet1BindingSource.Position = 0
        '
        'ApplicationBindingSource1
        '
        Me.ApplicationBindingSource1.DataMember = "Application"
        Me.ApplicationBindingSource1.DataSource = Me.PROJECTS1747DataSet1BindingSource
        '
        'ApplicationTableAdapter1
        '
        Me.ApplicationTableAdapter1.ClearBeforeFill = True
        '
        'ViewApplicationTableBindingSource
        '
        Me.ViewApplicationTableBindingSource.DataMember = "View_ApplicationTable"
        Me.ViewApplicationTableBindingSource.DataSource = Me.PROJECTS1747DataSet1BindingSource
        '
        'View_ApplicationTableTableAdapter
        '
        Me.View_ApplicationTableTableAdapter.ClearBeforeFill = True
        '
        'View_ApplicationTableTableAdapter1
        '
        Me.View_ApplicationTableTableAdapter1.ClearBeforeFill = True
        '
        'View_ApplicationTableTableAdapter2
        '
        Me.View_ApplicationTableTableAdapter2.ClearBeforeFill = True
        '
        'ApplicationViewBindingSource
        '
        Me.ApplicationViewBindingSource.DataMember = "ApplicationView"
        Me.ApplicationViewBindingSource.DataSource = Me.PROJECTS1747DataSet8
        '
        'ApplicationViewTableAdapter
        '
        Me.ApplicationViewTableAdapter.ClearBeforeFill = True
        '
        'ApplicantViewTableAdapter
        '
        Me.ApplicantViewTableAdapter.ClearBeforeFill = True
        '
        'ApplicationViewBindingSource1
        '
        Me.ApplicationViewBindingSource1.DataMember = "ApplicationView"
        Me.ApplicationViewBindingSource1.DataSource = Me.PROJECTS1747DataSet8
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 344)
        Me.Controls.Add(Me.btnViewApplicant)
        Me.Controls.Add(Me.tbFilter2)
        Me.Controls.Add(Me.tbFilter1)
        Me.Controls.Add(Me.cbFilter2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbFilter1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.Name = "Main"
        Me.Text = "Applicants"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ApplicantViewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PROJECTS1747DataSet8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ViewApplicationTableBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PROJECTS1747DataSet3BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PROJECTS1747DataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ViewApplicationTableBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PROJECTS1747DataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ApplicationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PROJECTS1747DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProjectS1730DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PROJECTS1747DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PROJECTS1747DataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ApplicationBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ViewApplicationTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ApplicationViewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ApplicationViewBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents Panel2 As Panel
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents cbFilter1 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cbFilter2 As ComboBox
    Friend WithEvents tbFilter1 As TextBox
    Friend WithEvents tbFilter2 As TextBox
    Friend WithEvents ApplicantProfileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PROJECTS1747DataSet As PROJECTS1747DataSet
    Friend WithEvents ApplicationBindingSource As BindingSource
    Friend WithEvents ApplicationTableAdapter As PROJECTS1747DataSetTableAdapters.ApplicationTableAdapter
    Friend WithEvents ProjectS1730DataSet1 As PROJECTS1730DataSet
    Friend WithEvents btnViewApplicant As Button
    Friend WithEvents PROJECTS1747DataSet1BindingSource As BindingSource
    Friend WithEvents PROJECTS1747DataSet1 As PROJECTS1747DataSet1
    Friend WithEvents ApplicationBindingSource1 As BindingSource
    Friend WithEvents ApplicationTableAdapter1 As PROJECTS1747DataSet1TableAdapters.ApplicationTableAdapter
    Friend WithEvents ViewApplicationTableBindingSource As BindingSource
    Friend WithEvents View_ApplicationTableTableAdapter As PROJECTS1747DataSet1TableAdapters.View_ApplicationTableTableAdapter
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents PROJECTS1747DataSet2 As PROJECTS1747DataSet2
    Friend WithEvents ViewApplicationTableBindingSource1 As BindingSource
    Friend WithEvents View_ApplicationTableTableAdapter1 As PROJECTS1747DataSet2TableAdapters.View_ApplicationTableTableAdapter
    Friend WithEvents PROJECTS1747DataSet3BindingSource As BindingSource
    Friend WithEvents PROJECTS1747DataSet3 As PROJECTS1747DataSet3
    Friend WithEvents ViewApplicationTableBindingSource2 As BindingSource
    Friend WithEvents View_ApplicationTableTableAdapter2 As PROJECTS1747DataSet3TableAdapters.View_ApplicationTableTableAdapter
    Friend WithEvents PROJECTS1747DataSet8 As PROJECTS1747DataSet8
    Friend WithEvents ApplicationViewBindingSource As BindingSource
    Friend WithEvents ApplicationViewTableAdapter As PROJECTS1747DataSet8TableAdapters.ApplicationViewTableAdapter
    Friend WithEvents ApplicantViewBindingSource As BindingSource
    Friend WithEvents ApplicantViewTableAdapter As PROJECTS1747DataSet8TableAdapters.ApplicantViewTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProgramDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ConcentrationDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ApplicationDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ResidencyDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ApplicationViewBindingSource1 As BindingSource
End Class
