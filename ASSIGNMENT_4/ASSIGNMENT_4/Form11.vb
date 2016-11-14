Public Class Form11

    Dim operand As Single
    Dim op As Char
    Dim clrdisp As Boolean = True


    Private Sub B1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B0.Click, B1.Click, B2.Click, B3.Click, B4.Click, B5.Click, B6.Click, B7.Click, B8.Click, B9.Click, BDot.Click

        If clrdisp = True Then
            TextBox1.Clear()
            clrdisp = False
        End If

        If sender.text = "." And TextBox1.Text.IndexOf(".") > -1 Then Exit Sub

        TextBox1.Text = TextBox1.Text & sender.TEXT
    End Sub

    Private Sub BPlus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BPlus.Click, BMinus.Click, BMulti.Click, BDiv.Click, BCap.Click

        If op <> "" Then BEqual.PerformClick()

        operand = Val(TextBox1.Text)
        op = sender.text
        ' TextBox1.Clear()
        clrdisp = True
    End Sub

    Private Sub BEqual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BEqual.Click

        If op = "+" Then TextBox1.Text = operand + Val(TextBox1.Text)
        If op = "-" Then TextBox1.Text = operand - Val(TextBox1.Text)
        If op = "*" Then TextBox1.Text = operand * Val(TextBox1.Text)
        If op = "/" Then TextBox1.Text = operand / Val(TextBox1.Text)
        If op = "^" Then TextBox1.Text = Math.Pow(operand, Val(TextBox1.Text))

        op = ""

    End Sub

    Private Sub BClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BClear.Click
        op = ""
        TextBox1.Clear()
        clrdisp = True

    End Sub

    Private Sub BLog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BLog.Click
        TextBox1.Text = Math.Log10(Val(TextBox1.Text))
    End Sub

    Private Sub BSin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BSin.Click
        TextBox1.Text = Math.Sin(Math.PI * Val(TextBox1.Text) / 180)
    End Sub

    Private Sub BCos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BCos.Click
        TextBox1.Text = Math.Cos(Math.PI * Val(TextBox1.Text) / 180)
    End Sub

    Private Sub BN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BN.Click
        TextBox1.Text = -(Val(TextBox1.Text))
    End Sub

    Private Sub BSqrt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BSqrt.Click
        TextBox1.Text = Math.Sqrt(Val(TextBox1.Text))
    End Sub

    Private Sub BFact_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BFact.Click
        Dim fact As Integer = 1
        Dim i As Integer = 1

        For i = 1 To Val(TextBox1.Text)
            fact *= i
        Next

        TextBox1.Text = fact

    End Sub
End Class