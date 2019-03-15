Option Strict On
Public Class DiceAppFRM
    Private Function getMessage(x As Integer, y As Integer) As String
        Dim message As String = ""
        If (y = 2) Then
            Select Case x
                Case 2
                    message &= "You rolled Snake Eyes!"
                Case 3
                    message &= "You rolled Trey!"
                Case 7
                    message &= "You rolled Lucky Seven!"
                Case 11
                    message &= "You rolled Yo Eleven!"
                Case 12
                    message &= "You rolled Box Cars!"
                Case Else
                    message &= "You rolled a total of " & x.ToString
            End Select
        ElseIf (y <> 2) Then
            message &= "You rolled a total of " & x.ToString
        End If
        Return message
    End Function

    Private Function rollDice(numDice As Integer) As Integer
        Dim random As Random = New Random
        Dim dice1 As Integer = random.Next(0, 7)
        Dim dice2 As Integer = random.Next(0, 7)
        Dim dice3 As Integer = random.Next(0, 7)
        Dim total As Integer

        Select Case numDice
            Case 1
                die1PBX.Image = Image.FromFile("Images\die" & dice1.ToString & ".png")

                total = dice1
            Case 2
                die1PBX.Image = Image.FromFile("Images\die" & dice1.ToString & ".png")
                die2PBX.Image = Image.FromFile("Images\die" & dice2.ToString & ".png")

                total = dice1 + dice2
            Case 3
                die1PBX.Image = Image.FromFile("Images\die" & dice1.ToString & ".png")
                die2PBX.Image = Image.FromFile("Images\die" & dice2.ToString & ".png")
                die3PBX.Image = Image.FromFile("Images\die" & dice3.ToString & ".png")

                total = dice1 + dice2 + dice3
        End Select

        Return total
    End Function

    Private Sub ImagesReset()
        die1PBX.Image = Image.FromFile("Images\dieFooBar.png")
        die2PBX.Image = Image.FromFile("Images\dieFooBar.png")
        die3PBX.Image = Image.FromFile("Images\dieFooBar.png")
        diceGBX.Text = "Roll the dice"
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles oneRBN.CheckedChanged
        If (oneRBN.Checked) Then
            die1PBX.Location = New Point(125, 50)
            die1PBX.Size = New Drawing.Size(150, 150)

            die1PBX.Visible = True
            die2PBX.Visible = False
            die3PBX.Visible = False

            ImagesReset()
        End If
    End Sub

    Private Sub twoRBN_CheckedChanged(sender As Object, e As EventArgs) Handles twoRBN.CheckedChanged
        If (twoRBN.Checked) Then
            die1PBX.Location = New Point(80, 40)
            die2PBX.Location = New Point(220, 120)
            die1PBX.Size = New Drawing.Size(100, 100)

            die1PBX.Visible = True
            die2PBX.Visible = True
            die3PBX.Visible = False

            ImagesReset()
        End If
    End Sub

    Private Sub threeRBN_CheckedChanged(sender As Object, e As EventArgs) Handles threeRBN.CheckedChanged
        If (threeRBN.Checked) Then
            die1PBX.Location = New Point(24, 40)
            die1PBX.Size = New Drawing.Size(100, 100)
            die2PBX.Location = New Point(152, 80)
            die3PBX.Location = New Point(280, 120)

            die1PBX.Visible = True
            die2PBX.Visible = True
            die3PBX.Visible = True

            ImagesReset()
        End If
    End Sub
    Private Sub rollBTN_Click(sender As Object, e As EventArgs) Handles rollBTN.Click
        Select Case True
            Case oneRBN.Checked
                rollDice(1)
                diceGBX.Text = getMessage(rollDice(1), 1)
            Case twoRBN.Checked
                rollDice(2)
                diceGBX.Text = getMessage(rollDice(2), 2)
            Case threeRBN.Checked
                rollDice(3)
                diceGBX.Text = getMessage(rollDice(3), 3)
        End Select
    End Sub

End Class
