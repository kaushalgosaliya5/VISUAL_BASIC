Module Module1

    Sub Main()

        Dim yr As Integer

        Console.WriteLine(" ENTER YEAR :: ")
        yr = Console.ReadLine

        If yr Mod 100 = 0 Then
            ' CENTURY YEAR
            If yr Mod 400 = 0 Then
                Console.WriteLine(" LEAP YEAR ")
            Else
                Console.WriteLine(" NOT LEAP YEAR ")
            End If

        Else
            ' NOT CENTURY YEAR
            If yr Mod 4 = 0 Then
                Console.WriteLine(" LEAP YEAR ")
            Else
                Console.WriteLine(" NOT LEAP YEAR ")
            End If

        End If

        Console.Read()

    End Sub

End Module
