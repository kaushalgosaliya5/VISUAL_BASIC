Public Class Form2

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click

        ' TEXTBOX ON NOT ANY WRITE ACTION

        TextBox1.Enabled = True

        'ON BUTTON CLICK TO TEXTBOX IS NOT DISPLAY

        TextBox1.Visible = Not TextBox1.Visible

    End Sub

End Class