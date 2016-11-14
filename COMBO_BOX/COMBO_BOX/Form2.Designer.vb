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
        Me.Binsert = New System.Windows.Forms.Button
        Me.ListBox1 = New System.Windows.Forms.ListBox
        Me.ListBox2 = New System.Windows.Forms.ListBox
        Me.B1 = New System.Windows.Forms.Button
        Me.B2 = New System.Windows.Forms.Button
        Me.B3 = New System.Windows.Forms.Button
        Me.B4 = New System.Windows.Forms.Button
        Me.B5 = New System.Windows.Forms.Button
        Me.B6 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'L1
        '
        Me.L1.AutoSize = True
        Me.L1.Location = New System.Drawing.Point(27, 64)
        Me.L1.Name = "L1"
        Me.L1.Size = New System.Drawing.Size(113, 13)
        Me.L1.TabIndex = 0
        Me.L1.Text = "INSERT LIST BOX  : :"
        '
        'T1
        '
        Me.T1.Location = New System.Drawing.Point(168, 64)
        Me.T1.Name = "T1"
        Me.T1.Size = New System.Drawing.Size(145, 20)
        Me.T1.TabIndex = 1
        '
        'Binsert
        '
        Me.Binsert.Location = New System.Drawing.Point(336, 62)
        Me.Binsert.Name = "Binsert"
        Me.Binsert.Size = New System.Drawing.Size(75, 23)
        Me.Binsert.TabIndex = 2
        Me.Binsert.Text = "INSERT"
        Me.Binsert.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Items.AddRange(New Object() {"SHACHIN" & Global.Microsoft.VisualBasic.ChrW(9), "SEHWAG", "DHONI", "YUVRAG", "DRAVID", "HARBHAJAN"})
        Me.ListBox1.Location = New System.Drawing.Point(30, 137)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.ListBox1.Size = New System.Drawing.Size(145, 173)
        Me.ListBox1.TabIndex = 3
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(260, 137)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.ListBox2.Size = New System.Drawing.Size(128, 173)
        Me.ListBox2.TabIndex = 4
        '
        'B1
        '
        Me.B1.Location = New System.Drawing.Point(198, 137)
        Me.B1.Name = "B1"
        Me.B1.Size = New System.Drawing.Size(35, 23)
        Me.B1.TabIndex = 5
        Me.B1.Text = ">"
        Me.B1.UseVisualStyleBackColor = True
        '
        'B2
        '
        Me.B2.Location = New System.Drawing.Point(198, 166)
        Me.B2.Name = "B2"
        Me.B2.Size = New System.Drawing.Size(35, 23)
        Me.B2.TabIndex = 6
        Me.B2.Text = ">>"
        Me.B2.UseVisualStyleBackColor = True
        '
        'B3
        '
        Me.B3.Location = New System.Drawing.Point(198, 195)
        Me.B3.Name = "B3"
        Me.B3.Size = New System.Drawing.Size(35, 23)
        Me.B3.TabIndex = 7
        Me.B3.Text = ">>>"
        Me.B3.UseVisualStyleBackColor = True
        '
        'B4
        '
        Me.B4.Location = New System.Drawing.Point(198, 225)
        Me.B4.Name = "B4"
        Me.B4.Size = New System.Drawing.Size(35, 23)
        Me.B4.TabIndex = 8
        Me.B4.Text = "<<<"
        Me.B4.UseVisualStyleBackColor = True
        '
        'B5
        '
        Me.B5.Location = New System.Drawing.Point(198, 255)
        Me.B5.Name = "B5"
        Me.B5.Size = New System.Drawing.Size(35, 23)
        Me.B5.TabIndex = 9
        Me.B5.Text = "<<"
        Me.B5.UseVisualStyleBackColor = True
        '
        'B6
        '
        Me.B6.Location = New System.Drawing.Point(198, 284)
        Me.B6.Name = "B6"
        Me.B6.Size = New System.Drawing.Size(35, 23)
        Me.B6.TabIndex = 10
        Me.B6.Text = "<"
        Me.B6.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(433, 392)
        Me.Controls.Add(Me.B6)
        Me.Controls.Add(Me.B5)
        Me.Controls.Add(Me.B4)
        Me.Controls.Add(Me.B3)
        Me.Controls.Add(Me.B2)
        Me.Controls.Add(Me.B1)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Binsert)
        Me.Controls.Add(Me.T1)
        Me.Controls.Add(Me.L1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents L1 As System.Windows.Forms.Label
    Friend WithEvents T1 As System.Windows.Forms.TextBox
    Friend WithEvents Binsert As System.Windows.Forms.Button
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents B1 As System.Windows.Forms.Button
    Friend WithEvents B2 As System.Windows.Forms.Button
    Friend WithEvents B3 As System.Windows.Forms.Button
    Friend WithEvents B4 As System.Windows.Forms.Button
    Friend WithEvents B5 As System.Windows.Forms.Button
    Friend WithEvents B6 As System.Windows.Forms.Button
End Class
