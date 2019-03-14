Option Strict On
Public Class ShapesFRM
    Dim x As Integer
    Dim y As Integer
    Dim w As Integer
    Dim h As Integer

    Private Sub draw(x As Integer, y As Integer, w As Integer, h As Integer)
        For paddingTop As Integer = 1 To y
            resultTBT.Text &= vbNewLine
        Next

        For i As Integer = 1 To h
            resultTBT.Text &= Space(x)
            For j As Integer = 1 To w
                resultTBT.Text &= "X "
            Next
            resultTBT.Text &= vbNewLine
        Next

    End Sub

    Private Sub DrawBTN_Click(sender As Object, e As EventArgs) Handles DrawBTN.Click
        x = CInt(xValueNUD.Value)
        y = CInt(yValueNUD.Value)
        w = CInt(widthNUD.Value)
        h = CInt(heightNUD.Value)

        resultTBT.Text = ""

        If (x + w < 25 And h + y <= 18) And (w > 1 And h > 1) Then
            draw(x, y, w, h)
        Else
            MessageBox.Show("- Width and Height should be greater than 1" & vbNewLine & "- X-Value + width less or equal than 25" & vbNewLine & "- Y-Value + height less or equal than 18 ", "Invalid data", MessageBoxButtons.OK)
        End If

    End Sub

    Private Sub randomDrawBTN_Click(sender As Object, e As EventArgs) Handles randomDrawBTN.Click

        Dim random As Random = New Random
        x = random.Next(4) + 1
        y = random.Next(7) + 1
        w = random.Next(9) + 1
        h = random.Next(9) + 1

        xValueNUD.Value = x
        yValueNUD.Value = y
        widthNUD.Value = w
        heightNUD.Value = h

        resultTBT.Text = ""
        draw(x, y, w, h)

    End Sub

End Class
