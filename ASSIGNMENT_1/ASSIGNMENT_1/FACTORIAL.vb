Module FACTORIAL

    Sub main()

        Dim num, i, ans As Integer

        Console.WriteLine(" ENTER ANY NUMBER :: ")
        num = Console.ReadLine

        ans = 1

        For i = 1 To num
            ans = ans * i
        Next

        Console.WriteLine(" FACTORIAL IS :: " & ans)

        Console.Read()
    End Sub
End Module
