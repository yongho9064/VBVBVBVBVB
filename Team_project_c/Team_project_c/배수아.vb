Public Class Baseball
    Dim isVolume As Boolean = True
    Dim rd As New Random
    Dim cnt As Integer = 10
    Dim numbers(9) As Integer
    Dim tmprd As Integer
    Dim tmp As Integer
    Dim strike As Integer
    Dim ball As Integer
    Dim out As Integer
    Dim userNum(4) As Integer
    Dim userNumCmp(10) As Integer

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
    Function cmp() As Integer
        Dim isb As Integer = 0
        Dim gameerror As String
        baseball_error()
        For i = 0 To 3
            userNumCmp(userNum(i)) = userNumCmp(userNum(i)) + 1
            If userNumCmp(userNum(i)) > 1 Then
                gameerror = MsgBox("중복값은 쓰지마세요.")
                TextBox1.Text = ""
                isb = 1
                Exit For
            End If
        Next
        If isb = 1 Then
            For j = 0 To 10
                userNumCmp(j) = 0
            Next
            Return 0
        End If
        For j = 0 To 10
            userNumCmp(j) = 0
        Next
        Return 1
    End Function
    Private Sub baseball_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.MaxLength = 4
        My.Computer.Audio.Play(My.Resources._2,
      AudioPlayMode.BackgroundLoop) '노래'
        Me.ControlBox = False
        numbers = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9}
        ToolTip1.SetToolTip(RemainNumber, "남은 횟수만큼 최고 점수가 되어집니다.")
        ToolTip2.SetToolTip(TextBox1, "0~9까지의 4가지 숫자를 입력해주세요")
        ToolTip3.SetToolTip(resultFiled, "과거의 입력했던 값을 확인할수 있습니다")
        ToolTip4.SetToolTip(ScoreLabel, "남은 횟수만큼 점수를 얻을수 있습니다.")
        baseball_Clear()
    End Sub

    Function baseball_error() As Integer
        Dim gameerror As String
        Try
            userNum(0) = Val(TextBox1.Text(0))
            userNum(1) = Val(TextBox1.Text(1))
            userNum(2) = Val(TextBox1.Text(2))
            userNum(3) = Val(TextBox1.Text(3))
        Catch ex As IndexOutOfRangeException
            gameerror = InputBox("4개 보다 작은 값은 못 받아들입니다.", "입력상자")
            While gameerror.Length > 4
                gameerror = InputBox("4개보다 큰 값은 못 받아들입니다", "입력상자")
                TextBox1.Text = gameerror
            End While
            TextBox1.Text = gameerror
            baseball_error()
        End Try
    End Function

    Function baseball_Clear() As Integer
        cnt = 10
        For i = 0 To 100
            tmprd = rd.Next(1, 9)
            tmp = numbers(tmprd)
            numbers(tmprd) = numbers(tmprd + 1)
            numbers(tmprd + 1) = tmp
        Next
        strike = 0
        ball = 0
        out = 0
        resultFiled.Text = ""
        Label1.Text = "결과"
        RemainNumber.Text = "남은횟수 : " & cnt
        num1.Text = numbers(0)
        num2.Text = numbers(1)
        num3.Text = numbers(2)
        num4.Text = numbers(3)
        num1.Visible = False
        num2.Visible = False
        num3.Visible = False
        num4.Visible = False
        Return 0
    End Function

    Private Sub btn_Click(sender As Object, e As EventArgs) Handles btn.Click
        ball = 0
        out = 0
        strike = 0
        Dim a As Integer = cmp()
        If a = 1 Then
            'baseball_error()
            cnt = cnt - 1
            RemainNumber.Text = "남은횟수 : " & cnt
            'main logic
            For i As Integer = 0 To 3
                Dim c As Boolean = False
                For j As Integer = 0 To 3
                    If strike = 4 Then
                        Me.Close()
                    End If
                    If numbers(i) = userNum(j) Then
                        If i = j Then
                            strike = strike + 1
                            c = True
                            If i = 0 Then
                                num1.Visible = True
                            ElseIf i = 1 Then
                                num2.Visible = True
                            ElseIf i = 2 Then
                                num3.Visible = True
                            ElseIf i = 3 Then
                                num4.Visible = True
                            End If
                            Exit For
                        Else
                            ball = ball + 1
                            c = True
                            Exit For

                        End If
                    End If
                Next
                If c = False Then
                    out = out + 1
                End If
            Next
            TextBox1.Clear()
            Label1.Text = "결과 " & strike & "Strike " & ball & "Ball " & out & "Out"

            resultFiled.Text += userNum(0) & " " & userNum(1) & " " & userNum(2) & " " & userNum(3) & "            " & strike & "s " & ball & "b " & out & "out" & vbCrLf

        End If

        Dim returnVal As String
        If strike = 4 Then
            returnVal = MsgBox("성공하셨습니다. 다시하겠습니까?", vbYesNo, "알림")
            If returnVal = vbYes Then
                score = (cnt + 1) + score
                ScoreLabel.Text = "최고점수 : " & cnt
                db_connection()
                updateCom.Connection = dbConn
                updateCom.CommandText = "UPDATE userinfo SET score = score + '" & Val(cnt) + 1 & "' WHERE ID='" & username & "'"
                updateCom.ExecuteNonQuery()
                dbConn.Close()
                baseball_Clear()
            Else
                score = (cnt + 1) + score
                db_connection()
                updateCom.Connection = dbConn
                updateCom.CommandText = "UPDATE userinfo SET score = score + '" & Val(cnt) + 1 & "' WHERE ID='" & username & "'"
                updateCom.ExecuteNonQuery()
                dbConn.Close()
                Game.Show()
                My.Computer.Audio.Stop()
                Close()
            End If
        End If
        If cnt = 0 Then
            returnVal = MsgBox("실패하셨습니다. 다시하겠습니까?", vbYesNo, "알림")
            If returnVal = vbYes Then
                '''초기화 하기전의 점수를 최고점수로 인정
                ScoreLabel.Text = "최고점수 : " & cnt
                baseball_Clear()
            Else
                Game.Show()
                My.Computer.Audio.Stop()
                Close()
            End If
        End If
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        '숫자만 입력
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not e.KeyChar = "." Then
            e.Handled = True
        End If
    End Sub

    Private Sub 나가기XToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 나가기XToolStripMenuItem.Click
        My.Computer.Audio.Stop()
        Game.Show()
        Close()
    End Sub

    Private Sub 새로고침RToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 새로고침RToolStripMenuItem.Click
        baseball_Clear()
    End Sub

    Private Sub 볼륨ONOFFToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 볼륨ONOFFToolStripMenuItem.Click
        If isVolume Like True Then
            isVolume = False
            My.Computer.Audio.Stop()
        Else
            isVolume = True
            My.Computer.Audio.Play(My.Resources._2,
            AudioPlayMode.BackgroundLoop) '노래'
        End If

    End Sub

    '빈칸시 에러발생 '11-16
    'If TextBox1.Text = "" Then
    '    gameerror = InputBox("새로운번호를 입력해주세요", "입력상자")
    '    TextBox1.Text = gameerror
    '    If TextBox1.Text.Length = 4 Then
    '        userNum(0) = Val(TextBox1.Text(0))
    '        userNum(1) = Val(TextBox1.Text(1))
    '        userNum(2) = Val(TextBox1.Text(2))
    '        userNum(3) = Val(TextBox1.Text(3))
    '    End If
    'End If
    ' 4개초과시 에러발생
    'If TextBox1.Text.Length > 4 Then
    '    gameerror = InputBox("4개 초과하는 값은 못 받아들입니다.", "입력상자")
    '    TextBox1.Text = gameerror
    '    'If TextBox1.Text.Length = 4 Then
    '    '    userNum(0) = Val(TextBox1.Text(0))
    '    '    userNum(1) = Val(TextBox1.Text(1))
    '    '    userNum(2) = Val(TextBox1.Text(2))
    '    '    userNum(3) = Val(TextBox1.Text(3))
    '    'End If
    'End If
    '예외 처리 구문

End Class