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

        Dim commandGetApplID As New OleDbCommand("SELECT Application_Id FROM Application WHERE Application_Id = '" & AppID & "'", con)
        Dim commandGetFName As New OleDbCommand("SELECT First_Name FROM Application WHERE Application_Id = '" & AppID & "'", con)
        Dim commandGetLName As New OleDbCommand("SELECT Last_Name FROM Application WHERE Application_Id = '" & AppID & "'", con)
        con.ConnectionString = ConnString
        con.Open()

        Try
            ApplID = commandGetApplID.ExecuteScalar
            StuFName = commandGetFName.ExecuteScalar
            StuLName = commandGetLName.ExecuteScalar
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        con.Close()
        lblStuName.Text = StuLName & ", " & StuFName
        lblAppID.Text = ApplID

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class