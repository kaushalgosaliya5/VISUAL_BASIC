Module Module3

    Sub main()

        Dim num, i As Integer

        ' check given num is even or odd
        Console.WriteLine(" ENTER NUMBER :: ")
        num = Console.ReadLine

        i = num Mod 2

        If i = 0 Then
            Console.WriteLine(" GIVEN NUM IS EVEN ")
        Else
            Console.WriteLine(" GIVEN NUM IS ODD ")
        End If

        Console.Read()

    End Sub

End Module
