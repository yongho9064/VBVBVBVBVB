Public Class 김현철
    Dim dbConn As OleDb.OleDbConnection = New OleDb.OleDbConnection()
    Dim selectCom As OleDb.OleDbCommand = New OleDb.OleDbCommand()
    Dim insertCom As OleDb.OleDbCommand = New OleDb.OleDbCommand()
    Dim updateCom As OleDb.OleDbCommand = New OleDb.OleDbCommand()
    Dim dbDa As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter()
    Private Sub db_connection()
        dbConn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\student\VB_TeamProjectC\Team_project_c\Team_project_c\c조회원.accdb"
        dbConn.Open()
        selectCom.Connection = dbConn
        selectCom.CommandText = "SELECT * FROM userinfo"
    End Sub
    Dim sumScore As Integer
    Dim value As Integer
    Dim rd As New Random
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        score = score + sumScore
        db_connection()
        updateCom.Connection = dbConn
        updateCom.CommandText = "UPDATE userinfo SET score = score + '" & Val(sumScore) & "' WHERE ID='" & username & "'"
        updateCom.ExecuteNonQuery()
        dbConn.Close()
        Game.Show()
        Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Button3.Enabled = True
        Button2.Enabled = False
        Button1.Enabled = False
        value = rd.Next(1, 100)
    End Sub

    Private Sub 김현철_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ControlBox = False
        Button3.Enabled = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox1.Text Like value Then
            MsgBox("정답입니다.")
            sumScore += 30
            Label5.Text = sumScore
            Label1.Text = value
            Button2.Enabled = True
            Button1.Enabled = True
        ElseIf TextBox1.Text > value Then
            MsgBox("다운")
            sumScore -= 1
            Label5.Text = score
        Else
            MsgBox("업")
            sumScore -= 1
            Label5.Text = score
        End If
    End Sub
End Class