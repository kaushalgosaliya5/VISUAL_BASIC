Public Class Form1
    Dim str As String = "ABC@gmail.com"

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MsgBox(" length of string is :: " & str.Length)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        MsgBox(" POSITION OF '4' CHARECTER IS :: " & str.Chars(4))
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        MsgBox(" INDEX NUM OF 'g' IS :: " & str.IndexOf("g"))
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        MsgBox(" UPPER CASE CONVERT THE STRING :: " & str.ToUpper)
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        MsgBox(" LOWER CASE CONVERT THE STRING :: " & str.ToLower)
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        MsgBox("ASCII VALUE RETURN 'A' :: " & Asc("A"))
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        MsgBox(" ASCII VALUE OF '65' CHARECTER IS :: " & Chr(97))
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        MsgBox(" UNICODE TO CONVERT CHARECTER IS :: " & " PI :: " & ChrW(960) & " ALPHA : " & ChrW(945) & " BITA : " & ChrW(946) & " GEMA " & ChrW(947))
    End Sub
End Class
