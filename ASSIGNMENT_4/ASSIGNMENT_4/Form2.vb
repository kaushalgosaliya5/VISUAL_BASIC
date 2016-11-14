Public Class Form2

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B1.Click
        Dim v, sp, d, sym As Integer
        Dim str As String = T1.Text

        For i As Integer = 0 To str.Length - 1
            Dim ch As Char = str.Chars(i)
            If ch = " " Then
                sp += 1
            ElseIf Char.IsDigit(ch) Then
                d += 1
            ElseIf Not Char.IsLetterOrDigit(ch) Then
                sym += 1
            Else
                If IsVowel(Char.ToLower(ch)) Then
                    v += 1
                End If
            End If
        Next

        MsgBox(" VOWEL IS :: " & v & vbCrLf & " DIGITS IS :: " & d & vbCrLf & " SPACE IS :: " & sp & vbCrLf & " SPECIAL SIMBOLES IS :: " & sym)


    End Sub

    Function IsVowel(ByVal ch As Char) As Boolean
        If ch = "a" Or ch = "e" Or ch = "i" Or ch = "o" Or ch = "u" Then
            Return True
        Else
            Return False
        End If
    End Function
End Class