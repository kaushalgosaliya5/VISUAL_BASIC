Public Class Form1

    Private Sub txtPricipal_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPricipal.KeyPress, txtDuration.KeyPress, txtRate.KeyPress

        If e.KeyChar = vbBack Then Exit Sub
        If Not e.KeyChar Like "[0-9,.]" Then e.Handled = True

    End Sub

    Private Sub txtPricipal_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPricipal.Leave, txtRate.Leave, txtDuration.Leave

        If Not IsNumeric(sender.Text) Then
            sender.Clear()
            sender.Focus()
            Exit Sub
        End If
    End Sub


    Private Sub B1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B1.Click

        Dim p, r, n, i, a As Single

        p = Val(txtPricipal.Text)
        r = Val(txtRate.Text)
        n = Val(txtDuration.Text)

        If RSIMPLE.Checked = True Then
            i = p * r * n / 100
            MsgBox(" SIMPLE INTEREST IS ::  " & i)
        Else
            a = p * Math.Pow((1 + r * 0.01), n) - p
            MsgBox(" COUMPOUND INTEREST IS :: " & a)


        End If
    End Sub
End Class
