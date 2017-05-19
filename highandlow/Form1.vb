Public Class Form1
    Dim kazu As Long
    Dim Rand As New Random

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'HIGHボタン
        Label1.Text = kazu
        If kazu > 5 Then
            Label2.Text = "正解です。"
        Else
            Label2.Text = "不正解です。"
        End If
        button_disable()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'HIGHボタン
        Label1.Text = kazu
        If kazu <= 5 Then
            Label2.Text = "正解です。"
        Else
            Label2.Text = "不正解です。"
        End If
        button_disable()

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        init()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        init()
        button_enable()
    End Sub

    Sub init()
        '初期処理
        Label1.Text = "?"
        Label2.Text = "5より大きい？小さい？"
        kazu = Rand.Next(1, 10)
    End Sub

    Sub button_enable()
        Button1.Enabled = True
        Button2.Enabled = True
    End Sub

    Sub button_disable()
        Button1.Enabled = False
        Button2.Enabled = False
    End Sub
End Class
