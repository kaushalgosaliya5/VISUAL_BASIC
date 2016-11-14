Public Class Form1

    
    Private Sub B1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B1.Click

        Dim n1, n2, ans As Double

        n1 = Val(TextBox1.Text)
        n2 = Val(TextBox2.Text)

        ans = n1 / n2

        If Double.IsInfinity(ans) Then
            If Double.IsPositiveInfinity(ans) Then
                MsgBox(" TOO LARGE NUMBER ")
                TextBox2.Clear()
            Else
                MsgBox(" TOO SMALL NUMBER ")
                TextBox1.Clear()
            End If
        Else
        If Double.IsNaN(ans) Then
            MsgBox(" NOT A NUMBER ")
            TextBox1.Clear()
            TextBox2.Clear()
        Else
            MsgBox(" YOUR ANS IS :: " & ans)
            TextBox1.Clear()
            TextBox2.Clear()
        End If
        End If

    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = vbBack Then Exit Sub

        If Not e.KeyChar Like "[0-9,-]" Then e.Handled = True
    End Sub
End Class
