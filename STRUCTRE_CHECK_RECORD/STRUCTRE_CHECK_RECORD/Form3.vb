Public Class Form3

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim dt As Date

        dt = Now

        MsgBox(" D :: " & dt.ToString("D"))

        MsgBox(" FORMATE CHANGE OF DATE :: " & Format(dt, "dd-MM-yyyy"))
    End Sub
End Class