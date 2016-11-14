<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form8
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
        Me.L1 = New System.Windows.Forms.Label
        Me.T1 = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'B1
        '
        Me.B1.Location = New System.Drawing.Point(78, 112)
        Me.B1.Name = "B1"
        Me.B1.Size = New System.Drawing.Size(110, 36)
        Me.B1.TabIndex = 0
        Me.B1.Text = "AREA OF CIRLE"
        Me.B1.UseVisualStyleBackColor = True
        '
        'L1
        '
        Me.L1.Location = New System.Drawing.Point(12, 42)
        Me.L1.Name = "L1"
        Me.L1.Size = New System.Drawing.Size(118, 23)
        Me.L1.TabIndex = 1
        Me.L1.Text = "ENTER RADIOUS  : : "
        '
        'T1
        '
        Me.T1.Location = New System.Drawing.Point(136, 39)
        Me.T1.Name = "T1"
        Me.T1.Size = New System.Drawing.Size(100, 20)
        Me.T1.TabIndex = 2
        '
        'Form8
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.T1)
        Me.Controls.Add(Me.L1)
        Me.Controls.Add(Me.B1)
        Me.Name = "Form8"
        Me.Text = "Form8"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents B1 As System.Windows.Forms.Button
    Friend WithEvents L1 As System.Windows.Forms.Label
    Friend WithEvents T1 As System.Windows.Forms.TextBox
End Class
