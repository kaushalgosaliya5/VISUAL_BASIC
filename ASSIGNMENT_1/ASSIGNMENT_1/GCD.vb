Module GCD

    Sub main()

        Dim n1, n2, min, i, gcd As Integer

        Console.WriteLine(" ENTER FIRST NUMBER :: ")
        n1 = Console.ReadLine

        Console.WriteLine(" ENTER SECOND NUMBER :: ")
        n2 = Console.ReadLine

        If n1 < n2 Then
            min = n1
        Else
            min = n2
        End If

        For i = 2 To min
            If n1 Mod i = 0 And n2 Mod i = 0 Then
                gcd = i
            End If
        Next

        Console.WriteLine(" GCD IS :: " & gcd)
        Console.Read()
    End Sub

End Module
