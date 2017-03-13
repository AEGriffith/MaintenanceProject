Imports System.Data.OleDb
Public Class ApplicantProfile
    'setup basic variables
    Dim StuFName As String
    Dim StuLName As String
    Dim Program As String
    Dim Decision As String
    'set options for MIS combobox
    Dim MISDecision = New String() {"Gold", "Silver", "Waitlist", "Reject"}
    'set options for PMIS combobox
    Dim PMISDecision = New String() {"Accept", "Waitlist", "Reject"}
    'set connection information
    Dim ConnInfo As New DBConnectionInfo
    Dim ConnString As String = ConnInfo.GetConnString()
    Dim con As New OleDbConnection()
    'get information from other forms
    Dim AppID = Integer.Parse(Main.getSelectedApplicant())
    Dim Username = Integer.Parse(Login.getUsername())




    Private Sub Application_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PROJECTS1747DataSet2.Application' table. You can move, or remove it, as needed.
        Me.ApplicationTableAdapter.Fill(Me.PROJECTS1747DataSet2.Application)

        ApplicationBindingSource.Filter = String.Format("Application_ID = '{0}'", AppID)
        'sql that gets name
        Dim commandGetFName As New OleDbCommand("SELECT First_Name FROM Application WHERE Application_Id = '" & AppID & "'", con)
        Dim commandGetLName As New OleDbCommand("SELECT Last_Name FROM Application WHERE Application_Id = '" & AppID & "'", con)
        'sql that gets program
        Dim commandGetProgram As New OleDbCommand("SELECT Program FROM Application WHERE Application_Id = '" & AppID & "'", con)
        'sql that gets Decision
        Dim commandGetDecision As New OleDbCommand("SELECT Decision From Application WHERE Application_Id = '" & AppID & "'", con)

        con.ConnectionString = ConnString
        con.Open()

        Try
            StuFName = commandGetFName.ExecuteScalar
            StuLName = commandGetLName.ExecuteScalar
            Program = commandGetProgram.ExecuteScalar
            Decision = commandGetDecision.ExecuteScalar
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        con.Close()
        lblStuName.Text = StuLName & ", " & StuFName

        MessageBox.Show(Decision)

        'If Decision = "" Or null Then
        '    cbDecision.SelectedIndex = -1
        'Else
        '    cbDecision.SelectedText = Decision
        'End If

        'sets combobox items based on program
        Select Case Program
            Case "MIS"
                cbDecision.Items.AddRange(MISDecision)
            Case "PMIS"
                cbDecision.Items.AddRange(PMISDecision)
        End Select

    End Sub
    Private Sub btnComment_Click(sender As Object, e As EventArgs) Handles btnComment.Click
        Application.Show()

    End Sub


    Private Sub ButtonAddInterview_Click(sender As Object, e As EventArgs) Handles btnAddInterview.Click
        InterviewAdd.Show()
    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        ViewComments.Show()
    End Sub

    Private Sub ButtonViewInterview_Click_1(sender As Object, e As EventArgs) Handles btnViewInterview.Click
        ViewInterviewComments.Show()
    End Sub

    Private Sub AddUpdateCommentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddUpdateCommentToolStripMenuItem.Click

    End Sub

    Friend Function getProgram()
        Return Program
    End Function

    Friend Function getName()
        Return StuLName & ", " & StuFName
    End Function

    Private Sub SetAdmissionDecisionToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Admissions.Show()
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        'sql that updates admissions decision
        Dim commandSetDecision As New OleDbCommand("UPDATE Application SET Decision = '" & cbDecision.SelectedValue & "' WHERE Application_ID = '" & AppID & "'", con)
        con.ConnectionString = ConnString
        con.Open()


        Try
            commandSetDecision.ExecuteNonQuery()
            MessageBox.Show("Decision Updated")
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        con.Close()
    End Sub

    Private Sub cbDecision_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbDecision.SelectedIndexChanged

    End Sub
End Class