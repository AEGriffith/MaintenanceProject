Imports System.Data.OleDb


Public Class ViewInterviewComments
    'Setup connection information
    Dim ConnInfo As New DBConnectionInfo
    Dim ConnString As String = ConnInfo.GetConnString()
    Dim con As New OleDbConnection()

    'Get application ID to use in queries
    Dim AppID = Integer.Parse(Main.getSelectedApplicant())

    'Set variables to store items returned by queries
    Dim fName As String
    Dim lName As String
    Dim score As Decimal

    'Most of the stuff will be done on the form load since this will jsut display comments
    Private Sub ViewInterviewComments_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Setup commands
        Dim reader As OleDbDataReader
        Dim commandGetComments As New OleDbCommand
        Dim commandGetScore As New OleDbCommand("SELECT AVG(Interview_Score) FROM Interview WHERE Application_ID = '" & AppID & "'", con)

        'Setup commandGetComments - it doesn't have to be done this way, I was trying several things. This works the other way too (as above), I was just too lazy to change it
        'Personally I'd do it the way I did commandGetScore, this way is a bit long
        With commandGetComments
            .CommandText = "SELECT I.Interview_Comments, I.Interview_Score, U.First_Name, U.Last_Name FROM Interview I INNER JOIN User_ID U ON I.User_ID = U.User_ID WHERE I.Application_ID = '" & AppID & "'"
            .CommandType = CommandType.Text
            .Connection = con
        End With

        'Query for first and last name
        Dim commandGetFName As New OleDbCommand("SELECT First_Name FROM Application WHERE Application_Id = '" & AppID & "'", con)
        Dim commandGetLName As New OleDbCommand("SELECT Last_Name FROM Application WHERE Application_Id = '" & AppID & "'", con)


        con.ConnectionString = ConnString


        con.Open()

        'Put it in a try catch so that if something goes wrong with loading the data, we can get feedback
        Try
            'get student name
            fName = commandGetFName.ExecuteScalar()
            lName = commandGetLName.ExecuteScalar()
            'get averaged score
            score = commandGetScore.ExecuteScalar()
            'get all comments
            reader = commandGetComments.ExecuteReader()
            'set label to student name
            lblName.Text = lName & ", " & fName
            'set label to average score
            lblAvgScore.Text = score.ToString("N")

            'Will loop through until there are no more records
            Do While reader.Read()
                'The numbers will represent the order of columns from your query. Whatever comes first in the select statement will start at 0 and will increment for each column.
                'Make sure you get the right data type - like my scores need to be .GetDecimal because they are a data decimal type.
                TextBox1.Text &= reader.GetDecimal(1) & vbNewLine & reader.GetString(0) & vbNewLine & "-- " & reader.GetString(2) & "" & reader.GetString(3) & vbNewLine & vbNewLine
                'The &= is very important here because it allows you to append the text so you're not just replacing it every time
            Loop
        Catch ex As Exception
            'This will print the error (ex) to a message box
            MessageBox.Show(ex.ToString)
        End Try
        con.Close()



    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class