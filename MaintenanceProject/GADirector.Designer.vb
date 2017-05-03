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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GADirector))
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
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(2, 1, 0, 1)
        Me.MenuStrip1.Size = New System.Drawing.Size(623, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 22)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AssignGAToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 22)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'AssignGAToolStripMenuItem
        '
        Me.AssignGAToolStripMenuItem.Name = "AssignGAToolStripMenuItem"
        Me.AssignGAToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.AssignGAToolStripMenuItem.Text = "Assign GA"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GARequestsToolStripMenuItem, Me.GAAssignmentsToolStripMenuItem})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(44, 22)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'GARequestsToolStripMenuItem
        '
        Me.GARequestsToolStripMenuItem.Name = "GARequestsToolStripMenuItem"
        Me.GARequestsToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.GARequestsToolStripMenuItem.Text = "GA Requests"
        '
        'GAAssignmentsToolStripMenuItem
        '
        Me.GAAssignmentsToolStripMenuItem.Name = "GAAssignmentsToolStripMenuItem"
        Me.GAAssignmentsToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.GAAssignmentsToolStripMenuItem.Text = "GA Assignments"
        '
        'dgvTaskTypeHours
        '
        Me.dgvTaskTypeHours.AllowUserToAddRows = False
        Me.dgvTaskTypeHours.AllowUserToDeleteRows = False
        Me.dgvTaskTypeHours.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvTaskTypeHours.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvTaskTypeHours.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTaskTypeHours.Location = New System.Drawing.Point(4, 68)
        Me.dgvTaskTypeHours.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.dgvTaskTypeHours.Name = "dgvTaskTypeHours"
        Me.dgvTaskTypeHours.ReadOnly = True
        Me.dgvTaskTypeHours.RowTemplate.Height = 40
        Me.dgvTaskTypeHours.Size = New System.Drawing.Size(606, 183)
        Me.dgvTaskTypeHours.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 49)
        Me.Label1.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(201, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Total Task Hours by Type and Semester:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 260)
        Me.Label2.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(195, 13)
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
        Me.dgvHoursProgress.Location = New System.Drawing.Point(4, 278)
        Me.dgvHoursProgress.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.dgvHoursProgress.Name = "dgvHoursProgress"
        Me.dgvHoursProgress.ReadOnly = True
        Me.dgvHoursProgress.RowTemplate.Height = 40
        Me.dgvHoursProgress.Size = New System.Drawing.Size(606, 183)
        Me.dgvHoursProgress.TabIndex = 3
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(559, 471)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(52, 25)
        Me.btnClose.TabIndex = 5
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'GADirector
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(623, 442)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgvHoursProgress)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvTaskTypeHours)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
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
