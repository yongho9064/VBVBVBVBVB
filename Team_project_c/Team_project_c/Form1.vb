Public Class Form1
    Dim dbConn As OleDb.OleDbConnection = New OleDb.OleDbConnection()
    Dim selectCom As OleDb.OleDbCommand = New OleDb.OleDbCommand()
    Dim insertCom As OleDb.OleDbCommand = New OleDb.OleDbCommand()
    Dim dbDa As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter()
    Private Sub db_connection()
        dbConn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\bsa05\3uby\VB_TeamProjectC\Team_project_c\Team_project_c\c조회원.accdb"
        dbConn.Open()
        selectCom.Connection = dbConn
        selectCom.CommandText = "SELECT * FROM userinfo"
    End Sub
    Private Sub db_update()
        dbDa.SelectCommand = selectCom
        dbDa.Fill(c조회원DataSet, "userinfo")
        dbDa.Update(c조회원DataSet, "userinfo")
        UserinfoTableAdapter.Fill(c조회원DataSet.userinfo)
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        회원가입.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim rowcount As Integer
        Dim isLogin As Integer = 0
        rowcount = Me.BindingContext(UserinfoBindingSource).Count 'db 최대값 받는 변수
        For i = 0 To rowcount - 1
            If TextBox1.Text Like TextBox3.Text And TextBox2.Text Like TextBox4.Text Then
                MsgBox(TextBox1.Text & " 환영합니다")
                username = TextBox1.Text
                Me.Hide()
                Game.Show()
                isLogin = 1
            End If
            If rowcount > Me.UserinfoBindingSource.Position Then
                Me.UserinfoBindingSource.Position = Me.UserinfoBindingSource.Position + 1
            End If
        Next
        If isLogin <> 1 Then
            MsgBox("로그인의 실패하였습니다")
            TextBox1.Text = ""
            TextBox2.Text = ""
            For i = 0 To rowcount - 1
                If 0 < Me.UserinfoBindingSource.Position Then
                    Me.UserinfoBindingSource.Position = Me.UserinfoBindingSource.Position - 1
                End If
            Next

        End If


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: 이 코드는 데이터를 'C조회원DataSet.userinfo' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
        Me.UserinfoTableAdapter.Fill(Me.C조회원DataSet.userinfo)
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class
