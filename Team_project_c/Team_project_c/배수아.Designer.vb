<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Baseball
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기에서는 수정하지 마세요.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Baseball))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.num1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.num3 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.num4 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.num2 = New System.Windows.Forms.Label()
        Me.ScoreLabel = New System.Windows.Forms.Label()
        Me.btn = New System.Windows.Forms.Button()
        Me.RemainNumber = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.resultFiled = New System.Windows.Forms.RichTextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.나가기XToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.새로고침RToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.볼륨ONOFFToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip2 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip3 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip4 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip5 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Controls.Add(Me.Panel3)
        Me.GroupBox1.Controls.Add(Me.Panel4)
        Me.GroupBox1.Controls.Add(Me.Panel2)
        Me.GroupBox1.Controls.Add(Me.ScoreLabel)
        Me.GroupBox1.Controls.Add(Me.btn)
        Me.GroupBox1.Controls.Add(Me.RemainNumber)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.resultFiled)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 34)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(610, 410)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.num1)
        Me.Panel1.Location = New System.Drawing.Point(25, 151)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(59, 100)
        Me.Panel1.TabIndex = 15
        '
        'num1
        '
        Me.num1.AutoSize = True
        Me.num1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.num1.Font = New System.Drawing.Font("굴림", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.num1.Location = New System.Drawing.Point(-1, -5)
        Me.num1.Name = "num1"
        Me.num1.Padding = New System.Windows.Forms.Padding(0, 20, 0, 20)
        Me.num1.Size = New System.Drawing.Size(0, 104)
        Me.num1.TabIndex = 8
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.num3)
        Me.Panel3.Location = New System.Drawing.Point(155, 151)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(59, 100)
        Me.Panel3.TabIndex = 15
        '
        'num3
        '
        Me.num3.AutoSize = True
        Me.num3.BackColor = System.Drawing.SystemColors.ControlDark
        Me.num3.Font = New System.Drawing.Font("굴림", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.num3.Location = New System.Drawing.Point(-1, -5)
        Me.num3.Name = "num3"
        Me.num3.Padding = New System.Windows.Forms.Padding(0, 20, 0, 20)
        Me.num3.Size = New System.Drawing.Size(0, 104)
        Me.num3.TabIndex = 10
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.num4)
        Me.Panel4.Location = New System.Drawing.Point(220, 151)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(59, 100)
        Me.Panel4.TabIndex = 15
        '
        'num4
        '
        Me.num4.AutoSize = True
        Me.num4.BackColor = System.Drawing.SystemColors.ControlDark
        Me.num4.Font = New System.Drawing.Font("굴림", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.num4.Location = New System.Drawing.Point(-1, -5)
        Me.num4.Name = "num4"
        Me.num4.Padding = New System.Windows.Forms.Padding(0, 20, 0, 20)
        Me.num4.Size = New System.Drawing.Size(0, 104)
        Me.num4.TabIndex = 12
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.num2)
        Me.Panel2.Location = New System.Drawing.Point(90, 151)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(59, 100)
        Me.Panel2.TabIndex = 14
        '
        'num2
        '
        Me.num2.AutoSize = True
        Me.num2.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.num2.Font = New System.Drawing.Font("굴림", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.num2.Location = New System.Drawing.Point(-1, -5)
        Me.num2.Name = "num2"
        Me.num2.Padding = New System.Windows.Forms.Padding(0, 20, 0, 20)
        Me.num2.Size = New System.Drawing.Size(0, 104)
        Me.num2.TabIndex = 11
        '
        'ScoreLabel
        '
        Me.ScoreLabel.AutoSize = True
        Me.ScoreLabel.Font = New System.Drawing.Font("굴림", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.ScoreLabel.Location = New System.Drawing.Point(441, -3)
        Me.ScoreLabel.Name = "ScoreLabel"
        Me.ScoreLabel.Size = New System.Drawing.Size(98, 21)
        Me.ScoreLabel.TabIndex = 9
        Me.ScoreLabel.Text = "최고점수"
        '
        'btn
        '
        Me.btn.Location = New System.Drawing.Point(212, 325)
        Me.btn.Name = "btn"
        Me.btn.Size = New System.Drawing.Size(75, 57)
        Me.btn.TabIndex = 4
        Me.btn.Text = "Enter"
        Me.btn.UseVisualStyleBackColor = True
        '
        'RemainNumber
        '
        Me.RemainNumber.AutoSize = True
        Me.RemainNumber.Font = New System.Drawing.Font("굴림", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.RemainNumber.Location = New System.Drawing.Point(36, 83)
        Me.RemainNumber.Name = "RemainNumber"
        Me.RemainNumber.Size = New System.Drawing.Size(106, 21)
        Me.RemainNumber.TabIndex = 6
        Me.RemainNumber.Text = "남은 횟수"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("굴림", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(25, 327)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(191, 57)
        Me.TextBox1.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("굴림", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label3.Location = New System.Drawing.Point(21, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(142, 21)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "숫자야구게임"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("굴림", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label1.Location = New System.Drawing.Point(316, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 21)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "결과"
        '
        'resultFiled
        '
        Me.resultFiled.Font = New System.Drawing.Font("굴림", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.resultFiled.Location = New System.Drawing.Point(320, 58)
        Me.resultFiled.Name = "resultFiled"
        Me.resultFiled.ReadOnly = True
        Me.resultFiled.Size = New System.Drawing.Size(261, 326)
        Me.resultFiled.TabIndex = 2
        Me.resultFiled.Text = ""
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripDropDownButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.ToolStrip1.Size = New System.Drawing.Size(631, 31)
        Me.ToolStrip1.TabIndex = 10
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.나가기XToolStripMenuItem, Me.새로고침RToolStripMenuItem, Me.볼륨ONOFFToolStripMenuItem})
        Me.ToolStripDropDownButton1.Image = CType(resources.GetObject("ToolStripDropDownButton1.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(37, 28)
        Me.ToolStripDropDownButton1.Text = "ToolStripDropDownButton1"
        '
        '나가기XToolStripMenuItem
        '
        Me.나가기XToolStripMenuItem.Name = "나가기XToolStripMenuItem"
        Me.나가기XToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.나가기XToolStripMenuItem.Text = "나가기(&X)"
        '
        '새로고침RToolStripMenuItem
        '
        Me.새로고침RToolStripMenuItem.Name = "새로고침RToolStripMenuItem"
        Me.새로고침RToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.새로고침RToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.새로고침RToolStripMenuItem.Text = "새로고침(&R)"
        '
        '볼륨ONOFFToolStripMenuItem
        '
        Me.볼륨ONOFFToolStripMenuItem.Name = "볼륨ONOFFToolStripMenuItem"
        Me.볼륨ONOFFToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.볼륨ONOFFToolStripMenuItem.Text = "볼륨ON/OFF"
        '
        'ToolTip1
        '
        Me.ToolTip1.ToolTipTitle = "TextBox1"
        '
        'ToolTip2
        '
        Me.ToolTip2.ToolTipTitle = "TextBox1"
        '
        'ToolTip3
        '
        Me.ToolTip3.ToolTipTitle = "TextBox1"
        '
        'ToolTip4
        '
        Me.ToolTip4.ToolTipTitle = "TextBox1"
        '
        'ToolTip5
        '
        Me.ToolTip5.ToolTipTitle = "TextBox1"
        '
        'Baseball
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(631, 450)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Baseball"
        Me.Text = "Baseball"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents num1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents num3 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents num4 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents num2 As Label
    Friend WithEvents ScoreLabel As Label
    Friend WithEvents btn As Button
    Friend WithEvents RemainNumber As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents resultFiled As RichTextBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripDropDownButton1 As ToolStripDropDownButton
    Friend WithEvents 나가기XToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 새로고침RToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents 볼륨ONOFFToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolTip2 As ToolTip
    Friend WithEvents ToolTip3 As ToolTip
    Friend WithEvents ToolTip4 As ToolTip
    Friend WithEvents ToolTip5 As ToolTip
End Class
