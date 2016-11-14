Public Class Form7

    Private Sub T1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles T1.KeyPress

        If e.KeyChar = vbBack Then Exit Sub
        If Not e.KeyChar Like "[0-9,-]" Then e.Handled = True

    End Sub

    Private Sub B1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B1.Click
        Dim num As Double
        Dim i As Integer

        i = Val(T1.Text)
        num = CDbl(i)

        MsgBox(" DOUBLE VALUE IS :: " & num)

    End Sub

   
    Private Sub T1_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles T1.KeyUp

        If Val(T1.Text) < Int32.MinValue Then
            MsgBox(" MINIMUM VALUE IS :: " & Int32.MinValue)
            T1.Clear()
            T1.Focus()
        ElseIf Val(T1.Text) > Int32.MaxValue Then
            MsgBox(" MAXIMUM VALUE IS :: " & Int32.MaxValue)
            T1.Clear()
            T1.Focus()
        End If

    End Sub

End Class