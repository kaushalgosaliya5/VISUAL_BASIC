Module SELECTION_SORT

    Sub main()

        Dim num(9), i, j, tmp As Integer

        For i = 0 To num.Length - 1
            Console.WriteLine(" ENTER NUMBER " & (i + 1) & " :: ")
            num(i) = Console.ReadLine
        Next

        For i = 0 To num.Length - 2
            For j = (i + 1) To num.Length - 1
                If num(i) > num(j) Then
                    tmp = num(i)
                    num(i) = num(j)
                    num(j) = tmp
                End If
            Next
        Next

        For i = 0 To num.Length - 1
            Console.Write(" " & num(i))
        Next

        Console.Read()
    End Sub
End Module
