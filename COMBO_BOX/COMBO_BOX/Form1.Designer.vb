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
        Me.T1 = New System.Windows.Forms.TextBox
        Me.B1 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.C1 = New System.Windows.Forms.ComboBox
        Me.SuspendLayout()
        '
        'T1
        '
        Me.T1.Location = New System.Drawing.Point(194, 49)
        Me.T1.Name = "T1"
        Me.T1.Size = New System.Drawing.Size(156, 20)
        Me.T1.TabIndex = 0
        '
        'B1
        '
        Me.B1.Location = New System.Drawing.Point(380, 46)
        Me.B1.Name = "B1"
        Me.B1.Size = New System.Drawing.Size(75, 23)
        Me.B1.TabIndex = 1
        Me.B1.Text = "INSERT "
        Me.B1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(-7, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(195, 23)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "INSERT INTO COMBO BOX  : : "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'C1
        '
        Me.C1.FormattingEnabled = True
        Me.C1.Items.AddRange(New Object() {"SHACHIN", "SEHVAG", "DRAVID"})
        Me.C1.Location = New System.Drawing.Point(168, 128)
        Me.C1.Name = "C1"
        Me.C1.Size = New System.Drawing.Size(126, 21)
        Me.C1.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(496, 313)
        Me.Controls.Add(Me.C1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.B1)
        Me.Controls.Add(Me.T1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents T1 As System.Windows.Forms.TextBox
    Friend WithEvents B1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents C1 As System.Windows.Forms.ComboBox

End Class
