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
        Me.Label1 = New System.Windows.Forms.Label
        Me.L2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtPricipal = New System.Windows.Forms.TextBox
        Me.txtRate = New System.Windows.Forms.TextBox
        Me.txtDuration = New System.Windows.Forms.TextBox
        Me.RSIMPLE = New System.Windows.Forms.RadioButton
        Me.RCOUMPOUND = New System.Windows.Forms.RadioButton
        Me.B1 = New System.Windows.Forms.Button
        Me.Lper = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(97, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(174, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Calculate Interest"
        '
        'L2
        '
        Me.L2.AutoSize = True
        Me.L2.Location = New System.Drawing.Point(29, 108)
        Me.L2.Name = "L2"
        Me.L2.Size = New System.Drawing.Size(128, 13)
        Me.L2.TabIndex = 1
        Me.L2.Text = "PRINCIPAL AMOUNT : : "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "RATE OF INTEREST : : "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(29, 163)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "NUMBER OF YEAR : : "
        '
        'txtPricipal
        '
        Me.txtPricipal.Location = New System.Drawing.Point(163, 105)
        Me.txtPricipal.Name = "txtPricipal"
        Me.txtPricipal.Size = New System.Drawing.Size(100, 20)
        Me.txtPricipal.TabIndex = 4
        '
        'txtRate
        '
        Me.txtRate.Location = New System.Drawing.Point(163, 131)
        Me.txtRate.Name = "txtRate"
        Me.txtRate.Size = New System.Drawing.Size(100, 20)
        Me.txtRate.TabIndex = 5
        Me.txtRate.Text = "9.98"
        Me.txtRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDuration
        '
        Me.txtDuration.Location = New System.Drawing.Point(163, 160)
        Me.txtDuration.Name = "txtDuration"
        Me.txtDuration.Size = New System.Drawing.Size(100, 20)
        Me.txtDuration.TabIndex = 6
        '
        'RSIMPLE
        '
        Me.RSIMPLE.AutoSize = True
        Me.RSIMPLE.Location = New System.Drawing.Point(49, 62)
        Me.RSIMPLE.Name = "RSIMPLE"
        Me.RSIMPLE.Size = New System.Drawing.Size(64, 17)
        Me.RSIMPLE.TabIndex = 7
        Me.RSIMPLE.TabStop = True
        Me.RSIMPLE.Text = "SIMPLE"
        Me.RSIMPLE.UseVisualStyleBackColor = True
        '
        'RCOUMPOUND
        '
        Me.RCOUMPOUND.AutoSize = True
        Me.RCOUMPOUND.Location = New System.Drawing.Point(163, 62)
        Me.RCOUMPOUND.Name = "RCOUMPOUND"
        Me.RCOUMPOUND.Size = New System.Drawing.Size(80, 17)
        Me.RCOUMPOUND.TabIndex = 8
        Me.RCOUMPOUND.TabStop = True
        Me.RCOUMPOUND.Text = "COMPOND"
        Me.RCOUMPOUND.UseVisualStyleBackColor = True
        '
        'B1
        '
        Me.B1.Location = New System.Drawing.Point(163, 206)
        Me.B1.Name = "B1"
        Me.B1.Size = New System.Drawing.Size(80, 32)
        Me.B1.TabIndex = 9
        Me.B1.Text = "INTEREST"
        Me.B1.UseVisualStyleBackColor = True
        '
        'Lper
        '
        Me.Lper.Location = New System.Drawing.Point(270, 132)
        Me.Lper.Name = "Lper"
        Me.Lper.Size = New System.Drawing.Size(18, 23)
        Me.Lper.TabIndex = 10
        Me.Lper.Text = "%"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(310, 264)
        Me.Controls.Add(Me.Lper)
        Me.Controls.Add(Me.B1)
        Me.Controls.Add(Me.RCOUMPOUND)
        Me.Controls.Add(Me.RSIMPLE)
        Me.Controls.Add(Me.txtDuration)
        Me.Controls.Add(Me.txtRate)
        Me.Controls.Add(Me.txtPricipal)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.L2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents L2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtPricipal As System.Windows.Forms.TextBox
    Friend WithEvents txtRate As System.Windows.Forms.TextBox
    Friend WithEvents txtDuration As System.Windows.Forms.TextBox
    Friend WithEvents RSIMPLE As System.Windows.Forms.RadioButton
    Friend WithEvents RCOUMPOUND As System.Windows.Forms.RadioButton
    Friend WithEvents B1 As System.Windows.Forms.Button
    Friend WithEvents Lper As System.Windows.Forms.Label

End Class
