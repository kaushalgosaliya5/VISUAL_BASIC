Public Class Form6

    Private Sub Tname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Tname.KeyPress
        If e.KeyChar = vbBack Then Exit Sub
        If Not e.KeyChar Like "[A-Z]" Then e.Handled = True
    End Sub

    
    Private Sub B1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B1.Click
        Dim g As String
        Dim s As String

        If Tname.Text = "" Then
            Tname.Focus()
            Exit Sub
        End If
        If Taddress.Text = "" Then
            Taddress.Focus()
            Exit Sub
        End If

        If Rssc.Checked = True Then
            s = " SSC "
        ElseIf Rhsc.Checked = True Then
            s = " HSC "
        Else
            s = " GRADUATION "
        End If

        If Rmale.Checked = True Then
            g = " MALE "
        Else
            g = " FEMALE "
        End If

        Ldetail.Text = " NAME :: " & Tname.Text & vbCrLf & " ADDRESS :: " & Taddress.Text & vbCrLf & " GENDER :: " & g & vbCrLf & " SKILLS :: " & s


    End Sub
End Class