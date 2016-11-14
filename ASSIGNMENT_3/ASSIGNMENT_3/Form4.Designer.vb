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
        Me.B1 = New System.Windows.Forms.Button
        Me.L1 = New System.Windows.Forms.Label
        Me.L2 = New System.Windows.Forms.Label
        Me.T1 = New System.Windows.Forms.TextBox
        Me.T2 = New System.Windows.Forms.TextBox
        Me.L3 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'B1
        '
        Me.B1.Location = New System.Drawing.Point(64, 177)
        Me.B1.Name = "B1"
        Me.B1.Size = New System.Drawing.Size(116, 34)
        Me.B1.TabIndex = 0
        Me.B1.Text = "CONCATENATION"
        Me.B1.UseVisualStyleBackColor = True
        '
        'L1
        '
        Me.L1.Location = New System.Drawing.Point(7, 33)
        Me.L1.Name = "L1"
        Me.L1.Size = New System.Drawing.Size(124, 23)
        Me.L1.TabIndex = 1
        Me.L1.Text = "ENTER FIRST NAME : : "
        '
        'L2
        '
        Me.L2.Location = New System.Drawing.Point(10, 65)
        Me.L2.Name = "L2"
        Me.L2.Size = New System.Drawing.Size(121, 23)
        Me.L2.TabIndex = 2
        Me.L2.Text = "ENTER LAST NAME : : "
        '
        'T1
        '
        Me.T1.Location = New System.Drawing.Point(137, 30)
        Me.T1.Name = "T1"
        Me.T1.Size = New System.Drawing.Size(100, 20)
        Me.T1.TabIndex = 3
        '
        'T2
        '
        Me.T2.Location = New System.Drawing.Point(137, 62)
        Me.T2.Name = "T2"
        Me.T2.Size = New System.Drawing.Size(100, 20)
        Me.T2.TabIndex = 4
        '
        'L3
        '
        Me.L3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L3.ForeColor = System.Drawing.Color.Maroon
        Me.L3.Location = New System.Drawing.Point(5, 129)
        Me.L3.Name = "L3"
        Me.L3.Size = New System.Drawing.Size(267, 45)
        Me.L3.TabIndex = 5
        Me.L3.Text = "fullname"
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.L3)
        Me.Controls.Add(Me.T2)
        Me.Controls.Add(Me.T1)
        Me.Controls.Add(Me.L2)
        Me.Controls.Add(Me.L1)
        Me.Controls.Add(Me.B1)
        Me.Name = "Form4"
        Me.Text = "Form4"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents B1 As System.Windows.Forms.Button
    Friend WithEvents L1 As System.Windows.Forms.Label
    Friend WithEvents L2 As System.Windows.Forms.Label
    Friend WithEvents T1 As System.Windows.Forms.TextBox
    Friend WithEvents T2 As System.Windows.Forms.TextBox
    Friend WithEvents L3 As System.Windows.Forms.Label
End Class
