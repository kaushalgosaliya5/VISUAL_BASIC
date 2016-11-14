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
        Me.L1 = New System.Windows.Forms.Label
        Me.T1 = New System.Windows.Forms.TextBox
        Me.B1 = New System.Windows.Forms.Button
        Me.Rcelsius = New System.Windows.Forms.RadioButton
        Me.Rfehrenheit = New System.Windows.Forms.RadioButton
        Me.L2 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'L1
        '
        Me.L1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.L1.Location = New System.Drawing.Point(82, 19)
        Me.L1.Name = "L1"
        Me.L1.Size = New System.Drawing.Size(119, 23)
        Me.L1.TabIndex = 0
        Me.L1.Text = "Converter"
        '
        'T1
        '
        Me.T1.Location = New System.Drawing.Point(171, 112)
        Me.T1.Name = "T1"
        Me.T1.Size = New System.Drawing.Size(100, 20)
        Me.T1.TabIndex = 1
        '
        'B1
        '
        Me.B1.Location = New System.Drawing.Point(90, 173)
        Me.B1.Name = "B1"
        Me.B1.Size = New System.Drawing.Size(75, 37)
        Me.B1.TabIndex = 2
        Me.B1.Text = "CLICK"
        Me.B1.UseVisualStyleBackColor = True
        '
        'Rcelsius
        '
        Me.Rcelsius.AutoSize = True
        Me.Rcelsius.Location = New System.Drawing.Point(29, 69)
        Me.Rcelsius.Name = "Rcelsius"
        Me.Rcelsius.Size = New System.Drawing.Size(70, 17)
        Me.Rcelsius.TabIndex = 3
        Me.Rcelsius.TabStop = True
        Me.Rcelsius.Text = "CELSIUS"
        Me.Rcelsius.UseVisualStyleBackColor = True
        '
        'Rfehrenheit
        '
        Me.Rfehrenheit.AutoSize = True
        Me.Rfehrenheit.Location = New System.Drawing.Point(144, 69)
        Me.Rfehrenheit.Name = "Rfehrenheit"
        Me.Rfehrenheit.Size = New System.Drawing.Size(94, 17)
        Me.Rfehrenheit.TabIndex = 4
        Me.Rfehrenheit.TabStop = True
        Me.Rfehrenheit.Text = "FEHRENHEIT"
        Me.Rfehrenheit.UseVisualStyleBackColor = True
        '
        'L2
        '
        Me.L2.Location = New System.Drawing.Point(-1, 112)
        Me.L2.Name = "L2"
        Me.L2.Size = New System.Drawing.Size(166, 17)
        Me.L2.TabIndex = 5
        Me.L2.Text = "        ENTER VALUE  : : "
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.L2)
        Me.Controls.Add(Me.Rfehrenheit)
        Me.Controls.Add(Me.Rcelsius)
        Me.Controls.Add(Me.B1)
        Me.Controls.Add(Me.T1)
        Me.Controls.Add(Me.L1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents L1 As System.Windows.Forms.Label
    Friend WithEvents T1 As System.Windows.Forms.TextBox
    Friend WithEvents B1 As System.Windows.Forms.Button
    Friend WithEvents Rcelsius As System.Windows.Forms.RadioButton
    Friend WithEvents Rfehrenheit As System.Windows.Forms.RadioButton
    Friend WithEvents L2 As System.Windows.Forms.Label
End Class
