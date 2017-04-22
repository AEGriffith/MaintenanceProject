Public Class GAViewRequest

    Dim SelectedForm
    Dim SelectedStudent
    Dim StudentName
    Dim SupervisorName

    Private Sub GAViewRequest_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'TODO: This line of code loads data into the 'PROJECTS1747DataSet15.viewGARequest' table. You can move, or remove it, as needed.
        Me.ViewGARequestTableAdapter.Fill(Me.PROJECTS1747DataSet15.viewGARequest)

        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect


    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick, DataGridView1.CellEnter
        'TODO: This line of code loads data into the 'PROJECTS1747DataSet5.viewRequestedGA' table. You can move, or remove it, as needed.
        Me.ViewRequestedGATableAdapter.Fill(Me.PROJECTS1747DataSet15.viewRequestedGA)
        SelectedForm = Me.DataGridView1.CurrentRow.Cells(0).Value
        SupervisorName = Me.DataGridView1.CurrentRow.Cells(2).Value & ", " & Me.DataGridView1.CurrentRow.Cells(1).Value
        ViewRequestedGABindingSource.Filter = String.Format("Form = '{0}'", SelectedForm)
    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick
        SelectedStudent = Me.DataGridView2.CurrentRow.Cells(14).Value
    End Sub

    Friend Function getForm()
        Return SelectedForm
    End Function

    Friend Function getSupervisorName()
        Return SupervisorName
    End Function

    Friend Function getStudentID()
        Return SelectedStudent
    End Function

    Friend Sub setStudentID(studentID)
        SelectedStudent = studentID
    End Sub

    Friend Function getStudentName()
        Return StudentName
    End Function

    Friend Sub setStudentName(Student)
        StudentName = Student
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnRequest.Click, DataGridView1.DoubleClick
        SelectedForm = Me.DataGridView1.CurrentRow.Cells(0).Value
        GAViewRequestForm.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnClose.Click, CloseToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub btnStudent_Click(sender As Object, e As EventArgs) Handles btnStudent.Click, DataGridView2.DoubleClick
        SelectedStudent = Me.DataGridView2.CurrentRow.Cells(13).Value
        StudentName = Me.DataGridView2.CurrentRow.Cells(1).Value & ", " & Me.DataGridView2.CurrentRow.Cells(0).Value
        GAProfile.Show()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click, AssignGAsToolStripMenuItem.Click
        GAAssignment.ShowDialog()
    End Sub

    Private Sub GAAssignmentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GAAssignmentToolStripMenuItem.Click
        GAViewUserAssignments.ShowDialog()

    End Sub

End Class