<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form12
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
        Me.N1 = New System.Windows.Forms.NumericUpDown
        Me.L1 = New System.Windows.Forms.ListBox
        CType(Me.N1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'N1
        '
        Me.N1.Location = New System.Drawing.Point(81, 45)
        Me.N1.Maximum = New Decimal(New Integer() {30, 0, 0, 0})
        Me.N1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.N1.Name = "N1"
        Me.N1.Size = New System.Drawing.Size(54, 20)
        Me.N1.TabIndex = 0
        Me.N1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.N1.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'L1
        '
        Me.L1.FormattingEnabled = True
        Me.L1.Location = New System.Drawing.Point(65, 110)
        Me.L1.Name = "L1"
        Me.L1.Size = New System.Drawing.Size(132, 108)
        Me.L1.TabIndex = 1
        '
        'Form12
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.L1)
        Me.Controls.Add(Me.N1)
        Me.Name = "Form12"
        Me.Text = "Form12"
        CType(Me.N1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents N1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents L1 As System.Windows.Forms.ListBox
End Class
