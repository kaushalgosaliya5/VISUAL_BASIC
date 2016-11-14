Public Class Form3

    Private Sub txtAmount_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAmount.KeyPress, txtInterest.KeyPress, txtnoInstollment.KeyPress
        If e.KeyChar = vbBack Then Exit Sub
        If Not e.KeyChar Like "[0-9,.]" Then e.Handled = True
    End Sub

    Private Sub txtAmount_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAmount.Leave, txtInterest.Leave, txtnoInstollment.Leave

        If Val(txtInterest.Text) > 100 Then
            MsgBox(" less then 100 ")
            txtInterest.Clear()
            txtInterest.Focus()
            Exit Sub
        End If

        If Not IsNumeric(sender.TEXT) Then
            MsgBox(" PROPARLY VALUE ENTER ")
            sender.CLEAR()
            sender.FOCUS()
            Exit Sub
        End If
    End Sub

    Private Sub Bcalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bcalculate.Click
        Dim amt As Single

        If Cpayment.Checked = True Then
            amt = Pmt(Val(txtInterest.Text) / 1200, Val(txtnoInstollment.Text), -Val(txtAmount.Text), , DueDate.BegOfPeriod)
        Else
            amt = Pmt(Val(txtInterest.Text) / 1200, Val(txtnoInstollment.Text), -Val(txtAmount.Text), , DueDate.EndOfPeriod)
        End If

        txtInstollment.Text = Val(amt)
    End Sub
End Class