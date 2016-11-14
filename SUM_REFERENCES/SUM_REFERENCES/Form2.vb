Public Class Form2

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        PRINTVAL(NAME:="ABC", SAL:=13000, ENO:=101) ' PASSING A PERAMITER ANY SEQUEANCE 

    End Sub

    Sub PRINTVAL(ByVal ENO As Integer, ByVal NAME As String, ByVal SAL As Integer)
        MsgBox(" EMP CODE :: " & ENO & vbCrLf & " NAME IS :: " & NAME & vbCrLf & " SALLARY IS :: " & SAL)
    End Sub
End Class