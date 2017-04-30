<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GADirector
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AssignGAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GARequestsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GAAssignmentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.dgvTaskTypeHours = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvHoursProgress = New System.Windows.Forms.DataGridView()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.dgvTaskTypeHours, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvHoursProgress, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(40, 40)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.ViewToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1662, 49)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(75, 45)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AssignGAToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(80, 45)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'AssignGAToolStripMenuItem
        '
        Me.AssignGAToolStripMenuItem.Name = "AssignGAToolStripMenuItem"
        Me.AssignGAToolStripMenuItem.Size = New System.Drawing.Size(268, 46)
        Me.AssignGAToolStripMenuItem.Text = "Assign GA"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GARequestsToolStripMenuItem, Me.GAAssignmentsToolStripMenuItem})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(94, 45)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'GARequestsToolStripMenuItem
        '
        Me.GARequestsToolStripMenuItem.Name = "GARequestsToolStripMenuItem"
        Me.GARequestsToolStripMenuItem.Size = New System.Drawing.Size(350, 46)
        Me.GARequestsToolStripMenuItem.Text = "GA Requests"
        '
        'GAAssignmentsToolStripMenuItem
        '
        Me.GAAssignmentsToolStripMenuItem.Name = "GAAssignmentsToolStripMenuItem"
        Me.GAAssignmentsToolStripMenuItem.Size = New System.Drawing.Size(350, 46)
        Me.GAAssignmentsToolStripMenuItem.Text = "GA Assignments"
        '
        'dgvTaskTypeHours
        '
        Me.dgvTaskTypeHours.AllowUserToAddRows = False
        Me.dgvTaskTypeHours.AllowUserToDeleteRows = False
        Me.dgvTaskTypeHours.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvTaskTypeHours.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvTaskTypeHours.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTaskTypeHours.Location = New System.Drawing.Point(12, 161)
        Me.dgvTaskTypeHours.Name = "dgvTaskTypeHours"
        Me.dgvTaskTypeHours.ReadOnly = True
        Me.dgvTaskTypeHours.RowTemplate.Height = 40
        Me.dgvTaskTypeHours.Size = New System.Drawing.Size(1617, 436)
        Me.dgvTaskTypeHours.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 117)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(527, 32)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Total Task Hours by Type and Semester:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 620)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(533, 32)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Assistantship Hours Fulfillment Progress:"
        '
        'dgvHoursProgress
        '
        Me.dgvHoursProgress.AllowUserToAddRows = False
        Me.dgvHoursProgress.AllowUserToDeleteRows = False
        Me.dgvHoursProgress.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvHoursProgress.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvHoursProgress.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHoursProgress.Location = New System.Drawing.Point(12, 664)
        Me.dgvHoursProgress.Name = "dgvHoursProgress"
        Me.dgvHoursProgress.ReadOnly = True
        Me.dgvHoursProgress.RowTemplate.Height = 40
        Me.dgvHoursProgress.Size = New System.Drawing.Size(1617, 436)
        Me.dgvHoursProgress.TabIndex = 3
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(1491, 1124)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(138, 60)
        Me.btnClose.TabIndex = 5
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'GADirector
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1662, 1208)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgvHoursProgress)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvTaskTypeHours)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "GADirector"
        Me.Text = "Graduate Assistant Management"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.dgvTaskTypeHours, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvHoursProgress, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GARequestsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GAAssignmentsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AssignGAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents dgvTaskTypeHours As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dgvHoursProgress As DataGridView
    Friend WithEvents btnClose As Button
End Class
