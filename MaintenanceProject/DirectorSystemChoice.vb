Public Class DirectorSystemChoice
    Private Sub btnAdmissions_Click(sender As Object, e As EventArgs) Handles btnAdmissions.Click
        Main.Show()
    End Sub

    Private Sub btnEnrollment_Click(sender As Object, e As EventArgs) Handles btnEnrollment.Click
        Advising.Show()
    End Sub

    Private Sub btnGA_Click(sender As Object, e As EventArgs) Handles btnGA.Click
        GADirector.Show()
    End Sub
End Class