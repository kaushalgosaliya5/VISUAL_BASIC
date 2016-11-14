Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim pass As String
        Dim letter, digit, simbol As Boolean
        letter = digit = simbol = False ' default value is false

        'Dim digit As Boolean = False
        'Dim simbol As Boolean = False

        pass = InputBox(" ENTER YOUR PASSWORD :: ", " INPUT VALUES", " PASSWORD ")

        For i = 0 To pass.Length - 1
            If Char.IsLetter(pass(i)) Then
                letter = True
            ElseIf Char.IsDigit(pass(i)) Then
                digit = True
            Else
                simbol = True
            End If
        Next

        If letter = True And digit = True And simbol = True Then
            MsgBox(" YOU PASSWORD IS CORRECT ")
        Else
            MsgBox(" YOU PASSWORD IS WRONG")
        End If

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
