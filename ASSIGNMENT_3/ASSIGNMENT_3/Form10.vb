Public Class Form10

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles T1.KeyPress

        If e.KeyChar = vbBack Then Exit Sub
        If Not e.KeyChar Like "[0-9,.]" Then e.Handled = True

    End Sub

   
    Private Sub B1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B1.Click

        Dim dlr As Single

        If Not IsNumeric(T1.Text) Then
            MsgBox(" PROPARLY RUPEESS ENTER ")
            T1.Clear()
            T1.Focus()
            Exit Sub
        End If

        dlr = Val(T1.Text) / 60

        MsgBox(" RS :: " & Val(T1.Text) & " DOLLER $ :: " & dlr)

    End Sub
End Class