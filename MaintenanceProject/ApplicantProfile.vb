Imports System.Data.OleDb
Public Class ApplicantProfile
    Dim StuFName As String
    Dim StuLName As String

    Dim ConnInfo As New DBConnectionInfo
    Dim ConnString As String = ConnInfo.GetConnString()
    Dim con As New OleDbConnection()
    Dim AppID = Integer.Parse(Main.getSelectedApplicant())
    Dim Username = Integer.Parse(Login.getUsername())

    Private Sub Application_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PROJECTS1747DataSet2.Application' table. You can move, or remove it, as needed.
        Me.ApplicationTableAdapter.Fill(Me.PROJECTS1747DataSet2.Application)

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


End Class