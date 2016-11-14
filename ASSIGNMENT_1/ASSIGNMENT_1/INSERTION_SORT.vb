Module INSERTION_SORT

    Sub main()

        Dim num(4), i, j, tmp As Integer

        For i = 0 To num.Length - 1
            Console.WriteLine(" ENTER NUMBER " & (i + 1) & " :: ")
            num(i) = Console.ReadLine
        Next

        For i = 1 To num.Length - 1
            j = i
            While num(j) < num(j - 1)
                tmp = num(j)
                num(j) = num(j - 1)
                num(j - 1) = tmp

                j = j - 1

                If j = 0 Then
                    Exit While
                End If
            End While
        Next

        For i = 0 To num.Length - 1
            Console.Write(" " & num(i))
        Next

        Console.Read()
    End Sub
End Module
