<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BudgetApp
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
        Me.expensesGBX = New System.Windows.Forms.GroupBox()
        Me.loanTBX = New System.Windows.Forms.TextBox()
        Me.billsTBX = New System.Windows.Forms.TextBox()
        Me.rentTBX = New System.Windows.Forms.TextBox()
        Me.loanLBL = New System.Windows.Forms.Label()
        Me.billsLBL = New System.Windows.Forms.Label()
        Me.rentLBL = New System.Windows.Forms.Label()
        Me.incomeGBX = New System.Windows.Forms.GroupBox()
        Me.tipsTBX = New System.Windows.Forms.TextBox()
        Me.payTBX = New System.Windows.Forms.TextBox()
        Me.tipsLBL = New System.Windows.Forms.Label()
        Me.payLBL = New System.Windows.Forms.Label()
        Me.calculateBTN = New System.Windows.Forms.Button()
        Me.differenceLBL = New System.Windows.Forms.Label()
        Me.outputLBL = New System.Windows.Forms.Label()
        Me.expensesGBX.SuspendLayout()
        Me.incomeGBX.SuspendLayout()
        Me.SuspendLayout()
        '
        'expensesGBX
        '
        Me.expensesGBX.Controls.Add(Me.loanTBX)
        Me.expensesGBX.Controls.Add(Me.billsTBX)
        Me.expensesGBX.Controls.Add(Me.rentTBX)
        Me.expensesGBX.Controls.Add(Me.loanLBL)
        Me.expensesGBX.Controls.Add(Me.billsLBL)
        Me.expensesGBX.Controls.Add(Me.rentLBL)
        Me.expensesGBX.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.expensesGBX.Location = New System.Drawing.Point(12, 12)
        Me.expensesGBX.Name = "expensesGBX"
        Me.expensesGBX.Size = New System.Drawing.Size(303, 220)
        Me.expensesGBX.TabIndex = 3
        Me.expensesGBX.TabStop = False
        Me.expensesGBX.Text = "Expenses"
        '
        'loanTBX
        '
        Me.loanTBX.Location = New System.Drawing.Point(151, 157)
        Me.loanTBX.Name = "loanTBX"
        Me.loanTBX.Size = New System.Drawing.Size(100, 23)
        Me.loanTBX.TabIndex = 5
        Me.loanTBX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'billsTBX
        '
        Me.billsTBX.Location = New System.Drawing.Point(151, 101)
        Me.billsTBX.Name = "billsTBX"
        Me.billsTBX.Size = New System.Drawing.Size(100, 23)
        Me.billsTBX.TabIndex = 4
        Me.billsTBX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'rentTBX
        '
        Me.rentTBX.Location = New System.Drawing.Point(151, 44)
        Me.rentTBX.Name = "rentTBX"
        Me.rentTBX.Size = New System.Drawing.Size(100, 23)
        Me.rentTBX.TabIndex = 3
        Me.rentTBX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'loanLBL
        '
        Me.loanLBL.AutoSize = True
        Me.loanLBL.Location = New System.Drawing.Point(19, 157)
        Me.loanLBL.Name = "loanLBL"
        Me.loanLBL.Size = New System.Drawing.Size(99, 17)
        Me.loanLBL.TabIndex = 2
        Me.loanLBL.Text = "Loan Payment"
        '
        'billsLBL
        '
        Me.billsLBL.AutoSize = True
        Me.billsLBL.Location = New System.Drawing.Point(19, 101)
        Me.billsLBL.Name = "billsLBL"
        Me.billsLBL.Size = New System.Drawing.Size(86, 17)
        Me.billsLBL.TabIndex = 1
        Me.billsLBL.Text = "Monthly Bills"
        '
        'rentLBL
        '
        Me.rentLBL.AutoSize = True
        Me.rentLBL.Location = New System.Drawing.Point(19, 44)
        Me.rentLBL.Name = "rentLBL"
        Me.rentLBL.Size = New System.Drawing.Size(107, 17)
        Me.rentLBL.TabIndex = 0
        Me.rentLBL.Text = "Apartment Rent"
        '
        'incomeGBX
        '
        Me.incomeGBX.Controls.Add(Me.tipsTBX)
        Me.incomeGBX.Controls.Add(Me.payTBX)
        Me.incomeGBX.Controls.Add(Me.tipsLBL)
        Me.incomeGBX.Controls.Add(Me.payLBL)
        Me.incomeGBX.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.incomeGBX.Location = New System.Drawing.Point(12, 255)
        Me.incomeGBX.Name = "incomeGBX"
        Me.incomeGBX.Size = New System.Drawing.Size(303, 152)
        Me.incomeGBX.TabIndex = 6
        Me.incomeGBX.TabStop = False
        Me.incomeGBX.Text = "Income"
        '
        'tipsTBX
        '
        Me.tipsTBX.Location = New System.Drawing.Point(151, 100)
        Me.tipsTBX.Name = "tipsTBX"
        Me.tipsTBX.Size = New System.Drawing.Size(100, 23)
        Me.tipsTBX.TabIndex = 4
        Me.tipsTBX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'payTBX
        '
        Me.payTBX.Location = New System.Drawing.Point(151, 47)
        Me.payTBX.Name = "payTBX"
        Me.payTBX.Size = New System.Drawing.Size(100, 23)
        Me.payTBX.TabIndex = 3
        Me.payTBX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tipsLBL
        '
        Me.tipsLBL.AutoSize = True
        Me.tipsLBL.Location = New System.Drawing.Point(19, 100)
        Me.tipsLBL.Name = "tipsLBL"
        Me.tipsLBL.Size = New System.Drawing.Size(35, 17)
        Me.tipsLBL.TabIndex = 1
        Me.tipsLBL.Text = "Tips"
        '
        'payLBL
        '
        Me.payLBL.AutoSize = True
        Me.payLBL.Location = New System.Drawing.Point(19, 47)
        Me.payLBL.Name = "payLBL"
        Me.payLBL.Size = New System.Drawing.Size(82, 17)
        Me.payLBL.TabIndex = 0
        Me.payLBL.Text = "Pay Checks"
        '
        'calculateBTN
        '
        Me.calculateBTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calculateBTN.Location = New System.Drawing.Point(330, 355)
        Me.calculateBTN.Name = "calculateBTN"
        Me.calculateBTN.Size = New System.Drawing.Size(165, 52)
        Me.calculateBTN.TabIndex = 7
        Me.calculateBTN.Text = "Calculate"
        Me.calculateBTN.UseVisualStyleBackColor = True
        '
        'differenceLBL
        '
        Me.differenceLBL.AutoSize = True
        Me.differenceLBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.differenceLBL.Location = New System.Drawing.Point(349, 255)
        Me.differenceLBL.Name = "differenceLBL"
        Me.differenceLBL.Size = New System.Drawing.Size(135, 17)
        Me.differenceLBL.TabIndex = 8
        Me.differenceLBL.Text = "Income - Expenses: "
        '
        'outputLBL
        '
        Me.outputLBL.BackColor = System.Drawing.SystemColors.ControlDark
        Me.outputLBL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.outputLBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.outputLBL.Location = New System.Drawing.Point(330, 291)
        Me.outputLBL.Name = "outputLBL"
        Me.outputLBL.Size = New System.Drawing.Size(165, 37)
        Me.outputLBL.TabIndex = 9
        Me.outputLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BudgetApp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(518, 442)
        Me.Controls.Add(Me.outputLBL)
        Me.Controls.Add(Me.differenceLBL)
        Me.Controls.Add(Me.calculateBTN)
        Me.Controls.Add(Me.incomeGBX)
        Me.Controls.Add(Me.expensesGBX)
        Me.Name = "BudgetApp"
        Me.Text = "My Personal Budget"
        Me.expensesGBX.ResumeLayout(False)
        Me.expensesGBX.PerformLayout()
        Me.incomeGBX.ResumeLayout(False)
        Me.incomeGBX.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents expensesGBX As GroupBox
    Friend WithEvents loanTBX As TextBox
    Friend WithEvents billsTBX As TextBox
    Friend WithEvents rentTBX As TextBox
    Friend WithEvents loanLBL As Label
    Friend WithEvents billsLBL As Label
    Friend WithEvents rentLBL As Label
    Friend WithEvents incomeGBX As GroupBox
    Friend WithEvents tipsTBX As TextBox
    Friend WithEvents payTBX As TextBox
    Friend WithEvents tipsLBL As Label
    Friend WithEvents payLBL As Label
    Friend WithEvents calculateBTN As Button
    Friend WithEvents differenceLBL As Label
    Friend WithEvents outputLBL As Label
End Class
