Module ARITHMATIC

    Sub main()

        Dim n1, n2, ch As Integer

        Console.Write(" ENTER FIRST NUMBER :: ")
        n1 = Console.ReadLine

        Console.Write(" ENTER SECOND NUMBER :: ")
        n2 = Console.ReadLine

        Console.WriteLine(" 1. ADDITION ")
        Console.WriteLine(" 2. SUBTRACTION ")
        Console.WriteLine(" 3. MULTIPLICATION ")
        Console.WriteLine(" 4. DIVITION ")

        Console.WriteLine(" SELECT NUMBER :: ")
        ch = Console.ReadLine

        Console.Write(" ANS IS :: ")

        Select Case ch
            Case 1
                Console.Write(n1 + n2)
            Case 2
                Console.Write(n1 - n2)
            Case 3
                Console.Write(n1 * n2)
            Case 4
                Console.Write(n1 / n2)
        End Select

        Console.Read()
    End Sub

End Module
