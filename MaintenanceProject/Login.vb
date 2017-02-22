Imports System.Data.OleDb

Public Class Login
    Dim UserName As String
    Dim Password As String
    Dim AdvisorCheck As Boolean
    Dim CommitteeCheck As Boolean
    Dim AdminCheck As Boolean

    Dim ConnInfo As New DBConnectionInfo
    Dim ConnString As String = ConnInfo.GetConnString()
    Dim con As New OleDbConnection()

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        If tbUsername.Text = "" Then
            MessageBox.Show("Please enter a username.", "Data Entry Error")
        ElseIf tbPassword.Text = "" Then
            MessageBox.Show("Please enter a password.", "Data Entry Error")
        Else
            UserName = tbUsername.Text

            Dim commandGetPass As New OleDbCommand("SELECT Password FROM Users WHERE Username = '" & UserName & "'", con)
            Dim commandGetAdmin As New OleDbCommand("SELECT Admin FROM Users WHERE Username = '" & UserName & "'", con)
            Dim commandGetCommittee As New OleDbCommand("SELECT Committee FROM Users WHERE Username = '" & UserName & "'", con)
            Dim commandGetAdvisor As New OleDbCommand("SELECT Advisor FROM Users WHERE Username = '" & UserName & "'", con)
            con.ConnectionString = ConnString
            con.Open()

            Try
                Password = commandGetPass.ExecuteScalar
                If Password = "" Then
                    MessageBox.Show("User not found.", "Data Entry Error")
                ElseIf Password = tbPassword.Text Then
                    Try
                        AdminCheck = commandGetAdmin.ExecuteScalar()
                        CommitteeCheck = commandGetCommittee.ExecuteScalar()
                        If AdminCheck = True Then
                            MessageBox.Show("This user is an Admin!")
                        ElseIf CommitteeCheck = True Then
                            MessageBox.Show("This user is a Committee Memeber!")
                        ElseIf AdvisorCheck = True Then
                            MessageBox.Show("This user is an Advisor!")
                        Else
                            MessageBox.Show("Please contact your System Administrator.")
                        End If
                    Catch
                    End Try
                End If

            Catch ex As Exception

            End Try
        End If
    End Sub
End Class