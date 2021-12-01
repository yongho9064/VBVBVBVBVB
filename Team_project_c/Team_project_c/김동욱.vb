Public Class 김동욱
    Dim sc As Integer = 0
    Dim win As Integer = 5
    Dim draw As Integer = 3
    Dim fair As Integer = 1

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

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Button1.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = False

        Label7.Text = sc

        If TextBox2.Text = "이겼습니다." Then
            sc += win
        ElseIf TextBox2.Text = "비겼습니다." Then
            sc += draw
        ElseIf TextBox2.Text = "졌습니다." Then
            sc += fair
        End If
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim rd As New Random
        Label6.Text = rd.Next(0, 3)            'Ai 랜덤함수를 생성

        If Label6.Text = "0" Then
            Label1.Text = "가위"
        ElseIf Label6.Text = "1" Then          'AI가 가위, 바위, 보를 랜덤으로 출력 
            Label1.Text = "바위"
        ElseIf Label6.Text = "2" Then
            Label1.Text = "보"
        End If

        Label2.Text = "가위"                    'User에 가위 출력

        If Label1.Text = "가위" Then
            TextBox2.Text = "비겼습니다."
            sc += draw
        ElseIf Label1.Text = "바위" Then
            TextBox2.Text = "졌습니다."
            sc += fair
        ElseIf Label1.Text = "보" Then
            TextBox2.Text = "이겼습니다."
            sc += win
        End If
        Label7.Text = sc

        Button1.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim rd As New Random
        Label6.Text = rd.Next(0, 3)            'Ai 랜덤함수를 생성

        If Label6.Text = "0" Then
            Label1.Text = "가위"
        ElseIf Label6.Text = "1" Then          'AI가 가위, 바위, 보를 랜덤으로 출력 
            Label1.Text = "바위"
        ElseIf Label6.Text = "2" Then
            Label1.Text = "보"
        End If

        Label2.Text = "바위"                    'User에 바위 출력

        If Label1.Text = "가위" Then
            TextBox2.Text = "이겼습니다."
            sc += win
        ElseIf Label1.Text = "바위" Then
            TextBox2.Text = "비겼습니다."
            sc += draw
        ElseIf Label1.Text = "보" Then
            TextBox2.Text = "졌습니다."
            sc += fair
        End If
        Label7.Text = sc

        Button1.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim rd As New Random
        Label6.Text = rd.Next(0, 3)            'Ai 랜덤함수를 생성

        If Label6.Text = "0" Then
            Label1.Text = "가위"
        ElseIf Label6.Text = "1" Then          'AI가 가위, 바위, 보를 랜덤으로 출력 
            Label1.Text = "바위"
        ElseIf Label6.Text = "2" Then
            Label1.Text = "보"
        End If

        Label2.Text = "보"                     'User에 보 출력

        If Label1.Text = "가위" Then
            TextBox2.Text = "졌습니다."
            sc += fair
        ElseIf Label1.Text = "바위" Then
            TextBox2.Text = "이겼습니다."
            sc += win
        ElseIf Label1.Text = "보" Then
            TextBox2.Text = "비겼습니다."
            sc += draw
        End If
        Label7.Text = sc

        Button1.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = False
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.TextBox2.Text = ""                 '시작 버튼을 누르면 
        Me.Label1.Text = "?"
        Me.Label2.Text = "?"
        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        ''Label7.Text = 0
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        db_connection()
        updateCom.Connection = dbConn
        updateCom.CommandText = "UPDATE userinfo SET score = score + '" & Val(Label7.Text) & "' WHERE ID='" & username & "'"
        updateCom.ExecuteNonQuery()
        dbConn.Close()
        score += Val(Label7.Text)
        Game.Show()
        Me.Close()


    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub
End Class
