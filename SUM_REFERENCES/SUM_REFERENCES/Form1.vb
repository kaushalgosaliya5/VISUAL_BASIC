Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If Not IsNumeric(T1.Text) Then
            MsgBox(" INVALIDE NUMBER ")
            T1.Clear()
            T1.Focus()
            Exit Sub
        End If

        If Not IsNumeric(T2.Text) Then
            MsgBox(" INVALIDE NUMBER ")
            T2.Clear()
            T2.Focus()
            Exit Sub
        End If

        Dim a, b, c As Integer

        a = Val(T1.Text)
        b = Val(T2.Text)

        c = SUM(a, b)

        MsgBox(" YOUR SUM IS :: " & c)
        MsgBox(" A IS :: " & a)  ' VALUE OF a is :: 0
        MsgBox(" B IS :: " & b)  ' VALUE OF b is :: 0 

    End Sub

    Function SUM(ByRef NUM1 As Integer, ByRef NUM2 As Integer) ' " ByRef " IS CALL BY REFERENCES (POINTER CONSEPT) 

        'Dim ans As Integer

        'ans = NUM1 + NUM2

        'Return ans

        SUM = NUM1 + NUM2

        NUM1 = 0
        NUM2 = 0

    End Function
End Class
