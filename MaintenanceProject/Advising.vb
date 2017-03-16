Public Class Advising
    'Delcare Variables
    Dim SelectedStudent
    Dim FirstName
    Dim LastName
    Dim Program
    Dim Concentration


    Private Sub Advising_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PROJECTS1747DataSet.viewStudent' table. You can move, or remove it, as needed.
        Me.ViewStudentTableAdapter.Fill(Me.PROJECTS1747DataSet.viewStudent)
        'This is important
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect


    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        SelectedStudent = Me.DataGridView1.CurrentRow.Cells(0).Value
        FirstName = Me.DataGridView1.CurrentRow.Cells(1).Value
        LastName = Me.DataGridView1.CurrentRow.Cells(2).Value
        Program = Me.DataGridView1.CurrentRow.Cells(3).Value
        Concentration = Me.DataGridView1.CurrentRow.Cells(4).Value
        StudentProfile.Show()
    End Sub

    Friend Function getStudentID()
        Return SelectedStudent
    End Function

    Friend Function getStudentName()
        Return LastName & ", " & FirstName
    End Function

    Friend Function getProgram()
        Return Program
    End Function

    Friend Function getConcentration()
        Return Concentration
    End Function


    Private Sub MISToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MISToolStripMenuItem1.Click
        MISReq.Show()
    End Sub

    Private Sub PMISToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PMISToolStripMenuItem1.Click
        PMISReq.Show()
    End Sub
End Class