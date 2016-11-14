Public Class Form2

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim x, y, z As Integer

        x = 5
        y = 7

        z = Sum(x, y)
        'z = Sum(x, y, 10) ' DEFAULT ARGUMENT

        MsgBox(" SUM IS :: " & z)

    End Sub

    Function Sum(ByVal NUM1 As Integer, ByVal NUM2 As Integer, Optional ByVal NUM3 As Integer = 0) As Integer

        'KEY WORLD := Optional

        Sum = NUM1 + NUM2 + NUM3

    End Function
End Class