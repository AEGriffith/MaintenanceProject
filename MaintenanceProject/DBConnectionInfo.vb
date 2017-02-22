Public Class DBConnectionInfo
    Private Const Provider = "SQLNCLI11"
    Private Const Server = "msenterprise.waltoncollege.uark.edu"
    Private Const Database = "PROJECTS1730"
    Dim User As String = "PROJECTS1730"
    Dim Pass As String = "VN60gv$"
    Dim ConnString As String = "Provider=" & Provider & ";Server=" & Server & ";Database=" & Database & ";UID=" & User & ";PWD=" & Pass & ";"


    Public Function GetConnString() As String
        Return ConnString
    End Function
End Class
