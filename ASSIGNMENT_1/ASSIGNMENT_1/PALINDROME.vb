Module PALINDROME

    Sub main()

        Dim num, ram, onum, rnum As Integer

        Console.WriteLine(" ENTER NUMBER :: ")
        num = Console.ReadLine

        onum = num

        While num > 0
            ram = num Mod 10
            num = num / 10
            rnum = rnum * 10 + ram
        End While

        If rnum = onum Then
            Console.WriteLine(" GIVEN NUM IS PALINDROME ")
        Else
            Console.WriteLine(" GIVEN NUM IS NOT PALINDROME")
        End If

        Console.Read()
    End Sub
End Module
