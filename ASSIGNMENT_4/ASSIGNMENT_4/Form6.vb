Public Class Form6

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles T1.KeyPress
        If Not e.KeyChar Like "[0-9 .]" Then e.Handled = True

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Not IsNumeric(T1.Text) Then
            MsgBox(" YOU HAVE WRONG NUMBER ENTER ")
            T1.Clear()
            T1.Focus()
            Exit Sub
        End If

        Dim tax As Integer
        Dim sal As Integer = CInt(T1.Text) * 12

        If sal < 50000 Then
            tax = 0
        ElseIf sal >= 50000 And sal < 60000 Then
            tax = sal * 0.1
        ElseIf sal >= 60000 And sal < 150000 Then
            tax = sal * 0.2
        ElseIf sal >= 150000 Then
            tax = sal * 0.3
        End If

        Label3.Text = " ANUAL SALLARY IS :: " & CInt(T1.Text) * 12 - tax


    End Sub

    Private Sub Form6_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class