Option Strict On
Public Class MortgageCalculatorFRM

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim label As String = "Terms     Payment"
        Dim interest As Double = Val(interestTBX.Text) / 12 / 100
        Dim amount As Double = Val(amountTBX.Text)
        Dim str As String = label + ""

        If fiveYears.Checked = True Then
            str += vbNewLine + "5 years: " + vbTab + CType(Math.Round(Pmt(interest, 5 * 12, -amount), 2), String)
        End If

        If tenYears.Checked = True Then
            str += vbNewLine + "10 years: " + vbTab + CType(Math.Round(Pmt(interest, 10 * 12, -amount), 2), String)
        End If

        If twoFiveYears.Checked = True Then
            str += vbNewLine + "25 years: " + vbTab + CType(Math.Round(Pmt(interest, 25 * 12, -amount), 2), String)
        End If

        If fiveZeroYears.Checked = True Then
            str += vbNewLine + "50 years: " + vbTab + CType(Math.Round(Pmt(interest, 50 * 12, -amount), 2), String)
        End If
        If interestTBX.Text.Equals("") Or amountTBX.Text.Equals("") Then
            MessageBox.Show("Enter an amount and an interest rate", "Invalid Data", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End If
        txtPayment.Text = str
    End Sub


End Class
