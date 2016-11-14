Public Class Form2

    Private Sub Form2_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        Dim res As MsgBoxResult

        res = MsgBox(" ARE YOUR SURE DO YOU WANT TO CLOSE THIS FORM ", MsgBoxStyle.YesNo, " CONFORMATION ")

        If res = MsgBoxResult.No Then
            e.Cancel = True
        End If

    End Sub

    Private Sub Form2_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        MsgBox(" FORM LOAD ")

    End Sub
End Class