<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Application
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
        Me.btnAddComment = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbComment = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblStuName = New System.Windows.Forms.Label()
        Me.ComboBox_suggesteddecision = New System.Windows.Forms.ComboBox()
        Me.Label_decisionsuggested = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnAddComment
        '
        Me.btnAddComment.Location = New System.Drawing.Point(220, 296)
        Me.btnAddComment.Name = "btnAddComment"
        Me.btnAddComment.Size = New System.Drawing.Size(91, 23)
        Me.btnAddComment.TabIndex = 0
        Me.btnAddComment.Text = "Add Comment"
        Me.btnAddComment.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Comments:"
        '
        'tbComment
        '
        Me.tbComment.Location = New System.Drawing.Point(12, 116)
        Me.tbComment.Multiline = True
        Me.tbComment.Name = "tbComment"
        Me.tbComment.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbComment.Size = New System.Drawing.Size(299, 165)
        Me.tbComment.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Applicant Name: "
        '
        'lblStuName
        '
        Me.lblStuName.AutoSize = True
        Me.lblStuName.BackColor = System.Drawing.SystemColors.Control
        Me.lblStuName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStuName.Location = New System.Drawing.Point(106, 19)
        Me.lblStuName.Name = "lblStuName"
        Me.lblStuName.Size = New System.Drawing.Size(51, 13)
        Me.lblStuName.TabIndex = 4
        Me.lblStuName.Text = "Student"
        '
        'ComboBox_suggesteddecision
        '
        Me.ComboBox_suggesteddecision.FormattingEnabled = True
        Me.ComboBox_suggesteddecision.Items.AddRange(New Object() {"Gold", "Silver", "Assistantship", "Waitlist", "Reject"})
        Me.ComboBox_suggesteddecision.Location = New System.Drawing.Point(190, 55)
        Me.ComboBox_suggesteddecision.Name = "ComboBox_suggesteddecision"
        Me.ComboBox_suggesteddecision.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox_suggesteddecision.TabIndex = 5
        '
        'Label_decisionsuggested
        '
        Me.Label_decisionsuggested.AutoSize = True
        Me.Label_decisionsuggested.Location = New System.Drawing.Point(9, 58)
        Me.Label_decisionsuggested.Name = "Label_decisionsuggested"
        Me.Label_decisionsuggested.Size = New System.Drawing.Size(102, 13)
        Me.Label_decisionsuggested.TabIndex = 6
        Me.Label_decisionsuggested.Text = "Suggested Decision"
        '
        'Application
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(325, 325)
        Me.Controls.Add(Me.Label_decisionsuggested)
        Me.Controls.Add(Me.ComboBox_suggesteddecision)
        Me.Controls.Add(Me.lblStuName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbComment)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnAddComment)
        Me.Name = "Application"
        Me.Text = "Add Comment"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAddComment As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents tbComment As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblStuName As Label
    Friend WithEvents ComboBox_suggesteddecision As ComboBox
    Friend WithEvents Label_decisionsuggested As Label
End Class
