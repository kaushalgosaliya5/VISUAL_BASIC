Module TIME_SUM

    Sub main()

        Dim h1, h2, h3, m1, m2, m3, t1, t2, t3 As Integer

        Console.WriteLine(" FIRST TIME :: ")
        Console.WriteLine(" ENTER HOURS :: ")
        h1 = Console.ReadLine
        Console.WriteLine(" ENTER MINUTE :: ")
        m1 = Console.ReadLine

        t1 = h1 * 60 + m1

        Console.WriteLine(" SECOND TIME :: ")
        Console.WriteLine(" ENTER HOURS :: ")
        h2 = Console.ReadLine
        Console.WriteLine(" ENTER SECONDS :: ")
        m2 = Console.ReadLine

        t2 = h2 * 60 + m2

        t3 = t1 + t2

        If t3 >= 60 Then
            h3 = t3 / 60
            m3 = t3 Mod 60
        End If

        Console.WriteLine(" HH :: MM IS :: " & h3 & " :: " & m3)

        Console.Read()
    End Sub

End Module
