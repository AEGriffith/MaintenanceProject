Public Class GAViewUserAssignments
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
End Class