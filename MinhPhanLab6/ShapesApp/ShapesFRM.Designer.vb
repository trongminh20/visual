<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ShapesFRM
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.widthNUD = New System.Windows.Forms.NumericUpDown()
        Me.heightNUD = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DrawBTN = New System.Windows.Forms.Button()
        Me.randomDrawBTN = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.yValueNUD = New System.Windows.Forms.NumericUpDown()
        Me.xValueLBL = New System.Windows.Forms.Label()
        Me.xValueNUD = New System.Windows.Forms.NumericUpDown()
        Me.resultTBT = New System.Windows.Forms.TextBox()
        CType(Me.widthNUD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.heightNUD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.yValueNUD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xValueNUD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Width:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Height:"
        '
        'widthNUD
        '
        Me.widthNUD.Location = New System.Drawing.Point(77, 25)
        Me.widthNUD.Maximum = New Decimal(New Integer() {15, 0, 0, 0})
        Me.widthNUD.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.widthNUD.Name = "widthNUD"
        Me.widthNUD.Size = New System.Drawing.Size(44, 24)
        Me.widthNUD.TabIndex = 3
        Me.widthNUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.widthNUD.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'heightNUD
        '
        Me.heightNUD.Location = New System.Drawing.Point(77, 62)
        Me.heightNUD.Maximum = New Decimal(New Integer() {18, 0, 0, 0})
        Me.heightNUD.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.heightNUD.Name = "heightNUD"
        Me.heightNUD.Size = New System.Drawing.Size(44, 24)
        Me.heightNUD.TabIndex = 4
        Me.heightNUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.heightNUD.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.heightNUD)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.widthNUD)
        Me.GroupBox1.Location = New System.Drawing.Point(372, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(134, 108)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Dimensions"
        '
        'DrawBTN
        '
        Me.DrawBTN.Location = New System.Drawing.Point(372, 273)
        Me.DrawBTN.Name = "DrawBTN"
        Me.DrawBTN.Size = New System.Drawing.Size(134, 31)
        Me.DrawBTN.TabIndex = 7
        Me.DrawBTN.Text = "Draw!"
        Me.DrawBTN.UseVisualStyleBackColor = True
        '
        'randomDrawBTN
        '
        Me.randomDrawBTN.Location = New System.Drawing.Point(372, 317)
        Me.randomDrawBTN.Name = "randomDrawBTN"
        Me.randomDrawBTN.Size = New System.Drawing.Size(134, 31)
        Me.randomDrawBTN.TabIndex = 8
        Me.randomDrawBTN.Text = "Random Draw!"
        Me.randomDrawBTN.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.yValueNUD)
        Me.GroupBox2.Controls.Add(Me.xValueLBL)
        Me.GroupBox2.Controls.Add(Me.xValueNUD)
        Me.GroupBox2.Location = New System.Drawing.Point(372, 132)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(134, 108)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Location(X,Y)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Y-Value:"
        '
        'yValueNUD
        '
        Me.yValueNUD.Location = New System.Drawing.Point(77, 62)
        Me.yValueNUD.Maximum = New Decimal(New Integer() {18, 0, 0, 0})
        Me.yValueNUD.Name = "yValueNUD"
        Me.yValueNUD.ReadOnly = True
        Me.yValueNUD.Size = New System.Drawing.Size(44, 24)
        Me.yValueNUD.TabIndex = 4
        Me.yValueNUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'xValueLBL
        '
        Me.xValueLBL.AutoSize = True
        Me.xValueLBL.Location = New System.Drawing.Point(12, 28)
        Me.xValueLBL.Name = "xValueLBL"
        Me.xValueLBL.Size = New System.Drawing.Size(63, 18)
        Me.xValueLBL.TabIndex = 1
        Me.xValueLBL.Text = "X-Value:"
        '
        'xValueNUD
        '
        Me.xValueNUD.Location = New System.Drawing.Point(77, 25)
        Me.xValueNUD.Maximum = New Decimal(New Integer() {15, 0, 0, 0})
        Me.xValueNUD.Name = "xValueNUD"
        Me.xValueNUD.ReadOnly = True
        Me.xValueNUD.Size = New System.Drawing.Size(44, 24)
        Me.xValueNUD.TabIndex = 3
        Me.xValueNUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'resultTBT
        '
        Me.resultTBT.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.resultTBT.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.resultTBT.Location = New System.Drawing.Point(12, 12)
        Me.resultTBT.Multiline = True
        Me.resultTBT.Name = "resultTBT"
        Me.resultTBT.ReadOnly = True
        Me.resultTBT.Size = New System.Drawing.Size(354, 335)
        Me.resultTBT.TabIndex = 10
        '
        'ShapesFRM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(518, 357)
        Me.Controls.Add(Me.resultTBT)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.randomDrawBTN)
        Me.Controls.Add(Me.DrawBTN)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ShapesFRM"
        Me.Text = "  "
        CType(Me.widthNUD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.heightNUD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.yValueNUD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xValueNUD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents widthNUD As NumericUpDown
    Friend WithEvents heightNUD As NumericUpDown
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DrawBTN As Button
    Friend WithEvents randomDrawBTN As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents yValueNUD As NumericUpDown
    Friend WithEvents xValueLBL As Label
    Friend WithEvents xValueNUD As NumericUpDown
    Friend WithEvents resultTBT As TextBox
End Class
