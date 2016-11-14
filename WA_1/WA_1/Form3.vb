Public Class Form3

    Private Sub Form3_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove

        Dim mypen As New System.Drawing.Pen(Color.FromArgb(Rnd() * 255, Rnd() * 255, Rnd() * 255))

        Dim g As Graphics = Me.CreateGraphics

        g.DrawEllipse(mypen, e.X, e.Y, 150, 150)

    End Sub
End Class