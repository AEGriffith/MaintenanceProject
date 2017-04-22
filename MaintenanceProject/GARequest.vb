Imports System.Data.OleDb
Public Class GARequest
    'Setup Connection Variables
    Dim ConnInfo As New DBConnectionInfo
    Dim ConnString As String = ConnInfo.GetConnString()
    Dim con As New OleDbConnection()

    Dim UsersName = Login.getName()
    Dim UserID = Login.getUsername()

    Dim GAs As New ArrayList()
    Dim GAHours As New ArrayList()
    Dim Email As String
    Dim Reason As String
    Dim GANumber As Integer
    Dim WeekHours As Integer
    Dim Duties As String
    Dim Research As Integer
    Dim Programming As Integer
    Dim Spreadsheet As Integer
    Dim Database As Integer
    Dim StatsPkg As String
    Dim Writing As Integer
    Dim Editing As Integer
    Dim English As Integer
    Dim OtherComm As String
    Dim Other As String
    Dim Item As Integer
    Dim formID

    Private Sub GARequest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PROJECTS1747DataSet4.viewPossibleGAList' table. You can move, or remove it, as needed.
        Me.ViewPossibleGAListTableAdapter1.Fill(Me.PROJECTS1747DataSet4.viewPossibleGAList)
        cbRequest.SelectedIndex = -1
        lblName.Text = UsersName
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        'MessageBox.Show("Text: " & cbRequest.SelectedText & "Value: " & cbRequest.SelectedValue)

        Item = cbRequest.SelectedValue
        If GAs.Contains(Item) Then
            MessageBox.Show("You have already requested that student.", "Request Error")
        Else
            lbGAsRequested.Items.Add(cbRequest.Text)
            GAs.Add(Item)
            GAHours.Add(numGAHours.Value)
        End If

        cbRequest.SelectedIndex = -1
        numGAHours.Value = 20
    End Sub



    Private Sub SubmitRequest()
        con.ConnectionString = ConnString

        Dim sqlComm As New OleDbCommand
        Dim ds As New DataSet


        sqlComm.Connection = con

        'setup for stored procedure
        sqlComm.CommandText = "procRequestGA"
        sqlComm.CommandType = CommandType.StoredProcedure
        sqlComm.Connection = con


        'sets values for stored procedure
        sqlComm.Parameters.AddWithValue("RequestorID", UserID)
        sqlComm.Parameters.AddWithValue("TotalGAs", GANumber)
        sqlComm.Parameters.AddWithValue("TotalHours", WeekHours)
        sqlComm.Parameters.AddWithValue("JobDescription", Duties)
        sqlComm.Parameters.AddWithValue("Research", Research)
        sqlComm.Parameters.AddWithValue("Programming", Programming)
        sqlComm.Parameters.AddWithValue("Spreadsheet", Spreadsheet)
        sqlComm.Parameters.AddWithValue("Database", Database)
        sqlComm.Parameters.AddWithValue("StatisticalPkg", StatsPkg)
        sqlComm.Parameters.AddWithValue("Writing", Writing)
        sqlComm.Parameters.AddWithValue("Editing", Editing)
        sqlComm.Parameters.AddWithValue("English", English)
        sqlComm.Parameters.AddWithValue("OtherCOMM", OtherComm)
        sqlComm.Parameters.AddWithValue("Other", Other)

        con.Open()
        formID = sqlComm.ExecuteScalar()

        con.Close()
    End Sub

    Private Sub AddGAs()
        con.ConnectionString = ConnString




        'sets values for stored procedure


        con.Open()
        For i = 0 To GAs.Count - 1
            Dim sqlComm As New OleDbCommand
            Dim ds As New DataSet


            sqlComm.Connection = con

            'setup for stored procedure
            sqlComm.CommandText = "procRequestSpecificGA"
            sqlComm.CommandType = CommandType.StoredProcedure
            sqlComm.Connection = con
            sqlComm.Parameters.AddWithValue("FormID", formID)
            sqlComm.Parameters.AddWithValue("GAID", Integer.Parse(GAs(i)))
            sqlComm.Parameters.AddWithValue("Hours", Integer.Parse(GAHours(i)))
            sqlComm.ExecuteScalar()
        Next i



        con.Close()
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click


        GANumber = numGAs.Value
        WeekHours = numHours.Value
        Duties = tbDuties.Text
        Research = trackInternet.Value
        Programming = trackWordProcess.Value
        Spreadsheet = trackSpreadsheet.Value
        Database = trackDatabase.Value
        StatsPkg = tbStatisticalPackages.Text
        Writing = trackWriting.Value
        Editing = trackEditing.Value
        English = trackEnglish.Value
        OtherComm = tbOther.Text
        Other = tbOther2.Text

        SubmitRequest()
        'MessageBox.Show(formID)
        AddGAs()

        MessageBox.Show("Request Submitted Successfully.", "Request Submitted")

        tbDuties.Clear()
        tbOther.Clear()
        tbOther2.Clear()
        tbStatisticalPackages.Clear()
        cbRequest.SelectedIndex = -1
        numGAHours.Value = 20
        numGAs.Value = 0
        numHours.Value = 0
        trackDatabase.Value = 1
        trackEditing.Value = 1
        trackEnglish.Value = 1
        trackInternet.Value = 1
        trackSpreadsheet.Value = 1
        trackWordProcess.Value = 1
        trackWriting.Value = 1
        lbGAsRequested.Items.Clear()
        GAs.Clear()
        GAHours.Clear()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        lbGAsRequested.Items.Clear()
        GAs.Clear()
        GAHours.Clear()
        numGAHours.Value = 20
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class