Module MULTI

    Sub main()

        Dim n1(4), n2(4), n3(4), i As Integer

        Console.WriteLine(" ENTER FIRST ARRAY VALUE :: ")

        For i = 0 To n1.Length - 1
            Console.WriteLine(" ENTER VALUE " & (i + 1) & " :: ")
            n1(i) = Console.ReadLine
        Next

        Console.WriteLine(" ENTER SECOND ARRAY VALUE :: ")

        For i = 0 To n2.Length - 1
            Console.WriteLine(" ENTER VALUE  " & (i + 1) & " :: ")
            n2(i) = Console.ReadLine
        Next

        For i = 0 To n3.Length - 1
            n3(i) = n1(i) * n2(i)
        Next

        Console.WriteLine(" MULTIPLICATION IS :: ")

        For i = 0 To n3.Length - 1
            Console.Write(n3(i) & " , ")
        Next

        Console.Read()
    End Sub

End Module
