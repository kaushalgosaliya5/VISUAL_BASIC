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
        Me.Gshape = New System.Windows.Forms.GroupBox
        Me.Rrectangle = New System.Windows.Forms.RadioButton
        Me.Rsquare = New System.Windows.Forms.RadioButton
        Me.Rcircle = New System.Windows.Forms.RadioButton
        Me.Gcircle = New System.Windows.Forms.GroupBox
        Me.Bcircle = New System.Windows.Forms.Button
        Me.Cradious = New System.Windows.Forms.TextBox
        Me.Lradious = New System.Windows.Forms.Label
        Me.Gsquare = New System.Windows.Forms.GroupBox
        Me.Slength = New System.Windows.Forms.TextBox
        Me.LSlength = New System.Windows.Forms.Label
        Me.Bsquare = New System.Windows.Forms.Button
        Me.Grectangle = New System.Windows.Forms.GroupBox
        Me.Brectangle = New System.Windows.Forms.Button
        Me.Rlength = New System.Windows.Forms.TextBox
        Me.Llength = New System.Windows.Forms.Label
        Me.Rwedth = New System.Windows.Forms.TextBox
        Me.Lwedth = New System.Windows.Forms.Label
        Me.Gshape.SuspendLayout()
        Me.Gcircle.SuspendLayout()
        Me.Gsquare.SuspendLayout()
        Me.Grectangle.SuspendLayout()
        Me.SuspendLayout()
        '
        'Gshape
        '
        Me.Gshape.Controls.Add(Me.Rrectangle)
        Me.Gshape.Controls.Add(Me.Rsquare)
        Me.Gshape.Controls.Add(Me.Rcircle)
        Me.Gshape.Location = New System.Drawing.Point(303, 27)
        Me.Gshape.Name = "Gshape"
        Me.Gshape.Size = New System.Drawing.Size(160, 100)
        Me.Gshape.TabIndex = 0
        Me.Gshape.TabStop = False
        Me.Gshape.Text = "SHAPE"
        '
        'Rrectangle
        '
        Me.Rrectangle.AutoSize = True
        Me.Rrectangle.Location = New System.Drawing.Point(27, 68)
        Me.Rrectangle.Name = "Rrectangle"
        Me.Rrectangle.Size = New System.Drawing.Size(90, 17)
        Me.Rrectangle.TabIndex = 2
        Me.Rrectangle.TabStop = True
        Me.Rrectangle.Text = "RECTANGLE"
        Me.Rrectangle.UseVisualStyleBackColor = True
        '
        'Rsquare
        '
        Me.Rsquare.AutoSize = True
        Me.Rsquare.Location = New System.Drawing.Point(27, 43)
        Me.Rsquare.Name = "Rsquare"
        Me.Rsquare.Size = New System.Drawing.Size(70, 17)
        Me.Rsquare.TabIndex = 1
        Me.Rsquare.TabStop = True
        Me.Rsquare.Text = "SQUARE"
        Me.Rsquare.UseVisualStyleBackColor = True
        '
        'Rcircle
        '
        Me.Rcircle.AutoSize = True
        Me.Rcircle.Location = New System.Drawing.Point(27, 20)
        Me.Rcircle.Name = "Rcircle"
        Me.Rcircle.Size = New System.Drawing.Size(63, 17)
        Me.Rcircle.TabIndex = 0
        Me.Rcircle.TabStop = True
        Me.Rcircle.Text = "CIRCLE"
        Me.Rcircle.UseVisualStyleBackColor = True
        '
        'Gcircle
        '
        Me.Gcircle.Controls.Add(Me.Bcircle)
        Me.Gcircle.Controls.Add(Me.Cradious)
        Me.Gcircle.Controls.Add(Me.Lradious)
        Me.Gcircle.Location = New System.Drawing.Point(24, 156)
        Me.Gcircle.Name = "Gcircle"
        Me.Gcircle.Size = New System.Drawing.Size(233, 100)
        Me.Gcircle.TabIndex = 1
        Me.Gcircle.TabStop = False
        Me.Gcircle.Text = "CIRCLE"
        Me.Gcircle.Visible = False
        '
        'Bcircle
        '
        Me.Bcircle.Location = New System.Drawing.Point(69, 56)
        Me.Bcircle.Name = "Bcircle"
        Me.Bcircle.Size = New System.Drawing.Size(75, 23)
        Me.Bcircle.TabIndex = 2
        Me.Bcircle.Text = "AREA"
        Me.Bcircle.UseVisualStyleBackColor = True
        '
        'Cradious
        '
        Me.Cradious.Location = New System.Drawing.Point(120, 17)
        Me.Cradious.Name = "Cradious"
        Me.Cradious.Size = New System.Drawing.Size(100, 20)
        Me.Cradious.TabIndex = 1
        '
        'Lradious
        '
        Me.Lradious.AutoSize = True
        Me.Lradious.Location = New System.Drawing.Point(7, 20)
        Me.Lradious.Name = "Lradious"
        Me.Lradious.Size = New System.Drawing.Size(108, 13)
        Me.Lradious.TabIndex = 0
        Me.Lradious.Text = "ENTER RADIOUS : :"
        '
        'Gsquare
        '
        Me.Gsquare.Controls.Add(Me.Slength)
        Me.Gsquare.Controls.Add(Me.LSlength)
        Me.Gsquare.Controls.Add(Me.Bsquare)
        Me.Gsquare.Location = New System.Drawing.Point(303, 156)
        Me.Gsquare.Name = "Gsquare"
        Me.Gsquare.Size = New System.Drawing.Size(231, 126)
        Me.Gsquare.TabIndex = 2
        Me.Gsquare.TabStop = False
        Me.Gsquare.Text = "SQUARE"
        Me.Gsquare.Visible = False
        '
        'Slength
        '
        Me.Slength.Location = New System.Drawing.Point(115, 23)
        Me.Slength.Name = "Slength"
        Me.Slength.Size = New System.Drawing.Size(100, 20)
        Me.Slength.TabIndex = 6
        '
        'LSlength
        '
        Me.LSlength.AutoSize = True
        Me.LSlength.Location = New System.Drawing.Point(6, 24)
        Me.LSlength.Name = "LSlength"
        Me.LSlength.Size = New System.Drawing.Size(103, 13)
        Me.LSlength.TabIndex = 5
        Me.LSlength.Text = "ENTER LENGTH : :"
        '
        'Bsquare
        '
        Me.Bsquare.Location = New System.Drawing.Point(85, 87)
        Me.Bsquare.Name = "Bsquare"
        Me.Bsquare.Size = New System.Drawing.Size(75, 23)
        Me.Bsquare.TabIndex = 4
        Me.Bsquare.Text = "AREA"
        Me.Bsquare.UseVisualStyleBackColor = True
        '
        'Grectangle
        '
        Me.Grectangle.Controls.Add(Me.Brectangle)
        Me.Grectangle.Controls.Add(Me.Rlength)
        Me.Grectangle.Controls.Add(Me.Llength)
        Me.Grectangle.Controls.Add(Me.Rwedth)
        Me.Grectangle.Controls.Add(Me.Lwedth)
        Me.Grectangle.Location = New System.Drawing.Point(550, 156)
        Me.Grectangle.Name = "Grectangle"
        Me.Grectangle.Size = New System.Drawing.Size(225, 126)
        Me.Grectangle.TabIndex = 3
        Me.Grectangle.TabStop = False
        Me.Grectangle.Text = "RACTANGLE"
        Me.Grectangle.Visible = False
        '
        'Brectangle
        '
        Me.Brectangle.Location = New System.Drawing.Point(76, 97)
        Me.Brectangle.Name = "Brectangle"
        Me.Brectangle.Size = New System.Drawing.Size(75, 23)
        Me.Brectangle.TabIndex = 8
        Me.Brectangle.Text = "AREA"
        Me.Brectangle.UseVisualStyleBackColor = True
        '
        'Rlength
        '
        Me.Rlength.Location = New System.Drawing.Point(119, 27)
        Me.Rlength.Name = "Rlength"
        Me.Rlength.Size = New System.Drawing.Size(100, 20)
        Me.Rlength.TabIndex = 7
        '
        'Llength
        '
        Me.Llength.AutoSize = True
        Me.Llength.Location = New System.Drawing.Point(6, 30)
        Me.Llength.Name = "Llength"
        Me.Llength.Size = New System.Drawing.Size(106, 13)
        Me.Llength.TabIndex = 6
        Me.Llength.Text = "ENTER LENGTH  : :"
        '
        'Rwedth
        '
        Me.Rwedth.Location = New System.Drawing.Point(118, 58)
        Me.Rwedth.Name = "Rwedth"
        Me.Rwedth.Size = New System.Drawing.Size(100, 20)
        Me.Rwedth.TabIndex = 5
        '
        'Lwedth
        '
        Me.Lwedth.AutoSize = True
        Me.Lwedth.Location = New System.Drawing.Point(9, 59)
        Me.Lwedth.Name = "Lwedth"
        Me.Lwedth.Size = New System.Drawing.Size(103, 13)
        Me.Lwedth.TabIndex = 4
        Me.Lwedth.Text = "ENTER WEDTH  : :"
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(859, 390)
        Me.Controls.Add(Me.Grectangle)
        Me.Controls.Add(Me.Gsquare)
        Me.Controls.Add(Me.Gcircle)
        Me.Controls.Add(Me.Gshape)
        Me.Name = "Form5"
        Me.Text = "Form5"
        Me.Gshape.ResumeLayout(False)
        Me.Gshape.PerformLayout()
        Me.Gcircle.ResumeLayout(False)
        Me.Gcircle.PerformLayout()
        Me.Gsquare.ResumeLayout(False)
        Me.Gsquare.PerformLayout()
        Me.Grectangle.ResumeLayout(False)
        Me.Grectangle.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Gshape As System.Windows.Forms.GroupBox
    Friend WithEvents Rrectangle As System.Windows.Forms.RadioButton
    Friend WithEvents Rsquare As System.Windows.Forms.RadioButton
    Friend WithEvents Rcircle As System.Windows.Forms.RadioButton
    Friend WithEvents Gcircle As System.Windows.Forms.GroupBox
    Friend WithEvents Bcircle As System.Windows.Forms.Button
    Friend WithEvents Cradious As System.Windows.Forms.TextBox
    Friend WithEvents Lradious As System.Windows.Forms.Label
    Friend WithEvents Gsquare As System.Windows.Forms.GroupBox
    Friend WithEvents Bsquare As System.Windows.Forms.Button
    Friend WithEvents Grectangle As System.Windows.Forms.GroupBox
    Friend WithEvents Rlength As System.Windows.Forms.TextBox
    Friend WithEvents Llength As System.Windows.Forms.Label
    Friend WithEvents Rwedth As System.Windows.Forms.TextBox
    Friend WithEvents Lwedth As System.Windows.Forms.Label
    Friend WithEvents Slength As System.Windows.Forms.TextBox
    Friend WithEvents LSlength As System.Windows.Forms.Label
    Friend WithEvents Brectangle As System.Windows.Forms.Button
End Class
