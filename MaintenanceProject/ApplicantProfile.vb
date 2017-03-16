Imports System.Data.OleDb
Public Class ApplicantProfile
    'setup basic variables
    Dim StuFName As String
    Dim StuLName As String
    Dim Program As String
    Dim Decision
    Dim Response
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
    Dim ProgramDirector = Login.getAdminCheck()




    Private Sub Application_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PROJECTS1747DataSet2.Application' table. You can move, or remove it, as needed.
        Me.ApplicationTableAdapter.Fill(Me.PROJECTS1747DataSet2.Application)

        ApplicationBindingSource.Filter = String.Format("Application_ID = '{0}'", AppID)
        'sql that gets name
        Dim commandGetFName As New OleDbCommand("SELECT First_Name FROM Application WHERE Application_Id = '" & AppID & "'", con)
        Dim commandGetLName As New OleDbCommand("SELECT Last_Name FROM Application WHERE Application_Id = '" & AppID & "'", con)
        'sql that gets program
        Dim commandGetProgram As New OleDbCommand("SELECT P.Program_Name FROM Program_Requirement P INNER JOIN Student S ON P.Program_ID = S.Program_ID INNER JOIN Application A ON S.Student_ID = A.Student_ID WHERE A.Application_Id = '" & AppID & "'", con)
        'sql that gets Decision
        Dim commandGetDecision As New OleDbCommand("SELECT Decision From Application WHERE Application_Id = '" & AppID & "'", con)
        'sql that gets Response
        Dim commandGetResponse As New OleDbCommand("SELECT Response From Application WHERE Application_Id = '" & AppID & "'", con)

        con.ConnectionString = ConnString
        con.Open()

        'sets variables to values in the database using sql
        Try
            StuFName = commandGetFName.ExecuteScalar
            StuLName = commandGetLName.ExecuteScalar
            Program = commandGetProgram.ExecuteScalar
            Decision = commandGetDecision.ExecuteScalar
            Response = commandGetResponse.ExecuteScalar
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        con.Close()

        'Displays the student's name
        lblStuName.Text = StuLName & ", " & StuFName

        'For some reason, the database allows these values to be null. Tables must be deleted and recreated to change this.
        If IsDBNull(StuFName) Then
            MessageBox.Show("Student Information Missing (Name), Contact Database Administrator.")
        ElseIf IsDBNull(StuLName) Then
            MessageBox.Show("Student Information Missing (Name), Contact Database Administrator.")
        ElseIf IsDBNull(Program) Then
            MessageBox.Show("Student Information Missing (Name), Contact Database Administrator.")
        End If

        'Checks to see if there is a decision for this application. If there is, it will populate the combobox with that decision.
        'Will not be editable by committee members, only Program Director (Admin)
        If Not IsDBNull(Decision) Then
            cbDecision.Text = Decision
            If Not IsDBNull(Response) Then
                Select Case Decision
                'Checking to see if the decision was Accept, Gold, or Silver. If it is not one of these, there should be no response.
                    Case "Accept"
                        tbResponse.Text = Response
                    Case "Silver"
                        tbResponse.Text = Response
                    Case "Gold"
                        tbResponse.Text = Response
                    Case "Reject"
                        tbResponse.Clear()
                    Case "Waitlist"
                        tbResponse.Clear()

                End Select
            Else
                tbResponse.Clear()
            End If

        Else
            cbDecision.SelectedIndex = -1
            'If there is no decision yet, there should be no response. The textbox won't show a response if there is no decision.
            tbResponse.Clear()
        End If

        'Populates Decision combobox based on student's program
        Select Case Program
            Case "MIS"
                cbDecision.Items.AddRange(MISDecision)
            Case "PMIS"
                cbDecision.Items.AddRange(PMISDecision)
        End Select

        'Checks to see if user is program director to enable combobox for decisions.
        'All Committee members can see decision, but cannot edit unless Program Director
        If ProgramDirector = True Then
            cbDecision.Enabled = True
            lblResponse.Visible = True
            tbResponse.Visible = True
            btnSubmit.Visible = True
            btnSubmit.Enabled = True
        Else
            cbDecision.Enabled = False
            lblResponse.Visible = False
            tbResponse.Visible = False
            btnSubmit.Visible = False
            btnSubmit.Enabled = False
        End If

    End Sub


    Friend Function getProgram()
        Return Program
    End Function

    Friend Function getName()
        Return StuLName & ", " & StuFName
    End Function



    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        'sql that updates admissions decision
        Dim commandSetDecision As New OleDbCommand("UPDATE Application SET Decision = '" & cbDecision.SelectedItem & "' WHERE Application_ID = '" & AppID & "'", con)
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

    'Removed buttons, access comments from menu
    Private Sub menuEditRecommendation_Click(sender As Object, e As EventArgs) Handles menuEditRecommendation.Click
        Application.Show()
    End Sub

    Private Sub menuEditInterview_Click(sender As Object, e As EventArgs) Handles menuEditInterview.Click
        InterviewAdd.Show()
    End Sub

    Private Sub menuViewRecommendations_Click(sender As Object, e As EventArgs) Handles menuViewRecommendations.Click
        ViewComments.Show()
    End Sub

    Private Sub menuViewInterview_Click(sender As Object, e As EventArgs) Handles menuViewInterview.Click
        ViewInterviewComments.Show()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Friend Function getMISDecision()
        Return MISDecision
    End Function

    Friend Function getPMISDecision()
        Return PMISDecision
    End Function
End Class