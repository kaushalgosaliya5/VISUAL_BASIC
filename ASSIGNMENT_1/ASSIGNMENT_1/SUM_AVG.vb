Module SUM_AVG

    Sub main()

        Dim Array(4), sum, avg, i As Integer

        For i = 0 To Array.Length - 1
            Console.WriteLine(" ENTER NUMBER " & (i + 1) & " :: ")
            Array(i) = Console.ReadLine

            sum = sum + Array(i)
        Next

        avg = sum / Array.Length

        Console.WriteLine(" SUM IS :: " & sum)
        Console.WriteLine(" AVERAGE IS :: " & avg)

        Console.Read()

    End Sub

End Module
