Module ARMASTRONG

    Sub main()

        Dim num, onum, ram, sum As Integer

        Console.WriteLine(" ENTER NUMBER :: ")
        num = Console.ReadLine

        onum = num
        sum = 0

        While num > 0
            ram = num Mod 10
            sum = sum + (ram * ram * ram)
            num = num / 10
        End While
        MsgBox(" " & sum)

        If onum = sum Then
            Console.WriteLine(" GIVEN NUM IS ARMASTRONG NUMBER")
        Else
            Console.WriteLine(" GIVEN NUM IS NOT ARMASTRONG NUMBER")
        End If

        Console.Read()
    End Sub

End Module
