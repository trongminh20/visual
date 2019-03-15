<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DiceAppFRM
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
        Me.numDiceGBX = New System.Windows.Forms.GroupBox()
        Me.threeRBN = New System.Windows.Forms.RadioButton()
        Me.twoRBN = New System.Windows.Forms.RadioButton()
        Me.oneRBN = New System.Windows.Forms.RadioButton()
        Me.die1PBX = New System.Windows.Forms.PictureBox()
        Me.die2PBX = New System.Windows.Forms.PictureBox()
        Me.die3PBX = New System.Windows.Forms.PictureBox()
        Me.diceGBX = New System.Windows.Forms.GroupBox()
        Me.rollBTN = New System.Windows.Forms.Button()
        Me.numDiceGBX.SuspendLayout()
        CType(Me.die1PBX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.die2PBX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.die3PBX, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.diceGBX.SuspendLayout()
        Me.SuspendLayout()
        '
        'numDiceGBX
        '
        Me.numDiceGBX.Controls.Add(Me.threeRBN)
        Me.numDiceGBX.Controls.Add(Me.twoRBN)
        Me.numDiceGBX.Controls.Add(Me.oneRBN)
        Me.numDiceGBX.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numDiceGBX.Location = New System.Drawing.Point(24, 34)
        Me.numDiceGBX.Margin = New System.Windows.Forms.Padding(6)
        Me.numDiceGBX.Name = "numDiceGBX"
        Me.numDiceGBX.Padding = New System.Windows.Forms.Padding(6)
        Me.numDiceGBX.Size = New System.Drawing.Size(166, 238)
        Me.numDiceGBX.TabIndex = 0
        Me.numDiceGBX.TabStop = False
        Me.numDiceGBX.Text = "Number Of Dice"
        '
        'threeRBN
        '
        Me.threeRBN.AutoSize = True
        Me.threeRBN.Location = New System.Drawing.Point(25, 158)
        Me.threeRBN.Name = "threeRBN"
        Me.threeRBN.Size = New System.Drawing.Size(95, 22)
        Me.threeRBN.TabIndex = 2
        Me.threeRBN.TabStop = True
        Me.threeRBN.Text = "Three dice"
        Me.threeRBN.UseVisualStyleBackColor = True
        '
        'twoRBN
        '
        Me.twoRBN.AutoSize = True
        Me.twoRBN.Location = New System.Drawing.Point(25, 98)
        Me.twoRBN.Name = "twoRBN"
        Me.twoRBN.Size = New System.Drawing.Size(86, 22)
        Me.twoRBN.TabIndex = 1
        Me.twoRBN.TabStop = True
        Me.twoRBN.Text = "Two dice"
        Me.twoRBN.UseVisualStyleBackColor = True
        '
        'oneRBN
        '
        Me.oneRBN.AutoSize = True
        Me.oneRBN.Location = New System.Drawing.Point(24, 48)
        Me.oneRBN.Name = "oneRBN"
        Me.oneRBN.Size = New System.Drawing.Size(85, 22)
        Me.oneRBN.TabIndex = 0
        Me.oneRBN.TabStop = True
        Me.oneRBN.Text = "One dice"
        Me.oneRBN.UseVisualStyleBackColor = True
        '
        'die1PBX
        '
        Me.die1PBX.Location = New System.Drawing.Point(24, 40)
        Me.die1PBX.Name = "die1PBX"
        Me.die1PBX.Size = New System.Drawing.Size(100, 100)
        Me.die1PBX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.die1PBX.TabIndex = 1
        Me.die1PBX.TabStop = False
        '
        'die2PBX
        '
        Me.die2PBX.Location = New System.Drawing.Point(152, 80)
        Me.die2PBX.Name = "die2PBX"
        Me.die2PBX.Size = New System.Drawing.Size(100, 100)
        Me.die2PBX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.die2PBX.TabIndex = 2
        Me.die2PBX.TabStop = False
        '
        'die3PBX
        '
        Me.die3PBX.Location = New System.Drawing.Point(280, 120)
        Me.die3PBX.Name = "die3PBX"
        Me.die3PBX.Size = New System.Drawing.Size(100, 100)
        Me.die3PBX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.die3PBX.TabIndex = 3
        Me.die3PBX.TabStop = False
        '
        'diceGBX
        '
        Me.diceGBX.Controls.Add(Me.die2PBX)
        Me.diceGBX.Controls.Add(Me.die3PBX)
        Me.diceGBX.Controls.Add(Me.die1PBX)
        Me.diceGBX.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.diceGBX.Location = New System.Drawing.Point(221, 34)
        Me.diceGBX.Name = "diceGBX"
        Me.diceGBX.Size = New System.Drawing.Size(404, 238)
        Me.diceGBX.TabIndex = 4
        Me.diceGBX.TabStop = False
        Me.diceGBX.Text = "Roll the dice"
        '
        'rollBTN
        '
        Me.rollBTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rollBTN.Location = New System.Drawing.Point(430, 295)
        Me.rollBTN.Name = "rollBTN"
        Me.rollBTN.Size = New System.Drawing.Size(195, 46)
        Me.rollBTN.TabIndex = 5
        Me.rollBTN.Text = "Roll!"
        Me.rollBTN.UseVisualStyleBackColor = True
        '
        'DiceAppFRM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(649, 367)
        Me.Controls.Add(Me.rollBTN)
        Me.Controls.Add(Me.diceGBX)
        Me.Controls.Add(Me.numDiceGBX)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "DiceAppFRM"
        Me.Text = "Dice Roller"
        Me.numDiceGBX.ResumeLayout(False)
        Me.numDiceGBX.PerformLayout()
        CType(Me.die1PBX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.die2PBX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.die3PBX, System.ComponentModel.ISupportInitialize).EndInit()
        Me.diceGBX.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents numDiceGBX As GroupBox
    Friend WithEvents die1PBX As PictureBox
    Friend WithEvents die2PBX As PictureBox
    Friend WithEvents die3PBX As PictureBox
    Friend WithEvents diceGBX As GroupBox
    Friend WithEvents rollBTN As Button
    Friend WithEvents threeRBN As RadioButton
    Friend WithEvents twoRBN As RadioButton
    Friend WithEvents oneRBN As RadioButton
End Class
