Public Class Form5

    Private Sub Rcircle_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rcircle.CheckedChanged

        If Rcircle.Checked = True Then
            Gcircle.Visible = True
            Gsquare.Visible = False
            Grectangle.Visible = False
        End If
    End Sub

    Private Sub Rsquare_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rsquare.CheckedChanged
        If Rsquare.Checked = True Then
            Gsquare.Visible = True
            Gcircle.Visible = False
            Grectangle.Visible = False
        End If
    End Sub

    Private Sub Rrectangle_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rrectangle.CheckedChanged
        If Rrectangle.Checked = True Then
            Grectangle.Visible = True
            Gcircle.Visible = False
            Gsquare.Visible = False
        End If
    End Sub

    Private Sub Bcircle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bcircle.Click
        MsgBox(" AREA OF CIRCLE IS :: " & (Math.PI * Val(Cradious.Text) * Val(Cradious.Text)))
    End Sub

    Private Sub Bsquare_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bsquare.Click
        MsgBox(" AREA OF SQUARE IS :: " & Val(Slength.Text) * Val(Slength.Text))
    End Sub

    Private Sub Brectangle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Brectangle.Click
        MsgBox(" AREA OF RECTANGLE IS :: " & Val(Rlength.Text) * Val(Rwedth.Text))
    End Sub

    Private Sub Cradious_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Cradious.KeyPress, Slength.KeyPress, Rlength.KeyPress, Rwedth.KeyPress
        If e.KeyChar = vbBack Then Exit Sub
        If Not e.KeyChar Like "[0-9,.]" Then e.Handled = True
    End Sub

    
End Class