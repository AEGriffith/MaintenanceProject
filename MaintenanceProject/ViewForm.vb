Public Class GAViewRequestForm
    Dim Form = GAViewRequest.getForm()
    Dim StudentID
    Dim ApplicationID
    Dim StudentName


    Private Sub ViewForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PROJECTS1747DataSet12.viewRequestedGA' table. You can move, or remove it, as needed.
        Me.ViewRequestedGATableAdapter.Fill(Me.PROJECTS1747DataSet12.viewRequestedGA)


        'TODO: This line of code loads data into the 'PROJECTS1747DataSet9.viewAvailableGAs' table. You can move, or remove it, as needed.
        Me.ViewAvailableGAsTableAdapter.Fill(Me.PROJECTS1747DataSet9.viewAvailableGAs)
        'TODO: This line of code loads data into the 'PROJECTS1747DataSet5.GA_Request' table. You can move, or remove it, as needed.
        Me.GA_RequestTableAdapter.Fill(Me.PROJECTS1747DataSet5.GA_Request)

        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        GARequestBindingSource.Filter = String.Format("Request_Form_ID = '{0}'", Form)
        ViewRequestedGABindingSource.Filter = String.Format("Form = '{0}'", Form)
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        StudentID = Me.DataGridView1.CurrentRow.Cells(14).Value

        StudentName = Me.DataGridView1.CurrentRow.Cells(1).Value & ", " & Me.DataGridView1.CurrentRow.Cells(0).Value
        GAProfile.Show()
    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellDoubleClick
        StudentID = Me.DataGridView2.CurrentRow.Cells(12).Value
        ApplicationID = Me.DataGridView2.CurrentRow.Cells(13).Value
        StudentName = Me.DataGridView2.CurrentRow.Cells(1).Value & ", " & Me.DataGridView2.CurrentRow.Cells(0).Value
        GAProfile.Show()
    End Sub

    Friend Function getStudentID()
        Return StudentID
    End Function

    Friend Function getStudentName()
        Return StudentName
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        GAAssignment.Show()
    End Sub
End Class