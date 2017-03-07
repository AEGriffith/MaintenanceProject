Imports System.Data.OleDb
Public Class ViewComments

    Dim StuFName As String
    Dim StuLName As String
    Dim ApplID As Integer


    Dim ConnInfo As New DBConnectionInfo
    Dim ConnString As String = ConnInfo.GetConnString()
    Dim con As New OleDbConnection()
    Dim AppID = Integer.Parse(Main.getSelectedApplicant())
    Dim Username = Integer.Parse(Login.getUsername())


    Private Sub ViewComments_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim reader As OleDbDataReader
        Dim commandGetComments As New OleDbCommand
        Dim commandGetApplID As New OleDbCommand("SELECT Application_Id FROM Application WHERE Application_Id = '" & AppID & "'", con)
        Dim commandGetFName As New OleDbCommand("SELECT First_Name FROM Application WHERE Application_Id = '" & AppID & "'", con)
        Dim commandGetLName As New OleDbCommand("SELECT Last_Name FROM Application WHERE Application_Id = '" & AppID & "'", con)
        con.ConnectionString = ConnString
        con.Open()

        With commandGetComments
            .CommandText = "SELECT A.Comments, A.Recomendations, U.First_Name, U.Last_Name FROM Application_Comment A INNER JOIN User_ID U ON A.User_ID = U.User_ID WHERE A.Application_ID = '" & AppID & "'"
            .CommandType = CommandType.Text
            .Connection = con
        End With

        'Put it In a Try Catch so that If something goes wrong With loading the data, we can get feedback
        Try
            '    get student name
            StuFName = commandGetFName.ExecuteScalar()
            StuLName = commandGetLName.ExecuteScalar()
            '    get all comments
            reader = commandGetComments.ExecuteReader()
            ApplID = commandGetApplID.ExecuteScalar

            lblStuName.Text = StuLName & ", " & StuFName
            lblAppID.Text = ApplID

            '    Will loop through until there are no more records
            Do While reader.Read()
                '        The numbers will represent the order of columns from your query. Whatever comes first in the select statement will start at 0 And will increment for each column.
                '        Make sure you get the right data type - Like my scores need to be .GetDecimal because they are a data decimal type.
                TextBox1.Text &= reader.GetString(2) & " " & reader.GetString(3) & vbNewLine & "Recomendation:" & vbNewLine & reader.GetString(1) & vbNewLine & "Comments:" & vbNewLine & reader.GetString(0) & "" & vbNewLine & vbNewLine
                '        The &= Is very important here because it allows you To append the text so you're not just replacing it every time
            Loop
        Catch ex As Exception
            '    This will print the error (ex) to a message box
            MessageBox.Show(ex.ToString)
        End Try
        con.Close()

        'Try
        '    'ApplID = commandGetApplID.ExecuteScalar
        '    StuFName = commandGetFName.ExecuteScalar
        '    StuLName = commandGetLName.ExecuteScalar
        'Catch ex As Exception
        '    MessageBox.Show(ex.ToString)
        'End Try


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class