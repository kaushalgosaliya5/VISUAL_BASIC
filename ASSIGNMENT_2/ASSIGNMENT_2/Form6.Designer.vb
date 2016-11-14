<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Me.L3 = New System.Windows.Forms.Label
        Me.T1 = New System.Windows.Forms.TextBox
        Me.T2 = New System.Windows.Forms.TextBox
        Me.T3 = New System.Windows.Forms.TextBox
        Me.HScrollBar1 = New System.Windows.Forms.HScrollBar
        Me.HScrollBar2 = New System.Windows.Forms.HScrollBar
        Me.HScrollBar3 = New System.Windows.Forms.HScrollBar
        Me.L4 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'L1
        '
        Me.L1.AutoSize = True
        Me.L1.Location = New System.Drawing.Point(12, 39)
        Me.L1.Name = "L1"
        Me.L1.Size = New System.Drawing.Size(60, 13)
        Me.L1.TabIndex = 0
        Me.L1.Text = "RED      : : "
        '
        'L2
        '
        Me.L2.AutoSize = True
        Me.L2.Location = New System.Drawing.Point(12, 76)
        Me.L2.Name = "L2"
        Me.L2.Size = New System.Drawing.Size(72, 13)
        Me.L2.TabIndex = 1
        Me.L2.Text = "GREEN     :  :"
        '
        'L3
        '
        Me.L3.AutoSize = True
        Me.L3.Location = New System.Drawing.Point(12, 111)
        Me.L3.Name = "L3"
        Me.L3.Size = New System.Drawing.Size(65, 13)
        Me.L3.TabIndex = 2
        Me.L3.Text = "BLUE      :  :"
        '
        'T1
        '
        Me.T1.Location = New System.Drawing.Point(281, 23)
        Me.T1.Name = "T1"
        Me.T1.Size = New System.Drawing.Size(53, 20)
        Me.T1.TabIndex = 3
        '
        'T2
        '
        Me.T2.Location = New System.Drawing.Point(281, 66)
        Me.T2.Name = "T2"
        Me.T2.Size = New System.Drawing.Size(53, 20)
        Me.T2.TabIndex = 4
        '
        'T3
        '
        Me.T3.Location = New System.Drawing.Point(281, 104)
        Me.T3.Name = "T3"
        Me.T3.Size = New System.Drawing.Size(53, 20)
        Me.T3.TabIndex = 5
        '
        'HScrollBar1
        '
        Me.HScrollBar1.Location = New System.Drawing.Point(106, 26)
        Me.HScrollBar1.Maximum = 255
        Me.HScrollBar1.Name = "HScrollBar1"
        Me.HScrollBar1.Size = New System.Drawing.Size(148, 17)
        Me.HScrollBar1.TabIndex = 6
        '
        'HScrollBar2
        '
        Me.HScrollBar2.Location = New System.Drawing.Point(106, 69)
        Me.HScrollBar2.Maximum = 255
        Me.HScrollBar2.Name = "HScrollBar2"
        Me.HScrollBar2.Size = New System.Drawing.Size(148, 17)
        Me.HScrollBar2.TabIndex = 7
        '
        'HScrollBar3
        '
        Me.HScrollBar3.Location = New System.Drawing.Point(106, 111)
        Me.HScrollBar3.Maximum = 255
        Me.HScrollBar3.Name = "HScrollBar3"
        Me.HScrollBar3.Size = New System.Drawing.Size(148, 20)
        Me.HScrollBar3.TabIndex = 8
        '
        'L4
        '
        Me.L4.Location = New System.Drawing.Point(125, 165)
        Me.L4.Name = "L4"
        Me.L4.Size = New System.Drawing.Size(89, 49)
        Me.L4.TabIndex = 9
        Me.L4.Text = "BACK COLOR"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(106, 234)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(91, 44)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "BACKGROUND"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(344, 306)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.L4)
        Me.Controls.Add(Me.HScrollBar3)
        Me.Controls.Add(Me.HScrollBar2)
        Me.Controls.Add(Me.HScrollBar1)
        Me.Controls.Add(Me.T3)
        Me.Controls.Add(Me.T2)
        Me.Controls.Add(Me.T1)
        Me.Controls.Add(Me.L3)
        Me.Controls.Add(Me.L2)
        Me.Controls.Add(Me.L1)
        Me.Name = "Form6"
        Me.Text = "Form6"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents L1 As System.Windows.Forms.Label
    Friend WithEvents L2 As System.Windows.Forms.Label
    Friend WithEvents L3 As System.Windows.Forms.Label
    Friend WithEvents T1 As System.Windows.Forms.TextBox
    Friend WithEvents T2 As System.Windows.Forms.TextBox
    Friend WithEvents T3 As System.Windows.Forms.TextBox
    Friend WithEvents HScrollBar1 As System.Windows.Forms.HScrollBar
    Friend WithEvents HScrollBar2 As System.Windows.Forms.HScrollBar
    Friend WithEvents HScrollBar3 As System.Windows.Forms.HScrollBar
    Friend WithEvents L4 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
