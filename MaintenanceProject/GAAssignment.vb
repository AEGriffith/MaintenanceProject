Imports System.Data.OleDb
Public Class GAAssignment
    'Setup Connection Variables
    Dim ConnInfo As New DBConnectionInfo
    Dim ConnString As String = ConnInfo.GetConnString()
    Dim con As New OleDbConnection()

    Dim SelectedRequest
    Dim SelectedStudent
    Dim Hours
    Dim Semester
    Dim AssignedHours
    Dim Supervisor
    Dim Student
    Dim TotalHours
    Dim TotalStudents

    Private Sub btnCancel_Click(sender As Object, e As EventArgs)
        Me.Close()

    End Sub

    Private Sub GAAssignment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PROJECTS1747DataSet9.viewAvailableGAs' table. You can move, or remove it, as needed.
        Me.ViewAvailableGAsTableAdapter.Fill(Me.PROJECTS1747DataSet9.viewAvailableGAs)
        'TODO: This line of code loads data into the 'PROJECTS1747DataSet6.viewGARequest' table. You can move, or remove it, as needed.
        Me.ViewGARequestTableAdapter.Fill(Me.PROJECTS1747DataSet6.viewGARequest)
        SelectedRequest = Me.dgvRequest.CurrentRow.Cells(0).Value
        cbSemester.SelectedIndex = 0

        'GetAssignedStudents()

    End Sub

    Private Sub btnStudent_Click(sender As Object, e As EventArgs) Handles btnAssignment.Click
        If cbSemester.SelectedIndex = -1 Then
            MessageBox.Show("Please Select a Semester", "Data Entry Error")
        Else
            'Set Variables
            SelectedRequest = Me.dgvRequest.CurrentRow.Cells(0).Value
            SelectedStudent = Me.dgvGA.CurrentRow.Cells(12).Value
            Hours = numHours.Value
            Semester = cbSemester.Text
            tbGAs.Text = TotalStudents
            tbSupervisorHours.Text = TotalHours

            Supervisor = Me.dgvRequest.CurrentRow.Cells(1).Value & " " & Me.dgvRequest.CurrentRow.Cells(2).Value
            Student = Me.dgvGA.CurrentRow.Cells(0).Value & Me.dgvGA.CurrentRow.Cells(1).Value
            'Get Assigned Hours
            GetAssignedHours()
            If AssignedHours + Hours > 20 Then
                MessageBox.Show("This Student is already assigned to " & AssignedHours & " weekly hours. Students can be assigned for a maximum of 20 weekly hours. Please assign for " & 20 - AssignedHours & " or less weekly hours.")
            Else
                SubmitRequest()
                MessageBox.Show(Student & " assigned to " & Supervisor & " for " & Hours & " during " & Semester)
            End If

            Me.Close()
        End If

    End Sub

    Private Sub numHours_ValueChanged(sender As Object, e As EventArgs) Handles numHours.ValueChanged
        Hours = numHours.Value
        If SelectedStudent IsNot vbNullString Then
            SelectedStudent = Me.dgvGA.CurrentRow.Cells(12).Value
            Semester = cbSemester.Text
            GetAssignedHours()
            GetAssignedStudents()
            GetTotalSupervisorHours()
            tbGAs.Text = TotalStudents
            tbSupervisorHours.Text = TotalHours
            If AssignedHours > 0 Then
                tbHours.Text = AssignedHours
            Else
                tbHours.Text = 0
            End If
        End If
    End Sub

    Private Sub cbSemester_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbSemester.SelectedIndexChanged
        SelectedStudent = Me.dgvGA.CurrentRow.Cells(12).Value
        Semester = cbSemester.Text
        GetAssignedHours()
        GetAssignedStudents()
        GetTotalSupervisorHours()
        tbGAs.Text = TotalStudents
        tbSupervisorHours.Text = TotalHours
        If AssignedHours > 0 Then
            tbHours.Text = AssignedHours
        Else
            tbHours.Text = 0
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
        sqlComm.Parameters.AddWithValue("StudentID", SelectedStudent)
        sqlComm.Parameters.AddWithValue("Semester", Semester)


        con.Open()
        AssignedHours = sqlComm.ExecuteScalar()

        con.Close()
    End Sub

    Private Sub GetTotalSupervisorHours()
        con.ConnectionString = ConnString

        Dim sqlComm As New OleDbCommand
        Dim dr As OleDbDataReader


        sqlComm.Connection = con

        'setup for stored procedure
        sqlComm.CommandText = "procGetTotalSupervisorHours"
        sqlComm.CommandType = CommandType.StoredProcedure
        sqlComm.Connection = con


        'sets values for stored procedure
        sqlComm.Parameters.AddWithValue("FormID", SelectedRequest)
        sqlComm.Parameters.AddWithValue("Semester", Semester)

        con.Open()
        dr = sqlComm.ExecuteReader()
        While dr.Read()
            TotalHours = Integer.Parse(dr.GetInt32(0))
            TotalStudents = dr.GetInt32(1)
        End While
        con.Close()
    End Sub

    Private Sub SubmitRequest()
        con.ConnectionString = ConnString

        Dim sqlComm As New OleDbCommand
        Dim ds As New DataSet


        sqlComm.Connection = con

        'setup for stored procedure
        sqlComm.CommandText = "procAddAssignment"
        sqlComm.CommandType = CommandType.StoredProcedure
        sqlComm.Connection = con


        'sets values for stored procedure
        sqlComm.Parameters.AddWithValue("formID", SelectedRequest)
        sqlComm.Parameters.AddWithValue("StudentID", SelectedStudent)
        sqlComm.Parameters.AddWithValue("Hours", Hours)
        sqlComm.Parameters.AddWithValue("Semester", Semester)


        con.Open()
        sqlComm.ExecuteNonQuery()

        con.Close()
    End Sub

    Private Sub GetAssignedStudents()
        con.ConnectionString = ConnString

        Dim sqlComm As New OleDbCommand
        Dim ds As New DataSet


        sqlComm.Connection = con

        'setup for stored procedure
        sqlComm.CommandText = "procGetAssignedStudents"
        sqlComm.CommandType = CommandType.StoredProcedure
        sqlComm.Connection = con


        'sets values for stored procedure
        sqlComm.Parameters.AddWithValue("FormID", Integer.Parse(SelectedRequest))
        sqlComm.Parameters.AddWithValue("Semester", Semester)

        con.Open()
        Dim Adpt = New OleDbDataAdapter(sqlComm)
        Adpt.Fill(ds)
        dgvAssigned.DataSource = ds.Tables(0)
        con.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRequest.CellContentClick, dgvRequest.CellLeave
        SelectedStudent = Me.dgvGA.CurrentRow.Cells(12).Value
        Semester = cbSemester.Text
        GetAssignedHours()
        GetAssignedStudents()
        GetTotalSupervisorHours()
        tbGAs.Text = TotalStudents
        tbSupervisorHours.Text = TotalHours
        If AssignedHours > 0 Then
            tbHours.Text = AssignedHours
        Else
            tbHours.Text = 0
        End If
    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvGA.CellContentClick, dgvGA.CellLeave, dgvGA.CellEnter
        SelectedStudent = Me.dgvGA.CurrentRow.Cells(12).Value
        Semester = cbSemester.Text
        GetAssignedHours()
        If AssignedHours > 0 Then
            tbHours.Text = AssignedHours
        Else
            tbHours.Text = 0
        End If

    End Sub
End Class