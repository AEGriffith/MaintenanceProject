Imports System.Data.OleDb
Public Class GASupervisorTask
    'Setup Connection Variables
    Dim ConnInfo As New DBConnectionInfo
    Dim ConnString As String = ConnInfo.GetConnString()
    Dim con As New OleDbConnection()

    Dim Supervisor_ID = Login.getUsername()
    Dim Semester = "Fa2017"

    Dim GAID
    Dim EstHours
    Dim DueDate
    Dim TaskType
    Dim Priority
    Dim Instructions

    Private Sub CreateTask()
        con.ConnectionString = ConnString

        Dim sqlComm As New OleDbCommand
        Dim ds As New DataSet


        sqlComm.Connection = con

        'setup for stored procedure
        sqlComm.CommandText = "procCreateTask"
        sqlComm.CommandType = CommandType.StoredProcedure
        sqlComm.Connection = con


        'sets values for stored procedure
        sqlComm.Parameters.AddWithValue("UserID", Supervisor_ID)
        sqlComm.Parameters.AddWithValue("GAID", GAID)
        sqlComm.Parameters.AddWithValue("EstHours", EstHours)
        sqlComm.Parameters.AddWithValue("DueDate", DueDate)
        sqlComm.Parameters.AddWithValue("TaskType", TaskType)
        sqlComm.Parameters.AddWithValue("Priority", Priority)
        sqlComm.Parameters.AddWithValue("Instructions", Instructions)




        con.Open()
        sqlComm.ExecuteNonQuery()

        con.Close()
    End Sub

    Private Sub GASupervisorTask_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ViewAssignedGAs._viewAssignedGAs' table. You can move, or remove it, as needed.
        ViewAssignedGAsBindingSource.Filter = "Supervisor_ID = " & Supervisor_ID
        ViewAssignedGAs.EnforceConstraints = False
        Me.ViewAssignedGAsTableAdapter.Fill(Me.ViewAssignedGAs._viewAssignedGAs)



    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        If cbGA.SelectedIndex = -1 Then
            MessageBox.Show("Please Select a GA.", "Data Entry Error")
        ElseIf cbTaskType.SelectedIndex = -1 Then
            MessageBox.Show("Please select a Task Type.", "Data Entry Error")
        ElseIf cbPriority.SelectedIndex = -1 Then
            MessageBox.Show("Please select a Priority.", "Data Entry Error")
        ElseIf tbInstructions.Text = "" Then
            MessageBox.Show("PLease enter task instructions.", "Data Entry Error")
        Else
            GAID = cbGA.SelectedValue
            EstHours = NumericUpDown1.Value
            DueDate = dateDue.Value
            TaskType = cbTaskType.Text
            Priority = cbPriority.Text
            Instructions = tbInstructions.Text
            CreateTask()
            MessageBox.Show("Task successfully assigned to " & cbGA.Text & ".")
            GASupervisor.GetAssignedTasks()
            Me.Close()
        End If

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        Me.Close()
    End Sub
End Class