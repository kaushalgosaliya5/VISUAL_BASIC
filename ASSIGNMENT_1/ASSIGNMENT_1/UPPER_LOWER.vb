Module UPPER_LOWER

    Sub main()

        Dim s1, s2 As String

        Console.WriteLine(" ENTER STRING LOWER_CASE 1 :: ")
        s1 = Console.ReadLine

        Console.WriteLine(" ENTER STRING UPPER_CASE 2 :: ")
        s2 = Console.ReadLine

        Console.WriteLine(" UPPER CASE :: " & UCase(s1))
        Console.WriteLine(" LOWER CASE :: " & LCase(s2))

        Console.Read()
    End Sub

End Module
