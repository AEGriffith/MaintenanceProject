Imports System.Data.OleDb
Public Class DegreeProgress

    'Setup Connection Variables
    Dim ConnInfo As New DBConnectionInfo
    Dim ConnString As String = ConnInfo.GetConnString()
    Dim con As New OleDbConnection()

    'Gets variables from advising form
    Dim StudentName = Advising.getStudentName
    Dim Program = Advising.getProgram
    Dim Concentration = Advising.getConcentration
    Dim StudentID = Advising.getStudentID

    Dim GradCheck

    Private Sub DegreeProgress_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Sets label information
        lblName.Text = StudentName
        'find the current right alignment position
        Dim rightAlignProgram As Integer = lblProgram.Left + lblProgram.Width
        'set the text
        lblProgram.Text = Program
        'adjust position so that the right hand point is in the same position as before
        lblProgram.Left = rightAlignProgram - lblProgram.Width
        'find the current right alignment position
        Dim rightAlignConcentration As Integer = lblConcentration.Left + lblConcentration.Width
        'set the text (assumes AutoSize is set to True)
        lblConcentration.Text = Concentration
        'adjust position so the right hand point is in the same position as before
        lblConcentration.Left = rightAlignConcentration - lblConcentration.Width
        lblStuID.Text = StudentID
        Me.Width = -lblConcentration.Width

        GetCoursesRemaining()
        GetCoursesTaken()

        If Login.getAdminCheck = True Then
            checkReady.Enabled = True
        Else
            checkReady.Enabled = False
        End If

        Dim commandGetGraduationCheck As New OleDbCommand("SELECT Graduation_Check FROM Student WHERE Student_ID = " & StudentID, con)
        con.Open()
        Try
            GradCheck = commandGetGraduationCheck.ExecuteScalar()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        con.Close()
        If IsDBNull(GradCheck) Then

        ElseIf GradCheck = True Then
            checkReady.Checked = True
        Else
            checkReady.Checked = False
        End If
    End Sub

    Private Sub GetCoursesRemaining()
        con.ConnectionString = ConnString

        Dim sqlComm As New OleDbCommand
        Dim ds As New DataSet


        sqlComm.Connection = con

        'setup for stored procedure
        sqlComm.CommandText = "procGetRemainingCourses"
        sqlComm.CommandType = CommandType.StoredProcedure
        sqlComm.Connection = con


        'sets values for stored procedure
        sqlComm.Parameters.AddWithValue("Student_ID", Integer.Parse(StudentID))

        con.Open()
        Dim Adpt = New OleDbDataAdapter(sqlComm)
        Adpt.Fill(ds)
        dgvRemainingCourses.DataSource = ds.Tables(0)
        con.Close()
    End Sub

    Private Sub GetCoursesTaken()
        con.ConnectionString = ConnString

        Dim sqlComm As New OleDbCommand
        Dim ds As New DataSet


        sqlComm.Connection = con

        'setup for stored procedure
        sqlComm.CommandText = "procGetStudentCourseHistory"
        sqlComm.CommandType = CommandType.StoredProcedure
        sqlComm.Connection = con


        'sets values for stored procedure
        sqlComm.Parameters.AddWithValue("Student_ID", Integer.Parse(StudentID))

        con.Open()
        Dim Adpt = New OleDbDataAdapter(sqlComm)
        Adpt.Fill(ds)
        dgvTakenCourses.DataSource = ds.Tables(0)
        con.Close()
    End Sub

    Private Sub lblProgram_Click(sender As Object, e As EventArgs) Handles lblProgram.Click, lblConcentration.Click
        If lblProgram.Text = "MIS" Then
            If lblConcentration.Text.Contains("Information Technology") Then
                MISReq.setIT()
            ElseIf lblConcentration.Text.Contains("Enterprise Resource") Then
                MISReq.setERP()
            ElseIf lblConcentration.Text.Contains("Enterprise Systems") Then
                MISReq.setES()
            Else
                MISReq.setSE()
            End If
            MISReq.Show()
        ElseIf lblProgram.Text = "PMIS" Then
            If lblConcentration.Text.Contains("Enterprise Systems") Then
                PMISReq.setES()
            Else
                PMISReq.setERP()
            End If
            PMISReq.Show()
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub checkReady_CheckedChanged(sender As Object, e As EventArgs) Handles checkReady.CheckedChanged
        Dim GraduationCheck
        If checkReady.Checked = True Then
            GraduationCheck = 1
        Else
            GraduationCheck = 0
        End If
        con.ConnectionString = ConnString
        Dim commandSetGraduation As New OleDbCommand("UPDATE Student SET Graduation_Check = " & GraduationCheck & " WHERE Student_ID = " & StudentID, con)
        con.Open()

        Try
            commandSetGraduation.ExecuteScalar()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

        con.Close()

    End Sub
End Class