<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MortgageCalculatorFRM
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.loanDataGBX = New System.Windows.Forms.GroupBox()
        Me.interestTBX = New System.Windows.Forms.TextBox()
        Me.amountTBX = New System.Windows.Forms.TextBox()
        Me.interestRateLBL = New System.Windows.Forms.Label()
        Me.mortgageAountLBL = New System.Windows.Forms.Label()
        Me.titleLBL = New System.Windows.Forms.Label()
        Me.monthlyPmtsLBL = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.fiveZeroYears = New System.Windows.Forms.CheckBox()
        Me.twoFiveYears = New System.Windows.Forms.CheckBox()
        Me.tenYears = New System.Windows.Forms.CheckBox()
        Me.fiveYears = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtPayment = New System.Windows.Forms.TextBox()
        Me.loanDataGBX.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'loanDataGBX
        '
        Me.loanDataGBX.Controls.Add(Me.interestTBX)
        Me.loanDataGBX.Controls.Add(Me.amountTBX)
        Me.loanDataGBX.Controls.Add(Me.interestRateLBL)
        Me.loanDataGBX.Controls.Add(Me.mortgageAountLBL)
        Me.loanDataGBX.Location = New System.Drawing.Point(25, 51)
        Me.loanDataGBX.Name = "loanDataGBX"
        Me.loanDataGBX.Size = New System.Drawing.Size(223, 114)
        Me.loanDataGBX.TabIndex = 0
        Me.loanDataGBX.TabStop = False
        Me.loanDataGBX.Text = "Loan Data:"
        '
        'interestTBX
        '
        Me.interestTBX.Location = New System.Drawing.Point(160, 72)
        Me.interestTBX.Name = "interestTBX"
        Me.interestTBX.Size = New System.Drawing.Size(44, 26)
        Me.interestTBX.TabIndex = 3
        Me.interestTBX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'amountTBX
        '
        Me.amountTBX.Location = New System.Drawing.Point(119, 34)
        Me.amountTBX.Name = "amountTBX"
        Me.amountTBX.Size = New System.Drawing.Size(85, 26)
        Me.amountTBX.TabIndex = 2
        Me.amountTBX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'interestRateLBL
        '
        Me.interestRateLBL.AutoSize = True
        Me.interestRateLBL.Location = New System.Drawing.Point(19, 75)
        Me.interestRateLBL.Name = "interestRateLBL"
        Me.interestRateLBL.Size = New System.Drawing.Size(132, 20)
        Me.interestRateLBL.TabIndex = 1
        Me.interestRateLBL.Text = "Interest rate (%): "
        '
        'mortgageAountLBL
        '
        Me.mortgageAountLBL.AutoSize = True
        Me.mortgageAountLBL.Location = New System.Drawing.Point(19, 37)
        Me.mortgageAountLBL.Name = "mortgageAountLBL"
        Me.mortgageAountLBL.Size = New System.Drawing.Size(69, 20)
        Me.mortgageAountLBL.TabIndex = 0
        Me.mortgageAountLBL.Text = "Amount:"
        '
        'titleLBL
        '
        Me.titleLBL.AutoSize = True
        Me.titleLBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titleLBL.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.titleLBL.Location = New System.Drawing.Point(127, 13)
        Me.titleLBL.Name = "titleLBL"
        Me.titleLBL.Size = New System.Drawing.Size(230, 29)
        Me.titleLBL.TabIndex = 2
        Me.titleLBL.Text = "Mortgage Calculator"
        '
        'monthlyPmtsLBL
        '
        Me.monthlyPmtsLBL.AutoSize = True
        Me.monthlyPmtsLBL.Location = New System.Drawing.Point(268, 56)
        Me.monthlyPmtsLBL.Name = "monthlyPmtsLBL"
        Me.monthlyPmtsLBL.Size = New System.Drawing.Size(142, 20)
        Me.monthlyPmtsLBL.TabIndex = 4
        Me.monthlyPmtsLBL.Text = "Monthly Payments:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.fiveZeroYears)
        Me.GroupBox1.Controls.Add(Me.twoFiveYears)
        Me.GroupBox1.Controls.Add(Me.tenYears)
        Me.GroupBox1.Controls.Add(Me.fiveYears)
        Me.GroupBox1.Location = New System.Drawing.Point(31, 185)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(216, 94)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Term Options"
        '
        'fiveZeroYears
        '
        Me.fiveZeroYears.AutoSize = True
        Me.fiveZeroYears.Location = New System.Drawing.Point(114, 54)
        Me.fiveZeroYears.Name = "fiveZeroYears"
        Me.fiveZeroYears.Size = New System.Drawing.Size(88, 24)
        Me.fiveZeroYears.TabIndex = 3
        Me.fiveZeroYears.Text = "50 years"
        Me.fiveZeroYears.UseVisualStyleBackColor = True
        '
        'twoFiveYears
        '
        Me.twoFiveYears.AutoSize = True
        Me.twoFiveYears.Location = New System.Drawing.Point(114, 24)
        Me.twoFiveYears.Name = "twoFiveYears"
        Me.twoFiveYears.Size = New System.Drawing.Size(88, 24)
        Me.twoFiveYears.TabIndex = 2
        Me.twoFiveYears.Text = "25 years"
        Me.twoFiveYears.UseVisualStyleBackColor = True
        '
        'tenYears
        '
        Me.tenYears.AutoSize = True
        Me.tenYears.Location = New System.Drawing.Point(16, 54)
        Me.tenYears.Name = "tenYears"
        Me.tenYears.Size = New System.Drawing.Size(88, 24)
        Me.tenYears.TabIndex = 1
        Me.tenYears.Text = "10 years"
        Me.tenYears.UseVisualStyleBackColor = True
        '
        'fiveYears
        '
        Me.fiveYears.AutoSize = True
        Me.fiveYears.Location = New System.Drawing.Point(16, 24)
        Me.fiveYears.Name = "fiveYears"
        Me.fiveYears.Size = New System.Drawing.Size(79, 24)
        Me.fiveYears.TabIndex = 0
        Me.fiveYears.Text = "5 years"
        Me.fiveYears.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(272, 236)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(200, 42)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Calculate Payments"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtPayment
        '
        Me.txtPayment.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtPayment.Location = New System.Drawing.Point(274, 88)
        Me.txtPayment.Multiline = True
        Me.txtPayment.Name = "txtPayment"
        Me.txtPayment.Size = New System.Drawing.Size(197, 131)
        Me.txtPayment.TabIndex = 7
        Me.txtPayment.Text = "Terms    Payment"
        '
        'MortgageCalculatorFRM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 304)
        Me.Controls.Add(Me.txtPayment)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.monthlyPmtsLBL)
        Me.Controls.Add(Me.titleLBL)
        Me.Controls.Add(Me.loanDataGBX)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "MortgageCalculatorFRM"
        Me.Text = "Mortgage App"
        Me.loanDataGBX.ResumeLayout(False)
        Me.loanDataGBX.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents loanDataGBX As GroupBox
    Friend WithEvents interestRateLBL As Label
    Friend WithEvents mortgageAountLBL As Label
    Friend WithEvents titleLBL As Label
    Friend WithEvents interestTBX As TextBox
    Friend WithEvents amountTBX As TextBox
    Friend WithEvents monthlyPmtsLBL As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents fiveZeroYears As CheckBox
    Friend WithEvents twoFiveYears As CheckBox
    Friend WithEvents tenYears As CheckBox
    Friend WithEvents fiveYears As CheckBox
    Friend WithEvents Button1 As Button
    Friend WithEvents txtPayment As TextBox
End Class
