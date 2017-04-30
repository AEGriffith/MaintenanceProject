Imports System.Data.OleDb
Public Class GADirector

    'Setup Connection Variables
    Dim ConnInfo As New DBConnectionInfo
    Dim ConnString As String = ConnInfo.GetConnString()
    Dim con As New OleDbConnection()

    Friend Sub GetTaskTypeHours()
        con.ConnectionString = ConnString

        Dim sqlComm As New OleDbCommand
        Dim ds As New DataSet


        sqlComm.Connection = con

        'setup for stored procedure
        sqlComm.CommandText = "procGetHourTypes"
        sqlComm.CommandType = CommandType.StoredProcedure
        sqlComm.Connection = con


        con.Open()
        Dim Adpt = New OleDbDataAdapter(sqlComm)
        Adpt.Fill(ds)
        dgvTaskTypeHours.DataSource = ds.Tables(0)
        con.Close()
    End Sub

    Private Sub GARequestsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GARequestsToolStripMenuItem.Click
        GAViewRequest.Show()
        Me.Close()
    End Sub

    Private Sub GAAssignmentsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GAAssignmentsToolStripMenuItem.Click
        GAViewUserAssignments.Show()
        Me.Close()
    End Sub

    Private Sub AssignGAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AssignGAToolStripMenuItem.Click
        GAAssignment.Show()
        Me.Close()
    End Sub

    Private Sub GADirector_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetTaskTypeHours()
    End Sub
End Class