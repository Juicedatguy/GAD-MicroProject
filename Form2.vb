Public Class Form2

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim t1, t2 As String

        t1 = TextBox1.Text
        t2 = TextBox2.Text

        MsgBox("UserName:" + t1 + vbCrLf + "LogIn successfully")

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Hide()
        Form1.Show()

    End Sub
End Class