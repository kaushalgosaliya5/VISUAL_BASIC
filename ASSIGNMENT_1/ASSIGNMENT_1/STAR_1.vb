Module STAR_1

    Sub Main()

        Dim num, i, j, sp As Integer

        Console.WriteLine(" ENTER NUMBER :: ")
        num = Console.ReadLine

        For i = 0 To num
            For sp = 0 To num - i
                Console.Write(" ")
            Next
            For j = 0 To i
                Console.Write("* ")
            Next
            Console.WriteLine("")
        Next

        Console.Read()
    End Sub

End Module
