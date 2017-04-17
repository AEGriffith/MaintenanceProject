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

    Private Sub btnCancel_Click(sender As Object, e As EventArgs)
        Me.Close()

    End Sub

    Private Sub GAAssignment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PROJECTS1747DataSet9.viewAvailableGAs' table. You can move, or remove it, as needed.
        Me.ViewAvailableGAsTableAdapter.Fill(Me.PROJECTS1747DataSet9.viewAvailableGAs)
        'TODO: This line of code loads data into the 'PROJECTS1747DataSet6.viewGARequest' table. You can move, or remove it, as needed.
        Me.ViewGARequestTableAdapter.Fill(Me.PROJECTS1747DataSet6.viewGARequest)
        cbSemester.SelectedIndex = 0

    End Sub

    Private Sub btnStudent_Click(sender As Object, e As EventArgs) Handles btnAssignment.Click
        If cbSemester.SelectedIndex = -1 Then
            MessageBox.Show("Please Select a Semester", "Data Entry Error")
        Else
            'Set Variables
            SelectedRequest = Me.DataGridView1.CurrentRow.Cells(0).Value
            SelectedStudent = Me.DataGridView2.CurrentRow.Cells(12).Value
            Hours = numHours.Value
            Semester = cbSemester.Text

            Supervisor = Me.DataGridView1.CurrentRow.Cells(1).Value & " " & Me.DataGridView1.CurrentRow.Cells(2).Value
            Student = Me.DataGridView2.CurrentRow.Cells(0).Value & Me.DataGridView2.CurrentRow.Cells(1).Value
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
            SelectedStudent = Me.DataGridView2.CurrentRow.Cells(12).Value
            Semester = cbSemester.Text
            GetAssignedHours()
            If AssignedHours > 0 Then
                tbHours.Text = AssignedHours
            Else
                tbHours.Text = 0
            End If
        End If
    End Sub

    Private Sub cbSemester_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbSemester.SelectedIndexChanged
        SelectedStudent = Me.DataGridView2.CurrentRow.Cells(12).Value
        Semester = cbSemester.Text
        GetAssignedHours()
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

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick, DataGridView1.CellEnter, DataGridView1.CellLeave
        SelectedStudent = Me.DataGridView2.CurrentRow.Cells(12).Value
        Semester = cbSemester.Text
        GetAssignedHours()
        If AssignedHours > 0 Then
            tbHours.Text = AssignedHours
        Else
            tbHours.Text = 0
        End If
    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick, DataGridView2.CellLeave, DataGridView2.CellEnter
        SelectedStudent = Me.DataGridView2.CurrentRow.Cells(12).Value
        Semester = cbSemester.Text
        GetAssignedHours()
        If AssignedHours > 0 Then
            tbHours.Text = AssignedHours
        Else
            tbHours.Text = 0
        End If

    End Sub
End Class