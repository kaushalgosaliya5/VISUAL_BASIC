Public Class Form1

    Structure CheckRecord
        Dim chkno As Integer  ' check number
        Dim payto As String   ' which person to pay check
        Dim amt As Single     ' amt is amount
        Dim chkdt As Date     ' chkdt is check date
    End Structure

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim ch1 As CheckRecord

        ch1.chkno = 123456
        ch1.payto = "ABC COMP PVT.LTD"
        ch1.amt = 35000.5
        ch1.chkdt = #1/1/2014#  ' SPECIAL FORMATE OF DATE IS :: '# DATE #'

        MsgBox(" CHECK NO :: " & ch1.chkno & vbCrLf & " PAY TO :: " & ch1.payto & vbCrLf & " AMOUNT :: " & ch1.amt & vbCrLf & " DATE :: " & ch1.chkdt)

    End Sub
End Class
