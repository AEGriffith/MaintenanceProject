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
        Me.lblStuName.Location = New System.Drawing.Point(6, 19)
        Me.lblStuName.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblStuName.Name = "lblStuName"
        Me.lblStuName.Size = New System.Drawing.Size(124, 20)
        Me.lblStuName.TabIndex = 0
        Me.lblStuName.Text = "Student Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 67)
        Me.Label2.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Score"
        '
        'numScore
        '
        Me.numScore.DecimalPlaces = 1
        Me.numScore.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.numScore.Location = New System.Drawing.Point(50, 65)
        Me.numScore.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.numScore.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.numScore.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numScore.Name = "numScore"
        Me.numScore.Size = New System.Drawing.Size(45, 20)
        Me.numScore.TabIndex = 2
        Me.numScore.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 102)
        Me.Label3.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Comment"
        '
        'tbComment
        '
        Me.tbComment.Location = New System.Drawing.Point(6, 119)
        Me.tbComment.Multiline = True
        Me.tbComment.Name = "tbComment"
        Me.tbComment.Size = New System.Drawing.Size(266, 110)
        Me.tbComment.TabIndex = 4
        '
        'btnAccept
        '
        Me.btnAccept.Location = New System.Drawing.Point(98, 254)
        Me.btnAccept.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.btnAccept.Name = "btnAccept"
        Me.btnAccept.Size = New System.Drawing.Size(82, 24)
        Me.btnAccept.TabIndex = 5
        Me.btnAccept.Text = "&Accept"
        Me.btnAccept.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(182, 254)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(82, 24)
        Me.btnCancel.TabIndex = 6
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'InterviewAdd
        '
        Me.AcceptButton = Me.btnAccept
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(275, 302)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnAccept)
        Me.Controls.Add(Me.tbComment)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.numScore)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblStuName)
        Me.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
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
