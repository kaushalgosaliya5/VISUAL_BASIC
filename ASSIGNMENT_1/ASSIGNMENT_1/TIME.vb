Module TIME

    Sub main()

        Dim hr, sec As Integer

        Console.WriteLine(" ENTER TOTAL SECONDS :: ")
        sec = Console.ReadLine

        If (sec >= 60) Then
            hr = sec / 60
            sec = sec Mod 60
        End If

        Console.WriteLine(" HR :: SEC IS :: " & hr & " :: " & sec)

        Console.Read()
    End Sub
End Module
