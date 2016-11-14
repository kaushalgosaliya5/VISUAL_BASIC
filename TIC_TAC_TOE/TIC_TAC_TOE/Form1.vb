Public Class Form1

    Dim player As Boolean
    Dim cnt As Integer = 0


    Private Sub B1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B1.Click, B2.Click, B3.Click, B4.Click, B5.Click, B6.Click, B7.Click, B8.Click, B9.Click

        If Not sender.text = "" Then Exit Sub

        If player = False Then
            sender.text = "X"
            cnt += 1
        Else
            sender.TEXT = "O"
            cnt += 1
        End If

        checkwinner()
        player = Not player
    End Sub

    Sub checkwinner()
        Dim sign As Char
        Dim m As String

        If player = False Then
            sign = "X"
            m = "PLAYER 1 WIN"
        Else
            sign = "O"
            m = "PLAYER 2 WIN"
        End If

        If B1.Text = sign And B2.Text = sign And B3.Text = sign Then MsgBox(m)
        If B4.Text = sign And B5.Text = sign And B6.Text = sign Then MsgBox(m)
        If B7.Text = sign And B8.Text = sign And B9.Text = sign Then MsgBox(m)

        If B1.Text = sign And B4.Text = sign And B7.Text = sign Then MsgBox(m)
        If B2.Text = sign And B5.Text = sign And B8.Text = sign Then MsgBox(m)
        If B3.Text = sign And B6.Text = sign And B9.Text = sign Then MsgBox(m)

        If B1.Text = sign And B5.Text = sign And B9.Text = sign Then MsgBox(m)
        If B3.Text = sign And B5.Text = sign And B7.Text = sign Then MsgBox(m)


        If cnt = 9 Then
            MsgBox("game over", MsgBoxStyle.YesNo)
            If MsgBoxResult.Ok Then
                Dim frm As New Form1
                frm.Show()
                Me.Hide()
            Else
                Me.Close()
            End If
        End If
    End Sub
End Class
