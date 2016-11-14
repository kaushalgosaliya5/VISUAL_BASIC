Public Class Form2

    Private Sub T1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles T1.KeyPress
        If e.KeyChar = vbBack Then Exit Sub
        If Not e.KeyChar Like "[0-9,.]" Then e.Handled = True
    End Sub

    Private Sub B1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B1.Click
        If Not IsNumeric(T1.Text) Then
            MsgBox(" CORRECT VALUE ENTER ")
            T1.Clear()
            T1.Focus()
            Exit Sub
        End If

        Dim ans As Single

        If Rcelsius.Checked = True Then
            ans = ftoc(Val(T1.Text))
            MsgBox(" CELSIOUS VALUE IS :: " & ans)
        ElseIf Rfehrenheit.Checked = True Then
            ans = ctof(Val(T1.Text))
            MsgBox(" FEHRAINHEIT VALUE IS :: " & ans)
        End If


        'Dim tmp As Single

        'tmp = Val(T1.Text)

        'If Rcelsius.Checked = True Then
        '    MsgBox(" FEHRENHEIT IS :: " & ((tmp - 32) * 5) / 9)
        'ElseIf Rfehrenheit.Checked = True Then
        '    MsgBox(" CELSIOUS IS :: " & ((tmp * 9) / 5) + 32)
        'End If

    End Sub
    Public Function ftoc(ByVal f As Single) As Single
        ftoc = (((f - 32) * 5) / 9)
    End Function
    Public Function ctof(ByVal c As Single) As Single
        ctof = (((c * 9) / 5) + 32)
    End Function
    

    Private Sub Rcelsius_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rcelsius.CheckedChanged
        If Rcelsius.Checked = True Then
            L2.Text = " ENTER FAHRENHEIT VALUE :: "
        End If
    End Sub

    Private Sub Rfehrenheit_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rfehrenheit.CheckedChanged
        If Rfehrenheit.Checked = True Then
            L2.Text = " ENTER CELSIOUS VALUE :: "
        End If
    End Sub

End Class