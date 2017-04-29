Imports System.Data.OleDb
Public Class GAReassignment
    Dim StudentID = GAViewUserAssignments.getStudentID
    Dim StudentName = GAViewUserAssignments.getStudentName
    Dim SupervisorID = GAViewUserAssignments.getSupervisorID
    Dim FormID = Integer.Parse(GAViewUserAssignments.getFormID)
    Dim Hours = GAViewUserAssignments.getHours
    Dim Semester = GAViewUserAssignments.getSemester
    Dim SupervisorName = GAViewUserAssignments.getSupervisorName


    'Variables set by Stored Procedure
    Dim AssignedHours

    'Calculated Variables
    Dim AssignableHours

    'Variable set by Form
    Dim NewSupervisorID
    Dim HoursAssigned


    'Setup Connection Variables
    Dim ConnInfo As New DBConnectionInfo
    Dim ConnString As String = ConnInfo.GetConnString()
    Dim con As New OleDbConnection()


    Private Sub GAReassignment_Load(sender As Object, e As EventArgs) Handles MyBase.Load, MyBase.Activated
        ' Get Values from GAViewUserAssignments
        StudentID = GAViewUserAssignments.getStudentID
        StudentName = GAViewUserAssignments.getStudentName
        SupervisorID = GAViewUserAssignments.getSupervisorID
        FormID = Integer.Parse(GAViewUserAssignments.getFormID)
        Hours = GAViewUserAssignments.getHours
        Semester = GAViewUserAssignments.getSemester
        SupervisorName = GAViewUserAssignments.getSupervisorName


        GetAssignedHours()
        If AssignedHours - Hours = 0 Then
            AssignableHours = 20
        ElseIf AssignedHours - Hours <= 10 Then
            AssignableHours = 10
        Else
            AssignableHours = 0
        End If

        lblHours.Text = "*This student is available to be assigned"
        lblHours1.Text = "for up to " & AssignableHours & " hours."
        cbSupervisor.SelectedValue = SupervisorID
        If Semester = "Fa2017" Then
            lblSemester.Text = "Fall 2017"
        Else
            lblSemester.Text = "Spring 2018"
        End If
        lblStudent.Text = StudentName
        Me.Text = "Reassign " & StudentName
        numHours.Maximum = AssignableHours
        If AssignableHours > Hours Then
            numHours.Value = Hours
        Else
            numHours.Value = AssignableHours
        End If

    End Sub

    Private Sub GetAssignedHours()
        con.ConnectionString = ConnString

        Dim sqlComm As New OleDbCommand
        Dim ds As New DataSet


        sqlComm.Connection = con

        'setup for stored procedure
        sqlComm.CommandText = "procGetAssignedHours"
        sqlComm.CommandType = CommandType.StoredProcedure
        sqlComm.Connection = con


        'sets values for stored procedure
        sqlComm.Parameters.AddWithValue("StudentID", StudentID)
        sqlComm.Parameters.AddWithValue("Semester", Semester)


        con.Open()
        AssignedHours = sqlComm.ExecuteScalar()

        con.Close()
    End Sub

    Private Sub Reassign()
        con.ConnectionString = ConnString

        Dim sqlComm As New OleDbCommand
        Dim ds As New DataSet


        sqlComm.Connection = con

        'setup for stored procedure
        sqlComm.CommandText = "procReassignment"
        sqlComm.CommandType = CommandType.StoredProcedure
        sqlComm.Connection = con


        'sets values for stored procedure
        sqlComm.Parameters.AddWithValue("SupervisorID", NewSupervisorID)
        sqlComm.Parameters.AddWithValue("Hours", HoursAssigned)
        sqlComm.Parameters.AddWithValue("FormID", FormID)


        con.Open()
        sqlComm.ExecuteNonQuery()

        con.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnReassign_Click(sender As Object, e As EventArgs) Handles btnReassign.Click
        NewSupervisorID = Integer.Parse(cbSupervisor.SelectedValue)

        HoursAssigned = Integer.Parse(numHours.Value)
        If NewSupervisorID = SupervisorID And HoursAssigned = Hours Then
            MessageBox.Show("No changes were made.")
        ElseIf NewSupervisorID = SupervisorID And HoursAssigned <> Hours Then
            If MessageBox.Show("Supervisor has not changed. Are you sure you wish to update?", "Confirmation", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                Reassign()
                MessageBox.Show("Hours changed from " & Hours & " weekly hours to " & HoursAssigned & " weekly hours.")
                GAViewUserAssignments.ViewGAAssignmentsTableAdapter.Fill(GAViewUserAssignments.PROJECTS1747DataSet6.viewGAAssignments)
                Me.Close()
            End If
        Else
            Reassign()
            GAViewUserAssignments.ViewGAAssignmentsTableAdapter.Fill(GAViewUserAssignments.PROJECTS1747DataSet6.viewGAAssignments)
            SupervisorName = GAViewUserAssignments.DataGridView1.CurrentRow.Cells(0).Value
            MessageBox.Show(StudentName & " reassigned to " & SupervisorName & " for " & HoursAssigned & " hours.")
            GAViewUserAssignments.ViewGAAssignmentsTableAdapter.Fill(GAViewUserAssignments.PROJECTS1747DataSet6.viewGAAssignments)
            Me.Close()

        End If

    End Sub
End Class