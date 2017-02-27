<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InterviewAdd
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
        Me.lblStuName = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.numScore = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbComment = New System.Windows.Forms.TextBox()
        Me.btnAccept = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        CType(Me.numScore, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblStuName
        '
        Me.lblStuName.AutoSize = True
        Me.lblStuName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStuName.Location = New System.Drawing.Point(17, 45)
        Me.lblStuName.Name = "lblStuName"
        Me.lblStuName.Size = New System.Drawing.Size(286, 46)
        Me.lblStuName.TabIndex = 0
        Me.lblStuName.Text = "Student Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 160)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 32)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Score"
        '
        'numScore
        '
        Me.numScore.DecimalPlaces = 1
        Me.numScore.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.numScore.Location = New System.Drawing.Point(134, 154)
        Me.numScore.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.numScore.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numScore.Name = "numScore"
        Me.numScore.Size = New System.Drawing.Size(120, 38)
        Me.numScore.TabIndex = 2
        Me.numScore.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 244)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(137, 32)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Comment"
        '
        'tbComment
        '
        Me.tbComment.Location = New System.Drawing.Point(17, 283)
        Me.tbComment.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.tbComment.Multiline = True
        Me.tbComment.Name = "tbComment"
        Me.tbComment.Size = New System.Drawing.Size(703, 256)
        Me.tbComment.TabIndex = 4
        '
        'btnAccept
        '
        Me.btnAccept.Location = New System.Drawing.Point(261, 606)
        Me.btnAccept.Name = "btnAccept"
        Me.btnAccept.Size = New System.Drawing.Size(218, 58)
        Me.btnAccept.TabIndex = 5
        Me.btnAccept.Text = "&Accept"
        Me.btnAccept.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(485, 606)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(218, 58)
        Me.btnCancel.TabIndex = 6
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'InterviewAdd
        '
        Me.AcceptButton = Me.btnAccept
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(733, 719)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnAccept)
        Me.Controls.Add(Me.tbComment)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.numScore)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblStuName)
        Me.Name = "InterviewAdd"
        Me.Text = "Interview Score"
        CType(Me.numScore, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblStuName As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents numScore As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents tbComment As TextBox
    Friend WithEvents btnAccept As Button
    Friend WithEvents btnCancel As Button
End Class
