Public Class Form3

    Private Sub B1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B1.Click
        Dim str As String = T1.Text
        Dim d, v As Integer

        For i As Integer = 0 To str.Length - 1
            Dim ch As Char = str.Chars(i)
            If Char.IsDigit(ch) Then
                d += 1
            Else
                If IsVowel(Char.ToLower(ch)) Then
                    v += 1
                End If
            End If
        Next

        MsgBox(" VOWEL IS :: " & v & vbCrLf & " DIGIT :: " & d)

    End Sub
    Function IsVowel(ByVal ch As Char) As Boolean
        If ch = "a" Or ch = "e" Or ch = "i" Or ch = "o" Or ch = "u" Then
            Return True
        Else
            Return False
        End If
    End Function
End Class