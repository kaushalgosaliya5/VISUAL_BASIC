Module Module1

    Sub Main()

        Dim num, r As Integer

        Console.WriteLine(" ENTER ANY NUMBER :: ")
        num = Console.ReadLine()

        r = num Mod 2

        If r = 0 Then
            Console.WriteLine(" GIVEN NUM IS EVEN ")
        Else
            Console.WriteLine(" GIVEN NUM IS ODD ")
        End If

        Console.ReadLine()

    End Sub

End Module
