Public Class StudentProfile
    Private Sub StudentProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Gets variables from advising form
        Dim StudentName = Advising.getStudentName
        Dim Program = Advising.getProgram
        Dim Concentration = Advising.getConcentration

        'Sets label information
        lblName.Text = StudentName
        lblProgram.Text = Program
        lblConcentration.Text = Concentration
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


End Class