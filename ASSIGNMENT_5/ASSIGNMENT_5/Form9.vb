Public Class Form9

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim A() As Integer = {5, 20, 140, 10, 70, 80, 40, 30, 50, 15}

        A = Sort(A)

        For i As Integer = 0 To A.Length - 1
            TextBox1.Text += A(i) & vbCrLf
        Next
    End Sub

    Function Sort(ByVal arr() As Integer) As Integer()

        Dim i, j As Integer
        Dim tmp As Integer

        For i = 0 To arr.Length - 2
            For j = i To (arr.Length - 2 - i)
                If arr(j) > arr(j + 1) Then
                    tmp = arr(j)
                    arr(j) = arr(j + 1)
                    arr(j + 1) = tmp
                End If
            Next
        Next

        Sort = arr

    End Function
End Class