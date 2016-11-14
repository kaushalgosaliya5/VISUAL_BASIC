Public Class Form1

    Private Sub B1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B1.Click
        If T1.Text = "Admin" And T2.Text = "abc" Then
            Dim frm As New form2
            frm.show()
            Me.Hide()
        Else
            MsgBox(" INVALIDE USER NAME AND PASSWORD")
            T1.Clear()
            T2.Clear()
            T1.Focus()
        End If
    End Sub

    Private Sub B2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B2.Click
        Me.Close()
    End Sub
End Class
