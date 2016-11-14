Public Class Form1


    Private Sub Form1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.DoubleClick
        MsgBox(" WELCODE TO VG .NET IS DOUBLE CLICK OF THE FORM ")
    End Sub

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        MsgBox(" THIS IS CLICK EVENTS ")
    End Sub

    Private Sub Button1_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.MouseEnter
        Dim fnt As New Font(Button1.Font, FontStyle.Bold)

        Button1.Font = fnt

    End Sub

    Private Sub Button1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.MouseLeave

        Dim fnt As New Font(Button1.Font, FontStyle.Regular)

        Button1.Font = fnt

    End Sub
End Class
