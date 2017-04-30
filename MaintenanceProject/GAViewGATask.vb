Imports System.Data.OleDb
Public Class GAViewGATask

    'Setup Connection Variables
    Dim ConnInfo As New DBConnectionInfo
    Dim ConnString As String = ConnInfo.GetConnString()
    Dim con As New OleDbConnection()

    Dim Supervisor = GA.getSupervisor()
    Dim TaskID = GA.getTaskID()
    Dim Progress = GA.getProgress()

    Dim commandCompleteDate As New OleDbCommand("UPDATE Task SET Completed = 'True' WHERE Task_ID = " & TaskID, con)

    Dim EndDate
    Dim Hours

    Private Sub GAViewGATask_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PROJECTS1747DataSet7.Task' table. You can move, or remove it, as needed.
        Me.TaskTableAdapter.Fill(Me.PROJECTS1747DataSet7.Task)
        TaskBindingSource.Filter = "Task_ID = " & TaskID
        tbSupervisor.Text = Supervisor
        cbProgress.SelectedText = Progress


        If cbProgress.SelectedIndex = 2 Then
            numActualHours.Enabled = True
        Else
            numActualHours.Value = 0
            numActualHours.Enabled = False
        End If
    End Sub

    Private Sub UpdateTasks()
        con.ConnectionString = ConnString

        Dim sqlComm As New OleDbCommand
        Dim ds As New DataSet


        sqlComm.Connection = con

        'setup for stored procedure
        sqlComm.CommandText = "procGAUpdateTask"
        sqlComm.CommandType = CommandType.StoredProcedure
        sqlComm.Connection = con


        'sets values for stored procedure
        sqlComm.Parameters.AddWithValue("Task_ID", Integer.Parse(TaskID))
        sqlComm.Parameters.AddWithValue("Progress", Progress)
        sqlComm.Parameters.AddWithValue("ActualHours", Hours)

        con.Open()
        sqlComm.ExecuteNonQuery()
        con.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Progress = cbProgress.Text
        Hours = numActualHours.Value
        UpdateTasks()
        If cbProgress.SelectedIndex = 2 Then
            con.Open()
            commandCompleteDate.ExecuteNonQuery()
            con.Close()
        End If
        MessageBox.Show("Task Successfully Updated.", "Task " & TaskID)
        GA.GetTasks()
        Me.Close()
    End Sub

    Private Sub cbProgress_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbProgress.SelectedIndexChanged
        If cbProgress.SelectedIndex = 2 Then
            numActualHours.Enabled = True
        Else
            numActualHours.Value = 0
            numActualHours.Enabled = False
        End If
    End Sub
End Class