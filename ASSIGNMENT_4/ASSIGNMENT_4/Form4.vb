Public Class Form4

    Private Sub B1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B1.Click
        Dim str As String = T1.Text
        Dim rstr As String = ""
        Dim i As Integer

        For i = str.Length - 1 To 0 Step -1
            rstr = rstr & str.Chars(i)
        Next

        MsgBox(" REVERSE IS :: " & rstr)

        If str = rstr Then
            MsgBox(" GIVEN STRING IS PALINDROME ")
        Else
            MsgBox(" GIVEN STRING IS NOT PALINDROME")
        End If

        Dim word, aword As Integer

        For i = 0 To str.Length - 1
            If str.Chars(i) = " " Then
                word += 1
                If str.Chars(i + 1) = "a" Or str.Chars(i + 1) = "A" Then
                    aword += 1
                End If
            End If
        Next

        word += 1

        If str.StartsWith("a") Or str.StartsWith("A") Then
            aword += 1
        End If

        MsgBox(" THERE ARE " & word & " WORDS IN THE LINE")
        MsgBox(" THERE ARE STARTS FROM 'A' WORLD IS :: " & aword)

    End Sub
End Class