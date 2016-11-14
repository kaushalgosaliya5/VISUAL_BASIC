Module REVERCE_STRING

    Sub MAIN()

        Dim s As String

        Console.WriteLine(" ENTER STRING :: ")
        s = Console.ReadLine

        Console.WriteLine(" REVERSE STRING IS :: " & StrReverse(s))

        Console.Read()
    End Sub

End Module
