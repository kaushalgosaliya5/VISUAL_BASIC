Public Class Form3

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim x As Integer
        Dim y, z As Integer

        x = 3

        If x = 3 Then y = 100 : z = 200 ' IF CONDITION ONLY SINGLE LINE

        MsgBox(" VALUE OF X :: " & x & " Y IS :: " & y & " Z IS :: " & z)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Dim i As Integer

        For i = 0 To 10 Step 2   ' FOR LOOP HAS i = i + 2  
            MsgBox(" I is :: " & i)
        Next

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        Dim x() As Integer = {1, 2, 3, 4, 5}

        For Each i As Integer In x
            MsgBox(" VALUE OF I IS :: " & i)
        Next


    End Sub
End Class