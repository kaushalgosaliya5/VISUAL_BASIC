Public Class Form2

    Private Sub Button1_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.MouseEnter

        Button1.Left = Rnd() * 500
        Button1.Top = Rnd() * 500


        MsgBox(" YOU ARE WINNER !!! ")

    End Sub
End Class