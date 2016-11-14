Module TAX

    Sub main()

        Dim sal, ch As Integer

        Console.Write(" ENTER SALLARY :: ")
        sal = Console.ReadLine

        Console.WriteLine(" 1. MALE ")
        Console.WriteLine(" 2. FEMALE ")

        Console.Write(" ENTER YOUR CHOICE :: ")
        ch = Console.ReadLine

        If ch = 1 Then
            If sal > 150000 Then
                Console.WriteLine(" GIVEN SALLARY IS TAXABLE ")
            Else
                Console.WriteLine(" GIVEN SALLARY IS NOT TAXABLE")
            End If
        ElseIf ch = 2 Then
            If sal > 200000 Then
                Console.WriteLine(" GIVEN SALLARY IS TAXABLE")
            Else
                Console.WriteLine(" GIVEN SALLARY IS NOT TAXABLE")
            End If
        Else
            Console.WriteLine(" YOUR CHOICE IS WRONG ")
        End If

        Console.Read()

    End Sub

End Module
