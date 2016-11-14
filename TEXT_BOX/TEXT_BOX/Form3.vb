Public Class Form3

    Private Sub B1_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles B1.MouseEnter

        Dim fnt As New Font(B1.Font, FontStyle.Bold)

        B1.Font = fnt

        MsgBox(" FONT HAS BEEN CHANGED ")

    End Sub
End Class