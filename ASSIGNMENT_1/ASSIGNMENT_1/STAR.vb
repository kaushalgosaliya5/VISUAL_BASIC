Module STAR

    Sub main()

        Dim num As Integer

        Console.WriteLine(" ENTER NUMBER :: ")
        num = Console.ReadLine

        For i = 0 To num
            For j = 0 To num
                Console.WriteLine("* ")
            Next
        Next

    End Sub
End Module
