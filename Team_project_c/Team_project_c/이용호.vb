Public Class 이용호
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
    'Private Sub db_update()
    '    dbDa.SelectCommand = selectCom
    '    dbDa.Fill(c조회원DataSet, "userinfo")
    '    dbDa.Update(c조회원DataSet, "userinfo")
    '    UserinfoTableAdapter.Fill(c조회원DataSet.userinfo)
    'End Sub
    Dim re As Integer     '재시작'
    Dim st As Integer = 0 '시작변수'

    Dim rn As New Random '랜덤 변수'
    Dim time As Integer = 0 '시간'
    Dim myScores As Integer = 0 '스코어 점수'
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        db_connection()
        updateCom.Connection = dbConn
        updateCom.CommandText = "UPDATE userinfo SET score = score + '" & Val(myScores) & "' WHERE ID='" & username & "'"
        updateCom.ExecuteNonQuery()
        dbConn.Close()
        My.Computer.Audio.Stop() '노래 끄기'
        Game.Show()
        Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If st = 1 Then
            If time = 1 Then '시간이 끝나면'
                Button3.Enabled = True '시작하기 버튼 활성화'
                Button2.Enabled = True '나가기 버튼 활성화'
                Button4.Enabled = True '미니게임 버튼 활성화'
                'Timer1.Enabled = False'
                st = 0
                re = MsgBox("게임이 끝났습니다. 재시작 할까요?", vbOKCancel, "확인!")
                If re = 2 Then
                    My.Computer.Audio.Stop()
                    db_connection()
                    updateCom.Connection = dbConn
                    updateCom.CommandText = "UPDATE userinfo SET score = score + '" & Val(myScores) & "' WHERE ID='" & username & "'"
                    updateCom.ExecuteNonQuery()
                    dbConn.Close()
                    score += myScores
                    Game.Show()
                    Close()
                Else
                    score += myScores
                End If
            End If

            PictureBox1.Left = rn.Next(0, 500) '이미지박스 위치를 0,500사이로 랜덤하게 나타나게 함'
            PictureBox1.Top = rn.Next(0, 500)  '타이머 1틱당 위치가 바뀜'

            time = time - 1 '타이머 마다 시간이 줄어들게 함'
            Label2.Text = time '줄어든 시간표시'
        End If
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If st = 1 Then
            If time > 0 Then '시간초과 될시 끝'
                '' My.Computer.Audio.Play(My.Resources._2, AudioPlayMode.Background) '' 
                myScores += 10 '픽쳐박스 클릭시 점수 1점 추가'
                Label3.Text = myScores '올린점수 표시'
            End If
        End If
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Button4.Enabled = False '미니게임 버튼 비활성화'
        Button3.Enabled = False '시작하기 버튼 비활성화'
        Button2.Enabled = False '나가기 버튼 비활성화'
        st = 1              '시작'
        time = 30           '시간'
        myScores = 0        '점수'
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("제한시간 안에 최대한 오징어를 클릭하세요!", vbOKOnly, "설명")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MiniGame.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        My.Computer.Audio.Play(My.Resources._1,
       AudioPlayMode.BackgroundLoop) '노래'
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        My.Computer.Audio.Stop() '노래끄기'
    End Sub

    Private Sub 이용호_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ControlBox = False
        My.Computer.Audio.Play(My.Resources._1,
      AudioPlayMode.BackgroundLoop) '노래'
    End Sub
    Private Sub GroupBox1_Click(sender As Object, e As EventArgs) Handles GroupBox1.Click
        If st = 1 Then
            If time > 0 Then '시간초과 될시 끝'
                myScores -= 30 '잘못클릭시 -30점'
                Label3.Text = myScores '올린점수 표시'
            End If
        End If
    End Sub
End Class