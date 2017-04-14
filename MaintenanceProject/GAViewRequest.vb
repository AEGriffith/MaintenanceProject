Public Class GAViewRequest

    Dim SelectedForm

    Private Sub GAViewRequest_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'TODO: This line of code loads data into the 'PROJECTS1747DataSet5.viewGARequest' table. You can move, or remove it, as needed.
        Me.ViewGARequestTableAdapter.Fill(Me.PROJECTS1747DataSet5.viewGARequest)


        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick, DataGridView1.CellEnter
        'TODO: This line of code loads data into the 'PROJECTS1747DataSet5.viewRequestedGA' table. You can move, or remove it, as needed.
        Me.ViewRequestedGATableAdapter.Fill(Me.PROJECTS1747DataSet5.viewRequestedGA)
        SelectedForm = Me.DataGridView1.CurrentRow.Cells(0).Value
        ViewRequestedGABindingSource.Filter = String.Format("Form = '{0}'", SelectedForm)
    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub

    Friend Function getForm()
        Return SelectedForm
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click, DataGridView1.DoubleClick
        SelectedForm = Me.DataGridView1.CurrentRow.Cells(0).Value
        ViewForm.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class