Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B1.Click

        Dim fnt As New Font(B1.Font, FontStyle.Bold)
        TextBox1.Font = fnt

    End Sub

    Private Sub B2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B2.Click
        Dim fnt As New Font(B2.Font, FontStyle.Italic)
        TextBox1.Font = fnt
    End Sub

    Private Sub B3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B3.Click

        Dim fnt As New Font(B3.Font, FontStyle.Underline)
        TextBox1.Font = fnt

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B4.Click
        If FontDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            TextBox1.Font = FontDialog1.Font
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B5.Click
        If ColorDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            TextBox1.ForeColor = ColorDialog1.Color
        End If
    End Sub

    Private Sub B7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B7.Click
        If ColorDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            TextBox1.BackColor = ColorDialog1.Color

        End If
    End Sub

    Private Sub B6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B6.Click
        Dim i As Integer
        i = TextBox1.Text.IndexOf(TextBox2.Text)
        If i = -1 Then
            MsgBox(" SEARCH TEXT DOSE NOT EXIST ")
        Else
            'MsgBox("WORD IS LOCKTED ON ::" & i)
            TextBox1.Select(i, TextBox2.Text.Length)

        End If
    End Sub
End Class
