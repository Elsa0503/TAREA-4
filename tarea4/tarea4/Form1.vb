Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i, j, n As Integer
        i = Val(TextBox1.Text)
        j = 1
        For n = 1 To i
            j = j * n
            MsgBox(j)
        Next



    End Sub

End Class
