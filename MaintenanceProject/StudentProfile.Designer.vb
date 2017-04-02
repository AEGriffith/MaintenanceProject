<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StudentProfile
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StudentProfile))
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblProgram = New System.Windows.Forms.Label()
        Me.lblConcentration = New System.Windows.Forms.Label()
        Me.tbStudentProfile = New System.Windows.Forms.TabControl()
        Me.tpProfile = New System.Windows.Forms.TabPage()
        Me.tbEdit = New System.Windows.Forms.TabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cbConcentration = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbProgram = New System.Windows.Forms.ComboBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.tbStudentProfile.SuspendLayout()
        Me.tbEdit.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(21, 28)
        Me.lblName.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(57, 17)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Label1"
        '
        'lblProgram
        '
        Me.lblProgram.AutoSize = True
        Me.lblProgram.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProgram.Location = New System.Drawing.Point(21, 50)
        Me.lblProgram.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblProgram.Name = "lblProgram"
        Me.lblProgram.Size = New System.Drawing.Size(51, 17)
        Me.lblProgram.TabIndex = 1
        Me.lblProgram.Text = "Label1"
        '
        'lblConcentration
        '
        Me.lblConcentration.AutoSize = True
        Me.lblConcentration.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConcentration.Location = New System.Drawing.Point(21, 72)
        Me.lblConcentration.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblConcentration.Name = "lblConcentration"
        Me.lblConcentration.Size = New System.Drawing.Size(45, 15)
        Me.lblConcentration.TabIndex = 2
        Me.lblConcentration.Text = "Label1"
        '
        'tbStudentProfile
        '
        Me.tbStudentProfile.Controls.Add(Me.tpProfile)
        Me.tbStudentProfile.Controls.Add(Me.tbEdit)
        Me.tbStudentProfile.Location = New System.Drawing.Point(4, 114)
        Me.tbStudentProfile.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.tbStudentProfile.Name = "tbStudentProfile"
        Me.tbStudentProfile.SelectedIndex = 0
        Me.tbStudentProfile.Size = New System.Drawing.Size(636, 269)
        Me.tbStudentProfile.TabIndex = 3
        '
        'tpProfile
        '
        Me.tpProfile.Location = New System.Drawing.Point(4, 22)
        Me.tpProfile.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.tpProfile.Name = "tpProfile"
        Me.tpProfile.Padding = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.tpProfile.Size = New System.Drawing.Size(628, 243)
        Me.tpProfile.TabIndex = 0
        Me.tpProfile.Text = "Information"
        Me.tpProfile.UseVisualStyleBackColor = True
        '
        'tbEdit
        '
        Me.tbEdit.Controls.Add(Me.Button1)
        Me.tbEdit.Controls.Add(Me.cbConcentration)
        Me.tbEdit.Controls.Add(Me.Label2)
        Me.tbEdit.Controls.Add(Me.Label1)
        Me.tbEdit.Controls.Add(Me.cbProgram)
        Me.tbEdit.Location = New System.Drawing.Point(4, 22)
        Me.tbEdit.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.tbEdit.Name = "tbEdit"
        Me.tbEdit.Padding = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.tbEdit.Size = New System.Drawing.Size(628, 243)
        Me.tbEdit.TabIndex = 1
        Me.tbEdit.Text = "Edit"
        Me.tbEdit.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(68, 105)
        Me.Button1.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(50, 21)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Update"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cbConcentration
        '
        Me.cbConcentration.FormattingEnabled = True
        Me.cbConcentration.Location = New System.Drawing.Point(15, 74)
        Me.cbConcentration.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.cbConcentration.Name = "cbConcentration"
        Me.cbConcentration.Size = New System.Drawing.Size(105, 21)
        Me.cbConcentration.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 52)
        Me.Label2.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Concentration"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 10)
        Me.Label1.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Program"
        '
        'cbProgram
        '
        Me.cbProgram.FormattingEnabled = True
        Me.cbProgram.Items.AddRange(New Object() {"MIS", "PMIS"})
        Me.cbProgram.Location = New System.Drawing.Point(15, 26)
        Me.cbProgram.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.cbProgram.Name = "cbProgram"
        Me.cbProgram.Size = New System.Drawing.Size(105, 21)
        Me.cbProgram.TabIndex = 0
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(570, 397)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(58, 21)
        Me.btnClose.TabIndex = 4
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'StudentProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(478, 418)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.tbStudentProfile)
        Me.Controls.Add(Me.lblConcentration)
        Me.Controls.Add(Me.lblProgram)
        Me.Controls.Add(Me.lblName)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.Name = "StudentProfile"
        Me.Text = "StudentProfile"
        Me.tbStudentProfile.ResumeLayout(False)
        Me.tbEdit.ResumeLayout(False)
        Me.tbEdit.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents lblProgram As Label
    Friend WithEvents lblConcentration As Label
    Friend WithEvents tbStudentProfile As TabControl
    Friend WithEvents tpProfile As TabPage
    Friend WithEvents tbEdit As TabPage
    Friend WithEvents cbConcentration As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cbProgram As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents btnClose As Button
End Class
