Public Class Form2

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim ans As Integer = T1.Text


        If R1.Checked = True Then
            ans = ADD(CInt(T1.Text), CInt(T2.Text))
        ElseIf R2.Checked = True Then
            ans = ADD(CInt(T1.Text), CInt(T2.Text), CInt(T3.Text))
        ElseIf R3.Checked = True Then
            ans = ADD(CInt(T1.Text), CInt(T2.Text), CInt(T3.Text), CInt(T4.Text))
        End If

        MsgBox(" SUM IS :: " & ans)

    End Sub
    Function ADD(ByVal n1 As Integer, Optional ByVal n2 As Integer = 0, Optional ByVal n3 As Integer = 0, Optional ByVal n4 As Integer = 0) As Integer
        Dim sum As Integer

        sum = n1 + n2 + n3 + n4

        ADD = sum

    End Function
End Class