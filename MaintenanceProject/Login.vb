﻿Imports System.Data.OleDb

Public Class Login
    Dim UserName As Integer
    Dim Password As String
    Dim AdvisorCheck
    Dim CommitteeCheck
    Dim AdminCheck
    Dim GACheck
    Dim SupervisorCheck
    Dim FirstName As String
    Dim LastName As String

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
            Try
                UserName = Integer.Parse(tbUsername.Text)

            Catch
                MessageBox.Show("Please enter an appropriate User ID.")
            End Try
            Dim commandGetPass As New OleDbCommand("SELECT Password FROM User_ID WHERE User_ID = " & UserName, con)
            Dim commandGetAdmin As New OleDbCommand("SELECT Admin FROM User_ID WHERE User_ID = " & UserName, con)
            Dim commandGetCommittee As New OleDbCommand("SELECT Committee_Member FROM User_ID WHERE User_ID = " & UserName, con)
            Dim commandGetAdvisor As New OleDbCommand("SELECT Advisor FROM User_ID WHERE User_ID = " & UserName, con)
            Dim commandGetGA As New OleDbCommand("SELECT GA FROM User_ID WHERE User_ID = " & UserName, con)
            Dim commandGetGASupervisor As New OleDbCommand("SELECT GA_Supervisor FROM User_ID WHERE User_ID = " & UserName, con)
            Dim commandGetFirstName As New OleDbCommand("SELECT First_Name FROM User_ID WHERE User_ID = " & UserName, con)
            Dim commandGetLastName As New OleDbCommand("SELECT Last_Name FROM User_ID WHERE User_ID = " & UserName, con)
            con.ConnectionString = ConnString
            con.Open()

            Try
                Password = commandGetPass.ExecuteScalar
                If Password = "" Then
                    MessageBox.Show("User not found.", "Data Entry Error")
                ElseIf Password = tbPassword.Text Then
                    'Main.Show()
                    Try
                        AdminCheck = commandGetAdmin.ExecuteScalar()
                        CommitteeCheck = commandGetCommittee.ExecuteScalar()
                        AdvisorCheck = commandGetAdvisor.ExecuteScalar()
                        GACheck = commandGetGA.ExecuteScalar()
                        SupervisorCheck = commandGetGASupervisor.ExecuteScalar()
                        FirstName = commandGetFirstName.ExecuteScalar()
                        LastName = commandGetLastName.ExecuteScalar()
                        If Not IsDBNull(AdminCheck) And AdminCheck = True Then
                            DirectorSystemChoice.Show()
                        ElseIf Not IsDBNull(CommitteeCheck) And CommitteeCheck = True Then
                            Main.Show()
                        ElseIf Not IsDBNull(AdvisorCheck) And AdvisorCheck = True Then
                            Advising.Show()
                        ElseIf Not IsDBNull(SupervisorCheck) And SupervisorCheck = True Then
                            GASupervisor.Show()
                        ElseIf Not IsDBNull(GACheck) And GACheck = True Then
                            GA.Show()
                        Else
                            MessageBox.Show("Please contact your System Administrator.")
                        End If

                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                Else
                    MessageBox.Show("Incorrect Password", "Data Entry Error")
                End If
            Catch ex As Exception
            End Try
        End If

        con.Close()
    End Sub
    Private Sub cbShowPass_CheckedChanged(sender As Object, e As EventArgs) Handles cbShowPass.CheckedChanged

        If cbShowPass.Checked Then
            tbPassword.PasswordChar = ""
        Else
            tbPassword.PasswordChar = "*"
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Friend Function getUsername()
        Return UserName
    End Function

    Friend Function getAdminCheck()
        Return AdminCheck
    End Function

    Friend Function getCommitteeCheck()
        Return CommitteeCheck
    End Function

    Friend Function getAdvisorCheck()
        Return AdvisorCheck
    End Function

    Friend Function getName()
        Return LastName & ", " & FirstName
    End Function
End Class