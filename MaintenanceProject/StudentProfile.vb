Imports System.Data.OleDb
Public Class StudentProfile
    'Setup Connection Variables
    Dim ConnInfo As New DBConnectionInfo
    Dim ConnString As String = ConnInfo.GetConnString()
    Dim con As New OleDbConnection()

    'Gets variables from advising form
    Dim StudentName = Advising.getStudentName
    Dim Program = Advising.getProgram
    Dim Concentration = Advising.getConcentration
    Dim StudentID = Advising.getStudentID



    Private Sub StudentProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Sets label information
        lblName.Text = StudentName
        'find the current right alignment position
        Dim rightAlignProgram As Integer = lblProgram.Left + lblProgram.Width
        'set the text
        lblProgram.Text = Program
        'adjust position so that the right hand point is in the same position as before
        lblProgram.Left = rightAlignProgram - lblProgram.Width
        'find the current right alignment position
        Dim rightAlignConcentration As Integer = lblConcentration.Left + lblConcentration.Width
        'set the text (assumes AutoSize is set to True)
        lblConcentration.Text = Concentration
        'adjust position so the right hand point is in the same position as before
        lblConcentration.Left = rightAlignConcentration - lblConcentration.Width
        lblStuID.Text = StudentID
    End Sub

    'Opens the appropriate requirements form
    Private Sub lblProgram_Click(sender As Object, e As EventArgs) Handles lblProgram.Click, lblConcentration.Click
        If lblProgram.Text = "MIS" Then
            If lblConcentration.Text.Contains("Information Technology") Then
                MISReq.setIT()
            ElseIf lblConcentration.Text.Contains("Enterprise Resource") Then
                MISReq.setERP()
            ElseIf lblConcentration.Text.Contains("Enterprise Systems") Then
                MISReq.setES()
            Else
                MISReq.setSE()
            End If
            MISReq.Show()
        ElseIf lblProgram.Text = "PMIS" Then
            If lblConcentration.Text.Contains("Enterprise Systems") Then
                PMISReq.setES()
            Else
                PMISReq.setERP()
            End If
            PMISReq.Show()
        End If


    End Sub



    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub DegreeProgressToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DegreeProgressToolStripMenuItem.Click
        DegreeProgress.Show()
    End Sub

    Private Sub ProgramConcentrationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProgramConcentrationToolStripMenuItem.Click
        EditProgram.Show()
    End Sub

    Friend Sub setLblProgram(Program)
        lblProgram.Text = Program
    End Sub

    Friend Sub setlblConcentration(Concentration)
        lblConcentration.Text = Concentration
    End Sub


End Class