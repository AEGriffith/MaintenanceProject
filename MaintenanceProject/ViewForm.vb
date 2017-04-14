Public Class ViewForm
    Dim Form = GAViewRequest.getForm()

    Private Sub ViewForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PROJECTS1747DataSet5.GA_Request' table. You can move, or remove it, as needed.
        Me.GA_RequestTableAdapter.Fill(Me.PROJECTS1747DataSet5.GA_Request)
        'TODO: This line of code loads data into the 'PROJECTS1747DataSet5.viewRequestedGA' table. You can move, or remove it, as needed.
        Me.ViewRequestedGATableAdapter.Fill(Me.PROJECTS1747DataSet5.viewRequestedGA)

        GARequestBindingSource.Filter = String.Format("Request_Form_ID = '{0}'", Form)
        ViewRequestedGABindingSource.Filter = String.Format("Form = '{0}'", Form)
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class