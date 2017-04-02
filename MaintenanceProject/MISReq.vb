Public Class MISReq
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles rbIT.CheckedChanged
        Dim Image As Image

        Image = My.Resources.MIS_IT

        PictureBox1.Image = Image

    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles rbES.CheckedChanged
        Dim Image As Image

        Image = My.Resources.MIS_ES

        PictureBox1.Image = Image

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles rbERP.CheckedChanged
        Dim Image As Image

        Image = My.Resources.MIS_ERP

        PictureBox1.Image = Image
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles rbSE.CheckedChanged
        Dim Image As Image

        Image = My.Resources.MIS_Software_Engineering

        PictureBox1.Image = Image
    End Sub

    Private Sub MISReq_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    'lets other forms selct the IT radio button
    Friend Sub setIT()
        rbIT.Checked = True
    End Sub
    'lets other forms select the ERP radio button
    Friend Sub setERP()
        rbERP.Checked = True
    End Sub
    'lets other forms select the ES radio button
    Friend Sub setES()
        rbES.Checked = True
    End Sub
    'lets other forms select the SE radio button
    Friend Sub setSE()
        rbSE.Checked = True
    End Sub
End Class