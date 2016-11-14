Module SALLARY

    Sub main()

        Dim sal, hra, da As Integer

        Console.WriteLine(" ENTER YOUR SALLARY :: ")
        sal = Console.ReadLine

        Console.WriteLine(" ENTER HRA :: ")
        hra = Console.ReadLine

        Console.WriteLine(" ENTER DA :: ")
        da = Console.ReadLine

        Console.WriteLine(" YOUR NET SALLARY IS ::" & sal + (sal * hra / 100) + (sal * da / 100))

        Console.Read()
    End Sub

End Module
