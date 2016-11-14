Public Class Form12

    Private Sub N1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles N1.ValueChanged
        Dim i As Integer
        Dim x As Integer = N1.Value

        L1.Items.Clear()

        For i = 1 To 10
            L1.Items.Add(x & " * " & i & " = " & (i * x))
        Next
    End Sub
End Class