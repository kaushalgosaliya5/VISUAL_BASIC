Public Class Form1

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            Label1.Text = " THANKS FOR YOUR DONATION"
        Else
            Label1.Text = ""
        End If
    End Sub
End Class
