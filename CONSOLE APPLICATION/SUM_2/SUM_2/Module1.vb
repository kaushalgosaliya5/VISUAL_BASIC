Module Module1

    Sub Main()

        Dim i, num, sum As Integer

        Console.WriteLine(" ENTER ANY NUMBER :: ")
        num = Console.ReadLine

        For i = 1 To num
            sum += i  ' sum = sum + i
        Next

        Console.WriteLine(" SUM IS :: " & sum)
        Console.Read()

    End Sub

End Module
