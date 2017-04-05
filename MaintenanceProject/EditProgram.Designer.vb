<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditProgram
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
        Me.lblStuID = New System.Windows.Forms.Label()
        Me.lblConcentration = New System.Windows.Forms.Label()
        Me.lblProgram = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cbConcentration = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbProgram = New System.Windows.Forms.ComboBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblStuID
        '
        Me.lblStuID.AutoSize = True
        Me.lblStuID.Location = New System.Drawing.Point(26, 100)
        Me.lblStuID.Name = "lblStuID"
        Me.lblStuID.Size = New System.Drawing.Size(102, 32)
        Me.lblStuID.TabIndex = 16
        Me.lblStuID.Text = "Label1"
        '
        'lblConcentration
        '
        Me.lblConcentration.AutoSize = True
        Me.lblConcentration.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConcentration.Location = New System.Drawing.Point(497, 96)
        Me.lblConcentration.Name = "lblConcentration"
        Me.lblConcentration.Size = New System.Drawing.Size(105, 36)
        Me.lblConcentration.TabIndex = 15
        Me.lblConcentration.Text = "Label1"
        '
        'lblProgram
        '
        Me.lblProgram.AutoSize = True
        Me.lblProgram.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProgram.Location = New System.Drawing.Point(482, 46)
        Me.lblProgram.Name = "lblProgram"
        Me.lblProgram.Size = New System.Drawing.Size(120, 39)
        Me.lblProgram.TabIndex = 14
        Me.lblProgram.Text = "Label1"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(25, 46)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(126, 39)
        Me.lblName.TabIndex = 13
        Me.lblName.Text = "Label1"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(308, 285)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(133, 50)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "Update"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cbConcentration
        '
        Me.cbConcentration.FormattingEnabled = True
        Me.cbConcentration.Location = New System.Drawing.Point(329, 218)
        Me.cbConcentration.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbConcentration.Name = "cbConcentration"
        Me.cbConcentration.Size = New System.Drawing.Size(273, 39)
        Me.cbConcentration.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(334, 166)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(193, 32)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Concentration"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 180)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 32)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Program"
        '
        'cbProgram
        '
        Me.cbProgram.FormattingEnabled = True
        Me.cbProgram.Items.AddRange(New Object() {"MIS", "PMIS"})
        Me.cbProgram.Location = New System.Drawing.Point(12, 218)
        Me.cbProgram.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbProgram.Name = "cbProgram"
        Me.cbProgram.Size = New System.Drawing.Size(273, 39)
        Me.cbProgram.TabIndex = 17
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(447, 285)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(155, 50)
        Me.btnClose.TabIndex = 22
        Me.btnClose.Text = "Cancel"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'EditProgram
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(634, 351)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cbConcentration)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbProgram)
        Me.Controls.Add(Me.lblStuID)
        Me.Controls.Add(Me.lblConcentration)
        Me.Controls.Add(Me.lblProgram)
        Me.Controls.Add(Me.lblName)
        Me.Name = "EditProgram"
        Me.Text = "EditProgram"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblStuID As Label
    Friend WithEvents lblConcentration As Label
    Friend WithEvents lblProgram As Label
    Friend WithEvents lblName As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents cbConcentration As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cbProgram As ComboBox
    Friend WithEvents btnClose As Button
End Class
