<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ApplicantProfile
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
        Me.PersonalTabPage = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.tbAddress = New System.Windows.Forms.TextBox()
        Me.ApplicationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PROJECTS1747DataSet2 = New MaintenanceProject.PROJECTS1747DataSet2()
        Me.tbPhone = New System.Windows.Forms.TextBox()
        Me.tbEmail = New System.Windows.Forms.TextBox()
        Me.tbYears = New System.Windows.Forms.TextBox()
        Me.tbEmployer = New System.Windows.Forms.TextBox()
        Me.tbEthnicity = New System.Windows.Forms.TextBox()
        Me.tbGender = New System.Windows.Forms.TextBox()
        Me.tbAge = New System.Windows.Forms.TextBox()
        Me.tbStuID = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.tbGDDegree = New System.Windows.Forms.TextBox()
        Me.tbGDInst = New System.Windows.Forms.TextBox()
        Me.tbUGDMajor = New System.Windows.Forms.TextBox()
        Me.tbUGDDegree = New System.Windows.Forms.TextBox()
        Me.tbUDGGPA = New System.Windows.Forms.TextBox()
        Me.tbUDGInst = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tabAdmissions = New System.Windows.Forms.TabPage()
        Me.lblResponse = New System.Windows.Forms.Label()
        Me.tbResponse = New System.Windows.Forms.TextBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.cbDecision = New System.Windows.Forms.ComboBox()
        Me.lblStuName = New System.Windows.Forms.Label()
        Me.ApplicationTableAdapter = New MaintenanceProject.PROJECTS1747DataSet2TableAdapters.ApplicationTableAdapter()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label_ProgramType = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuEditRecommendation = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuEditInterview = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuViewRecommendations = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuViewInterview = New System.Windows.Forms.ToolStripMenuItem()
        Me.tbAppDate = New System.Windows.Forms.TextBox()
        Me.tbStudentID = New System.Windows.Forms.TextBox()
        Me.tbAppId = New System.Windows.Forms.TextBox()
        Me.tbUAEmail = New System.Windows.Forms.TextBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.TextBox13 = New System.Windows.Forms.TextBox()
        Me.TextBox14 = New System.Windows.Forms.TextBox()
        Me.PersonalTabPage.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.ApplicationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PROJECTS1747DataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.tabAdmissions.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PersonalTabPage
        '
        Me.PersonalTabPage.Controls.Add(Me.TabPage1)
        Me.PersonalTabPage.Controls.Add(Me.TabPage2)
        Me.PersonalTabPage.Controls.Add(Me.TabPage3)
        Me.PersonalTabPage.Controls.Add(Me.TabPage4)
        Me.PersonalTabPage.Controls.Add(Me.tabAdmissions)
        Me.PersonalTabPage.Location = New System.Drawing.Point(17, 134)
        Me.PersonalTabPage.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.PersonalTabPage.Name = "PersonalTabPage"
        Me.PersonalTabPage.SelectedIndex = 0
        Me.PersonalTabPage.Size = New System.Drawing.Size(845, 725)
        Me.PersonalTabPage.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.tbAddress)
        Me.TabPage1.Controls.Add(Me.tbPhone)
        Me.TabPage1.Controls.Add(Me.tbEmail)
        Me.TabPage1.Controls.Add(Me.tbYears)
        Me.TabPage1.Controls.Add(Me.tbEmployer)
        Me.TabPage1.Controls.Add(Me.tbEthnicity)
        Me.TabPage1.Controls.Add(Me.tbGender)
        Me.TabPage1.Controls.Add(Me.tbAge)
        Me.TabPage1.Controls.Add(Me.tbStuID)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Location = New System.Drawing.Point(10, 48)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.TabPage1.Size = New System.Drawing.Size(825, 667)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Personal"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'tbAddress
        '
        Me.tbAddress.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ApplicationBindingSource, "Phone", True))
        Me.tbAddress.Location = New System.Drawing.Point(210, 562)
        Me.tbAddress.Name = "tbAddress"
        Me.tbAddress.ReadOnly = True
        Me.tbAddress.Size = New System.Drawing.Size(341, 38)
        Me.tbAddress.TabIndex = 27
        '
        'ApplicationBindingSource
        '
        Me.ApplicationBindingSource.DataMember = "Application"
        Me.ApplicationBindingSource.DataSource = Me.PROJECTS1747DataSet2
        '
        'PROJECTS1747DataSet2
        '
        Me.PROJECTS1747DataSet2.DataSetName = "PROJECTS1747DataSet2"
        Me.PROJECTS1747DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'tbPhone
        '
        Me.tbPhone.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ApplicationBindingSource, "Phone", True))
        Me.tbPhone.Location = New System.Drawing.Point(210, 498)
        Me.tbPhone.Name = "tbPhone"
        Me.tbPhone.ReadOnly = True
        Me.tbPhone.Size = New System.Drawing.Size(341, 38)
        Me.tbPhone.TabIndex = 26
        '
        'tbEmail
        '
        Me.tbEmail.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ApplicationBindingSource, "Non_UA_Email", True))
        Me.tbEmail.Location = New System.Drawing.Point(210, 433)
        Me.tbEmail.Name = "tbEmail"
        Me.tbEmail.ReadOnly = True
        Me.tbEmail.Size = New System.Drawing.Size(341, 38)
        Me.tbEmail.TabIndex = 25
        '
        'tbYears
        '
        Me.tbYears.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ApplicationBindingSource, "TWE", True))
        Me.tbYears.Location = New System.Drawing.Point(210, 369)
        Me.tbYears.Name = "tbYears"
        Me.tbYears.ReadOnly = True
        Me.tbYears.Size = New System.Drawing.Size(341, 38)
        Me.tbYears.TabIndex = 24
        Me.tbYears.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbEmployer
        '
        Me.tbEmployer.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ApplicationBindingSource, "Current_Employer", True))
        Me.tbEmployer.Location = New System.Drawing.Point(210, 305)
        Me.tbEmployer.Name = "tbEmployer"
        Me.tbEmployer.ReadOnly = True
        Me.tbEmployer.Size = New System.Drawing.Size(341, 38)
        Me.tbEmployer.TabIndex = 23
        '
        'tbEthnicity
        '
        Me.tbEthnicity.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ApplicationBindingSource, "Ethnicity", True))
        Me.tbEthnicity.Location = New System.Drawing.Point(210, 240)
        Me.tbEthnicity.Name = "tbEthnicity"
        Me.tbEthnicity.ReadOnly = True
        Me.tbEthnicity.Size = New System.Drawing.Size(341, 38)
        Me.tbEthnicity.TabIndex = 22
        '
        'tbGender
        '
        Me.tbGender.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ApplicationBindingSource, "Gender", True))
        Me.tbGender.Location = New System.Drawing.Point(210, 176)
        Me.tbGender.Name = "tbGender"
        Me.tbGender.ReadOnly = True
        Me.tbGender.Size = New System.Drawing.Size(341, 38)
        Me.tbGender.TabIndex = 21
        '
        'tbAge
        '
        Me.tbAge.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ApplicationBindingSource, "Age", True))
        Me.tbAge.Location = New System.Drawing.Point(210, 111)
        Me.tbAge.Name = "tbAge"
        Me.tbAge.ReadOnly = True
        Me.tbAge.Size = New System.Drawing.Size(341, 38)
        Me.tbAge.TabIndex = 20
        Me.tbAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbStuID
        '
        Me.tbStuID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ApplicationBindingSource, "Student_ID", True))
        Me.tbStuID.Location = New System.Drawing.Point(210, 47)
        Me.tbStuID.Name = "tbStuID"
        Me.tbStuID.ReadOnly = True
        Me.tbStuID.Size = New System.Drawing.Size(341, 38)
        Me.tbStuID.TabIndex = 19
        Me.tbStuID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(16, 565)
        Me.Label11.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(134, 32)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "Address: "
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(16, 501)
        Me.Label10.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(113, 32)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Phone: "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(16, 436)
        Me.Label9.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(102, 32)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Email: "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(16, 114)
        Me.Label8.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 32)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Age:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(16, 372)
        Me.Label7.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 32)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Years: "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 308)
        Me.Label6.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(150, 32)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Employer: "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 243)
        Me.Label5.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(132, 32)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Ethnicity:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 179)
        Me.Label4.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(125, 32)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Gender: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 50)
        Me.Label2.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(156, 32)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Student ID:"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.tbGDDegree)
        Me.TabPage2.Controls.Add(Me.tbGDInst)
        Me.TabPage2.Controls.Add(Me.tbUGDMajor)
        Me.TabPage2.Controls.Add(Me.tbUGDDegree)
        Me.TabPage2.Controls.Add(Me.tbUDGGPA)
        Me.TabPage2.Controls.Add(Me.tbUDGInst)
        Me.TabPage2.Controls.Add(Me.Label17)
        Me.TabPage2.Controls.Add(Me.Label16)
        Me.TabPage2.Controls.Add(Me.Label15)
        Me.TabPage2.Controls.Add(Me.Label14)
        Me.TabPage2.Controls.Add(Me.Label13)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Location = New System.Drawing.Point(10, 48)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.TabPage2.Size = New System.Drawing.Size(825, 667)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Academics"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'tbGDDegree
        '
        Me.tbGDDegree.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ApplicationBindingSource, "G_Degree", True))
        Me.tbGDDegree.Location = New System.Drawing.Point(335, 433)
        Me.tbGDDegree.Name = "tbGDDegree"
        Me.tbGDDegree.ReadOnly = True
        Me.tbGDDegree.Size = New System.Drawing.Size(371, 38)
        Me.tbGDDegree.TabIndex = 27
        '
        'tbGDInst
        '
        Me.tbGDInst.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ApplicationBindingSource, "GRAD", True))
        Me.tbGDInst.Location = New System.Drawing.Point(335, 357)
        Me.tbGDInst.Name = "tbGDInst"
        Me.tbGDInst.ReadOnly = True
        Me.tbGDInst.Size = New System.Drawing.Size(371, 38)
        Me.tbGDInst.TabIndex = 26
        '
        'tbUGDMajor
        '
        Me.tbUGDMajor.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ApplicationBindingSource, "UDRG_Major", True))
        Me.tbUGDMajor.Location = New System.Drawing.Point(335, 281)
        Me.tbUGDMajor.Name = "tbUGDMajor"
        Me.tbUGDMajor.ReadOnly = True
        Me.tbUGDMajor.Size = New System.Drawing.Size(371, 38)
        Me.tbUGDMajor.TabIndex = 25
        '
        'tbUGDDegree
        '
        Me.tbUGDDegree.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ApplicationBindingSource, "U_Deg", True))
        Me.tbUGDDegree.Location = New System.Drawing.Point(335, 204)
        Me.tbUGDDegree.Name = "tbUGDDegree"
        Me.tbUGDDegree.ReadOnly = True
        Me.tbUGDDegree.Size = New System.Drawing.Size(371, 38)
        Me.tbUGDDegree.TabIndex = 24
        '
        'tbUDGGPA
        '
        Me.tbUDGGPA.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ApplicationBindingSource, "U_GPA", True))
        Me.tbUDGGPA.Location = New System.Drawing.Point(335, 128)
        Me.tbUDGGPA.Name = "tbUDGGPA"
        Me.tbUDGGPA.ReadOnly = True
        Me.tbUDGGPA.Size = New System.Drawing.Size(371, 38)
        Me.tbUDGGPA.TabIndex = 23
        '
        'tbUDGInst
        '
        Me.tbUDGInst.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ApplicationBindingSource, "U_Inst", True))
        Me.tbUDGInst.Location = New System.Drawing.Point(335, 52)
        Me.tbUDGInst.Name = "tbUDGInst"
        Me.tbUDGInst.ReadOnly = True
        Me.tbUDGInst.Size = New System.Drawing.Size(371, 38)
        Me.tbUDGInst.TabIndex = 22
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(16, 355)
        Me.Label17.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(279, 32)
        Me.Label17.TabIndex = 6
        Me.Label17.Text = "Graduate Institution: "
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(16, 430)
        Me.Label16.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(249, 32)
        Me.Label16.TabIndex = 5
        Me.Label16.Text = "Graduate Degree: "
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(16, 280)
        Me.Label15.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(242, 32)
        Me.Label15.TabIndex = 4
        Me.Label15.Text = "Undergrad Major: "
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(16, 205)
        Me.Label14.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(264, 32)
        Me.Label14.TabIndex = 3
        Me.Label14.Text = "Undergrad Degree: "
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(16, 55)
        Me.Label13.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(294, 32)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Undergrad Institution: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 130)
        Me.Label3.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(231, 32)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Undergrad GPA: "
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.tbUAEmail)
        Me.TabPage3.Controls.Add(Me.tbAppId)
        Me.TabPage3.Controls.Add(Me.tbStudentID)
        Me.TabPage3.Controls.Add(Me.tbAppDate)
        Me.TabPage3.Controls.Add(Me.Label21)
        Me.TabPage3.Controls.Add(Me.Label20)
        Me.TabPage3.Controls.Add(Me.Label19)
        Me.TabPage3.Controls.Add(Me.Label18)
        Me.TabPage3.Location = New System.Drawing.Point(10, 48)
        Me.TabPage3.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(825, 667)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Application"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(41, 38)
        Me.Label21.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(206, 32)
        Me.Label21.TabIndex = 3
        Me.Label21.Text = "Application ID: "
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(41, 281)
        Me.Label20.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(186, 32)
        Me.Label20.TabIndex = 2
        Me.Label20.Text = "U of A Email: "
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(41, 200)
        Me.Label19.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(239, 32)
        Me.Label19.TabIndex = 1
        Me.Label19.Text = "Application Date: "
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(41, 119)
        Me.Label18.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(170, 32)
        Me.Label18.TabIndex = 0
        Me.Label18.Text = "Student ID:  "
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.TextBox14)
        Me.TabPage4.Controls.Add(Me.TextBox13)
        Me.TabPage4.Controls.Add(Me.TextBox12)
        Me.TabPage4.Controls.Add(Me.TextBox11)
        Me.TabPage4.Controls.Add(Me.TextBox10)
        Me.TabPage4.Controls.Add(Me.TextBox9)
        Me.TabPage4.Controls.Add(Me.TextBox8)
        Me.TabPage4.Controls.Add(Me.TextBox7)
        Me.TabPage4.Controls.Add(Me.TextBox6)
        Me.TabPage4.Controls.Add(Me.TextBox5)
        Me.TabPage4.Controls.Add(Me.Label30)
        Me.TabPage4.Controls.Add(Me.Label29)
        Me.TabPage4.Controls.Add(Me.Label28)
        Me.TabPage4.Controls.Add(Me.Label27)
        Me.TabPage4.Controls.Add(Me.Label26)
        Me.TabPage4.Controls.Add(Me.Label25)
        Me.TabPage4.Controls.Add(Me.Label24)
        Me.TabPage4.Controls.Add(Me.Label23)
        Me.TabPage4.Controls.Add(Me.Label22)
        Me.TabPage4.Controls.Add(Me.Label1)
        Me.TabPage4.Location = New System.Drawing.Point(10, 48)
        Me.TabPage4.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(825, 667)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Test Scores"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(17, 562)
        Me.Label30.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(121, 32)
        Me.Label30.TabIndex = 9
        Me.Label30.Text = "TOEFL: "
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(17, 502)
        Me.Label29.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(76, 32)
        Me.Label29.TabIndex = 8
        Me.Label29.Text = "WR: "
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(17, 442)
        Me.Label28.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(98, 32)
        Me.Label28.TabIndex = 7
        Me.Label28.Text = "V-Q%:"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(17, 382)
        Me.Label27.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(77, 32)
        Me.Label27.TabIndex = 6
        Me.Label27.Text = "Q%: "
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(17, 262)
        Me.Label26.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(74, 32)
        Me.Label26.TabIndex = 5
        Me.Label26.Text = "V%: "
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(17, 322)
        Me.Label25.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(100, 32)
        Me.Label25.TabIndex = 4
        Me.Label25.Text = "Quan: "
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(17, 202)
        Me.Label24.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(90, 32)
        Me.Label24.TabIndex = 3
        Me.Label24.Text = "Verb: "
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(17, 142)
        Me.Label23.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(111, 32)
        Me.Label23.TabIndex = 2
        Me.Label23.Text = "GMAT: "
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(17, 82)
        Me.Label22.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(163, 32)
        Me.Label22.TabIndex = 1
        Me.Label22.Text = "ELAC Req: "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 22)
        Me.Label1.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Eval/ I-20: "
        '
        'tabAdmissions
        '
        Me.tabAdmissions.Controls.Add(Me.lblResponse)
        Me.tabAdmissions.Controls.Add(Me.tbResponse)
        Me.tabAdmissions.Controls.Add(Me.btnSubmit)
        Me.tabAdmissions.Controls.Add(Me.Label42)
        Me.tabAdmissions.Controls.Add(Me.cbDecision)
        Me.tabAdmissions.Location = New System.Drawing.Point(10, 48)
        Me.tabAdmissions.Name = "tabAdmissions"
        Me.tabAdmissions.Padding = New System.Windows.Forms.Padding(3)
        Me.tabAdmissions.Size = New System.Drawing.Size(825, 667)
        Me.tabAdmissions.TabIndex = 4
        Me.tabAdmissions.Text = "Admissions"
        Me.tabAdmissions.UseVisualStyleBackColor = True
        '
        'lblResponse
        '
        Me.lblResponse.AutoSize = True
        Me.lblResponse.Location = New System.Drawing.Point(320, 272)
        Me.lblResponse.Name = "lblResponse"
        Me.lblResponse.Size = New System.Drawing.Size(151, 32)
        Me.lblResponse.TabIndex = 4
        Me.lblResponse.Text = "Response:"
        '
        'tbResponse
        '
        Me.tbResponse.Location = New System.Drawing.Point(266, 310)
        Me.tbResponse.Name = "tbResponse"
        Me.tbResponse.ReadOnly = True
        Me.tbResponse.Size = New System.Drawing.Size(258, 38)
        Me.tbResponse.TabIndex = 3
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(393, 170)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(134, 48)
        Me.btnSubmit.TabIndex = 2
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Location = New System.Drawing.Point(263, 76)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(264, 32)
        Me.Label42.TabIndex = 1
        Me.Label42.Text = "Admission Decision"
        '
        'cbDecision
        '
        Me.cbDecision.FormattingEnabled = True
        Me.cbDecision.Location = New System.Drawing.Point(263, 114)
        Me.cbDecision.Name = "cbDecision"
        Me.cbDecision.Size = New System.Drawing.Size(264, 39)
        Me.cbDecision.TabIndex = 0
        '
        'lblStuName
        '
        Me.lblStuName.AutoSize = True
        Me.lblStuName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStuName.Location = New System.Drawing.Point(249, 77)
        Me.lblStuName.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.lblStuName.Name = "lblStuName"
        Me.lblStuName.Size = New System.Drawing.Size(230, 32)
        Me.lblStuName.TabIndex = 2
        Me.lblStuName.Text = "Applicant Name"
        '
        'ApplicationTableAdapter
        '
        Me.ApplicationTableAdapter.ClearBeforeFill = True
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Location = New System.Drawing.Point(9, 77)
        Me.Label41.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(231, 32)
        Me.Label41.TabIndex = 5
        Me.Label41.Text = "Applicant Name: "
        '
        'Label_ProgramType
        '
        Me.Label_ProgramType.AutoSize = True
        Me.Label_ProgramType.Font = New System.Drawing.Font("Castellar", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_ProgramType.Location = New System.Drawing.Point(819, 50)
        Me.Label_ProgramType.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label_ProgramType.Name = "Label_ProgramType"
        Me.Label_ProgramType.Size = New System.Drawing.Size(0, 40)
        Me.Label_ProgramType.TabIndex = 6
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(40, 40)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.ViewToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(884, 49)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(75, 45)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(179, 46)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuEditRecommendation, Me.menuEditInterview})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(80, 45)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'menuEditRecommendation
        '
        Me.menuEditRecommendation.Name = "menuEditRecommendation"
        Me.menuEditRecommendation.Size = New System.Drawing.Size(541, 46)
        Me.menuEditRecommendation.Text = "Add/Update Recommendation"
        '
        'menuEditInterview
        '
        Me.menuEditInterview.Name = "menuEditInterview"
        Me.menuEditInterview.Size = New System.Drawing.Size(541, 46)
        Me.menuEditInterview.Text = "Add/Update Interview"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuViewRecommendations, Me.menuViewInterview})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(94, 45)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'menuViewRecommendations
        '
        Me.menuViewRecommendations.Name = "menuViewRecommendations"
        Me.menuViewRecommendations.Size = New System.Drawing.Size(381, 46)
        Me.menuViewRecommendations.Text = "Recommendations"
        '
        'menuViewInterview
        '
        Me.menuViewInterview.Name = "menuViewInterview"
        Me.menuViewInterview.Size = New System.Drawing.Size(381, 46)
        Me.menuViewInterview.Text = "Interview"
        '
        'tbAppDate
        '
        Me.tbAppDate.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ApplicationBindingSource, "App_Date", True))
        Me.tbAppDate.Location = New System.Drawing.Point(291, 197)
        Me.tbAppDate.Name = "tbAppDate"
        Me.tbAppDate.ReadOnly = True
        Me.tbAppDate.Size = New System.Drawing.Size(371, 38)
        Me.tbAppDate.TabIndex = 23
        '
        'tbStudentID
        '
        Me.tbStudentID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ApplicationBindingSource, "Student_ID", True))
        Me.tbStudentID.Location = New System.Drawing.Point(291, 116)
        Me.tbStudentID.Name = "tbStudentID"
        Me.tbStudentID.ReadOnly = True
        Me.tbStudentID.Size = New System.Drawing.Size(371, 38)
        Me.tbStudentID.TabIndex = 24
        '
        'tbAppId
        '
        Me.tbAppId.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ApplicationBindingSource, "Application_ID", True))
        Me.tbAppId.Location = New System.Drawing.Point(291, 35)
        Me.tbAppId.Name = "tbAppId"
        Me.tbAppId.ReadOnly = True
        Me.tbAppId.Size = New System.Drawing.Size(371, 38)
        Me.tbAppId.TabIndex = 25
        '
        'tbUAEmail
        '
        Me.tbUAEmail.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ApplicationBindingSource, "UA_Email", True))
        Me.tbUAEmail.Location = New System.Drawing.Point(291, 275)
        Me.tbUAEmail.Name = "tbUAEmail"
        Me.tbUAEmail.ReadOnly = True
        Me.tbUAEmail.Size = New System.Drawing.Size(371, 38)
        Me.tbUAEmail.TabIndex = 26
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(717, 870)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(135, 51)
        Me.btnClose.TabIndex = 9
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'TextBox5
        '
        Me.TextBox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ApplicationBindingSource, "Student_ID", True))
        Me.TextBox5.Location = New System.Drawing.Point(191, 79)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.ReadOnly = True
        Me.TextBox5.Size = New System.Drawing.Size(371, 38)
        Me.TextBox5.TabIndex = 23
        '
        'TextBox6
        '
        Me.TextBox6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ApplicationBindingSource, "Student_ID", True))
        Me.TextBox6.Location = New System.Drawing.Point(191, 19)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.ReadOnly = True
        Me.TextBox6.Size = New System.Drawing.Size(371, 38)
        Me.TextBox6.TabIndex = 24
        '
        'TextBox7
        '
        Me.TextBox7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ApplicationBindingSource, "Student_ID", True))
        Me.TextBox7.Location = New System.Drawing.Point(191, 139)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.ReadOnly = True
        Me.TextBox7.Size = New System.Drawing.Size(371, 38)
        Me.TextBox7.TabIndex = 25
        '
        'TextBox8
        '
        Me.TextBox8.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ApplicationBindingSource, "Student_ID", True))
        Me.TextBox8.Location = New System.Drawing.Point(191, 199)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.ReadOnly = True
        Me.TextBox8.Size = New System.Drawing.Size(371, 38)
        Me.TextBox8.TabIndex = 26
        '
        'TextBox9
        '
        Me.TextBox9.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ApplicationBindingSource, "Student_ID", True))
        Me.TextBox9.Location = New System.Drawing.Point(191, 259)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.ReadOnly = True
        Me.TextBox9.Size = New System.Drawing.Size(371, 38)
        Me.TextBox9.TabIndex = 27
        '
        'TextBox10
        '
        Me.TextBox10.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ApplicationBindingSource, "Student_ID", True))
        Me.TextBox10.Location = New System.Drawing.Point(191, 319)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.ReadOnly = True
        Me.TextBox10.Size = New System.Drawing.Size(371, 38)
        Me.TextBox10.TabIndex = 28
        '
        'TextBox11
        '
        Me.TextBox11.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ApplicationBindingSource, "Student_ID", True))
        Me.TextBox11.Location = New System.Drawing.Point(191, 379)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.ReadOnly = True
        Me.TextBox11.Size = New System.Drawing.Size(371, 38)
        Me.TextBox11.TabIndex = 29
        '
        'TextBox12
        '
        Me.TextBox12.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ApplicationBindingSource, "Student_ID", True))
        Me.TextBox12.Location = New System.Drawing.Point(191, 439)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.ReadOnly = True
        Me.TextBox12.Size = New System.Drawing.Size(371, 38)
        Me.TextBox12.TabIndex = 30
        '
        'TextBox13
        '
        Me.TextBox13.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ApplicationBindingSource, "Student_ID", True))
        Me.TextBox13.Location = New System.Drawing.Point(191, 499)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.ReadOnly = True
        Me.TextBox13.Size = New System.Drawing.Size(371, 38)
        Me.TextBox13.TabIndex = 31
        '
        'TextBox14
        '
        Me.TextBox14.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ApplicationBindingSource, "Student_ID", True))
        Me.TextBox14.Location = New System.Drawing.Point(191, 559)
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.ReadOnly = True
        Me.TextBox14.Size = New System.Drawing.Size(371, 38)
        Me.TextBox14.TabIndex = 32
        '
        'ApplicantProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(884, 933)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Label_ProgramType)
        Me.Controls.Add(Me.Label41)
        Me.Controls.Add(Me.lblStuName)
        Me.Controls.Add(Me.PersonalTabPage)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.Name = "ApplicantProfile"
        Me.Text = "Applicant Profile"
        Me.PersonalTabPage.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.ApplicationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PROJECTS1747DataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.tabAdmissions.ResumeLayout(False)
        Me.tabAdmissions.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PersonalTabPage As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents lblStuName As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents PROJECTS1747DataSet2 As PROJECTS1747DataSet2
    Friend WithEvents ApplicationBindingSource As BindingSource
    Friend WithEvents ApplicationTableAdapter As PROJECTS1747DataSet2TableAdapters.ApplicationTableAdapter
    Friend WithEvents Label30 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label41 As Label
    Friend WithEvents Label_ProgramType As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents menuEditRecommendation As ToolStripMenuItem
    Friend WithEvents menuEditInterview As ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents menuViewRecommendations As ToolStripMenuItem
    Friend WithEvents menuViewInterview As ToolStripMenuItem
    Friend WithEvents tabAdmissions As TabPage
    Friend WithEvents Label42 As Label
    Friend WithEvents cbDecision As ComboBox
    Friend WithEvents btnSubmit As Button
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblResponse As Label
    Friend WithEvents tbResponse As TextBox
    Friend WithEvents tbStuID As TextBox
    Friend WithEvents tbAddress As TextBox
    Friend WithEvents tbPhone As TextBox
    Friend WithEvents tbEmail As TextBox
    Friend WithEvents tbYears As TextBox
    Friend WithEvents tbEmployer As TextBox
    Friend WithEvents tbEthnicity As TextBox
    Friend WithEvents tbGender As TextBox
    Friend WithEvents tbAge As TextBox
    Friend WithEvents tbGDDegree As TextBox
    Friend WithEvents tbGDInst As TextBox
    Friend WithEvents tbUGDMajor As TextBox
    Friend WithEvents tbUGDDegree As TextBox
    Friend WithEvents tbUDGGPA As TextBox
    Friend WithEvents tbUDGInst As TextBox
    Friend WithEvents tbUAEmail As TextBox
    Friend WithEvents tbAppId As TextBox
    Friend WithEvents tbStudentID As TextBox
    Friend WithEvents tbAppDate As TextBox
    Friend WithEvents TextBox14 As TextBox
    Friend WithEvents TextBox13 As TextBox
    Friend WithEvents TextBox12 As TextBox
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents btnClose As Button
End Class
