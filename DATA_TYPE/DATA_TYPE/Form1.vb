Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B1.Click
        MsgBox(" MINIMUM VALUE IS :: " & Short.MinValue & " MAXIMUM VALUE IS : " & Short.MaxValue)
    End Sub

    Private Sub B2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B2.Click
        MsgBox(" MINIMUM VALUE IS :: " & Integer.MinValue & " MAXIMUM VALUE IS : " & Integer.MaxValue)
    End Sub

    Private Sub B3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B3.Click
        MsgBox(" MINIMUM VALUE IS :: " & Long.MinValue & " MAXIMUM VALUE IS : " & Long.MaxValue)
    End Sub

    Private Sub B4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B4.Click
        MsgBox(" MINIMUM VALUE IS :: " & Single.MinValue & " MAXIMUM VALUE IS : " & Single.MaxValue)
    End Sub

    Private Sub B5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B5.Click
        MsgBox(" MINIMUM VALUE IS :: " & Double.MinValue & " MAXIMUM VALUE IS : " & Double.MaxValue)
    End Sub

    Private Sub B6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B6.Click
        MsgBox(" MINIMUM VALUE IS :: " & Decimal.MinValue & " MAXIMUM VALUE IS : " & Decimal.MaxValue)
    End Sub
End Class
