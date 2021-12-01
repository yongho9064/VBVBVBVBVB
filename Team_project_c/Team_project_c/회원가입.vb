Public Class 회원가입
    Dim dbConn As OleDb.OleDbConnection = New OleDb.OleDbConnection()
    Dim selectCom As OleDb.OleDbCommand = New OleDb.OleDbCommand()
    Dim insertCom As OleDb.OleDbCommand = New OleDb.OleDbCommand()
    Dim dbDa As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter()
    Private Sub db_connection()
        dbConn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\student\VB_TeamProjectC\Team_project_c\Team_project_c\c조회원.accdb"
        dbConn.Open()
        selectCom.Connection = dbConn
        selectCom.CommandText = "SELECT * FROM userinfo"
    End Sub
    Private Sub db_update()
        dbDa.SelectCommand = selectCom
        dbDa.Fill(C조회원DataSet, "userinfo")
        dbDa.Update(C조회원DataSet, "userinfo")
        UserinfoTableAdapter.Fill(C조회원DataSet.userinfo)
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        db_connection()
        insertCom.Connection = dbConn
        insertCom.CommandText = "INSERT INTO userinfo([ID],[PW])" & "VALUES ('" & TextBox1.Text & "','" & TextBox2.Text & "')"
        insertCom.ExecuteNonQuery()
        db_update()
        Me.UserinfoBindingSource.Position = Me.BindingContext(UserinfoBindingSource).Count
        dbConn.Close()
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub 회원가입_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: 이 코드는 데이터를 'C조회원가입DataSet.userinfo' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
        Me.UserinfoTableAdapter.Fill(Me.C조회원DataSet.userinfo)
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub
End Class