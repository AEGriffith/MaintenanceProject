Imports System.Data.OleDb
Public Class ApplicantProfile
    Dim StuFName As String
    Dim StuLName As String

    Dim ConnInfo As New DBConnectionInfo
    Dim ConnString As String = ConnInfo.GetConnString()
    Dim con As New OleDbConnection()
    Dim AppID = Integer.Parse(Main.getSelectedApplicant())
    Dim Username = Integer.Parse(Login.getUsername())
    Private Sub programtype()
        Try
            Dim conn As New SqlClient.SqlConnection
            conn.ConnectionString = ConnectionString
            Dim cmdString As String = "SELECT Program FROM Application WHERE Application_Id = '" & AppID & "'"
            Dim Command As New SqlClient.SqlCommand
            Command.CommandText = cmdString
            Command.Connection = conn
            Dim dr As SqlClient.SqlDataReader
            conn.Open()
            dr = Command.ExecuteReader
            While dr.Read
                Label_ProgramType.Text = dr.GetValue(0).ToString
            End While
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Application_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        programtype()



        'TODO: This line of code loads data into the 'PROJECTS1747DataSet2.Application' table. You can move, or remove it, as needed.
        Me.ApplicationTableAdapter.Fill(Me.PROJECTS1747DataSet2.Application)

        ApplicationBindingSource.Filter = String.Format("Application_ID = '{0}'", AppID)

        Dim commandGetFName As New OleDbCommand("SELECT First_Name FROM Application WHERE Application_Id = '" & AppID & "'", con)
        Dim commandGetLName As New OleDbCommand("SELECT Last_Name FROM Application WHERE Application_Id = '" & AppID & "'", con)
        con.ConnectionString = ConnString
        con.Open()

        Try
            StuFName = commandGetFName.ExecuteScalar
            StuLName = commandGetLName.ExecuteScalar
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        con.Close()
        lblStuName.Text = StuLName & ", " & StuFName
    End Sub
    Private Sub btnComment_Click(sender As Object, e As EventArgs) Handles btnComment.Click
        Application.Show()

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAddInterview.Click
        InterviewAdd.Show()
    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        ViewComments.Show()
    End Sub
End Class