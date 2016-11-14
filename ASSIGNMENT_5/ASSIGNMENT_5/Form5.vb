Public Class Form5

    Private Sub OPENToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OPENToolStripMenuItem.Click

        OpenFileDialog1.Filter = "all Rich Text Files (*.rtf)|*.rtf|ALL TEXT FILES (*.txt)|*.txt|ALL FILE (*.*)|*.*"

        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            RichTextBox1.LoadFile(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub CLOSEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CLOSEToolStripMenuItem.Click

        Me.Close()

    End Sub

    Private Sub EXITToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EXITToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub TILEHORIZONTALToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TILEHORIZONTALToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub TILEVERTICALToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TILEVERTICALToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)

    End Sub

    Private Sub CASCADEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CASCADEToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)

    End Sub

    Private Sub ARRANGEICONSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ARRANGEICONSToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.ArrangeIcons)

    End Sub

    Private Sub FILEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FILEToolStripMenuItem.Click

    End Sub
End Class