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
        Me.Lname = New System.Windows.Forms.Label
        Me.Laddress = New System.Windows.Forms.Label
        Me.Skills = New System.Windows.Forms.GroupBox
        Me.Rgraduation = New System.Windows.Forms.RadioButton
        Me.Rhsc = New System.Windows.Forms.RadioButton
        Me.Rssc = New System.Windows.Forms.RadioButton
        Me.Gender = New System.Windows.Forms.GroupBox
        Me.Rfemale = New System.Windows.Forms.RadioButton
        Me.Rmale = New System.Windows.Forms.RadioButton
        Me.Tname = New System.Windows.Forms.TextBox
        Me.Taddress = New System.Windows.Forms.TextBox
        Me.B1 = New System.Windows.Forms.Button
        Me.Ldetail = New System.Windows.Forms.Label
        Me.Skills.SuspendLayout()
        Me.Gender.SuspendLayout()
        Me.SuspendLayout()
        '
        'L1
        '
        Me.L1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.L1.Location = New System.Drawing.Point(51, 28)
        Me.L1.Name = "L1"
        Me.L1.Size = New System.Drawing.Size(183, 23)
        Me.L1.TabIndex = 0
        Me.L1.Text = "Employee Detail"
        '
        'Lname
        '
        Me.Lname.AutoSize = True
        Me.Lname.Location = New System.Drawing.Point(21, 73)
        Me.Lname.Name = "Lname"
        Me.Lname.Size = New System.Drawing.Size(56, 13)
        Me.Lname.TabIndex = 1
        Me.Lname.Text = "NAME  : : "
        '
        'Laddress
        '
        Me.Laddress.AutoSize = True
        Me.Laddress.Location = New System.Drawing.Point(13, 106)
        Me.Laddress.Name = "Laddress"
        Me.Laddress.Size = New System.Drawing.Size(77, 13)
        Me.Laddress.TabIndex = 2
        Me.Laddress.Text = "ADDRESS  : : "
        '
        'Skills
        '
        Me.Skills.Controls.Add(Me.Rgraduation)
        Me.Skills.Controls.Add(Me.Rhsc)
        Me.Skills.Controls.Add(Me.Rssc)
        Me.Skills.Location = New System.Drawing.Point(24, 165)
        Me.Skills.Name = "Skills"
        Me.Skills.Size = New System.Drawing.Size(118, 114)
        Me.Skills.TabIndex = 3
        Me.Skills.TabStop = False
        Me.Skills.Text = "SKILLS"
        '
        'Rgraduation
        '
        Me.Rgraduation.AutoSize = True
        Me.Rgraduation.Location = New System.Drawing.Point(21, 77)
        Me.Rgraduation.Name = "Rgraduation"
        Me.Rgraduation.Size = New System.Drawing.Size(97, 17)
        Me.Rgraduation.TabIndex = 0
        Me.Rgraduation.TabStop = True
        Me.Rgraduation.Text = "GRADUATION"
        Me.Rgraduation.UseVisualStyleBackColor = True
        '
        'Rhsc
        '
        Me.Rhsc.AutoSize = True
        Me.Rhsc.Location = New System.Drawing.Point(21, 55)
        Me.Rhsc.Name = "Rhsc"
        Me.Rhsc.Size = New System.Drawing.Size(47, 17)
        Me.Rhsc.TabIndex = 0
        Me.Rhsc.TabStop = True
        Me.Rhsc.Text = "HSC"
        Me.Rhsc.UseVisualStyleBackColor = True
        '
        'Rssc
        '
        Me.Rssc.AutoSize = True
        Me.Rssc.Location = New System.Drawing.Point(21, 31)
        Me.Rssc.Name = "Rssc"
        Me.Rssc.Size = New System.Drawing.Size(46, 17)
        Me.Rssc.TabIndex = 0
        Me.Rssc.TabStop = True
        Me.Rssc.Text = "SSC"
        Me.Rssc.UseVisualStyleBackColor = True
        '
        'Gender
        '
        Me.Gender.Controls.Add(Me.Rfemale)
        Me.Gender.Controls.Add(Me.Rmale)
        Me.Gender.Location = New System.Drawing.Point(173, 165)
        Me.Gender.Name = "Gender"
        Me.Gender.Size = New System.Drawing.Size(114, 114)
        Me.Gender.TabIndex = 4
        Me.Gender.TabStop = False
        Me.Gender.Text = "GENDER"
        '
        'Rfemale
        '
        Me.Rfemale.AutoSize = True
        Me.Rfemale.Location = New System.Drawing.Point(18, 55)
        Me.Rfemale.Name = "Rfemale"
        Me.Rfemale.Size = New System.Drawing.Size(67, 17)
        Me.Rfemale.TabIndex = 0
        Me.Rfemale.TabStop = True
        Me.Rfemale.Text = "FEMALE"
        Me.Rfemale.UseVisualStyleBackColor = True
        '
        'Rmale
        '
        Me.Rmale.AutoSize = True
        Me.Rmale.Location = New System.Drawing.Point(18, 31)
        Me.Rmale.Name = "Rmale"
        Me.Rmale.Size = New System.Drawing.Size(54, 17)
        Me.Rmale.TabIndex = 0
        Me.Rmale.TabStop = True
        Me.Rmale.Text = "MALE"
        Me.Rmale.UseVisualStyleBackColor = True
        '
        'Tname
        '
        Me.Tname.Location = New System.Drawing.Point(112, 73)
        Me.Tname.Name = "Tname"
        Me.Tname.Size = New System.Drawing.Size(146, 20)
        Me.Tname.TabIndex = 5
        '
        'Taddress
        '
        Me.Taddress.Location = New System.Drawing.Point(112, 103)
        Me.Taddress.Multiline = True
        Me.Taddress.Name = "Taddress"
        Me.Taddress.Size = New System.Drawing.Size(146, 45)
        Me.Taddress.TabIndex = 6
        '
        'B1
        '
        Me.B1.Location = New System.Drawing.Point(100, 285)
        Me.B1.Name = "B1"
        Me.B1.Size = New System.Drawing.Size(75, 36)
        Me.B1.TabIndex = 7
        Me.B1.Text = "CLICK"
        Me.B1.UseVisualStyleBackColor = True
        '
        'Ldetail
        '
        Me.Ldetail.Location = New System.Drawing.Point(51, 343)
        Me.Ldetail.Name = "Ldetail"
        Me.Ldetail.Size = New System.Drawing.Size(222, 106)
        Me.Ldetail.TabIndex = 8
        Me.Ldetail.Text = "EMPLOYEE DETAIL"
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(307, 458)
        Me.Controls.Add(Me.Ldetail)
        Me.Controls.Add(Me.B1)
        Me.Controls.Add(Me.Taddress)
        Me.Controls.Add(Me.Tname)
        Me.Controls.Add(Me.Gender)
        Me.Controls.Add(Me.Skills)
        Me.Controls.Add(Me.Laddress)
        Me.Controls.Add(Me.Lname)
        Me.Controls.Add(Me.L1)
        Me.Name = "Form6"
        Me.Text = "Form6"
        Me.Skills.ResumeLayout(False)
        Me.Skills.PerformLayout()
        Me.Gender.ResumeLayout(False)
        Me.Gender.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents L1 As System.Windows.Forms.Label
    Friend WithEvents Lname As System.Windows.Forms.Label
    Friend WithEvents Laddress As System.Windows.Forms.Label
    Friend WithEvents Skills As System.Windows.Forms.GroupBox
    Friend WithEvents Rgraduation As System.Windows.Forms.RadioButton
    Friend WithEvents Rhsc As System.Windows.Forms.RadioButton
    Friend WithEvents Rssc As System.Windows.Forms.RadioButton
    Friend WithEvents Gender As System.Windows.Forms.GroupBox
    Friend WithEvents Rfemale As System.Windows.Forms.RadioButton
    Friend WithEvents Rmale As System.Windows.Forms.RadioButton
    Friend WithEvents Tname As System.Windows.Forms.TextBox
    Friend WithEvents Taddress As System.Windows.Forms.TextBox
    Friend WithEvents B1 As System.Windows.Forms.Button
    Friend WithEvents Ldetail As System.Windows.Forms.Label
End Class
