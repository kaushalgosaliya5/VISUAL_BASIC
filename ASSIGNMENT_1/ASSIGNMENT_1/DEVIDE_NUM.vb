Module DEVIDE_NUM

    Sub main()

        Dim num(4), i, j, min, count As Integer

        For i = 0 To num.Length - 1
            Console.WriteLine(" ENTER VALUE " & (i + 1) & " :: ")
            num(i) = Console.ReadLine
        Next

        min = num(0)

        For i = 0 To num.Length - 1
            If num(i) < min Then
                min = num(i)
            End If
        Next

        For i = 1 To min
            count = 0
            For j = 0 To num.Length - 1
                If num(j) Mod i = 0 Then
                    count += 1
                End If
            Next

            If count = num.Length Then
                Console.Write(i & " , ")
            End If
        Next

        Console.Read()
    End Sub
End Module
