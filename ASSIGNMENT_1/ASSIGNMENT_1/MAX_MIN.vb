Module MAX_MIN

    Sub main()

        Dim Array(4), i, min, max As Integer

        For i = 0 To Array.Length - 1
            Console.WriteLine(" ENTER NUMBER " & i & " :: ")
            Array(i) = Console.ReadLine
        Next

        min = Array(0)
        max = Array(0)

        For i = 1 To Array.Length - 1
            If Array(i) > min Then
                min = Array(i)
            End If
            If Array(i) < max Then
                max = Array(i)
            End If
        Next

        Console.WriteLine(" MAXIMUM NUM IS :: " & max)
        Console.WriteLine(" MINIMUM NUM IS :: " & min)

        Console.Read()
    End Sub

End Module
