Public Class GAViewRequestForm
    Dim Form = GAViewRequest.getForm()
    Dim StudentID
    Dim ApplicationID
    Dim StudentName


    Private Sub ViewForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PROJECTS1747DataSet15.GA_Request' table. You can move, or remove it, as needed.
        Me.GA_RequestTableAdapter.Fill(Me.PROJECTS1747DataSet15.GA_Request)
        'TODO: This line of code loads data into the 'PROJECTS1747DataSet15.viewAvailableGAs' table. You can move, or remove it, as needed.
        Me.ViewAvailableGAsTableAdapter.Fill(Me.PROJECTS1747DataSet15.viewAvailableGAs)
        'TODO: This line of code loads data into the 'PROJECTS1747DataSet15.viewRequestedGA' table. You can move, or remove it, as needed.
        Me.ViewRequestedGATableAdapter.Fill(Me.PROJECTS1747DataSet15.viewRequestedGA)



        lblName.Text = GAViewRequest.getSupervisorName
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        GARequestBindingSource.Filter = String.Format("Request_Form_ID = '{0}'", Form)
        ViewRequestedGABindingSource.Filter = String.Format("Form = '{0}'", Form)
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click, CloseToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        StudentID = Me.DataGridView1.CurrentRow.Cells(13).Value
        GAViewRequest.setStudentID(StudentID)
        StudentName = Me.DataGridView1.CurrentRow.Cells(1).Value & ", " & Me.DataGridView1.CurrentRow.Cells(0).Value
        GAViewRequest.setStudentName(StudentName)
        GAProfile.Show()
    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellDoubleClick
        StudentID = Me.DataGridView2.CurrentRow.Cells(11).Value
        GAViewRequest.setStudentID(StudentID)
        ApplicationID = Me.DataGridView2.CurrentRow.Cells(12).Value
        StudentName = Me.DataGridView2.CurrentRow.Cells(1).Value & ", " & Me.DataGridView2.CurrentRow.Cells(0).Value
        GAViewRequest.setStudentName(StudentName)
        GAProfile.Show()
    End Sub

    Friend Function getStudentID()
        Return StudentID
    End Function

    Friend Function getStudentName()
        Return StudentName
    End Function

    Private Sub AssignGAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AssignGAsToolStripMenuItem.Click
        GAAssignment.Show()
        Me.Close()
    End Sub

    Private Sub GAAssignmentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GAAssignmentToolStripMenuItem.Click
        GAViewUserAssignments.Show()
        Me.Close()
    End Sub
End Class