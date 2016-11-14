Module BOUBLE_SORT

    Sub main()

        Dim num(9), i, j, tmp As Integer

        For i = 0 To num.Length - 1
            Console.WriteLine(" ENTER VALUE " & (i + 1) & " :: ")
            num(i) = Console.ReadLine
        Next

        For i = 0 To num.Length - 2
            For j = 0 To num.Length - 2
                If num(j) > num(j + 1) Then
                    tmp = num(j)
                    num(j) = num(j + 1)
                    num(j + 1) = tmp
                End If
            Next
        Next

        For i = 0 To num.Length - 1
            Console.Write("  " & num(i))
        Next

        Console.Read()

    End Sub

End Module
