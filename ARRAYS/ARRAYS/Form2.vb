Public Class Form2

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim Statistics(15, 5) As Integer   ' DECLARATION OF TWO DIAMENTION ARRAYS  total value is (15+1) 16 * 6 (5+1) = 96 values

        MsgBox(" Statistics arrays length is (16*6) :: " & Statistics.Length)

        MsgBox(" Statistics 0th diamention length :: " & Statistics.GetLength(0))
        MsgBox(" Statistics 1th diamention length :: " & Statistics.GetLength(1))

        MsgBox(" Statistics 0th diamention UPPER_BOUND IS :: " & Statistics.GetUpperBound(0))
        MsgBox(" Statistics 0th diamention LOWER_BOUND IS :: " & Statistics.GetLowerBound(0))


        MsgBox(" Statistics 1th diamention UPPER_BOUND IS :: " & Statistics.GetUpperBound(1))
        MsgBox(" Statistics 1th diamention LOWER_BOUND IS :: " & Statistics.GetLowerBound(1))

        Dim y(,) As Integer = {{1, 11, 21}, {2, 12, 22}, {3, 13, 23}}

        MsgBox(" HOW MANY DIAMENTION THIS PATIQLAR ARRAY :: " & y.Rank)

    End Sub
End Class