Public Class Main

    Dim SelectedApplicant

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PROJECTS1747DataSet3.View_ApplicationTable' table. You can move, or remove it, as needed.
        Me.View_ApplicationTableTableAdapter2.Fill(Me.PROJECTS1747DataSet3.View_ApplicationTable)
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        'TODO: This line of code loads data into the 'PROJECTS1747DataSet2.View_ApplicationTable' table. You can move, or remove it, as needed.
        Me.View_ApplicationTableTableAdapter1.Fill(Me.PROJECTS1747DataSet2.View_ApplicationTable)
        'TODO: This line of code loads data into the 'PROJECTS1747DataSet1.View_ApplicationTable' table. You can move, or remove it, as needed.
        Me.View_ApplicationTableTableAdapter.Fill(Me.PROJECTS1747DataSet1.View_ApplicationTable)
        'TODO: This line of code loads data into the 'PROJECTS1747DataSet1.Application' table. You can move, or remove it, as needed.
        Me.ApplicationTableAdapter1.Fill(Me.PROJECTS1747DataSet1.Application)
        'TODO: This line of code loads data into the 'PROJECTS1747DataSet.Application' table. You can move, or remove it, as needed.
        Me.ApplicationTableAdapter.Fill(Me.PROJECTS1747DataSet.Application)
        'TODO: This line of code loads data into the 'PROJECTS1730DataSet.Students' table. You can move, or remove it, as needed.



    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub cbFilter1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbFilter1.SelectedIndexChanged


        tbFilter1.Clear()
        If cbFilter2.SelectedIndex <> -1 And cbFilter1.SelectedIndex = cbFilter2.SelectedIndex Then
            MessageBox.Show("You are already using this value as a filter. Please use another value.")
            If cbFilter1.SelectedIndex = 0 Then
                cbFilter1.SelectedIndex = cbFilter1.SelectedIndex + 1
            Else
                cbFilter1.SelectedIndex = cbFilter1.SelectedIndex - 1
            End If


        End If
        Select Case cbFilter1.SelectedIndex
            Case -1
                cbFilter2.Enabled = False
                tbFilter1.Enabled = False
                tbFilter2.Enabled = False
            Case 0
                cbFilter2.Enabled = True
                tbFilter1.Enabled = True
                'tbFilter2.Enabled = True
            Case 1
                cbFilter2.Enabled = True
                tbFilter1.Enabled = True
                'tbFilter2.Enabled = True
            Case 2
                cbFilter2.Enabled = True
                tbFilter1.Enabled = True
                'tbFilter2.Enabled = True
            Case 3
                cbFilter2.Enabled = True
                tbFilter1.Enabled = True
                'tbFilter2.Enabled = True
        End Select
    End Sub

    Private Sub cbFilter2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbFilter2.SelectedIndexChanged
        tbFilter2.Clear()
        If cbFilter2.SelectedIndex = -1 Then
            tbFilter2.Enabled = False
        Else
            tbFilter2.Enabled = True
        End If
        If cbFilter1.SelectedIndex <> -1 And cbFilter1.SelectedIndex = cbFilter2.SelectedIndex Then
            MessageBox.Show("You are already using this value as a filter. Please use another value.")
            cbFilter2.SelectedIndex = -1
        End If
    End Sub

    Private Sub tbFilter1_TextChanged(sender As Object, e As EventArgs) Handles tbFilter1.TextChanged

        If cbFilter2.SelectedIndex = -1 Then
            ApplicationBindingSource.Filter = cbFilter1.Text & " Like '" & tbFilter1.Text & "*'"
        Else
            ApplicationBindingSource.Filter = cbFilter2.Text & " Like '" & tbFilter2.Text & "*' and " & cbFilter1.Text & " Like '" & tbFilter1.Text & "*'"
        End If
        DataGridView1.DataSource = ApplicationBindingSource
    End Sub

    Private Sub tbFilter2_TextChanged(sender As Object, e As EventArgs) Handles tbFilter2.TextChanged

        ApplicationBindingSource.Filter = cbFilter2.Text & " Like '" & tbFilter2.Text & "*' and " & cbFilter1.Text & " Like '" & tbFilter1.Text & "*'"

    End Sub

    Private Sub ApplicantProfileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ApplicantProfileToolStripMenuItem.Click, btnViewApplicant.Click
        SelectedApplicant = Me.DataGridView1.CurrentRow.Cells(0).Value
        ApplicantProfile.Show()
    End Sub

    'Uncomment this to troubleshoot getting the applicant data
    'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnViewApplicant.Click
    '    SelectedApplicant = Me.DataGridView1.CurrentRow.Cells(0).Value
    '    MessageBox.Show(SelectedApplicant)
    'End Sub

    Friend Function getSelectedApplicant()
        Return SelectedApplicant
    End Function


End Class
