Public Class Main
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PROJECTS1730DataSet.Students' table. You can move, or remove it, as needed.
        Me.StudentsTableAdapter.Fill(Me.PROJECTS1730DataSet.Students)


    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub cbFilter1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbFilter1.SelectedIndexChanged
        Select Case cbFilter1.SelectedIndex
            Case -1
                cbFilter2.Enabled = False
                tbFilter1.Enabled = False
                tbFilter2.Enabled = False
            Case 0
                cbFilter2.Enabled = True
                tbFilter1.Enabled = True
                tbFilter2.Enabled = True
            Case 1
                cbFilter2.Enabled = True
                tbFilter1.Enabled = True
                tbFilter2.Enabled = True
            Case 2
                cbFilter2.Enabled = True
                tbFilter1.Enabled = True
                tbFilter2.Enabled = True
            Case 3
                cbFilter2.Enabled = True
                tbFilter1.Enabled = True
                tbFilter2.Enabled = True
        End Select
    End Sub

    Private Sub cbFilter2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbFilter2.SelectedIndexChanged
        If cbFilter1.SelectedIndex <> -1 And cbFilter1.SelectedIndex = cbFilter2.SelectedIndex Then
            MessageBox.Show("You are already using this value as a filter. Please use another value.")
            cbFilter2.SelectedIndex = -1
        End If
    End Sub

    Private Sub tbFilter1_TextChanged(sender As Object, e As EventArgs) Handles tbFilter1.TextChanged

        StudentsBindingSource.Filter = cbFilter1.Text & " Like '" & tbFilter1.Text & "*'"

    End Sub

    Private Sub tbFilter2_TextChanged(sender As Object, e As EventArgs) Handles tbFilter2.TextChanged

        StudentsBindingSource.Filter = cbFilter2.Text & " Like '" & tbFilter2.Text & "*' and " & cbFilter1.Text & " Like '" & tbFilter1.Text & "*'"

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class
