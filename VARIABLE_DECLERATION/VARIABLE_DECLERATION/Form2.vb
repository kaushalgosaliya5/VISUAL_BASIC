Option Strict On

Public Class Form2

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim str As String = "25000"
        Dim y As Double

        y = CDbl(str) / 2  ' Convert STRING TO DOUBLE

        MsgBox(y)

    End Sub
End Class