Public Class Form1

    Private Sub B1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B1.Click
        Dim sum As Integer

        For i As Integer = 0 To TextBox1.Lines.Length - 1
            sum += TextBox1.Lines(i)
        Next

        MsgBox(" AVERAGE IS :: " & sum / TextBox1.Lines.Count)

    End Sub

    Private Sub B2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B2.Click
        Dim min As Integer = Integer.MaxValue

        For i As Integer = 0 To TextBox1.Lines.Length - 1
            If CInt(TextBox1.Lines(i)) < min Then
                min = CInt(TextBox1.Lines(i))
            End If
        Next

        MsgBox("MIN VALUE IS :: " & min)

    End Sub

    Private Sub B3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B3.Click
        Dim MAX As Integer = Integer.MinValue

        For i As Integer = 0 To TextBox1.Lines.Length - 1
            If CInt(TextBox1.Lines(i)) > MAX Then
                MAX = TextBox1.Lines(i)
            End If
        Next

        MsgBox("MAX VALUE IS :: " & MAX)

    End Sub
End Class
