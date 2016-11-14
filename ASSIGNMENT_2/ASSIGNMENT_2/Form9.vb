Public Class Form9
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        T1.Focus()
        T1.TextAlign = HorizontalAlignment.Left
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        T1.Focus()
        T1.TextAlign = HorizontalAlignment.Center
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        T1.Focus()
        T1.TextAlign = HorizontalAlignment.Right
    End Sub
End Class