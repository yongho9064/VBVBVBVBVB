Public Class Game
    Dim dbConn As OleDb.OleDbConnection = New OleDb.OleDbConnection()
    Dim selectCom As OleDb.OleDbCommand = New OleDb.OleDbCommand()
    Dim insertCom As OleDb.OleDbCommand = New OleDb.OleDbCommand()
    Dim updateCom As OleDb.OleDbCommand = New OleDb.OleDbCommand()
    Dim dbDa As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter()
    '전체 점수를 받아야 하니 전역변수 score <- 에다가 점수 넣어줘'
    Private Sub db_connection()
        dbConn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\bsa05\3uby\VB_TeamProjectC\Team_project_c\Team_project_c\c조회원.accdb"
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
        김현철.Show()
        Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        김동욱.Show()
        Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Baseball.Show()
        Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        이용호.Show()
        Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        End
    End Sub

    Private Sub Game_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: 이 코드는 데이터를 'C조회원DataSet.userinfo' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
        Me.UserinfoTableAdapter.Fill(Me.C조회원DataSet.userinfo)
        Dim userSc As Integer
        Dim rowcount As Integer
        Dim isLogin As Integer = 0
        rowcount = Me.BindingContext(UserinfoBindingSource).Count 'db 최대값 받는 변수
        For i = 0 To rowcount - 1
            If username Like Label10.Text Then
                userSc = TextBox2.Text
                Exit For
            End If
            If rowcount > Me.UserinfoBindingSource.Position Then
                Me.UserinfoBindingSource.Position = Me.UserinfoBindingSource.Position + 1
            End If
        Next
        Sc.Text = Val(TextBox2.Text) + score

    End Sub


End Class