Public Class Form7

    Private Sub T1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles T1.KeyPress
        If e.KeyChar = vbBack Then Exit Sub
        If Not e.KeyChar Like "[0-9]" Then e.Handled = True
    End Sub

    Private Sub Form7_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class