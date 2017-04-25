Public Class GAViewUserAssignments
    Dim StudentName
    Dim StudentID
    Dim SupervisorID
    Dim FormID
    Dim Semester
    Dim Hours
    Dim SupervisorName

    Private Sub GAViewUserAssignments_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PROJECTS1747DataSet6.viewGAAssignments' table. You can move, or remove it, as needed.
        Me.ViewGAAssignmentsTableAdapter.Fill(Me.PROJECTS1747DataSet6.viewGAAssignments)

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter, rb1.CheckedChanged, rb2.CheckedChanged
        If rb1.Checked = True Then
            ViewGAAssignmentsBindingSource.Filter = "Semester = 'Fa2017'"
        Else
            ViewGAAssignmentsBindingSource.Filter = "Semester = 'Sp2018'"
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnReassign_Click(sender As Object, e As EventArgs) Handles btnReassign.Click
        StudentName = Me.DataGridView1.CurrentRow.Cells(1).Value
        StudentID = Me.DataGridView1.CurrentRow.Cells(5).Value
        SupervisorID = Me.DataGridView1.CurrentRow.Cells(6).Value
        FormID = Me.DataGridView1.CurrentRow.Cells(4).Value
        Semester = Me.DataGridView1.CurrentRow.Cells(2).Value
        Hours = Me.DataGridView1.CurrentRow.Cells(3).Value
        SupervisorName = Me.DataGridView1.CurrentRow.Cells(0).Value

        GAReassignment.ShowDialog()
    End Sub


    Friend Function getStudentName()
        Return StudentName
    End Function

    Friend Function getStudentID()
        Return StudentID
    End Function

    Friend Function getSupervisorID()
        Return SupervisorID
    End Function

    Friend Function getFormID()
        Return FormID
    End Function

    Friend Function getSemester()
        Return Semester
    End Function

    Friend Function getHours()
        Return Hours
    End Function

    Friend Function getSupervisorName()
        Return SupervisorName
    End Function
End Class