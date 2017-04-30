Imports System.Data.OleDb
Public Class GA

    'Setup Connection Variables
    Dim ConnInfo As New DBConnectionInfo
    Dim ConnString As String = ConnInfo.GetConnString()
    Dim con As New OleDbConnection()

    Dim UserID = Login.getUsername()
    Dim GAName = Login.getName()

    Dim TaskID
    Dim Supervisor
    Dim Progress


    Friend Sub GetTasks()
        con.ConnectionString = ConnString

        Dim sqlComm As New OleDbCommand
        Dim ds As New DataSet


        sqlComm.Connection = con

        'setup for stored procedure
        sqlComm.CommandText = "procGetGATasks"
        sqlComm.CommandType = CommandType.StoredProcedure
        sqlComm.Connection = con


        'sets values for stored procedure
        sqlComm.Parameters.AddWithValue("User_ID", Integer.Parse(UserID))

        con.Open()
        Dim Adpt = New OleDbDataAdapter(sqlComm)
        Adpt.Fill(ds)
        dgvTasks.DataSource = ds.Tables(0)
        con.Close()
    End Sub

    Private Sub GA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetTasks()
        Me.Text = GAName
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub dgvTasks_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTasks.CellDoubleClick
        TaskID = Me.dgvTasks.CurrentRow.Cells(6).Value
        Supervisor = Me.dgvTasks.CurrentRow.Cells(0).Value
        Progress = Me.dgvTasks.CurrentRow.Cells(5).Value
        GAViewGATask.Show()
    End Sub

    Friend Function getTaskID()
        Return TaskID
    End Function

    Friend Function getSupervisor()
        Return Supervisor
    End Function

    Friend Function getProgress()
        Return Progress
    End Function
End Class