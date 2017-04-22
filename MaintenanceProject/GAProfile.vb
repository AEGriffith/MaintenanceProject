Public Class GAProfile

    Dim StudentName = GAViewRequest.getStudentName()
    Dim StudentID = GAViewRequest.getStudentID()

    Private Sub GAProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PROJECTS1747DataSet15.Student' table. You can move, or remove it, as needed.
        Me.StudentTableAdapter.Fill(Me.PROJECTS1747DataSet15.Student)
        'TODO: This line of code loads data into the 'PROJECTS1747DataSet15.viewGAsRequestedBy' table. You can move, or remove it, as needed.
        Me.ViewGAsRequestedByTableAdapter.Fill(Me.PROJECTS1747DataSet15.viewGAsRequestedBy)


        Label1.Text = StudentName
        Me.Text = StudentName
        StudentBindingSource.Filter = String.Format("Student_ID = '{0}'", StudentID)
        ViewGAsRequestedByBindingSource.Filter = String.Format("Student_ID = '{0}'", StudentID)
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click, CloseToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub GAAssignmentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GAAssignmentToolStripMenuItem.Click
        GAViewUserAssignments.Show()
        Me.Close()
    End Sub

    Private Sub AssignGAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AssignGAsToolStripMenuItem.Click
        GAAssignment.Show()
        Me.Close()
    End Sub
End Class