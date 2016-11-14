Public Class Form3

    Private Sub TrackBar1_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar1.Scroll
        Dim x As Integer
        Dim i As Integer

        ListBox1.Items.Clear()

        i = TrackBar1.Value

        L1.Text = " MULTIPLICATION TABLE OF :: " & i

        For x = 1 To 10
            ListBox1.Items.Add(i & " * " & x & " = " & (i * x))
        Next

    End Sub
End Class