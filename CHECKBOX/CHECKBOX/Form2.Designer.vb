<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FILEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NEWToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OPENToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SAVEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SAVEASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator
        Me.EXITToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EDITToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.COPPYToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PASTEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator
        Me.SELECTALLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator
        Me.UNDOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.REDOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator
        Me.FINDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FORMATEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FONTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.COLORToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripSeparator
        Me.BOLDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ITALICToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.UNDERLINEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CUTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.COPYToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FONTToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.COLORToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.FontDialog1 = New System.Windows.Forms.FontDialog
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog
        Me.MenuStrip1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FILEToolStripMenuItem, Me.EDITToolStripMenuItem, Me.FORMATEToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(743, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FILEToolStripMenuItem
        '
        Me.FILEToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NEWToolStripMenuItem, Me.OPENToolStripMenuItem, Me.SAVEToolStripMenuItem, Me.SAVEASToolStripMenuItem, Me.ToolStripMenuItem1, Me.EXITToolStripMenuItem})
        Me.FILEToolStripMenuItem.Name = "FILEToolStripMenuItem"
        Me.FILEToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.FILEToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.FILEToolStripMenuItem.Text = "&FILE"
        '
        'NEWToolStripMenuItem
        '
        Me.NEWToolStripMenuItem.Name = "NEWToolStripMenuItem"
        Me.NEWToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NEWToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.NEWToolStripMenuItem.Text = "&NEW"
        '
        'OPENToolStripMenuItem
        '
        Me.OPENToolStripMenuItem.Name = "OPENToolStripMenuItem"
        Me.OPENToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.OPENToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.OPENToolStripMenuItem.Text = "&OPEN"
        '
        'SAVEToolStripMenuItem
        '
        Me.SAVEToolStripMenuItem.Name = "SAVEToolStripMenuItem"
        Me.SAVEToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SAVEToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.SAVEToolStripMenuItem.Text = "&SAVE"
        '
        'SAVEASToolStripMenuItem
        '
        Me.SAVEASToolStripMenuItem.Name = "SAVEASToolStripMenuItem"
        Me.SAVEASToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.SAVEASToolStripMenuItem.Text = "SAVE AS"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(145, 6)
        '
        'EXITToolStripMenuItem
        '
        Me.EXITToolStripMenuItem.Name = "EXITToolStripMenuItem"
        Me.EXITToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.EXITToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.EXITToolStripMenuItem.Text = "&EXIT"
        '
        'EDITToolStripMenuItem
        '
        Me.EDITToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CToolStripMenuItem, Me.COPPYToolStripMenuItem, Me.PASTEToolStripMenuItem, Me.ToolStripMenuItem2, Me.SELECTALLToolStripMenuItem, Me.ToolStripMenuItem3, Me.UNDOToolStripMenuItem, Me.REDOToolStripMenuItem, Me.ToolStripMenuItem4, Me.FINDToolStripMenuItem})
        Me.EDITToolStripMenuItem.Name = "EDITToolStripMenuItem"
        Me.EDITToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.EDITToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.EDITToolStripMenuItem.Text = "&EDIT"
        '
        'CToolStripMenuItem
        '
        Me.CToolStripMenuItem.Name = "CToolStripMenuItem"
        Me.CToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.U), System.Windows.Forms.Keys)
        Me.CToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.CToolStripMenuItem.Text = "C&UT"
        '
        'COPPYToolStripMenuItem
        '
        Me.COPPYToolStripMenuItem.Name = "COPPYToolStripMenuItem"
        Me.COPPYToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.COPPYToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.COPPYToolStripMenuItem.Text = "&COPPY"
        '
        'PASTEToolStripMenuItem
        '
        Me.PASTEToolStripMenuItem.Name = "PASTEToolStripMenuItem"
        Me.PASTEToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.PASTEToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.PASTEToolStripMenuItem.Text = "&PASTE"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(175, 6)
        '
        'SELECTALLToolStripMenuItem
        '
        Me.SELECTALLToolStripMenuItem.Name = "SELECTALLToolStripMenuItem"
        Me.SELECTALLToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.SELECTALLToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.SELECTALLToolStripMenuItem.Text = "SELECT &ALL"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(175, 6)
        '
        'UNDOToolStripMenuItem
        '
        Me.UNDOToolStripMenuItem.Name = "UNDOToolStripMenuItem"
        Me.UNDOToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.U), System.Windows.Forms.Keys)
        Me.UNDOToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.UNDOToolStripMenuItem.Text = "&UNDO"
        '
        'REDOToolStripMenuItem
        '
        Me.REDOToolStripMenuItem.Name = "REDOToolStripMenuItem"
        Me.REDOToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.REDOToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.REDOToolStripMenuItem.Text = "&REDO"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(175, 6)
        '
        'FINDToolStripMenuItem
        '
        Me.FINDToolStripMenuItem.Name = "FINDToolStripMenuItem"
        Me.FINDToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.FINDToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.FINDToolStripMenuItem.Text = "&FIND"
        '
        'FORMATEToolStripMenuItem
        '
        Me.FORMATEToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FONTToolStripMenuItem, Me.COLORToolStripMenuItem, Me.ToolStripMenuItem5, Me.BOLDToolStripMenuItem, Me.ITALICToolStripMenuItem, Me.UNDERLINEToolStripMenuItem})
        Me.FORMATEToolStripMenuItem.Name = "FORMATEToolStripMenuItem"
        Me.FORMATEToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.FORMATEToolStripMenuItem.Size = New System.Drawing.Size(73, 20)
        Me.FORMATEToolStripMenuItem.Text = "F&ORMATE"
        '
        'FONTToolStripMenuItem
        '
        Me.FONTToolStripMenuItem.Name = "FONTToolStripMenuItem"
        Me.FONTToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.FONTToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.FONTToolStripMenuItem.Text = "FON&T"
        '
        'COLORToolStripMenuItem
        '
        Me.COLORToolStripMenuItem.Name = "COLORToolStripMenuItem"
        Me.COLORToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.COLORToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.COLORToolStripMenuItem.Text = "&COLOR"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(173, 6)
        '
        'BOLDToolStripMenuItem
        '
        Me.BOLDToolStripMenuItem.Name = "BOLDToolStripMenuItem"
        Me.BOLDToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
        Me.BOLDToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.BOLDToolStripMenuItem.Text = "&BOLD"
        '
        'ITALICToolStripMenuItem
        '
        Me.ITALICToolStripMenuItem.Name = "ITALICToolStripMenuItem"
        Me.ITALICToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.I), System.Windows.Forms.Keys)
        Me.ITALICToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.ITALICToolStripMenuItem.Text = "&ITALIC"
        '
        'UNDERLINEToolStripMenuItem
        '
        Me.UNDERLINEToolStripMenuItem.Name = "UNDERLINEToolStripMenuItem"
        Me.UNDERLINEToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
        Me.UNDERLINEToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.UNDERLINEToolStripMenuItem.Text = "UNDER&LINE"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBox1.Location = New System.Drawing.Point(0, 24)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(743, 402)
        Me.RichTextBox1.TabIndex = 1
        Me.RichTextBox1.Text = ""
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CUTToolStripMenuItem, Me.COPYToolStripMenuItem, Me.FONTToolStripMenuItem1, Me.COLORToolStripMenuItem1})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(153, 114)
        '
        'CUTToolStripMenuItem
        '
        Me.CUTToolStripMenuItem.Name = "CUTToolStripMenuItem"
        Me.CUTToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CUTToolStripMenuItem.Text = "CUT"
        '
        'COPYToolStripMenuItem
        '
        Me.COPYToolStripMenuItem.Name = "COPYToolStripMenuItem"
        Me.COPYToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.COPYToolStripMenuItem.Text = "COPY"
        '
        'FONTToolStripMenuItem1
        '
        Me.FONTToolStripMenuItem1.Name = "FONTToolStripMenuItem1"
        Me.FONTToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.FONTToolStripMenuItem1.Text = "FONT"
        '
        'COLORToolStripMenuItem1
        '
        Me.COLORToolStripMenuItem1.Name = "COLORToolStripMenuItem1"
        Me.COLORToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.COLORToolStripMenuItem1.Text = "COLOR"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(743, 426)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FILEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EDITToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FORMATEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NEWToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OPENToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SAVEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SAVEASToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents EXITToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents COPPYToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PASTEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SELECTALLToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents UNDOToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents REDOToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents FINDToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FONTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents COLORToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BOLDToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ITALICToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UNDERLINEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CUTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents COPYToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FONTToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents COLORToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
End Class
