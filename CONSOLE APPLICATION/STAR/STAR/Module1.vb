Module Module1

    Sub Main()

        Dim num, r, c, sp As Integer

        Console.WriteLine(" ENTER NUM :: ")
        num = Console.ReadLine

        For r = 1 To num
            For sp = 1 To num - r
                Console.Write(" ")
            Next
            For c = 1 To r
                Console.Write("* ") ' difference between writeline and write.
            Next
            Console.WriteLine()
        Next

        Console.Read()
    End Sub

End Module
