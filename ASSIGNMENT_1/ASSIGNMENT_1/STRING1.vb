Module STRING1

    Sub main()

        Dim s1, s2 As String

        Console.WriteLine(" ENTER STRING 1 :: ")
        s1 = Console.ReadLine


        Console.WriteLine(" ENTER STRING 2 :: ")
        s2 = Console.ReadLine

        If s1 = s2 Then
            Console.WriteLine(" BOTH IS SAME ")
        Else
            Console.WriteLine(" BOTH IS NOT SAME")
        End If

        Console.Read()

    End Sub

End Module
