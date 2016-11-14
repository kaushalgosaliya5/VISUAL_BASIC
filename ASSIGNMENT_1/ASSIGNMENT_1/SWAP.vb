Module SWAP

    Sub main()

        Dim n1, n2 As Integer

        Console.WriteLine(" ENTER FIRST NUMBER :: ")
        n1 = Console.ReadLine

        Console.WriteLine(" ENTER SECOND NUMBER :: ")
        n2 = Console.ReadLine

        n1 = n1 + n2
        n2 = n1 - n2
        n1 = n1 - n2

        Console.WriteLine(" N1 IS :: " & n1)
        Console.WriteLine(" N2 IS :: " & n2)

        Console.Read()
    End Sub

End Module
