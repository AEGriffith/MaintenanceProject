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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DirectorSystemChoice))
        Me.btnAdmissions = New System.Windows.Forms.Button()
        Me.btnEnrollment = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnGA = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnAdmissions
        '
        Me.btnAdmissions.Location = New System.Drawing.Point(4, 27)
        Me.btnAdmissions.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.btnAdmissions.Name = "btnAdmissions"
        Me.btnAdmissions.Size = New System.Drawing.Size(81, 82)
        Me.btnAdmissions.TabIndex = 0
        Me.btnAdmissions.Text = "Admissions"
        Me.btnAdmissions.UseVisualStyleBackColor = True
        '
        'btnEnrollment
        '
        Me.btnEnrollment.Location = New System.Drawing.Point(89, 27)
        Me.btnEnrollment.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.btnEnrollment.Name = "btnEnrollment"
        Me.btnEnrollment.Size = New System.Drawing.Size(82, 82)
        Me.btnEnrollment.TabIndex = 1
        Me.btnEnrollment.Text = "Enrollment"
        Me.btnEnrollment.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 5)
        Me.Label1.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(168, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Welcome! Please select a system."
        '
        'btnGA
        '
        Me.btnGA.Location = New System.Drawing.Point(174, 27)
        Me.btnGA.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.btnGA.Name = "btnGA"
        Me.btnGA.Size = New System.Drawing.Size(82, 82)
        Me.btnGA.TabIndex = 3
        Me.btnGA.Text = "GA Management"
        Me.btnGA.UseVisualStyleBackColor = True
        '
        'DirectorSystemChoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(260, 115)
        Me.Controls.Add(Me.btnGA)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnEnrollment)
        Me.Controls.Add(Me.btnAdmissions)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.Name = "DirectorSystemChoice"
        Me.Text = "Choose System"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAdmissions As Button
    Friend WithEvents btnEnrollment As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnGA As Button
End Class
