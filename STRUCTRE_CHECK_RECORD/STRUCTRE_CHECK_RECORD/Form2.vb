Public Class Form2

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim dt1, dt2, dt3, dt4 As Date

        dt1 = #1/1/2014#
        dt2 = Now
        dt3 = Today
        dt4 = #1/1/2014 8:45:23 PM# ' 24 HOURSE IS MANTION OF COMPUTER

        MsgBox(" ONLY DATE :: " & dt1 & vbCrLf & " TIME WITH DATE :: " & dt2 & vbCrLf & " SYSTEM DATE :: " & dt3)
        MsgBox(" HH : MM : SS :: " & dt4.Hour & " : " & dt4.Minute & " : " & dt4.Second)

    End Sub
End Class