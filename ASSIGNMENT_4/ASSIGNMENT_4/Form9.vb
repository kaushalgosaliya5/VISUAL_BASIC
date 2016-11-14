Public Class Form9

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B1.Click
        Dim i As Integer
        i = TextBox1.Text.IndexOf(TextBox2.Text)

        If i = -1 Then
            MsgBox(" search text does not exit")
        Else
            MsgBox(" word is located on " & i)
        End If

        TextBox1.Select(i, TextBox2.Text.Length)

    End Sub
End Class