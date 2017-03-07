Imports System.Data.OleDb

Public Class InterviewAdd
    'Setup Basic Variables
    Dim StuFName As String
    Dim StuLName As String
    Dim CommentID As Decimal
    Dim Comment As String
    Dim Score As Decimal

    'Setup Connection Variables
    Dim ConnInfo As New DBConnectionInfo
    Dim ConnString As String = ConnInfo.GetConnString()
    Dim con As New OleDbConnection()

    'Get Important Variables from other forms
    Dim AppID = Integer.Parse(Main.getSelectedApplicant())
    Dim Username = Integer.Parse(Login.getUsername())


    Private Sub InterviewAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Check to see if user has left a comment before
        Dim commandCheckUser As New OleDbCommand("SELECT Comment_ID FROM Interview WHERE User_ID = '" & Username & "' AND Application_ID = '" & AppID & "'", con)


        'Get first and last names
        Dim commandGetFName As New OleDbCommand("SELECT First_Name FROM Application WHERE Application_Id = '" & AppID & "'", con)
        Dim commandGetLName As New OleDbCommand("SELECT Last_Name FROM Application WHERE Application_Id = '" & AppID & "'", con)
        con.ConnectionString = ConnString
        con.Open()

        Try
            StuFName = commandGetFName.ExecuteScalar
            StuLName = commandGetLName.ExecuteScalar
            CommentID = commandCheckUser.ExecuteScalar
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        con.Close()
        lblStuName.Text = StuLName & ", " & StuFName


        If CommentID = 0 Then
            'Changes Button text - If it is a new comment button text will be "Add", if there is already a comment, button text will be "update"
            btnAccept.Text = "Add"
        Else
            'Get Comment and Score
            Dim commandGetComment As New OleDbCommand("SELECT Interview_Comments FROM Interview WHERE Comment_ID =  '" & CommentID & "'", con)
            Dim commandGetScore As New OleDbCommand("SELECT Interview_Score FROM Interview WHERE Comment_ID = '" & CommentID & "'", con)
            'Changes button text to update
            btnAccept.Text = "Update"
            con.Open()
            'Sets variable values from database values
            Try

                Comment = commandGetComment.ExecuteScalar
                Score = commandGetScore.ExecuteScalar


            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            End Try
            con.Close()
            'Sets the textbox to the text in the comment column in the interview table: Will be editable
            tbComment.Text = Comment
            'Sets the track bar to the value in the score column in the interview table: Will be editable
            trackScore.Value = Score
        End If
    End Sub

    'For updating records (if commentID != 0)
    Private Sub UpdateRecord()
        con.ConnectionString = ConnString

        Dim sqlComm As New OleDbCommand

        sqlComm.Connection = con

        'setup for stored procedure
        sqlComm.CommandText = "procUpdateInterview"
        sqlComm.CommandType = CommandType.StoredProcedure

        'sets values for stored procedure
        sqlComm.Parameters.AddWithValue("comment_ID", Integer.Parse(CommentID))
        sqlComm.Parameters.AddWithValue("interview_comment", tbComment.Text)
        sqlComm.Parameters.AddWithValue("interview_score", trackScore.Value)

        con.Open()
        'execute stored procedure
        sqlComm.ExecuteNonQuery()
        con.Close()
    End Sub

    'For new records (if commentID = 0)
    Private Sub InsertNewRecord()



        con.ConnectionString = ConnString

        Dim sqlComm As New OleDbCommand

        sqlComm.Connection = con

        sqlComm.CommandText = "addInterviewComment"
        sqlComm.CommandType = CommandType.StoredProcedure

        sqlComm.Parameters.AddWithValue("AppID", Integer.Parse(AppID))
        sqlComm.Parameters.AddWithValue("userID", Integer.Parse(Username))
        sqlComm.Parameters.AddWithValue("comment", tbComment.Text)
        sqlComm.Parameters.AddWithValue("intscore", trackScore.Value)

        con.Open()

        sqlComm.ExecuteNonQuery()
        con.Close()


    End Sub

    Private Sub btnAccept_Click(sender As Object, e As EventArgs) Handles btnAccept.Click
        'Checks to see if comment box is blank
        If tbComment.Text = "" Then
            MessageBox.Show("Please enter a comment.")
        Else
            'Checks to see if it is a new comment or an update
            If CommentID = 0 Then
                Try
                    'New comment calls InsertNewRecord()
                    InsertNewRecord()
                    MessageBox.Show("Data Successfully Added!")
                    Me.Close()
                Catch ex As Exception
                    MessageBox.Show("Data was not added.")
                    'MessageBox.Show(ex.ToString) (system message)
                End Try
            Else
                Try
                    'Updating comment calls UpdateRecord()
                    UpdateRecord()
                    MessageBox.Show("Date Successfully Updated!")
                    Me.Close()
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