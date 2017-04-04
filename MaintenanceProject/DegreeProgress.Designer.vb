<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DegreeProgress
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgvTakenCourses = New System.Windows.Forms.DataGridView()
        Me.dgvRemainingCourses = New System.Windows.Forms.DataGridView()
        Me.lblConcentration = New System.Windows.Forms.Label()
        Me.lblProgram = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblStuID = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        CType(Me.dgvTakenCourses, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvRemainingCourses, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 596)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(268, 32)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Classes Remaining:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(210, 32)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Classes Taken:"
        '
        'dgvTakenCourses
        '
        Me.dgvTakenCourses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvTakenCourses.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvTakenCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTakenCourses.Location = New System.Drawing.Point(12, 163)
        Me.dgvTakenCourses.Name = "dgvTakenCourses"
        Me.dgvTakenCourses.RowTemplate.Height = 40
        Me.dgvTakenCourses.Size = New System.Drawing.Size(1132, 405)
        Me.dgvTakenCourses.TabIndex = 5
        '
        'dgvRemainingCourses
        '
        Me.dgvRemainingCourses.AllowUserToAddRows = False
        Me.dgvRemainingCourses.AllowUserToDeleteRows = False
        Me.dgvRemainingCourses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvRemainingCourses.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvRemainingCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRemainingCourses.Location = New System.Drawing.Point(12, 631)
        Me.dgvRemainingCourses.Name = "dgvRemainingCourses"
        Me.dgvRemainingCourses.ReadOnly = True
        Me.dgvRemainingCourses.RowTemplate.Height = 40
        Me.dgvRemainingCourses.Size = New System.Drawing.Size(1132, 416)
        Me.dgvRemainingCourses.TabIndex = 4
        '
        'lblConcentration
        '
        Me.lblConcentration.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblConcentration.AutoSize = True
        Me.lblConcentration.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConcentration.Location = New System.Drawing.Point(1045, 61)
        Me.lblConcentration.Name = "lblConcentration"
        Me.lblConcentration.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblConcentration.Size = New System.Drawing.Size(105, 36)
        Me.lblConcentration.TabIndex = 10
        Me.lblConcentration.Text = "Label1"
        Me.lblConcentration.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblProgram
        '
        Me.lblProgram.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblProgram.AutoSize = True
        Me.lblProgram.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProgram.Location = New System.Drawing.Point(1031, 9)
        Me.lblProgram.Name = "lblProgram"
        Me.lblProgram.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblProgram.Size = New System.Drawing.Size(120, 39)
        Me.lblProgram.TabIndex = 9
        Me.lblProgram.Text = "Label1"
        Me.lblProgram.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(17, 9)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(126, 39)
        Me.lblName.TabIndex = 8
        Me.lblName.Text = "Label1"
        '
        'lblStuID
        '
        Me.lblStuID.AutoSize = True
        Me.lblStuID.Location = New System.Drawing.Point(18, 61)
        Me.lblStuID.Name = "lblStuID"
        Me.lblStuID.Size = New System.Drawing.Size(102, 32)
        Me.lblStuID.TabIndex = 11
        Me.lblStuID.Text = "Label1"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(931, 1112)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(213, 55)
        Me.btnClose.TabIndex = 33
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'DegreeProgress
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1183, 1178)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lblStuID)
        Me.Controls.Add(Me.lblConcentration)
        Me.Controls.Add(Me.lblProgram)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dgvTakenCourses)
        Me.Controls.Add(Me.dgvRemainingCourses)
        Me.Name = "DegreeProgress"
        Me.Text = "DegreeProgress"
        CType(Me.dgvTakenCourses, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvRemainingCourses, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents dgvTakenCourses As DataGridView
    Friend WithEvents dgvRemainingCourses As DataGridView
    Friend WithEvents lblConcentration As Label
    Friend WithEvents lblProgram As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblStuID As Label
    Friend WithEvents btnClose As Button
End Class
