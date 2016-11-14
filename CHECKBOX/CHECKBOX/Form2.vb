Public Class Form2

    Private Sub NEWToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NEWToolStripMenuItem.Click
        RichTextBox1.Text = ""
        RichTextBox1.Focus()
    End Sub

    Private Sub OPENToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OPENToolStripMenuItem.Click
        OpenFileDialog1.Filter = "ALL RICH TEXT FILES|*.rtf|ALL TEXT FILES|*.txt|ALL FILES|*.*"

        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            RichTextBox1.LoadFile(OpenFileDialog1.FileName)
        End If

    End Sub

    Private Sub SAVEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SAVEToolStripMenuItem.Click
        SaveFileDialog1.Filter = " ALL RICH TEXT FILES|*.rtf|ALL TEXT FILES|*.txt|ALL FILES|*.*"

        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            RichTextBox1.SaveFile(SaveFileDialog1.FileName)
        End If
    End Sub

    Private Sub EXITToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EXITToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub CToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CToolStripMenuItem.Click
        RichTextBox1.Cut()

    End Sub

    Private Sub COPPYToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles COPPYToolStripMenuItem.Click
        RichTextBox1.Copy()
    End Sub

    Private Sub PASTEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PASTEToolStripMenuItem.Click
        RichTextBox1.Paste()
    End Sub

    Private Sub SELECTALLToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SELECTALLToolStripMenuItem.Click
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

    Private Sub COLORToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles COLORToolStripMenuItem.Click
        If ColorDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            RichTextBox1.SelectionColor = ColorDialog1.Color
        End If
    End Sub

    Private Sub BOLDToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BOLDToolStripMenuItem.Click
        Dim fnt As New Font(RichTextBox1.SelectionFont, FontStyle.Bold)
        RichTextBox1.SelectionFont = fnt
    End Sub

    Private Sub ITALICToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ITALICToolStripMenuItem.Click
        Dim fnt As New Font(RichTextBox1.SelectionFont, FontStyle.Italic)
        RichTextBox1.SelectionFont = fnt

    End Sub

    Private Sub UNDERLINEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UNDERLINEToolStripMenuItem.Click
        Dim fnt As New Font(RichTextBox1.SelectionFont, FontStyle.Underline)
        RichTextBox1.SelectionFont = fnt
    End Sub

    Private Sub SAVEASToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SAVEASToolStripMenuItem.Click

    End Sub

    Private Sub RichTextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RichTextBox1.TextChanged

    End Sub

    Private Sub CUTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CUTToolStripMenuItem.Click
        RichTextBox1.Cut()

    End Sub
End Class