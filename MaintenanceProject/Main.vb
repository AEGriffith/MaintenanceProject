Public Class Main

    Dim SelectedApplicant
    Dim GridFilter As String


    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PROJECTS1747DataSet.viewApplicant' table. You can move, or remove it, as needed.


        Me.ViewApplicantTableAdapter.Fill(Me.PROJECTS1747DataSet.viewApplicant)


        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        'ViewApplicationTableBindingSource2.Filter = String.Format()


    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
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

    'Filters the grid
    Private Sub tbFName_TextChanged(sender As Object, e As EventArgs) Handles tbFName.TextChanged, tbLName.TextChanged, cbProgram.SelectedIndexChanged,
        tbEmployer.TextChanged, tbTWE.TextChanged, tbGender.TextChanged, tbEthnicity.TextChanged, tbResidency.TextChanged, tbUDegree.TextChanged,
        numMinAge.ValueChanged, numMaxAge.ValueChanged, numGMATMin.ValueChanged, numGMATMax.ValueChanged, numGREMin.ValueChanged, numGREMax.ValueChanged,
        numUGPAMax.ValueChanged, numUGPAMin.ValueChanged, cbGRE.CheckedChanged, cbGMAT.CheckedChanged
        GridFilter = "[First Name] LIKE '" & tbFName.Text & "*' AND [Last Name] LIKE '" & tbLName.Text &
            "*' AND Program LIKE '" & cbProgram.Text &
            "*' AND [Current Employer] LIKE '" & tbEmployer.Text & "*' AND [Time With Employer] LIKE '" & tbTWE.Text &
            "*' AND Gender LIKE '" & tbGender.Text & "*' AND Ethnicity LIKE '" & tbEthnicity.Text &
            "*' AND Age >= '" & numMinAge.Value & "' AND Age <= '" & numMaxAge.Value &
            "' AND [Undergraduate Degree] LIKE '" & tbUDegree.Text &
            "*' And Residency LIKE '" & tbResidency.Text &
            "*' AND [Undergraduate GPA] >= '" & numUGPAMin.Value & "' AND [Undergraduate GPA] <= '" & numUGPAMax.Value & "'"
        If GridFilter Is Nothing Then

        Else
            If cbGRE.Checked = True Then
                numGREMax.Enabled = True
                numGREMin.Enabled = True
                GridFilter += " AND GRE >= '" & numGREMin.Value & "' AND GRE <= '" & numGREMax.Value & "'"

            Else
                numGREMin.Enabled = False
                numGREMax.Enabled = False
                If GridFilter.Contains("GRE") Then
                    Replace(GridFilter, " AND GRE >= '" & numGREMin.Value & "' AND GRE <= '" & numGREMax.Value & "'", "")
                End If
            End If
            If cbGMAT.Checked = True Then
                numGMATMax.Enabled = True
                numGMATMin.Enabled = True
                GridFilter += " AND GMAT >= '" & numGMATMin.Value & "' AND GMAT <= '" & numGMATMax.Value & "'"

            Else
                numGMATMin.Enabled = False
                numGMATMax.Enabled = False
                If GridFilter.Contains("GMAT") Then
                    Replace(GridFilter, " AND GMAT >= '" & numGMATMin.Value & "' AND GMAT <= '" & numGMATMax.Value & "'", "")
                End If
            End If

        End If

        Try
            ViewApplicantBindingSource.Filter = GridFilter


        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        tbLName.Clear()
        tbFName.Clear()
        cbProgram.SelectedIndex = -1
        tbEmployer.Clear()
        tbTWE.Clear()
        tbGender.Clear()
        tbEthnicity.Clear()
        tbUDegree.Clear()
        tbResidency.Clear()
        numGMATMax.Value = 800
        numGMATMin.Value = 200
        numGREMax.Value = 340
        numGREMin.Value = 260
        numMaxAge.Value = 100
        numMinAge.Value = 0
        numUGPAMax.Value = 4
        numUGPAMin.Value = 1
        cbGMAT.Checked = False
        cbGRE.Checked = False
    End Sub

    Private Sub Label16_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click

    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles numGMATMax.ValueChanged

    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click

    End Sub

    Private Sub NumericUpDown2_ValueChanged(sender As Object, e As EventArgs) Handles numGMATMin.ValueChanged

    End Sub

    Private Sub cbGMAT_CheckedChanged(sender As Object, e As EventArgs) Handles cbGMAT.CheckedChanged
        If cbGMAT.Checked = True Then
            numGMATMin.Enabled = True
            numGMATMax.Enabled = True
        Else
            numGMATMax.Enabled = False
            numGMATMin.Enabled = False
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class
