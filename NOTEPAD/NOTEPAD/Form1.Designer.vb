<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.B1 = New System.Windows.Forms.Button
        Me.B2 = New System.Windows.Forms.Button
        Me.B3 = New System.Windows.Forms.Button
        Me.B4 = New System.Windows.Forms.Button
        Me.B5 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.B6 = New System.Windows.Forms.Button
        Me.FontDialog1 = New System.Windows.Forms.FontDialog
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog
        Me.B7 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.HideSelection = False
        Me.TextBox1.Location = New System.Drawing.Point(12, 12)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(424, 228)
        Me.TextBox1.TabIndex = 0
        '
        'B1
        '
        Me.B1.Location = New System.Drawing.Point(13, 247)
        Me.B1.Name = "B1"
        Me.B1.Size = New System.Drawing.Size(75, 23)
        Me.B1.TabIndex = 1
        Me.B1.Text = "BOLD"
        Me.B1.UseVisualStyleBackColor = True
        '
        'B2
        '
        Me.B2.Location = New System.Drawing.Point(94, 247)
        Me.B2.Name = "B2"
        Me.B2.Size = New System.Drawing.Size(75, 23)
        Me.B2.TabIndex = 2
        Me.B2.Text = "ITALIC"
        Me.B2.UseVisualStyleBackColor = True
        '
        'B3
        '
        Me.B3.Location = New System.Drawing.Point(175, 247)
        Me.B3.Name = "B3"
        Me.B3.Size = New System.Drawing.Size(75, 23)
        Me.B3.TabIndex = 3
        Me.B3.Text = "UNDERLINE"
        Me.B3.UseVisualStyleBackColor = True
        '
        'B4
        '
        Me.B4.Location = New System.Drawing.Point(256, 247)
        Me.B4.Name = "B4"
        Me.B4.Size = New System.Drawing.Size(75, 23)
        Me.B4.TabIndex = 4
        Me.B4.Text = "FONT"
        Me.B4.UseVisualStyleBackColor = True
        '
        'B5
        '
        Me.B5.Location = New System.Drawing.Point(337, 247)
        Me.B5.Name = "B5"
        Me.B5.Size = New System.Drawing.Size(99, 23)
        Me.B5.TabIndex = 5
        Me.B5.Text = "FONT-COLOR"
        Me.B5.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 287)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "FIND TEXT ::"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(101, 284)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(75, 20)
        Me.TextBox2.TabIndex = 7
        '
        'B6
        '
        Me.B6.Location = New System.Drawing.Point(193, 282)
        Me.B6.Name = "B6"
        Me.B6.Size = New System.Drawing.Size(47, 23)
        Me.B6.TabIndex = 8
        Me.B6.Text = "TEXT"
        Me.B6.UseVisualStyleBackColor = True
        '
        'B7
        '
        Me.B7.Location = New System.Drawing.Point(256, 282)
        Me.B7.Name = "B7"
        Me.B7.Size = New System.Drawing.Size(110, 23)
        Me.B7.TabIndex = 9
        Me.B7.Text = "BACK COLOR"
        Me.B7.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(448, 350)
        Me.Controls.Add(Me.B7)
        Me.Controls.Add(Me.B6)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.B5)
        Me.Controls.Add(Me.B4)
        Me.Controls.Add(Me.B3)
        Me.Controls.Add(Me.B2)
        Me.Controls.Add(Me.B1)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents B1 As System.Windows.Forms.Button
    Friend WithEvents B2 As System.Windows.Forms.Button
    Friend WithEvents B3 As System.Windows.Forms.Button
    Friend WithEvents B4 As System.Windows.Forms.Button
    Friend WithEvents B5 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents B6 As System.Windows.Forms.Button
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents B7 As System.Windows.Forms.Button

End Class
