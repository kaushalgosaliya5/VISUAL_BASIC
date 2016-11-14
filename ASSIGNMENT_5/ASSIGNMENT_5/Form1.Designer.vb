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
        Me.B3 = New System.Windows.Forms.Button
        Me.B2 = New System.Windows.Forms.Button
        Me.B1 = New System.Windows.Forms.Button
        Me.L1 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'B3
        '
        Me.B3.Location = New System.Drawing.Point(176, 151)
        Me.B3.Name = "B3"
        Me.B3.Size = New System.Drawing.Size(48, 23)
        Me.B3.TabIndex = 9
        Me.B3.Text = "MAX"
        Me.B3.UseVisualStyleBackColor = True
        '
        'B2
        '
        Me.B2.Location = New System.Drawing.Point(176, 109)
        Me.B2.Name = "B2"
        Me.B2.Size = New System.Drawing.Size(54, 23)
        Me.B2.TabIndex = 8
        Me.B2.Text = "MIN"
        Me.B2.UseVisualStyleBackColor = True
        '
        'B1
        '
        Me.B1.Location = New System.Drawing.Point(170, 66)
        Me.B1.Name = "B1"
        Me.B1.Size = New System.Drawing.Size(73, 23)
        Me.B1.TabIndex = 7
        Me.B1.Text = "AVERAGE"
        Me.B1.UseVisualStyleBackColor = True
        '
        'L1
        '
        Me.L1.AutoSize = True
        Me.L1.Location = New System.Drawing.Point(41, 36)
        Me.L1.Name = "L1"
        Me.L1.Size = New System.Drawing.Size(109, 13)
        Me.L1.TabIndex = 5
        Me.L1.Text = "ENTER NUMBER  : :"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(44, 68)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 152)
        Me.TextBox1.TabIndex = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.B3)
        Me.Controls.Add(Me.B2)
        Me.Controls.Add(Me.B1)
        Me.Controls.Add(Me.L1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents B3 As System.Windows.Forms.Button
    Friend WithEvents B2 As System.Windows.Forms.Button
    Friend WithEvents B1 As System.Windows.Forms.Button
    Friend WithEvents L1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox

End Class
