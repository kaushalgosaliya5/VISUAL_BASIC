Module PERSENTAGE

    Sub main()

        Dim s(4), i, sum As Integer

        For i = 0 To s.Length - 1
            Console.Write(" ENTER MARKS SUBJECT " & i + 1 & " :: ")
            s(i) = Console.ReadLine

            sum = sum + s(i)
        Next

        Console.Write(" YOUR GRADE IS :: ")

        Select Case (sum / s.Length)
            Case Is > 80
                Console.Write(" A ")
            Case Is > 60
                Console.Write(" B ")
            Case Is > 40
                Console.Write(" C ")
            Case Is < 40
                Console.Write(" FAIL ")
        End Select

        Console.Read()
    End Sub

End Module
