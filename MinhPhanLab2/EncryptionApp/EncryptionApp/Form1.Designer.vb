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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBox1 = New System.Windows.Forms.TextBox()
        Me.txtBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBox3 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtBox4 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lbDigit1 = New System.Windows.Forms.Label()
        Me.lbDigit2 = New System.Windows.Forms.Label()
        Me.lbDigit3 = New System.Windows.Forms.Label()
        Me.lbDigit4 = New System.Windows.Forms.Label()
        Me.btnEncrypt = New System.Windows.Forms.Button()
        Me.btnDecrypt = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtBox4)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtBox3)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtBox2)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtBox1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(32, 40)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(244, 358)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "4 Digits PIN"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 82)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Digit 1:"
        '
        'txtBox1
        '
        Me.txtBox1.Location = New System.Drawing.Point(100, 75)
        Me.txtBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtBox1.Name = "txtBox1"
        Me.txtBox1.Size = New System.Drawing.Size(66, 26)
        Me.txtBox1.TabIndex = 1
        Me.txtBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtBox2
        '
        Me.txtBox2.Location = New System.Drawing.Point(100, 138)
        Me.txtBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtBox2.Name = "txtBox2"
        Me.txtBox2.Size = New System.Drawing.Size(66, 26)
        Me.txtBox2.TabIndex = 3
        Me.txtBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 145)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Digit 2:"
        '
        'txtBox3
        '
        Me.txtBox3.Location = New System.Drawing.Point(100, 202)
        Me.txtBox3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtBox3.Name = "txtBox3"
        Me.txtBox3.Size = New System.Drawing.Size(66, 26)
        Me.txtBox3.TabIndex = 5
        Me.txtBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 208)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Digit 3:"
        '
        'txtBox4
        '
        Me.txtBox4.Location = New System.Drawing.Point(100, 265)
        Me.txtBox4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtBox4.Name = "txtBox4"
        Me.txtBox4.Size = New System.Drawing.Size(66, 26)
        Me.txtBox4.TabIndex = 7
        Me.txtBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(32, 271)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Digit 4:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lbDigit4)
        Me.GroupBox2.Controls.Add(Me.lbDigit3)
        Me.GroupBox2.Controls.Add(Me.lbDigit2)
        Me.GroupBox2.Controls.Add(Me.lbDigit1)
        Me.GroupBox2.Location = New System.Drawing.Point(292, 237)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox2.Size = New System.Drawing.Size(288, 160)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Encrypted PIN"
        '
        'lbDigit1
        '
        Me.lbDigit1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lbDigit1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbDigit1.Location = New System.Drawing.Point(38, 63)
        Me.lbDigit1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbDigit1.Name = "lbDigit1"
        Me.lbDigit1.Size = New System.Drawing.Size(28, 57)
        Me.lbDigit1.TabIndex = 0
        Me.lbDigit1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbDigit2
        '
        Me.lbDigit2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lbDigit2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbDigit2.Location = New System.Drawing.Point(93, 63)
        Me.lbDigit2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbDigit2.Name = "lbDigit2"
        Me.lbDigit2.Size = New System.Drawing.Size(28, 57)
        Me.lbDigit2.TabIndex = 1
        Me.lbDigit2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbDigit3
        '
        Me.lbDigit3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lbDigit3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbDigit3.Location = New System.Drawing.Point(148, 63)
        Me.lbDigit3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbDigit3.Name = "lbDigit3"
        Me.lbDigit3.Size = New System.Drawing.Size(28, 57)
        Me.lbDigit3.TabIndex = 2
        Me.lbDigit3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbDigit4
        '
        Me.lbDigit4.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lbDigit4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbDigit4.Location = New System.Drawing.Point(204, 63)
        Me.lbDigit4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbDigit4.Name = "lbDigit4"
        Me.lbDigit4.Size = New System.Drawing.Size(28, 57)
        Me.lbDigit4.TabIndex = 3
        Me.lbDigit4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnEncrypt
        '
        Me.btnEncrypt.Location = New System.Drawing.Point(290, 52)
        Me.btnEncrypt.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnEncrypt.Name = "btnEncrypt"
        Me.btnEncrypt.Size = New System.Drawing.Size(286, 46)
        Me.btnEncrypt.TabIndex = 2
        Me.btnEncrypt.Text = "Encrypt My PIN"
        Me.btnEncrypt.UseVisualStyleBackColor = True
        '
        'btnDecrypt
        '
        Me.btnDecrypt.Location = New System.Drawing.Point(291, 125)
        Me.btnDecrypt.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnDecrypt.Name = "btnDecrypt"
        Me.btnDecrypt.Size = New System.Drawing.Size(286, 46)
        Me.btnDecrypt.TabIndex = 3
        Me.btnDecrypt.Text = "Decrypt My PIN"
        Me.btnDecrypt.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(594, 426)
        Me.Controls.Add(Me.btnDecrypt)
        Me.Controls.Add(Me.btnEncrypt)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form1"
        Me.Text = "Encryption App"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtBox4 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtBox3 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lbDigit4 As Label
    Friend WithEvents lbDigit3 As Label
    Friend WithEvents lbDigit2 As Label
    Friend WithEvents lbDigit1 As Label
    Friend WithEvents btnEncrypt As Button
    Friend WithEvents btnDecrypt As Button
End Class
