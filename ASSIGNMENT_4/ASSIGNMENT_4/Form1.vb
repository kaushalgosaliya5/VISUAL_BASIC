Public Class Form1

    Private Sub B1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B1.Click
        Dim h, sh As Integer

        h = Integer.MinValue
        sh = Integer.MinValue

        For i As Integer = 0 To T1.Lines.Length - 1
            Dim num As Integer
            num = Val(T1.Lines(i))

            If num > h Then
                sh = h
                h = num
            Else
                If num > sh Then
                    sh = num
                End If
            End If
        Next

        MsgBox(" HIGEST IS :: " & h)
        MsgBox(" SECOND HIGEST IS :: " & sh)

        GenerateFibonacci(sh)

        If IsPRIME(h) Then
            MsgBox(" GIVEN NUMBER IS PRIME :: " & h)
        Else
            MsgBox(" GIVEN NUMBER IS NOT PRIME :: " & h)
        End If

    End Sub

    Function IsPRIME(ByVal h As Integer) As Boolean
        Dim LOGIC As Boolean = True

        For i As Integer = 2 To h - 1
            If h Mod i = 0 Then
                LOGIC = False
                Exit For
            End If
        Next

        Return LOGIC
    End Function
    Sub GenerateFibonacci(ByVal num1 As Integer)
        Dim str As String
        Dim n1, n2, sum As Integer

        n1 = 0
        n2 = 1

        str = n1 & vbCrLf
        str = str & n2 & vbCrLf
        sum = n1 + n2

        While sum < num1
            str = str & sum & vbCrLf
            n1 = n2
            n2 = sum
            sum = n1 + n2
        End While

        T2.Text = str
    End Sub
End Class
