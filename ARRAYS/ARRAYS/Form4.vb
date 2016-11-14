Public Class Form4

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim i As Integer

        Do Until i > 10
            MsgBox(" VALUE OF I IS :: " & i)
            i += 1
        Loop
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim i As Integer

        i = 1

        While i < 10
            MsgBox(" value of is is :: " & i)
            i += 1
        End While

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Dim i As Integer

        Do While i < 10
            MsgBox(" VALUE OF I IS :: " & i + 1)
            i += 1
        Loop

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim i As Integer

        Do
            MsgBox(" VALUE OF I IS :: " & i)
            i += 1
        Loop While (i < 10)

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click

        Dim i As Integer

        Do
            MsgBox(" VALUE OF I IS :: " & i)
            i += 1
        Loop Until i > 10

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim i As Integer

        i = Today.DayOfWeek

        Select Case i
            Case 1, 2, 3, 4
                MsgBox(" WISH YOUR HAPPY WEEK ")
            Case 5
                MsgBox(" WISHING YOUR HAPPY END OF WEEK ")
            Case 6
                MsgBox(" HOLIDAY ")
            Case 0
                MsgBox(" HOLIDAY ")
        End Select

    End Sub
End Class