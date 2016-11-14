<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.L1 = New System.Windows.Forms.Label
        Me.T1 = New System.Windows.Forms.TextBox
        Me.B1 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'L1
        '
        Me.L1.AutoSize = True
        Me.L1.Location = New System.Drawing.Point(42, 49)
        Me.L1.Name = "L1"
        Me.L1.Size = New System.Drawing.Size(109, 13)
        Me.L1.TabIndex = 0
        Me.L1.Text = "ENTER STRING  : :  "
        '
        'T1
        '
        Me.T1.Location = New System.Drawing.Point(167, 46)
        Me.T1.Name = "T1"
        Me.T1.Size = New System.Drawing.Size(300, 20)
        Me.T1.TabIndex = 1
        '
        'B1
        '
        Me.B1.Location = New System.Drawing.Point(177, 106)
        Me.B1.Name = "B1"
        Me.B1.Size = New System.Drawing.Size(83, 36)
        Me.B1.TabIndex = 2
        Me.B1.Text = "ANALISIS"
        Me.B1.UseVisualStyleBackColor = True
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(494, 165)
        Me.Controls.Add(Me.B1)
        Me.Controls.Add(Me.T1)
        Me.Controls.Add(Me.L1)
        Me.Name = "Form4"
        Me.Text = "Form4"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents L1 As System.Windows.Forms.Label
    Friend WithEvents T1 As System.Windows.Forms.TextBox
    Friend WithEvents B1 As System.Windows.Forms.Button
End Class
