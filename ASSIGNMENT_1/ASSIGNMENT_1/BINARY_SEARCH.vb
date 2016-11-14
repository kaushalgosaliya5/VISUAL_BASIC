Module BINARY_SEARCH

    Sub main()

        Dim num(4), i, x, min, max, mid As Integer

        For i = 0 To num.Length - 1
            Console.WriteLine(" ENTER NUMBER " & (i + 1) & ":: ")
            num(i) = Console.ReadLine
        Next

        Console.WriteLine(" ENTER WHICH NUMBER TO SEARCH :: ")
        x = Console.ReadLine

        min = 0
        max = num.Length - 1
        mid = (min + max) / 2

        While max > min

            If num(mid) = x Then
                Console.WriteLine(" YOUR VALUE IS " & mid + 1 & " POSITION ")
                Exit While
            ElseIf num(mid) > x Then
                max = mid - 1
            Else
                min = mid + 1
            End If

            mid = (min + max) / 2
        End While

        If max < min Then
            Console.WriteLine(" GIVEN NUM IS NOT IN ARRAY")
        End If
        Console.Read()

    End Sub
End Module

