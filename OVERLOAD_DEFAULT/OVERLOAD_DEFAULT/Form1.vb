Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim x, y, z As Integer

        x = 5
        y = 7

        'z = Sum(x, y, 10) '
        z = Sum(x, y)

        MsgBox(" SUM IS ::" & z)  ' THIS IS A FUNCTION OVERLOADING

    End Sub
    Function Sum(ByVal NUM1 As Integer, ByVal NUM2 As Integer) As Integer

        Sum = NUM1 + NUM2

        MsgBox(" 2 ARGUMENT FUNCTION ")
    End Function
    Function Sum(ByVal NUM1 As Integer, ByVal NUM2 As Integer, ByVal NUM3 As Integer) As Single

        Sum = NUM1 + NUM2 + NUM3

        MsgBox(" 3 ARGUMENT FUNCTION ")
    End Function

End Class
