Public Class DBConnectionInfo
    Private Const Provider = "SQLNCLI11"
    Private Const Server = "msenterprise.waltoncollege.uark.edu"
    Private Const Database = "PROJECTS1747"
    Dim User As String = "PROJECTS1747"
    Dim Pass As String = "GQ49nw$"
    Dim ConnString As String = "Provider=" & Provider & ";Server=" & Server & ";Database=" & Database & ";UID=" & User & ";PWD=" & Pass & ";"


    Public Function GetConnString() As String
        Return ConnString
    End Function
End Class
