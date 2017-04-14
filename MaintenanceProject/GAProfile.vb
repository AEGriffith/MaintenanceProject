Public Class GAProfile

    Dim StudentName = GAViewRequestForm.getStudentName()
    Dim StudentID = GAViewRequestForm.getStudentID()

    Private Sub GAProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PROJECTS1747DataSet11.viewGAsRequestedBy' table. You can move, or remove it, as needed.
        Me.ViewGAsRequestedByTableAdapter.Fill(Me.PROJECTS1747DataSet11.viewGAsRequestedBy)
        'TODO: This line of code loads data into the 'PROJECTS1747DataSet7.viewRequestedGA' table. You can move, or remove it, as needed.
        Me.ViewRequestedGATableAdapter.Fill(Me.PROJECTS1747DataSet7.viewRequestedGA)
        Label1.Text = StudentName
        ViewRequestedGABindingSource.Filter = String.Format("Student_ID = '{0}'", StudentID)
        ViewGAsRequestedByBindingSource.Filter = String.Format("Student_ID = '{0}'", StudentID)
    End Sub
End Class