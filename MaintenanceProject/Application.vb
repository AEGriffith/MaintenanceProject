Imports System.Data.OleDb
Public Class Application

    Dim StuName = ApplicantProfile.getName()
    Dim CommentID As Integer
    Dim Comment As String
    Dim Recommendation As String
    'Get Program Recommendation Options
    Dim MISDecision = ApplicantProfile.getMISDecision()
    Dim PMISDecision = ApplicantProfile.getPMISDecision()
    'Get Program
    Dim Program = ApplicantProfile.getProgram

    Dim ConnInfo As New DBConnectionInfo
        Dim ConnString As String = ConnInfo.GetConnString()
        Dim con As New OleDbConnection()
        Dim AppID = Integer.Parse(Main.getSelectedApplicant())
        Dim Username = Integer.Parse(Login.getUsername())


    Private Sub Application_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Check to see if user has already left a recommendation comment - will return a value for Application_Comment_ID
        Dim commandCheckUser As New OleDbCommand("SELECT Application_Comment_ID FROM Application_Comment WHERE User_ID = '" & Username & "' AND Application_ID = '" & AppID & "'", con)


        con.ConnectionString = ConnString
        con.Open()

        Try

            'executes the check to see if user has alredy left a comment for this application
            CommentID = commandCheckUser.ExecuteScalar
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        con.Close()
        lblStuName.Text = StuName

        If CommentID = 0 Then
            'Changes Button text - If it is a new comment button text will be "Add", if there is already a comment, button text will be "update"
            btnAddComment.Text = "Add"
        Else
            'Get Comment and Score
            Dim commandGetComment As New OleDbCommand("SELECT Comments FROM Application_Comment WHERE Application_Comment_ID =  '" & CommentID & "'", con)
            Dim commandGetRecommendation As New OleDbCommand("SELECT Recomendations FROM Application_Comment WHERE Application_Comment_ID = '" & CommentID & "'", con)
            'Changes button text to update
            btnAddComment.Text = "Update"
            con.Open()
            'Sets variable values from database values
            Try
                'executes queries to set the variable values from values in database
                Comment = commandGetComment.ExecuteScalar
                Recommendation = commandGetRecommendation.ExecuteScalar


            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            End Try
            con.Close()
            'Sets the textbox to the text in the comment column in the application_comment table: Will be editable
            tbComment.Text = Comment
            'Sets the track bar to the value in the score column in the application_comment table: Will be editable
            cbRecommendation.SelectedText = Recommendation
        End If

        'Populates recommendation combobox based on Program
        Select Case Program
            Case "MIS"
                cbRecommendation.Items.Clear()
                cbRecommendation.Items.AddRange(MISDecision)
            Case "PMIS"
                MessageBox.Show("PMIS")
                cbRecommendation.Items.Clear()
                cbRecommendation.Items.AddRange(PMISDecision)
        End Select

    End Sub

    'Stored procedure to update records
    Private Sub UpdateRecord()
        If cbRecommendation.Text <> "" Then
            con.ConnectionString = ConnString

            Dim sqlComm As New OleDbCommand

            sqlComm.Connection = con

            sqlComm.CommandText = "procUpdateApplicationComment"
            sqlComm.CommandType = CommandType.StoredProcedure

            sqlComm.Parameters.AddWithValue("comment_ID", Integer.Parse(CommentID))
            sqlComm.Parameters.AddWithValue("comment", tbComment.Text)
            sqlComm.Parameters.AddWithValue("recommend", cbRecommendation.Text)

            con.Open()

            sqlComm.ExecuteNonQuery()
            con.Close()
            MessageBox.Show("Date Successfully Updated!")
            Me.Close()
        Else
            MessageBox.Show("Recommendation required")
        End If
    End Sub
    Private Sub InsertNewRecord()


        If cbRecommendation.Text <> "" Then
            con.ConnectionString = ConnString

            Dim sqlComm As New OleDbCommand

            sqlComm.Connection = con

            sqlComm.CommandText = "addApplicationComment"
            sqlComm.CommandType = CommandType.StoredProcedure

            sqlComm.Parameters.AddWithValue("AppID", Integer.Parse(AppID))
            sqlComm.Parameters.AddWithValue("userID", Integer.Parse(Username))
            sqlComm.Parameters.AddWithValue("comment", tbComment.Text)
            sqlComm.Parameters.AddWithValue("recommendations", cbRecommendation.Text)

            con.Open()

            sqlComm.ExecuteNonQuery()
            con.Close()
            MessageBox.Show("Data Successfully Added!")
            Me.Close()
        Else
            MessageBox.Show("Recommendation required")
        End If


    End Sub

    Private Sub btnAddComment_Click(sender As Object, e As EventArgs) Handles btnAddComment.Click

        'Checks to see if comment box is blank
        If tbComment.Text = "" Then
            MessageBox.Show("Please enter a comment.")
        Else
            'Checks to see if it is a new comment or an update
            If CommentID = 0 Then
                Try
                    'New comment calls InsertNewRecord()
                    InsertNewRecord()


                Catch ex As Exception
                    MessageBox.Show("Data was not added.")
                    'MessageBox.Show(ex.ToString) (system message)
                End Try
            Else
                Try
                    'Updating comment calls UpdateRecord()
                    UpdateRecord()


                Catch ex As Exception
                    MessageBox.Show("Data was not updated.")
                End Try
            End If
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub


End Class
