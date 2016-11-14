<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.LNAME = New System.Windows.Forms.Label
        Me.Lamount = New System.Windows.Forms.Label
        Me.Lrate = New System.Windows.Forms.Label
        Me.txtAmount = New System.Windows.Forms.TextBox
        Me.txtInterest = New System.Windows.Forms.TextBox
        Me.txtnoInstollment = New System.Windows.Forms.TextBox
        Me.Cpayment = New System.Windows.Forms.CheckBox
        Me.Bcalculate = New System.Windows.Forms.Button
        Me.txtInstollment = New System.Windows.Forms.TextBox
        Me.Lnoinstol = New System.Windows.Forms.Label
        Me.Linstollment = New System.Windows.Forms.Label
        Me.L1 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'LNAME
        '
        Me.LNAME.AutoSize = True
        Me.LNAME.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LNAME.ForeColor = System.Drawing.Color.Navy
        Me.LNAME.Location = New System.Drawing.Point(42, 18)
        Me.LNAME.Name = "LNAME"
        Me.LNAME.Size = New System.Drawing.Size(223, 25)
        Me.LNAME.TabIndex = 0
        Me.LNAME.Text = "LOAN CALCULATOR"
        '
        'Lamount
        '
        Me.Lamount.AutoSize = True
        Me.Lamount.Location = New System.Drawing.Point(44, 60)
        Me.Lamount.Name = "Lamount"
        Me.Lamount.Size = New System.Drawing.Size(72, 13)
        Me.Lamount.TabIndex = 1
        Me.Lamount.Text = "AMOUNT  : : "
        '
        'Lrate
        '
        Me.Lrate.AutoSize = True
        Me.Lrate.Location = New System.Drawing.Point(3, 94)
        Me.Lrate.Name = "Lrate"
        Me.Lrate.Size = New System.Drawing.Size(128, 13)
        Me.Lrate.TabIndex = 2
        Me.Lrate.Text = "RATE OF INTEREST  : : "
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(143, 60)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(100, 20)
        Me.txtAmount.TabIndex = 3
        '
        'txtInterest
        '
        Me.txtInterest.Location = New System.Drawing.Point(143, 94)
        Me.txtInterest.Name = "txtInterest"
        Me.txtInterest.Size = New System.Drawing.Size(100, 20)
        Me.txtInterest.TabIndex = 4
        '
        'txtnoInstollment
        '
        Me.txtnoInstollment.Location = New System.Drawing.Point(143, 125)
        Me.txtnoInstollment.Name = "txtnoInstollment"
        Me.txtnoInstollment.Size = New System.Drawing.Size(100, 20)
        Me.txtnoInstollment.TabIndex = 5
        '
        'Cpayment
        '
        Me.Cpayment.AutoSize = True
        Me.Cpayment.Location = New System.Drawing.Point(143, 163)
        Me.Cpayment.Name = "Cpayment"
        Me.Cpayment.Size = New System.Drawing.Size(93, 17)
        Me.Cpayment.TabIndex = 6
        Me.Cpayment.Text = "Early Payment"
        Me.Cpayment.UseVisualStyleBackColor = True
        '
        'Bcalculate
        '
        Me.Bcalculate.Location = New System.Drawing.Point(62, 200)
        Me.Bcalculate.Name = "Bcalculate"
        Me.Bcalculate.Size = New System.Drawing.Size(166, 30)
        Me.Bcalculate.TabIndex = 7
        Me.Bcalculate.Text = "CALCULATE INSTOLLMENT"
        Me.Bcalculate.UseVisualStyleBackColor = True
        '
        'txtInstollment
        '
        Me.txtInstollment.Location = New System.Drawing.Point(128, 251)
        Me.txtInstollment.Name = "txtInstollment"
        Me.txtInstollment.ReadOnly = True
        Me.txtInstollment.Size = New System.Drawing.Size(100, 20)
        Me.txtInstollment.TabIndex = 8
        '
        'Lnoinstol
        '
        Me.Lnoinstol.AutoSize = True
        Me.Lnoinstol.Location = New System.Drawing.Point(3, 128)
        Me.Lnoinstol.Name = "Lnoinstol"
        Me.Lnoinstol.Size = New System.Drawing.Size(134, 13)
        Me.Lnoinstol.TabIndex = 9
        Me.Lnoinstol.Text = "NO OF INSTOLLMENT : : "
        '
        'Linstollment
        '
        Me.Linstollment.AutoSize = True
        Me.Linstollment.Location = New System.Drawing.Point(21, 251)
        Me.Linstollment.Name = "Linstollment"
        Me.Linstollment.Size = New System.Drawing.Size(101, 13)
        Me.Linstollment.TabIndex = 10
        Me.Linstollment.Text = "INSTOLLMENT  :  :"
        '
        'L1
        '
        Me.L1.AutoSize = True
        Me.L1.Location = New System.Drawing.Point(249, 97)
        Me.L1.Name = "L1"
        Me.L1.Size = New System.Drawing.Size(15, 13)
        Me.L1.TabIndex = 11
        Me.L1.Text = "%"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(287, 295)
        Me.Controls.Add(Me.L1)
        Me.Controls.Add(Me.Linstollment)
        Me.Controls.Add(Me.Lnoinstol)
        Me.Controls.Add(Me.txtInstollment)
        Me.Controls.Add(Me.Bcalculate)
        Me.Controls.Add(Me.Cpayment)
        Me.Controls.Add(Me.txtnoInstollment)
        Me.Controls.Add(Me.txtInterest)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.Lrate)
        Me.Controls.Add(Me.Lamount)
        Me.Controls.Add(Me.LNAME)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LNAME As System.Windows.Forms.Label
    Friend WithEvents Lamount As System.Windows.Forms.Label
    Friend WithEvents Lrate As System.Windows.Forms.Label
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents txtInterest As System.Windows.Forms.TextBox
    Friend WithEvents txtnoInstollment As System.Windows.Forms.TextBox
    Friend WithEvents Cpayment As System.Windows.Forms.CheckBox
    Friend WithEvents Bcalculate As System.Windows.Forms.Button
    Friend WithEvents txtInstollment As System.Windows.Forms.TextBox
    Friend WithEvents Lnoinstol As System.Windows.Forms.Label
    Friend WithEvents Linstollment As System.Windows.Forms.Label
    Friend WithEvents L1 As System.Windows.Forms.Label
End Class
