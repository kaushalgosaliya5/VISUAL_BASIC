Public Class Form6

    Private Sub HScrollBar1_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles HScrollBar1.Scroll, HScrollBar2.Scroll, HScrollBar3.Scroll
        T1.Text = HScrollBar1.Value
        T2.Text = HScrollBar2.Value
        T3.Text = HScrollBar3.Value

        L4.BACKCOLOR = Color.FromArgb(Val(T1.Text), Val(T2.Text), Val(T3.Text))


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Me.BackColor = L4.BackColor

    End Sub
End Class