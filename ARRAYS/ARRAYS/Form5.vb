Public Class Form5

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Dim a, b As Integer

        a = 5
        b = 10

        sum(a, b) ' this called subrutin
    End Sub

    Sub sum(ByVal num1 As Integer, ByVal num2 As Integer)

        Dim ans As Integer

        ans = num1 + num2

        MsgBox(" ANS IS :: " & ans)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim a, b, ans As Integer

        a = 15
        b = 10

        ans = add(a, b)

        MsgBox(" ADDITION IS :: " & ans)

    End Sub

    Function add(ByVal num1 As Integer, ByVal num2 As Integer) As Integer

        Dim ans As Integer

        ans = num1 + num2

        Return ans

    End Function

End Class