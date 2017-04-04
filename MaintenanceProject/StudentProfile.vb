Imports System.Data.OleDb
Public Class StudentProfile
    'Setup Connection Variables
    Dim ConnInfo As New DBConnectionInfo
    Dim ConnString As String = ConnInfo.GetConnString()
    Dim con As New OleDbConnection()

    'Gets variables from advising form
    Dim StudentName = Advising.getStudentName
    Dim Program = Advising.getProgram
    Dim Concentration = Advising.getConcentration
    Dim StudentID = Advising.getStudentID

    'Set Variables for SQL
    Dim SelectedProgram As String
    Dim SelectedConcentration As String

    'Set Options for Concentration
    Dim MISConcentrations = New String() {"Information Technology Management", "Enterprise Resource Planning (ERP) Management", "Enterprise Systems (ES) Management", "Software Engineering Management"}
    Dim PMISConcentrations = New String() {"Enterprise Resource Planning (ERP)", "Enterprise Systems (ES)"}

    Private Sub StudentProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load


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

        'Sets the Program Selection in the Edit tab
        If lblProgram.Text = "MIS" Then
            cbProgram.SelectedIndex = 0
        Else
            cbProgram.SelectedIndex = 1
        End If

        'Sets the concentration selection in the Edit tab
        cbConcentration.SelectedItem = Concentration

    End Sub

    'Opens the appropriate requirements form
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

    'Set up Stored Procedure to Update Program
    Private Sub UpdateProgram()
        con.ConnectionString = ConnString

        Dim sqlComm As New OleDbCommand

        sqlComm.Connection = con

        'setup for stored procedure
        sqlComm.CommandText = "procUpdateProgram"
        sqlComm.CommandType = CommandType.StoredProcedure

        'sets values for stored procedure
        sqlComm.Parameters.AddWithValue("Program", SelectedProgram)
        sqlComm.Parameters.AddWithValue("Concentration", SelectedConcentration)
        sqlComm.Parameters.AddWithValue("StudentID", Integer.Parse(StudentID))

        con.Open()
        'execute stored procedure
        sqlComm.ExecuteNonQuery()

        con.Close()
    End Sub



    'Changes the options in the Concentration combo box to the right list
    Private Sub cbProgram_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbProgram.SelectedIndexChanged
        Select Case cbProgram.SelectedIndex
            Case -1
                cbConcentration.Items.Clear()
                cbConcentration.Enabled = False
            Case 0
                cbConcentration.Items.Clear()
                cbConcentration.Items.AddRange(MISConcentrations)
                cbConcentration.SelectedIndex = 0
                cbConcentration.Enabled = True
            Case 1
                cbConcentration.Items.Clear()
                cbConcentration.Items.AddRange(PMISConcentrations)
                cbConcentration.SelectedIndex = 0
                cbConcentration.Enabled = True
        End Select
    End Sub

    'Updates Everything
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If cbProgram.SelectedIndex = -1 Then
            MessageBox.Show("Please Select a Program")
        ElseIf cbConcentration.SelectedIndex = -1 Then
            MessageBox.Show("Please Select a Concentration")
        Else
            SelectedProgram = cbProgram.SelectedItem
            SelectedConcentration = cbConcentration.SelectedItem
            UpdateProgram()
            Advising.ViewStudentTableAdapter.Fill(Advising.PROJECTS1747DataSet1.viewStudent)
            MessageBox.Show("Successfully Updated")
            Me.Close()
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub DegreeProgressToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DegreeProgressToolStripMenuItem.Click
        DegreeProgress.Show()
    End Sub
End Class