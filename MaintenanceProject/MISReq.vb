Public Class MISReq
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        Dim Image As Image

        Image = My.Resources.MIS_IT

        PictureBox1.Image = Image

    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        Dim Image As Image

        Image = My.Resources.MIS_ES

        PictureBox1.Image = Image

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        Dim Image As Image

        Image = My.Resources.MIS_ERP

        PictureBox1.Image = Image
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        Dim Image As Image

        Image = My.Resources.MIS_Software_Engineering

        PictureBox1.Image = Image
    End Sub
End Class