Module LCM

    Sub main()

        Dim n1, n2, max, i As Integer

        Console.WriteLine(" ENTER FIRST NUMBER :: ")
        n1 = Console.ReadLine

        Console.WriteLine(" ENTER SECOND NUMBER :: ")
        n2 = Console.ReadLine

        If n1 > n2 Then
            max = n1
        Else
            max = n2
        End If

        i = max

        For i = max To n1 * n2
            If i Mod n1 = 0 And i Mod n2 = 0 Then
                Console.WriteLine(" LCM IS :: " & i)
                Exit For
            End If
        Next

        Console.Read()
    End Sub

End Module
