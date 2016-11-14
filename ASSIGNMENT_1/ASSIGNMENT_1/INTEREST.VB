Module Module1

    Sub Main()

        Dim p, r, n, i As Integer

        Console.WriteLine(" ENTER PRINCIPAL AMOUNT :: ")
        p = Console.ReadLine

        Console.WriteLine(" ENTER RATE OF INTEREST :: ")
        r = Console.ReadLine

        Console.WriteLine(" ENTER NUMBER OF YEAR :: ")
        n = Console.ReadLine

        i = (p * r * n) / 100

        Console.WriteLine(" YOUR INTEREST IS :: " & i)
        Console.Read()

    End Sub

End Module
