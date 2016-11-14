Public Class Form7

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        MsgBox(" HSCROLLBAR VALUE IS :: " & HScrollBar1.Value)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        MsgBox(" VSCROLLBAR VALUE IS :: " & VScrollBar1.Value)

    End Sub
End Class