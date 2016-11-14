Public Class Form1

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles T1.KeyPress
        If e.KeyChar = vbBack Then Exit Sub
        If Not e.KeyChar Like "[0-9-/]" Then e.Handled = True
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Not IsDate(T1.TEXT) Then
            MsgBox(" INVALIDE DATE ")
            T1.Clear()
            T1.Focus()
            Exit Sub
        End If

        Dim d1 As Date = T1.Text
        Dim d2 As Date = Now()
        Dim yr As Single

        yr = DateDiff(DateInterval.Year, d1, d2)   ' VALIDATION OF DATE

        MsgBox(" YOU ARE " & yr & " YEARS OLD")

        Dim deathdate As Date

        deathdate = DateAdd(DateInterval.Year, 75, d1) ' ADD YEAR ON MONTH 

        MsgBox(" DEATH DATE IS : " & deathdate)

        Dim x As Date = Now()

        Dim y As Date = DateAdd(DateInterval.Day, 14, x)

        MsgBox(" CURRENT DATE IN A ADDING A 14 DAYS FOR NEW DATE IS :: " & y)

    End Sub
End Class
