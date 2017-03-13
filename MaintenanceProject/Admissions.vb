Imports System.Data.OleDb
Public Class Admissions
    'get Program
    Dim Program As String = ApplicantProfile.getProgram()
    'get Name
    Dim StuName As String = ApplicantProfile.getName()
    'set options for MIS combobox
    Dim MISDecision = New String() {"Gold", "Silver", "Waitlist", "Reject"}
    'set options for PMIS combobox
    Dim PMISDecision = New String() {"Accept", "Waitlist", "Reject"}
    'set connection stuff
    Dim ConnInfo As New DBConnectionInfo
    Dim ConnString As String = ConnInfo.GetConnString()
    Dim con As New OleDbConnection()
    Dim AppID = Integer.Parse(Main.getSelectedApplicant())


    Private Sub Admissions_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class