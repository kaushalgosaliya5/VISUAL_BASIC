Public Class Form2

    Public Const PI As Single = Math.PI ' 3.14

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim area As Single

        area = PI * Val(T1.Text) * Val(T1.Text)

        MsgBox(" AREA OF CIRCLE IS :: " & area)

    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles T1.KeyPress
        If e.KeyChar = vbBack Then Exit Sub
        If Not e.KeyChar Like "[0-9-.]" Then e.Handled = True
    End Sub
End Class