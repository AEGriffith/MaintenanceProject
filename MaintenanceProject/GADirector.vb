Public Class GADirector
    Private Sub GARequestsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GARequestsToolStripMenuItem.Click
        GAViewRequest.Show()
        Me.Close()
    End Sub

    Private Sub GAAssignmentsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GAAssignmentsToolStripMenuItem.Click
        GAViewUserAssignments.Show()
        Me.Close()
    End Sub

    Private Sub AssignGAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AssignGAToolStripMenuItem.Click
        GAAssignment.Show()
        Me.Close()
    End Sub
End Class