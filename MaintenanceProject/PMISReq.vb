Public Class PMISReq
    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        Dim Image As Image


        Image = My.Resources.PMIS_ERP

        PictureBox1.Image = Image

    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        Dim Image As Image
        Image = My.Resources.PMIS_ES

        PictureBox1.Image = Image

    End Sub
End Class