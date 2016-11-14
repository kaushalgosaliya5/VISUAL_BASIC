Public Class Form5

    Private Sub Form5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        C1.Items.Add("ADD")
        C1.Items.Add("SUB")
        C1.Items.Add("MULTI")
        C1.Items.Add("DIV")
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles T1.KeyPress, T2.KEYPRESS
        If e.KeyChar = vbBack Then Exit Sub
        If Not e.KeyChar Like "[0-9 .]" Then e.Handled = True
    End Sub

    Private Sub B1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B1.Click
        If Not IsNumeric(T1.Text) Then
            MsgBox(" PROPARLY VALUE ENTER")
            T1.Clear()
            T1.Focus()
            Exit Sub
        End If
        If Not IsNumeric(T2.Text) Then
            MsgBox(" PROPARLY VALUE ENTER")
            T2.Clear()
            T2.Focus()
            Exit Sub
        End If

        L3.Visible = True
        C1.Visible = True
        B2.Visible = True

    End Sub

    Private Sub B2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B2.Click
        Dim ans As Integer

        If C1.Text = "ADD" Then
            ans = Val(T1.Text) + Val(T2.Text)
        ElseIf C1.Text = "SUB" Then
            ans = Val(T1.Text) - Val(T2.Text)
        ElseIf C1.Text = "MULTI" Then
            ans = Val(T1.Text) * Val(T2.Text)
        ElseIf C1.Text = "DIV" Then
            ans = Val(T1.Text) \ (T2.Text)
        Else
            MsgBox(" OPERATOR IS WORNG ")
        End If

        MsgBox(" YOUR RESULT IS :: " & ans)
    End Sub
End Class