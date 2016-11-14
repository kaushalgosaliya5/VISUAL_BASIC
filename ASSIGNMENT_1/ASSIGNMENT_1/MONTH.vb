Module MONTH

    Sub main()

        Dim x As Integer

        Console.Write(" ENTER ANY MONTH NUMBER  ( 1 TO 5 ) :: ")
        x = Console.ReadLine

        Console.Write(" YOUR SELECT MONTH IS :: ")

        Select Case x
            Case 1
                Console.Write(" JANUARY ")
            Case 2
                Console.Write(" FEBRUARY ")
            Case 3
                Console.Write(" MARCH ")
            Case 4
                Console.Write(" APRIL ")
            Case 5
                Console.Write(" MAY ")
            Case Is > 6
                Console.Write(" WRONG ENTER ")
        End Select

        Console.Read()

    End Sub

End Module
