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
        Me.B1 = New System.Windows.Forms.Button
        Me.T1 = New System.Windows.Forms.TextBox
        Me.L2 = New System.Windows.Forms.Label
        Me.L1 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'B1
        '
        Me.B1.Location = New System.Drawing.Point(80, 128)
        Me.B1.Name = "B1"
        Me.B1.Size = New System.Drawing.Size(75, 23)
        Me.B1.TabIndex = 0
        Me.B1.Text = "CLICK"
        Me.B1.UseVisualStyleBackColor = True
        '
        'T1
        '
        Me.T1.Cursor = System.Windows.Forms.Cursors.Cross
        Me.T1.Location = New System.Drawing.Point(154, 34)
        Me.T1.Name = "T1"
        Me.T1.Size = New System.Drawing.Size(118, 20)
        Me.T1.TabIndex = 1
        '
        'L2
        '
        Me.L2.Location = New System.Drawing.Point(102, 87)
        Me.L2.Name = "L2"
        Me.L2.Size = New System.Drawing.Size(65, 26)
        Me.L2.TabIndex = 2
        Me.L2.Text = "NAME"
        '
        'L1
        '
        Me.L1.AutoSize = True
        Me.L1.Location = New System.Drawing.Point(21, 37)
        Me.L1.Name = "L1"
        Me.L1.Size = New System.Drawing.Size(127, 13)
        Me.L1.TabIndex = 3
        Me.L1.Text = "ENTER YOUR NAME : : "
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.L1)
        Me.Controls.Add(Me.L2)
        Me.Controls.Add(Me.T1)
        Me.Controls.Add(Me.B1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents B1 As System.Windows.Forms.Button
    Friend WithEvents T1 As System.Windows.Forms.TextBox
    Friend WithEvents L2 As System.Windows.Forms.Label
    Friend WithEvents L1 As System.Windows.Forms.Label

End Class
