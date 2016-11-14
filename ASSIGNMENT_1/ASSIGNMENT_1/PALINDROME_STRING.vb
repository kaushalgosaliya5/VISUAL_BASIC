Module PALINDROME_STRING

    Sub main()

        Dim s1, s2 As String

        Console.WriteLine(" ENTER NAME :: ")
        s1 = Console.ReadLine

        s2 = StrReverse(s1)

        If s1 = s2 Then
            Console.WriteLine(" GIVEN STRING IS PALINDROME ")
        Else
            Console.WriteLine(" GIVEN STRING IS NOT PALINDROME")
        End If

        Console.Read()
    End Sub
End Module
