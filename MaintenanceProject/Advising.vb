﻿Public Class Advising
    Private Sub Advising_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PROJECTS1747DataSet4.Student_View' table. You can move, or remove it, as needed.
        Me.Student_ViewTableAdapter.Fill(Me.PROJECTS1747DataSet4.Student_View)

    End Sub
End Class