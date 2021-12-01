Public Class MiniGame

    Dim randomNum As Integer            '컴퓨터의 랜덤변수'
    Dim randomNum2 As Integer           '나의 랜덤변수'
    Dim sc As Integer                   '점수'
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("하이로우게임 방식과 비슷합니다.")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Button5.Enabled = False             '시작하기 비활성화'
        Button6.Enabled = False             '나가기 비활성화'
        randomNum = Int(Rnd() * 9) + 1         '컴퓨터의 랜덤변수 실행'
        Label1.Text = randomNum           '텍스트로 보이기'
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        randomNum2 = Int(Rnd() * 10)        '나의 랜덤변수 실행'
        Label2.Text = randomNum2            '텍스트로 보이기'

        If Label1.Text = "?" Then               '시작/재시작 버튼을 클릭했는지 확인'
            MsgBox("시작/재시작 버튼을 누르시오")
        ElseIf randomNum2 > randomNum Then         '컴퓨터 보다 나의 랜덤변수가 크다면 참'
            MsgBox("정답입니다.")
            sc += 10                               '참:+10점'
            Label4.Text = sc
        Else                                       '컴퓨터 보다 나의 랜덤변수가 작다면 거짓'
            MsgBox("틀렸습니다.")
            sc -= 50                                '거짓:-10점'
            Label4.Text = sc
        End If

        Button5.Enabled = True             '시작하기 활성화'
        Button6.Enabled = True             '나가기 활성화'

        Label1.Text = "?"                       '? 다시 초기화'
        Label2.Text = "?"                       '나머지 밑에는 다 비슷함'
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        randomNum2 = Int(Rnd() * 9) + 1
        Label2.Text = randomNum2

        If Label1.Text = "?" Then
            MsgBox("시작/재시작 버튼을 누르시오")
        ElseIf randomNum2 < randomNum Then
            MsgBox("정답입니다.")
            sc += 10
            Label4.Text = sc
        Else
            MsgBox("틀렸습니다.")
            sc -= 50
            Label4.Text = sc
        End If

        Button5.Enabled = True             '시작하기 활성화'
        Button6.Enabled = True             '나가기 활성화'

        Label1.Text = "?"
        Label2.Text = "?"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        randomNum2 = Int(Rnd() * 10)
        Label2.Text = randomNum2

        If Label1.Text = "?" Then
            MsgBox("시작/재시작 버튼을 누르시오")
        ElseIf randomNum2 = randomNum Then
            MsgBox("정답입니다.")
            sc += 500
            Label4.Text = sc
        Else
            MsgBox("틀렸습니다.")
            sc -= 200
            Label4.Text = sc
        End If

        Button5.Enabled = True             '시작하기 활성화'
        Button6.Enabled = True             '나가기 활성화'

        Label1.Text = "?"
        Label2.Text = "?"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Close()
    End Sub

    Private Sub MiniGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class