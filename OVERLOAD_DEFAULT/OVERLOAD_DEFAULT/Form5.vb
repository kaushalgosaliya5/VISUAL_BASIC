Public Class Form5

    Private Sub TrackBar1_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar1.Scroll

        Me.Opacity = TrackBar1.Value * 0.1  ' trancparencty by form

    End Sub
End Class