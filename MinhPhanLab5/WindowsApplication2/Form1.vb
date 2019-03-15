Public Class Form1


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim departTime As Date = departTimeDTP.Value
        Dim departDay As Date = departDayDTP.Value
        Dim arrivalTime As Date = arrivalTimeDTP.Value
        Dim arrivalDay As Date = arrivalDayDTP.Value
        Dim diffDay As TimeSpan = arrivalDay - departDay
        Dim diffHour As TimeSpan = arrivalTime - departTime
        Dim days As Integer
        Dim hours As Integer
        Dim minutes As Integer

        If (flightNumberTxt.Text = "") Then
            flLBL.Text = "N/A"
        Else
            flLBL.Text = Val(flightNumberTxt.Text)
        End If

        If (flightNumberTxt.Text = "") Then
            MessageBox.Show("Please enter the flight number", "Missing data", MessageBoxButtons.OK)

        ElseIf (departDayDTP.Value < System.DateTime.Today) Then
            MessageBox.Show("Departure must be in future", "Invalid departure Date/Time", MessageBoxButtons.OK)
        Else
            days = diffDay.TotalDays

            hours = diffHour.TotalHours
            minutes = diffHour.Minutes

            dayLBL.Text = days
            hoursLBL.Text = hours

            durationLBL.Text = hours & " hours " & minutes & " minutes "
        End If

    End Sub

    Private Sub flightNumberTxt_TextChanged(sender As Object, e As EventArgs) Handles flightNumberTxt.TextChanged
        If (flightNumberTxt.Text = "") Then
            Me.timeToFlightGb.Text = "Time to flight " & "-N/A-"
        Else
            Me.timeToFlightGb.Text = "Time to flight " & flightNumberTxt.Text
        End If
        dayLBL.Text = ""
        hoursLBL.Text = ""
        durationLBL.Text = ""
    End Sub

    Private Sub timeToFlightGb_Enter(sender As Object, e As EventArgs) Handles timeToFlightGb.Enter
        timeToFlightGb.Text = flightNumberTxt.Text
    End Sub
End Class
