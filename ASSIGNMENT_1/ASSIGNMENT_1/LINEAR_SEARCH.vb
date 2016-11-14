Module LINEAR_SEARCH

    Sub main()

        Dim num(4), i, x As Integer

        For i = 0 To num.Length - 1
            Console.WriteLine(" ENTER NUMBER " & (i + 1) & " :: ")
            num(i) = Console.ReadLine
        Next

        Console.WriteLine(" ENTER VALUE TO SEARCH :: ")
        x = Console.ReadLine

        For i = 0 To num.Length - 1
            If num(i) = x Then
                Console.WriteLine(" YOUR NUM IS " & (i + 1) & " POSITION")
                Exit For
            End If
        Next

        If i = num.Length Then
            Console.WriteLine(" YOUR VALUE IS NOT FOUND ")
        End If

        Console.Read()
    End Sub
End Module
