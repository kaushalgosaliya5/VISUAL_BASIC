Public Class Form4

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B2.Click
        If Not IsNumeric(TextBox1.Text) Then
            MsgBox(" YOUR VALUE IS WRONG ")
            TextBox1.Clear()
            TextBox1.Focus()
        End If

        Dim ans As Boolean = EvenOdd(TextBox1.Text)

        If ans Then
            MsgBox(" YOUR VALUE IS EVEN")
        Else
            MsgBox(" YOUR VALUE IS ODD")
        End If

    End Sub

    Function EvenOdd(ByVal i As Integer) As Boolean

        If i Mod 2 = 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B1.Click

        fibonacci(TextBox1.Text)

    End Sub
    Sub fibonacci(ByVal i As Integer)
        Dim str As String
        Dim n1, n2, sum As Integer

        n1 = 0
        n2 = 1
        str = n1 & vbCrLf
        str = str & n2 & vbCrLf
        sum = n1 + n2
    
        While sum < i
            str = str & sum & vbCrLf
            n1 = n2
            n2 = sum
            sum = n1 + n2
        End While

        TextBox2.Text = str
    End Sub
End Class





