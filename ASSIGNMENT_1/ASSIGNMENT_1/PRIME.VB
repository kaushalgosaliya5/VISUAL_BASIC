Module Module2

    Sub main()

        Dim logic As Boolean
        logic = True

        Dim num, i As Integer

        Console.WriteLine(" ENTER NUMBER :: ")
        num = Console.ReadLine

        For i = 2 To num - 1
            If num Mod i = 0 Then
                logic = False
            End If
        Next

        If logic = True Then
            Console.WriteLine(" GIVEN NUM IS PRIME ")
        Else
            Console.WriteLine(" GIVEN NUM IS NOT PRIME ")
        End If

        Console.Read()
    End Sub
End Module
