<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DirectorSystemChoice
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
        Me.btnAdmissions = New System.Windows.Forms.Button()
        Me.btnEnrollment = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnAdmissions
        '
        Me.btnAdmissions.Location = New System.Drawing.Point(12, 64)
        Me.btnAdmissions.Name = "btnAdmissions"
        Me.btnAdmissions.Size = New System.Drawing.Size(304, 298)
        Me.btnAdmissions.TabIndex = 0
        Me.btnAdmissions.Text = "Admissions"
        Me.btnAdmissions.UseVisualStyleBackColor = True
        '
        'btnEnrollment
        '
        Me.btnEnrollment.Location = New System.Drawing.Point(322, 64)
        Me.btnEnrollment.Name = "btnEnrollment"
        Me.btnEnrollment.Size = New System.Drawing.Size(304, 298)
        Me.btnEnrollment.TabIndex = 1
        Me.btnEnrollment.Text = "Enrollment"
        Me.btnEnrollment.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(445, 32)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Welcome! Please select a system."
        '
        'DirectorSystemChoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(639, 374)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnEnrollment)
        Me.Controls.Add(Me.btnAdmissions)
        Me.Name = "DirectorSystemChoice"
        Me.Text = "Choose System"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAdmissions As Button
    Friend WithEvents btnEnrollment As Button
    Friend WithEvents Label1 As Label
End Class
