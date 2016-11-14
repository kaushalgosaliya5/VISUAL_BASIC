Module FIBONACI

    Sub main()

        Dim n1, n2, sum, num As Integer

        n1 = 0
        n2 = 1
        sum = n1 + n2

        ' FIBONACI SERIOCE 

        Console.WriteLine(" ENTER NUMBER :: ")
        num = Console.ReadLine

        While sum <= num
            Console.WriteLine(sum & "  ")
            n1 = n2
            n2 = sum
            sum = n1 + n2
        End While

        Console.Read()
    End Sub
End Module
