Public Class Form1

    Dim player As Boolean
    Dim rnd As Double
    Dim a As New System.Random
    Dim ans As Integer
    Dim cnt As Integer = 0

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ksl1()
    End Sub

    Private Sub B1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B1.Click, B2.Click, B3.Click, B4.Click, B5.Click, B6.Click, B7.Click, B8.Click, B9.Click

        If Not sender.text = "" Then Exit Sub

        sender.TEXT = "X"
        cnt += 1

        checkwinner()
        player = Not player

        ksl()

        checkwinner()
        cnt += 1
        If cnt = 10 Then
            MsgBox("hello")

        End If

        player = Not player

    End Sub

    Sub checkwinner()
        Dim sign As Char
        Dim m As String
        Dim res As MsgBoxResult

        If player = False Then
            sign = "X"
            m = "PLAYER 1 WIN"
        Else
            sign = "O"
            m = "PLAYER 2 WIN"
        End If

        If B1.Text = sign And B2.Text = sign And B3.Text = sign Then res = MsgBox(m & " YOU ARE RESTART THE GAME !!! ", MsgBoxStyle.YesNo, " CONFORMATION ")
        If B4.Text = sign And B5.Text = sign And B6.Text = sign Then res = MsgBox(m & " YOU ARE RESTART THE GAME !!! ", MsgBoxStyle.YesNo, " CONFORMATION ")
        If B7.Text = sign And B8.Text = sign And B9.Text = sign Then res = MsgBox(m & " YOU ARE RESTART THE GAME !!! ", MsgBoxStyle.YesNo, " CONFORMATION ")

        If B1.Text = sign And B4.Text = sign And B7.Text = sign Then res = MsgBox(m & " YOU ARE RESTART THE GAME !!! ", MsgBoxStyle.YesNo, " CONFORMATION ")
        If B2.Text = sign And B5.Text = sign And B8.Text = sign Then res = MsgBox(m & " YOU ARE RESTART THE GAME !!! ", MsgBoxStyle.YesNo, " CONFORMATION ")
        If B3.Text = sign And B6.Text = sign And B9.Text = sign Then res = MsgBox(m & " YOU ARE RESTART THE GAME !!! ", MsgBoxStyle.YesNo, " CONFORMATION ")

        If B1.Text = sign And B5.Text = sign And B9.Text = sign Then res = MsgBox(m & " YOU ARE RESTART THE GAME !!! ", MsgBoxStyle.YesNo, " CONFORMATION ")
        If B3.Text = sign And B5.Text = sign And B7.Text = sign Then res = MsgBox(m & " YOU ARE RESTART THE GAME !!! ", MsgBoxStyle.YesNo, " CONFORMATION ")

        If res = MsgBoxResult.Yes Then
            clr()
        ElseIf res = MsgBoxResult.No Then
            Me.Close()
        End If

    End Sub

    Sub clr()
        B1.ResetText()
        B2.ResetText()
        B3.ResetText()
        B4.ResetText()
        B5.ResetText()
        B6.ResetText()
        B7.ResetText()
        B8.ResetText()
        B9.ResetText()

        Me.ksl1()
        cnt = 0
        'player = False
    End Sub

    Sub ksl1()
        If (a.Next Mod 10) > 4 Then
            ans = 1
        ElseIf (a.Next Mod 10) > 7 Then
            ans = 2
        ElseIf (a.Next Mod 10) > 9 Then
            ans = 3
        Else
            ans = 4
        End If
    End Sub

    Sub ksl()

        If B1.Text = "O" And B2.Text = "O" And B3.Text = "" Then
            B3.Text = "O"
            Exit Sub
        End If

        If B1.Text = "O" And B2.Text = "" And B3.Text = "O" Then
            B2.Text = "O"
            Exit Sub
        End If

        If B1.Text = "" And B2.Text = "O" And B3.Text = "0" Then
            B1.Text = "O"
            Exit Sub
        End If


        If B4.Text = "O" And B5.Text = "O" And B6.Text = "" Then
            B6.Text = "O"
            Exit Sub
        End If

        If B4.Text = "O" And B5.Text = "" And B6.Text = "O" Then
            B5.Text = "O"
            Exit Sub
        End If

        If B4.Text = "" And B5.Text = "O" And B6.Text = "O" Then
            B4.Text = "O"
            Exit Sub
        End If

        If B7.Text = "O" And B8.Text = "O" And B9.Text = "" Then
            B9.Text = "O"
            Exit Sub
        End If

        If B7.Text = "O" And B8.Text = "" And B9.Text = "O" Then
            B8.Text = "O"
            Exit Sub
        End If

        If B7.Text = "" And B8.Text = "O" And B9.Text = "" Then
            B7.Text = "O"
            Exit Sub
        End If

        If B1.Text = "O" And B4.Text = "O" And B7.Text = "" Then
            B7.Text = "O"
            Exit Sub
        End If

        If B1.Text = "O" And B4.Text = "" And B7.Text = "O" Then
            B4.Text = "O"
            Exit Sub
        End If

        If B1.Text = "" And B4.Text = "O" And B7.Text = "O" Then
            B1.Text = "O"
            Exit Sub
        End If

        If B2.Text = "O" And B5.Text = "O" And B8.Text = "" Then
            B8.Text = "O"
            Exit Sub
        End If

        If B2.Text = "O" And B5.Text = "" And B8.Text = "O" Then
            B5.Text = "O"
            Exit Sub
        End If
        If B2.Text = "" And B5.Text = "O" And B8.Text = "O" Then
            B2.Text = "O"
            Exit Sub
        End If

        If B3.Text = "O" And B6.Text = "O" And B9.Text = "" Then
            B9.Text = "O"
            Exit Sub
        End If
        If B3.Text = "O" And B6.Text = "" And B9.Text = "O" Then
            B6.Text = "O"
            Exit Sub
        End If
        If B3.Text = "" And B6.Text = "O" And B9.Text = "" Then
            B3.Text = "O"
            Exit Sub
        End If

        If B1.Text = "O" And B5.Text = "O" And B9.Text = "" Then
            B9.Text = "O"
            Exit Sub
        End If
        If B1.Text = "O" And B5.Text = "" And B9.Text = "O" Then
            B5.Text = "O"
            Exit Sub
        End If
        If B1.Text = "" And B5.Text = "O" And B9.Text = "O" Then
            B1.Text = "O"
            Exit Sub
        End If

        If B3.Text = "O" And B5.Text = "O" And B7.Text = "" Then
            B7.Text = "O"
            Exit Sub
        End If
        If B3.Text = "O" And B5.Text = "" And B7.Text = "O" Then
            B5.Text = "O"
            Exit Sub
        End If
        If B3.Text = "" And B5.Text = "O" And B7.Text = "O" Then
            B3.Text = "O"
            Exit Sub
        End If

        If B1.Text = "X" And B2.Text = "X" And B3.Text = "" Then
            B3.Text = "O"
            Exit Sub
        End If

        If B1.Text = "X" And B2.Text = "" And B3.Text = "X" Then
            B2.Text = "O"
            Exit Sub
        End If

        If B1.Text = "" And B2.Text = "X" And B3.Text = "X" Then
            B1.Text = "O"
            Exit Sub
        End If


        If B4.Text = "X" And B5.Text = "X" And B6.Text = "" Then
            B6.Text = "O"
            Exit Sub
        End If
        If B4.Text = "X" And B5.Text = "" And B6.Text = "X" Then
            B5.Text = "O"
            Exit Sub
        End If
        If B4.Text = "" And B5.Text = "X" And B6.Text = "X" Then
            B4.Text = "O"
            Exit Sub
        End If


        If B7.Text = "X" And B8.Text = "X" And B9.Text = "" Then
            B9.Text = "O"
            Exit Sub
        End If
        If B7.Text = "X" And B8.Text = "" And B9.Text = "X" Then
            B8.Text = "O"
            Exit Sub
        End If
        If B7.Text = "" And B8.Text = "X" And B9.Text = "X" Then
            B7.Text = "O"
            Exit Sub
        End If


        If B1.Text = "X" And B5.Text = "X" And B9.Text = "" Then
            B9.Text = "O"
            Exit Sub
        End If
        If B1.Text = "X" And B5.Text = "" And B9.Text = "X" Then
            B5.Text = "O"
            Exit Sub
        End If
        If B1.Text = "" And B5.Text = "X" And B9.Text = "X" Then
            B1.Text = "O"
            Exit Sub
        End If

        If B3.Text = "X" And B5.Text = "X" And B7.Text = "" Then
            B7.Text = "O"
            Exit Sub
        End If
        If B3.Text = "X" And B5.Text = "" And B7.Text = "X" Then
            B5.Text = "O"
            Exit Sub
        End If
        If B3.Text = "" And B5.Text = "X" And B7.Text = "X" Then
            B3.Text = "O"
            Exit Sub
        End If


        If B1.Text = "X" And B4.Text = "X" And B7.Text = "" Then
            B7.Text = "O"
            Exit Sub
        End If
        If B1.Text = "X" And B4.Text = "" And B7.Text = "X" Then
            B4.Text = "O"
            Exit Sub
        End If
        If B1.Text = "" And B4.Text = "X" And B7.Text = "X" Then
            B1.Text = "O"
            Exit Sub
        End If


        If B2.Text = "X" And B5.Text = "X" And B8.Text = "" Then
            B8.Text = "O"
            Exit Sub
        End If
        If B2.Text = "X" And B5.Text = "" And B8.Text = "X" Then
            B5.Text = "O"
            Exit Sub
        End If
        If B2.Text = "" And B5.Text = "X" And B8.Text = "X" Then
            B2.Text = "O"
            Exit Sub
        End If


        If B3.Text = "X" And B6.Text = "X" And B9.Text = "" Then
            B9.Text = "O"
            Exit Sub
        End If
        If B3.Text = "X" And B6.Text = "" And B9.Text = "X" Then
            B6.Text = "O"
            Exit Sub
        End If
        If B3.Text = "" And B6.Text = "X" And B9.Text = "X" Then
            B3.Text = "O"
            Exit Sub
        End If

        If ans = 1 Then

            If B1.Text = "" Then
                B1.Text = "O"
                Exit Sub
            End If

            If B2.Text = "" Then
                B2.Text = "O"
                Exit Sub
            End If

            If B3.Text = "" Then
                B3.Text = "O"
                Exit Sub
            End If

            If B4.Text = "" Then
                B4.Text = "O"
                Exit Sub
            End If

            If B5.Text = "" Then
                B5.Text = "O"
                Exit Sub
            End If

            If B6.Text = "" Then
                B6.Text = "O"
                Exit Sub
            End If

            If B7.Text = "" Then
                B7.Text = "O"
                Exit Sub
            End If

            If B8.Text = "" Then
                B8.Text = "O"
                Exit Sub
            End If

            If B9.Text = "" Then
                B9.Text = "O"
                Exit Sub
            End If

        End If
        If ans = 2 Then

            If B9.Text = "" Then
                B9.Text = "O"
                Exit Sub
            End If

            If B1.Text = "" Then
                B1.Text = "O"
                Exit Sub
            End If

            If B3.Text = "" Then
                B3.Text = "O"
                Exit Sub
            End If

            If B7.Text = "" Then
                B7.Text = "O"
                Exit Sub
            End If

            If B5.Text = "" Then
                B5.Text = "O"
                Exit Sub
            End If

            If B6.Text = "" Then
                B6.Text = "O"
                Exit Sub
            End If

            If B4.Text = "" Then
                B4.Text = "O"
                Exit Sub
            End If

            If B8.Text = "" Then
                B8.Text = "O"
                Exit Sub
            End If

            If B2.Text = "" Then
                B2.Text = "O"
                Exit Sub
            End If
        End If

        If ans = 3 Then

            If B5.Text = "" Then
                B5.Text = "O"
                Exit Sub
            End If

            If B9.Text = "" Then
                B9.Text = "O"
                Exit Sub
            End If

            If B7.Text = "" Then
                B7.Text = "O"
                Exit Sub
            End If

            If B4.Text = "" Then
                B4.Text = "O"
                Exit Sub
            End If

            If B3.Text = "" Then
                B3.Text = "O"
                Exit Sub
            End If

            If B2.Text = "" Then
                B2.Text = "O"
                Exit Sub
            End If

            If B6.Text = "" Then
                B6.Text = "O"
                Exit Sub
            End If

            If B1.Text = "" Then
                B1.Text = "O"
                Exit Sub
            End If

            If B8.Text = "" Then
                B8.Text = "O"
                Exit Sub
            End If
        End If
        If ans = 4 Then

            If B3.Text = "" Then
                B3.Text = "O"
                Exit Sub
            End If

            If B7.Text = "" Then
                B7.Text = "O"
                Exit Sub
            End If

            If B6.Text = "" Then
                B6.Text = "O"
                Exit Sub
            End If

            If B1.Text = "" Then
                B1.Text = "O"
                Exit Sub
            End If

            If B9.Text = "" Then
                B9.Text = "O"
                Exit Sub
            End If

            If B5.Text = "" Then
                B5.Text = "O"
                Exit Sub
            End If

            If B4.Text = "" Then
                B4.Text = "O"
                Exit Sub
            End If

            If B2.Text = "" Then
                B2.Text = "O"
                Exit Sub
            End If

            If B8.Text = "" Then
                B8.Text = "O"
                Exit Sub
            End If
        End If


        MsgBox("DROW")
        clr()

    End Sub

End Class
