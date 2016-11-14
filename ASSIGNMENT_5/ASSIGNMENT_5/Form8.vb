Public Class Form8

    Private Sub CUToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CUToolStripMenuItem.Click
        RichTextBox1.Cut()
    End Sub

    Private Sub FORM1ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FORM1ToolStripMenuItem.Click
        RichTextBox1.Text = ""
        RichTextBox1.Focus()
    End Sub

    Private Sub OPENToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OPENToolStripMenuItem.Click
        OpenFileDialog1.Filter = " ALL RICH TEXT FILTER|*.rtf|ALL TEXT FILES|*.txt|ALL FILES|*.*"

        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            RichTextBox1.LoadFile(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub SAVEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SAVEToolStripMenuItem.Click
        SaveFileDialog1.Filter = " ALL RICH TEXT FILTER |*.rtf|ALL TEXT FILES|*.txt|ALL FILES|*.*"

        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            RichTextBox1.SaveFile(SaveFileDialog1.FileName)
        End If
    End Sub

    Private Sub EXITToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EXITToolStripMenuItem.Click
        Application.Exit()

    End Sub

    Private Sub COPPYToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles COPPYToolStripMenuItem.Click
        RichTextBox1.Copy()
    End Sub

    Private Sub PASTEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PASTEToolStripMenuItem.Click
        RichTextBox1.Paste()
    End Sub

    Private Sub COLORToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles COLORToolStripMenuItem.Click
        RichTextBox1.SelectAll()
    End Sub

    Private Sub UNDOToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UNDOToolStripMenuItem.Click
        If RichTextBox1.CanUndo Then
            RichTextBox1.Undo()
        End If
    End Sub

    Private Sub REDOToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REDOToolStripMenuItem.Click
        If RichTextBox1.CanRedo Then
            RichTextBox1.Redo()
        End If
    End Sub

    Private Sub FONTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FONTToolStripMenuItem.Click
        If FontDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            RichTextBox1.SelectionFont = FontDialog1.Font
        End If
    End Sub

    Private Sub COLORToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles COLORToolStripMenuItem1.Click
        If ColorDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            RichTextBox1.SelectionColor = ColorDialog1.Color
        End If
    End Sub


    Private Sub CUTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CUTToolStripMenuItem.Click
        RichTextBox1.Cut()
    End Sub

    Private Sub COPYToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles COPYToolStripMenuItem.Click
        RichTextBox1.Copy()
    End Sub

    Private Sub PESTEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PESTEToolStripMenuItem.Click
        RichTextBox1.Paste()
    End Sub

    Private Sub EXITToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EXITToolStripMenuItem1.Click
        Application.Exit()
    End Sub
End Class