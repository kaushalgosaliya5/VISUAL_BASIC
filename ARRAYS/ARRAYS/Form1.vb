Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim x(5) As Integer

        MsgBox(" LENGTH OF 'X(5)' ARRAY IS  :: " & x.Length)

        x(0) = 5
        x(1) = 10
        x(2) = 15
        x(3) = 20
        x(4) = 25
        x(5) = 30

        ReDim Preserve x(7)   ' only ReDim x(7) declare to previous value is convert to '0' value

        x(6) = 35
        x(7) = 40

        For i As Integer = 0 To x.Length - 1
            MsgBox(" POSITION OF " & (i + 1) & " is :: " & x(i))
        Next

    End Sub
End Class
