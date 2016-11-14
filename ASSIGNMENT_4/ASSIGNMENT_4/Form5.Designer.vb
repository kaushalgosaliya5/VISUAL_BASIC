<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Me.L2 = New System.Windows.Forms.Label
        Me.T1 = New System.Windows.Forms.TextBox
        Me.T2 = New System.Windows.Forms.TextBox
        Me.B1 = New System.Windows.Forms.Button
        Me.L3 = New System.Windows.Forms.Label
        Me.C1 = New System.Windows.Forms.ComboBox
        Me.B2 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'L1
        '
        Me.L1.AutoSize = True
        Me.L1.Location = New System.Drawing.Point(68, 57)
        Me.L1.Name = "L1"
        Me.L1.Size = New System.Drawing.Size(143, 13)
        Me.L1.TabIndex = 0
        Me.L1.Text = "ENTER FIRST NUMBER  : :"
        '
        'L2
        '
        Me.L2.AutoSize = True
        Me.L2.Location = New System.Drawing.Point(68, 87)
        Me.L2.Name = "L2"
        Me.L2.Size = New System.Drawing.Size(157, 13)
        Me.L2.TabIndex = 1
        Me.L2.Text = "ENTER SECOND NUMBER  : :"
        '
        'T1
        '
        Me.T1.Location = New System.Drawing.Point(238, 54)
        Me.T1.Name = "T1"
        Me.T1.Size = New System.Drawing.Size(111, 20)
        Me.T1.TabIndex = 2
        '
        'T2
        '
        Me.T2.Location = New System.Drawing.Point(238, 80)
        Me.T2.Name = "T2"
        Me.T2.Size = New System.Drawing.Size(111, 20)
        Me.T2.TabIndex = 3
        '
        'B1
        '
        Me.B1.Location = New System.Drawing.Point(238, 120)
        Me.B1.Name = "B1"
        Me.B1.Size = New System.Drawing.Size(85, 31)
        Me.B1.TabIndex = 4
        Me.B1.Text = "VALIDATE"
        Me.B1.UseVisualStyleBackColor = True
        '
        'L3
        '
        Me.L3.AutoSize = True
        Me.L3.Location = New System.Drawing.Point(68, 171)
        Me.L3.Name = "L3"
        Me.L3.Size = New System.Drawing.Size(70, 13)
        Me.L3.TabIndex = 5
        Me.L3.Text = "OPERATOR "
        Me.L3.Visible = False
        '
        'C1
        '
        Me.C1.FormattingEnabled = True
        Me.C1.Location = New System.Drawing.Point(238, 171)
        Me.C1.Name = "C1"
        Me.C1.Size = New System.Drawing.Size(121, 21)
        Me.C1.TabIndex = 6
        Me.C1.Visible = False
        '
        'B2
        '
        Me.B2.Location = New System.Drawing.Point(150, 224)
        Me.B2.Name = "B2"
        Me.B2.Size = New System.Drawing.Size(108, 34)
        Me.B2.TabIndex = 7
        Me.B2.Text = "CALCULATE"
        Me.B2.UseVisualStyleBackColor = True
        Me.B2.Visible = False
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(426, 280)
        Me.Controls.Add(Me.B2)
        Me.Controls.Add(Me.C1)
        Me.Controls.Add(Me.L3)
        Me.Controls.Add(Me.B1)
        Me.Controls.Add(Me.T2)
        Me.Controls.Add(Me.T1)
        Me.Controls.Add(Me.L2)
        Me.Controls.Add(Me.L1)
        Me.Name = "Form5"
        Me.Text = "Form5"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents L1 As System.Windows.Forms.Label
    Friend WithEvents L2 As System.Windows.Forms.Label
    Friend WithEvents T1 As System.Windows.Forms.TextBox
    Friend WithEvents T2 As System.Windows.Forms.TextBox
    Friend WithEvents B1 As System.Windows.Forms.Button
    Friend WithEvents L3 As System.Windows.Forms.Label
    Friend WithEvents C1 As System.Windows.Forms.ComboBox
    Friend WithEvents B2 As System.Windows.Forms.Button
End Class
