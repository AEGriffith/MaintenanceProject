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
        Me.btnComment = New System.Windows.Forms.Button()
        Me.PersonalTabPage = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.ApplicationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PROJECTS1747DataSet2 = New MaintenanceProject.PROJECTS1747DataSet2()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblYears = New System.Windows.Forms.Label()
        Me.lblEmployer = New System.Windows.Forms.Label()
        Me.lblEthnicity = New System.Windows.Forms.Label()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.lblAge = New System.Windows.Forms.Label()
        Me.lblStuID = New System.Windows.Forms.Label()
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
        Me.lblGDegree = New System.Windows.Forms.Label()
        Me.lblGInstitution = New System.Windows.Forms.Label()
        Me.lblMajor = New System.Windows.Forms.Label()
        Me.lblDegree = New System.Windows.Forms.Label()
        Me.lblGPA = New System.Windows.Forms.Label()
        Me.lblInstitution = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.lblUAEmail = New System.Windows.Forms.Label()
        Me.lblAppDate = New System.Windows.Forms.Label()
        Me.lblStudID = New System.Windows.Forms.Label()
        Me.lblAppID = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
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
        Me.lblStuName = New System.Windows.Forms.Label()
        Me.btnAddInterview = New System.Windows.Forms.Button()
        Me.ApplicationTableAdapter = New MaintenanceProject.PROJECTS1747DataSet2TableAdapters.ApplicationTableAdapter()
        Me.btnView = New System.Windows.Forms.Button()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label_ProgramType = New System.Windows.Forms.Label()
        Me.btnViewInterview = New System.Windows.Forms.Button()
        Me.PersonalTabPage.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.ApplicationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PROJECTS1747DataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnComment
        '
        Me.btnComment.Location = New System.Drawing.Point(206, 383)
        Me.btnComment.Name = "btnComment"
        Me.btnComment.Size = New System.Drawing.Size(95, 23)
        Me.btnComment.TabIndex = 0
        Me.btnComment.Text = "Add Comment"
        Me.btnComment.UseVisualStyleBackColor = True
        '
        'PersonalTabPage
        '
        Me.PersonalTabPage.Controls.Add(Me.TabPage1)
        Me.PersonalTabPage.Controls.Add(Me.TabPage2)
        Me.PersonalTabPage.Controls.Add(Me.TabPage3)
        Me.PersonalTabPage.Controls.Add(Me.TabPage4)
        Me.PersonalTabPage.Location = New System.Drawing.Point(56, 56)
        Me.PersonalTabPage.Name = "PersonalTabPage"
        Me.PersonalTabPage.SelectedIndex = 0
        Me.PersonalTabPage.Size = New System.Drawing.Size(317, 304)
        Me.PersonalTabPage.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.lblAddress)
        Me.TabPage1.Controls.Add(Me.lblPhone)
        Me.TabPage1.Controls.Add(Me.lblEmail)
        Me.TabPage1.Controls.Add(Me.lblYears)
        Me.TabPage1.Controls.Add(Me.lblEmployer)
        Me.TabPage1.Controls.Add(Me.lblEthnicity)
        Me.TabPage1.Controls.Add(Me.lblGender)
        Me.TabPage1.Controls.Add(Me.lblAge)
        Me.TabPage1.Controls.Add(Me.lblStuID)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.TabPage1.Size = New System.Drawing.Size(309, 278)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Personal"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Location = New System.Drawing.Point(166, 237)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(45, 13)
        Me.lblAddress.TabIndex = 18
        Me.lblAddress.Text = "Address"
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ApplicationBindingSource, "Phone", True))
        Me.lblPhone.Location = New System.Drawing.Point(166, 210)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(38, 13)
        Me.lblPhone.TabIndex = 17
        Me.lblPhone.Text = "Phone"
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
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ApplicationBindingSource, "Non_UA_Email", True))
        Me.lblEmail.Location = New System.Drawing.Point(166, 183)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(32, 13)
        Me.lblEmail.TabIndex = 16
        Me.lblEmail.Text = "Email"
        '
        'lblYears
        '
        Me.lblYears.AutoSize = True
        Me.lblYears.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ApplicationBindingSource, "TWE", True))
        Me.lblYears.Location = New System.Drawing.Point(166, 156)
        Me.lblYears.Name = "lblYears"
        Me.lblYears.Size = New System.Drawing.Size(34, 13)
        Me.lblYears.TabIndex = 15
        Me.lblYears.Text = "Years"
        '
        'lblEmployer
        '
        Me.lblEmployer.AutoSize = True
        Me.lblEmployer.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ApplicationBindingSource, "Current_Employer", True))
        Me.lblEmployer.Location = New System.Drawing.Point(166, 129)
        Me.lblEmployer.Name = "lblEmployer"
        Me.lblEmployer.Size = New System.Drawing.Size(50, 13)
        Me.lblEmployer.TabIndex = 14
        Me.lblEmployer.Text = "Employer"
        '
        'lblEthnicity
        '
        Me.lblEthnicity.AutoSize = True
        Me.lblEthnicity.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ApplicationBindingSource, "Ethnicity", True))
        Me.lblEthnicity.Location = New System.Drawing.Point(166, 102)
        Me.lblEthnicity.Name = "lblEthnicity"
        Me.lblEthnicity.Size = New System.Drawing.Size(47, 13)
        Me.lblEthnicity.TabIndex = 13
        Me.lblEthnicity.Text = "Ethnicity"
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ApplicationBindingSource, "Gender", True))
        Me.lblGender.Location = New System.Drawing.Point(166, 75)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(42, 13)
        Me.lblGender.TabIndex = 12
        Me.lblGender.Text = "Gender"
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ApplicationBindingSource, "Age", True))
        Me.lblAge.Location = New System.Drawing.Point(166, 48)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(26, 13)
        Me.lblAge.TabIndex = 11
        Me.lblAge.Text = "Age"
        '
        'lblStuID
        '
        Me.lblStuID.AutoSize = True
        Me.lblStuID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ApplicationBindingSource, "Student_ID", True))
        Me.lblStuID.Location = New System.Drawing.Point(166, 21)
        Me.lblStuID.Name = "lblStuID"
        Me.lblStuID.Size = New System.Drawing.Size(34, 13)
        Me.lblStuID.TabIndex = 10
        Me.lblStuID.Text = "StuID"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(103, 237)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(51, 13)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "Address: "
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(110, 211)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 13)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Phone: "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(116, 182)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(38, 13)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Email: "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(125, 48)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(29, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Age:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(114, 156)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Years: "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(98, 129)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Employer: "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(102, 102)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Ethnicity:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(106, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Gender: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(93, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Student ID:"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.lblGDegree)
        Me.TabPage2.Controls.Add(Me.lblGInstitution)
        Me.TabPage2.Controls.Add(Me.lblMajor)
        Me.TabPage2.Controls.Add(Me.lblDegree)
        Me.TabPage2.Controls.Add(Me.lblGPA)
        Me.TabPage2.Controls.Add(Me.lblInstitution)
        Me.TabPage2.Controls.Add(Me.Label17)
        Me.TabPage2.Controls.Add(Me.Label16)
        Me.TabPage2.Controls.Add(Me.Label15)
        Me.TabPage2.Controls.Add(Me.Label14)
        Me.TabPage2.Controls.Add(Me.Label13)
        Me.TabPage2.Controls.Add(Me.Label12)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.TabPage2.Size = New System.Drawing.Size(309, 278)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Academics"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'lblGDegree
        '
        Me.lblGDegree.AutoSize = True
        Me.lblGDegree.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ApplicationBindingSource, "G_Degree", True))
        Me.lblGDegree.Location = New System.Drawing.Point(171, 183)
        Me.lblGDegree.Name = "lblGDegree"
        Me.lblGDegree.Size = New System.Drawing.Size(50, 13)
        Me.lblGDegree.TabIndex = 12
        Me.lblGDegree.Text = "GDegree"
        '
        'lblGInstitution
        '
        Me.lblGInstitution.AutoSize = True
        Me.lblGInstitution.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ApplicationBindingSource, "GRAD", True))
        Me.lblGInstitution.Location = New System.Drawing.Point(171, 151)
        Me.lblGInstitution.Name = "lblGInstitution"
        Me.lblGInstitution.Size = New System.Drawing.Size(60, 13)
        Me.lblGInstitution.TabIndex = 11
        Me.lblGInstitution.Text = "GInstitution"
        '
        'lblMajor
        '
        Me.lblMajor.AutoSize = True
        Me.lblMajor.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ApplicationBindingSource, "UDRG_Major", True))
        Me.lblMajor.Location = New System.Drawing.Point(171, 119)
        Me.lblMajor.Name = "lblMajor"
        Me.lblMajor.Size = New System.Drawing.Size(33, 13)
        Me.lblMajor.TabIndex = 10
        Me.lblMajor.Text = "Major"
        '
        'lblDegree
        '
        Me.lblDegree.AutoSize = True
        Me.lblDegree.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ApplicationBindingSource, "U_Deg", True))
        Me.lblDegree.Location = New System.Drawing.Point(171, 87)
        Me.lblDegree.Name = "lblDegree"
        Me.lblDegree.Size = New System.Drawing.Size(42, 13)
        Me.lblDegree.TabIndex = 9
        Me.lblDegree.Text = "Degree"
        '
        'lblGPA
        '
        Me.lblGPA.AutoSize = True
        Me.lblGPA.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ApplicationBindingSource, "U_GPA", True))
        Me.lblGPA.Location = New System.Drawing.Point(171, 55)
        Me.lblGPA.Name = "lblGPA"
        Me.lblGPA.Size = New System.Drawing.Size(29, 13)
        Me.lblGPA.TabIndex = 8
        Me.lblGPA.Text = "GPA"
        '
        'lblInstitution
        '
        Me.lblInstitution.AutoSize = True
        Me.lblInstitution.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ApplicationBindingSource, "U_Inst", True))
        Me.lblInstitution.Location = New System.Drawing.Point(171, 23)
        Me.lblInstitution.Name = "lblInstitution"
        Me.lblInstitution.Size = New System.Drawing.Size(52, 13)
        Me.lblInstitution.TabIndex = 7
        Me.lblInstitution.Text = "Institution"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(59, 151)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(105, 13)
        Me.Label17.TabIndex = 6
        Me.Label17.Text = "Graduate Institution: "
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(69, 183)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(95, 13)
        Me.Label16.TabIndex = 5
        Me.Label16.Text = "Graduate Degree: "
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(72, 119)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(92, 13)
        Me.Label15.TabIndex = 4
        Me.Label15.Text = "Undergrad Major: "
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(63, 87)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(101, 13)
        Me.Label14.TabIndex = 3
        Me.Label14.Text = "Undergrad Degree: "
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(53, 23)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(111, 13)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Undergrad Institution: "
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(22, 58)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(0, 13)
        Me.Label12.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(76, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Undergrad GPA: "
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.lblUAEmail)
        Me.TabPage3.Controls.Add(Me.lblAppDate)
        Me.TabPage3.Controls.Add(Me.lblStudID)
        Me.TabPage3.Controls.Add(Me.lblAppID)
        Me.TabPage3.Controls.Add(Me.Label21)
        Me.TabPage3.Controls.Add(Me.Label20)
        Me.TabPage3.Controls.Add(Me.Label19)
        Me.TabPage3.Controls.Add(Me.Label18)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(309, 278)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Application"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'lblUAEmail
        '
        Me.lblUAEmail.AutoSize = True
        Me.lblUAEmail.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ApplicationBindingSource, "UA_Email", True))
        Me.lblUAEmail.Location = New System.Drawing.Point(161, 118)
        Me.lblUAEmail.Name = "lblUAEmail"
        Me.lblUAEmail.Size = New System.Drawing.Size(47, 13)
        Me.lblUAEmail.TabIndex = 7
        Me.lblUAEmail.Text = "UAEmail"
        '
        'lblAppDate
        '
        Me.lblAppDate.AutoSize = True
        Me.lblAppDate.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ApplicationBindingSource, "App_Date", True))
        Me.lblAppDate.Location = New System.Drawing.Point(161, 84)
        Me.lblAppDate.Name = "lblAppDate"
        Me.lblAppDate.Size = New System.Drawing.Size(49, 13)
        Me.lblAppDate.TabIndex = 6
        Me.lblAppDate.Text = "AppDate"
        '
        'lblStudID
        '
        Me.lblStudID.AutoSize = True
        Me.lblStudID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ApplicationBindingSource, "Student_ID", True))
        Me.lblStudID.Location = New System.Drawing.Point(161, 49)
        Me.lblStudID.Name = "lblStudID"
        Me.lblStudID.Size = New System.Drawing.Size(40, 13)
        Me.lblStudID.TabIndex = 5
        Me.lblStudID.Text = "StudID"
        '
        'lblAppID
        '
        Me.lblAppID.AutoSize = True
        Me.lblAppID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ApplicationBindingSource, "Application_ID", True))
        Me.lblAppID.Location = New System.Drawing.Point(161, 16)
        Me.lblAppID.Name = "lblAppID"
        Me.lblAppID.Size = New System.Drawing.Size(37, 13)
        Me.lblAppID.TabIndex = 4
        Me.lblAppID.Text = "AppID"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(64, 16)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(79, 13)
        Me.Label21.TabIndex = 3
        Me.Label21.Text = "Application ID: "
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(72, 118)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(71, 13)
        Me.Label20.TabIndex = 2
        Me.Label20.Text = "U of A Email: "
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(52, 84)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(91, 13)
        Me.Label19.TabIndex = 1
        Me.Label19.Text = "Application Date: "
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(76, 50)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(67, 13)
        Me.Label18.TabIndex = 0
        Me.Label18.Text = "Student ID:  "
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.Label40)
        Me.TabPage4.Controls.Add(Me.Label39)
        Me.TabPage4.Controls.Add(Me.Label38)
        Me.TabPage4.Controls.Add(Me.Label37)
        Me.TabPage4.Controls.Add(Me.Label36)
        Me.TabPage4.Controls.Add(Me.Label35)
        Me.TabPage4.Controls.Add(Me.Label34)
        Me.TabPage4.Controls.Add(Me.Label33)
        Me.TabPage4.Controls.Add(Me.Label32)
        Me.TabPage4.Controls.Add(Me.Label31)
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
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(309, 278)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Test Scores"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ApplicationBindingSource, "Toefl", True))
        Me.Label40.Location = New System.Drawing.Point(146, 218)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(41, 13)
        Me.Label40.TabIndex = 19
        Me.Label40.Text = "TOEFL"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ApplicationBindingSource, "WR", True))
        Me.Label39.Location = New System.Drawing.Point(146, 195)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(26, 13)
        Me.Label39.TabIndex = 18
        Me.Label39.Text = "WR"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ApplicationBindingSource, "V_Q_percent", True))
        Me.Label38.Location = New System.Drawing.Point(146, 171)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(33, 13)
        Me.Label38.TabIndex = 17
        Me.Label38.Text = "V-Q%"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ApplicationBindingSource, "GMAT_Q_Percentage", True))
        Me.Label37.Location = New System.Drawing.Point(146, 149)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(23, 13)
        Me.Label37.TabIndex = 16
        Me.Label37.Text = "Q%"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ApplicationBindingSource, "GMAT_Quan", True))
        Me.Label36.Location = New System.Drawing.Point(146, 127)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(33, 13)
        Me.Label36.TabIndex = 15
        Me.Label36.Text = "Quan"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ApplicationBindingSource, "GMAT_V_Percentage", True))
        Me.Label35.Location = New System.Drawing.Point(146, 105)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(22, 13)
        Me.Label35.TabIndex = 14
        Me.Label35.Text = "V%"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ApplicationBindingSource, "GMAT_Verb", True))
        Me.Label34.Location = New System.Drawing.Point(146, 83)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(29, 13)
        Me.Label34.TabIndex = 13
        Me.Label34.Text = "Verb"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ApplicationBindingSource, "GMAT", True))
        Me.Label33.Location = New System.Drawing.Point(146, 61)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(38, 13)
        Me.Label33.TabIndex = 12
        Me.Label33.Text = "GMAT"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ApplicationBindingSource, "ELAC_Reg", True))
        Me.Label32.Location = New System.Drawing.Point(146, 39)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(34, 13)
        Me.Label32.TabIndex = 11
        Me.Label32.Text = "ELAC"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ApplicationBindingSource, "Eval_I20", True))
        Me.Label31.Location = New System.Drawing.Point(146, 17)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(28, 13)
        Me.Label31.TabIndex = 10
        Me.Label31.Text = "Eval"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(93, 218)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(47, 13)
        Me.Label30.TabIndex = 9
        Me.Label30.Text = "TOEFL: "
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(108, 195)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(32, 13)
        Me.Label29.TabIndex = 8
        Me.Label29.Text = "WR: "
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(104, 171)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(36, 13)
        Me.Label28.TabIndex = 7
        Me.Label28.Text = "V-Q%:"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(111, 149)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(29, 13)
        Me.Label27.TabIndex = 6
        Me.Label27.Text = "Q%: "
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(112, 104)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(28, 13)
        Me.Label26.TabIndex = 5
        Me.Label26.Text = "V%: "
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(101, 127)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(39, 13)
        Me.Label25.TabIndex = 4
        Me.Label25.Text = "Quan: "
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(105, 84)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(35, 13)
        Me.Label24.TabIndex = 3
        Me.Label24.Text = "Verb: "
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(96, 61)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(44, 13)
        Me.Label23.TabIndex = 2
        Me.Label23.Text = "GMAT: "
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(77, 39)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(63, 13)
        Me.Label22.TabIndex = 1
        Me.Label22.Text = "ELAC Req: "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(80, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Eval/ I-20: "
        '
        'lblStuName
        '
        Me.lblStuName.AutoSize = True
        Me.lblStuName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStuName.Location = New System.Drawing.Point(102, 22)
        Me.lblStuName.Name = "lblStuName"
        Me.lblStuName.Size = New System.Drawing.Size(96, 13)
        Me.lblStuName.TabIndex = 2
        Me.lblStuName.Text = "Applicant Name"
        '
        'btnAddInterview
        '
        Me.btnAddInterview.Location = New System.Drawing.Point(105, 383)
        Me.btnAddInterview.Name = "btnAddInterview"
        Me.btnAddInterview.Size = New System.Drawing.Size(95, 23)
        Me.btnAddInterview.TabIndex = 3
        Me.btnAddInterview.Text = "Add Interview"
        Me.btnAddInterview.UseVisualStyleBackColor = True
        '
        'ApplicationTableAdapter
        '
        Me.ApplicationTableAdapter.ClearBeforeFill = True
        '
        'btnView
        '
        Me.btnView.Location = New System.Drawing.Point(307, 383)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(95, 23)
        Me.btnView.TabIndex = 4
        Me.btnView.Text = "View Comments"
        Me.btnView.UseVisualStyleBackColor = True
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Location = New System.Drawing.Point(12, 22)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(88, 13)
        Me.Label41.TabIndex = 5
        Me.Label41.Text = "Applicant Name: "
        '
        'Label_ProgramType
        '
        Me.Label_ProgramType.AutoSize = True
        Me.Label_ProgramType.Font = New System.Drawing.Font("Castellar", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_ProgramType.Location = New System.Drawing.Point(307, 21)
        Me.Label_ProgramType.Name = "Label_ProgramType"
        Me.Label_ProgramType.Size = New System.Drawing.Size(0, 16)
        Me.Label_ProgramType.TabIndex = 6
        '
        'btnViewInterview
        '
        Me.btnViewInterview.Location = New System.Drawing.Point(6, 383)
        Me.btnViewInterview.Name = "btnViewInterview"
        Me.btnViewInterview.Size = New System.Drawing.Size(95, 23)
        Me.btnViewInterview.TabIndex = 7
        Me.btnViewInterview.Text = "View Comments"
        Me.btnViewInterview.UseVisualStyleBackColor = True
        '
        'ApplicantProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(417, 415)
        Me.Controls.Add(Me.btnViewInterview)
        Me.Controls.Add(Me.Label_ProgramType)
        Me.Controls.Add(Me.Label41)
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(Me.btnAddInterview)
        Me.Controls.Add(Me.lblStuName)
        Me.Controls.Add(Me.PersonalTabPage)
        Me.Controls.Add(Me.btnComment)
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
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnComment As Button
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
    Friend WithEvents Label12 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents btnAddInterview As Button
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblPhone As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblYears As Label
    Friend WithEvents lblEmployer As Label
    Friend WithEvents lblEthnicity As Label
    Friend WithEvents lblGender As Label
    Friend WithEvents lblAge As Label
    Friend WithEvents lblStuID As Label
    Friend WithEvents PROJECTS1747DataSet2 As PROJECTS1747DataSet2
    Friend WithEvents ApplicationBindingSource As BindingSource
    Friend WithEvents ApplicationTableAdapter As PROJECTS1747DataSet2TableAdapters.ApplicationTableAdapter
    Friend WithEvents lblGDegree As Label
    Friend WithEvents lblGInstitution As Label
    Friend WithEvents lblMajor As Label
    Friend WithEvents lblDegree As Label
    Friend WithEvents lblGPA As Label
    Friend WithEvents lblInstitution As Label
    Friend WithEvents lblUAEmail As Label
    Friend WithEvents lblAppDate As Label
    Friend WithEvents lblStudID As Label
    Friend WithEvents lblAppID As Label
    Friend WithEvents Label40 As Label
    Friend WithEvents Label39 As Label
    Friend WithEvents Label38 As Label
    Friend WithEvents Label37 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Label31 As Label
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
    Friend WithEvents btnView As Button
    Friend WithEvents Label41 As Label
    Friend WithEvents Label_ProgramType As Label
    Friend WithEvents btnViewInterview As Button
End Class
