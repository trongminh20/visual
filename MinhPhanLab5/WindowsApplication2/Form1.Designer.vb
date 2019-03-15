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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.departTimeDTP = New System.Windows.Forms.DateTimePicker()
        Me.departDayDTP = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.arrivalTimeDTP = New System.Windows.Forms.DateTimePicker()
        Me.arrivalDayDTP = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.timeToFlightGb = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.flLBL = New System.Windows.Forms.Label()
        Me.durationLBL = New System.Windows.Forms.Label()
        Me.hoursLBL = New System.Windows.Forms.Label()
        Me.dayLBL = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.flightNumberTxt = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.timeToFlightGb.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Flight number:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.departTimeDTP)
        Me.GroupBox1.Controls.Add(Me.departDayDTP)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 59)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(252, 121)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Departure information"
        '
        'departTimeDTP
        '
        Me.departTimeDTP.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.departTimeDTP.Location = New System.Drawing.Point(72, 67)
        Me.departTimeDTP.Name = "departTimeDTP"
        Me.departTimeDTP.Size = New System.Drawing.Size(150, 20)
        Me.departTimeDTP.TabIndex = 5
        Me.departTimeDTP.Value = New Date(2019, 2, 21, 11, 30, 0, 0)
        '
        'departDayDTP
        '
        Me.departDayDTP.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.departDayDTP.Location = New System.Drawing.Point(72, 25)
        Me.departDayDTP.Name = "departDayDTP"
        Me.departDayDTP.Size = New System.Drawing.Size(150, 20)
        Me.departDayDTP.TabIndex = 4
        Me.departDayDTP.Value = New Date(2019, 2, 6, 0, 0, 0, 0)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(25, 67)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Time:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Day:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.arrivalTimeDTP)
        Me.GroupBox2.Controls.Add(Me.arrivalDayDTP)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(23, 200)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(251, 138)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Arrival information"
        '
        'arrivalTimeDTP
        '
        Me.arrivalTimeDTP.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.arrivalTimeDTP.Location = New System.Drawing.Point(75, 69)
        Me.arrivalTimeDTP.Name = "arrivalTimeDTP"
        Me.arrivalTimeDTP.Size = New System.Drawing.Size(150, 20)
        Me.arrivalTimeDTP.TabIndex = 7
        Me.arrivalTimeDTP.Value = New Date(2019, 2, 21, 11, 30, 0, 0)
        '
        'arrivalDayDTP
        '
        Me.arrivalDayDTP.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.arrivalDayDTP.Location = New System.Drawing.Point(75, 29)
        Me.arrivalDayDTP.Name = "arrivalDayDTP"
        Me.arrivalDayDTP.Size = New System.Drawing.Size(150, 20)
        Me.arrivalDayDTP.TabIndex = 6
        Me.arrivalDayDTP.Value = New Date(2019, 2, 6, 0, 0, 0, 0)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Time:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Day:"
        '
        'timeToFlightGb
        '
        Me.timeToFlightGb.Controls.Add(Me.Label11)
        Me.timeToFlightGb.Controls.Add(Me.flLBL)
        Me.timeToFlightGb.Controls.Add(Me.durationLBL)
        Me.timeToFlightGb.Controls.Add(Me.hoursLBL)
        Me.timeToFlightGb.Controls.Add(Me.dayLBL)
        Me.timeToFlightGb.Controls.Add(Me.Label10)
        Me.timeToFlightGb.Controls.Add(Me.Label9)
        Me.timeToFlightGb.Controls.Add(Me.Label8)
        Me.timeToFlightGb.Controls.Add(Me.Label7)
        Me.timeToFlightGb.Controls.Add(Me.Label6)
        Me.timeToFlightGb.Location = New System.Drawing.Point(281, 23)
        Me.timeToFlightGb.Name = "timeToFlightGb"
        Me.timeToFlightGb.Size = New System.Drawing.Size(259, 314)
        Me.timeToFlightGb.TabIndex = 3
        Me.timeToFlightGb.TabStop = False
        Me.timeToFlightGb.Text = "Time to flight "



        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(107, 16)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(0, 13)
        Me.Label11.TabIndex = 8
        '
        'flLBL
        '
        Me.flLBL.Location = New System.Drawing.Point(61, 0)
        Me.flLBL.Name = "flLBL"
        Me.flLBL.Size = New System.Drawing.Size(0, 13)
        Me.flLBL.TabIndex = 6
        '
        'durationLBL
        '
        Me.durationLBL.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.durationLBL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.durationLBL.Location = New System.Drawing.Point(32, 206)
        Me.durationLBL.Name = "durationLBL"
        Me.durationLBL.Size = New System.Drawing.Size(209, 60)
        Me.durationLBL.TabIndex = 7
        Me.durationLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'hoursLBL
        '
        Me.hoursLBL.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.hoursLBL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.hoursLBL.ForeColor = System.Drawing.Color.Red
        Me.hoursLBL.Location = New System.Drawing.Point(111, 103)
        Me.hoursLBL.Name = "hoursLBL"
        Me.hoursLBL.Size = New System.Drawing.Size(52, 22)
        Me.hoursLBL.TabIndex = 6
        Me.hoursLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dayLBL
        '
        Me.dayLBL.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.dayLBL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dayLBL.ForeColor = System.Drawing.Color.Red
        Me.dayLBL.Location = New System.Drawing.Point(110, 62)
        Me.dayLBL.Name = "dayLBL"
        Me.dayLBL.Size = New System.Drawing.Size(53, 21)
        Me.dayLBL.TabIndex = 5
        Me.dayLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(77, 64)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(0, 13)
        Me.Label10.TabIndex = 4
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(27, 177)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(76, 13)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Flight duration:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(61, 105)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 13)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Hours:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(61, 64)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(29, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Day:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(27, 36)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Time until departure"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(322, 352)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(185, 30)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Calculate Times"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'flightNumberTxt
        '
        Me.flightNumberTxt.Location = New System.Drawing.Point(100, 20)
        Me.flightNumberTxt.Name = "flightNumberTxt"
        Me.flightNumberTxt.Size = New System.Drawing.Size(147, 20)
        Me.flightNumberTxt.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(570, 390)
        Me.Controls.Add(Me.flightNumberTxt)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.timeToFlightGb)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Flight Information"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.timeToFlightGb.ResumeLayout(False)
        Me.timeToFlightGb.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents timeToFlightGb As GroupBox
    Friend WithEvents departTimeDTP As DateTimePicker
    Friend WithEvents departDayDTP As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents arrivalTimeDTP As DateTimePicker
    Friend WithEvents arrivalDayDTP As DateTimePicker
    Friend WithEvents Button1 As Button
    Friend WithEvents flightNumberTxt As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents durationLBL As Label
    Friend WithEvents hoursLBL As Label
    Friend WithEvents dayLBL As Label
    Friend WithEvents flLBL As Label
    Friend WithEvents Label11 As Label
End Class
