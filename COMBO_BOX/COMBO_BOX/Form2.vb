Public Class Form2

    Private Sub B1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Binsert.Click
        If Not T1.Text = "" Then
            ListBox1.Items.Add(T1.Text)
            T1.Clear()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B1.Click
        If ListBox1.SelectedIndex > -1 Then
            ListBox2.Items.Add(ListBox1.SelectedItem)
            ListBox1.Items.Remove(ListBox1.SelectedItem)
            'ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)
        End If
    End Sub

    Private Sub B6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B6.Click
        If ListBox2.SelectedIndex > -1 Then
            ListBox1.Items.Add(ListBox2.SelectedItem)
            ListBox2.Items.Remove(ListBox2.SelectedItem)
            'ListBox2.Items.RemoveAt(ListBox2.SelectedIndex)
        End If
    End Sub

    Private Sub B3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B3.Click
        Dim i As Integer

        For i = 0 To ListBox1.Items.Count - 1
            ListBox2.Items.Add(ListBox1.Items(0))
            ListBox1.Items.RemoveAt(0)
        Next

        'ListBox1.Items.Clear()
    End Sub

    Private Sub B4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B4.Click
        Dim i As Integer

        For i = 0 To ListBox2.Items.Count - 1
            ListBox1.Items.Add(ListBox2.Items(0))
            ListBox2.Items.RemoveAt(0)
        Next
    End Sub

    Private Sub B2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B2.Click
        For i As Integer = 0 To ListBox1.SelectedItems.Count - 1
            ListBox2.Items.Add(ListBox1.SelectedItem)
            ListBox1.Items.Remove(ListBox1.SelectedItems(0))
        Next

    End Sub

    Private Sub B5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B5.Click
        For i As Integer = 0 To ListBox2.SelectedItems.Count - 1
            ListBox1.Items.Add(ListBox2.SelectedItem)
            ListBox2.Items.Remove(ListBox2.SelectedItems(0))
        Next
    End Sub
End Class