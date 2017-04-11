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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Application))
        Me.btnAddComment = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbComment = New System.Windows.Forms.TextBox()
        Me.lblStuName = New System.Windows.Forms.Label()
        Me.cbRecommendation = New System.Windows.Forms.ComboBox()
        Me.Label_decisionsuggested = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnAddComment
        '
        Me.btnAddComment.Location = New System.Drawing.Point(89, 246)
        Me.btnAddComment.Name = "btnAddComment"
        Me.btnAddComment.Size = New System.Drawing.Size(91, 23)
        Me.btnAddComment.TabIndex = 0
        Me.btnAddComment.Text = "Update"
        Me.btnAddComment.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Comments:"
        '
        'tbComment
        '
        Me.tbComment.Location = New System.Drawing.Point(11, 116)
        Me.tbComment.Multiline = True
        Me.tbComment.Name = "tbComment"
        Me.tbComment.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbComment.Size = New System.Drawing.Size(283, 109)
        Me.tbComment.TabIndex = 2
        '
        'lblStuName
        '
        Me.lblStuName.AutoSize = True
        Me.lblStuName.BackColor = System.Drawing.SystemColors.Control
        Me.lblStuName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStuName.Location = New System.Drawing.Point(7, 19)
        Me.lblStuName.Name = "lblStuName"
        Me.lblStuName.Size = New System.Drawing.Size(124, 20)
        Me.lblStuName.TabIndex = 4
        Me.lblStuName.Text = "Student Name"
        '
        'cbRecommendation
        '
        Me.cbRecommendation.FormattingEnabled = True
        Me.cbRecommendation.Location = New System.Drawing.Point(130, 55)
        Me.cbRecommendation.Name = "cbRecommendation"
        Me.cbRecommendation.Size = New System.Drawing.Size(121, 21)
        Me.cbRecommendation.TabIndex = 5
        '
        'Label_decisionsuggested
        '
        Me.Label_decisionsuggested.AutoSize = True
        Me.Label_decisionsuggested.Location = New System.Drawing.Point(8, 55)
        Me.Label_decisionsuggested.Name = "Label_decisionsuggested"
        Me.Label_decisionsuggested.Size = New System.Drawing.Size(105, 13)
        Me.Label_decisionsuggested.TabIndex = 6
        Me.Label_decisionsuggested.Text = "Suggested Decision:"
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(194, 246)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(91, 23)
        Me.btnCancel.TabIndex = 7
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Application
        '
        Me.AcceptButton = Me.btnAddComment
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(306, 294)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.Label_decisionsuggested)
        Me.Controls.Add(Me.cbRecommendation)
        Me.Controls.Add(Me.lblStuName)
        Me.Controls.Add(Me.tbComment)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnAddComment)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Application"
        Me.Text = "Application Comments"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAddComment As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents tbComment As TextBox
    Friend WithEvents lblStuName As Label
    Friend WithEvents cbRecommendation As ComboBox
    Friend WithEvents Label_decisionsuggested As Label
    Friend WithEvents btnCancel As Button
End Class
