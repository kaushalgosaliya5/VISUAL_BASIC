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
        Me.T1 = New System.Windows.Forms.TextBox
        Me.T2 = New System.Windows.Forms.TextBox
        Me.T3 = New System.Windows.Forms.TextBox
        Me.T4 = New System.Windows.Forms.TextBox
        Me.R1 = New System.Windows.Forms.RadioButton
        Me.R2 = New System.Windows.Forms.RadioButton
        Me.R3 = New System.Windows.Forms.RadioButton
        Me.Button1 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'T1
        '
        Me.T1.Location = New System.Drawing.Point(66, 12)
        Me.T1.Name = "T1"
        Me.T1.Size = New System.Drawing.Size(100, 20)
        Me.T1.TabIndex = 0
        '
        'T2
        '
        Me.T2.Location = New System.Drawing.Point(66, 38)
        Me.T2.Name = "T2"
        Me.T2.Size = New System.Drawing.Size(100, 20)
        Me.T2.TabIndex = 1
        '
        'T3
        '
        Me.T3.Location = New System.Drawing.Point(66, 64)
        Me.T3.Name = "T3"
        Me.T3.Size = New System.Drawing.Size(100, 20)
        Me.T3.TabIndex = 2
        '
        'T4
        '
        Me.T4.Location = New System.Drawing.Point(66, 90)
        Me.T4.Name = "T4"
        Me.T4.Size = New System.Drawing.Size(100, 20)
        Me.T4.TabIndex = 3
        '
        'R1
        '
        Me.R1.AutoSize = True
        Me.R1.Location = New System.Drawing.Point(66, 129)
        Me.R1.Name = "R1"
        Me.R1.Size = New System.Drawing.Size(51, 17)
        Me.R1.TabIndex = 4
        Me.R1.TabStop = True
        Me.R1.Text = "TWO"
        Me.R1.UseVisualStyleBackColor = True
        '
        'R2
        '
        Me.R2.AutoSize = True
        Me.R2.Location = New System.Drawing.Point(66, 153)
        Me.R2.Name = "R2"
        Me.R2.Size = New System.Drawing.Size(62, 17)
        Me.R2.TabIndex = 5
        Me.R2.TabStop = True
        Me.R2.Text = "THREE"
        Me.R2.UseVisualStyleBackColor = True
        '
        'R3
        '
        Me.R3.AutoSize = True
        Me.R3.Location = New System.Drawing.Point(66, 177)
        Me.R3.Name = "R3"
        Me.R3.Size = New System.Drawing.Size(55, 17)
        Me.R3.TabIndex = 6
        Me.R3.TabStop = True
        Me.R3.Text = "FOUR"
        Me.R3.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(56, 229)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(126, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "CALCULATE"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(246, 264)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.R3)
        Me.Controls.Add(Me.R2)
        Me.Controls.Add(Me.R1)
        Me.Controls.Add(Me.T4)
        Me.Controls.Add(Me.T3)
        Me.Controls.Add(Me.T2)
        Me.Controls.Add(Me.T1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents T1 As System.Windows.Forms.TextBox
    Friend WithEvents T2 As System.Windows.Forms.TextBox
    Friend WithEvents T3 As System.Windows.Forms.TextBox
    Friend WithEvents T4 As System.Windows.Forms.TextBox
    Friend WithEvents R1 As System.Windows.Forms.RadioButton
    Friend WithEvents R2 As System.Windows.Forms.RadioButton
    Friend WithEvents R3 As System.Windows.Forms.RadioButton
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
