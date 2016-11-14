Public Class Form10

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B1.Click, B2.Click

        Dim A() As Integer = {50, 10, 20, 50, 40, 30, 60, 80, 5, 140}
        Dim min As Integer = Integer.MaxValue, max As Integer = Integer.MinValue

        
        For i = 0 To A.Length - 1
            If A(i) < min Then
                min = A(i)
            End If

            If A(i) > max Then
                max = A(i)
            End If
        Next

        If sender.Text = "MINIMUM" Then
            MsgBox(" MINIMUM IS :: " & min)
        Else
            MsgBox(" MAXIMUM IS :: " & max)
        End If
    End Sub
End Class