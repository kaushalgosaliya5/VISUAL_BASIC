Module PARFECT_NUM

    Sub main()

        Dim num, sum, i, onum, s1, ram As Integer

        Console.WriteLine(" ENTER NUMBER :: ")
        num = Console.ReadLine

        onum = num

        For i = 1 To num
            sum = sum + i
        Next

        While sum > 0
            ram = sum Mod 10
            s1 = s1 + ram
            sum = sum / 10
        End While

        If s1 = onum Then
            Console.WriteLine(" GIVEN NUM IS PERFECT NUM ")
        Else
            Console.WriteLine(" GIVEN NUM IS NOT PERFECT NUM")
        End If

        Console.Read()
    End Sub

End Module
