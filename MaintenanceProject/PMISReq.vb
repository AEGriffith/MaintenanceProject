Public Class PMISReq
    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles rbERP.CheckedChanged
        Dim Image As Image


        Image = My.Resources.PMIS_ERP

        PictureBox1.Image = Image

    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles rbES.CheckedChanged
        Dim Image As Image
        Image = My.Resources.PMIS_ES

        PictureBox1.Image = Image

    End Sub

    Private Sub PMISReq_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Friend Sub setES()
        rbES.Checked = True
    End Sub

    Friend Sub setERP()
        rbERP.Checked = True
    End Sub

End Class