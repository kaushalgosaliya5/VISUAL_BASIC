Module BASE_EXPONENT

    Sub main()

        Dim b, e, i, ans As Integer

        Console.WriteLine(" ENTER BASE :: ")
        b = Console.ReadLine

        Console.WriteLine(" ENTER EXPONENT :: ")
        e = Console.ReadLine

        ans = 1

        For i = 1 To e
            ans = ans * b
        Next

        Console.WriteLine(" ANS IS :: " & ans)

        Console.Read()
    End Sub
End Module
