Public Class Form1
    Private Sub btnEncrypt_Click(sender As Object, e As EventArgs) Handles btnEncrypt.Click
        lbDigit1.Text = (Val(txtBox2.Text) + 7) Mod 10
        lbDigit2.Text = (Val(txtBox3.Text) + 7) Mod 10
        lbDigit3.Text = (Val(txtBox4.Text) + 7) Mod 10
        lbDigit4.Text = (Val(txtBox1.Text) + 7) Mod 10
    End Sub

    Private Sub btnDecrypt_Click(sender As Object, e As EventArgs) Handles btnDecrypt.Click
        lbDigit1.Text = (Val(txtBox4.Text) + 3) Mod 10
        lbDigit2.Text = (Val(txtBox1.Text) + 3) Mod 10
        lbDigit3.Text = (Val(txtBox2.Text) + 3) Mod 10
        lbDigit4.Text = (Val(txtBox3.Text) + 3) Mod 10
    End Sub

    Private Sub txtBox1_TextChanged(sender As Object, e As EventArgs) Handles txtBox1.TextChanged
        lbDigit1.Text = ""
        lbDigit2.Text = ""
        lbDigit3.Text = ""
        lbDigit4.Text = ""
    End Sub

    Private Sub txtBox2_TextChanged(sender As Object, e As EventArgs) Handles txtBox2.TextChanged
        lbDigit1.Text = ""
        lbDigit2.Text = ""
        lbDigit3.Text = ""
        lbDigit4.Text = ""
    End Sub

    Private Sub txtBox3_TextChanged(sender As Object, e As EventArgs) Handles txtBox3.TextChanged
        lbDigit1.Text = ""
        lbDigit2.Text = ""
        lbDigit3.Text = ""
        lbDigit4.Text = ""
    End Sub

    Private Sub txtBox4_TextChanged(sender As Object, e As EventArgs) Handles txtBox4.TextChanged
        lbDigit1.Text = ""
        lbDigit2.Text = ""
        lbDigit3.Text = ""
        lbDigit4.Text = ""
    End Sub
End Class
