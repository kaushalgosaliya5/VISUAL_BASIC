Public Class Form6

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B1.Click
        If Not IsNumeric(TextBox1.Text) Then
            MsgBox(" YOUR VALUE IS WRONG")
            TextBox1.Clear()
            TextBox1.Focus()
            Exit Sub
        End If

        Dim ans As Boolean = Prime(TextBox1.Text)

        If ans Then
            MsgBox(" GIVEN NUMBER IS PRIME ")
        Else
            MsgBox(" GIVEN NUMBER IS NOT PRIME")
        End If
    End Sub

    Function Prime(ByVal num As Integer) As Boolean

        Dim logic As Boolean = True
        Dim i As Integer

        For i = 2 To num - 1
            If num Mod i = 0 Then
                logic = False
                Exit For
            End If
        Next

        Return logic

    End Function
End Class