<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PMISReq
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbES = New System.Windows.Forms.RadioButton()
        Me.rbERP = New System.Windows.Forms.RadioButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(59, 296)
        Me.Label2.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(221, 32)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Requirements: "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(59, 62)
        Me.Label1.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(230, 32)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Concentrations:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbES)
        Me.GroupBox1.Controls.Add(Me.rbERP)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(117, 124)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.GroupBox1.Size = New System.Drawing.Size(853, 122)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        '
        'rbES
        '
        Me.rbES.AutoSize = True
        Me.rbES.Location = New System.Drawing.Point(523, 45)
        Me.rbES.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.rbES.Name = "rbES"
        Me.rbES.Size = New System.Drawing.Size(297, 36)
        Me.rbES.TabIndex = 3
        Me.rbES.TabStop = True
        Me.rbES.Text = "Enterprise Systems"
        Me.rbES.UseVisualStyleBackColor = True
        '
        'rbERP
        '
        Me.rbERP.AutoSize = True
        Me.rbERP.Location = New System.Drawing.Point(16, 45)
        Me.rbERP.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.rbERP.Name = "rbERP"
        Me.rbERP.Size = New System.Drawing.Size(430, 36)
        Me.rbERP.TabIndex = 2
        Me.rbERP.TabStop = True
        Me.rbERP.Text = "Enterprise Resource Planning"
        Me.rbERP.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(117, 365)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1869, 1493)
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'PMISReq
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(2091, 1929)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.Name = "PMISReq"
        Me.Text = "PMIS Requirements"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbES As RadioButton
    Friend WithEvents rbERP As RadioButton
    Friend WithEvents PictureBox1 As PictureBox
End Class
