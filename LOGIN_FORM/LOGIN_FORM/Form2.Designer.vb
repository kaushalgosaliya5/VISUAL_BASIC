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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FORM1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FORM1ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.FORM2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator
        Me.EXITToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.WINDOWSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TileHorizontalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CascadeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator
        Me.ArrangeAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FORM1ToolStripMenuItem, Me.WINDOWSToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(475, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FORM1ToolStripMenuItem
        '
        Me.FORM1ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FORM1ToolStripMenuItem1, Me.FORM2ToolStripMenuItem, Me.ToolStripMenuItem1, Me.EXITToolStripMenuItem})
        Me.FORM1ToolStripMenuItem.Name = "FORM1ToolStripMenuItem"
        Me.FORM1ToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.FORM1ToolStripMenuItem.Text = "FORMS"
        '
        'FORM1ToolStripMenuItem1
        '
        Me.FORM1ToolStripMenuItem1.Name = "FORM1ToolStripMenuItem1"
        Me.FORM1ToolStripMenuItem1.Size = New System.Drawing.Size(116, 22)
        Me.FORM1ToolStripMenuItem1.Text = "FORM 1"
        '
        'FORM2ToolStripMenuItem
        '
        Me.FORM2ToolStripMenuItem.Name = "FORM2ToolStripMenuItem"
        Me.FORM2ToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.FORM2ToolStripMenuItem.Text = "FORM 2"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(113, 6)
        '
        'EXITToolStripMenuItem
        '
        Me.EXITToolStripMenuItem.Name = "EXITToolStripMenuItem"
        Me.EXITToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.EXITToolStripMenuItem.Text = "EXIT"
        '
        'WINDOWSToolStripMenuItem
        '
        Me.WINDOWSToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TileHorizontalToolStripMenuItem, Me.TileToolStripMenuItem, Me.CascadeToolStripMenuItem, Me.ToolStripMenuItem2, Me.ArrangeAllToolStripMenuItem})
        Me.WINDOWSToolStripMenuItem.Name = "WINDOWSToolStripMenuItem"
        Me.WINDOWSToolStripMenuItem.Size = New System.Drawing.Size(76, 20)
        Me.WINDOWSToolStripMenuItem.Text = "WINDOWS"
        '
        'TileHorizontalToolStripMenuItem
        '
        Me.TileHorizontalToolStripMenuItem.Name = "TileHorizontalToolStripMenuItem"
        Me.TileHorizontalToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.TileHorizontalToolStripMenuItem.Text = "Tile Horizontal"
        '
        'TileToolStripMenuItem
        '
        Me.TileToolStripMenuItem.Name = "TileToolStripMenuItem"
        Me.TileToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.TileToolStripMenuItem.Text = "Tile Virticle"
        '
        'CascadeToolStripMenuItem
        '
        Me.CascadeToolStripMenuItem.Name = "CascadeToolStripMenuItem"
        Me.CascadeToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.CascadeToolStripMenuItem.Text = "Cascade"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(148, 6)
        '
        'ArrangeAllToolStripMenuItem
        '
        Me.ArrangeAllToolStripMenuItem.Name = "ArrangeAllToolStripMenuItem"
        Me.ArrangeAllToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.ArrangeAllToolStripMenuItem.Text = "Arrange All"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(475, 330)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Form2"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FORM1ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FORM1ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FORM2ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents EXITToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WINDOWSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TileHorizontalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CascadeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ArrangeAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
