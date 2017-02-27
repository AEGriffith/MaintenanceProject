Imports System.Data.OleDb

Public Class InterviewAdd
    Dim StuFName As String
    Dim StuLName As String

    Dim ConnInfo As New DBConnectionInfo
    Dim ConnString As String = ConnInfo.GetConnString()
    Dim con As New OleDbConnection()
    Dim AppID = Main.getSelectedApplicant()

    Private Sub InterviewAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

        lblStuName.Text = StuLName & ", " & StuFName
    End Sub
End Class