Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        System.IO.Directory.CreateDirectory("E:\KSL\KAUSHAL")

        MsgBox(" FOLDER HAS BEEN CREATED :: E:\KSL\KAUSHAL ")
    End Sub
End Class
