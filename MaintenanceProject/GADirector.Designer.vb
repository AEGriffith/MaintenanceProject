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
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GARequestsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GAAssignmentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AssignGAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(40, 40)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.ViewToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(625, 49)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(75, 48)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GARequestsToolStripMenuItem, Me.GAAssignmentsToolStripMenuItem})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(94, 48)
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
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AssignGAToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(80, 48)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'AssignGAToolStripMenuItem
        '
        Me.AssignGAToolStripMenuItem.Name = "AssignGAToolStripMenuItem"
        Me.AssignGAToolStripMenuItem.Size = New System.Drawing.Size(327, 46)
        Me.AssignGAToolStripMenuItem.Text = "Assign GA"
        '
        'GADirector
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(625, 442)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "GADirector"
        Me.Text = "Graduate Assistant Management"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
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
End Class
