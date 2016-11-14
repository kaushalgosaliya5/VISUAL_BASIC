Module ABSOLUTE

    Sub main()

        Dim num As Integer

        Console.WriteLine(" ENTER NUMBER :: ")
        num = Console.ReadLine

        If num < 0 Then
            num = num * -1
        End If

        Console.WriteLine(" ABSOLUTE VALUE IS :: " & num)

        Console.Read()
    End Sub
End Module
