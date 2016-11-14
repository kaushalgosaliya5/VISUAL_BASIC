Public Class Form8

    Public Const PI As Single = 3.14

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B1.Click
        Dim area As Single

        If Not IsNumeric(T1.Text) Then
            MsgBox(" PLEASE PROPARLY VALUE ENTER ")
            T1.Clear()
            T1.Focus()
            Exit Sub
        End If

        area = PI * Val(T1.Text) * Val(T1.Text)

        MsgBox(" AREA OF CIRCLE IS :: " & area)

    End Sub

    Private Sub T1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles T1.KeyPress
        If e.KeyChar = vbBack Then Exit Sub
        If Not e.KeyChar Like "[0-9,.]" Then e.Handled = True

    End Sub
End Class