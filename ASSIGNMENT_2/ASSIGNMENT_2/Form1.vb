Public Class Form1

    Private Sub B1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B1.Click

        If T1.Text = "" Then
            MsgBox(" PLEASE ENTER YOUR NAME")
            T1.Focus()
            Exit Sub
        End If

        L2.Text = T1.Text

        MsgBox(" your valu is transfer in label ")

    End Sub
End Class
