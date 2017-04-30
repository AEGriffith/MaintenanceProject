Imports System.Data.OleDb
Public Class GASupervisor

    'Setup Connection Variables
    Dim ConnInfo As New DBConnectionInfo
    Dim ConnString As String = ConnInfo.GetConnString()
    Dim con As New OleDbConnection()

    Dim Supervisor_ID = Login.getUsername()
    Dim Semester = "Fa2017"
    Dim SemesterTask = "Fa2017"

    Private Sub RequestGraduateAssistantToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RequestGraduateAssistantToolStripMenuItem.Click
        GARequest.Show()
    End Sub

    Private Sub GetAssignedStudentsHours()
        con.ConnectionString = ConnString

        Dim sqlComm As New OleDbCommand
        Dim ds As New DataSet


        sqlComm.Connection = con

        'setup for stored procedure
        sqlComm.CommandText = "procGetAssignedStudentsHours"
        sqlComm.CommandType = CommandType.StoredProcedure
        sqlComm.Connection = con


        'sets values for stored procedure
        sqlComm.Parameters.AddWithValue("UserID", Supervisor_ID)
        sqlComm.Parameters.AddWithValue("Semester", Semester)


        con.Open()
        Dim Adpt = New OleDbDataAdapter(sqlComm)
        Adpt.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)

        con.Close()
    End Sub

    Private Sub GetAssignedTasks()
        con.ConnectionString = ConnString

        Dim sqlComm As New OleDbCommand
        Dim ds As New DataSet


        sqlComm.Connection = con

        'setup for stored procedure
        sqlComm.CommandText = "procGetAssignedTasks"
        sqlComm.CommandType = CommandType.StoredProcedure
        sqlComm.Connection = con


        'sets values for stored procedure
        sqlComm.Parameters.AddWithValue("UserID", Supervisor_ID)
        sqlComm.Parameters.AddWithValue("Semester", SemesterTask)


        con.Open()
        Dim Adpt = New OleDbDataAdapter(sqlComm)
        Adpt.Fill(ds)
        DataGridView2.DataSource = ds.Tables(0)

        con.Close()
    End Sub


    Private Sub GASupervisor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SemesterSelect()
        Semester2Select()
        GetAssignedStudentsHours()
        GetAssignedTasks()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter
        SemesterSelect()
        Semester2Select()
        GetAssignedStudentsHours()
        GetAssignedTasks()
    End Sub

    Private Sub SemesterSelect()
        If rb1.Checked = True Then
            Semester = "Fa2017"
        Else
            Semester = "Sp2018"
        End If
    End Sub

    Private Sub Semester2Select()
        If rb2Fall.Checked = True Then
            SemesterTask = "Fa2017"
        Else
            SemesterTask = "Sp2018"
        End If
    End Sub

    Private Sub rb1_CheckedChanged(sender As Object, e As EventArgs) Handles rb1.CheckedChanged, rb2.CheckedChanged
        SemesterSelect()
        GetAssignedStudentsHours()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub AssignTasksToGAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AssignTasksToGAsToolStripMenuItem.Click
        GASupervisorTask.Show()
    End Sub

    Private Sub rb2Fall_CheckedChanged(sender As Object, e As EventArgs) Handles rb2Fall.CheckedChanged, rb2Spring.CheckedChanged
        Semester2Select()
        GetAssignedTasks()
    End Sub
End Class