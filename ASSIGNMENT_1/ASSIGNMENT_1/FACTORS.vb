Module FACTORS

    Sub main()

        Dim num, i As Integer

        Console.WriteLine(" ENTER NUMBER :: ")
        num = Console.ReadLine

        For i = 1 To num
            If num Mod i = 0 Then
                Console.WriteLine(" " & i)
            End If
        Next

        Console.Read()
    End Sub

End Module














































































